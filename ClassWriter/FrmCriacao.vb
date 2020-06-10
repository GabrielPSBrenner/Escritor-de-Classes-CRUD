Imports System.IO
Imports System.IO.File

Public Class FrmCriacao
   Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

   Public Sub New()
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

   End Sub

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   Friend WithEvents LblDisplay As System.Windows.Forms.Label
   Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
   Friend WithEvents CmdFechar As System.Windows.Forms.Button
   Friend WithEvents CmdVoltar As System.Windows.Forms.Button
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCriacao))
      Me.LblDisplay = New System.Windows.Forms.Label
      Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
      Me.CmdFechar = New System.Windows.Forms.Button
      Me.CmdVoltar = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'LblDisplay
      '
      Me.LblDisplay.Location = New System.Drawing.Point(8, 20)
      Me.LblDisplay.Name = "LblDisplay"
      Me.LblDisplay.Size = New System.Drawing.Size(436, 16)
      Me.LblDisplay.TabIndex = 0
      '
      'ProgressBar1
      '
      Me.ProgressBar1.Location = New System.Drawing.Point(4, 40)
      Me.ProgressBar1.Name = "ProgressBar1"
      Me.ProgressBar1.Size = New System.Drawing.Size(440, 16)
      Me.ProgressBar1.TabIndex = 1
      '
      'CmdFechar
      '
      Me.CmdFechar.Enabled = False
      Me.CmdFechar.Location = New System.Drawing.Point(244, 64)
      Me.CmdFechar.Name = "CmdFechar"
      Me.CmdFechar.Size = New System.Drawing.Size(100, 28)
      Me.CmdFechar.TabIndex = 6
      Me.CmdFechar.Text = "Fechar"
      '
      'CmdVoltar
      '
      Me.CmdVoltar.Enabled = False
      Me.CmdVoltar.Location = New System.Drawing.Point(348, 64)
      Me.CmdVoltar.Name = "CmdVoltar"
      Me.CmdVoltar.Size = New System.Drawing.Size(100, 28)
      Me.CmdVoltar.TabIndex = 5
      Me.CmdVoltar.Text = "Voltar no Início"
      '
      'FrmCriacao
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(452, 98)
      Me.Controls.Add(Me.CmdFechar)
      Me.Controls.Add(Me.CmdVoltar)
      Me.Controls.Add(Me.ProgressBar1)
      Me.Controls.Add(Me.LblDisplay)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "FrmCriacao"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Concluíndo operação"
      Me.ResumeLayout(False)

   End Sub

#End Region

   Public FrmPonteiroPasso3 As FrmPasso3

   Public lArquivosClasses As Boolean    'identificador se serão criados os arquivos .VB das classes
   Public Super As Boolean               'identificador se será criado a classe super
   Public CRUDMODEL As Boolean           'identificador se será criado a classe CRUDMODEL
   Public lXML As Boolean                'identificador se será criado o arquivo XML
   Public Controladora As Boolean        'identificador se será criado a controladora padrão

   Public Diretorio As String
   Public NomeArquivoXML As String
   Public Prefixo As String

   Public Items As ArrayList

   Private PrimeiraVez As Boolean = True

   Private Sub CmdFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFechar.Click
      FrmPonteiroPasso3.Close()
      FrmPonteiroPasso3.Dispose()
      Me.Close()
   End Sub

   Private Sub FrmCriacao_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      If PrimeiraVez Then
         PrimeiraVez = False
         CriaArquivosClassesVBNET()
         CRIAXML()
         MsgBox("Operação concluída com sucesso! ", MsgBoxStyle.Information, "Operação concluída")
         CmdFechar.Enabled = True
         CmdVoltar.Enabled = True
      End If
   End Sub

   Private Sub CRIAXML()
      Dim NomeArquivo As String
      Dim strm As StreamWriter
      Dim NomeTabela As String
      Dim i, x As Integer
      Dim Tabela As LERESTRUTURA.TABLE.stTable
      Dim Estrutura As New LERESTRUTURA.TABLE

      NomeArquivo = Diretorio & NomeArquivoXML & ".xml"

      strm = New StreamWriter(NomeArquivo)
      strm.WriteLine("<?xml version=""1.0"" encoding=""ISO-8859-1""?>")
      strm.WriteLine("<Objects>")
      strm.WriteLine("  <Connection>")
      If TipoConexao = [Global].EnumTipoConexao.SQLSERVER Then
         strm.WriteLine("    <ServerType>SQLSERVER</ServerType>")
      End If
      strm.WriteLine("    <ConnectionString>Server=" & Server & ";DataBase=" & DataBase & ";UID=" & UID & ";PWD=" & PWD & "</ConnectionString>")
      strm.WriteLine("  </Connection>")

      ProgressBar1.Maximum = Items.Count

      For i = 0 To Items.Count - 1

         LblDisplay.Text = "Criando XML (item " & i & " de " & Items.Count & ")"
         ProgressBar1.Value = i + 1
         Me.Refresh()

         NomeTabela = Items(i).ToString
         NomeTabela = NomeTabela.Substring(NomeTabela.IndexOf(".") + 1)

         If TipoConexao = [Global].EnumTipoConexao.SQLSERVER Then
            Tabela = Estrutura.Table(DirectCast(Cn, SqlClient.SqlConnection), NomeTabela)
         Else
            Tabela = Estrutura.Table(DirectCast(Cn, OleDb.OleDbConnection), NomeTabela)
         End If
         Dim Tablename As String = Prefixo & NomeTabela
         Tablename = Tablename.Replace(" ", "_")
         strm.WriteLine("  <" & Tablename & " Table=""" & NomeTabela & """ PrefixTableName="""" Legenda="""">")
         strm.WriteLine("   <Fields>")
         For x = 0 To Tabela.TotalCampos - 1
            Dim strField As String
            strField = "      <" & Tabela.Campos(x).Nome.Replace(" ", "_") & " "
            If Tabela.Campos(x).Chave = True Then
               strField += " Id=""PK""" & " "
            Else
               strField += " Id=""""" & " "
            End If
            Select Case Tabela.Campos(x).Tipo
               Case LERESTRUTURA.TABLE.EnumTipo.eBin
                  strField += "Type=""Bin"""
               Case LERESTRUTURA.TABLE.EnumTipo.eBool
                  strField += "Type=""Bool"""
               Case LERESTRUTURA.TABLE.EnumTipo.eDate
                  strField += "Type=""Date"""
               Case LERESTRUTURA.TABLE.EnumTipo.eDateTime
                  strField += "Type=""DateTime"""
               Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                  strField += "Type=""Float"""
               Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                  strField += "Type=""Integer"""
               Case LERESTRUTURA.TABLE.EnumTipo.eText
                  strField += "Type=""Text"""
               Case LERESTRUTURA.TABLE.EnumTipo.eTime
                  strField += "Type=""Time"""
            End Select
            strField += ">" & Tabela.Campos(x).Nome & "</" & Tabela.Campos(x).Nome.Replace(" ", "_") & ">"
            strm.WriteLine(strField)
         Next
         strm.WriteLine("   </Fields>")
         strm.WriteLine("  </" & Tablename & ">")
      Next
      strm.WriteLine("</Objects>")
      strm.Close()
      LblDisplay.Text = ""
      ProgressBar1.Value = 0
   End Sub

   Private Sub CriaArquivosClassesVBNET()
      Dim NomeArquivo As String
      Dim NomeArquivoCompleto As String
      Dim Tipo As String
      Dim NomeTabela As String

      Dim Tabela As LERESTRUTURA.TABLE.stTable
      Dim Estrutura As New LERESTRUTURA.TABLE

      Dim i As Integer, x As Integer

      ProgressBar1.Maximum = Items.Count - 1

      If CRUDMODEL Then
         Dim s As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("ClassWriter.super.txt")
         Dim sr As New System.IO.StreamReader(s, System.Text.Encoding.ASCII)
         Dim str As String = sr.ReadToEnd()
         Dim strm As New StreamWriter(Diretorio & "SUPER.vb")
         strm.Write(str)
         strm.Close()

         s = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("ClassWriter.crudmodel.txt")
         sr = New System.IO.StreamReader(s, System.Text.Encoding.ASCII)
         str = sr.ReadToEnd()
         strm = New StreamWriter(Diretorio & "CRUDMODEL.vb")
         strm.Write(str)
         strm.Close()
      End If

      For i = 0 To Items.Count - 1

         ProgressBar1.Value = i
         LblDisplay.Text = "Criando classes (" & i + 1 & " de " & Items.Count & ")"
         Me.Refresh()

         NomeArquivo = Items(i).ToString
         Tipo = NomeArquivo.Substring(0, NomeArquivo.IndexOf("."))
         NomeTabela = NomeArquivo.Substring(NomeArquivo.IndexOf(".") + 1)
         NomeArquivo = Prefixo & NomeArquivo.Substring(NomeArquivo.IndexOf(".") + 1)
         NomeArquivoCompleto = Diretorio & NomeArquivo.Replace(" ", "_") & ".vb"

         If TipoConexao = EnumTipoConexao.SQLSERVER Then
            Tabela = Estrutura.Table(DirectCast(Cn, SqlClient.SqlConnection), NomeTabela)
         Else
            Tabela = Estrutura.Table(DirectCast(Cn, OleDb.OleDbConnection), NomeTabela)
         End If

         If Tabela.TotalCampos > 0 Then

            Dim strm As New StreamWriter(NomeArquivoCompleto)
            strm.WriteLine("Public Class " & NomeArquivo.Replace(" ", "_"))
            If CRUDMODEL Then
               strm.WriteLine("   inherits CRUDMODEL ")
            End If


            strm.WriteLine("")

            strm.WriteLine("   Public Sub New()")
            strm.WriteLine("      MyBase.New()")
            strm.WriteLine("   End Sub")

            strm.WriteLine("")
            strm.WriteLine("#Region ""Propriedades Internas da Classe""")
            strm.WriteLine("")
            'strm.WriteLine("'*************************************************************************************'")
            'strm.WriteLine("'PROPRIEDADES INTERNAS DA CLASSE'")
            'strm.WriteLine("'*************************************************************************************'")
            For x = 0 To Tabela.TotalCampos - 1
               Select Case Tabela.Campos(x).Tipo
                  Case LERESTRUTURA.TABLE.EnumTipo.eBin
                     strm.WriteLine("   Protected Friend obj" & Tabela.Campos(x).Nome.Replace(" ", "_") & " as Object")
                  Case LERESTRUTURA.TABLE.EnumTipo.eBool
                     strm.WriteLine("   Protected Friend bol" & Tabela.Campos(x).Nome.Replace(" ", "_") & " as Boolean")
                  Case LERESTRUTURA.TABLE.EnumTipo.eDate
                     strm.WriteLine("   Protected Friend dat" & Tabela.Campos(x).Nome.Replace(" ", "_") & " as Date")
                  Case LERESTRUTURA.TABLE.EnumTipo.eDateTime
                     strm.WriteLine("   Protected Friend dat" & Tabela.Campos(x).Nome.Replace(" ", "_") & " as Date")
                  Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                     strm.WriteLine("   Protected Friend dec" & Tabela.Campos(x).Nome.Replace(" ", "_") & " as Decimal")
                  Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                     strm.WriteLine("   Protected Friend int" & Tabela.Campos(x).Nome.Replace(" ", "_") & " as Integer")
                  Case LERESTRUTURA.TABLE.EnumTipo.eTime
                     strm.WriteLine("   Protected Friend dat" & Tabela.Campos(x).Nome.Replace(" ", "_") & " as Date")
                  Case LERESTRUTURA.TABLE.EnumTipo.eText
                     strm.WriteLine("   Protected Friend str" & Tabela.Campos(x).Nome.Replace(" ", "_") & " as String = """" ")
               End Select
            Next
            'strm.WriteLine("'*************************************************************************************'")
            'strm.WriteLine("'FIM DAS PROPRIEDADES INTERNAS DA CLASSE'")
            'strm.WriteLine("'*************************************************************************************'")
            strm.WriteLine("")
            strm.WriteLine("#End Region")
            strm.WriteLine("")

            strm.WriteLine("")
            strm.WriteLine("#Region ""PROPRIEDADES PUBLICAS DA CLASSE""")

            'strm.WriteLine("'*************************************************************************************'")
            'strm.WriteLine("'PROPRIEDADES PUBLICAS DA CLASSE'")
            'strm.WriteLine("'*************************************************************************************'")

            For x = 0 To Tabela.TotalCampos - 1
               strm.WriteLine("")
               Select Case Tabela.Campos(x).Tipo
                  Case LERESTRUTURA.TABLE.EnumTipo.eBin
                     strm.WriteLine("   Public Property " & Tabela.Campos(x).Nome.Replace(" ", "_") & " As Object")
                     strm.WriteLine("      Get")
                     strm.WriteLine("         Return obj" & Tabela.Campos(x).Nome.Replace(" ", "_"))
                     strm.WriteLine("      End Get")
                     strm.WriteLine("      Set(ByVal Value As Object)")
                     strm.WriteLine("         obj" & Tabela.Campos(x).Nome.Replace(" ", "_") & "=Value")
                     strm.WriteLine("      End Set")
                     strm.WriteLine("   End Property")
                  Case LERESTRUTURA.TABLE.EnumTipo.eBool
                     strm.WriteLine("   Public Property " & Tabela.Campos(x).Nome.Replace(" ", "_") & " As Boolean")
                     strm.WriteLine("      Get")
                     strm.WriteLine("         Return bol" & Tabela.Campos(x).Nome.Replace(" ", "_"))
                     strm.WriteLine("      End Get")
                     strm.WriteLine("      Set(ByVal Value As Boolean)")
                     strm.WriteLine("         bol" & Tabela.Campos(x).Nome.Replace(" ", "_") & "=Value")
                     strm.WriteLine("      End Set")
                     strm.WriteLine("   End Property")
                  Case LERESTRUTURA.TABLE.EnumTipo.eDate, LERESTRUTURA.TABLE.EnumTipo.eDateTime, LERESTRUTURA.TABLE.EnumTipo.eTime
                     strm.WriteLine("   Public Property " & Tabela.Campos(x).Nome.Replace(" ", "_") & " As Date")
                     strm.WriteLine("      Get")
                     strm.WriteLine("         Return dat" & Tabela.Campos(x).Nome.Replace(" ", "_"))
                     strm.WriteLine("      End Get")
                     strm.WriteLine("      Set(ByVal Value As Date)")
                     strm.WriteLine("         dat" & Tabela.Campos(x).Nome.Replace(" ", "_") & "=Value")
                     strm.WriteLine("      End Set")
                     strm.WriteLine("   End Property")
                  Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                     strm.WriteLine("   Public Property " & Tabela.Campos(x).Nome.Replace(" ", "_") & " As Decimal")
                     strm.WriteLine("      Get")
                     strm.WriteLine("         Return dec" & Tabela.Campos(x).Nome.Replace(" ", "_"))
                     strm.WriteLine("      End Get")
                     strm.WriteLine("      Set(ByVal Value As Decimal)")
                     strm.WriteLine("         dec" & Tabela.Campos(x).Nome.Replace(" ", "_") & "=Value")
                     strm.WriteLine("      End Set")
                     strm.WriteLine("   End Property")
                  Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                     strm.WriteLine("   Public Property " & Tabela.Campos(x).Nome.Replace(" ", "_") & " As Integer")
                     strm.WriteLine("      Get")
                     strm.WriteLine("         Return int" & Tabela.Campos(x).Nome.Replace(" ", "_"))
                     strm.WriteLine("      End Get")
                     strm.WriteLine("      Set(ByVal Value As Integer)")
                     strm.WriteLine("         int" & Tabela.Campos(x).Nome.Replace(" ", "_") & "=Value")
                     strm.WriteLine("      End Set")
                     strm.WriteLine("   End Property")
                  Case LERESTRUTURA.TABLE.EnumTipo.eText
                     strm.WriteLine("   Public Property " & Tabela.Campos(x).Nome.Replace(" ", "_") & " As String")
                     strm.WriteLine("      Get")
                     strm.WriteLine("         Return str" & Tabela.Campos(x).Nome.Replace(" ", "_"))
                     strm.WriteLine("      End Get")
                     strm.WriteLine("      Set(ByVal Value As String)")
                     strm.WriteLine("         str" & Tabela.Campos(x).Nome.Replace(" ", "_") & "=Value")
                     strm.WriteLine("      End Set")
                     strm.WriteLine("   End Property")
               End Select
               strm.WriteLine("")
            Next

            strm.WriteLine("#End Region")
            'strm.WriteLine("'*************************************************************************************'")
            'strm.WriteLine("'FIM DAS PROPRIEDADES PÚBLICAS DA CLASSE'")
            'strm.WriteLine("'*************************************************************************************'")
            strm.WriteLine("")

            strm.WriteLine("#Region ""MÉTODOS INTERNOS DA CLASSE""")
            strm.WriteLine("   Public Overridable Sub ClearProperties()")

            For x = 0 To Tabela.TotalCampos - 1
               Select Case Tabela.Campos(x).Tipo
                  Case LERESTRUTURA.TABLE.EnumTipo.eBin
                     strm.WriteLine("      obj" & Tabela.Campos(x).Nome.Replace(" ", "_") & " = Nothing")
                  Case LERESTRUTURA.TABLE.EnumTipo.eBool
                     strm.WriteLine("      bol" & Tabela.Campos(x).Nome.Replace(" ", "_") & " = Nothing")
                  Case LERESTRUTURA.TABLE.EnumTipo.eDate
                     strm.WriteLine("      dat" & Tabela.Campos(x).Nome.Replace(" ", "_") & " = Nothing")
                  Case LERESTRUTURA.TABLE.EnumTipo.eDateTime
                     strm.WriteLine("      dat" & Tabela.Campos(x).Nome.Replace(" ", "_") & " = Nothing")
                  Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                     strm.WriteLine("      dec" & Tabela.Campos(x).Nome.Replace(" ", "_") & " = Nothing")
                  Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                     strm.WriteLine("      int" & Tabela.Campos(x).Nome.Replace(" ", "_") & " = Nothing")
                  Case LERESTRUTURA.TABLE.EnumTipo.eTime
                     strm.WriteLine("      dat" & Tabela.Campos(x).Nome.Replace(" ", "_") & " = Nothing")
                  Case LERESTRUTURA.TABLE.EnumTipo.eText
                     strm.WriteLine("      str" & Tabela.Campos(x).Nome.Replace(" ", "_") & " = """" ")
               End Select
            Next
            strm.WriteLine("   End Sub ")

            If CRUDMODEL Then
               strm.WriteLine("   Public Overrides Sub lPersisteDados_AfterDelete(ByVal Success As Boolean, ByVal Err As System.Exception)")
               strm.WriteLine("      If Success Then")
               strm.WriteLine("         ClearProperties()")
               strm.WriteLine("      End If")
               strm.WriteLine("   End Sub")
            End If
            strm.WriteLine("#End Region")
            strm.WriteLine("End Class")
            strm.Close()
         End If
      Next
      ProgressBar1.Value = 0
      LblDisplay.Text = ""
      
   End Sub

   Private Sub CmdVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVoltar.Click
      Me.Hide()
      FrmPas1 = New FrmPasso1
      FrmPas1.Show()
      Me.Close()
   End Sub

   Private Sub FrmCriacao_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      FrmPonteiroPasso3.Close()
      FrmPonteiroPasso3 = Nothing
      If Me.Visible = True Then
         End
      End If
   End Sub
End Class

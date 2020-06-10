Imports System.IO
Imports System.IO.File

Public Class FrmCriacao
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Linguagem As LinguagemCriacao, ByVal DataContextName As String)
        MyBase.New()
        lLinguagemCriacao = Linguagem
        lDataContextName = DataContextName
        InitializeComponent()
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
    Public Diretorio As String
    Public TipoClasse As ModelType
    Private lDataContextName As String
    Public Prefixo As String
    Public ConnectionString As String
    Public UsaCaminhoPadrao As Boolean = False
    Private _ConnectionString As String
    Public Items As ArrayList
    Private PrimeiraVez As Boolean = True
    Public PreparaLog As Boolean = False
    Public ImportaCONSEG As Boolean = False
    Public NAMESPACEMODEL As String
	Public RecebeMetodo As eRecebeMetodo
	
    Private lLinguagemCriacao As LinguagemCriacao

    Public Enum eRecebeMetodo
        NA = 0
        Matricula = 1
        Perfil = 2
    End Enum


    Public Enum ModelType
        ClassesDAO = 0
        ClassesPartial = 1
    End Enum

    Public Enum LinguagemCriacao
        VBNET = 0
        C = 1
    End Enum


    Private Sub CmdFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFechar.Click
        FrmPonteiroPasso3.Close()
        FrmPonteiroPasso3.Dispose()
        Me.Close()
    End Sub

    Private Sub FrmCriacao_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If PrimeiraVez Then
            PrimeiraVez = False
			'CriaArquivosClasses()
			CriaArquivosClassesTemplate()
            MsgBox("Operação concluída com sucesso! ", MsgBoxStyle.Information, "Operação concluída")
            CmdFechar.Enabled = True
            CmdVoltar.Enabled = True
        End If
	End Sub

	Private Sub CriaArquivosClassesTemplate()
		Dim oConfig As New Configuracao
		With oConfig
			.Namespace = NAMESPACEMODEL
			.CodigoSistema = FrmPonteiroPasso3.cboSistema.SelectedValue
			.NomeSistema = FrmPonteiroPasso3.cboSistema.Text
			.Diretorio = Diretorio
			.ConnectionString = ConnectionString
			.DataContextName = lDataContextName
			.LinguagemCriacao = lLinguagemCriacao
			.Prefixo = Prefixo
			.PreparaLog = PreparaLog
			.UsaCaminhoPadrao = UsaCaminhoPadrao
			If FrmPonteiroPasso3.OptIdMatricula.Checked Then
				.IdentificacaoUsuario = Configuracao.eIdentificacaoUsuario.Matricula
			ElseIf FrmPonteiroPasso3.OptIdPerfil.Checked Then
				.IdentificacaoUsuario = Configuracao.eIdentificacaoUsuario.Perfil
			Else
				.IdentificacaoUsuario = Configuracao.eIdentificacaoUsuario.Nenhum
			End If
			If FrmPonteiroPasso3.OptLogTudo.Checked Then
				.TipoLog = Configuracao.eLog.Tudo
			ElseIf FrmPonteiroPasso3.OptLogInserirAtualizarExcluir.Checked Then
				.TipoLog = Configuracao.eLog.InserirAtualizarExcluir
			Else
				.TipoLog = Configuracao.eLog.Nenhum
			End If
		End With

		oConfig.GerarArquivosHelper()

		Dim NomeArquivo As String
		Dim NomeArquivoCompleto As String
		Dim Tipo As String
		Dim NomeTabela As String

		Dim Tabela As LERESTRUTURA.TABLE.stTable
		Dim Estrutura As New LERESTRUTURA.TABLE

		Dim i As Integer, x As Integer

		ProgressBar1.Maximum = Items.Count - 1


		For i = 0 To Items.Count - 1
			ProgressBar1.Value = i
			LblDisplay.Text = "Criando classes (" & i + 1 & " de " & Items.Count & ")"
			Me.Refresh()

			NomeArquivo = Items(i).ToString
			Tipo = NomeArquivo.Substring(0, NomeArquivo.IndexOf("."))
			NomeTabela = NomeArquivo.Substring(NomeArquivo.IndexOf(".") + 1)
			NomeArquivo = Prefixo & NomeArquivo.Substring(NomeArquivo.IndexOf(".") + 1)


			Estrutura.ConnectionString = _ConnectionString

			If TipoConexao = EnumTipoConexao.SQLSERVER Then
				Tabela = Estrutura.Table(DirectCast(Cn, SqlClient.SqlConnection), NomeTabela)
			Else
				Tabela = Estrutura.Table(DirectCast(Cn, OleDb.OleDbConnection), NomeTabela)
			End If

			If FrmPas2.EhTable(Tabela.Nome) Then
				Tabela.Tipo = LERESTRUTURA.TABLE.eTable.Table
			ElseIf FrmPas2.EhView(Tabela.Nome) Then
				Tabela.Tipo = LERESTRUTURA.TABLE.eTable.View
			End If

			If Tabela.TotalCampos > 0 Then
				oConfig.GerarArquivosModel(Tabela)
				oConfig.GerarArquivosModelMeta(Tabela)

				'If lLinguagemCriacao = LinguagemCriacao.VBNET Then
				'	NomeArquivoCompleto = Diretorio & NomeArquivo.Replace(" ", "_") & ".vb"
				'	ExportaVB_NET(NomeArquivoCompleto, NomeArquivo, Tabela)
				'Else
				'	NomeArquivoCompleto = Diretorio & NomeArquivo.Replace(" ", "_") & ".cs"
				'	ExportaC(NomeArquivoCompleto, NomeArquivo, Tabela)
				'End If
			End If
		Next
		ProgressBar1.Value = 0
		LblDisplay.Text = ""
	End Sub

    Private Sub ExportaVB_NET(NomeArquivoCompleto As String, NomeArquivo As String, Tabela As LERESTRUTURA.TABLE.stTable)
        Dim strm As New StreamWriter(NomeArquivoCompleto)

        NAMESPACEMODEL = NAMESPACEMODEL & "."

        If ImportaCONSEG Then
            strm.WriteLine("Imports INB.CONSEG.BASECLASS")
            strm.WriteLine("Imports INB.CONSEG.REGRASNEGOCIO")

            If PreparaLog Then
                strm.WriteLine("Imports INB.CONSEG.LOG")
            End If
        End If


        If TipoClasse = ModelType.ClassesDAO Then
            strm.WriteLine("Public Class " & NomeArquivo.Replace(" ", "_"))
        ElseIf TipoClasse = ModelType.ClassesPartial Then
            strm.WriteLine("Public Partial Class " & NomeArquivo.Replace(" ", "_"))
        End If

        strm.WriteLine("")

        If TipoClasse = ModelType.ClassesDAO Then
            strm.WriteLine("   Public Sub New()")
            strm.WriteLine("      ")
            strm.WriteLine("   End Sub")
            strm.WriteLine("")
        End If

        strm.WriteLine("#Region ""MÉTODOS INCLUIR, ALTERAR E EXCLUIR""")

        '*** MÉTODO INCLUIR ***
        strm.WriteLine("")
        strm.WriteLine("   Public Shared Sub Incluir(o" & Tabela.Nome & " as " & Tabela.Nome & ", MyDb as " & lDataContextName & ")")
        strm.WriteLine("      MyDb." & Tabela.Nome & "s.InsertOnSubmit(o" & Tabela.Nome & ")")
        strm.WriteLine("   End Sub")
        strm.WriteLine("")
        If RecebeMetodo = eRecebeMetodo.NA Then
            strm.WriteLine("   Public Shared Sub Incluir(o" & Tabela.Nome & " as " & Tabela.Nome & ") ")
        ElseIf RecebeMetodo = eRecebeMetodo.Perfil Then
            strm.WriteLine("   Public Shared Sub Incluir(o" & Tabela.Nome & " as " & Tabela.Nome & ", oPerfil as Perfil) ")
        Else
            strm.WriteLine("   Public Shared Sub Incluir(o" & Tabela.Nome & " as " & Tabela.Nome & ", oMatricula as Integer) ")
        End If
        strm.WriteLine("      Dim db As new " & lDataContextName & "(" & ConnectionString & ")")
        If PreparaLog Then
            strm.WriteLine("      Dim MyStream As New System.IO.MemoryStream")
            strm.WriteLine("      db.Log = New System.IO.StreamWriter(MyStream)")
        End If
        strm.WriteLine("      Incluir(o" & Tabela.Nome & ",db)")
        strm.WriteLine("      db.SubmitChanges()")
        If PreparaLog Then
            If RecebeMetodo = eRecebeMetodo.Perfil Then
                strm.WriteLine("      INB.CONSEG.LOG.LOGLINQ.IncluirSerializaSQLLINQ(3, MyGlobal.CODIGOSISTEMA, oPerfil.Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, o" & Tabela.Nome & ", db, MyStream)")
                strm.WriteLine("      MyStream.Dispose()")
            Else
                strm.WriteLine("      INB.CONSEG.LOG.LOGLINQ.IncluirSerializaSQLLINQ(3, MyGlobal.CODIGOSISTEMA, Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, o" & Tabela.Nome & ", db, MyStream)")
                strm.WriteLine("      MyStream.Dispose()")
            End If
        End If
        strm.WriteLine("      db.Dispose()")
        strm.WriteLine("   End Sub")
        '*** FIM DO MÉTODO INCLUIR ***



        '*** MÉTODO ALTERAR ***
        strm.WriteLine("")
        strm.WriteLine("   Public Shared Sub Alterar(o" & Tabela.Nome & " as " & Tabela.Nome & ", MyDb as " & lDataContextName & ")")
        strm.WriteLine("      MyDb." & Tabela.Nome & "s.Attach(o" & Tabela.Nome & ", True)")
        strm.WriteLine("   End Sub")
        strm.WriteLine("")

        If RecebeMetodo = eRecebeMetodo.NA Then
            strm.WriteLine("   Public Shared Sub Alterar(o" & Tabela.Nome & " as " & Tabela.Nome & ") ")
        ElseIf RecebeMetodo = eRecebeMetodo.Perfil Then
            strm.WriteLine("   Public Shared Sub Alterar(o" & Tabela.Nome & " as " & Tabela.Nome & ", oPerfil as Perfil) ")
        Else
            strm.WriteLine("   Public Shared Sub Alterar(o" & Tabela.Nome & " as " & Tabela.Nome & ", Matricula as Integer) ")
        End If
        strm.WriteLine("      Dim db As new " & lDataContextName & "(" & ConnectionString & ")")
        If PreparaLog Then
            strm.WriteLine("      Dim MyStream As New System.IO.MemoryStream")
            strm.WriteLine("      db.Log = New System.IO.StreamWriter(MyStream)")
        End If
        strm.WriteLine("      Alterar(o" & Tabela.Nome & ",db)")
        strm.WriteLine("      db.SubmitChanges()")
        If PreparaLog Then
            If RecebeMetodo = eRecebeMetodo.Perfil Then
                strm.WriteLine("      INB.CONSEG.LOG.LOGLINQ.IncluirSerializaSQLLINQ(4, MyGlobal.CODIGOSISTEMA, oPerfil.Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, o" & Tabela.Nome & ", db, MyStream)")
                strm.WriteLine("      MyStream.Dispose()")

            Else
                strm.WriteLine("      INB.CONSEG.LOG.LOGLINQ.IncluirSerializaSQLLINQ(4, MyGlobal.CODIGOSISTEMA, Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, o" & Tabela.Nome & ", db, MyStream)")
                strm.WriteLine("      MyStream.Dispose()")
            End If
        End If
        strm.WriteLine("      db.dispose()")
        strm.WriteLine("   End Sub")
        '*** FIM DO MÉTODO ALTERAR ***

        '*** MÉTODO EXCLUIR ***
        strm.WriteLine("")

        strm.Write("   Public Shared Sub Excluir(")
        Dim Primeiro As Boolean = True
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(",")
                End If
                strm.Write("p" & Tabela.Campos(icampos).Nome & " as ")
                Select Case Tabela.Campos(icampos).Tipo
                    Case LERESTRUTURA.TABLE.EnumTipo.eBool
                        strm.Write("Boolean")
                    Case LERESTRUTURA.TABLE.EnumTipo.eDate, LERESTRUTURA.TABLE.EnumTipo.eDateTime, LERESTRUTURA.TABLE.EnumTipo.eTime
                        strm.Write("Date")
                    Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                        strm.Write("Double")
                    Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                        strm.Write("Integer")
                    Case LERESTRUTURA.TABLE.EnumTipo.eText
                        strm.Write("String")
                End Select
            End If
        Next
        strm.Write(", MyDB as " & lDataContextName & ") ")


        strm.WriteLine("")
        strm.WriteLine("      Dim o" & Tabela.Nome & " As " & Tabela.Nome)
        strm.Write("      Dim res = From p In MyDB." & Tabela.Nome & "s Where ")
        Primeiro = True
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(" and ")
                End If
                strm.Write("p." & Tabela.Campos(icampos).Nome & "=" & "p" & Tabela.Campos(icampos).Nome)
            End If
        Next
        strm.WriteLine("")
        strm.WriteLine("      If res.Count > 0 Then")
        strm.WriteLine("         o" & Tabela.Nome & "= res.First")
        strm.WriteLine("         MyDB." & Tabela.Nome & "s.DeleteOnSubmit(o" & Tabela.Nome & ")")
        strm.WriteLine("      Else")
        strm.WriteLine("         Throw New Exception(""Não foi possível excluir o ítem, porque o mesmo não existe na base de dados."")")
        strm.WriteLine("      End If")
        strm.WriteLine("   End Sub")
        strm.WriteLine("")

        strm.WriteLine("")
        strm.Write("   Public Shared Sub Excluir(")
        Primeiro = True
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(",")
                End If
                strm.Write("p" & Tabela.Campos(icampos).Nome & " as ")
                Select Case Tabela.Campos(icampos).Tipo
                    Case LERESTRUTURA.TABLE.EnumTipo.eBool
                        strm.Write("Boolean")
                    Case LERESTRUTURA.TABLE.EnumTipo.eDate, LERESTRUTURA.TABLE.EnumTipo.eDateTime, LERESTRUTURA.TABLE.EnumTipo.eTime
                        strm.Write("Date")
                    Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                        strm.Write("Double")
                    Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                        strm.Write("Integer")
                    Case LERESTRUTURA.TABLE.EnumTipo.eText
                        strm.Write("String")
                End Select
            End If
        Next
        If RecebeMetodo = eRecebeMetodo.NA Then
            strm.Write(")")
        ElseIf RecebeMetodo = eRecebeMetodo.Perfil Then
            strm.Write(", oPerfil as Perfil)")
        Else
            strm.Write(", Matricula as Integer)")
        End If
        strm.WriteLine("")
        strm.WriteLine("      Dim db As new " & lDataContextName & "(" & ConnectionString & ")")
        If PreparaLog Then
            strm.WriteLine("      Dim MyStream As New System.IO.MemoryStream")
            strm.WriteLine("      db.Log = New System.IO.StreamWriter(MyStream)")
        End If

        strm.WriteLine("      Dim o" & Tabela.Nome & " As " & Tabela.Nome)
        strm.Write("      Dim res = From p In db." & Tabela.Nome & "s Where ")
        Primeiro = True
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(" and ")
                End If
                strm.Write("p." & Tabela.Campos(icampos).Nome & "=" & "p" & Tabela.Campos(icampos).Nome)
            End If
        Next
        strm.WriteLine("")
        strm.WriteLine("      If res.Count > 0 Then")
        strm.WriteLine("         o" & Tabela.Nome & "= res.First")
        strm.WriteLine("         db." & Tabela.Nome & "s.DeleteOnSubmit(o" & Tabela.Nome & ")")
        strm.WriteLine("         db.SubmitChanges()")
        If PreparaLog Then
            If RecebeMetodo = eRecebeMetodo.Matricula Then
                strm.WriteLine("         INB.CONSEG.LOG.LOGLINQ.IncluirSerializaSQLLINQ(5, MyGlobal.CODIGOSISTEMA, Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, o" & Tabela.Nome & ", db, MyStream)")
                strm.WriteLine("         MyStream.Dispose()")
            ElseIf RecebeMetodo = eRecebeMetodo.Perfil Then
                strm.WriteLine("         INB.CONSEG.LOG.LOGLINQ.IncluirSerializaSQLLINQ(5, MyGlobal.CODIGOSISTEMA, oPerfil.Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, o" & Tabela.Nome & ", db, MyStream)")
                strm.WriteLine("         MyStream.Dispose()")
            End If
        End If

        strm.WriteLine("         db.Dispose()")
        strm.WriteLine("      Else")
        strm.WriteLine("         db.Dispose()")
        strm.WriteLine("         Throw New Exception(""Não foi possível excluir o ítem, porque o mesmo não existe na base de dados."")")
        strm.WriteLine("      End If")
        strm.WriteLine("      db.Dispose()")
        strm.WriteLine("   End Sub")
        strm.WriteLine("")




        strm.WriteLine("   Public Shared Sub Excluir(o" & Tabela.Nome & " as " & Tabela.Nome & ", MyDb as " & lDataContextName & ")")
        strm.WriteLine("       MyDb." & Tabela.Nome & "s.Attach(o" & Tabela.Nome & ")")
        strm.WriteLine("       MyDb." & Tabela.Nome & "s.DeleteOnSubmit(o" & Tabela.Nome & ")")
        strm.WriteLine("   End Sub ")
        If RecebeMetodo = eRecebeMetodo.NA Then
            strm.WriteLine("   Public Shared Sub Excluir(o" & Tabela.Nome & " as " & Tabela.Nome & ")")
        ElseIf RecebeMetodo = eRecebeMetodo.Perfil Then
            strm.WriteLine("   Public Shared Sub Excluir(o" & Tabela.Nome & " as " & Tabela.Nome & ", oPerfil as Perfil)")
        Else
            strm.WriteLine("   Public Shared Sub Excluir(o" & Tabela.Nome & " as " & Tabela.Nome & ", oMatricula as Integer)")
        End If
        strm.WriteLine("      Dim db As new " & lDataContextName & "(" & ConnectionString & ")")
        If PreparaLog Then
            strm.WriteLine("      Dim MyStream As New System.IO.MemoryStream")
            strm.WriteLine("      db.Log = New System.IO.StreamWriter(MyStream)")
        End If
        strm.WriteLine("      Excluir(o" & Tabela.Nome & ",db)")
        strm.WriteLine("      db.SubmitChanges()")
        If PreparaLog Then
            If RecebeMetodo = eRecebeMetodo.Matricula Then
                strm.WriteLine("      INB.CONSEG.LOG.LOGLINQ.IncluirSerializaSQLLINQ(5, MyGlobal.CODIGOSISTEMA, Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, o" & Tabela.Nome & ", db, MyStream)")
                strm.WriteLine("      MyStream.Dispose()")
            ElseIf RecebeMetodo = eRecebeMetodo.Perfil Then
                strm.WriteLine("      INB.CONSEG.LOG.LOGLINQ.IncluirSerializaSQLLINQ(5, MyGlobal.CODIGOSISTEMA, oPerfil.Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, o" & Tabela.Nome & ", db, MyStream)")
                strm.WriteLine("      MyStream.Dispose()")
            End If
        End If
        strm.WriteLine("      db.Dispose()")
        strm.WriteLine("   End Sub ")
        strm.WriteLine("#End Region")
        '*** FIM DO MÉTODO EXCLUIR **

        strm.WriteLine("")


        strm.WriteLine("#Region ""MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE""")
        '*** SELECIONA TODOS OS OBJETOS ***
        strm.WriteLine("")
        strm.WriteLine("   Public Shared Function ListarTodos(MyDB as " & lDataContextName & ") As List(Of " & Tabela.Nome & ")")


        strm.WriteLine("      Dim oLista As New List(Of " & Tabela.Nome & ")")
        strm.WriteLine("      Dim res = From p In MyDB." & Tabela.Nome & "s")
        strm.WriteLine("      oLista = res.ToList")
        strm.WriteLine("      Return oLista")
        strm.WriteLine("   End Function")


        If RecebeMetodo = eRecebeMetodo.NA Then
            strm.WriteLine("   Public Shared Function ListarTodos() As List(Of " & Tabela.Nome & ")")
        ElseIf RecebeMetodo = eRecebeMetodo.Perfil Then
            strm.WriteLine("   Public Shared Function ListarTodos(oPerfil as Perfil) As List(Of " & Tabela.Nome & ")")
        Else
            strm.WriteLine("   Public Shared Function ListarTodos(Matricula as Integer) As List(Of " & Tabela.Nome & ")")
        End If
        strm.WriteLine("      Dim db As new " & lDataContextName & "(" & ConnectionString & ")")
        If PreparaLog Then
            strm.WriteLine("      Dim MyStream As New System.IO.MemoryStream")
            strm.WriteLine("      db.Log = New System.IO.StreamWriter(MyStream)")
        End If
        strm.WriteLine("      Dim oLista = ListarTodos(db)")

        If PreparaLog Then
            strm.WriteLine("      INB.CONSEG.LOG.LOGLINQ.IncluirSQLLINQ(6, MyGlobal.CODIGOSISTEMA, oPerfil.Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, """ & NAMESPACEMODEL & "." & Tabela.Nome & """, db, MyStream)")
            strm.WriteLine("      MyStream.Dispose()")
        End If

        strm.WriteLine("      db.Dispose()")
        strm.WriteLine("      Return oLista")
        strm.WriteLine("   End Function")
        strm.WriteLine("")
        '*** FIM DO SELECIONA TODOS OS OBJETOS ***

        '*** SELECIONA O OBJETO PELA CHAVE ***
        strm.WriteLine("")
        strm.Write("   Public Shared Function SelecionaPK(")
        Primeiro = True
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(",")
                End If
                strm.Write("p" & Tabela.Campos(icampos).Nome & " as ")
                Select Case Tabela.Campos(icampos).Tipo
                    Case LERESTRUTURA.TABLE.EnumTipo.eBool
                        strm.Write("Boolean")
                    Case LERESTRUTURA.TABLE.EnumTipo.eDate, LERESTRUTURA.TABLE.EnumTipo.eDateTime, LERESTRUTURA.TABLE.EnumTipo.eTime
                        strm.Write("Date")
                    Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                        strm.Write("Double")
                    Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                        strm.Write("Integer")
                    Case LERESTRUTURA.TABLE.EnumTipo.eText
                        strm.Write("String")
                End Select
            End If
        Next
        If RecebeMetodo = eRecebeMetodo.NA Then
            strm.Write(", Optional MyDB as " & lDataContextName & "=Nothing) as " & Tabela.Nome)
        ElseIf RecebeMetodo = eRecebeMetodo.Perfil Then
            strm.Write(", oPerfil as Perfil, Optional MyDB as " & lDataContextName & "=Nothing) as " & Tabela.Nome)
        Else
            strm.Write(", Matricula as Integer, Optional MyDB as " & lDataContextName & "=Nothing) as " & Tabela.Nome)
        End If

        strm.WriteLine("")
        strm.WriteLine("      Dim db As " & lDataContextName)
        If PreparaLog Then
            strm.Write("      Dim MyStream As New System.IO.MemoryStream")
        End If
        strm.WriteLine("")
        strm.WriteLine("      If Not MyDb Is Nothing Then")
        strm.WriteLine("         db = MyDb")
        strm.WriteLine("      Else")
        strm.WriteLine("         db = New " & lDataContextName & "(" & ConnectionString & ")")
        If PreparaLog Then
            strm.WriteLine("         db.Log = New System.IO.StreamWriter(MyStream)")
        End If
        strm.WriteLine("      End If")
        strm.WriteLine("      Dim o" & Tabela.Nome & " As " & Tabela.Nome)



        strm.Write("      Dim res = (From p In db." & Tabela.Nome & "s Where ")

        Primeiro = True
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(" and ")
                End If
                strm.Write("p." & Tabela.Campos(icampos).Nome & "=" & "p" & Tabela.Campos(icampos).Nome)
            End If
        Next
        strm.Write(").ToList")
        strm.WriteLine("")
        strm.WriteLine("      If res.Count > 0 Then")
        strm.WriteLine("         o" & Tabela.Nome & "= res.First")
        strm.WriteLine("      Else")
        strm.WriteLine("         o" & Tabela.Nome & "= Nothing")
        strm.WriteLine("      End If")
        strm.WriteLine("      If MyDb Is Nothing Then")
        If PreparaLog Then
            strm.WriteLine("         INB.CONSEG.LOG.LOGLINQ.IncluirSQLLINQ(6, MyGlobal.CODIGOSISTEMA, oPerfil.Matricula, MyGlobal.IP, MyGlobal.NomeEstacao, """ & NAMESPACEMODEL & "." & Tabela.Nome & """, db, MyStream)")
            strm.WriteLine("         MyStream.Dispose()")
        End If
        strm.WriteLine("         db.Dispose()")
        strm.WriteLine("      End If")
        strm.WriteLine("      Return o" & Tabela.Nome)
        strm.WriteLine("   End Function")

        strm.WriteLine("")

        '*** FIM DO SELECIONA O OBJETO PELA CHAVE ***

        strm.WriteLine("#End Region")
        strm.WriteLine("End Class")
        strm.Close()
    End Sub

    Private Sub ExportaC(NomeArquivoCompleto As String, NomeArquivo As String, Tabela As LERESTRUTURA.TABLE.stTable)
        Dim strm As New StreamWriter(NomeArquivoCompleto)

        strm.WriteLine("using System;")
        strm.WriteLine("using System.Collections.Generic;")
        strm.WriteLine("using System.Data.Entity;")
        strm.WriteLine("using System.Text;")
        strm.WriteLine("using System.Threading.Tasks;")
        strm.WriteLine("using System.IO;")
        strm.WriteLine("using System.ComponentModel.DataAnnotations;")
        strm.WriteLine("using System.ComponentModel;")
        strm.WriteLine("using System.Linq;")
        strm.WriteLine("")
        'NAMESPACE

        Dim NomeClasse As String = Tabela.Nome.Replace(" ", "_")

        strm.WriteLine("namespace " & NAMESPACEMODEL & "{")

        strm.WriteLine("public class MD_" & NomeClasse)
        strm.WriteLine("{")
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            strm.WriteLine("   [DisplayName(""" & Tabela.Campos(icampos).Nome & """)]")
            strm.WriteLine("   public object " & Tabela.Campos(icampos).Nome & " { get; set; }")
        Next
        strm.WriteLine("}")
        strm.WriteLine("")
        strm.WriteLine("[MetadataType(typeof(MD_" & NomeClasse & "))]")
        strm.WriteLine("public partial class " & NomeClasse)
        strm.WriteLine("{")
        strm.WriteLine("")
        '****************************************************************************************************************************
        'MÉTODO INCLUIR
        '****************************************************************************************************************************
        strm.WriteLine("   public static void Incluir(" & NomeClasse & " o" & NomeClasse & ")")
        strm.WriteLine("   {")
        strm.WriteLine("       using (" & lDataContextName & " db = new " & lDataContextName & "(" + ConnectionString + "))")
        strm.WriteLine("       {")
        strm.WriteLine("           db." & NomeClasse & ".Add(o" & NomeClasse & ");")
        strm.WriteLine("           INB.LOG.GRAVALOG.IncluirSerializa(3, MyGlobal.CodigoSistema, MyGlobal.Matricula, MyGlobal.IP(), MyGlobal.NomeEstacao(),o" & Tabela.Nome & ", MyGlobal.AmbienteReal);")
        strm.WriteLine("           db.SaveChanges();")
        strm.WriteLine("       }")
        strm.WriteLine("   }")
        '****************************************************************************************************************************
        '****************************************************************************************************************************
        strm.WriteLine("")
        '****************************************************************************************************************************
        'MÉTODO ALTERAR
        '****************************************************************************************************************************
        strm.WriteLine("   public static void Alterar(" & NomeClasse & " o" & NomeClasse & ")")
        strm.WriteLine("   {")
        strm.WriteLine("       using (" & lDataContextName & " db = new " & lDataContextName & "(" + ConnectionString + "))")
        strm.WriteLine("       {")
        strm.WriteLine("           db.Entry(o" & NomeClasse & ").State = System.Data.Entity.EntityState.Modified;")
        strm.WriteLine("           INB.LOG.GRAVALOG.IncluirSerializa(4, MyGlobal.CodigoSistema, MyGlobal.Matricula, MyGlobal.IP(), MyGlobal.NomeEstacao(),o" & NomeClasse & ", MyGlobal.AmbienteReal);")
        strm.WriteLine("           db.SaveChanges();")
        strm.WriteLine("       }")
        strm.WriteLine("   }")
        '****************************************************************************************************************************
        '****************************************************************************************************************************
        strm.WriteLine("")
        '****************************************************************************************************************************
        'MÉTODO Excluir pelo Objeto
        '****************************************************************************************************************************
        strm.WriteLine("   public static void Excluir(" & NomeClasse & " o" & NomeClasse & ")")
        strm.WriteLine("   {")
        strm.WriteLine("       using (" & lDataContextName & " db = new " & lDataContextName & "(" + ConnectionString + "))")
        strm.WriteLine("       {")
        strm.WriteLine("           db.Entry(o" & NomeClasse & ").State = System.Data.Entity.EntityState.Deleted;")
        strm.WriteLine("           INB.LOG.GRAVALOG.IncluirSerializa(5, MyGlobal.CodigoSistema, MyGlobal.Matricula, MyGlobal.IP(), MyGlobal.NomeEstacao(),o" & NomeClasse & ", MyGlobal.AmbienteReal);")
        strm.WriteLine("           db.SaveChanges();")
        strm.WriteLine("       }")
        strm.WriteLine("   }")
        '****************************************************************************************************************************
        '****************************************************************************************************************************
        '****************************************************************************************************************************
        'MÉTODO EXCLUIR PELA CHAVE
        '****************************************************************************************************************************
        strm.Write("   public static void Excluir(")

        Dim Primeiro As Boolean = True
        Dim strSeleciona As String = ""
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(",")
                End If
                Select Case Tabela.Campos(icampos).Tipo
                    Case LERESTRUTURA.TABLE.EnumTipo.eBool
                        strm.Write("bool ")
                    Case LERESTRUTURA.TABLE.EnumTipo.eDate, LERESTRUTURA.TABLE.EnumTipo.eDateTime, LERESTRUTURA.TABLE.EnumTipo.eTime
                        strm.Write("DateTime ")
                    Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                        strm.Write("Decimal ")
                    Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                        strm.Write("int ")
                    Case LERESTRUTURA.TABLE.EnumTipo.eText
                        strm.Write("string ")
                    Case Else
                        strm.Write("object ")
                End Select
                strm.Write("p" & Tabela.Campos(icampos).Nome)
            End If
        Next
        strm.Write(")")
        strm.WriteLine("")
        strm.WriteLine("   {")
        strm.WriteLine("      using (" & lDataContextName & " db = new " & lDataContextName & "(" + ConnectionString + "))")
        strm.WriteLine("      {")

        strm.WriteLine("         " & Tabela.Nome & " oExcluir = new " & Tabela.Nome & "();")
        Primeiro = True
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                strm.WriteLine("         oExcluir." & Tabela.Campos(icampos).Nome & " = p" & Tabela.Campos(icampos).Nome & ";")
            End If
        Next
        strm.WriteLine("           db.Entry(oExcluir).State = System.Data.Entity.EntityState.Deleted;")
        strm.WriteLine("           INB.LOG.GRAVALOG.IncluirSerializa(5, MyGlobal.CodigoSistema, MyGlobal.Matricula, MyGlobal.IP(), MyGlobal.NomeEstacao(),oExcluir, MyGlobal.AmbienteReal);")
        strm.WriteLine("           db.SaveChanges();")
        strm.WriteLine("      }")
        strm.WriteLine("   }")
        '****************************************************************************************************************************
        '****************************************************************************************************************************
        strm.WriteLine("")
    '****************************************************************************************************************************
    'MÉTODO SELECIONAR TODOS OS REGISTROS
    '****************************************************************************************************************************
        strm.WriteLine("   public static List<" & NomeClasse & "> SelecionarTodos()")
        strm.WriteLine("   {")
        strm.WriteLine("   using (" & lDataContextName & " db = new " & lDataContextName & "(" + ConnectionString + "))")
        strm.WriteLine("      {")
        strm.WriteLine("         var res = (from p in db." & NomeClasse & " select p).ToList();")
        strm.WriteLine("         db.Dispose();")
        strm.WriteLine("         INB.LOG.GRAVALOG.Incluir(MyGlobal.Matricula, MyGlobal.CodigoSistema, 6, MyGlobal.NomeEstacao(),""" & NomeClasse & """, MyGlobal.IP(), ""SelecionarTodos();"", """", MyGlobal.AmbienteReal);")
        strm.WriteLine("         return res;")
        strm.WriteLine("       }")
        strm.WriteLine("   }")
    '****************************************************************************************************************************
    '****************************************************************************************************************************
        strm.WriteLine("")


    '****************************************************************************************************************************
    'MÉTODO SELECIONAR PELA CHAVE
    '****************************************************************************************************************************
        strm.Write("   public static " & NomeClasse & " Selecionar(")

        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(",")
                End If
                Select Case Tabela.Campos(icampos).Tipo
                    Case LERESTRUTURA.TABLE.EnumTipo.eBool
                        strm.Write("bool ")
                    Case LERESTRUTURA.TABLE.EnumTipo.eDate, LERESTRUTURA.TABLE.EnumTipo.eDateTime, LERESTRUTURA.TABLE.EnumTipo.eTime
                        strm.Write("DateTime ")
                    Case LERESTRUTURA.TABLE.EnumTipo.eFloat
                        strm.Write("Decimal ")
                    Case LERESTRUTURA.TABLE.EnumTipo.eInteger
                        strm.Write("int ")
                    Case LERESTRUTURA.TABLE.EnumTipo.eText
                        strm.Write("string ")
                    Case Else
                        strm.Write("object ")
                End Select
                strm.Write("p" & Tabela.Campos(icampos).Nome)
            End If
        Next
        strm.Write(")")
        strm.WriteLine("")
        strm.WriteLine("   {")
        strm.WriteLine("      using (" & lDataContextName & " db = new " & lDataContextName & "(" + ConnectionString + "))")
        strm.WriteLine("      {")

        strm.Write("         var res = (from p in db." & Tabela.Nome & " where ")
        Primeiro = True
        For icampos As Integer = 0 To Tabela.TotalCampos - 1
            If Tabela.Campos(icampos).Chave Then
                If Primeiro Then
                    Primeiro = False
                Else
                    strm.Write(" && ")
                End If
                strm.Write("p." & Tabela.Campos(icampos).Nome & " == " & "p" & Tabela.Campos(icampos).Nome)
            End If
        Next
        strm.Write(" select p).ToList();")
        strm.WriteLine("")
        strm.WriteLine("         var oRetorno = res.FirstOrDefault();")
        strm.WriteLine("         INB.LOG.GRAVALOG.IncluirSerializa(6, MyGlobal.CodigoSistema, MyGlobal.Matricula, MyGlobal.IP(), MyGlobal.NomeEstacao(), oRetorno, MyGlobal.AmbienteReal);")
        strm.WriteLine("         return oRetorno;")
        strm.WriteLine("      }")
        strm.WriteLine("   }")
    '****************************************************************************************************************************
    '****************************************************************************************************************************
        strm.WriteLine("}") 'Fecha a classe
        strm.WriteLine("}") 'Fecha o namespace

        strm.Close()
    End Sub

    Private Sub CriaArquivosClasses()
        Dim NomeArquivo As String
        Dim NomeArquivoCompleto As String
        Dim Tipo As String
        Dim NomeTabela As String

        Dim Tabela As LERESTRUTURA.TABLE.stTable
        Dim Estrutura As New LERESTRUTURA.TABLE

        Dim i As Integer, x As Integer

        ProgressBar1.Maximum = Items.Count - 1


        For i = 0 To Items.Count - 1
            ProgressBar1.Value = i
            LblDisplay.Text = "Criando classes (" & i + 1 & " de " & Items.Count & ")"
            Me.Refresh()

            NomeArquivo = Items(i).ToString
            Tipo = NomeArquivo.Substring(0, NomeArquivo.IndexOf("."))
            NomeTabela = NomeArquivo.Substring(NomeArquivo.IndexOf(".") + 1)
            NomeArquivo = Prefixo & NomeArquivo.Substring(NomeArquivo.IndexOf(".") + 1)


            Estrutura.ConnectionString = _ConnectionString

            If TipoConexao = EnumTipoConexao.SQLSERVER Then

                Tabela = Estrutura.Table(DirectCast(Cn, SqlClient.SqlConnection), NomeTabela)
            Else
                Tabela = Estrutura.Table(DirectCast(Cn, OleDb.OleDbConnection), NomeTabela)
            End If

            If Tabela.TotalCampos > 0 Then
                If lLinguagemCriacao = LinguagemCriacao.VBNET Then
                    NomeArquivoCompleto = Diretorio & NomeArquivo.Replace(" ", "_") & ".vb"
                    ExportaVB_NET(NomeArquivoCompleto, NomeArquivo, Tabela)
                Else
                    NomeArquivoCompleto = Diretorio & NomeArquivo.Replace(" ", "_") & ".cs"
                    ExportaC(NomeArquivoCompleto, NomeArquivo, Tabela)
                End If
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

    Private Sub FrmCriacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ConnectionString = strCn
    End Sub

    Private Sub LblDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDisplay.Click

    End Sub
End Class

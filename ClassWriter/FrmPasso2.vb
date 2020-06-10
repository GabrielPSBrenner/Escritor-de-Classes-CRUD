Public Class FrmPasso2
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
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents ChkListaObjetos As System.Windows.Forms.CheckedListBox
   Friend WithEvents ChkClasses As System.Windows.Forms.CheckBox
   Friend WithEvents CmdRetorna As System.Windows.Forms.Button
   Friend WithEvents CmdAvanca As System.Windows.Forms.Button
   Friend WithEvents CmdCancela As System.Windows.Forms.Button
   Friend WithEvents CmdInverterSelecao As System.Windows.Forms.Button
   Friend WithEvents ChkCRUDModel As System.Windows.Forms.CheckBox
   Friend WithEvents ChkXML As System.Windows.Forms.CheckBox
   Friend WithEvents ChkControladora As System.Windows.Forms.CheckBox
   Friend WithEvents ChkSuper As System.Windows.Forms.CheckBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPasso2))
      Me.Label1 = New System.Windows.Forms.Label
      Me.ChkListaObjetos = New System.Windows.Forms.CheckedListBox
      Me.ChkClasses = New System.Windows.Forms.CheckBox
      Me.ChkXML = New System.Windows.Forms.CheckBox
      Me.ChkSuper = New System.Windows.Forms.CheckBox
      Me.ChkCRUDModel = New System.Windows.Forms.CheckBox
      Me.ChkControladora = New System.Windows.Forms.CheckBox
      Me.CmdRetorna = New System.Windows.Forms.Button
      Me.CmdAvanca = New System.Windows.Forms.Button
      Me.CmdCancela = New System.Windows.Forms.Button
      Me.CmdInverterSelecao = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.Location = New System.Drawing.Point(28, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(192, 16)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Objetos do Banco de Dados"
      '
      'ChkListaObjetos
      '
      Me.ChkListaObjetos.CheckOnClick = True
      Me.ChkListaObjetos.Location = New System.Drawing.Point(24, 36)
      Me.ChkListaObjetos.Name = "ChkListaObjetos"
      Me.ChkListaObjetos.Size = New System.Drawing.Size(272, 169)
      Me.ChkListaObjetos.Sorted = True
      Me.ChkListaObjetos.TabIndex = 1
      '
      'ChkClasses
      '
      Me.ChkClasses.Location = New System.Drawing.Point(304, 68)
      Me.ChkClasses.Name = "ChkClasses"
      Me.ChkClasses.Size = New System.Drawing.Size(184, 16)
      Me.ChkClasses.TabIndex = 2
      Me.ChkClasses.Text = "Criar os arquivos de classes "
      '
      'ChkXML
      '
      Me.ChkXML.Location = New System.Drawing.Point(304, 180)
      Me.ChkXML.Name = "ChkXML"
      Me.ChkXML.Size = New System.Drawing.Size(184, 16)
      Me.ChkXML.TabIndex = 3
      Me.ChkXML.Text = "Criar o arquivo XML"
      '
      'ChkSuper
      '
      Me.ChkSuper.Enabled = False
      Me.ChkSuper.Location = New System.Drawing.Point(320, 160)
      Me.ChkSuper.Name = "ChkSuper"
      Me.ChkSuper.Size = New System.Drawing.Size(168, 16)
      Me.ChkSuper.TabIndex = 5
      Me.ChkSuper.Visible = False
      '
      'ChkCRUDModel
      '
      Me.ChkCRUDModel.Enabled = False
      Me.ChkCRUDModel.Location = New System.Drawing.Point(320, 92)
      Me.ChkCRUDModel.Name = "ChkCRUDModel"
      Me.ChkCRUDModel.Size = New System.Drawing.Size(168, 40)
      Me.ChkCRUDModel.TabIndex = 6
      Me.ChkCRUDModel.Text = "Criar o arquivo CRUD Model e Super e herdar as classes bases dele"
      '
      'ChkControladora
      '
      Me.ChkControladora.Enabled = False
      Me.ChkControladora.Location = New System.Drawing.Point(320, 136)
      Me.ChkControladora.Name = "ChkControladora"
      Me.ChkControladora.Size = New System.Drawing.Size(168, 16)
      Me.ChkControladora.TabIndex = 7
      Me.ChkControladora.Text = "Criar controladora padrão"
      '
      'CmdRetorna
      '
      Me.CmdRetorna.Location = New System.Drawing.Point(280, 216)
      Me.CmdRetorna.Name = "CmdRetorna"
      Me.CmdRetorna.Size = New System.Drawing.Size(100, 28)
      Me.CmdRetorna.TabIndex = 9
      Me.CmdRetorna.Text = "<<"
      '
      'CmdAvanca
      '
      Me.CmdAvanca.Location = New System.Drawing.Point(384, 216)
      Me.CmdAvanca.Name = "CmdAvanca"
      Me.CmdAvanca.Size = New System.Drawing.Size(100, 28)
      Me.CmdAvanca.TabIndex = 8
      Me.CmdAvanca.Text = "> >"
      '
      'CmdCancela
      '
      Me.CmdCancela.Location = New System.Drawing.Point(176, 216)
      Me.CmdCancela.Name = "CmdCancela"
      Me.CmdCancela.Size = New System.Drawing.Size(100, 28)
      Me.CmdCancela.TabIndex = 12
      Me.CmdCancela.Text = "Cancelar"
      '
      'CmdInverterSelecao
      '
      Me.CmdInverterSelecao.Location = New System.Drawing.Point(304, 36)
      Me.CmdInverterSelecao.Name = "CmdInverterSelecao"
      Me.CmdInverterSelecao.Size = New System.Drawing.Size(180, 24)
      Me.CmdInverterSelecao.TabIndex = 13
      Me.CmdInverterSelecao.Text = "Inverter Seleção"
      '
      'FrmPasso2
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(494, 256)
      Me.Controls.Add(Me.CmdInverterSelecao)
      Me.Controls.Add(Me.CmdCancela)
      Me.Controls.Add(Me.CmdRetorna)
      Me.Controls.Add(Me.CmdAvanca)
      Me.Controls.Add(Me.ChkControladora)
      Me.Controls.Add(Me.ChkCRUDModel)
      Me.Controls.Add(Me.ChkSuper)
      Me.Controls.Add(Me.ChkXML)
      Me.Controls.Add(Me.ChkClasses)
      Me.Controls.Add(Me.ChkListaObjetos)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "FrmPasso2"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Assistente de utilização da Persiste Dados - Escolha das origens"
      Me.ResumeLayout(False)

   End Sub

#End Region

   Public FrmPonteiroPasso1 As FrmPasso1

   Private ExibeAleta As Boolean = True

   Private Sub CmdRetorna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRetorna.Click
      Me.Hide()
      FrmPonteiroPasso1.Show()
      ExibeAleta = False
      Me.Close()
      Me.Dispose()
   End Sub

   Private Sub FrmPasso2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim ds As DataSet
      If TipoConexao = [Global].EnumTipoConexao.SQLSERVER Then
         ds = LERESTRUTURA.DATABASE.SQLSERVERDataBaseObjects(DirectCast(Cn, SqlClient.SqlConnection))
      Else
         ds = LERESTRUTURA.DATABASE.SQLSERVERDataBaseObjects(DirectCast(Cn, OleDb.OleDbConnection))
      End If
      Dim Dv As DataView
      Dv = ds.Tables("TABLES").DefaultView
      For i As Short = 0 To Dv.Count - 1
         ChkListaObjetos.Items.Add("{TABLE}." & Dv.Item(i).Row(0))
      Next
      Dv = ds.Tables("VIEWS").DefaultView
      For i As Short = 0 To Dv.Count - 1
         ChkListaObjetos.Items.Add("{VIEW}." & Dv.Item(i).Row(0))
      Next
   End Sub

   Private Sub CmdInverterSelecao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInverterSelecao.Click
      For i As Integer = 0 To ChkListaObjetos.Items.Count - 1
         ChkListaObjetos.SetItemChecked(i, Not ChkListaObjetos.GetItemChecked(i))
      Next
   End Sub

   Private Sub CmdCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancela.Click
      Me.Close()
   End Sub

   Private Sub FrmPasso2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
      If Me.Visible = True And ExibeAleta Then
         If MsgBox("Deseja sair do assistente ?", MsgBoxStyle.YesNo, "Sair da aplicação") = MsgBoxResult.Yes Then
            FrmPonteiroPasso1.Close()
            End
         Else
            e.Cancel = True
         End If
      End If
   End Sub

   Private Sub ChkClasses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkClasses.CheckedChanged
      ChkSuper.Enabled = ChkClasses.Checked
      ChkCRUDModel.Enabled = ChkClasses.Checked
      ChkControladora.Enabled = ChkClasses.Checked
      ChkSuper.Checked = False
      ChkCRUDModel.Checked = False
      ChkControladora.Checked = False
   End Sub

   Private Sub CmdAvanca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAvanca.Click
      Dim Arrayitems As New ArrayList
      For i As Integer = 0 To ChkListaObjetos.Items.Count - 1
         If ChkListaObjetos.GetItemChecked(i) = True Then
            Arrayitems.Add(ChkListaObjetos.GetItemText(ChkListaObjetos.Items(i)))
         End If
      Next

      If Arrayitems.Count = 0 Then
         MsgBox("É necessário escolher ao menos um objeto do banco de dados para continuar ", MsgBoxStyle.Exclamation, "Impossível continuar")
         Exit Sub
      End If
      If ChkClasses.Checked = False And ChkXML.Checked = False Then
         MsgBox("É necessário escolhar ao menos uma opção de criação (classes ou XML ou ambos)!", MsgBoxStyle.Exclamation, "Impossível continuar")
         Exit Sub
      End If
      FrmPas3 = New FrmPasso3
      FrmPas3.FrmPonteiroPasso2 = Me
      FrmPas3.ArquivosClasses = ChkClasses.Checked
      FrmPas3.CRUDMODEL = ChkCRUDModel.Checked
      FrmPas3.Super = ChkSuper.Checked
      FrmPas3.XML = ChkXML.Checked
      FrmPas3.Controladora = ChkControladora.Checked
      FrmPas3.ItensSelecionados = Arrayitems
      Me.Hide()
      FrmPas3.Show()
   End Sub
End Class

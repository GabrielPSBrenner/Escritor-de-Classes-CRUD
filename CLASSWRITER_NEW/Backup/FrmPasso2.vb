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
    Friend WithEvents ChkClasses As System.Windows.Forms.CheckBox
    Friend WithEvents CmdRetorna As System.Windows.Forms.Button
    Friend WithEvents CmdAvanca As System.Windows.Forms.Button
    Friend WithEvents CmdCancela As System.Windows.Forms.Button
    Friend WithEvents CmdInverterSelecao As System.Windows.Forms.Button
    Friend WithEvents ChkCRUDModel As System.Windows.Forms.CheckBox
    Friend WithEvents ChkXML As System.Windows.Forms.CheckBox
    Friend WithEvents ChkControladora As System.Windows.Forms.CheckBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ChkListaObjetos As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChkView As System.Windows.Forms.CheckedListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ChkProcedure As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChkSuper As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPasso2))
        Me.ChkClasses = New System.Windows.Forms.CheckBox
        Me.ChkXML = New System.Windows.Forms.CheckBox
        Me.ChkSuper = New System.Windows.Forms.CheckBox
        Me.ChkCRUDModel = New System.Windows.Forms.CheckBox
        Me.ChkControladora = New System.Windows.Forms.CheckBox
        Me.CmdRetorna = New System.Windows.Forms.Button
        Me.CmdAvanca = New System.Windows.Forms.Button
        Me.CmdCancela = New System.Windows.Forms.Button
        Me.CmdInverterSelecao = New System.Windows.Forms.Button
        Me.DataSet1 = New System.Data.DataSet
        Me.Tabs = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ChkListaObjetos = New System.Windows.Forms.CheckedListBox
        Me.ChkView = New System.Windows.Forms.CheckedListBox
        Me.ChkProcedure = New System.Windows.Forms.CheckedListBox
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkClasses
        '
        Me.ChkClasses.Location = New System.Drawing.Point(413, 67)
        Me.ChkClasses.Name = "ChkClasses"
        Me.ChkClasses.Size = New System.Drawing.Size(184, 16)
        Me.ChkClasses.TabIndex = 2
        Me.ChkClasses.Text = "Criar os arquivos de classes "
        '
        'ChkXML
        '
        Me.ChkXML.Location = New System.Drawing.Point(413, 179)
        Me.ChkXML.Name = "ChkXML"
        Me.ChkXML.Size = New System.Drawing.Size(184, 16)
        Me.ChkXML.TabIndex = 3
        Me.ChkXML.Text = "Criar o arquivo XML"
        '
        'ChkSuper
        '
        Me.ChkSuper.Enabled = False
        Me.ChkSuper.Location = New System.Drawing.Point(429, 159)
        Me.ChkSuper.Name = "ChkSuper"
        Me.ChkSuper.Size = New System.Drawing.Size(168, 16)
        Me.ChkSuper.TabIndex = 5
        Me.ChkSuper.Visible = False
        '
        'ChkCRUDModel
        '
        Me.ChkCRUDModel.Enabled = False
        Me.ChkCRUDModel.Location = New System.Drawing.Point(429, 91)
        Me.ChkCRUDModel.Name = "ChkCRUDModel"
        Me.ChkCRUDModel.Size = New System.Drawing.Size(168, 40)
        Me.ChkCRUDModel.TabIndex = 6
        Me.ChkCRUDModel.Text = "Criar o arquivo CRUD Model e Super e herdar as classes bases dele"
        '
        'ChkControladora
        '
        Me.ChkControladora.Enabled = False
        Me.ChkControladora.Location = New System.Drawing.Point(429, 135)
        Me.ChkControladora.Name = "ChkControladora"
        Me.ChkControladora.Size = New System.Drawing.Size(168, 16)
        Me.ChkControladora.TabIndex = 7
        Me.ChkControladora.Text = "Criar controladora padrão"
        '
        'CmdRetorna
        '
        Me.CmdRetorna.Location = New System.Drawing.Point(393, 231)
        Me.CmdRetorna.Name = "CmdRetorna"
        Me.CmdRetorna.Size = New System.Drawing.Size(100, 28)
        Me.CmdRetorna.TabIndex = 9
        Me.CmdRetorna.Text = "<<"
        '
        'CmdAvanca
        '
        Me.CmdAvanca.Location = New System.Drawing.Point(497, 231)
        Me.CmdAvanca.Name = "CmdAvanca"
        Me.CmdAvanca.Size = New System.Drawing.Size(100, 28)
        Me.CmdAvanca.TabIndex = 8
        Me.CmdAvanca.Text = "> >"
        '
        'CmdCancela
        '
        Me.CmdCancela.Location = New System.Drawing.Point(289, 231)
        Me.CmdCancela.Name = "CmdCancela"
        Me.CmdCancela.Size = New System.Drawing.Size(100, 28)
        Me.CmdCancela.TabIndex = 12
        Me.CmdCancela.Text = "Cancelar"
        '
        'CmdInverterSelecao
        '
        Me.CmdInverterSelecao.Location = New System.Drawing.Point(413, 35)
        Me.CmdInverterSelecao.Name = "CmdInverterSelecao"
        Me.CmdInverterSelecao.Size = New System.Drawing.Size(180, 24)
        Me.CmdInverterSelecao.TabIndex = 13
        Me.CmdInverterSelecao.Text = "Inverter Seleção"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabPage1)
        Me.Tabs.Controls.Add(Me.TabPage2)
        Me.Tabs.Controls.Add(Me.TabPage3)
        Me.Tabs.Location = New System.Drawing.Point(2, 4)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(405, 228)
        Me.Tabs.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ChkListaObjetos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(397, 202)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TABELAS / TABLES"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ChkView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(397, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VIEWS / CONSULTAS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ChkProcedure)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(397, 202)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "STORED PROCEDURES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ChkListaObjetos
        '
        Me.ChkListaObjetos.CheckOnClick = True
        Me.ChkListaObjetos.Location = New System.Drawing.Point(3, 2)
        Me.ChkListaObjetos.Name = "ChkListaObjetos"
        Me.ChkListaObjetos.Size = New System.Drawing.Size(391, 199)
        Me.ChkListaObjetos.Sorted = True
        Me.ChkListaObjetos.TabIndex = 2
        '
        'ChkView
        '
        Me.ChkView.CheckOnClick = True
        Me.ChkView.Location = New System.Drawing.Point(3, 2)
        Me.ChkView.Name = "ChkView"
        Me.ChkView.Size = New System.Drawing.Size(391, 199)
        Me.ChkView.Sorted = True
        Me.ChkView.TabIndex = 3
        '
        'ChkProcedure
        '
        Me.ChkProcedure.CheckOnClick = True
        Me.ChkProcedure.Location = New System.Drawing.Point(3, 2)
        Me.ChkProcedure.Name = "ChkProcedure"
        Me.ChkProcedure.Size = New System.Drawing.Size(391, 199)
        Me.ChkProcedure.Sorted = True
        Me.ChkProcedure.TabIndex = 3
        '
        'FrmPasso2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(605, 262)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.CmdInverterSelecao)
        Me.Controls.Add(Me.CmdCancela)
        Me.Controls.Add(Me.CmdRetorna)
        Me.Controls.Add(Me.CmdAvanca)
        Me.Controls.Add(Me.ChkControladora)
        Me.Controls.Add(Me.ChkCRUDModel)
        Me.Controls.Add(Me.ChkSuper)
        Me.Controls.Add(Me.ChkXML)
        Me.Controls.Add(Me.ChkClasses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPasso2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistente de utilização da Persiste Dados - Escolha das origens"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
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

    Private Sub FrmPasso2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
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
            ChkView.Items.Add("{VIEW}." & Dv.Item(i).Row(0))
        Next
        BindingControls(False)
    End Sub

    Private Sub CmdInverterSelecao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInverterSelecao.Click
        If Tabs.SelectedIndex = 0 Then
            For i As Integer = 0 To ChkListaObjetos.Items.Count - 1
                ChkListaObjetos.SetItemChecked(i, Not ChkListaObjetos.GetItemChecked(i))
            Next
        ElseIf Tabs.SelectedIndex = 1 Then
            For i As Integer = 0 To ChkView.Items.Count - 1
                ChkView.SetItemChecked(i, Not ChkView.GetItemChecked(i))
            Next
        ElseIf Tabs.SelectedIndex = 2 Then
            For i As Integer = 0 To ChkProcedure.Items.Count - 1
                ChkProcedure.SetItemChecked(i, Not ChkProcedure.GetItemChecked(i))
            Next
        End If
    End Sub

    Private Sub CmdCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancela.Click
        Me.Close()
    End Sub

    Private Sub FrmPasso2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If Me.Visible = True And ExibeAleta Then
            If MsgBox("Deseja sair do assistente ?", MsgBoxStyle.YesNo, "Sair da aplicação") = MsgBoxResult.Yes Then
                FrmPonteiroPasso1.Close()
                BindingControls(True)
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

        For i As Integer = 0 To ChkView.Items.Count - 1
            If ChkView.GetItemChecked(i) = True Then
                Arrayitems.Add(ChkView.GetItemText(ChkView.Items(i)))
            End If
        Next

        For i As Integer = 0 To ChkProcedure.Items.Count - 1
            If ChkProcedure.GetItemChecked(i) = True Then
                Arrayitems.Add(ChkProcedure.GetItemText(ChkProcedure.Items(i)))
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
        BindingControls(True)
    End Sub

    Public Sub BindingControls(ByVal Save As Boolean)
        If Save = False Then
            DataSet1.ReadXml(ConfigXmlPath & "FrmPas2.xml")
            ChkClasses.DataBindings.Add(New Binding("Checked", DataSet1, "FrmPasso2.ChkClasses"))
            ChkCRUDModel.DataBindings.Add(New Binding("Checked", DataSet1, "FrmPasso2.ChkCRUDModel"))
            ChkControladora.DataBindings.Add(New Binding("Checked", DataSet1, "FrmPasso2.ChkControladora"))
            ChkXML.DataBindings.Add(New Binding("Checked", DataSet1, "FrmPasso2.ChkXML"))
        Else
            ChkClasses.DataBindings.Item("Checked").BindingManagerBase.EndCurrentEdit()
            ChkCRUDModel.DataBindings.Item("Checked").BindingManagerBase.EndCurrentEdit()
            ChkControladora.DataBindings.Item("Checked").BindingManagerBase.EndCurrentEdit()
            ChkXML.DataBindings.Item("Checked").BindingManagerBase.EndCurrentEdit()
            'DataSet1.WriteXml(ConfigXmlPath & "FrmPas2.xml")
        End If
    End Sub

    Private Sub ChkXML_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkXML.CheckedChanged

    End Sub

    Private Sub ChkListaObjetos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

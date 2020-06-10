Public Class FrmPasso3
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
   Friend WithEvents CmdSelecionar As System.Windows.Forms.Button
   Friend WithEvents TxtPrefixo As System.Windows.Forms.TextBox
   Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
   Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
   Friend WithEvents CmdVoltar As System.Windows.Forms.Button
   Friend WithEvents CmdCancelar As System.Windows.Forms.Button
   Friend WithEvents CmdAvancar As System.Windows.Forms.Button
   Friend WithEvents TxtXML As System.Windows.Forms.TextBox
   Friend WithEvents LblXML As System.Windows.Forms.Label
   Friend WithEvents DlgPasta As System.Windows.Forms.FolderBrowserDialog
	Friend WithEvents LblPrefixo As System.Windows.Forms.Label
	Friend WithEvents ChkCaminhoPadrao As System.Windows.Forms.CheckBox
	Friend WithEvents DataSet1 As System.Data.DataSet
	Friend WithEvents TxtDiretorio As System.Windows.Forms.TextBox
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPasso3))
		Me.Label1 = New System.Windows.Forms.Label
		Me.TxtDiretorio = New System.Windows.Forms.TextBox
		Me.CmdSelecionar = New System.Windows.Forms.Button
		Me.LblPrefixo = New System.Windows.Forms.Label
		Me.TxtPrefixo = New System.Windows.Forms.TextBox
		Me.CheckBox1 = New System.Windows.Forms.CheckBox
		Me.CheckBox2 = New System.Windows.Forms.CheckBox
		Me.CmdCancelar = New System.Windows.Forms.Button
		Me.CmdAvancar = New System.Windows.Forms.Button
		Me.CmdVoltar = New System.Windows.Forms.Button
		Me.LblXML = New System.Windows.Forms.Label
		Me.TxtXML = New System.Windows.Forms.TextBox
		Me.DlgPasta = New System.Windows.Forms.FolderBrowserDialog
		Me.ChkCaminhoPadrao = New System.Windows.Forms.CheckBox
		Me.DataSet1 = New System.Data.DataSet
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(12, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(104, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Gravar arquivos em"
		'
		'TxtDiretorio
		'
		Me.TxtDiretorio.Location = New System.Drawing.Point(116, 12)
		Me.TxtDiretorio.Name = "TxtDiretorio"
		Me.TxtDiretorio.ReadOnly = True
		Me.TxtDiretorio.Size = New System.Drawing.Size(444, 20)
		Me.TxtDiretorio.TabIndex = 1
		Me.TxtDiretorio.TabStop = False
		'
		'CmdSelecionar
		'
		Me.CmdSelecionar.Enabled = False
		Me.CmdSelecionar.Location = New System.Drawing.Point(560, 12)
		Me.CmdSelecionar.Name = "CmdSelecionar"
		Me.CmdSelecionar.Size = New System.Drawing.Size(24, 20)
		Me.CmdSelecionar.TabIndex = 2
		Me.CmdSelecionar.Text = "..."
		'
		'LblPrefixo
		'
		Me.LblPrefixo.Location = New System.Drawing.Point(12, 43)
		Me.LblPrefixo.Name = "LblPrefixo"
		Me.LblPrefixo.Size = New System.Drawing.Size(104, 16)
		Me.LblPrefixo.TabIndex = 3
		Me.LblPrefixo.Text = "Prefixo das Classes"
		'
		'TxtPrefixo
		'
		Me.TxtPrefixo.Location = New System.Drawing.Point(116, 39)
		Me.TxtPrefixo.MaxLength = 10
		Me.TxtPrefixo.Name = "TxtPrefixo"
		Me.TxtPrefixo.Size = New System.Drawing.Size(244, 20)
		Me.TxtPrefixo.TabIndex = 4
		'
		'CheckBox1
		'
		Me.CheckBox1.Enabled = False
		Me.CheckBox1.Location = New System.Drawing.Point(116, 64)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(428, 16)
		Me.CheckBox1.TabIndex = 5
		Me.CheckBox1.Text = "Atualizar arquivos de classes existentes. mantendo seus métodos (extra classe)"
		'
		'CheckBox2
		'
		Me.CheckBox2.Enabled = False
		Me.CheckBox2.Location = New System.Drawing.Point(116, 84)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(424, 16)
		Me.CheckBox2.TabIndex = 6
		Me.CheckBox2.Text = "Atualizar XML, mantendo as configurações existentes"
		'
		'CmdCancelar
		'
		Me.CmdCancelar.Location = New System.Drawing.Point(272, 128)
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(100, 28)
		Me.CmdCancelar.TabIndex = 11
		Me.CmdCancelar.Text = "Cancelar"
		'
		'CmdAvancar
		'
		Me.CmdAvancar.Location = New System.Drawing.Point(480, 128)
		Me.CmdAvancar.Name = "CmdAvancar"
		Me.CmdAvancar.Size = New System.Drawing.Size(100, 28)
		Me.CmdAvancar.TabIndex = 10
		Me.CmdAvancar.Text = "> >"
		'
		'CmdVoltar
		'
		Me.CmdVoltar.Location = New System.Drawing.Point(376, 128)
		Me.CmdVoltar.Name = "CmdVoltar"
		Me.CmdVoltar.Size = New System.Drawing.Size(100, 28)
		Me.CmdVoltar.TabIndex = 12
		Me.CmdVoltar.Text = "<<"
		'
		'LblXML
		'
		Me.LblXML.Location = New System.Drawing.Point(361, 43)
		Me.LblXML.Name = "LblXML"
		Me.LblXML.Size = New System.Drawing.Size(76, 16)
		Me.LblXML.TabIndex = 13
		Me.LblXML.Text = "Nome do XML"
		'
		'TxtXML
		'
		Me.TxtXML.Location = New System.Drawing.Point(437, 39)
		Me.TxtXML.MaxLength = 20
		Me.TxtXML.Name = "TxtXML"
		Me.TxtXML.ReadOnly = True
		Me.TxtXML.Size = New System.Drawing.Size(148, 20)
		Me.TxtXML.TabIndex = 14
		Me.TxtXML.TabStop = False
		'
		'ChkCaminhoPadrao
		'
		Me.ChkCaminhoPadrao.Checked = True
		Me.ChkCaminhoPadrao.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ChkCaminhoPadrao.Location = New System.Drawing.Point(116, 106)
		Me.ChkCaminhoPadrao.Name = "ChkCaminhoPadrao"
		Me.ChkCaminhoPadrao.Size = New System.Drawing.Size(424, 16)
		Me.ChkCaminhoPadrao.TabIndex = 7
		Me.ChkCaminhoPadrao.Text = "Utilizar caminho padrão para o XML"
		'
		'DataSet1
		'
		Me.DataSet1.DataSetName = "NewDataSet"
		'
		'FrmPasso3
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(594, 165)
		Me.Controls.Add(Me.ChkCaminhoPadrao)
		Me.Controls.Add(Me.TxtXML)
		Me.Controls.Add(Me.LblXML)
		Me.Controls.Add(Me.CmdVoltar)
		Me.Controls.Add(Me.CmdCancelar)
		Me.Controls.Add(Me.CmdAvancar)
		Me.Controls.Add(Me.CheckBox2)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.TxtPrefixo)
		Me.Controls.Add(Me.LblPrefixo)
		Me.Controls.Add(Me.CmdSelecionar)
		Me.Controls.Add(Me.TxtDiretorio)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.Name = "FrmPasso3"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CONFIG"
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region

	Public Super As Boolean				  'identificador se será criado a classe super
	Public CRUDMODEL As Boolean			  'identificador se será criado a classe CRUDMODEL
	Public lArquivosClasses As Boolean	  'identificador se serão criados os arquivos .VB das classes
	Public lXML As Boolean				  'identificador se será criado o arquivo XML
	Public Controladora As Boolean		  'identificador se será criado a controladora padrão
	Public FrmPonteiroPasso2 As FrmPasso2 'Ponteiro para o passo 2 do assistente de criação das classes
	Public ItensSelecionados As ArrayList 'Coleção de itens selecionados no passo 2 do assitente

	Private ExibeAlerta As Boolean = True

	Public WriteOnly Property ArquivosClasses() As Boolean
		Set(ByVal Value As Boolean)
			lArquivosClasses = Value
			CmdSelecionar.Enabled = True
			LblPrefixo.Enabled = Value
			TxtPrefixo.Enabled = Value
		End Set
	End Property

	Public WriteOnly Property XML() As Boolean
		Set(ByVal Value As Boolean)
			lXML = Value
			LblXML.Enabled = Value
			TxtXML.Enabled = Value
			CmdSelecionar.Enabled = True
		End Set
	End Property

	Private Sub CmdVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVoltar.Click
		Me.Hide()
		FrmPonteiroPasso2.Show()
		ExibeAlerta = False
		BindingControls(True)
		Me.Close()
		Me.Dispose()
	End Sub

	Private Sub FrmPasso3_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		If ExibeAlerta And Me.Visible = True Then
			If MsgBox("Deseja sair do assistente ?", MsgBoxStyle.YesNo, "Sair da aplicação") = MsgBoxResult.Yes Then
				FrmPonteiroPasso2.Close()
				BindingControls(True)
				End
			Else
				e.Cancel = True
			End If
		End If
	End Sub

	Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
		Me.Close()
	End Sub

	Private Sub FrmPasso3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		TxtPrefixo.Text = ""
		TxtXML.Text = "Config" & DataBase
		BindingControls(False)
	End Sub

	Private Sub CmdSelecionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSelecionar.Click
		Dim DlgRetorno As System.Windows.Forms.DialogResult
		DlgRetorno = DlgPasta.ShowDialog()
		If DlgRetorno = DialogResult.OK Then
			TxtDiretorio.Text = DlgPasta.SelectedPath & "\"
		Else
			TxtDiretorio.Text = ""
		End If
	End Sub

	Private Sub CmdAvancar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAvancar.Click
		If TxtDiretorio.Text.Trim = "" Then
			MsgBox("É necessário escolher um diretório para continuar!", MsgBoxStyle.Exclamation, "Impossível continuar")
			Exit Sub
		End If

		FrmCria = New FrmCriacao
		FrmCria.FrmPonteiroPasso3 = Me
		FrmCria.Diretorio = TxtDiretorio.Text
		FrmCria.NomeArquivoXML = TxtXML.Text
		FrmCria.Prefixo = TxtPrefixo.Text
		FrmCria.UsaCaminhoPadrao = ChkCaminhoPadrao.Checked

		FrmCria.Super = Me.Super
		FrmCria.CRUDMODEL = Me.CRUDMODEL
		FrmCria.lXML = Me.lXML
		FrmCria.lArquivosClasses = Me.lArquivosClasses
		FrmCria.Controladora = Me.Controladora

		FrmCria.Items = Me.ItensSelecionados
		Me.Hide()
		FrmCria.Show()
		BindingControls(True)
	End Sub

	Public Sub BindingControls(ByVal Save As Boolean)
		If Save = False Then
			DataSet1.ReadXml(ConfigXmlPath & "FrmPas3.xml")
			TxtDiretorio.DataBindings.Add(New Binding("Text", DataSet1, "FrmPasso3.TxtDiretorio"))
			TxtPrefixo.DataBindings.Add(New Binding("Text", DataSet1, "FrmPasso3.TxtPrefixo"))
			ChkCaminhoPadrao.DataBindings.Add(New Binding("Checked", DataSet1, "FrmPasso3.ChkCaminhoPadrao"))
		Else
			TxtDiretorio.DataBindings.Item("Text").BindingManagerBase.EndCurrentEdit()
			TxtPrefixo.DataBindings.Item("Text").BindingManagerBase.EndCurrentEdit()
			ChkCaminhoPadrao.DataBindings.Item("Checked").BindingManagerBase.EndCurrentEdit()
			'DataSet1.WriteXml(ConfigXmlPath & "FrmPas3.xml")
		End If
	End Sub
End Class

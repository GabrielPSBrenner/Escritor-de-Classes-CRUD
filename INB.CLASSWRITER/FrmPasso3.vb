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
    Friend WithEvents CmdVoltar As System.Windows.Forms.Button
    Friend WithEvents CmdCancelar As System.Windows.Forms.Button
    Friend WithEvents CmdAvancar As System.Windows.Forms.Button
    Friend WithEvents DlgPasta As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LblPrefixo As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents OptVB As System.Windows.Forms.RadioButton
    Friend WithEvents OptC As System.Windows.Forms.RadioButton
    Friend WithEvents TxtDataContext As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OptDAO As System.Windows.Forms.RadioButton
    Friend WithEvents OptPartial As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtStringConnection As System.Windows.Forms.TextBox
    Friend WithEvents ChkPreparaLog As System.Windows.Forms.CheckBox
    Friend WithEvents ChkImportaCONSEG As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNameSpace As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OptMatricula As System.Windows.Forms.RadioButton
    Friend WithEvents OptPerfil As System.Windows.Forms.RadioButton
    Friend WithEvents TxtDiretorio As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPasso3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDiretorio = New System.Windows.Forms.TextBox()
        Me.CmdSelecionar = New System.Windows.Forms.Button()
        Me.LblPrefixo = New System.Windows.Forms.Label()
        Me.TxtPrefixo = New System.Windows.Forms.TextBox()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdAvancar = New System.Windows.Forms.Button()
        Me.CmdVoltar = New System.Windows.Forms.Button()
        Me.DlgPasta = New System.Windows.Forms.FolderBrowserDialog()
        Me.DataSet1 = New System.Data.DataSet()
        Me.OptVB = New System.Windows.Forms.RadioButton()
        Me.OptC = New System.Windows.Forms.RadioButton()
        Me.TxtDataContext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OptDAO = New System.Windows.Forms.RadioButton()
        Me.OptPartial = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtStringConnection = New System.Windows.Forms.TextBox()
        Me.ChkPreparaLog = New System.Windows.Forms.CheckBox()
        Me.ChkImportaCONSEG = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNameSpace = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OptMatricula = New System.Windows.Forms.RadioButton()
        Me.OptPerfil = New System.Windows.Forms.RadioButton()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gravar arquivos em"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDiretorio
        '
        Me.TxtDiretorio.Location = New System.Drawing.Point(148, 9)
        Me.TxtDiretorio.Name = "TxtDiretorio"
        Me.TxtDiretorio.ReadOnly = True
        Me.TxtDiretorio.Size = New System.Drawing.Size(398, 20)
        Me.TxtDiretorio.TabIndex = 1
        Me.TxtDiretorio.TabStop = False
        '
        'CmdSelecionar
        '
        Me.CmdSelecionar.Location = New System.Drawing.Point(552, 9)
        Me.CmdSelecionar.Name = "CmdSelecionar"
        Me.CmdSelecionar.Size = New System.Drawing.Size(24, 20)
        Me.CmdSelecionar.TabIndex = 2
        Me.CmdSelecionar.Text = "..."
        '
        'LblPrefixo
        '
        Me.LblPrefixo.Location = New System.Drawing.Point(16, 37)
        Me.LblPrefixo.Name = "LblPrefixo"
        Me.LblPrefixo.Size = New System.Drawing.Size(126, 16)
        Me.LblPrefixo.TabIndex = 3
        Me.LblPrefixo.Text = "Prefixo das Classes"
        Me.LblPrefixo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPrefixo
        '
        Me.TxtPrefixo.Location = New System.Drawing.Point(148, 35)
        Me.TxtPrefixo.MaxLength = 10
        Me.TxtPrefixo.Name = "TxtPrefixo"
        Me.TxtPrefixo.Size = New System.Drawing.Size(206, 20)
        Me.TxtPrefixo.TabIndex = 4
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Location = New System.Drawing.Point(215, 183)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(126, 44)
        Me.CmdCancelar.TabIndex = 11
        Me.CmdCancelar.Text = "Cancelar"
        '
        'CmdAvancar
        '
        Me.CmdAvancar.Location = New System.Drawing.Point(459, 183)
        Me.CmdAvancar.Name = "CmdAvancar"
        Me.CmdAvancar.Size = New System.Drawing.Size(117, 44)
        Me.CmdAvancar.TabIndex = 10
        Me.CmdAvancar.Text = "> >"
        '
        'CmdVoltar
        '
        Me.CmdVoltar.Location = New System.Drawing.Point(341, 183)
        Me.CmdVoltar.Name = "CmdVoltar"
        Me.CmdVoltar.Size = New System.Drawing.Size(118, 44)
        Me.CmdVoltar.TabIndex = 12
        Me.CmdVoltar.Text = "<<"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'OptVB
        '
        Me.OptVB.AutoSize = True
        Me.OptVB.Location = New System.Drawing.Point(20, 19)
        Me.OptVB.Name = "OptVB"
        Me.OptVB.Size = New System.Drawing.Size(64, 17)
        Me.OptVB.TabIndex = 13
        Me.OptVB.Text = "VB.NET"
        Me.OptVB.UseVisualStyleBackColor = True
        '
        'OptC
        '
        Me.OptC.AutoSize = True
        Me.OptC.Checked = True
        Me.OptC.Location = New System.Drawing.Point(85, 17)
        Me.OptC.Name = "OptC"
        Me.OptC.Size = New System.Drawing.Size(39, 17)
        Me.OptC.TabIndex = 14
        Me.OptC.TabStop = True
        Me.OptC.Text = "C#"
        Me.OptC.UseVisualStyleBackColor = True
        '
        'TxtDataContext
        '
        Me.TxtDataContext.Location = New System.Drawing.Point(148, 61)
        Me.TxtDataContext.MaxLength = 40
        Me.TxtDataContext.Name = "TxtDataContext"
        Me.TxtDataContext.Size = New System.Drawing.Size(206, 20)
        Me.TxtDataContext.TabIndex = 16
        Me.TxtDataContext.Text = "NameEntities"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(51, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Data Context"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptDAO
        '
        Me.OptDAO.AutoSize = True
        Me.OptDAO.Location = New System.Drawing.Point(14, 19)
        Me.OptDAO.Name = "OptDAO"
        Me.OptDAO.Size = New System.Drawing.Size(48, 17)
        Me.OptDAO.TabIndex = 17
        Me.OptDAO.Text = "DAO"
        Me.OptDAO.UseVisualStyleBackColor = True
        '
        'OptPartial
        '
        Me.OptPartial.AutoSize = True
        Me.OptPartial.Checked = True
        Me.OptPartial.Location = New System.Drawing.Point(65, 19)
        Me.OptPartial.Name = "OptPartial"
        Me.OptPartial.Size = New System.Drawing.Size(131, 17)
        Me.OptPartial.TabIndex = 18
        Me.OptPartial.TabStop = True
        Me.OptPartial.Text = "Utilizando Partial Class"
        Me.OptPartial.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptVB)
        Me.GroupBox1.Controls.Add(Me.OptC)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 40)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Linguagem"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OptDAO)
        Me.GroupBox2.Controls.Add(Me.OptPartial)
        Me.GroupBox2.Location = New System.Drawing.Point(150, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 40)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modelo de Classes"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Parâmetro DataContext"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtStringConnection
        '
        Me.TxtStringConnection.Location = New System.Drawing.Point(148, 91)
        Me.TxtStringConnection.MaxLength = 40
        Me.TxtStringConnection.Name = "TxtStringConnection"
        Me.TxtStringConnection.Size = New System.Drawing.Size(206, 20)
        Me.TxtStringConnection.TabIndex = 22
        Me.TxtStringConnection.Text = "MyGlobal.ConnectionString"
        '
        'ChkPreparaLog
        '
        Me.ChkPreparaLog.AutoSize = True
        Me.ChkPreparaLog.Checked = True
        Me.ChkPreparaLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPreparaLog.Location = New System.Drawing.Point(12, 198)
        Me.ChkPreparaLog.Name = "ChkPreparaLog"
        Me.ChkPreparaLog.Size = New System.Drawing.Size(84, 17)
        Me.ChkPreparaLog.TabIndex = 23
        Me.ChkPreparaLog.Text = "Prepara Log"
        Me.ChkPreparaLog.UseVisualStyleBackColor = True
        '
        'ChkImportaCONSEG
        '
        Me.ChkImportaCONSEG.AutoSize = True
        Me.ChkImportaCONSEG.Checked = True
        Me.ChkImportaCONSEG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkImportaCONSEG.Location = New System.Drawing.Point(97, 198)
        Me.ChkImportaCONSEG.Name = "ChkImportaCONSEG"
        Me.ChkImportaCONSEG.Size = New System.Drawing.Size(112, 17)
        Me.ChkImportaCONSEG.TabIndex = 23
        Me.ChkImportaCONSEG.Text = "Importar CONSEG"
        Me.ChkImportaCONSEG.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "NAMESPACE MODEL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNameSpace
        '
        Me.TxtNameSpace.Location = New System.Drawing.Point(148, 118)
        Me.TxtNameSpace.MaxLength = 40
        Me.TxtNameSpace.Name = "TxtNameSpace"
        Me.TxtNameSpace.Size = New System.Drawing.Size(206, 20)
        Me.TxtNameSpace.TabIndex = 25
        Me.TxtNameSpace.Text = "INB"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OptMatricula)
        Me.GroupBox3.Controls.Add(Me.OptPerfil)
        Me.GroupBox3.Location = New System.Drawing.Point(350, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 40)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recebe Matricula/Perfil"
        '
        'OptMatricula
        '
        Me.OptMatricula.AutoSize = True
        Me.OptMatricula.Checked = True
        Me.OptMatricula.Location = New System.Drawing.Point(14, 19)
        Me.OptMatricula.Name = "OptMatricula"
        Me.OptMatricula.Size = New System.Drawing.Size(70, 17)
        Me.OptMatricula.TabIndex = 17
        Me.OptMatricula.TabStop = True
        Me.OptMatricula.Text = "Matrícula"
        Me.OptMatricula.UseVisualStyleBackColor = True
        '
        'OptPerfil
        '
        Me.OptPerfil.AutoSize = True
        Me.OptPerfil.Location = New System.Drawing.Point(84, 20)
        Me.OptPerfil.Name = "OptPerfil"
        Me.OptPerfil.Size = New System.Drawing.Size(48, 17)
        Me.OptPerfil.TabIndex = 18
        Me.OptPerfil.Text = "Perfil"
        Me.OptPerfil.UseVisualStyleBackColor = True
        '
        'FrmPasso3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(581, 232)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TxtNameSpace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChkImportaCONSEG)
        Me.Controls.Add(Me.ChkPreparaLog)
        Me.Controls.Add(Me.TxtStringConnection)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtDataContext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdVoltar)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAvancar)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public lArquivosClasses As Boolean    'identificador se serão criados os arquivos .VB das classes
    Public FrmPonteiroPasso2 As FrmPasso2 'Ponteiro para o passo 2 do assistente de criação das classes
    Public ItensSelecionados As ArrayList 'Coleção de itens selecionados no passo 2 do assitente

    Private ExibeAlerta As Boolean = True

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
            TxtDiretorio.Focus()
            Exit Sub
        ElseIf TxtDataContext.Text = "" Then
            MsgBox("É necessário preencher o nome do DataContext da aplicação!", MsgBoxStyle.Exclamation, "Impossível continuar")
            TxtDataContext.Focus()
            Exit Sub
        End If
        If OptVB.Checked Then
            FrmCria = New FrmCriacao(FrmCriacao.LinguagemCriacao.VBNET, TxtDataContext.Text)
        Else
            FrmCria = New FrmCriacao(FrmCriacao.LinguagemCriacao.C, TxtDataContext.Text)
        End If
        FrmCria.PreparaLog = ChkPreparaLog.Checked
        FrmCria.ImportaCONSEG = ChkImportaCONSEG.Checked
        FrmCria.FrmPonteiroPasso3 = Me
        FrmCria.Diretorio = TxtDiretorio.Text
        FrmCria.Prefixo = TxtPrefixo.Text
        FrmCria.ConnectionString = TxtStringConnection.Text
        FrmCria.NAMESPACEMODEL = TxtNameSpace.Text
        If OptMatricula.Checked Then
            FrmCria.RecebeMetodo = FrmCriacao.eRecebeMetodo.Matricula
        ElseIf OptPerfil.Checked Then
            FrmCria.RecebeMetodo = FrmCriacao.eRecebeMetodo.Perfil
        Else
            FrmCria.RecebeMetodo = FrmCriacao.eRecebeMetodo.NA
        End If
        If OptPartial.Checked Then
            FrmCria.TipoClasse = FrmCriacao.ModelType.ClassesPartial
        Else
            FrmCria.TipoClasse = FrmCriacao.ModelType.ClassesDAO
        End If
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
        Else
            TxtDiretorio.DataBindings.Item("Text").BindingManagerBase.EndCurrentEdit()
            TxtPrefixo.DataBindings.Item("Text").BindingManagerBase.EndCurrentEdit()
            DataSet1.WriteXml(ConfigXmlPath & "FrmPas3.xml")
		End If
	End Sub

    Private Sub OptDAO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptDAO.CheckedChanged
        If OptDAO.Checked Then
            TxtPrefixo.Enabled = True
            TxtPrefixo.Text = "DAO_"
        End If
    End Sub

    Private Sub OptPartial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptPartial.CheckedChanged
        If OptPartial.Checked Then
            TxtPrefixo.Enabled = False
            TxtPrefixo.Text = ""
        End If
    End Sub

    Private Sub ChkPreparaLog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPreparaLog.CheckedChanged
        If ChkPreparaLog.Checked Then
            ChkImportaCONSEG.Checked = True
        End If
    End Sub

    Private Sub OptC_CheckedChanged(sender As Object, e As EventArgs) Handles OptC.CheckedChanged
        OptPartial.Checked = True
        OptMatricula.Checked = True
        ChkPreparaLog.Checked = True
        ChkImportaCONSEG.Checked = False

        OptPartial.Enabled = False
        OptMatricula.Enabled = False
        ChkPreparaLog.Enabled = False
        ChkImportaCONSEG.Enabled = False
        OptVB.Checked = False
        OptDAO.Enabled = False
        OptPerfil.Enabled = False
        ChkPreparaLog.Enabled = False
    End Sub

    Private Sub OptVB_CheckedChanged(sender As Object, e As EventArgs) Handles OptVB.CheckedChanged
        OptPartial.Enabled = True
        OptMatricula.Enabled = True
        ChkPreparaLog.Enabled = True
        ChkImportaCONSEG.Enabled = True
        OptVB.Checked = True
        OptDAO.Enabled = True
        OptPerfil.Enabled = True
        ChkPreparaLog.Enabled = True
    End Sub
End Class

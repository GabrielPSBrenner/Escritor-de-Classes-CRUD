Public Class FrmPasso1
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
   Friend WithEvents CboTipoConexao As System.Windows.Forms.ComboBox
   Friend WithEvents FamSQLSERVER As System.Windows.Forms.Panel
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents TxtServidor As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents TxtBancoDados As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents CmdAvancarPasso2 As System.Windows.Forms.Button
   Friend WithEvents CmdFinalizar As System.Windows.Forms.Button
   Friend WithEvents TxtUID As System.Windows.Forms.TextBox
   Friend WithEvents TxtPWD As System.Windows.Forms.TextBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPasso1))
      Me.Label1 = New System.Windows.Forms.Label
      Me.CboTipoConexao = New System.Windows.Forms.ComboBox
      Me.FamSQLSERVER = New System.Windows.Forms.Panel
      Me.TxtPWD = New System.Windows.Forms.TextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.TxtUID = New System.Windows.Forms.TextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.TxtBancoDados = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.TxtServidor = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.CmdAvancarPasso2 = New System.Windows.Forms.Button
      Me.CmdFinalizar = New System.Windows.Forms.Button
      Me.FamSQLSERVER.SuspendLayout()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.Location = New System.Drawing.Point(8, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(92, 16)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Tipo da Conex�o"
      '
      'CboTipoConexao
      '
      Me.CboTipoConexao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CboTipoConexao.Location = New System.Drawing.Point(104, 8)
      Me.CboTipoConexao.Name = "CboTipoConexao"
      Me.CboTipoConexao.Size = New System.Drawing.Size(168, 21)
      Me.CboTipoConexao.TabIndex = 1
      '
      'FamSQLSERVER
      '
      Me.FamSQLSERVER.Controls.Add(Me.TxtPWD)
      Me.FamSQLSERVER.Controls.Add(Me.Label5)
      Me.FamSQLSERVER.Controls.Add(Me.TxtUID)
      Me.FamSQLSERVER.Controls.Add(Me.Label4)
      Me.FamSQLSERVER.Controls.Add(Me.TxtBancoDados)
      Me.FamSQLSERVER.Controls.Add(Me.Label3)
      Me.FamSQLSERVER.Controls.Add(Me.TxtServidor)
      Me.FamSQLSERVER.Controls.Add(Me.Label2)
      Me.FamSQLSERVER.Location = New System.Drawing.Point(8, 44)
      Me.FamSQLSERVER.Name = "FamSQLSERVER"
      Me.FamSQLSERVER.Size = New System.Drawing.Size(540, 64)
      Me.FamSQLSERVER.TabIndex = 2
      '
      'TxtPWD
      '
      Me.TxtPWD.Location = New System.Drawing.Point(348, 36)
      Me.TxtPWD.MaxLength = 25
      Me.TxtPWD.Name = "TxtPWD"
      Me.TxtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
      Me.TxtPWD.Size = New System.Drawing.Size(184, 20)
      Me.TxtPWD.TabIndex = 7
      '
      'Label5
      '
      Me.Label5.Location = New System.Drawing.Point(300, 40)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(44, 12)
      Me.Label5.TabIndex = 6
      Me.Label5.Text = "Senha"
      '
      'TxtUID
      '
      Me.TxtUID.Location = New System.Drawing.Point(68, 36)
      Me.TxtUID.MaxLength = 25
      Me.TxtUID.Name = "TxtUID"
      Me.TxtUID.Size = New System.Drawing.Size(184, 20)
      Me.TxtUID.TabIndex = 5
      '
      'Label4
      '
      Me.Label4.Location = New System.Drawing.Point(20, 40)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 12)
      Me.Label4.TabIndex = 4
      Me.Label4.Text = "Usu�rio"
      '
      'TxtBancoDados
      '
      Me.TxtBancoDados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.TxtBancoDados.Location = New System.Drawing.Point(348, 8)
      Me.TxtBancoDados.MaxLength = 25
      Me.TxtBancoDados.Name = "TxtBancoDados"
      Me.TxtBancoDados.Size = New System.Drawing.Size(184, 20)
      Me.TxtBancoDados.TabIndex = 3
      '
      'Label3
      '
      Me.Label3.Location = New System.Drawing.Point(260, 12)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(88, 12)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "Banco de Dados"
      '
      'TxtServidor
      '
      Me.TxtServidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.TxtServidor.Location = New System.Drawing.Point(68, 8)
      Me.TxtServidor.MaxLength = 25
      Me.TxtServidor.Name = "TxtServidor"
      Me.TxtServidor.Size = New System.Drawing.Size(184, 20)
      Me.TxtServidor.TabIndex = 1
      Me.TxtServidor.Text = "BDADOSSVR"
      '
      'Label2
      '
      Me.Label2.Location = New System.Drawing.Point(16, 12)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(48, 12)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Servidor"
      '
      'CmdAvancarPasso2
      '
      Me.CmdAvancarPasso2.Location = New System.Drawing.Point(448, 116)
      Me.CmdAvancarPasso2.Name = "CmdAvancarPasso2"
      Me.CmdAvancarPasso2.Size = New System.Drawing.Size(100, 28)
      Me.CmdAvancarPasso2.TabIndex = 3
      Me.CmdAvancarPasso2.Text = "> >"
      '
      'CmdFinalizar
      '
      Me.CmdFinalizar.Location = New System.Drawing.Point(344, 116)
      Me.CmdFinalizar.Name = "CmdFinalizar"
      Me.CmdFinalizar.Size = New System.Drawing.Size(100, 28)
      Me.CmdFinalizar.TabIndex = 4
      Me.CmdFinalizar.Text = "Cancelar"
      '
      'FrmPasso1
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(556, 150)
      Me.Controls.Add(Me.CmdFinalizar)
      Me.Controls.Add(Me.CmdAvancarPasso2)
      Me.Controls.Add(Me.FamSQLSERVER)
      Me.Controls.Add(Me.CboTipoConexao)
      Me.Controls.Add(Me.Label1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "FrmPasso1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Assistente de utiliza��o da Persiste Dados - Conex�o"
      Me.FamSQLSERVER.ResumeLayout(False)
      Me.FamSQLSERVER.PerformLayout()
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub FrmPasso1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      CboTipoConexao.Items.Add("SQL-SERVER")
      CboTipoConexao.SelectedIndex = 0
   End Sub

   Private Sub CmdFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFinalizar.Click
      Me.Close()
   End Sub

   Private Sub CmdAvancarPasso2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAvancarPasso2.Click
      Dim strCn As String
      If TipoConexao = [Global].EnumTipoConexao.SQLSERVER Then
         strCn = "Connection Timeout=100000;Server=" & TxtServidor.Text & ";Database=" & TxtBancoDados.Text & ";UID=" & TxtUID.Text & ";PWD=" & TxtPWD.Text
         'strCn = "Provider=SQLOLEDB.1;Password=" & TxtPWD.Text & ";Persist Security Info=True;User ID=" & TxtUID.Text & ";Initial Catalog=" & TxtBancoDados.Text & ";Data Source=" & TxtServidor.Text
         Cn = New SqlClient.SqlConnection(strCn)
         'Cn = New OleDb.OleDbConnection(strCn)
         Try
            Cn.Open()
         Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro na conex�o")
            Cn = Nothing
            Exit Sub
         End Try
         Server = TxtServidor.Text
         DataBase = TxtBancoDados.Text
         UID = TxtUID.Text
         PWD = TxtPWD.Text
         FrmPas2 = New FrmPasso2
         FrmPas2.FrmPonteiroPasso1 = Me
         Me.Hide()
         FrmPas2.Show()
      End If
   End Sub

   Private Sub FrmPasso1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
      If Me.Visible = True Then
         If MsgBox("Deseja sair do assistente ?", MsgBoxStyle.YesNo, "Sair da aplica��o") = MsgBoxResult.Yes Then
            End
         Else
            e.Cancel = True
         End If
      End If
   End Sub
End Class

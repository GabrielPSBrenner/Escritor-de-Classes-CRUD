<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfProcedure
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmdCancela = New System.Windows.Forms.Button
        Me.CmdRetorna = New System.Windows.Forms.Button
        Me.CmdAvanca = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ProNome = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProRetorno = New System.Windows.Forms.DataGridViewComboBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdCancela
        '
        Me.CmdCancela.Location = New System.Drawing.Point(161, 235)
        Me.CmdCancela.Name = "CmdCancela"
        Me.CmdCancela.Size = New System.Drawing.Size(100, 28)
        Me.CmdCancela.TabIndex = 15
        Me.CmdCancela.Text = "Cancelar"
        '
        'CmdRetorna
        '
        Me.CmdRetorna.Location = New System.Drawing.Point(265, 235)
        Me.CmdRetorna.Name = "CmdRetorna"
        Me.CmdRetorna.Size = New System.Drawing.Size(100, 28)
        Me.CmdRetorna.TabIndex = 14
        Me.CmdRetorna.Text = "<<"
        '
        'CmdAvanca
        '
        Me.CmdAvanca.Location = New System.Drawing.Point(369, 235)
        Me.CmdAvanca.Name = "CmdAvanca"
        Me.CmdAvanca.Size = New System.Drawing.Size(100, 28)
        Me.CmdAvanca.TabIndex = 13
        Me.CmdAvanca.Text = "> >"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProNome, Me.ProRetorno})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(466, 228)
        Me.DataGridView1.TabIndex = 16
        '
        'ProNome
        '
        Me.ProNome.HeaderText = "Procedure"
        Me.ProNome.Name = "ProNome"
        Me.ProNome.ReadOnly = True
        Me.ProNome.Width = 250
        '
        'ProRetorno
        '
        Me.ProRetorno.HeaderText = "Retorno da Procedure"
        Me.ProRetorno.Items.AddRange(New Object() {"Um único Valor", "Registros Afetados", "Coleção de Registros"})
        Me.ProRetorno.Name = "ProRetorno"
        Me.ProRetorno.Width = 150
        '
        'FrmConfProcedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 266)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdCancela)
        Me.Controls.Add(Me.CmdRetorna)
        Me.Controls.Add(Me.CmdAvanca)
        Me.Name = "FrmConfProcedure"
        Me.Text = "Configuração das Procedures"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdCancela As System.Windows.Forms.Button
    Friend WithEvents CmdRetorna As System.Windows.Forms.Button
    Friend WithEvents CmdAvanca As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProRetorno As System.Windows.Forms.DataGridViewComboBoxColumn
End Class

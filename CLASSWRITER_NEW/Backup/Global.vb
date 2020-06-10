Module [Global]
	Public FrmPas1 As FrmPasso1
	Public FrmPas2 As FrmPasso2
	Public FrmPas3 As FrmPasso3
	Public FrmCria As FrmCriacao

	Public Enum EnumTipoConexao
		SQLSERVER = 0
	End Enum

	Public Cn As IDbConnection
	Public TipoConexao As EnumTipoConexao = EnumTipoConexao.SQLSERVER
	Public Server As String
	Public DataBase As String
	Public UID As String
	Public PWD As String
	Public ConfigXmlPath As String = Application.StartupPath & "\Config"

	Public Sub Main()
		FrmPas1 = New FrmPasso1
		Application.Run(FrmPas1)
		FrmPas1.Dispose()
		FrmPas1 = Nothing
	End Sub

End Module

Namespace My.Templates.CSharp

	Partial Class Model

		Private _Config As Configuracao
		Private _Tabela As LERESTRUTURA.TABLE.stTable

		Public Sub New()
		End Sub

		Public Sub New(pConfiguracao As Configuracao, pTabela As LERESTRUTURA.TABLE.stTable)
			_Config = pConfiguracao
			_Tabela = pTabela
		End Sub

	End Class

End Namespace
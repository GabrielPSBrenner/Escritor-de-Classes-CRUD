Imports System.Data.SqlClient

Public Class TABLE
	Private i, ii As Integer
	Private lTable As stTable
	Private _ConnectionString As String

	Public Enum EnumDBType
		SQLServer = 0
		Oracle = 1
		MySQL = 2
		OLEDB = 3
		ODBC = 4
	End Enum

	Public Enum EnumTipo
		eFloat = 0
		eInteger = 1
		eText = 2
		eDate = 3
		eTime = 4
		eBin = 5
		eBool = 6
		eDateTime = 7 'Falta identificar o tipo data/hora junto <<IMPLEMENTAR>>
	End Enum

	Public Structure stCampo
		Dim Index As Integer
		Dim Chave As Boolean
		Dim ChaveEstrangeira As Boolean
		Dim Nome As String
		Dim Tipo As EnumTipo
		Dim Value As String
		Dim Obrigatorio As Boolean
	End Structure

	Public Structure stTable
		Dim Nome As String
		Dim TotalCamposChaves As Integer
		Dim ChavePrimaria() As stCampo
		Dim TotalCampos As Integer
		Dim Campos() As stCampo
	End Structure

	Public Property ConnectionString() As String
		Get
			Return _ConnectionString
		End Get
		Set(ByVal value As String)
			_ConnectionString = value
		End Set
	End Property

	Public Function Table(ByVal AccessDatabase As String, ByVal PWD As String, ByVal pTable As String) As stTable
		Dim Cn As OleDb.OleDbConnection
		If PWD.Trim <> "" Then
			Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & AccessDatabase & ";Jet OLEDB:Database Password=" & PWD & ";")
		Else
			Cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & AccessDatabase & ";User Id=admin;Password=;")
		End If
		Return Table(Cn, pTable)
		Cn.Close()
		Cn.Dispose()
	End Function

	Public Function Table(ByRef Cn As OleDb.OleDbConnection, ByVal pTable As String) As stTable
		Dim Dr As OleDb.OleDbDataReader
		Dim Total As Integer = 0
		Try
			Dim Cm As New OleDb.OleDbCommand("Select Top 1 * from [" & pTable & "]", Cn)
			Cm.CommandTimeout = 100000
			If Cm.Connection.State = 0 Then Cm.Connection.Open()
			Dr = Cm.ExecuteReader(CommandBehavior.SchemaOnly)
			Dim Dt As DataTable = Dr.GetSchemaTable
			Total = Dt.Rows.Count
			Dr.Close()
			Try
				Dr = Cm.ExecuteReader(CommandBehavior.KeyInfo)
				Dt = Dr.GetSchemaTable
			Catch ex As Exception
				Dr = Cm.ExecuteReader(CommandBehavior.SchemaOnly)
				Dt = Dr.GetSchemaTable
			End Try
			Dr.Close()
			Dr = Nothing
			Cm.Dispose()
			Return ProcessaDetalhesTable(Dt, pTable, Total)
		Catch ex As SqlClient.SqlException
			Dr = Nothing
			MsgBox(ex.Message)
			Return Nothing
		End Try
	End Function

	Public Function Table(ByRef Cn As SqlClient.SqlConnection, ByVal pTable As String) As stTable
		Dim Dr As SqlClient.SqlDataReader
		Dim Total As Integer
		Try
			Dim Cm As New SqlClient.SqlCommand("Select Top 1 * from [" & pTable & "]", Cn)
			Cm.CommandTimeout = 10000000
			If Cm.Connection.State = 0 Then Cm.Connection.Open()

			'É necessário buscar o total de registros, para montar as views, porque o KeyInfo tráz colunas a mais.
			Dr = Cm.ExecuteReader(CommandBehavior.SchemaOnly)
			Dim Dt As DataTable = Dr.GetSchemaTable
			Total = Dt.Rows.Count
			Dr.Close()

			Try
				Dr = Cm.ExecuteReader(CommandBehavior.KeyInfo)
				Dt = Dr.GetSchemaTable
			Catch ex As Exception
				Dr = Cm.ExecuteReader(CommandBehavior.SchemaOnly)
				Dt = Dr.GetSchemaTable
			End Try
			Dr.Close()
			Dr = Nothing
			Cm.Dispose()
			Return ProcessaDetalhesTable(Dt, pTable, Total)
		Catch e As SqlClient.SqlException
			Dr = Nothing
			MsgBox(e.Message)
			Return Nothing
		End Try
	End Function

	Public Function Table(ByVal Server As String, ByVal Database As String, ByVal UID As String, ByVal PWD As String, ByVal pTable As String) As stTable
		_ConnectionString = "Server=" & Server & ";Database=" & Database & ";UID=" & UID & ";Pwd=" & PWD

		Dim Cn As New SqlClient.SqlConnection(_ConnectionString)
		Return Table(Cn, pTable)
		Cn.Close()
		Cn.Dispose()
		ChaveEstrangeira.FechaConexao()
	End Function

	Private Function ProcessaDetalhesTable(ByVal Dt As DataTable, ByVal pTable As String, ByVal Total As Integer) As stTable
		Dim iTable As stTable
		Dim Tipo As EnumTipo
		Dim TotalChaves As Integer = 0
		Dim arrChavesEstrangeiras As ArrayList = ChaveEstrangeira.RetornaChaves(pTable, _ConnectionString)
		ReDim iTable.Campos(Total - 1)

		iTable.TotalCampos = Total
		If Dt.Rows.Count > 0 Then
			iTable.Nome = pTable	'Dt.Rows(0).Item("BAseTableName")
		End If

		For i = 0 To Total - 1
			iTable.Campos(i).Nome = Dt.Rows(i).Item("ColumnName")

			iTable.Campos(i).Index = Dt.Rows(i).Item("ColumnOrdinal")
			If Dt.Rows(i).Item("AllowDbNull") = True Then
				iTable.Campos(i).Obrigatorio = False
			Else
				iTable.Campos(i).Obrigatorio = True
			End If
			Select Case Dt.Rows(i).Item("DataType").ToString
				Case "System.Int32", "System.Int16", "System.Byte"
					Tipo = EnumTipo.eInteger
				Case "System.Single", "System.Double", "System.Decimal"
					Tipo = EnumTipo.eFloat
				Case "System.Boolean"
					Tipo = EnumTipo.eBool
				Case "System.DateTime"
					Tipo = EnumTipo.eDateTime
				Case "System.Byte[]"
					Tipo = EnumTipo.eBin
				Case "System.String", "System.Char"
					Tipo = EnumTipo.eText
			End Select
			iTable.Campos(i).Tipo = Tipo
			If Dt.Rows(i).Item("isKey") = True Then
				ReDim Preserve iTable.ChavePrimaria(TotalChaves)
				iTable.Campos(i).Chave = True
				iTable.ChavePrimaria(TotalChaves).Nome = Dt.Rows(i).Item("ColumnName")
				iTable.ChavePrimaria(TotalChaves).Index = iTable.Campos(i).Index = Dt.Rows(i).Item("ColumnOrdinal")
				iTable.ChavePrimaria(TotalChaves).Chave = True
				iTable.ChavePrimaria(TotalChaves).Obrigatorio = True
				iTable.ChavePrimaria(TotalChaves).Tipo = Tipo
				TotalChaves += 1
			ElseIf arrChavesEstrangeiras.Count > 0 Then
				If arrChavesEstrangeiras.Contains(iTable.Campos(i).Nome) Then
					iTable.Campos(i).ChaveEstrangeira = True
				End If
			End If
		Next
		iTable.TotalCamposChaves = TotalChaves
		Return iTable
	End Function

End Class

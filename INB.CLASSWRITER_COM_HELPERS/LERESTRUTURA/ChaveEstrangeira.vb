Public Class ChaveEstrangeira
	Private Shared _ConnectionString As String
	Private Shared _Cn As SqlClient.SqlConnection

	Public Shared WriteOnly Property ConnectionString() As String
		Set(ByVal value As String)
			_ConnectionString = value
		End Set
	End Property

	Public Shared Sub FechaConexao()
		If Not _Cn Is Nothing Then
			If _Cn.State <> ConnectionState.Closed Then _Cn.Close()
			_Cn.Dispose()
		End If
	End Sub

	Public Shared Function RetornaChaves(ByVal TabelaNome As String, ByVal StrConexao As String) As ArrayList
		Dim arrList As New ArrayList
		Dim Dr As SqlClient.SqlDataReader
		Dim Cmd As SqlClient.SqlCommand
		Dim cSql As String = "Select SysObjects.Name As TableName, SysObjects.ID, SysColumns.name As ColumnName " & _
		"From SysObjects Inner Join SysColumns On SysColumns.id = SysObjects.id " & _
		"Inner Join SysForeignkeys On fkeyid = SysObjects.id And SysColumns.colid = fkey " & _
		"Where SysObjects.Type ='U' And SysObjects.Name = '" & TabelaNome & "'"

		'Sql que só funciona com SA
		'cSql = "Select COLUMN_NAME From INFORMATION_SCHEMA.KEY_COLUMN_USAGE Where Table_Name = '" & TabelaNome & "' And Substring(Constraint_Name, 1, 2) = 'FK'"

		If _Cn Is Nothing Then
			_Cn = New SqlClient.SqlConnection(StrConexao)
			_ConnectionString = StrConexao
		ElseIf StrConexao <> _ConnectionString Then
			If _Cn.State <> ConnectionState.Closed Then _Cn.Close()
			_Cn = New SqlClient.SqlConnection(StrConexao)
			_ConnectionString = StrConexao
		End If

		Cmd = New SqlClient.SqlCommand(cSql, _Cn)
		Cmd.CommandTimeout = 10000000
		If Cmd.Connection.State = 0 Then Cmd.Connection.Open()

		Dr = Cmd.ExecuteReader(CommandBehavior.Default)
		While Dr.Read
			arrList.Add(Dr.Item("ColumnName"))
		End While
		Dr.Close()

		Return arrList
	End Function
End Class

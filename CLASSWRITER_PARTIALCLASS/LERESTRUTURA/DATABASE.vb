Public Class DATABASE
   Public Shared Function SQLSERVERDataBaseObjects(ByVal oCn As SqlClient.SqlConnection) As DataSet
      Dim SQLTABLE As String = "Select [name] as Nome,'Table' as Type from [sysobjects] where xtype='U' and [name] <> 'dtproperties'"
      Dim SQLVIEWER As String = "Select [name] as Nome,'Viewer' as Type from [sysobjects] where xtype='V' and category =0"

      Dim Ds As New DataSet
      Dim Da As New SqlClient.SqlDataAdapter(SQLTABLE, oCn)

      Da.Fill(Ds, "TABLES")

      Da = New SqlClient.SqlDataAdapter(SQLVIEWER, oCn)
      Da.Fill(Ds, "VIEWS")

      Da.Dispose()
      Da = Nothing

      Return Ds
   End Function


   Public Shared Function SQLSERVERDataBaseObjects(ByVal oCn As OleDb.OleDbConnection) As DataSet
      'The library SQLClient, return wrong collunm names of the viewers.
      Dim SQLTABLE As String = "Select [name] as Nome,'Table' as Type from [sysobjects] where xtype='U' and [name] <> 'dtproperties'"
      Dim SQLVIEWER As String = "Select [name] as Nome,'Viewer' as Type from [sysobjects] where xtype='V' and category =0"

      Dim Ds As New DataSet
      Dim Da As New OleDb.OleDbDataAdapter(SQLTABLE, oCn)

      Da.Fill(Ds, "TABLES")

      Da = New OleDb.OleDbDataAdapter(SQLVIEWER, oCn)
      Da.Fill(Ds, "VIEWS")

      Da.Dispose()
      Da = Nothing

      Return Ds
   End Function
End Class

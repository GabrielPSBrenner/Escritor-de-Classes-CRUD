Public Class Placeholder

	Private _txtControl As TextBox
	Private _Message As String

	Public Sub New(ByRef txtControl As TextBox, Message As String)
		_txtControl = txtControl
		_Message = Message
		AddText(Nothing, Nothing)

		AddHandler _txtControl.GotFocus, AddressOf RemoveText
		AddHandler _txtControl.LostFocus, AddressOf AddText
	End Sub

	Public Sub RemoveText(sender As Object, e As EventArgs)
		If String.Equals(_txtControl.Text, _Message) Then
			_txtControl.Text = ""
			_txtControl.ForeColor = Color.Black
		End If
	End Sub

	Public Sub AddText(sender As Object, e As EventArgs)
		If String.IsNullOrWhiteSpace(_txtControl.Text) Then
			_txtControl.Text = _Message
			_txtControl.ForeColor = Color.Gray
		End If
	End Sub


End Class

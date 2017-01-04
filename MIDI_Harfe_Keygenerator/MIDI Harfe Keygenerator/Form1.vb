Public Class Form1


    Private Sub Generieren_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Generieren_Button.Click
        Key_TextBox.Clear()
        Dim R As New Random(Now.TimeOfDay.Milliseconds)
        For I As Integer = 1 To 10
            For J As Integer = 1 To 5
                Key_TextBox.Text &= Chr(R.Next(Asc("A"), Asc("Z")))
            Next
            Key_TextBox.Text &= "-"
            For J As Integer = 1 To 5
                Key_TextBox.Text &= Chr(R.Next(Asc("A"), Asc("Z")))
            Next
            Key_TextBox.Text &= "-"
            For J As Integer = 1 To 5
                Key_TextBox.Text &= Chr(R.Next(Asc("A"), Asc("Z")))
            Next
            Key_TextBox.Text &= "-"
            For J As Integer = 1 To 5
                Key_TextBox.Text &= Chr(R.Next(Asc("A"), Asc("Z")))
            Next
            Key_TextBox.Text &= "-"
            For J As Integer = 1 To 5
                Key_TextBox.Text &= Chr(R.Next(Asc("A"), Asc("Z")))
            Next
            Key_TextBox.Text &= vbCrLf
        Next
    End Sub
End Class

Public Class UserForm5
    Private Sub CommandButton1_Click(sender As Object, e As EventArgs) Handles CommandButton1.Click
        Dim a As Integer

        a = Label1.Text
        If (a >= 0) Then
            a = a + 1
            Label1.Text = a
        End If
    End Sub
End Class

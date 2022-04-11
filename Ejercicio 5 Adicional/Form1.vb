Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim limite As Integer
        Dim texto As String
        Dim num As Integer
        texto = TextBox1.Text
        limite = Len(texto)
        If Len(texto) <= 10 Then
            For i = 1 To Len(TextBox1.Text)
                num = Asc(Mid(texto, i, 1))
                If (num >= 48) And (num <= 57) Then
                    TextBox2.Text &= Mid(texto, i, 1)
                End If
            Next i
        Else MsgBox("Se excedió en cantidad de caracteres")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class

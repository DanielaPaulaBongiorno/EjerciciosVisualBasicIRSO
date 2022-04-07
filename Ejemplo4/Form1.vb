Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim prod As Integer
        a = Val(Caja1.Text)
        b = Val(Caja2.Text)
        prod = a * b
        Caja3.Text = prod
    End Sub
End Class

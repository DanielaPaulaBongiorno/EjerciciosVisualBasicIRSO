Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Caja3.Text = Int(Caja1.Text) + Int(Caja2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Caja3.Text = Int(Caja1.Text) - Int(Caja2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Caja3.Text = Int(Caja1.Text) * Int(Caja2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Caja2.Text <> 0) Then
            Caja3.Text = Int(Caja1.Text) / Int(Caja2.Text)
        Else Caja3.Text = "ERROR!"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Caja1.Clear()
        Caja2.Clear()
        Caja3.Clear()

    End Sub
End Class

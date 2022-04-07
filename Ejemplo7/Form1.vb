Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (CheckBox1.Checked = True) Then
            Caja.Text = "Opción 1"
        ElseIf (CheckBox2.Checked = True) Then
            Caja.Text = "Opción 2"
        ElseIf (CheckBox3.Checked = True) Then
            Caja.Text = "Opción 3"
        ElseIf (CheckBox4.Checked = True) Then
            Caja.Text = "Opción 4"
        Else Caja.Text = "Marque una opción"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Caja.Clear()

    End Sub
End Class

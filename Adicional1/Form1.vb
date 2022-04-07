Public Class Form1


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim texto As String
        Dim i, suma As Integer
        Dim tamanio As Integer
        texto = TextBox1.Text
        tamanio = Len(texto)
        suma = 0

        For i = 1 To tamanio
            If Mid(texto, i, 1) = "a" Then
                suma = suma + 1
            End If
            If Mid(texto, i, 1) = "e" Then
                suma = suma + 1
            End If
            If Mid(texto, i, 1) = "i" Then
                suma = suma + 1
            End If
            If Mid(texto, i, 1) = "o" Then
                suma = suma + 1
            End If
            If Mid(texto, i, 1) = "u" Then
                suma = suma + 1
            End If
        Next

        TextBox2.Text = suma

    End Sub
End Class

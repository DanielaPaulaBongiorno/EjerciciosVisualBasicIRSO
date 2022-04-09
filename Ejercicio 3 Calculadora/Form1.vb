Public Class Form1
    Dim numero1 As String
    Dim numero2 As String
    Dim operador As String
    Dim resultado As String
    Dim memo As String
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text &= "0"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "1"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "2"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "3"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "4"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "5"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "6"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "7"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "8"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        TextBox1.Text &= "9"
    End Sub
    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        Button11.Enabled = True
        numero1 = TextBox1.Text
        TextBox1.Clear()
        operador = "suma"
    End Sub
    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        Button11.Enabled = True
        numero1 = TextBox1.Text
        TextBox1.Clear()
        operador = "resta"
    End Sub
    Private Sub ButtonMulti_Click(sender As Object, e As EventArgs) Handles ButtonMulti.Click
        Button11.Enabled = True
        numero1 = TextBox1.Text
        TextBox1.Clear()
        operador = "multiplicacion"
    End Sub
    Private Sub ButtonDivi_Click(sender As Object, e As EventArgs) Handles ButtonDivi.Click
        Button11.Enabled = True
        numero1 = TextBox1.Text
        TextBox1.Clear()
        operador = "division"
    End Sub
    Private Sub ButtonRaiz_Click(sender As Object, e As EventArgs) Handles ButtonRaiz.Click
        Button11.Enabled = True
        numero1 = TextBox1.Text
        TextBox1.Clear()
        operador = "raiz"
    End Sub
    Private Sub ButtonCuadrado_Click(sender As Object, e As EventArgs) Handles ButtonCuadrado.Click
        Button11.Enabled = True
        numero1 = TextBox1.Text
        TextBox1.Clear()
        operador = "cuadrado"
    End Sub
    Private Sub ButtonLimpiartodo_Click(sender As Object, e As EventArgs) Handles ButtonLimpiartodo.Click
        Button11.Enabled = True
        TextBox1.Clear()
        TextBox1.Text = "0"
    End Sub
    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        numero2 = TextBox1.Text
        TextBox1.Clear()
        If (operador = "suma") Then
            Button11.Enabled = True
            resultado = Val(numero1) + Val(numero2)
            TextBox1.Text = resultado
        End If
        If (operador = "resta") Then
            Button11.Enabled = True
            resultado = Val(numero1) - Val(numero2)
            TextBox1.Text = resultado
        End If
        If (operador = "multiplicacion") Then
            Button11.Enabled = True
            resultado = Val(numero1) * Val(numero2)
            TextBox1.Text = resultado
        End If
        If (operador = "division") Then
            Button11.Enabled = True
            If (Val(numero2 > 0)) Then
                resultado = Val(numero1) + Val(numero2)
                TextBox1.Text = resultado
            Else
                TextBox1.Text = "ERROR!"
            End If
        End If
        If (operador = "raiz") Then
            Button11.Enabled = True
            resultado = Val(numero1) ^ (1 / 2)
            TextBox1.Text = resultado
        End If
        If (operador = "cuadrado") Then
            Button11.Enabled = True
            resultado = Val(numero1) * Val(numero1)
            TextBox1.Text = resultado
        End If
    End Sub
    Private Sub ButtonMemo_Click(sender As Object, e As EventArgs) Handles ButtonMemo.Click
        Button11.Enabled = True
        memo = TextBox1.Text
        TextBox1.Clear()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button11.Enabled = True
        TextBox1.Text = memo
    End Sub
    Dim punto As Double
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "0."
        Else
            TextBox1.Text &= "."
            punto = 1
            If punto = 1 Then
                Button11.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button11.Enabled = True
        TextBox1.Text = "0"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Button11.Enabled = True
        TextBox1.Text = ""
    End Sub
End Class

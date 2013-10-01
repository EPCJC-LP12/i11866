Public Class Form1

    Private Sub calcular()
        Dim preco, consumo, distancia, res1, res2 As Double
        preco = TextBox1.Text
        consumo = TextBox2.Text
        distancia = TextBox3.Text

        res1 = consumo * distancia / 100
        res2 = res1 * preco

        TextBox4.Text = res1
        TextBox5.Text = res2


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.calcular()
    End Sub
End Class

Public Class Form1

    Private Sub soma()

        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 + num2

        TextBox3.Text = res

        Label2.Text = "+"

    End Sub

    Private Sub subtr()

        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 - num2

        TextBox3.Text = res

        Label2.Text = "-"

    End Sub

    Private Sub mult()

        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 * num2

        TextBox3.Text = res

        Label2.Text = "*"

    End Sub

    Private Sub div()

        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 / num2

        TextBox3.Text = res

        Label2.Text = "/"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.soma()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.subtr()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.mult()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.div()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class

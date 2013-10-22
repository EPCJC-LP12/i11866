Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bd02DataSet.criticas' table. You can move, or remove it, as needed.
        Me.CriticasTableAdapter.Fill(Me.Bd02DataSet.criticas)

    End Sub
End Class

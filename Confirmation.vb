Public Class Confirmation
    Public Property StringPass As String
    Private Sub Confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = StringPass
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Form1.Show()
    End Sub
End Class
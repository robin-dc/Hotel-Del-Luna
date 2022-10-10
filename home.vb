Public Class home
    Private Sub Bright_Click(sender As Object, e As EventArgs) Handles Bright.Click
        PictureBox3.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub Bleft_Click(sender As Object, e As EventArgs) Handles Bleft.Click
        PictureBox2.Visible = True
        PictureBox3.Visible = False
    End Sub
End Class
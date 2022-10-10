Public Class Form1

    Sub switchpanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Maroon
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        switchpanel(home)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Maroon
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        switchpanel(loc)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Maroon
        Button4.BackColor = Color.Transparent
        switchpanel(Topick)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Maroon
        switchpanel(contact)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class


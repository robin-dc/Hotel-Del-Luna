Public Class Morong
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TextBox1.Text = "Kai Lodge"
        Btn1.BackColor = Color.Maroon
        Btn2.BackColor = Color.Transparent
        Btn3.BackColor = Color.Transparent
        Button2.Visible = True

        Lbl1.Visible = True
        Lbl2.Visible = False
        Lbl3.Visible = False

        Pic1.Visible = True
        Pic2.Visible = False
        Pic3.Visible = False
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TextBox1.Text = "Morong Star"
        Btn1.BackColor = Color.Transparent
        Btn2.BackColor = Color.Maroon
        Btn3.BackColor = Color.Transparent
        Button2.Visible = True

        Lbl3.Visible = True
        Lbl2.Visible = False
        Lbl1.Visible = False

        Pic3.Visible = True
        Pic2.Visible = False
        Pic1.Visible = False
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TextBox1.Text = "Casa Trias"
        Btn1.BackColor = Color.Transparent
        Btn2.BackColor = Color.Transparent
        Btn3.BackColor = Color.Maroon
        Button2.Visible = True

        Lbl2.Visible = True
        Lbl3.Visible = False
        Lbl1.Visible = False

        Pic2.Visible = True
        Pic3.Visible = False
        Pic1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New Confirmation
        OBJ.StringPass = TextBox1.Text
        OBJ.Show()
        Close()
    End Sub
End Class
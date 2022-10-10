Public Class loc
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub loc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Antipolo" Then
            Antipolo.Show()
        ElseIf ComboBox1.Text = "Tanay" Then
            Tanay.Show()
        ElseIf ComboBox1.Text = "Morong" Then
            Morong.Show()
        Else
            MsgBox("404 NOT FOUND")
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
Imports Guna.UI2.WinForms
Public Class library
    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Guna2Button1.Text = "Read"
        Guna2Button2.Text = "Read"
        Guna2Button3.Text = "Read"
        Guna2Button4.Text = "Read"
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Guna2Button1.Text = "Borrow"
        Guna2Button2.Text = "Borrow"
        Guna2Button3.Text = "Borrow"
        Guna2Button4.Text = "Borrow"
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click, Guna2Button2.Click, Guna2Button3.Click, Guna2Button4.Click
        info.ShowDialog()
    End Sub
End Class
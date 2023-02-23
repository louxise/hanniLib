Public Class hanni
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        library.ShowDialog()
        Me.Close()
    End Sub

    Private Sub hanni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()

    End Sub
End Class

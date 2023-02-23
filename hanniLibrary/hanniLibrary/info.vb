Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class info
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            command.Connection = connection
            command.CommandText = "INSERT INTO borrowedbooks (full_name, address, return_date) VALUES (@full_name, @address, @return_date)"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@full_name", Guna2TextBox1.Text)
            command.Parameters.AddWithValue("@address", Guna2TextBox2.Text)
            command.Parameters.AddWithValue("@return_date", Guna2DateTimePicker1.Value)
            command.ExecuteNonQuery()
            Guna2TextBox1.Clear()
            Guna2TextBox2.Clear()
            MsgBox("Saved!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
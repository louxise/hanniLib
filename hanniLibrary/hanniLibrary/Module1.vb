Imports MySql.Data.MySqlClient

Module Module1
    Public connection As New MySqlConnection
    Public command As New MySqlCommand

    Sub openConnection()
        connection.ConnectionString = "server=localhost; username=root; password=kimminji; database=library"
        connection.Open()

    End Sub
End Module

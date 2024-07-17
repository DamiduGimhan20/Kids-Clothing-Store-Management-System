Imports MySql.Data.MySqlClient

Module DatabaseModule
    Public ConnectionString As String = "Server=localhost;Database=KidsClothingStore;Uid=root;Pwd=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module
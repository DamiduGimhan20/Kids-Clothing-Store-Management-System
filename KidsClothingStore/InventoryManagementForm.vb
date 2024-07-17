Imports MySql.Data.MySqlClient

Public Class InventoryManagementForm
    Private connectionString As String = "Server=localhost;Database=KidsClothingStore;Uid=root;Pwd=;"
    Private connection As MySqlConnection
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As DataTable

    Private Sub InventoryManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ProductID, ProductName, StockQuantity FROM Products"
            dataAdapter = New MySqlDataAdapter(query, connection)
            dataTable = New DataTable()
            dataAdapter.Fill(dataTable)

            DataGridViewProducts.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridViewProducts_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewProducts.SelectionChanged
        If DataGridViewProducts.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewProducts.SelectedRows(0)
            TextBoxProductID.Text = selectedRow.Cells("ProductID").Value.ToString()
            TextBoxProductName.Text = selectedRow.Cells("ProductName").Value.ToString()
            TextBoxStockQuantity.Text = selectedRow.Cells("StockQuantity").Value.ToString()
        End If
    End Sub

    Private Sub ButtonUpdateStock_Click(sender As Object, e As EventArgs) Handles ButtonUpdateStock.Click
        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE Products SET StockQuantity = @StockQuantity WHERE ProductID = @ProductID"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@StockQuantity", Integer.Parse(TextBoxStockQuantity.Text))
            command.Parameters.AddWithValue("@ProductID", Integer.Parse(TextBoxProductID.Text))

            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Stock updated successfully!")
                LoadProducts()
            Else
                MessageBox.Show("No rows were updated.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        LoadProducts()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainmenu As New MainMenuForm()
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class ProductManagementForm
    Private Sub ProductManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        LoadCategories()
    End Sub

    Private Sub LoadProducts()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT p.ProductID, p.ProductName, c.CategoryName, p.Price, p.StockQuantity FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvProducts.DataSource = table
        End Using
    End Sub

    Private Sub LoadCategories()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT CategoryID, CategoryName FROM Categories", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            cboCategory.DataSource = table
            cboCategory.DisplayMember = "CategoryName"
            cboCategory.ValueMember = "CategoryID"
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO Products (ProductName, CategoryID, Price, StockQuantity) VALUES (@ProductName, @CategoryID, @Price, @StockQuantity)", conn)
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            cmd.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue)
            cmd.Parameters.AddWithValue("@Price", Decimal.Parse(txtPrice.Text))
            cmd.Parameters.AddWithValue("@StockQuantity", Integer.Parse(txtStockQuantity.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product added successfully.")
            LoadProducts()
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim productId As Integer = CInt(dgvProducts.SelectedRows(0).Cells("ProductID").Value)
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE Products SET ProductName = @ProductName, CategoryID = @CategoryID, Price = @Price, StockQuantity = @StockQuantity WHERE ProductID = @ProductID", conn)
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                cmd.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue)
                cmd.Parameters.AddWithValue("@Price", Decimal.Parse(txtPrice.Text))
                cmd.Parameters.AddWithValue("@StockQuantity", Integer.Parse(txtStockQuantity.Text))
                cmd.Parameters.AddWithValue("@ProductID", productId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product updated successfully.")
                LoadProducts()
            End Using
        Else
            MessageBox.Show("Please select a product to update.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim productId As Integer = CInt(dgvProducts.SelectedRows(0).Cells("ProductID").Value)
            If MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM Products WHERE ProductID = @ProductID", conn)
                    cmd.Parameters.AddWithValue("@ProductID", productId)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product deleted successfully.")
                    LoadProducts()
                End Using
            End If
        Else
            MessageBox.Show("Please select a product to delete.")
        End If
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        If dgvProducts.SelectedRows.Count > 0 Then
            txtProductName.Text = dgvProducts.SelectedRows(0).Cells("ProductName").Value.ToString()
            cboCategory.Text = dgvProducts.SelectedRows(0).Cells("CategoryName").Value.ToString()
            txtPrice.Text = dgvProducts.SelectedRows(0).Cells("Price").Value.ToString()
            txtStockQuantity.Text = dgvProducts.SelectedRows(0).Cells("StockQuantity").Value.ToString()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainmenu As New MainMenuForm()
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class CategoryManagementForm
    Private Sub CategoryManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM Categories", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvCategories.DataSource = table

        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO Categories (CategoryName) VALUES (@CategoryName)", conn)
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Category added successfully.")
            LoadCategories()
            txtCategoryName.Clear()
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvCategories.SelectedRows.Count > 0 Then
            Dim categoryId As Integer = CInt(dgvCategories.SelectedRows(0).Cells("CategoryID").Value)
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID", conn)
                cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text)
                cmd.Parameters.AddWithValue("@CategoryID", categoryId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Category updated successfully.")
                LoadCategories()
                txtCategoryName.Clear()
            End Using
        Else
            MessageBox.Show("Please select a category to update.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCategories.SelectedRows.Count > 0 Then
            Dim categoryId As Integer = CInt(dgvCategories.SelectedRows(0).Cells("CategoryID").Value)
            If MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM Categories WHERE CategoryID = @CategoryID", conn)
                    cmd.Parameters.AddWithValue("@CategoryID", categoryId)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Category deleted successfully.")
                    LoadCategories()
                    txtCategoryName.Clear()
                End Using
            End If
        Else
            MessageBox.Show("Please select a category to delete.")
        End If
    End Sub

    Private Sub dgvCategories_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCategories.SelectionChanged
        If dgvCategories.SelectedRows.Count > 0 Then
            txtCategoryName.Text = dgvCategories.SelectedRows(0).Cells("CategoryName").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainmenu As New MainMenuForm()
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub dgvCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategories.CellContentClick

    End Sub

    Private Sub txtCategoryName_TextChanged(sender As Object, e As EventArgs) Handles txtCategoryName.TextChanged

    End Sub
End Class
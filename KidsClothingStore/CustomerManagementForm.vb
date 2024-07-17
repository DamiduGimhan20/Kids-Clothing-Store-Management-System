Imports MySql.Data.MySqlClient

Public Class CustomerManagementForm
    Private Sub CustomerManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM Customers", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvCustomers.DataSource = table
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO Customers (FirstName, LastName, Email, Phone) VALUES (@FirstName, @LastName, @Email, @Phone)", conn)
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Customer added successfully.")
            LoadCustomers()
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim customerId As Integer = CInt(dgvCustomers.SelectedRows(0).Cells("CustomerID").Value)
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone WHERE CustomerID = @CustomerID", conn)
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@CustomerID", customerId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Customer updated successfully.")
                LoadCustomers()
            End Using
        Else
            MessageBox.Show("Please select a customer to update.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim customerId As Integer = CInt(dgvCustomers.SelectedRows(0).Cells("CustomerID").Value)
            If MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", conn)
                    cmd.Parameters.AddWithValue("@CustomerID", customerId)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Customer deleted successfully.")
                    LoadCustomers()
                End Using
            End If
        Else
            MessageBox.Show("Please select a customer to delete.")
        End If
    End Sub

    Private Sub dgvCustomers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCustomers.SelectionChanged
        If dgvCustomers.SelectedRows.Count > 0 Then
            txtFirstName.Text = dgvCustomers.SelectedRows(0).Cells("FirstName").Value.ToString()
            txtLastName.Text = dgvCustomers.SelectedRows(0).Cells("LastName").Value.ToString()
            txtEmail.Text = dgvCustomers.SelectedRows(0).Cells("Email").Value.ToString()
            txtPhone.Text = dgvCustomers.SelectedRows(0).Cells("Phone").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainmenu As New MainMenuForm()
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class UserRegistration
    Private connectionString As String = "Server=localhost;Database=KidsClothingStore;Uid=root;Pwd=;"

    Private Sub UserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboRole.Items.Add("Admin")
        cboRole.Items.Add("Staff")
        cboRole.SelectedIndex = 1
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If ValidateInput() Then
            If RegisterUser() Then
                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                Dim loginForm As New LoginForm()
                loginForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Failed to register user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If cboRole.SelectedIndex = -1 Then
            MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function RegisterUser() As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@Username, @PasswordHash, @Role)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text))
                    cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem.ToString())

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function HashPassword(password As String) As String
        ' For simplicity, we're using a basic hashing method.
        ' In a real-world application, use a more secure hashing algorithm like bcrypt.
        Return Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)))
    End Function

    Private Sub ClearForm()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        cboRole.SelectedIndex = 1
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Dim userLoginForm As New LoginForm()
        userLoginForm.ShowDialog()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub
End Class
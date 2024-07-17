Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login successful!")
            Dim mainmenuForm As New MainMenuForm()
            mainmenuForm.ShowDialog()
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT PasswordHash FROM Users WHERE Username = @Username", conn)
            cmd.Parameters.AddWithValue("@Username", username)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                ' Compare hashed passwords instead of plain text
                Return CompareHashedPasswords(result.ToString(), password)
            End If
        End Using
        Return False
    End Function

    Private Function CompareHashedPasswords(storedHash As String, inputPassword As String) As Boolean
        ' Implement password comparison logic here
        ' For demonstration, we're using a simple comparison
        ' In a real application, you should use a proper password hashing and verification method
        Return storedHash = HashPassword(inputPassword)
    End Function

    Private Function HashPassword(password As String) As String
        ' Implement the same hashing method as in UserRegistration
        Return Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)))
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add any initialization code here
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        ' Add any code for username text changed event here
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        ' Open the UserRegistration form
        Dim userRegistrationForm As New UserRegistration()
        userRegistrationForm.ShowDialog()
    End Sub
End Class
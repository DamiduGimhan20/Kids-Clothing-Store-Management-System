<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Label1 = New Label()
        Label2 = New Label()
        lblRegister = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtUsername.Location = New Point(708, 130)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(191, 30)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtPassword.Location = New Point(708, 199)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(191, 30)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(59), CByte(67), CByte(214))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(778, 269)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(121, 35)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(547, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 23)
        Label1.TabIndex = 3
        Label1.Text = "UserName :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(547, 199)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 23)
        Label2.TabIndex = 4
        Label2.Text = "Password :"
        ' 
        ' lblRegister
        ' 
        lblRegister.AutoSize = True
        lblRegister.Cursor = Cursors.Hand
        lblRegister.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRegister.ForeColor = SystemColors.Highlight
        lblRegister.Location = New Point(708, 324)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(201, 16)
        lblRegister.TabIndex = 5
        lblRegister.Text = "Not a member? Register here."
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(36, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(455, 500)
        Panel1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(59), CByte(67), CByte(214))
        Label3.Location = New Point(669, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 42)
        Label3.TabIndex = 7
        Label3.Text = "Hello ! "
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(984, 511)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblRegister)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class

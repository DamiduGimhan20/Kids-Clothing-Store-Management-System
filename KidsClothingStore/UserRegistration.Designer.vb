<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRegistration))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        cboRole = New ComboBox()
        btnSubmit = New Button()
        btnCancel = New Button()
        lblLogin = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(611, 143)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 23)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(614, 188)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 23)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(532, 236)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 23)
        Label3.TabIndex = 2
        Label3.Text = "Confirm Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(663, 287)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 23)
        Label4.TabIndex = 3
        Label4.Text = "Role:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtUsername.Location = New Point(745, 140)
        txtUsername.Margin = New Padding(4, 3, 4, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(186, 30)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtPassword.Location = New Point(745, 185)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(186, 30)
        txtPassword.TabIndex = 5
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtConfirmPassword.Location = New Point(745, 233)
        txtConfirmPassword.Margin = New Padding(4, 3, 4, 3)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(186, 30)
        txtConfirmPassword.TabIndex = 6
        ' 
        ' cboRole
        ' 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        cboRole.FormattingEnabled = True
        cboRole.Location = New Point(745, 284)
        cboRole.Margin = New Padding(4, 3, 4, 3)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(186, 31)
        cboRole.TabIndex = 7
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(90), CByte(183), CByte(92))
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnSubmit.Location = New Point(622, 339)
        btnSubmit.Margin = New Padding(4, 3, 4, 3)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(145, 41)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(218), CByte(79), CByte(74))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnCancel.Location = New Point(786, 339)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(145, 41)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Cursor = Cursors.Hand
        lblLogin.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogin.ForeColor = SystemColors.Highlight
        lblLogin.Location = New Point(712, 402)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(219, 16)
        lblLogin.TabIndex = 10
        lblLogin.Text = "If You Are Member? Login Here !"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Perpetua", 27.75F, FontStyle.Bold)
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(663, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(229, 42)
        Label5.TabIndex = 11
        Label5.Text = "Register User"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Location = New Point(3, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(498, 488)
        Panel1.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Perpetua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(355, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(576, 24)
        Label6.TabIndex = 0
        Label6.Text = "Welcome! Please fill in the form below to create a new account."
        ' 
        ' UserRegistration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(984, 511)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(lblLogin)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(cboRole)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserRegistration"
        StartPosition = FormStartPosition.CenterParent
        Text = "User Registration"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
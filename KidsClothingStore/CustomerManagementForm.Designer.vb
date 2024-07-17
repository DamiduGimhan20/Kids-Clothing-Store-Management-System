<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerManagementForm
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


    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerManagementForm))
        dgvCustomers = New DataGridView()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        Panel1 = New Panel()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.BackgroundColor = SystemColors.ButtonFace
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Location = New Point(149, 88)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.Size = New Size(666, 235)
        dgvCustomers.TabIndex = 0
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtFirstName.Location = New Point(219, 48)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(200, 30)
        txtFirstName.TabIndex = 1
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtLastName.Location = New Point(219, 101)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(200, 30)
        txtLastName.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtEmail.Location = New Point(593, 48)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 30)
        txtEmail.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtPhone.Location = New Point(593, 97)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 30)
        txtPhone.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(90), CByte(183), CByte(92))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(233, 169)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(89, 41)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(250), CByte(166), CByte(50))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(372, 169)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(89, 41)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(218), CByte(79), CByte(74))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(506, 169)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(89, 41)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(64, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 23)
        Label1.TabIndex = 8
        Label1.Text = "First Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(64, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 23)
        Label2.TabIndex = 9
        Label2.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(467, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 23)
        Label3.TabIndex = 10
        Label3.Text = "Email:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(461, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 23)
        Label4.TabIndex = 11
        Label4.Text = "Phone:"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 39)
        Button1.TabIndex = 12
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(322, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(333, 42)
        Label5.TabIndex = 13
        Label5.Text = "Customer Management"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(223), CByte(240), CByte(216))
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(txtPhone)
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(txtLastName)
        Panel1.Controls.Add(txtFirstName)
        Panel1.Location = New Point(63, 351)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(854, 248)
        Panel1.TabIndex = 14
        ' 
        ' CustomerManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(984, 611)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(dgvCustomers)
        Name = "CustomerManagementForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Customer Management"
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
End Class
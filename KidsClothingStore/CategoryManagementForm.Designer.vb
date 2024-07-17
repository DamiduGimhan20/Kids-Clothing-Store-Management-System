<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryManagementForm
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


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryManagementForm))
        dgvCategories = New DataGridView()
        txtCategoryName = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        CType(dgvCategories, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvCategories
        ' 
        dgvCategories.BackgroundColor = SystemColors.ControlLightLight
        dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCategories.Location = New Point(160, 87)
        dgvCategories.Name = "dgvCategories"
        dgvCategories.Size = New Size(680, 211)
        dgvCategories.TabIndex = 0
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtCategoryName.Location = New Point(212, 38)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(200, 30)
        txtCategoryName.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(92), CByte(184), CByte(92))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(51, 109)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(107, 37)
        btnAdd.TabIndex = 2
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
        btnUpdate.Location = New Point(191, 109)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(107, 37)
        btnUpdate.TabIndex = 3
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
        btnDelete.Location = New Point(330, 109)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(107, 38)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(42, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 23)
        Label1.TabIndex = 5
        Label1.Text = "Category Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(319, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(331, 42)
        Label2.TabIndex = 6
        Label2.Text = "Category  Management"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(12, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 39)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(223), CByte(240), CByte(216))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(txtCategoryName)
        Panel1.Location = New Point(255, 327)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(502, 183)
        Panel1.TabIndex = 8
        ' 
        ' CategoryManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(984, 611)
        Controls.Add(dgvCategories)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        DoubleBuffered = True
        Name = "CategoryManagementForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Category Management"
        CType(dgvCategories, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCategories As DataGridView
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
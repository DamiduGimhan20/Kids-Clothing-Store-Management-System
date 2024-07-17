<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductManagementForm))
        dgvProducts = New DataGridView()
        txtProductName = New TextBox()
        txtPrice = New TextBox()
        txtStockQuantity = New TextBox()
        cboCategory = New ComboBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        Button1 = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvProducts
        ' 
        dgvProducts.BackgroundColor = SystemColors.ButtonFace
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(40, 74)
        dgvProducts.Margin = New Padding(4, 3, 4, 3)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.Size = New Size(905, 231)
        dgvProducts.TabIndex = 0
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtProductName.Location = New Point(277, 29)
        txtProductName.Margin = New Padding(4, 3, 4, 3)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(233, 30)
        txtProductName.TabIndex = 1
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtPrice.Location = New Point(277, 74)
        txtPrice.Margin = New Padding(4, 3, 4, 3)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(233, 30)
        txtPrice.TabIndex = 2
        ' 
        ' txtStockQuantity
        ' 
        txtStockQuantity.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtStockQuantity.Location = New Point(277, 120)
        txtStockQuantity.Margin = New Padding(4, 3, 4, 3)
        txtStockQuantity.Name = "txtStockQuantity"
        txtStockQuantity.Size = New Size(233, 30)
        txtStockQuantity.TabIndex = 3
        ' 
        ' cboCategory
        ' 
        cboCategory.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(277, 171)
        cboCategory.Margin = New Padding(4, 3, 4, 3)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(233, 31)
        cboCategory.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(90), CByte(183), CByte(92))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(145, 225)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(88, 36)
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
        btnUpdate.Location = New Point(267, 225)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(88, 36)
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
        btnDelete.Location = New Point(390, 225)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(88, 36)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(45, 29)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 23)
        Label1.TabIndex = 8
        Label1.Text = "Product Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(133, 74)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 23)
        Label2.TabIndex = 9
        Label2.Text = "Price :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(38, 120)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 23)
        Label3.TabIndex = 10
        Label3.Text = "Stock Quantity :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(94, 171)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 23)
        Label4.TabIndex = 11
        Label4.Text = "Category :"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(223), CByte(240), CByte(216))
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(txtProductName)
        Panel1.Controls.Add(cboCategory)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtStockQuantity)
        Panel1.Controls.Add(txtPrice)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(216, 322)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(558, 277)
        Panel1.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(349, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(309, 42)
        Label5.TabIndex = 13
        Label5.Text = "Product Management"
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
        Button1.TabIndex = 14
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ProductManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(984, 611)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(dgvProducts)
        Margin = New Padding(4, 3, 4, 3)
        Name = "ProductManagementForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Product Management"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStockQuantity As TextBox
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
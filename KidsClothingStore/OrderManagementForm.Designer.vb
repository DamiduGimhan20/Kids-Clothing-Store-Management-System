<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderManagementForm))
        cboCustomer = New ComboBox()
        dgvOrderItems = New DataGridView()
        cboProduct = New ComboBox()
        txtQuantity = New TextBox()
        btnAddItem = New Button()
        btnRemoveItem = New Button()
        lblTotalAmount = New Label()
        txtTotalAmount = New TextBox()
        btnSaveOrder = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        Button1 = New Button()
        CType(dgvOrderItems, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' cboCustomer
        ' 
        cboCustomer.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        cboCustomer.FormattingEnabled = True
        cboCustomer.Location = New Point(152, 33)
        cboCustomer.Name = "cboCustomer"
        cboCustomer.Size = New Size(200, 31)
        cboCustomer.TabIndex = 0
        ' 
        ' dgvOrderItems
        ' 
        dgvOrderItems.BackgroundColor = SystemColors.ButtonFace
        dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrderItems.Location = New Point(78, 92)
        dgvOrderItems.Name = "dgvOrderItems"
        dgvOrderItems.Size = New Size(839, 254)
        dgvOrderItems.TabIndex = 1
        ' 
        ' cboProduct
        ' 
        cboProduct.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        cboProduct.FormattingEnabled = True
        cboProduct.Location = New Point(152, 75)
        cboProduct.Name = "cboProduct"
        cboProduct.Size = New Size(200, 31)
        cboProduct.TabIndex = 2
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtQuantity.Location = New Point(152, 121)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(100, 30)
        txtQuantity.TabIndex = 3
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Color.FromArgb(CByte(90), CByte(183), CByte(92))
        btnAddItem.FlatAppearance.BorderSize = 0
        btnAddItem.FlatStyle = FlatStyle.Flat
        btnAddItem.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnAddItem.ForeColor = Color.White
        btnAddItem.Location = New Point(267, 121)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(85, 30)
        btnAddItem.TabIndex = 4
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveItem
        ' 
        btnRemoveItem.BackColor = Color.FromArgb(CByte(218), CByte(79), CByte(74))
        btnRemoveItem.FlatAppearance.BorderSize = 0
        btnRemoveItem.FlatStyle = FlatStyle.Flat
        btnRemoveItem.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnRemoveItem.Location = New Point(164, 101)
        btnRemoveItem.Name = "btnRemoveItem"
        btnRemoveItem.Size = New Size(105, 33)
        btnRemoveItem.TabIndex = 5
        btnRemoveItem.Text = "Remove Item"
        btnRemoveItem.UseVisualStyleBackColor = False
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        lblTotalAmount.Location = New Point(11, 54)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(147, 23)
        lblTotalAmount.TabIndex = 6
        lblTotalAmount.Text = "Total Amount:"
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        txtTotalAmount.Location = New Point(164, 54)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.Size = New Size(215, 30)
        txtTotalAmount.TabIndex = 7
        ' 
        ' btnSaveOrder
        ' 
        btnSaveOrder.BackColor = Color.FromArgb(CByte(74), CByte(175), CByte(205))
        btnSaveOrder.FlatAppearance.BorderSize = 0
        btnSaveOrder.FlatStyle = FlatStyle.Flat
        btnSaveOrder.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnSaveOrder.Location = New Point(275, 101)
        btnSaveOrder.Name = "btnSaveOrder"
        btnSaveOrder.Size = New Size(104, 33)
        btnSaveOrder.TabIndex = 8
        btnSaveOrder.Text = "Save Order"
        btnSaveOrder.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(37, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 23)
        Label1.TabIndex = 9
        Label1.Text = "Customer:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(46, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 23)
        Label2.TabIndex = 10
        Label2.Text = "Product:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(37, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 11
        Label3.Text = "Quantity:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(223), CByte(240), CByte(216))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnAddItem)
        Panel1.Controls.Add(txtQuantity)
        Panel1.Controls.Add(cboProduct)
        Panel1.Controls.Add(cboCustomer)
        Panel1.Location = New Point(78, 387)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(389, 177)
        Panel1.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(223), CByte(240), CByte(216))
        Panel2.Controls.Add(btnSaveOrder)
        Panel2.Controls.Add(txtTotalAmount)
        Panel2.Controls.Add(lblTotalAmount)
        Panel2.Controls.Add(btnRemoveItem)
        Panel2.Location = New Point(507, 384)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(410, 180)
        Panel2.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(327, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(282, 42)
        Label5.TabIndex = 14
        Label5.Text = "Order Management"
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
        Button1.TabIndex = 15
        Button1.UseVisualStyleBackColor = True
        ' 
        ' OrderManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(984, 611)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(dgvOrderItems)
        Name = "OrderManagementForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Order Management"
        CType(dgvOrderItems, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents dgvOrderItems As DataGridView
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents btnSaveOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
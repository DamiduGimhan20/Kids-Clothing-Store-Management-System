<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryManagementForm))
        DataGridViewProducts = New DataGridView()
        LabelProductID = New Label()
        LabelProductName = New Label()
        LabelStockQuantity = New Label()
        TextBoxProductID = New TextBox()
        TextBoxProductName = New TextBox()
        TextBoxStockQuantity = New TextBox()
        ButtonUpdateStock = New Button()
        ButtonRefresh = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        Label5 = New Label()
        CType(DataGridViewProducts, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridViewProducts
        ' 
        DataGridViewProducts.BackgroundColor = SystemColors.ButtonFace
        DataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProducts.Location = New Point(108, 85)
        DataGridViewProducts.Margin = New Padding(4, 3, 4, 3)
        DataGridViewProducts.Name = "DataGridViewProducts"
        DataGridViewProducts.Size = New Size(754, 251)
        DataGridViewProducts.TabIndex = 0
        ' 
        ' LabelProductID
        ' 
        LabelProductID.AutoSize = True
        LabelProductID.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        LabelProductID.Location = New Point(98, 22)
        LabelProductID.Margin = New Padding(4, 0, 4, 0)
        LabelProductID.Name = "LabelProductID"
        LabelProductID.Size = New Size(126, 23)
        LabelProductID.TabIndex = 1
        LabelProductID.Text = "Product ID :"
        ' 
        ' LabelProductName
        ' 
        LabelProductName.AutoSize = True
        LabelProductName.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        LabelProductName.Location = New Point(72, 73)
        LabelProductName.Margin = New Padding(4, 0, 4, 0)
        LabelProductName.Name = "LabelProductName"
        LabelProductName.Size = New Size(158, 23)
        LabelProductName.TabIndex = 2
        LabelProductName.Text = "Product Name :"
        ' 
        ' LabelStockQuantity
        ' 
        LabelStockQuantity.AutoSize = True
        LabelStockQuantity.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        LabelStockQuantity.Location = New Point(72, 129)
        LabelStockQuantity.Margin = New Padding(4, 0, 4, 0)
        LabelStockQuantity.Name = "LabelStockQuantity"
        LabelStockQuantity.Size = New Size(165, 23)
        LabelStockQuantity.TabIndex = 3
        LabelStockQuantity.Text = "Stock Quantity :"
        ' 
        ' TextBoxProductID
        ' 
        TextBoxProductID.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        TextBoxProductID.Location = New Point(238, 22)
        TextBoxProductID.Margin = New Padding(4, 3, 4, 3)
        TextBoxProductID.Name = "TextBoxProductID"
        TextBoxProductID.ReadOnly = True
        TextBoxProductID.Size = New Size(188, 30)
        TextBoxProductID.TabIndex = 4
        ' 
        ' TextBoxProductName
        ' 
        TextBoxProductName.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        TextBoxProductName.Location = New Point(238, 73)
        TextBoxProductName.Margin = New Padding(4, 3, 4, 3)
        TextBoxProductName.Name = "TextBoxProductName"
        TextBoxProductName.ReadOnly = True
        TextBoxProductName.Size = New Size(188, 30)
        TextBoxProductName.TabIndex = 5
        ' 
        ' TextBoxStockQuantity
        ' 
        TextBoxStockQuantity.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        TextBoxStockQuantity.Location = New Point(238, 122)
        TextBoxStockQuantity.Margin = New Padding(4, 3, 4, 3)
        TextBoxStockQuantity.Name = "TextBoxStockQuantity"
        TextBoxStockQuantity.Size = New Size(121, 30)
        TextBoxStockQuantity.TabIndex = 6
        ' 
        ' ButtonUpdateStock
        ' 
        ButtonUpdateStock.BackColor = Color.FromArgb(CByte(250), CByte(166), CByte(50))
        ButtonUpdateStock.FlatAppearance.BorderSize = 0
        ButtonUpdateStock.FlatStyle = FlatStyle.Flat
        ButtonUpdateStock.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        ButtonUpdateStock.Location = New Point(157, 184)
        ButtonUpdateStock.Margin = New Padding(4, 3, 4, 3)
        ButtonUpdateStock.Name = "ButtonUpdateStock"
        ButtonUpdateStock.Size = New Size(104, 36)
        ButtonUpdateStock.TabIndex = 7
        ButtonUpdateStock.Text = "Update Stock"
        ButtonUpdateStock.UseVisualStyleBackColor = False
        ' 
        ' ButtonRefresh
        ' 
        ButtonRefresh.BackColor = Color.FromArgb(CByte(74), CByte(175), CByte(205))
        ButtonRefresh.FlatAppearance.BorderSize = 0
        ButtonRefresh.FlatStyle = FlatStyle.Flat
        ButtonRefresh.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        ButtonRefresh.Location = New Point(281, 184)
        ButtonRefresh.Margin = New Padding(4, 3, 4, 3)
        ButtonRefresh.Name = "ButtonRefresh"
        ButtonRefresh.Size = New Size(104, 36)
        ButtonRefresh.TabIndex = 8
        ButtonRefresh.Text = "Refresh"
        ButtonRefresh.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(223), CByte(240), CByte(216))
        Panel1.Controls.Add(ButtonRefresh)
        Panel1.Controls.Add(ButtonUpdateStock)
        Panel1.Controls.Add(TextBoxStockQuantity)
        Panel1.Controls.Add(TextBoxProductName)
        Panel1.Controls.Add(TextBoxProductID)
        Panel1.Controls.Add(LabelStockQuantity)
        Panel1.Controls.Add(LabelProductName)
        Panel1.Controls.Add(LabelProductID)
        Panel1.Location = New Point(228, 353)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(524, 236)
        Panel1.TabIndex = 9
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(326, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(344, 42)
        Label5.TabIndex = 16
        Label5.Text = "Inventory  Management"
        ' 
        ' InventoryManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(984, 611)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(DataGridViewProducts)
        Margin = New Padding(4, 3, 4, 3)
        Name = "InventoryManagementForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Inventory Management"
        CType(DataGridViewProducts, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DataGridViewProducts As DataGridView
    Friend WithEvents LabelProductID As Label
    Friend WithEvents LabelProductName As Label
    Friend WithEvents LabelStockQuantity As Label
    Friend WithEvents TextBoxProductID As TextBox
    Friend WithEvents TextBoxProductName As TextBox
    Friend WithEvents TextBoxStockQuantity As TextBox
    Friend WithEvents ButtonUpdateStock As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
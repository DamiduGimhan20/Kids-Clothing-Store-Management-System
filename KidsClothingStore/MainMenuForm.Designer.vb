<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenuForm))
        btnCustomerManagement = New Button()
        btnOrderManagement = New Button()
        btnExit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnCategoryManagement = New Button()
        btnInventoryManagement = New Button()
        btnProductManagement = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCustomerManagement
        ' 
        btnCustomerManagement.BackgroundImage = CType(resources.GetObject("btnCustomerManagement.BackgroundImage"), Image)
        btnCustomerManagement.BackgroundImageLayout = ImageLayout.Stretch
        btnCustomerManagement.Cursor = Cursors.Hand
        btnCustomerManagement.FlatAppearance.BorderSize = 0
        btnCustomerManagement.FlatStyle = FlatStyle.Flat
        btnCustomerManagement.Font = New Font("Segoe UI", 12F)
        btnCustomerManagement.Location = New Point(720, 51)
        btnCustomerManagement.Name = "btnCustomerManagement"
        btnCustomerManagement.Size = New Size(81, 83)
        btnCustomerManagement.TabIndex = 1
        btnCustomerManagement.UseVisualStyleBackColor = True
        ' 
        ' btnOrderManagement
        ' 
        btnOrderManagement.BackgroundImage = CType(resources.GetObject("btnOrderManagement.BackgroundImage"), Image)
        btnOrderManagement.BackgroundImageLayout = ImageLayout.Stretch
        btnOrderManagement.Cursor = Cursors.Hand
        btnOrderManagement.FlatAppearance.BorderSize = 0
        btnOrderManagement.FlatStyle = FlatStyle.Flat
        btnOrderManagement.Font = New Font("Segoe UI", 12F)
        btnOrderManagement.Location = New Point(265, 256)
        btnOrderManagement.Name = "btnOrderManagement"
        btnOrderManagement.Size = New Size(74, 76)
        btnOrderManagement.TabIndex = 2
        btnOrderManagement.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.BackgroundImageLayout = ImageLayout.Stretch
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F)
        btnExit.Location = New Point(928, 555)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(44, 44)
        btnExit.TabIndex = 3
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(93, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(389, 41)
        Label1.TabIndex = 4
        Label1.Text = "Kids Clothing Store "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 26.25F, FontStyle.Bold)
        Label2.Location = New Point(470, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(396, 41)
        Label2.TabIndex = 5
        Label2.Text = "Management System"
        ' 
        ' btnCategoryManagement
        ' 
        btnCategoryManagement.BackgroundImage = CType(resources.GetObject("btnCategoryManagement.BackgroundImage"), Image)
        btnCategoryManagement.BackgroundImageLayout = ImageLayout.Stretch
        btnCategoryManagement.Cursor = Cursors.Hand
        btnCategoryManagement.FlatAppearance.BorderSize = 0
        btnCategoryManagement.FlatStyle = FlatStyle.Flat
        btnCategoryManagement.Font = New Font("Segoe UI", 12F)
        btnCategoryManagement.Location = New Point(417, 63)
        btnCategoryManagement.Name = "btnCategoryManagement"
        btnCategoryManagement.Size = New Size(84, 88)
        btnCategoryManagement.TabIndex = 6
        btnCategoryManagement.UseVisualStyleBackColor = True
        ' 
        ' btnInventoryManagement
        ' 
        btnInventoryManagement.BackgroundImage = CType(resources.GetObject("btnInventoryManagement.BackgroundImage"), Image)
        btnInventoryManagement.BackgroundImageLayout = ImageLayout.Stretch
        btnInventoryManagement.Cursor = Cursors.Hand
        btnInventoryManagement.FlatAppearance.BorderSize = 0
        btnInventoryManagement.FlatStyle = FlatStyle.Flat
        btnInventoryManagement.Font = New Font("Segoe UI", 12F)
        btnInventoryManagement.Location = New Point(585, 256)
        btnInventoryManagement.Name = "btnInventoryManagement"
        btnInventoryManagement.Size = New Size(76, 77)
        btnInventoryManagement.TabIndex = 7
        btnInventoryManagement.UseVisualStyleBackColor = True
        ' 
        ' btnProductManagement
        ' 
        btnProductManagement.BackColor = Color.Transparent
        btnProductManagement.BackgroundImage = CType(resources.GetObject("btnProductManagement.BackgroundImage"), Image)
        btnProductManagement.BackgroundImageLayout = ImageLayout.Stretch
        btnProductManagement.FlatAppearance.BorderSize = 0
        btnProductManagement.FlatStyle = FlatStyle.Flat
        btnProductManagement.Font = New Font("Segoe UI", 12F)
        btnProductManagement.Location = New Point(86, 51)
        btnProductManagement.Name = "btnProductManagement"
        btnProductManagement.Size = New Size(100, 100)
        btnProductManagement.TabIndex = 0
        btnProductManagement.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(61, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 21)
        Label3.TabIndex = 1
        Label3.Text = "Product Management"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(229, 352)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 21)
        Label4.TabIndex = 8
        Label4.Text = "Order Management"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(548, 352)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 21)
        Label5.TabIndex = 9
        Label5.Text = "Inventory Management"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(682, 148)
        Label6.Name = "Label6"
        Label6.Size = New Size(171, 21)
        Label6.TabIndex = 10
        Label6.Text = "Customer Management"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(381, 154)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 21)
        Label7.TabIndex = 11
        Label7.Text = "Category Management"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnProductManagement)
        Panel1.Controls.Add(btnInventoryManagement)
        Panel1.Controls.Add(btnCategoryManagement)
        Panel1.Controls.Add(btnOrderManagement)
        Panel1.Controls.Add(btnCustomerManagement)
        Panel1.Location = New Point(31, 129)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(908, 411)
        Panel1.TabIndex = 12
        ' 
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(984, 611)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Name = "MainMenuForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Menu"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnCustomerManagement As Button
    Friend WithEvents btnOrderManagement As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCategoryManagement As Button
    Friend WithEvents btnInventoryManagement As Button
    Friend WithEvents btnProductManagement As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
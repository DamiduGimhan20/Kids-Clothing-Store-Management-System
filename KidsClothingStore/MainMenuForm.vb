Public Class MainMenuForm
    Private Sub btnProductManagement_Click(sender As Object, e As EventArgs) Handles btnProductManagement.Click
        Dim productForm As New ProductManagementForm()
        productForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnCustomerManagement_Click(sender As Object, e As EventArgs) Handles btnCustomerManagement.Click
        Dim customerForm As New CustomerManagementForm
        customerForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnOrderManagement_Click(sender As Object, e As EventArgs) Handles btnOrderManagement.Click
        Dim orderForm As New OrderManagementForm()
        orderForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCategoryManagement_Click(sender As Object, e As EventArgs) Handles btnCategoryManagement.Click
        Dim categoryForm As New CategoryManagementForm
        categoryForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnInventoryManagement_Click(sender As Object, e As EventArgs) Handles btnInventoryManagement.Click
        Dim inventoryForm As New InventoryManagementForm
        inventoryForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
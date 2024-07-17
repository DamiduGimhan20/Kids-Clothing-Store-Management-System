Imports MySql.Data.MySqlClient

Public Class OrderManagementForm
    Private orderItems As New DataTable()

    Private Sub OrderManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
        LoadProducts()
        SetupOrderItemsTable()
    End Sub

    Private Sub LoadCustomers()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT CustomerID, CONCAT(FirstName, ' ', LastName) AS CustomerName FROM Customers", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            cboCustomer.DataSource = table
            cboCustomer.DisplayMember = "CustomerName"
            cboCustomer.ValueMember = "CustomerID"
        End Using
    End Sub

    Private Sub LoadProducts()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT ProductID, ProductName, Price FROM Products", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            cboProduct.DataSource = table
            cboProduct.DisplayMember = "ProductName"
            cboProduct.ValueMember = "ProductID"
        End Using
    End Sub

    Private Sub SetupOrderItemsTable()
        orderItems.Columns.Add("ProductID", GetType(Integer))
        orderItems.Columns.Add("ProductName", GetType(String))
        orderItems.Columns.Add("Quantity", GetType(Integer))
        orderItems.Columns.Add("UnitPrice", GetType(Decimal))
        orderItems.Columns.Add("TotalPrice", GetType(Decimal))
        dgvOrderItems.DataSource = orderItems
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim productId As Integer = CInt(cboProduct.SelectedValue)
        Dim productName As String = cboProduct.Text
        Dim quantity As Integer = CInt(txtQuantity.Text)
        Dim unitPrice As Decimal = CDec(CType(cboProduct.SelectedItem, DataRowView)("Price"))
        Dim totalPrice As Decimal = quantity * unitPrice

        orderItems.Rows.Add(productId, productName, quantity, unitPrice, totalPrice)
        CalculateTotalAmount()
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If dgvOrderItems.SelectedRows.Count > 0 Then
            dgvOrderItems.Rows.RemoveAt(dgvOrderItems.SelectedRows(0).Index)
            CalculateTotalAmount()
        End If
    End Sub

    Private Sub CalculateTotalAmount()
        Dim total As Decimal = 0
        For Each row As DataRow In orderItems.Rows
            total += CDec(row("TotalPrice"))
        Next
        txtTotalAmount.Text = total.ToString("C")
    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                ' Insert into Orders table
                Dim cmdOrder As New MySqlCommand("INSERT INTO Orders (CustomerID, OrderDate, TotalAmount) VALUES (@CustomerID, @OrderDate, @TotalAmount); SELECT LAST_INSERT_ID();", conn, transaction)
                cmdOrder.Parameters.AddWithValue("@CustomerID", cboCustomer.SelectedValue)
                cmdOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now)
                cmdOrder.Parameters.AddWithValue("@TotalAmount", Decimal.Parse(txtTotalAmount.Text.TrimStart("$"c)))
                Dim orderId As Integer = Convert.ToInt32(cmdOrder.ExecuteScalar())

                ' Insert into OrderDetails table
                For Each row As DataRow In orderItems.Rows
                    Dim cmdDetail As New MySqlCommand("INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) VALUES (@OrderID, @ProductID, @Quantity, @UnitPrice)", conn, transaction)
                    cmdDetail.Parameters.AddWithValue("@OrderID", orderId)
                    cmdDetail.Parameters.AddWithValue("@ProductID", row("ProductID"))
                    cmdDetail.Parameters.AddWithValue("@Quantity", row("Quantity"))
                    cmdDetail.Parameters.AddWithValue("@UnitPrice", row("UnitPrice"))
                    cmdDetail.ExecuteNonQuery()
                Next

                transaction.Commit()
                MessageBox.Show("Order saved successfully.")
                ClearForm()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error saving order: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ClearForm()
        cboCustomer.SelectedIndex = -1
        orderItems.Rows.Clear()
        txtTotalAmount.Text = ""
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomer.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainmenu As New MainMenuForm()
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class
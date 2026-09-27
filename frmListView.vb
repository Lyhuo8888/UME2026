Imports System.Runtime.CompilerServices

Public Class frmListView
    Private Sub frmListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("ProductID", 100)
        ListView1.Columns.Add("ProductName", 100)
        ListView1.Columns.Add("Quantity", 100)
        ListView1.Columns.Add("Price", 100)
        ListView1.Columns.Add("Total", 100)
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim total As Integer
        Static amount As Integer = 0
        Dim lstItem As ListViewItem

        lstItem = ListView1.Items.Add(txtProductID.Text)
        lstItem.SubItems.Add(txtProductName.Text)
        lstItem.SubItems.Add(txtQuantity.Text)
        lstItem.SubItems.Add(txtPrice.Text)
        total = txtQuantity.Text * txtPrice.Text
        lstItem.SubItems.Add(Format(total, "#,##0.00"))
        amount += total
        lblAmount.Text = "Amount: " + Format(amount, "#,##0.00")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtProductID.Text = ListView1.SelectedItems(0).Text
            txtProductName.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtQuantity.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtPrice.Text = ListView1.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        On Error Resume Next
        If ListView1.SelectedIndices.Count = 0 Then
            MessageBox.Show("Please select record to Edit.")
        End If
        ListView1.SelectedItems(0).Text = txtProductID.Text
        ListView1.SelectedItems(0).SubItems(1).Text = txtProductName.Text
        ListView1.SelectedItems(0).SubItems(2).Text = txtQuantity.Text
        ListView1.SelectedItems(0).SubItems(3).Text = txtPrice.Text
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'MessageBox.Show(ListView1.SelectedIndices(0))
        'MessageBox.Show(ListView1.SelectedIndices.Count)

        If ListView1.SelectedIndices.Count > 0 Then
            Dim i As Integer = ListView1.SelectedIndices(0)
            ListView1.Items.RemoveAt(i)
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtProductID.Clear()
        txtProductName.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
    End Sub
End Class
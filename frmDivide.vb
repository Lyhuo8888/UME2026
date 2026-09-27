Public Class frmDivide
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim val1, val2, result As Integer
        val1 = txtValue1.Text
        val2 = txtValue2.Text
        If (val2 = 0) Then
            MessageBox.Show("Cannot divide a number by zero.")
        ElseIf val2 <> 0 Then
            result = val1 / val2
            txtResult.Text = result
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
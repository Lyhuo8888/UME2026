Public Class Form1
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        txtResult.Text = CDbl(txtValue1.Text) + CDbl(txtValue2.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue1.Clear()
        txtValue2.Clear()
        txtResult.Clear()
        txtValue1.Focus()
    End Sub
End Class

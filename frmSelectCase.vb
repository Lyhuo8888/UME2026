Public Class frmSelectCase
    Private Sub btnMention_Click(sender As Object, e As EventArgs) Handles btnMention.Click
        Dim average As Integer
        average = Val(txtAverage.Text)
        Select Case average
            Case Is > 100
                txtMention.Text = "Invalid"
            Case 95 To 100
                txtMention.Text = "Excellent"
            Case Is >= 85
                txtMention.Text = "Very Good"
            Case 75 To 84
                txtMention.Text = "Good"
            Case Is >= 65
                txtMention.Text = "Fair"
            Case Is >= 50
                txtMention.Text = "Medium"
            Case Else
                txtMention.Text = "Weak"
        End Select
    End Sub
End Class
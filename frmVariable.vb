Public Class frmVariable
    Private Sub frmVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMassage_Click(sender As Object, e As EventArgs) Handles btnMassage.Click
        Dim intMaryAge As Integer
        Dim strMaryName As String = "Mary"
        Dim x As Integer, y As String

        intMaryAge = 18
        MessageBox.Show("Hi, my name is " & strMaryName &
                        " and my age is " & intMaryAge)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim num1, num2, result As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        result = num1 + num2
        txtResult.Text = result
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim num1, num2, result As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        result = num1 - num2
        txtResult.Text = result
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim num1, num2, result As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        result = num1 * num2
        txtResult.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2, result As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        result = num1 / num2
        txtResult.Text = result
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtNum1.Text = ""
        txtNum2.Clear()
        txtResult.Clear()
        txtNum1.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
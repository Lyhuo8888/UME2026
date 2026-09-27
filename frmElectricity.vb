Public Class frmElectricity
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim oldNum, newNum, totalNum, payment As Integer
        oldNum = Val(txtOldNumber.Text)
        newNum = Val(txtNewNumber.Text)
        totalNum = newNum - oldNum
        If totalNum < 0 Then
            MessageBox.Show("New number must grater than old number.")
        Else
            If totalNum < 50 Then
                payment = totalNum * 500
            Else
                payment = totalNum * 400
            End If
            txtToltal.Text = totalNum & " Kilowat"
            txtPayment.Text = Format(payment, "#,##0.00Riel")
        End If
    End Sub

    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click

        'Dim x As Integer = 15
        'Select Case x
        '    Case 10
        '        MsgBox("x Value is 10")
        '    Case 15
        '        MsgBox("x Value is 15")
        '    Case 20
        '        MsgBox("x Value is 20")
        '    Case Else
        '        MsgBox("Not known")
        'End Select


        'Dim gender As Integer = 1
        'Select Case gender
        '    Case 0
        '        MsgBox("Male")
        '    Case 1
        '        MsgBox("Female")
        'End Select


        Dim numOfDay As Integer = 2
        Select Case numOfDay
            Case 1
                MsgBox("Monday")
            Case 2
                MsgBox("Tuesday")
            Case 3
                MsgBox("Wednesday")
        End Select
    End Sub
End Class
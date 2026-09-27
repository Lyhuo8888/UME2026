Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim correctUser As String = "Admin"
        Dim correctPass As String = "admin@123"

        Dim inputUser As String
        Dim inputPass As String
        inputUser = txtUserName.Text
        inputPass = txtPassword.Text

        If inputUser = correctUser And inputPass = correctPass Then
            MessageBox.Show("Login Successfully!")
        Else
            MessageBox.Show("Incorrect Username or Password!")
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
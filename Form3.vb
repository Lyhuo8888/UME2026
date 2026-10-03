Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim correctUser As String = "Admin"
        Dim correctPass As String = "admin@123"

        Dim inputUser As String
        Dim inputPass As String
        inputUser = txtUserName.Text
        inputPass = txtPassword.Text

        Static i As Byte

        If Trim(inputUser.ToUpper) = Trim(correctUser.ToUpper) And inputPass = correctPass Then
            MessageBox.Show("Login Successfully!")
            txtUserName.Clear()
            txtPassword.Clear()
            Dim frmMain As New frmMainForm
            frmMain.Show()
            Me.Hide()
            i = 0
        Else
            i += 1
            MessageBox.Show("Incorrect Username or Password!" & vbCrLf & "Attempts remaining: " & (3 - i))
        End If

        If i = 3 Then
            Application.Exit()
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtUserName.Clear()
        'txtPassword.Clear()
    End Sub
End Class
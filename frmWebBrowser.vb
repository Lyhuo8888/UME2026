Public Class frmWebBrowser
    Private Async Sub frmWebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Sub

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim strWeb As String
        strWeb = txtWeb.Text
        WebView21.CoreWebView2.Navigate("https://www." + strWeb + ".com/")
    End Sub
End Class
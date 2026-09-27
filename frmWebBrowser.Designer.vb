<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        btnClick = New Button()
        txtWeb = New TextBox()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(12, 74)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(1185, 456)
        WebView21.TabIndex = 0
        WebView21.ZoomFactor = 1R
        ' 
        ' btnClick
        ' 
        btnClick.Location = New Point(146, 12)
        btnClick.Name = "btnClick"
        btnClick.Size = New Size(145, 56)
        btnClick.TabIndex = 1
        btnClick.Text = "Click"
        btnClick.UseVisualStyleBackColor = True
        ' 
        ' txtWeb
        ' 
        txtWeb.Location = New Point(312, 27)
        txtWeb.Name = "txtWeb"
        txtWeb.Size = New Size(470, 27)
        txtWeb.TabIndex = 2
        ' 
        ' frmWebBrowser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1209, 542)
        Controls.Add(txtWeb)
        Controls.Add(btnClick)
        Controls.Add(WebView21)
        Name = "frmWebBrowser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmWebBrowser"
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents btnClick As Button
    Friend WithEvents txtWeb As TextBox
End Class

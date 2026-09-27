<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Label1 = New Label()
        txtUserName = New TextBox()
        txtPassword = New TextBox()
        Label2 = New Label()
        btnLogin = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 27)
        Label1.TabIndex = 0
        Label1.Text = "User Name:"
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(199, 61)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(256, 34)
        txtUserName.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(199, 121)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(256, 34)
        txtPassword.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 27)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' btnLogin
        ' 
        btnLogin.ForeColor = Color.Navy
        btnLogin.Location = New Point(199, 179)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(125, 43)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.ForeColor = Color.Navy
        btnExit.Location = New Point(330, 179)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(125, 43)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(12F, 27F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(527, 272)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtUserName)
        Controls.Add(Label1)
        Font = New Font("Palatino Linotype", 12F)
        ForeColor = Color.White
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
End Class

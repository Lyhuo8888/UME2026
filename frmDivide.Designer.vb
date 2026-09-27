<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDivide
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
        Label1 = New Label()
        txtValue1 = New TextBox()
        Label2 = New Label()
        txtValue2 = New TextBox()
        Label3 = New Label()
        txtResult = New TextBox()
        btnDivide = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 0
        Label1.Text = "Value 1:"
        ' 
        ' txtValue1
        ' 
        txtValue1.Location = New Point(114, 44)
        txtValue1.Name = "txtValue1"
        txtValue1.Size = New Size(164, 27)
        txtValue1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 2
        Label2.Text = "Value 2:"
        ' 
        ' txtValue2
        ' 
        txtValue2.Location = New Point(114, 104)
        txtValue2.Name = "txtValue2"
        txtValue2.Size = New Size(164, 27)
        txtValue2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 4
        Label3.Text = "Result: "
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(114, 160)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(164, 27)
        txtResult.TabIndex = 5
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(32, 219)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(94, 29)
        btnDivide.TabIndex = 6
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(184, 219)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmDivide
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(334, 292)
        Controls.Add(btnExit)
        Controls.Add(btnDivide)
        Controls.Add(txtResult)
        Controls.Add(Label3)
        Controls.Add(txtValue2)
        Controls.Add(Label2)
        Controls.Add(txtValue1)
        Controls.Add(Label1)
        Name = "frmDivide"
        Text = "frmDivide"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValue1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnExit As Button
End Class

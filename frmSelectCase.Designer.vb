<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectCase
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
        txtAverage = New TextBox()
        txtMention = New TextBox()
        Label2 = New Label()
        btnMention = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 0
        Label1.Text = "Average:"
        ' 
        ' txtAverage
        ' 
        txtAverage.Location = New Point(187, 43)
        txtAverage.Name = "txtAverage"
        txtAverage.Size = New Size(221, 27)
        txtAverage.TabIndex = 1
        ' 
        ' txtMention
        ' 
        txtMention.Location = New Point(187, 76)
        txtMention.Name = "txtMention"
        txtMention.Size = New Size(221, 27)
        txtMention.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(85, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 2
        Label2.Text = "Mention:"
        ' 
        ' btnMention
        ' 
        btnMention.Location = New Point(187, 125)
        btnMention.Name = "btnMention"
        btnMention.Size = New Size(221, 50)
        btnMention.TabIndex = 4
        btnMention.Text = "Mention"
        btnMention.UseVisualStyleBackColor = True
        ' 
        ' frmSelectCase
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(520, 220)
        Controls.Add(btnMention)
        Controls.Add(txtMention)
        Controls.Add(Label2)
        Controls.Add(txtAverage)
        Controls.Add(Label1)
        Name = "frmSelectCase"
        Text = "frmSelectCase"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents txtMention As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMention As Button
End Class

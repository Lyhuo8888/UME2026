<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoops
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
        btnWhileLoop = New Button()
        txtWhileLoop = New TextBox()
        txtDoWhileLoop = New TextBox()
        btnDoWhileLoop = New Button()
        txtDoLoop = New TextBox()
        btnDoLoop = New Button()
        txtDoUntilLoop = New TextBox()
        btnDoUntilLoop = New Button()
        txtForNextLoop = New TextBox()
        btnForNextLoop = New Button()
        SuspendLayout()
        ' 
        ' btnWhileLoop
        ' 
        btnWhileLoop.Location = New Point(12, 12)
        btnWhileLoop.Name = "btnWhileLoop"
        btnWhileLoop.Size = New Size(203, 75)
        btnWhileLoop.TabIndex = 0
        btnWhileLoop.Text = "While Loop"
        btnWhileLoop.UseVisualStyleBackColor = True
        ' 
        ' txtWhileLoop
        ' 
        txtWhileLoop.Location = New Point(12, 93)
        txtWhileLoop.Multiline = True
        txtWhileLoop.Name = "txtWhileLoop"
        txtWhileLoop.Size = New Size(203, 414)
        txtWhileLoop.TabIndex = 1
        ' 
        ' txtDoWhileLoop
        ' 
        txtDoWhileLoop.Location = New Point(221, 93)
        txtDoWhileLoop.Multiline = True
        txtDoWhileLoop.Name = "txtDoWhileLoop"
        txtDoWhileLoop.Size = New Size(203, 414)
        txtDoWhileLoop.TabIndex = 3
        ' 
        ' btnDoWhileLoop
        ' 
        btnDoWhileLoop.Location = New Point(221, 12)
        btnDoWhileLoop.Name = "btnDoWhileLoop"
        btnDoWhileLoop.Size = New Size(203, 75)
        btnDoWhileLoop.TabIndex = 2
        btnDoWhileLoop.Text = "Do While Loop"
        btnDoWhileLoop.UseVisualStyleBackColor = True
        ' 
        ' txtDoLoop
        ' 
        txtDoLoop.Location = New Point(430, 93)
        txtDoLoop.Multiline = True
        txtDoLoop.Name = "txtDoLoop"
        txtDoLoop.Size = New Size(203, 414)
        txtDoLoop.TabIndex = 5
        ' 
        ' btnDoLoop
        ' 
        btnDoLoop.Location = New Point(430, 12)
        btnDoLoop.Name = "btnDoLoop"
        btnDoLoop.Size = New Size(203, 75)
        btnDoLoop.TabIndex = 4
        btnDoLoop.Text = "Do Loop"
        btnDoLoop.UseVisualStyleBackColor = True
        ' 
        ' txtDoUntilLoop
        ' 
        txtDoUntilLoop.Location = New Point(639, 93)
        txtDoUntilLoop.Multiline = True
        txtDoUntilLoop.Name = "txtDoUntilLoop"
        txtDoUntilLoop.Size = New Size(203, 414)
        txtDoUntilLoop.TabIndex = 7
        ' 
        ' btnDoUntilLoop
        ' 
        btnDoUntilLoop.Location = New Point(639, 12)
        btnDoUntilLoop.Name = "btnDoUntilLoop"
        btnDoUntilLoop.Size = New Size(203, 75)
        btnDoUntilLoop.TabIndex = 6
        btnDoUntilLoop.Text = "Do Until Loop"
        btnDoUntilLoop.UseVisualStyleBackColor = True
        ' 
        ' txtForNextLoop
        ' 
        txtForNextLoop.Location = New Point(848, 93)
        txtForNextLoop.Multiline = True
        txtForNextLoop.Name = "txtForNextLoop"
        txtForNextLoop.Size = New Size(203, 414)
        txtForNextLoop.TabIndex = 9
        ' 
        ' btnForNextLoop
        ' 
        btnForNextLoop.Location = New Point(848, 12)
        btnForNextLoop.Name = "btnForNextLoop"
        btnForNextLoop.Size = New Size(203, 75)
        btnForNextLoop.TabIndex = 8
        btnForNextLoop.Text = "For Next Loop"
        btnForNextLoop.UseVisualStyleBackColor = True
        ' 
        ' frmLoops
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1066, 519)
        Controls.Add(txtForNextLoop)
        Controls.Add(btnForNextLoop)
        Controls.Add(txtDoUntilLoop)
        Controls.Add(btnDoUntilLoop)
        Controls.Add(txtDoLoop)
        Controls.Add(btnDoLoop)
        Controls.Add(txtDoWhileLoop)
        Controls.Add(btnDoWhileLoop)
        Controls.Add(txtWhileLoop)
        Controls.Add(btnWhileLoop)
        Name = "frmLoops"
        Text = "frmLoops"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnWhileLoop As Button
    Friend WithEvents txtWhileLoop As TextBox
    Friend WithEvents txtDoWhileLoop As TextBox
    Friend WithEvents btnDoWhileLoop As Button
    Friend WithEvents txtDoLoop As TextBox
    Friend WithEvents btnDoLoop As Button
    Friend WithEvents txtDoUntilLoop As TextBox
    Friend WithEvents btnDoUntilLoop As Button
    Friend WithEvents txtForNextLoop As TextBox
    Friend WithEvents btnForNextLoop As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtValue2 = New TextBox()
        Label3 = New Label()
        btnSum = New Button()
        btnClear = New Button()
        txtResult = New TextBox()
        Label4 = New Label()
        txtValue1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 24F, FontStyle.Bold)
        Label1.Location = New Point(158, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(469, 55)
        Label1.TabIndex = 0
        Label1.Text = "My First VB Application"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 18F)
        Label2.Location = New Point(172, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 41)
        Label2.TabIndex = 1
        Label2.Text = "Value 1"
        ' 
        ' txtValue2
        ' 
        txtValue2.Font = New Font("Palatino Linotype", 18F)
        txtValue2.Location = New Point(318, 195)
        txtValue2.Name = "txtValue2"
        txtValue2.Size = New Size(285, 48)
        txtValue2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 18F)
        Label3.Location = New Point(172, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 41)
        Label3.TabIndex = 3
        Label3.Text = "Value 2"
        ' 
        ' btnSum
        ' 
        btnSum.Font = New Font("Palatino Linotype", 18F)
        btnSum.Location = New Point(329, 322)
        btnSum.Name = "btnSum"
        btnSum.Size = New Size(131, 63)
        btnSum.TabIndex = 5
        btnSum.Text = "+"
        btnSum.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Palatino Linotype", 18F)
        btnClear.Location = New Point(483, 322)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(131, 63)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.Font = New Font("Palatino Linotype", 18F)
        txtResult.Location = New Point(318, 259)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(285, 48)
        txtResult.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Palatino Linotype", 18F)
        Label4.Location = New Point(172, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 41)
        Label4.TabIndex = 6
        Label4.Text = "Result"
        ' 
        ' txtValue1
        ' 
        txtValue1.Font = New Font("Palatino Linotype", 18F)
        txtValue1.Location = New Point(318, 132)
        txtValue1.Name = "txtValue1"
        txtValue1.Size = New Size(285, 48)
        txtValue1.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtValue1)
        Controls.Add(txtResult)
        Controls.Add(Label4)
        Controls.Add(btnClear)
        Controls.Add(btnSum)
        Controls.Add(txtValue2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSum As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValue1 As TextBox

End Class

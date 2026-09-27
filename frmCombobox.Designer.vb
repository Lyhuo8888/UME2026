<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombobox
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
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(247, 61)
        ComboBox1.Margin = New Padding(4, 4, 4, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(224, 35)
        ComboBox1.TabIndex = 0
        ' 
        ' frmCombobox
        ' 
        AutoScaleDimensions = New SizeF(12F, 27F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(818, 371)
        Controls.Add(ComboBox1)
        Font = New Font("Palatino Linotype", 12F)
        Margin = New Padding(4, 4, 4, 4)
        Name = "frmCombobox"
        Text = "frmCombobox"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
End Class

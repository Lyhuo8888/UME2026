<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeekDay
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
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        ComboBox2 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(93, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 27)
        Label1.TabIndex = 0
        Label1.Text = "WeekDays"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(93, 93)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(399, 35)
        ComboBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(93, 170)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 27)
        Label2.TabIndex = 2
        Label2.Text = "Year"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(93, 215)
        ComboBox2.Margin = New Padding(4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(399, 35)
        ComboBox2.TabIndex = 3
        ' 
        ' frmWeekDay
        ' 
        AutoScaleDimensions = New SizeF(12F, 27F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(635, 359)
        Controls.Add(ComboBox2)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Font = New Font("Palatino Linotype", 12F)
        ForeColor = Color.Navy
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(4)
        Name = "frmWeekDay"
        Text = "Form WeekDay"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
End Class

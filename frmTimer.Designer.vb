<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimer
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        lblTime = New Label()
        Timer1 = New Timer(components)
        Label3 = New Label()
        lblStart = New Label()
        LabelDuration = New Label()
        lblEnd = New Label()
        Label6 = New Label()
        lblDuration = New Label()
        btnStart = New Button()
        btnStop = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 24F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Location = New Point(164, 26)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(360, 55)
        Label1.TabIndex = 0
        Label1.Text = "Timer Application"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 14F, FontStyle.Bold)
        Label2.Location = New Point(382, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 32)
        Label2.TabIndex = 1
        Label2.Text = "Time:"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Location = New Point(464, 112)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(136, 32)
        lblTime.TabIndex = 2
        lblTime.Text = "Label_Time"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 14F, FontStyle.Bold)
        Label3.Location = New Point(92, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 32)
        Label3.TabIndex = 3
        Label3.Text = "Start Time:"
        ' 
        ' lblStart
        ' 
        lblStart.AutoSize = True
        lblStart.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblStart.Location = New Point(255, 173)
        lblStart.Name = "lblStart"
        lblStart.Size = New Size(198, 32)
        lblStart.TabIndex = 4
        lblStart.Text = "Label_Start_Time"
        ' 
        ' LabelDuration
        ' 
        LabelDuration.AutoSize = True
        LabelDuration.Font = New Font("Palatino Linotype", 14F, FontStyle.Bold)
        LabelDuration.Location = New Point(107, 220)
        LabelDuration.Name = "LabelDuration"
        LabelDuration.Size = New Size(119, 32)
        LabelDuration.TabIndex = 5
        LabelDuration.Text = "Duration:"
        ' 
        ' lblEnd
        ' 
        lblEnd.AutoSize = True
        lblEnd.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblEnd.Location = New Point(255, 274)
        lblEnd.Name = "lblEnd"
        lblEnd.Size = New Size(191, 32)
        lblEnd.TabIndex = 8
        lblEnd.Text = "Label_End_Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Palatino Linotype", 14F, FontStyle.Bold)
        Label6.Location = New Point(100, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 32)
        Label6.TabIndex = 7
        Label6.Text = "End Time:"
        ' 
        ' lblDuration
        ' 
        lblDuration.AutoSize = True
        lblDuration.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblDuration.Location = New Point(255, 220)
        lblDuration.Name = "lblDuration"
        lblDuration.Size = New Size(179, 32)
        lblDuration.TabIndex = 9
        lblDuration.Text = "Label_Duration"
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnStart.ForeColor = SystemColors.ControlLightLight
        btnStart.Location = New Point(133, 334)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(119, 58)
        btnStart.TabIndex = 10
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnStop
        ' 
        btnStop.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnStop.ForeColor = SystemColors.ControlLightLight
        btnStop.Location = New Point(339, 334)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(119, 58)
        btnStop.TabIndex = 11
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = False
        ' 
        ' frmTimer
        ' 
        AutoScaleDimensions = New SizeF(14F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(690, 435)
        Controls.Add(btnStop)
        Controls.Add(btnStart)
        Controls.Add(lblDuration)
        Controls.Add(lblEnd)
        Controls.Add(Label6)
        Controls.Add(LabelDuration)
        Controls.Add(lblStart)
        Controls.Add(Label3)
        Controls.Add(lblTime)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Palatino Linotype", 14F)
        Margin = New Padding(5)
        Name = "frmTimer"
        Text = "frmTimer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelDuration As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
End Class

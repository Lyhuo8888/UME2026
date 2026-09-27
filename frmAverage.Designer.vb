<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverage
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
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        btnAnswer = New Button()
        txtAverage = New TextBox()
        Label7 = New Label()
        txtTotalScore = New TextBox()
        Label6 = New Label()
        txtISA = New TextBox()
        Label5 = New Label()
        txtLinux = New TextBox()
        Label4 = New Label()
        txtOOP = New TextBox()
        Label3 = New Label()
        txtDBMS = New TextBox()
        Label2 = New Label()
        txtNetwork = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(btnAnswer)
        GroupBox1.Controls.Add(txtAverage)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtTotalScore)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtISA)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtLinux)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtOOP)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtDBMS)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtNetwork)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(535, 388)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(271, 301)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 15
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnAnswer
        ' 
        btnAnswer.Location = New Point(143, 301)
        btnAnswer.Name = "btnAnswer"
        btnAnswer.Size = New Size(94, 29)
        btnAnswer.TabIndex = 14
        btnAnswer.Text = "Answer"
        btnAnswer.UseVisualStyleBackColor = True
        ' 
        ' txtAverage
        ' 
        txtAverage.BackColor = SystemColors.Info
        txtAverage.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        txtAverage.Location = New Point(280, 243)
        txtAverage.Name = "txtAverage"
        txtAverage.Size = New Size(152, 27)
        txtAverage.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(315, 220)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 20)
        Label7.TabIndex = 12
        Label7.Text = "Average"
        ' 
        ' txtTotalScore
        ' 
        txtTotalScore.BackColor = SystemColors.Info
        txtTotalScore.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        txtTotalScore.Location = New Point(76, 243)
        txtTotalScore.Name = "txtTotalScore"
        txtTotalScore.Size = New Size(149, 27)
        txtTotalScore.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(99, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 10
        Label6.Text = "Total Score"
        ' 
        ' txtISA
        ' 
        txtISA.Location = New Point(188, 172)
        txtISA.Name = "txtISA"
        txtISA.Size = New Size(244, 27)
        txtISA.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(151, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 20)
        Label5.TabIndex = 8
        Label5.Text = "ISA"
        ' 
        ' txtLinux
        ' 
        txtLinux.Location = New Point(188, 139)
        txtLinux.Name = "txtLinux"
        txtLinux.Size = New Size(244, 27)
        txtLinux.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(139, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 6
        Label4.Text = "Linux"
        ' 
        ' txtOOP
        ' 
        txtOOP.Location = New Point(188, 106)
        txtOOP.Name = "txtOOP"
        txtOOP.Size = New Size(244, 27)
        txtOOP.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(143, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 4
        Label3.Text = "OOP"
        ' 
        ' txtDBMS
        ' 
        txtDBMS.Location = New Point(188, 73)
        txtDBMS.Name = "txtDBMS"
        txtDBMS.Size = New Size(244, 27)
        txtDBMS.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(132, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 2
        Label2.Text = "DBMS"
        ' 
        ' txtNetwork
        ' 
        txtNetwork.Location = New Point(188, 40)
        txtNetwork.Name = "txtNetwork"
        txtNetwork.Size = New Size(244, 27)
        txtNetwork.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(117, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 20)
        Label1.TabIndex = 0
        Label1.Text = "Network"
        ' 
        ' frmAverage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(569, 420)
        Controls.Add(GroupBox1)
        Name = "frmAverage"
        Text = "frmAverage"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNetwork As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOOP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDBMS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLinux As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtISA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalScore As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAnswer As Button
    Friend WithEvents Button1 As Button
End Class

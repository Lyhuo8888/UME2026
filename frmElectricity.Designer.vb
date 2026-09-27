<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElectricity
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
        Label2 = New Label()
        txtCustomer = New TextBox()
        Label3 = New Label()
        txtOldNumber = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtPayment = New TextBox()
        btnCalculate = New Button()
        btnExit = New Button()
        txtNewNumber = New TextBox()
        txtToltal = New TextBox()
        btnSelectCase = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Khmer OS Muol Light", 18F)
        Label1.Location = New Point(149, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 55)
        Label1.TabIndex = 0
        Label1.Text = "អគ្គីសនីកម្ពុជា"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 36)
        Label2.TabIndex = 1
        Label2.Text = "ឈ្មោះអតិថិជន"
        ' 
        ' txtCustomer
        ' 
        txtCustomer.Location = New Point(210, 108)
        txtCustomer.Name = "txtCustomer"
        txtCustomer.Size = New Size(277, 44)
        txtCustomer.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 36)
        Label3.TabIndex = 3
        Label3.Text = "ទូរលេខចាស់"
        ' 
        ' txtOldNumber
        ' 
        txtOldNumber.Location = New Point(210, 171)
        txtOldNumber.Name = "txtOldNumber"
        txtOldNumber.Size = New Size(277, 44)
        txtOldNumber.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(82, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 36)
        Label4.TabIndex = 5
        Label4.Text = "ទូរលេខថ្មី"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(80, 300)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 36)
        Label5.TabIndex = 7
        Label5.Text = "ចំនួនគីឡូ"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(108, 365)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 36)
        Label6.TabIndex = 9
        Label6.Text = "បង់ថ្លៃ"
        ' 
        ' txtPayment
        ' 
        txtPayment.Enabled = False
        txtPayment.Location = New Point(210, 362)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(277, 44)
        txtPayment.TabIndex = 10
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(210, 425)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(134, 53)
        btnCalculate.TabIndex = 11
        btnCalculate.Text = "គណនា"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(377, 425)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(110, 53)
        btnExit.TabIndex = 12
        btnExit.Text = "ចាកចេញ"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtNewNumber
        ' 
        txtNewNumber.Location = New Point(210, 237)
        txtNewNumber.Name = "txtNewNumber"
        txtNewNumber.Size = New Size(277, 44)
        txtNewNumber.TabIndex = 14
        ' 
        ' txtToltal
        ' 
        txtToltal.Enabled = False
        txtToltal.Location = New Point(210, 297)
        txtToltal.Name = "txtToltal"
        txtToltal.Size = New Size(277, 44)
        txtToltal.TabIndex = 15
        ' 
        ' btnSelectCase
        ' 
        btnSelectCase.Location = New Point(12, 425)
        btnSelectCase.Name = "btnSelectCase"
        btnSelectCase.Size = New Size(137, 53)
        btnSelectCase.TabIndex = 16
        btnSelectCase.Text = "Select Case"
        btnSelectCase.UseVisualStyleBackColor = True
        ' 
        ' frmElectricity
        ' 
        AutoScaleDimensions = New SizeF(11F, 36F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(541, 496)
        Controls.Add(btnSelectCase)
        Controls.Add(txtToltal)
        Controls.Add(txtNewNumber)
        Controls.Add(btnExit)
        Controls.Add(btnCalculate)
        Controls.Add(txtPayment)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtOldNumber)
        Controls.Add(Label3)
        Controls.Add(txtCustomer)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Khmer OS Siemreap", 12F)
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmElectricity"
        Text = "Electricity"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOldNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNewNumber As TextBox
    Friend WithEvents txtToltal As TextBox
    Friend WithEvents btnSelectCase As Button
End Class

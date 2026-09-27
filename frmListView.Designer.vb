<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListView
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
        ListView1 = New ListView()
        Label1 = New Label()
        Label2 = New Label()
        txtProductID = New TextBox()
        txtProductName = New TextBox()
        Label3 = New Label()
        txtQuantity = New TextBox()
        Label4 = New Label()
        txtPrice = New TextBox()
        Label5 = New Label()
        btnAdd = New Button()
        btnEdit = New Button()
        btnRemove = New Button()
        btnClear = New Button()
        lblAmount = New Label()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.GridLines = True
        ListView1.Location = New Point(29, 243)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(573, 283)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.Location = New Point(120, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(307, 41)
        Label1.TabIndex = 1
        Label1.Text = "Product Information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 2
        Label2.Text = "ProductID:"
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(177, 82)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(214, 27)
        txtProductID.TabIndex = 3
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(177, 115)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(214, 27)
        txtProductName.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 4
        Label3.Text = "ProductName:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(177, 148)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(214, 27)
        txtQuantity.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(54, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 6
        Label4.Text = "Quantity:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(177, 181)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(214, 27)
        txtPrice.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(54, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 8
        Label5.Text = "Price:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(432, 76)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(432, 111)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 11
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(432, 146)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(94, 29)
        btnRemove.TabIndex = 12
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(432, 181)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(416, 538)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(62, 20)
        lblAmount.TabIndex = 14
        lblAmount.Text = "Amount"
        ' 
        ' frmListView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(622, 567)
        Controls.Add(lblAmount)
        Controls.Add(btnClear)
        Controls.Add(btnRemove)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(txtPrice)
        Controls.Add(Label5)
        Controls.Add(txtQuantity)
        Controls.Add(Label4)
        Controls.Add(txtProductName)
        Controls.Add(Label3)
        Controls.Add(txtProductID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        Name = "frmListView"
        Text = "ListView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAmount As Label
End Class

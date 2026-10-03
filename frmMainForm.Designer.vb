<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ToolToolStripMenuItem = New ToolStripMenuItem()
        RadioButtonToolStripMenuItem = New ToolStripMenuItem()
        ComboboxToolStripMenuItem = New ToolStripMenuItem()
        CheckBoxToolStripMenuItem = New ToolStripMenuItem()
        ListBoxToolStripMenuItem = New ToolStripMenuItem()
        ListViewToolStripMenuItem = New ToolStripMenuItem()
        PictureBoxToolStripMenuItem = New ToolStripMenuItem()
        WebBrowserToolStripMenuItem = New ToolStripMenuItem()
        LoopToolStripMenuItem = New ToolStripMenuItem()
        IFStatementToolStripMenuItem = New ToolStripMenuItem()
        SelectCaseToolStripMenuItem = New ToolStripMenuItem()
        LoopToolStripMenuItem1 = New ToolStripMenuItem()
        OtherToolStripMenuItem = New ToolStripMenuItem()
        AverageToolStripMenuItem = New ToolStripMenuItem()
        DivideToolStripMenuItem = New ToolStripMenuItem()
        VariableToolStripMenuItem = New ToolStripMenuItem()
        TimerToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ToolToolStripMenuItem, LoopToolStripMenuItem, OtherToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem})
        FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), Image)
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(66, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), Image)
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(139, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' ToolToolStripMenuItem
        ' 
        ToolToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RadioButtonToolStripMenuItem, ComboboxToolStripMenuItem, CheckBoxToolStripMenuItem, ListBoxToolStripMenuItem, ListViewToolStripMenuItem, PictureBoxToolStripMenuItem, WebBrowserToolStripMenuItem})
        ToolToolStripMenuItem.Image = CType(resources.GetObject("ToolToolStripMenuItem.Image"), Image)
        ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        ToolToolStripMenuItem.Size = New Size(72, 24)
        ToolToolStripMenuItem.Text = "Tool"
        ' 
        ' RadioButtonToolStripMenuItem
        ' 
        RadioButtonToolStripMenuItem.Image = CType(resources.GetObject("RadioButtonToolStripMenuItem.Image"), Image)
        RadioButtonToolStripMenuItem.Name = "RadioButtonToolStripMenuItem"
        RadioButtonToolStripMenuItem.Size = New Size(179, 26)
        RadioButtonToolStripMenuItem.Text = "Radio Button"
        ' 
        ' ComboboxToolStripMenuItem
        ' 
        ComboboxToolStripMenuItem.Image = CType(resources.GetObject("ComboboxToolStripMenuItem.Image"), Image)
        ComboboxToolStripMenuItem.Name = "ComboboxToolStripMenuItem"
        ComboboxToolStripMenuItem.Size = New Size(179, 26)
        ComboboxToolStripMenuItem.Text = "Combo Box"
        ' 
        ' CheckBoxToolStripMenuItem
        ' 
        CheckBoxToolStripMenuItem.Image = CType(resources.GetObject("CheckBoxToolStripMenuItem.Image"), Image)
        CheckBoxToolStripMenuItem.Name = "CheckBoxToolStripMenuItem"
        CheckBoxToolStripMenuItem.Size = New Size(179, 26)
        CheckBoxToolStripMenuItem.Text = "Check Box"
        ' 
        ' ListBoxToolStripMenuItem
        ' 
        ListBoxToolStripMenuItem.Image = CType(resources.GetObject("ListBoxToolStripMenuItem.Image"), Image)
        ListBoxToolStripMenuItem.Name = "ListBoxToolStripMenuItem"
        ListBoxToolStripMenuItem.Size = New Size(179, 26)
        ListBoxToolStripMenuItem.Text = "List Box"
        ' 
        ' ListViewToolStripMenuItem
        ' 
        ListViewToolStripMenuItem.Image = CType(resources.GetObject("ListViewToolStripMenuItem.Image"), Image)
        ListViewToolStripMenuItem.Name = "ListViewToolStripMenuItem"
        ListViewToolStripMenuItem.Size = New Size(179, 26)
        ListViewToolStripMenuItem.Text = "List View"
        ' 
        ' PictureBoxToolStripMenuItem
        ' 
        PictureBoxToolStripMenuItem.Image = CType(resources.GetObject("PictureBoxToolStripMenuItem.Image"), Image)
        PictureBoxToolStripMenuItem.Name = "PictureBoxToolStripMenuItem"
        PictureBoxToolStripMenuItem.Size = New Size(179, 26)
        PictureBoxToolStripMenuItem.Text = "Picture Box"
        ' 
        ' WebBrowserToolStripMenuItem
        ' 
        WebBrowserToolStripMenuItem.Image = CType(resources.GetObject("WebBrowserToolStripMenuItem.Image"), Image)
        WebBrowserToolStripMenuItem.Name = "WebBrowserToolStripMenuItem"
        WebBrowserToolStripMenuItem.Size = New Size(179, 26)
        WebBrowserToolStripMenuItem.Text = "Web Browser"
        ' 
        ' LoopToolStripMenuItem
        ' 
        LoopToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IFStatementToolStripMenuItem, SelectCaseToolStripMenuItem, LoopToolStripMenuItem1})
        LoopToolStripMenuItem.Image = CType(resources.GetObject("LoopToolStripMenuItem.Image"), Image)
        LoopToolStripMenuItem.Name = "LoopToolStripMenuItem"
        LoopToolStripMenuItem.Size = New Size(92, 24)
        LoopToolStripMenuItem.Text = "Control"
        ' 
        ' IFStatementToolStripMenuItem
        ' 
        IFStatementToolStripMenuItem.Image = CType(resources.GetObject("IFStatementToolStripMenuItem.Image"), Image)
        IFStatementToolStripMenuItem.Name = "IFStatementToolStripMenuItem"
        IFStatementToolStripMenuItem.Size = New Size(175, 26)
        IFStatementToolStripMenuItem.Text = "IF Statement"
        ' 
        ' SelectCaseToolStripMenuItem
        ' 
        SelectCaseToolStripMenuItem.Image = CType(resources.GetObject("SelectCaseToolStripMenuItem.Image"), Image)
        SelectCaseToolStripMenuItem.Name = "SelectCaseToolStripMenuItem"
        SelectCaseToolStripMenuItem.Size = New Size(175, 26)
        SelectCaseToolStripMenuItem.Text = "Select Case"
        ' 
        ' LoopToolStripMenuItem1
        ' 
        LoopToolStripMenuItem1.Image = CType(resources.GetObject("LoopToolStripMenuItem1.Image"), Image)
        LoopToolStripMenuItem1.Name = "LoopToolStripMenuItem1"
        LoopToolStripMenuItem1.Size = New Size(175, 26)
        LoopToolStripMenuItem1.Text = "Loop"
        ' 
        ' OtherToolStripMenuItem
        ' 
        OtherToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AverageToolStripMenuItem, DivideToolStripMenuItem, VariableToolStripMenuItem, TimerToolStripMenuItem})
        OtherToolStripMenuItem.Image = CType(resources.GetObject("OtherToolStripMenuItem.Image"), Image)
        OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        OtherToolStripMenuItem.Size = New Size(103, 24)
        OtherToolStripMenuItem.Text = "Operator"
        ' 
        ' AverageToolStripMenuItem
        ' 
        AverageToolStripMenuItem.Image = CType(resources.GetObject("AverageToolStripMenuItem.Image"), Image)
        AverageToolStripMenuItem.Name = "AverageToolStripMenuItem"
        AverageToolStripMenuItem.Size = New Size(224, 26)
        AverageToolStripMenuItem.Text = "Average"
        ' 
        ' DivideToolStripMenuItem
        ' 
        DivideToolStripMenuItem.Image = CType(resources.GetObject("DivideToolStripMenuItem.Image"), Image)
        DivideToolStripMenuItem.Name = "DivideToolStripMenuItem"
        DivideToolStripMenuItem.Size = New Size(224, 26)
        DivideToolStripMenuItem.Text = "Divide"
        ' 
        ' VariableToolStripMenuItem
        ' 
        VariableToolStripMenuItem.Image = CType(resources.GetObject("VariableToolStripMenuItem.Image"), Image)
        VariableToolStripMenuItem.Name = "VariableToolStripMenuItem"
        VariableToolStripMenuItem.Size = New Size(224, 26)
        VariableToolStripMenuItem.Text = "Variable"
        ' 
        ' TimerToolStripMenuItem
        ' 
        TimerToolStripMenuItem.Image = CType(resources.GetObject("TimerToolStripMenuItem.Image"), Image)
        TimerToolStripMenuItem.Name = "TimerToolStripMenuItem"
        TimerToolStripMenuItem.Size = New Size(224, 26)
        TimerToolStripMenuItem.Text = "Timer"
        ' 
        ' frmMainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "frmMainForm"
        Text = "Main Form"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IFStatementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectCaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoopToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AverageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VariableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerToolStripMenuItem As ToolStripMenuItem
End Class

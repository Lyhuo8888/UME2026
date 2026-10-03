Public Class frmMainForm
    Private Sub RadioButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadioButtonToolStripMenuItem.Click
        Dim frmRadioBtn As New frmRadioButton
        frmRadioBtn.MdiParent = Me
        frmRadioBtn.Show()
    End Sub

    Private Sub ComboboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboboxToolStripMenuItem.Click
        Dim frmComboBox As New frmCombobox
        frmComboBox.MdiParent = Me
        frmComboBox.Show()
    End Sub

    Private Sub CheckBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckBoxToolStripMenuItem.Click
        Dim fmCheckBox As New frmCheckBox
        fmCheckBox.MdiParent = Me
        fmCheckBox.Show()
    End Sub

    Private Sub ListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListBoxToolStripMenuItem.Click
        Dim fmListBox As New frmListBox
        fmListBox.MdiParent = Me
        fmListBox.Show()
    End Sub

    Private Sub ListViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListViewToolStripMenuItem.Click
        Dim fmListView As New frmListView
        fmListView.MdiParent = Me
        fmListView.Show()
    End Sub

    Private Sub PictureBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureBoxToolStripMenuItem.Click
        Dim fmPictureBox As New frmPictureBox
        fmPictureBox.MdiParent = Me
        fmPictureBox.Show()
    End Sub

    Private Sub WebBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebBrowserToolStripMenuItem.Click
        Dim fmWebBrowser As New frmWebBrowser
        fmWebBrowser.MdiParent = Me
        fmWebBrowser.Show()
    End Sub

    Private Sub IFStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IFStatementToolStripMenuItem.Click
        Dim fmIfStatement As New frmIfStatement
        fmIfStatement.MdiParent = Me
        fmIfStatement.Show()
    End Sub

    Private Sub SelectCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCaseToolStripMenuItem.Click
        Dim fmSelectCase As New frmSelectCase
        fmSelectCase.MdiParent = Me
        fmSelectCase.Show()
    End Sub

    Private Sub LoopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoopToolStripMenuItem1.Click
        Dim fmLoop As New frmLoops
        fmLoop.MdiParent = Me
        fmLoop.Show()
    End Sub

    Private Sub AverageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AverageToolStripMenuItem.Click
        Dim fmAverage As New frmAverage
        fmAverage.MdiParent = Me
        fmAverage.Show()
    End Sub

    Private Sub DivideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivideToolStripMenuItem.Click
        Dim fmDivide As New frmDivide
        fmDivide.MdiParent = Me
        fmDivide.Show()
    End Sub

    Private Sub VariableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VariableToolStripMenuItem.Click
        Dim fmVariable As New frmVariable
        fmVariable.MdiParent = Me
        fmVariable.Show()
    End Sub

    Private Sub TimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerToolStripMenuItem.Click
        Dim fmTimer As New frmTimer
        fmTimer.MdiParent = Me
        fmTimer.Show()
    End Sub
End Class
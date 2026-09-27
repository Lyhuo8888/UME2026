Public Class frmTimer
    Dim startTime
    Dim endTime
    Dim duration
    Private Sub frmTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
        'MessageBox.Show("Form Load")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        startTime = TimeOfDay
        lblStart.Text = FormatDateTime(startTime, DateFormat.LongTime)
        lblDuration.Text = ""
        lblEnd.Text = ""
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        endTime = TimeOfDay
        duration = endTime - startTime
        lblDuration.Text = duration.ToString()
        lblEnd.Text = FormatDateTime(endTime, DateFormat.LongTime)
    End Sub
End Class
Public Class frmAverage
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim network, dbms, oop, linux, isa As Integer
        Dim totalScore As Integer
        Dim average As Double

        network = txtNetwork.Text
        dbms = txtDBMS.Text
        oop = txtOOP.Text
        linux = txtLinux.Text
        isa = txtISA.Text
        totalScore = network + dbms + oop + linux + isa
        average = totalScore / 5
        txtTotalScore.Text = totalScore
        txtAverage.Text = average
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNetwork.Clear()
        txtDBMS.Clear()
        txtOOP.Clear()
        txtLinux.Clear()
        txtISA.Clear()
        txtTotalScore.Clear()
        txtAverage.Clear()
    End Sub
End Class
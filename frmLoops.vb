Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmLoops
    Private Sub btnWhileLoop_Click(sender As Object, e As EventArgs) Handles btnWhileLoop.Click
        Dim i As Integer = 1
        Dim str As String = ""
        While i <= 12
            str = str & "i = " & i & vbCrLf
            i += 1
        End While
        txtWhileLoop.Text = str

    End Sub

    Private Sub btnDoWhileLoop_Click(sender As Object, e As EventArgs) Handles btnDoWhileLoop.Click
        Dim i As Integer = 1
        Dim str As String = ""
        Do While i <= 12

            If i = 6 Then
                Exit Do
            End If

            str = str & "i = " & i & vbCrLf
            i += 1
        Loop
        txtDoWhileLoop.Text = str
    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        Dim i As Integer = 1
        Dim str As String = ""
        Do
            str = str & "i = " & i & vbCrLf
            i += 1
        Loop While i <= 12
        txtDoLoop.Text = str

    End Sub

    Private Sub btnDoUntilLoop_Click(sender As Object, e As EventArgs) Handles btnDoUntilLoop.Click
        'Dim i As Integer = 1
        'Dim str As String = ""
        'Do Until i >= 13
        '    str = str & "i = " & i & vbCrLf
        '    i += 1
        'Loop
        'txtDoUntilLoop.Text = str

        Dim i As Integer = 1
        Dim str As String = ""
        Do
            str = str & "i = " & i & vbCrLf
            i += 1
        Loop Until i >= 13
        txtDoUntilLoop.Text = str
    End Sub

    Private Sub btnForNextLoop_Click(sender As Object, e As EventArgs) Handles btnForNextLoop.Click
        Dim i As Integer
        Dim str As String = ""
        For i = 1 To 12
            If i = 6 Then
                Exit For
            End If
            str = str & "i = " & i & vbCrLf
        Next i
        txtForNextLoop.Text = str
    End Sub
End Class
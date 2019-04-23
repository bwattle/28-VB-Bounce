Imports System.Drawing.Drawing2D
Public Class frmColour
    Dim g As Graphics
    Dim c As New Rectangle(60, 20, 90, 90)
    Dim r As New Rectangle(0, 0, 130, 130)
    Dim myBallBrush As Brush
    Dim myBGBrush As Brush
    Public colourBallFill_R As Integer
    Public colourBallFill_G As Integer
    Public colourBallFill_B As Integer
    Public colourBGFill_R As Integer
    Public colourBGFill_G As Integer
    Public colourBGFill_B As Integer

    Private Sub frmColour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Panel1.CreateGraphics
        colourBallFill_R = frmBounce.shpBallFill_R
        colourBallFill_G = frmBounce.shpBallFill_G
        colourBallFill_B = frmBounce.shpBallFill_B
        colourBGFill_R = frmBounce.shpBGFill_R
        colourBGFill_G = frmBounce.shpBGFill_G
        colourBGFill_B = frmBounce.shpBGFill_B
        tbrRed.Value = colourBallFill_R
        tbrGreen.Value = colourBallFill_G
        tbrBlue.Value = colourBallFill_B
        myBGBrush = New SolidBrush(Color.FromArgb(tbrRed.Value, tbrGreen.Value, tbrBlue.Value))
        g.FillRectangle(myBGBrush, r)
        myBallBrush = New SolidBrush(Color.FromArgb(tbrRed.Value, tbrGreen.Value, tbrBlue.Value))
        g.FillEllipse(myBallBrush, c)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If optBall.Checked Then
            tbrRed.Value = colourBallFill_R
            tbrGreen.Value = colourBallFill_G
            tbrBlue.Value = colourBallFill_B
        Else
            tbrRed.Value = colourBGFill_R
            tbrGreen.Value = colourBGFill_G
            tbrBlue.Value = colourBGFill_B
        End If
    End Sub

    Private Sub colourChange(sender As Object, e As EventArgs) Handles tbrRed.Scroll, tbrGreen.Scroll, tbrBlue.Scroll
        If optBall.Checked Then
            myBallBrush = New SolidBrush(Color.FromArgb(tbrRed.Value, tbrGreen.Value, tbrBlue.Value))
            g.FillEllipse(myBallBrush, c)
        Else
            myBGBrush = New SolidBrush(Color.FromArgb(tbrRed.Value, tbrGreen.Value, tbrBlue.Value))
            g.FillRectangle(myBGBrush, r)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("Ball colour " & colourBallFill_R & ", " & colourBallFill_G & ", " & colourBallFill_B & " BG colour " & colourBGFill_R & ", " & colourBGFill_G & ", " & colourBGFill_B)
        Me.Close()
    End Sub

    Private Sub optBall_CheckedChanged(sender As Object, e As EventArgs) Handles optBall.CheckedChanged
        If optBall.Checked Then
            tbrRed.Value = colourBallFill_R
            tbrGreen.Value = colourBallFill_G
            tbrBlue.Value = colourBallFill_B
        Else
            tbrRed.Value = colourBGFill_R
            tbrGreen.Value = colourBGFill_G
            tbrBlue.Value = colourBGFill_B
        End If
    End Sub

    Private Sub optBG_CheckedChanged(sender As Object, e As EventArgs) Handles optBG.CheckedChanged
        If optBall.Checked Then
            tbrRed.Value = colourBallFill_R
            tbrGreen.Value = colourBallFill_G
            tbrBlue.Value = colourBallFill_B
        Else
            tbrRed.Value = colourBGFill_R
            tbrGreen.Value = colourBGFill_G
            tbrBlue.Value = colourBGFill_B
        End If
    End Sub
End Class
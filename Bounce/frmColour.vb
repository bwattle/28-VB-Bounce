Imports System.Drawing.Drawing2D
Public Class frmColour
    Dim g As Graphics
    Dim c As New Rectangle(20, 20, 90, 90)
    Dim r As New Rectangle(0, 0, 130, 130)
    Dim myBallBrush As Brush
    Dim myBGBrush As Brush
    Private Sub frmColour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Panel1.CreateGraphics
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Me.Close
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
        Me.Close()
    End Sub
End Class
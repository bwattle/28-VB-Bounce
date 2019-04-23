Public Class frmBounce
    Dim g As Graphics
    Dim c As New Rectangle(20, 20, 90, 90)
    Dim r As New Rectangle(0, 0, 130, 130)
    Dim myBallBrush As Brush
    Dim myBGBrush As Brush
    Public shpBallFill_R As Integer
    Public shpBallFill_G As Integer
    Public shpBallFill_B As Integer
    Public shpBGFill_R As Integer
    Public shpBGFill_G As Integer
    Public shpBGFill_B As Integer

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        frmColour.Show()
    End Sub

    Private Sub SpeedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeedToolStripMenuItem.Click
        frmSpeed.Show()
    End Sub

    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizeToolStripMenuItem.Click
        frmSize.Show()
        MsgBox("Not available yet", MsgBoxStyle.Exclamation, "Stub")
    End Sub

    Private Sub frmBounce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shpBallFill_R = 10
        shpBallFill_G = 100
        shpBallFill_B = 200
        shpBGFill_R = 250
        shpBGFill_G = 150
        shpBGFill_B = 50
    End Sub
End Class

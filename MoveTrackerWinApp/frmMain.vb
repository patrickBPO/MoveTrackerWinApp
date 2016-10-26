Public Class frmMain
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub SetupLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupLocationToolStripMenuItem.Click
        frmAssignLocale.Show()

    End Sub

    Private Sub TrackingSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrackingSystemToolStripMenuItem.Click
        frmAssignLocale.Show()
        Me.Close()
    End Sub

End Class
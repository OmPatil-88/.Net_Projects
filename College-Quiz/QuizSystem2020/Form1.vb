Public Class Form1

    Private Sub QuizStartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuizStartToolStripMenuItem.Click
        Dim f As New frmQuizStart
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub TeamEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamEntryToolStripMenuItem.Click
        Dim f As New frmTeamEntry
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub HorizToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizToolStripMenuItem.Click
        Dim f As New frmHScore
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageToolStripMenuItem.Click
        Dim f As New frmImage
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaToolStripMenuItem.Click
        Dim f As New frmMedia
        f.MdiParent = Me
        f.Show()
    End Sub
End Class

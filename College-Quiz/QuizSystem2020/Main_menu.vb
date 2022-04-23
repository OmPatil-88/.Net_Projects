Public Class Main_menu
    Public f As Form
    Private Sub close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cls.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If buzzer.Visible = False Then
            buzzer.Visible = True
        Else
            buzzer.Visible = False
        End If
    End Sub

    Private Sub Button7_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If panel_iew_score.Visible = True Then
            panel_iew_score.Visible = False
        Else
            panel_iew_score.Visible = True
        End If
    End Sub
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        load_panel.Controls.Clear()
    End Sub
    Public Sub switch_panel(ByVal frm As Form)
        load_panel.Controls.Clear()
        frm.TopLevel = False
        load_panel.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        clear_pan()
        f = New frmQuizStart
        switch_panel(f)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        clear_pan()
        f = New frmHScore
        switch_panel(f)
    End Sub

    Private Sub pan_buzzer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pan_buzzer.Click
        clear_pan()
        f = New frmImage
        switch_panel(f)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        clear_pan()
        f = New frmMedia
        switch_panel(f)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear_pan()
        f = New frmTeamEntry
        switch_panel(f)
    End Sub
    Public Sub clear_pan()
        'f.Dispose()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            My.Computer.Audio.Stop()
            'My.Computer.Audio.Play("‪E:\Quizaudio2020\suspence1.wav", AudioPlayMode.Background)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            My.Computer.Audio.Stop()
            'My.Computer.Audio.Play("‪E:\Quizaudio2020\suspence2.wav", AudioPlayMode.Background)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            My.Computer.Audio.Stop()
            ' My.Computer.Audio.Play("‪E:\Quizaudio2020\suspence3.wav", AudioPlayMode.Background)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            My.Computer.Audio.Stop()
            ' My.Computer.Audio.Play("‪E:\Quizaudio2020\timer.wav", AudioPlayMode.Background)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        clear_pan()
        f = New frmVscore
        switch_panel(f)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        clear_pan()
        f = New frmAnimated
        switch_panel(f)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If pan_side.Width = 220 Then
            pan_side.Width = 43
            load_panel.Width += 187

        Else
            pan_side.Width = 220
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        clear_pan()
        f = New frm_final_result
        switch_panel(f)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear_pan()
        f = New frm_rules
        switch_panel(f)
    End Sub
End Class
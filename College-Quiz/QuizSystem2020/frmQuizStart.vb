Imports System.Data
Imports System.Data.OleDb
Public Class frmQuizStart
    Dim question_name(1) As String
    Dim question_answer(1) As String
    Dim i, j, wd, i1, len1 As Integer
    Dim z As Integer
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play("E:\Quizaudio2020\Registration.wav", AudioPlayMode.Background)
        'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        'Dim str As String
        'str = System.AppDomain.CurrentDomain.BaseDirectory.      
        Startconnection()
        Dim cm As New OleDbCommand
        Dim dtr As OleDbDataReader
        cm.Connection = con
        cm.CommandText = "select distinct Subject from Question1"
        dtr = cm.ExecuteReader()
        cmb_subject.Items.Clear()
        While dtr.Read()
            cmb_subject.Items.Add(dtr("Subject"))
        End While
        Endconnection()
    End Sub
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

        If (txtQNumber.Text <> "") Then

        End If
        OvalShape1.BackColor = Color.WhiteSmoke
        txtopa.BackColor = Color.White
        txtopb.BackColor = Color.White
        txtopc.BackColor = Color.White
        txtopd.BackColor = Color.White

        txtopa.ForeColor = Color.Black
        txtopb.ForeColor = Color.Black
        txtopc.ForeColor = Color.Black
        txtopd.ForeColor = Color.Black

        txtQuestion.Text = ""
        txtAnswer.Text = ""
        txtQNumber.Enabled = True
        txtQuestion.Visible = False
        txtAnswer.Visible = False
        Timer1.Enabled = False
        Timer1.Stop()
    
        txtQNumber.Text = ""

        btnShow.Enabled = True
        btnAnswer.Enabled = False

        clear_text()
        hide_optiions()

    End Sub
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtQuestion.Text = Show_question(cmb_subject.Text, txtQNumber.Text)
            txtQuestion.Visible = True
            txtQNumber.Enabled = False
            btnShow.Enabled = False
           End If
    End Sub
    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtopa.Text = Show_option(cmb_subject.Text, txtQNumber.Text, "a")
            txtopb.Text = Show_option(cmb_subject.Text, txtQNumber.Text, "b")
            txtopc.Text = Show_option(cmb_subject.Text, txtQNumber.Text, "c")
            txtopd.Text = Show_option(cmb_subject.Text, txtQNumber.Text, "d")
            Timer2.Start()
            Timer2.Enabled = True
            btnAnswer.Enabled = True
            txtQNumber.Enabled = False
            btnShow.Enabled = False
            btn_pass.Enabled = True
            show_options()
            Panel1.Visible = True
        End If
    End Sub
    Public Sub show_options()
        txtopa.Visible = True
        txtopb.Visible = True
        txtopc.Visible = True
        txtopd.Visible = True
    End Sub
    Public Sub hide_optiions()
        txtopa.Text = ""
        txtopb.Text = ""
        txtopc.Text = ""
        txtopd.Text = ""
    End Sub
    Public Sub clear_text()
        'txtopa.Clear()
        'txtopb.Clear()
        'txtopc.Clear()
        'txtopd.Clear()
    End Sub
    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        Dim answer As String
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtAnswer.Visible = True
            answer = Show_answer(cmb_subject.Text, txtQNumber.Text)
            ''''''''''''''''''''''''''''''''''''''''''''code for right code
            wrong_right_questions(txtopa, answer, 1)
            wrong_right_questions(txtopb, answer, 1)
            wrong_right_questions(txtopc, answer, 1)
            wrong_right_questions(txtopd, answer, 1)

        End If
        
    End Sub
    Public Sub wrong_right_questions(ByVal obj As Button, ByVal ans As String, ByVal var As Integer)
        If obj.BackColor = Color.Orange And obj.Text = ans And var = 1 Then
            obj.BackColor = Color.Green
            txtAnswer.Text = "Correct Answer"

            txtAnswer.ForeColor = Color.Green
        ElseIf obj.BackColor = Color.Orange And obj.Text <> ans And var = 1 Then
            obj.BackColor = Color.Red
            If txtopa.Text = ans Then
                txtopa.BackColor = Color.Green
                txtopa.ForeColor = Color.White
            ElseIf txtopb.Text = ans Then
                txtopb.BackColor = Color.Green
                txtopb.ForeColor = Color.White
            ElseIf txtopc.Text = ans Then
                txtopb.BackColor = Color.Green
                txtopc.ForeColor = Color.White
            ElseIf txtopd.Text = ans Then
                txtopd.BackColor = Color.Green
                txtopd.ForeColor = Color.White
            End If
            My.Computer.Audio.Play("E:\Quizaudio2020\Wrong_answer.wav", AudioPlayMode.Background)
            txtAnswer.Text = " Wrong Answer"
            txtAnswer.ForeColor = Color.Red
        ElseIf obj.BackColor = Color.Orange And obj.Text <> ans And var = 0 Then
            txtAnswer.Text = " Wrong Answer"
            My.Computer.Audio.Play("E:\Quizaudio2020\Wrong_answer.wav", AudioPlayMode.Background)
            txtAnswer.ForeColor = Color.Red
        End If
    End Sub
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If P1.Value = 100 Then
        '    Timer1.Enabled = False
        '    Exit Sub
        'End If

        'P1.Value = P1.Value + 1

        'If ((P1.Value) Mod 10 = 0) Then

        '    lblTime.Text = Convert.ToInt32((P1.Value) / 10) & " Sec."
        '    Beep()
        '    ' System.Media.SystemSounds.Question.Play()
        'End If

        '' Beep()

        'If lblTime.Text = "10 Sec." Then
        '    lblTime.Text = "Time Up...!!!"
        '    System.Media.SystemSounds.Hand.Play()
        'End If
    End Sub
    Private Sub btnTimeUp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''  c.Hide()
        'If (txtAnswer.Visible) Then
        '    ' c.Show()
        '    '   c.Play("wave")
        '    '   c.Speak("Time Up ")
        '    '  c.Play("announce")
        'Else    'txtAnswer.Visible = True()
        '    '  c.Show()
        '    '  c.Play("wave")
        '    '  c.Speak("Time Up ")
        '    '   c.Play("announce")
        '    '
        '    '   c.Hide()

        'End If

    End Sub
    Private Sub btnTimeStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (txtQuestion.Text <> "") Then
        '    Timer1.Start()
        '    '    Timer1.Start()
        '    '    Timer1.Enabled = True

        '    '    c.Show()
        '    '    c.Play("process")
        '    lblTime.Visible = True
        'End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtQNumber.Text <> "" Then
            txtQNumber.Text = Val(txtQNumber.Text) - 1
        End If
    End Sub
    Private Sub txtQNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQNumber.TextChanged
        If txtQNumber.Text <> "" Then
            If txtQNumber.Text = 1 Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtQNumber.Text <> "" Then
            txtQNumber.Text = Val(txtQNumber.Text) + 1
        End If
    End Sub
    Private Sub txtopa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtopa.Click
        If txtopa.ForeColor = Color.White And txtopa.BackColor = Color.Orange Then
            txtopa.BackColor = Color.White
            txtopa.ForeColor = Color.Black
        Else
            txtopa.BackColor = Color.Orange
            txtopa.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtopb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtopb.Click
        If txtopb.ForeColor = Color.White And txtopb.BackColor = Color.Orange Then
            txtopb.BackColor = Color.White
            txtopb.ForeColor = Color.Black
        Else
            txtopb.BackColor = Color.Orange
            txtopb.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtopc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtopc.Click
        If txtopc.ForeColor = Color.White And txtopc.BackColor = Color.Orange Then
            txtopc.BackColor = Color.White
            txtopc.ForeColor = Color.Black
        Else
            txtopc.BackColor = Color.Orange
            txtopc.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtopd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtopd.Click
        If txtopd.ForeColor = Color.White And txtopd.BackColor = Color.Orange Then
            txtopd.BackColor = Color.White
            txtopd.ForeColor = Color.Black
        Else
            txtopd.BackColor = Color.Orange
            txtopd.ForeColor = Color.White
        End If
    End Sub

    Private Sub btn_submit_score_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit_score.Click
        If submit_points(cmb_team.Text, cmb_points.Text) Then
            OvalShape1.BackColor = Color.Green
        Else
            OvalShape1.BackColor = Color.Red
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pass.Click
        Dim answer As String
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtAnswer.Visible = True
            answer = Show_answer(cmb_subject.Text, txtQNumber.Text)
            ''''''''''''''''''''''''''''''''''''''''''''code for right code
            wrong_right_questions(txtopa, answer, False)
            wrong_right_questions(txtopb, answer, False)
            wrong_right_questions(txtopc, answer, False)
            wrong_right_questions(txtopd, answer, False)
        End If
    End Sub
End Class
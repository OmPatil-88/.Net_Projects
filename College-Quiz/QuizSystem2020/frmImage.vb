Imports System.Data.OleDb
Public Class frmImage
    Private Sub frmImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String
        str = System.AppDomain.CurrentDomain.BaseDirectory
        Startconnection()
        '*******************************************************************for subjects
        Dim cm As New OleDbCommand
        Dim dtr As OleDbDataReader
        cm.Connection = con
        cm.CommandText = "select distinct Subject from Question1"
        dtr = cm.ExecuteReader()
        cmb_subject.Items.Clear()
        While dtr.Read()
            cmb_subject.Items.Add(dtr("Subject"))
        End While
        dtr.Close()

        '********************************************************************for teams
        cm.CommandText = "select team from studinfo"
        dtr = cm.ExecuteReader()
        cmb_team.Items.Clear()
        While dtr.Read()
            cmb_team.Items.Add(dtr("team"))
        End While
        cm.Dispose()
        dtr.Close()
        Endconnection()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If txtQNumber.Text <> "" Then
            imgShow.ImageLocation = "E:\quizimages2020\" + txtQNumber.Text + ".jpg"
        End If
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtQuestion.Text = Show_question(cmb_subject.Text, txtQNumber.Text)
            txtQuestion.Visible = True
            txtQNumber.Enabled = False
            btnAnswer.Enabled = True
            btnShow.Enabled = False
            btnAnswer.Enabled = True
        End If
    End Sub
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        txtQNumber.Text = ""
        imgShow.ImageLocation = ""
        If (txtQNumber.Text <> "") Then

        End If
        OvalShape1.BackColor = Color.WhiteSmoke
       
        txtQuestion.Text = ""
        txtAnswer.Text = ""
        txtQNumber.Enabled = True
        txtAnswer.Text = ""
        txtQNumber.Text = ""

        cmb_points.Text = ""
        cmb_team.Text = ""
        btnShow.Enabled = True
        btnAnswer.Enabled = False
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtQNumber.Text <> "" Then
            txtQNumber.Text = Val(txtQNumber.Text) - 1
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtQNumber.Text <> "" Then
            txtQNumber.Text = Val(txtQNumber.Text) + 1
        End If
    End Sub
   Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        Dim answer As String
        If (txtQNumber.Text <> "") And cmb_subject.SelectedIndex <> -1 Then
            txtAnswer.Visible = True
            answer = Show_answer(cmb_subject.Text, txtQNumber.Text)
            txtAnswer.Text = answer
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
   Private Sub btn_submit_score_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit_score.Click
        If submit_points(cmb_team.Text, cmb_points.Text) Then
            OvalShape1.BackColor = Color.Green
        Else
            OvalShape1.BackColor = Color.Red
        End If

    End Sub

    Private Sub imgShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgShow.Click
        If imgShow.Size.Height = 768 And imgShow.Size.Width = 1366 Then
            imgShow.Size = New Point(532, 416)
        ElseIf imgShow.Size.Height = 416 And imgShow.Size.Width = 532 Then
            imgShow.Size = New Point(1366, 768)
        End If
    End Sub
End Class
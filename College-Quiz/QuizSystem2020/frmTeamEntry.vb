Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frmTeamEntry
    'Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\QuizSystem2020\QuizDb2020.accdb")
    ''Dim da As New OleDbDataAdapter
    ''Dim da1 As New OleDbDataAdapter
    ''Dim ds As DataSet
    ''Dim dt As DataTable
    ''Dim dr As DataRow
    Dim id As Integer = 0
    Dim cmd As OleDbCommand
    Private Sub frmTeamEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("E:\Quizaudio2020\Registration.wav", AudioPlayMode.BackgroundLoop)
        id = auto_incr("select count(ID) from studinfo", 1)
        'cmbT.Items.Clear()
        'cmbTeamName.Items.Clear()
        'da = New OleDbDataAdapter("select Team from studinfo", con)
        'ds = New DataSet()
        'da.Fill(ds, "stud")
        'dt = ds.Tables("stud")
        'If (dt.Rows.Count > 0) Then
        '    For Each dr In ds.Tables("stud").Rows
        '        cmbT.Items.Add(dr("team"))
        '        cmbTeamName.Items.Add(dr("team"))
        '    Next
        'End If
    End Sub

    Private Sub cmbTeamName_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTeamName.SelectedIndexChanged
        If cmbTeamName.Text <> "" Then
            da = New OleDbDataAdapter("select * from studinfo where Team='" + cmbTeamName.Text + "'", con)
            ds = New DataSet
            da.Fill(ds, "studinfo")
            dt = ds.Tables("studinfo")
            If dt.Rows.Count > 0 Then

                dr = ds.Tables("studinfo").Rows(0)
                txtCollageName.Text = dr("collegename")

                txtFStudName.Text = dr("sname1")
                txtSStudName.Text = dr("sname2")
                txtScore.Text = dr("score")
                btnUpdate.Enabled = True
                btnSave.Enabled = False
                'btnDelete.Enabled = False
            Else
                'MessageBox.Show("Record Not Present", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'clr_text()
                txtCollageName.Text = ""
                txtFStudName.Text = ""
                txtSStudName.Text = ""
                txtScore.Text = ""
                txtScore.Text = 0
                btnSave.Enabled = True
                btnUpdate.Enabled = False
                'btnDelete.Enabled = False
            End If
        End If


    End Sub
    Public Sub clr_text()
        cmbTeamName.SelectedIndex = -1
        cmbT.SelectedIndex = -1

        txtCollageName.Text = ""
        txtFStudName.Text = ""
        txtSStudName.Text = ""
        txtScore.Text = 0

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cmbTeamName.Text <> "" And txtCollageName.Text <> "" And txtFStudName.Text <> "" And txtSStudName.Text <> "" And cmbTeamName.SelectedIndex <> -1 Then

            ''    da = New OleDbDataAdapter("select * from studinfo where Team='" + cmbTeamName.Text + "'", con)
            ''    ds = New DataSet
            ''    da.Fill(ds, "stud")
            ''    dt = ds.Tables("stud")
            ''    If dt.Rows.Count <> 1 Then
            ''        If cmbTeamName.Text <> "" And txtCollageName.Text <> "" Then
            ''            da1 = New OleDbDataAdapter("select * from studinfo", con)
            ''            ds = New DataSet
            ''            da1.Fill(ds, "stud")
            ''            dt = ds.Tables("stud")

            ''            dr = ds.Tables("stud").NewRow()
            ''            dr("collegename") = txtCollageName.Text
            ''            dr("sname1") = txtFStudName.Text
            ''            dr("sname2") = txtSStudName.Text

            ''            dr("score") = txtScore.Text
            ''            dr("team") = cmbTeamName.Text


            ''            dt.Rows.Add(dr)
            ''            Dim cmd As New OleDbCommandBuilder(da1)
            ''            da1.Update(ds, "stud")

            ''            MessageBox.Show("Record Save ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ''            clr_text()
            ''        Else
            ''            MessageBox.Show("Please Make Team Entry", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ''        End If

            ''    Else

            ''        MessageBox.Show("Record Already Exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ''    End If

            ''Else
            ''    MessageBox.Show("Please Select Team first", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ''End If

            ''btnSave.Enabled = True
            ''btnUpdate.Enabled = False
            ''btnDelete.Enabled = False


            Startconnection()
            cmd = New OleDbCommand("insert into studinfo values(" & id & ",'" & txtCollageName.Text & "','" & txtFStudName.Text & "','" & txtSStudName.Text & "'," & txtScore.Text & ",'" & cmbTeamName.Text & "')", con)
            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("Student Added Successfully", MsgBoxStyle.OkOnly)
                id = auto_incr("select count(ID) from studinfo", 1)
                cmd.Dispose()
                clr_text()
            Else
                MsgBox("Error....!", MsgBoxStyle.OkOnly)
            End If
            Endconnection()
        Else
            MsgBox("first fill all fields...", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If cmbTeamName.Text <> "" And txtCollageName.Text <> "" And txtFStudName.Text <> "" And txtSStudName.Text <> "" And cmbTeamName.SelectedIndex <> -1 Then
            Startconnection()
            cmd = New OleDbCommand("Update studinfo set collegename='" & txtCollageName.Text & "',sname1 = '" & txtFStudName.Text & "',sname2 = '" & txtSStudName.Text & "',score = " & txtScore.Text & ",team = '" & cmbTeamName.Text & "'", con)
            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("Record Update Successfully..", MsgBoxStyle.OkOnly)
                cmd.Dispose()
                clr_text()
            Else
                MsgBox("Record Not update successfully..", MsgBoxStyle.OkOnly)
            End If
        Else
            MsgBox("First Fill All Fields", MsgBoxStyle.OkOnly)
        End If
        Endconnection()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''BtnEdit.Enabled = False
        ''btnUpdate.Enabled = True
        ''btnDelete.Enabled = True

        ''cmbTeamName.Enabled = False
        ''cmbT.Enabled = True
    End Sub

    Private Sub cmbT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbT.SelectedIndexChanged
        If cmbT.Text <> "" Then
            da = New OleDbDataAdapter("select * from studinfo where Team='" + cmbT.Text + "'", con)
            ds = New DataSet
            da.Fill(ds, "stud")
            dt = ds.Tables("stud")
            If dt.Rows.Count > 0 Then

                dr = ds.Tables("stud").Rows(0)
                txtCollageName.Text = dr("collegename")

                txtFStudName.Text = dr("sname1")
                txtSStudName.Text = dr("sname2")
                txtScore.Text = dr("score")

            Else
                MessageBox.Show("Record Not Present", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clr_text()

            End If
        End If

        btnSave.Enabled = False
        btnUpdate.Enabled = True
        'btnDelete.Enabled = True
    End Sub

    Private Sub tb_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Reset.Click
        If MsgBox("Are you sure want to Reset the Data...", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            Startconnection()
            Dim cmd As OleDbCommand

            Dim temp As Integer = 0
            cmd = New OleDbCommand("select count(ID) from studinfo", con)
            temp = cmd.ExecuteScalar()
            cmd.Dispose()


            Dim dr As OleDbDataReader
            Dim id As Integer = 0
            Dim college_nm As String = Nothing
            Dim sname1 As String = Nothing
            Dim sname2 As String = Nothing
            Dim score As Integer = 0
            Dim team As String = Nothing
            cmd = New OleDbCommand("select * from studinfo ", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                id = dr("ID")
                college_nm = dr("collegename")
                sname1 = dr("sname1")
                sname2 = dr("sname2")
                score = dr("score")
                team = dr("team")

                cmd.Dispose()

                Dim sfid As Integer = 0
                sfid = auto_incr("select count(ID) from Student_Final_data ", 1)

                cmd = New OleDbCommand("insert into Student_Final_data values(" & sfid & ",'" & college_nm & "','" & sname1 & "','" & sname2 & "'," & score & ",'" & team & "')", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                cmd = New OleDbCommand("delete from studinfo where ID = " & id & "", con)
                If temp = temp - (temp - 1) Then
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Reset Successfully..", MsgBoxStyle.OkOnly)
                        cmd.Dispose()
                        clr_text()
                        temp = 0
                    End If
                Else
                    cmd.ExecuteNonQuery()
                    temp = temp - 1
                End If
            End While
            dr.Close()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clr_text()
    End Sub

    Private Sub frmTeamEntry_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        My.Computer.Audio.Stop()
    End Sub
End Class
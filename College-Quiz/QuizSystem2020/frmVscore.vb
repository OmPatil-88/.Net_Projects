Imports System.Data.OleDb

Public Class frmVscore

    Dim con As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim dr As DataRow

    Dim da1 As New OleDbDataAdapter
    Dim dt1 As DataTable
    Dim dr1 As DataRow

    Dim da2 As New OleDbDataAdapter
    Dim dt2 As DataTable
    Dim dr2 As DataRow

    Dim da3 As New OleDbDataAdapter
    Dim dt3 As DataTable
    Dim dr3 As DataRow

    Dim da4 As New OleDbDataAdapter
    Dim dt4 As DataTable
    Dim dr4 As DataRow

    Dim cmd As OleDbCommandBuilder

    Dim y As Integer = 40
    Dim x As Integer = 40
    Dim z As Integer = 40
    Dim a As Integer = 40
    Dim b As Integer = 40

    Dim a1 As Integer = 55
    Dim a2 As Integer = 55
    Dim a3 As Integer = 55
    Dim a4 As Integer = 55
    Dim a5 As Integer = 55

    Dim i As Integer
    Private Sub frmVertScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\QuizSystem2020\QuizDb2020.accdb")

        '.................................................................................For Team  A
        da = New OleDbDataAdapter("select * from studinfo where id=1", con)
        ds = New DataSet
        da.Fill(ds, "stud")
        dt = ds.Tables("stud")
        If dt.Rows.Count > 0 Then
            dr = ds.Tables("stud").Rows(0)
            txtTeamA.Text = dr("score")
        End If
        '.................................................................................For Team  B
        da1 = New OleDbDataAdapter("select * from studinfo where id=2", con)
        ds = New DataSet
        da1.Fill(ds, "stud")
        dt1 = ds.Tables("stud")
        If dt1.Rows.Count > 0 Then
            dr1 = ds.Tables("stud").Rows(0)
            txtTeamB.Text = dr1("score")
        End If
        '.................................................................................For Team  C
        da2 = New OleDbDataAdapter("select * from studinfo where id=3", con)
        ds = New DataSet
        da2.Fill(ds, "stud")
        dt2 = ds.Tables("stud")
        If dt2.Rows.Count > 0 Then
            dr2 = ds.Tables("stud").Rows(0)
            txtTeamC.Text = dr2("score")
        End If
        '.................................................................................For Team  D
        da3 = New OleDbDataAdapter("select * from studinfo where id=4", con)
        ds = New DataSet
        da3.Fill(ds, "stud")
        dt3 = ds.Tables("stud")
        If dt3.Rows.Count > 0 Then
            dr3 = ds.Tables("stud").Rows(0)
            txtTeamD.Text = dr3("score")
        End If
        '.................................................................................For Team  E
        da4 = New OleDbDataAdapter("select * from studinfo where id=5", con)
        ds = New DataSet
        da4.Fill(ds, "stud")
        dt4 = ds.Tables("stud")
        If dt4.Rows.Count > 0 Then
            dr4 = ds.Tables("stud").Rows(0)
            txtTeamE.Text = dr4("score")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblA.Size = New Point(176, y)
        y = y + 5
        ' Next
        If y = 600 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblB.Size = New Point(176, x)
        x = x + 5
        If x = 600 Then
            Timer2.Stop()
            Timer3.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        lblC.Size = New Point(176, z)
        z = z + 5
        If z = 600 Then
            Timer3.Stop()
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        lblD.Size = New Point(176, a)
        a = a + 5
        If a = 600 Then
            Timer4.Stop()
            Timer5.Start()
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        lblE.Size = New Point(176, b)
        b = b + 5
        If b = 600 Then
            Timer5.Stop()
        End If
    End Sub

    Private Sub txtTeamA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamA.TextChanged
        'If txtTeamA.Text <> "" Then
        '    da = New OleDbDataAdapter("select * from studinfo where id=1", con)
        '    ds = New DataSet
        '    da.Fill(ds, "stud")
        '    dt = ds.Tables("stud")
        '    If dt.Rows.Count > 0 Then
        '        dr = ds.Tables("stud").Rows(0)
        '        dr("score") = txtTeamA.Text

        '        cmd = New OleDbCommandBuilder(da)
        '        da.Update(ds, "stud")
        '    End If
        'End If
    End Sub

    Private Sub txtTeamB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamB.TextChanged
        'If txtTeamB.Text <> "" Then
        '    da = New OleDbDataAdapter("select * from studinfo where id=2", con)
        '    ds = New DataSet
        '    da.Fill(ds, "stud")
        '    dt = ds.Tables("stud")
        '    If dt.Rows.Count > 0 Then
        '        dr = ds.Tables("stud").Rows(0)
        '        dr("score") = txtTeamB.Text
        '        cmd = New OleDbCommandBuilder(da)
        '        da.Update(ds, "stud")

        '    End If
        'End If
    End Sub

    Private Sub txtTeamC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamC.TextChanged
        'If txtTeamC.Text <> "" Then
        '    da = New OleDbDataAdapter("select * from studinfo where id=3", con)
        '    ds = New DataSet
        '    da.Fill(ds, "stud")
        '    dt = ds.Tables("stud")
        '    If dt.Rows.Count > 0 Then
        '        dr = ds.Tables("stud").Rows(0)
        '        dr("score") = txtTeamC.Text
        '        cmd = New OleDbCommandBuilder(da)
        '        da.Update(ds, "stud")

        '    End If
        'End If
    End Sub

    Private Sub txtTeamD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamD.TextChanged
        'If txtTeamD.Text <> "" Then
        '    da = New OleDbDataAdapter("select * from studinfo where id=4", con)
        '    ds = New DataSet
        '    da.Fill(ds, "stud")
        '    dt = ds.Tables("stud")
        '    If dt.Rows.Count > 0 Then
        '        dr = ds.Tables("stud").Rows(0)
        '        dr("score") = txtTeamD.Text
        '        cmd = New OleDbCommandBuilder(da)
        '        da.Update(ds, "stud")

        '    End If
        'End If
    End Sub

    Private Sub txtTeamE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamE.TextChanged
        'If txtTeamE.Text <> "" Then
        '    da = New OleDbDataAdapter("select * from studinfo where id=5", con)
        '    ds = New DataSet
        '    da.Fill(ds, "stud")
        '    dt = ds.Tables("stud")
        '    If dt.Rows.Count > 0 Then
        '        dr = ds.Tables("stud").Rows(0)
        '        dr("score") = txtTeamE.Text
        '        cmd = New OleDbCommandBuilder(da)
        '        da.Update(ds, "stud")

        '    End If
        'End If
    End Sub

    
End Class
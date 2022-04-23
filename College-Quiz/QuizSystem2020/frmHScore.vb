Imports System.Data
Imports System.Data.OleDb
Public Class frmHScore
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

    Private Sub frmHScore_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Timer1.Start()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\QuizSystem2020\QuizDb2020.accdb")


        '.................................................................................For Team  A
        da = New OleDbDataAdapter("select * from studinfo where id=1", con)
        ds = New DataSet
        da.Fill(ds, "stud")
        dt = ds.Tables("stud")
        If dt.Rows.Count > 0 Then
            dr = ds.Tables("stud").Rows(0)
            txtTeamACollegename.Text = dr("collegename")
            txtTeamAScore.Text = dr("score")
        End If
        '.................................................................................For Team  B
        da1 = New OleDbDataAdapter("select * from studinfo where id=2", con)
        ds = New DataSet
        da1.Fill(ds, "stud")
        dt1 = ds.Tables("stud")
        If dt1.Rows.Count > 0 Then
            dr1 = ds.Tables("stud").Rows(0)
            txtTeamBCollegename.Text = dr1("collegename")
            txtTeamBScore.Text = dr1("score")
        End If
        '.................................................................................For Team  C
        da2 = New OleDbDataAdapter("select * from studinfo where id=3", con)
        ds = New DataSet
        da2.Fill(ds, "stud")
        dt2 = ds.Tables("stud")
        If dt2.Rows.Count > 0 Then
            dr2 = ds.Tables("stud").Rows(0)
            txtTeamCCollegename.Text = dr2("collegename")
            txtTeamCScore.Text = dr2("score")
        End If
        '.................................................................................For Team  D
        da3 = New OleDbDataAdapter("select * from studinfo where id=4", con)
        ds = New DataSet
        da3.Fill(ds, "stud")
        dt3 = ds.Tables("stud")
        If dt3.Rows.Count > 0 Then
            dr3 = ds.Tables("stud").Rows(0)
            txtTeamDCollegename.Text = dr3("collegename")
            txtTeamDScore.Text = dr3("score")
        End If
        '.................................................................................For Team  E
        da4 = New OleDbDataAdapter("select * from studinfo where id=5", con)
        ds = New DataSet
        da4.Fill(ds, "stud")
        dt4 = ds.Tables("stud")
        If dt4.Rows.Count > 0 Then
            dr4 = ds.Tables("stud").Rows(0)
            txtTeamECollegename.Text = dr4("collegename")
            txtTeamEScore.Text = dr4("score")
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label12.Size = New Point(a2, 70)
        a2 = a2 + 4
        ' Next
        If a2 > 970 Then
            Timer2.Stop()
            Timer3.Start()

        End If

        Label12.Size = New Point(a2, 70)
        a2 = a2 + 4
        ' Next
        If a2 > 970 Then
            Timer2.Stop()
            Timer3.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label10.Size = New Point(a3, 70)
        a3 = a3 + 4
        ' Next
        If a3 > 970 Then
            Timer3.Stop()
            Timer4.Start()

        End If
        Label10.Size = New Point(a3, 70)
        a3 = a3 + 4
        ' Next
        If a3 > 970 Then
            Timer3.Stop()
            Timer4.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label13.Size = New Point(a1, 70)
        a1 = a1 + 4
        ' Next
        If a1 > 970 Then
            Timer1.Stop()
            Timer2.Start()

        End If

        Label13.Size = New Point(a1, 70)
        a1 = a1 + 4
        ' Next
        If a1 > 970 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Label9.Size = New Point(a4, 70)
        a4 = a4 + 4
        ' Next
        If a4 > 970 Then
            Timer4.Stop()
            Timer5.Start()

        End If
        Label9.Size = New Point(a4, 70)
        a4 = a4 + 4
        ' Next
        If a4 > 970 Then
            Timer4.Stop()
            Timer5.Start()

        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Label8.Size = New Point(a5, 70)
        a5 = a5 + 4
        ' Next
        If a5 > 970 Then
            Timer5.Stop()
        End If
        Label8.Size = New Point(a5, 70)
        a5 = a5 + 4
        ' Next
        If a5 > 970 Then
            Timer5.Stop()
        End If
    End Sub

    'Private Sub txtTeamAScore_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamAScore.TextChanged
    '    If (txtTeamAScore.Text <> "") Then

    '        da = New OleDbDataAdapter("select * from studinfo where id=1", con)
    '        ds = New DataSet()
    '        da.Fill(ds, "stud")
    '        dt = ds.Tables("stud")
    '        If (dt.Rows.Count > 0) Then
    '            dr = ds.Tables("stud").Rows(0)
    '            dr("Score") = txtTeamAScore.Text

    '            Dim cmd As New OleDbCommandBuilder(da)

    '            da.Update(ds, "stud")


    '        End If

    '    End If
    'End Sub

    'Private Sub txtTeamBScore_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamBScore.TextChanged
    '    If txtTeamBScore.Text <> "" Then
    '        da = New OleDbDataAdapter("select * from studinfo where id=2", con)
    '        ds = New DataSet
    '        da.Fill(ds, "stud")
    '        dt = ds.Tables("stud")
    '        If dt.Rows.Count > 0 Then
    '            dr = ds.Tables("stud").Rows(0)
    '            dr("score") = txtTeamBScore.Text
    '            cmd = New OleDbCommandBuilder(da)
    '            da.Update(ds, "stud")

    '        End If
    '    End If
    'End Sub

    'Private Sub txtTeamCScore_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamCScore.TextChanged
    '    If txtTeamCScore.Text <> "" Then
    '        da = New OleDbDataAdapter("select * from studinfo where id=3", con)
    '        ds = New DataSet
    '        da.Fill(ds, "stud")
    '        dt = ds.Tables("stud")
    '        If dt.Rows.Count > 0 Then
    '            dr = ds.Tables("stud").Rows(0)
    '            dr("score") = txtTeamCScore.Text
    '            cmd = New OleDbCommandBuilder(da)
    '            da.Update(ds, "stud")

    '        End If
    '    End If
    'End Sub

    'Private Sub txtTeamDScore_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamDScore.TextChanged
    '    If txtTeamDScore.Text <> "" Then
    '        da = New OleDbDataAdapter("select * from studinfo where id=4", con)
    '        ds = New DataSet
    '        da.Fill(ds, "stud")
    '        dt = ds.Tables("stud")
    '        If dt.Rows.Count > 0 Then
    '            dr = ds.Tables("stud").Rows(0)
    '            dr("score") = txtTeamDScore.Text
    '            cmd = New OleDbCommandBuilder(da)
    '            da.Update(ds, "stud")

    '        End If
    '    End If
    'End Sub

    'Private Sub txtTeamEScore_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeamEScore.TextChanged
    '    If txtTeamEScore.Text <> "" Then
    '        da = New OleDbDataAdapter("select * from studinfo where id=5", con)
    '        ds = New DataSet
    '        da.Fill(ds, "stud")
    '        dt = ds.Tables("stud")
    '        If dt.Rows.Count > 0 Then
    '            dr = ds.Tables("stud").Rows(0)
    '            dr("score") = txtTeamEScore.Text
    '            cmd = New OleDbCommandBuilder(da)
    '            da.Update(ds, "stud")

    '        End If
    '    End If
    'End Sub

   
  
    Private Sub frmHScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\QuizSystem2020\QuizDb2020.accdb")


        '.................................................................................For Team  A
        da = New OleDbDataAdapter("select * from studinfo where id=1", con)
        ds = New DataSet
        da.Fill(ds, "stud")
        dt = ds.Tables("stud")
        If dt.Rows.Count > 0 Then
            dr = ds.Tables("stud").Rows(0)
            txtTeamACollegename.Text = dr("collegename")
            txtTeamAScore.Text = dr("score")
        End If
        '.................................................................................For Team  B
        da1 = New OleDbDataAdapter("select * from studinfo where id=2", con)
        ds = New DataSet
        da1.Fill(ds, "stud")
        dt1 = ds.Tables("stud")
        If dt1.Rows.Count > 0 Then
            dr1 = ds.Tables("stud").Rows(0)
            txtTeamBCollegename.Text = dr1("collegename")
            txtTeamBScore.Text = dr1("score")
        End If
        '.................................................................................For Team  C
        da2 = New OleDbDataAdapter("select * from studinfo where id=3", con)
        ds = New DataSet
        da2.Fill(ds, "stud")
        dt2 = ds.Tables("stud")
        If dt2.Rows.Count > 0 Then
            dr2 = ds.Tables("stud").Rows(0)
            txtTeamCCollegename.Text = dr2("collegename")
            txtTeamCScore.Text = dr2("score")
        End If
        '.................................................................................For Team  D
        da3 = New OleDbDataAdapter("select * from studinfo where id=4", con)
        ds = New DataSet
        da3.Fill(ds, "stud")
        dt3 = ds.Tables("stud")
        If dt3.Rows.Count > 0 Then
            dr3 = ds.Tables("stud").Rows(0)
            txtTeamDCollegename.Text = dr3("collegename")
            txtTeamDScore.Text = dr3("score")
        End If
        '.................................................................................For Team  E
        da4 = New OleDbDataAdapter("select * from studinfo where id=5", con)
        ds = New DataSet
        da4.Fill(ds, "stud")
        dt4 = ds.Tables("stud")
        If dt4.Rows.Count > 0 Then
            dr4 = ds.Tables("stud").Rows(0)
            txtTeamECollegename.Text = dr4("collegename")
            txtTeamEScore.Text = dr4("score")
        End If
    End Sub
End Class
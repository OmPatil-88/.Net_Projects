Imports System.Data
Imports System.Data.OleDb
Public Class frmAnimated
    'Dim con As New OleDbConnection
    Dim da As New OleDbCommand
    Dim ds As OleDbDataReader
    'Dim dt As DataTable
    'Dim dr As DataRow
    Dim teamname(4) As String
    Dim teamid(4) As String
    Dim teamscore(4) As String
    Dim i1 As Integer
    Dim last As Integer
    Dim len1, len2, len3, len4, len5, z, k, m As Integer
    Dim j, wd As Integer
    Dim i2 As Integer
    Private Sub frmAnimated_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Startconnection()
            da = New OleDbCommand("SELECT ID, collegename, sname1, sname2, score, team  FROM studinfo ORDER BY score desc ", con)
            ds = da.ExecuteReader
            Dim i As Integer = 0
            While ds.Read()
                teamname(i) = CStr(ds("sname1") & " and " & ds("sname2"))
                teamid(i) = CStr(ds("team"))
                teamscore(i) = CStr(ds("score"))
                i = i + 1
            End While



            Label1.Visible = True

            Timer1.Start()
            Timer2.Start()
            len1 = teamname(0).Length
            len2 = teamname(1).Length
            len3 = teamname(2).Length
            len4 = teamname(3).Length
            len5 = teamname(4).Length
            m = 190

            TextBox7.Text = 0
            TextBox8.Text = 0
            TextBox9.Text = 0
            TextBox10.Text = 0
        Catch
            MsgBox("Plese Enter all 5 teams record or click to other view option")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If j <= 90 Then
                Label1.Size = New Size(j, 70)
                j += 20
                Label1.Text = teamid(0)
            End If

            If wd <= 730 Then
                Label9.Size = New Size(wd, 80)
                wd += 20
            Else
                Timer1.Stop()
            End If

            Label1.Location = New Point(i1 + 5, 200)
            If i1 <= 50 Then
                i1 = i1 + 10
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            If z < len1 Then
                Label8.Text = teamname(0)(z)
                Label8.Location = New Point(m, k)
                k += 60
                m += 7
                If k >= 190 Then
                    Label9.Text += Label8.Text
                    k = 0
                    z += 1
                End If
            Else
                Label8.Hide()
                TextBox6.Show()


                TextBox6.Text = teamscore(0)
                TextBox6.ForeColor = Color.Green
                Timer11.Start()

                Timer2.Stop()
                j = 0
                i1 = 0
                wd = 0
                z = 0
                m = 0
                k = 160
                Label2.Visible = True
                Timer3.Start()
                Timer4.Start()
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        Try
            i2 += 1
            Dim a As Integer = TextBox6.Text
            If i2 Mod 2 = 0 Then
                TextBox6.Hide()
                If TextBox7.Text = a Then
                    TextBox7.Hide()
                End If
                If TextBox8.Text = a Then
                    TextBox8.Hide()
                End If
                If TextBox9.Text = a Then
                    TextBox9.Hide()
                End If
                If TextBox10.Text = a Then
                    TextBox10.Hide()
                End If
            Else
                TextBox6.Show()
                If TextBox7.Text = a Then
                    TextBox7.Show()
                End If
                If TextBox8.Text = a Then
                    TextBox8.Show()
                End If
                If TextBox9.Text = a Then
                    TextBox9.Show()
                End If
                If TextBox10.Text = a Then
                    TextBox10.Show()
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Try
            If j <= 90 Then
                Label2.Size = New Size(j, 80)
                j += 20
                Label2.Text = teamid(1)
            End If

            If wd <= 730 Then
                Label14.Size = New Size(wd, 80)
                wd += 20
            Else
                Timer3.Stop()
            End If

            Label2.Location = New Point(i1 + 5, 300)
            If i1 <= 50 Then
                i1 = i1 + 10
            End If
        Catch
        End Try

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Try
            If z < len2 Then
                Label10.Text = teamname(1)(z)
                Label10.Location = New Point(m, 302)
                m += 40
                If m >= k Then
                    Label14.Text += Label10.Text
                    z += 1
                    k += 40
                    m = 0
                End If
            Else
                Label10.Visible = False
                TextBox7.Show()
                TextBox7.Text = teamscore(1)
                'TextBox7.ForeColor = Color.Blue
                j = 0
                i1 = 0
                wd = 0
                z = 0
                m = 1025
                k = 160
                Label3.Visible = True
                Timer4.Stop()
                Timer5.Start()
                Timer6.Start()
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Try
            If j <= 90 Then
                Label3.Size = New Size(j, 80)
                j += 20
                Label3.Text = teamid(2)
            End If

            If wd <= 730 Then
                Label15.Size = New Size(wd, 80)
                wd += 20
            Else
                Timer5.Stop()
            End If

            Label3.Location = New Point(i1 + 5, 400)
            If i1 <= 50 Then
                i1 = i1 + 10
            End If
        Catch
        End Try

    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Try
            If z < len3 Then
                Label10.Visible = True
                Label10.Text = teamname(2)(z)
                Label10.Location = New Point(m, 402)
                m -= 100
                If m <= k Then
                    Label15.Text += Label10.Text
                    z += 1
                    k += 40
                    m = 1025
                End If
            Else
                Label10.Visible = False
                TextBox8.Show()
                TextBox8.Text = teamscore(2)
                'TextBox8.ForeColor = Color.Blue
                j = 0
                i1 = 0
                wd = 0
                z = 0
                m = 1025
                k = 160
                Label4.Visible = True
                Timer6.Stop()
                Timer7.Start()
                Timer8.Start()
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Try
            If j <= 90 Then
                Label4.Size = New Size(j, 80)
                j += 20
                Label4.Text = teamid(3)
            End If

            If wd <= 730 Then
                Label16.Size = New Size(wd, 80)
                wd += 20
            Else
                Timer7.Stop()
            End If

            Label4.Location = New Point(i1 + 5, 500)
            If i1 <= 50 Then
                i1 = i1 + 10
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        Try
            If z < len4 Then
                Label10.Text = teamname(3)(z)
                Label10.Location = New Point(m, 498)
                m -= 100
                If m <= k Then
                    Label16.Text += Label10.Text
                    z += 1
                    k += 40
                    m = 1025
                End If
            Else
                Label10.Visible = False
                TextBox9.Show()
                TextBox9.Text = teamscore(3)
                ' TextBox9.ForeColor = Color.Blue
                j = 0
                i1 = 0
                wd = 0
                z = 0
                k = 690
                m = 160
                Label5.Visible = True
                Timer8.Stop()
                Timer9.Start()
                Timer10.Start()
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        Try
            If j <= 90 Then
                Label5.Size = New Size(j, 80)
                j += 20
                Label5.Text = teamid(4)
            End If

            If wd <= 730 Then
                Label13.Size = New Size(wd, 80)
                wd += 20
            Else
                Timer9.Stop()
            End If

            Label5.Location = New Point(i1 + 5, 600)
            If i1 <= 50 Then
                i1 = i1 + 10
            End If
        Catch
        End Try
    End Sub
    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        Try
            If z < len5 Then
                Label10.Visible = True
                Label10.Text = teamname(4)(z)
                Label10.Location = New Point(m, k)
                k -= 10
                If k <= 600 Then
                    Label13.Text += Label10.Text
                    k = 690
                    m += 40
                    z += 1
                End If
            Else
                Label10.Hide()
                TextBox10.Show()
                TextBox10.Text = teamscore(4)

                ' TextBox10.ForeColor = Color.Blue
                j = 0
                i1 = 0
                wd = 0
                z = 0
                m = 0
                k = 0
                Label2.Visible = True
                Timer10.Stop()
            End If
        Catch
        End Try
    End Sub
End Class
Imports System.Data.SqlClient

Public Class uchotel_pkg
    Inherits UserControl
    Private Shared _instanse As uchotel_pkg
    Public Shared ReadOnly Property Instance() As uchotel_pkg
        Get
            If _instanse Is Nothing Then
                _instanse = New uchotel_pkg()
            End If
            Return _instanse
        End Get
    End Property
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btn_pkg_search.Click
        getconnection()
        cmd.Connection = con
        If tb_pi_pkg_id.Enabled = False Then
            tb_pi_pkg_id.Enabled = False
        End If
        cmd.CommandText = "select * from  package_data where pkg_id = " & tb_pi_pkg_id.Text & ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_pkg_name.Text = dr("pkg_name")
            tb_pkg_type.Text = dr("pkg_type")
            tb_pkg_days.Text = dr("day")
            tb_pkg_nights.Text = dr("night")
            tb_pkg_prize.Text = dr("prize")


            If dr("pkg_img").ToString() <> "" Then
                pb_pkg_img.Image = global_class.view(dr("pkg_img"))
            Else
                pb_pkg_img.Image = Infinity.My.Resources.user
            End If

        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_pkg_reset_Click(sender As Object, e As EventArgs) Handles btn_pkg_reset.Click
        global_class.clearAllmetrobunifuTextbo(pan_view_pkg)
        pb_pkg_img.Image = Nothing
    End Sub

    Private Sub uchotel_pkg_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        pan_all_pkg_detail.Controls.Clear()
    End Sub
    Private Sub tb_pi_pkg_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_pi_pkg_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

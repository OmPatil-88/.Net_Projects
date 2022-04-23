Imports System.Data.SqlClient

Public Class uchotel_room_manegement
    Inherits UserControl
    Private Shared _instanse As uchotel_room_manegement
    Public Shared ReadOnly Property Instance() As uchotel_room_manegement
        Get
            If _instanse Is Nothing Then
                _instanse = New uchotel_room_manegement()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        getconnection()

        cmd = New SqlCommand("select * from  room_data where room_no = " + tb_room_no.Text + "", con)

        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_room_id.Text = dr("room_id")
            cmb_room_type.Text = dr("room_type")
            tb_room_total_capacity.Text = dr("total_capacity")
            tb_room_prize.Text = dr("prize")
            tb_desc.Text = dr("romm_desc")
            If dr("room_img").ToString() <> "" Then
                pb_room_images.Image = global_class.view(dr("room_img"))
            Else
                pb_room_images.Image = Infinity.My.Resources.user
            End If

        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If

        endconnection()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        global_class.clearAllmetrobunifuTextbo(pan_rm_room)
        global_class.clearAllcombo_box(pan_rm_room)

        pb_room_images.Image = Nothing
    End Sub

    Private Sub tb_room_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_room_no.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        grid_load("select * from room_data", dg_rm_ri_view)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If cmb_Search_type.Text <> "" And tb_search_type.Text <> "" Then
            If cmb_Search_type.Text = "Guest name" Then
                grid_load("select * from room_data where room_id like '%" + tb_search_type.Text + "%'", dg_rm_ri_view)
            ElseIf cmb_Search_type.Text = "Check In ID" Then
                grid_load("select * from room_data where room_no like '%" + tb_search_type.Text + "%'", dg_rm_ri_view)
            End If
        Else
            MessageBox.Show("please select all options")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

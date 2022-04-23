Imports System.Data.SqlClient

Public Class uc_hotel_guest
    Inherits UserControl
    Private Shared _instanse As uc_hotel_guest
    Public Shared ReadOnly Property Instance() As uc_hotel_guest
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_hotel_guest()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_search_guest_Click(sender As Object, e As EventArgs) Handles btn_search_guest.Click
        getconnection()
        cmd = New SqlCommand("select s_services_name from Guest_Extra_services_Freezed where Check_id=" & tb_gi_guest_id.Text & "", con)
        Dim sd As SqlDataReader
        sd = cmd.ExecuteReader()
        cb_add_services.Items.Clear()
        While sd.Read()
            cb_add_services.Items.Add(sd("s_services_name").ToString)
        End While
        sd.Close()
        cmd.Dispose()
        endconnection()
        '**********************************************************************************************************************************
        getconnection()
        If tb_gi_guest_id.Text = "" Then
            MsgBox("Plese Fill Id")
        Else
            Dim d As SqlDataReader
            cmd = New SqlCommand("select * from  Guest_data where Check_id = " + tb_gi_guest_id.Text + "", con)
            d = cmd.ExecuteReader
            If d.Read() Then
                tb_gi_name.Text = d("guest_name")
                tb_gi_midname.Text = d("guest_m_name")
                tb_gi_sirname.Text = d("guest_l_name")
                tb_gi_permadd.Text = d("guest_address")
                tb_permobile_number.Text = d("guest_mobile_number1")
                tb_optmobile_number.Text = d("guest_mobile_number2")
                dtp_check_in_date.Text = d("cin_date")
                dtp_check_out_date.Text = d("cout_date")
                tb_gi_days.Text = d("c_days")
                tb_gi_nights.Text = d("c_nights")
                tb_gi_adults.Text = d("c_adults")
                tb_gi_children.Text = d("c_childrens")
                tb_gi_room_no.Text = d("c_room_no")
                tb_gi_room_type.Text = d("c_room_type")
                tb_gi_package_name.Text = d("c_pkg_name")
                tb_gi_final_amount.Text = d("c_total_amount_paid")
                tb_gi_Gst.Text = d("c_gst")
                tb_discount.Text = d("c_discount")
                d.Close()
            Else
                MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

            End If
        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_resert_guest_Click(sender As Object, e As EventArgs) Handles btn_resert_guest.Click
        global_class.clearAllbunifuTextbo(gb_personal)
        global_class.clearAllbunifuTextbo(gb_professional)
        global_class.clearAlldatetimepicker(gb_professional)
        cb_add_services.Items.Clear()
        tb_gi_final_amount.Text = ""
    End Sub

    Private Sub tb_gi_guest_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gi_guest_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        grid_load("select * from Guest_data", dgv_guest_info)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If cmb_Search_type.Text <> "" And search_type.Text <> "" Then
            If cmb_Search_type.Text = "Guest name" Then
                grid_load("select * from Guest_data where guest_name like '%" + search_type.Text + "%' and cout_date between '" + dtp_start.Value + "' and '" + dtp_end.Value + "' ", dgv_guest_info)
            ElseIf cmb_Search_type.Text = "Check In ID" Then
                grid_load("select * from Guest_data where Check_id like '%" + search_type.Text + "%' and cout_date between '" + dtp_start.Value + "' and '" + dtp_end.Value + "' ", dgv_guest_info)
            End If
        Else
            MessageBox.Show("please select all options")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

Imports System.Data.SqlClient

Public Class uchome_check_in
    Inherits UserControl
    Private Shared _instanse As uchome_check_in
    Public deta As Date
    Public room_rent As Integer = 0.0
    Public pkg_price As Double = 0.0
    Public Shared ReadOnly Property Instance() As uchome_check_in
        Get
            If _instanse Is Nothing Then
                _instanse = New uchome_check_in()
            End If
            Return _instanse
        End Get
    End Property
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        grid_load("select * from check_in_check_out", dgv_check_in)
    End Sub

    Private Sub btn_home_chenin_search_Click(sender As Object, e As EventArgs) Handles btn_home_chenin_search.Click
        getconnection()
        If tb_reservation_id.Text = "" Then
            MsgBox("Plese Fill Id")
        Else
            cmd = New SqlCommand("select * from  Reservation_data where r_id = " + tb_reservation_id.Text + "", con)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                tb_guest_name.Text = dr("r_guest_name")
                tb_ch_middle_name.Text = dr("r_middle_name")
                tb_ch_surname.Text = dr("r_last_name")
                tb_ch_permadd.Text = dr("r_address")
                tb_per_mobile.Text = dr("r_mobile_number")
                tb_optional_numer.Text = dr("r_opt_mobile_number")
                cmb_discount_name.Text = dr("r_discount_name")
                tb_discount.Text = dr("r_discount")
                tb_ch_days.Text = dr("r_days")
                tb_ch_night.Text = dr("r_nights")
                tb_ch_adults.Text = dr("r_adults")
                tb_ch_childrens.Text = dr("r_no_childerns")
                cmb_pkg_name.Text = dr("r_pkg_name")
                pkg_price = dr("r_total")
                tb_total_amount.Text = dr("r_total")
                tb_advance_payment.Text = dr("r_advance")
                tb_sub_total.Text = dr("r_sub_total")
            Else
                MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

            End If
        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub tb_per_mobile_Leave(sender As Object, e As EventArgs) Handles tb_per_mobile.Leave
        If tb_per_mobile.Text = "" Then
            tb_per_mobile.Text = "PERMANENT NUMBER"
            tb_per_mobile.ForeColor = Color.Silver
        Else
            tb_per_mobile.ForeColor = Color.Black
        End If

    End Sub

    Private Sub tb_optional_numer_Leave(sender As Object, e As EventArgs) Handles tb_optional_numer.Leave
        If tb_optional_numer.Text = "" Then
            tb_optional_numer.Text = "OPTOIONAL NUMBER"
            tb_optional_numer.ForeColor = Color.Silver
        Else
            tb_optional_numer.ForeColor = Color.Black
        End If

    End Sub

    Private Sub tb_per_mobile_Enter(sender As Object, e As EventArgs) Handles tb_per_mobile.Enter
        If tb_per_mobile.Text = "PERMANENT NUMBER" Then
            tb_per_mobile.Text = ""
        End If
    End Sub

    Private Sub tb_optional_numer_Enter(sender As Object, e As EventArgs) Handles tb_optional_numer.Enter
        If tb_optional_numer.Text = "OPTOIONAL NUMBER" Then
            tb_optional_numer.Text = ""
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            btn_checkin_id_search.Visible = True
            btn_extend_package_date.Visible = True
            For Each obj As Control In pan_main_payment.Controls
                obj.Enabled = False
            Next
            For Each obj As Control In pan_main_personal.Controls
                obj.Enabled = False
            Next
            tb_check_id.Enabled = True
            dtp_check_out_date.Enabled = True
            btn_extend_package_date.Enabled = True
            btn_checkin_id_search.Enabled = True
        Else
            btn_checkin_id_search.Visible = False
            btn_extend_package_date.Visible = False
            For Each obj As Control In pan_main_payment.Controls
                obj.Enabled = True
            Next
            For Each obj As Control In pan_main_personal.Controls
                obj.Enabled = True
            Next
        End If
    End Sub
    Private Sub tb_reset_Click(sender As Object, e As EventArgs) Handles tb_reset.Click
        global_class.clearAllbunifuTextbo(pan_main_personal)
        global_class.clearAllbunifuTextbo(pan_main_payment)
        global_class.clearAlldatetimepicker(pan_main_personal)
        global_class.clearAllCombo(pan_main_payment)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select count(Check_id)from check_in_check_out"
        Dim y As Integer = cmd.ExecuteScalar()
        If y = 0 Then
            cmd.Dispose()
            uchome_check_in.Instance.tb_check_id.Text = autoincr("select max(Check_id) from Guest_data", 1)
        Else
            cmd.Dispose()
            cmd = New SqlCommand("select max(Check_id)from check_in_check_out", con)
            If IsDBNull(cmd.ExecuteScalar) Then
                uchome_check_in.Instance.tb_check_id.Text = 1000
            Else
                uchome_check_in.Instance.tb_check_id.Text = cmd.ExecuteScalar + 1
                cmd.Dispose()
            End If

        End If
        endconnection()
        tb_optional_numer.Text = "OPTOIONAL NUMBER"
        tb_per_mobile.Text = "PERMANENT NUMBER"
    End Sub

    Private Sub cmb_ch_room_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ch_room_type.SelectedIndexChanged
        If tb_Room_no.Text <> "" Then
            getconnection()
            cmd = New SqlCommand("select prize from room_data where room_no= " + tb_Room_no.Text + " and room_type='" + cmb_ch_room_type.Text + "'", con)
            room_rent = cmd.ExecuteScalar()
            tb_total_amount.Text = Val(tb_total_amount.Text) + room_rent
            cmd.Dispose()
            endconnection()
        End If
    End Sub

    Private Sub tb_Room_no_OnValueChanged(sender As Object, e As EventArgs) Handles tb_Room_no.OnValueChanged
        If tb_Room_no.Text <> "" Then
            getconnection()
            cmd = New SqlCommand("select prize from room_data where room_no = " + tb_Room_no.Text + " and room_type='" + cmb_ch_room_type.Text + "'", con)
            room_rent = cmd.ExecuteScalar()
            tb_total_amount.Text = Val(tb_total_amount.Text) + room_rent
            cmd.Dispose()
            endconnection()
        End If
    End Sub

    Private Sub cmb_pkg_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pkg_name.SelectedIndexChanged
        If cmb_ch_room_type.Text <> "" Then
            getconnection()
            cmd = New SqlCommand("select prize from package_data where pkg_name ='" + cmb_pkg_name.Text + "'", con)
            pkg_price = cmd.ExecuteScalar()
            tb_total_amount.Text = Val(tb_total_amount.Text) + pkg_price
            cmd.Dispose()
            endconnection()
            '****************************************************************************************************************************************
            getconnection()
            cmd = New SqlCommand("select * from package_data where pkg_name = '" & cmb_pkg_name.Text & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                cmb_discount_name.Text = dr("discount_name")
                tb_discount.Text = dr("discount")
            End If
            dr.Close()
            con.Close()
            endconnection()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If tb_ch_adults.Text = "" Then
            tb_ch_adults.Text = 0
        End If
        If tb_ch_adults.Text <> 0 Then
            tb_ch_adults.Text = tb_ch_adults.Text - 1
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If tb_ch_adults.Text = "" Then
            tb_ch_adults.Text = 0
        End If
        tb_ch_adults.Text = tb_ch_adults.Text + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If tb_ch_childrens.Text = "" Then
            tb_ch_childrens.Text = 0
        End If
        If tb_ch_childrens.Text <> 0 Then
            tb_ch_childrens.Text = tb_ch_childrens.Text - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tb_ch_childrens.Text = "" Then
            tb_ch_childrens.Text = 0
        End If
        tb_ch_childrens.Text = tb_ch_childrens.Text + 1
    End Sub

    Private Sub tb_advance_payment_OnValueChanged(sender As Object, e As EventArgs) Handles tb_advance_payment.OnValueChanged
        tb_sub_total.Text = Val(tb_total_amount.Text) - Val(tb_advance_payment.Text)
    End Sub
    Private Sub btn_check_in_Click(sender As Object, e As EventArgs) Handles btn_check_in.Click
        getconnection()
        cmd = New SqlCommand("insert into check_in_check_out values(" & tb_check_id.Text & ",'" & tb_guest_name.Text & "','" & tb_ch_middle_name.Text & "','" & tb_ch_surname.Text & "','" & tb_ch_permadd.Text + "'," & tb_per_mobile.Text & "," & tb_optional_numer.Text & ",'" & dtp_check_in_date.Text & "','" & dtp_check_out_date.Text & "'," & tb_ch_days.Text & "," & tb_ch_night.Text & "," & tb_ch_adults.Text & "," & tb_ch_childrens.Text & "," & tb_Room_no.Text & ",'" & cmb_ch_room_type.Text & "','" & cmb_pkg_name.Text & "'," & tb_total_amount.Text & "," & tb_advance_payment.Text & "," & tb_sub_total.Text & "," & tb_ch_Gst.Text & "," & tb_discount.Text & ",'" & cmb_discount_name.Text & "'," & pkg_price & "," & room_rent & ")", con)
        If tb_check_id.Text <> "" And tb_guest_name.Text <> "" And tb_ch_middle_name.Text <> "" And tb_ch_surname.Text <> "" And tb_ch_permadd.Text <> "" And tb_per_mobile.Text <> "" And tb_optional_numer.Text <> "" And dtp_check_in_date.Text <> "" And dtp_check_out_date.Text <> "" And tb_ch_days.Text <> "" And tb_ch_night.Text <> "" And tb_ch_adults.Text <> "" And tb_ch_childrens.Text <> "" And tb_Room_no.Text <> "" And cmb_ch_room_type.Text <> "" And cmb_pkg_name.Text <> "" And tb_total_amount.Text <> "" And tb_advance_payment.Text <> "" And tb_ch_Gst.Text <> "" And tb_discount.Text <> "" And cmb_discount_name.Text <> "" And tb_sub_total.Text <> "" Then
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                cmd.Dispose()
                MessageBox.Show("Id is Activated ", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cmd = New SqlCommand("delete from Reservation_data where r_id=" & tb_check_id.Text & "", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                global_class.clearAllbunifuTextbo(pan_main_personal)
                global_class.clearAllbunifuTextbo(pan_main_payment)
                global_class.clearAlldatetimepicker(pan_main_personal)
                global_class.clearAllCombo(pan_main_payment)
                getconnection()
                grid_load("select *  from check_in_check_out ", uchome_check_in.Instance.dgv_check_in)
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "select count(Check_id)from check_in_check_out"
                Dim y As Integer = cmd.ExecuteScalar()
                If y < 0 Then
                    cmd.Dispose()
                    cmd = New SqlCommand("select max(Check_id)from check_in_check_out", con)
                    If IsDBNull(cmd.ExecuteScalar) Then
                        tb_check_id.Text = 1000
                    Else
                        tb_check_id.Text = cmd.ExecuteScalar + 1
                        cmd.Dispose()
                    End If
                Else
                    cmd.Dispose()
                    tb_check_id.Text = autoincr("select count(Check_id) from Guest_data", 1000)
                End If
                endconnection()
                tb_optional_numer.Text = "OPTOIONAL NUMBER"
                tb_per_mobile.Text = "PERMANENT NUMBER"
                grid_load("select * from check_in_check_out  ", dgv_check_in)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub btn_checkin_id_search_Click(sender As Object, e As EventArgs) Handles btn_checkin_id_search.Click
        getconnection()
        If tb_check_id.Text = "" Then
            MsgBox("Plese Fill Id")
        Else
            Dim d As SqlDataReader
            cmd = New SqlCommand("select * from  check_in_check_out where Check_id = " + tb_check_id.Text + "", con)
            d = cmd.ExecuteReader
            If d.Read() Then
                tb_guest_name.Text = d("guest_name")
                tb_ch_middle_name.Text = d("guest_m_name")
                tb_ch_surname.Text = d("guest_l_name")
                tb_ch_permadd.Text = d("guest_address")
                tb_per_mobile.Text = d("guest_mobile_number1")
                tb_optional_numer.Text = d("guest_mobile_number2")
                dtp_check_in_date.Text = d("cin_date")
                dtp_check_out_date.Text = d("cout_date")
                deta = d("cout_date")
                tb_ch_days.Text = d("c_days")
                tb_ch_night.Text = d("c_nights")
                tb_ch_adults.Text = d("c_adults")
                tb_ch_childrens.Text = d("c_childrens")
                tb_Room_no.Text = d("c_room_no")
                cmb_ch_room_type.Text = d("c_room_type")
                cmb_pkg_name.Text = d("c_pkg_name")
                tb_total_amount.Text = d("c_total_amount")
                tb_advance_payment.Text = d("c_advance_paid")
                tb_sub_total.Text = d("c_sub_total")
                tb_ch_Gst.Text = d("c_gst")
                tb_discount.Text = d("c_discount")
                cmb_discount_name.Text = d("c_discout_name")
                d.Close()
            Else
                MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

            End If
        End If

        con.Close()
        endconnection()
    End Sub

    Private Sub btn_extend_package_date_Click(sender As Object, e As EventArgs) Handles btn_extend_package_date.Click
        If deta > dtp_check_out_date.Value Then
            MsgBox("Invalid attempt to reduse the date You can only Extend The Date", MsgBoxStyle.Critical,)
        Else
            getconnection()
            cmd = New SqlCommand("update check_in_check_out set cout_date='" + dtp_check_out_date.Text + "'", con)
            If cmd.ExecuteNonQuery() Then
                MsgBox("ID Extended")
            Else
                MsgBox("Server Eroor")
            End If
            endconnection()
        End If
    End Sub

    Private Sub btn_serch_grid_Click(sender As Object, e As EventArgs) Handles btn_serch_grid.Click
        If cmb_search_type.Text <> "" And tb_serch.Text <> "" Then
            If cmb_search_type.Text = "Check In ID" Then
                grid_load(" select * from check_in_check_out where Check_id like '%" + tb_serch.Text + "%' ", dgv_check_in)
            ElseIf cmb_search_type.Text = "Guest Name" Then
                grid_load(" select * from check_in_check_out where guest_name like '%" + tb_serch.Text + "%' ", dgv_check_in)
            ElseIf cmb_search_type.Text = "Package" Then
                grid_load(" select * from check_in_check_out where c_pkg_name  Name like '%" + tb_serch.Text + "%' ", dgv_check_in)
            End If
        End If
    End Sub
    Private Sub Isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_ch_childrens.KeyPress, tb_discount.KeyPress, tb_ch_adults.KeyPress, tb_ch_night.KeyPress, tb_ch_days.KeyPress, tb_per_mobile.KeyPress, tb_ch_Gst.KeyPress, tb_sub_total.KeyPress, tb_optional_numer.KeyPress, tb_total_amount.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub IsChar(sender As Object, e As KeyPressEventArgs) Handles tb_guest_name.KeyPress, tb_ch_surname.KeyPress, tb_ch_middle_name.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Lf AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        uchome_check_in.Instance.Hide()
    End Sub

    Private Sub uchome_check_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

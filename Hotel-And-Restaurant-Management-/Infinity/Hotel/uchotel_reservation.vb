Imports System.Data.SqlClient

Public Class uchotel_reservation
    Inherits UserControl
    Private Shared _instanse As uchotel_reservation
    Public Shared ReadOnly Property Instance() As uchotel_reservation
        Get
            If _instanse Is Nothing Then
                _instanse = New uchotel_reservation()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If tb_rm_adults.Text = "" Then
            tb_rm_adults.Text = 0
        End If
        tb_rm_adults.Text = tb_rm_adults.Text + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tb_rm_childrens.Text = "" Then
            tb_rm_childrens.Text = 0
        End If
        tb_rm_childrens.Text = tb_rm_childrens.Text + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If tb_rm_childrens.Text = "" Then
            tb_rm_childrens.Text = 0
        End If
        If tb_rm_childrens.Text > 0 Then

            tb_rm_childrens.Text = tb_rm_childrens.Text - 1
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If tb_rm_adults.Text = "" Then
            tb_rm_adults.Text = 0
        End If
        If tb_rm_adults.Text <> 0 Then
            tb_rm_adults.Text = tb_rm_adults.Text - 1
        End If
    End Sub

    Private Sub cmb_rm_pkg_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_rm_pkg_name.SelectedIndexChanged
        getconnection()
        cmd = New SqlCommand("select * from package_data where pkg_name = '" & cmb_rm_pkg_name.Text & "'", con)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_rm_total_amount.Text = dr("prize")
            cmb_rm_discount_name.Text = dr("discount_name")
            tb_rm_discount.Text = dr("discount")
        End If
        dr.Close()
        con.Close()
        endconnection()
    End Sub

    Private Sub tb_rm_advance_payment_OnValueChanged(sender As Object, e As EventArgs) Handles tb_rm_advance_payment.OnValueChanged
        tb_rm_sub_total.Text = Val(tb_rm_total_amount.Text) - Val(tb_rm_advance_payment.Text)
    End Sub

    Private Sub cb_apply_discount_CheckedChanged(sender As Object, e As EventArgs) Handles cb_apply_discount.CheckedChanged
        If cb_apply_discount.Checked = True Then
            tb_rm_total_amount.Text = Val(tb_rm_total_amount.Text) - (Val(tb_rm_total_amount.Text) * (Val(tb_rm_discount.Text) / 100))
        Else
            tb_rm_total_amount.Text = Val(tb_rm_total_amount.Text) + (Val(tb_rm_total_amount.Text) * (Val(tb_rm_discount.Text) / 100))
        End If
    End Sub

    Private Sub tb_rm_total_amount_OnValueChanged(sender As Object, e As EventArgs) Handles tb_rm_total_amount.OnValueChanged
        tb_rm_sub_total.Text = Val(tb_rm_total_amount.Text) - Val(tb_rm_advance_payment.Text)
    End Sub

    Private Sub btn_rm_book_reservation_Click(sender As Object, e As EventArgs) Handles btn_rm_book_reservation.Click
        getconnection()
        cmd = New SqlCommand("insert into Reservation_data values(" & tb_rm_rid.Text & ",'" & tb_rm_name.Text & "','" & tb_rm_middlename.Text & "','" & tb_rm_surname.Text & "','" & tb_rm_permadd.Text + "'," & tb_permobile_number.Text & "," & tb_optmobile_number.Text & ",'" & dtp_rm_res_date.Text & "','" & dtp_rm_check_in_date.Text & "','" & cmb_rm_discount_name.Text & "'," & tb_rm_discount.Text & "," & tb_rm_no_of_days.Text & "," & tb_rm_no_of_nights.Text & "," & tb_rm_adults.Text & "," & tb_rm_childrens.Text & ",'" & cmb_rm_pkg_name.Text & "'," & tb_rm_total_amount.Text & "," & tb_rm_advance_payment.Text & "," & tb_rm_sub_total.Text & ")", con)
        If tb_rm_rid.Text <> "" And tb_rm_middlename.Text <> "" And tb_rm_surname.Text <> "" And tb_rm_permadd.Text <> "" And tb_permobile_number.Text <> "" And tb_optmobile_number.Text <> "" And dtp_rm_res_date.Text <> "" And dtp_rm_check_in_date.Text <> "" And cmb_rm_discount_name.Text <> "" And tb_rm_discount.Text <> "" And tb_rm_no_of_days.Text <> "" And tb_rm_no_of_nights.Text <> "" And tb_rm_adults.Text <> "" And tb_rm_childrens.Text <> "" And cmb_rm_pkg_name.Text <> "" And tb_rm_total_amount.Text <> "" And tb_rm_advance_payment.Text <> "" And tb_rm_sub_total.Text <> "" Then
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("Booking Succesfull!!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                global_class.clearAllbunifuTextbo(pan_main_reservation)
                global_class.clearAlldatetimepicker(pan_main_reservation)
                global_class.clearAllbunifuTextbo(pan_balence_info)
                global_class.clearAllcombo_box(pan_balence_info)
                tb_rm_rid.Text = autoincr("select count(r_id) from Reservation_data", 1000)
                grid_load("select * Reservation_data from ", dgv_rm_grid)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_rm_grid_refresh_Click(sender As Object, e As EventArgs) Handles btn_rm_grid_refresh.Click
        grid_load("select * Reservation_data from ", dgv_rm_grid)
    End Sub

    Private Sub btn_grid_Search_Click(sender As Object, e As EventArgs) Handles btn_grid_Search.Click
        If cmb_search_type.Text <> "" And tb_search_type.Text <> "" Then
            If cmb_search_type.Text = "Guest name" Then
                grid_load("select * from Reservation_data where r_guest_name like '%" + tb_search_type.Text + "%' and r_check_in_date between '" + dtp_start.Value + "' and '" + dtp_end.Value + "' ", dgv_rm_grid)
            ElseIf cmb_search_type.Text = "Reservation In ID" Then
                grid_load("select * from Reservation_data where r_id like '%" + tb_search_type.Text + "%' and r_check_in_date between '" + dtp_start.Value + "' and '" + dtp_end.Value + "' ", dgv_rm_grid)
            End If
        Else
            MessageBox.Show("please select all options")
        End If
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_rm_rid.KeyPress, tb_rm_childrens.KeyPress, tb_rm_adults.KeyPress, tb_rm_no_of_nights.KeyPress, tb_rm_sub_total.KeyPress, tb_rm_no_of_days.KeyPress, tb_permobile_number.KeyPress, tb_optmobile_number.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub IsChar(sender As Object, e As KeyPressEventArgs) Handles tb_rm_middlename.KeyPress, tb_rm_name.KeyPress, tb_rm_surname.KeyPress, tb_rm_permadd.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Lf AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

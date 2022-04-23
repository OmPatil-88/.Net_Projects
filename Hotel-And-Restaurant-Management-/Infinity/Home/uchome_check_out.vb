Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class uchome_check_out
    Inherits UserControl
    Private Shared _instanse As uchome_check_out
    Public final_total As Double
    Public Shared ReadOnly Property Instance() As uchome_check_out
        Get
            If _instanse Is Nothing Then
                _instanse = New uchome_check_out()
            End If
            Return _instanse
        End Get
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_home_chek_in_search_Click(sender As Object, e As EventArgs) Handles btn_home_chek_in_search.Click
        getconnection()
        cmd = New SqlCommand("select s_services_name from Guest_Extra_services where Check_id=" & tb_ch_id.Text & "", con)
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
        If tb_ch_id.Text = "" Then
            MsgBox("Plese Fill Id")
        Else
            Dim d As SqlDataReader
            cmd = New SqlCommand("select * from  check_in_check_out where Check_id = " + tb_ch_id.Text + "", con)
            d = cmd.ExecuteReader
            If d.Read() Then
                tb_guest_name.Text = d("guest_name")
                tb_ch_middle_name.Text = d("guest_m_name")
                tb_ch_surname.Text = d("guest_l_name")
                tb_ch_permadd.Text = d("guest_address")
                tb_perment_mobile.Text = d("guest_mobile_number1")
                tb_optional_number.Text = d("guest_mobile_number2")
                dtp_check_in_date.Text = d("cin_date")
                dtp_check_out_date.Text = d("cout_date")
                tb_ch_days.Text = d("c_days")
                tb_ch_night.Text = d("c_nights")
                tb_ch_adults.Text = d("c_adults")
                tb_ch_childrens.Text = d("c_childrens")
                tb_Room_no.Text = d("c_room_no")
                cmb_ch_room_type.Text = d("c_room_type")
                cmb_pkg_name.Text = d("c_pkg_name")
                tb_advance_payment.Text = d("c_advance_paid")
                tb_old_check_in_amount.Text = d("c_total_amount")
                tb_ch_Gst.Text = d("c_gst")
                tb_discount.Text = d("c_discount")
                cmb_discount_name.Text = d("c_discout_name")
                room_rent.Text = d("c_room_price")
                pkg_rent.Text = d("c_pkg_price")
                d.Close()

            Else
                MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

            End If
        End If

        '******************************************************************************************************************************************
        con.Close()
        endconnection()
    End Sub

    Private Sub tb_extra_services_cost_OnValueChanged(sender As Object, e As EventArgs) Handles tb_extra_services_cost.OnValueChanged
        tb_final_total.Text = (Val(tb_extra_services_cost.Text) + Val(tb_old_check_in_amount.Text)) - Val(tb_advance_payment.Text)
    End Sub
    Private Sub tb_amount_paid_in_check_out_OnValueChanged(sender As Object, e As EventArgs) Handles tb_amount_paid_in_check_out.OnValueChanged
        tb_change_of_money.Text = Val(tb_amount_paid_in_check_out.Text) - Val(tb_grand_total.Text)
        If tb_change_of_money.Text < 0 Then
            tb_change_of_money.Text = ""
        End If
    End Sub

    Private Sub btn_chek_out_Click(sender As Object, e As EventArgs) Handles btn_chek_out.Click
        If CheckBox1.Checked = False Then
            tb_ch_Gst.Text = 0
        End If
        If CheckBox2.Checked = False Then
            tb_discount.Text = 0
        End If

        getconnection()
        cmd = New SqlCommand("insert into Guest_data values(" & tb_ch_id.Text & ",'" & tb_guest_name.Text & "','" & tb_ch_middle_name.Text & "','" & tb_ch_surname.Text & "','" & tb_ch_permadd.Text + "'," & tb_perment_mobile.Text & "," & tb_optional_number.Text & ",'" & dtp_check_in.Text & "','" & dtp_check_out_date.Text & "'," & tb_ch_days.Text & "," & tb_ch_night.Text & "," & tb_ch_adults.Text & "," & tb_ch_childrens.Text & "," & tb_Room_no.Text & ",'" & cmb_ch_room_type.Text & "','" & cmb_pkg_name.Text & "'," & final_total & "," & tb_ch_Gst.Text & "," & tb_discount.Text & ",'" & cmb_discount_name.Text & "'," & pkg_rent.Text & "," & room_rent.Text & ")", con)
        If tb_ch_id.Text <> "" And tb_guest_name.Text <> "" And tb_ch_middle_name.Text <> "" And tb_ch_surname.Text <> "" And tb_ch_permadd.Text <> "" And tb_perment_mobile.Text <> "" And tb_optional_number.Text <> "" And dtp_check_in.Text <> "" And dtp_check_out_date.Text <> "" And tb_ch_days.Text <> "" And tb_ch_night.Text <> "" And tb_ch_adults.Text <> "" And tb_ch_childrens.Text <> "" And tb_Room_no.Text <> "" And cmb_ch_room_type.Text <> "" And cmb_pkg_name.Text <> "" And tb_advance_payment.Text <> "" And tb_ch_Gst.Text <> "" And tb_discount.Text <> "" And cmb_discount_name.Text <> "" And (CheckBox1.Checked = True Or CheckBox2.Checked = True) Then
            If (cmd.ExecuteNonQuery() > 0) Then
                MessageBox.Show("Id is Deactivated ", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cmd.Dispose()
                Dim cnt As Integer
                cmd = New SqlCommand("select count(Check_id) from Guest_Extra_services where Check_id=" + tb_ch_id.Text + " ", con)
                cnt = cmd.ExecuteScalar()
                cmd.Dispose()
                While cnt > 0

                    Dim sdr As SqlDataReader
                    cmd = New SqlCommand("select * from  Guest_Extra_services where Check_id = " + tb_ch_id.Text + "", con)
                    sdr = cmd.ExecuteReader
                    sdr.Read()
                    cmd.Dispose()

                    cmd = New SqlCommand("insert into Guest_Extra_services_Freezed values(" & sdr("Check_id") & "," & sdr("s_id") & ",'" & sdr("s_services_name") & "'," & sdr("prize").ToString & ")", con)
                    Dim s_id As Integer = sdr("s_id")
                    Dim check_id As Integer = sdr("Check_id")
                    Dim service_name As String = sdr("s_services_name")
                    Dim prize As Double = sdr("prize").ToString
                    sdr.Close()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New SqlCommand("select count(s_id) from Guest_Extra_services where s_id=" & s_id & "", con)
                    Dim i As Integer = cmd.ExecuteScalar()
                    cmd.Dispose()
                    While i > 1
                        cmd = New SqlCommand("insert into Guest_Extra_services_Freezed values(" & check_id & "," & s_id & ",'" & service_name & "'," & prize & ")", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        i = i - 1
                        cnt = cnt - 1
                    End While
                    cmd = New SqlCommand("delete from Guest_Extra_services where s_id=" & s_id & "", con)
                    cmd.ExecuteNonQuery()
                    cnt = cnt - 1
                End While
                cmd = New SqlCommand("delete from check_in_check_out where Check_id=" & tb_ch_id.Text & "", con)
                cmd.ExecuteNonQuery()
                '***************************************************************************report
                Dim dt As New DataTable
                Dim addpter As SqlDataAdapter

                cmd = New SqlCommand("SELECT * from Guest_data join Guest_Extra_services_Freezed on Guest_data.Check_id=Guest_Extra_services_Freezed.Check_id where Guest_data.Check_id=" + tb_ch_id.Text + "", con)
                addpter = New SqlDataAdapter(cmd)
                addpter.Fill(dt)
                If dt.Rows.Count <> 0 Then
                    Dim report As New Hotel_bill_rpt
                    report.DataSource = dt
                    report.DataAdapter = addpter
                    report.DataMember = "Guest_data"
                    Dim tool As ReportPrintTool = New ReportPrintTool(report)
                    report.CreateDocument()
                    Hotel_bill.doc_hotel_bill.DocumentSource = report
                    Hotel_bill.ShowDialog()
                Else
                    MessageBox.Show("No Record found!!!!!!!!!!")
                End If

                global_class.clearAllbunifuTextbo(pan_personal)
                global_class.clearAllbunifuTextbo(pan_service)
                global_class.clearAlldatetimepicker(pan_personal)
                global_class.clearAllCombo(pan_service)
                tb_perment_mobile.Text = "OPTOIONAL NUMBER"
                tb_optional_number.Text = "PERMANENT NUMBER"
                cb_add_services.Items.Clear()
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()

        endconnection()
    End Sub

    Private Sub tb_reset_Click(sender As Object, e As EventArgs) Handles tb_reset.Click
        global_class.clearAllbunifuTextbo(pan_personal)
        global_class.clearAllbunifuTextbo(pan_service)
        global_class.clearAlldatetimepicker(pan_personal)
        global_class.clearAllCombo(pan_service)
        tb_perment_mobile.Text = "OPTOIONAL NUMBER"
        tb_optional_number.Text = "PERMANENT NUMBER"
        cb_addtional_servises.Items.Clear()
    End Sub

    Private Sub cb_add_services_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_add_services.SelectedValueChanged
        Dim total As Double = 0.0
        For Each item In cb_add_services.CheckedItems
            getconnection()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            ' Dim cnt As Integer = clb_services.Items.IndexOf(item)
            cmd.CommandText = "select prize from service_data where s_name='" & cb_add_services.Items(cb_add_services.Items.IndexOf(item)).ToString & "'"
            total = total + cmd.ExecuteScalar()
            cmd.Dispose()
            endconnection()
        Next
        tb_extra_services_cost.Text = total
    End Sub

    Private Sub cb_add_services_Leave(sender As Object, e As EventArgs) Handles cb_add_services.Leave
        Dim total As Double = 0.0
        For Each item In cb_add_services.CheckedItems
            getconnection()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            ' Dim cnt As Integer = clb_services.Items.IndexOf(item)
            cmd.CommandText = "select prize from service_data where s_name='" & cb_add_services.Items(cb_add_services.Items.IndexOf(item)).ToString & "'"
            total = total + cmd.ExecuteScalar()
            cmd.Dispose()
            endconnection()
        Next
        tb_extra_services_cost.Text = total
    End Sub
    '********************************************************************************************************************************************************validation
    Private Sub Isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_ch_id.KeyPress, tb_discount.KeyPress, tb_extra_services_cost.KeyPress, tb_final_amount.KeyPress, tb_final_total.KeyPress, tb_old_check_in_amount.KeyPress, tb_ch_Gst.KeyPress, tb_sub_total.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            final_total = Val(tb_final_total.Text) * ((100 + Val(tb_ch_Gst.Text)) / 100)
            tb_grand_total.Text = final_total
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            final_total = Val(tb_final_total.Text) * ((100 - Val(tb_ch_Gst.Text)) / 100)
            tb_grand_total.Text = final_total
        End If
    End Sub
End Class

Imports System.Data.SqlClient
Imports System.IO

Public Class ucr_stock
    Inherits UserControl
    Private Shared _instanse As ucr_stock
    Public Shared ReadOnly Property Instance() As ucr_stock
        Get
            If _instanse Is Nothing Then
                _instanse = New ucr_stock()
            End If
            Return _instanse
        End Get
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub tb_emp_id_Leave(sender As Object, e As EventArgs) Handles tb_emp_id.Leave
        getconnection()
        cmd = New SqlCommand("select e_name,e_surname from  emplyee_detail where e_id = " + tb_emp_id.Text + "", con)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_emp_name.Text = (dr("e_name") + " " + dr("e_surname").ToString)
        End If
        dr.Close()
        cmd.Dispose()
        endconnection()
    End Sub


    Private Sub btn_search_id_Click(sender As Object, e As EventArgs) Handles btn_search_id.Click
        getconnection()
        cmd.Connection = con
        If tb_stock_bill_id.Enabled = False Then
            tb_stock_bill_id.Enabled = False
            tb_stock_bill_id.Enabled = False
        End If
        cmd.CommandText = "select * from  restarunt_stock where stock_bill_id = " + tb_stock_bill_id.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_emp_id.Text = dr("e_id")
            tb_emp_name.Text = dr("employe_name")
            tb_dm_delear_id.Text = dr("d_id")
            dtp_date.Text = dr("stock_add_date")
            dtp_time.Text = dr("stock_add_time").ToString
            tb_paid_amount.Text = dr("amount_paid")
            cmb_import.DropDownStyle = ComboBoxStyle.DropDown
            cmb_import.Text = dr("delear_name")
            cmb_stock_type.Text = dr("stock_name").ToString
            If dr("stock_bill_img").ToString() <> "" Then
                pb_bill_img.Image = global_class.view(dr("stock_bill_img"))
            Else
                pb_bill_img.Image = Infinity.My.Resources.user
            End If
        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_add_new_bill_Click(sender As Object, e As EventArgs) Handles btn_add_new_bill.Click
        getconnection()
        Dim mst As New MemoryStream
        cmd = New SqlCommand("insert into restarunt_stock (stock_bill_id,e_id,employe_name,stock_add_date,stock_add_time,delear_name,amount_paid,d_id,stock_name,stock_bill_img)values(" & tb_stock_bill_id.Text & ",'" & tb_emp_id.Text & "','" & tb_emp_name.Text & "','" & dtp_date.Text + "','" & dtp_time.Text & "','" & cmb_import.Text & "','" & tb_paid_amount.Text & "','" & tb_dm_delear_id.Text & "','" & cmb_stock_type.Text & "',@e_img)", con)
        If tb_emp_id.Text <> "" And tb_paid_amount.Text <> "" And cmb_import.Text <> "" And Not pb_bill_img.Image Is Nothing And cmb_stock_type.Text <> "" Then
            pb_bill_img.Image.Save(mst, pb_bill_img.Image.RawFormat)
            cmd.Parameters.Add("@e_img", SqlDbType.Image).Value = mst.ToArray()
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                pb_bill_img.Image = Nothing
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        con.Close()
        '********************************************************************************************************************************************************
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select DISTINCT stock_name from restarunt_stock "
        Dim d As SqlDataReader
        d = cmd.ExecuteReader()
        cmb_stock_type.Items.Clear()
        While d.Read()
            cmb_stock_type.Items.Add(d("stock_name").ToString)
        End While
        d.Close()
        cmd.Dispose()
        con.Close()
        '**********************************************************************************************************************************************************
        Dim sum As Double = 0
        getconnection()
        cmd = New SqlCommand("select sum(amount_paid) from restarunt_stock where d_id=" & tb_dm_delear_id.Text & "", con)
        sum = cmd.ExecuteScalar()
        cmd.Dispose()
        endconnection()

        Dim cnt As Double = 0
        getconnection()
        cmd = New SqlCommand("select count(amount_paid) from restarunt_stock where d_id=" & tb_dm_delear_id.Text & "", con)
        cnt = cmd.ExecuteScalar()
        cmd.Dispose()
        endconnection()

        getconnection()
        cmd = New SqlCommand("update  delar_data set d_tot_amount_paid=" & sum & ",tot_tranzection_done =" & cnt & "  where d_id=" & tb_dm_delear_id.Text & "", con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        endconnection()


        global_class.clearAllmetrobunifuTextbo(pan_main_stock)
        global_class.clearAlldatetimepicker(pan_main_stock)
        global_class.clearAllcombo_box(pan_main_stock)
        tb_stock_bill_id.Text = autoincr("select count(stock_bill_id) from restarunt_stock", 100)

        grid_load("select * from restarunt_stock", dg_sm_view)
    End Sub

    Private Sub btn_upload_bill_Click(sender As Object, e As EventArgs) Handles btn_upload_bill.Click
        global_class.browse(pb_bill_img.Image)
    End Sub

    Private Sub btn_reset_panel_Click(sender As Object, e As EventArgs) Handles btn_reset_panel.Click
        global_class.clearAllmetrobunifuTextbo(pan_main_stock)
        global_class.clearAlldatetimepicker(pan_main_stock)
        global_class.clearAllcombo_box(pan_main_stock)
        pb_bill_img.Image = Nothing
        tb_stock_bill_id.Text = autoincr("select count(stock_bill_id) from restarunt_stock", 100)
    End Sub
    Private Sub cmb_import_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_import.SelectedIndexChanged
        tb_dm_delear_id.Text = global_class.d_id_arr(cmb_import.SelectedIndex)
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_paid_amount.KeyPress, tb_emp_id.KeyPress, tb_dm_delear_id.KeyPress, tb_stock_bill_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        grid_load("select * from restarunt_stock", dg_sm_view)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        grid_load("select * from restarunt_stock where stock_add_date between '" + dtp_start.Value + "' and '" + dtp_end.Value + "' ", dg_sm_view)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

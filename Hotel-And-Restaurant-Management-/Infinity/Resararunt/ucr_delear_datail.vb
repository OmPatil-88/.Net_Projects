Imports System.Data.SqlClient
Imports System.IO

Public Class ucr_delear_datail
    Inherits UserControl
    Private Shared _instanse As ucr_delear_datail
    Public Shared ReadOnly Property Instance() As ucr_delear_datail
        Get
            If _instanse Is Nothing Then
                _instanse = New ucr_delear_datail()
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

    Private Sub btn_browse_img_Click(sender As Object, e As EventArgs) Handles btn_browse_img.Click
        global_class.browse(pb_dm_profile.Image)
    End Sub
    Private Sub btn_dm_new_Click(sender As Object, e As EventArgs) Handles btn_dm_new.Click
        global_class.clearAllbunifuTextbo(gb_personal_info)
        global_class.clearAllbunifuTextbo(gb_dm_pi)
        global_class.clearAllcombo_box(gb_dm_pi)
        tb_dm_amount_paid.Text = 0
        tb_dm_tranzaction_done.Text = 0
        tb_dm_delear_id.Text = autoincr("select count(d_id) from delar_data", 100)
        tb_dm_delear_id.Enabled = False
        btn_dm_save.Enabled = True
        pb_dm_profile.Image = Infinity.My.Resources.user
        cmb_dm_stock_type.DropDownStyle = ComboBoxStyle.DropDown
        cmb_dm_stock_type.Enabled = True
    End Sub
    Private Sub btn_search_id_Click(sender As Object, e As EventArgs) Handles btn_search_id.Click
        getconnection()
        cmd.Connection = con
        If tb_dm_delear_id.Enabled = False Then
            tb_dm_delear_id.Enabled = False
            btn_dm_save.Enabled = False
        End If
        cmd.CommandText = "select * from  delar_data where d_id = " + tb_dm_delear_id.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_dlname.Text = dr("d_name")
            tb_dlname.Enabled = False
            tb_dlmidname.Text = dr("d_middle_nm")
            tb_dlmidname.Enabled = False
            tb_dlsirname.Text = dr("d_surname")
            tb_dlsirname.Enabled = False
            tb_permobile_number.Text = dr("d_mob_no")
            tb_optmobile_number.Text = dr("d_alter_mob_no")
            tb_dllpermadd.Text = dr("d_per_address")
            tb_dm_adhar_number.Text = dr("d_addhar")
            tb_dm_pan_number.Text = dr("d_pan_no")
            tb_dm_bank_name.Text = dr("d_bank_nm")
            tb_dm_bank_account_no.Text = dr("d_bank_acc_no")
            tb_dm_amount_paid.Text = dr("d_tot_amount_paid")
            tb_dm_tranzaction_done.Text = dr("tot_tranzection_done")
            cmb_dm_stock_type.DropDownStyle = ComboBoxStyle.DropDown
            cmb_dm_stock_type.Text = dr("stock_type")
            If dr("d_image").ToString() <> "" Then
                pb_dm_profile.Image = global_class.view(dr("d_image"))
            Else
                pb_dm_profile.Image = Infinity.My.Resources.user
            End If

        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_dm_save_Click(sender As Object, e As EventArgs) Handles btn_dm_save.Click
        getconnection()
        Dim mst As New MemoryStream
        cmd = New SqlCommand("insert into delar_data (d_id, d_name, d_middle_nm, d_surname, d_mob_no, d_alter_mob_no, d_per_address, d_addhar, d_pan_no, d_bank_nm, d_bank_acc_no, d_tot_amount_paid, tot_tranzection_done, stock_type, d_image)values(" & tb_dm_delear_id.Text & ",'" & tb_dlname.Text & "','" & tb_dlmidname.Text & "','" & tb_dlsirname.Text + "','" & tb_permobile_number.Text & "','" & tb_optmobile_number.Text & "','" & tb_dllpermadd.Text & "','" & tb_dm_adhar_number.Text & "','" & tb_dm_pan_number.Text & "','" & tb_dm_bank_name.Text & "','" & tb_dm_bank_account_no.Text & "','" & tb_dm_amount_paid.Text & "','" & tb_dm_tranzaction_done.Text & "','" & cmb_dm_stock_type.Text & "',@img)", con)
        If tb_dm_delear_id.Text <> "" And tb_dlname.Text <> "" And tb_dlmidname.Text <> "" And tb_dlsirname.Text <> "" And tb_permobile_number.Text <> "" And tb_dllpermadd.Text <> "" And tb_dm_adhar_number.Text <> "" And tb_dm_pan_number.Text <> "" And tb_dm_bank_name.Text <> "" And tb_dm_bank_account_no.Text <> "" And tb_dm_amount_paid.Text <> "" And tb_dm_tranzaction_done.Text <> "" And cmb_dm_stock_type.Text <> "" And Not pb_dm_profile Is Nothing Then
            pb_dm_profile.Image.Save(mst, pb_dm_profile.Image.RawFormat)
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = mst.ToArray()
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                pb_dm_profile.Image = Nothing
                global_class.clearAllbunifuTextbo(gb_personal_info)
                global_class.clearAllbunifuTextbo(gb_dm_pi)
                tb_dm_amount_paid.Text = 0
                tb_dm_tranzaction_done.Text = 0
                tb_dm_delear_id.Text = autoincr("select count(d_id) from delar_data", 100)
                grid_load("select * from delar_data", dg_dm_view_all)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_dm_update_Click(sender As Object, e As EventArgs) Handles btn_dm_update.Click
        getconnection()
        cmd.Connection = con
        Dim MS As New MemoryStream
        Dim bm As New Bitmap(pb_dm_profile.Image)
        cmd.CommandText = "update delar_data set d_name='" + tb_dlname.Text + "',d_middle_nm='" + tb_dlmidname.Text + "',d_surname='" + tb_dlsirname.Text + "',d_mob_no='" + tb_permobile_number.Text + "',d_alter_mob_no='" + tb_permobile_number.Text + "',d_per_address='" + tb_dllpermadd.Text + "',d_addhar='" + tb_dm_adhar_number.Text + "',d_pan_no='" + tb_dm_pan_number.Text + "',d_bank_nm='" + tb_dm_bank_name.Text + "',d_bank_acc_no='" + tb_dm_bank_account_no.Text + "',stock_type='" + cmb_dm_stock_type.Text + "',d_image = @image where  d_id= " + tb_dm_delear_id.Text + " "

        If tb_dm_delear_id.Text <> "" And tb_dlname.Text <> "" And tb_dlmidname.Text <> "" And tb_dlsirname.Text <> "" And tb_permobile_number.Text <> "" And tb_dllpermadd.Text <> "" And tb_dm_adhar_number.Text <> "" And tb_dm_pan_number.Text <> "" And tb_dm_bank_name.Text <> "" And tb_dm_bank_account_no.Text <> "" And tb_dm_amount_paid.Text <> "" And tb_dm_tranzaction_done.Text <> "" And cmb_dm_stock_type.Text <> "" And Not pb_dm_profile Is Nothing Then


            pb_dm_profile.Image.Save(MS, pb_dm_profile.Image.RawFormat)
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = MS.ToArray()


            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                grid_load("select * from delar_data", dg_dm_view_all)
                global_class.clearAllbunifuTextbo(gb_personal_info)
                global_class.clearAllbunifuTextbo(gb_dm_pi)
                tb_dm_amount_paid.Text = 0
                tb_dm_tranzaction_done.Text = 0
                tb_dm_delear_id.Text = autoincr("select count(d_id) from delar_data", 100)
                grid_load("select * from delar_data", dg_dm_view_all)
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        MS.Dispose()
        con.Close()
        bm.Dispose()
        'rwd.command.Parameters.Clear();
        cmd.Parameters.Clear()
    End Sub
    Private Sub IsChar(sender As Object, e As KeyPressEventArgs) Handles tb_dm_bank_name.KeyPress, tb_dlmidname.KeyPress, tb_dlname.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Lf AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_dm_adhar_number.KeyPress, tb_dm_bank_account_no.KeyPress, tb_dm_tranzaction_done.KeyPress, tb_permobile_number.KeyPress, tb_optmobile_number.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

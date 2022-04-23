Imports System.Data.SqlClient

Public Class uc_admin_services_manegement
    Inherits UserControl
    Private Shared _instanse As uc_admin_services_manegement
    Public Shared ReadOnly Property Instance() As uc_admin_services_manegement
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_admin_services_manegement()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_sm_new_Click(sender As Object, e As EventArgs) Handles btn_sm_new.Click
        global_class.n = 0
        global_class.clearAllmetrobunifuTextbo(pan_main_services)
        global_class.clearAllCombo(pan_main_services)
        tb_sm_services_id.Text = autoincr("select count(s_id) from service_data", 100)
        btn_services_save.Enabled = True
        btn_sm_search.Enabled = False
        rb_hotel.Checked = False
        rb_restrurant.Checked = False
        '*********************************************************************************************************************************

        If autoincr("select count(s_id) from service_data", 100) = 100 Then
            tb_sm_services_id.Text = autoincr("select count(s_id) from service_data", 100)
        Else
            tb_sm_services_id.Text = max("select max(s_id) from service_data")
        End If

    End Sub

    Private Sub btn_services_save_Click(sender As Object, e As EventArgs) Handles btn_services_save.Click
        global_class.n = 0
        getconnection()
        Dim i As Byte = False
        Dim j As Byte = False
        If rb_hotel.Checked Then
            i = True
        Else
            j = True
        End If
        cmd = New SqlCommand("insert into service_data values('" & tb_sm_services_id.Text & "','" & tb_sm_services_name.Text & "','" & i & "','" & j & "','" & cmb_sm_services_type.Text & "'," & tb_services_prize.Text & ")", con)
        If (rb_hotel.Checked = True Or rb_restrurant.Checked = True) And tb_sm_services_id.Text <> "" And tb_sm_services_name.Text <> "" And cmb_sm_services_type.Text <> "" And tb_services_prize.Text <> "" Then

            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                global_class.clearAllmetrobunifuTextbo(pan_main_services)
                If autoincr("select count(s_id) from service_data", 100) = 100 Then
                    tb_sm_services_id.Text = autoincr("select count(s_id) from service_data", 100)
                Else
                    tb_sm_services_id.Text = max("select max(s_id) from service_data")
                End If
                cmb_sm_services_type.Text = ""
                btn_services_save.Enabled = False
                tb_sm_services_id.Enabled = True
                rb_hotel.Checked = False
                rb_restrurant.Checked = False
                btn_sm_search.Enabled = True
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        getconnection()
        cmd = New SqlCommand("select DISTINCT service_type from service_data ", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader()
        uc_admin_services_manegement.Instance.cmb_sm_services_type.Items.Clear()
        While d.Read()
            uc_admin_services_manegement.Instance.cmb_sm_services_type.Items.Add(d("service_type").ToString)
        End While

        d.Close()
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_sm_search_Click(sender As Object, e As EventArgs) Handles btn_sm_search.Click
        getconnection()
        cmd.Connection = con
        If tb_sm_services_id.Enabled = False Then
            tb_sm_services_id.Enabled = True
            btn_services_save.Enabled = False
        End If
        cmd.CommandText = "select * from service_data where s_id = " + tb_sm_services_id.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_sm_services_name.Text = dr("s_name")
            If dr("s_type_hotel") = True Then
                rb_hotel.Checked = True
            End If
            If dr("s_type_restarunt") = True Then
                rb_restrurant.Checked = True
            End If
            cmb_sm_services_type.Text = dr("service_type")
            cmb_sm_services_type.DropDownStyle = ComboBoxStyle.DropDown
            tb_services_prize.Text = dr("prize")
        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")
        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_services_Hold_Click(sender As Object, e As EventArgs) Handles btn_services_Hold.Click
        getconnection()
        Dim i As Byte = False
        Dim j As Byte = False
        If rb_hotel.Checked Then
            i = True
        Else
            j = True
        End If
        cmd = New SqlCommand("insert into Hold_service values('" & tb_sm_services_id.Text & "','" & tb_sm_services_name.Text & "','" & i & "','" & j & "','" & cmb_sm_services_type.Text & "'," & tb_services_prize.Text & ")", con)
        If (rb_hotel.Checked = True Or rb_restrurant.Checked = True) And tb_sm_services_id.Text <> "" And tb_sm_services_name.Text <> "" And cmb_sm_services_type.Text <> "" And tb_services_prize.Text <> "" Then
            cmd.ExecuteNonQuery()
        End If
        cmd.Dispose()
        endconnection()
        getconnection()
        cmd.Connection = con
        cmd.CommandText = "delete from service_data where s_id='" + tb_sm_services_id.Text + "'"
        If MsgBox("Do you Really want To Hold this record ", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If (rb_hotel.Checked = True Or rb_restrurant.Checked = True) And tb_sm_services_id.Text <> "" And tb_sm_services_name.Text <> "" And cmb_sm_services_type.Text <> "" And tb_services_prize.Text <> "" Then
                If cmd.ExecuteNonQuery() Then
                    cmd.Dispose()
                    MessageBox.Show("RECORD is on Hold! ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    global_class.clearAllmetrobunifuTextbo(pan_main_services)
                    cmb_sm_services_type.SelectedIndex = -1
                    If autoincr("select count(s_id) from service_data", 100) = 100 Then
                        tb_sm_services_id.Text = autoincr("select count(s_id) from service_data", 100)
                    Else
                        tb_sm_services_id.Text = max("select max(s_id) from service_data")
                    End If
                    btn_services_save.Enabled = False
                    btn_sm_search.Enabled = True
                    tb_sm_services_id.Enabled = True
                    rb_hotel.Checked = False
                    rb_restrurant.Checked = False
                Else
                    MessageBox.Show("Server Error")
                End If
            Else
                MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            End If
        End If
        cmd.Dispose()
        dr.Close()
    End Sub

    Private Sub btn_services_update_Click(sender As Object, e As EventArgs) Handles btn_services_update.Click
        getconnection()
        cmd.Connection = con
        Dim i As Byte = False
        Dim j As Byte = False
        If rb_hotel.Checked Then
            i = True
        Else
            j = True
        End If
        cmd.CommandText = "update service_data set s_name='" & tb_sm_services_name.Text & "',s_type_hotel='" & i & "',s_type_restarunt='" & j & "',service_type='" & cmb_sm_services_type.Text & "',prize=" & tb_services_prize.Text & " where  s_id=" & tb_sm_services_id.Text & " "

        If tb_sm_services_name.Text <> "" And cmb_sm_services_type.SelectedIndex <> -1 And tb_services_prize.Text <> "" Then

            If cmd.ExecuteNonQuery Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cmb_sm_services_type.SelectedIndex = -1
                tb_sm_services_id.Text = autoincr("select count(login_id) from login", 100)
                tb_sm_services_id.Enabled = True
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

        End If
        con.Close()
        cmd.Connection.Close()
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_services_prize.KeyPress, tb_sm_services_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

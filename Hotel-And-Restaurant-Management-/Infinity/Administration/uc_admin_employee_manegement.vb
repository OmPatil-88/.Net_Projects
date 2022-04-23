Imports System.Data.SqlClient
Imports System.IO
Imports Bunifu.Framework
Public Class uc_admin_employee_manegement
    Inherits UserControl
    Private Shared _instanse As uc_admin_employee_manegement
    Public Shared ReadOnly Property Instance() As uc_admin_employee_manegement
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_admin_employee_manegement()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_em_emp_new_Click(sender As Object, e As EventArgs) Handles btn_em_emp_new.Click
        global_class.clearAllbunifuTextbo(Panel_Employee_Management)
        global_class.clearAlldatetimepicker(Panel_Employee_Management)
        global_class.clearAllcombo_box(Panel_Employee_Management)
        tb_em_emp_id.Text = autoincr("select count(e_id) from emplyee_detail", 100)
        tb_em_emp_id.Enabled = False
        btn_em_emp_add.Enabled = True
        pb_em_emp_image.Image = Infinity.My.Resources.user
        cb_em_emp_type.DropDownStyle = ComboBoxStyle.DropDownList
        cb_em_emp_type.Enabled = True
    End Sub

    Private Sub btn_em_search_Click(sender As Object, e As EventArgs) Handles btn_em_search.Click
        getconnection()
        cmd.Connection = con
        If tb_em_emp_id.Enabled = False Then
            tb_em_emp_id.Enabled = False
            btn_em_emp_add.Enabled = False
        End If
        cmd.CommandText = "select * from  emplyee_detail where e_id = " + tb_em_emp_id.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_em_emp_name.Text = dr("e_name")
            tb_em_emp_middlename.Text = dr("e_father_name")
            tb_em_emp_surname.Text = dr("e_surname")
            tb_em_emp_address.Text = dr("e_address")
            tb_em_emp_mob1.Text = dr("e_mob_no1")
            tb_em_emp_mob2.Text = dr("e_mob_no2")
            tb_em_emp_adhar_no.Text = dr("e_adhar_no")
            dtp_em_emp_birthday.Text = dr("e_birth_day")
            dtp_em_emp_join.Text = dr("e_join_day")
            tb_em_emp_age.Text = dr("e_age")
            tb_em_emp_sallery.Text = dr("e_sallery")
            cb_em_emp_type.DropDownStyle = ComboBoxStyle.Simple
            cb_em_emp_type.Enabled = False
            cb_em_emp_type.Text = dr("e_type")
            If dr("e_img").ToString() <> "" Then
                pb_em_emp_image.Image = global_class.view(dr("e_img"))
            Else
                pb_em_emp_image.Image = Infinity.My.Resources.user
            End If

        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_em_emp_img_brows_Click(sender As Object, e As EventArgs) Handles btn_em_emp_img_brows.Click
        global_class.browse(pb_em_emp_image.Image)
    End Sub

    Private Sub uc_admin_employee_manegement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        global_class.clearAllbunifuTextbo(Panel_Employee_Management)
        global_class.clearAlldatetimepicker(Panel_Employee_Management)
        global_class.clearAllcombo_box(Panel_Employee_Management)
        tb_em_emp_id.Text = autoincr("select count(e_id) from emplyee_detail", 100)
        grid_load("select e_id,e_name,e_father_name,e_surname from emplyee_detail", dg_em_emp_grid)
    End Sub

    Private Sub btn_em_emp_add_Click(sender As Object, e As EventArgs) Handles btn_em_emp_add.Click
        getconnection()
        Dim mst As New MemoryStream
        cmd = New SqlCommand("insert into emplyee_detail (e_id,e_name,e_father_name,e_surname,e_address,e_adhar_no,e_mob_no1,e_mob_no2,e_birth_day,e_join_day,e_age,e_type,e_sallery,e_img)values(" & tb_em_emp_id.Text & ",'" & tb_em_emp_name.Text & "','" & tb_em_emp_middlename.Text & "','" & tb_em_emp_surname.Text + "','" & tb_em_emp_address.Text & "','" & tb_em_emp_adhar_no.Text & "','" & tb_em_emp_mob1.Text & "','" & tb_em_emp_mob2.Text & "','" & dtp_em_emp_birthday.Text & "','" & dtp_em_emp_join.Text & "','" & tb_em_emp_age.Text & "','" & cb_em_emp_type.Text & "','" & tb_em_emp_sallery.Text & "',@e_img)", con)
        If tb_em_emp_name.Text <> "" And tb_em_emp_middlename.Text <> "" And tb_em_emp_surname.Text <> "" And tb_em_emp_address.Text <> "" And tb_em_emp_mob1.Text <> "" And tb_em_emp_adhar_no.Text <> "" And dtp_em_emp_birthday.Text <> "" And dtp_em_emp_join.Text <> "" And tb_em_emp_age.Text <> "" And cb_em_emp_type.Text <> "" And tb_em_emp_sallery.Text <> "" Then
            pb_em_emp_image.Image.Save(mst, pb_em_emp_image.Image.RawFormat)
            cmd.Parameters.Add("@e_img", SqlDbType.Image).Value = mst.ToArray()
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                pb_em_emp_image.Image = Nothing
                global_class.clearAllbunifuTextbo(Panel_Employee_Management)
                global_class.clearAlldatetimepicker(Panel_Employee_Management)
                global_class.clearAllcombo_box(Panel_Employee_Management)
                tb_em_emp_id.Text = autoincr("select count(e_id) from emplyee_detail", 100)
                btn_em_emp_add.Enabled = False
                tb_em_emp_id.Enabled = True
                grid_load("select e_id,e_name,e_father_name,e_surname from emplyee_detail", dg_em_emp_grid)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_em_emp_delete_Click(sender As Object, e As EventArgs) Handles btn_em_emp_delete.Click
        getconnection()
        cmd.Connection = con
        cmd.CommandText = "delete from emplyee_detail where e_id='" + tb_em_emp_id.Text + "'"
        If MsgBox("Do you Really want To delete this record ", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If tb_em_emp_name.Text <> "" And tb_em_emp_middlename.Text <> "" And tb_em_emp_surname.Text <> "" And tb_em_emp_address.Text <> "" And tb_em_emp_mob1.Text <> "" And tb_em_emp_adhar_no.Text <> "" And dtp_em_emp_birthday.Text <> "" And dtp_em_emp_join.Text <> "" And tb_em_emp_age.Text <> "" And cb_em_emp_type.Text <> "" And tb_em_emp_sallery.Text <> "" Then


                Dim i As Integer = cmd.ExecuteNonQuery

                If (i > 0) Then
                    MessageBox.Show("RECORD Deleted !!!!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    pb_em_emp_image.Image = Infinity.My.Resources.user

                    grid_load("select e_id,e_name,e_father_name,e_surname from emplyee_detail", dg_em_emp_grid)

                Else
                    MessageBox.Show("Server Error")
                End If
            Else
                MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

                cb_em_emp_type.SelectedIndex = -1
                cb_em_emp_type.DropDownStyle = ComboBoxStyle.DropDownList
                cb_em_emp_type.Enabled = True
                pb_em_emp_image.Image = Infinity.My.Resources.user
            End If
        End If
        cmd.Dispose()
    End Sub

    Private Sub btn_em_emp_update_Click(sender As Object, e As EventArgs) Handles btn_em_emp_update.Click
        getconnection()
        cmd.Connection = con
        Dim MS As New MemoryStream
        Dim bm As New Bitmap(pb_em_emp_image.Image)
        cmd.CommandText = "update emplyee_detail set e_name='" + tb_em_emp_name.Text + "',e_father_name='" + tb_em_emp_middlename.Text + "',e_surname='" + tb_em_emp_surname.Text + "',e_address='" + tb_em_emp_address.Text + "',e_adhar_no='" + tb_em_emp_adhar_no.Text + "',e_mob_no1='" + tb_em_emp_mob1.Text + "',e_mob_no2='" + tb_em_emp_mob2.Text + "',e_birth_day='" + dtp_em_emp_birthday.Text + "',e_join_day='" + dtp_em_emp_join.Text + "',e_age='" + tb_em_emp_age.Text + "',e_type='" + cb_em_emp_type.Text + "',e_sallery='" + tb_em_emp_sallery.Text + "',e_img = @pb_em_emp_image where  e_id= " + tb_em_emp_id.Text + " "

        If tb_em_emp_name.Text <> "" And tb_em_emp_middlename.Text <> "" And tb_em_emp_surname.Text <> "" And tb_em_emp_address.Text <> "" And tb_em_emp_mob1.Text <> "" And tb_em_emp_adhar_no.Text <> "" And dtp_em_emp_birthday.Text <> "" And dtp_em_emp_join.Text <> "" And tb_em_emp_age.Text <> "" And cb_em_emp_type.Text <> "" And tb_em_emp_sallery.Text <> "" Then


            bm.Save(MS, pb_em_emp_image.Image.RawFormat)
            cmd.Parameters.Add("@pb_em_emp_image", SqlDbType.Image).Value = MS.ToArray()


            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                cb_em_emp_type.SelectedIndex = -1
                pb_em_emp_image.Image = Infinity.My.Resources.user
                cb_em_emp_type.DropDownStyle = ComboBoxStyle.DropDownList
                cb_em_emp_type.Enabled = True
                grid_load("select e_id,e_name,e_father_name,e_surname from emplyee_detail", dg_em_emp_grid)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

            cb_em_emp_type.SelectedIndex = -1
            pb_em_emp_image.Image = Infinity.My.Resources.user
            cb_em_emp_type.DropDownStyle = ComboBoxStyle.DropDownList
            cb_em_emp_type.Enabled = True
        End If
        MS.Dispose()
        bm.Dispose()
        cmd.Parameters.Clear()
        endconnection()
    End Sub

    Private Sub btn_em_emp_minus_Click(sender As Object, e As EventArgs) Handles btn_em_emp_minus.Click
        If tb_em_emp_sallery.Text = "" Then
            tb_em_emp_sallery.Text = 0
        End If
        If tb_em_emp_sallery.Text > 0 Then
            tb_em_emp_sallery.Text = tb_em_emp_sallery.Text - 1000
        End If
    End Sub

    Private Sub btn_em_emp_plus_Click(sender As Object, e As EventArgs) Handles btn_em_emp_plus.Click
        If tb_em_emp_sallery.Text = "" Then
            tb_em_emp_sallery.Text = 0
        End If
        tb_em_emp_sallery.Text = tb_em_emp_sallery.Text + 1000
    End Sub

    Private Sub dtp_em_emp_birthday_ValueChanged(sender As Object, e As EventArgs) Handles dtp_em_emp_birthday.ValueChanged
        Dim t As TimeSpan = DateTime.Now.Date - dtp_em_emp_birthday.Value
        tb_em_emp_age.Text = String.Format("{0:n0} ", (t.TotalDays / 365))
        tb_em_emp_age.Enabled = False
    End Sub
    Private Sub IsChar(sender As Object, e As KeyPressEventArgs) Handles tb_em_emp_adhar_no.KeyPress, tb_em_emp_surname.KeyPress, tb_em_emp_name.KeyPress, tb_em_emp_middlename.KeyPress, tb_em_emp_id.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Lf AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_em_emp_sallery.KeyPress, tb_em_emp_mob2.KeyPress, tb_em_emp_adhar_no.KeyPress, tb_em_emp_age.KeyPress, tb_em_emp_mob1.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

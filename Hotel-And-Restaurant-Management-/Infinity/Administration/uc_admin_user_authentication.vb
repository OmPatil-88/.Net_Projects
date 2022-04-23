Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class uc_admin_user_authentication
    Inherits UserControl
    Private Shared _instanse As uc_admin_user_authentication
    Public Shared ReadOnly Property Instance() As uc_admin_user_authentication
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_admin_user_authentication()
            End If
            Return _instanse
        End Get
    End Property
    Private Sub btn_search_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_search.MouseDown
        tb_pass.isPassword = False
    End Sub
    Private Sub btn_search_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_search.MouseUp
        tb_pass.isPassword = True
    End Sub
    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        tb_con_pass.isPassword = False
    End Sub
    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        tb_con_pass.isPassword = True
    End Sub
    Private Sub btn_save_password_Click(sender As Object, e As EventArgs) Handles btn_save_password.Click
        getconnection()
        Dim mst As New MemoryStream
        cmd = New SqlCommand("insert into login (login_id,user_name,user_password,user_role,user_image)values('" & tb_um_user_name.Text & "','" & tb_um_name.Text & "','" & tb_pass.Text + "','" & cmb_um_user_roll.Text & "',@pb_um_user_image)", con)

        If tb_um_user_name.Text <> "" And tb_um_name.Text <> "" And tb_con_pass.Text <> "" And tb_pass.Text <> "" And cmb_um_user_roll.Text <> "" Then
            If Not pb_um_user_image.Image Is Nothing Then
                pb_um_user_image.Image.Save(mst, pb_um_user_image.Image.RawFormat)
                cmd.Parameters.Add("@pb_um_user_image", SqlDbType.Image).Value = mst.ToArray()
            End If

            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                tb_um_user_name.Text = ""
                tb_um_name.Text = ""
                tb_con_pass.Text = ""
                tb_pass.Text = ""
                cmb_um_user_roll.Text = ""
                pb_um_user_image.Image = Nothing
                tb_um_user_name.Text = autoincr("select count(login_id) from login", 100)
                btn_save_password.Enabled = False
                tb_um_user_name.Enabled = True
                grid_load("select login_id,user_name,user_password,user_role from login", dg_user_manegament)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub uc_admin_user_authentication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_um_user_name.Text = autoincr("select count(login_id) from login", 100)
        grid_load("select login_id,user_name,user_password,user_role from login", dg_user_manegament)
        btn_save_password.Enabled = True

    End Sub

    Private Sub tb_con_pass_Leave(sender As Object, e As EventArgs) Handles tb_con_pass.Leave
        lbl_password_confirmation.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        global_class.browse(pb_um_user_image.Image)
    End Sub

    Private Sub btn_um_search_Click(sender As Object, e As EventArgs) Handles btn_um_search.Click

        getconnection()
        cmd.Connection = con
        If tb_um_user_name.Enabled = False Then
            tb_um_user_name.Enabled = True
            btn_save_password.Enabled = False
        End If
        cmd.CommandText = "select * from login where login_id = " + tb_um_user_name.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_um_name.Text = dr("user_name")
            tb_pass.Text = dr("user_password")
            tb_con_pass.Text = dr("user_password")
            cmb_um_user_roll.DropDownStyle = ComboBoxStyle.Simple
            cmb_um_user_roll.Enabled = False
            cmb_um_user_roll.Text = dr("user_role")
            If dr("user_image").ToString() <> "" Then
                pb_um_user_image.Image = global_class.view(dr("user_image"))
            Else
                pb_um_user_image.Image = Infinity.My.Resources.user
            End If

        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")
            tb_um_name.Text = ""
            tb_pass.Text = ""
            tb_con_pass.Text = ""
            cmb_um_user_roll.SelectedIndex = -1
            pb_um_user_image.Image = Infinity.My.Resources.user
        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub uc_admin_user_authentication_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        tb_um_name.Text = ""
        tb_pass.Text = ""
        tb_con_pass.Text = ""
        cmb_um_user_roll.SelectedIndex = -1
        pb_um_user_image.Image = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tb_um_user_name.Text = autoincr("select count(login_id) from login", 100)
        tb_um_user_name.Enabled = False
        btn_save_password.Enabled = True
        tb_um_name.Text = ""
        tb_pass.Text = ""
        tb_con_pass.Text = ""
        cmb_um_user_roll.SelectedIndex = -1
        pb_um_user_image.Image = Infinity.My.Resources.user
        cmb_um_user_roll.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_um_user_roll.Enabled = True
    End Sub

    Private Sub btn_um_update_click(sender As Object, e As EventArgs) Handles btn_um_update.Click
        getconnection()
        cmd.Connection = con
        Dim MS As New MemoryStream
        Dim bm As New Bitmap(pb_um_user_image.Image)
        cmd.CommandText = "update login set user_name='" + tb_um_name.Text + "',user_password='" + tb_pass.Text + "',user_role='" + cmb_um_user_roll.Text + "',user_image = @pb_um_user_image where  login_id= " + tb_um_user_name.Text + " "

        If tb_um_name.Text <> "" Or cmb_um_user_roll.SelectedIndex <> -1 Or tb_pass.Text <> "" Then


            bm.Save(MS, pb_um_user_image.Image.RawFormat)
            cmd.Parameters.Add("@pb_um_user_image", SqlDbType.Image).Value = MS.ToArray()


            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                tb_um_name.Text = ""
                tb_pass.Text = ""
                tb_con_pass.Text = ""
                cmb_um_user_roll.SelectedIndex = -1
                pb_um_user_image.Image = Infinity.My.Resources.user
                cmb_um_user_roll.DropDownStyle = ComboBoxStyle.DropDownList
                cmb_um_user_roll.Enabled = True
                grid_load("select login_id,user_name,user_password,user_role from login", dg_user_manegament)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            tb_um_name.Text = ""
            tb_pass.Text = ""
            tb_con_pass.Text = ""
            cmb_um_user_roll.SelectedIndex = -1
            pb_um_user_image.Image = Infinity.My.Resources.user
            cmb_um_user_roll.DropDownStyle = ComboBoxStyle.DropDownList
            cmb_um_user_roll.Enabled = True
        End If
        ' MS.Dispose()
        con.Close()
        cmd.Connection.Close()
        ' rwd.command.Parameters.Clear();
        cmd.Parameters.Clear()
    End Sub

    Private Sub btn_um_delete_click(sender As Object, e As EventArgs) Handles btn_um_delete.Click
        getconnection()
        cmd.Connection = con
        cmd.CommandText = "delete from login where login_id='" + tb_um_user_name.Text + "'"
        If MsgBox("Do you Really want To delete this record ", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If tb_um_name.Text <> "" Or cmb_um_user_roll.SelectedIndex <> -1 Or tb_pass.Text <> "" Then


         Dim i As Integer = cmd.ExecuteNonQuery

                If (i > 0) Then
                    MessageBox.Show("RECORD Deleted !!!!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    tb_um_name.Text = ""
                    tb_pass.Text = ""
                    tb_con_pass.Text = ""
                    cmb_um_user_roll.SelectedIndex = -1
                    pb_um_user_image.Image = Infinity.My.Resources.user
                    cmb_um_user_roll.DropDownStyle = ComboBoxStyle.DropDownList
                    cmb_um_user_roll.Enabled = True
                    grid_load("select login_id,user_name,user_password,user_role from login", dg_user_manegament)

                Else
                    MessageBox.Show("Server Error")
                End If
            Else
                MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
                tb_um_name.Text = ""
                tb_pass.Text = ""
                tb_con_pass.Text = ""
                cmb_um_user_roll.SelectedIndex = -1
                pb_um_user_image.Image = Infinity.My.Resources.user
                cmb_um_user_roll.DropDownStyle = ComboBoxStyle.DropDownList
                cmb_um_user_roll.Enabled = True
            End If
        End If
    End Sub

    Private Sub tb_con_pass_OnValueChanged(sender As Object, e As EventArgs) Handles tb_con_pass.OnValueChanged
        If tb_con_pass.Text = tb_pass.Text Then
            lbl_password_confirmation.Visible = True
            lbl_password_confirmation.Text = "Password Matched"
            lbl_password_confirmation.ForeColor = System.Drawing.Color.Green
        Else
            lbl_password_confirmation.Visible = True
            lbl_password_confirmation.Text = "Password Not Matched"
            lbl_password_confirmation.ForeColor = System.Drawing.Color.Red
        End If
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_um_user_name.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

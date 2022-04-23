Imports System.Data.SqlClient

Public Class Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If tb_id.Text <> "" And tb_password.Text <> "" And cmb_user_type.SelectedIndex <> -1 Then
            getconnection()
            cmd = New SqlCommand("select * from login where user_name='" & tb_id.Text & "'and user_password='" & tb_password.Text & "' and user_role='" + cmb_user_type.Text + "'", con)
            'cmd.CommandText = "select * from login where user_name='" & tb_id.Text & "'and user_password='" & tb_password.Text & "' and user_role='" + cmb_user_type.Text + "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                If dr("user_role") = "Administration                                    " Then
                    MessageBox.Show("Welcome Admin", "ADMIN")
                ElseIf dr("user_role") = "Recepationeast                                    " Then
                    MessageBox.Show("Welcome sir", "Recepationeast", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                ElseIf dr("user_role") = "Employe                                           " Then
                    MessageBox.Show("Welcome sir", "Employe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                ElseIf dr("user_role") = "Chef                                              " Then
                    MessageBox.Show("Welcome sir", "Chef", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                global_class.user_statues = dr("user_role")
                global_class.user_name = dr("user_name")
                global_class.user_image = dr("user_image")
                dr.Close()
                con.Close()
                Me.Hide()
                cmb_user_type.SelectedIndex = -1
                tb_password.Text = ""
                tb_id.Text = ""
                main_menu.Show()
            Else
                MessageBox.Show("INVALID USER NAME OR PASSWORD", "FAILED", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            End If
            dr.Close()
        Else
            MessageBox.Show("You Must fill all fild")
        End If
        endconnection()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        tb_id.Text = ""
    End Sub
End Class
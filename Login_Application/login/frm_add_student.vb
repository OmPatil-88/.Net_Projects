Imports System.Data.SqlClient

Public Class frm_add_student


    Private Sub btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view.Click
        Me.Hide()
        frm_stud_info.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frm_login.Show()
    End Sub


    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=login_1;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into tbl_info(ROLL_NO,Name,City,Mobile_Number) values (" + tb_roll_name.Text + " ,'" + tb_name.Text + "' ,'" + tb_city.Text + "'," + tb_mo_no.Text + ")"
        If (tb_roll_name.Text <> "" Or tb_name.Text <> "" Or tb_city.Text <> "" Or tb_mo_no.Text <> "") Then
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("Record saved successfully")
            Else
                MessageBox.Show("Failled")

            End If
        Else
            MessageBox.Show("First fill all the field", "WARNING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        End If

    End Sub


    Private Sub frm_add_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_roll_name.Focus()
    End Sub

    Private Sub frm_add_student_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        tb_roll_name.Focus()
        tb_roll_name.Text = ""
        tb_name.Text = ""
        tb_city.Text = ""
        tb_mo_no.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tb_roll_name.Text = ""
        tb_name.Text = ""
        tb_city.Text = ""
        tb_mo_no.Text = ""
        tb_roll_name.Focus()
    End Sub
End Class
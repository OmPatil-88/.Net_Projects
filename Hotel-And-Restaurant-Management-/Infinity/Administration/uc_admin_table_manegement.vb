Imports System.Data.SqlClient
Imports System.IO
Public Class uc_admin_table_manegement
    Inherits UserControl
    Private Shared _instanse As uc_admin_table_manegement
    Public Shared ReadOnly Property Instance() As uc_admin_table_manegement
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_admin_table_manegement()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_um_tm_search_Click(sender As Object, e As EventArgs) Handles btn_um_tm_search.Click
        getconnection()
        cmd.Connection = con
        If tb_um_tm_table_id.Enabled = False Then
            tb_um_tm_table_id.Enabled = True
        End If
        cmd.CommandText = "select * from table_data where table_id = " + tb_um_tm_table_id.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then

            tb_um_tm_table_number.Text = dr("table_number")
            cmb_um_tm_order_type.DropDownStyle = ComboBoxStyle.Simple
            cmb_um_tm_order_type.Text = dr("table_type")
            tb_um_tm_people_capacity.Text = dr("people_capacity")
        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        cmd.Dispose()
        dr.Close()
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_um_tm_new_Click(sender As Object, e As EventArgs) Handles btn_um_tm_new.Click
        tb_um_tm_table_id.Text = autoincr("select count(table_id) from table_data", 100)
        tb_um_tm_table_number.Text = ""
        tb_um_tm_people_capacity.Text = ""
        cmb_um_tm_order_type.SelectedIndex = -1
        btn_um_tm_save.Enabled = True
        tb_um_tm_table_id.Enabled = False
    End Sub

    Private Sub uc_admin_table_manegement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_um_tm_table_id.Text = autoincr("select count(table_id) from table_data", 100)
    End Sub

    Private Sub btn_um_tm_save_Click(sender As Object, e As EventArgs) Handles btn_um_tm_save.Click
        getconnection()

        cmd = New SqlCommand("insert into table_data (table_id,table_number,table_type,people_capacity )values('" & tb_um_tm_table_id.Text & "','" & tb_um_tm_table_number.Text & "','" & cmb_um_tm_order_type.Text & "','" & tb_um_tm_people_capacity.Text & "')", con)

        If tb_um_tm_table_id.Text <> "" And tb_um_tm_table_number.Text <> "" And cmb_um_tm_order_type.SelectedIndex <> -1 And tb_um_tm_people_capacity.Text <> "" Then
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                tb_um_tm_table_id.Text = autoincr("select count(table_id) from table_data", 100)
                tb_um_tm_table_number.Text = ""
                tb_um_tm_people_capacity.Text = ""
                cmb_um_tm_order_type.SelectedIndex = -1
                btn_um_tm_save.Enabled = False
                tb_um_tm_table_id.Enabled = True
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_um_tm_update_Click(sender As Object, e As EventArgs) Handles btn_um_tm_update.Click
        getconnection()
        cmd.Connection = con

        cmd.CommandText = "update table_data set table_number='" + tb_um_tm_table_number.Text + "',table_type='" + cmb_um_tm_order_type.Text + "',people_capacity='" + tb_um_tm_people_capacity.Text + "' where  table_id= " + tb_um_tm_table_id.Text + " "

        If tb_um_tm_table_id.Text <> "" And tb_um_tm_table_number.Text <> "" And cmb_um_tm_order_type.Text <> "" And tb_um_tm_people_capacity.Text <> "" Then

            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                tb_um_tm_table_id.Text = autoincr("select count(table_id) from table_data", 100)
                tb_um_tm_table_number.Text = ""
                tb_um_tm_people_capacity.Text = ""
                cmb_um_tm_order_type.DropDownStyle = ComboBoxStyle.DropDownList
                btn_um_tm_save.Enabled = False
                tb_um_tm_table_id.Enabled = True

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

        End If
        con.Close()
        cmd.Connection.Close()

    End Sub

    Private Sub btn_um_tm_delete_Click(sender As Object, e As EventArgs) Handles btn_um_tm_delete.Click
        getconnection()
        cmd.Connection = con
        cmd.CommandText = "delete from table_data where table_id='" + tb_um_tm_table_id.Text + "'"
        If MsgBox("Do you Really want To delete this record ", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If tb_um_tm_table_id.Text <> "" And tb_um_tm_table_number.Text <> "" And cmb_um_tm_order_type.Text <> "" And tb_um_tm_people_capacity.Text <> "" Then


                Dim i As Integer = cmd.ExecuteNonQuery

                If (i > 0) Then
                    MessageBox.Show("RECORD Deleted !!!!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    tb_um_tm_table_id.Text = autoincr("select count(table_id) from table_data", 100)
                    tb_um_tm_table_number.Text = ""
                    tb_um_tm_people_capacity.Text = ""
                    cmb_um_tm_order_type.DropDownStyle = ComboBoxStyle.DropDownList
                    btn_um_tm_save.Enabled = False
                    tb_um_tm_table_id.Enabled = True
                Else
                    MessageBox.Show("Server Error")
                End If
            Else
                MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

            End If
        End If
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_um_tm_table_id.KeyPress, tb_um_tm_table_number.KeyPress, tb_um_tm_people_capacity.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

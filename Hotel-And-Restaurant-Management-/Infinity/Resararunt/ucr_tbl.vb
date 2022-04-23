Imports System.Data.SqlClient
Public Class ucr_tbl
    Private Shared _instanse As UserControl
    Public Shared ReadOnly Property Instance() As ucr_tbl
        Get
            If _instanse Is Nothing Then
                _instanse = New ucr_tbl()
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

    Private Sub btn_tm_search_table_no_Click(sender As Object, e As EventArgs) Handles btn_tm_search_table_no.Click
        getconnection()
        If tb_tm_table_number.Enabled = False Then
            tb_tm_table_number.Enabled = True
        End If
        cmd = New SqlCommand("select * from table_data where table_number = " & tb_tm_table_number.Text & "", con)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_tm_tableid.Text = dr("table_id")
            cmb_order_type.DropDownStyle = ComboBoxStyle.Simple
            cmb_order_type.Text = dr("table_type")
            tb_tm_people_capacity.Text = dr("people_capacity")
            grid_load("select * from table_data", dg_tm_drid)
        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        dr.Close()
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_tm_update_Click(sender As Object, e As EventArgs) Handles btn_tm_update.Click
        getconnection()
        cmd.Connection = con

        cmd.CommandText = "update table_data set table_type='" + cmb_order_type.Text + "',people_capacity='" + tb_tm_people_capacity.Text + "' where  table_number= " + tb_tm_table_number.Text + " "

        If tb_tm_tableid.Text <> "" And tb_tm_table_number.Text <> "" And cmb_order_type.Text <> "" And tb_tm_people_capacity.Text <> "" Then

            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                tb_tm_table_number.Text = ""
                tb_tm_people_capacity.Text = ""
                cmb_order_type.SelectedIndex = -1
                cmb_order_type.DropDownStyle = ComboBoxStyle.DropDownList
                tb_tm_tableid.Enabled = False

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

        End If
        con.Close()
        cmd.Connection.Close()

    End Sub

    Private Sub ucr_tbl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grid_load("select * from table_data", dg_tm_drid)
    End Sub

    Private Sub btn_tm_grid_viewall_Click(sender As Object, e As EventArgs) Handles btn_tm_grid_viewall.Click
        grid_load("select * from table_data", dg_tm_drid)
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_tm_current_capacity.KeyPress, tb_tm_table_number.KeyPress, tb_tm_people_capacity.KeyPress, tb_tm_tableid.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

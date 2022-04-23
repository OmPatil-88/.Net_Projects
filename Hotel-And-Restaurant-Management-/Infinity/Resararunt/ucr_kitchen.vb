Imports System.Data.SqlClient
Imports System.IO
Public Class ucr_kitchen
    Inherits UserControl
    Private Shared _instanse As ucr_kitchen
    Public Shared ReadOnly Property Instance() As ucr_kitchen
        Get
            If _instanse Is Nothing Then
                _instanse = New ucr_kitchen()
            End If
            Return _instanse
        End Get
    End Property
    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_km_new_Click(sender As Object, e As EventArgs) Handles btn_km_new.Click
        tb_km_kitchen_id.Text = autoincr("select count(kitchen_id) from kitchen_data", 100)
        tb_km_kitchen_id.Enabled = False
        btn_save_kitchen_master.Enabled = True
        cmb_km_menu_type.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_km_menu_type.Enabled = True
        cmb_km_chef_name.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_km_chef_name.Enabled = True
    End Sub

    Private Sub ucr_kitchen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        global_class.clearAllbunifuTextbo(panel_kitchen_master)
        grid_load("select kitchen_id,kitchen_head_chef,order_capacity,kitchen_type from kitchen_data", dgv_kitchen_master)
        tb_km_kitchen_id.Text = autoincr("select count(kitchen_id) from kitchen_data", 100)
    End Sub

    Private Sub btn_save_kitchen_master_Click(sender As Object, e As EventArgs) Handles btn_save_kitchen_master.Click
        getconnection()

        cmd = New SqlCommand("insert into kitchen_data (kitchen_id,order_capacity,kitchen_type,kitchen_head_chef )values('" & tb_km_kitchen_id.Text & "','" & tb_km_order_capacity.Text & "','" & cmb_km_menu_type.Text & "','" & cmb_km_chef_name.Text & "')", con)

        If tb_km_kitchen_id.Text <> "" And tb_km_current_orders.Text <> "" And tb_km_order_capacity.Text <> "" And cmb_km_chef_name.Text <> "" And cmb_km_menu_type.Text <> "" Then


            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                global_class.clearAllbunifuTextbo(panel_kitchen_master)
                global_class.clearAllCombo(panel_kitchen_master)

                tb_km_kitchen_id.Text = autoincr("select count(kitchen_id) from kitchen_data", 100)
                btn_save_kitchen_master.Enabled = False
                tb_km_kitchen_id.Enabled = True
                grid_load("select kitchen_id,kitchen_head_chef,order_capacity,kitchen_type from kitchen_data", dgv_kitchen_master)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_km_update_Click(sender As Object, e As EventArgs) Handles btn_km_update.Click
        getconnection()
        cmd.Connection = con

        cmd.CommandText = "update kitchen_data set order_capacity='" + tb_km_order_capacity.Text + "',kitchen_type='" + cmb_km_menu_type.Text + "',kitchen_head_chef='" + cmb_km_chef_name.Text + "' where  kitchen_id= " + tb_km_kitchen_id.Text + " "

        If tb_km_kitchen_id.Text <> "" And tb_km_current_orders.Text <> "" And tb_km_order_capacity.Text <> "" And cmb_km_chef_name.Text <> "" And cmb_km_menu_type.Text <> "" Then

            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                global_class.clearAllbunifuTextbo(panel_kitchen_master)
                global_class.clearAllcombo_box(panel_kitchen_master)
                cmb_km_chef_name.Enabled = True
                cmb_km_menu_type.Enabled = True
                grid_load("select kitchen_id,kitchen_head_chef,order_capacity,kitchen_type from kitchen_data", dgv_kitchen_master)

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            global_class.clearAllbunifuTextbo(panel_kitchen_master)
            global_class.clearAllcombo_box(panel_kitchen_master)
            cmb_km_chef_name.Enabled = True
            cmb_km_menu_type.Enabled = True
        End If
        con.Close()
        cmd.Connection.Close()

    End Sub

    Private Sub btn_km_view_single_Click(sender As Object, e As EventArgs) Handles btn_km_view_single.Click
        getconnection()
        cmd.Connection = con
        If tb_km_kitchen_id.Enabled = False Then
            tb_km_kitchen_id.Enabled = True
            btn_save_kitchen_master.Enabled = False
        End If
        cmd.CommandText = "select * from kitchen_data where kitchen_id = " + tb_km_kitchen_id.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then

            tb_km_order_capacity.Text = dr("order_capacity")
            cmb_km_menu_type.Text = dr("kitchen_type")
            cmb_km_chef_name.Text = dr("kitchen_head_chef")


        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        dr.Close()
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_km_view_Click(sender As Object, e As EventArgs) Handles btn_km_view.Click
        grid_load("select kitchen_id,kitchen_head_chef,order_capacity,kitchen_type from kitchen_data", dgv_kitchen_master)
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_km_current_orders.KeyPress, tb_km_order_capacity.KeyPress, tb_km_kitchen_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

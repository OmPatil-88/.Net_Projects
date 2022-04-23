Imports System.Data.SqlClient

Public Class uchome
    Inherits UserControl
    Private Shared _instanse As uchome
    Public Shared ReadOnly Property Instance() As uchome
        Get
            If _instanse Is Nothing Then
                _instanse = New uchome()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_checkin_Click(sender As Object, e As EventArgs) Handles btn_checkin.Click
#Region "Display"
        If Not main_menu.main_panel.Controls.Contains(uchome_check_in.Instance) Then
            main_menu.main_panel.Controls.Add(uchome_check_in.Instance)
            uchome_check_in.Instance.Dock = DockStyle.Fill
            uchome_check_in.Instance.BringToFront()
            uchome_check_in.Instance.Visible = True
        End If
        uchome_check_in.Instance.BringToFront()
        uchome_check_in.Instance.Visible = True
#End Region
#Region "Activated"
        getconnection()
        grid_load("select *  from check_in_check_out ", uchome_check_in.Instance.dgv_check_in)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select count(Check_id)from check_in_check_out"
        Dim y As Integer = cmd.ExecuteScalar()
        If y = 0 Then
            cmd.Dispose()
            uchome_check_in.Instance.tb_check_id.Text = autoincr("select max(Check_id) from Guest_data", 1)
        Else
            cmd.Dispose()
            cmd = New SqlCommand("select max(Check_id)from check_in_check_out", con)
            If IsDBNull(cmd.ExecuteScalar) Then
                uchome_check_in.Instance.tb_check_id.Text = 1000
            Else
                uchome_check_in.Instance.tb_check_id.Text = cmd.ExecuteScalar + 1
                cmd.Dispose()
            End If

        End If
            endconnection()
        '***********************************************************************
        getconnection()
        cmd = New SqlCommand("select DISTINCT room_type from room_data ", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader()
        uchome_check_in.Instance.cmb_ch_room_type.Items.Clear()
        While d.Read()
            uchome_check_in.Instance.cmb_ch_room_type.Items.Add(d("room_type").ToString)
        End While
        d.Close()
        cmd.Dispose()
        endconnection()
        '***********************************************************************************************************
        getconnection()
        cmd = New SqlCommand("select DISTINCT pkg_name from package_data ", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        uchome_check_in.Instance.cmb_pkg_name.Items.Clear()
        While dr.Read()
            uchome_check_in.Instance.cmb_pkg_name.Items.Add(dr("pkg_name").ToString)
        End While
        dr.Close()
        cmd.Dispose()
        endconnection()
#End Region
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_cout.Click
#Region "Display"
        If Not main_menu.main_panel.Controls.Contains(uchome_check_out.Instance) Then
            main_menu.main_panel.Controls.Add(uchome_check_out.Instance)
            uchome_check_out.Instance.Dock = DockStyle.Fill
            uchome_check_out.Instance.BringToFront()
            uchome_check_out.Instance.Visible = True
        End If
        uchome_check_out.Instance.BringToFront()
        uchome_check_out.Instance.Visible = True
#End Region
#Region "Activated"

#End Region
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
#Region "display"
        If Not main_menu.main_panel.Controls.Contains(uchome_bill.Instance) Then
            main_menu.main_panel.Controls.Add(uchome_bill.Instance)
            uchome_bill.Instance.Dock = DockStyle.Fill
            uchome_bill.Instance.BringToFront()
            uchome_bill.Instance.Visible = True
        End If
        uchome_bill.Instance.BringToFront()
        uchome_bill.Instance.Visible = True
#End Region
#Region "Activated"
        Try
            grid_load("select * from Final_bill_table ", uchome_bill.Instance.dgv_biiled_order)
            getconnection()
            cmd = New SqlCommand("select count(bill_id) from temp_Bill_menu", con)
            If cmd.ExecuteScalar() = 0 Then
                uchome_bill.Instance.tb_bill_no.Text = autoincr("select count(bill_no) from Final_bill_table", 1)
            Else
                cmd.Dispose()
                cmd = New SqlCommand("select max(bill_id) from temp_Bill_menu", con)
                uchome_bill.Instance.tb_bill_no.Text = cmd.ExecuteScalar() + 1
            End If
            cmd.Dispose()

            cmd = New SqlCommand("select menu_name from menu_data", con)
            Dim dr As SqlDataReader
Up:
            dr = cmd.ExecuteReader
            uchome_bill.Instance.lb_menu_items.Items.Clear()
            While dr.Read()
                uchome_bill.Instance.lb_menu_items.Items.Add(dr("menu_name"))
            End While
            cmd.Dispose()
            endconnection()
        Catch
            con.Open()
            GoTo Up
        End Try

#End Region
#Region "load table icon "
        uchome_bill.Instance.pan_table.Controls.Clear()
        getconnection()
        Dim x As Integer = 17
        Dim y As Integer = 24
        Dim cnt As Integer = 1
        cmd = New SqlCommand("select * from table_data", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader
        While d.Read()
            Dim obj = New uc_button
            obj.Location = New System.Drawing.Point(x, y)
            obj.lbl_table_name.Text = d("table_number")

            uchome_bill.Instance.pan_table.Controls.Add(obj)
            y = y + 75
            cnt = cnt + 1
            If cnt > 4 Then
                cnt = 1
                x = x + 86
                y = 24
            End If
        End While
#End Region
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_extra_services.Click
        If Not main_menu.main_panel.Controls.Contains(uc_home_Extra_services.Instance) Then
            main_menu.main_panel.Controls.Add(uc_home_Extra_services.Instance)
            uc_home_Extra_services.Instance.Dock = DockStyle.Fill
            uc_home_Extra_services.Instance.BringToFront()
            uc_home_Extra_services.Instance.Visible = True
        End If
        uc_home_Extra_services.Instance.BringToFront()
        uc_home_Extra_services.Instance.Visible = True

        global_class.load_services = True
    End Sub


End Class

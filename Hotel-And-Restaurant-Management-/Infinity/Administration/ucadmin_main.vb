Imports System.Data.SqlClient

Public Class ucadmin_main
    Inherits UserControl
    Private Shared _instanse As ucadmin_main
    Public Shared ReadOnly Property Instance() As ucadmin_main
        Get
            If _instanse Is Nothing Then
                _instanse = New ucadmin_main()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_design_room_Click(sender As Object, e As EventArgs) Handles btn_design_room.Click
#Region "dispaly"
        If Not main_menu.main_panel.Controls.Contains(uc_admin_room_manegement.Instance) Then
            main_menu.main_panel.Controls.Add(uc_admin_room_manegement.Instance)
            uc_admin_room_manegement.Instance.Dock = DockStyle.Fill
            uc_admin_room_manegement.Instance.BringToFront()
            uc_admin_room_manegement.Instance.Visible = True
        End If
        uc_admin_room_manegement.Instance.BringToFront()
        uc_admin_room_manegement.Instance.Visible = True
#End Region
#Region "activated"
        uc_admin_room_manegement.Instance.tb_room_no.Text = autoincr("select count(room_id) from room_data", 1000)
        uc_admin_room_manegement.Instance.tb_room_id.Text = autoincr("select count(room_no) from room_data", 100)
        '***********************************************************************************************************
        getconnection()
        cmd = New SqlCommand("select DISTINCT room_type from room_data ", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader()
        uc_admin_room_manegement.Instance.cmb_room_type.Items.Clear()
        While d.Read()
            uc_admin_room_manegement.Instance.cmb_room_type.Items.Add(d("room_type").ToString)
        End While
        d.Close()
        cmd.Dispose()
        endconnection()


#End Region
    End Sub

    Private Sub btn_design_pakage_Click(sender As Object, e As EventArgs) Handles btn_design_pakage.Click
#Region "display"
        If Not main_menu.main_panel.Controls.Contains(uc_admin_package_manege.Instance) Then
            main_menu.main_panel.Controls.Add(uc_admin_package_manege.Instance)
            uc_admin_package_manege.Instance.Dock = DockStyle.Fill
            uc_admin_package_manege.Instance.BringToFront()
            uc_admin_package_manege.Instance.Visible = True
        End If
        uc_admin_package_manege.Instance.BringToFront()
        uc_admin_package_manege.Instance.Visible = True
#End Region
#Region "activated"
        uc_admin_package_manege.Instance.tb_pm_pkg_id.Text = autoincr("select count(pkg_id) from package_data", 100)
        '***********************************************************************************************************
        getconnection()
        cmd = New SqlCommand("select DISTINCT pkg_type from package_data ", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader()
        uc_admin_package_manege.Instance.cmb_pm_pkg_type.Items.Clear()
        While d.Read()
            uc_admin_package_manege.Instance.cmb_pm_pkg_type.Items.Add(d("pkg_type").ToString)
        End While
        d.Close()
        cmd.Dispose()
        endconnection()
        '*************************************************************************************************************
        getconnection()
        cmd = New SqlCommand("select DISTINCT s_name,s_id,service_type,prize from service_data ", con)
        Dim t As SqlDataReader
        Dim cnt As Integer
        t = cmd.ExecuteReader()
        uc_admin_package_manege.Instance.clb_services.Items.Clear()
        While t.Read()
            global_class.hold_pkg_services(cnt) = t("s_id")
            global_class.hold_services_type(cnt) = t("service_type")
            global_class.hold_pkg_service_prize(cnt) = t("prize")
            uc_admin_package_manege.Instance.clb_services.Items.Add(t("s_name").ToString)
            cnt = cnt + 1
        End While
        t.Close()
        cmd.Dispose()
        endconnection()
#End Region
    End Sub

    Private Sub btn_cost_scheduling_Click(sender As Object, e As EventArgs) Handles btn_cost_scheduling.Click
        If Not main_menu.main_panel.Controls.Contains(uc_admin_costscheduling.Instance) Then
            main_menu.main_panel.Controls.Add(uc_admin_costscheduling.Instance)
            uc_admin_costscheduling.Instance.Dock = DockStyle.Fill
            uc_admin_costscheduling.Instance.BringToFront()
            uc_admin_costscheduling.Instance.Visible = True
        End If
        uc_admin_costscheduling.Instance.BringToFront()
        uc_admin_costscheduling.Instance.Visible = True
    End Sub

    Private Sub btn_manage_table_Click(sender As Object, e As EventArgs) Handles btn_manage_table.Click
        If Not main_menu.main_panel.Controls.Contains(uc_admin_table_manegement.Instance) Then
            main_menu.main_panel.Controls.Add(uc_admin_table_manegement.Instance)
            uc_admin_table_manegement.Instance.Dock = DockStyle.Fill
            uc_admin_table_manegement.Instance.BringToFront()
            uc_admin_table_manegement.Instance.Visible = True
        End If
        uc_admin_table_manegement.Instance.BringToFront()
        uc_admin_table_manegement.Instance.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
#Region "define"
        If Not main_menu.main_panel.Controls.Contains(uc_admin_employee_manegement.Instance) Then
            main_menu.main_panel.Controls.Add(uc_admin_employee_manegement.Instance)
            uc_admin_employee_manegement.Instance.Dock = DockStyle.Fill
            uc_admin_employee_manegement.Instance.BringToFront()
            uc_admin_employee_manegement.Instance.Visible = True
        End If
        uc_admin_employee_manegement.Instance.BringToFront()
        uc_admin_employee_manegement.Instance.Visible = True
#End Region
#Region "Activated"
#End Region

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
#Region "display"
        If Not main_menu.main_panel.Controls.Contains(uc_admin_services_manegement.Instance) Then
            main_menu.main_panel.Controls.Add(uc_admin_services_manegement.Instance)
            uc_admin_services_manegement.Instance.Dock = DockStyle.Fill
            uc_admin_services_manegement.Instance.BringToFront()
            uc_admin_services_manegement.Instance.Visible = True
        End If
        uc_admin_services_manegement.Instance.BringToFront()
        uc_admin_services_manegement.Instance.Visible = True
#End Region
#Region "activated"
        If autoincr("select count(s_id) from service_data", 100) = 100 Then
            uc_admin_services_manegement.Instance.tb_sm_services_id.Text = autoincr("select count(s_id) from service_data", 100)
        Else
            uc_admin_services_manegement.Instance.tb_sm_services_id.Text = max("select max(s_id) from service_data")
        End If

        '***********************************************************************************************************
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
#End Region

    End Sub

    Private Sub btn_authentication_Click(sender As Object, e As EventArgs) Handles btn_authentication.Click
        If Not main_menu.main_panel.Controls.Contains(uc_admin_user_authentication.Instance) Then
            main_menu.main_panel.Controls.Add(uc_admin_user_authentication.Instance)
            uc_admin_user_authentication.Instance.Dock = DockStyle.Fill
            uc_admin_user_authentication.Instance.BringToFront()
            uc_admin_user_authentication.Instance.Visible = True
        End If
        uc_admin_user_authentication.Instance.BringToFront()
        uc_admin_user_authentication.Instance.Visible = True
    End Sub

    Private Sub btn_other_Click(sender As Object, e As EventArgs) Handles btn_other.Click
        If Not main_menu.main_panel.Controls.Contains(uc_admin_other.Instance) Then
            main_menu.main_panel.Controls.Add(uc_admin_other.Instance)
            uc_admin_other.Instance.Dock = DockStyle.Fill
            uc_admin_other.Instance.BringToFront()
            uc_admin_other.Instance.Visible = True
        End If
        uc_admin_other.Instance.BringToFront()
        uc_admin_other.Instance.Visible = True
    End Sub


End Class

Imports System.Data.SqlClient

Public Class uchotel_main
    Inherits UserControl
    Private Shared _instanse As uchotel_main
    Public Shared ReadOnly Property Instance() As uchotel_main
        Get
            If _instanse Is Nothing Then
                _instanse = New uchotel_main()
            End If
            Return _instanse
        End Get
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_pakage_Click(sender As Object, e As EventArgs) Handles btn_pakage.Click
#Region "display"
        If Not main_menu.main_panel.Controls.Contains(uchotel_pkg.Instance) Then
            main_menu.main_panel.Controls.Add(uchotel_pkg.Instance)
            uchotel_pkg.Instance.Dock = DockStyle.Fill
            uchotel_pkg.Instance.BringToFront()
            uchotel_pkg.Instance.Visible = True
        End If
        uchotel_pkg.Instance.BringToFront()
        uchotel_pkg.Instance.Visible = True
#End Region
#Region "pkg load iocn"
        uchotel_pkg.Instance.pan_all_pkg_detail.Controls.Clear()
        getconnection()
        Dim x As Integer = 23
        Dim y As Integer = 17
        Dim cnt As Integer = 0
        Dim loopcnt As Integer = 0
        cmd = New SqlCommand("SELECT pkg_name,pkg_guid,pkg_img,day,night,discount,prize,Name,package_data.pkg_id,pkg_type FROM package_data full JOIN pkg_service ON package_data.pkg_id = pkg_service.pkg_id", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader
        If d.Read() Then
start:
            cnt = d("pkg_id")
            Dim obj = New uchotel_pkg_icon
            obj.Location = New System.Drawing.Point(x, y)
            obj.tb_pkg_name.Text = d("pkg_name")
            obj.tb_pkg_type.Text = d("pkg_type")
            obj.tb_pkg_prize.Text = d("prize")
            obj.tb_pm_pkg_days.Text = d("day")
            obj.tb_pm_pkg_nights.Text = d("night")
            obj.tb_discount_value.Text = d("discount")
            obj.pb_pkg_icon_img.Image = global_class.view(d("pkg_img"))
            If d("pkg_guid") Then
                obj.rb_yes.Checked = True
            Else
                obj.rb_no.Checked = True
            End If
            obj.clb_services.Items.Add(d("Name").ToString)
            Try
                While cnt = d("pkg_id")
                    d.Read()
                    If cnt = d("pkg_id") Then
                        obj.clb_services.Items.Add(d("Name").ToString)
                    End If
                End While
                uchotel_pkg.Instance.pan_all_pkg_detail.Controls.Add(obj)
                y = y + 345
                GoTo start
            Catch
                uchotel_pkg.Instance.pan_all_pkg_detail.Controls.Add(obj)
            End Try
        End If
#End Region
    End Sub

    Private Sub btn_room_manegment_Click(sender As Object, e As EventArgs) Handles btn_room_manegment.Click
#Region "dispaly"
        If Not main_menu.main_panel.Controls.Contains(uchotel_room_manegement.Instance) Then
            main_menu.main_panel.Controls.Add(uchotel_room_manegement.Instance)
            uchotel_room_manegement.Instance.Dock = DockStyle.Fill
            uchotel_room_manegement.Instance.BringToFront()
            uchotel_room_manegement.Instance.Visible = True
        End If
        uchotel_room_manegement.Instance.BringToFront()
        uchotel_room_manegement.Instance.Visible = True
#End Region
        grid_load("select * from room_data", uchotel_room_manegement.Instance.dg_rm_ri_view)
    End Sub

    Private Sub btn_reservation_Click(sender As Object, e As EventArgs) Handles btn_reservation.Click
#Region "dispaly"
        If Not main_menu.main_panel.Controls.Contains(uchotel_reservation.Instance) Then
            main_menu.main_panel.Controls.Add(uchotel_reservation.Instance)
            uchotel_reservation.Instance.Dock = DockStyle.Fill
            uchotel_reservation.Instance.BringToFront()
            uchotel_reservation.Instance.Visible = True
        End If
        uchotel_reservation.Instance.BringToFront()
        uchotel_reservation.Instance.Visible = True
#End Region
#Region "Activated"
        uchotel_reservation.Instance.tb_rm_rid.Text = autoincr("select count(r_id) from Reservation_data", 1000)
        grid_load("select * from Reservation_data  ", uchotel_reservation.Instance.dgv_rm_grid)
        getconnection()
        cmd = New SqlCommand("select DISTINCT pkg_name from package_data ", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader()
        uchotel_reservation.Instance.cmb_rm_pkg_name.Items.Clear()
        While d.Read()
            uchotel_reservation.Instance.cmb_rm_pkg_name.Items.Add(d("pkg_name").ToString)
        End While
        d.Close()
        cmd.Dispose()

#End Region
    End Sub

    Private Sub btn_guest_info_Click(sender As Object, e As EventArgs) Handles btn_guest_info.Click
        If Not main_menu.main_panel.Controls.Contains(uc_hotel_guest.Instance) Then
            main_menu.main_panel.Controls.Add(uc_hotel_guest.Instance)
            uc_hotel_guest.Instance.Dock = DockStyle.Fill
            uc_hotel_guest.Instance.BringToFront()
            uc_hotel_guest.Instance.Visible = True
        End If
        uc_hotel_guest.Instance.BringToFront()
        uc_hotel_guest.Instance.Visible = True
    End Sub


End Class

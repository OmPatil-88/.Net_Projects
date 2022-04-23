Public Class main_menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If global_class.time_var = 0 Then
            Dim max As Byte = main_img_slider.Images.Count
            Dim pos As Byte = 0
            main_img_slider.AnimationTime = 2500
            If pos < max Then
                main_img_slider.SlideNext()
                main_img_slider.SlideFirst()
            End If
        End If
    End Sub
    Private Sub main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        global_class.side_moving(pan_moving, btn_home)
        Timer1.Enabled = True
    End Sub
    Private Sub main_menu_activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' pb_user.Image = global_class.view(global_class.user_image)
        global_class.side_moving(pan_moving, btn_home)
        Timer1.Enabled = True
        lb_user_name.Text = global_class.user_name
        lbl_global_usr_statues.Text = global_class.user_statues

        If lbl_global_usr_statues.Text = "Administration                                    " Then
            btn_report.Visible = True
            btn_administartion.Visible = True
            btn_restorunt.Visible = True
            btn_home.Visible = True
            btn_hotal.Visible = True
            uchome.Instance.btn_checkin.Enabled = True
            uchome.Instance.btn_cout.Enabled = True
            uchome.Instance.btn_extra_services.Enabled = True

        ElseIf lbl_global_usr_statues.Text = "Recepationeast                                    " Then
            btn_hotal.Visible = True
            btn_report.Visible = False
            btn_administartion.Visible = False
            btn_restorunt.Visible = False
            btn_home.Visible = True
            uchome.Instance.btn_checkin.Enabled = True
            uchome.Instance.btn_cout.Enabled = True
            uchome.Instance.btn_extra_services.Enabled = True

        ElseIf lbl_global_usr_statues.Text = "Employe                                           " Then

            uchome.Instance.btn_checkin.Enabled = False
            uchome.Instance.btn_cout.Enabled = False
            uchome.Instance.btn_extra_services.Enabled = False
            btn_home.Visible = True
            btn_report.Visible = False
            btn_administartion.Visible = False
            btn_restorunt.Visible = False

        ElseIf lbl_global_usr_statues.Text = "Chef                                              " Then

            btn_report.Visible = False
            btn_administartion.Visible = False
            btn_restorunt.Visible = True
            btn_hotal.Visible = False
            btn_home.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        global_class.side_moving(pan_moving, btn_home)
        If Not main_panel.Controls.Contains(uchome.Instance) Then
            main_panel.Controls.Add(uchome.Instance)
            uchome.Instance.Dock = DockStyle.Fill
            uchome.Instance.BringToFront()
            uchome.Instance.Visible = True
        End If
        uchome.Instance.BringToFront()
        uchome.Instance.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_restorunt.Click
        global_class.side_moving(pan_moving, btn_restorunt)
        If Not main_panel.Controls.Contains(ucr_main.Instance) Then
            main_panel.Controls.Add(ucr_main.Instance)
            ucr_main.Instance.Dock = DockStyle.Fill
            ucr_main.Instance.BringToFront()
            ucr_main.Instance.Visible = True
        End If
        ucr_main.Instance.BringToFront()
        ucr_main.Instance.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_hotal.Click
        global_class.side_moving(pan_moving, btn_hotal)
        If Not main_panel.Controls.Contains(uchotel_main.Instance) Then
            main_panel.Controls.Add(uchotel_main.Instance)
            uchotel_main.Instance.Dock = DockStyle.Fill
            uchotel_main.Instance.BringToFront()
            uchotel_main.Instance.Visible = True
        End If
        uchotel_main.Instance.BringToFront()
        uchotel_main.Instance.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_administartion.Click
        global_class.side_moving(pan_moving, btn_administartion)
        If Not main_panel.Controls.Contains(ucadmin_main.Instance) Then
            main_panel.Controls.Add(ucadmin_main.Instance)
            ucadmin_main.Instance.Dock = DockStyle.Fill
            ucadmin_main.Instance.BringToFront()
            ucadmin_main.Instance.Visible = True
        End If
        ucadmin_main.Instance.BringToFront()
        ucadmin_main.Instance.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        global_class.side_moving(pan_moving, btn_report)

        If Not main_panel.Controls.Contains(uc_report_main.Instance) Then
            main_panel.Controls.Add(uc_report_main.Instance)
            uc_report_main.Instance.Dock = DockStyle.Fill
            uc_report_main.Instance.BringToFront()
            uc_report_main.Instance.Visible = True
        End If
        uc_report_main.Instance.BringToFront()
        uc_report_main.Instance.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        global_class.side_moving(pan_moving, btn_logout)
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub main_menu_Leave(sender As Object, e As EventArgs)
        global_class.side_moving(pan_moving, btn_home)
        main_panel.Controls.Remove(uchome.Instance)
        main_panel.Controls.Remove(ucr_main.Instance)
        main_panel.Controls.Remove(uchotel_main.Instance)
        main_panel.Controls.Remove(uc_report_main.Instance)
        main_panel.Controls.Remove(ucadmin_main.Instance)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        global_class.side_moving(pan_moving, btn_home)
        main_panel.Controls.Remove(uchome.Instance)
        main_panel.Controls.Remove(uchome_bill.Instance)
        main_panel.Controls.Remove(uchome_check_in.Instance)
        main_panel.Controls.Remove(uchome_check_out.Instance)
        main_panel.Controls.Remove(uc_home_Extra_services.Instance)

        main_panel.Controls.Remove(ucr_delear_datail.Instance)
        main_panel.Controls.Remove(ucr_kitchen.Instance)
        main_panel.Controls.Remove(ucr_menu.Instance)
        main_panel.Controls.Remove(ucr_stock.Instance)
        main_panel.Controls.Remove(ucr_tbl.Instance)
        main_panel.Controls.Remove(ucr_main.Instance)

        main_panel.Controls.Remove(uc_hotel_guest.Instance)
        main_panel.Controls.Remove(uchotel_pkg.Instance)
        main_panel.Controls.Remove(uchotel_reservation.Instance)
        main_panel.Controls.Remove(uchotel_room_manegement.Instance)
        main_panel.Controls.Remove(uchotel_main.Instance)

        main_panel.Controls.Remove(report_delear_payment_slip.Instance)
        ' main_panel.Controls.Remove(report_employe_payment_slip.Instance)
        main_panel.Controls.Remove(report_final_checkin_out.Instance)
        main_panel.Controls.Remove(report_hotal_bill.Instance)
        main_panel.Controls.Remove(report_restarunt.Instance)
        main_panel.Controls.Remove(report_Stock_records.Instance)
        main_panel.Controls.Remove(uc_report_main.Instance)


        main_panel.Controls.Remove(ucadmin_main.Instance)
        main_panel.Controls.Remove(uc_admin_costscheduling.Instance)
        main_panel.Controls.Remove(uc_admin_employee_manegement.Instance)
        main_panel.Controls.Remove(uc_admin_other.Instance)
        main_panel.Controls.Remove(uc_admin_package_manege.Instance)
        main_panel.Controls.Remove(uc_admin_room_manegement.Instance)
        main_panel.Controls.Remove(uc_admin_services_manegement.Instance)
        main_panel.Controls.Remove(uc_admin_table_manegement.Instance)
        main_panel.Controls.Remove(uc_admin_user_authentication.Instance)




    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
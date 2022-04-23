Public Class uc_report_main
    Inherits UserControl
    Private Shared _instanse As uc_report_main
    Public Shared ReadOnly Property Instance() As uc_report_main
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_report_main()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_final_checkin_out_Click(sender As Object, e As EventArgs) Handles btn_final_checkin_out.Click
        If Not main_menu.main_panel.Controls.Contains(report_final_checkin_out.Instance) Then
            main_menu.main_panel.Controls.Add(report_final_checkin_out.Instance)
            report_final_checkin_out.Instance.Dock = DockStyle.Fill
            report_final_checkin_out.Instance.BringToFront()
            report_final_checkin_out.Instance.Visible = True
        End If
        report_final_checkin_out.Instance.BringToFront()
        report_final_checkin_out.Instance.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not main_menu.main_panel.Controls.Contains(report_Stock_records.Instance) Then
            main_menu.main_panel.Controls.Add(report_Stock_records.Instance)
            report_Stock_records.Instance.Dock = DockStyle.Fill
            report_Stock_records.Instance.BringToFront()
            report_Stock_records.Instance.Visible = True
        End If
        report_Stock_records.Instance.BringToFront()
        report_Stock_records.Instance.Visible = True
        '******************************************************load
        report_Stock_records.Instance.btn_view_all.PerformClick()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not main_menu.main_panel.Controls.Contains(report_hotal_bill.Instance) Then
            main_menu.main_panel.Controls.Add(report_hotal_bill.Instance)
            report_hotal_bill.Instance.Dock = DockStyle.Fill
            report_hotal_bill.Instance.BringToFront()
            report_hotal_bill.Instance.Visible = True
        End If
        report_hotal_bill.Instance.BringToFront()
        report_hotal_bill.Instance.Visible = True
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    If Not main_menu.main_panel.Controls.Contains(report_employe_payment_slip.Instance) Then
    '        main_menu.main_panel.Controls.Add(report_employe_payment_slip.Instance)
    '        report_employe_payment_slip.Instance.Dock = DockStyle.Fill
    '        report_employe_payment_slip.Instance.BringToFront()
    '        report_employe_payment_slip.Instance.Visible = True
    '    End If
    '    report_employe_payment_slip.Instance.BringToFront()
    '    report_employe_payment_slip.Instance.Visible = True
    'End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not main_menu.main_panel.Controls.Contains(report_restarunt.Instance) Then
            main_menu.main_panel.Controls.Add(report_restarunt.Instance)
            report_restarunt.Instance.Dock = DockStyle.Fill
            report_restarunt.Instance.BringToFront()
            report_restarunt.Instance.Visible = True
        End If
        report_restarunt.Instance.BringToFront()
        report_restarunt.Instance.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not main_menu.main_panel.Controls.Contains(report_delear_payment_slip.Instance) Then
            main_menu.main_panel.Controls.Add(report_delear_payment_slip.Instance)
            report_delear_payment_slip.Instance.Dock = DockStyle.Fill
            report_delear_payment_slip.Instance.BringToFront()
            report_delear_payment_slip.Instance.Visible = True
        End If
        report_delear_payment_slip.Instance.BringToFront()
        report_delear_payment_slip.Instance.Visible = True
    End Sub


End Class

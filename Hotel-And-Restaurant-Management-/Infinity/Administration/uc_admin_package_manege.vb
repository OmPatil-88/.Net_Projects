Imports System.Data.SqlClient
Imports System.IO

Public Class uc_admin_package_manege
    Inherits UserControl
    Dim d As Date
    Private Shared _instanse As uc_admin_package_manege
    Public Shared ReadOnly Property Instance() As uc_admin_package_manege
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_admin_package_manege()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub dtp_create_date_ValueChanged(sender As Object, e As EventArgs) Handles dtp_create_date.ValueChanged
        Dim t As TimeSpan = DateTime.Now.Date - dtp_create_date.Value
        If cmb_valid_for_type.SelectedIndex = 0 Then

            'tb_em_emp_age.Text = String.Format("{0:n0} ", (t.TotalDays / 365))
            'tb_em_emp_age.Enabled = False
        End If
    End Sub

    Private Sub btn_create_pkg_Click(sender As Object, e As EventArgs) Handles btn_create_pkg.Click
        getconnection()
        Dim mst As New MemoryStream
        Dim bm As New Bitmap(pb_pkg_icon_images.Image)
        Dim guid As Byte
        If rb_yes.Checked Then
            guid = True
        Else
            guid = False
        End If
        cmd = New SqlCommand("insert into package_data (pkg_id,pkg_name,pkg_type,day,night,prize,valid_for,create_date,last_date,pkg_guid,discount_name,discount,pkg_img)values(" & tb_pm_pkg_id.Text & ",'" & tb_pm_pkg_name.Text & "','" & cmb_pm_pkg_type.Text & "','" & tb_pm_pkg_days.Text + "','" & tb_pm_pkg_nights.Text & "','" & tb_grand_prize.Text & "','" & tb_pm_pkg_days.Text & "','" & dtp_create_date.Text & "','" & dtp_last_date.Text & "','" & guid & "','" & tb_pkg_discount.Text & "','" & tb_discount_value.Text & "',@img)", con)
        If tb_pm_pkg_name.Text <> "" And tb_pm_pkg_days.Text <> "" And cmb_pm_pkg_type.Text <> "" And tb_pm_pkg_nights.Text <> "" And tb_pm_pkg_valid_for.Text <> "" And tb_pm_pkg_days.Text <> "" And dtp_create_date.Text <> "" And dtp_last_date.Text <> "" And tb_discount_value.Text <> "" And tb_pkg_discount.Text <> "" And tb_discount_value.Text <> "" And Not pb_pkg_icon_images.Image Is Nothing Then
            bm.Save(mst, pb_pkg_icon_images.Image.RawFormat)
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = mst.ToArray()
            Dim i As Integer = cmd.ExecuteNonQuery()
            cmd.Dispose()
            For Each item In clb_services.CheckedItems
                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandText = "insert into pkg_service values(" & tb_pm_pkg_id.Text & "," & global_class.hold_pkg_services(clb_services.Items.IndexOf(item)) & ",'" & clb_services.Items(clb_services.Items.IndexOf(item)).ToString & "','" & global_class.hold_services_type(clb_services.Items.IndexOf(item)) & "'," & global_class.hold_pkg_service_prize(clb_services.Items.IndexOf(item)) & ") "
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                pb_pkg_icon_images.Image = Nothing
                global_class.clearAllmetrobunifuTextbo(pan_pkg_manege_main)
                global_class.clearAlldatetimepicker(pan_pkg_manege_main)
                global_class.clearAllcombo_box(pan_pkg_manege_main)
                tb_pm_pkg_id.Text = autoincr("select count(pkg_id) from package_data", 100)
                rb_yes.Checked = False
                rb_no.Checked = False

                For item As Integer = 0 To clb_services.Items.Count - 1
                    clb_services.SetItemCheckState(item, False)
                Next
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_browse_img_Click(sender As Object, e As EventArgs) Handles btn_browse_img.Click
        global_class.browse(pb_pkg_icon_images.Image)
    End Sub

    Private Sub btn_search_pkg_Click(sender As Object, e As EventArgs) Handles btn_search_pkg.Click
        For item As Integer = 0 To clb_services.Items.Count - 1
            clb_services.SetItemCheckState(item, False)
        Next
        getconnection()
        cmd.Connection = con
        If tb_pm_pkg_id.Enabled = False Then
            tb_pm_pkg_id.Enabled = False
        End If
        cmd.CommandText = "select * from  package_data where pkg_id = " + tb_pm_pkg_id.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_pm_pkg_name.Text = dr("pkg_name")
            cmb_pm_pkg_type.Text = dr("pkg_type")
            tb_pm_pkg_days.Text = dr("day")
            tb_pm_pkg_nights.Text = dr("night")
            tb_grand_prize.Text = dr("prize")
            tb_pm_pkg_valid_for.Text = dr("valid_for")
            dtp_create_date.Text = dr("create_date")
            dtp_last_date.Text = dr("last_date")
            If dr("pkg_guid") Then
                rb_yes.Checked = True
            Else
                rb_no.Checked = True
            End If
            tb_pkg_discount.Text = dr("discount_name")
            tb_discount_value.Text = dr("discount")
            If dr("pkg_img").ToString() <> "" Then
                pb_pkg_icon_images.Image = global_class.view(dr("pkg_img"))
            Else
                pb_pkg_icon_images.Image = Infinity.My.Resources.user
            End If
            dr.Close()
            cmd.Dispose()
            cmd = New SqlCommand("select * from pkg_service where pkg_id=" & tb_pm_pkg_id.Text & " ", con)
            Dim d As SqlDataReader
            d = cmd.ExecuteReader()
            Dim cnt As Integer = 0
            While d.Read()
                For j As Integer = 0 To clb_services.Items.Count - 1
                    If d("Name") = clb_services.Items(j) Then
                        clb_services.SetItemChecked(j, True)
                        Continue While
                    End If
                Next

            End While
        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If

        con.Close()
        endconnection()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        getconnection()
        cmd.Connection = con
        Dim MS As New MemoryStream
        Dim bm As New Bitmap(pb_pkg_icon_images.Image)
        Dim temp_guid As Byte = False
        If rb_yes.Checked Then
            temp_guid = 1
        End If
        cmd = New SqlCommand("update package_data set pkg_name='" & tb_pm_pkg_name.Text & "',pkg_type='" & cmb_pm_pkg_type.Text & "',day=" & tb_pm_pkg_days.Text & ",night=" & tb_pm_pkg_nights.Text & ",prize=" & tb_grand_prize.Text & ",valid_for=" & tb_pm_pkg_valid_for.Text & ",create_date='" & dtp_create_date.Text & "',last_date='" & dtp_last_date.Text & "',pkg_guid=" & temp_guid & ",discount_name='" & tb_pkg_discount.Text & "',discount=" & tb_discount_value.Text & ",pkg_img =@img where  pkg_id=" & tb_pm_pkg_id.Text & "", con)

        If tb_pm_pkg_name.Text <> "" And tb_pm_pkg_days.Text <> "" And cmb_pm_pkg_type.Text <> "" And tb_pm_pkg_nights.Text <> "" And tb_pm_pkg_valid_for.Text <> "" And tb_pm_pkg_days.Text <> "" And dtp_create_date.Text <> "" And dtp_last_date.Text <> "" And tb_discount_value.Text <> "" And tb_pkg_discount.Text <> "" And tb_discount_value.Text <> "" And Not pb_pkg_icon_images.Image Is Nothing Then

            bm.Save(MS, pb_pkg_icon_images.Image.RawFormat)
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = MS.ToArray()
            Dim i As Integer = cmd.ExecuteNonQuery()
            cmd.Dispose()
            cmd = New SqlCommand("delete from pkg_service where pkg_id=" & tb_pm_pkg_id.Text & "", con)
            If cmd.ExecuteNonQuery() = 1 Then
                GoTo last
            End If
            cmd.Dispose()
            For Each item In clb_services.CheckedItems
                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandText = "insert into pkg_service values(" & tb_pm_pkg_id.Text & "," & global_class.hold_pkg_services(clb_services.Items.IndexOf(item)) & ",'" & clb_services.Items(clb_services.Items.IndexOf(item)).ToString & "','" & global_class.hold_services_type(clb_services.Items.IndexOf(item)) & "'," & global_class.hold_pkg_service_prize(clb_services.Items.IndexOf(item)) & ") "
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                pb_pkg_icon_images.Image = Nothing
                global_class.clearAllmetrobunifuTextbo(pan_pkg_manege_main)
                global_class.clearAlldatetimepicker(pan_pkg_manege_main)
                global_class.clearAllcombo_box(pan_pkg_manege_main)
                tb_pm_pkg_id.Text = autoincr("select count(pkg_id) from package_data", 100)
                rb_yes.Checked = False
                rb_no.Checked = False

                For item As Integer = 0 To clb_services.Items.Count - 1
                    clb_services.SetItemCheckState(item, False)
                Next
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        GoTo endl
last:
        MessageBox.Show("No Record Found")
endl:
        bm.Dispose()
        MS.Dispose()
        cmd.Parameters.Clear()
        con.Close()
    End Sub

    Private Sub tb_pm_pkg_valid_for_OnValueChanged(sender As Object, e As EventArgs) Handles tb_pm_pkg_valid_for.OnValueChanged
        If tb_pm_pkg_valid_for.Text <> "" And cmb_valid_for_type.Text = "Days" Then
            dtp_last_date.Value = dtp_create_date.Value.AddDays(Val(tb_pm_pkg_valid_for.Text))
        ElseIf tb_pm_pkg_valid_for.Text <> "" And cmb_valid_for_type.Text = "Month" Then
            dtp_last_date.Value = dtp_create_date.Value.AddMonths(Val(tb_pm_pkg_valid_for.Text))
        ElseIf tb_pm_pkg_valid_for.Text <> "" And cmb_valid_for_type.Text = "Year" Then
            dtp_last_date.Value = dtp_create_date.Value.AddYears(Val(tb_pm_pkg_valid_for.Text))
        End If
    End Sub
    Private Sub clb_services_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_services.SelectedIndexChanged
        Dim total As Double = 0.0
        'While clb_services.Items.Count > 0
        For Each item In clb_services.CheckedItems
            getconnection()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            ' Dim cnt As Integer = clb_services.Items.IndexOf(item)
            cmd.CommandText = "select prize from service_data where s_name='" & clb_services.Items(clb_services.Items.IndexOf(item)).ToString & "'"
            total = total + cmd.ExecuteScalar()
            cmd.Dispose()
            endconnection()
        Next
        'End While
        tb_all_service_cost.Text = total
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        pb_pkg_icon_images.Image = Nothing
        global_class.clearAllmetrobunifuTextbo(pan_pkg_manege_main)
        global_class.clearAlldatetimepicker(pan_pkg_manege_main)
        global_class.clearAllcombo_box(pan_pkg_manege_main)
        tb_pm_pkg_id.Text = autoincr("select count(pkg_id) from package_data", 100)
        rb_yes.Checked = False
        rb_no.Checked = False

        For item As Integer = 0 To clb_services.Items.Count - 1
            clb_services.SetItemCheckState(item, False)
        Next
    End Sub

    Private Sub clb_services_Leave(sender As Object, e As EventArgs) Handles clb_services.Leave
        Dim total As Double = 0.0
        For Each item In clb_services.CheckedItems
            getconnection()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            ' Dim cnt As Integer = clb_services.Items.IndexOf(item)
            cmd.CommandText = "select prize from service_data where s_name='" & clb_services.Items(clb_services.Items.IndexOf(item)).ToString & "'"
            total = total + cmd.ExecuteScalar()
            cmd.Dispose()
            endconnection()
        Next
        tb_all_service_cost.Text = total
    End Sub
    Private Sub IsChar(sender As Object, e As KeyPressEventArgs) Handles tb_pm_pkg_name.KeyPress, tb_pkg_discount.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Lf AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_grand_prize.KeyPress, tb_pm_pkg_days.KeyPress, tb_pm_pkg_nights.KeyPress, tb_all_service_cost.KeyPress, tb_discount_value.KeyPress, tb_pm_pkg_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

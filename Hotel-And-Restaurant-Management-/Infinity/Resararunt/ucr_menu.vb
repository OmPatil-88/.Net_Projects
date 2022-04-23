Imports System.Data.SqlClient
Imports System.IO

Public Class ucr_menu
    Inherits UserControl
    Private Shared _instanse As ucr_menu
    Public Shared ReadOnly Property Instance() As ucr_menu
        Get
            If _instanse Is Nothing Then
                _instanse = New ucr_menu()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub ucr_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "cmobo load"
        getconnection()
        Dim Chef As String = "Chef"
        cmd = New SqlCommand("select e_name,e_surname from emplyee_detail where e_type='" + Chef + "' ", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        cmb_chef_name.Items.Clear()
        While dr.Read()
            cmb_chef_name.Items.Add(dr("e_name") + " " + dr("e_surname").ToString)
        End While
        dr.Close()
        cmd.Dispose()
        endconnection()
        global_class.clearAllmetrobunifuTextbo(pan_mm_main)
        global_class.clearAllcombo_box(pan_mm_main)
        tb_mm_menu_id.Text = autoincr("select count(menu_id) from menu_data", 100)
#End Region
#Region "icon load"
        getconnection()
        Dim x As Integer = 40
        Dim y As Integer = 37
        Dim cnt As Integer = 1
        cmd = New SqlCommand("select * from menu_data", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader
        While d.Read()
            Dim obj = New ucr_menu_icon
            obj.Location = New System.Drawing.Point(x, y)


            obj.tb_ucer_menu_name.Text = d("menu_name")
            obj.tb_ucr_menu_category.Text = d("menu_category")
            obj.tb_ucr_menu_type.Text = d("menu_type")
            obj.tb_ucr_menu_peize.Text = d("prize")
            obj.pb_menu_image_user_control.Image = global_class.view(d("menu_image"))
            pan_menu_icon.Controls.Add(obj)
            x = x + 380
            cnt = cnt + 1
            If cnt > 4 Then
                cnt = 1
                y = y + 345
                x = 40
            End If
        End While
#End Region
    End Sub

    Private Sub ucr_menu_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Hide()
    End Sub
    Private Sub btn_mm_menu_new_Click(sender As Object, e As EventArgs) Handles btn_mm_menu_new.Click
        tb_mm_menu_name.Text = ""
        tb_mm_menu_time.Text = ""
        tb_mm_menu_prize.Text = ""
        global_class.clearAllcombo_box(pan_mm_main)
        tb_mm_menu_id.Text = autoincr("select count(menu_id) from menu_data", 100)
        tb_mm_menu_id.Enabled = False
        btn_mm_menu_save.Enabled = True
        pb_menu_image.Image = Infinity.My.Resources.user
        cmb_chef_name.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_chef_name.Enabled = True
        cmb_menu_category.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_menu_category.Enabled = True
        cmb_menu_type.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_menu_type.Enabled = True
    End Sub

    Private Sub btn_mm_menu_save_Click(sender As Object, e As EventArgs) Handles btn_mm_menu_save.Click
#Region "insert data"
        getconnection()
        Dim mst As New MemoryStream
        cmd = New SqlCommand("insert into menu_data values(" & tb_mm_menu_id.Text & ",'" & tb_mm_menu_name.Text & "','" & cmb_menu_category.Text & "',@menu_image,'" & cmb_menu_type.Text + "','" & tb_mm_menu_time.Text & "','" & cmb_chef_name.Text & "','" & tb_mm_menu_prize.Text & "')", con)
        If tb_mm_menu_id.Text <> "" And tb_mm_menu_name.Text <> "" And cmb_menu_category.Text <> "" And cmb_menu_type.Text <> "" And tb_mm_menu_time.Text <> "" And cmb_chef_name.Text <> "" And tb_mm_menu_prize.Text <> "" Then
            pb_menu_image.Image.Save(mst, pb_menu_image.Image.RawFormat)
            cmd.Parameters.Add("@menu_image", SqlDbType.Image).Value = mst.ToArray()
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                pb_menu_image.Image = Nothing
                global_class.clearAllmetrobunifuTextbo(pan_mm_main)
                global_class.clearAllcombo_box(pan_mm_main)
                tb_mm_menu_id.Text = autoincr("select count(menu_id) from menu_data", 100)
                btn_mm_menu_save.Enabled = False
                tb_mm_menu_id.Enabled = True
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
#End Region
#Region "icon load"
        pan_menu_icon.Controls.Clear()
        getconnection()
        Dim x As Integer = 40
        Dim y As Integer = 37
        Dim cnt As Integer = 1
        cmd = New SqlCommand("select * from menu_data", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader
        While d.Read()
            Dim obj = New ucr_menu_icon
            obj.Location = New System.Drawing.Point(x, y)


            obj.tb_ucer_menu_name.Text = d("menu_name")
            obj.tb_ucr_menu_category.Text = d("menu_category")
            obj.tb_ucr_menu_type.Text = d("menu_type")
            obj.tb_ucr_menu_peize.Text = d("prize")
            obj.pb_menu_image_user_control.Image = global_class.view(d("menu_image"))
            pan_menu_icon.Controls.Add(obj)
            x = x + 380
            cnt = cnt + 1
            If cnt > 4 Then
                cnt = 1
                y = y + 345
                x = 40
            End If
        End While
#End Region
    End Sub

    Private Sub btn_mm__menu_search_Click(sender As Object, e As EventArgs) Handles btn_mm__menu_search.Click
        getconnection()
        cmd.Connection = con
        If tb_mm_menu_id.Enabled = False Then
            tb_mm_menu_id.Enabled = False
            tb_mm_menu_id.Enabled = False
        End If
        cmd.CommandText = "select * from  menu_data where menu_id = " + tb_mm_menu_id.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_mm_menu_name.Text = dr("menu_name")
            tb_mm_menu_time.Text = dr("menu_time")
            tb_mm_menu_prize.Text = dr("prize")
            cmb_chef_name.DropDownStyle = ComboBoxStyle.DropDown
            cmb_menu_category.DropDownStyle = ComboBoxStyle.DropDown
            cmb_menu_type.DropDownStyle = ComboBoxStyle.DropDown
            cmb_chef_name.Text = dr("chef_name")
            cmb_menu_category.Text = dr("menu_category")
            cmb_menu_type.Text = dr("menu_type")
            If dr("menu_image").ToString() <> "" Then
                pb_menu_image.Image = global_class.view(dr("menu_image"))
            Else
                pb_menu_image.Image = Infinity.My.Resources.user
            End If


        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_browse_image_Click(sender As Object, e As EventArgs) Handles btn_browse_image.Click
        global_class.browse(pb_menu_image.Image)
    End Sub

    Private Sub btn_mm_menu_update_Click(sender As Object, e As EventArgs) Handles btn_mm_menu_update.Click
        getconnection()
        cmd.Connection = con
        Dim MS As New MemoryStream
        Dim bm As New Bitmap(pb_menu_image.Image)
        cmd.CommandText = "update menu_data set menu_name='" + tb_mm_menu_name.Text + "',menu_category='" + cmb_menu_category.Text + "',menu_type='" + cmb_menu_type.Text + "',menu_time='" + tb_mm_menu_time.Text + "',chef_name='" + cmb_chef_name.Text + "',prize='" + tb_mm_menu_prize.Text + "',menu_image = @menu_image where menu_id='" + tb_mm_menu_id.Text + "' "

        If tb_mm_menu_id.Text <> "" And tb_mm_menu_name.Text <> "" And cmb_menu_category.Text <> "" And cmb_menu_type.Text <> "" And tb_mm_menu_time.Text <> "" And cmb_chef_name.Text <> "" And tb_mm_menu_prize.Text <> "" Then


            bm.Save(MS, pb_menu_image.Image.RawFormat)
            cmd.Parameters.Add("@menu_image", SqlDbType.Image).Value = MS.ToArray()


            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                cmb_menu_category.SelectedIndex = -1
                cmb_menu_type.SelectedIndex = -1
                cmb_chef_name.SelectedIndex = -1
                global_class.clearAllmetrobunifuTextbo(pan_mm_main)
                pb_menu_image.Image = Infinity.My.Resources.user
                cmb_menu_category.DropDownStyle = ComboBoxStyle.DropDownList
                cmb_menu_category.Enabled = True
                tb_mm_menu_id.Text = autoincr("select count(menu_id) from menu_data", 100)
#Region "icon load"
                pan_menu_icon.Controls.Clear()
                getconnection()
                Dim x As Integer = 40
                Dim y As Integer = 37
                Dim cnt As Integer = 1
                cmd = New SqlCommand("select * from menu_data", con)
                Dim d As SqlDataReader
                d = cmd.ExecuteReader
                While d.Read()
                    Dim obj = New ucr_menu_icon
                    obj.Location = New System.Drawing.Point(x, y)


                    obj.tb_ucer_menu_name.Text = d("menu_name")
                    obj.tb_ucr_menu_category.Text = d("menu_category")
                    obj.tb_ucr_menu_type.Text = d("menu_type")
                    obj.tb_ucr_menu_peize.Text = d("prize")
                    obj.pb_menu_image_user_control.Image = global_class.view(d("menu_image"))
                    pan_menu_icon.Controls.Add(obj)
                    x = x + 380
                    cnt = cnt + 1
                    If cnt > 4 Then
                        cnt = 1
                        y = y + 345
                        x = 40
                    End If
                End While
#End Region

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        MS.Dispose()
        bm.Dispose()
        cmd.Dispose()
    End Sub


    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_mm_menu_time.KeyPress, tb_mm_menu_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub IsChar(sender As Object, e As KeyPressEventArgs) Handles tb_mm_menu_name.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Lf AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

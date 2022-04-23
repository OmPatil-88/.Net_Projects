
Imports System.Data.SqlClient
Imports System.IO
Public Class uc_admin_room_manegement
    Inherits UserControl
    Private Shared _instanse As uc_admin_room_manegement
    Public Shared ReadOnly Property Instance() As uc_admin_room_manegement
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_admin_room_manegement()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        getconnection()

        cmd = New SqlCommand("insert into room_data (room_no,room_id,room_type,total_capacity,prize,romm_desc,room_img)values('" & tb_room_no.Text & "','" & tb_room_id.Text & "','" & cmb_room_type.Text + "','" & tb_room_total_capacity.Text & "','" & tb_room_prize.Text & "','" & tb_desc.Text & "',@image)", con)

        If tb_room_no.Text <> "" And tb_room_id.Text <> "" And cmb_room_type.Text <> "" And tb_room_total_capacity.Text <> "" And tb_room_prize.Text <> "" And tb_desc.Text <> "" And Not pb_room_images.Image Is Nothing Then
            pb_room_images.Image.Save(ms, pb_room_images.Image.RawFormat)
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("RECORD SAVED !!!!!!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                global_class.clearAllmetrobunifuTextbo(pan_rm_room)
                global_class.clearAllcombo_box(pan_rm_room)
                pb_room_images.Image = Nothing
                tb_room_no.Text = autoincr("select count(room_id) from room_data", 1000)
                tb_room_id.Text = autoincr("select count(room_no) from room_data", 100)
                btn_add.Enabled = False
                tb_room_id.Enabled = True
            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        global_class.browse(pb_room_images.Image)
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        global_class.clearAllmetrobunifuTextbo(pan_rm_room)
        global_class.clearAllcombo_box(pan_rm_room)
        pb_room_images.Image = Nothing
        tb_room_no.Text = autoincr("select count(room_id) from room_data", 1000)
        tb_room_id.Text = autoincr("select count(room_no) from room_data", 100)
        btn_search.Enabled = False
        btn_add.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        getconnection()
        cmd.Connection = con
        Dim MS As New MemoryStream
        Dim bm As New Bitmap(pb_room_images.Image)
        cmd.CommandText = "update room_data set room_id='" + tb_room_id.Text + "',room_type='" + cmb_room_type.Text + "',total_capacity='" + tb_room_total_capacity.Text + "',prize='" + tb_room_prize.Text + "',romm_desc='" + tb_desc.Text + "',room_img = @image where  room_no='" + tb_room_no.Text + "'"

        If tb_room_no.Text <> "" And tb_room_id.Text <> "" And cmb_room_type.Text <> "" And tb_room_total_capacity.Text <> "" And tb_room_prize.Text <> "" And tb_desc.Text <> "" And Not pb_room_images.Image Is Nothing Then


            bm.Save(MS, pb_room_images.Image.RawFormat)
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = MS.ToArray()


            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("RECORD UPDATED !!!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                global_class.clearAllmetrobunifuTextbo(pan_rm_room)
                global_class.clearAllcombo_box(pan_rm_room)
                tb_room_no.Text = autoincr("select count(room_id) from room_data", 1000)
                tb_room_id.Text = autoincr("select count(room_no) from room_data", 100)
                pb_room_images.Image = Nothing

            Else
                MessageBox.Show("Server Error")
            End If
        Else
            MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
        MS.Dispose()
        bm.Dispose()
        cmd.Parameters.Clear()
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_search_Click_1(sender As Object, e As EventArgs) Handles btn_search.Click
        getconnection()
        cmd.Connection = con
        If tb_room_no.Enabled = False Then
            tb_room_no.Enabled = False
            btn_add.Enabled = False
        End If
        cmd.CommandText = "select * from  room_data where room_no = " + tb_room_no.Text + ""
        dr = cmd.ExecuteReader
        If dr.Read() Then
            tb_room_id.Text = dr("room_id")
            cmb_room_type.Text = dr("room_type")
            tb_room_total_capacity.Text = dr("total_capacity")
            tb_room_prize.Text = dr("prize")
            tb_desc.Text = dr("romm_desc")
            If dr("room_img").ToString() <> "" Then
                pb_room_images.Image = global_class.view(dr("room_img"))
            Else
                pb_room_images.Image = Infinity.My.Resources.user
            End If

        Else
            MsgBox(" Record not Found", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")

        End If
        con.Close()
        endconnection()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        getconnection()
        cmd.Connection = con
        cmd.CommandText = "delete from room_data where room_no='" + tb_room_no.Text + "'"
        If MsgBox("Do you Really want To delete this record ", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If tb_room_no.Text <> "" And tb_room_id.Text <> "" And cmb_room_type.Text <> "" And tb_room_total_capacity.Text <> "" And tb_room_prize.Text <> "" And tb_desc.Text <> "" And Not pb_room_images.Image Is Nothing Then


                Dim i As Integer = cmd.ExecuteNonQuery

                If (i > 0) Then
                    MessageBox.Show("RECORD Deleted !!!!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    global_class.clearAllmetrobunifuTextbo(pan_rm_room)
                    global_class.clearAllcombo_box(pan_rm_room)
                    tb_room_no.Text = autoincr("select count(room_id) from room_data", 1000)
                    tb_room_id.Text = autoincr("select count(room_no) from room_data", 100)
                    pb_room_images.Image = Nothing
                Else
                    MessageBox.Show("Server Error")
                End If
            Else
                MessageBox.Show("First fill all the field", "caution", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

            End If
        End If
        cmd.Dispose()
    End Sub
    Private Sub isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_room_total_capacity.KeyPress, tb_room_prize.KeyPress, tb_room_no.KeyPress, tb_room_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

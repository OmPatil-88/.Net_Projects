Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class uchome_bill
    Inherits UserControl
    Private Shared _instanse As uchome_bill
    Public pcost As Double
    Public Shared ReadOnly Property Instance() As uchome_bill
        Get
            If _instanse Is Nothing Then
                _instanse = New uchome_bill()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub tb_menu_name_Enter(sender As Object, e As EventArgs) Handles tb_menu_name.Enter
        lb_menu_items.Visible = True
    End Sub
    Private Sub lb_menu_items_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_menu_items.SelectedIndexChanged
        lb_menu_items.Visible = False
        tb_menu_name.Text = lb_menu_items.SelectedItem
    End Sub
    Private Sub tb_menu_name_TextChanged(sender As Object, e As EventArgs) Handles tb_menu_name.TextChanged

        If tb_menu_name.Text <> "" Then
            getconnection()
            cmd = New SqlCommand("select prize from menu_data where menu_name='" + tb_menu_name.Text + "'", con)
            pcost = cmd.ExecuteScalar()

            endconnection()
            tb_cost.Text = pcost
        End If
    End Sub

    Private Sub tb_quanty_TextChanged(sender As Object, e As EventArgs) Handles tb_quanty.TextChanged
        If tb_quanty.Text <> "" Then
            tb_cost.Text = Val(tb_quanty.Text) * pcost
        Else
            tb_cost.Text = pcost
        End If
    End Sub

    Private Sub btn_hm_order_Click(sender As Object, e As EventArgs) Handles btn_hm_order.Click
        getconnection()
        If tb_table_number.Text <> "" And tb_bill_no.Text <> "" And tb_customer_name.Text <> "" And tb_menu_name.Text <> "" Then
            cmd.Dispose()
            cmd = New SqlCommand("select count(menu_name) from temp_Bill_menu where menu_name='" + tb_menu_name.Text + "'", con)
            If cmd.ExecuteScalar() > 0 Then
                cmd.Dispose()
                cmd = New SqlCommand("update temp_Bill_menu set qty= qty + " + tb_quanty.Text + " , all_prize=all_prize +" + tb_cost.Text + " where menu_name='" + tb_menu_name.Text + "'", con)
                cmd.ExecuteNonQuery()
                grid_load("select * from temp_Bill_menu where bill_id=" + tb_bill_no.Text + "", dgv_current_order)
                cmd.Dispose()
                Exit Sub
            End If
            cmd = New SqlCommand("insert into temp_Bill_menu values(" & tb_bill_no.Text & "," & tb_table_number.Text & ",'" & tb_customer_name.Text & "','" & tb_menu_name.Text & "'," & pcost & "," & tb_quanty.Text & "," & tb_cost.Text & ")", con)
            cmd.ExecuteNonQuery()
            grid_load("select * from temp_Bill_menu where bill_id=" + tb_bill_no.Text + "", dgv_current_order)
            tb_menu_name.Text = ""
            tb_quanty.Text = ""
            tb_cost.Text = ""
            global_class.table_restriction = True
            cmd.Dispose()
            con.Open()
            cmd = New SqlCommand("select count(all_prize) from temp_Bill_menu where table_no=" + tb_table_number.Text + "", con)
            If cmd.ExecuteScalar() = 0 Then
                tb_total_cost.Text = 0
            Else
                cmd.Dispose()
                cmd = New SqlCommand("select sum(all_prize) from temp_Bill_menu where table_no=" + tb_table_number.Text + "", con)
                tb_total_cost.Text = cmd.ExecuteScalar()
            End If

        Else
            MsgBox("First Fill All Fild")
        End If
        cmd.Dispose()
        endconnection()
    End Sub

    Private Sub btn_hm_Bill_Click(sender As Object, e As EventArgs) Handles btn_hm_Bill.Click
        getconnection()
        Dim bill_id As Integer = tb_bill_no.Text
        If tb_table_number.Text <> "" Then
            cmd = New SqlCommand("select count(table_no) from temp_Bill_menu where table_no=" & tb_table_number.Text & " ", con)
            If cmd.ExecuteScalar() <> 0 Then
                cmd.Dispose()
                If tb_bill_no.Text <> "" And tb_customer_name.Text <> "" And tb_table_number.Text <> "" And tb_total_cost.Text <> "" And tb_hm_gst.Text <> "" Then
                    Dim final_total As Double
                    final_total = Val(tb_total_cost.Text) * ((100 + Val(tb_hm_gst.Text)) / 100)
                    cmd = New SqlCommand("insert into Final_bill_table values(" + tb_bill_no.Text + ",'" + tb_customer_name.Text + "'," + tb_table_number.Text + "," & final_total & "," + tb_hm_gst.Text + ",'" + Date.Now + "')", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    '************************************************************************************************************************************************************************************************************************************************
                    Dim cnt As Integer
                    cmd = New SqlCommand("select count(bill_id) from temp_Bill_menu where bill_id=" + tb_bill_no.Text + " ", con)
                    cnt = cmd.ExecuteScalar()
                    cmd.Dispose()
                    While cnt > 0
                        Dim sdr As SqlDataReader
                        cmd = New SqlCommand("select * from  temp_Bill_menu where bill_id = " + tb_bill_no.Text + "", con)
                        sdr = cmd.ExecuteReader
                        sdr.Read()
                        cmd.Dispose()

                        Dim val As Double = sdr("menu_prize") * sdr("qty")
                        cmd = New SqlCommand("insert into Final_Bill_menu values(" & sdr("bill_id") & ",'" & sdr("menu_name").ToString & "'," & sdr("menu_prize") & "," & sdr("qty") & "," & val & ")", con)
                        Dim menu As String = sdr("menu_name").ToString
                        sdr.Close()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New SqlCommand("delete from temp_Bill_menu where menu_name ='" + menu + "'", con)
                        cmd.ExecuteNonQuery()
                        cnt = cnt - 1
                    End While
                    pan_table.Controls.Clear()
                    getconnection()
                    Dim x As Integer = 17
                    Dim y As Integer = 24
                    Dim count As Integer = 1
                    cmd = New SqlCommand("select * from table_data", con)
                    Dim d As SqlDataReader
                    d = cmd.ExecuteReader
                    While d.Read()
                        Dim obj = New uc_button
                        obj.Location = New System.Drawing.Point(x, y)
                        obj.lbl_table_name.Text = d("table_number")

                        pan_table.Controls.Add(obj)
                        y = y + 75
                        count = count + 1
                        If count > 4 Then
                            count = 1
                            x = x + 86
                            y = 24
                        End If
                    End While

                    grid_load("select * from Final_bill_table", dgv_biiled_order)
                    dgv_current_order.DataSource = ""
                    '************************************************************report
                    Dim dt As New DataTable
                    Dim addpter As SqlDataAdapter

                    cmd = New SqlCommand("SELECT * from Final_bill_table join Final_Bill_menu on Final_bill_table.bill_no=Final_Bill_menu.bill_no where Final_bill_table.bill_no=" & bill_id & "", con)
                    addpter = New SqlDataAdapter(cmd)
                    addpter.Fill(dt)
                    If dt.Rows.Count <> 0 Then
                        Dim report As New resto_bill_rpt
                        report.DataSource = dt
                        report.DataAdapter = addpter
                        report.DataMember = "Final_bill_table"
                        Dim tool As ReportPrintTool = New ReportPrintTool(report)
                        report.CreateDocument()
                        Resto_bill.Bill_doc.DocumentSource = report
                        Resto_bill.ShowDialog()
                        '.DocumentSource = report
                    Else
                        MessageBox.Show("No Record found!!!!!!!!!!")
                    End If
                    tb_customer_name.Text = ""
                    tb_hm_gst.Text = ""
                    tb_menu_name.Text = ""

                Else
                    MsgBox("First Fill all the Filds")
                End If
            Else
                MsgBox("First Add menu to the List")
            End If
        End If
        endconnection()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        pan_load.Visible = True
        global_class.load_services = False
        pan_load.Controls.Clear()
        pan_load.Controls.Add(uc_home_Extra_services.hotel_Insatnce)
        global_class.clearAllmetrobunifuTextbo(uc_home_Extra_services.hotel_Insatnce)

        uc_home_Extra_services.hotel_Insatnce.panel_main_charge.Location = New System.Drawing.Point(49, 75)
        uc_home_Extra_services.hotel_Insatnce.Label1.Location = New System.Drawing.Point(46, 2)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        pan_load.Visible = False
    End Sub

    Private Sub uchome_bill_Load(sender As Object, e As EventArgs)
        panel_bill.Visible = True
        pan_table.Visible = True
    End Sub
    Private Sub Isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_hm_gst.KeyPress, pan_table.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

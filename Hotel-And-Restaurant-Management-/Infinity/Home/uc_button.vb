Imports System.Data.SqlClient

Public Class uc_button
    Private Sub lbl_table_name_Click(sender As Object, e As EventArgs) Handles lbl_table_name.Click
        If global_class.table_restriction = False Then
            If lbl_table_name.BackColor = Color.Khaki Then
                MsgBox("First Release another Holded table Or Place that order ", MsgBoxStyle.Critical)
                ' global_class.table_restriction = True
                Exit Sub
                'ElseIf lbl_table_name.BackColor = Color.Orange Then
                '    If MsgBox("Do you want to Release this table", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '        global_class.table_restriction = True
                '        lbl_table_name.BackColor = Color.Khaki
                '        Exit Sub
                '    End If
            End If
        End If

            endconnection()
        If lbl_table_name.BackColor = Color.Orange Then
            getconnection()
            cmd = New SqlCommand("select * from temp_Bill_menu where table_no=" + lbl_table_name.Text + "", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                uchome_bill.Instance.tb_table_number.Text = dr("table_no")
                uchome_bill.Instance.tb_bill_no.Text = dr("bill_id")
                uchome_bill.Instance.tb_customer_name.Text = dr("customer_name")
            End If
            dr.Close()
            cmd.Dispose()
            cmd = New SqlCommand("select count(all_prize) from temp_Bill_menu where table_no=" + lbl_table_name.Text + "", con)
            If cmd.ExecuteScalar() = 0 Then
                uchome_bill.Instance.tb_total_cost.Text = 0
            Else
                cmd.Dispose()
                cmd = New SqlCommand("select sum(all_prize) from temp_Bill_menu where table_no=" + lbl_table_name.Text + "", con)
                uchome_bill.Instance.tb_total_cost.Text = cmd.ExecuteScalar()
            End If
            grid_load("select * from temp_Bill_menu where table_no=" + lbl_table_name.Text + "", uchome_bill.Instance.dgv_current_order)
            endconnection()
            'lbl_table_name.BackColor = Color.Khaki
        Else
            For Each item As Control In uchome_bill.Instance.panel_bill.Controls
                If item.GetType Is GetType(TextBox) Then
                    item.Text = ""
                End If
                lbl_table_name.BackColor = Color.Orange
                uchome_bill.Instance.tb_table_number.Text = lbl_table_name.Text
                global_class.table_restriction = False
                '*****************************************************************************************************************************************
                cmd.Dispose()
                getconnection()

                cmd = New SqlCommand("select count(bill_id) from temp_Bill_menu", con)
                If cmd.ExecuteScalar() = 0 Then
                    uchome_bill.Instance.tb_bill_no.Text = autoincr("select count(bill_no) from Final_bill_table", 1)
                Else
                    cmd.Dispose()
                    cmd = New SqlCommand("select max(bill_id) from temp_Bill_menu", con)
                    If IsDBNull(cmd.ExecuteScalar) Then
                        uchome_bill.Instance.tb_bill_no.Text = 1000
                    Else
                        uchome_bill.Instance.tb_bill_no.Text = cmd.ExecuteScalar + 1
                        cmd.Dispose()
                    End If
                End If
                uchome_bill.Instance.dgv_current_order.DataSource = ""
                cmd.Dispose()
                endconnection()
            Next
        End If
    End Sub

    Private Sub uc_button_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getconnection()
        cmd = New SqlCommand("select count(table_no) from temp_Bill_menu where table_no=" + lbl_table_name.Text + "", con)
        If cmd.ExecuteScalar() <> 0 Then
            lbl_table_name.BackColor = Color.Orange
        End If
        cmd.Dispose()
        endconnection()
    End Sub
End Class

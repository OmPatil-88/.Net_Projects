Imports System.Data.SqlClient

Public Class ucr_main
    Inherits UserControl
    Private Shared _instanse As ucr_main

    Public Shared ReadOnly Property Instance() As ucr_main
        Get
            If _instanse Is Nothing Then
                _instanse = New ucr_main()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_kitchen_Click(sender As Object, e As EventArgs) Handles btn_kitchen.Click
        If Not main_menu.main_panel.Controls.Contains(ucr_kitchen.Instance) Then
            main_menu.main_panel.Controls.Add(ucr_kitchen.Instance)
            ucr_kitchen.Instance.Dock = DockStyle.Fill
            ucr_kitchen.Instance.BringToFront()
            ucr_kitchen.Instance.Visible = True
        End If
        ucr_kitchen.Instance.BringToFront()
        ucr_kitchen.Instance.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
#Region "display"
        If Not main_menu.main_panel.Controls.Contains(ucr_stock.Instance) Then
            main_menu.main_panel.Controls.Add(ucr_stock.Instance)
            ucr_stock.Instance.Dock = DockStyle.Fill
            ucr_stock.Instance.BringToFront()
            ucr_stock.Instance.Visible = True
        End If
        ucr_stock.Instance.BringToFront()
        ucr_stock.Instance.Visible = True
#End Region
#Region "activate stock"
        Dim cnt As Integer = 0
        ucr_stock.Instance.tb_stock_bill_id.Text = autoincr("select count(stock_bill_id) from restarunt_stock", 100)
        '*********************************************************************************************************************
        grid_load("select * from restarunt_stock", ucr_stock.Instance.dg_sm_view)
        '*********************************************************************************************************************'
        getconnection()
        Dim delear As String = "delear"
        cmd = New SqlCommand("select d_name,d_surname,d_id from delar_data ", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        ucr_stock.Instance.cmb_import.Items.Clear()
        While dr.Read()
            ucr_stock.Instance.cmb_import.Items.Add(dr("d_name") + " " + dr("d_surname").ToString)
            global_class.d_id_arr(cnt) = dr("d_id")
            cnt = cnt + 1
        End While
        dr.Close()
        cmd.Dispose()
        '*************************************************************************************************************************
        cmd = New SqlCommand("select DISTINCT stock_name from restarunt_stock ", con)
        Dim d As SqlDataReader
        d = cmd.ExecuteReader()
        ucr_stock.Instance.cmb_stock_type.Items.Clear()
        While d.Read()
            ucr_stock.Instance.cmb_stock_type.Items.Add(d("stock_name").ToString)
        End While
        dr.Close()
        cmd.Dispose()
        endconnection()
#End Region

    End Sub

    Private Sub btn_delear_detail_Click(sender As Object, e As EventArgs) Handles btn_delear_detail.Click
#Region "display"
        If Not main_menu.main_panel.Controls.Contains(ucr_delear_datail.Instance) Then
            main_menu.main_panel.Controls.Add(ucr_delear_datail.Instance)
            ucr_delear_datail.Instance.Dock = DockStyle.Fill
            ucr_delear_datail.Instance.BringToFront()
            ucr_delear_datail.Instance.Visible = True
        End If
        ucr_delear_datail.Instance.BringToFront()
        ucr_delear_datail.Instance.Visible = True
#End Region
#Region "activate delear"
        ucr_delear_datail.Instance.tb_dm_delear_id.Text = autoincr("select count(d_id) from delar_data", 100)
        grid_load("select * from delar_data", ucr_delear_datail.Instance.dg_dm_view_all)
        getconnection()
        cmd = New SqlCommand("select DISTINCT stock_name from restarunt_stock", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        ucr_delear_datail.Instance.cmb_dm_stock_type.Items.Clear()
        While dr.Read()
            ucr_delear_datail.Instance.cmb_dm_stock_type.Items.Add(dr("stock_name").ToString)
        End While
        dr.Close()
        cmd.Dispose()
        endconnection()
#End Region
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
#Region "dispaly"
        If Not main_menu.main_panel.Controls.Contains(ucr_menu.Instance) Then
            main_menu.main_panel.Controls.Add(ucr_menu.Instance)
            ucr_menu.Instance.Dock = DockStyle.Fill
            ucr_menu.Instance.BringToFront()
            ucr_menu.Instance.Visible = True
        End If
        ucr_menu.Instance.BringToFront()
        ucr_menu.Instance.Visible = True
        endconnection()
#End Region
#Region "activated menu ucr"
        getconnection()
        Dim Chef As String = "Chef"
        cmd = New SqlCommand("select e_name,e_surname from emplyee_detail where e_type='" + Chef + "' ", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        ucr_menu.Instance.cmb_chef_name.Items.Clear()
        While dr.Read()
            ucr_menu.Instance.cmb_chef_name.Items.Add(dr("e_name") + " " + dr("e_surname").ToString)
        End While
        dr.Close()
        cmd.Dispose()
#End Region
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not main_menu.main_panel.Controls.Contains(ucr_tbl.Instance) Then
            main_menu.main_panel.Controls.Add(ucr_tbl.Instance)
            ucr_tbl.Instance.Dock = DockStyle.Fill
            ucr_tbl.Instance.BringToFront()
            ucr_tbl.Instance.Visible = True
        End If
        ucr_tbl.Instance.BringToFront()
        ucr_tbl.Instance.Visible = True
    End Sub
End Class

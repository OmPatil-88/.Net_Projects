Imports System.Data.SqlClient

Public Class uc_home_Extra_services
    Inherits UserControl
    Private Shared _instanse, hotel_instance As uc_home_Extra_services
    Public Shared ReadOnly Property Instance() As uc_home_Extra_services
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_home_Extra_services()
            End If
            Return _instanse
        End Get
    End Property
    Public Shared ReadOnly Property hotel_Insatnce() As uc_home_Extra_services
        Get
            If hotel_instance Is Nothing Then
                hotel_instance = New uc_home_Extra_services()
            End If
            Return hotel_instance
        End Get
    End Property


    Private Sub tb_ec_service_id_OnValueChanged(sender As Object, e As EventArgs) Handles tb_ec_service_id.OnValueChanged
        If tb_ec_service_id.Text <> "" Then
            getconnection()
            Dim dr As SqlDataReader
            cmd = New SqlCommand("select s_name,prize from service_data where s_id=" + tb_ec_service_id.Text + " ", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                tb_ec_services_name.Text = dr("s_name")
                tb_em_cost.Text = dr("prize")
            Else
                tb_ec_services_name.Text = ""
                tb_em_cost.Text = ""
            End If
            cmd.Dispose()
            dr.Close()
            endconnection()
        Else
            If tb_ec_services_name.Text <> "" Or tb_em_cost.Text <> "" Then
                tb_ec_services_name.Text = ""
                tb_em_cost.Text = ""
            End If
        End If
    End Sub

    Private Sub Isnumaric(sender As Object, e As KeyPressEventArgs) Handles tb_ec_check_in_id.KeyPress, tb_ec_service_id.KeyPress
        If ((e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub

    Private Sub btn_update_all_menu_data_Click(sender As Object, e As EventArgs) Handles btn_update_all_menu_data.Click
        getconnection()
        Try
            If tb_ec_check_in_id.Text <> "" Then
                cmd = New SqlCommand("select Check_id from check_in_check_out where Check_id=" + tb_ec_check_in_id.Text + "", con)
                If cmd.ExecuteScalar() <> 0 Then
                    cmd.Dispose()
                    If tb_ec_service_id.Text <> "" Then
                        cmd = New SqlCommand("insert into Guest_Extra_services values(" + tb_ec_check_in_id.Text + "," + tb_ec_service_id.Text + ",'" + tb_ec_services_name.Text + "'," + tb_em_cost.Text + ")", con)
                        If cmd.ExecuteNonQuery() Then
                            MsgBox("Services add to ID")
                            tb_ec_service_id.Text = ""
                        Else
                            MsgBox("Server Error")
                        End If
                    Else
                        MsgBox("Fill the Services ID")
                    End If
                Else
                    MsgBox("No such Check In ID")
                End If
            Else
                MsgBox("First Fil the Check In ID")
            End If
        Catch
        End Try
        endconnection()
    End Sub
End Class

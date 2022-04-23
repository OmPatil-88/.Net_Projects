
Imports System.IO

Public Class global_class
    Public Shared load_services As Byte = True
    Public Shared table_restriction As Byte = True
    Public Shared n As Integer = 0
    Public Shared hold_pkg_services(100) As Integer
    Public Shared hold_services_type(100) As String
    Public Shared hold_pkg_service_prize(100) As Double
    Public Shared d_id_arr(100) As Integer
    Public Shared temp As Byte = Nothing
    Public Shared time_var As Integer = 0

    Public Shared user_statues As String 'main_menu
    Public Shared user_name As String 'main_menu
    Public Shared user_image As Byte()  'main_menu
    Public Shared Sub side_moving(ByRef pan_moving As Panel, ByRef btn_common As Button)
        pan_moving.Height = btn_common.Height
        pan_moving.Top = btn_common.Top
    End Sub
    Public Shared Sub browse(ByRef search As Image)
        obj.Filter = "choose Images(*.JPG;*.PNG;*GIF)|*.jpg;*.png;*.gif"
        If obj.ShowDialog = DialogResult.OK Then
            search = Image.FromFile(obj.FileName)
        End If
    End Sub
    Public Shared Function view(ByVal imag As Byte())
        Using ms As New MemoryStream(imag)
            Return Image.FromStream(ms)
        End Using
    End Function

    Public Shared Sub clearAllCombo(ByVal objcbo As Object)
        For Each cbo As Control In objcbo.controls
            If cbo.GetType Is GetType(ComboBox) Then
                cbo.Text = ""
            End If
        Next
    End Sub

    Public Shared Sub clearAllbunifuTextbo(ByVal objtxt As Object)
        For Each cbo As Control In objtxt.controls
            If cbo.GetType Is GetType(Bunifu.Framework.UI.BunifuMaterialTextbox) Then
                cbo.Text = ""
            End If
        Next
    End Sub
    Public Shared Sub clearAllmetrobunifuTextbo(ByVal objtxt As Object)
        For Each cbo As Control In objtxt.controls
            If cbo.GetType Is GetType(Bunifu.Framework.UI.BunifuMetroTextbox) Then
                cbo.Text = ""
            End If
        Next
    End Sub

    Public Shared Sub clearAlldatetimepicker(ByVal objtxt As Object)
        For Each cbo As Control In objtxt.controls
            If cbo.GetType Is GetType(DateTimePicker) Then
                cbo.Text = ""
            End If
        Next
    End Sub
    Public Shared Sub clearAllcombo_box(ByVal objtxt As Object)
        For Each cbo As Control In objtxt.controls
            If cbo.GetType Is GetType(ComboBox) Then
                cbo.Text = ""
            End If
        Next
    End Sub
End Class

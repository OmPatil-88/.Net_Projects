Public Class uc_admin_other
    Inherits UserControl
    Private Shared _instanse As uc_admin_other
    Public Shared ReadOnly Property Instance() As uc_admin_other
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_admin_other()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class

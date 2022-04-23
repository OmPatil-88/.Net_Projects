Public Class CALForm1
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If cal.Text = "0" Then
            cal.Text = "1"
        Else
            cal.Text &= "1"
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If cal.Text = "0" Then
            cal.Text = "2"
        Else
            cal.Text &= "2"
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If cal.Text = "0" Then
            cal.Text = "3"
        Else
            cal.Text &= "3"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cal.Text = "0" Then
            cal.Text = "4"
        Else
            cal.Text &= "4"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If cal.Text = "0" Then
            cal.Text = "5"
        Else
            cal.Text &= "5"
        End If
    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If cal.Text = "0" Then
            cal.Text = "6"
        Else
            cal.Text &= "6"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cal.Text = "0" Then
            cal.Text = "7"
        Else
            cal.Text &= "7"
        End If
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If cal.Text = "0" Then
            cal.Text = "8"
        Else
            cal.Text &= "8"
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If cal.Text = "0" Then
            cal.Text = "9"
        Else
            cal.Text &= "9"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If cal.Text = "0" Then
            cal.Text = "0"
        Else
            cal.Text &= "0"
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        'cal.Text = ""
        cal.Text = 0
    End Sub
    Private Sub opration(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plus.Click, subs.Click, mul.Click, div.Click, dot.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "plus" Then
            cal.Text = cal.Text + "+"
        End If
        If button.Name = "subs" Then
            cal.Text = cal.Text + "-"
        End If
        If button.Name = "mul" Then
            cal.Text = cal.Text + "*"
        End If
        If button.Name = "div" Then
            cal.Text = cal.Text + "/"
        End If
        If button.Name = "dot" Then
            cal.Text = cal.Text + "."
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim var As String = cal.Text
        Dim res = New DataTable().Compute(var, Nothing)
        cal.Text = res
    End Sub

    Private Sub cal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal.TextChanged

    End Sub
End Class

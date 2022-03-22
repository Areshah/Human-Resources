Public Class Frm_Admin_Login

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If txtUserName.Text.Equals("osama") AndAlso txtPassword.Text.Equals("maverick") Then
            Frm_Main.btnLogout.Visible = True
            Frm_Main.flag2 = 1
            Me.Close()
        Else
            MsgBox("Must Enter A Valid Login Details")
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress

        If (Asc(e.KeyChar) = 13) Then
            btnOk_Click(sender, e)
        End If

    End Sub
End Class

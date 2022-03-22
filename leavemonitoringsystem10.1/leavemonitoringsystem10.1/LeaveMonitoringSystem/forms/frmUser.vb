Public Class frmUser
    Private Sub chkShowpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowpass.CheckedChanged
        Try
            If chkShowpass.CheckState = CheckState.Checked Then
                txtpass.UseSystemPasswordChar = False
            Else
                txtpass.UseSystemPasswordChar = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            sql = "SELECT user_id as Id,name as Name,username as Username, type as Type FROM  tbluser  "
            reloadDtg(sql, dtglist)

            cleartext(Me)
            loadautonumber("user", txtId)

            txtId.Enabled = False

        Catch ex As Exception
            Me.Text = ex.Message
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            For Each ctrl As Control In Me.Controls
                If ctrl.GetType Is GetType(TextBox) Then
                    If ctrl.Text = "" Then
                        MsgBox("One of the box is empty. It needed to be filled up.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If
                If ctrl.GetType Is GetType(ComboBox) Then
                    If ctrl.Text = "----Select-----" Then
                        MsgBox("You have to set the correct information.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If
            Next
            If txtpass.Text <> txtrpass.Text Then
                MsgBox("Password does not match.", MsgBoxStyle.Exclamation)
                Return
            End If


            sql = "SELECT * FROM tbluser WHERE user_id='" & txtId.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                sql = "UPDATE tbluser SET name='" & txtname.Text & "' ,username='" & txtusername.Text & "',pass=sha1('" & txtpass.Text & "'),type='" & cboType.Text & "'  WHERE user_id ='" & txtId.Text & "'"
                updates(sql, txtname.Text)
            Else
                sql = "INSERT INTO tbluser (user_id,name,username,pass,type)" &
             " VALUES (" & txtId.Text & ",'" & txtname.Text & "','" & txtusername.Text & "',sha1('" & txtpass.Text & "'),'" & cboType.Text & "')"
                create(sql, txtname.Text)
                updateautonumber("user")
            End If


            cleartext(Me)
            loadautonumber("user", txtId)
            sql = "SELECT user_id as Id,name as Name,username as Username, type as Type FROM  tbluser  "
            reloadDtg(sql, dtglist)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            txtId.Text = dtglist.CurrentRow.Cells(0).Value
            sql = "SELECT * FROM tbluser WHERE user_id ='" & txtId.Text & "'"
            reloadtxt(sql)

            With dt.Rows(0)
                txtname.Text = .Item("name")
                txtusername.Text = .Item("username")
                'txtpass.Text = .Item("pass")
                'cboType.Text = .Item("type")
                cboType.Text = .Item("type")
            End With
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            sql = "DELETE FROM tbluser WHERE user_id ='" & dtglist.CurrentRow.Cells(0).Value & "'"
            deletes(sql, dtglist.CurrentRow.Cells(2).Value)

            sql = "SELECT user_id as Id,name as Name,username as Username, type as Type FROM  tbluser  "
            reloadDtg(sql, dtglist)

            cleartext(Me)
            loadautonumber("user", txtId)
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
    End Sub
End Class

Public Class frmSetting
    Dim positionID As Integer = 0
    Dim departmentid As Integer = 0
    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "SELECT ID,`DESCRIPTION` as Position FROM `tblsettings` WHERE `FORTHE`='Position'"
            reloadDtg(sql, dtglistposition)
            txtposition.Clear()
            dtglistposition.Columns(0).Visible = False

            sql = "SELECT ID,`DEPARTMENT` FROM `tbldepartment` "
            reloadDtg(sql, dtgdeptlist)
            txtdepartment.Clear()
            dtgdeptlist.Columns(0).Visible = False

            btn_delete_dept.Enabled = False
            btn_Delete_Position.Enabled = False
            btn_update_dept.Enabled = False
            btn_update_Position.Enabled = False
            btn_save_dept.Enabled = True
            btn_save_Position.Enabled = True

            dtgdeptlist.DefaultCellStyle.Font = New Font("arial", 8)
            dtglistposition.DefaultCellStyle.Font = New Font("arial", 8)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_save_Position_Click(sender As Object, e As EventArgs) Handles btn_save_Position.Click
        Try
            sql = "INSERT INTO `tblsettings` (`DESCRIPTION`, `FORTHE`) VALUES ('" & txtposition.Text & "','Position')"
            create(sql, "New Position")
            Call frmSetting_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_update_Position_Click(sender As Object, e As EventArgs) Handles btn_update_Position.Click
        sql = "UPDATE `tblsettings` SET `DESCRIPTION`='" & txtposition.Text & "' WHERE  `ID`=" & positionID
        updates(sql, "Position")
        Call frmSetting_Load(sender, e)
    End Sub

    Private Sub btn_Delete_Position_Click(sender As Object, e As EventArgs) Handles btn_Delete_Position.Click
        sql = "DELETE FROM `tblsettings` WHERE `ID`=" & dtglistposition.CurrentRow.Cells(0).Value
        deletes(sql, "Position")
        Call frmSetting_Load(sender, e)
    End Sub

    Private Sub btn_save_dept_Click(sender As Object, e As EventArgs) Handles btn_save_dept.Click
        sql = "INSERT INTO `tbldepartment` (`DEPARTMENT`) VALUES ('" & txtdepartment.Text & "')"
        create(sql, "New Department")
        Call frmSetting_Load(sender, e)
    End Sub

    Private Sub btn_update_dept_Click(sender As Object, e As EventArgs) Handles btn_update_dept.Click
        sql = "UPDATE `tbldepartment`  SET `DEPARTMENT`='" & txtdepartment.Text & "' WHERE `ID`=" & departmentid
        updates(sql, "Department")
        Call frmSetting_Load(sender, e)
    End Sub

    Private Sub btn_delete_dept_Click(sender As Object, e As EventArgs) Handles btn_delete_dept.Click
        sql = "DELETE FROM `tbldepartment` WHERE `ID`='" & dtgdeptlist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, dtgdeptlist.CurrentRow.Cells(1).Value)
        Call frmSetting_Load(sender, e)
    End Sub

    Private Sub dtgdeptlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgdeptlist.CellClick
        Try
            departmentid = dtgdeptlist.CurrentRow.Cells(0).Value
            txtdepartment.Text = dtgdeptlist.CurrentRow.Cells(1).Value

            btn_delete_dept.Enabled = True
            btn_update_dept.Enabled = True
            btn_save_dept.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtglistposition_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglistposition.CellClick
        Try
            positionID = dtglistposition.CurrentRow.Cells(0).Value
            txtposition.Text = dtglistposition.CurrentRow.Cells(1).Value


            btn_Delete_Position.Enabled = True
            btn_update_Position.Enabled = True
            btn_save_Position.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

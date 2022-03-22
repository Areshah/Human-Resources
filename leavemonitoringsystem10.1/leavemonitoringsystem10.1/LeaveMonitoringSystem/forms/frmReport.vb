Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `EMPID` as 'Employee Id' , concat(`emp_fname`, ' ',`emp_lname`) as 'Name' FROM `employee`  "
        reloadDtg(sql, dtglist)
        field = "EMPID"
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

        sql = "SELECT `EMPID` as 'Employee Id' , concat(`emp_fname`, ' ',`emp_lname`) as 'Name' FROM `employee` WHERE  " & field & " LIKE '%" & txtsearch.Text & "%' "
        reloadDtg(sql, dtglist)

    End Sub
    Dim field As String = ""

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.Text = "Id" Then
            field = "EMPID"
        ElseIf cboCategory.Text = "First Name" Then
            field = "emp_fname"
        ElseIf cboCategory.Text = "Last Name" Then
            field = "emp_lname"
        End If
    End Sub

    Private Sub btnPrintAll_Click(sender As Object, e As EventArgs) Handles btnPrintAll.Click
        sql = "SELECT  e.`EMPID`, concat( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) as 'Name' ,`emp_sex`,(`d_rate` * 14) as 'TwooWeeksSalary', `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` we  WHERE e.`EMPID`=we.`EMPID`"
        reports(sql, "allemployees", CrystalReportViewer1)
    End Sub

    Private Sub btnPrintEmp_Click(sender As Object, e As EventArgs) Handles btnPrintEmp.Click
        sql = "SELECT  e.`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`,`address`, `contact`, `status`, `emp_sex`, round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age',`d_rate`, `position`, `d_hired`,(`d_rate` * 15) as 'Salary', `DEPARTMENT`, `REMAININGLEAVE`, `DEFAULTLEAVE`  ,w_type" &
            " FROM  `employee` e,  `employee_workinfo` w " &
            " WHERE e.EMPID = w.EMPID AND e.EMPID='" & dtglist.CurrentRow.Cells(0).Value & "'"
        reports(sql, "selectedemployee", CrystalReportViewer1)
    End Sub

    Private Sub dtglist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellClick

    End Sub
End Class

Public Class frmFindEmployee
    Private Sub frmFindEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `EMPID` AS 'Employee Id',`emp_fname` as 'First Name', `emp_lname` as 'Last Name',`emp_mname` AS 'Middle Name'" _
       & ",round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age', `emp_sex` AS 'Gender', `status` AS 'Status', `address` AS 'Address', `contact` AS 'Contact Number'  FROM `employee`"
        reloadDtg(sql, dtgemplist)
    End Sub

    Private Sub txtempsearch_TextChanged(sender As Object, e As EventArgs) Handles txtempsearch.TextChanged
        sql = "SELECT `EMPID` AS 'Employee Id',`emp_fname` as 'First Name', `emp_lname` as 'Last Name',`emp_mname` AS 'Middle Name'" _
     & ", round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age', `emp_sex` AS 'Gender', `status` AS 'Status', `address` AS 'ADDRESS'" _
     & ", `contact` AS 'CONTACT'  FROM `employee` WHERE `EMPID` LIKE '%" & txtempsearch.Text & "%'" _
     & " OR emp_fname LIKE '%" & txtempsearch.Text & "%' OR emp_lname LIKE '%" & txtempsearch.Text & "%'"
        reloadDtg(sql, dtgemplist)
    End Sub

    Private Sub btnPrintAll_Click(sender As Object, e As EventArgs) 
        sql = "SELECT  e.`EMPID`, concat( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) as 'Name' ,`emp_sex`,(`d_rate` * 14) as 'TwooWeeksSalary', `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` we  WHERE e.`EMPID`=we.`EMPID`"
        reports(sql, "allemployees", frmprint_emp.CrystalReportViewer1)
        frmprint_emp.ShowDialog()
    End Sub

    Private Sub btnPrintEmp_Click(sender As Object, e As EventArgs) 
        sql = "SELECT  e.`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`,`address`, `contact`, `status`, `emp_sex`, round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age',`d_rate`, `position`, `d_hired`,(`d_rate` * 15) as 'Salary', `DEPARTMENT`, `REMAININGLEAVE`, `DEFAULTLEAVE`  ,w_type" &
            " FROM  `employee` e,  `employee_workinfo` w " &
            " WHERE e.EMPID = w.EMPID AND e.EMPID='" & dtgemplist.CurrentRow.Cells(0).Value & "'"
        reports(sql, "selectedemployee", frmprint_emp.CrystalReportViewer1)
        frmprint_emp.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Form1.addContent(Form1.FrmEmployee1)
            Form1.FrmEmployee1.emptitle.Text = "Update Employee"
            Form1.FrmEmployee1.txtcode.Text = dtgemplist.CurrentRow.Cells(0).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sql = "DELETE FROM employee WHERE EMPID = '" & dtgemplist.CurrentRow.Cells(0).Value & "'"
        createNoMsg(sql)
        sql = "DELETE FROM employee_workinfo WHERE EMPID = '" & dtgemplist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, dtgemplist.CurrentRow.Cells(1).Value)

        sql = "SELECT `EMPID` AS 'Employee Id',`emp_fname` as 'First Name', `emp_lname` as 'Last Name',`emp_mname` AS 'Middle Name'" _
        & ",round( ((DATEDIFF( NOW( ) ,  `birth_date` ) /12) /31))  AS 'Age', `emp_sex` AS 'Gender', `status` AS 'Status', `address` AS 'Address', `contact` AS 'Contact Number'  FROM `employee`"
        reloadDtg(sql, dtgemplist)
    End Sub
End Class

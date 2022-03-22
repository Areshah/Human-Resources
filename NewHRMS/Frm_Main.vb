Public Class Frm_Main

    Public Shared flag = 0
    Public Shared flag2 = 0
    Public Shared flag3 = 0

    Private Sub Frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnLogout.Visible = False
        Panel4.Visible = False
        Timer1.Start()
    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        Frm_Employee.Show()
    End Sub

    Private Sub btnDeptt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeptt.Click
        Frm_Department.Show()
    End Sub

    Private Sub btnPerformance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerformance.Click

        If (flag = 0) Then

            Frm_Employee_Performance.Show()

        ElseIf (flag = 1) Then

            Frm_PerformanceAll.Show()

        End If

    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        If (flag2 = 0) Then

            Me.Close()

        ElseIf (flag2 = 1) Then

            Me.Close()
            Frm_Login.Show()

        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Frm_Department.Show()
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        Frm_Employee.Show()
    End Sub

    Private Sub btnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculator.Click
        Frm_Calculator.Show()
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        Frm_Admin_Login.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Frm_Search.Show()
    End Sub

    Private Sub btnNews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNews.Click

        If (flag3 = 0) Then

            loadNews()

            Panel4.Visible = True

        ElseIf (flag3 = 1) Then

            Frm_News.Show()

        End If

    End Sub

    Private Sub AllEmployeePerformanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllEmployeePerformanceToolStripMenuItem.Click
        Frm_PerformanceAll.Show()
    End Sub

    Private Sub AddNewsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewsToolStripMenuItem.Click
        Frm_News.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Frm_About.Show()
    End Sub

    Private Sub loadNews()

        Dim news As String = String.Empty

        Dim query = "Select news_title, news_description From News"
        
        Dim dr As SqlClient.SqlDataReader = getDataReader(query)

        While dr.Read AndAlso dr.HasRows
            news &= "-> " & dr("news_description").ToString()
        End While

        Label1.Text = news
        Label1.BackColor = Color.SkyBlue
        Label1.AutoSize = True
        Label1.Left = Panel1.Width
        Timer1.Interval = 25

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left -= 1        
        If Label1.Left + Label1.Width < 0 Then
            Label1.Left = Panel1.Width
        End If
    End Sub



    Private Sub AddLeaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddLeaveToolStripMenuItem1.Click
        frmAddLeave.Show()
    End Sub

    Private Sub AddAdvanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAdvanceToolStripMenuItem.Click
        frmAdvance.Show()
    End Sub

    Private Sub AdvancEEntryRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancEEntryRecordToolStripMenuItem.Click
        frmAdvanceEntryRecord.Show()
    End Sub

    Private Sub AdvanceDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvanceDetailsToolStripMenuItem.Click
        frmHistory.Show()
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        frm_Payroll.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        frmReports.Show()
    End Sub

    Private Sub AdvanceEntryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvanceEntryReportToolStripMenuItem.Click
        frmAdvanceEntryReport.Show()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click
        frmAttendance.Show()
    End Sub

    Private Sub AttendanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceReportToolStripMenuItem.Click
        frmAttendanceReport.Show()
    End Sub

    Private Sub DeductionEntryRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeductionEntryRecordToolStripMenuItem.Click
        frmDeductionEntryRecord.Show()
    End Sub

    Private Sub TtendanceRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TtendanceRecordToolStripMenuItem.Click
        frmEmployeeAttendanceRecord.Show()
    End Sub
End Class
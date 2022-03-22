﻿Public Class frmAddLeave
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        With frmviewEmployee
            .ShowDialog()
        End With
    End Sub

    Private Sub txtEmployeeId_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeId.TextChanged
        Try

            sql = "SELECT `d_rate`, `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` ew WHERE e.`EMPID`=ew.`EMPID` AND e.`EMPID`='" & txtEmployeeId.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    txtposition.Text = .Item("position")
                    txtsalary.Text = .Item("d_rate")
                    txtdepartment.Text = .Item("DEPARTMENT")
                End With
                sql = "SELECT * FROM `employee_workinfo` WHERE `EMPID` ='" & txtemid.Text & "'"
                reloadtxt(sql)

                If dt.Rows(0).Item("w_type") = "Regular" Then
                    rdowithPay.Enabled = True
                Else
                    rdowithPay.Enabled = False
                End If

            Else
                txtEmployeeId.Clear()
                txtposition.Clear()
                txtsalary.Clear()
                txtdepartment.Clear()
            End If

        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            'For Each grp As Control In Me.Controls
            '    If TypeOf grp Is GroupBox Then
            '        For Each ctrl As Control In grp.Controls
            '            If TypeOf ctrl Is TextBox Then
            '                If ctrl.Text = "" Then
            '                    MessageBox.Show("Please put information in " & ctrl.Tag, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '                    Exit Sub
            '                End If
            '            End If
            '            If TypeOf ctrl Is RichTextBox Then
            '                If ctrl.Text = "" Then
            '                    MessageBox.Show("Please put information in " & ctrl.Tag, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '                    Exit Sub
            '                End If
            '            End If

            '        Next
            '    End If
            'Next
            If rdoAcidentOnDuty.Checked = False And rdoPaternity.Checked = False And rdoMaternity.Checked = False _
             And rdoVacation.Checked = False And rdoFuneral.Checked = False And rdoSick.Checked = False Then
                MessageBox.Show("Please choose your leave applied for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ''----------------------------------
            Dim rdoleaveformat As String = ""
            Dim rdoleaveapplied As String = ""

            If rdoWithoutPay.Checked = True Then
                rdoleaveformat = "Without Pay"
            ElseIf rdowithPay.Checked = True Then
                rdoleaveformat = "With Pay"
            End If

            ' --------------------------
            If rdoSick.Checked = True Then
                rdoleaveapplied = "Sick"
            ElseIf rdoVacation.Checked = True Then
                rdoleaveapplied = "Vacation"
            ElseIf rdoFuneral.Checked = True Then
                rdoleaveapplied = "Funeral"
            ElseIf rdoPaternity.Checked = True Then
                rdoleaveapplied = "Paternity"
            ElseIf rdoMaternity.Checked = True Then
                rdoleaveapplied = "Maternity"
            ElseIf rdoAcidentOnDuty.Checked = True Then
                rdoleaveapplied = "AccidentOnDuty"
            End If
            ''----------------------------------------------------
            Dim day As Double
            Dim numdays As Integer
            Dim numtime As Integer
            numtime = DateDiff(DateInterval.Hour, dtpTimeFrom.Value, dtpTimeTo.Value)
            ' MsgBox(numtime)
            numdays = DateDiff(DateInterval.Day, dtpdatestart.Value, dtpenddate.Value)
            'MsgBox(numdays)
            If numdays = 0 Then
                If numtime >= 0 Then
                    day = 0.5
                ElseIf numtime = 12 Then
                    day = 1
                End If
            Else
                day = numdays
            End If

            MsgBox(day)

            ''------------------------------------------
            sql = "INSERT INTO `leave` (`EMPID`,`LEAVECODE`,`LEAVEFORMAT`, `LEAVEAPPLIED`, `DATEFROM`, `DATETO`,`LEAVEDATE`,`LEAVEENDDATE`, `NODAYS`, `REASON`,  `DAYOFFSCHEDULE`,`REMARKS`,`APPLIED`,`STATUS`) " _
            & "VALUES ('" & txtEmployeeId.Text & "','" & lblcode.Text & "','" & rdoleaveformat & "','" & rdoleaveapplied & "','" & Format(dtpTimeFrom.Value, "yyyy-MM-dd hh:mm:ss tt") &
            "','" & Format(dtpTimeTo.Value, "yyyy-MM-dd hh:mm:ss tt") & "','" & Format(dtpdatestart.Value, "yyyy-MM-dd hh:mm:ss tt") & "','" & Format(dtpenddate.Value, "yyyy-MM-dd hh:mm:ss tt") & "'," & day &
            ",'" & txtreasons.Text & "','" & Format(dtpNotfallWeekened.Value, "yyyy-MM-dd hh:mm:ss tt") & "','Approved',1,'Approved')"
            create(sql, "New Leave")


            ''------------------------------------------
            sql = "UPDATE `employee` set `ONLEAVE`=1 ,`REMAININGLEAVE` =`REMAININGLEAVE`- " & day & " WHERE `EMPID`='" & txtEmployeeId.Text & "'"
            createNoMsg(sql)
            '-----------------------------------------
            updateautonumber("applicationcode")
            Call btn_new_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        cleartext(GroupBox1)
        cleartext(GroupBox2)
        cleartext(GroupBox3)
        cleartext(GroupBox4)
        cleartext(GroupBox5)
        cleartext(Me)

        'For Each rdo As Control In GroupBox2.Controls
        '    If TypeOf rdo Is RadioButton Then
        '        rdo.Enabled = False
        '    End If
        '    If TypeOf rdo Is RadioButton Then
        '        TryCast(rdo, RadioButton).Checked = False
        '    End If
        'Next


        'rdoWithoutPay.Checked = False
        'rdowithPay.Checked = False

        sql = "SELECT  e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' ,DATE(`LEAVEDATE`) as 'Start of Date Leave', DATE(LEAVEENDDATE) as 'End of Date Leave',`NODAYS` as 'No. Days', `REASON` as 'Reasons'  FROM `employee` e,`leave` l  WHERE  e.`EMPID`=l.`EMPID`"
        reloadDtg(sql, dtgapprovedlist)
    End Sub

    Private Sub dtpenddate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpenddate.ValueChanged, dtpdatestart.ValueChanged
        Try

            txtnoDays.Text = DateDiff(DateInterval.Day, dtpdatestart.Value, dtpenddate.Value)

            Dim numdays As Integer

            numdays = DateDiff(DateInterval.Day, dtpdatestart.Value, dtpenddate.Value)

            If numdays > 0 Then
                dtpTimeFrom.Enabled = False
                dtpTimeTo.Enabled = False
            Else
                dtpTimeFrom.Enabled = True
                dtpTimeTo.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddLeave(sender As Object, e As EventArgs) Handles MyBase.Load
         Call btn_new_Click(sender, e)
        Try
            'For Each rdo As Control In GroupBox2.Controls
            '    If TypeOf rdo Is RadioButton Then
            '        rdo.Enabled = False
            '    End If
            'Next
            '---------------------------------------
            dtpTimeFrom.Format = DateTimePickerFormat.Time
            dtpTimeFrom.ShowUpDown = True
            '----------------------------------
            dtpTimeTo.Format = DateTimePickerFormat.Time
            dtpTimeTo.ShowUpDown = True
            '-----------------------------------
            loadautonumber("applicationcode", lblcode)
            '--------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtemid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemid.KeyPress, txtnoDays.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtapprovesearch_TextChanged(sender As Object, e As EventArgs) Handles txtapprovesearch.TextChanged
        Try
            '----------------------------------approved list.
            sql = "SELECT  e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Start of Date Leave',`LEAVEENDDATE` as 'End of Date Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons'   FROM `employee` e,`leave` l  WHERE e.`EMPID`=l.`EMPID` " &
        " AND (e.`EMPID` LIKE '%" & txtapprovesearch.Text & "%' OR concat( `emp_fname`,' ', `emp_lname`) LIKE '%" & txtapprovesearch.Text & "%')"
            reloadDtg(sql, dtgapprovedlist)
            'sql = "SELECT LEAVECODE, e.`EMPID` as 'Employee Id', concat( `emp_fname`,' ', `emp_lname`) as 'Name',`LEAVEFORMAT` as 'Status', `LEAVEAPPLIED` as 'Applied Leave', TIME(`DATEFROM`) as 'From', TIME(`DATETO`) as 'To' , DATE(`LEAVEDATE`) as 'Date of Leave', `NODAYS` as 'No. Days', `REASON` as 'Reasons', `DAYOFFSCHEDULE` as 'Dayoff Schedule'   FROM `employee` e,`leave` l  WHERE   AND e.`EMPID`=l.`EMPID`" & _
            '" AND (e.`EMPID` LIKE '%" & txtapprovesearch.Text & "%' OR concat( `emp_fname`,' ', `emp_lname`) LIKE '%" & txtapprovesearch.Text & "%')"
            'reloadDtg(sql, dtgapprovedlist)
            'dtgapprovedlist.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddLeave
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpNotfallWeekened = New System.Windows.Forms.DateTimePicker()
        Me.txtnoDays = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpenddate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpdatestart = New System.Windows.Forms.DateTimePicker()
        Me.dtpTimeTo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTimeFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoAcidentOnDuty = New System.Windows.Forms.RadioButton()
        Me.rdoFuneral = New System.Windows.Forms.RadioButton()
        Me.rdoMaternity = New System.Windows.Forms.RadioButton()
        Me.rdoPaternity = New System.Windows.Forms.RadioButton()
        Me.rdoVacation = New System.Windows.Forms.RadioButton()
        Me.rdoSick = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoWithoutPay = New System.Windows.Forms.RadioButton()
        Me.rdowithPay = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtreasons = New System.Windows.Forms.RichTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.txtdepartment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemid = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtapprovesearch = New System.Windows.Forms.TextBox()
        Me.dtgapprovedlist = New System.Windows.Forms.DataGridView()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgapprovedlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.btnNew)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.dtpNotfallWeekened)
        Me.GroupBox4.Controls.Add(Me.txtnoDays)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(4, 351)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(740, 70)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Tag = "Reasons"
        Me.GroupBox4.Text = "Other Reasons"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNew.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(369, 14)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(99, 42)
        Me.btnNew.TabIndex = 18
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(426, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Please specify DAY-OFF schedule if it does not fall on a weekened"
        '
        'dtpNotfallWeekened
        '
        Me.dtpNotfallWeekened.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNotfallWeekened.Location = New System.Drawing.Point(469, 34)
        Me.dtpNotfallWeekened.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpNotfallWeekened.Name = "dtpNotfallWeekened"
        Me.dtpNotfallWeekened.Size = New System.Drawing.Size(265, 22)
        Me.dtpNotfallWeekened.TabIndex = 17
        '
        'txtnoDays
        '
        Me.txtnoDays.Location = New System.Drawing.Point(469, 34)
        Me.txtnoDays.Name = "txtnoDays"
        Me.txtnoDays.Size = New System.Drawing.Size(100, 26)
        Me.txtnoDays.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox5.Controls.Add(Me.dtpenddate)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.dtpdatestart)
        Me.GroupBox5.Controls.Add(Me.dtpTimeTo)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.dtpTimeFrom)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(4, 292)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(740, 108)
        Me.GroupBox5.TabIndex = 46
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "                              From                                               " &
    "                              To"
        '
        'dtpenddate
        '
        Me.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpenddate.Location = New System.Drawing.Point(443, 27)
        Me.dtpenddate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpenddate.Name = "dtpenddate"
        Me.dtpenddate.Size = New System.Drawing.Size(161, 22)
        Me.dtpenddate.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(364, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "End Date :"
        '
        'dtpdatestart
        '
        Me.dtpdatestart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdatestart.Location = New System.Drawing.Point(146, 28)
        Me.dtpdatestart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpdatestart.Name = "dtpdatestart"
        Me.dtpdatestart.Size = New System.Drawing.Size(201, 22)
        Me.dtpdatestart.TabIndex = 28
        '
        'dtpTimeTo
        '
        Me.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimeTo.Location = New System.Drawing.Point(443, 61)
        Me.dtpTimeTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpTimeTo.Name = "dtpTimeTo"
        Me.dtpTimeTo.Size = New System.Drawing.Size(161, 22)
        Me.dtpTimeTo.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(84, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Time :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(389, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Time :"
        '
        'dtpTimeFrom
        '
        Me.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimeFrom.Location = New System.Drawing.Point(146, 62)
        Me.dtpTimeFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpTimeFrom.Name = "dtpTimeFrom"
        Me.dtpTimeFrom.Size = New System.Drawing.Size(201, 22)
        Me.dtpTimeFrom.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Leave Date :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.rdoAcidentOnDuty)
        Me.GroupBox2.Controls.Add(Me.rdoFuneral)
        Me.GroupBox2.Controls.Add(Me.rdoMaternity)
        Me.GroupBox2.Controls.Add(Me.rdoPaternity)
        Me.GroupBox2.Controls.Add(Me.rdoVacation)
        Me.GroupBox2.Controls.Add(Me.rdoSick)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 179)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(742, 106)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Leave Applied For"
        '
        'rdoAcidentOnDuty
        '
        Me.rdoAcidentOnDuty.AutoSize = True
        Me.rdoAcidentOnDuty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAcidentOnDuty.Location = New System.Drawing.Point(460, 67)
        Me.rdoAcidentOnDuty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoAcidentOnDuty.Name = "rdoAcidentOnDuty"
        Me.rdoAcidentOnDuty.Size = New System.Drawing.Size(135, 20)
        Me.rdoAcidentOnDuty.TabIndex = 7
        Me.rdoAcidentOnDuty.TabStop = True
        Me.rdoAcidentOnDuty.Text = "Accident On Duty"
        Me.rdoAcidentOnDuty.UseVisualStyleBackColor = True
        '
        'rdoFuneral
        '
        Me.rdoFuneral.AutoSize = True
        Me.rdoFuneral.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFuneral.Location = New System.Drawing.Point(460, 39)
        Me.rdoFuneral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoFuneral.Name = "rdoFuneral"
        Me.rdoFuneral.Size = New System.Drawing.Size(75, 20)
        Me.rdoFuneral.TabIndex = 6
        Me.rdoFuneral.TabStop = True
        Me.rdoFuneral.Text = "Funeral"
        Me.rdoFuneral.UseVisualStyleBackColor = True
        '
        'rdoMaternity
        '
        Me.rdoMaternity.AutoSize = True
        Me.rdoMaternity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMaternity.Location = New System.Drawing.Point(354, 67)
        Me.rdoMaternity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoMaternity.Name = "rdoMaternity"
        Me.rdoMaternity.Size = New System.Drawing.Size(85, 20)
        Me.rdoMaternity.TabIndex = 5
        Me.rdoMaternity.TabStop = True
        Me.rdoMaternity.Text = "Maternity"
        Me.rdoMaternity.UseVisualStyleBackColor = True
        '
        'rdoPaternity
        '
        Me.rdoPaternity.AutoSize = True
        Me.rdoPaternity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPaternity.Location = New System.Drawing.Point(255, 67)
        Me.rdoPaternity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoPaternity.Name = "rdoPaternity"
        Me.rdoPaternity.Size = New System.Drawing.Size(83, 20)
        Me.rdoPaternity.TabIndex = 4
        Me.rdoPaternity.TabStop = True
        Me.rdoPaternity.Text = "Paternity"
        Me.rdoPaternity.UseVisualStyleBackColor = True
        '
        'rdoVacation
        '
        Me.rdoVacation.AutoSize = True
        Me.rdoVacation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoVacation.Location = New System.Drawing.Point(357, 39)
        Me.rdoVacation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoVacation.Name = "rdoVacation"
        Me.rdoVacation.Size = New System.Drawing.Size(81, 20)
        Me.rdoVacation.TabIndex = 3
        Me.rdoVacation.TabStop = True
        Me.rdoVacation.Text = "Vacation"
        Me.rdoVacation.UseVisualStyleBackColor = True
        '
        'rdoSick
        '
        Me.rdoSick.AutoSize = True
        Me.rdoSick.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSick.Location = New System.Drawing.Point(255, 39)
        Me.rdoSick.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoSick.Name = "rdoSick"
        Me.rdoSick.Size = New System.Drawing.Size(53, 20)
        Me.rdoSick.TabIndex = 2
        Me.rdoSick.TabStop = True
        Me.rdoSick.Text = "Sick"
        Me.rdoSick.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoWithoutPay)
        Me.GroupBox3.Controls.Add(Me.rdowithPay)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(215, 80)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option"
        '
        'rdoWithoutPay
        '
        Me.rdoWithoutPay.AutoSize = True
        Me.rdoWithoutPay.Location = New System.Drawing.Point(40, 48)
        Me.rdoWithoutPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoWithoutPay.Name = "rdoWithoutPay"
        Me.rdoWithoutPay.Size = New System.Drawing.Size(103, 20)
        Me.rdoWithoutPay.TabIndex = 0
        Me.rdoWithoutPay.TabStop = True
        Me.rdoWithoutPay.Text = "Without Pay"
        Me.rdoWithoutPay.UseVisualStyleBackColor = True
        '
        'rdowithPay
        '
        Me.rdowithPay.AutoSize = True
        Me.rdowithPay.Location = New System.Drawing.Point(40, 20)
        Me.rdowithPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdowithPay.Name = "rdowithPay"
        Me.rdowithPay.Size = New System.Drawing.Size(83, 20)
        Me.rdowithPay.TabIndex = 0
        Me.rdowithPay.TabStop = True
        Me.rdowithPay.Text = "With Pay"
        Me.rdowithPay.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 581)
        Me.TabControl1.TabIndex = 53
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.txtreasons)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnOk)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(755, 555)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Leave of Absence"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtreasons
        '
        Me.txtreasons.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreasons.Location = New System.Drawing.Point(16, 418)
        Me.txtreasons.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtreasons.Name = "txtreasons"
        Me.txtreasons.Size = New System.Drawing.Size(728, 63)
        Me.txtreasons.TabIndex = 86
        Me.txtreasons.Text = ""
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(122, 499)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 51)
        Me.btnCancel.TabIndex = 84
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.SteelBlue
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(10, 499)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(106, 51)
        Me.btnOk.TabIndex = 83
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtsalary)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblcode)
        Me.GroupBox1.Controls.Add(Me.txtdepartment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeId)
        Me.GroupBox1.Controls.Add(Me.txtposition)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtemid)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(740, 109)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee's Details"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(234, -27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(214, 33)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Add Leave of Absence"
        '
        'txtsalary
        '
        Me.txtsalary.Enabled = False
        Me.txtsalary.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalary.Location = New System.Drawing.Point(479, 59)
        Me.txtsalary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsalary.Multiline = True
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(239, 26)
        Me.txtsalary.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(391, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Salary :"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcode.Location = New System.Drawing.Point(609, 109)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(125, 16)
        Me.lblcode.TabIndex = 13
        Me.lblcode.Text = "HR Form-011 (ALA)"
        '
        'txtdepartment
        '
        Me.txtdepartment.Enabled = False
        Me.txtdepartment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepartment.Location = New System.Drawing.Point(135, 59)
        Me.txtdepartment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdepartment.Multiline = True
        Me.txtdepartment.Name = "txtdepartment"
        Me.txtdepartment.Size = New System.Drawing.Size(240, 26)
        Me.txtdepartment.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Employee Id:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Department :"
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.Enabled = False
        Me.txtEmployeeId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeId.Location = New System.Drawing.Point(135, 27)
        Me.txtEmployeeId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmployeeId.Multiline = True
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(181, 26)
        Me.txtEmployeeId.TabIndex = 4
        '
        'txtposition
        '
        Me.txtposition.Enabled = False
        Me.txtposition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.Location = New System.Drawing.Point(479, 25)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtposition.Multiline = True
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(239, 26)
        Me.txtposition.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(391, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Position :"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsearch.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(394, 132)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(74, 28)
        Me.btnsearch.TabIndex = 6
        Me.btnsearch.Text = "Find"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Id :"
        '
        'txtemid
        '
        Me.txtemid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemid.Location = New System.Drawing.Point(187, 132)
        Me.txtemid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtemid.Multiline = True
        Me.txtemid.Name = "txtemid"
        Me.txtemid.Size = New System.Drawing.Size(188, 28)
        Me.txtemid.TabIndex = 2
        Me.txtemid.Tag = "Employee Id"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtapprovesearch)
        Me.TabPage2.Controls.Add(Me.dtgapprovedlist)
        Me.TabPage2.Controls.Add(Me.btnApprove)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(755, 555)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(472, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 15)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Search :"
        '
        'txtapprovesearch
        '
        Me.txtapprovesearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtapprovesearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapprovesearch.Location = New System.Drawing.Point(539, 10)
        Me.txtapprovesearch.Name = "txtapprovesearch"
        Me.txtapprovesearch.Size = New System.Drawing.Size(234, 23)
        Me.txtapprovesearch.TabIndex = 63
        '
        'dtgapprovedlist
        '
        Me.dtgapprovedlist.AllowUserToAddRows = False
        Me.dtgapprovedlist.AllowUserToDeleteRows = False
        Me.dtgapprovedlist.AllowUserToResizeColumns = False
        Me.dtgapprovedlist.AllowUserToResizeRows = False
        Me.dtgapprovedlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgapprovedlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgapprovedlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgapprovedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgapprovedlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgapprovedlist.Location = New System.Drawing.Point(14, 40)
        Me.dtgapprovedlist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgapprovedlist.Name = "dtgapprovedlist"
        Me.dtgapprovedlist.RowHeadersVisible = False
        Me.dtgapprovedlist.RowTemplate.Height = 24
        Me.dtgapprovedlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgapprovedlist.Size = New System.Drawing.Size(759, 401)
        Me.dtgapprovedlist.TabIndex = 61
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnApprove.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(21, 243)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(91, 38)
        Me.btnApprove.TabIndex = 56
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 25)
        Me.Panel1.TabIndex = 55
        '
        'frmAddLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 581)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmAddLeave"
        Me.Text = "frmAddLeave"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgapprovedlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnNew As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpNotfallWeekened As DateTimePicker
    Friend WithEvents txtnoDays As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dtpenddate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpdatestart As DateTimePicker
    Friend WithEvents dtpTimeTo As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpTimeFrom As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoAcidentOnDuty As RadioButton
    Friend WithEvents rdoFuneral As RadioButton
    Friend WithEvents rdoMaternity As RadioButton
    Friend WithEvents rdoPaternity As RadioButton
    Friend WithEvents rdoVacation As RadioButton
    Friend WithEvents rdoSick As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdoWithoutPay As RadioButton
    Friend WithEvents rdowithPay As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtreasons As RichTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtsalary As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcode As Label
    Friend WithEvents txtdepartment As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmployeeId As TextBox
    Friend WithEvents txtposition As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemid As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents txtapprovesearch As TextBox
    Friend WithEvents dtgapprovedlist As DataGridView
    Friend WithEvents btnApprove As Button
End Class

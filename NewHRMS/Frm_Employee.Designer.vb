<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Employee
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstboxNames = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cmboxNames = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmboxDeptt = New System.Windows.Forms.ComboBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.FromDB = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmpID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpDeptt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpDepttID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmboxTitle = New System.Windows.Forms.ComboBox()
        Me.dateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnAddJob = New System.Windows.Forms.Button()
        Me.dateTimeJoin = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.dtpdbirth = New System.Windows.Forms.DateTimePicker()
        Me.txtworkstatus = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtdrate = New System.Windows.Forms.TextBox()
        Me.dtpdhired = New System.Windows.Forms.DateTimePicker()
        Me.txtpmethod = New System.Windows.Forms.ComboBox()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label16.Location = New System.Drawing.Point(12, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "End Date"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnOk)
        Me.TabPage1.Controls.Add(Me.btnApply)
        Me.TabPage1.Controls.Add(Me.btnEdit)
        Me.TabPage1.Controls.Add(Me.btnRemove)
        Me.TabPage1.Controls.Add(Me.dgvEmployee)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(997, 576)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lstboxNames)
        Me.GroupBox2.Controls.Add(Me.btnSubmit)
        Me.GroupBox2.Controls.Add(Me.cmboxNames)
        Me.GroupBox2.Location = New System.Drawing.Point(338, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 347)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(14, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Names"
        '
        'lstboxNames
        '
        Me.lstboxNames.FormattingEnabled = True
        Me.lstboxNames.Location = New System.Drawing.Point(85, 64)
        Me.lstboxNames.Name = "lstboxNames"
        Me.lstboxNames.Size = New System.Drawing.Size(198, 225)
        Me.lstboxNames.TabIndex = 22
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(184, 15)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 31)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'cmboxNames
        '
        Me.cmboxNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmboxNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmboxNames.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmboxNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxNames.FormattingEnabled = True
        Me.cmboxNames.Location = New System.Drawing.Point(17, 19)
        Me.cmboxNames.Name = "cmboxNames"
        Me.cmboxNames.Size = New System.Drawing.Size(154, 23)
        Me.cmboxNames.TabIndex = 20
        Me.cmboxNames.Text = "Search Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(335, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Search"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(11, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Enter Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtSalary)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.cmboxDeptt)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 349)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(124, 163)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(154, 22)
        Me.txtPhone.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(23, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Phone No."
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(124, 205)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(154, 52)
        Me.txtAddress.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(22, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Salary (Rs.)"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(124, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(154, 22)
        Me.txtID.TabIndex = 1
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(124, 274)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(154, 22)
        Me.txtSalary.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(124, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 22)
        Me.txtName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(22, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Department"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(124, 128)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(154, 22)
        Me.txtEmail.TabIndex = 4
        '
        'cmboxDeptt
        '
        Me.cmboxDeptt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxDeptt.FormattingEnabled = True
        Me.cmboxDeptt.Location = New System.Drawing.Point(124, 310)
        Me.cmboxDeptt.Name = "cmboxDeptt"
        Me.cmboxDeptt.Size = New System.Drawing.Size(154, 23)
        Me.cmboxDeptt.TabIndex = 8
        Me.cmboxDeptt.Text = "Select - Department"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(124, 88)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(154, 22)
        Me.txtAge.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(21, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Employee ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(24, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(23, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(23, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(23, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Age (yrs)"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(82, 542)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 31)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(620, 542)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 31)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.SteelBlue
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(515, 542)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(99, 31)
        Me.btnOk.TabIndex = 26
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.SteelBlue
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.Location = New System.Drawing.Point(410, 542)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(99, 31)
        Me.btnApply.TabIndex = 25
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(200, 542)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 31)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(305, 542)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(99, 31)
        Me.btnRemove.TabIndex = 23
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FromDB, Me.EmpID, Me.EmpName, Me.EmpAge, Me.EmpEmail, Me.EmpPhone, Me.EmpAddress, Me.EmpSalary, Me.EmpDeptt, Me.EmpDepttID})
        Me.dgvEmployee.Location = New System.Drawing.Point(3, 386)
        Me.dgvEmployee.MultiSelect = False
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployee.Size = New System.Drawing.Size(957, 150)
        Me.dgvEmployee.TabIndex = 29
        '
        'FromDB
        '
        Me.FromDB.HeaderText = "FromDB"
        Me.FromDB.Name = "FromDB"
        Me.FromDB.Visible = False
        '
        'EmpID
        '
        Me.EmpID.HeaderText = "EmployeeID"
        Me.EmpID.Name = "EmpID"
        '
        'EmpName
        '
        Me.EmpName.HeaderText = "Name"
        Me.EmpName.Name = "EmpName"
        '
        'EmpAge
        '
        Me.EmpAge.HeaderText = "Age"
        Me.EmpAge.Name = "EmpAge"
        '
        'EmpEmail
        '
        Me.EmpEmail.HeaderText = "Email"
        Me.EmpEmail.Name = "EmpEmail"
        '
        'EmpPhone
        '
        Me.EmpPhone.HeaderText = "PhoneNumber"
        Me.EmpPhone.Name = "EmpPhone"
        '
        'EmpAddress
        '
        Me.EmpAddress.HeaderText = "Address"
        Me.EmpAddress.Name = "EmpAddress"
        '
        'EmpSalary
        '
        Me.EmpSalary.HeaderText = "Salary"
        Me.EmpSalary.Name = "EmpSalary"
        '
        'EmpDeptt
        '
        Me.EmpDeptt.HeaderText = "DepartmentName"
        Me.EmpDeptt.Name = "EmpDeptt"
        '
        'EmpDepttID
        '
        Me.EmpDepttID.HeaderText = "EmpDepttID"
        Me.EmpDepttID.Name = "EmpDepttID"
        Me.EmpDepttID.Visible = False
        '
        'cmboxTitle
        '
        Me.cmboxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxTitle.FormattingEnabled = True
        Me.cmboxTitle.Location = New System.Drawing.Point(112, 25)
        Me.cmboxTitle.Name = "cmboxTitle"
        Me.cmboxTitle.Size = New System.Drawing.Size(199, 23)
        Me.cmboxTitle.TabIndex = 32
        Me.cmboxTitle.Text = "Select - Title"
        '
        'dateTimeEnd
        '
        Me.dateTimeEnd.Location = New System.Drawing.Point(111, 124)
        Me.dateTimeEnd.Name = "dateTimeEnd"
        Me.dateTimeEnd.Size = New System.Drawing.Size(200, 20)
        Me.dateTimeEnd.TabIndex = 38
        '
        'btnAddJob
        '
        Me.btnAddJob.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddJob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddJob.ForeColor = System.Drawing.Color.White
        Me.btnAddJob.Location = New System.Drawing.Point(7, 161)
        Me.btnAddJob.Name = "btnAddJob"
        Me.btnAddJob.Size = New System.Drawing.Size(99, 31)
        Me.btnAddJob.TabIndex = 37
        Me.btnAddJob.Text = "Add"
        Me.btnAddJob.UseVisualStyleBackColor = False
        '
        'dateTimeJoin
        '
        Me.dateTimeJoin.Location = New System.Drawing.Point(111, 77)
        Me.dateTimeJoin.Name = "dateTimeJoin"
        Me.dateTimeJoin.Size = New System.Drawing.Size(200, 20)
        Me.dateTimeJoin.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(10, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Job Title"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-1, 660)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 24)
        Me.Panel1.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1005, 602)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(630, 576)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Job Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.dateTimeEnd)
        Me.GroupBox3.Controls.Add(Me.dateTimeJoin)
        Me.GroupBox3.Controls.Add(Me.btnAddJob)
        Me.GroupBox3.Controls.Add(Me.cmboxTitle)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(330, 200)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(10, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 16)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Start Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(22, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Enter Job Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(474, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Employee"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1021, 39)
        Me.Panel2.TabIndex = 13
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtposition)
        Me.GroupBox10.Controls.Add(Me.dtpdbirth)
        Me.GroupBox10.Controls.Add(Me.txtworkstatus)
        Me.GroupBox10.Controls.Add(Me.Label22)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.Label24)
        Me.GroupBox10.Controls.Add(Me.rdofemale)
        Me.GroupBox10.Controls.Add(Me.Label35)
        Me.GroupBox10.Controls.Add(Me.rdomale)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.txtdrate)
        Me.GroupBox10.Controls.Add(Me.dtpdhired)
        Me.GroupBox10.Controls.Add(Me.txtpmethod)
        Me.GroupBox10.Location = New System.Drawing.Point(656, 24)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(304, 347)
        Me.GroupBox10.TabIndex = 35
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Work Information"
        '
        'txtposition
        '
        Me.txtposition.Location = New System.Drawing.Point(99, 100)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(156, 20)
        Me.txtposition.TabIndex = 47
        '
        'dtpdbirth
        '
        Me.dtpdbirth.CustomFormat = "yyyy-MM-dd"
        Me.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdbirth.Location = New System.Drawing.Point(90, 240)
        Me.dtpdbirth.Name = "dtpdbirth"
        Me.dtpdbirth.Size = New System.Drawing.Size(121, 20)
        Me.dtpdbirth.TabIndex = 46
        '
        'txtworkstatus
        '
        Me.txtworkstatus.FormattingEnabled = True
        Me.txtworkstatus.Items.AddRange(New Object() {"Active", "Resigned", "Retired"})
        Me.txtworkstatus.Location = New System.Drawing.Point(99, 131)
        Me.txtworkstatus.Name = "txtworkstatus"
        Me.txtworkstatus.Size = New System.Drawing.Size(154, 21)
        Me.txtworkstatus.TabIndex = 8
        Me.txtworkstatus.Text = "Active"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(17, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Date of Birth"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(18, 34)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(62, 13)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "Daily Rate :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(18, 103)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(50, 13)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Position :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(18, 204)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 13)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "Sex"
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Location = New System.Drawing.Point(153, 204)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(59, 17)
        Me.rdofemale.TabIndex = 40
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(18, 131)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(43, 13)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Status :"
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Location = New System.Drawing.Point(99, 204)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(48, 17)
        Me.rdomale.TabIndex = 41
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(18, 70)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(70, 13)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Pay Method :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(17, 173)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 13)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Date Hired :"
        '
        'txtdrate
        '
        Me.txtdrate.Location = New System.Drawing.Point(101, 32)
        Me.txtdrate.MaxLength = 3
        Me.txtdrate.Name = "txtdrate"
        Me.txtdrate.Size = New System.Drawing.Size(154, 20)
        Me.txtdrate.TabIndex = 2
        '
        'dtpdhired
        '
        Me.dtpdhired.CustomFormat = "yyyy-MM-dd"
        Me.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdhired.Location = New System.Drawing.Point(101, 172)
        Me.dtpdhired.Name = "dtpdhired"
        Me.dtpdhired.Size = New System.Drawing.Size(154, 20)
        Me.dtpdhired.TabIndex = 1
        '
        'txtpmethod
        '
        Me.txtpmethod.FormattingEnabled = True
        Me.txtpmethod.Items.AddRange(New Object() {"Weekly", "Monthly"})
        Me.txtpmethod.Location = New System.Drawing.Point(99, 67)
        Me.txtpmethod.Name = "txtpmethod"
        Me.txtpmethod.Size = New System.Drawing.Size(154, 21)
        Me.txtpmethod.TabIndex = 0
        Me.txtpmethod.Text = "Weekly"
        '
        'Frm_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1020, 682)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.MinimizeBox = False
        Me.Name = "Frm_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lstboxNames As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents cmboxNames As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cmboxDeptt As System.Windows.Forms.ComboBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents dgvEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents FromDB As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EmpID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpSalary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpDeptt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpDepttID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmboxTitle As System.Windows.Forms.ComboBox
    Friend WithEvents dateTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAddJob As System.Windows.Forms.Button
    Friend WithEvents dateTimeJoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents txtposition As TextBox
    Friend WithEvents dtpdbirth As DateTimePicker
    Friend WithEvents txtworkstatus As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents rdofemale As RadioButton
    Friend WithEvents Label35 As Label
    Friend WithEvents rdomale As RadioButton
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtdrate As TextBox
    Friend WithEvents dtpdhired As DateTimePicker
    Friend WithEvents txtpmethod As ComboBox
End Class

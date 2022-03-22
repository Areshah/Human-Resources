<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtbplace = New System.Windows.Forms.RichTextBox()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbodeaprtment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.dtpdbirth = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.txtemerg = New System.Windows.Forms.TextBox()
        Me.txtposition = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cbowtype = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtdrate = New System.Windows.Forms.TextBox()
        Me.dtpdhired = New System.Windows.Forms.DateTimePicker()
        Me.txtpmethod = New System.Windows.Forms.ComboBox()
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.emptitle = New System.Windows.Forms.Label()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(14, 64)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(91, 16)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Pay Method :"
        '
        'txtcode
        '
        Me.txtcode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(104, 27)
        Me.txtcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcode.Multiline = True
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(171, 26)
        Me.txtcode.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Employee Id"
        '
        'txtbplace
        '
        Me.txtbplace.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtbplace.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbplace.Location = New System.Drawing.Point(112, 199)
        Me.txtbplace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbplace.Name = "txtbplace"
        Me.txtbplace.Size = New System.Drawing.Size(229, 25)
        Me.txtbplace.TabIndex = 17
        Me.txtbplace.Text = ""
        '
        'txtaddress
        '
        Me.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtaddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(103, 104)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(274, 27)
        Me.txtaddress.TabIndex = 17
        Me.txtaddress.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Work Status :"
        '
        'cbodeaprtment
        '
        Me.cbodeaprtment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbodeaprtment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodeaprtment.FormattingEnabled = True
        Me.cbodeaprtment.Location = New System.Drawing.Point(402, 58)
        Me.cbodeaprtment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbodeaprtment.Name = "cbodeaprtment"
        Me.cbodeaprtment.Size = New System.Drawing.Size(363, 24)
        Me.cbodeaprtment.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Department :"
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(306, 30)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(67, 16)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Position :"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(14, 202)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 16)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Place of Birth"
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(14, 29)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(81, 16)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "Daily Rate :"
        '
        'dtpdbirth
        '
        Me.dtpdbirth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpdbirth.CustomFormat = "yyyy-MM-dd"
        Me.dtpdbirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdbirth.Location = New System.Drawing.Point(643, 150)
        Me.dtpdbirth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpdbirth.Name = "dtpdbirth"
        Me.dtpdbirth.Size = New System.Drawing.Size(115, 22)
        Me.dtpdbirth.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(550, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 16)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Date of Birth"
        '
        'txtlname
        '
        Me.txtlname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtlname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(362, 60)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlname.Multiline = True
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(182, 26)
        Me.txtlname.TabIndex = 0
        '
        'txtcontact
        '
        Me.txtcontact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcontact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(382, 149)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcontact.MaxLength = 11
        Me.txtcontact.Multiline = True
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(162, 26)
        Me.txtcontact.TabIndex = 0
        '
        'txtfname
        '
        Me.txtfname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtfname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(104, 60)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfname.Multiline = True
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(171, 26)
        Me.txtfname.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(15, 155)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 16)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Sex"
        '
        'txtmname
        '
        Me.txtmname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtmname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(643, 60)
        Me.txtmname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmname.Multiline = True
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(131, 24)
        Me.txtmname.TabIndex = 0
        '
        'rdofemale
        '
        Me.rdofemale.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdofemale.Location = New System.Drawing.Point(167, 155)
        Me.rdofemale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(74, 20)
        Me.rdofemale.TabIndex = 6
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'txtemerg
        '
        Me.txtemerg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtemerg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemerg.Location = New System.Drawing.Point(573, 199)
        Me.txtemerg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtemerg.MaxLength = 11
        Me.txtemerg.Multiline = True
        Me.txtemerg.Name = "txtemerg"
        Me.txtemerg.Size = New System.Drawing.Size(201, 25)
        Me.txtemerg.TabIndex = 0
        '
        'txtposition
        '
        Me.txtposition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtposition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.FormattingEnabled = True
        Me.txtposition.Location = New System.Drawing.Point(402, 26)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(363, 24)
        Me.txtposition.TabIndex = 2
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.cbowtype)
        Me.GroupBox10.Controls.Add(Me.Label3)
        Me.GroupBox10.Controls.Add(Me.cbodeaprtment)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.txtposition)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.txtdrate)
        Me.GroupBox10.Controls.Add(Me.dtpdhired)
        Me.GroupBox10.Controls.Add(Me.txtpmethod)
        Me.GroupBox10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(4, 324)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox10.Size = New System.Drawing.Size(780, 145)
        Me.GroupBox10.TabIndex = 39
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Work Information"
        '
        'cbowtype
        '
        Me.cbowtype.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbowtype.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbowtype.FormattingEnabled = True
        Me.cbowtype.Items.AddRange(New Object() {"Regular", "Casual"})
        Me.cbowtype.Location = New System.Drawing.Point(402, 90)
        Me.cbowtype.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbowtype.Name = "cbowtype"
        Me.cbowtype.Size = New System.Drawing.Size(363, 24)
        Me.cbowtype.TabIndex = 12
        Me.cbowtype.Text = "Regular"
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(14, 95)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(83, 16)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Date Hired :"
        '
        'txtdrate
        '
        Me.txtdrate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtdrate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrate.Location = New System.Drawing.Point(111, 26)
        Me.txtdrate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdrate.MaxLength = 3
        Me.txtdrate.Name = "txtdrate"
        Me.txtdrate.Size = New System.Drawing.Size(129, 22)
        Me.txtdrate.TabIndex = 2
        '
        'dtpdhired
        '
        Me.dtpdhired.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpdhired.CustomFormat = "yyyy-MM-dd"
        Me.dtpdhired.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdhired.Location = New System.Drawing.Point(111, 90)
        Me.dtpdhired.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpdhired.Name = "dtpdhired"
        Me.dtpdhired.Size = New System.Drawing.Size(129, 22)
        Me.dtpdhired.TabIndex = 1
        '
        'txtpmethod
        '
        Me.txtpmethod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtpmethod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpmethod.FormattingEnabled = True
        Me.txtpmethod.Items.AddRange(New Object() {"Weekly", "Monthly"})
        Me.txtpmethod.Location = New System.Drawing.Point(111, 59)
        Me.txtpmethod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpmethod.Name = "txtpmethod"
        Me.txtpmethod.Size = New System.Drawing.Size(129, 24)
        Me.txtpmethod.TabIndex = 0
        Me.txtpmethod.Text = "Weekly"
        '
        'rdomale
        '
        Me.rdomale.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdomale.AutoSize = True
        Me.rdomale.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdomale.Location = New System.Drawing.Point(102, 155)
        Me.rdomale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(57, 20)
        Me.rdomale.TabIndex = 6
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(266, 155)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 16)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Contact Number"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(14, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 16)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "First Name"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(400, 115)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 16)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Civil Status"
        '
        'txtstatus
        '
        Me.txtstatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtstatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.FormattingEnabled = True
        Me.txtstatus.Items.AddRange(New Object() {"Married", "Single", "Widow"})
        Me.txtstatus.Location = New System.Drawing.Point(485, 107)
        Me.txtstatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(164, 24)
        Me.txtstatus.TabIndex = 2
        Me.txtstatus.Text = "Single"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(281, 65)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 16)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Last Name"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(347, 202)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(220, 16)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Contact no. [ case of emergency ]"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(545, 65)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 16)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Middle Name"
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.txtcode)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.txtbplace)
        Me.GroupBox9.Controls.Add(Me.txtaddress)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.dtpdbirth)
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.Controls.Add(Me.txtlname)
        Me.GroupBox9.Controls.Add(Me.txtcontact)
        Me.GroupBox9.Controls.Add(Me.txtfname)
        Me.GroupBox9.Controls.Add(Me.Label24)
        Me.GroupBox9.Controls.Add(Me.txtmname)
        Me.GroupBox9.Controls.Add(Me.rdofemale)
        Me.GroupBox9.Controls.Add(Me.txtemerg)
        Me.GroupBox9.Controls.Add(Me.rdomale)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.Label26)
        Me.GroupBox9.Controls.Add(Me.Label27)
        Me.GroupBox9.Controls.Add(Me.txtstatus)
        Me.GroupBox9.Controls.Add(Me.Label28)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.Label31)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(3, 60)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox9.Size = New System.Drawing.Size(781, 246)
        Me.GroupBox9.TabIndex = 38
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Personal Information"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(15, 115)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 16)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Address"
        '
        'emptitle
        '
        Me.emptitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emptitle.AutoSize = True
        Me.emptitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emptitle.Location = New System.Drawing.Point(3, 0)
        Me.emptitle.Name = "emptitle"
        Me.emptitle.Size = New System.Drawing.Size(347, 40)
        Me.emptitle.TabIndex = 37
        Me.emptitle.Text = "Add New Employee"
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 0
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.Gray
        Me.btnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSave.Iconimage = CType(resources.GetObject("btnSave.Iconimage"), System.Drawing.Image)
        Me.btnSave.Iconimage_right = Nothing
        Me.btnSave.Iconimage_right_Selected = Nothing
        Me.btnSave.Iconimage_Selected = Nothing
        Me.btnSave.IconMarginLeft = 0
        Me.btnSave.IconMarginRight = 0
        Me.btnSave.IconRightVisible = True
        Me.btnSave.IconRightZoom = 0R
        Me.btnSave.IconVisible = True
        Me.btnSave.IconZoom = 90.0R
        Me.btnSave.IsTab = False
        Me.btnSave.Location = New System.Drawing.Point(4, 476)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(128, 59)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Textcolor = System.Drawing.Color.White
        Me.btnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNew
        '
        Me.btnNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.BorderRadius = 0
        Me.btnNew.ButtonText = "New"
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.DisabledColor = System.Drawing.Color.Gray
        Me.btnNew.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNew.Iconimage = CType(resources.GetObject("btnNew.Iconimage"), System.Drawing.Image)
        Me.btnNew.Iconimage_right = Nothing
        Me.btnNew.Iconimage_right_Selected = Nothing
        Me.btnNew.Iconimage_Selected = Nothing
        Me.btnNew.IconMarginLeft = 0
        Me.btnNew.IconMarginRight = 0
        Me.btnNew.IconRightVisible = True
        Me.btnNew.IconRightZoom = 0R
        Me.btnNew.IconVisible = True
        Me.btnNew.IconZoom = 90.0R
        Me.btnNew.IsTab = False
        Me.btnNew.Location = New System.Drawing.Point(132, 476)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnNew.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNew.selected = False
        Me.btnNew.Size = New System.Drawing.Size(128, 59)
        Me.btnNew.TabIndex = 41
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Textcolor = System.Drawing.Color.White
        Me.btnNew.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.emptitle)
        Me.Name = "frmEmployee"
        Me.Size = New System.Drawing.Size(787, 538)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label34 As Label
    Friend WithEvents txtcode As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtbplace As RichTextBox
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbodeaprtment As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents dtpdbirth As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtmname As TextBox
    Friend WithEvents rdofemale As RadioButton
    Friend WithEvents txtemerg As TextBox
    Friend WithEvents txtposition As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents cbowtype As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtdrate As TextBox
    Friend WithEvents dtpdhired As DateTimePicker
    Friend WithEvents txtpmethod As ComboBox
    Friend WithEvents rdomale As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtstatus As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents emptitle As Label
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuFlatButton
End Class

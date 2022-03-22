<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.dtgdeptlist = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Delete_Position = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_update_Position = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_save_Position = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.dtglistposition = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_delete_dept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_update_dept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_save_dept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtdepartment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgdeptlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtglistposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgdeptlist
        '
        Me.dtgdeptlist.AllowUserToAddRows = False
        Me.dtgdeptlist.AllowUserToDeleteRows = False
        Me.dtgdeptlist.AllowUserToResizeColumns = False
        Me.dtgdeptlist.AllowUserToResizeRows = False
        Me.dtgdeptlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgdeptlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgdeptlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgdeptlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgdeptlist.Location = New System.Drawing.Point(6, 61)
        Me.dtgdeptlist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgdeptlist.Name = "dtgdeptlist"
        Me.dtgdeptlist.Size = New System.Drawing.Size(378, 405)
        Me.dtgdeptlist.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btn_Delete_Position)
        Me.GroupBox1.Controls.Add(Me.btn_update_Position)
        Me.GroupBox1.Controls.Add(Me.btn_save_Position)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtposition)
        Me.GroupBox1.Controls.Add(Me.dtglistposition)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(391, 533)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position of the Employee"
        '
        'btn_Delete_Position
        '
        Me.btn_Delete_Position.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Delete_Position.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Delete_Position.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Delete_Position.BorderRadius = 0
        Me.btn_Delete_Position.ButtonText = "Delete"
        Me.btn_Delete_Position.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete_Position.DisabledColor = System.Drawing.Color.Gray
        Me.btn_Delete_Position.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete_Position.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_Delete_Position.Iconimage = CType(resources.GetObject("btn_Delete_Position.Iconimage"), System.Drawing.Image)
        Me.btn_Delete_Position.Iconimage_right = Nothing
        Me.btn_Delete_Position.Iconimage_right_Selected = Nothing
        Me.btn_Delete_Position.Iconimage_Selected = Nothing
        Me.btn_Delete_Position.IconMarginLeft = 0
        Me.btn_Delete_Position.IconMarginRight = 0
        Me.btn_Delete_Position.IconRightVisible = True
        Me.btn_Delete_Position.IconRightZoom = 0R
        Me.btn_Delete_Position.IconVisible = True
        Me.btn_Delete_Position.IconZoom = 90.0R
        Me.btn_Delete_Position.IsTab = False
        Me.btn_Delete_Position.Location = New System.Drawing.Point(262, 474)
        Me.btn_Delete_Position.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_Delete_Position.Name = "btn_Delete_Position"
        Me.btn_Delete_Position.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_Delete_Position.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_Delete_Position.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_Delete_Position.selected = False
        Me.btn_Delete_Position.Size = New System.Drawing.Size(123, 48)
        Me.btn_Delete_Position.TabIndex = 10
        Me.btn_Delete_Position.Text = "Delete"
        Me.btn_Delete_Position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Delete_Position.Textcolor = System.Drawing.Color.White
        Me.btn_Delete_Position.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_update_Position
        '
        Me.btn_update_Position.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update_Position.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update_Position.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update_Position.BorderRadius = 0
        Me.btn_update_Position.ButtonText = "Update"
        Me.btn_update_Position.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update_Position.DisabledColor = System.Drawing.Color.Gray
        Me.btn_update_Position.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_Position.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_update_Position.Iconimage = CType(resources.GetObject("btn_update_Position.Iconimage"), System.Drawing.Image)
        Me.btn_update_Position.Iconimage_right = Nothing
        Me.btn_update_Position.Iconimage_right_Selected = Nothing
        Me.btn_update_Position.Iconimage_Selected = Nothing
        Me.btn_update_Position.IconMarginLeft = 0
        Me.btn_update_Position.IconMarginRight = 0
        Me.btn_update_Position.IconRightVisible = True
        Me.btn_update_Position.IconRightZoom = 0R
        Me.btn_update_Position.IconVisible = True
        Me.btn_update_Position.IconZoom = 90.0R
        Me.btn_update_Position.IsTab = False
        Me.btn_update_Position.Location = New System.Drawing.Point(135, 474)
        Me.btn_update_Position.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_update_Position.Name = "btn_update_Position"
        Me.btn_update_Position.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update_Position.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_update_Position.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_update_Position.selected = False
        Me.btn_update_Position.Size = New System.Drawing.Size(123, 48)
        Me.btn_update_Position.TabIndex = 9
        Me.btn_update_Position.Text = "Update"
        Me.btn_update_Position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update_Position.Textcolor = System.Drawing.Color.White
        Me.btn_update_Position.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_save_Position
        '
        Me.btn_save_Position.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_save_Position.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_save_Position.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save_Position.BorderRadius = 0
        Me.btn_save_Position.ButtonText = "Save"
        Me.btn_save_Position.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save_Position.DisabledColor = System.Drawing.Color.Gray
        Me.btn_save_Position.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_Position.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_save_Position.Iconimage = CType(resources.GetObject("btn_save_Position.Iconimage"), System.Drawing.Image)
        Me.btn_save_Position.Iconimage_right = Nothing
        Me.btn_save_Position.Iconimage_right_Selected = Nothing
        Me.btn_save_Position.Iconimage_Selected = Nothing
        Me.btn_save_Position.IconMarginLeft = 0
        Me.btn_save_Position.IconMarginRight = 0
        Me.btn_save_Position.IconRightVisible = True
        Me.btn_save_Position.IconRightZoom = 0R
        Me.btn_save_Position.IconVisible = True
        Me.btn_save_Position.IconZoom = 90.0R
        Me.btn_save_Position.IsTab = False
        Me.btn_save_Position.Location = New System.Drawing.Point(8, 474)
        Me.btn_save_Position.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_save_Position.Name = "btn_save_Position"
        Me.btn_save_Position.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_save_Position.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_save_Position.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_save_Position.selected = False
        Me.btn_save_Position.Size = New System.Drawing.Size(123, 48)
        Me.btn_save_Position.TabIndex = 7
        Me.btn_save_Position.Text = "Save"
        Me.btn_save_Position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save_Position.Textcolor = System.Drawing.Color.White
        Me.btn_save_Position.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Position :"
        '
        'txtposition
        '
        Me.txtposition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.Location = New System.Drawing.Point(79, 27)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtposition.Multiline = True
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(306, 26)
        Me.txtposition.TabIndex = 2
        '
        'dtglistposition
        '
        Me.dtglistposition.AllowUserToAddRows = False
        Me.dtglistposition.AllowUserToDeleteRows = False
        Me.dtglistposition.AllowUserToResizeColumns = False
        Me.dtglistposition.AllowUserToResizeRows = False
        Me.dtglistposition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtglistposition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtglistposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistposition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglistposition.Location = New System.Drawing.Point(6, 61)
        Me.dtglistposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtglistposition.Name = "dtglistposition"
        Me.dtglistposition.Size = New System.Drawing.Size(379, 405)
        Me.dtglistposition.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.btn_delete_dept)
        Me.GroupBox2.Controls.Add(Me.btn_update_dept)
        Me.GroupBox2.Controls.Add(Me.btn_save_dept)
        Me.GroupBox2.Controls.Add(Me.txtdepartment)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtgdeptlist)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(406, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(390, 533)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Department of the Employee"
        '
        'btn_delete_dept
        '
        Me.btn_delete_dept.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_delete_dept.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_delete_dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_delete_dept.BorderRadius = 0
        Me.btn_delete_dept.ButtonText = "Delete"
        Me.btn_delete_dept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete_dept.DisabledColor = System.Drawing.Color.Gray
        Me.btn_delete_dept.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_dept.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_delete_dept.Iconimage = CType(resources.GetObject("btn_delete_dept.Iconimage"), System.Drawing.Image)
        Me.btn_delete_dept.Iconimage_right = Nothing
        Me.btn_delete_dept.Iconimage_right_Selected = Nothing
        Me.btn_delete_dept.Iconimage_Selected = Nothing
        Me.btn_delete_dept.IconMarginLeft = 0
        Me.btn_delete_dept.IconMarginRight = 0
        Me.btn_delete_dept.IconRightVisible = True
        Me.btn_delete_dept.IconRightZoom = 0R
        Me.btn_delete_dept.IconVisible = True
        Me.btn_delete_dept.IconZoom = 90.0R
        Me.btn_delete_dept.IsTab = False
        Me.btn_delete_dept.Location = New System.Drawing.Point(257, 474)
        Me.btn_delete_dept.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_delete_dept.Name = "btn_delete_dept"
        Me.btn_delete_dept.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_delete_dept.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_delete_dept.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_delete_dept.selected = False
        Me.btn_delete_dept.Size = New System.Drawing.Size(123, 48)
        Me.btn_delete_dept.TabIndex = 13
        Me.btn_delete_dept.Text = "Delete"
        Me.btn_delete_dept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete_dept.Textcolor = System.Drawing.Color.White
        Me.btn_delete_dept.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_update_dept
        '
        Me.btn_update_dept.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update_dept.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update_dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update_dept.BorderRadius = 0
        Me.btn_update_dept.ButtonText = "Update"
        Me.btn_update_dept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update_dept.DisabledColor = System.Drawing.Color.Gray
        Me.btn_update_dept.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_dept.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_update_dept.Iconimage = CType(resources.GetObject("btn_update_dept.Iconimage"), System.Drawing.Image)
        Me.btn_update_dept.Iconimage_right = Nothing
        Me.btn_update_dept.Iconimage_right_Selected = Nothing
        Me.btn_update_dept.Iconimage_Selected = Nothing
        Me.btn_update_dept.IconMarginLeft = 0
        Me.btn_update_dept.IconMarginRight = 0
        Me.btn_update_dept.IconRightVisible = True
        Me.btn_update_dept.IconRightZoom = 0R
        Me.btn_update_dept.IconVisible = True
        Me.btn_update_dept.IconZoom = 90.0R
        Me.btn_update_dept.IsTab = False
        Me.btn_update_dept.Location = New System.Drawing.Point(134, 474)
        Me.btn_update_dept.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_update_dept.Name = "btn_update_dept"
        Me.btn_update_dept.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update_dept.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_update_dept.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_update_dept.selected = False
        Me.btn_update_dept.Size = New System.Drawing.Size(123, 48)
        Me.btn_update_dept.TabIndex = 12
        Me.btn_update_dept.Text = "Update"
        Me.btn_update_dept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update_dept.Textcolor = System.Drawing.Color.White
        Me.btn_update_dept.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_save_dept
        '
        Me.btn_save_dept.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_save_dept.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_save_dept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save_dept.BorderRadius = 0
        Me.btn_save_dept.ButtonText = "Save"
        Me.btn_save_dept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save_dept.DisabledColor = System.Drawing.Color.Gray
        Me.btn_save_dept.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_dept.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_save_dept.Iconimage = CType(resources.GetObject("btn_save_dept.Iconimage"), System.Drawing.Image)
        Me.btn_save_dept.Iconimage_right = Nothing
        Me.btn_save_dept.Iconimage_right_Selected = Nothing
        Me.btn_save_dept.Iconimage_Selected = Nothing
        Me.btn_save_dept.IconMarginLeft = 0
        Me.btn_save_dept.IconMarginRight = 0
        Me.btn_save_dept.IconRightVisible = True
        Me.btn_save_dept.IconRightZoom = 0R
        Me.btn_save_dept.IconVisible = True
        Me.btn_save_dept.IconZoom = 90.0R
        Me.btn_save_dept.IsTab = False
        Me.btn_save_dept.Location = New System.Drawing.Point(11, 474)
        Me.btn_save_dept.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_save_dept.Name = "btn_save_dept"
        Me.btn_save_dept.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_save_dept.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_save_dept.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_save_dept.selected = False
        Me.btn_save_dept.Size = New System.Drawing.Size(123, 48)
        Me.btn_save_dept.TabIndex = 11
        Me.btn_save_dept.Text = "Save"
        Me.btn_save_dept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save_dept.Textcolor = System.Drawing.Color.White
        Me.btn_save_dept.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtdepartment
        '
        Me.txtdepartment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepartment.Location = New System.Drawing.Point(114, 27)
        Me.txtdepartment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdepartment.Multiline = True
        Me.txtdepartment.Name = "txtdepartment"
        Me.txtdepartment.Size = New System.Drawing.Size(270, 26)
        Me.txtdepartment.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department :"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmSetting"
        Me.Size = New System.Drawing.Size(805, 556)
        CType(Me.dtgdeptlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtglistposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgdeptlist As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtglistposition As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtposition As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtdepartment As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Delete_Position As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_update_Position As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_save_Position As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_delete_dept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_update_dept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_save_dept As Bunifu.Framework.UI.BunifuFlatButton
End Class

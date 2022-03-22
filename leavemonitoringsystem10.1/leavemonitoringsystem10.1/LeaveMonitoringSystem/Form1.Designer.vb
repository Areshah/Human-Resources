<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.pnlSideBar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.picLogo2 = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEmployee = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlHeader = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMenuBar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.animate1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.animate2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.FrmReport1 = New LeaveMonitoringSystem.frmReport()
        Me.FrmUser1 = New LeaveMonitoringSystem.frmUser()
        Me.FrmSetting1 = New LeaveMonitoringSystem.frmSetting()
        Me.FrmAddLeave1 = New LeaveMonitoringSystem.frmAddLeave()
        Me.FrmFindEmployee1 = New LeaveMonitoringSystem.frmFindEmployee()
        Me.FrmEmployee1 = New LeaveMonitoringSystem.frmEmployee()
        Me.FrmHome1 = New LeaveMonitoringSystem.frmHome()
        Me.pnlSideBar.SuspendLayout()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContainer.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSideBar
        '
        Me.pnlSideBar.BackgroundImage = CType(resources.GetObject("pnlSideBar.BackgroundImage"), System.Drawing.Image)
        Me.pnlSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSideBar.Controls.Add(Me.picLogo2)
        Me.pnlSideBar.Controls.Add(Me.picLogo)
        Me.pnlSideBar.Controls.Add(Me.Label1)
        Me.pnlSideBar.Controls.Add(Me.BunifuFlatButton7)
        Me.pnlSideBar.Controls.Add(Me.BunifuFlatButton6)
        Me.pnlSideBar.Controls.Add(Me.BunifuFlatButton5)
        Me.pnlSideBar.Controls.Add(Me.BunifuFlatButton4)
        Me.pnlSideBar.Controls.Add(Me.BunifuFlatButton3)
        Me.pnlSideBar.Controls.Add(Me.btnEmployee)
        Me.pnlSideBar.Controls.Add(Me.BunifuFlatButton1)
        Me.animate2.SetDecoration(Me.pnlSideBar, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.pnlSideBar, BunifuAnimatorNS.DecorationType.None)
        Me.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideBar.GradientBottomLeft = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlSideBar.GradientBottomRight = System.Drawing.SystemColors.HotTrack
        Me.pnlSideBar.GradientTopLeft = System.Drawing.Color.ForestGreen
        Me.pnlSideBar.GradientTopRight = System.Drawing.Color.LawnGreen
        Me.pnlSideBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideBar.Name = "pnlSideBar"
        Me.pnlSideBar.Quality = 10
        Me.pnlSideBar.Size = New System.Drawing.Size(248, 590)
        Me.pnlSideBar.TabIndex = 0
        '
        'picLogo2
        '
        Me.picLogo2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picLogo2.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.picLogo2, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.picLogo2, BunifuAnimatorNS.DecorationType.None)
        Me.picLogo2.Image = CType(resources.GetObject("picLogo2.Image"), System.Drawing.Image)
        Me.picLogo2.Location = New System.Drawing.Point(3, 7)
        Me.picLogo2.Name = "picLogo2"
        Me.picLogo2.Size = New System.Drawing.Size(57, 58)
        Me.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo2.TabIndex = 8
        Me.picLogo2.TabStop = False
        Me.picLogo2.Visible = False
        '
        'picLogo
        '
        Me.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.picLogo, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.picLogo, BunifuAnimatorNS.DecorationType.None)
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(71, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(90, 72)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Janobe Sourcecode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "         Report"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 90.0R
        Me.BunifuFlatButton7.IsTab = True
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(0, 472)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(248, 58)
        Me.BunifuFlatButton7.TabIndex = 7
        Me.BunifuFlatButton7.Text = "         Report"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "         Manage Users"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 90.0R
        Me.BunifuFlatButton6.IsTab = True
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(0, 414)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(248, 58)
        Me.BunifuFlatButton6.TabIndex = 6
        Me.BunifuFlatButton6.Text = "         Manage Users"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "         Settings"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = True
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 356)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(248, 58)
        Me.BunifuFlatButton5.TabIndex = 5
        Me.BunifuFlatButton5.Text = "         Settings"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "         Leave of Absence"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = True
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 298)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(248, 58)
        Me.BunifuFlatButton4.TabIndex = 4
        Me.BunifuFlatButton4.Text = "         Leave of Absence"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "         Find Employees"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = True
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 240)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(249, 58)
        Me.BunifuFlatButton3.TabIndex = 3
        Me.BunifuFlatButton3.Text = "         Find Employees"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnEmployee
        '
        Me.btnEmployee.Activecolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnEmployee.BackColor = System.Drawing.Color.Transparent
        Me.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmployee.BorderRadius = 0
        Me.btnEmployee.ButtonText = "         Employees"
        Me.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.btnEmployee, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.btnEmployee, BunifuAnimatorNS.DecorationType.None)
        Me.btnEmployee.DisabledColor = System.Drawing.Color.Gray
        Me.btnEmployee.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEmployee.Iconimage = CType(resources.GetObject("btnEmployee.Iconimage"), System.Drawing.Image)
        Me.btnEmployee.Iconimage_right = Nothing
        Me.btnEmployee.Iconimage_right_Selected = Nothing
        Me.btnEmployee.Iconimage_Selected = Nothing
        Me.btnEmployee.IconMarginLeft = 0
        Me.btnEmployee.IconMarginRight = 0
        Me.btnEmployee.IconRightVisible = True
        Me.btnEmployee.IconRightZoom = 0R
        Me.btnEmployee.IconVisible = True
        Me.btnEmployee.IconZoom = 90.0R
        Me.btnEmployee.IsTab = True
        Me.btnEmployee.Location = New System.Drawing.Point(0, 182)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Normalcolor = System.Drawing.Color.Transparent
        Me.btnEmployee.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnEmployee.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEmployee.selected = False
        Me.btnEmployee.Size = New System.Drawing.Size(248, 58)
        Me.btnEmployee.TabIndex = 2
        Me.btnEmployee.Text = "         Employees"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.Textcolor = System.Drawing.Color.White
        Me.btnEmployee.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "         Home"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 124)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = True
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(248, 58)
        Me.BunifuFlatButton1.TabIndex = 0
        Me.BunifuFlatButton1.Text = "         Home"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlHeader
        '
        Me.pnlHeader.BackgroundImage = CType(resources.GetObject("pnlHeader.BackgroundImage"), System.Drawing.Image)
        Me.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHeader.Controls.Add(Me.BunifuImageButton2)
        Me.pnlHeader.Controls.Add(Me.BunifuImageButton1)
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.btnMenuBar)
        Me.animate2.SetDecoration(Me.pnlHeader, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.pnlHeader, BunifuAnimatorNS.DecorationType.None)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.pnlHeader.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.pnlHeader.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.pnlHeader.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(248, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Quality = 10
        Me.pnlHeader.Size = New System.Drawing.Size(805, 34)
        Me.pnlHeader.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(38, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Leave Monitoring System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.btnLogout, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.btnLogout, BunifuAnimatorNS.DecorationType.None)
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageActive = Nothing
        Me.btnLogout.Location = New System.Drawing.Point(758, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(44, 34)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.TabStop = False
        Me.btnLogout.Zoom = 10
        '
        'btnMenuBar
        '
        Me.btnMenuBar.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.btnMenuBar, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.btnMenuBar, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenuBar.Image = CType(resources.GetObject("btnMenuBar.Image"), System.Drawing.Image)
        Me.btnMenuBar.ImageActive = Nothing
        Me.btnMenuBar.Location = New System.Drawing.Point(1, 2)
        Me.btnMenuBar.Name = "btnMenuBar"
        Me.btnMenuBar.Size = New System.Drawing.Size(31, 31)
        Me.btnMenuBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenuBar.TabIndex = 2
        Me.btnMenuBar.TabStop = False
        Me.btnMenuBar.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnlHeader
        Me.BunifuDragControl1.Vertical = True
        '
        'pnlContainer
        '
        Me.pnlContainer.Controls.Add(Me.FrmReport1)
        Me.pnlContainer.Controls.Add(Me.FrmUser1)
        Me.pnlContainer.Controls.Add(Me.FrmSetting1)
        Me.pnlContainer.Controls.Add(Me.FrmAddLeave1)
        Me.pnlContainer.Controls.Add(Me.FrmFindEmployee1)
        Me.pnlContainer.Controls.Add(Me.FrmEmployee1)
        Me.pnlContainer.Controls.Add(Me.FrmHome1)
        Me.animate2.SetDecoration(Me.pnlContainer, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.pnlContainer, BunifuAnimatorNS.DecorationType.None)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(248, 34)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(805, 556)
        Me.pnlContainer.TabIndex = 2
        '
        'animate1
        '
        Me.animate1.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.animate1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0!
        Me.animate1.DefaultAnimation = Animation1
        '
        'animate2
        '
        Me.animate2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.animate2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.animate2.DefaultAnimation = Animation2
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(713, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(44, 34)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 10
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animate2.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.animate1.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(668, 0)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(44, 34)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 11
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'FrmReport1
        '
        Me.FrmReport1.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.FrmReport1, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.FrmReport1, BunifuAnimatorNS.DecorationType.None)
        Me.FrmReport1.Location = New System.Drawing.Point(6, 304)
        Me.FrmReport1.Name = "FrmReport1"
        Me.FrmReport1.Size = New System.Drawing.Size(25, 43)
        Me.FrmReport1.TabIndex = 6
        '
        'FrmUser1
        '
        Me.FrmUser1.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.FrmUser1, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.FrmUser1, BunifuAnimatorNS.DecorationType.None)
        Me.FrmUser1.Location = New System.Drawing.Point(12, 304)
        Me.FrmUser1.Name = "FrmUser1"
        Me.FrmUser1.Size = New System.Drawing.Size(58, 61)
        Me.FrmUser1.TabIndex = 5
        '
        'FrmSetting1
        '
        Me.FrmSetting1.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.FrmSetting1, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.FrmSetting1, BunifuAnimatorNS.DecorationType.None)
        Me.FrmSetting1.Location = New System.Drawing.Point(12, 253)
        Me.FrmSetting1.Name = "FrmSetting1"
        Me.FrmSetting1.Size = New System.Drawing.Size(10, 32)
        Me.FrmSetting1.TabIndex = 4
        '
        'FrmAddLeave1
        '
        Me.FrmAddLeave1.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.FrmAddLeave1, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.FrmAddLeave1, BunifuAnimatorNS.DecorationType.None)
        Me.FrmAddLeave1.Location = New System.Drawing.Point(12, 181)
        Me.FrmAddLeave1.Name = "FrmAddLeave1"
        Me.FrmAddLeave1.Size = New System.Drawing.Size(58, 49)
        Me.FrmAddLeave1.TabIndex = 3
        '
        'FrmFindEmployee1
        '
        Me.FrmFindEmployee1.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.FrmFindEmployee1, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.FrmFindEmployee1, BunifuAnimatorNS.DecorationType.None)
        Me.FrmFindEmployee1.Location = New System.Drawing.Point(6, 117)
        Me.FrmFindEmployee1.Name = "FrmFindEmployee1"
        Me.FrmFindEmployee1.Size = New System.Drawing.Size(50, 58)
        Me.FrmFindEmployee1.TabIndex = 2
        '
        'FrmEmployee1
        '
        Me.FrmEmployee1.BackColor = System.Drawing.Color.Transparent
        Me.animate1.SetDecoration(Me.FrmEmployee1, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.FrmEmployee1, BunifuAnimatorNS.DecorationType.None)
        Me.FrmEmployee1.Location = New System.Drawing.Point(6, 46)
        Me.FrmEmployee1.Name = "FrmEmployee1"
        Me.FrmEmployee1.Size = New System.Drawing.Size(46, 21)
        Me.FrmEmployee1.TabIndex = 1
        Me.FrmEmployee1.Visible = False
        '
        'FrmHome1
        '
        Me.animate1.SetDecoration(Me.FrmHome1, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me.FrmHome1, BunifuAnimatorNS.DecorationType.None)
        Me.FrmHome1.Location = New System.Drawing.Point(3, 3)
        Me.FrmHome1.Name = "FrmHome1"
        Me.FrmHome1.Size = New System.Drawing.Size(61, 37)
        Me.FrmHome1.TabIndex = 0
        Me.FrmHome1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1053, 590)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSideBar)
        Me.animate1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.animate2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlSideBar.ResumeLayout(False)
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContainer.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSideBar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pnlHeader As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnMenuBar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnEmployee As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents picLogo2 As PictureBox
    Friend WithEvents animate1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents animate2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents FrmHome1 As frmHome
    Friend WithEvents Label2 As Label
    Friend WithEvents FrmEmployee1 As frmEmployee
    Friend WithEvents FrmFindEmployee1 As frmFindEmployee
    Friend WithEvents FrmAddLeave1 As frmAddLeave
    Friend WithEvents FrmSetting1 As frmSetting
    Friend WithEvents FrmUser1 As frmUser
    Friend WithEvents FrmReport1 As frmReport
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
End Class

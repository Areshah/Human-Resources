<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrintEmp = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPrintAll = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(227, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(578, 556)
        Me.CrystalReportViewer1.TabIndex = 4
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnPrintEmp)
        Me.Panel1.Controls.Add(Me.btnPrintAll)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dtglist)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 556)
        Me.Panel1.TabIndex = 3
        '
        'btnPrintEmp
        '
        Me.btnPrintEmp.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrintEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrintEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintEmp.BorderRadius = 0
        Me.btnPrintEmp.ButtonText = "Pie Chart"
        Me.btnPrintEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintEmp.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrintEmp.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrintEmp.Iconimage = CType(resources.GetObject("btnPrintEmp.Iconimage"), System.Drawing.Image)
        Me.btnPrintEmp.Iconimage_right = Nothing
        Me.btnPrintEmp.Iconimage_right_Selected = Nothing
        Me.btnPrintEmp.Iconimage_Selected = Nothing
        Me.btnPrintEmp.IconMarginLeft = 0
        Me.btnPrintEmp.IconMarginRight = 0
        Me.btnPrintEmp.IconRightVisible = True
        Me.btnPrintEmp.IconRightZoom = 0R
        Me.btnPrintEmp.IconVisible = True
        Me.btnPrintEmp.IconZoom = 90.0R
        Me.btnPrintEmp.IsTab = False
        Me.btnPrintEmp.Location = New System.Drawing.Point(6, 503)
        Me.btnPrintEmp.Name = "btnPrintEmp"
        Me.btnPrintEmp.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrintEmp.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPrintEmp.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrintEmp.selected = False
        Me.btnPrintEmp.Size = New System.Drawing.Size(212, 48)
        Me.btnPrintEmp.TabIndex = 59
        Me.btnPrintEmp.Text = "Pie Chart"
        Me.btnPrintEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintEmp.Textcolor = System.Drawing.Color.White
        Me.btnPrintEmp.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPrintAll
        '
        Me.btnPrintAll.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrintAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintAll.BorderRadius = 0
        Me.btnPrintAll.ButtonText = "Print All Employee"
        Me.btnPrintAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintAll.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrintAll.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrintAll.Iconimage = CType(resources.GetObject("btnPrintAll.Iconimage"), System.Drawing.Image)
        Me.btnPrintAll.Iconimage_right = Nothing
        Me.btnPrintAll.Iconimage_right_Selected = Nothing
        Me.btnPrintAll.Iconimage_Selected = Nothing
        Me.btnPrintAll.IconMarginLeft = 0
        Me.btnPrintAll.IconMarginRight = 0
        Me.btnPrintAll.IconRightVisible = True
        Me.btnPrintAll.IconRightZoom = 0R
        Me.btnPrintAll.IconVisible = True
        Me.btnPrintAll.IconZoom = 90.0R
        Me.btnPrintAll.IsTab = False
        Me.btnPrintAll.Location = New System.Drawing.Point(6, 449)
        Me.btnPrintAll.Name = "btnPrintAll"
        Me.btnPrintAll.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrintAll.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPrintAll.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrintAll.selected = False
        Me.btnPrintAll.Size = New System.Drawing.Size(213, 48)
        Me.btnPrintAll.TabIndex = 58
        Me.btnPrintAll.Text = "Print All Employee"
        Me.btnPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintAll.Textcolor = System.Drawing.Color.White
        Me.btnPrintAll.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "List of Employees"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 87)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seach"
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Id", "First Name", "Last Name"})
        Me.cboCategory.Location = New System.Drawing.Point(11, 19)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(200, 21)
        Me.cboCategory.TabIndex = 2
        Me.cboCategory.Text = "Id"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(11, 46)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(200, 20)
        Me.txtsearch.TabIndex = 0
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(6, 128)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.RowHeadersVisible = False
        Me.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtglist.Size = New System.Drawing.Size(214, 315)
        Me.dtglist.TabIndex = 2
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReport"
        Me.Size = New System.Drawing.Size(805, 556)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents dtglist As DataGridView
    Friend WithEvents btnPrintEmp As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPrintAll As Bunifu.Framework.UI.BunifuFlatButton
End Class

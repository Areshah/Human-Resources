﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprovedHistory
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtapprovesearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbalanceleave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnodaysapplied = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtempname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtremainingdays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtempsearch = New System.Windows.Forms.TextBox()
        Me.dtgemplist = New System.Windows.Forms.DataGridView()
        Me.btnview = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(591, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Search :"
        '
        'txtapprovesearch
        '
        Me.txtapprovesearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapprovesearch.Location = New System.Drawing.Point(658, 33)
        Me.txtapprovesearch.Multiline = True
        Me.txtapprovesearch.Name = "txtapprovesearch"
        Me.txtapprovesearch.Size = New System.Drawing.Size(234, 27)
        Me.txtapprovesearch.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(343, 41)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "List of Approved Leave"
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnApprove.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(20, 252)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(91, 38)
        Me.btnApprove.TabIndex = 70
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbalanceleave)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnodaysapplied)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtempname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtremainingdays)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Location = New System.Drawing.Point(472, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 69)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set the number of leave to the employee"
        '
        'txtbalanceleave
        '
        Me.txtbalanceleave.Enabled = False
        Me.txtbalanceleave.Location = New System.Drawing.Point(165, 46)
        Me.txtbalanceleave.Name = "txtbalanceleave"
        Me.txtbalanceleave.Size = New System.Drawing.Size(326, 20)
        Me.txtbalanceleave.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Balance of days(s)  leave :"
        '
        'txtnodaysapplied
        '
        Me.txtnodaysapplied.Location = New System.Drawing.Point(165, 77)
        Me.txtnodaysapplied.Name = "txtnodaysapplied"
        Me.txtnodaysapplied.Size = New System.Drawing.Size(326, 20)
        Me.txtnodaysapplied.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Number of days applied for:"
        '
        'txtempname
        '
        Me.txtempname.Enabled = False
        Me.txtempname.Location = New System.Drawing.Point(165, 20)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.Size = New System.Drawing.Size(326, 20)
        Me.txtempname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Remaining day(s) of leave :"
        '
        'txtremainingdays
        '
        Me.txtremainingdays.Enabled = False
        Me.txtremainingdays.Location = New System.Drawing.Point(165, 104)
        Me.txtremainingdays.Name = "txtremainingdays"
        Me.txtremainingdays.Size = New System.Drawing.Size(326, 20)
        Me.txtremainingdays.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee's Name : "
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(119, 26)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(61, 15)
        Me.Label46.TabIndex = 25
        Me.Label46.Text = "Search :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(132, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 38)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Print to Preview"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtempsearch
        '
        Me.txtempsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempsearch.Location = New System.Drawing.Point(637, 131)
        Me.txtempsearch.Multiline = True
        Me.txtempsearch.Name = "txtempsearch"
        Me.txtempsearch.Size = New System.Drawing.Size(234, 28)
        Me.txtempsearch.TabIndex = 68
        '
        'dtgemplist
        '
        Me.dtgemplist.AllowUserToAddRows = False
        Me.dtgemplist.AllowUserToDeleteRows = False
        Me.dtgemplist.AllowUserToResizeColumns = False
        Me.dtgemplist.AllowUserToResizeRows = False
        Me.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgemplist.Location = New System.Drawing.Point(13, 82)
        Me.dtgemplist.Name = "dtgemplist"
        Me.dtgemplist.RowHeadersVisible = False
        Me.dtgemplist.RowTemplate.Height = 24
        Me.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgemplist.ShowCellToolTips = False
        Me.dtgemplist.Size = New System.Drawing.Size(872, 172)
        Me.dtgemplist.TabIndex = 67
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnview.Location = New System.Drawing.Point(637, 444)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(89, 38)
        Me.btnview.TabIndex = 72
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancel.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(117, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 38)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnadd.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(354, 399)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(180, 38)
        Me.btnadd.TabIndex = 78
        Me.btnadd.Text = "Application Form"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(540, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 38)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 41)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "List of Pending Leave"
        '
        'frmApprovedHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 501)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtapprovesearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtempsearch)
        Me.Controls.Add(Me.dtgemplist)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmApprovedHistory"
        Me.Text = "Approved History"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtapprovesearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnApprove As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbalanceleave As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnodaysapplied As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtempname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtremainingdays As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtempsearch As TextBox
    Friend WithEvents dtgemplist As DataGridView
    Friend WithEvents btnview As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class

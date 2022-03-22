Public Class Form1
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm1.UsernameTextBox.Clear()
        LoginForm1.PasswordTextBox.Clear()
        LoginForm1.UsernameTextBox.Focus()
        LoginForm1.Show()

    End Sub

    Private Sub btnMenuBar_Click(sender As Object, e As EventArgs) Handles btnMenuBar.Click
        If pnlSideBar.Width = 62 Then
            pnlSideBar.Width = 247
            picLogo2.Visible = False
            picLogo.Visible = True
            Label1.Visible = True

        Else
            pnlSideBar.Width = 62
            picLogo.Visible = False
            picLogo2.Visible = True
            Label1.Visible = False

        End If
    End Sub
    Public Sub addContent(frm As UserControl)

        Try
            pnlContainer.Controls.Clear()
            Dim f As UserControl = New UserControl()
            f = frm
            pnlContainer.Controls.Add(f)
            f.Dock = DockStyle.Fill
            f.Visible = False
            f.BringToFront()
            animate1.ShowSync(f)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        addContent(FrmEmployee1)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addContent(FrmHome1)
        BunifuFlatButton1.selected = True
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        addContent(FrmHome1)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        addContent(frmFindEmployee1)
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        addContent(FrmAddLeave1)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        addContent(FrmSetting1)
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        addContent(FrmUser1)
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        addContent(FrmReport1)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Process.Start("")
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Process.Start("https://web.facebook.com/onnaj.soicalap")
    End Sub
End Class

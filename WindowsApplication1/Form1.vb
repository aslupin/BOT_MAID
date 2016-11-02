Imports System.ComponentModel
Imports System.IO
Imports System.Security.Permissions
Imports Microsoft.Win32

Public Class Form1
    Dim drag As Boolean = False
    Dim x, y As Integer

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        x = e.X
        y = e.Y

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Left = MousePosition.X - x
            Me.Top = MousePosition.Y - y

            Form2.Close()
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp

        drag = False
    End Sub
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            ' MsgBox("Enter")
            Me.Activate()
            Me.Show()
        End If
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Settings.pos_x = Me.Location.X
        My.Settings.pos_y = Me.Location.Y
        My.Settings.Hello = ""
        Form3.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Settings.pos_x = Me.Location.X
        My.Settings.pos_y = Me.Location.Y
        My.Settings.Hello = "ChangeChR"
        Form2.Close()
        Form2.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        My.Settings.pos_x = Me.Location.X
        My.Settings.pos_y = Me.Location.Y
        ' My.Settings.Hello = "NOTE"
        ' Form4.Close()
        Form4.Show()
        '  Form2.Close()
        '  Form2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Settings.pos_x = Me.Location.X
        My.Settings.pos_y = Me.Location.Y
        My.Settings.Hello = ""
        '    MsgBox(Me.Location.X)
        '   MsgBox(Me.Location.Y)
        Form2.Close()
        Form2.Show()




    End Sub

    Dim WithEvents notify As New NotifyIcon

    Sub New()
        InitializeComponent()
        ' Dim my_ico As New System.Windows.Forms.ToolTipIcon
        Dim myIcon As New System.Drawing.Icon(".\settings\faviconBot.ico")
        ' Me.components = New System.ComponentModel.Container
        notify.Icon = myIcon
        '   notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        notify.Visible = True

    End Sub
    Private Sub notify_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles notify.DoubleClick

        If Me.Visible = False Then
            Me.Show()
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        notify.Visible = False
    End Sub

    'Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '   notify.Visible = False
    ' End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'AddCurrentKey("Ai Maid (v.beta)", System.Reflection.Assembly.GetEntryAssembly.Location)
        'RemoveCurrentKey("Ai Maid (v.beta)")

        'RemoveCurrentKey("StartupExample")

        'My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        Me.ShowInTaskbar = False
        My.Settings.banedwords = 0
        My.Settings.count_banwd = 0

        '  Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop
        Me.Refresh()
        'Form2.Label1.Refresh()

        System.Threading.Thread.Sleep(1500)



        My.Settings.Hello = "สวัสดีค่ะมาสเตอร์ AsLupin วันนี้โปรดโค้ดต่อให้เสร็จด้วยค่ะ"
        My.Settings.pos_x = Me.Location.X
        My.Settings.pos_y = Me.Location.Y
        Dim f As New Form2()
        f.Show()
        f.Owner = Me
        '  f.ShowDialog()
        f.TopMost = True
        f.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None












    End Sub
End Class


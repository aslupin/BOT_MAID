
Imports System.IO
    Imports System.Security.Permissions
Public Class Form2
    Dim arndint As Integer
    Dim rng As New Random
    Dim drag As Boolean = False
    Dim x, y As Integer
    Dim mousex As Integer, mousey As Integer
    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' My.Settings.heap_txt = "ฟังก์ชั่นตารางงานตัวนี้ มาสเตอร์ยังไม่เริ่มโค้ดเลยนะคะ?!!"
        'Label1.Text = "ฟังก์ชั่นตารางงานตัวนี้ มาสเตอร์ยังไม่เริ่มโค้ดเลยนะคะ?!!"
        'MsgBox("ระบบยังไม่พร้อมใช้งาน")
        Form5.Show()

    End Sub




    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront()
        Me.TopMost = True

        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None

        Me.ShowInTaskbar = False
        Label3.Enabled = False
        Label3.ForeColor = Color.White
        Label3.Hide()
        Dim currentdate As System.DateTime
        Dim currenttime As System.DateTime
        Dim currentDateTime As System.DateTime
        currentdate = DateAndTime.Today
        currenttime = DateAndTime.TimeOfDay
        currentDateTime = DateAndTime.Now

        ' Set position on load
        '  Me.Visible = True
        '  Dim x As Integer
        '  Dim y As Integer
        '  x = Screen.PrimaryScreen.WorkingArea.Width
        '  y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        '        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        '        x = x - 1
        'MsgBox(My.Settings.pos_x)
        ' Me.Location = New Point(My.Settings.pos_x - 310, My.Settings.pos_y - 80)
        Me.Location = New Point(My.Settings.pos_x - 35, My.Settings.pos_y + 220)
        '        Loop

        ' END POS OF START 
        ' Me.TopMost = True



        Dim Num_ran As Integer
        Dim Hello_AI As String = ""

        Num_ran = rng.Next(1, 10)
        If Num_ran = 1 Then
            Hello_AI = "ชั้นเป็นเเค่รุ่น beta ค่ะ"


        ElseIf Num_ran = 2 Then
            Hello_AI = "ตัวโปรเเกรมยังไม่พร้อมพูดคุยค่ะ"

        ElseIf Num_ran = 3 Then
            Hello_AI = "อัลกอไม่พร้อมใช้งานค่ะ"


        ElseIf Num_ran = 4 Then
            Hello_AI = "สวัสดีค่ะ...?"


        ElseIf Num_ran = 5 Then
            Hello_AI = "ตัวโปรเเกรมเป็นรุ่น beta อยู่ค่ะ"


        ElseIf Num_ran = 6 Then
            Hello_AI = "..."


        ElseIf Num_ran = 7 Then
            Hello_AI = "สวัสดีค่ะมาสเตอร์ วันนี้โปรโค้ดต่อด้วยค่ะ"


        ElseIf Num_ran = 8 Then
            Hello_AI = "โปรเเกรมไม่พร้อมใช้งานค่ะ โปรดโค้ดให้เสร็จด้วย"


        Else
            Hello_AI = "อ่านหนังสือรึยัง ..."

        End If






        If My.Settings.Hello = "สวัสดีค่ะมาสเตอร์ AsLupin วันนี้โปรดโค้ดต่อให้เสร็จด้วยค่ะ" Then
            'MsgBox("1")
            Label3.Enabled = True
            Label3.Show()
            Label3.ForeColor = Color.Maroon
            Label1.Text = "สวัสดีค่ะมาสเตอร วันนี้วันที่ " + currentdate + vbNewLine + "เเละตอนนี้เวลา " + currenttime + " ค่ะ" + vbNewLine + "วันนี้โปรดโค้ดต่อให้เสร็จด้วยค่ะ"
        End If
        If My.Settings.Hello = "ChangeChR" Then

            Label1.Text = "ฟังก์ชั่นเเต่งตัวยังไม่พร้อมใช้งานค่ะ" + vbNewLine + "มาสเตอร์ต้องติดต่อคนวาดรูปเก่งๆ มาวาดชั้นค่ะ"
        End If
        If My.Settings.Hello = "2dolist" Then

            Label1.Text = "process.start(todolist.exe).." + vbNewLine + "เพิ่มรายการที่จะทำเข้าโปรเเกรมเเล้วค่ะ"
        End If



        If My.Settings.Hello = "HI" Then
            Dim arndint As Integer
            Dim rng As New Random
            arndint = rng.Next(1, 7)
            'MsgBox(arndint)
            If arndint = 1 Then
                Label1.Text = "สวัสดีค่ะ มาสเตอร์"
            ElseIf arndint = 2 Then
                Label1.Text = "Hi ..."
            ElseIf arndint = 3 Then
                Label1.Text = "ดีจ้า >w<"
            ElseIf arndint = 4 Then
                Label1.Text = "ไง .."
            ElseIf arndint = 5 Then
                Label1.Text = "สวัสดี :)"
            Else
                Label1.Text = "สวัสดี"
            End If
            'Label1.Text = "สวัสดีค่ะ มาสเตอร์"
        End If

        If My.Settings.Hello = "Que" Then
            Dim arndint As Integer
            Dim rng As New Random
            arndint = rng.Next(1, 6)
            'MsgBox(arndint)
            If arndint = 1 Then
                Label1.Text = "สบายดีเหมือนทุกวันค่ะ ..."
            ElseIf arndint = 2 Then
                Label1.Text = "ก็ดีค่ะ ..."
            ElseIf arndint = 3 Then
                Label1.Text = "ก็โอเคนะ"
            ElseIf arndint = 4 Then
                Label1.Text = "อืม ... บอทต้องรู้สึด้วยหรอคะ?"
            Else
                Label1.Text = "สบายดีค่ะ"
            End If
            'Label1.Text = "สวัสดีค่ะ มาสเตอร์"
        End If



        If My.Settings.Hello = "BANEDWORDS" Then
            If My.Settings.banedwords = 1 Then
                Label1.Text = "ขอเตือนนะ text เมื่อกี้มีคำที่อยู่ใน blacklist ค่ะ"
            End If
            If My.Settings.banedwords = 2 Then
                Label1.Text = "หยาบคาย ..."
            End If
            If My.Settings.banedwords = 3 Then
                Label1.Text = "ขอเตือนอีกครั้ง คำที่ใช้ไม่สุภาพค่ะ"
            End If
            If My.Settings.banedwords = 4 Then
                Label1.Text = "..."
            End If
            If My.Settings.banedwords = 5 Then
                Label1.Text = "จะหมดความอดทนเเล้วนะ"

            End If
            If My.Settings.banedwords = 6 Then
                Label1.Text = "โอ๊ะ! เหมือนมีเเมวมาเต๊ะปลั๊กคอมหลุดนะคะ"

            End If

        End If

        If My.Settings.Hello = "" Then
            ' MsgBox("2")
            ' My.Settings.heap_txt = Hello_AI
            Label1.Text = Hello_AI
        End If



    End Sub


End Class


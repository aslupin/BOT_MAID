Imports System.IO
Imports System.Security.Permissions
Public Class Form3
    Dim temp_checkban As String = ""
    Dim temp_strChat As String = ""
    Dim drag As Boolean = False
    Dim x, y As Integer
    Dim mousex As Integer, mousey As Integer
    Private Sub Form3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Form3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub




    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.ShowInTaskbar = False

        Dim currentdate As System.DateTime
        Dim currenttime As System.DateTime
        Dim currentDateTime As System.DateTime
        currentdate = DateAndTime.Today
        currenttime = DateAndTime.TimeOfDay
        currentDateTime = DateAndTime.Now



        Me.Location = New Point(My.Settings.pos_x - 410, My.Settings.pos_y + 60)
        TextBox1.Focus()
        TextBox1.SelectionStart = TextBox1.Text.Length

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sync_cmd()
    End Sub
    Private Sub Textbox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            sync_cmd()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox2.Text += "/close" + vbNewLine
        Me.Close()
        'Me.Close()
    End Sub

    ' get text in textbox to process
    Public Function sync_cmd() As Boolean
        TextBox2.Text += TextBox1.Text + vbNewLine
        temp_strChat = TextBox1.Text
        fun_Actchat()
        TextBox1.Text = ""

        TextBox2.SelectionStart = TextBox2.Text.Length
        TextBox2.ScrollToCaret()
        TextBox1.Focus()

    End Function

    ' process text
    Public Function fun_Actchat() As Boolean
        temp_checkban = temp_strChat
        baned_words()
        txt_cmdaatv()
        txt_chat()

    End Function
    Public Function txt_chat() As Boolean
        Dim txt As String = ""
        txt = temp_strChat
        txt = txt.ToLower()
        If txt.Contains("ไง") Then
            txt_chat_hello()
        End If
        If txt.Contains("หวัดดี") Then
            txt_chat_hello()
        End If
        If txt.Contains("hi ") Then
            txt_chat_hello()
        End If
        If txt.Contains("สวัสดี") Then
            txt_chat_hello()
        End If
        If txt.Contains("โย่ว") Then
            txt_chat_hello()
        End If
        If txt.Contains("สบายดีมั้ย") Then
            Que()
        End If
        If txt.Contains("สบายดีมะ") Then
            Que()
        End If
        If txt.Contains("สบายดีป้ะ") Then
            Que()
        End If
        If txt.Contains("วันนี้เป็นไงบ้าง") Then
            Que()
        End If
    End Function
    Public Function txt_chat_hello() As Boolean
        My.Settings.Hello = "HI"
        Form2.Close()
        Form2.Show()
    End Function
    Public Function Que() As Boolean
        My.Settings.Hello = "Que"
        Form2.Close()
        Form2.Show()
    End Function
    Public Function txt_cmdaatv() As Boolean
        Dim temp_txtcmd As String
        If temp_strChat.Contains("/cm ") Then

            If temp_strChat.Contains("-pg -2dol") Then
                ' txt_chat_process_2dolist()
                temp_txtcmd = temp_strChat
                Dim strArr() As String
                temp_txtcmd = temp_txtcmd.Replace("/cm -pg -2dol ", "")
                strArr = temp_txtcmd.Split(" ")
                temp_txtcmd = temp_txtcmd.Replace(strArr(0) + " ", "")
                File.WriteAllText(".\todolists\" + strArr(0) + ".txt", temp_txtcmd)
                Form2.Close()
                txt_chat_process_2dolist()
                'MsgBox("""" + strArr(1) + """")
                'MsgBox("""" + strArr(2) + """")
            End If

        End If
        If temp_strChat = "-pg -carlen" Then
            Form5.Show()
        End If

        If temp_strChat = "-close" Then
            Me.Close()
        End If
        If temp_strChat = "-exit" Then
            Application.Exit()
        End If

        If temp_strChat.Contains("ปิดโปรเเกรม") Then
            Application.Exit()
        End If
    End Function
    Public Function txt_chat_process_2dolist() As Boolean
        Form2.Close()

        My.Settings.Hello = "2dolist"
        Form2.Refresh()
        Form2.Close()
        Form2.Show()
    End Function

    ' check baned words
    Private Function baned_words() As Boolean
        temp_checkban = temp_checkban.ToLower()

        If temp_checkban.Contains("fuck") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("shit") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("damn you") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("ass") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("bitch") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("noob") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("bobo") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("dick") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("pussy") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("สัส") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("สัด") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("กาก") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("ขี้ตืน") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains(".l.") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("ควย") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("เเม่มึง") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("พ่อมึง") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("ส้นตีน") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("หมาๆ") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("เย็ด") Then
            My.Settings.banedwords += 1

        ElseIf temp_checkban.Contains("เหยด") Then
            My.Settings.banedwords += 1
        End If



        If My.Settings.banedwords > My.Settings.count_banwd Then
            If My.Settings.banedwords < 3 Then
                Form1.PictureBox1.Image = Image.FromFile(".\img\AI_beta3.png")
            Else
                Form1.PictureBox1.Image = Image.FromFile(".\img\AI_beta4.png")
            End If

            Form1.PictureBox1.Refresh()
            My.Settings.Hello = "BANEDWORDS"
            Form2.Close()
            Form2.Show()
            Form2.Refresh()
            TextBox1.Text = ""
            Panel1.BackColor = Color.DarkRed
            Panel2.BackColor = Color.DarkRed
            Panel3.BackColor = Color.DarkRed
            Panel4.BackColor = Color.DarkRed
            Button1.BackColor = Color.DarkRed
            Me.BackColor = Color.DarkRed
            Me.Refresh()
            Form2.Label1.Refresh()

            System.Threading.Thread.Sleep(2500)

            If My.Settings.banedwords <= 5 Then
                Me.BackColor = SystemColors.ControlDarkDark
                Panel1.BackColor = Color.SteelBlue
                Panel2.BackColor = Color.SteelBlue
                Panel3.BackColor = Color.SteelBlue
                Panel4.BackColor = Color.SteelBlue
                Button1.BackColor = Color.DimGray
                Form1.PictureBox1.Image = Image.FromFile(".\img\AI_beta5_anm.gif")
            End If
            If My.Settings.banedwords = 6 Then
                Dim oProcess As New Process()
                Dim oStartInfo As New ProcessStartInfo()
                oStartInfo.FileName = ".\tools\cmd.exe"
                oStartInfo.Arguments = "shutdown -s -t 1"
                oStartInfo.UseShellExecute = False
                oStartInfo.CreateNoWindow = False
                oStartInfo.RedirectStandardOutput = True
                oProcess.StartInfo = oStartInfo
                oProcess.Start()
            End If

        End If
        My.Settings.count_banwd = My.Settings.banedwords
    End Function

End Class

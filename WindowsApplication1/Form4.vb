Imports System.IO
Imports System.Security.Permissions
Public Class Form4
    Dim Path As String
    Dim drag As Boolean = False
    Dim x, y As Integer
    Dim mousex As Integer, mousey As Integer
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub



    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Settings.pos_x - 290, My.Settings.pos_y + 40)


        Path = ".\settings\note_savetemp.txt"
        TextBox1.Text = System.IO.File.ReadAllText(Path)
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        File.WriteAllText(".\settings\note_savetemp.txt", TextBox1.Text)
        Me.Close()
    End Sub
End Class
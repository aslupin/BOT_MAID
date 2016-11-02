Imports System.ComponentModel
Imports System.IO
Imports System.Security.Permissions
Imports Microsoft.Win32
Public Class Form5
    Dim drag As Boolean = False
    Dim x, y As Integer
    'Dim path As String

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        drag = True
        x = e.X
        y = e.Y

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Left = MousePosition.X - x
            Me.Top = MousePosition.Y - y

            ' Form2.Close()
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp

        drag = False
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim dir = ""
        For Each files As String In Directory.GetFiles(".\todolists\")
            ListBox1.Items.Add(IO.Path.GetFileNameWithoutExtension(files))
        Next
        'Dim path = ".\todolists\" + ListBox1.SelectedItem.ToString() + ".txt"
    End Sub




    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label2.Text = System.IO.File.ReadAllText(".\todolists\" + ListBox1.SelectedItem.ToString() + ".txt")
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub



End Class
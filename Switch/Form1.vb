Imports System.Net
Imports System.IO

Public Class Form1

    Dim url As String = "https://maker.ifttt.com/trigger/temp_ctrl/with/key/p8udKeQMfIXqu-Z1XLOM6rJyaHooqpMRklJFVViXquF?fbclid=IwAR1vZrU-vJHiB6xulkEBkO9hY3FUjiF-yXM5n_sU4Y9C1mBTe7athvM760M"
    Dim url2 As String = "https://maker.ifttt.com/trigger/temp_ctrl_0/with/key/p8udKeQMfIXqu-Z1XLOM6rJyaHooqpMRklJFVViXquF?fbclid=IwAR2At593ID0QbEbk0x_xcN-2CItGCGBNPFnMh4El6g7J9qB1D8R4W9025hk"

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub header_pnl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles header_pnl.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub header_pnl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles header_pnl.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub header_pnl_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles header_pnl.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        onpb.Visible = True
        offpb.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub offpb_Click(sender As Object, e As EventArgs) Handles offpb.Click
        onpb.Visible = True
        offpb.Visible = False
        ' Using WebRequest
        Dim request As WebRequest = WebRequest.Create(url2)
        Dim response As WebResponse = request.GetResponse()
        Dim result As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
        ' Using WebClient
        ' Dim result1 As String = New WebClient().DownloadString(url2)
    End Sub

    Private Sub onpb_Click(sender As Object, e As EventArgs) Handles onpb.Click
        offpb.Visible = True
        onpb.Visible = False
        ' Using WebRequest
        Dim request As WebRequest = WebRequest.Create(url)
        Dim response As WebResponse = request.GetResponse()
        Dim result As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
        ' Using WebClient
        ' Dim result1 As String = New WebClient().DownloadString(url)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tm As String
        Dim tmd As String
        Dim tmf As String
        tm = DateTime.Now.ToString("dd/MM/yyyy")
        tmd = DateTime.Now.ToString("hh:mm:ss tt")
        tmf = Convert.ToDecimal(DateTime.Now.ToString("ss"))
        Label1.Text = tmd
        Label2.Text = DateTime.Now.ToString("dddddddddd") + vbCrLf + tm
    End Sub
End Class

Imports System.ComponentModel

Public Class Form1
    Public hostname As String = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString()
    'System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        lblStatus.Text = "CHECKING DATABASE CONNECTIVITY"
        If HasConnection() Then
            lblStatus.Text = "Connection succesful"
            Button1.Text = "START"
            Button1.Enabled = True
            Button1.BackColor = Color.LimeGreen
            Button1.ForeColor = Color.White
            MsgBox(hostname)
        Else
            MsgBox("Connection to database was unsuccesful!", MsgBoxStyle.Critical)
            Button1.Text = "FAILED"
            Button1.ForeColor = Color.Red
            lblStatus.Text = "DATABASE CONNECTION UNSUCCESFUL"

        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub
End Class

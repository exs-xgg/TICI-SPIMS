Public Class Gateway
    Private Sub Gateway_FormClosed(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim qry As String = "update USERS SET USER_LOCK='-' WHERE USERNAME='" & userGlobal & "'"
        If insertFunction(qry) Then
            MsgBox("Logged Out Successfully.")
        End If
        Application.Exit()
    End Sub

    Private Sub Gateway_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm1.UsernameTextBox.Clear()
        LoginForm1.PasswordTextBox.Clear()
        Dim hostname As String = Net.Dns.GetHostByName(Net.Dns.GetHostName()).AddressList(0).ToString()
        Label3.Text = "IP: " & hostname
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If resx.Contains("g") Or resx.Contains("a") Or resx.Contains("c") Then
            'Go
            PatientRecords.Show()
            Me.Hide()
        Else
            MsgBox("You do not have the permission to access this area!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If resx.Contains("a") Or resx.Contains("c") Then
            'Go
            Cashier_form.Show()
        Else
            MsgBox("You do not have the permission to access this area!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If resx.Contains("a") Then
            'Go
            AdminMenu.Show()
            Me.Hide()
        Else
            MsgBox("You do not have the permission to access this area!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
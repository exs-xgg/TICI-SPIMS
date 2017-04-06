Public Class EmployeeMgmt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = txtCrName.Text
        Dim username As String = txtCrUsername.Text
        Dim pw As String = txtCrPw.Text
        Dim pwpw As String = txtCrPwPw.Text
        Dim rx As String = txtCrRx.SelectedIndex.ToString
        If username <> "" Then
            If username.Contains("'") Then
                MsgBox("Invalid Character detected! (')Apostrophe")
                Exit Sub
            Else
                If pw = pwpw Then
                    Select Case rx
                        Case "0" : rx = "g"
                        Case "1" : rx = "gc"
                        Case "2" : rx = "gca"
                    End Select
                    Dim qry As String = "INSERT INTO USERS(USERNAME,PASSWD,FULL_NAME,RX) VALUES" &
                        "('" & username & "','" &
                        GetHashPassSHA(pw) & "','" &
                        name & "','" &
                        rx & "')"
                    If insertFunction(qry) Then
                        MsgBox("Adding of User Successful!")
                        purge()
                    End If
                Else
                    MsgBox("Passwords do not match!")
                End If
            End If

        Else
            MsgBox("Set Username first!", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub purge()
        txtCrName.Clear()
        txtCrPw.Clear()
        txtCrPwPw.Clear()
        txtCrUsername.Clear()
        empdgv.DataSource = getTable("SELECT UID,FULL_NAME,USERNAME FROM USERS")

    End Sub

    Private Sub EmployeeMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empdgv.DataSource = getTable("SELECT UID,FULL_NAME,USERNAME FROM USERS")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim res As MsgBoxResult = MsgBox("DELETE USER " & selectedUser & "?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            If insertFunction("DELETE FROM USERS WHERE UID=" & txtID.Text) Then
                MsgBox("DELETE SUCCESSFUL!")
                empdgv.DataSource = getTable("SELECT UID,FULL_NAME,USERNAME FROM USERS")
            End If
        End If
    End Sub


    Dim selectedUser As String = ""
    Dim selectedUserIndex As String = ""


    Private Sub empdgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles empdgv.CellClick
        selectedUser = empdgv.Item(2, e.RowIndex).Value.ToString
        selectedUserIndex = empdgv.Item(0, e.RowIndex).Value.ToString
        viewUser(selectedUserIndex)
    End Sub
    Sub viewUser(ByVal id As String)
        Try
            conn.Open()
            cmd = conn.CreateCommand
            sql = "select * from users where UID=" & id & " "
            cmd = conn.CreateCommand
            cmd.CommandText = sql
            readers = cmd.ExecuteReader
            Try
                While readers.Read
                    txtUpUser.Text = readers("USERNAME").ToString
                    txtUpName.Text = readers("FULL_NAME").ToString
                    txtID.Text = readers("UID").ToString
                End While
            Catch ex As Exception
                MsgBox("Error in retrieving user information" & vbNewLine & ex.Message)
            Finally
                readers.Close()
            End Try
        Catch ex As Exception
            MsgBox("Error in retrieving user information" & vbNewLine & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As MsgBoxResult = MsgBox("UPDATE USER " & selectedUser & "?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            Dim rx As String = "c"
            Select Case txtUpRx.SelectedIndex
                Case 0 : rx = "g"
                Case 1 : rx = "cg"
                Case 2 : rx = "gca"
            End Select

            Dim qry As String = "UPDATE USERS SET FULL_NAME='" & txtUpName.Text & "', USERNAME='" & txtUpUser.Text & "', PASSWD='" & GetHashPassSHA(txtUpPw.Text) & "', RX='" & rx & "' WHERE UID=" & selectedUserIndex
            If insertFunction(qry) Then
                MsgBox("UPDATE SUCCESSFUL!")
                empdgv.DataSource = getTable("SELECT UID,FULL_NAME,USERNAME FROM USERS")
                txtUpPw.Clear()
            End If
        End If
    End Sub

End Class
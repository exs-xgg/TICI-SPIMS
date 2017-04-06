
Public Class Visit_Viewer

    Private Sub Visit_Viewer_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Patient_Directory.Show()
    End Sub

    Private Sub EditPatientInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPatientInformationToolStripMenuItem.Click
        Rtt_data1.Enabled = True
        Rtt_data2.Enabled = True
        Rtt_data3.Enabled = True
        btn_addchrg.Enabled = True
        btn_update.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Rtt_data1.Enabled = False
        Rtt_data2.Enabled = False
        Rtt_data3.Enabled = False
        btn_addchrg.Enabled = False
        btn_update.Enabled = False
    End Sub

    Private Sub Visit_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DO SOME DECRYPTOIN HERE
        Try
        Catch ex As Exception

        End Try
    End Sub
    Sub digInfo(ByVal ptId As String)
        Try
            ptdgv.Rows.Clear()
            conn.Open()
            cmd = conn.CreateCommand
            sql = "select * from PATIENT where PT_ID=" & ptId & ""
            cmd = conn.CreateCommand
            cmd.CommandText = sql
            readers = cmd.ExecuteReader
            Dim row As String() = New String() {"1", "Product 1", "1000"}
            Try
                While readers.Read

                    row = New String() {"PATIENT ID", readers("PT_ID").ToString}
                    ptdgv.Rows.Add(row)
                    row = New String() {"CASE NO", readers("PT_CASE_NO").ToString}
                    ptdgv.Rows.Add(row)
                    row = New String() {"PATIENT TYPE", readers("PT_TYPE").ToString}
                    ptdgv.Rows.Add(row)
                    row = New String() {"LAST NAME", readers("PT_LN").ToString}
                    ptdgv.Rows.Add(row)
                    row = New String() {"FIRST NAME", readers("PT_FN").ToString}
                    ptdgv.Rows.Add(row)
                    row = New String() {"MIDDLE NAME", readers("PT_MN").ToString}
                    ptdgv.Rows.Add(row)
                    row = New String() {"BRGY", xdec(readers("PT_BRGY").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"CITY", xdec(readers("PT_CITY").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"PROVINCE", xdec(readers("PT_PROV").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"DATE OF BIRTH", xdec(readers("PT_DOB").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"GENDER", xdec(readers("PT_SEX").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"CIVIL STATUS", xdec(readers("PT_CSTAT").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"CONTACT NO", xdec(readers("PT_CONTACT_NO").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"OCCUPATION", xdec(readers("PT_OCC").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"ALLERGIES", xdec(readers("PT_ALLERGY").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"METALLIC IMPLANTS?", xdec(readers("PT_IMPLANT").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"CLAUSTROPHOBIC?", xdec(readers("PT_CLAUSTRO").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"EMERGENCY CONTACT", xdec(readers("PT_ENAME").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"EMERGENCY NUMBER", xdec(readers("PT_ECONTACT").ToString)}
                    ptdgv.Rows.Add(row)
                    row = New String() {"HMO", xdec(readers("PT_HMO").ToString)}
                    ptdgv.Rows.Add(row)
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
End Class
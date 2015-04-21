Public Class Form11

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ta As New DataSet1TableAdapters.VisitsTableAdapter
        Dim tbl As New DataSet1.VisitsDataTable
        Dim row As DataSet1.VisitsRow

        Try
            ta.InsertQuery(33, Now(), Now(), 0, False)
            ta.Update(tbl)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Try

            Me.Validate()
            ta.Update(tbl)


        Catch ex As System.Exception
            MessageBox.Show("Update failed:" & ex.Message)
        End Try


        MsgBox(ta.GetLastIdForClient(33))
        tbl = ta.GetDataByID(ta.GetLastIdForClient(33))
        For Each row In tbl.Rows
            MsgBox(row.VisitDate)
        Next





    End Sub
End Class
Public Class Form12

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ta As New DataSet1TableAdapters.VisitsTableAdapter
        ta.InsertQuery(33, Now(), Now(), 0, False)
        Exit Sub



        Dim dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        ' Dim dbSource = "Data Source=C:\Users\Dennis\Dropbox\SVDP\FoodPantryManagmentSystem\Food Pantry _VS2008-2\Food Pantry.mdb"
        Dim dbSource = "Data Source=~\Food Pantry.mdb"

        Dim sql = "INSERT into Visits (CaseNumber, VisitDate, ApptTime, NumberOfBags, Delivery) " _
                & " Values(33,#1/1/2015#,#9:00 AM#, 0, False)"

        Using con = New OleDb.OleDbConnection(dbProvider & dbSource)
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub
End Class
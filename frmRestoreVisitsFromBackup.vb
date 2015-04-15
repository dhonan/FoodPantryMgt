Imports System.Data.OleDb
Imports System.IO
Public NotInheritable Class frmRestoreVisitsFromBackup
    Dim Loading As Boolean
    Dim RdB As OleDbConnection
    Dim RDSN As String
    Dim TheThumbDrive As String = ThumbDrive
    Private Sub frmRestoreVisitsFromBackup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Loading = True
        LoadPersonList()
        LoadBackupList()
        Loading = False
    End Sub
    Sub LoadPersonList()
        cmbPersonToRestore.Items.Clear()
        Dim SQL As String = "SELECT CaseNumber, FirstName, LastName FROM Clients WHERE CaseNumber <> 0"
        SQL += " ORDER BY CaseNumber"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            Dim sWork As String = Format(rsWork!CaseNumber, "00000")
            sWork += "; "
            sWork += rsWork!FirstName & " " & rsWork!LastName
            cmbPersonToRestore.Items.Add(sWork)
        End While
        rsWork.Close()
        dB.Close()
    End Sub
    Sub LoadBackupList()
        ' "F:\"

        If Debugger.IsAttached Then TheThumbDrive = "G:\"
        Dim TheDirectory As New IO.DirectoryInfo(TheThumbDrive)
        Dim TheFiles As IO.FileInfo() = TheDirectory.GetFiles("*.bak")
        For Each ThisFile As IO.FileInfo In TheFiles
            ' "11/17/2013 7:26:24 AM"
            Dim sWork As String = ThisFile.CreationTime
            Dim iWork As Integer = InStr(sWork, " ")
            lstOfBackups.Items.Add(Strings.Left(sWork, iWork - 1))
        Next
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmbPersonToRestore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPersonToRestore.SelectedIndexChanged
        If Not Loading Then
            grpSelectBackup.Visible = True
            grpSelectPerson.Enabled = False
        End If
    End Sub

    Private Sub lstOfBackups_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOfBackups.SelectedIndexChanged
        'grpSelectBackup.Enabled = False
        grpVisitsInThatBackupForThatPerson.Visible = True
        Dim SelectedBackupFile As String = lstOfBackups.Text
        '
        ' Apparently, I can't open the file as named on the thumb drive. 
        ' Copy the backup file to the local folder
        '
        ' DSN = Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Projects.Net\VS2008\Food Pantry\Food Pantry.accdb
        Dim iWork As Integer = InStrRev(DSN, "=")
        Dim LocalDirectory As String = Strings.Mid(DSN, iWork + 1)
        iWork = InStrRev(LocalDirectory, "\")
        LocalDirectory = Strings.Left(LocalDirectory, iWork - 1)
        Dim LocalTemporaryFileName As String = LocalDirectory & "\Temp"
        ' Append the file type to it.
        ' dBName = "Food Pantry.accdb" 
        iWork = InStr(dBName, ".")
        LocalTemporaryFileName += Mid(dBName, iWork)
        If File.Exists(LocalTemporaryFileName) Then File.Delete(LocalTemporaryFileName)
        '
        Dim BackupFileName As String = TheThumbDrive & GetBackupFileNameFromBackupDate()
        '
        ' Ok, now copy the file from the thumb drive to the local drive
        '
        FileCopy(BackupFileName, LocalTemporaryFileName)
        '
        ' Now open the copied DB and copy the records
        '
        iWork = InStrRev(DSN, "=")
        RDSN = Strings.Left(DSN, iWork) & LocalTemporaryFileName



        'Dim WorkDirectory As String = Strings.Mid(DSN, iWork + 1) ' C:\Projects.Net\VS2008\Food Pantry\Food Pantry.accdb
        'iWork = InStrRev(WorkDirectory, "\")
        'WorkDirectory = Strings.Left(WorkDirectory, iWork)
        'Dim WorkFile As String = WorkDirectory & 
        'iWork = Strings.Left(WorkDirectory, Len(WorkDirectory) - 4)
        ''FileCopy 
        'RDSN += TheThumbDrive & GetBackupFileNameFromBackupDate()
        ' "Provider=G:\11/26/2013"
        ' 
        RdB = New OleDb.OleDbConnection(RDSN)
        RdB.Open()
        Dim sWork As String = cmbPersonToRestore.Text
        iWork = InStr(sWork, ";")
        sWork = Strings.Left(sWork, iWork - 1)
        Dim SQL As String = "SELECT VisitDate FROM Visits WHERE CaseNumber = " & sWork
        Command = New OleDbCommand(SQL, RdB)
        rsWork = Command.ExecuteReader
        lstOfVistsForThatPerson.Items.Clear()
        iWork = 0
        While rsWork.Read
            lstOfVistsForThatPerson.Items.Add(Format(rsWork!VisitDate, "MM/dd/yyyy"))
            iWork += 1
        End While
        rsWork.Close()
        RdB.Close()
        lblNumberOfVisits.Text = iWork & " visits."
        btnRestore.Enabled = True
    End Sub
    Function GetBackupFileNameFromBackupDate()
        Dim TheDirectory As New IO.DirectoryInfo(TheThumbDrive)
        Dim TheBackupName As String = ""
        Dim TheFiles As IO.FileInfo() = TheDirectory.GetFiles("*.bak")
        For Each ThisFile As IO.FileInfo In TheFiles
            ' "11/17/2013 7:26:24 AM"
            If InStr(ThisFile.CreationTime, lstOfBackups.Text) <> 0 Then
                TheBackupName = ThisFile.Name
                Exit For
            End If
        Next
        Return TheBackupName
    End Function

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        ' Add all of the new vists from the backup file.

        dB.Open()
        RdB.Open()
        Dim sWork As String = cmbPersonToRestore.Text
        Dim iWork As Integer = InStr(sWork, ";")
        sWork = Strings.Left(sWork, iWork - 1)
        ' First delete any existing visits for that person
        'ExecuteSQLCommand("DELETE FROM Visits WHERE CaseNumber = " & sWork)
        Dim SQL As String = "SELECT * FROM Visits WHERE CaseNumber = " & sWork
        Command = New OleDbCommand(SQL, RdB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            SQL = "INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags, Delivery) VALUES(" & sWork & ", #" & rsWork!VisitDate.ToString & "#, " & rsWork!NumberOfBags & "," & rsWork!Delivery.ToString & ")"
            ExecuteSQLCommand(SQL)
            'Dim RCommand As OleDbCommand = New OleDbCommand(SQL, RdB)
            'RCommand.ExecuteNonQuery()
        End While
        rsWork.Close()
        dB.Close()
        RdB.Close()
        Me.Close()
    End Sub
End Class

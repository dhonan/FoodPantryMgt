Imports System.Data.OleDb
Public Class frmChanges

    Private Sub frmChanges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sWork As String = "Changes for " & System.Windows.Forms.Application.ProductVersion
        'Dim iWork As Integer
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = "SELECT * FROM ApplicationChanges WHERE Version = '" & System.Windows.Forms.Application.ProductVersion & "' ORDER BY LineNumber"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            sWork += vbCrLf & vbCrLf & rsWork!Change
        End While
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        ' 1.0.0.7
        'sWork += vbCrLf & vbCrLf & "Change First and Last names to Upper/Lower case, with settings option."
        'sWork += vbCrLf & vbCrLf & "Fix 'Last visit date' at bottom of printed ticket."
        'sWork += vbCrLf & vbCrLf & "If a box on the printed ticket is empty, make it not visible."
        'sWork += vbCrLf & vbCrLf & "Mark clients with 'Registration is NOT complete' and warn."
        'sWork += vbCrLf & vbCrLf & "When printing a sample ticket, ask specifically whether to print FACLESS."
        'sWork += vbCrLf & vbCrLf & "Add groupings."
        lblWhatsNew.Text = sWork
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        If chkDontShowAgain.Checked Then
            '         If GetASetting("ShowCurrentVersionChanges", "") = System.Windows.Forms.Application.ProductVersion Then

            Dim sWork As String = "CurrentVersionChanges"
            ' & System.Windows.Forms.Application.ProductVersion
            SaveASetting(sWork, System.Windows.Forms.Application.ProductVersion)
        End If
        Me.Close()
    End Sub
End Class
Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim args(2) As String
        args(0) = 14
        args(1) = ""
        args(2) = ""

        Using TicketPrint As New TicketPrint()
            TicketPrint.Main(args)


        End Using

    End Sub
End Class
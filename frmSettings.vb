Imports System.Drawing.Printing
Public Class frmSettings
    Private Sub frmSelectPrinter_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim CurrentlySelectedPrinter As Integer = -1
        Dim CurrentlySelectedPrinterName As String = GetASetting("Printer")
        For Each printer As String In PrinterSettings.InstalledPrinters
            cmbPrinter.Items.Add(printer)
            If printer = CurrentlySelectedPrinterName Then
                CurrentlySelectedPrinter = cmbPrinter.Items.Count - 1
            End If
        Next printer
        If CurrentlySelectedPrinter <> -1 Then cmbPrinter.SelectedIndex = CurrentlySelectedPrinter
        Dim sWork As String = GetASetting("InactiveToActiveMonths", "3")
        numInactiveToActiveMonths.Value = Val(sWork)
        sWork = GetASetting("ProgramToLaunch", "Nothing")
        cmbProgram.Text = sWork
        txtVisitDate.Text = GetASetting("VisitDate", "")
        numMonthsToInactive.Value = Val(GetASetting("MonthsToInactive", "0"))
        chkAutoULCase.Checked = GetASetting("AutoULCase", "False")
        ' Get the installed fonts collection.
        Dim allFonts As New Drawing.Text.InstalledFontCollection
        ' Get an array of the system's font familiies.
        Dim fontFamilies() As FontFamily = allFonts.Families()
        ' Display the font families.
        For Each myFont As FontFamily In fontFamilies
            cmbFontForTickets.Items.Add(myFont.Name)
        Next 'font_family
        sWork = GetASetting("TicketFont", "Microsoft Sans Serif")
        cmbFontForTickets.Text = sWork
        sWork = GetASetting("NumberOfCopies", "1")
        numNumberOfCopies.Value = CInt(sWork)
        txtLabelForFoodBox.Text = GetASetting("LabelForFoodBox", "Food")
        txtLabelForHomeBox.Text = GetASetting("LabelForHomeBox", "Home")
        txtLabelForColdBox.Text = GetASetting("LabelForColdBox", "Cold")
        txtLabelForColdSpecialsBox.Text = GetASetting("LabelForColdSpecialsBox", "Cold specials")
        txtLabelForLimitOf3ItemsBox.Text = GetASetting("LabelForLimitOf3Items", "Limit of 3 items")
        txtLabelForFreshBox.Text = GetASetting("LabelForFreshBox", "Fresh")
        txtLabelForSpecialsBox.Text = GetASetting("LabelForSpecialsBox", "Specials")
        txtLabelForColdPickOnly2Box.Text = GetASetting("LabelForColdPickOnly2Box", "Cold(2 only)")
        cmbWeekStartDay.Text = GetASetting("WeekStartDay", "Wednesday")
        'txtLabelForColdPickOnly2Box.Text = GetASetting("LabelForColdPickOnly2Box", "Cold(2 only)")

        txtLabelForLimitOf4ItemsBox.Text = GetASetting("LabelForLimitOf4ItemsBox", "Limit of 4 items")
        txtLabelForOtherItemsBox.Text = GetASetting("LabelForOtherItemsBox", "Other items")
        sWork = GetASetting("FootPrints", "True")
        If sWork = "True" Then optFootPrints.Checked = True Else optStVincent.Checked = True
        sWork = GetASetting("TrackMilitary", "False")
        If sWork = "True" Then chkMilitary.Checked = True Else chkMilitary.Checked = False
        txtTitle.Text = GetASetting("Title", "FootPrints food pantry")

    End Sub
    Private Sub btnDone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDone.Click

        If txtVisitDate.Text <> "" AndAlso Not IsDate(txtVisitDate.Text) Then
            MsgBox("Sorry, the 'Date to use when recording visits' must be blank, or a valid date.")
            Exit Sub
        End If

        SaveASetting("VisitDate", txtVisitDate.Text)
        SaveASetting("Printer", cmbPrinter.Text)
        SaveASetting("NumberOfCopies", numNumberOfCopies.Value)
        SaveASetting("InactiveToActiveMonths", numInactiveToActiveMonths.Value.ToString)
        SaveASetting("ProgramToLaunch", cmbProgram.Text)
        SaveASetting("MonthsToInactive", numMonthsToInactive.Value.ToString)
        SaveASetting("TicketFont", cmbFontForTickets.Text)
        SaveASetting("AutoULCase", chkAutoULCase.Checked)

        SaveASetting("LabelForFoodBox", txtLabelForFoodBox.Text)
        SaveASetting("LabelForHomeBox", txtLabelForHomeBox.Text)
        SaveASetting("LabelForColdBox", txtLabelForColdBox.Text)
        SaveASetting("LabelForColdSpecialsBox", txtLabelForColdSpecialsBox.Text)
        SaveASetting("LabelForLimitOf3Items", txtLabelForLimitOf3ItemsBox.Text)
        SaveASetting("LabelForFreshBox", txtLabelForFreshBox.Text)
        SaveASetting("LabelForSpecialsBox", txtLabelForSpecialsBox.Text)
        SaveASetting("LabelForColdPickOnly2Box", txtLabelForColdPickOnly2Box.Text)
        SaveASetting("LabelForLimitOf4ItemsBox", txtLabelForLimitOf4ItemsBox.Text)
        SaveASetting("LabelForOtherItemsBox", txtLabelForOtherItemsBox.Text)
        If optFootPrints.Checked Then SaveASetting("FootPrints", "True") Else SaveASetting("FootPrints", "False")
        SaveASetting("Title", txtTitle.Text)
        SaveASetting("TrackMilitary", chkMilitary.Checked)
        SaveASetting("FootPrints", optFootPrints.Checked)
        SaveASetting("WeekStartDay", cmbWeekStartDay.Text)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
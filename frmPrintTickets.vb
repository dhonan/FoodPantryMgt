Imports System.Data.OleDb
Public Class frmPrintTickets
    Dim Loading As Boolean = False
    Dim NumberOfAdults As Integer = 0
    Dim NumberOfChildren As Integer = 0
    Dim MaleAdults As Integer = 0
    Dim FemaleAdults As Integer = 0

    Dim MaleChildren As Integer = 0
    Dim FemaleChildren As Integer = 0

    Dim MaleSeniors As Integer = 0
    Dim FemaleSeniors As Integer = 0

    Dim ThisIsForAHomeLessPerson As Boolean = False
    Dim UseItemGroups As Boolean = False
    Dim FootPrintsFoodPantry As Boolean
    Private Sub frmPrintTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DSN = "" Then    ' Only during debugging
            GetDBLocation()
            dB = New OleDb.OleDbConnection(DSN)
        End If
        Loading = True
        If GetASetting("FootPrints", "True") = "True" Then FootPrintsFoodPantry = True Else FootPrintsFoodPantry = False
        lblReserved.Text = GetASetting("Title", "FootPrints food pantry") & lblReserved.Text
        lblTicketTitle.Text = GetASetting("Title", "FootPrints food pantry")
        UseItemGroups = AnyGroupings()
        LoadMeUp(frmMain.PrintSample)
        Loading = False
        NameCheckBoxLists()
        LoadBoxNames()
        LoadCheckBoxLists()
        'If TestingMode or  ViewFirst Then btnPrint.Visible = True
        PrintTheTicket(frmMain.PrintSample)
    End Sub
    Sub NameCheckBoxLists()

        grpFood.Text = GetASetting("LabelForFoodBox", "Food")
        grpHome.Text = GetASetting("LabelForHomeBox", "Home")
        grpCold.Text = GetASetting("LabelForColdBox", "Cold")
        grpColdSpecials.Text = GetASetting("LabelForColdSpecialsBox", "Cold specials")
        grpHomeless3.Text = GetASetting("LabelForLimitOf3Items", "Limit of 3 items")
        grpFresh.Text = GetASetting("LabelForFreshBox", "Fresh")
        grpSpecial.Text = GetASetting("LabelForSpecialsBox", "Specials")
        grpCold2Only.Text = GetASetting("LabelForColdPickOnly2Box", "Cold(2 only)")
        grpHomeless4.Text = GetASetting("LabelForLimitOf4ItemsBox", "Limit of 4 items")
        grpHomelessOther.Text = GetASetting("LabelForOtherItemsBox", "Other items")


    End Sub
    Sub LoadBoxNames()
        grpFood.Text = GetASetting("LabelForFoodBox", "Food")
        grpHome.Text = GetASetting("LabelForHomeBox", "Home")
        grpCold.Text = GetASetting("LabelForColdBox", "Cold")
        grpColdSpecials.Text = GetASetting("LabelForColdSpecialsBox", "Cold specials")
        grpHomeless3.Text = GetASetting("LabelForLimitOf3Items", "Limit of 3 items")
        grpFresh.Text = GetASetting("LabelForFreshBox", "Fresh")
        grpSpecial.Text = GetASetting("LabelForSpecialsBox", "Specials")
        grpCold2Only.Text = GetASetting("LabelForColdPickOnly2Box", "Cold(2 only)")
        grpHomeless4.Text = GetASetting("LabelForLimitOf4ItemsBox", "Limit of 4 items")
        grpHomelessOther.Text = GetASetting("LabelForOtherItemsBox", "Other items")
    End Sub
    Sub PrintTheTicket(Optional ByVal ForceIt As Boolean = False)
        Dim ShowMargins As Boolean = False
        PrintForm1.PrinterSettings.PrinterName = GetASetting("Printer")

        'If TestingMode Then
        '    PrintForm1.PrinterSettings.PrinterName = "Brother MFC-465CN Printer"
        'End If
        If ForceIt Or frmMain.chkPrintIt.Checked Or (Not TestingMode) Then
            PrintForm1.PrinterSettings.DefaultPageSettings.PrinterResolution.Kind = Printing.PrinterResolutionKind.Medium
            PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0
            PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0
            PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 5
            PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0
       
            

            Dim NumberOfCopiesToPrint As Integer = CInt(GetASetting("NumberOfCopies", "1"))
            PrintForm1.Form.AutoSize = True
            PrintForm1.PrinterSettings.Copies = NumberOfCopiesToPrint
            If ForceIt Then
                PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
                ' 1/31/2015 changed from True to False D. Honan
                clbHomessOther.Visible = False
                ' 1/31/2015 changed from True to False D. Honan
                clbHomeLess3.Visible = False
                clbHomeless4.Visible = True
            End If
            'TopMargin = 10
            If CLA.LeftMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = CLA.LeftMargin : ShowMargins = True
            If CLA.RightMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = CLA.RightMargin : ShowMargins = True
            If CLA.TopMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = CLA.TopMargin : ShowMargins = True
            If CLA.BottomMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = CLA.BottomMargin : ShowMargins = True
            PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter     ' 2/13/15 DJH vcanuse prview also


            Try
                PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
                'PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)
            Catch ex As Exception
                MsgBox("Unable to print form, the wrong printer has been specified.")
            End Try
            Me.Close()
        End If
    End Sub
    Private Sub btnPrintMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintTheTicket(True)
    End Sub
    Sub LoadMeUp(Optional ByVal SamplePage As Boolean = False)
        Dim sWork As String = ""
        'lblCurrentDate.Text = Format(Now, "MM/dd/yyyy") DJH 3/17/15
        Dim SQL As String = GetSQLForClientRetrieve(frmMain.SelectedClientNumber, frmMain.SelectedClientName)
        If GetNumberOfVisitsForClient(frmMain.SelectedClientNumber) = 1 Then lblNewClient.Visible = True Else lblNewClient.Visible = False
        ' If one visit, AND currently inactive (about to be re-activated), change lblNewClient to "Re-Activated"
        If Not SamplePage AndAlso GetClientActiveOrInactiveFromNumber(frmMain.SelectedClientNumber) = 0 Then lblNewClient.Text = "Re-Activated"
        lblNewClient.Visible = False   ' 2/6/15 DJH
        If SQL <> "" Then
            dB.Open()

            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            rsWork.Read()
            ThisIsForAHomeLessPerson = rsWork!HomeLess
            'lblCaseNumber.Text = rsWork!CaseNumber
            txtCaseNumber.Text = rsWork!CaseNumber
            lblNotes.Text = rsWork!Notes
            lblSpecialReq.Text = rsWork!SpecialReq
            lblFoodAllergies.Text = rsWork!FoodAllergies
            lblClientName.Text = frmMain.SelectedClientName
            If SamplePage Then lblClientName.Text = "Sample page"
            lblBarCodeClientNumber.Text = "*" & Format(rsWork!CaseNumber, "000000") & "*"
            lblDate.Text = frmMain.SelectedClientLastVisitDate
            lblDate.Visible = False
            NumberOfAdults = rsWork!NumberOfAdults
            NumberOfChildren = rsWork!NumberOfChildren
            MaleAdults = rsWork!MaleAdults
            FemaleAdults = rsWork!FemaleAdults
            MaleChildren = rsWork!MaleChildren
            FemaleChildren = rsWork!FemaleChildren
            MaleSeniors = rsWork!MaleSeniors
            FemaleSeniors = rsWork!FemaleSeniors



            lblNumberOfAdults.Text = rsWork!NumberOfAdults ' NumberOfAdults.ToString
            lblNumberOfChildren.Text = rsWork!NumberOfChildren ' NumberOfChildren.ToString
            lblNumberOfSeniors.Text = rsWork!NumberOfSeniors
            lblAgesOfChildren.Text = rsWork!AgesOfChildren

            lblMaleAdults.Text = rsWork!MaleAdults
            lblFemaleadults.Text = rsWork!FemaleAdults
            lblMaleChildren.Text = rsWork!MaleChildren
            lblFemaleChildren.Text = rsWork!FemaleChildren
            lblMaleSeniors.Text = rsWork!MaleSeniors
            lblFemaleSeniors.Text = rsWork!FemaleSeniors
            


            'lblBarCodeClientNumber.Text = "*" & Format(rsWork!CaseNumber, "000000") & "*"
            ' DJH SetABox(chkHomeless, rsWork!HomeLess)
            ' DJHSetABox(chkDiabetic, rsWork!Diabetic)
            ' DJHSetABox(chkDeaf, rsWork!Deaf)
            ' DJH SetABox(chkSpecial, rsWork!Special)
            tbCustName.Text = rsWork!LastName & ", " & rsWork!FirstName
            If frmMain.chkDelivery.Checked Then
                sWork = "Delivery to " & rsWork!Address
                If Not IsDBNull(rsWork!Address2) AndAlso rsWork!Address2 <> "" Then sWork += " " & rsWork!Address2
                sWork += ", " & rsWork!Town
                If Not IsDBNull(rsWork!PhoneH) AndAlso rsWork!PhoneH <> "" Then sWork += " " & rsWork!PhoneH
                If Not IsDBNull(rsWork!PhoneC) AndAlso rsWork!PhoneC <> "" Then sWork += " " & rsWork!PhoneC
                lblDelivery.Text = sWork
            Else
                lblDelivery.Text = ""
            End If
            lblNotices.Text = ""

            If GetNumberOfVisitsForClient(frmMain.SelectedClientNumber) = 1 Then
                lblNotices.Text += "NEW CLIENT"
            End If
            If rsWork!NoCooking Then
                lblNotices.Text += vbCrLf & "No Cooking Facilities"
            End If

            If rsWork!NoPork Then
                lblNotices.Text += vbCrLf & "No Pork Products"
            End If

            If rsWork!Diabetic Then
                lblNotices.Text += vbCrLf & "Diabetic"
            End If

            If rsWork!Homeless Then
                lblNotices.Text += vbCrLf & "No Living Facility"
            End If

            If rsWork!Deaf Then
                lblNotices.Text += vbCrLf & "Deaf"
            End If
            ' 2/11/16 DJH added Limited
            If rsWork!Limited Then
                lblNotices.Text += vbCrLf & "Limited Selection"
            End If




            If Len(lblDate.Text) > 0 Then
                lblNotices.Text += vbCrLf & "Last Visit: " & lblDate.Text
            End If

            If FootPrintsFoodPantry Then
                ' Load homeless boxes for footprints
                If ThisIsForAHomeLessPerson Or SamplePage Then
                    'DJH chkHomeless.Checked = True
                    LoadACheckBoxList(clbHomeless4, grpHomeless4, "ItemType = 'Homeless' AND Limit = 4", False)
                    LoadACheckBoxList(clbHomeLess3, grpHomeless3, "ItemType = 'Homeless' AND Limit = 3", False)
                    LoadACheckBoxList(clbHomessOther, grpHomelessOther, "ItemType = 'Homeless' AND Limit <>  4 AND Limit <> 3", False)
                    grpHomeless4.Visible = True
                    grpHomeless3.Visible = True
                    grpHomelessOther.Visible = True
                Else
                    'DJH chkHomeless.Visible = False
                    grpHomeless4.Visible = False
                    grpHomeless3.Visible = False
                    grpHomelessOther.Visible = False

                End If
            Else
                ' Load homeless boxes for Saint Vincents
                '11/ Change box of "Limit of 4 items" to "Baked Goods"
                '12/ Box "Limit of 3 items add the words USDA-Frozen
                '13/ Change Box title " Other Items" to just USDA
                LoadACheckBoxList(clbHomeless4, grpHomeless4, "ItemType = 'Baked Goods'", False)
                LoadACheckBoxList(clbHomeLess3, grpHomeless3, "ItemType = 'USDA Frozen'", False)
                LoadACheckBoxList(clbHomessOther, grpHomelessOther, "ItemType = 'USDA'", False)

            End If
            If SamplePage Then
                txtCaseNumber.Text = ""
                'DJHchkDeaf.Visible = False
                lblNumberOfAdults.Text = ""
                lblNumberOfChildren.Text = ""
                lblMaleAdults.Text = ""
                lblFemaleadults.Text = ""
                lblMaleChildren.Text = ""
                lblFemaleChildren.Text = ""
                lblMaleSeniors.Text = ""
                lblFemaleSeniors.Text = ""


                'DJHlblNumberOfSeniors.Text = ""
                lblAgesOfChildren.Text = ""
                lblDelivery.Visible = False
            End If
            'grpHomeless4.Text = ""
            ' DJH If Not chkHomeless.Checked Then chkHomeless.Visible = False


            rsWork.Close()

            If Not SamplePage Then
                'sWork = GetLastVisitDateForClient(frmMain.SelectedClientNumber, frmMain.SelectedClientName)
                sWork = frmMain.SelectedClientLastVisitDate
                If IsDate(sWork) Then
                    lblLastVisitDate.Text = Format(CDate(sWork), "MM/dd/yyyy")
                Else
                    lblLastVisitDate.Text = ""
                    lblLastVisitDateL.Visible = False
                End If
            Else
                lblLastVisitDate.Text = "Last visit date"
            End If
            lblLastVisitDate.Visible = False    ' DJH 2/6/15
            lblLastVisitDateL.Visible = False    ' DJH 2/6/15


            ' Add Appointment Time 1/31/2015 D. Honan

            ' Add ability to schedule future dates D. Honan 3/17/15

            'SQL = "select * from Visits where CaseNumber=" & txtCaseNumber.Text _
            '       & " and int(VisitDate) = int(now)"

            SQL = "select * from Visits where CaseNumber=" & txtCaseNumber.Text _
                   & " and int(VisitDate) >= int(now)"

            dB.Close()
            dB.Open()
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            rsWork.Read()
            If rsWork.HasRows = False Then
                MsgBox("Fatal Error - cannot find visit row")
                Exit Sub
            End If
            lblApptTime.Text = Format(rsWork!ApptTime, "h:mmtt")
            lblCurrentDate.Text = Format(rsWork!VisitDate, "MM/dd/yyyy") ' DJH 3/17/15
            ' end of changes 1/31/2015 D. Honan

            dB.Close()




        Else
            ' No SQL, must be a sample.  Load up the homeless boxes
            txtCaseNumber.Text = ""
            lblApptTime.Text = "00:00 AM"
            lblCurrentDate.Text = Format(Now, "MM/dd/yyyy") ' DJH 3/17/15
            'DJH chkDeaf.Visible = False
            'DJH chkDiabetic.Visible = False
            lblNumberOfAdults.Text = ""
            lblNumberOfChildren.Text = ""
            lblNumberOfSeniors.Text = ""

            lblMaleAdults.Text = ""
            lblFemaleadults.Text = ""
            lblMaleChildren.Text = ""
            lblFemaleChildren.Text = ""
            lblMaleSeniors.Text = ""
            lblFemaleSeniors.Text = ""

            lblAgesOfChildren.Text = ""
            lblDelivery.Visible = False
            If FootPrintsFoodPantry Then
                LoadACheckBoxList(clbHomeless4, grpHomeless4, "ItemType = 'Homeless' AND Limit = 4", False)
                LoadACheckBoxList(clbHomeLess3, grpHomeless3, "ItemType = 'Homeless' AND Limit = 3", False)
                LoadACheckBoxList(clbHomessOther, grpHomelessOther, "ItemType = 'Homeless' AND Limit <>  4 AND Limit <> 3", False)
            Else
                LoadACheckBoxList(clbHomeless4, grpHomeless4, "ItemType = 'Baked Goods'", False)
                LoadACheckBoxList(clbHomeLess3, grpHomeless3, "ItemType = 'USDA Frozen'", False)
                LoadACheckBoxList(clbHomessOther, grpHomelessOther, "ItemType = 'USDA'", False)

            End If
            grpHomeless4.Visible = frmMain.PrintFacLessSelections
            grpHomeless3.Visible = frmMain.PrintFacLessSelections
            grpHomelessOther.Visible = frmMain.PrintFacLessSelections
            lblDate.Visible = False
            lblLastVisitDate.Visible = False
            lblBarCodeClientNumber.Text = "*000000*"
            'lblDelivery.Text = lblBarCodeClientNumber.Text
            'lblDelivery.Visible = True
        End If
        'Dim SQL As String = "SELECT * FROM Clients WHERE CaseNumber = " & frmMain.SelectedClientNumber

    End Sub
    Sub SetABox(ByVal CheckBox As CheckBox, ByVal TheValue As Boolean)
        If TheValue Then
            'CheckBox.Checked = True
            CheckBox.Visible = True
        Else
            CheckBox.Visible = False
        End If
    End Sub
    Sub LoadCheckBoxLists()
        If FootPrintsFoodPantry Then
            LoadACheckBoxList(clbCold, grpCold, "ItemType IN ('Cold')", True, True)
            LoadACheckBoxList(clbCold2Only, grpCold2Only, "ItemType IN ('Cold(2 only)')", True, True)
            LoadACheckBoxList(cblColdSpecials, grpColdSpecials, "ItemType IN ('Cold Special')", True, True)
            LoadACheckBoxList(clbFood, grpFood, "ItemType IN ('Food', 'Kid snack', 'Normal')", True)
            LoadACheckBoxList(clbFresh, grpFresh, "ItemType IN ('Fresh')", True)
            LoadACheckBoxList(clbHome, grpHome, "ItemType IN ('Home', 'Personal care')", True)
            LoadACheckBoxList(clbSpecials, grpSpecial, "ItemType IN ('Special')", True)
        Else
            LoadACheckBoxList(clbFood, grpFood, "ItemType IN ('Food', 'Kid snack', 'Normal')", True)
            LoadACheckBoxList(clbFresh, grpFresh, "ItemType IN ('Fresh')", True)
            LoadACheckBoxList(clbHome, grpHome, "ItemType IN ('Home', 'Personal care')", True)
            LoadACheckBoxList(clbSpecials, grpSpecial, "ItemType IN ('Specials')", True)
            LoadACheckBoxList(clbCold, grpCold, "ItemType IN ('Dairy')", True, True)
            LoadACheckBoxList(clbCold2Only, grpCold2Only, "ItemType IN ('Meats pick only 2')", True, True)
            LoadACheckBoxList(cblColdSpecials, grpColdSpecials, "ItemType IN ('Misc. Meats')", True, True)

        End If
    End Sub
    Sub LoadACheckBoxList(ByRef TheBox As CheckedListBox, ByVal TheGroupBox As GroupBox, ByVal Where As String, ByVal CheckForHomeless As Boolean, Optional ByVal ColdItems As Boolean = False)
        Dim OkToAddItem As Boolean = True
        Dim ThisGroupItemType As String = TheBox.Tag
        Dim ItemsLoaded As ArrayList = New ArrayList
        Dim iWork As Integer = 0
        '
        ' Set the font
        '
        On Error Resume Next : Err.Clear()
        'ItemsLoaded.Sort()

        Dim SQL As String = ""
        Dim sWork As String = "" ' Err.Description
        sWork = GetASetting("TicketFont", "Microsoft Sans Serif")
        'sWork = "Microsoft Sans Serif"
        Dim myfont As New Font(sWork, 9, FontStyle.Regular)
        TheBox.Items.Clear()
        TheBox.Font = myfont
        Dim dbWasOpen As Boolean = dBIsOpen()
        If Not dbWasOpen Then dB.Open()
        If UseItemGroups Then
            '
            ' First retrieve any groupings for this GroupName and load the items.
            '
            SQL = "SELECT GroupedItems FROM Groupings WHERE ItemType = '" & ThisGroupItemType & "' ORDER BY GroupName"
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            While rsWork.Read
                Dim TheseGroupItems() As String = Split(rsWork!GroupedItems, vbTab)
                For ThisGroupedItem As Integer = 0 To UBound(TheseGroupItems)
                    sWork = GetItemNameFromItemNumber(Val(TheseGroupItems(ThisGroupedItem)))
                    iWork = TheseGroupItems(ThisGroupedItem)

                    If IsThisItemAvailableToday(Val(TheseGroupItems(ThisGroupedItem))) Then
                        TheBox.Items.Add(sWork)
                        ItemsLoaded.Add(Integer2String((TheseGroupItems(ThisGroupedItem))))
                    End If
                Next

            End While
            rsWork.Close()
            ItemsLoaded.Sort()

        End If
        '
        SQL = "SELECT ID, ItemName, Available, ItemType, CountForNPeople FROM Items WHERE Available = True AND " & Where & " ORDER BY ItemName"


        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            OkToAddItem = True
            If UseItemGroups Then
                ' First, check to see if this item has already been loaded as part of a group.
                If Not IsDBNull(ItemsLoaded) Then
                    ItemsLoaded.Sort()

                    'This is the HARD way!

                    'iWork = -1
                    'For iWork2 As Integer = 0 To ItemsLoaded.Count - 1
                    '    If ItemsLoaded(iWork2) = rsWork!ID Then
                    '        iWork = iWork2
                    '        Exit For
                    '    End If
                    'Next
                    '
                    '
                    iWork = ItemsLoaded.BinarySearch(Integer2String(rsWork!ID))
                    'MsgBox(ItemsLoaded.Count)
                    If iWork >= 0 Then
                        OkToAddItem = False
                    End If
                End If
            End If
            ' First, check to see if this item has already been loaded as part of a group.
            'If Not IsDBNull(ItemsLoaded) Then
            'ItemsLoaded.Sort()
            '
            ' This is the HARD way!
            '
            'iWork = -1
            'For iWork2 As Integer = 0 To ItemsLoaded.Count - 1
            '    If ItemsLoaded(iWork2) = rsWork!ID Then
            '        iWork = iWork2
            '        Exit For
            '    End If
            'Next
            'iWork = ItemsLoaded.BinarySearch(rsWork!ID)
            'MsgBox(ItemsLoaded.Count)
            'If iWork >= 0 Then
            '    OkToAddItem = False
            'End If
            'End If

            ' If we're printing a ticket for a homeless person, 
            ' don't include items in the OTHER CheckBoxList that are in the "Homeless" CheckBoxList
            sWork = rsWork!ItemName

            ' 1/31/2015 added logic to show space for quantities and remove checkbox for USDA
            ' Items - D. Honan

            If rsWork!ItemType = "USDA" Then
                sWork = "___ " & sWork
                lbUSDA.Items.Add(sWork)
            End If

            If rsWork!ItemType = "USDA Frozen" Then
                sWork = "___ " & sWork
                lbUSDAFrozen.Items.Add(sWork)
            End If


            iWork = rsWork!ID
            ' Remove any leading periods or numbers

            If Strings.Left(sWork, 1) = "." Then sWork = Strings.Mid(sWork, 2)
            If CheckForHomeless And ThisIsForAHomeLessPerson Then
                ' We're NOT loading a homeless checkbox, and this IS a homeless person.  Don't add items if they're also homeless items.
                If DoesThisItemExistAsAHomelessItem(sWork) Then
                    ' Yes, this item exists as a homeless item.  Don't include it.
                    OkToAddItem = False
                End If
            End If
            If OkToAddItem Then
                sWork = StripLeadingStuff(sWork)
                TheBox.Items.Add(sWork)
                If UseItemGroups Then
                    ItemsLoaded.Add(Integer2String(rsWork!ID))
                    ItemsLoaded.Sort()
                End If

            End If
        End While
        rsWork.Close()
        If Not dbWasOpen Then dB.Close()
        If TheBox.Items.Count <> 0 Then
            TheBox.SelectedItems.Clear()
        Else
            TheGroupBox.Visible = False
        End If
        'If TestingMode Then MsgBox(TheBox.Name & ", " & TheBox.Items.Count & " items.")
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintTheTicket(True)
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbUSDA.SelectedIndexChanged

    End Sub

    Private Sub clbHomessOther_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbHomessOther.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblReserved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReserved.Click

    End Sub
End Class
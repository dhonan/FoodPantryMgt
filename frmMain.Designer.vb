<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileImport = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileQuit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileChangeDBLocation = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileBackup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileSQL = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileFixhtmlPages = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileRestoreVisitsFromBackup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditFoodItems = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditItemsMaintain = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditItemsGroupItems = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateItemTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditVisits = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditSettings = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReportVisits = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReportItems = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReportExtract = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReportTodaysDeliveries = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReportCounts = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpChanges = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpCLA = New System.Windows.Forms.ToolStripMenuItem
        Me.btnTest = New System.Windows.Forms.Button
        Me.txtSearchLastName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnRecordAndPrint = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnDone = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.pnlClients = New System.Windows.Forms.Panel
        Me.lvClients = New System.Windows.Forms.ListView
        Me.chkPrintIt = New System.Windows.Forms.CheckBox
        Me.btnPrintSample = New System.Windows.Forms.Button
        Me.optActive = New System.Windows.Forms.RadioButton
        Me.optInactive = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblCurrentlySelected = New System.Windows.Forms.Label
        Me.txtSearchClientNumber = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblTotalVisitsToday = New System.Windows.Forms.Label
        Me.btnUnVisit = New System.Windows.Forms.Button
        Me.chkDelivery = New System.Windows.Forms.CheckBox
        Me.btnSpecial = New System.Windows.Forms.Button
        Me.lblTotalDeliveriesToday = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkDiabetic = New System.Windows.Forms.CheckBox
        Me.chkHomeless = New System.Windows.Forms.CheckBox
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtPhoneH = New System.Windows.Forms.TextBox
        Me.datStarted = New System.Windows.Forms.DateTimePicker
        Me.datReopened = New System.Windows.Forms.DateTimePicker
        Me.cmbNumberOfAdults = New System.Windows.Forms.ComboBox
        Me.cmbNumberOfChildren = New System.Windows.Forms.ComboBox
        Me.txtAgesOfChildren = New System.Windows.Forms.TextBox
        Me.cmbTown = New System.Windows.Forms.ComboBox
        Me.txtCaseNumber = New System.Windows.Forms.TextBox
        Me.btnNewTown = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPhoneC = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtPhoneW = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.grpVisits = New System.Windows.Forms.GroupBox
        Me.lstOfVisits = New System.Windows.Forms.ListBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbNumberOfSeniors = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.chkDeaf = New System.Windows.Forms.CheckBox
        Me.lblLastUpdated = New System.Windows.Forms.Label
        Me.datLastUpdated = New System.Windows.Forms.DateTimePicker
        Me.lblReOpened = New System.Windows.Forms.Label
        Me.chkUpdateDateUpdated = New System.Windows.Forms.CheckBox
        Me.chkRegistrationIsComplete = New System.Windows.Forms.CheckBox
        Me.chkMilitary = New System.Windows.Forms.CheckBox
        Me.grpOtherAdults = New System.Windows.Forms.GroupBox
        Me.txtOtherAdults = New System.Windows.Forms.TextBox
        Me.chkSNAP = New System.Windows.Forms.CheckBox
        Me.chkWIC = New System.Windows.Forms.CheckBox
        Me.btnDeleteTown = New System.Windows.Forms.Button
        Me.tbApptTime = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cbFuelAsst = New System.Windows.Forms.CheckBox
        Me.cbMedicaid = New System.Windows.Forms.CheckBox
        Me.cbAidBlind = New System.Windows.Forms.CheckBox
        Me.cbCSFP = New System.Windows.Forms.CheckBox
        Me.cbOldAge = New System.Windows.Forms.CheckBox
        Me.cbTANF = New System.Windows.Forms.CheckBox
        Me.cbSubsHousing = New System.Windows.Forms.CheckBox
        Me.cbAPTD = New System.Windows.Forms.CheckBox
        Me.cbHeadStart = New System.Windows.Forms.CheckBox
        Me.cbWelfare = New System.Windows.Forms.CheckBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.cbIncomeEligible = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.pnlClient = New System.Windows.Forms.Panel
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.cmbFemaleSeniors = New System.Windows.Forms.ComboBox
        Me.cmbFemaleChildren = New System.Windows.Forms.ComboBox
        Me.cmbFemaleAdults = New System.Windows.Forms.ComboBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.cmbMaleSeniors = New System.Windows.Forms.ComboBox
        Me.cmbMaleChildren = New System.Windows.Forms.ComboBox
        Me.cmbMaleAdults = New System.Windows.Forms.ComboBox
        Me.datApptDate = New System.Windows.Forms.DateTimePicker
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.tbSpecialReq = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.tbFoodAllergies = New System.Windows.Forms.TextBox
        Me.cbNoPork = New System.Windows.Forms.CheckBox
        Me.cbNoCooking = New System.Windows.Forms.CheckBox
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.pnlClients.SuspendLayout()
        Me.grpVisits.SuspendLayout()
        Me.grpOtherAdults.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlClient.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuReport, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileImport, Me.mnuFileQuit, Me.mnuFileChangeDBLocation, Me.mnuFileBackup, Me.mnuFileSQL, Me.mnuFileFixhtmlPages, Me.mnuFileRestoreVisitsFromBackup})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileImport
        '
        Me.mnuFileImport.Name = "mnuFileImport"
        Me.mnuFileImport.Size = New System.Drawing.Size(216, 22)
        Me.mnuFileImport.Text = "Import"
        '
        'mnuFileQuit
        '
        Me.mnuFileQuit.Name = "mnuFileQuit"
        Me.mnuFileQuit.Size = New System.Drawing.Size(216, 22)
        Me.mnuFileQuit.Text = "Quit"
        '
        'mnuFileChangeDBLocation
        '
        Me.mnuFileChangeDBLocation.Name = "mnuFileChangeDBLocation"
        Me.mnuFileChangeDBLocation.Size = New System.Drawing.Size(216, 22)
        Me.mnuFileChangeDBLocation.Text = "Change DB Location"
        '
        'mnuFileBackup
        '
        Me.mnuFileBackup.Name = "mnuFileBackup"
        Me.mnuFileBackup.Size = New System.Drawing.Size(216, 22)
        Me.mnuFileBackup.Text = "Back up the DB"
        '
        'mnuFileSQL
        '
        Me.mnuFileSQL.Name = "mnuFileSQL"
        Me.mnuFileSQL.Size = New System.Drawing.Size(216, 22)
        Me.mnuFileSQL.Text = "Enter SQL command or file"
        Me.mnuFileSQL.Visible = False
        '
        'mnuFileFixhtmlPages
        '
        Me.mnuFileFixhtmlPages.Name = "mnuFileFixhtmlPages"
        Me.mnuFileFixhtmlPages.Size = New System.Drawing.Size(216, 22)
        Me.mnuFileFixhtmlPages.Text = "Fix html pages"
        '
        'mnuFileRestoreVisitsFromBackup
        '
        Me.mnuFileRestoreVisitsFromBackup.Name = "mnuFileRestoreVisitsFromBackup"
        Me.mnuFileRestoreVisitsFromBackup.Size = New System.Drawing.Size(216, 22)
        Me.mnuFileRestoreVisitsFromBackup.Text = "Restore visits from backup"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditFoodItems, Me.mnuEditVisits, Me.mnuEditSettings})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuEditFoodItems
        '
        Me.mnuEditFoodItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditItemsMaintain, Me.mnuEditItemsGroupItems, Me.UpdateItemTypesToolStripMenuItem})
        Me.mnuEditFoodItems.Name = "mnuEditFoodItems"
        Me.mnuEditFoodItems.Size = New System.Drawing.Size(116, 22)
        Me.mnuEditFoodItems.Text = "Items"
        '
        'mnuEditItemsMaintain
        '
        Me.mnuEditItemsMaintain.Name = "mnuEditItemsMaintain"
        Me.mnuEditItemsMaintain.Size = New System.Drawing.Size(173, 22)
        Me.mnuEditItemsMaintain.Text = "Maintain"
        '
        'mnuEditItemsGroupItems
        '
        Me.mnuEditItemsGroupItems.Name = "mnuEditItemsGroupItems"
        Me.mnuEditItemsGroupItems.Size = New System.Drawing.Size(173, 22)
        Me.mnuEditItemsGroupItems.Text = "Group items"
        Me.mnuEditItemsGroupItems.Visible = False
        '
        'UpdateItemTypesToolStripMenuItem
        '
        Me.UpdateItemTypesToolStripMenuItem.Name = "UpdateItemTypesToolStripMenuItem"
        Me.UpdateItemTypesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.UpdateItemTypesToolStripMenuItem.Text = "Update Item Types"
        '
        'mnuEditVisits
        '
        Me.mnuEditVisits.Name = "mnuEditVisits"
        Me.mnuEditVisits.Size = New System.Drawing.Size(116, 22)
        Me.mnuEditVisits.Text = "Visits"
        '
        'mnuEditSettings
        '
        Me.mnuEditSettings.Name = "mnuEditSettings"
        Me.mnuEditSettings.Size = New System.Drawing.Size(116, 22)
        Me.mnuEditSettings.Text = "Settings"
        '
        'mnuReport
        '
        Me.mnuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportVisits, Me.mnuReportItems, Me.mnuReportExtract, Me.mnuReportTodaysDeliveries, Me.mnuReportCounts})
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(54, 20)
        Me.mnuReport.Text = "Report"
        '
        'mnuReportVisits
        '
        Me.mnuReportVisits.Name = "mnuReportVisits"
        Me.mnuReportVisits.Size = New System.Drawing.Size(166, 22)
        Me.mnuReportVisits.Text = "Visits"
        '
        'mnuReportItems
        '
        Me.mnuReportItems.Name = "mnuReportItems"
        Me.mnuReportItems.Size = New System.Drawing.Size(166, 22)
        Me.mnuReportItems.Text = "Items"
        '
        'mnuReportExtract
        '
        Me.mnuReportExtract.Name = "mnuReportExtract"
        Me.mnuReportExtract.Size = New System.Drawing.Size(166, 22)
        Me.mnuReportExtract.Text = "Extract year totals"
        '
        'mnuReportTodaysDeliveries
        '
        Me.mnuReportTodaysDeliveries.Name = "mnuReportTodaysDeliveries"
        Me.mnuReportTodaysDeliveries.Size = New System.Drawing.Size(166, 22)
        Me.mnuReportTodaysDeliveries.Text = "Todays deliveries"
        '
        'mnuReportCounts
        '
        Me.mnuReportCounts.Name = "mnuReportCounts"
        Me.mnuReportCounts.Size = New System.Drawing.Size(166, 22)
        Me.mnuReportCounts.Text = "Counts"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout, Me.mnuHelpChanges, Me.mnuHelpCLA})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(213, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'mnuHelpChanges
        '
        Me.mnuHelpChanges.Name = "mnuHelpChanges"
        Me.mnuHelpChanges.Size = New System.Drawing.Size(213, 22)
        Me.mnuHelpChanges.Text = "Changes"
        '
        'mnuHelpCLA
        '
        Me.mnuHelpCLA.Name = "mnuHelpCLA"
        Me.mnuHelpCLA.Size = New System.Drawing.Size(213, 22)
        Me.mnuHelpCLA.Text = "Command line arguments"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(700, 551)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 34
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtSearchLastName
        '
        Me.txtSearchLastName.Location = New System.Drawing.Point(134, 522)
        Me.txtSearchLastName.Name = "txtSearchLastName"
        Me.txtSearchLastName.Size = New System.Drawing.Size(125, 20)
        Me.txtSearchLastName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 525)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Search first/last name:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(128, 580)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 23)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRecordAndPrint
        '
        Me.btnRecordAndPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnRecordAndPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordAndPrint.ForeColor = System.Drawing.Color.Maroon
        Me.btnRecordAndPrint.Location = New System.Drawing.Point(337, 537)
        Me.btnRecordAndPrint.Name = "btnRecordAndPrint"
        Me.btnRecordAndPrint.Size = New System.Drawing.Size(256, 66)
        Me.btnRecordAndPrint.TabIndex = 31
        Me.btnRecordAndPrint.Text = "Record visit and print ticket"
        Me.btnRecordAndPrint.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(128, 551)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 23)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(20, 580)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 23)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel adding"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(700, 580)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 35
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(20, 551)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(98, 23)
        Me.btnAddNew.TabIndex = 25
        Me.btnAddNew.Text = "Add new"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'pnlClients
        '
        Me.pnlClients.Controls.Add(Me.lvClients)
        Me.pnlClients.Location = New System.Drawing.Point(13, 63)
        Me.pnlClients.Name = "pnlClients"
        Me.pnlClients.Size = New System.Drawing.Size(291, 422)
        Me.pnlClients.TabIndex = 82
        '
        'lvClients
        '
        Me.lvClients.FullRowSelect = True
        Me.lvClients.HideSelection = False
        Me.lvClients.Location = New System.Drawing.Point(8, 3)
        Me.lvClients.Name = "lvClients"
        Me.lvClients.Size = New System.Drawing.Size(280, 416)
        Me.lvClients.TabIndex = 8
        Me.lvClients.UseCompatibleStateImageBehavior = False
        Me.lvClients.View = System.Windows.Forms.View.Details
        '
        'chkPrintIt
        '
        Me.chkPrintIt.AutoSize = True
        Me.chkPrintIt.Checked = True
        Me.chkPrintIt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintIt.Location = New System.Drawing.Point(249, 584)
        Me.chkPrintIt.Name = "chkPrintIt"
        Me.chkPrintIt.Size = New System.Drawing.Size(76, 17)
        Me.chkPrintIt.TabIndex = 30
        Me.chkPrintIt.Text = "Print ticket"
        Me.chkPrintIt.UseVisualStyleBackColor = True
        '
        'btnPrintSample
        '
        Me.btnPrintSample.Location = New System.Drawing.Point(603, 580)
        Me.btnPrintSample.Name = "btnPrintSample"
        Me.btnPrintSample.Size = New System.Drawing.Size(91, 23)
        Me.btnPrintSample.TabIndex = 33
        Me.btnPrintSample.Text = "Print sample"
        Me.btnPrintSample.UseVisualStyleBackColor = True
        '
        'optActive
        '
        Me.optActive.AutoSize = True
        Me.optActive.Checked = True
        Me.optActive.Location = New System.Drawing.Point(22, 27)
        Me.optActive.Name = "optActive"
        Me.optActive.Size = New System.Drawing.Size(88, 17)
        Me.optActive.TabIndex = 88
        Me.optActive.TabStop = True
        Me.optActive.Text = "Active clients"
        Me.optActive.UseVisualStyleBackColor = True
        '
        'optInactive
        '
        Me.optInactive.AutoSize = True
        Me.optInactive.Location = New System.Drawing.Point(116, 27)
        Me.optInactive.Name = "optInactive"
        Me.optInactive.Size = New System.Drawing.Size(96, 17)
        Me.optInactive.TabIndex = 89
        Me.optInactive.Text = "Inactive clients"
        Me.optInactive.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "Currently selected:"
        '
        'lblCurrentlySelected
        '
        Me.lblCurrentlySelected.AutoSize = True
        Me.lblCurrentlySelected.Location = New System.Drawing.Point(120, 47)
        Me.lblCurrentlySelected.Name = "lblCurrentlySelected"
        Me.lblCurrentlySelected.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrentlySelected.TabIndex = 91
        '
        'txtSearchClientNumber
        '
        Me.txtSearchClientNumber.Location = New System.Drawing.Point(134, 492)
        Me.txtSearchClientNumber.MaxLength = 6
        Me.txtSearchClientNumber.Name = "txtSearchClientNumber"
        Me.txtSearchClientNumber.Size = New System.Drawing.Size(67, 20)
        Me.txtSearchClientNumber.TabIndex = 0
        Me.txtSearchClientNumber.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 495)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 13)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "Search client number:"
        Me.Label18.Visible = False
        '
        'lblTotalVisitsToday
        '
        Me.lblTotalVisitsToday.AutoSize = True
        Me.lblTotalVisitsToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVisitsToday.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalVisitsToday.Location = New System.Drawing.Point(626, 488)
        Me.lblTotalVisitsToday.Name = "lblTotalVisitsToday"
        Me.lblTotalVisitsToday.Size = New System.Drawing.Size(108, 13)
        Me.lblTotalVisitsToday.TabIndex = 94
        Me.lblTotalVisitsToday.Text = "Total visits today:"
        '
        'btnUnVisit
        '
        Me.btnUnVisit.ForeColor = System.Drawing.Color.Maroon
        Me.btnUnVisit.Location = New System.Drawing.Point(233, 551)
        Me.btnUnVisit.Name = "btnUnVisit"
        Me.btnUnVisit.Size = New System.Drawing.Size(98, 23)
        Me.btnUnVisit.TabIndex = 29
        Me.btnUnVisit.Text = "UnVisit"
        Me.btnUnVisit.UseVisualStyleBackColor = True
        Me.btnUnVisit.Visible = False
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(531, 497)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(64, 17)
        Me.chkDelivery.TabIndex = 32
        Me.chkDelivery.Text = "Delivery"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'btnSpecial
        '
        Me.btnSpecial.Location = New System.Drawing.Point(603, 549)
        Me.btnSpecial.Name = "btnSpecial"
        Me.btnSpecial.Size = New System.Drawing.Size(90, 24)
        Me.btnSpecial.TabIndex = 95
        Me.btnSpecial.Text = "Special"
        Me.btnSpecial.UseVisualStyleBackColor = True
        Me.btnSpecial.Visible = False
        '
        'lblTotalDeliveriesToday
        '
        Me.lblTotalDeliveriesToday.AutoSize = True
        Me.lblTotalDeliveriesToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeliveriesToday.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalDeliveriesToday.Location = New System.Drawing.Point(601, 505)
        Me.lblTotalDeliveriesToday.Name = "lblTotalDeliveriesToday"
        Me.lblTotalDeliveriesToday.Size = New System.Drawing.Size(133, 13)
        Me.lblTotalDeliveriesToday.TabIndex = 96
        Me.lblTotalDeliveriesToday.Text = "Total deliveries today:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(60, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Case number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "First name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Last name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Address:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Town:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Zip:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Phone:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Date started:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Date reopened:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 343)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 20)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Number of adults:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 372)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 20)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Number of children:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(17, 425)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 20)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "Ages of children:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDiabetic
        '
        Me.chkDiabetic.AutoSize = True
        Me.chkDiabetic.Location = New System.Drawing.Point(84, 27)
        Me.chkDiabetic.Name = "chkDiabetic"
        Me.chkDiabetic.Size = New System.Drawing.Size(65, 17)
        Me.chkDiabetic.TabIndex = 22
        Me.chkDiabetic.Text = "Diabetic"
        Me.chkDiabetic.UseVisualStyleBackColor = True
        '
        'chkHomeless
        '
        Me.chkHomeless.AutoSize = True
        Me.chkHomeless.Location = New System.Drawing.Point(83, 4)
        Me.chkHomeless.Name = "chkHomeless"
        Me.chkHomeless.Size = New System.Drawing.Size(106, 17)
        Me.chkHomeless.TabIndex = 21
        Me.chkHomeless.Text = "No Living Facility"
        Me.chkHomeless.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(9, 9)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 110
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(73, 87)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(73, 111)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(200, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(73, 135)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 20)
        Me.txtAddress.TabIndex = 5
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(73, 187)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 9
        '
        'txtPhoneH
        '
        Me.txtPhoneH.Location = New System.Drawing.Point(114, 212)
        Me.txtPhoneH.Name = "txtPhoneH"
        Me.txtPhoneH.Size = New System.Drawing.Size(76, 20)
        Me.txtPhoneH.TabIndex = 10
        '
        'datStarted
        '
        Me.datStarted.Location = New System.Drawing.Point(114, 241)
        Me.datStarted.Name = "datStarted"
        Me.datStarted.Size = New System.Drawing.Size(200, 20)
        Me.datStarted.TabIndex = 13
        '
        'datReopened
        '
        Me.datReopened.Location = New System.Drawing.Point(114, 266)
        Me.datReopened.Name = "datReopened"
        Me.datReopened.Size = New System.Drawing.Size(200, 20)
        Me.datReopened.TabIndex = 14
        '
        'cmbNumberOfAdults
        '
        Me.cmbNumberOfAdults.FormattingEnabled = True
        Me.cmbNumberOfAdults.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbNumberOfAdults.Location = New System.Drawing.Point(116, 344)
        Me.cmbNumberOfAdults.Name = "cmbNumberOfAdults"
        Me.cmbNumberOfAdults.Size = New System.Drawing.Size(43, 21)
        Me.cmbNumberOfAdults.TabIndex = 17
        '
        'cmbNumberOfChildren
        '
        Me.cmbNumberOfChildren.FormattingEnabled = True
        Me.cmbNumberOfChildren.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbNumberOfChildren.Location = New System.Drawing.Point(116, 371)
        Me.cmbNumberOfChildren.Name = "cmbNumberOfChildren"
        Me.cmbNumberOfChildren.Size = New System.Drawing.Size(43, 21)
        Me.cmbNumberOfChildren.TabIndex = 18
        '
        'txtAgesOfChildren
        '
        Me.txtAgesOfChildren.Location = New System.Drawing.Point(116, 425)
        Me.txtAgesOfChildren.Name = "txtAgesOfChildren"
        Me.txtAgesOfChildren.Size = New System.Drawing.Size(100, 20)
        Me.txtAgesOfChildren.TabIndex = 20
        '
        'cmbTown
        '
        Me.cmbTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTown.FormattingEnabled = True
        Me.cmbTown.Location = New System.Drawing.Point(73, 160)
        Me.cmbTown.Name = "cmbTown"
        Me.cmbTown.Size = New System.Drawing.Size(121, 21)
        Me.cmbTown.TabIndex = 7
        '
        'txtCaseNumber
        '
        Me.txtCaseNumber.Location = New System.Drawing.Point(148, 9)
        Me.txtCaseNumber.MaxLength = 6
        Me.txtCaseNumber.Name = "txtCaseNumber"
        Me.txtCaseNumber.Size = New System.Drawing.Size(75, 20)
        Me.txtCaseNumber.TabIndex = 1
        '
        'btnNewTown
        '
        Me.btnNewTown.Location = New System.Drawing.Point(200, 161)
        Me.btnNewTown.Name = "btnNewTown"
        Me.btnNewTown.Size = New System.Drawing.Size(75, 21)
        Me.btnNewTown.TabIndex = 8
        Me.btnNewTown.Text = "New town"
        Me.btnNewTown.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(196, 215)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "Cell:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhoneC
        '
        Me.txtPhoneC.Location = New System.Drawing.Point(237, 212)
        Me.txtPhoneC.Name = "txtPhoneC"
        Me.txtPhoneC.Size = New System.Drawing.Size(76, 20)
        Me.txtPhoneC.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(320, 215)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Work:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhoneW
        '
        Me.txtPhoneW.Location = New System.Drawing.Point(362, 212)
        Me.txtPhoneW.Name = "txtPhoneW"
        Me.txtPhoneW.Size = New System.Drawing.Size(76, 20)
        Me.txtPhoneW.TabIndex = 12
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(282, 136)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(120, 20)
        Me.txtAddress2.TabIndex = 6
        '
        'grpVisits
        '
        Me.grpVisits.Controls.Add(Me.lstOfVisits)
        Me.grpVisits.Location = New System.Drawing.Point(315, 289)
        Me.grpVisits.Name = "grpVisits"
        Me.grpVisits.Size = New System.Drawing.Size(154, 172)
        Me.grpVisits.TabIndex = 122
        Me.grpVisits.TabStop = False
        Me.grpVisits.Text = "Recent visits"
        '
        'lstOfVisits
        '
        Me.lstOfVisits.FormattingEnabled = True
        Me.lstOfVisits.Location = New System.Drawing.Point(6, 19)
        Me.lstOfVisits.Name = "lstOfVisits"
        Me.lstOfVisits.Size = New System.Drawing.Size(138, 147)
        Me.lstOfVisits.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(6, 398)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 20)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Number of seniors:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNumberOfSeniors
        '
        Me.cmbNumberOfSeniors.FormattingEnabled = True
        Me.cmbNumberOfSeniors.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbNumberOfSeniors.Location = New System.Drawing.Point(116, 398)
        Me.cmbNumberOfSeniors.Name = "cmbNumberOfSeniors"
        Me.cmbNumberOfSeniors.Size = New System.Drawing.Size(43, 21)
        Me.cmbNumberOfSeniors.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(70, 321)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 126
        Me.Label19.Text = "Notes:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(114, 318)
        Me.txtNotes.MaxLength = 25
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(195, 20)
        Me.txtNotes.TabIndex = 2
        '
        'chkDeaf
        '
        Me.chkDeaf.AutoSize = True
        Me.chkDeaf.Location = New System.Drawing.Point(205, 4)
        Me.chkDeaf.Name = "chkDeaf"
        Me.chkDeaf.Size = New System.Drawing.Size(49, 17)
        Me.chkDeaf.TabIndex = 23
        Me.chkDeaf.Text = "Deaf"
        Me.chkDeaf.UseVisualStyleBackColor = True
        '
        'lblLastUpdated
        '
        Me.lblLastUpdated.Location = New System.Drawing.Point(10, 292)
        Me.lblLastUpdated.Name = "lblLastUpdated"
        Me.lblLastUpdated.Size = New System.Drawing.Size(100, 20)
        Me.lblLastUpdated.TabIndex = 130
        Me.lblLastUpdated.Text = "Date last updated:"
        Me.lblLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLastUpdated.Visible = False
        '
        'datLastUpdated
        '
        Me.datLastUpdated.Enabled = False
        Me.datLastUpdated.Location = New System.Drawing.Point(116, 292)
        Me.datLastUpdated.Name = "datLastUpdated"
        Me.datLastUpdated.Size = New System.Drawing.Size(200, 20)
        Me.datLastUpdated.TabIndex = 15
        Me.datLastUpdated.Visible = False
        '
        'lblReOpened
        '
        Me.lblReOpened.AutoSize = True
        Me.lblReOpened.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReOpened.ForeColor = System.Drawing.Color.Red
        Me.lblReOpened.Location = New System.Drawing.Point(333, 241)
        Me.lblReOpened.Name = "lblReOpened"
        Me.lblReOpened.Size = New System.Drawing.Size(69, 13)
        Me.lblReOpened.TabIndex = 131
        Me.lblReOpened.Text = "Re-opened"
        Me.lblReOpened.Visible = False
        '
        'chkUpdateDateUpdated
        '
        Me.chkUpdateDateUpdated.AutoSize = True
        Me.chkUpdateDateUpdated.Checked = True
        Me.chkUpdateDateUpdated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpdateDateUpdated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUpdateDateUpdated.Location = New System.Drawing.Point(323, 266)
        Me.chkUpdateDateUpdated.Name = "chkUpdateDateUpdated"
        Me.chkUpdateDateUpdated.Size = New System.Drawing.Size(146, 17)
        Me.chkUpdateDateUpdated.TabIndex = 16
        Me.chkUpdateDateUpdated.Text = "Update date last updated"
        Me.chkUpdateDateUpdated.UseVisualStyleBackColor = True
        Me.chkUpdateDateUpdated.Visible = False
        '
        'chkRegistrationIsComplete
        '
        Me.chkRegistrationIsComplete.AutoSize = True
        Me.chkRegistrationIsComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRegistrationIsComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegistrationIsComplete.ForeColor = System.Drawing.Color.Red
        Me.chkRegistrationIsComplete.Location = New System.Drawing.Point(300, 8)
        Me.chkRegistrationIsComplete.Name = "chkRegistrationIsComplete"
        Me.chkRegistrationIsComplete.Size = New System.Drawing.Size(162, 17)
        Me.chkRegistrationIsComplete.TabIndex = 132
        Me.chkRegistrationIsComplete.Text = "Registration is complete"
        Me.chkRegistrationIsComplete.UseVisualStyleBackColor = True
        '
        'chkMilitary
        '
        Me.chkMilitary.AutoSize = True
        Me.chkMilitary.Location = New System.Drawing.Point(4, 4)
        Me.chkMilitary.Name = "chkMilitary"
        Me.chkMilitary.Size = New System.Drawing.Size(58, 17)
        Me.chkMilitary.TabIndex = 133
        Me.chkMilitary.Text = "Military"
        Me.chkMilitary.UseVisualStyleBackColor = True
        Me.chkMilitary.Visible = False
        '
        'grpOtherAdults
        '
        Me.grpOtherAdults.Controls.Add(Me.txtOtherAdults)
        Me.grpOtherAdults.Location = New System.Drawing.Point(282, 63)
        Me.grpOtherAdults.Name = "grpOtherAdults"
        Me.grpOtherAdults.Size = New System.Drawing.Size(179, 67)
        Me.grpOtherAdults.TabIndex = 134
        Me.grpOtherAdults.TabStop = False
        Me.grpOtherAdults.Text = "Other adults in the household"
        Me.grpOtherAdults.Visible = False
        '
        'txtOtherAdults
        '
        Me.txtOtherAdults.Location = New System.Drawing.Point(6, 18)
        Me.txtOtherAdults.Multiline = True
        Me.txtOtherAdults.Name = "txtOtherAdults"
        Me.txtOtherAdults.Size = New System.Drawing.Size(167, 43)
        Me.txtOtherAdults.TabIndex = 0
        '
        'chkSNAP
        '
        Me.chkSNAP.AutoSize = True
        Me.chkSNAP.Location = New System.Drawing.Point(209, 68)
        Me.chkSNAP.Name = "chkSNAP"
        Me.chkSNAP.Size = New System.Drawing.Size(55, 17)
        Me.chkSNAP.TabIndex = 135
        Me.chkSNAP.Text = "SNAP"
        Me.chkSNAP.UseVisualStyleBackColor = True
        '
        'chkWIC
        '
        Me.chkWIC.AutoSize = True
        Me.chkWIC.Location = New System.Drawing.Point(209, 24)
        Me.chkWIC.Name = "chkWIC"
        Me.chkWIC.Size = New System.Drawing.Size(47, 17)
        Me.chkWIC.TabIndex = 136
        Me.chkWIC.Text = "WIC"
        Me.chkWIC.UseVisualStyleBackColor = True
        '
        'btnDeleteTown
        '
        Me.btnDeleteTown.Location = New System.Drawing.Point(282, 161)
        Me.btnDeleteTown.Name = "btnDeleteTown"
        Me.btnDeleteTown.Size = New System.Drawing.Size(75, 21)
        Me.btnDeleteTown.TabIndex = 137
        Me.btnDeleteTown.Text = "Delete town"
        Me.btnDeleteTown.UseVisualStyleBackColor = True
        '
        'tbApptTime
        '
        Me.tbApptTime.Location = New System.Drawing.Point(148, 60)
        Me.tbApptTime.Name = "tbApptTime"
        Me.tbApptTime.Size = New System.Drawing.Size(75, 20)
        Me.tbApptTime.TabIndex = 138
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(60, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 20)
        Me.Label20.TabIndex = 139
        Me.Label20.Text = "Appt. Time:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbFuelAsst
        '
        Me.cbFuelAsst.AutoSize = True
        Me.cbFuelAsst.Location = New System.Drawing.Point(3, 24)
        Me.cbFuelAsst.Name = "cbFuelAsst"
        Me.cbFuelAsst.Size = New System.Drawing.Size(72, 17)
        Me.cbFuelAsst.TabIndex = 141
        Me.cbFuelAsst.Text = "Fuel Asst."
        Me.cbFuelAsst.UseVisualStyleBackColor = True
        '
        'cbMedicaid
        '
        Me.cbMedicaid.AutoSize = True
        Me.cbMedicaid.Location = New System.Drawing.Point(75, 24)
        Me.cbMedicaid.Name = "cbMedicaid"
        Me.cbMedicaid.Size = New System.Drawing.Size(69, 17)
        Me.cbMedicaid.TabIndex = 143
        Me.cbMedicaid.Text = "Medicaid"
        Me.cbMedicaid.UseVisualStyleBackColor = True
        '
        'cbAidBlind
        '
        Me.cbAidBlind.AutoSize = True
        Me.cbAidBlind.Location = New System.Drawing.Point(276, 22)
        Me.cbAidBlind.Name = "cbAidBlind"
        Me.cbAidBlind.Size = New System.Drawing.Size(113, 17)
        Me.cbAidBlind.TabIndex = 144
        Me.cbAidBlind.Text = "Aid to Needy Blind"
        Me.cbAidBlind.UseVisualStyleBackColor = True
        '
        'cbCSFP
        '
        Me.cbCSFP.AutoSize = True
        Me.cbCSFP.Location = New System.Drawing.Point(3, 45)
        Me.cbCSFP.Name = "cbCSFP"
        Me.cbCSFP.Size = New System.Drawing.Size(53, 17)
        Me.cbCSFP.TabIndex = 145
        Me.cbCSFP.Text = "CSFP"
        Me.cbCSFP.UseVisualStyleBackColor = True
        '
        'cbOldAge
        '
        Me.cbOldAge.AutoSize = True
        Me.cbOldAge.Location = New System.Drawing.Point(75, 45)
        Me.cbOldAge.Name = "cbOldAge"
        Me.cbOldAge.Size = New System.Drawing.Size(90, 17)
        Me.cbOldAge.TabIndex = 146
        Me.cbOldAge.Text = "Old Age Asst."
        Me.cbOldAge.UseVisualStyleBackColor = True
        '
        'cbTANF
        '
        Me.cbTANF.AutoSize = True
        Me.cbTANF.Location = New System.Drawing.Point(209, 45)
        Me.cbTANF.Name = "cbTANF"
        Me.cbTANF.Size = New System.Drawing.Size(54, 17)
        Me.cbTANF.TabIndex = 147
        Me.cbTANF.Text = "TANF"
        Me.cbTANF.UseVisualStyleBackColor = True
        '
        'cbSubsHousing
        '
        Me.cbSubsHousing.AutoSize = True
        Me.cbSubsHousing.Location = New System.Drawing.Point(276, 45)
        Me.cbSubsHousing.Name = "cbSubsHousing"
        Me.cbSubsHousing.Size = New System.Drawing.Size(95, 17)
        Me.cbSubsHousing.TabIndex = 148
        Me.cbSubsHousing.Text = "Subs. Housing"
        Me.cbSubsHousing.UseVisualStyleBackColor = True
        '
        'cbAPTD
        '
        Me.cbAPTD.AutoSize = True
        Me.cbAPTD.Location = New System.Drawing.Point(3, 68)
        Me.cbAPTD.Name = "cbAPTD"
        Me.cbAPTD.Size = New System.Drawing.Size(55, 17)
        Me.cbAPTD.TabIndex = 149
        Me.cbAPTD.Text = "APTD"
        Me.cbAPTD.UseVisualStyleBackColor = True
        '
        'cbHeadStart
        '
        Me.cbHeadStart.AutoSize = True
        Me.cbHeadStart.Location = New System.Drawing.Point(276, 67)
        Me.cbHeadStart.Name = "cbHeadStart"
        Me.cbHeadStart.Size = New System.Drawing.Size(77, 17)
        Me.cbHeadStart.TabIndex = 151
        Me.cbHeadStart.Text = "Head Start"
        Me.cbHeadStart.UseVisualStyleBackColor = True
        '
        'cbWelfare
        '
        Me.cbWelfare.AutoSize = True
        Me.cbWelfare.Location = New System.Drawing.Point(75, 68)
        Me.cbWelfare.Name = "cbWelfare"
        Me.cbWelfare.Size = New System.Drawing.Size(119, 17)
        Me.cbWelfare.TabIndex = 152
        Me.cbWelfare.Text = "Cnty/Town Welfare"
        Me.cbWelfare.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(24, 463)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 15)
        Me.Label21.TabIndex = 153
        Me.Label21.Text = "Eligiblity"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.cbIncomeEligible)
        Me.Panel1.Controls.Add(Me.cbFuelAsst)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.cbAidBlind)
        Me.Panel1.Controls.Add(Me.cbHeadStart)
        Me.Panel1.Controls.Add(Me.cbWelfare)
        Me.Panel1.Controls.Add(Me.cbMedicaid)
        Me.Panel1.Controls.Add(Me.chkWIC)
        Me.Panel1.Controls.Add(Me.cbAPTD)
        Me.Panel1.Controls.Add(Me.chkSNAP)
        Me.Panel1.Controls.Add(Me.cbCSFP)
        Me.Panel1.Controls.Add(Me.cbSubsHousing)
        Me.Panel1.Controls.Add(Me.cbOldAge)
        Me.Panel1.Controls.Add(Me.cbTANF)
        Me.Panel1.Location = New System.Drawing.Point(27, 480)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 125)
        Me.Panel1.TabIndex = 156
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(170, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 156
        Me.Label23.Text = "Program"
        '
        'cbIncomeEligible
        '
        Me.cbIncomeEligible.AutoSize = True
        Me.cbIncomeEligible.Location = New System.Drawing.Point(148, 104)
        Me.cbIncomeEligible.Name = "cbIncomeEligible"
        Me.cbIncomeEligible.Size = New System.Drawing.Size(97, 17)
        Me.cbIncomeEligible.TabIndex = 155
        Me.cbIncomeEligible.Text = "Income Eligible"
        Me.cbIncomeEligible.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(182, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 13)
        Me.Label22.TabIndex = 154
        Me.Label22.Text = "OR"
        '
        'pnlClient
        '
        Me.pnlClient.AutoScroll = True
        Me.pnlClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlClient.Controls.Add(Me.Label33)
        Me.pnlClient.Controls.Add(Me.Label32)
        Me.pnlClient.Controls.Add(Me.cmbFemaleSeniors)
        Me.pnlClient.Controls.Add(Me.cmbFemaleChildren)
        Me.pnlClient.Controls.Add(Me.cmbFemaleAdults)
        Me.pnlClient.Controls.Add(Me.Label31)
        Me.pnlClient.Controls.Add(Me.Label30)
        Me.pnlClient.Controls.Add(Me.Label29)
        Me.pnlClient.Controls.Add(Me.Label28)
        Me.pnlClient.Controls.Add(Me.cmbMaleSeniors)
        Me.pnlClient.Controls.Add(Me.cmbMaleChildren)
        Me.pnlClient.Controls.Add(Me.cmbMaleAdults)
        Me.pnlClient.Controls.Add(Me.datApptDate)
        Me.pnlClient.Controls.Add(Me.Label27)
        Me.pnlClient.Controls.Add(Me.Label26)
        Me.pnlClient.Controls.Add(Me.Panel2)
        Me.pnlClient.Controls.Add(Me.Label21)
        Me.pnlClient.Controls.Add(Me.Panel1)
        Me.pnlClient.Controls.Add(Me.Label20)
        Me.pnlClient.Controls.Add(Me.tbApptTime)
        Me.pnlClient.Controls.Add(Me.btnDeleteTown)
        Me.pnlClient.Controls.Add(Me.grpOtherAdults)
        Me.pnlClient.Controls.Add(Me.chkRegistrationIsComplete)
        Me.pnlClient.Controls.Add(Me.chkUpdateDateUpdated)
        Me.pnlClient.Controls.Add(Me.lblReOpened)
        Me.pnlClient.Controls.Add(Me.datLastUpdated)
        Me.pnlClient.Controls.Add(Me.lblLastUpdated)
        Me.pnlClient.Controls.Add(Me.txtNotes)
        Me.pnlClient.Controls.Add(Me.Label19)
        Me.pnlClient.Controls.Add(Me.cmbNumberOfSeniors)
        Me.pnlClient.Controls.Add(Me.Label15)
        Me.pnlClient.Controls.Add(Me.grpVisits)
        Me.pnlClient.Controls.Add(Me.txtAddress2)
        Me.pnlClient.Controls.Add(Me.txtPhoneW)
        Me.pnlClient.Controls.Add(Me.Label16)
        Me.pnlClient.Controls.Add(Me.txtPhoneC)
        Me.pnlClient.Controls.Add(Me.Label14)
        Me.pnlClient.Controls.Add(Me.btnNewTown)
        Me.pnlClient.Controls.Add(Me.txtCaseNumber)
        Me.pnlClient.Controls.Add(Me.cmbTown)
        Me.pnlClient.Controls.Add(Me.txtAgesOfChildren)
        Me.pnlClient.Controls.Add(Me.cmbNumberOfChildren)
        Me.pnlClient.Controls.Add(Me.cmbNumberOfAdults)
        Me.pnlClient.Controls.Add(Me.datReopened)
        Me.pnlClient.Controls.Add(Me.datStarted)
        Me.pnlClient.Controls.Add(Me.txtPhoneH)
        Me.pnlClient.Controls.Add(Me.txtZip)
        Me.pnlClient.Controls.Add(Me.txtAddress)
        Me.pnlClient.Controls.Add(Me.txtLastName)
        Me.pnlClient.Controls.Add(Me.txtFirstName)
        Me.pnlClient.Controls.Add(Me.chkActive)
        Me.pnlClient.Controls.Add(Me.Label13)
        Me.pnlClient.Controls.Add(Me.Label12)
        Me.pnlClient.Controls.Add(Me.Label11)
        Me.pnlClient.Controls.Add(Me.Label10)
        Me.pnlClient.Controls.Add(Me.Label9)
        Me.pnlClient.Controls.Add(Me.Label8)
        Me.pnlClient.Controls.Add(Me.Label7)
        Me.pnlClient.Controls.Add(Me.Label6)
        Me.pnlClient.Controls.Add(Me.Label5)
        Me.pnlClient.Controls.Add(Me.Label4)
        Me.pnlClient.Controls.Add(Me.Label3)
        Me.pnlClient.Controls.Add(Me.Label1)
        Me.pnlClient.Location = New System.Drawing.Point(307, 12)
        Me.pnlClient.Name = "pnlClient"
        Me.pnlClient.Size = New System.Drawing.Size(488, 473)
        Me.pnlClient.TabIndex = 0
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(249, 398)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(24, 20)
        Me.Label33.TabIndex = 172
        Me.Label33.Text = "F:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(249, 372)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 20)
        Me.Label32.TabIndex = 171
        Me.Label32.Text = "F:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFemaleSeniors
        '
        Me.cmbFemaleSeniors.FormattingEnabled = True
        Me.cmbFemaleSeniors.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbFemaleSeniors.Location = New System.Drawing.Point(274, 399)
        Me.cmbFemaleSeniors.Name = "cmbFemaleSeniors"
        Me.cmbFemaleSeniors.Size = New System.Drawing.Size(35, 21)
        Me.cmbFemaleSeniors.TabIndex = 170
        '
        'cmbFemaleChildren
        '
        Me.cmbFemaleChildren.FormattingEnabled = True
        Me.cmbFemaleChildren.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbFemaleChildren.Location = New System.Drawing.Point(274, 372)
        Me.cmbFemaleChildren.Name = "cmbFemaleChildren"
        Me.cmbFemaleChildren.Size = New System.Drawing.Size(35, 21)
        Me.cmbFemaleChildren.TabIndex = 169
        '
        'cmbFemaleAdults
        '
        Me.cmbFemaleAdults.FormattingEnabled = True
        Me.cmbFemaleAdults.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbFemaleAdults.Location = New System.Drawing.Point(274, 345)
        Me.cmbFemaleAdults.Name = "cmbFemaleAdults"
        Me.cmbFemaleAdults.Size = New System.Drawing.Size(35, 21)
        Me.cmbFemaleAdults.TabIndex = 168
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(174, 398)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 20)
        Me.Label31.TabIndex = 167
        Me.Label31.Text = "M:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(174, 372)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(24, 20)
        Me.Label30.TabIndex = 166
        Me.Label30.Text = "M:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(249, 343)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(24, 20)
        Me.Label29.TabIndex = 165
        Me.Label29.Text = "F:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(174, 343)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(24, 20)
        Me.Label28.TabIndex = 164
        Me.Label28.Text = "M:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMaleSeniors
        '
        Me.cmbMaleSeniors.FormattingEnabled = True
        Me.cmbMaleSeniors.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbMaleSeniors.Location = New System.Drawing.Point(199, 398)
        Me.cmbMaleSeniors.Name = "cmbMaleSeniors"
        Me.cmbMaleSeniors.Size = New System.Drawing.Size(35, 21)
        Me.cmbMaleSeniors.TabIndex = 163
        '
        'cmbMaleChildren
        '
        Me.cmbMaleChildren.FormattingEnabled = True
        Me.cmbMaleChildren.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbMaleChildren.Location = New System.Drawing.Point(199, 371)
        Me.cmbMaleChildren.Name = "cmbMaleChildren"
        Me.cmbMaleChildren.Size = New System.Drawing.Size(35, 21)
        Me.cmbMaleChildren.TabIndex = 162
        '
        'cmbMaleAdults
        '
        Me.cmbMaleAdults.FormattingEnabled = True
        Me.cmbMaleAdults.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbMaleAdults.Location = New System.Drawing.Point(199, 344)
        Me.cmbMaleAdults.Name = "cmbMaleAdults"
        Me.cmbMaleAdults.Size = New System.Drawing.Size(35, 21)
        Me.cmbMaleAdults.TabIndex = 161
        '
        'datApptDate
        '
        Me.datApptDate.Location = New System.Drawing.Point(148, 34)
        Me.datApptDate.Name = "datApptDate"
        Me.datApptDate.Size = New System.Drawing.Size(200, 20)
        Me.datApptDate.TabIndex = 159
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(42, 34)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 20)
        Me.Label27.TabIndex = 160
        Me.Label27.Text = "Appt Date"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(26, 614)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(119, 15)
        Me.Label26.TabIndex = 158
        Me.Label26.Text = "Other Information"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tbSpecialReq)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.tbFoodAllergies)
        Me.Panel2.Controls.Add(Me.cbNoPork)
        Me.Panel2.Controls.Add(Me.cbNoCooking)
        Me.Panel2.Controls.Add(Me.chkHomeless)
        Me.Panel2.Controls.Add(Me.chkDiabetic)
        Me.Panel2.Controls.Add(Me.chkMilitary)
        Me.Panel2.Controls.Add(Me.chkDeaf)
        Me.Panel2.Location = New System.Drawing.Point(27, 632)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 178)
        Me.Panel2.TabIndex = 157
        '
        'tbSpecialReq
        '
        Me.tbSpecialReq.Location = New System.Drawing.Point(105, 58)
        Me.tbSpecialReq.MaxLength = 75
        Me.tbSpecialReq.Multiline = True
        Me.tbSpecialReq.Name = "tbSpecialReq"
        Me.tbSpecialReq.Size = New System.Drawing.Size(280, 50)
        Me.tbSpecialReq.TabIndex = 162
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 61)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 13)
        Me.Label24.TabIndex = 161
        Me.Label24.Text = "Special Requests"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(23, 134)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 13)
        Me.Label25.TabIndex = 159
        Me.Label25.Text = "Food Allergies:"
        '
        'tbFoodAllergies
        '
        Me.tbFoodAllergies.Location = New System.Drawing.Point(105, 131)
        Me.tbFoodAllergies.MaxLength = 75
        Me.tbFoodAllergies.Multiline = True
        Me.tbFoodAllergies.Name = "tbFoodAllergies"
        Me.tbFoodAllergies.Size = New System.Drawing.Size(280, 42)
        Me.tbFoodAllergies.TabIndex = 158
        '
        'cbNoPork
        '
        Me.cbNoPork.AutoSize = True
        Me.cbNoPork.Location = New System.Drawing.Point(3, 27)
        Me.cbNoPork.Name = "cbNoPork"
        Me.cbNoPork.Size = New System.Drawing.Size(65, 17)
        Me.cbNoPork.TabIndex = 157
        Me.cbNoPork.Text = "No Pork"
        Me.cbNoPork.UseVisualStyleBackColor = True
        '
        'cbNoCooking
        '
        Me.cbNoCooking.AutoSize = True
        Me.cbNoCooking.Location = New System.Drawing.Point(205, 27)
        Me.cbNoCooking.Name = "cbNoCooking"
        Me.cbNoCooking.Size = New System.Drawing.Size(117, 17)
        Me.cbNoCooking.TabIndex = 155
        Me.cbNoCooking.Text = "No Cooking Facility"
        Me.cbNoCooking.UseVisualStyleBackColor = True
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 697
        Me.ReSize1.InitialHostContainerWidth = 795
        Me.ReSize1.Tag = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 697)
        Me.Controls.Add(Me.lblTotalDeliveriesToday)
        Me.Controls.Add(Me.btnSpecial)
        Me.Controls.Add(Me.chkDelivery)
        Me.Controls.Add(Me.btnUnVisit)
        Me.Controls.Add(Me.lblTotalVisitsToday)
        Me.Controls.Add(Me.txtSearchClientNumber)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblCurrentlySelected)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.optInactive)
        Me.Controls.Add(Me.optActive)
        Me.Controls.Add(Me.btnPrintSample)
        Me.Controls.Add(Me.chkPrintIt)
        Me.Controls.Add(Me.pnlClient)
        Me.Controls.Add(Me.pnlClients)
        Me.Controls.Add(Me.txtSearchLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRecordAndPrint)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlClients.ResumeLayout(False)
        Me.grpVisits.ResumeLayout(False)
        Me.grpOtherAdults.ResumeLayout(False)
        Me.grpOtherAdults.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlClient.ResumeLayout(False)
        Me.pnlClient.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileChangeDBLocation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditFoodItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearchLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRecordAndPrint As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents pnlClients As System.Windows.Forms.Panel
    Friend WithEvents lvClients As System.Windows.Forms.ListView
    Friend WithEvents mnuEditItemsMaintain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditVisits As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkPrintIt As System.Windows.Forms.CheckBox
    Friend WithEvents mnuFileSQL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintSample As System.Windows.Forms.Button
    Friend WithEvents optInactive As System.Windows.Forms.RadioButton
    Friend WithEvents optActive As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentlySelected As System.Windows.Forms.Label
    Friend WithEvents txtSearchClientNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents mnuReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportVisits As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTotalVisitsToday As System.Windows.Forms.Label
    Friend WithEvents btnUnVisit As System.Windows.Forms.Button
    Friend WithEvents mnuHelpCLA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileFixhtmlPages As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportExtract As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents btnSpecial As System.Windows.Forms.Button
    Friend WithEvents mnuReportTodaysDeliveries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTotalDeliveriesToday As System.Windows.Forms.Label
    Friend WithEvents mnuEditItemsGroupItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpChanges As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportCounts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileRestoreVisitsFromBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlClient As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbFuelAsst As System.Windows.Forms.CheckBox
    Friend WithEvents cbAidBlind As System.Windows.Forms.CheckBox
    Friend WithEvents cbMedicaid As System.Windows.Forms.CheckBox
    Friend WithEvents chkWIC As System.Windows.Forms.CheckBox
    Friend WithEvents cbAPTD As System.Windows.Forms.CheckBox
    Friend WithEvents cbCSFP As System.Windows.Forms.CheckBox
    Friend WithEvents cbSubsHousing As System.Windows.Forms.CheckBox
    Friend WithEvents cbOldAge As System.Windows.Forms.CheckBox
    Friend WithEvents cbTANF As System.Windows.Forms.CheckBox
    Friend WithEvents cbIncomeEligible As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbWelfare As System.Windows.Forms.CheckBox
    Friend WithEvents cbHeadStart As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbApptTime As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteTown As System.Windows.Forms.Button
    Friend WithEvents chkSNAP As System.Windows.Forms.CheckBox
    Friend WithEvents grpOtherAdults As System.Windows.Forms.GroupBox
    Friend WithEvents txtOtherAdults As System.Windows.Forms.TextBox
    Friend WithEvents chkMilitary As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegistrationIsComplete As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpdateDateUpdated As System.Windows.Forms.CheckBox
    Friend WithEvents lblReOpened As System.Windows.Forms.Label
    Friend WithEvents datLastUpdated As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLastUpdated As System.Windows.Forms.Label
    Friend WithEvents chkDeaf As System.Windows.Forms.CheckBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbNumberOfSeniors As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents grpVisits As System.Windows.Forms.GroupBox
    Friend WithEvents lstOfVisits As System.Windows.Forms.ListBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneW As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneC As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnNewTown As System.Windows.Forms.Button
    Friend WithEvents txtCaseNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmbTown As System.Windows.Forms.ComboBox
    Friend WithEvents txtAgesOfChildren As System.Windows.Forms.TextBox
    Friend WithEvents cmbNumberOfChildren As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNumberOfAdults As System.Windows.Forms.ComboBox
    Friend WithEvents datReopened As System.Windows.Forms.DateTimePicker
    Friend WithEvents datStarted As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPhoneH As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents chkHomeless As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiabetic As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbNoPork As System.Windows.Forms.CheckBox
    Friend WithEvents cbNoCooking As System.Windows.Forms.CheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tbFoodAllergies As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents tbSpecialReq As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents datApptDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbMaleSeniors As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMaleChildren As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMaleAdults As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cmbFemaleSeniors As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFemaleChildren As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFemaleAdults As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents UpdateItemTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

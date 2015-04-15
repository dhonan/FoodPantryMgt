<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.grpVisits = New System.Windows.Forms.GroupBox
        Me.grpDateRange = New System.Windows.Forms.GroupBox
        Me.datTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.datFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.optDateRange = New System.Windows.Forms.RadioButton
        Me.optVisitsLastWeek = New System.Windows.Forms.RadioButton
        Me.grpReport = New System.Windows.Forms.GroupBox
        Me.lblDeliveries = New System.Windows.Forms.Label
        Me.lblNumberOfSeniors = New System.Windows.Forms.Label
        Me.lblNumberNew = New System.Windows.Forms.Label
        Me.lblBags = New System.Windows.Forms.Label
        Me.lblInactiveToActive = New System.Windows.Forms.Label
        Me.lblNumberOfChildren = New System.Windows.Forms.Label
        Me.lblNumberOfAdults = New System.Windows.Forms.Label
        Me.lblTotalVisits = New System.Windows.Forms.Label
        Me.lvVisits = New System.Windows.Forms.ListView
        Me.Town = New System.Windows.Forms.ColumnHeader
        Me.Visits = New System.Windows.Forms.ColumnHeader
        Me.Adults = New System.Windows.Forms.ColumnHeader
        Me.Seniors = New System.Windows.Forms.ColumnHeader
        Me.Children = New System.Windows.Forms.ColumnHeader
        Me.Total = New System.Windows.Forms.ColumnHeader
        Me.Bags = New System.Windows.Forms.ColumnHeader
        Me.InactiveToActive = New System.Windows.Forms.ColumnHeader
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.grpTowns = New System.Windows.Forms.GroupBox
        Me.lstOfTowns = New System.Windows.Forms.ListBox
        Me.grpOther = New System.Windows.Forms.GroupBox
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkOnlyFamliesWithChildren = New System.Windows.Forms.CheckBox
        Me.chkActiveToInactive = New System.Windows.Forms.CheckBox
        Me.chkOnlyActive = New System.Windows.Forms.CheckBox
        Me.chkOnlySeniors = New System.Windows.Forms.CheckBox
        Me.chkOnlyHomeless = New System.Windows.Forms.CheckBox
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.lblCountDown = New System.Windows.Forms.Label
        Me.btnExtract = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.btnDone = New System.Windows.Forms.Button
        Me.grpVisitsByHour = New System.Windows.Forms.GroupBox
        Me.lvByHour = New System.Windows.Forms.ListView
        Me.Hour = New System.Windows.Forms.ColumnHeader
        Me.Count = New System.Windows.Forms.ColumnHeader
        Me.Veterans = New System.Windows.Forms.ColumnHeader
        Me.grpVisits.SuspendLayout()
        Me.grpDateRange.SuspendLayout()
        Me.grpReport.SuspendLayout()
        Me.grpTowns.SuspendLayout()
        Me.grpOther.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.grpVisitsByHour.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 786
        Me.ReSize1.InitialHostContainerWidth = 791
        Me.ReSize1.Tag = Nothing
        '
        'grpVisits
        '
        Me.grpVisits.Controls.Add(Me.grpDateRange)
        Me.grpVisits.Controls.Add(Me.optDateRange)
        Me.grpVisits.Controls.Add(Me.optVisitsLastWeek)
        Me.grpVisits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVisits.ForeColor = System.Drawing.Color.Blue
        Me.grpVisits.Location = New System.Drawing.Point(12, 12)
        Me.grpVisits.Name = "grpVisits"
        Me.grpVisits.Size = New System.Drawing.Size(382, 113)
        Me.grpVisits.TabIndex = 0
        Me.grpVisits.TabStop = False
        Me.grpVisits.Text = "Date range"
        '
        'grpDateRange
        '
        Me.grpDateRange.Controls.Add(Me.datTo)
        Me.grpDateRange.Controls.Add(Me.Label2)
        Me.grpDateRange.Controls.Add(Me.datFrom)
        Me.grpDateRange.Controls.Add(Me.Label1)
        Me.grpDateRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDateRange.ForeColor = System.Drawing.Color.Black
        Me.grpDateRange.Location = New System.Drawing.Point(103, 38)
        Me.grpDateRange.Name = "grpDateRange"
        Me.grpDateRange.Size = New System.Drawing.Size(270, 69)
        Me.grpDateRange.TabIndex = 2
        Me.grpDateRange.TabStop = False
        Me.grpDateRange.Text = "Range"
        Me.grpDateRange.Visible = False
        '
        'datTo
        '
        Me.datTo.Location = New System.Drawing.Point(57, 42)
        Me.datTo.Name = "datTo"
        Me.datTo.Size = New System.Drawing.Size(203, 20)
        Me.datTo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To:"
        '
        'datFrom
        '
        Me.datFrom.Location = New System.Drawing.Point(57, 16)
        Me.datFrom.Name = "datFrom"
        Me.datFrom.Size = New System.Drawing.Size(203, 20)
        Me.datFrom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'optDateRange
        '
        Me.optDateRange.AutoSize = True
        Me.optDateRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDateRange.ForeColor = System.Drawing.Color.Black
        Me.optDateRange.Location = New System.Drawing.Point(19, 42)
        Me.optDateRange.Name = "optDateRange"
        Me.optDateRange.Size = New System.Drawing.Size(78, 17)
        Me.optDateRange.TabIndex = 1
        Me.optDateRange.Text = "Date range"
        Me.optDateRange.UseVisualStyleBackColor = True
        '
        'optVisitsLastWeek
        '
        Me.optVisitsLastWeek.AutoSize = True
        Me.optVisitsLastWeek.Checked = True
        Me.optVisitsLastWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVisitsLastWeek.ForeColor = System.Drawing.Color.Black
        Me.optVisitsLastWeek.Location = New System.Drawing.Point(19, 15)
        Me.optVisitsLastWeek.Name = "optVisitsLastWeek"
        Me.optVisitsLastWeek.Size = New System.Drawing.Size(83, 17)
        Me.optVisitsLastWeek.TabIndex = 0
        Me.optVisitsLastWeek.TabStop = True
        Me.optVisitsLastWeek.Text = "Latest week"
        Me.optVisitsLastWeek.UseVisualStyleBackColor = True
        '
        'grpReport
        '
        Me.grpReport.Controls.Add(Me.lblDeliveries)
        Me.grpReport.Controls.Add(Me.lblNumberOfSeniors)
        Me.grpReport.Controls.Add(Me.lblNumberNew)
        Me.grpReport.Controls.Add(Me.lblBags)
        Me.grpReport.Controls.Add(Me.lblInactiveToActive)
        Me.grpReport.Controls.Add(Me.lblNumberOfChildren)
        Me.grpReport.Controls.Add(Me.lblNumberOfAdults)
        Me.grpReport.Controls.Add(Me.lblTotalVisits)
        Me.grpReport.Controls.Add(Me.lvVisits)
        Me.grpReport.Location = New System.Drawing.Point(21, 446)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(658, 328)
        Me.grpReport.TabIndex = 6
        Me.grpReport.TabStop = False
        Me.grpReport.Visible = False
        '
        'lblDeliveries
        '
        Me.lblDeliveries.AutoSize = True
        Me.lblDeliveries.Location = New System.Drawing.Point(252, 45)
        Me.lblDeliveries.Name = "lblDeliveries"
        Me.lblDeliveries.Size = New System.Drawing.Size(56, 13)
        Me.lblDeliveries.TabIndex = 14
        Me.lblDeliveries.Text = "Deliveries:"
        '
        'lblNumberOfSeniors
        '
        Me.lblNumberOfSeniors.AutoSize = True
        Me.lblNumberOfSeniors.Location = New System.Drawing.Point(222, 16)
        Me.lblNumberOfSeniors.Name = "lblNumberOfSeniors"
        Me.lblNumberOfSeniors.Size = New System.Drawing.Size(95, 13)
        Me.lblNumberOfSeniors.TabIndex = 13
        Me.lblNumberOfSeniors.Text = "Number of seniors:"
        '
        'lblNumberNew
        '
        Me.lblNumberNew.AutoSize = True
        Me.lblNumberNew.Location = New System.Drawing.Point(10, 44)
        Me.lblNumberNew.Name = "lblNumberNew"
        Me.lblNumberNew.Size = New System.Drawing.Size(32, 13)
        Me.lblNumberNew.TabIndex = 12
        Me.lblNumberNew.Text = "New:"
        '
        'lblBags
        '
        Me.lblBags.AutoSize = True
        Me.lblBags.Location = New System.Drawing.Point(487, 16)
        Me.lblBags.Name = "lblBags"
        Me.lblBags.Size = New System.Drawing.Size(60, 13)
        Me.lblBags.TabIndex = 11
        Me.lblBags.Text = "Total bags:"
        '
        'lblInactiveToActive
        '
        Me.lblInactiveToActive.AutoSize = True
        Me.lblInactiveToActive.Location = New System.Drawing.Point(115, 44)
        Me.lblInactiveToActive.Name = "lblInactiveToActive"
        Me.lblInactiveToActive.Size = New System.Drawing.Size(68, 13)
        Me.lblInactiveToActive.TabIndex = 10
        Me.lblInactiveToActive.Text = "Reactivated:"
        '
        'lblNumberOfChildren
        '
        Me.lblNumberOfChildren.AutoSize = True
        Me.lblNumberOfChildren.Location = New System.Drawing.Point(335, 16)
        Me.lblNumberOfChildren.Name = "lblNumberOfChildren"
        Me.lblNumberOfChildren.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberOfChildren.TabIndex = 9
        Me.lblNumberOfChildren.Text = "Number of children:"
        '
        'lblNumberOfAdults
        '
        Me.lblNumberOfAdults.AutoSize = True
        Me.lblNumberOfAdults.Location = New System.Drawing.Point(115, 16)
        Me.lblNumberOfAdults.Name = "lblNumberOfAdults"
        Me.lblNumberOfAdults.Size = New System.Drawing.Size(90, 13)
        Me.lblNumberOfAdults.TabIndex = 8
        Me.lblNumberOfAdults.Text = "Number of adults:"
        '
        'lblTotalVisits
        '
        Me.lblTotalVisits.AutoSize = True
        Me.lblTotalVisits.Location = New System.Drawing.Point(6, 16)
        Me.lblTotalVisits.Name = "lblTotalVisits"
        Me.lblTotalVisits.Size = New System.Drawing.Size(60, 13)
        Me.lblTotalVisits.TabIndex = 7
        Me.lblTotalVisits.Text = "Total visits:"
        '
        'lvVisits
        '
        Me.lvVisits.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Town, Me.Visits, Me.Veterans, Me.Adults, Me.Seniors, Me.Children, Me.Total, Me.Bags, Me.InactiveToActive})
        Me.lvVisits.Location = New System.Drawing.Point(0, 84)
        Me.lvVisits.Name = "lvVisits"
        Me.lvVisits.Size = New System.Drawing.Size(643, 235)
        Me.lvVisits.TabIndex = 6
        Me.lvVisits.UseCompatibleStateImageBehavior = False
        Me.lvVisits.View = System.Windows.Forms.View.Details
        '
        'Town
        '
        Me.Town.Text = "Town"
        Me.Town.Width = 109
        '
        'Visits
        '
        Me.Visits.Text = "Visits"
        Me.Visits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Visits.Width = 50
        '
        'Adults
        '
        Me.Adults.Text = "Adults"
        Me.Adults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Seniors
        '
        Me.Seniors.Text = "Seniors"
        Me.Seniors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Children
        '
        Me.Children.Text = "Children"
        Me.Children.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Total
        '
        Me.Total.Text = "Total people"
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.Width = 75
        '
        'Bags
        '
        Me.Bags.Text = "Bags"
        Me.Bags.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Bags.Width = 50
        '
        'InactiveToActive
        '
        Me.InactiveToActive.Text = "Inactive to Active"
        Me.InactiveToActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.InactiveToActive.Width = 100
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'grpTowns
        '
        Me.grpTowns.Controls.Add(Me.lstOfTowns)
        Me.grpTowns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTowns.ForeColor = System.Drawing.Color.Blue
        Me.grpTowns.Location = New System.Drawing.Point(400, 15)
        Me.grpTowns.Name = "grpTowns"
        Me.grpTowns.Size = New System.Drawing.Size(143, 126)
        Me.grpTowns.TabIndex = 11
        Me.grpTowns.TabStop = False
        Me.grpTowns.Text = "Only for these towns"
        '
        'lstOfTowns
        '
        Me.lstOfTowns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOfTowns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lstOfTowns.FormattingEnabled = True
        Me.lstOfTowns.Location = New System.Drawing.Point(10, 16)
        Me.lstOfTowns.Name = "lstOfTowns"
        Me.lstOfTowns.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstOfTowns.Size = New System.Drawing.Size(120, 108)
        Me.lstOfTowns.TabIndex = 0
        '
        'grpOther
        '
        Me.grpOther.Controls.Add(Me.txtNotes)
        Me.grpOther.Controls.Add(Me.Label3)
        Me.grpOther.Controls.Add(Me.chkOnlyFamliesWithChildren)
        Me.grpOther.Controls.Add(Me.chkActiveToInactive)
        Me.grpOther.Controls.Add(Me.chkOnlyActive)
        Me.grpOther.Controls.Add(Me.chkOnlySeniors)
        Me.grpOther.Controls.Add(Me.chkOnlyHomeless)
        Me.grpOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOther.ForeColor = System.Drawing.Color.Blue
        Me.grpOther.Location = New System.Drawing.Point(12, 131)
        Me.grpOther.Name = "grpOther"
        Me.grpOther.Size = New System.Drawing.Size(375, 108)
        Me.grpOther.TabIndex = 12
        Me.grpOther.TabStop = False
        Me.grpOther.Text = "Other criteria"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(273, 73)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(100, 20)
        Me.txtNotes.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Notes contains the word:"
        '
        'chkOnlyFamliesWithChildren
        '
        Me.chkOnlyFamliesWithChildren.AutoSize = True
        Me.chkOnlyFamliesWithChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnlyFamliesWithChildren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOnlyFamliesWithChildren.Location = New System.Drawing.Point(121, 50)
        Me.chkOnlyFamliesWithChildren.Name = "chkOnlyFamliesWithChildren"
        Me.chkOnlyFamliesWithChildren.Size = New System.Drawing.Size(144, 17)
        Me.chkOnlyFamliesWithChildren.TabIndex = 4
        Me.chkOnlyFamliesWithChildren.Text = "Only famlies with children"
        Me.chkOnlyFamliesWithChildren.UseVisualStyleBackColor = True
        '
        'chkActiveToInactive
        '
        Me.chkActiveToInactive.AutoSize = True
        Me.chkActiveToInactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActiveToInactive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkActiveToInactive.Location = New System.Drawing.Point(121, 25)
        Me.chkActiveToInactive.Name = "chkActiveToInactive"
        Me.chkActiveToInactive.Size = New System.Drawing.Size(131, 17)
        Me.chkActiveToInactive.TabIndex = 3
        Me.chkActiveToInactive.Text = "Only active to inactive"
        Me.chkActiveToInactive.UseVisualStyleBackColor = True
        '
        'chkOnlyActive
        '
        Me.chkOnlyActive.AutoSize = True
        Me.chkOnlyActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnlyActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOnlyActive.Location = New System.Drawing.Point(15, 75)
        Me.chkOnlyActive.Name = "chkOnlyActive"
        Me.chkOnlyActive.Size = New System.Drawing.Size(80, 17)
        Me.chkOnlyActive.TabIndex = 2
        Me.chkOnlyActive.Text = "Only Active"
        Me.chkOnlyActive.UseVisualStyleBackColor = True
        '
        'chkOnlySeniors
        '
        Me.chkOnlySeniors.AutoSize = True
        Me.chkOnlySeniors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnlySeniors.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOnlySeniors.Location = New System.Drawing.Point(15, 50)
        Me.chkOnlySeniors.Name = "chkOnlySeniors"
        Me.chkOnlySeniors.Size = New System.Drawing.Size(85, 17)
        Me.chkOnlySeniors.TabIndex = 1
        Me.chkOnlySeniors.Text = "Only Seniors"
        Me.chkOnlySeniors.UseVisualStyleBackColor = True
        '
        'chkOnlyHomeless
        '
        Me.chkOnlyHomeless.AutoSize = True
        Me.chkOnlyHomeless.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnlyHomeless.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOnlyHomeless.Location = New System.Drawing.Point(15, 25)
        Me.chkOnlyHomeless.Name = "chkOnlyHomeless"
        Me.chkOnlyHomeless.Size = New System.Drawing.Size(90, 17)
        Me.chkOnlyHomeless.TabIndex = 0
        Me.chkOnlyHomeless.Text = "Only FacLess"
        Me.chkOnlyHomeless.UseVisualStyleBackColor = True
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.lblCountDown)
        Me.pnlButtons.Controls.Add(Me.btnExtract)
        Me.pnlButtons.Controls.Add(Me.btnPrint)
        Me.pnlButtons.Controls.Add(Me.btnDisplay)
        Me.pnlButtons.Controls.Add(Me.btnDone)
        Me.pnlButtons.Location = New System.Drawing.Point(685, 594)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(96, 171)
        Me.pnlButtons.TabIndex = 14
        '
        'lblCountDown
        '
        Me.lblCountDown.AutoSize = True
        Me.lblCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountDown.ForeColor = System.Drawing.Color.Red
        Me.lblCountDown.Location = New System.Drawing.Point(32, 98)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(30, 31)
        Me.lblCountDown.TabIndex = 19
        Me.lblCountDown.Text = "0"
        Me.lblCountDown.Visible = False
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(21, 70)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(56, 25)
        Me.btnExtract.TabIndex = 18
        Me.btnExtract.Text = "Extract"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(21, 39)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(56, 25)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(21, 8)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(56, 25)
        Me.btnDisplay.TabIndex = 16
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(21, 136)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(65, 30)
        Me.btnDone.TabIndex = 15
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'grpVisitsByHour
        '
        Me.grpVisitsByHour.Controls.Add(Me.lvByHour)
        Me.grpVisitsByHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVisitsByHour.ForeColor = System.Drawing.Color.Blue
        Me.grpVisitsByHour.Location = New System.Drawing.Point(549, 15)
        Me.grpVisitsByHour.Name = "grpVisitsByHour"
        Me.grpVisitsByHour.Size = New System.Drawing.Size(162, 425)
        Me.grpVisitsByHour.TabIndex = 15
        Me.grpVisitsByHour.TabStop = False
        Me.grpVisitsByHour.Text = "Visits by hour"
        Me.grpVisitsByHour.Visible = False
        '
        'lvByHour
        '
        Me.lvByHour.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Hour, Me.Count})
        Me.lvByHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvByHour.Location = New System.Drawing.Point(7, 19)
        Me.lvByHour.Name = "lvByHour"
        Me.lvByHour.Size = New System.Drawing.Size(140, 400)
        Me.lvByHour.TabIndex = 0
        Me.lvByHour.UseCompatibleStateImageBehavior = False
        Me.lvByHour.View = System.Windows.Forms.View.Details
        '
        'Hour
        '
        Me.Hour.Text = "Hour"
        Me.Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Hour.Width = 47
        '
        'Count
        '
        Me.Count.Text = "Visits"
        Me.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Count.Width = 47
        '
        'Veterans
        '
        Me.Veterans.Text = "Veterans"
        Me.Veterans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 786)
        Me.Controls.Add(Me.grpVisitsByHour)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.grpOther)
        Me.Controls.Add(Me.grpTowns)
        Me.Controls.Add(Me.grpReport)
        Me.Controls.Add(Me.grpVisits)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reports"
        Me.grpVisits.ResumeLayout(False)
        Me.grpVisits.PerformLayout()
        Me.grpDateRange.ResumeLayout(False)
        Me.grpDateRange.PerformLayout()
        Me.grpReport.ResumeLayout(False)
        Me.grpReport.PerformLayout()
        Me.grpTowns.ResumeLayout(False)
        Me.grpOther.ResumeLayout(False)
        Me.grpOther.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        Me.grpVisitsByHour.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents grpVisits As System.Windows.Forms.GroupBox
    Friend WithEvents optDateRange As System.Windows.Forms.RadioButton
    Friend WithEvents optVisitsLastWeek As System.Windows.Forms.RadioButton
    Friend WithEvents grpDateRange As System.Windows.Forms.GroupBox
    Friend WithEvents datTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpReport As System.Windows.Forms.GroupBox
    Friend WithEvents lblInactiveToActive As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfChildren As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfAdults As System.Windows.Forms.Label
    Friend WithEvents lblTotalVisits As System.Windows.Forms.Label
    Friend WithEvents lvVisits As System.Windows.Forms.ListView
    Friend WithEvents Town As System.Windows.Forms.ColumnHeader
    Friend WithEvents Visits As System.Windows.Forms.ColumnHeader
    Friend WithEvents Adults As System.Windows.Forms.ColumnHeader
    Friend WithEvents Children As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lblBags As System.Windows.Forms.Label
    Friend WithEvents lblNumberNew As System.Windows.Forms.Label
    Friend WithEvents Bags As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpTowns As System.Windows.Forms.GroupBox
    Friend WithEvents lstOfTowns As System.Windows.Forms.ListBox
    Friend WithEvents grpOther As System.Windows.Forms.GroupBox
    Friend WithEvents chkOnlyHomeless As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnlySeniors As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnlyActive As System.Windows.Forms.CheckBox
    Friend WithEvents chkActiveToInactive As System.Windows.Forms.CheckBox
    Friend WithEvents Seniors As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblNumberOfSeniors As System.Windows.Forms.Label
    Friend WithEvents InactiveToActive As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDeliveries As System.Windows.Forms.Label
    Friend WithEvents chkOnlyFamliesWithChildren As System.Windows.Forms.CheckBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents grpVisitsByHour As System.Windows.Forms.GroupBox
    Friend WithEvents lvByHour As System.Windows.Forms.ListView
    Friend WithEvents Hour As System.Windows.Forms.ColumnHeader
    Friend WithEvents Count As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCountDown As System.Windows.Forms.Label
    Friend WithEvents Veterans As System.Windows.Forms.ColumnHeader
End Class

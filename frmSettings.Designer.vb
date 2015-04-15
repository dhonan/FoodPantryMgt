<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnDone = New System.Windows.Forms.Button
        Me.cmbPrinter = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.numInactiveToActiveMonths = New System.Windows.Forms.NumericUpDown
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.cmbProgram = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtVisitDate = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.numMonthsToInactive = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbFontForTickets = New System.Windows.Forms.ComboBox
        Me.chkAutoULCase = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtLabelForOtherItemsBox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtLabelForLimitOf3ItemsBox = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtLabelForLimitOf4ItemsBox = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtLabelForColdSpecialsBox = New System.Windows.Forms.TextBox
        Me.Label124 = New System.Windows.Forms.Label
        Me.txtLabelForColdPickOnly2Box = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtLabelForColdBox = New System.Windows.Forms.TextBox
        Me.Label123 = New System.Windows.Forms.Label
        Me.txtLabelForSpecialsBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLabelForHomeBox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtLabelForFreshBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtLabelForFoodBox = New System.Windows.Forms.TextBox
        Me.optFootPrints = New System.Windows.Forms.RadioButton
        Me.optStVincent = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.chkMilitary = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbWeekStartDay = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.numNumberOfCopies = New System.Windows.Forms.NumericUpDown
        CType(Me.numInactiveToActiveMonths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMonthsToInactive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numNumberOfCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(452, 542)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(100, 23)
        Me.btnDone.TabIndex = 5
        Me.btnDone.Text = "Save and Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'cmbPrinter
        '
        Me.cmbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrinter.FormattingEnabled = True
        Me.cmbPrinter.Location = New System.Drawing.Point(314, 52)
        Me.cmbPrinter.Name = "cmbPrinter"
        Me.cmbPrinter.Size = New System.Drawing.Size(213, 21)
        Me.cmbPrinter.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selected Printer:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(55, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Number of months of inactivity after which, the client will be considered ReActiv" & _
            "ated:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'numInactiveToActiveMonths
        '
        Me.numInactiveToActiveMonths.Location = New System.Drawing.Point(472, 112)
        Me.numInactiveToActiveMonths.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.numInactiveToActiveMonths.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numInactiveToActiveMonths.Name = "numInactiveToActiveMonths"
        Me.numInactiveToActiveMonths.Size = New System.Drawing.Size(55, 20)
        Me.numInactiveToActiveMonths.TabIndex = 7
        Me.numInactiveToActiveMonths.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 577
        Me.ReSize1.InitialHostContainerWidth = 564
        Me.ReSize1.Tag = Nothing
        '
        'cmbProgram
        '
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Items.AddRange(New Object() {"Nothing", "NotePad", "Excel"})
        Me.cmbProgram.Location = New System.Drawing.Point(452, 151)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(75, 21)
        Me.cmbProgram.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Program to launch after report text files have been created:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(371, 542)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Date to use when recording visits (blank for today):"
        '
        'txtVisitDate
        '
        Me.txtVisitDate.Location = New System.Drawing.Point(398, 180)
        Me.txtVisitDate.Name = "txtVisitDate"
        Me.txtVisitDate.Size = New System.Drawing.Size(129, 20)
        Me.txtVisitDate.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "After this many months with no visits, set them to inactive:"
        '
        'numMonthsToInactive
        '
        Me.numMonthsToInactive.Location = New System.Drawing.Point(472, 216)
        Me.numMonthsToInactive.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numMonthsToInactive.Name = "numMonthsToInactive"
        Me.numMonthsToInactive.Size = New System.Drawing.Size(55, 20)
        Me.numMonthsToInactive.TabIndex = 15
        Me.numMonthsToInactive.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Font to use for tickets:"
        '
        'cmbFontForTickets
        '
        Me.cmbFontForTickets.FormattingEnabled = True
        Me.cmbFontForTickets.Items.AddRange(New Object() {"Nothing", "NotePad", "Excel"})
        Me.cmbFontForTickets.Location = New System.Drawing.Point(391, 252)
        Me.cmbFontForTickets.Name = "cmbFontForTickets"
        Me.cmbFontForTickets.Size = New System.Drawing.Size(136, 21)
        Me.cmbFontForTickets.TabIndex = 16
        '
        'chkAutoULCase
        '
        Me.chkAutoULCase.AutoSize = True
        Me.chkAutoULCase.Location = New System.Drawing.Point(262, 279)
        Me.chkAutoULCase.Name = "chkAutoULCase"
        Me.chkAutoULCase.Size = New System.Drawing.Size(259, 17)
        Me.chkAutoULCase.TabIndex = 18
        Me.chkAutoULCase.Text = "Automatically convert names to upper/lower case"
        Me.chkAutoULCase.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtLabelForOtherItemsBox)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtLabelForLimitOf3ItemsBox)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtLabelForLimitOf4ItemsBox)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtLabelForColdSpecialsBox)
        Me.GroupBox1.Controls.Add(Me.Label124)
        Me.GroupBox1.Controls.Add(Me.txtLabelForColdPickOnly2Box)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtLabelForColdBox)
        Me.GroupBox1.Controls.Add(Me.Label123)
        Me.GroupBox1.Controls.Add(Me.txtLabelForSpecialsBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLabelForHomeBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtLabelForFreshBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtLabelForFoodBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 368)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 159)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "These settings are for the boxes on the 'Tickets' form"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(293, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 13)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Label for 'Other items' box"
        '
        'txtLabelForOtherItemsBox
        '
        Me.txtLabelForOtherItemsBox.Location = New System.Drawing.Point(427, 129)
        Me.txtLabelForOtherItemsBox.Name = "txtLabelForOtherItemsBox"
        Me.txtLabelForOtherItemsBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForOtherItemsBox.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Label for 'Limit of 3 items' box"
        '
        'txtLabelForLimitOf3ItemsBox
        '
        Me.txtLabelForLimitOf3ItemsBox.Location = New System.Drawing.Point(165, 128)
        Me.txtLabelForLimitOf3ItemsBox.Name = "txtLabelForLimitOf3ItemsBox"
        Me.txtLabelForLimitOf3ItemsBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForLimitOf3ItemsBox.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(277, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Label for 'Limit of 4 items' box"
        '
        'txtLabelForLimitOf4ItemsBox
        '
        Me.txtLabelForLimitOf4ItemsBox.Location = New System.Drawing.Point(427, 103)
        Me.txtLabelForLimitOf4ItemsBox.Name = "txtLabelForLimitOf4ItemsBox"
        Me.txtLabelForLimitOf4ItemsBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForLimitOf4ItemsBox.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Label for 'Cold specials' box"
        '
        'txtLabelForColdSpecialsBox
        '
        Me.txtLabelForColdSpecialsBox.Location = New System.Drawing.Point(165, 102)
        Me.txtLabelForColdSpecialsBox.Name = "txtLabelForColdSpecialsBox"
        Me.txtLabelForColdSpecialsBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForColdSpecialsBox.TabIndex = 51
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Location = New System.Drawing.Point(265, 80)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(130, 13)
        Me.Label124.TabIndex = 50
        Me.Label124.Text = "Label for 'Cold(2 only)' box"
        '
        'txtLabelForColdPickOnly2Box
        '
        Me.txtLabelForColdPickOnly2Box.Location = New System.Drawing.Point(427, 76)
        Me.txtLabelForColdPickOnly2Box.Name = "txtLabelForColdPickOnly2Box"
        Me.txtLabelForColdPickOnly2Box.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForColdPickOnly2Box.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Label for 'Cold' box"
        '
        'txtLabelForColdBox
        '
        Me.txtLabelForColdBox.Location = New System.Drawing.Point(165, 76)
        Me.txtLabelForColdBox.Name = "txtLabelForColdBox"
        Me.txtLabelForColdBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForColdBox.TabIndex = 47
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Location = New System.Drawing.Point(306, 57)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(115, 13)
        Me.Label123.TabIndex = 46
        Me.Label123.Text = "Label for 'Specials' box"
        '
        'txtLabelForSpecialsBox
        '
        Me.txtLabelForSpecialsBox.Location = New System.Drawing.Point(427, 50)
        Me.txtLabelForSpecialsBox.Name = "txtLabelForSpecialsBox"
        Me.txtLabelForSpecialsBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForSpecialsBox.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Label for 'Home' box"
        '
        'txtLabelForHomeBox
        '
        Me.txtLabelForHomeBox.Location = New System.Drawing.Point(165, 50)
        Me.txtLabelForHomeBox.Name = "txtLabelForHomeBox"
        Me.txtLabelForHomeBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForHomeBox.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(320, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Label for 'Fresh' box"
        '
        'txtLabelForFreshBox
        '
        Me.txtLabelForFreshBox.Location = New System.Drawing.Point(427, 24)
        Me.txtLabelForFreshBox.Name = "txtLabelForFreshBox"
        Me.txtLabelForFreshBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForFreshBox.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Label for 'Food' box"
        '
        'txtLabelForFoodBox
        '
        Me.txtLabelForFoodBox.Location = New System.Drawing.Point(165, 24)
        Me.txtLabelForFoodBox.Name = "txtLabelForFoodBox"
        Me.txtLabelForFoodBox.Size = New System.Drawing.Size(100, 20)
        Me.txtLabelForFoodBox.TabIndex = 39
        '
        'optFootPrints
        '
        Me.optFootPrints.AutoSize = True
        Me.optFootPrints.Location = New System.Drawing.Point(16, 12)
        Me.optFootPrints.Name = "optFootPrints"
        Me.optFootPrints.Size = New System.Drawing.Size(72, 17)
        Me.optFootPrints.TabIndex = 40
        Me.optFootPrints.TabStop = True
        Me.optFootPrints.Text = "FootPrints"
        Me.optFootPrints.UseVisualStyleBackColor = True
        '
        'optStVincent
        '
        Me.optStVincent.AutoSize = True
        Me.optStVincent.Location = New System.Drawing.Point(95, 12)
        Me.optStVincent.Name = "optStVincent"
        Me.optStVincent.Size = New System.Drawing.Size(77, 17)
        Me.optStVincent.TabIndex = 41
        Me.optStVincent.TabStop = True
        Me.optStVincent.Text = "St. Vincent"
        Me.optStVincent.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(220, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Organization title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(314, 22)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(213, 20)
        Me.txtTitle.TabIndex = 43
        '
        'chkMilitary
        '
        Me.chkMilitary.AutoSize = True
        Me.chkMilitary.Location = New System.Drawing.Point(446, 313)
        Me.chkMilitary.Name = "chkMilitary"
        Me.chkMilitary.Size = New System.Drawing.Size(88, 17)
        Me.chkMilitary.TabIndex = 44
        Me.chkMilitary.Text = "Track military"
        Me.chkMilitary.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(347, 337)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Week start day:"
        '
        'cmbWeekStartDay
        '
        Me.cmbWeekStartDay.FormattingEnabled = True
        Me.cmbWeekStartDay.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmbWeekStartDay.Location = New System.Drawing.Point(426, 334)
        Me.cmbWeekStartDay.Name = "cmbWeekStartDay"
        Me.cmbWeekStartDay.Size = New System.Drawing.Size(126, 21)
        Me.cmbWeekStartDay.TabIndex = 46
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(124, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(184, 13)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Number of copies of the ticket to print"
        '
        'numNumberOfCopies
        '
        Me.numNumberOfCopies.Location = New System.Drawing.Point(314, 82)
        Me.numNumberOfCopies.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numNumberOfCopies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNumberOfCopies.Name = "numNumberOfCopies"
        Me.numNumberOfCopies.Size = New System.Drawing.Size(71, 20)
        Me.numNumberOfCopies.TabIndex = 48
        Me.numNumberOfCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 577)
        Me.Controls.Add(Me.numNumberOfCopies)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbWeekStartDay)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chkMilitary)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.optStVincent)
        Me.Controls.Add(Me.optFootPrints)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkAutoULCase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbFontForTickets)
        Me.Controls.Add(Me.numMonthsToInactive)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVisitDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbProgram)
        Me.Controls.Add(Me.numInactiveToActiveMonths)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.cmbPrinter)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        CType(Me.numInactiveToActiveMonths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMonthsToInactive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numNumberOfCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents cmbPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numInactiveToActiveMonths As System.Windows.Forms.NumericUpDown
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProgram As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtVisitDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numMonthsToInactive As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbFontForTickets As System.Windows.Forms.ComboBox
    Friend WithEvents chkAutoULCase As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForOtherItemsBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForLimitOf3ItemsBox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForLimitOf4ItemsBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForColdSpecialsBox As System.Windows.Forms.TextBox
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForColdPickOnly2Box As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForColdBox As System.Windows.Forms.TextBox
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForSpecialsBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForHomeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForFreshBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLabelForFoodBox As System.Windows.Forms.TextBox
    Friend WithEvents optStVincent As System.Windows.Forms.RadioButton
    Friend WithEvents optFootPrints As System.Windows.Forms.RadioButton
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkMilitary As System.Windows.Forms.CheckBox
    Friend WithEvents cmbWeekStartDay As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents numNumberOfCopies As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class

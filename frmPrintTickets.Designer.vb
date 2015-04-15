<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintTickets))
        Me.clbFood = New System.Windows.Forms.CheckedListBox
        Me.txtCaseNumber = New System.Windows.Forms.TextBox
        Me.lblClientName = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblFemaleSeniors = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblMaleSeniors = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblFemaleAdults = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblMaleAdults = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblFemaleChildren = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblMaleChildren = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblNotices = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblSpecialReq = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblFoodAllergies = New System.Windows.Forms.Label
        Me.lblLastVisitDate = New System.Windows.Forms.Label
        Me.lblNumberOfSeniors = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbCustName = New System.Windows.Forms.TextBox
        Me.lblNotes = New System.Windows.Forms.Label
        Me.lblNewClient = New System.Windows.Forms.Label
        Me.lblApptTime = New System.Windows.Forms.Label
        Me.lblCurrentDate = New System.Windows.Forms.Label
        Me.lblTicketTitle = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblAgesOfChildren = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblNumberOfChildren = New System.Windows.Forms.Label
        Me.lblNumberOfAdults = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblLastVisitDateL = New System.Windows.Forms.Label
        Me.lblReserved = New System.Windows.Forms.Label
        Me.grpCold = New System.Windows.Forms.GroupBox
        Me.clbCold = New System.Windows.Forms.CheckedListBox
        Me.grpFresh = New System.Windows.Forms.GroupBox
        Me.clbFresh = New System.Windows.Forms.CheckedListBox
        Me.clbSpecials = New System.Windows.Forms.CheckedListBox
        Me.clbHomessOther = New System.Windows.Forms.CheckedListBox
        Me.clbHomeless4 = New System.Windows.Forms.CheckedListBox
        Me.grpHomelessOther = New System.Windows.Forms.GroupBox
        Me.lbUSDA = New System.Windows.Forms.ListBox
        Me.grpFood = New System.Windows.Forms.GroupBox
        Me.grpHomeless4 = New System.Windows.Forms.GroupBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.clbHome = New System.Windows.Forms.CheckedListBox
        Me.clbHomeLess3 = New System.Windows.Forms.CheckedListBox
        Me.grpHomeless3 = New System.Windows.Forms.GroupBox
        Me.lbUSDAFrozen = New System.Windows.Forms.ListBox
        Me.grpHome = New System.Windows.Forms.GroupBox
        Me.grpSpecial = New System.Windows.Forms.GroupBox
        Me.grpCold2Only = New System.Windows.Forms.GroupBox
        Me.clbCold2Only = New System.Windows.Forms.CheckedListBox
        Me.lblDelivery = New System.Windows.Forms.Label
        Me.grpColdSpecials = New System.Windows.Forms.GroupBox
        Me.cblColdSpecials = New System.Windows.Forms.CheckedListBox
        Me.lblBarCodeClientNumber = New System.Windows.Forms.Label
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.Panel1.SuspendLayout()
        Me.grpCold.SuspendLayout()
        Me.grpFresh.SuspendLayout()
        Me.grpHomelessOther.SuspendLayout()
        Me.grpFood.SuspendLayout()
        Me.grpHomeless4.SuspendLayout()
        Me.grpHomeless3.SuspendLayout()
        Me.grpHome.SuspendLayout()
        Me.grpSpecial.SuspendLayout()
        Me.grpCold2Only.SuspendLayout()
        Me.grpColdSpecials.SuspendLayout()
        Me.SuspendLayout()
        '
        'clbFood
        '
        Me.clbFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbFood.FormattingEnabled = True
        Me.clbFood.Location = New System.Drawing.Point(8, 17)
        Me.clbFood.Name = "clbFood"
        Me.clbFood.Size = New System.Drawing.Size(155, 612)
        Me.clbFood.TabIndex = 1
        Me.clbFood.Tag = "Food"
        '
        'txtCaseNumber
        '
        Me.txtCaseNumber.BackColor = System.Drawing.Color.White
        Me.txtCaseNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseNumber.Location = New System.Drawing.Point(16, 19)
        Me.txtCaseNumber.Name = "txtCaseNumber"
        Me.txtCaseNumber.Size = New System.Drawing.Size(76, 32)
        Me.txtCaseNumber.TabIndex = 12
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.Location = New System.Drawing.Point(133, 891)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(93, 17)
        Me.lblClientName.TabIndex = 105
        Me.lblClientName.Text = "Client name"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(133, 835)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(150, 1)
        Me.Label50.TabIndex = 102
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(134, 878)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(150, 1)
        Me.Label51.TabIndex = 104
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(17, 817)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(111, 19)
        Me.Label49.TabIndex = 101
        Me.Label49.Text = "Order filled by:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(39, 860)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(89, 19)
        Me.Label52.TabIndex = 103
        Me.Label52.Text = "Please sign:"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(444, 835)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(60, 1)
        Me.Label48.TabIndex = 100
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(353, 817)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(85, 19)
        Me.Label47.TabIndex = 99
        Me.Label47.Text = "Cloth bags:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblFemaleSeniors)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lblMaleSeniors)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblFemaleAdults)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblMaleAdults)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblFemaleChildren)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblMaleChildren)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblNotices)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblSpecialReq)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblFoodAllergies)
        Me.Panel1.Controls.Add(Me.lblLastVisitDate)
        Me.Panel1.Controls.Add(Me.lblNumberOfSeniors)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbCustName)
        Me.Panel1.Controls.Add(Me.lblNotes)
        Me.Panel1.Controls.Add(Me.lblNewClient)
        Me.Panel1.Controls.Add(Me.lblApptTime)
        Me.Panel1.Controls.Add(Me.lblCurrentDate)
        Me.Panel1.Controls.Add(Me.txtCaseNumber)
        Me.Panel1.Controls.Add(Me.lblTicketTitle)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblAgesOfChildren)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblNumberOfChildren)
        Me.Panel1.Controls.Add(Me.lblNumberOfAdults)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblLastVisitDateL)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 166)
        Me.Panel1.TabIndex = 92
        '
        'lblFemaleSeniors
        '
        Me.lblFemaleSeniors.AutoSize = True
        Me.lblFemaleSeniors.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFemaleSeniors.Location = New System.Drawing.Point(276, 108)
        Me.lblFemaleSeniors.Name = "lblFemaleSeniors"
        Me.lblFemaleSeniors.Size = New System.Drawing.Size(25, 17)
        Me.lblFemaleSeniors.TabIndex = 128
        Me.lblFemaleSeniors.Text = "Ch"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(260, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 17)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "F:"
        '
        'lblMaleSeniors
        '
        Me.lblMaleSeniors.AutoSize = True
        Me.lblMaleSeniors.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMaleSeniors.Location = New System.Drawing.Point(235, 108)
        Me.lblMaleSeniors.Name = "lblMaleSeniors"
        Me.lblMaleSeniors.Size = New System.Drawing.Size(25, 17)
        Me.lblMaleSeniors.TabIndex = 126
        Me.lblMaleSeniors.Text = "Ch"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(216, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 17)
        Me.Label15.TabIndex = 125
        Me.Label15.Text = "M:"
        '
        'lblFemaleAdults
        '
        Me.lblFemaleAdults.AutoSize = True
        Me.lblFemaleAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFemaleAdults.Location = New System.Drawing.Point(180, 108)
        Me.lblFemaleAdults.Name = "lblFemaleAdults"
        Me.lblFemaleAdults.Size = New System.Drawing.Size(25, 17)
        Me.lblFemaleAdults.TabIndex = 124
        Me.lblFemaleAdults.Text = "Ch"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(164, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 17)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "F:"
        '
        'lblMaleAdults
        '
        Me.lblMaleAdults.AutoSize = True
        Me.lblMaleAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMaleAdults.Location = New System.Drawing.Point(139, 108)
        Me.lblMaleAdults.Name = "lblMaleAdults"
        Me.lblMaleAdults.Size = New System.Drawing.Size(25, 17)
        Me.lblMaleAdults.TabIndex = 122
        Me.lblMaleAdults.Text = "Ch"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(120, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 17)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "M:"
        '
        'lblFemaleChildren
        '
        Me.lblFemaleChildren.AutoSize = True
        Me.lblFemaleChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFemaleChildren.Location = New System.Drawing.Point(81, 108)
        Me.lblFemaleChildren.Name = "lblFemaleChildren"
        Me.lblFemaleChildren.Size = New System.Drawing.Size(25, 17)
        Me.lblFemaleChildren.TabIndex = 120
        Me.lblFemaleChildren.Text = "Ch"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(63, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 17)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "F:"
        '
        'lblMaleChildren
        '
        Me.lblMaleChildren.AutoSize = True
        Me.lblMaleChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMaleChildren.Location = New System.Drawing.Point(33, 108)
        Me.lblMaleChildren.Name = "lblMaleChildren"
        Me.lblMaleChildren.Size = New System.Drawing.Size(25, 17)
        Me.lblMaleChildren.TabIndex = 118
        Me.lblMaleChildren.Text = "Ch"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 17)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "M:"
        '
        'lblNotices
        '
        Me.lblNotices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotices.ForeColor = System.Drawing.Color.Red
        Me.lblNotices.Location = New System.Drawing.Point(367, 5)
        Me.lblNotices.Name = "lblNotices"
        Me.lblNotices.Size = New System.Drawing.Size(188, 113)
        Me.lblNotices.TabIndex = 113
        Me.lblNotices.Text = "No Cooking Facilities" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NEW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deaf" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No Pork" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No Living Facilities" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Last Visit 1/1/2" & _
            "015" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Diabities"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Notes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(573, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Special Requests"
        '
        'lblSpecialReq
        '
        Me.lblSpecialReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpecialReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecialReq.ForeColor = System.Drawing.Color.Red
        Me.lblSpecialReq.Location = New System.Drawing.Point(564, 23)
        Me.lblSpecialReq.Name = "lblSpecialReq"
        Me.lblSpecialReq.Size = New System.Drawing.Size(215, 51)
        Me.lblSpecialReq.TabIndex = 111
        Me.lblSpecialReq.Text = "Peanut Butter, Poultry, and also many many different kinds of chock full of nut N" & _
            "uts of all kinds, etc. and "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(573, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Food Allergies"
        '
        'lblFoodAllergies
        '
        Me.lblFoodAllergies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFoodAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodAllergies.ForeColor = System.Drawing.Color.Red
        Me.lblFoodAllergies.Location = New System.Drawing.Point(564, 98)
        Me.lblFoodAllergies.Name = "lblFoodAllergies"
        Me.lblFoodAllergies.Size = New System.Drawing.Size(215, 55)
        Me.lblFoodAllergies.TabIndex = 112
        Me.lblFoodAllergies.Text = "Notes are here this is up to 2 lines of stuff that you may like"
        '
        'lblLastVisitDate
        '
        Me.lblLastVisitDate.Location = New System.Drawing.Point(275, 10)
        Me.lblLastVisitDate.Name = "lblLastVisitDate"
        Me.lblLastVisitDate.Size = New System.Drawing.Size(79, 15)
        Me.lblLastVisitDate.TabIndex = 108
        Me.lblLastVisitDate.Text = "Last visit date"
        '
        'lblNumberOfSeniors
        '
        Me.lblNumberOfSeniors.AutoSize = True
        Me.lblNumberOfSeniors.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNumberOfSeniors.Location = New System.Drawing.Point(275, 90)
        Me.lblNumberOfSeniors.Name = "lblNumberOfSeniors"
        Me.lblNumberOfSeniors.Size = New System.Drawing.Size(27, 17)
        Me.lblNumberOfSeniors.TabIndex = 26
        Me.lblNumberOfSeniors.Tag = resources.GetString("lblNumberOfSeniors.Tag")
        Me.lblNumberOfSeniors.Text = "SR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(216, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Tag = resources.GetString("Label1.Tag")
        Me.Label1.Text = "Seniors:"
        '
        'tbCustName
        '
        Me.tbCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustName.Location = New System.Drawing.Point(103, 19)
        Me.tbCustName.Name = "tbCustName"
        Me.tbCustName.Size = New System.Drawing.Size(215, 22)
        Me.tbCustName.TabIndex = 24
        Me.tbCustName.Text = "name"
        '
        'lblNotes
        '
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblNotes.ForeColor = System.Drawing.Color.Red
        Me.lblNotes.Location = New System.Drawing.Point(343, 132)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(215, 21)
        Me.lblNotes.TabIndex = 19
        Me.lblNotes.Text = "Notes"
        '
        'lblNewClient
        '
        Me.lblNewClient.AutoSize = True
        Me.lblNewClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewClient.Location = New System.Drawing.Point(435, 38)
        Me.lblNewClient.Name = "lblNewClient"
        Me.lblNewClient.Size = New System.Drawing.Size(91, 20)
        Me.lblNewClient.TabIndex = 110
        Me.lblNewClient.Text = "New client"
        Me.lblNewClient.Visible = False
        '
        'lblApptTime
        '
        Me.lblApptTime.AutoSize = True
        Me.lblApptTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApptTime.Location = New System.Drawing.Point(107, 54)
        Me.lblApptTime.Name = "lblApptTime"
        Me.lblApptTime.Size = New System.Drawing.Size(84, 20)
        Me.lblApptTime.TabIndex = 22
        Me.lblApptTime.Text = "appt time"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(12, 54)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(48, 20)
        Me.lblCurrentDate.TabIndex = 15
        Me.lblCurrentDate.Text = "Date"
        '
        'lblTicketTitle
        '
        Me.lblTicketTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketTitle.Location = New System.Drawing.Point(3, 3)
        Me.lblTicketTitle.Name = "lblTicketTitle"
        Me.lblTicketTitle.Size = New System.Drawing.Size(236, 13)
        Me.lblTicketTitle.TabIndex = 4
        Me.lblTicketTitle.Text = "Title"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(274, 5)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 20)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        Me.lblDate.Visible = False
        '
        'lblAgesOfChildren
        '
        Me.lblAgesOfChildren.AutoSize = True
        Me.lblAgesOfChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAgesOfChildren.Location = New System.Drawing.Point(59, 136)
        Me.lblAgesOfChildren.Name = "lblAgesOfChildren"
        Me.lblAgesOfChildren.Size = New System.Drawing.Size(40, 17)
        Me.lblAgesOfChildren.TabIndex = 9
        Me.lblAgesOfChildren.Text = "Ages"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(13, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Children:"
        '
        'lblNumberOfChildren
        '
        Me.lblNumberOfChildren.AutoSize = True
        Me.lblNumberOfChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNumberOfChildren.Location = New System.Drawing.Point(74, 90)
        Me.lblNumberOfChildren.Name = "lblNumberOfChildren"
        Me.lblNumberOfChildren.Size = New System.Drawing.Size(25, 17)
        Me.lblNumberOfChildren.TabIndex = 7
        Me.lblNumberOfChildren.Text = "Ch"
        '
        'lblNumberOfAdults
        '
        Me.lblNumberOfAdults.AutoSize = True
        Me.lblNumberOfAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNumberOfAdults.Location = New System.Drawing.Point(167, 90)
        Me.lblNumberOfAdults.Name = "lblNumberOfAdults"
        Me.lblNumberOfAdults.Size = New System.Drawing.Size(25, 17)
        Me.lblNumberOfAdults.TabIndex = 5
        Me.lblNumberOfAdults.Tag = resources.GetString("lblNumberOfAdults.Tag")
        Me.lblNumberOfAdults.Text = "Ad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(17, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ages:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(119, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Tag = resources.GetString("Label4.Tag")
        Me.Label4.Text = "Adults:"
        '
        'lblLastVisitDateL
        '
        Me.lblLastVisitDateL.AutoSize = True
        Me.lblLastVisitDateL.Location = New System.Drawing.Point(275, 26)
        Me.lblLastVisitDateL.Name = "lblLastVisitDateL"
        Me.lblLastVisitDateL.Size = New System.Drawing.Size(51, 13)
        Me.lblLastVisitDateL.TabIndex = 107
        Me.lblLastVisitDateL.Text = "Last visit:"
        '
        'lblReserved
        '
        Me.lblReserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReserved.ForeColor = System.Drawing.Color.Red
        Me.lblReserved.Location = New System.Drawing.Point(16, 930)
        Me.lblReserved.Name = "lblReserved"
        Me.lblReserved.Size = New System.Drawing.Size(266, 31)
        Me.lblReserved.TabIndex = 10
        Me.lblReserved.Text = " reserves the right to limit food when necessary"
        Me.lblReserved.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpCold
        '
        Me.grpCold.Controls.Add(Me.clbCold)
        Me.grpCold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCold.ForeColor = System.Drawing.Color.Black
        Me.grpCold.Location = New System.Drawing.Point(395, 184)
        Me.grpCold.Name = "grpCold"
        Me.grpCold.Size = New System.Drawing.Size(174, 170)
        Me.grpCold.TabIndex = 93
        Me.grpCold.TabStop = False
        Me.grpCold.Text = "Cold"
        '
        'clbCold
        '
        Me.clbCold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbCold.ForeColor = System.Drawing.Color.Black
        Me.clbCold.FormattingEnabled = True
        Me.clbCold.Location = New System.Drawing.Point(8, 16)
        Me.clbCold.Name = "clbCold"
        Me.clbCold.Size = New System.Drawing.Size(160, 148)
        Me.clbCold.TabIndex = 0
        Me.clbCold.Tag = "Cold"
        '
        'grpFresh
        '
        Me.grpFresh.Controls.Add(Me.clbFresh)
        Me.grpFresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFresh.ForeColor = System.Drawing.Color.Black
        Me.grpFresh.Location = New System.Drawing.Point(194, 184)
        Me.grpFresh.Name = "grpFresh"
        Me.grpFresh.Size = New System.Drawing.Size(193, 153)
        Me.grpFresh.TabIndex = 94
        Me.grpFresh.TabStop = False
        Me.grpFresh.Text = "Fresh"
        '
        'clbFresh
        '
        Me.clbFresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbFresh.ForeColor = System.Drawing.Color.Black
        Me.clbFresh.FormattingEnabled = True
        Me.clbFresh.Location = New System.Drawing.Point(6, 16)
        Me.clbFresh.Name = "clbFresh"
        Me.clbFresh.Size = New System.Drawing.Size(179, 132)
        Me.clbFresh.TabIndex = 0
        Me.clbFresh.Tag = "Fresh"
        '
        'clbSpecials
        '
        Me.clbSpecials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbSpecials.FormattingEnabled = True
        Me.clbSpecials.Location = New System.Drawing.Point(7, 19)
        Me.clbSpecials.Name = "clbSpecials"
        Me.clbSpecials.Size = New System.Drawing.Size(172, 116)
        Me.clbSpecials.TabIndex = 1
        Me.clbSpecials.Tag = "Special"
        '
        'clbHomessOther
        '
        Me.clbHomessOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbHomessOther.ForeColor = System.Drawing.SystemColors.WindowText
        Me.clbHomessOther.FormattingEnabled = True
        Me.clbHomessOther.Location = New System.Drawing.Point(6, 20)
        Me.clbHomessOther.Name = "clbHomessOther"
        Me.clbHomessOther.Size = New System.Drawing.Size(203, 30)
        Me.clbHomessOther.TabIndex = 2
        Me.clbHomessOther.Tag = "Homeless"
        Me.clbHomessOther.Visible = False
        '
        'clbHomeless4
        '
        Me.clbHomeless4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbHomeless4.FormattingEnabled = True
        Me.clbHomeless4.Location = New System.Drawing.Point(6, 19)
        Me.clbHomeless4.Name = "clbHomeless4"
        Me.clbHomeless4.Size = New System.Drawing.Size(202, 186)
        Me.clbHomeless4.TabIndex = 2
        Me.clbHomeless4.Tag = "Homeless"
        '
        'grpHomelessOther
        '
        Me.grpHomelessOther.Controls.Add(Me.lbUSDA)
        Me.grpHomelessOther.Controls.Add(Me.clbHomessOther)
        Me.grpHomelessOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHomelessOther.ForeColor = System.Drawing.Color.Black
        Me.grpHomelessOther.Location = New System.Drawing.Point(584, 581)
        Me.grpHomelessOther.Name = "grpHomelessOther"
        Me.grpHomelessOther.Size = New System.Drawing.Size(220, 372)
        Me.grpHomelessOther.TabIndex = 98
        Me.grpHomelessOther.TabStop = False
        Me.grpHomelessOther.Text = "Other items"
        '
        'lbUSDA
        '
        Me.lbUSDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUSDA.FormattingEnabled = True
        Me.lbUSDA.ItemHeight = 20
        Me.lbUSDA.Location = New System.Drawing.Point(6, 20)
        Me.lbUSDA.Name = "lbUSDA"
        Me.lbUSDA.Size = New System.Drawing.Size(203, 324)
        Me.lbUSDA.TabIndex = 3
        '
        'grpFood
        '
        Me.grpFood.Controls.Add(Me.clbFood)
        Me.grpFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFood.Location = New System.Drawing.Point(19, 184)
        Me.grpFood.Name = "grpFood"
        Me.grpFood.Size = New System.Drawing.Size(169, 602)
        Me.grpFood.TabIndex = 95
        Me.grpFood.TabStop = False
        Me.grpFood.Text = "Food"
        '
        'grpHomeless4
        '
        Me.grpHomeless4.Controls.Add(Me.clbHomeless4)
        Me.grpHomeless4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHomeless4.ForeColor = System.Drawing.Color.Black
        Me.grpHomeless4.Location = New System.Drawing.Point(585, 184)
        Me.grpHomeless4.Name = "grpHomeless4"
        Me.grpHomeless4.Size = New System.Drawing.Size(219, 211)
        Me.grpHomeless4.TabIndex = 96
        Me.grpHomeless4.TabStop = False
        Me.grpHomeless4.Text = "Limit of 4 items"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(332, 906)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(38, 23)
        Me.btnPrint.TabIndex = 106
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'clbHome
        '
        Me.clbHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbHome.FormattingEnabled = True
        Me.clbHome.Location = New System.Drawing.Point(7, 19)
        Me.clbHome.Name = "clbHome"
        Me.clbHome.Size = New System.Drawing.Size(175, 260)
        Me.clbHome.TabIndex = 1
        Me.clbHome.Tag = "Home"
        '
        'clbHomeLess3
        '
        Me.clbHomeLess3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbHomeLess3.FormattingEnabled = True
        Me.clbHomeLess3.Location = New System.Drawing.Point(6, 20)
        Me.clbHomeLess3.Name = "clbHomeLess3"
        Me.clbHomeLess3.Size = New System.Drawing.Size(203, 17)
        Me.clbHomeLess3.TabIndex = 2
        Me.clbHomeLess3.Tag = "Homeless"
        Me.clbHomeLess3.Visible = False
        '
        'grpHomeless3
        '
        Me.grpHomeless3.Controls.Add(Me.lbUSDAFrozen)
        Me.grpHomeless3.Controls.Add(Me.clbHomeLess3)
        Me.grpHomeless3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHomeless3.ForeColor = System.Drawing.Color.Black
        Me.grpHomeless3.Location = New System.Drawing.Point(589, 417)
        Me.grpHomeless3.Name = "grpHomeless3"
        Me.grpHomeless3.Size = New System.Drawing.Size(215, 146)
        Me.grpHomeless3.TabIndex = 97
        Me.grpHomeless3.TabStop = False
        Me.grpHomeless3.Text = "Limit of 3 items"
        '
        'lbUSDAFrozen
        '
        Me.lbUSDAFrozen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUSDAFrozen.FormattingEnabled = True
        Me.lbUSDAFrozen.ItemHeight = 20
        Me.lbUSDAFrozen.Location = New System.Drawing.Point(6, 19)
        Me.lbUSDAFrozen.Name = "lbUSDAFrozen"
        Me.lbUSDAFrozen.Size = New System.Drawing.Size(203, 104)
        Me.lbUSDAFrozen.TabIndex = 4
        '
        'grpHome
        '
        Me.grpHome.Controls.Add(Me.clbHome)
        Me.grpHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHome.Location = New System.Drawing.Point(194, 355)
        Me.grpHome.Name = "grpHome"
        Me.grpHome.Size = New System.Drawing.Size(193, 279)
        Me.grpHome.TabIndex = 90
        Me.grpHome.TabStop = False
        Me.grpHome.Text = "Home"
        '
        'grpSpecial
        '
        Me.grpSpecial.Controls.Add(Me.clbSpecials)
        Me.grpSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSpecial.Location = New System.Drawing.Point(200, 643)
        Me.grpSpecial.Name = "grpSpecial"
        Me.grpSpecial.Size = New System.Drawing.Size(187, 143)
        Me.grpSpecial.TabIndex = 91
        Me.grpSpecial.TabStop = False
        Me.grpSpecial.Text = "Specials"
        '
        'grpCold2Only
        '
        Me.grpCold2Only.Controls.Add(Me.clbCold2Only)
        Me.grpCold2Only.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCold2Only.ForeColor = System.Drawing.Color.Black
        Me.grpCold2Only.Location = New System.Drawing.Point(403, 374)
        Me.grpCold2Only.Name = "grpCold2Only"
        Me.grpCold2Only.Size = New System.Drawing.Size(166, 201)
        Me.grpCold2Only.TabIndex = 109
        Me.grpCold2Only.TabStop = False
        Me.grpCold2Only.Text = "Cold(2 only)"
        '
        'clbCold2Only
        '
        Me.clbCold2Only.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbCold2Only.ForeColor = System.Drawing.Color.Black
        Me.clbCold2Only.FormattingEnabled = True
        Me.clbCold2Only.Location = New System.Drawing.Point(6, 21)
        Me.clbCold2Only.Name = "clbCold2Only"
        Me.clbCold2Only.Size = New System.Drawing.Size(152, 164)
        Me.clbCold2Only.TabIndex = 0
        Me.clbCold2Only.Tag = "Cold(2 only)"
        '
        'lblDelivery
        '
        Me.lblDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivery.Location = New System.Drawing.Point(392, 849)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(153, 80)
        Me.lblDelivery.TabIndex = 111
        Me.lblDelivery.Text = "Delivery"
        '
        'grpColdSpecials
        '
        Me.grpColdSpecials.Controls.Add(Me.cblColdSpecials)
        Me.grpColdSpecials.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpColdSpecials.Location = New System.Drawing.Point(403, 581)
        Me.grpColdSpecials.Name = "grpColdSpecials"
        Me.grpColdSpecials.Size = New System.Drawing.Size(166, 190)
        Me.grpColdSpecials.TabIndex = 112
        Me.grpColdSpecials.TabStop = False
        Me.grpColdSpecials.Text = "Cold specials"
        '
        'cblColdSpecials
        '
        Me.cblColdSpecials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cblColdSpecials.ForeColor = System.Drawing.Color.Black
        Me.cblColdSpecials.FormattingEnabled = True
        Me.cblColdSpecials.Location = New System.Drawing.Point(6, 19)
        Me.cblColdSpecials.Name = "cblColdSpecials"
        Me.cblColdSpecials.Size = New System.Drawing.Size(152, 180)
        Me.cblColdSpecials.TabIndex = 0
        Me.cblColdSpecials.Tag = "Cold Special"
        '
        'lblBarCodeClientNumber
        '
        Me.lblBarCodeClientNumber.Font = New System.Drawing.Font("Verdana", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarCodeClientNumber.Location = New System.Drawing.Point(386, 851)
        Me.lblBarCodeClientNumber.Name = "lblBarCodeClientNumber"
        Me.lblBarCodeClientNumber.Size = New System.Drawing.Size(198, 57)
        Me.lblBarCodeClientNumber.TabIndex = 113
        Me.lblBarCodeClientNumber.Text = "Label8"
        Me.lblBarCodeClientNumber.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 1009
        Me.ReSize1.InitialHostContainerWidth = 821
        Me.ReSize1.Tag = Nothing
        '
        'frmPrintTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(821, 1009)
        Me.Controls.Add(Me.lblReserved)
        Me.Controls.Add(Me.grpSpecial)
        Me.Controls.Add(Me.lblBarCodeClientNumber)
        Me.Controls.Add(Me.grpColdSpecials)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.grpCold2Only)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpCold)
        Me.Controls.Add(Me.grpFresh)
        Me.Controls.Add(Me.grpHomelessOther)
        Me.Controls.Add(Me.grpFood)
        Me.Controls.Add(Me.grpHomeless4)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpHomeless3)
        Me.Controls.Add(Me.grpHome)
        Me.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Name = "frmPrintTickets"
        Me.Text = "frmPrintTickets"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpCold.ResumeLayout(False)
        Me.grpFresh.ResumeLayout(False)
        Me.grpHomelessOther.ResumeLayout(False)
        Me.grpFood.ResumeLayout(False)
        Me.grpHomeless4.ResumeLayout(False)
        Me.grpHomeless3.ResumeLayout(False)
        Me.grpHome.ResumeLayout(False)
        Me.grpSpecial.ResumeLayout(False)
        Me.grpCold2Only.ResumeLayout(False)
        Me.grpColdSpecials.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCaseNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblReserved As System.Windows.Forms.Label
    Friend WithEvents lblAgesOfChildren As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfChildren As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfAdults As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTicketTitle As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents grpCold As System.Windows.Forms.GroupBox
    Friend WithEvents clbCold As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpFresh As System.Windows.Forms.GroupBox
    Friend WithEvents clbFresh As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpHomelessOther As System.Windows.Forms.GroupBox
    Friend WithEvents clbHomessOther As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpFood As System.Windows.Forms.GroupBox
    Friend WithEvents clbFood As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpHomeless4 As System.Windows.Forms.GroupBox
    Friend WithEvents clbHomeless4 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents grpHomeless3 As System.Windows.Forms.GroupBox
    Friend WithEvents clbHomeLess3 As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpHome As System.Windows.Forms.GroupBox
    Friend WithEvents clbHome As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpSpecial As System.Windows.Forms.GroupBox
    Friend WithEvents clbSpecials As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblLastVisitDate As System.Windows.Forms.Label
    Friend WithEvents lblLastVisitDateL As System.Windows.Forms.Label
    Friend WithEvents grpCold2Only As System.Windows.Forms.GroupBox
    Friend WithEvents clbCold2Only As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblCurrentDate As System.Windows.Forms.Label
    Friend WithEvents lblNewClient As System.Windows.Forms.Label
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents grpColdSpecials As System.Windows.Forms.GroupBox
    Friend WithEvents cblColdSpecials As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblBarCodeClientNumber As System.Windows.Forms.Label
    Friend WithEvents lbUSDA As System.Windows.Forms.ListBox
    Friend WithEvents lbUSDAFrozen As System.Windows.Forms.ListBox
    Friend WithEvents lblApptTime As System.Windows.Forms.Label
    Friend WithEvents tbCustName As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOfSeniors As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFoodAllergies As System.Windows.Forms.Label
    Friend WithEvents lblSpecialReq As System.Windows.Forms.Label
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblNotices As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents lblFemaleAdults As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblMaleAdults As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblFemaleChildren As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMaleChildren As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFemaleSeniors As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMaleSeniors As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class

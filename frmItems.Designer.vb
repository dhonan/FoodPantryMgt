<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Me.btnDone = New System.Windows.Forms.Button
        Me.lvItems = New System.Windows.Forms.ListView
        Me.Item = New System.Windows.Forms.ColumnHeader
        Me.Type = New System.Windows.Forms.ColumnHeader
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbItemsToShow = New System.Windows.Forms.ComboBox
        Me.pnlItem = New System.Windows.Forms.Panel
        Me.optLimitNone = New System.Windows.Forms.RadioButton
        Me.optLimit3 = New System.Windows.Forms.RadioButton
        Me.optLimit4 = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.numCount3 = New System.Windows.Forms.NumericUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.numTo3 = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.numFrom3 = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.numCount2 = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.numTo2 = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.numFrom2 = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.numCount1 = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.numTo1 = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.numFrom1 = New System.Windows.Forms.NumericUpDown
        Me.chkAvailableToday = New System.Windows.Forms.CheckBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblNoteColdSpecial = New System.Windows.Forms.Label
        Me.lblNoteCold2Only = New System.Windows.Forms.Label
        Me.lblNoteSpecial = New System.Windows.Forms.Label
        Me.lblNoteFood = New System.Windows.Forms.Label
        Me.lblNoteHomeless = New System.Windows.Forms.Label
        Me.lblNoteHome = New System.Windows.Forms.Label
        Me.lblNoteFresh = New System.Windows.Forms.Label
        Me.lblNoteCold = New System.Windows.Forms.Label
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.Label24 = New System.Windows.Forms.Label
        Me.pnlItem.SuspendLayout()
        CType(Me.numCount3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFrom3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCount2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFrom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCount1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFrom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(601, 293)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 0
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lvItems
        '
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Item, Me.Type})
        Me.lvItems.FullRowSelect = True
        Me.lvItems.Location = New System.Drawing.Point(12, 38)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(274, 515)
        Me.lvItems.TabIndex = 1
        Me.lvItems.UseCompatibleStateImageBehavior = False
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'Item
        '
        Me.Item.Text = "Item"
        Me.Item.Width = 250
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.Width = 150
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(408, 293)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 23)
        Me.btnDelete.TabIndex = 79
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(408, 264)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 23)
        Me.btnUpdate.TabIndex = 78
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(300, 293)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 23)
        Me.btnCancel.TabIndex = 77
        Me.btnCancel.Text = "Cancel adding"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(300, 264)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(102, 23)
        Me.btnAddNew.TabIndex = 76
        Me.btnAddNew.Text = "Add new"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Items to show in list:"
        '
        'cmbItemsToShow
        '
        Me.cmbItemsToShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemsToShow.FormattingEnabled = True
        Me.cmbItemsToShow.Items.AddRange(New Object() {"All", "Cold", "Cold Special", "Cold(2 only)", "Food", "Fresh", "Home", "Homeless", "Kid snack", "Personal care", "Special"})
        Me.cmbItemsToShow.Location = New System.Drawing.Point(113, 11)
        Me.cmbItemsToShow.MaxDropDownItems = 15
        Me.cmbItemsToShow.Name = "cmbItemsToShow"
        Me.cmbItemsToShow.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemsToShow.Sorted = True
        Me.cmbItemsToShow.TabIndex = 90
        '
        'pnlItem
        '
        Me.pnlItem.Controls.Add(Me.Label24)
        Me.pnlItem.Controls.Add(Me.optLimitNone)
        Me.pnlItem.Controls.Add(Me.optLimit3)
        Me.pnlItem.Controls.Add(Me.optLimit4)
        Me.pnlItem.Controls.Add(Me.Label16)
        Me.pnlItem.Controls.Add(Me.Label15)
        Me.pnlItem.Controls.Add(Me.Label14)
        Me.pnlItem.Controls.Add(Me.Label11)
        Me.pnlItem.Controls.Add(Me.numCount3)
        Me.pnlItem.Controls.Add(Me.Label12)
        Me.pnlItem.Controls.Add(Me.numTo3)
        Me.pnlItem.Controls.Add(Me.Label13)
        Me.pnlItem.Controls.Add(Me.numFrom3)
        Me.pnlItem.Controls.Add(Me.Label8)
        Me.pnlItem.Controls.Add(Me.numCount2)
        Me.pnlItem.Controls.Add(Me.Label9)
        Me.pnlItem.Controls.Add(Me.numTo2)
        Me.pnlItem.Controls.Add(Me.Label10)
        Me.pnlItem.Controls.Add(Me.numFrom2)
        Me.pnlItem.Controls.Add(Me.Label7)
        Me.pnlItem.Controls.Add(Me.numCount1)
        Me.pnlItem.Controls.Add(Me.Label6)
        Me.pnlItem.Controls.Add(Me.numTo1)
        Me.pnlItem.Controls.Add(Me.Label5)
        Me.pnlItem.Controls.Add(Me.numFrom1)
        Me.pnlItem.Controls.Add(Me.chkAvailableToday)
        Me.pnlItem.Controls.Add(Me.cmbType)
        Me.pnlItem.Controls.Add(Me.txtName)
        Me.pnlItem.Controls.Add(Me.Label2)
        Me.pnlItem.Controls.Add(Me.Label1)
        Me.pnlItem.Location = New System.Drawing.Point(292, 38)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(398, 216)
        Me.pnlItem.TabIndex = 91
        '
        'optLimitNone
        '
        Me.optLimitNone.AutoSize = True
        Me.optLimitNone.Location = New System.Drawing.Point(196, 107)
        Me.optLimitNone.Name = "optLimitNone"
        Me.optLimitNone.Size = New System.Drawing.Size(59, 17)
        Me.optLimitNone.TabIndex = 119
        Me.optLimitNone.TabStop = True
        Me.optLimitNone.Text = "No limit"
        Me.optLimitNone.UseVisualStyleBackColor = True
        Me.optLimitNone.Visible = False
        '
        'optLimit3
        '
        Me.optLimit3.AutoSize = True
        Me.optLimit3.Location = New System.Drawing.Point(48, 107)
        Me.optLimit3.Name = "optLimit3"
        Me.optLimit3.Size = New System.Drawing.Size(67, 17)
        Me.optLimit3.TabIndex = 118
        Me.optLimit3.TabStop = True
        Me.optLimit3.Text = "Limit of 3"
        Me.optLimit3.UseVisualStyleBackColor = True
        Me.optLimit3.Visible = False
        '
        'optLimit4
        '
        Me.optLimit4.AutoSize = True
        Me.optLimit4.Location = New System.Drawing.Point(123, 107)
        Me.optLimit4.Name = "optLimit4"
        Me.optLimit4.Size = New System.Drawing.Size(67, 17)
        Me.optLimit4.TabIndex = 117
        Me.optLimit4.TabStop = True
        Me.optLimit4.Text = "Limit of 4"
        Me.optLimit4.UseVisualStyleBackColor = True
        Me.optLimit4.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "From"
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "From"
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "From"
        Me.Label14.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(338, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "items"
        Me.Label11.Visible = False
        '
        'numCount3
        '
        Me.numCount3.Location = New System.Drawing.Point(278, 188)
        Me.numCount3.Name = "numCount3"
        Me.numCount3.Size = New System.Drawing.Size(53, 20)
        Me.numCount3.TabIndex = 112
        Me.numCount3.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(193, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "people, include"
        Me.Label12.Visible = False
        '
        'numTo3
        '
        Me.numTo3.Location = New System.Drawing.Point(135, 188)
        Me.numTo3.Name = "numTo3"
        Me.numTo3.Size = New System.Drawing.Size(52, 20)
        Me.numTo3.TabIndex = 110
        Me.numTo3.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(113, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 13)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "to"
        Me.Label13.Visible = False
        '
        'numFrom3
        '
        Me.numFrom3.Location = New System.Drawing.Point(58, 188)
        Me.numFrom3.Name = "numFrom3"
        Me.numFrom3.Size = New System.Drawing.Size(49, 20)
        Me.numFrom3.TabIndex = 108
        Me.numFrom3.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "items"
        Me.Label8.Visible = False
        '
        'numCount2
        '
        Me.numCount2.Location = New System.Drawing.Point(278, 162)
        Me.numCount2.Name = "numCount2"
        Me.numCount2.Size = New System.Drawing.Size(53, 20)
        Me.numCount2.TabIndex = 106
        Me.numCount2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(193, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "people, include"
        Me.Label9.Visible = False
        '
        'numTo2
        '
        Me.numTo2.Location = New System.Drawing.Point(135, 162)
        Me.numTo2.Name = "numTo2"
        Me.numTo2.Size = New System.Drawing.Size(52, 20)
        Me.numTo2.TabIndex = 104
        Me.numTo2.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(113, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "to"
        Me.Label10.Visible = False
        '
        'numFrom2
        '
        Me.numFrom2.Location = New System.Drawing.Point(58, 162)
        Me.numFrom2.Name = "numFrom2"
        Me.numFrom2.Size = New System.Drawing.Size(49, 20)
        Me.numFrom2.TabIndex = 102
        Me.numFrom2.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "items"
        Me.Label7.Visible = False
        '
        'numCount1
        '
        Me.numCount1.Location = New System.Drawing.Point(278, 136)
        Me.numCount1.Name = "numCount1"
        Me.numCount1.Size = New System.Drawing.Size(53, 20)
        Me.numCount1.TabIndex = 100
        Me.numCount1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "people, include"
        Me.Label6.Visible = False
        '
        'numTo1
        '
        Me.numTo1.Location = New System.Drawing.Point(135, 136)
        Me.numTo1.Name = "numTo1"
        Me.numTo1.Size = New System.Drawing.Size(52, 20)
        Me.numTo1.TabIndex = 98
        Me.numTo1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "to"
        Me.Label5.Visible = False
        '
        'numFrom1
        '
        Me.numFrom1.Location = New System.Drawing.Point(58, 136)
        Me.numFrom1.Name = "numFrom1"
        Me.numFrom1.Size = New System.Drawing.Size(49, 20)
        Me.numFrom1.TabIndex = 96
        Me.numFrom1.Visible = False
        '
        'chkAvailableToday
        '
        Me.chkAvailableToday.AutoSize = True
        Me.chkAvailableToday.Location = New System.Drawing.Point(156, 51)
        Me.chkAvailableToday.Name = "chkAvailableToday"
        Me.chkAvailableToday.Size = New System.Drawing.Size(98, 17)
        Me.chkAvailableToday.TabIndex = 95
        Me.chkAvailableToday.Text = "Available today"
        Me.chkAvailableToday.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Cold", "Cold Special", "Cold(2 only)", "Food", "Fresh", "Home", "Homeless", "Kid snack", "Personal care", "Special"})
        Me.cmbType.Location = New System.Drawing.Point(51, 74)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.Sorted = True
        Me.cmbType.TabIndex = 92
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(50, 49)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNoteColdSpecial)
        Me.GroupBox1.Controls.Add(Me.lblNoteCold2Only)
        Me.GroupBox1.Controls.Add(Me.lblNoteSpecial)
        Me.GroupBox1.Controls.Add(Me.lblNoteFood)
        Me.GroupBox1.Controls.Add(Me.lblNoteHomeless)
        Me.GroupBox1.Controls.Add(Me.lblNoteHome)
        Me.GroupBox1.Controls.Add(Me.lblNoteFresh)
        Me.GroupBox1.Controls.Add(Me.lblNoteCold)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(300, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 231)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Which types go into which box on the ticket?"
        Me.GroupBox1.Visible = False
        '
        'lblNoteColdSpecial
        '
        Me.lblNoteColdSpecial.AutoSize = True
        Me.lblNoteColdSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteColdSpecial.ForeColor = System.Drawing.Color.Blue
        Me.lblNoteColdSpecial.Location = New System.Drawing.Point(14, 72)
        Me.lblNoteColdSpecial.Name = "lblNoteColdSpecial"
        Me.lblNoteColdSpecial.Size = New System.Drawing.Size(244, 13)
        Me.lblNoteColdSpecial.TabIndex = 101
        Me.lblNoteColdSpecial.Text = "Cold Special goes in the Cold Special box"
        '
        'lblNoteCold2Only
        '
        Me.lblNoteCold2Only.AutoSize = True
        Me.lblNoteCold2Only.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteCold2Only.ForeColor = System.Drawing.Color.Blue
        Me.lblNoteCold2Only.Location = New System.Drawing.Point(14, 50)
        Me.lblNoteCold2Only.Name = "lblNoteCold2Only"
        Me.lblNoteCold2Only.Size = New System.Drawing.Size(236, 13)
        Me.lblNoteCold2Only.TabIndex = 100
        Me.lblNoteCold2Only.Text = "Cold(2 only) goes in the Cold(2 only) box"
        '
        'lblNoteSpecial
        '
        Me.lblNoteSpecial.AutoSize = True
        Me.lblNoteSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteSpecial.ForeColor = System.Drawing.Color.Blue
        Me.lblNoteSpecial.Location = New System.Drawing.Point(13, 143)
        Me.lblNoteSpecial.Name = "lblNoteSpecial"
        Me.lblNoteSpecial.Size = New System.Drawing.Size(186, 13)
        Me.lblNoteSpecial.TabIndex = 99
        Me.lblNoteSpecial.Text = "Special goes in the Special box"
        '
        'lblNoteFood
        '
        Me.lblNoteFood.AutoSize = True
        Me.lblNoteFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteFood.ForeColor = System.Drawing.Color.Blue
        Me.lblNoteFood.Location = New System.Drawing.Point(14, 95)
        Me.lblNoteFood.Name = "lblNoteFood"
        Me.lblNoteFood.Size = New System.Drawing.Size(290, 13)
        Me.lblNoteFood.TabIndex = 98
        Me.lblNoteFood.Text = "Food, Kid snack and Normal goes in the Food box"
        '
        'lblNoteHomeless
        '
        Me.lblNoteHomeless.AutoSize = True
        Me.lblNoteHomeless.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteHomeless.ForeColor = System.Drawing.Color.Blue
        Me.lblNoteHomeless.Location = New System.Drawing.Point(13, 191)
        Me.lblNoteHomeless.Name = "lblNoteHomeless"
        Me.lblNoteHomeless.Size = New System.Drawing.Size(219, 13)
        Me.lblNoteHomeless.TabIndex = 96
        Me.lblNoteHomeless.Text = "Homeless goes in the Homeless box's"
        '
        'lblNoteHome
        '
        Me.lblNoteHome.AutoSize = True
        Me.lblNoteHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteHome.ForeColor = System.Drawing.Color.Blue
        Me.lblNoteHome.Location = New System.Drawing.Point(13, 167)
        Me.lblNoteHome.Name = "lblNoteHome"
        Me.lblNoteHome.Size = New System.Drawing.Size(166, 13)
        Me.lblNoteHome.TabIndex = 95
        Me.lblNoteHome.Text = "Home goes in the Home box"
        '
        'lblNoteFresh
        '
        Me.lblNoteFresh.AutoSize = True
        Me.lblNoteFresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteFresh.ForeColor = System.Drawing.Color.Blue
        Me.lblNoteFresh.Location = New System.Drawing.Point(14, 119)
        Me.lblNoteFresh.Name = "lblNoteFresh"
        Me.lblNoteFresh.Size = New System.Drawing.Size(164, 13)
        Me.lblNoteFresh.TabIndex = 94
        Me.lblNoteFresh.Text = "Fresh goes in the Fresh box"
        '
        'lblNoteCold
        '
        Me.lblNoteCold.AutoSize = True
        Me.lblNoteCold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteCold.ForeColor = System.Drawing.Color.Blue
        Me.lblNoteCold.Location = New System.Drawing.Point(14, 26)
        Me.lblNoteCold.Name = "lblNoteCold"
        Me.lblNoteCold.Size = New System.Drawing.Size(152, 13)
        Me.lblNoteCold.TabIndex = 93
        Me.lblNoteCold.Text = "Cold goes in the Cold box"
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 565
        Me.ReSize1.InitialHostContainerWidth = 712
        Me.ReSize1.Tag = Nothing
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Green
        Me.Label24.Location = New System.Drawing.Point(7, 5)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(331, 47)
        Me.Label24.TabIndex = 120
        Me.Label24.Text = "Note: Leading digits or periods of names are NOT displayed and can be used for gr" & _
            "ouping items.."
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 565)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlItem)
        Me.Controls.Add(Me.cmbItemsToShow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.lvItems)
        Me.Controls.Add(Me.btnDone)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maintain items"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlItem.ResumeLayout(False)
        Me.pnlItem.PerformLayout()
        CType(Me.numCount3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFrom3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCount2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFrom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCount1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFrom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents lvItems As System.Windows.Forms.ListView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbItemsToShow As System.Windows.Forms.ComboBox
    Friend WithEvents Item As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAvailableToday As System.Windows.Forms.CheckBox
    Friend WithEvents numCount1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numTo1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numFrom1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents numCount3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents numTo3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents numFrom3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents numCount2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents numTo2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents numFrom2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents optLimitNone As System.Windows.Forms.RadioButton
    Friend WithEvents optLimit3 As System.Windows.Forms.RadioButton
    Friend WithEvents optLimit4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNoteFood As System.Windows.Forms.Label
    Friend WithEvents lblNoteHomeless As System.Windows.Forms.Label
    Friend WithEvents lblNoteHome As System.Windows.Forms.Label
    Friend WithEvents lblNoteFresh As System.Windows.Forms.Label
    Friend WithEvents lblNoteCold As System.Windows.Forms.Label
    Friend WithEvents lblNoteSpecial As System.Windows.Forms.Label
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents lblNoteCold2Only As System.Windows.Forms.Label
    Friend WithEvents lblNoteColdSpecial As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class

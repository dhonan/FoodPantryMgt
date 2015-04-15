<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupItems
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
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.btnDone = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.grpExistingGroups = New System.Windows.Forms.GroupBox
        Me.lvExistingGroups = New System.Windows.Forms.ListView
        Me.GroupName = New System.Windows.Forms.ColumnHeader
        Me.GroupItemType = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpItemsInThisGroup = New System.Windows.Forms.GroupBox
        Me.lstOfItemsInGroup = New System.Windows.Forms.ListBox
        Me.grpNew = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optORVertical = New System.Windows.Forms.RadioButton
        Me.optORHorizontal = New System.Windows.Forms.RadioButton
        Me.txtNewGroupName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstOfItemsToIncludeInGroup = New System.Windows.Forms.ListBox
        Me.cmbItemType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.lblHelp = New System.Windows.Forms.Label
        Me.grpExistingGroups.SuspendLayout()
        Me.grpItemsInThisGroup.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 394
        Me.ReSize1.InitialHostContainerWidth = 653
        Me.ReSize1.Tag = Nothing
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(567, 370)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 91
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(258, 89)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 25)
        Me.btnDelete.TabIndex = 100
        Me.btnDelete.Text = "Delete the group"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'grpExistingGroups
        '
        Me.grpExistingGroups.Controls.Add(Me.lvExistingGroups)
        Me.grpExistingGroups.Controls.Add(Me.Label1)
        Me.grpExistingGroups.Controls.Add(Me.grpItemsInThisGroup)
        Me.grpExistingGroups.Location = New System.Drawing.Point(13, 12)
        Me.grpExistingGroups.Name = "grpExistingGroups"
        Me.grpExistingGroups.Size = New System.Drawing.Size(240, 361)
        Me.grpExistingGroups.TabIndex = 101
        Me.grpExistingGroups.TabStop = False
        Me.grpExistingGroups.Text = "Groups"
        '
        'lvExistingGroups
        '
        Me.lvExistingGroups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GroupName, Me.GroupItemType})
        Me.lvExistingGroups.Location = New System.Drawing.Point(24, 35)
        Me.lvExistingGroups.Name = "lvExistingGroups"
        Me.lvExistingGroups.Size = New System.Drawing.Size(205, 123)
        Me.lvExistingGroups.TabIndex = 101
        Me.lvExistingGroups.UseCompatibleStateImageBehavior = False
        Me.lvExistingGroups.View = System.Windows.Forms.View.Details
        '
        'GroupName
        '
        Me.GroupName.Text = "Name"
        Me.GroupName.Width = 100
        '
        'GroupItemType
        '
        Me.GroupItemType.Text = "Item type"
        Me.GroupItemType.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Existing groups:"
        '
        'grpItemsInThisGroup
        '
        Me.grpItemsInThisGroup.Controls.Add(Me.lstOfItemsInGroup)
        Me.grpItemsInThisGroup.Location = New System.Drawing.Point(6, 164)
        Me.grpItemsInThisGroup.Name = "grpItemsInThisGroup"
        Me.grpItemsInThisGroup.Size = New System.Drawing.Size(200, 191)
        Me.grpItemsInThisGroup.TabIndex = 99
        Me.grpItemsInThisGroup.TabStop = False
        Me.grpItemsInThisGroup.Text = "Items in this group"
        '
        'lstOfItemsInGroup
        '
        Me.lstOfItemsInGroup.FormattingEnabled = True
        Me.lstOfItemsInGroup.Location = New System.Drawing.Point(20, 23)
        Me.lstOfItemsInGroup.Name = "lstOfItemsInGroup"
        Me.lstOfItemsInGroup.Size = New System.Drawing.Size(168, 147)
        Me.lstOfItemsInGroup.TabIndex = 0
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.GroupBox1)
        Me.grpNew.Controls.Add(Me.txtNewGroupName)
        Me.grpNew.Controls.Add(Me.Label2)
        Me.grpNew.Controls.Add(Me.lstOfItemsToIncludeInGroup)
        Me.grpNew.Controls.Add(Me.cmbItemType)
        Me.grpNew.Controls.Add(Me.Label4)
        Me.grpNew.Location = New System.Drawing.Point(400, 12)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Size = New System.Drawing.Size(255, 352)
        Me.grpNew.TabIndex = 102
        Me.grpNew.TabStop = False
        Me.grpNew.Text = "Add a new group"
        Me.grpNew.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optORVertical)
        Me.GroupBox1.Controls.Add(Me.optORHorizontal)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 37)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OR location"
        '
        'optORVertical
        '
        Me.optORVertical.AutoSize = True
        Me.optORVertical.Location = New System.Drawing.Point(99, 14)
        Me.optORVertical.Name = "optORVertical"
        Me.optORVertical.Size = New System.Drawing.Size(60, 17)
        Me.optORVertical.TabIndex = 1
        Me.optORVertical.Text = "Vertical"
        Me.optORVertical.UseVisualStyleBackColor = True
        '
        'optORHorizontal
        '
        Me.optORHorizontal.AutoSize = True
        Me.optORHorizontal.Checked = True
        Me.optORHorizontal.Location = New System.Drawing.Point(20, 15)
        Me.optORHorizontal.Name = "optORHorizontal"
        Me.optORHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.optORHorizontal.TabIndex = 0
        Me.optORHorizontal.TabStop = True
        Me.optORHorizontal.Text = "Horizontal"
        Me.optORHorizontal.UseVisualStyleBackColor = True
        '
        'txtNewGroupName
        '
        Me.txtNewGroupName.Location = New System.Drawing.Point(121, 45)
        Me.txtNewGroupName.Name = "txtNewGroupName"
        Me.txtNewGroupName.Size = New System.Drawing.Size(120, 20)
        Me.txtNewGroupName.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "New group name:"
        '
        'lstOfItemsToIncludeInGroup
        '
        Me.lstOfItemsToIncludeInGroup.FormattingEnabled = True
        Me.lstOfItemsToIncludeInGroup.Location = New System.Drawing.Point(30, 108)
        Me.lstOfItemsToIncludeInGroup.Name = "lstOfItemsToIncludeInGroup"
        Me.lstOfItemsToIncludeInGroup.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstOfItemsToIncludeInGroup.Size = New System.Drawing.Size(212, 238)
        Me.lstOfItemsToIncludeInGroup.TabIndex = 98
        '
        'cmbItemType
        '
        Me.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Items.AddRange(New Object() {"All", "Cold", "Cold Special", "Cold(2 only)", "Food", "Fresh", "Home", "Homeless", "Kid snack", "Personal care", "Special"})
        Me.cmbItemType.Location = New System.Drawing.Point(121, 17)
        Me.cmbItemType.MaxDropDownItems = 15
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemType.Sorted = True
        Me.cmbItemType.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Item types to group:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(259, 59)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 25)
        Me.btnCancel.TabIndex = 103
        Me.btnCancel.Text = "Cancel adding"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(259, 29)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(103, 25)
        Me.btnAddNew.TabIndex = 104
        Me.btnAddNew.Text = "Add new"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'lblHelp
        '
        Me.lblHelp.ForeColor = System.Drawing.Color.Red
        Me.lblHelp.Location = New System.Drawing.Point(267, 117)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(127, 224)
        Me.lblHelp.TabIndex = 105
        Me.lblHelp.Text = "Help"
        '
        'frmGroupItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 394)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.grpExistingGroups)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDone)
        Me.Name = "frmGroupItems"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Group items"
        Me.grpExistingGroups.ResumeLayout(False)
        Me.grpExistingGroups.PerformLayout()
        Me.grpItemsInThisGroup.ResumeLayout(False)
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents grpNew As System.Windows.Forms.GroupBox
    Friend WithEvents grpExistingGroups As System.Windows.Forms.GroupBox
    Friend WithEvents lvExistingGroups As System.Windows.Forms.ListView
    Friend WithEvents GroupName As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupItemType As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpItemsInThisGroup As System.Windows.Forms.GroupBox
    Friend WithEvents lstOfItemsInGroup As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lstOfItemsToIncludeInGroup As System.Windows.Forms.ListBox
    Friend WithEvents txtNewGroupName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optORVertical As System.Windows.Forms.RadioButton
    Friend WithEvents optORHorizontal As System.Windows.Forms.RadioButton

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestoreVisitsFromBackup
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
        Me.btnRestore = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.grpSelectPerson = New System.Windows.Forms.GroupBox
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPersonToRestore = New System.Windows.Forms.ComboBox
        Me.grpSelectBackup = New System.Windows.Forms.GroupBox
        Me.lstOfBackups = New System.Windows.Forms.ListBox
        Me.grpVisitsInThatBackupForThatPerson = New System.Windows.Forms.GroupBox
        Me.lstOfVistsForThatPerson = New System.Windows.Forms.ListBox
        Me.lblNumberOfVisits = New System.Windows.Forms.Label
        Me.grpSelectPerson.SuspendLayout()
        Me.grpSelectBackup.SuspendLayout()
        Me.grpVisitsInThatBackupForThatPerson.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRestore
        '
        Me.btnRestore.Enabled = False
        Me.btnRestore.Location = New System.Drawing.Point(525, 445)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(75, 23)
        Me.btnRestore.TabIndex = 0
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(444, 445)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpSelectPerson
        '
        Me.grpSelectPerson.Controls.Add(Me.cmbPersonToRestore)
        Me.grpSelectPerson.Controls.Add(Me.Label1)
        Me.grpSelectPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectPerson.Location = New System.Drawing.Point(12, 12)
        Me.grpSelectPerson.Name = "grpSelectPerson"
        Me.grpSelectPerson.Size = New System.Drawing.Size(297, 59)
        Me.grpSelectPerson.TabIndex = 2
        Me.grpSelectPerson.TabStop = False
        Me.grpSelectPerson.Text = "Select the person to restore visits for"
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 470
        Me.ReSize1.InitialHostContainerWidth = 618
        Me.ReSize1.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Person:"
        '
        'cmbPersonToRestore
        '
        Me.cmbPersonToRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPersonToRestore.FormattingEnabled = True
        Me.cmbPersonToRestore.Location = New System.Drawing.Point(84, 26)
        Me.cmbPersonToRestore.Name = "cmbPersonToRestore"
        Me.cmbPersonToRestore.Size = New System.Drawing.Size(203, 21)
        Me.cmbPersonToRestore.TabIndex = 1
        '
        'grpSelectBackup
        '
        Me.grpSelectBackup.Controls.Add(Me.grpVisitsInThatBackupForThatPerson)
        Me.grpSelectBackup.Controls.Add(Me.lstOfBackups)
        Me.grpSelectBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectBackup.Location = New System.Drawing.Point(12, 91)
        Me.grpSelectBackup.Name = "grpSelectBackup"
        Me.grpSelectBackup.Size = New System.Drawing.Size(594, 348)
        Me.grpSelectBackup.TabIndex = 2
        Me.grpSelectBackup.TabStop = False
        Me.grpSelectBackup.Text = "Select the backup file"
        Me.grpSelectBackup.Visible = False
        '
        'lstOfBackups
        '
        Me.lstOfBackups.FormattingEnabled = True
        Me.lstOfBackups.Location = New System.Drawing.Point(6, 30)
        Me.lstOfBackups.Name = "lstOfBackups"
        Me.lstOfBackups.Size = New System.Drawing.Size(280, 251)
        Me.lstOfBackups.TabIndex = 0
        '
        'grpVisitsInThatBackupForThatPerson
        '
        Me.grpVisitsInThatBackupForThatPerson.Controls.Add(Me.lblNumberOfVisits)
        Me.grpVisitsInThatBackupForThatPerson.Controls.Add(Me.lstOfVistsForThatPerson)
        Me.grpVisitsInThatBackupForThatPerson.Location = New System.Drawing.Point(299, 30)
        Me.grpVisitsInThatBackupForThatPerson.Name = "grpVisitsInThatBackupForThatPerson"
        Me.grpVisitsInThatBackupForThatPerson.Size = New System.Drawing.Size(289, 312)
        Me.grpVisitsInThatBackupForThatPerson.TabIndex = 1
        Me.grpVisitsInThatBackupForThatPerson.TabStop = False
        Me.grpVisitsInThatBackupForThatPerson.Text = "Visits for that person in the selected backup"
        Me.grpVisitsInThatBackupForThatPerson.Visible = False
        '
        'lstOfVistsForThatPerson
        '
        Me.lstOfVistsForThatPerson.FormattingEnabled = True
        Me.lstOfVistsForThatPerson.Location = New System.Drawing.Point(18, 24)
        Me.lstOfVistsForThatPerson.Name = "lstOfVistsForThatPerson"
        Me.lstOfVistsForThatPerson.Size = New System.Drawing.Size(259, 264)
        Me.lstOfVistsForThatPerson.TabIndex = 0
        '
        'lblNumberOfVisits
        '
        Me.lblNumberOfVisits.AutoSize = True
        Me.lblNumberOfVisits.Location = New System.Drawing.Point(7, 293)
        Me.lblNumberOfVisits.Name = "lblNumberOfVisits"
        Me.lblNumberOfVisits.Size = New System.Drawing.Size(45, 13)
        Me.lblNumberOfVisits.TabIndex = 1
        Me.lblNumberOfVisits.Text = "Label2"
        '
        'frmRestoreVisitsFromBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 470)
        Me.Controls.Add(Me.grpSelectBackup)
        Me.Controls.Add(Me.grpSelectPerson)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRestore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRestoreVisitsFromBackup"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Restore visits from a backup"
        Me.grpSelectPerson.ResumeLayout(False)
        Me.grpSelectPerson.PerformLayout()
        Me.grpSelectBackup.ResumeLayout(False)
        Me.grpVisitsInThatBackupForThatPerson.ResumeLayout(False)
        Me.grpVisitsInThatBackupForThatPerson.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpSelectPerson As System.Windows.Forms.GroupBox
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents cmbPersonToRestore As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpSelectBackup As System.Windows.Forms.GroupBox
    Friend WithEvents grpVisitsInThatBackupForThatPerson As System.Windows.Forms.GroupBox
    Friend WithEvents lstOfVistsForThatPerson As System.Windows.Forms.ListBox
    Friend WithEvents lstOfBackups As System.Windows.Forms.ListBox
    Friend WithEvents lblNumberOfVisits As System.Windows.Forms.Label

End Class

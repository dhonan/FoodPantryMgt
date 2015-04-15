<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.lstOfPaperSlips = New System.Windows.Forms.ListBox
        Me.lstOfVisitsinDB = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblNumberOfPaperSlips = New System.Windows.Forms.Label
        Me.lblNumberOfVisitsInDB = New System.Windows.Forms.Label
        Me.grpProblems = New System.Windows.Forms.GroupBox
        Me.lstOfProblems = New System.Windows.Forms.ListBox
        Me.grpProblems.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstOfPaperSlips
        '
        Me.lstOfPaperSlips.FormattingEnabled = True
        Me.lstOfPaperSlips.Location = New System.Drawing.Point(44, 57)
        Me.lstOfPaperSlips.Name = "lstOfPaperSlips"
        Me.lstOfPaperSlips.Size = New System.Drawing.Size(120, 745)
        Me.lstOfPaperSlips.TabIndex = 0
        '
        'lstOfVisitsinDB
        '
        Me.lstOfVisitsinDB.FormattingEnabled = True
        Me.lstOfVisitsinDB.Location = New System.Drawing.Point(170, 57)
        Me.lstOfVisitsinDB.Name = "lstOfVisitsinDB"
        Me.lstOfVisitsinDB.Size = New System.Drawing.Size(120, 745)
        Me.lstOfVisitsinDB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(44, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "List of paper slips"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(182, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "List of vists recorded in DB"
        '
        'lblNumberOfPaperSlips
        '
        Me.lblNumberOfPaperSlips.AutoSize = True
        Me.lblNumberOfPaperSlips.Location = New System.Drawing.Point(62, 41)
        Me.lblNumberOfPaperSlips.Name = "lblNumberOfPaperSlips"
        Me.lblNumberOfPaperSlips.Size = New System.Drawing.Size(39, 13)
        Me.lblNumberOfPaperSlips.TabIndex = 4
        Me.lblNumberOfPaperSlips.Text = "Label3"
        '
        'lblNumberOfVisitsInDB
        '
        Me.lblNumberOfVisitsInDB.AutoSize = True
        Me.lblNumberOfVisitsInDB.Location = New System.Drawing.Point(192, 41)
        Me.lblNumberOfVisitsInDB.Name = "lblNumberOfVisitsInDB"
        Me.lblNumberOfVisitsInDB.Size = New System.Drawing.Size(39, 13)
        Me.lblNumberOfVisitsInDB.TabIndex = 5
        Me.lblNumberOfVisitsInDB.Text = "Label4"
        '
        'grpProblems
        '
        Me.grpProblems.Controls.Add(Me.lstOfProblems)
        Me.grpProblems.Location = New System.Drawing.Point(304, 65)
        Me.grpProblems.Name = "grpProblems"
        Me.grpProblems.Size = New System.Drawing.Size(354, 238)
        Me.grpProblems.TabIndex = 7
        Me.grpProblems.TabStop = False
        Me.grpProblems.Text = "Problems found"
        '
        'lstOfProblems
        '
        Me.lstOfProblems.FormattingEnabled = True
        Me.lstOfProblems.Location = New System.Drawing.Point(6, 19)
        Me.lstOfProblems.Name = "lstOfProblems"
        Me.lstOfProblems.Size = New System.Drawing.Size(338, 212)
        Me.lstOfProblems.TabIndex = 7
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 823)
        Me.Controls.Add(Me.grpProblems)
        Me.Controls.Add(Me.lblNumberOfVisitsInDB)
        Me.Controls.Add(Me.lblNumberOfPaperSlips)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstOfVisitsinDB)
        Me.Controls.Add(Me.lstOfPaperSlips)
        Me.Name = "frmTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTest"
        Me.grpProblems.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstOfPaperSlips As System.Windows.Forms.ListBox
    Friend WithEvents lstOfVisitsinDB As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfPaperSlips As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfVisitsInDB As System.Windows.Forms.Label
    Friend WithEvents grpProblems As System.Windows.Forms.GroupBox
    Friend WithEvents lstOfProblems As System.Windows.Forms.ListBox
End Class

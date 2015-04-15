<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtractInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExtractInformation))
        Me.btnDone = New System.Windows.Forms.Button
        Me.btnExtract = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.datRangeTo = New System.Windows.Forms.DateTimePicker
        Me.lblRangeTo = New System.Windows.Forms.Label
        Me.datRangeFrom = New System.Windows.Forms.DateTimePicker
        Me.lblRangeFrom = New System.Windows.Forms.Label
        Me.optDateRange = New System.Windows.Forms.RadioButton
        Me.cmbCalendarYear = New System.Windows.Forms.ComboBox
        Me.lblCalendarYear = New System.Windows.Forms.Label
        Me.optByCalendarYear = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.optByWeek = New System.Windows.Forms.RadioButton
        Me.optByMonth = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(530, 168)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 0
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(449, 168)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(75, 23)
        Me.btnExtract.TabIndex = 3
        Me.btnExtract.Text = "Extract"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datRangeTo)
        Me.GroupBox1.Controls.Add(Me.lblRangeTo)
        Me.GroupBox1.Controls.Add(Me.datRangeFrom)
        Me.GroupBox1.Controls.Add(Me.lblRangeFrom)
        Me.GroupBox1.Controls.Add(Me.optDateRange)
        Me.GroupBox1.Controls.Add(Me.cmbCalendarYear)
        Me.GroupBox1.Controls.Add(Me.lblCalendarYear)
        Me.GroupBox1.Controls.Add(Me.optByCalendarYear)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 96)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Extraction dates"
        '
        'datRangeTo
        '
        Me.datRangeTo.Location = New System.Drawing.Point(390, 60)
        Me.datRangeTo.Name = "datRangeTo"
        Me.datRangeTo.Size = New System.Drawing.Size(203, 20)
        Me.datRangeTo.TabIndex = 14
        Me.datRangeTo.Visible = False
        '
        'lblRangeTo
        '
        Me.lblRangeTo.AutoSize = True
        Me.lblRangeTo.Location = New System.Drawing.Point(361, 64)
        Me.lblRangeTo.Name = "lblRangeTo"
        Me.lblRangeTo.Size = New System.Drawing.Size(23, 13)
        Me.lblRangeTo.TabIndex = 13
        Me.lblRangeTo.Text = "To:"
        Me.lblRangeTo.Visible = False
        '
        'datRangeFrom
        '
        Me.datRangeFrom.Location = New System.Drawing.Point(142, 62)
        Me.datRangeFrom.Name = "datRangeFrom"
        Me.datRangeFrom.Size = New System.Drawing.Size(203, 20)
        Me.datRangeFrom.TabIndex = 12
        Me.datRangeFrom.Visible = False
        '
        'lblRangeFrom
        '
        Me.lblRangeFrom.AutoSize = True
        Me.lblRangeFrom.Location = New System.Drawing.Point(99, 66)
        Me.lblRangeFrom.Name = "lblRangeFrom"
        Me.lblRangeFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblRangeFrom.TabIndex = 11
        Me.lblRangeFrom.Text = "From:"
        Me.lblRangeFrom.Visible = False
        '
        'optDateRange
        '
        Me.optDateRange.AutoSize = True
        Me.optDateRange.Location = New System.Drawing.Point(6, 62)
        Me.optDateRange.Name = "optDateRange"
        Me.optDateRange.Size = New System.Drawing.Size(91, 17)
        Me.optDateRange.TabIndex = 10
        Me.optDateRange.Text = "By date range"
        Me.optDateRange.UseVisualStyleBackColor = True
        '
        'cmbCalendarYear
        '
        Me.cmbCalendarYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCalendarYear.FormattingEnabled = True
        Me.cmbCalendarYear.Location = New System.Drawing.Point(285, 22)
        Me.cmbCalendarYear.Name = "cmbCalendarYear"
        Me.cmbCalendarYear.Size = New System.Drawing.Size(121, 28)
        Me.cmbCalendarYear.TabIndex = 9
        '
        'lblCalendarYear
        '
        Me.lblCalendarYear.AutoSize = True
        Me.lblCalendarYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalendarYear.Location = New System.Drawing.Point(116, 19)
        Me.lblCalendarYear.Name = "lblCalendarYear"
        Me.lblCalendarYear.Size = New System.Drawing.Size(163, 24)
        Me.lblCalendarYear.TabIndex = 8
        Me.lblCalendarYear.Text = "For calendar year:"
        '
        'optByCalendarYear
        '
        Me.optByCalendarYear.AutoSize = True
        Me.optByCalendarYear.Checked = True
        Me.optByCalendarYear.Location = New System.Drawing.Point(6, 19)
        Me.optByCalendarYear.Name = "optByCalendarYear"
        Me.optByCalendarYear.Size = New System.Drawing.Size(104, 17)
        Me.optByCalendarYear.TabIndex = 7
        Me.optByCalendarYear.TabStop = True
        Me.optByCalendarYear.Text = "By calendar year"
        Me.optByCalendarYear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optByWeek)
        Me.GroupBox2.Controls.Add(Me.optByMonth)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 48)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total by"
        '
        'optByWeek
        '
        Me.optByWeek.AutoSize = True
        Me.optByWeek.Checked = True
        Me.optByWeek.Location = New System.Drawing.Point(90, 19)
        Me.optByWeek.Name = "optByWeek"
        Me.optByWeek.Size = New System.Drawing.Size(66, 17)
        Me.optByWeek.TabIndex = 7
        Me.optByWeek.TabStop = True
        Me.optByWeek.Text = "By week"
        Me.optByWeek.UseVisualStyleBackColor = True
        '
        'optByMonth
        '
        Me.optByMonth.AutoSize = True
        Me.optByMonth.Location = New System.Drawing.Point(6, 19)
        Me.optByMonth.Name = "optByMonth"
        Me.optByMonth.Size = New System.Drawing.Size(69, 17)
        Me.optByMonth.TabIndex = 6
        Me.optByMonth.Text = "By month"
        Me.optByMonth.UseVisualStyleBackColor = True
        '
        'frmExtractInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 202)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExtract)
        Me.Controls.Add(Me.btnDone)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExtractInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Extract information for reporting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optDateRange As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCalendarYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalendarYear As System.Windows.Forms.Label
    Friend WithEvents optByCalendarYear As System.Windows.Forms.RadioButton
    Friend WithEvents datRangeTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRangeTo As System.Windows.Forms.Label
    Friend WithEvents datRangeFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRangeFrom As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optByWeek As System.Windows.Forms.RadioButton
    Friend WithEvents optByMonth As System.Windows.Forms.RadioButton
End Class

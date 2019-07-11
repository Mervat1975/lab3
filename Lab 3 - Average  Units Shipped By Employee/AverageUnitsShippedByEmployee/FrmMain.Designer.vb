<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAverageUnitsShippedByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTipAvrageUintForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.lblEmp1Average = New System.Windows.Forms.Label()
        Me.lblEmp2Average = New System.Windows.Forms.Label()
        Me.lblEmp3Average = New System.Windows.Forms.Label()
        Me.lblAveragePerDay = New System.Windows.Forms.Label()
        Me.txtEmp1 = New System.Windows.Forms.TextBox()
        Me.txtEmp2 = New System.Windows.Forms.TextBox()
        Me.TxtEmp3 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEmp1 = New System.Windows.Forms.Label()
        Me.lblEmp2 = New System.Windows.Forms.Label()
        Me.lblEmp3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(21, 418)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(103, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipAvrageUintForm.SetToolTip(Me.btnEnter, "Click to Enter uint")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(145, 418)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Re&set"
        Me.ToolTipAvrageUintForm.SetToolTip(Me.btnReset, "Click to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(278, 418)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTipAvrageUintForm.SetToolTip(Me.btnExit, "Click to close the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(68, 50)
        Me.txtUnit.MaximumSize = New System.Drawing.Size(100, 20)
        Me.txtUnit.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(100, 20)
        Me.txtUnit.TabIndex = 2
        Me.ToolTipAvrageUintForm.SetToolTip(Me.txtUnit, "Enter Uints shipped")
        '
        'lblEmp1Average
        '
        Me.lblEmp1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp1Average.Location = New System.Drawing.Point(21, 333)
        Me.lblEmp1Average.MaximumSize = New System.Drawing.Size(100, 23)
        Me.lblEmp1Average.MinimumSize = New System.Drawing.Size(100, 23)
        Me.lblEmp1Average.Name = "lblEmp1Average"
        Me.lblEmp1Average.Size = New System.Drawing.Size(100, 23)
        Me.lblEmp1Average.TabIndex = 9
        Me.lblEmp1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvrageUintForm.SetToolTip(Me.lblEmp1Average, "Employee 1 average")
        '
        'lblEmp2Average
        '
        Me.lblEmp2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp2Average.Location = New System.Drawing.Point(145, 333)
        Me.lblEmp2Average.MaximumSize = New System.Drawing.Size(100, 23)
        Me.lblEmp2Average.MinimumSize = New System.Drawing.Size(100, 23)
        Me.lblEmp2Average.Name = "lblEmp2Average"
        Me.lblEmp2Average.Size = New System.Drawing.Size(100, 23)
        Me.lblEmp2Average.TabIndex = 10
        Me.lblEmp2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvrageUintForm.SetToolTip(Me.lblEmp2Average, "Employee 2 average")
        '
        'lblEmp3Average
        '
        Me.lblEmp3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmp3Average.Location = New System.Drawing.Point(281, 333)
        Me.lblEmp3Average.MaximumSize = New System.Drawing.Size(100, 23)
        Me.lblEmp3Average.MinimumSize = New System.Drawing.Size(100, 23)
        Me.lblEmp3Average.Name = "lblEmp3Average"
        Me.lblEmp3Average.Size = New System.Drawing.Size(100, 23)
        Me.lblEmp3Average.TabIndex = 11
        Me.lblEmp3Average.Text = " "
        Me.lblEmp3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvrageUintForm.SetToolTip(Me.lblEmp3Average, "Employee 3 average")
        '
        'lblAveragePerDay
        '
        Me.lblAveragePerDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveragePerDay.Location = New System.Drawing.Point(21, 373)
        Me.lblAveragePerDay.MaximumSize = New System.Drawing.Size(360, 23)
        Me.lblAveragePerDay.MinimumSize = New System.Drawing.Size(360, 23)
        Me.lblAveragePerDay.Name = "lblAveragePerDay"
        Me.lblAveragePerDay.Size = New System.Drawing.Size(360, 23)
        Me.lblAveragePerDay.TabIndex = 12
        Me.lblAveragePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvrageUintForm.SetToolTip(Me.lblAveragePerDay, "All employees average per day")
        '
        'txtEmp1
        '
        Me.txtEmp1.BackColor = System.Drawing.Color.White
        Me.txtEmp1.Location = New System.Drawing.Point(21, 113)
        Me.txtEmp1.MaximumSize = New System.Drawing.Size(100, 207)
        Me.txtEmp1.MinimumSize = New System.Drawing.Size(100, 207)
        Me.txtEmp1.Multiline = True
        Me.txtEmp1.Name = "txtEmp1"
        Me.txtEmp1.ReadOnly = True
        Me.txtEmp1.Size = New System.Drawing.Size(100, 207)
        Me.txtEmp1.TabIndex = 6
        Me.ToolTipAvrageUintForm.SetToolTip(Me.txtEmp1, "Units shipped for employee 1")
        '
        'txtEmp2
        '
        Me.txtEmp2.BackColor = System.Drawing.Color.White
        Me.txtEmp2.Location = New System.Drawing.Point(145, 113)
        Me.txtEmp2.MaximumSize = New System.Drawing.Size(100, 207)
        Me.txtEmp2.MinimumSize = New System.Drawing.Size(100, 207)
        Me.txtEmp2.Multiline = True
        Me.txtEmp2.Name = "txtEmp2"
        Me.txtEmp2.ReadOnly = True
        Me.txtEmp2.Size = New System.Drawing.Size(100, 207)
        Me.txtEmp2.TabIndex = 7
        Me.ToolTipAvrageUintForm.SetToolTip(Me.txtEmp2, "Units shipped for employee 2")
        '
        'TxtEmp3
        '
        Me.TxtEmp3.BackColor = System.Drawing.Color.White
        Me.TxtEmp3.Location = New System.Drawing.Point(281, 113)
        Me.TxtEmp3.MinimumSize = New System.Drawing.Size(100, 207)
        Me.TxtEmp3.Multiline = True
        Me.TxtEmp3.Name = "TxtEmp3"
        Me.TxtEmp3.ReadOnly = True
        Me.TxtEmp3.Size = New System.Drawing.Size(100, 207)
        Me.TxtEmp3.TabIndex = 8
        Me.ToolTipAvrageUintForm.SetToolTip(Me.TxtEmp3, "Units shipped for employee 3")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.RosyBrown
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(410, 87)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 26
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(18, 19)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(38, 13)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1:"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(18, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Units:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmp1
        '
        Me.lblEmp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp1.Location = New System.Drawing.Point(27, 97)
        Me.lblEmp1.Name = "lblEmp1"
        Me.lblEmp1.Size = New System.Drawing.Size(72, 13)
        Me.lblEmp1.TabIndex = 3
        Me.lblEmp1.Text = "Employee &1"
        Me.lblEmp1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmp2
        '
        Me.lblEmp2.Location = New System.Drawing.Point(164, 97)
        Me.lblEmp2.MaximumSize = New System.Drawing.Size(72, 13)
        Me.lblEmp2.MinimumSize = New System.Drawing.Size(72, 13)
        Me.lblEmp2.Name = "lblEmp2"
        Me.lblEmp2.Size = New System.Drawing.Size(72, 13)
        Me.lblEmp2.TabIndex = 4
        Me.lblEmp2.Text = "Employee &2"
        Me.lblEmp2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmp3
        '
        Me.lblEmp3.Location = New System.Drawing.Point(302, 97)
        Me.lblEmp3.MaximumSize = New System.Drawing.Size(72, 13)
        Me.lblEmp3.MinimumSize = New System.Drawing.Size(72, 13)
        Me.lblEmp3.Name = "lblEmp3"
        Me.lblEmp3.Size = New System.Drawing.Size(72, 13)
        Me.lblEmp3.TabIndex = 5
        Me.lblEmp3.Text = "Employee &3"
        Me.lblEmp3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.TxtEmp3)
        Me.Controls.Add(Me.txtEmp2)
        Me.Controls.Add(Me.txtEmp1)
        Me.Controls.Add(Me.lblAveragePerDay)
        Me.Controls.Add(Me.lblEmp3Average)
        Me.Controls.Add(Me.lblEmp2Average)
        Me.Controls.Add(Me.lblEmp1Average)
        Me.Controls.Add(Me.lblEmp3)
        Me.Controls.Add(Me.lblEmp2)
        Me.Controls.Add(Me.lblEmp1)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(420, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(420, 500)
        Me.Name = "FrmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTipAvrageUintForm As ToolTip
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblDay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents lblEmp1 As Label
    Friend WithEvents lblEmp2 As Label
    Friend WithEvents lblEmp3 As Label
    Friend WithEvents lblEmp1Average As Label
    Friend WithEvents lblEmp2Average As Label
    Friend WithEvents lblEmp3Average As Label
    Friend WithEvents lblAveragePerDay As Label
    Friend WithEvents txtEmp1 As TextBox
    Friend WithEvents txtEmp2 As TextBox
    Friend WithEvents TxtEmp3 As TextBox
End Class

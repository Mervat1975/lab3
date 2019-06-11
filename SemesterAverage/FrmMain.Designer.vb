<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSemasterAvrage
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
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.txtNumericGrade1 = New System.Windows.Forms.TextBox()
        Me.lblLetterGrade1 = New System.Windows.Forms.Label()
        Me.txtNumericGrade2 = New System.Windows.Forms.TextBox()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.txtNumericGrade3 = New System.Windows.Forms.TextBox()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.txtNumericGrade4 = New System.Windows.Forms.TextBox()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.txtNumericGrade5 = New System.Windows.Forms.TextBox()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.txtNumericGrade6 = New System.Windows.Forms.TextBox()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.txtSemesterNumericGrade = New System.Windows.Forms.Label()
        Me.lblLetterGrade3 = New System.Windows.Forms.Label()
        Me.lblLetterGrade4 = New System.Windows.Forms.Label()
        Me.lblLetterGrade5 = New System.Windows.Forms.Label()
        Me.lblLetterGrade6 = New System.Windows.Forms.Label()
        Me.lblSemesterLetterGrade = New System.Windows.Forms.Label()
        Me.lblLetterGrade2 = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.ToolTipSemesterAvrageForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblCourse1
        '
        Me.lblCourse1.AutoSize = True
        Me.lblCourse1.Location = New System.Drawing.Point(32, 26)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course&1"
        '
        'txtNumericGrade1
        '
        Me.txtNumericGrade1.Location = New System.Drawing.Point(117, 26)
        Me.txtNumericGrade1.Name = "txtNumericGrade1"
        Me.txtNumericGrade1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumericGrade1.TabIndex = 1
        Me.txtNumericGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.txtNumericGrade1, "Enter the course1 grade")
        '
        'lblLetterGrade1
        '
        Me.lblLetterGrade1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade1.Location = New System.Drawing.Point(266, 26)
        Me.lblLetterGrade1.MaximumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade1.MinimumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade1.Name = "lblLetterGrade1"
        Me.lblLetterGrade1.Size = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade1.TabIndex = 2
        Me.lblLetterGrade1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumericGrade2
        '
        Me.txtNumericGrade2.Location = New System.Drawing.Point(117, 66)
        Me.txtNumericGrade2.Name = "txtNumericGrade2"
        Me.txtNumericGrade2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumericGrade2.TabIndex = 4
        Me.txtNumericGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.txtNumericGrade2, "Enter the course2 grade")
        '
        'lblCourse2
        '
        Me.lblCourse2.AutoSize = True
        Me.lblCourse2.Location = New System.Drawing.Point(32, 66)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse2.TabIndex = 3
        Me.lblCourse2.Text = "Course&2"
        '
        'txtNumericGrade3
        '
        Me.txtNumericGrade3.Location = New System.Drawing.Point(117, 103)
        Me.txtNumericGrade3.Name = "txtNumericGrade3"
        Me.txtNumericGrade3.Size = New System.Drawing.Size(100, 20)
        Me.txtNumericGrade3.TabIndex = 7
        Me.txtNumericGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.txtNumericGrade3, "Enter the course3 grade")
        '
        'lblCourse3
        '
        Me.lblCourse3.AutoSize = True
        Me.lblCourse3.Location = New System.Drawing.Point(32, 103)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course&3"
        '
        'txtNumericGrade4
        '
        Me.txtNumericGrade4.Location = New System.Drawing.Point(117, 144)
        Me.txtNumericGrade4.Name = "txtNumericGrade4"
        Me.txtNumericGrade4.Size = New System.Drawing.Size(100, 20)
        Me.txtNumericGrade4.TabIndex = 10
        Me.txtNumericGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.txtNumericGrade4, "Enter the course4 grade")
        '
        'lblCourse4
        '
        Me.lblCourse4.AutoSize = True
        Me.lblCourse4.Location = New System.Drawing.Point(32, 144)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse4.TabIndex = 9
        Me.lblCourse4.Text = "Course&4"
        '
        'txtNumericGrade5
        '
        Me.txtNumericGrade5.Location = New System.Drawing.Point(117, 182)
        Me.txtNumericGrade5.Name = "txtNumericGrade5"
        Me.txtNumericGrade5.Size = New System.Drawing.Size(100, 20)
        Me.txtNumericGrade5.TabIndex = 13
        Me.txtNumericGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.txtNumericGrade5, "Enter the course5 grade")
        '
        'lblCourse5
        '
        Me.lblCourse5.AutoSize = True
        Me.lblCourse5.Location = New System.Drawing.Point(32, 182)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse5.TabIndex = 12
        Me.lblCourse5.Text = "Course&5"
        '
        'txtNumericGrade6
        '
        Me.txtNumericGrade6.Location = New System.Drawing.Point(117, 221)
        Me.txtNumericGrade6.Name = "txtNumericGrade6"
        Me.txtNumericGrade6.Size = New System.Drawing.Size(100, 20)
        Me.txtNumericGrade6.TabIndex = 16
        Me.txtNumericGrade6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.txtNumericGrade6, "Enter the course6 grade")
        '
        'lblCourse6
        '
        Me.lblCourse6.AutoSize = True
        Me.lblCourse6.Location = New System.Drawing.Point(32, 221)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse6.TabIndex = 15
        Me.lblCourse6.Text = "Course&6"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(32, 260)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(51, 13)
        Me.lblSemester.TabIndex = 18
        Me.lblSemester.Text = "Semester"
        '
        'txtSemesterNumericGrade
        '
        Me.txtSemesterNumericGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSemesterNumericGrade.Location = New System.Drawing.Point(114, 260)
        Me.txtSemesterNumericGrade.Name = "txtSemesterNumericGrade"
        Me.txtSemesterNumericGrade.Size = New System.Drawing.Size(103, 23)
        Me.txtSemesterNumericGrade.TabIndex = 19
        Me.txtSemesterNumericGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetterGrade3
        '
        Me.lblLetterGrade3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade3.Location = New System.Drawing.Point(266, 103)
        Me.lblLetterGrade3.MaximumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade3.MinimumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade3.Name = "lblLetterGrade3"
        Me.lblLetterGrade3.Size = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade3.TabIndex = 8
        Me.lblLetterGrade3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetterGrade4
        '
        Me.lblLetterGrade4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade4.Location = New System.Drawing.Point(266, 144)
        Me.lblLetterGrade4.MaximumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade4.MinimumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade4.Name = "lblLetterGrade4"
        Me.lblLetterGrade4.Size = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade4.TabIndex = 11
        Me.lblLetterGrade4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetterGrade5
        '
        Me.lblLetterGrade5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade5.Location = New System.Drawing.Point(266, 182)
        Me.lblLetterGrade5.MaximumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade5.MinimumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade5.Name = "lblLetterGrade5"
        Me.lblLetterGrade5.Size = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade5.TabIndex = 14
        Me.lblLetterGrade5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetterGrade6
        '
        Me.lblLetterGrade6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade6.Location = New System.Drawing.Point(266, 221)
        Me.lblLetterGrade6.MaximumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade6.MinimumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade6.Name = "lblLetterGrade6"
        Me.lblLetterGrade6.Size = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade6.TabIndex = 17
        Me.lblLetterGrade6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemesterLetterGrade
        '
        Me.lblSemesterLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterLetterGrade.Location = New System.Drawing.Point(266, 260)
        Me.lblSemesterLetterGrade.MaximumSize = New System.Drawing.Size(96, 23)
        Me.lblSemesterLetterGrade.MinimumSize = New System.Drawing.Size(96, 23)
        Me.lblSemesterLetterGrade.Name = "lblSemesterLetterGrade"
        Me.lblSemesterLetterGrade.Size = New System.Drawing.Size(96, 23)
        Me.lblSemesterLetterGrade.TabIndex = 20
        Me.lblSemesterLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetterGrade2
        '
        Me.lblLetterGrade2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade2.Location = New System.Drawing.Point(266, 66)
        Me.lblLetterGrade2.MaximumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade2.MinimumSize = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade2.Name = "lblLetterGrade2"
        Me.lblLetterGrade2.Size = New System.Drawing.Size(96, 23)
        Me.lblLetterGrade2.TabIndex = 5
        Me.lblLetterGrade2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorMessage.Location = New System.Drawing.Point(35, 308)
        Me.lblErrorMessage.MaximumSize = New System.Drawing.Size(327, 250)
        Me.lblErrorMessage.MinimumSize = New System.Drawing.Size(327, 250)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(327, 250)
        Me.lblErrorMessage.TabIndex = 21
        Me.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(44, 575)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.btnCalculate, "Click to get the Semester Average")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(160, 575)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "Re&set"
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.btnReset, "Click to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(266, 575)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.ToolTipSemesterAvrageForm.SetToolTip(Me.btnExit, "Click to close the application")
        Me.btnExit.UseVisualStyleBackColor = True
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
        'FrmSemasterAvrage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(404, 611)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.txtSemesterNumericGrade)
        Me.Controls.Add(Me.lblSemesterLetterGrade)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblLetterGrade6)
        Me.Controls.Add(Me.txtNumericGrade6)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblLetterGrade5)
        Me.Controls.Add(Me.txtNumericGrade5)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblLetterGrade4)
        Me.Controls.Add(Me.txtNumericGrade4)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblLetterGrade3)
        Me.Controls.Add(Me.txtNumericGrade3)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblLetterGrade2)
        Me.Controls.Add(Me.txtNumericGrade2)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblLetterGrade1)
        Me.Controls.Add(Me.txtNumericGrade1)
        Me.Controls.Add(Me.lblCourse1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(420, 650)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(420, 650)
        Me.Name = "FrmSemasterAvrage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourse1 As Label
    Friend WithEvents txtNumericGrade1 As TextBox
    Friend WithEvents lblLetterGrade1 As Label
    Friend WithEvents txtNumericGrade2 As TextBox
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents txtNumericGrade3 As TextBox
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents txtNumericGrade4 As TextBox
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents txtNumericGrade5 As TextBox
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents txtNumericGrade6 As TextBox
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents txtSemesterNumericGrade As Label
    Friend WithEvents lblLetterGrade3 As Label
    Friend WithEvents lblLetterGrade4 As Label
    Friend WithEvents lblLetterGrade5 As Label
    Friend WithEvents lblLetterGrade6 As Label
    Friend WithEvents lblSemesterLetterGrade As Label
    Friend WithEvents lblLetterGrade2 As Label
    Friend WithEvents lblErrorMessage As Label
    Friend WithEvents ToolTipSemesterAvrageForm As ToolTip
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

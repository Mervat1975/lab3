
Option Strict On


Public Class FrmSemasterAvrage
    '''Developer: Mervat Mustafa
    ''Date : May 31, 2019        
    ''Description: this is a  windows application  to determine a course letter grade, semester average,
    ''And a semester letter grade, based on the user input of course numeric grades.
    ''''''''''''''''''  

    ''' 
    ''' ''' <summary>
    ''' this function recive the numeric grade value and return the letter grade
    ''' </summary>
    ''' <param name="numericGrade"></param>
    ''' <returns></returns>

    Private Function getLatterGrade(numericGrade As Integer) As String
        If numericGrade < 50 Then
            Return "F"
        Else
            If numericGrade < 53 Then
                Return "D-"
            Else
                If numericGrade < 57 Then
                    Return "D"
                Else
                    If numericGrade < 60 Then
                        Return "D+"
                    Else
                        If numericGrade < 63 Then
                            Return "C-"
                        Else
                            If numericGrade < 67 Then
                                Return "C"
                            Else
                                If numericGrade < 70 Then
                                    Return "C+"
                                Else
                                    If numericGrade < 73 Then
                                        Return "B-"
                                    Else
                                        If numericGrade < 77 Then
                                            Return "B"
                                        Else
                                            If numericGrade < 80 Then
                                                Return "B+"
                                            Else
                                                If numericGrade < 85 Then
                                                    Return "A-"
                                                Else
                                                    If numericGrade < 90 Then
                                                        Return "A"
                                                    Else

                                                        Return "A+"


                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If



    End Function

    ''' <summary>
    '''this sub is a generic sub it has 6 handlers( the all 6 text boxes lost focus) 
    '''it responsible for invoking the getLatterGrade  function and display the result in the desired label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub txtNumericGrade_LostFocus(sender As Object, e As EventArgs) Handles txtNumericGrade1.LostFocus, txtNumericGrade2.LostFocus, txtNumericGrade3.LostFocus, txtNumericGrade4.LostFocus, txtNumericGrade5.LostFocus, txtNumericGrade6.LostFocus


        Dim txtbx As TextBox = CType(sender, TextBox)
        lblErrorMessage.Text = ""
        If InputValidate(txtbx.Text.ToString.Trim) Then

            Me.Controls(Controls.Count - 2 - txtbx.TabIndex).Text = getLatterGrade(CInt(txtbx.Text.ToString.Trim))
        Else
        End If

    End Sub
    ''' <summary>
    ''' validate the input value and return true if its valid other wise it will return false
    ''' </summary>
    ''' <param name="inputGrade"></param>
    ''' <returns></returns>
    Function InputValidate(inputGrade As String) As Boolean
        Dim numericGrade As Integer = 0
        If Integer.TryParse(inputGrade, numericGrade) Then
            If numericGrade >= 0 And numericGrade <= 100 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    ''' <summary>
    '''this sub will invoke by click on the calculate button
    ''' it stores the 6 entered values in the array then calculate the average
    ''' ,invoke the getLetterGrade function and display the semester letter grade in the label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const NUM_OF_COURSES As Integer = 6
        Dim allCourses(NUM_OF_COURSES - 1) As String
        Dim numericGrade As Integer = 0
        Dim sum As Integer = 0
        Dim average As Double = 0.00
        Dim errFlag As Boolean = False

        txtNumericGrade1.Enabled = False
        txtNumericGrade2.Enabled = False
        txtNumericGrade3.Enabled = False
        txtNumericGrade4.Enabled = False
        txtNumericGrade5.Enabled = False
        txtNumericGrade6.Enabled = False
        btnCalculate.Enabled = False
        btnReset.Focus()

        allCourses(0) = txtNumericGrade1.Text.ToString
        allCourses(1) = txtNumericGrade2.Text.ToString
        allCourses(2) = txtNumericGrade3.Text.ToString
        allCourses(3) = txtNumericGrade4.Text.ToString
        allCourses(4) = txtNumericGrade5.Text.ToString
        allCourses(5) = txtNumericGrade6.Text.ToString
        lblErrorMessage.Text = "ERROR(s):" & vbNewLine
        For i As Integer = 0 To NUM_OF_COURSES - 1

            If Integer.TryParse(allCourses(i), numericGrade) Then
                If numericGrade >= 0 And numericGrade <= 100 Then
                    sum = sum + numericGrade

                Else
                    lblErrorMessage.Text = lblErrorMessage.Text + "Please ensure that what you input in Course " & i + 1 & "is a number between 0 and 100" & vbNewLine
                    errFlag = True
                End If
            Else
                lblErrorMessage.Text = lblErrorMessage.Text + "Please ensure that what you input in Course " & i + 1 & " is a number between 0 and 100" & vbNewLine
                errFlag = True
            End If
        Next
        If Not errFlag Then
            lblErrorMessage.Text = ""
            average = Math.Round(sum / NUM_OF_COURSES, 2)
            txtSemesterNumericGrade.Text = average.ToString("0.00")
            lblSemesterLetterGrade.Text = getLatterGrade(CInt(average))
        End If



    End Sub
    ''' <summary>
    ''' Clear all the form controls (textboxes and labels)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtNumericGrade1.Text = ""
        txtNumericGrade2.Text = ""
        txtNumericGrade3.Text = ""
        txtNumericGrade4.Text = ""
        txtNumericGrade5.Text = ""
        txtNumericGrade6.Text = ""
        txtSemesterNumericGrade.Text = ""

        lblLetterGrade1.Text = ""
        lblLetterGrade2.Text = ""
        lblLetterGrade3.Text = ""
        lblLetterGrade4.Text = ""
        lblLetterGrade5.Text = ""
        lblLetterGrade6.Text = ""
        lblSemesterLetterGrade.Text = ""

        txtNumericGrade1.Enabled = True
        txtNumericGrade2.Enabled = True
        txtNumericGrade3.Enabled = True
        txtNumericGrade4.Enabled = True
        txtNumericGrade5.Enabled = True
        txtNumericGrade6.Enabled = True
        btnCalculate.Enabled = True

        txtNumericGrade1.Focus()
        lblErrorMessage.Text = ""
    End Sub
    ''' <summary>
    ''' Close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    ''' <summary>
    ''' this sub is a generic sub it has 6 handlers( the all 6 text boxes txt change) 
    ''' it clers the error label 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtNumericGrade_TextChanged(sender As Object, e As EventArgs) Handles txtNumericGrade1.TextChanged, txtNumericGrade2.TextChanged, txtNumericGrade3.TextChanged, txtNumericGrade4.TextChanged, txtNumericGrade5.TextChanged, txtNumericGrade6.TextChanged
        lblErrorMessage.Text = ""

    End Sub

    Private Sub FrmSemasterAvrage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


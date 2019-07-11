
Option Strict On


Public Class FrmAverageUnitsShippedByEmployee
    'Devloper: Mervat Mustafa
    'Date:June 21, 2019
    'Lab 3 - Average  Units Shipped By Employee
    'Description:create a windows application in Visual Basic to calculate the average number of units shipped per week.
    'The client liked it so much that they decided To expand the scope Of the project To include an employee component.
    ''''''''''''''''''''''''''''''''''''''''''''''''

    Const DAYS As Integer = 7
    Const EMPLOYEES As Integer = 3
    Dim empUint(EMPLOYEES - 1, DAYS - 1) As Integer
    Dim day As Integer = 1
    Dim emp As Integer = 1
    Const MIN_UNIT As Integer = 0
    Const MAX_UNIT As Integer = 1000
    Dim txtArr(EMPLOYEES - 1) As TextBox
    Dim lblTitleArr(EMPLOYEES - 1) As Label
    Dim lblAverageArr(EMPLOYEES - 1) As Label


    ''' <summary>
    ''' close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    ''' <summary>
    ''' validate the input value and return true if its valid other wise it will return false
    ''' </summary>
    ''' <param name="inputGrade"></param>
    ''' <returns></returns>
    Function InputValidate(inputGrade As String) As Boolean
        Dim numericGrade As Integer = 0
        If Integer.TryParse(inputGrade, numericGrade) Then
            If numericGrade >= MIN_UNIT And numericGrade <= MAX_UNIT Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function
    ''' <summary>
    '''The function  takes the array and employee index as parameters
    '''and loop the array and calculating the sum  for that specific index.
    ''' </summary>
    ''' <param name="arr"></param>
    ''' <param name="row"></param>
    ''' <returns></returns>
    Function GetSum(ByVal arr(,) As Integer, row As Integer) As Integer
        Dim sum As Integer = 0
        For i As Integer = 0 To DAYS - 1
            sum += arr(row, i)
        Next
        Return sum
    End Function
    ''' <summary>
    ''' The function takes the array as a parameter and for each employee call the function above storing the value calculated for each employee
    ''' and then  returam the sum of all the arrry elements.
    ''' </summary>
    ''' <param name="arr"></param>
    ''' <returns></returns>
    Function GetAllSum(ByVal arr(,) As Integer) As Integer
        Dim sumAll As Integer = 0
        For i As Integer = 0 To EMPLOYEES - 1
            sumAll = sumAll + GetSum(arr, i)
        Next
        Return sumAll
    End Function
    ''' <summary>
    ''' take an input for each day in the week numbered from 1 to 7,
    ''' but the functionality will be extended to record the information for 3 employees. 
    ''' The user input data will need to be validated and, if it passes validation, 
    ''' the data will need to be displayed to the user. Once the number of units has been entered for the 7th
    ''' day for the 3rd employee the solution will calculate and display the average per employee, as well as, the company average.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim average As Double = 0.0
        Dim sum As Integer = 0
        If InputValidate(txtUnit.Text.ToString.Trim) Then
            If day <= DAYS And emp <= EMPLOYEES Then
                ' store value in the array
                empUint(emp - 1, day - 1) = CInt(txtUnit.Text.ToString.Trim)
                txtUnit.Text = ""
                ' display the inputs values in textBoxes

                txtArr(emp - 1).Text = txtArr(emp - 1).Text + empUint(emp - 1, day - 1).ToString + vbNewLine
                day += 1
                If day > DAYS Then
                    'calculate the average for each employee
                    '''''''''''''''''
                    For i As Integer = 0 To EMPLOYEES - 1
                        lblTitleArr(i).Font = New Font(lblTitleArr(i).Font, FontStyle.Regular)
                    Next
                    lblAverageArr(emp - 1).Text = "Average : " & (GetSum(empUint, emp - 1) / DAYS).ToString("0.00")
                    If emp < 3 Then

                        lblTitleArr(emp).Font = New Font(lblTitleArr(emp).Font, FontStyle.Bold)

                    Else
                        lblAveragePerDay.Text = "Average per day : " & (GetAllSum(empUint) / (DAYS * EMPLOYEES)).ToString("0.00")
                        txtUnit.ReadOnly = True
                        btnEnter.Enabled = False
                        btnReset.Focus()
                    End If
                    '''''''''''''''
                    emp += 1
                    day = 1
                End If

                ''Update the day number
                lblDay.Text = "Day " & day.ToString("0")
            End If
        Else '' invalid input
            MessageBox.Show("Please ensure the units shiped is  nemuric and between 0 and 1000 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUnit.SelectionStart = 0
            txtUnit.SelectionLength = txtUnit.Text.Length

        End If
    End Sub
    ''' <summary>
    ''' Reset the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ReDim empUint(EMPLOYEES - 1, DAYS - 1)
        day = 1
        emp = 1
        txtEmp1.Text = ""
        txtEmp2.Text = ""
        TxtEmp3.Text = ""
        lblEmp1Average.Text = ""
        lblEmp2Average.Text = ""
        lblEmp3Average.Text = ""
        lblAveragePerDay.Text = ""
        txtUnit.ReadOnly = False
        txtUnit.Focus()
        btnEnter.Enabled = True
        lblEmp1.Font = New Font(lblEmp1.Font, FontStyle.Bold)
        lblEmp2.Font = New Font(lblEmp2.Font, FontStyle.Regular)
        lblEmp3.Font = New Font(lblEmp3.Font, FontStyle.Regular)
        lblDay.Text = "Day " & day.ToString("0")
    End Sub

    Private Sub FrmAverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtArr(0) = txtEmp1
        txtArr(1) = txtEmp2
        txtArr(2) = TxtEmp3
        '''''''''
        lblTitleArr(0) = lblEmp1
        lblTitleArr(1) = lblEmp2
        lblTitleArr(2) = lblEmp3
        '''''''''''
        lblAverageArr(0) = lblEmp1Average
        lblAverageArr(1) = lblEmp2Average
        lblAverageArr(2) = lblEmp3Average

    End Sub
End Class


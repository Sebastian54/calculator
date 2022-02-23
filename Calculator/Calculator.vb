Public Class Calculator
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Declare Variables
        Dim numberOne As Integer
        Dim numberTwo As Integer
        Dim answer As Integer

        'Read in the numbers
        numberOne = txtNum1.Text
        numberTwo = txtNum2.Text

        'Add the numbers together
        answer = numberOne + numberTwo

        'Output the result
        lblResult.Text = "Result: " & numberOne & " + " & numberTwo & " = " & answer

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click

        'Declare Variables
        Dim numberOne As Integer
        Dim numberTwo As Integer
        Dim answer As Integer

        'Read in the numbers
        numberOne = txtNum1.Text
        numberTwo = txtNum2.Text

        'Subtract the numbers
        answer = numberOne - numberTwo

        'Output the result
        lblResult.Text = "Result: " & numberOne & " - " & numberTwo & " = " & answer

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        'Declare Variables
        Dim numberOne As Integer
        Dim numberTwo As Integer
        Dim answer As Integer

        'Read in the numbers
        numberOne = txtNum1.Text
        numberTwo = txtNum2.Text

        'Multiply the numbers together
        answer = numberOne * numberTwo

        'Output the result
        lblResult.Text = "Result: " & numberOne & " x " & numberTwo & " = " & answer

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click

        'Declare Variables
        Dim numberOne As Integer
        Dim numberTwo As Integer
        Dim answer As Decimal

        'Read in the numbers
        numberOne = txtNum1.Text
        numberTwo = txtNum2.Text

        'Divide the numbers
        answer = numberOne / numberTwo

        'Output the result
        lblResult.Text = "Result: " & numberOne & " / " & numberTwo & " = " & answer

    End Sub
End Class

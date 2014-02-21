Public Class IncomeTax

    'Sets a constant for all the brackets
    Const FIRSTBRACKET As Integer = 7825
    Const SECONDBRACKET As Integer = 31850
    Const THIRDBRACKET As Integer = 77100
    Const FOURTHBRACKET As Integer = 160850
    Const FIFTHBRACKET As Integer = 349700

    'Creates the amounts owed for each bracket. 
    Dim taxamount2 As Decimal = FIRSTBRACKET * 0.1 'First Bracket is different because there is only 10% applied
    Dim taxAmount3 As Decimal = taxamount2 + (SECONDBRACKET - FIRSTBRACKET) * 0.15
    Dim taxAmount4 As Decimal = taxAmount3 + (THIRDBRACKET - SECONDBRACKET) * 0.25
    Dim taxAmount5 As Decimal = taxAmount4 + (FOURTHBRACKET - THIRDBRACKET) * 0.28
    Dim taxAmount6 As Decimal = taxAmount5 + (FIFTHBRACKET - FOURTHBRACKET) * 0.33


    Private Sub salaryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salaryTextBox.TextChanged
        taxresultlabel.Text = "" 'Sets the string to empty.

    End Sub 'Clears display when input is changed

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click

        Dim income As Decimal = Val(salaryTextBox.Text) 'Declares income as value given by user
        Dim totalTax As Decimal

        Select Case income 'Calculates amount of taxes owed for the income given by user from the text box.
            Case Is <= FIRSTBRACKET
                totalTax = income * 0.1

            Case Is <= SECONDBRACKET
                totalTax = taxamount2
                income -= FIRSTBRACKET
                totalTax += income * 0.15

            Case Is <= THIRDBRACKET
                totalTax = taxAmount3
                income -= SECONDBRACKET
                totalTax += income * 0.25

            Case Is <= FOURTHBRACKET
                totalTax = taxAmount4
                income -= THIRDBRACKET
                totalTax += income * 0.28

            Case Is <= FIFTHBRACKET
                totalTax = taxAmount5
                income -= FOURTHBRACKET
                totalTax += income * 0.33

            Case Else
                totalTax = taxAmount6
                income -= FIFTHBRACKET
                totalTax += income * 0.35

        End Select
        taxresultlabel.Text = String.Format("{0:C}", totalTax)
    End Sub
End Class
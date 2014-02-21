Public Class Form1
    ''' <summary>
    ''' Digit Extractor 
    ''' Tyler Marshall
    ''' 300210747 
    ''' Button controls which numbers get modded.
    Private Sub enterButton_Click(sender As System.Object, e As System.EventArgs) Handles enterButton.Click
        Dim firstDigit As Integer = inputTextBox.Text Mod 100000 'Mods the 5th digit number to get the first digit.
        Label1.Text = firstDigit 'Assigns the label1.text to the first digit which is the inputTextBox.Text MOD 100000

        Dim secondDigit As Integer = inputTextBox.Text Mod 10000 'Mods the 4th digit number to get the second digit.
        Label2.Text = secondDigit 'Assigns the label2.text to the second digit which is the inputTextBox.Text MOD 10000

        Dim thirdDigit As Integer = inputTextBox.Text Mod 1000 'Mods the 3rd digit number to get the third digit.
        Label3.Text = thirdDigit 'Assigns the label3.text to the third digit which is the inputTextBox.Text MOD 1000

        Dim fourthDigit As Integer = inputTextBox.Text Mod 100 'Mods the 2nd digit number to get the second digit.
        Label4.Text = fourthDigit 'Assigns the label4.text to the fourth digit which is the inputTextBox.Text MOD 100

        Dim fifthDigit As Integer = inputTextBox.Text Mod 10 'Mods the 1st digit number to get the first digit.
        Label5.Text = fifthDigit 'Assigns the label5.text to the fifth digit which is the inputTextBox.Text MOD 10
    End Sub
    ''' <summary> 
    ''' Clears the boxes for the numbers to go into.
    ''' </summary>
    Private Sub inputTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles inputTextBox.TextChanged
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
    End Sub
End Class

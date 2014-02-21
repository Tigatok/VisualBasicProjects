Public Class TableOfPowersForm

    Private Sub calculateButton_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton.Click
        resultsListBox.Items.Clear() 'Clears all the items in the list box.
        Dim upperLimit As Integer = inputTextBox.Text 'Sets the value the user enters to the upper limit of the power
        Dim count As Integer = 1 'Sets count at 1.
        Dim firstPower As Integer
        Dim secondPower As Integer
        Dim thirdPower As Integer

        resultsListBox.Items.Add("N" & ControlChars.Tab &
                                 "N^2" & ControlChars.Tab & "N^3") 'Adding a header to our List Box separated by Tabs.

        Do Until count = upperLimit + 1

            firstPower = Val(count) ' Determines the first power.
            secondPower = Val(count * count) 'Determines the second power
            thirdPower = Val(count * count * count) 'Determines the third power

            resultsListBox.Items.Add(firstPower & ControlChars.Tab &
                                     secondPower & ControlChars.Tab &
                                     thirdPower)
            count += 1
        Loop

    End Sub
End Class ' TableOfPowersForm

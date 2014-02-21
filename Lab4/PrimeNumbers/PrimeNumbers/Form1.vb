Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click 'Displays an error message box if it was not filled out all the way.
        Prime(TextBox1.Text, TextBox2.Text)
        If TextBox2.Text > TextBox1.Text Then
            MsgBox("Upper bound cannot be lower than lower bound", MsgBoxStyle.Critical)
        End If
    End Sub

    Function Prime(upperLimit As Integer, lowerLimit As Integer) 'Takes in 2 integers and calculates which ones are prime and which ones will get displayed.

        Dim primeNumber As Integer
        Dim isPrime As Boolean = False
        lowerLimit = lowerLimit
        upperLimit = upperLimit

        While lowerLimit < upperLimit
            primeNumber = lowerLimit

            If primeNumber = 2 Or primeNumber = 3 Then
                isPrime = True
            ElseIf primeNumber = 1 Then
                isPrime = False
            ElseIf primeNumber = upperLimit Then
                Exit While

            Else
                For i As Integer = 2 To (primeNumber - 1)
                    If primeNumber Mod i = 0 Then
                        isPrime = False
                        Exit For
                    Else
                        isPrime = True
                    End If
                Next
            End If

            If isPrime = True Then
                TextBox3.Text += primeNumber & vbCrLf
            End If
            lowerLimit += 1
        End While
    End Function
End Class

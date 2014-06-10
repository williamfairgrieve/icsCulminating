Public Class quadForm
    Public sinA As Single 'Declare variables for coeficcients
    Public sinB As Single
    Public sinC As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim discriminate As Single 'Declare variable for discriminate
        Dim sinZeros(0 To 1) As Single 'Declare single array for zeros

        Try 'Try parsing textboxes into variables
            sinA = Single.Parse(TextBox1.Text)
            sinB = Single.Parse(TextBox2.Text)
            sinC = Single.Parse(TextBox3.Text)
            invalidLabel.Visible = False 'Invalid invisible
        Catch ex As Exception 'If a runtime error occurs
            invalidLabel.Visible = True 'Invalid visible
        End Try

        discriminate = (sinB ^ 2) - (4 * sinA * sinC) 'Calculate discriminate

        If discriminate < 0 Then 'If discriminate < 0 there are no real roots
            outputXs.Text = "No real roots"
        ElseIf discriminate = 0 Then 'If discriminate is 0 there is one root and the square root of the discriminate is 0
            sinZeros(0) = (sinB * -1) / (2 * sinA)
            outputXs.Text = "Zero is: " & sinZeros(0)
        Else 'If there are 2 zeroes
            'Calculate first zero adding sqrt of discriminate
            sinZeros(0) = ((sinB * -1) + Math.Sqrt(Math.Pow(sinB, 2) - 4 * sinA * sinC)) / (2 * sinA)
            'Calculate second zero subtracting sqrt of discriminate
            sinZeros(1) = ((sinB * -1) - Math.Sqrt(Math.Pow(sinB, 2) - 4 * sinA * sinC)) / (2 * sinA)

            'Output zeros
            outputXs.Text = "Zeros are: " & sinZeros(0) & " and " & sinZeros(1)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "" 'Clear textboxes and label when reset clicked
        TextBox2.Text = ""
        TextBox3.Text = ""
        outputXs.Text = ""
    End Sub
End Class
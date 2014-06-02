Public Class quadForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sinA As Single
        Dim sinB As Single
        Dim sinC As Single
        Dim discriminate As Single
        Dim sinZeros(0 To 1) As Single

        Try
            sinA = Single.Parse(TextBox1.Text)
            sinB = Single.Parse(TextBox2.Text)
            sinC = Single.Parse(TextBox3.Text)
            invalidLabel.Visible = False
        Catch ex As Exception
            invalidLabel.Visible = True
        End Try
        discriminate = (sinB ^ 2) - (4 * sinA * sinC)
        If discriminate < 0 Then
            outputXs.Text = "No real roots"
        ElseIf discriminate = 0 Then
            sinZeros(0) = (sinB * -1) / (2 * sinA)
            outputXs.Text = "Zero is: " & sinZeros(0)
        Else
            sinZeros(0) = ((sinB * -1) + Math.Sqrt(Math.Pow(sinB, 2) - 4 * sinA * sinC)) / (2 * sinA)
            sinZeros(1) = ((sinB * -1) - Math.Sqrt(Math.Pow(sinB, 2) - 4 * sinA * sinC)) / (2 * sinA)

            outputXs.Text = "Zeros are: " & sinZeros(0) & " and " & sinZeros(1)
        End If

    End Sub
End Class
Public Class quadForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sinA As Single
        Dim sinB As Single
        Dim sinC As Single
        Dim sinZeros(1) As Single

        Try
            sinA = Single.Parse(TextBox1.Text)
            sinB = Single.Parse(TextBox2.Text)
            sinC = Single.Parse(TextBox3.Text)
            invalidLabel.Visible = False
        Catch ex As Exception
            invalidLabel.Visible = True
        End Try

        sinZeros(0) = (-sinB + Math.Sqrt(Math.Pow(sinB, 2) - 4 * sinA * sinC)) / (2 * sinA)
        sinZeros(1) = (-sinB - Math.Sqrt(Math.Pow(sinB, 2) - 4 * sinA * sinC)) / (2 * sinA)

        outputXs.Text = "Zeros are: " & sinZeros(0) & " and " & sinZeros(1)
    End Sub
End Class
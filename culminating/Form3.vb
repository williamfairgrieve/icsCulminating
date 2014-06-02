Public Class trigCalc

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sinInput As Single
        Dim sinOutput As Single

        Try
            sinInput = Single.Parse(inputBox.Text)
            invalidLabel.Visible = False
        Catch ex As Exception
            invalidLabel.Visible = True
        End Try

        If radRB.Checked = True Then
            sinInput = sinInput
        Else
            sinInput = sinInput / (180 / Math.PI)
        End If

        sinOutput = Math.Tan(sinInput)
        inputBox.Text = sinOutput
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sinInput As Single
        Dim sinOutput As Single

        Try
            sinInput = Single.Parse(inputBox.Text)
            invalidLabel.Visible = False
        Catch ex As Exception
            invalidLabel.Visible = True
        End Try

        If radRB.Checked = True Then
            sinInput = sinInput
        Else
            sinInput = sinInput / (180 / Math.PI)
        End If

        sinOutput = Math.Sin(sinInput)
        inputBox.Text = sinOutput
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sinInput As Single
        Dim sinOutput As Single

        Try
            sinInput = Single.Parse(inputBox.Text)
            invalidLabel.Visible = False
        Catch ex As Exception
            invalidLabel.Visible = True
        End Try

        If radRB.Checked = True Then
            sinInput = sinInput
        Else
            sinInput = sinInput / (180 / Math.PI)
        End If

        sinOutput = Math.Cos(sinInput)
        inputBox.Text = sinOutput
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        inputBox.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            My.Computer.Clipboard.SetText(inputBox.Text)
            invalidLabel.Visible = False
        Catch ex As Exception
            invalidLabel.Visible = True
        End Try

    End Sub
End Class
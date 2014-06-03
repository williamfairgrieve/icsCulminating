Public Class trigCalc

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sinInput As Single 'Declare input and output variables
        Dim sinOutput As Single

        Try 'Try parsing textbox into variable
            sinInput = Single.Parse(inputBox.Text)
            invalidLabel.Visible = False 'Invalid invisible
        Catch ex As Exception 'If a runtime error occurs
            invalidLabel.Visible = True 'Invalid visible
        End Try

        If degRB.Checked = True Then 'If degrees is selected
            sinInput = sinInput / (180 / Math.PI) 'Calculate radians
        End If

        sinOutput = Math.Tan(sinInput) 'Calculate tangent from radians
        inputBox.Text = sinOutput 'Output calculated value to textboxs
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sinInput As Single 'Declare input and output variables
        Dim sinOutput As Single

        Try 'Try parsing textbox into variable
            sinInput = Single.Parse(inputBox.Text)
            invalidLabel.Visible = False 'Invalid invisible
        Catch ex As Exception 'If a runtime error occurs
            invalidLabel.Visible = True 'Invalid visible
        End Try

        If degRB.Checked = True Then 'If degrees is selected
            sinInput = sinInput / (180 / Math.PI) 'Calculate radians
        End If

        sinOutput = Math.Sin(sinInput) 'Calculate sine from radians
        inputBox.Text = sinOutput 'Output calculated value to textboxs
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sinInput As Single 'Declare input and output variables
        Dim sinOutput As Single

        Try 'Try parsing textbox into variable
            sinInput = Single.Parse(inputBox.Text)
            invalidLabel.Visible = False 'Invalid invisible
        Catch ex As Exception 'If a runtime error occurs
            invalidLabel.Visible = True 'Invalid visible
        End Try

        If degRB.Checked = True Then 'If degrees is selected
            sinInput = sinInput / (180 / Math.PI) 'Calculate radians
        End If

        sinOutput = Math.Cos(sinInput) 'Calculate tangent from radians
        inputBox.Text = sinOutput 'Output calculated value to textboxs
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        inputBox.Text = "" 'If reset is clicked, clear the textbox
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'When copy button is clicked
        Try
            My.Computer.Clipboard.SetText(inputBox.Text) 'Set clipboard text to textbox contents
            invalidLabel.Visible = False 'Invalid invisible
        Catch ex As Exception
            invalidLabel.Visible = True 'Invalid visible
        End Try

    End Sub
End Class
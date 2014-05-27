Public Class tempForm
    Public sinCelc As Single
    Public sinFer As Single
    Public sinKel As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sinCelc = Single.Parse(celcBox.Text)
            sinFer = Single.Parse(ferBox.Text)
            sinKel = Single.Parse(kelBox.Text)
            invalidLabel.Visible = False
        Catch ex As Exception
            invalidLabel.Visible = True
        End Try
        

        If (sinFer = 0 And sinKel = 0 And sinCelc) Then
            sinFer = (9 / 5) * sinCelc + 32
            sinKel = sinCelc + 273.15
        ElseIf (sinFer And sinKel = 0 And sinCelc = 0) Then
            sinCelc = (5 / 9) * (sinFer - 32)
            sinKel = sinCelc + 273.15
        ElseIf (sinFer = 0 And sinKel And sinCelc = 0) Then
            sinCelc = sinKel - 273.15
            sinFer = (9 / 5) * sinCelc + 32
        Else
            invalidLabel.Visible = True
        End If

        celcBox.Text = sinCelc
        ferBox.Text = sinFer
        kelBox.Text = sinKel
    End Sub

    Private Sub tempForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        celcBox.Text = "0"
        ferBox.Text = "0"
        kelBox.Text = "0"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        celcBox.Text = "0"
        ferBox.Text = "0"
        kelBox.Text = "0"
    End Sub
End Class
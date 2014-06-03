Public Class tempForm
    Public sinCelc As Single 'Declare temperature variables
    Public sinFer As Single
    Public sinKel As Single
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try 'Try parsing textboxes into variables
            sinCelc = Single.Parse(celcBox.Text)
            sinFer = Single.Parse(ferBox.Text)
            sinKel = Single.Parse(kelBox.Text)
            invalidLabel.Visible = False 'Make invalid input invisible
        Catch ex As Exception 'If there is a runtime error
            invalidLabel.Visible = True 'Show invalid input
        End Try
        

        If (sinFer = 0 And sinKel = 0 And sinCelc) Then 'If celcius has a value and the others are empty
            sinFer = (9 / 5) * sinCelc + 32 'Calculate farinheight
            sinKel = sinCelc + 273.15 'Calculate kelvin
        ElseIf (sinFer And sinKel = 0 And sinCelc = 0) Then 'If farenheight has a value and the others are empty
            sinCelc = (5 / 9) * (sinFer - 32) 'Calculate celcius
            sinKel = sinCelc + 273.15 'Calculate kelvin from celcius
        ElseIf (sinFer = 0 And sinKel And sinCelc = 0) Then 'If kelvin has a value and the others are empty
            sinCelc = sinKel - 273.15 'calculate celcius from kelvin
            sinFer = (9 / 5) * sinCelc + 32 'calculate farenheight from celcius
        Else
            invalidLabel.Visible = True 'Make invalid visible
        End If

        celcBox.Text = sinCelc 'Set textboxes to calculated values
        ferBox.Text = sinFer
        kelBox.Text = sinKel
    End Sub

    Private Sub tempForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set textboxes to 0 when form loads
        celcBox.Text = "0"
        ferBox.Text = "0"
        kelBox.Text = "0"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'set textboxes to 0 when reset button clicked
        celcBox.Text = "0"
        ferBox.Text = "0"
        kelBox.Text = "0"
    End Sub
End Class
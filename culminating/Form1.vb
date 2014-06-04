Imports System.Text.RegularExpressions 'Import regular expression library
Public Class Form1

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.Close() 'Close the application if close button is pressed
    End Sub

    Private Sub infoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infoButton.Click
        AboutBox1.Show() 'Show the about window
    End Sub

    Private Sub slopeCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slopeCalc.Click 'Slope calculator code:
        Dim strFirstXCoordinate As String 'Declare all of the strings
        Dim strFirstYCoordinate As String
        Dim strSecondXCoordinate As String
        Dim strSecondYCoordinate As String
        Dim intIndex As Integer
        Dim regexPattern As String = "(0|1|2|3|4|5|6|7|8|9)+" 'This is the regex pattern I will use later
        Dim sinFirstCoordinate(0 To 1) As Single 'Declare the arrays to hold the coordinates
        Dim sinSecondCoordinate(0 To 1) As Single
        Dim sinSlope As Single 'Declare single for slope

        'strFirstXCoordinate = InputBox("Enter your first X coordinate: ") 'Get input from user
        'strFirstYCoordinate = InputBox("Enter your first Y coordinate: ")
        'strSecondXCoordinate = InputBox("Enter your second X coordinate: ")
        'strSecondYCoordinate = InputBox("Enter your second Y coordinate: ")

        'Try 'Try parsing input into arrays
        '    sinFirstCoordinate(0) = Single.Parse(strFirstXCoordinate)
        '    sinFirstCoordinate(1) = Single.Parse(strFirstYCoordinate)
        '    sinSecondCoordinate(0) = Single.Parse(strSecondXCoordinate)
        '    sinSecondCoordinate(1) = Single.Parse(strSecondYCoordinate)
        'Catch ex As Exception 'If a runtime error occurs
        '    MsgBox("Invalid Input") 'Popup invalid input window
        'End Try

        For intIndex = 1 To 2
            Dim sinX As Single
            Dim sinY As Single
            Dim strX As String
            Dim strY As String

            strX = InputBox("Enter x" & intIndex & ": ")
            strY = InputBox("Enter y" & intIndex & ": ")

            Try
                sinX = Single.Parse(strX)
                sinY = Single.Parse(strY)
            Catch ex As Exception
                MsgBox("Invalid Input")
            End Try

            If intIndex = 1 Then
                sinFirstCoordinate(0) = sinX
                sinFirstCoordinate(1) = sinY

            ElseIf intIndex = 2 Then
                sinSecondCoordinate(0) = sinX
                sinSecondCoordinate(1) = sinY
            End If
        Next intIndex


        'Calculate slope using delta y / delta x
        sinSlope = (sinSecondCoordinate(1) - sinFirstCoordinate(1)) / (sinSecondCoordinate(0) - sinFirstCoordinate(0))

        MsgBox(sinSlope) 'Output slope using msgbox
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tempForm.Show() 'Show the temperature calculator
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        trigCalc.Show() 'Show the trig functions calculator
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cdForm.Show() 'Show the CD drive controller
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        quadForm.Show() 'Show the quadratic solver
    End Sub
End Class

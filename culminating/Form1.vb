Imports System.Text.RegularExpressions 'Import regular expression library
Public Class Form1

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub infoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infoButton.Click
        AboutBox1.Show()
    End Sub

    Private Sub slopeCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slopeCalc.Click
        Dim strFirstXCoordinate As String 'Declare all of the strings
        Dim strFirstYCoordinate As String
        Dim strSecondXCoordinate As String
        Dim strSecondYCoordinate As String
        Dim regexPattern As String = "(0|1|2|3|4|5|6|7|8|9)+" 'This is the regex pattern I will use later
        Dim sinFirstCoordinate(0 To 1) As Single 'Declare the arrays to hold the coordinates
        Dim sinSecondCoordinate(0 To 1) As Single
        Dim sinSlope As Single 'Declare single for slope

        strFirstXCoordinate = InputBox("Enter your first X coordinate: ")
        strFirstYCoordinate = InputBox("Enter your first Y coordinate: ")
        strSecondXCoordinate = InputBox("Enter your second X coordinate: ")
        strSecondYCoordinate = InputBox("Enter your second Y coordinate: ")

        sinFirstCoordinate(0) = Single.Parse(strFirstXCoordinate)
        sinFirstCoordinate(1) = Single.Parse(strFirstYCoordinate)
        sinSecondCoordinate(0) = Single.Parse(strSecondXCoordinate)
        sinSecondCoordinate(1) = Single.Parse(strSecondYCoordinate)

        sinSlope = (sinSecondCoordinate(1) - sinFirstCoordinate(1)) / (sinSecondCoordinate(0) - sinFirstCoordinate(0))

        MsgBox(sinSlope)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tempForm.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        trigCalc.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cdForm.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        quadForm.Show()
    End Sub
End Class

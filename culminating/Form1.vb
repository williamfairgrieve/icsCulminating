Public Class Form1

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub infoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infoButton.Click
        AboutBox1.Show()
    End Sub

    Private Sub slopeCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slopeCalc.Click
        Dim strFirstCoordinate As String
        Dim strSecondCoordinate As String

        Dim sinFirstCoordinate(0 To 1) As Single
        Dim sinSecondCoordinate(0 To 1) As Single

        strFirstCoordinate = InputBox("Enter your first coordinate (x,y): ")
        strSecondCoordinate = InputBox("Enter your second coordinate (x,y): ")

        sinFirstCoordinate(0) = 666
        sinFirstCoordinate(1) = 69

        sinSecondCoordinate(0) = 420
        sinSecondCoordinate(1) = 520

        MsgBox("Coord 1  " & sinFirstCoordinate(0) & sinFirstCoordinate(1) & "Coord 2  " & sinSecondCoordinate(0) & sinSecondCoordinate(1))
    End Sub
End Class

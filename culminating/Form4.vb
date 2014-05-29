Public Class cdForm
    Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
   (ByVal lpCommandString As String, ByVal lpReturnString As String, _
   ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim retval As Long
        'Dim returnString As String
        retval = mciSendString("set CDAudio door open", "", 0, 0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim retval As Long
        ' Dim returnstring As String
        retval = mciSendString("set CDAudio door close", "", 0, 0)
    End Sub
End Class
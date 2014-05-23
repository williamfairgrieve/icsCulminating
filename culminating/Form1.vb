Public Class Form1

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub infoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infoButton.Click
        AboutBox1.Show()
    End Sub
End Class

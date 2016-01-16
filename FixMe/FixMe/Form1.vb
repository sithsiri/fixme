Public Class Form1

    Private Sub Button1_Click(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("CMD", "/Q /C ipconfig /renew && ipconfig /flushdns && echo Press any key to finish... && pause > nul")
    End Sub

End Class

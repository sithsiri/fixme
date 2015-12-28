Public Class Form1
    Private Sub Button1_Click(ByVal sender As Object,
        ByVal e As System.EventArgs) Handles Button1.Click
        Dim psi As New _
            System.Diagnostics.ProcessStartInfo("fixnet.bat")
        psi.RedirectStandardOutput = True
        psi.WindowStyle = ProcessWindowStyle.Hidden
        psi.UseShellExecute = False
        Dim listFiles As System.Diagnostics.Process
        listFiles = System.Diagnostics.Process.Start(psi)
        Dim myOutput As System.IO.StreamReader _
            = listFiles.StandardOutput
        listFiles.WaitForExit(2000)
        If listFiles.HasExited Then
            Dim output As String = myOutput.ReadToEnd
            Debug.WriteLine(output)
        End If
    End Sub
End Class

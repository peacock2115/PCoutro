Public Class Form1
    Private Sub fff(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        'prevents the background being focused instead of the dialog
        If Me.Focused Then
            dialog.Focus()
        End If
    End Sub
End Class

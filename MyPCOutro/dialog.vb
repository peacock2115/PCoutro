Public Class dialog
    Dim time As String = 0
    Dim shutdowntype As String
    Private Sub dialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.outro, AudioPlayMode.BackgroundLoop)
        Me.Hide()
        Form1.Hide()
        Timer1.Start()
        Timer2.Start()
        shutdowntype = "shutdown"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time = time + 1
        'Debug.WriteLine(shutdowntype)
        'Debug.WriteLine(time)
        If time = 53 Then
            bsod.Show()
        End If
        If time = 103 Then
            If shutdowntype = "shutdown" Then
                Process.Start("shutdown.exe", "-s -t 0")
            ElseIf shutdowntype = "restart" Then
                Process.Start("shutdown.exe", "-r -t 0")
            ElseIf shutdowntype = "logout" Then
                Process.Start("shutdown.exe", "-l -t 0")
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If time > 54 Then
            'Shows bsod image and prevents ALT+F4
            If Not bsod.Visible Then
                bsod.Show()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.outro, AudioPlayMode.BackgroundLoop)
        Me.Hide()
        Form1.Hide()
        Timer1.Start()
        Timer2.Start()
        shutdowntype = "restart"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.outro, AudioPlayMode.BackgroundLoop)
        Me.Hide()
        Form1.Hide()
        Timer1.Start()
        Timer2.Start()
        shutdowntype = "logout"
    End Sub
End Class
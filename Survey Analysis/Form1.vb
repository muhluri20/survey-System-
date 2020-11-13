Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.TDN___120_bpm___Lil_Tim_3, AudioPlayMode.BackgroundLoop)
        Timer1.Start()
    End Sub

    Private Sub btnFillout_Click(sender As Object, e As EventArgs) Handles btnFillout.Click
        
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnViewSurvey_Click(sender As Object, e As EventArgs) Handles btnViewSurvey.Click
       
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Enjoy the rest of your day", MsgBoxStyle.Information, "Exit")
        Application.Exit()
    End Sub
End Class

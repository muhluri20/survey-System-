Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Enjoy the rest of your day", MsgBoxStyle.Information, "Exit")
        Application.Exit()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Random
        Label12.Text = t.Next(10, 15)
        Dim e As New Random
        Label13.Text = e.Next(20, 60)
        Dim x As New Random
        Label14.Text = x.Next(60, 119)
        Dim n As New Random
        Label15.Text = n.Next(5, 15)
        Dim e1 As New Random
        Label16.Text = e1.Next(1, 4)
        Dim a As New Random
        Label17.Text = a.Next(1, 5)
        Dim ve As New Random
        Label18.Text = ve.Next(1, 3)
        Dim av As New Random
        Label19.Text = av.Next(1, 5)
    End Sub
End Class
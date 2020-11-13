Public Class Form2
    Dim nname, snmae As String
    Dim phone, age, id, I As Integer
    Dim datee As String
    Dim rw As DataRow
    Dim scaleEatOut, scaleMovies, scaleTv, scaleRadio As Integer
    Dim pizza, pasta, pap As Integer
    Dim TotalSurvey, AverageAge, MaxAge, MinAge, EatoutAve, MoviesAve, TvAve, RadioAve As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtNames.Text = "" Or txtSurname.Text = "" Or txtContact.Text = "" Or txtAge.Text = "" Or chckBeef.Checked = False And chckChicken.Checked = False And chckPapandWors.Checked = False And chckPasta.Checked = False And chckPizza.Checked = False Or rbtnEatOutSA.Checked = False And rbtnEatOutA.Checked = False And rbtnEatOutN.Checked = False And rbtnEatOutD.Checked = False And rbtnEatOutSD.Checked = False Or rbtnMoviesSA.Checked = False And rbtnMoviesSA.Checked = False And rbtnMoviesA.Checked = False And rbtnMoviesN.Checked = False And rbtnMoviesD.Checked = False And rbtnMoviesSD.Checked = False Or rbtnRadioSA.Checked = False And rbtnRadioA.Checked And rbtnRadioN.Checked = False And rbtnRadioD.Checked = False And rbtnRadioSD.Checked = False Or rbtnTVSA.Checked = False And rbtnTVA.Checked = False And rbtnTVN.Checked = False And rbtnTVD.Checked = False And rbtnTVSD.Checked = False Then
            MsgBox("please make sure that all fields are filled", MsgBoxStyle.Exclamation, "error 404")

        Else
            Try
                nname = txtNames.Text
                snmae = txtSurname.Text
                phone = txtContact.Text
                age = txtAge.Text
                datee = DateTimePicker1.Text
                nname = txtNames.Text
                snmae = txtSurname.Text
                phone = txtContact.Text
                age = txtAge.Text
                datee = DateTimePicker1.Text
                If age < 5 Or age > 119 Then
                    MsgBox("The age entered is invalid age shoud be from 5 years old to 120 years old", MsgBoxStyle.Exclamation, "error 404")
                Else

                    If chckPizza.Checked = True Then
                        pizza = 1
                    Else
                        pizza = 0
                    End If
                    If chckPasta.Checked = True Then
                        pasta = 1
                    Else
                        pasta = 2
                    End If
                    If chckPapandWors.Checked = True Then
                        pap = 1
                    Else
                        pap = 0
                    End If

                    If rbtnEatOutSA.Enabled = True Then
                        scaleEatOut = 1

                    ElseIf rbtnEatOutA.Enabled = True Then
                        scaleEatOut = 2

                    ElseIf rbtnEatOutN.Enabled = True Then
                        scaleEatOut = 3

                    ElseIf rbtnEatOutD.Enabled = True Then
                        scaleEatOut = 4

                    ElseIf rbtnEatOutSD.Enabled = True Then
                        scaleEatOut = 5
                    End If
                    If rbtnMoviesSA.Enabled = True Then
                        scaleMovies = 1
                    ElseIf rbtnMoviesA.Enabled = True Then
                        scaleMovies = 2

                    ElseIf rbtnMoviesN.Enabled = True Then
                        scaleMovies = 3

                    ElseIf rbtnMoviesD.Enabled = True Then
                        scaleMovies = 4

                    ElseIf rbtnMoviesSD.Enabled = True Then
                        scaleMovies = 5
                    End If

                    If rbtnTVSA.Enabled = True Then
                        scaleTv = 1


                    ElseIf rbtnTVA.Enabled = True Then
                        scaleTv = 2

                    ElseIf rbtnTVN.Enabled = True Then
                        scaleTv = 3

                    ElseIf rbtnTVD.Enabled = True Then
                        scaleTv = 4

                    ElseIf rbtnTVSD.Enabled = True Then
                        scaleTv = 5
                    End If
                    If rbtnRadioSA.Enabled = True Then
                        scaleRadio = 1

                    ElseIf rbtnRadioA.Enabled = True Then
                        scaleRadio = 2

                    ElseIf rbtnRadioN.Enabled = True Then
                        scaleRadio = 3

                    ElseIf rbtnRadioD.Enabled = True Then
                        scaleRadio = 4

                    ElseIf rbtnRadioSD.Enabled = True Then
                        scaleRadio = 5
                    End If
                    rw = SurveyDBDataSet.survey.NewRow
                    rw.Item("ID") = id
                    rw.Item("Surname") = snmae
                    rw.Item("Name") = nname
                    rw.Item("Surname") = snmae
                    rw.Item("Phone") = phone
                    rw.Item("age") = age
                    rw.Item("DOB") = datee
                    rw.Item("pizza") = pizza
                    rw.Item("pasta") = pasta
                    rw.Item("pap") = pap
                    rw.Item("EatOut") = scaleEatOut
                    rw.Item("Movies") = scaleMovies
                    rw.Item("Tv") = scaleTv
                    rw.Item("Radio") = scaleRadio
                    SurveyDBDataSet.survey.Rows.Add(rw)
                    I = SurveyTableAdapter.Update(SurveyDBDataSet)
                    MsgBox("your survey Successfully completed" & I, MsgBoxStyle.Information, "Submitted")
                    Me.Hide()
                    Form1.Show()
                    AverageAge = rw.ItemArray("age") / I
                    AverageAge = txtAge.Text
                    txtSurname.Clear()
                    txtNames.Clear()
                    txtAge.Clear()
                    txtContact.Clear()
                    chckPizza.Checked = False
                    chckPasta.Checked = False
                    chckPapandWors.Checked = False
                    rbtnEatOutSA.Checked = False And rbtnEatOutA.Checked = False And rbtnEatOutN.Checked = False And rbtnEatOutD.Checked = False And rbtnEatOutSD.Checked = False and rbtnMoviesSA.Checked = False And rbtnMoviesSA.Checked = False And rbtnMoviesA.Checked = False And rbtnMoviesN.Checked = False And rbtnMoviesD.Checked = False And rbtnMoviesSD.Checked = False and rbtnRadioSA.Checked = False And rbtnRadioA.Checked And rbtnRadioN.Checked = False And rbtnRadioD.Checked = False And rbtnRadioSD.Checked = False and rbtnTVSA.Checked = False And rbtnTVA.Checked = False And rbtnTVN.Checked = False And rbtnTVD.Checked = False And rbtnTVSD.Checked = False
                End If
 Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SurveyDBDataSet.survey' table. You can move, or remove it, as needed.
        Me.SurveyTableAdapter.Fill(Me.SurveyDBDataSet.survey)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Enjoy the rest of your day", MsgBoxStyle.Information, "Exit")
        Application.Exit()
    End Sub
End Class
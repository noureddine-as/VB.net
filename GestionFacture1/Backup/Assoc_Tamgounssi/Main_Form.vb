Public Class Main_Form

#Region "Les Fonctions Et Les Procédures"

    Function CalculerPConsommation(ByVal Prix As Double, ByVal Consommation As Double, ByVal TXT_PConsomm As TextBox) As Double

        Dim PConsommation As Double

        PConsommation = (Prix * Consommation)

        TXT_PConsomm.Text = PConsommation

        Return PConsommation

    End Function

    Function CalculerPTotal(ByVal PConsommation As Double, ByVal Abonn As Double, ByVal DevMosquee As Double, ByVal TXT_PTotal As TextBox) As Double

        Dim PTotal As Double

        PTotal = (PConsommation + Abonn + DevMosquee)

        TXT_PTotal.Text = PTotal

        Return PTotal

    End Function

    Sub InitialiserTout()
        With Me

            .TXT_Nom.Text = ""
            .TXT_NAbonn.Text = ""
            .TXT_NCompteur.Text = ""
            .TXT_IndexPreced.Text = ""
            .TXT_IndexPresent.Text = ""
            .TXT_Mois.Text = Now.Month
            .TXT_Annee.Text = Now.Year
            .TXT_ConsomM3.Text = ""
            .TXT_Prix.Text = "5,00"
            .TXT_PrixConsomm.Text = ""
            .TXT_Abonn.Text = "13,00"
            .TXT_DevMosquee.Text = "13,5"
            .TXT_Total.Text = ""
            .TXT_Nom.Select()

        End With
    End Sub

#End Region

#Region "Les Calcules"

    Private Sub BTN_PrixConsommation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PrixConsommation.Click
        Try

            Dim Prix As Double = Me.TXT_Prix.Text
            Dim Consommation As Double = Me.TXT_ConsomM3.Text

            CalculerPConsommation(Prix, Consommation, Me.TXT_PrixConsomm)

        Catch ex As Exception
            If IsNumeric(Me.TXT_Prix.Text) = False Or IsNumeric(Me.TXT_ConsomM3.Text) = False Then

                MsgBox("يجب أن يتم ملأ المكان الخاص بالثمن و المكان الخاص بالاستهلاك بواسطة أعداد", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "حساب مبلغ الاستهلاك")

            End If
        End Try
    End Sub

    Private Sub BTN_PrixTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PrixTotal.Click
        Try

            Dim PConsommation As Double = Me.TXT_PrixConsomm.Text
            Dim Abonn As Double = Me.TXT_Abonn.Text
            Dim DevMosquee As Double = Me.TXT_DevMosquee.Text

            CalculerPTotal(PConsommation, Abonn, DevMosquee, Me.TXT_Total)

        Catch ex As Exception

            If IsNumeric(Me.TXT_Abonn.Text) = False Or _
               IsNumeric(Me.TXT_DevMosquee.Text) = False Then

                MsgBox("يجب أن يتم ملأ المكان الخاص بالاشتراك و المكان الخاص بواجب المسجد بواسطة أعداد", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "حساب المجموع")
                
            ElseIf IsNumeric(Me.TXT_PrixConsomm.Text) = False Then

                MsgBox("قم أولا بحساب مبلغ الاستهلاك بعد ادخال كمية الاستهلاك و الثمن ثم الضغط على زر حساب مبلغ الاستهلاك", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "حساب المجموع")

            End If

        End Try
    End Sub

#End Region

#Region "Form Load  |  Initialisation  |  Vérification  |  Heure Et Date"

    Private Sub Main_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("هل أنت متأكد من أنك تريد الخروج من البرنامج؟", "تأكيد الخروج" _
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, False) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Main_Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With Me.HG_Light

            .SetHighlightOnFocus(Me.TXT_Nom, True)
            .SetHighlightOnFocus(Me.TXT_NAbonn, True)
            .SetHighlightOnFocus(Me.TXT_NCompteur, True)
            .SetHighlightOnFocus(Me.TXT_IndexPreced, True)
            .SetHighlightOnFocus(Me.TXT_IndexPresent, True)
            .SetHighlightOnFocus(Me.TXT_ConsomM3, True)
            .SetHighlightOnFocus(Me.TXT_Prix, True)
            .SetHighlightOnFocus(Me.TXT_PrixConsomm, True)
            .SetHighlightOnFocus(Me.TXT_Mois, True)
            .SetHighlightOnFocus(Me.TXT_Annee, True)
            .SetHighlightOnFocus(Me.TXT_Abonn, True)
            .SetHighlightOnFocus(Me.TXT_DevMosquee, True)
            .SetHighlightOnFocus(Me.TXT_Total, True)

        End With
        Login_Form.Close()
        InitialiserTout()
    End Sub

    Private Sub BTN_Initialiser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Initialiser.Click
        InitialiserTout()
    End Sub

    Private Sub TM_HeureEtDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_HeureEtDate.Tick
        Me.LBI_DateEtHeure.Text = ("اليوم : " & Now.Day & "   | الشهر : " & Now.Month & "   | السنة : " & Now.Year & "   | الساعة : " & TimeOfDay)
    End Sub

    Private Sub TM_Verification_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_Verification.Tick
        If Me.TXT_Nom.Text <> Nothing And _
            Me.TXT_NAbonn.Text <> Nothing And _
            Me.TXT_ConsomM3.Text <> Nothing And _
            Me.TXT_Prix.Text <> Nothing And _
            Me.TXT_PrixConsomm.Text <> Nothing And _
            Me.TXT_IndexPreced.Text <> Nothing And _
            Me.TXT_IndexPresent.Text <> Nothing And _
            Me.TXT_Mois.Text <> Nothing And _
            Me.TXT_Annee.Text <> Nothing And _
            Me.TXT_Abonn.Text <> Nothing And _
            Me.TXT_DevMosquee.Text <> Nothing And _
            Me.TXT_Total.Text <> Nothing Then

            Me.BTN_Apercu.Enabled = True

        Else
            Me.BTN_Apercu.Enabled = False
        End If
    End Sub

#End Region

#Region "Aperçu  |  Options  |  HelpButton"

    Private Sub BTN_Apercu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Apercu.Click
        Apercu_Form.Show()
    End Sub

    Private Sub BTN_Options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Options.Click
        Options_Form.Show()
    End Sub

    Private Sub Main_Form_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        About_Form.Show()
    End Sub

#End Region

End Class
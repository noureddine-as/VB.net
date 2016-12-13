Public Class Main_Form

#Region "Les Fonctions"

    Function Simplifier(ByVal a As Integer, ByVal b As Integer) As String
        If (a Mod b = 0) Then
            Return a / b
        Else
            Dim PGCD As Integer
            If a < b Then
                For i = a To 1 Step -1
                    If (a Mod i = 0) And (b Mod i = 0) Then
                        PGCD = i
                        Exit For
                    End If
                Next
            ElseIf a > b Then
                For i = b To 1 Step -1
                    If (a Mod i = 0) And (b Mod i = 0) Then
                        PGCD = i
                        Exit For
                    End If
                Next
            End If

            Dim a0 As Integer = a / PGCD
            Dim b0 As Integer = b / PGCD

            Return "S = " & a0 & "/" & b0
        End If
    End Function

    Sub ResoudreE_1Deg(ByVal a As Decimal, ByVal b As Decimal, ByVal x As Decimal, ByVal Observ As Label, ByVal solution As TextBox)
        ' حل معادلة من الدرجة الاولى

        If a <> 0 Then
            ' اذا كان العدد الأول يخالف الصفر

            x = -b / a

            'x = -(Simplifier(b, a))

            ' وضع الملاحظة في الليبل و جعله ظاهرا
            Observ.Text = ("Cette équation a une seule solution sur IR.")
            Observ.Visible = True

            ' وضع النتيجة النهائية في المكان المخصص و اظهارها في ميساج بوكس
            solution.Text = ("X = " & x)
            MsgBox("Cette équation a une seule solution sur IR." & vbNewLine & "X = " & x, MsgBoxStyle.Information, "La Résolution de l'équation")

        ElseIf a = 0 And b = 0 Then
            ' اذا كان العدد الأول و العدد الثاني يساويان صفر

            Observ.Text = ("Cette équation a un nombre infini de solutions sur IR.")
            Observ.Visible = True
            solution.Text = ("S = IR")
            MsgBox("Cette équation a un nombre infini de solutions sur IR." & vbNewLine & "S = IR", MsgBoxStyle.Information, "La Résolution de l'équation")

        ElseIf a = 0 And b <> 0 Then
            ' اذا كان الأول يساوي صفر و الثاني يخالفه

            Observ.Text = ("Cette équation n'a aucune solution sur IR.")
            Observ.Visible = True
            solution.Text = ("S = Ø")
            MsgBox("Cette équation n'a aucune solution sur IR." & vbNewLine & "S = Ø", MsgBoxStyle.Information, "La Résolution de l'équation")

        End If

    End Sub

    Sub ResoudreE_2Deg(ByVal a As Decimal, ByVal b As Decimal, ByVal c As Decimal, ByVal Delta As Decimal, ByVal X1 As String, ByVal X2 As String, ByVal Xp As String, ByVal Xf As String, ByVal Delta0 As Label, ByVal TXT_Delta As TextBox, ByVal Observ As Label, ByVal TXT_X1 As TextBox, ByVal TXT_X2 As TextBox, ByVal TXT_Xp As TextBox, ByVal TXT_Xf As TextBox, ByVal TXT_S As TextBox)
        ' حل معادلة من الدرجة الثانية
        ' أولا نقوم بحساب الدلتا و وضعه في المكان المخصص له

        Delta = (b ^ 2) - (4 * a * c)
        TXT_Delta.Text = Delta

        ' مقارنة الدلتا

        If Delta > 0 Then
            ' اذا كان الدلتا يخالف الصفر
            If a <> 0 Then
                ' اذا كان العدد الاول يخالف الصفر
                ' فان للمعادلة حلان مختلفان
                ' نظهر أن الدلتا اكبر من الصفر
                ' و نقوم باظهار الملاحظة في المكان المخصص لها و نجعلها ظاهرة

                Delta0.Text = ("Δ > 0")
                Observ.Text = ("Cette équation a deux différentes solutions sur IR.")
                Observ.Visible = True

                ' نقوم بحساب الحل الاول
                X1 = Simplifier(((-b) + (Math.Sqrt(Delta))), (2 * a))
                'X1 = ((-b) + (Math.Sqrt(Delta))) / (2 * a)
                TXT_X1.Text = X1

                ' الحل الثاني
                X2 = Simplifier(((-b) - (Math.Sqrt(Delta))), (2 * a))
                'X2 = ((-b) - (Math.Sqrt(Delta))) / (2 * a)
                TXT_X2.Text = X2

                ' مجموع الحلين
                Xp = -(Simplifier(b, a))
                'Xp = (-b) / a
                TXT_Xp.Text = Xp

                ' جداء الحلين
                Xf = Simplifier(c, a)
                'Xf = c / a
                TXT_Xf.Text = Xf

                ' نقوم بوضع الحلول في المكان المخصص
                ' و نظهرها كذلك في رسالة
                TXT_S.Text = ("S = {" & X1 & " ; " & X2 & "}")
                MsgBox("Cette équation a deux différentes solutions sur IR:" & vbNewLine & "S = {" & X1 & " ; " & X2 & "}", MsgBoxStyle.Information, "La Résolution de l'équation")

            Else

                ' اذا كان العدد الاول يساوي الصفر

                Initialiser_Deg2_Sans_a_Et_b()
                MsgBox("Il faut que le nombre 'a' soit non égal à zéro (a ≠ 0).", MsgBoxStyle.Critical, "Erreur")

            End If

        ElseIf Delta = 0 Then

            ' اذا كان الدلتا يساوي الصفر

            If a <> 0 Then

                ' اذا كان العدد الاول يخالف الصفر
                ' فان للمعادلة حلا مزدوجا في المجموعة R

                Delta0.Text = ("Δ = 0")
                Observ.Text = ("Cette équation a une seule solution double sur IR.")
                Observ.Visible = True

                X1 = (-b) / (2 * a)
                TXT_X1.Text = X1
                X2 = (-b) / (2 * a)
                TXT_X2.Text = X2

                Xp = (-b) / a
                TXT_Xp.Text = Xp

                Xf = c / a
                TXT_Xf.Text = Xf

                TXT_S.Text = ("S = {" & X1 & "}")
                MsgBox("Cette équation a une seule solution double sur IR." & vbNewLine & "S = {" & X1 & "}", MsgBoxStyle.Information, "La Résolution de l'équation")

            Else

                Initialiser_Deg2_Sans_a_Et_b()
                MsgBox("Il faut que le nombre 'a' soit non égal à zéro (a ≠ 0).", MsgBoxStyle.Critical, "Erreur")

            End If

        ElseIf Delta < 0 Then

            ' اذا كان الدلتا اصغر من الصفر

            If a <> 0 Then

                Initialiser_X1_X2_Xp_Xf()

                Delta0.Text = ("Δ < 0")
                Observ.Text = ("Cette équation n'a aucune solution sur IR.")
                Observ.Visible = True

                TXT_S.Text = ("S = Ø")
                MsgBox("Cette équation n'a aucune solution sur IR." & vbNewLine & "S = Ø", MsgBoxStyle.Information, "La Résolution de l'équation")

            Else

                Initialiser_Deg2_Sans_a_Et_b()
                MsgBox("Il faut que le nombre 'a' soit non égal à zéro (a ≠ 0).", MsgBoxStyle.Critical, "Erreur")

            End If

        End If

    End Sub

#End Region

#Region "Les boutons"

    Private Sub BTN_Resoudre1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Resoudre1.Click

        Try
            ' نعرف ثلاث متغيرات

            Dim a As Decimal = Me.Donnee1_TXT_a.Text
            Dim b As Decimal = Me.Donnee1_TXT_b.Text
            Dim x As Decimal

            ' نستعمل الدالة لحل المعادلة

            ResoudreE_1Deg(a, b, x, Me.Resolution1_LBL_Observ, Me.Resolution1_TXT_S)

        Catch ex As Exception

            ' اذا لم يكن محتوى احد مربعات النص رقميا

            If IsNumeric(Me.Donnee1_TXT_a.Text) = False Or IsNumeric(Me.Donnee1_TXT_b.Text) = False Then

                MsgBox("Il faut remplir les deux cases par des nombres.", MsgBoxStyle.Exclamation, "Erreur")

            End If

        End Try

    End Sub

    Private Sub BTN_Resoudre2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Resoudre2.Click

        Try
            ' هنا ايضا نعرف المتغيرات اولا

            Dim a As Decimal = Me.Donnee2_TXT_a.Text
            Dim b As Decimal = Me.Donnee2_TXT_b.Text
            Dim c As Decimal = Me.Donnee2_TXT_c.Text

            Dim Delta As Decimal

            Dim X1 As Decimal
            Dim X2 As Decimal

            Dim Xp As Decimal
            Dim Xf As Decimal

            ' نستعمل دالة حل معادلات الدرجة الثانية

            ResoudreE_2Deg(a, b, c, Delta, X1, X2, Xp, Xf, Me.Resolution2_LBL_Delta0, Me.Resolution2_TXT_Delta, Me.Resolution2_LBL_Observ, Me.Resolution2_TXT_X1, Me.Resolution2_TXT_X2, Me.Resolution2_TXT_X1plusX2, Me.Resolution2_TXT_X1foisX2, Me.Resolution2_TXT_S)

        Catch ex As Exception

            ' اذا لم يكن محتوى احد مربعات النص رقميا

            If IsNumeric(Me.Donnee2_TXT_a.Text) = False Or IsNumeric(Me.Donnee2_TXT_b.Text) = False Or IsNumeric(Me.Donnee2_TXT_c.Text) = False Then

                MsgBox("Il faut remplir les trois cases par des nombres.", MsgBoxStyle.Exclamation, "Erreur")

            End If

        End Try

    End Sub

#End Region

#Region "Actualisation | Initialisation"

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Me.RB_1.Checked Then ' في حالة تفعيل الخيار الاول

            ' نقوم بتفعيل الجروب بوكس الاول و الغاء الثاني
            GB_Deg1.Enabled = True
            GB_Deg2.Enabled = False
            ' جعل الزر الاول هو زر الموافقة في الفورم
            Me.AcceptButton = Me.BTN_Resoudre1

        ElseIf Me.RB_2.Checked Then ' في حالة تفعيل الخيار الثاني

            ' نقوم بتفعيل الثاني و الغاء الاول
            GB_Deg1.Enabled = False
            GB_Deg2.Enabled = True
            ' جعل الزر الثاني هو زر الموافقة في الفورم
            Me.AcceptButton = Me.BTN_Resoudre2

        End If

    End Sub

    Sub InitialiserTout()

        ' اعادة كل شيء الى ما كان عليه
        ' و ذلك بتفعيل الخيار الاول و افراغ مربعات النصوص و الملاحظات
        ' و كذلك تفعيل الجروب الاول و الغاء الثاني

        Me.RB_1.Checked = True

        Me.Donnee1_TXT_a.Text = ""
        Me.Donnee1_TXT_b.Text = ""

        Me.Donnee2_TXT_a.Text = ""
        Me.Donnee2_TXT_b.Text = ""
        Me.Donnee2_TXT_c.Text = ""

        Me.Resolution1_LBL_Observ.Visible = False
        Me.Resolution1_LBL_Observ.Text = ""
        Me.Resolution1_TXT_S.Text = ""

        Me.Resolution2_TXT_Delta.Text = ""
        Me.Resolution2_LBL_Delta0.Text = ""

        Me.Resolution2_TXT_X1.Text = ""
        Me.Resolution2_TXT_X2.Text = ""

        Me.Resolution2_TXT_X1plusX2.Text = ""
        Me.Resolution2_TXT_X1foisX2.Text = ""

        Me.Resolution2_LBL_Observ.Visible = False
        Me.Resolution2_LBL_Observ.Text = ""

        Me.Resolution2_TXT_S.Text = ""

    End Sub

    Sub Initialiser_X1_X2_Xp_Xf()

        ' اعادة مكان الحل الاول و مكان الحل الثاني و مكان
        ' مجموع الحلول و مكان جداء الحلول الى ما كان عليه

        Me.Resolution2_TXT_X1.Text = ""
        Me.Resolution2_TXT_X2.Text = ""

        Me.Resolution2_TXT_X1plusX2.Text = ""
        Me.Resolution2_TXT_X1foisX2.Text = ""

    End Sub

    Sub Initialiser_Deg2_Sans_a_Et_b()

        ' اعادة منطقة المعادلات من الدرجة الثانية
        ' باستثناء مكان العدد الاول ومكان العدد الثاني
        ' الى ما كان عليه

        Me.Donnee2_TXT_a.Text = ""

        Me.Resolution2_TXT_Delta.Text = ""
        Me.Resolution2_LBL_Delta0.Text = ""

        Me.Resolution2_TXT_X1.Text = ""
        Me.Resolution2_TXT_X2.Text = ""

        Me.Resolution2_TXT_X1plusX2.Text = ""
        Me.Resolution2_TXT_X1foisX2.Text = ""

        Me.Resolution2_LBL_Observ.Visible = False
        Me.Resolution2_LBL_Observ.Text = ""

        Me.Resolution2_TXT_S.Text = ""

    End Sub

#End Region

#Region "Les menus et les barres"

    Private Sub InitialiserToutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitialiserToutToolStripMenuItem.Click

        ' اعادة كل شيء الى ماكان عليه

        InitialiserTout()

    End Sub

    Private Sub AideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AideToolStripMenuItem.Click

        ' اظهار نافذة المساعدة

        Aide_Form.Show(Me)

    End Sub

    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click

        ' اظهار نافذة عن البرنامج

        AboutBox1.Show(Me)

    End Sub

    Private Sub DateEtHeure_TIM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEtHeure_TIM.Tick

        ' اظهار التاريخ و الوقت في شريط الحالات

        DateEtHeure_SbT.Text = (Now.ToLongDateString & "  |  " & TimeOfDay.ToLongTimeString)

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click

        ' اغلاق البرنامج

        End

    End Sub

#End Region

    ' اهداء لجميع اعضاء و زوار منتدى لغات البرمجة
    ' http://www.startimes.com/f.aspx?f=233
    ' اتمنى ان يفيدكم البرنامج، و السلام عليكم و رحمة الله تعالى و بركاته

End Class

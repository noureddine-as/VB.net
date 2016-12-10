Public Class Login_Form

    Private Sub BTN_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Ok.Click
        If (Me.TXT_UserName.Text = "association tamgounssi" And Me.TXT_Password.Text = "a.t_42152") Then
            MsgBox("المعطيات صحيحة" & vbNewLine & "أنقر على الزر ليتم توجيهك للصفحة الرئيسية", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, "المعطيات صحيحة")
            Main_Form.Show()
        Else
            MsgBox("المعطيات غير صحيحة" & vbNewLine & "المرجو التحقق من المعطيات المدخلة", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight, "المعطيات خاطئة")
            Me.TXT_UserName.Select()
        End If
    End Sub

    Private Sub BTN_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Annuler.Click
        If MsgBox("هل تريد فعلا الخروج من البرنامج؟", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "الخروج من البرنامج") = MsgBoxResult.Ok Then
            End
        Else
            Me.TXT_UserName.Select()
        End If
    End Sub

    Private Sub Login_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HG_Red.SetHighlightOnFocus(Me.TXT_UserName, True)
        Me.HG_Red.SetHighlightOnFocus(Me.TXT_Password, True)
        Me.TXT_UserName.Select()
        With My.Settings
            If .Office2007Blue = ("Selected") Then
                Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
                Options_Form.CB_Theme.SelectedItem = ("Office 2007 Bleu")

            ElseIf .Office2007Black = ("Selected") Then
                Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black
                Options_Form.CB_Theme.SelectedItem = ("Office 2007 Noir")

            End If
        End With

    End Sub

End Class
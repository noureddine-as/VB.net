Imports System.IO

Public Class UP_Config

#Region "Load | Ok - Ok2 | Annuler - Annuler2"

    Private Sub UP_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.P_1.Visible = True
        Me.P_2.Visible = False
        Me.AcceptButton = Me.BTN_Ok
        Me.CancelButton = Me.BTN_Annuler
        Me.TXT_OldUsername.Select()
    End Sub

    Private Sub BTN_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Ok.Click
        Dim OUN As String = GetLoginInfos("UN", "Config.ini")
        Dim OPW As String = GetLoginInfos("PW", "Config.ini")

        If Me.TXT_OldUsername.Text = OUN And _
           Me.TXT_OldPassword.Text = OPW Then
            Me.P_1.Visible = False
            Me.P_2.Visible = True
            Me.AcceptButton = Me.BTN_Ok2
            Me.CancelButton = Me.BTN_Annuler2
            Me.TXT_NewUsername.Select()
        Else
            MsgBox(".يجب إدخال المعطيات القديمة بشكل صحيح قبل تغييرها", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "المعطيات خاطئة")
            Me.TXT_OldUsername.Select()
        End If
    End Sub

    Private Sub BTN_Ok2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Ok2.Click
        If Me.TXT_NewUsername.Text = "" And Me.TXT_NewPassword.Text = "" Then
            If MessageBox.Show("المرجو تأكيد رغبتك في مسح معلومات الدخول؟" & vbNewLine & ".(للمواصلة اضغط على الزر (نعم) للعودة اضغط على الزر (لا", "مسح معلومات الدخول", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, False) = _
                                                   Windows.Forms.DialogResult.Yes Then

                SetLoginInfos("", "")
                Me.Close()
            Else
                Me.TXT_NewUsername.Select()
            End If
        Else
            If MessageBox.Show(".المرجو تأكيد اختيارك" & vbNewLine & ".(للمواصلة اضغط على الزر (نعم) للعودة اضغط على الزر (لا", "تغيير معلومات الدخول", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, False) = _
                                       Windows.Forms.DialogResult.Yes Then

                SetLoginInfos(Me.TXT_NewUsername.Text, Me.TXT_NewPassword.Text)
                Me.Close()
            Else
                Me.TXT_NewUsername.Select()
            End If
        End If
    End Sub

    Private Sub BTN_Annuler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Annuler.Click
        Me.Close()
    End Sub

    Private Sub BTN_Annuler2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Annuler2.Click
        Me.TXT_OldUsername.Text = ""
        Me.TXT_OldPassword.Text = ""
        Me.AcceptButton = Me.BTN_Ok
        Me.CancelButton = Me.BTN_Annuler
        Me.P_1.Visible = True
        Me.P_2.Visible = False
        Me.TXT_NewUsername.Text = ""
        Me.TXT_NewPassword.Text = ""
    End Sub

#End Region

#Region "Fonctions"

    Function GetLoginInfos(ByVal key As String, ByVal Path As String) As String
        For Each Line As String In File.ReadAllLines(Path)
            If Line.Split("=")(0) = key Then
                Dim KeyValue As String = Line.Split("=")(1)
                Return KeyValue
            End If
        Next
        Return ""
    End Function

    Sub SetLoginInfos(ByVal NewUserName As String, ByVal NewPassword As String)
        Try
            File.SetAttributes("Config.ini", FileAttributes.Normal)

            Dim SR = New StreamReader("Config.ini")
            Dim L1 As String = SR.ReadLine()  '[LoginInfos]
            Dim L2 As String = SR.ReadLine()  'UN=0
            Dim L3 As String = SR.ReadLine()  'PW=0
            Dim L4 As String = SR.ReadLine()  '
            Dim L5 As String = SR.ReadLine()  '[DureeConsommation]
            Dim L6 As String = SR.ReadLine()  'DCType=Auto or DCType=Manual,06/2011
            Dim L7 As String = SR.ReadLine()  '
            Dim L8 As String = SR.ReadLine()  '[Others]
            Dim L9 As String = SR.ReadLine()  'P=5,00
            Dim L10 As String = SR.ReadLine() 'A=13,00
            Dim L11 As String = SR.ReadLine() 'M=13,50
            SR.Close()

            Dim SW = New StreamWriter("Config.ini")
            SW.WriteLine(L1)
            SW.WriteLine("UN=" & NewUserName)
            SW.WriteLine("PW=" & NewPassword)
            SW.WriteLine(L4)
            SW.WriteLine(L5)
            SW.WriteLine(L6)
            SW.WriteLine(L7)
            SW.WriteLine(L8)
            SW.WriteLine(L9)
            SW.WriteLine(L10)
            SW.WriteLine(L11)
            SW.Close()

            File.SetAttributes("Config.ini", FileAttributes.Hidden)

            MsgBox(".تم حفظ معلومات الدخول الجديدة بنجاح", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, "تغيير معلومات الدخول")
        Catch ex As Exception
            MsgBox(".تعرض البرنامج لخلل أثناء تغيير معلومات الدخول" & vbNewLine & ".المرجو المحاولة مرة أخرى أو تغييرها يدويا", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "تغيير معلومات الدخول")
            Me.TXT_NewUsername.Select()
        End Try
    End Sub

#End Region

End Class
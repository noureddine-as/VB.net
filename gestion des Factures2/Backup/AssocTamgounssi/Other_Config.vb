Imports System.IO

Public Class Other_Config

#Region "Load | Boutons"

    Private Sub Config_Abonnement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim P As String = GetInfos("P", "Config.ini")
        Dim A As String = GetInfos("A", "Config.ini")
        Dim M As String = GetInfos("M", "Config.ini")

        Me.TXT_Prix.Text = P
        Me.TXT_Abonn.Text = A
        Me.TXT_Mosquee.Text = M
    End Sub

    Private Sub BTN_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Ok.Click
        Dim NP As String = Me.TXT_Prix.Text
        Dim NA As String = Me.TXT_Abonn.Text
        Dim NM As String = Me.TXT_Mosquee.Text

        If (IsNumeric(NP) = True) And _
           (IsNumeric(NA) = True) And _
           (IsNumeric(NM) = True) Then

            SetNewValues(NP, NA, NM)
        Else
            MsgBox(".يجب أن تكون جمبع القيم أعداد (صحيحة أو عشرية) غير منعدمة", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "إعدادات أخرى")
            Me.TXT_Prix.Select()
        End If
    End Sub

    Private Sub BTN_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Annuler.Click
        Me.Close()
    End Sub

#End Region

#Region "Fonctions & Procédures"

    Function GetInfos(ByVal Key As String, ByVal Path As String)
        For Each Line As String In File.ReadAllLines(Path)
            If Line.Split("=")(0) = Key Then
                Return Line.Split("=")(1)
            End If
        Next
        Return ""
    End Function

    Sub SetNewValues(ByVal NPrix As Double, ByVal NAbonn As Double, ByVal NMosq As Double)
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
            SW.WriteLine(L2)
            SW.WriteLine(L3)
            SW.WriteLine(L4)
            SW.WriteLine(L5)
            SW.WriteLine(L6)
            SW.WriteLine(L7)
            SW.WriteLine(L8)
            SW.WriteLine("P=" & NPrix)
            SW.WriteLine("A=" & NAbonn)
            SW.WriteLine("M=" & NMosq)

            SW.Close()

            File.SetAttributes("Config.ini", FileAttributes.Hidden)

            MsgBox(".تم حفظ المعطيات الجديدة بنجاح", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, "إعدادات أخرى")

            Me.Close()
        Catch ex As Exception
            MsgBox(".تعرض البرنامج لخلل أثناء تغيير واجبات الإشتراك" & vbNewLine & ".المرجو المحاولة مرة أخرى أو تغييرها يدويا", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "تغيير معلومات الدخول")
            Me.TXT_Prix.Select()
        End Try
    End Sub

#End Region

End Class
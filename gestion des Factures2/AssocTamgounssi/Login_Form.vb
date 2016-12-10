Imports System.IO

Public Class Login_Form

#Region "Gestion des boutons"

    Private Sub BTN_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Ok.Click
        Dim Path As String = ("Config.ini")
        Dim UserN As String = GetLoginInfo("UN", Path)
        Dim PassW As String = GetLoginInfo("PW", Path)
        If (Me.TXT_Username.Text = UserN) And _
            (Me.TXT_Password.Text = PassW) Then
            Main_Form.Show()
            Me.Close()
        Else
            MsgBox("المعطيات خاطئة" & vbNewLine & "المرجو التحقق من المعطيات المدخلة ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight, "المعطيات خاطئة")
            Me.TXT_Username.Select()
        End If
    End Sub

    Private Sub BTN_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Annuler.Click
        End
    End Sub

#End Region

#Region "FormLoad"

    Private Sub Login_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists("Config.ini") = False Then
            Dim SW As New StreamWriter("Config.ini")
            SW.WriteLine("[LoginInfos]")
            SW.WriteLine("UN=0")
            SW.WriteLine("PW=0")
            SW.WriteLine("")
            SW.WriteLine("[DureeConsommation]")
            SW.WriteLine("DCType=Auto")
            SW.WriteLine("")
            SW.WriteLine("[Others]")
            SW.WriteLine("P=5,00")
            SW.WriteLine("A=13,00")
            SW.WriteLine("M=13,50")
            SW.Close()
            File.SetAttributes("Config.ini", FileAttributes.Hidden)
        Else
            If File.GetAttributes("Config.ini") <> FileAttributes.Hidden Then
                File.SetAttributes("Config.ini", FileAttributes.Hidden)
            End If
        End If
        Me.TXT_Username.Select()
    End Sub

#End Region

#Region "Fonctions"

    Function GetLoginInfo(ByVal Key As String, ByVal Path As String) As String
        For Each Line As String In File.ReadAllLines(Path)
            If Line.Split("=")(0) = Key Then
                Return Line.Split("=")(1)
            End If
        Next
        Return ""
    End Function

#End Region

End Class

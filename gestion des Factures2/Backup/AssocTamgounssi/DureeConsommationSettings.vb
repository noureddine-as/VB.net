Imports System.IO

Public Class DureeConsommationSettings

#Region "FormLoad | Timer | Boutons"

    Private Sub DureeConsommationSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Mois, Annee As String

        Annee = Now.Year

        If Now.Month <= 9 Then
            Mois = "0" & Now.Month
        Else
            Mois = Now.Month
        End If

        MTBAdv_1.Text = Mois & "/" & Annee

        If GetDCType("Config.ini") = "Auto" Then
            Me.RB_Auto.Checked = True
        ElseIf GetDCType("Config.ini") = "Manual" Then
            Me.RB_Manual.Checked = True
            Me.MTBAdv_1.Text = GetManualValue("Config.ini")
        End If

    End Sub

    Private Sub TM_1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_1.Tick
        If Me.RB_Auto.Checked = True Then
            MTBAdv_1.Enabled = False
        ElseIf Me.RB_Manual.Checked = True Then
            MTBAdv_1.Enabled = True
        End If
    End Sub

    Private Sub BTN_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Annuler.Click
        Me.Close()
    End Sub

    Private Sub BTN_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Ok.Click
        If Me.RB_Auto.Checked = True Then
            WriteIniFile("Auto", Nothing, "Config.ini")
        ElseIf Me.RB_Manual.Checked = True Then
            Dim DCValue As String = MTBAdv_1.Text
            WriteIniFile("Manual", DCValue, "Config.ini")
        End If
        Me.Close()
    End Sub

#End Region

#Region "Procédures & Fonctions"

    Sub WriteIniFile(ByVal AutoOrManual As String, ByVal OnManualChoice As String, ByVal path As String)
        File.SetAttributes(path, FileAttributes.Normal)

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

        Dim SW As New StreamWriter(path)
        SW.WriteLine(L1)
        SW.WriteLine(L2)
        SW.WriteLine(L3)
        SW.WriteLine(L4)
        SW.WriteLine(L5)

        If AutoOrManual = "Auto" Then
            SW.WriteLine("DCType=Auto")
        ElseIf AutoOrManual = "Manual" Then
            SW.WriteLine("DCType=Manual," & OnManualChoice)
        End If

        SW.WriteLine(L7)
        SW.WriteLine(L8)
        SW.WriteLine(L9)
        SW.WriteLine(L10)
        SW.WriteLine(L11)

        SW.Close()
        File.SetAttributes(path, FileAttributes.Hidden)

    End Sub

    Function GetDCType(ByVal Path As String) As String
        For Each Line As String In File.ReadAllLines(Path)
            If Line.Split("=")(0) = "DCType" Then
                If Line.Split("=")(1).StartsWith("Auto") Then
                    Return "Auto"
                ElseIf Line.Split("=")(1).StartsWith("Manual") Then
                    Return "Manual"
                End If
            End If
        Next
        Return ""
    End Function

    Function GetManualValue(ByVal Path As String) As String
        For Each Line As String In File.ReadAllLines(Path)
            If Line.Split("=")(0) = "DCType" Then
                Dim TYPEandValue As String = Line.Split("=")(1)
                Dim Value As String = TYPEandValue.Split(",")(1)
                Return Value
            End If
        Next
        Return ""
    End Function

#End Region

End Class
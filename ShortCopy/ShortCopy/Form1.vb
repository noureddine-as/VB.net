Imports System.IO

Public Class Main_Form

    Dim Path As String = "D:\Others\SCList.txt"

#Region "Fonctions et Procédures"

    Public Sub AddNewLine(ByVal Line As String)
        If Line <> Nothing Then
            Try
                Me.LB_ShortCopies.Items.Add(Line)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub DeleteSelectedLine(ByVal ListBox As ListBox)
        If ListBox.SelectedItems.Count <> Nothing Then
            Me.LB_ShortCopies.Items.Remove(Me.LB_ShortCopies.SelectedItem)
        Else
            MsgBox("Veuillez selectionnez d'abord un élément ou plusieurs.", _
                   MsgBoxStyle.Exclamation, "Erreur")
        End If
    End Sub

    Public Sub WriteToFile(ByVal Path As String, ByVal ListBox As ListBox)
        Try
            Dim SW As New StreamWriter(Path)

            For Each Line As String In ListBox.Items
                SW.WriteLine(Line)
            Next

            SW.Close()
        Catch ex As Exception
            MsgBox("Erreur !!", MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

    Public Sub ReadFromFile(ByVal Path As String, ByVal ListBox As ListBox)
        Try
            Dim SR As New StreamReader(Path)

            For Each Line As String In File.ReadAllLines(Path)
                ListBox.Items.Add(Line)
            Next

            SR.Close()
        Catch ex As Exception
            MsgBox("Erreur !!", MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

    Public Function GetClipBoardContent() As String
        If My.Computer.Clipboard.ContainsText = True Then
            Return My.Computer.Clipboard.GetText()
        Else
            Return ""
        End If
    End Function

    Public Sub CopySelectedItem(ByVal ListBox As ListBox)
        Try
            If ListBox.SelectedItems.Count <> Nothing Then
                My.Computer.Clipboard.SetText(ListBox.SelectedItem)
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Private Sub Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReadFromFile(Path, Me.LB_ShortCopies)
        Me.TXT_TextToSave.Text = GetClipBoardContent()
        Me.NotifyIcon1.ShowBalloonTip(3000)
    End Sub

    Private Sub BTN_AddNewLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AddNewLine.Click
        AddNewLine(Me.TXT_TextToSave.Text)
        WriteToFile(Path, Me.LB_ShortCopies)
    End Sub

    Private Sub BTN_DeleteLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DeleteLine.Click
        DeleteSelectedLine(Me.LB_ShortCopies)
        WriteToFile(Path, Me.LB_ShortCopies)
    End Sub

    Private Sub BTN_Copier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Copier.Click
        CopySelectedItem(Me.LB_ShortCopies)
    End Sub

    Private Sub BTN_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exit.Click
        End
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub RestaurerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurerToolStripMenuItem.Click
        ShowFrm()
    End Sub

    'Private Sub Main_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    'HideFrm()
    'End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        ShowFrm()
    End Sub

    Sub ShowFrm()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Sub HideFrm()
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        Me.NotifyIcon1.ShowBalloonTip(3000)
    End Sub

    Private Sub Main_Form_MaximizedBoundsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximizedBoundsChanged
        HideFrm()
    End Sub

End Class

Imports System.IO

Public Class Form1

    Private Fpath As String = "D:\Others\LCopy.txt"
    Public Property _Fpath() As String
        Get
            Return Fpath
        End Get
        Set(ByVal value As String)
            Fpath = value
        End Set
    End Property

    Sub SaveLines()
        Dim SW As New StreamWriter(Fpath)
        For Each Line As String In Me.lbLines.Items
            SW.WriteLine(Line)
        Next
        SW.Close()
    End Sub

    Sub AddLine(ByVal Line As String)
        Try
            Me.lbLines.Items.Add(Line)

            SaveLines()

            Dim MiniLine As String = GetShortLineTxt(Line, 10)

            Me.lblSatus.Text = String.Format("L'élement '{0}' a été ajouté.", MiniLine & "...")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub DeleteLine()
        If Me.lbLines.SelectedItems.Count = 0 Then
            MsgBox("Selectionnez d'abord un élement de la liste.", MsgBoxStyle.Exclamation, "LineCopy")
        Else

            Dim Index As Integer = Me.lbLines.SelectedIndex
            Dim LineTxt As String = Me.lbLines.Items.Item(Index).ToString

            Dim MiniLine As String = GetShortLineTxt(LineTxt, 10)

            Me.lbLines.Items.RemoveAt(Index)

            SaveLines()

            Me.lblSatus.Text = String.Format("L'élement '{0}' a été supprimé.", MiniLine & "...")

        End If
    End Sub


    Function GetShortLineTxt(ByVal Line As String, ByVal CaractersCount As Integer) As String
        Dim ShortLineTxt As String = Nothing
        Dim i As Integer = 0

        For Each C As Char In Line
            If i < CaractersCount Then
                ShortLineTxt &= C
                i += 1
            Else
                Exit For
            End If
        Next

        Return ShortLineTxt
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddLine(Me.txtText.Text)
    End Sub

    Private Sub btnCopier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopier.Click

    End Sub
End Class

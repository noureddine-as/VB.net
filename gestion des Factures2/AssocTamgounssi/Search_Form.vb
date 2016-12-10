Public Class Search_Form

#Region "Load"

    Private Sub Search_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each Champ As Data.DataColumn In Main_Form.Quittance_Eau_PotableTableAdapter.GetData.Columns
            Me.CB_Champs.Items.Add(Champ.Caption.ToString)
        Next
        Me.CB_Champs.SelectedIndex = 0
        Me.TXT_Input.Select()
    End Sub

#End Region

#Region "BTN_Search | BTN_Cancel | TXT_Input"

    Private Sub BTN_Search_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Search.Click
        Dim Text As String = Me.TXT_Input.Text
        Dim Prop As String = Me.CB_Champs.SelectedItem.ToString
        Search(Text, Prop, False)
    End Sub

    Private Sub BTN_Cancel_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    Private Sub TXT_Input_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_Input.TextChanged
        Dim Text As String = Me.TXT_Input.Text
        Dim Prop As String = Me.CB_Champs.SelectedItem.ToString
        Search(Text, Prop, True)
    End Sub

#End Region

#Region "Procédures"

    Sub Search(ByVal Text As String, ByVal Prop As String, ByVal OnValidating As Boolean)
        If (OnValidating = True) Then
            Try
                If Me.CB_Champs.SelectedItem <> Nothing Then
                    Dim Index As Integer = Main_Form.Quittance_Eau_PotableBindingSource.Find(Prop, Text)
                    Main_Form.DGV_1.Rows(Index).Selected = True
                    Me.TXT_Input.Select()
                End If
            Catch ex As Exception
            End Try
        ElseIf (OnValidating = False) Then
            Try
                If Me.CB_Champs.SelectedItem <> Nothing Then
                    Dim Index As Integer = Main_Form.Quittance_Eau_PotableBindingSource.Find(Prop, Text)
                    Main_Form.DGV_1.Rows(Index).Selected = True
                End If
            Catch ex As Exception
                If Text = Nothing Then
                    MsgBox(".قم أولا بإدخال القيمة التي تريد البحث عنها", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "بحث")
                    Me.TXT_Input.Select()
                Else
                    If (Main_Form.Quittance_Eau_PotableBindingSource.Contains(Text) = False) Then
                        Dim P1 As String = ("." & "هذا العنصر غير موجود في عمود " & Prop)
                        MsgBox(P1, MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight, "بحث")
                        Me.TXT_Input.Select()
                    Else
                        MsgBox(".إما أن العنصر الذي تبحث عنه غير موجود في قاعدة البيانات أو أن هناك خطأ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight, "خلل أثناء البحث")
                        Me.TXT_Input.Select()
                    End If
                End If
            End Try
        End If
    End Sub

#End Region

End Class
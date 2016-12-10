Imports System.IO
Imports Microsoft.Office.Interop

Public Class Main_Form

#Region "Load | FormClosing | SavingItem | Timer | Help | Exit"

    Private Sub Quittance_Eau_PotableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quittance_Eau_PotableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Quittance_Eau_PotableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AT_DBDataSet)
    End Sub

    Private Sub Main_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox(".المرجو تأكيد خروجك من البرنامج", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "تأكيد الخروج") = MsgBoxResult.Ok Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AT_DBDataSet.Quittance_Eau_Potable' table. You can move, or remove it, as needed.
        Me.Quittance_Eau_PotableTableAdapter.Fill(Me.AT_DBDataSet.Quittance_Eau_Potable)
        Me.SB_Menu.ExpandedPanel = Me.SBP_Visualisation
    End Sub

    Private Sub BTN_Restart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Restart.Click
        Application.Restart()
    End Sub

    Private Sub BTN_Exit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN_Exit.Click
        Me.Close()
    End Sub

    Private Sub Main_Form_HelpButtonClicked(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        Help.Show()
    End Sub

#End Region

#Region "Fenetre Des Opérations"

    Private Sub BI_Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BI_Change.Click
        ChangeIndex()
        Me.BI_Change.Enabled = False
    End Sub

    Private Sub BI_Calculs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BI_Calculs.Click
        Calculs()
    End Sub

    Private Sub BI_Enreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BI_Enreg.Click
        ' verification
        If (Verifier() = True) Then
            ' enregistrer et passer au membre suivant
            EnregistrerPasser()
            Me.BI_Change.Enabled = True
        Else
            MsgBox(".المرجو مراجعة المعلومات قبل المرور الى المشترك التالي", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "مراجعة المعطيات")
        End If
    End Sub

#End Region

#Region "Fonctions & Procédures"

    Dim Prix As Double = CDbl(GetInfos("P", "Config.ini"))
    Dim Abonn As Double = CDbl(GetInfos("A", "Config.ini"))
    Dim Mosq As Double = CDbl(GetInfos("M", "Config.ini"))

    Sub ChangeIndex()
        Try
            If DureeConsommationSettings.GetDCType("Config.ini") = "Auto" Then
                Me.فترة_الاستهلاكMaskedTextBoxAdv.Text = GetMonthYear()
            ElseIf DureeConsommationSettings.GetDCType("Config.ini") = "Manual" Then
                Me.فترة_الاستهلاكMaskedTextBoxAdv.Text = DureeConsommationSettings.GetManualValue("Config.ini")
            End If
        Catch ex As Exception
            Me.فترة_الاستهلاكMaskedTextBoxAdv.Text = GetMonthYear()
        End Try
        Me.الدليل_السابقTextBoxX.Text = Me.الدليل_الحاليTextBoxX.Text
        Me.الدليل_الحاليTextBoxX.Text = ""
        Me.الدليل_الحاليTextBoxX.Select()

    End Sub

    Function Verifier() As Boolean
        Try
            Dim Consomm As Integer = CInt(Me.الاستهلاكTextBoxX.Text)
            Dim ConsommV As Boolean = False

            Dim PrixConsomm As Integer = CInt(Me.مبلغ_الاستهلاكTextBoxX.Text)
            Dim PrixConsommV As Boolean = False

            Dim Total As Double = CDbl(Me.المجموعTextBoxX.Text)
            Dim TotalV As Boolean = False

            If Consomm = CInt(Me.الدليل_الحاليTextBoxX.Text) - _
                         CInt(Me.الدليل_السابقTextBoxX.Text) Then

                ConsommV = True
            Else
                ConsommV = False
            End If

            If PrixConsomm = Consomm * Prix Then
                PrixConsommV = True
            Else
                PrixConsommV = False
            End If

            If (Total = PrixConsomm + Abonn + Mosq) Then
                TotalV = True
            Else
                TotalV = False
            End If

            If ((ConsommV = True) And (PrixConsommV = True) And (TotalV = True)) Then
                Verifier = True
            Else
                Verifier = False
            End If

        Catch ex As Exception
            Verifier = False
        End Try

        Return Verifier
    End Function

    Sub Calculs()
        If (IsNumeric(Me.الدليل_السابقTextBoxX.Text) = True) And _
           (IsNumeric(Me.الدليل_الحاليTextBoxX.Text) = True) Then
            Me.الاستهلاكTextBoxX.Text = (CInt(Me.الدليل_الحاليTextBoxX.Text) - CInt(Me.الدليل_السابقTextBoxX.Text))
            Me.مبلغ_الاستهلاكTextBoxX.Text = (CInt(Me.الاستهلاكTextBoxX.Text) * Prix)
            Me.المجموعTextBoxX.Text = (CInt(Me.مبلغ_الاستهلاكTextBoxX.Text) + Abonn + Mosq)
        Else
            MsgBox(".يجب أن لا تكون قيمة الدليل الحالي أو الدليل السابق منعدمة", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, "إنجاز الحسابات")
        End If
    End Sub

    Sub EnregistrerPasser()
        Me.Validate()
        Me.Quittance_Eau_PotableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AT_DBDataSet)
        Dim CurrentIndex As Integer = Me.DGV_1.CurrentRow.Index
        If (CurrentIndex = Me.DGV_1.Rows.GetLastRow(DataGridViewElementStates.None)) Then
            MsgBox(".تم بفضل الله إتمام و حفظ معطيات جميع المشتركين" & vbNewLine & ".يمكنك الآن مراجعة البيانات أو حفظها مباشرة", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, "انتهى")
            Me.Validate()
            Me.Quittance_Eau_PotableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AT_DBDataSet)
            My.Computer.Audio.Play(My.Resources.Vista_MSNMSGR_ContactOnline, AudioPlayMode.Background)
            Me.Quittance_Eau_PotableBindingSource.MoveFirst()
            Me.SB_Menu.ExpandedPanel = Me.SBP_Visualisation
        Else
            My.Computer.Audio.Play(My.Resources.Vista_MSNMSGR_NewAlert, AudioPlayMode.Background)
            Me.Quittance_Eau_PotableBindingSource.MoveNext()
        End If
    End Sub

    Function GetMonthYear() As String

        Dim Mois, Annee As String

        Annee = Now.Year

        If Now.Month <= 9 Then
            Mois = "0" & Now.Month
        Else
            Mois = Now.Month
        End If

        Return (Mois & "/" & Annee)
    End Function

    Function GetInfos(ByVal Key As String, ByVal Path As String) As String
        For Each Line As String In File.ReadAllLines(Path)
            If Line.Split("=")(0) = Key Then
                Return Line.Split("=")(1)
            End If
        Next
        Return ""
    End Function

#End Region

#Region "Fenetre De Visualisation"

    Private Sub BTN_First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_First.Click
        Me.Quittance_Eau_PotableBindingSource.MoveFirst()
    End Sub

    Private Sub BTN_Precedent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Precedent.Click
        Me.Quittance_Eau_PotableBindingSource.MovePrevious()
    End Sub

    Private Sub BTN_Suivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Suivant.Click
        Me.Quittance_Eau_PotableBindingSource.MoveNext()
    End Sub

    Private Sub BTN_Dernier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Dernier.Click
        Me.Quittance_Eau_PotableBindingSource.MoveLast()
    End Sub

    Private Sub BTN_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Search.Click
        Search_Form.Show()
    End Sub

    Private Sub TM_DataVerify_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TM_DataVerify.Tick
        If Me.SB_Menu.ExpandedPanel Is Me.SBP_Visualisation Then
            Dim CurrentIndex As Integer = Me.DGV_1.CurrentRow.Index
            If (CurrentIndex = Me.DGV_1.Rows.GetFirstRow(DataGridViewElementStates.None)) Then
                Me.BTN_First.Enabled = False
                Me.BTN_Precedent.Enabled = False
                Me.BTN_Dernier.Enabled = True
                Me.BTN_Suivant.Enabled = True
            ElseIf (CurrentIndex = Me.DGV_1.Rows.GetLastRow(DataGridViewElementStates.None)) Then
                Me.BTN_First.Enabled = True
                Me.BTN_Precedent.Enabled = True
                Me.BTN_Dernier.Enabled = False
                Me.BTN_Suivant.Enabled = False
            Else
                Me.BTN_First.Enabled = True
                Me.BTN_Precedent.Enabled = True
                Me.BTN_Dernier.Enabled = True
                Me.BTN_Suivant.Enabled = True
            End If
        End If
    End Sub

#End Region

#Region "Fenetre Des Paramètres"

    Private Sub BTN_DureeConsomm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DureeConsomm.Click
        DureeConsommationSettings.Show()
    End Sub

    Private Sub BTN_UPConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_UPConfig.Click
        UP_Config.Show()
    End Sub

    Private Sub BTN_OtherConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_OtherConfig.Click
        Other_Config.Show()
    End Sub

    Private Sub WB_1_OptionsClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WB_1.OptionsClick
        Me.SB_Menu.ExpandedPanel = Me.SBP_Parametres
    End Sub

#End Region

#Region "Enregistrement Des Données"

    Sub EnregistrerDB()
        SFD_1.Title = ("حفظ قاعدة البيانات")
        SFD_1.Filter = ("قاعدة بيانات ACCESS|*.mdb")
        SFD_1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Dim T As String
        T = ("جمعية تمكونسي - " & Now.Day & "_" & Now.Month & "_" & Now.Year & " - " & Now.Hour & "_" & _
            Now.Minute & "_" & Now.Second)
        SFD_1.FileName = (T)

        If SFD_1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Validate()
            Me.Quittance_Eau_PotableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AT_DBDataSet)
            Dim DBFullPath As String = My.Application.Info.DirectoryPath & "\AT_DB.mdb"
             My.Computer.FileSystem.CopyFile(DBFullPath, Me.SFD_1.FileName)
            MsgBox(".تم حفظ قاعدة البيانات بنجاح", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, "حفظ قاعدة البيانات")
        Else
            MsgBox(".تم إلغاء عملية حفظ البيانات", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight, "إلغاء عملية الحفظ")
        End If
    End Sub

    Sub EnregistrerExcel()
        SFD_2.Title = ("EXCEL حفظ على شكل جدول")
        SFD_2.Filter = ("جدول EXCEL 97 - 2003|*.xls|جدول EXCEL 2007|*.xlsx")
        SFD_2.DefaultExt = ("xls")
        SFD_2.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Dim T As String
        T = ("جمعية تمكونسي - " & Now.Day & "_" & Now.Month & "_" & Now.Year & " - " & Now.Hour & "_" & _
            Now.Minute & "_" & Now.Second)
        SFD_2.FileName = (T)

        If SFD_2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Validate()
            Me.Quittance_Eau_PotableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AT_DBDataSet)
            Cursor = Cursors.WaitCursor
            Dim xlApp As Excel.Application
            Dim xlBook As Excel.Workbook
            Dim xlSheet As Excel.Worksheet
            xlApp = CreateObject("Excel.Application")
            xlBook = xlApp.Workbooks.Add
            xlSheet = xlBook.Worksheets(1)
            xlSheet.Cells(1, 1).ColumnWidth = 9.14
            xlSheet.Cells(1, 2).ColumnWidth = 18.29
            xlSheet.Cells(1, 3).ColumnWidth = 9.71
            xlSheet.Cells(1, 4).ColumnWidth = 9.71
            xlSheet.Cells(1, 5).ColumnWidth = 7
            xlSheet.Cells(1, 6).ColumnWidth = 10.57
            xlSheet.Cells(1, 7).ColumnWidth = 10.57
            xlSheet.Cells(1, 8).ColumnWidth = 6.57
            For k As Integer = 1 To DGV_1.Columns.Count
                xlSheet.Cells(1, k) = Me.DGV_1.Columns(k - 1).HeaderText
                xlSheet.Cells(1, k).Font.bold = True
                xlSheet.Cells(1, k).Borders.Weight = 2
            Next
            For i = 0 To DGV_1.RowCount - 1
                For j = 0 To DGV_1.ColumnCount - 1
                    xlSheet.Cells(i + 2, j + 1) = Me.DGV_1(j, i).Value.ToString()
                    xlSheet.Cells(i + 2, j + 1).Borders.Weight = 2
                    xlSheet.Cells(i + 2, j + 1).VerticalAlignment = 2
                    If j = 1 Then
                        xlSheet.Cells(i + 2, j + 1).Font.bold = True
                    ElseIf j >= 2 Then
                        xlSheet.Cells(i + 2, j + 1).HorizontalAlignment = 3
                    End If
                Next
            Next
            For k As Integer = 1 To Me.DGV_1.Columns.Count
                xlSheet.Cells(1, k).HorizontalAlignment = 3
                xlSheet.Cells(1, k).VerticalAlignment = 2
            Next
            xlSheet.SaveAs(SFD_2.FileName)
            Cursor = Cursors.Default
            MsgBox(".تم حفظ جدول البيانات بنجاح", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, "حفظ الجدول")
            xlSheet.Application.Visible = True
            'xlApp.Quit()
            xlSheet = Nothing
            xlBook = Nothing
            xlApp = Nothing
        Else
            MsgBox(".تم إلغاء عملية حفظ البيانات", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight, "إلغاء عملية الحفظ")
        End If
    End Sub

    Private Sub SaveAsDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsDB.Click
        EnregistrerDB()
    End Sub

    Private Sub SaveAsExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsExcel.Click
        EnregistrerExcel()
    End Sub

#End Region

End Class
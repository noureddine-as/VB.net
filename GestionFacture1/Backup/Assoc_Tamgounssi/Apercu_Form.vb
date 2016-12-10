Imports System.Drawing.Imaging

Public Class Apercu_Form

    Private Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As System.Int32) As Boolean
    Private Const SRCCOPY As Integer = &HCC0020

    Private Sub ImageApercu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Main_Form
            Me.LBL_Nom.Text = .TXT_Nom.Text
            Me.LBL_Nom.Visible = True
            Me.LBL_NComp.Text = .TXT_NCompteur.Text
            Me.LBL_NComp.Visible = True
            Me.LBL_NAbonn.Text = .TXT_NAbonn.Text
            Me.LBL_NAbonn.Visible = True
            Me.LBL_Mois.Text = .TXT_Mois.Text
            Me.LBL_Mois.Visible = True
            Me.LBL_Annee.Text = .TXT_Annee.Text
            Me.LBL_Annee.Visible = True
            Me.LBL_IPrecedent.Text = .TXT_IndexPreced.Text
            Me.LBL_IPrecedent.Visible = True
            Me.LBL_IPresent.Text = .TXT_IndexPresent.Text
            Me.LBL_IPresent.Visible = True
            Me.LBL_ConsommM3.Text = .TXT_ConsomM3.Text
            Me.LBL_ConsommM3.Visible = True
            Me.LBL_Prix.Text = .TXT_Prix.Text
            Me.LBL_Prix.Visible = True
            Me.LBL_PConsomm.Text = .TXT_PrixConsomm.Text
            Me.LBL_PConsomm.Visible = True
            Me.LBL_Abonn.Text = .TXT_Abonn.Text
            Me.LBL_Abonn.Visible = True
            Me.LBL_DevMosquee.Text = .TXT_DevMosquee.Text
            Me.LBL_DevMosquee.Visible = True
            Me.LBL_Total.Text = .TXT_Total.Text
            Me.LBL_Total.Visible = True
        End With
    End Sub

    Private Sub BTN_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Enregistrer.Click
        Try
            CImage()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_Return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Return.Click
        Me.Close()
    End Sub

    Sub CImage()

        If My.Computer.FileSystem.DirectoryExists(FileIO.SpecialDirectories.MyDocuments & "\Association Tamgounssi") = False Then
            My.Computer.FileSystem.CreateDirectory(FileIO.SpecialDirectories.MyDocuments & "\Association Tamgounssi")
            My.Computer.FileSystem.CreateDirectory(FileIO.SpecialDirectories.MyDocuments & "\Association Tamgounssi\" & Now.Date.ToLongDateString)
        Else
            If My.Computer.FileSystem.DirectoryExists(FileIO.SpecialDirectories.MyDocuments & "\Association Tamgounssi\" & Now.Date.ToLongDateString) = False Then
                My.Computer.FileSystem.CreateDirectory(FileIO.SpecialDirectories.MyDocuments & "\Association Tamgounssi\" & Now.Date.ToLongDateString)
            End If
        End If

        Me.SFD.InitialDirectory = (My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Association Tamgounssi\" & Now.Date.ToLongDateString)
        Me.SFD.FileName = (Now.Day & "-" & Now.Month & "-" & _
                           Now.Year & " " & Now.Hour & "-" & _
                           Now.Minute & " __ " & Main_Form.TXT_Nom.Text & ".bmp")
        Me.SFD.Title = "حفظ الصورة"
        Me.SFD.DefaultExt = ".bmp"
        Me.SFD.Filter = ("Bitmap (*.bmp)|*.bmp")

        If Me.SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Image As Bitmap = GetPicBoxImage()
            Image.Save(Me.SFD.FileName, ImageFormat.Bmp)
            MsgBox("تم حفظ الصورة بنجاح", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Information, "حفظ الصورة")
            Shell(Me.SFD.FileName)
        Else
            MsgBox("تم الغاء عملية الحفظ", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Exclamation, "الغاء عملية حفظ الصورة")
        End If

    End Sub

    Function GetPicBoxImage() As Bitmap
        Dim me_gr As Graphics = Me.PictureBox1.CreateGraphics

        Dim bm As New Bitmap(Me.PictureBox1.ClientSize.Width, Me.PictureBox1.ClientSize.Height, me_gr)
        Dim bm_gr As Graphics = me_gr.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc

        Dim me_hdc As IntPtr = me_gr.GetHdc

        BitBlt(bm_hdc, 0, 0, Me.PictureBox1.ClientSize.Width, Me.PictureBox1.ClientSize.Height, _
            me_hdc, 0, 0, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)

        Return bm
    End Function

End Class
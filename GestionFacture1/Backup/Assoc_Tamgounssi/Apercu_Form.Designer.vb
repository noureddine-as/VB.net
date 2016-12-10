<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apercu_Form
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Apercu_Form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BTN_Enregistrer = New DevComponents.DotNetBar.ButtonX
        Me.BTN_Return = New DevComponents.DotNetBar.ButtonX
        Me.LBL_Nom = New System.Windows.Forms.Label
        Me.LBL_NComp = New System.Windows.Forms.Label
        Me.LBL_NAbonn = New System.Windows.Forms.Label
        Me.LBL_Mois = New System.Windows.Forms.Label
        Me.LBL_Annee = New System.Windows.Forms.Label
        Me.LBL_IPresent = New System.Windows.Forms.Label
        Me.LBL_IPrecedent = New System.Windows.Forms.Label
        Me.LBL_ConsommM3 = New System.Windows.Forms.Label
        Me.LBL_Prix = New System.Windows.Forms.Label
        Me.LBL_PConsomm = New System.Windows.Forms.Label
        Me.LBL_Abonn = New System.Windows.Forms.Label
        Me.LBL_DevMosquee = New System.Windows.Forms.Label
        Me.LBL_Total = New System.Windows.Forms.Label
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(438, 298)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BTN_Enregistrer
        '
        Me.BTN_Enregistrer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Enregistrer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Enregistrer.Image = Global.AssociationTamgounssi.My.Resources.Resources.picture_save
        Me.BTN_Enregistrer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_Enregistrer.Location = New System.Drawing.Point(12, 316)
        Me.BTN_Enregistrer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Enregistrer.Name = "BTN_Enregistrer"
        Me.BTN_Enregistrer.Size = New System.Drawing.Size(213, 37)
        Me.BTN_Enregistrer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Enregistrer.TabIndex = 1
        Me.BTN_Enregistrer.Text = "حفظ الصورة"
        '
        'BTN_Return
        '
        Me.BTN_Return.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Return.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Return.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Return.Image = Global.AssociationTamgounssi.My.Resources.Resources.arrow_rotate_anticlockwise
        Me.BTN_Return.Location = New System.Drawing.Point(237, 316)
        Me.BTN_Return.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_Return.Name = "BTN_Return"
        Me.BTN_Return.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_Return.Size = New System.Drawing.Size(213, 37)
        Me.BTN_Return.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Return.TabIndex = 2
        Me.BTN_Return.Text = "عودة"
        '
        'LBL_Nom
        '
        Me.LBL_Nom.BackColor = System.Drawing.Color.White
        Me.LBL_Nom.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Nom.Location = New System.Drawing.Point(208, 109)
        Me.LBL_Nom.Name = "LBL_Nom"
        Me.LBL_Nom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_Nom.Size = New System.Drawing.Size(158, 38)
        Me.LBL_Nom.TabIndex = 3
        Me.LBL_Nom.Text = "Nom"
        Me.LBL_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_Nom.Visible = False
        '
        'LBL_NComp
        '
        Me.LBL_NComp.BackColor = System.Drawing.Color.White
        Me.LBL_NComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NComp.Location = New System.Drawing.Point(208, 152)
        Me.LBL_NComp.Name = "LBL_NComp"
        Me.LBL_NComp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_NComp.Size = New System.Drawing.Size(165, 27)
        Me.LBL_NComp.TabIndex = 4
        Me.LBL_NComp.Text = "NumCompteur"
        Me.LBL_NComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_NComp.Visible = False
        '
        'LBL_NAbonn
        '
        Me.LBL_NAbonn.BackColor = System.Drawing.Color.White
        Me.LBL_NAbonn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NAbonn.Location = New System.Drawing.Point(156, 152)
        Me.LBL_NAbonn.Name = "LBL_NAbonn"
        Me.LBL_NAbonn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_NAbonn.Size = New System.Drawing.Size(46, 27)
        Me.LBL_NAbonn.TabIndex = 5
        Me.LBL_NAbonn.Text = "NAbn"
        Me.LBL_NAbonn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_NAbonn.Visible = False
        '
        'LBL_Mois
        '
        Me.LBL_Mois.BackColor = System.Drawing.Color.White
        Me.LBL_Mois.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Mois.Location = New System.Drawing.Point(96, 152)
        Me.LBL_Mois.Name = "LBL_Mois"
        Me.LBL_Mois.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_Mois.Size = New System.Drawing.Size(54, 27)
        Me.LBL_Mois.TabIndex = 6
        Me.LBL_Mois.Text = "Mois"
        Me.LBL_Mois.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_Mois.Visible = False
        '
        'LBL_Annee
        '
        Me.LBL_Annee.BackColor = System.Drawing.Color.White
        Me.LBL_Annee.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Annee.Location = New System.Drawing.Point(31, 152)
        Me.LBL_Annee.Name = "LBL_Annee"
        Me.LBL_Annee.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_Annee.Size = New System.Drawing.Size(59, 27)
        Me.LBL_Annee.TabIndex = 7
        Me.LBL_Annee.Text = "Annee"
        Me.LBL_Annee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_Annee.Visible = False
        '
        'LBL_IPresent
        '
        Me.LBL_IPresent.BackColor = System.Drawing.Color.White
        Me.LBL_IPresent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IPresent.Location = New System.Drawing.Point(31, 232)
        Me.LBL_IPresent.Name = "LBL_IPresent"
        Me.LBL_IPresent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_IPresent.Size = New System.Drawing.Size(59, 26)
        Me.LBL_IPresent.TabIndex = 8
        Me.LBL_IPresent.Text = "INow"
        Me.LBL_IPresent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_IPresent.Visible = False
        '
        'LBL_IPrecedent
        '
        Me.LBL_IPrecedent.BackColor = System.Drawing.Color.White
        Me.LBL_IPrecedent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IPrecedent.Location = New System.Drawing.Point(95, 232)
        Me.LBL_IPrecedent.Name = "LBL_IPrecedent"
        Me.LBL_IPrecedent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_IPrecedent.Size = New System.Drawing.Size(56, 26)
        Me.LBL_IPrecedent.TabIndex = 9
        Me.LBL_IPrecedent.Text = "IAvant"
        Me.LBL_IPrecedent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_IPrecedent.Visible = False
        '
        'LBL_ConsommM3
        '
        Me.LBL_ConsommM3.BackColor = System.Drawing.Color.White
        Me.LBL_ConsommM3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ConsommM3.Location = New System.Drawing.Point(157, 232)
        Me.LBL_ConsommM3.Name = "LBL_ConsommM3"
        Me.LBL_ConsommM3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_ConsommM3.Size = New System.Drawing.Size(46, 26)
        Me.LBL_ConsommM3.TabIndex = 10
        Me.LBL_ConsommM3.Text = "CM3"
        Me.LBL_ConsommM3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_ConsommM3.Visible = False
        '
        'LBL_Prix
        '
        Me.LBL_Prix.BackColor = System.Drawing.Color.White
        Me.LBL_Prix.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Prix.Location = New System.Drawing.Point(207, 232)
        Me.LBL_Prix.Name = "LBL_Prix"
        Me.LBL_Prix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_Prix.Size = New System.Drawing.Size(33, 26)
        Me.LBL_Prix.TabIndex = 11
        Me.LBL_Prix.Text = "P"
        Me.LBL_Prix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_Prix.Visible = False
        '
        'LBL_PConsomm
        '
        Me.LBL_PConsomm.BackColor = System.Drawing.Color.White
        Me.LBL_PConsomm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PConsomm.Location = New System.Drawing.Point(244, 232)
        Me.LBL_PConsomm.Name = "LBL_PConsomm"
        Me.LBL_PConsomm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_PConsomm.Size = New System.Drawing.Size(47, 26)
        Me.LBL_PConsomm.TabIndex = 12
        Me.LBL_PConsomm.Text = "Pc"
        Me.LBL_PConsomm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_PConsomm.Visible = False
        '
        'LBL_Abonn
        '
        Me.LBL_Abonn.BackColor = System.Drawing.Color.White
        Me.LBL_Abonn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Abonn.Location = New System.Drawing.Point(295, 232)
        Me.LBL_Abonn.Name = "LBL_Abonn"
        Me.LBL_Abonn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_Abonn.Size = New System.Drawing.Size(42, 26)
        Me.LBL_Abonn.TabIndex = 13
        Me.LBL_Abonn.Text = "Abn"
        Me.LBL_Abonn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_Abonn.Visible = False
        '
        'LBL_DevMosquee
        '
        Me.LBL_DevMosquee.BackColor = System.Drawing.Color.White
        Me.LBL_DevMosquee.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DevMosquee.Location = New System.Drawing.Point(342, 232)
        Me.LBL_DevMosquee.Name = "LBL_DevMosquee"
        Me.LBL_DevMosquee.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_DevMosquee.Size = New System.Drawing.Size(40, 26)
        Me.LBL_DevMosquee.TabIndex = 14
        Me.LBL_DevMosquee.Text = "DM"
        Me.LBL_DevMosquee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_DevMosquee.Visible = False
        '
        'LBL_Total
        '
        Me.LBL_Total.BackColor = System.Drawing.Color.White
        Me.LBL_Total.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Total.Location = New System.Drawing.Point(385, 232)
        Me.LBL_Total.Name = "LBL_Total"
        Me.LBL_Total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_Total.Size = New System.Drawing.Size(46, 26)
        Me.LBL_Total.TabIndex = 15
        Me.LBL_Total.Text = "Total"
        Me.LBL_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_Total.Visible = False
        '
        'Apercu_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BTN_Return
        Me.ClientSize = New System.Drawing.Size(462, 365)
        Me.Controls.Add(Me.LBL_Total)
        Me.Controls.Add(Me.LBL_DevMosquee)
        Me.Controls.Add(Me.LBL_Abonn)
        Me.Controls.Add(Me.LBL_PConsomm)
        Me.Controls.Add(Me.LBL_Prix)
        Me.Controls.Add(Me.LBL_ConsommM3)
        Me.Controls.Add(Me.LBL_IPrecedent)
        Me.Controls.Add(Me.LBL_IPresent)
        Me.Controls.Add(Me.LBL_Annee)
        Me.Controls.Add(Me.LBL_Mois)
        Me.Controls.Add(Me.LBL_NAbonn)
        Me.Controls.Add(Me.LBL_NComp)
        Me.Controls.Add(Me.LBL_Nom)
        Me.Controls.Add(Me.BTN_Return)
        Me.Controls.Add(Me.BTN_Enregistrer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Apercu_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "مشاهدة الصورة"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_Enregistrer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_Return As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LBL_Nom As System.Windows.Forms.Label
    Friend WithEvents LBL_NComp As System.Windows.Forms.Label
    Friend WithEvents LBL_NAbonn As System.Windows.Forms.Label
    Friend WithEvents LBL_Mois As System.Windows.Forms.Label
    Friend WithEvents LBL_Annee As System.Windows.Forms.Label
    Friend WithEvents LBL_IPresent As System.Windows.Forms.Label
    Friend WithEvents LBL_IPrecedent As System.Windows.Forms.Label
    Friend WithEvents LBL_ConsommM3 As System.Windows.Forms.Label
    Friend WithEvents LBL_Prix As System.Windows.Forms.Label
    Friend WithEvents LBL_PConsomm As System.Windows.Forms.Label
    Friend WithEvents LBL_Abonn As System.Windows.Forms.Label
    Friend WithEvents LBL_DevMosquee As System.Windows.Forms.Label
    Friend WithEvents LBL_Total As System.Windows.Forms.Label
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
End Class

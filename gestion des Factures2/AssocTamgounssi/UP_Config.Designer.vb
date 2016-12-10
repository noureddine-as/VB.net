<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UP_Config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UP_Config))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.BTN_Annuler = New DevComponents.DotNetBar.ButtonX
        Me.BTN_Ok = New DevComponents.DotNetBar.ButtonX
        Me.TXT_OldPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.TXT_OldUsername = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.P_1 = New System.Windows.Forms.Panel
        Me.P_2 = New System.Windows.Forms.Panel
        Me.BTN_Annuler2 = New DevComponents.DotNetBar.ButtonX
        Me.BTN_Ok2 = New DevComponents.DotNetBar.ButtonX
        Me.TXT_NewPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.TXT_NewUsername = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
        Me.Highlighter2 = New DevComponents.DotNetBar.Validator.Highlighter
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_1.SuspendLayout()
        Me.P_2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.LabelX1.Location = New System.Drawing.Point(179, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(162, 16)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "قم بادخال المعلومات القديمة :"
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Annuler.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Annuler.Location = New System.Drawing.Point(143, 126)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(96, 30)
        Me.BTN_Annuler.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Annuler.TabIndex = 13
        Me.BTN_Annuler.Text = "الغاء"
        '
        'BTN_Ok
        '
        Me.BTN_Ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTN_Ok.Location = New System.Drawing.Point(245, 126)
        Me.BTN_Ok.Name = "BTN_Ok"
        Me.BTN_Ok.Size = New System.Drawing.Size(96, 30)
        Me.BTN_Ok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Ok.TabIndex = 12
        Me.BTN_Ok.Text = "موافق"
        '
        'TXT_OldPassword
        '
        '
        '
        '
        Me.TXT_OldPassword.Border.Class = "TextBoxBorder"
        Me.TXT_OldPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.TXT_OldPassword, True)
        Me.TXT_OldPassword.Location = New System.Drawing.Point(144, 100)
        Me.TXT_OldPassword.Name = "TXT_OldPassword"
        Me.TXT_OldPassword.Size = New System.Drawing.Size(197, 20)
        Me.TXT_OldPassword.TabIndex = 11
        Me.TXT_OldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXT_OldPassword.UseSystemPasswordChar = True
        Me.TXT_OldPassword.WatermarkText = "كلمة المرور"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(282, 79)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(59, 15)
        Me.LabelX2.TabIndex = 10
        Me.LabelX2.Text = "كلمة المرور :"
        '
        'TXT_OldUsername
        '
        '
        '
        '
        Me.TXT_OldUsername.Border.Class = "TextBoxBorder"
        Me.TXT_OldUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.TXT_OldUsername, True)
        Me.TXT_OldUsername.Location = New System.Drawing.Point(144, 53)
        Me.TXT_OldUsername.Name = "TXT_OldUsername"
        Me.TXT_OldUsername.Size = New System.Drawing.Size(197, 20)
        Me.TXT_OldUsername.TabIndex = 9
        Me.TXT_OldUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXT_OldUsername.WatermarkText = "اسم المستخدم"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(261, 32)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(80, 15)
        Me.LabelX3.TabIndex = 8
        Me.LabelX3.Text = "اسم المستخدم :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AssocTamgounssi.My.Resources.Resources.mot_de_passe
        Me.PictureBox1.Location = New System.Drawing.Point(9, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'P_1
        '
        Me.P_1.Controls.Add(Me.BTN_Annuler)
        Me.P_1.Controls.Add(Me.BTN_Ok)
        Me.P_1.Controls.Add(Me.TXT_OldPassword)
        Me.P_1.Controls.Add(Me.LabelX2)
        Me.P_1.Controls.Add(Me.TXT_OldUsername)
        Me.P_1.Controls.Add(Me.LabelX3)
        Me.P_1.Controls.Add(Me.PictureBox1)
        Me.P_1.Controls.Add(Me.LabelX1)
        Me.P_1.Location = New System.Drawing.Point(0, 3)
        Me.P_1.Name = "P_1"
        Me.P_1.Size = New System.Drawing.Size(350, 168)
        Me.P_1.TabIndex = 14
        '
        'P_2
        '
        Me.P_2.Controls.Add(Me.BTN_Annuler2)
        Me.P_2.Controls.Add(Me.BTN_Ok2)
        Me.P_2.Controls.Add(Me.TXT_NewPassword)
        Me.P_2.Controls.Add(Me.LabelX4)
        Me.P_2.Controls.Add(Me.TXT_NewUsername)
        Me.P_2.Controls.Add(Me.LabelX5)
        Me.P_2.Controls.Add(Me.PictureBox2)
        Me.P_2.Controls.Add(Me.LabelX6)
        Me.P_2.Location = New System.Drawing.Point(0, 3)
        Me.P_2.Name = "P_2"
        Me.P_2.Size = New System.Drawing.Size(350, 168)
        Me.P_2.TabIndex = 15
        '
        'BTN_Annuler2
        '
        Me.BTN_Annuler2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Annuler2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Annuler2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Annuler2.Location = New System.Drawing.Point(143, 126)
        Me.BTN_Annuler2.Name = "BTN_Annuler2"
        Me.BTN_Annuler2.Size = New System.Drawing.Size(96, 30)
        Me.BTN_Annuler2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Annuler2.TabIndex = 13
        Me.BTN_Annuler2.Text = "عودة"
        '
        'BTN_Ok2
        '
        Me.BTN_Ok2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Ok2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Ok2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTN_Ok2.Location = New System.Drawing.Point(245, 126)
        Me.BTN_Ok2.Name = "BTN_Ok2"
        Me.BTN_Ok2.Size = New System.Drawing.Size(96, 30)
        Me.BTN_Ok2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Ok2.TabIndex = 12
        Me.BTN_Ok2.Text = "موافق"
        '
        'TXT_NewPassword
        '
        '
        '
        '
        Me.TXT_NewPassword.Border.Class = "TextBoxBorder"
        Me.TXT_NewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter2.SetHighlightOnFocus(Me.TXT_NewPassword, True)
        Me.TXT_NewPassword.Location = New System.Drawing.Point(144, 100)
        Me.TXT_NewPassword.Name = "TXT_NewPassword"
        Me.TXT_NewPassword.Size = New System.Drawing.Size(197, 20)
        Me.TXT_NewPassword.TabIndex = 11
        Me.TXT_NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXT_NewPassword.UseSystemPasswordChar = True
        Me.TXT_NewPassword.WatermarkText = "كلمة المرور"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(282, 79)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(59, 15)
        Me.LabelX4.TabIndex = 10
        Me.LabelX4.Text = "كلمة المرور :"
        '
        'TXT_NewUsername
        '
        '
        '
        '
        Me.TXT_NewUsername.Border.Class = "TextBoxBorder"
        Me.TXT_NewUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter2.SetHighlightOnFocus(Me.TXT_NewUsername, True)
        Me.TXT_NewUsername.Location = New System.Drawing.Point(144, 53)
        Me.TXT_NewUsername.Name = "TXT_NewUsername"
        Me.TXT_NewUsername.Size = New System.Drawing.Size(197, 20)
        Me.TXT_NewUsername.TabIndex = 9
        Me.TXT_NewUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXT_NewUsername.WatermarkText = "اسم المستخدم"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(261, 32)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX5.Size = New System.Drawing.Size(80, 15)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "اسم المستخدم :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AssocTamgounssi.My.Resources.Resources.mot_de_passe
        Me.PictureBox2.Location = New System.Drawing.Point(9, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.LabelX6.Location = New System.Drawing.Point(179, 10)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX6.Size = New System.Drawing.Size(162, 16)
        Me.LabelX6.TabIndex = 2
        Me.LabelX6.Text = "قم بادخال المعلومات الجديدة :"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Orange
        '
        'Highlighter2
        '
        Me.Highlighter2.ContainerControl = Me
        Me.Highlighter2.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'UP_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 174)
        Me.Controls.Add(Me.P_1)
        Me.Controls.Add(Me.P_2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UP_Config"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تغيير معلومات الدخول"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_1.ResumeLayout(False)
        Me.P_1.PerformLayout()
        Me.P_2.ResumeLayout(False)
        Me.P_2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BTN_Annuler As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_Ok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_OldPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_OldUsername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents P_1 As System.Windows.Forms.Panel
    Friend WithEvents P_2 As System.Windows.Forms.Panel
    Friend WithEvents BTN_Annuler2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_Ok2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_NewPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_NewUsername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Highlighter2 As DevComponents.DotNetBar.Validator.Highlighter
End Class

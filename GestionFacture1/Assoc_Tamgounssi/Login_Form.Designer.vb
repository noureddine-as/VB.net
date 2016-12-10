<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.TXT_UserName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_Password = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.BTN_Ok = New DevComponents.DotNetBar.ButtonX
        Me.BTN_Annuler = New DevComponents.DotNetBar.ButtonX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.HG_Red = New DevComponents.DotNetBar.Validator.Highlighter
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_UserName
        '
        '
        '
        '
        Me.TXT_UserName.Border.Class = "TextBoxBorder"
        Me.TXT_UserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_UserName.Location = New System.Drawing.Point(139, 33)
        Me.TXT_UserName.Name = "TXT_UserName"
        Me.TXT_UserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_UserName.Size = New System.Drawing.Size(197, 20)
        Me.TXT_UserName.TabIndex = 3
        '
        'TXT_Password
        '
        '
        '
        '
        Me.TXT_Password.Border.Class = "TextBoxBorder"
        Me.TXT_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXT_Password.Location = New System.Drawing.Point(139, 80)
        Me.TXT_Password.Name = "TXT_Password"
        Me.TXT_Password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_Password.Size = New System.Drawing.Size(197, 20)
        Me.TXT_Password.TabIndex = 4
        Me.TXT_Password.UseSystemPasswordChar = True
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(256, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(80, 15)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "اسم المستخدم :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(277, 59)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(59, 15)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "كلمة المرور :"
        '
        'BTN_Ok
        '
        Me.BTN_Ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Ok.Location = New System.Drawing.Point(245, 106)
        Me.BTN_Ok.Name = "BTN_Ok"
        Me.BTN_Ok.Size = New System.Drawing.Size(91, 30)
        Me.BTN_Ok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Ok.TabIndex = 7
        Me.BTN_Ok.Text = "موافق"
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Annuler.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Annuler.Location = New System.Drawing.Point(139, 106)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(100, 30)
        Me.BTN_Annuler.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Annuler.TabIndex = 0
        Me.BTN_Annuler.Text = "الغاء"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AssociationTamgounssi.My.Resources.Resources.mot_de_passe
        Me.PictureBox1.Location = New System.Drawing.Point(5, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'HG_Red
        '
        Me.HG_Red.ContainerControl = Me
        Me.HG_Red.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'Login_Form
        '
        Me.AcceptButton = Me.BTN_Ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BTN_Annuler
        Me.ClientSize = New System.Drawing.Size(348, 148)
        Me.Controls.Add(Me.BTN_Annuler)
        Me.Controls.Add(Me.BTN_Ok)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.TXT_Password)
        Me.Controls.Add(Me.TXT_UserName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login_Form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسجيل الدخول"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_UserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_Password As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BTN_Ok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_Annuler As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HG_Red As DevComponents.DotNetBar.Validator.Highlighter
End Class

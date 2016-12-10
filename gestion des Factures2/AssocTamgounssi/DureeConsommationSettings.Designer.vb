<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DureeConsommationSettings
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DureeConsommationSettings))
        Me.RB_Auto = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.RB_Manual = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.MTBAdv_1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
        Me.GP_1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
        Me.TM_1 = New System.Windows.Forms.Timer(Me.components)
        Me.BTN_Annuler = New DevComponents.DotNetBar.ButtonX
        Me.BTN_Ok = New DevComponents.DotNetBar.ButtonX
        Me.GP_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RB_Auto
        '
        Me.RB_Auto.AutoSize = True
        Me.RB_Auto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.RB_Auto.BackgroundStyle.Class = ""
        Me.RB_Auto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RB_Auto.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RB_Auto.Checked = True
        Me.RB_Auto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RB_Auto.CheckValue = "Y"
        Me.RB_Auto.Location = New System.Drawing.Point(22, 12)
        Me.RB_Auto.Name = "RB_Auto"
        Me.RB_Auto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RB_Auto.Size = New System.Drawing.Size(199, 15)
        Me.RB_Auto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RB_Auto.TabIndex = 1
        Me.RB_Auto.Text = "أوتوماتيكي : وضع الشهر و السنة الحالية"
        '
        'RB_Manual
        '
        Me.RB_Manual.AutoSize = True
        Me.RB_Manual.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.RB_Manual.BackgroundStyle.Class = ""
        Me.RB_Manual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RB_Manual.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.RB_Manual.Location = New System.Drawing.Point(3, 39)
        Me.RB_Manual.Name = "RB_Manual"
        Me.RB_Manual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RB_Manual.Size = New System.Drawing.Size(218, 15)
        Me.RB_Manual.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RB_Manual.TabIndex = 2
        Me.RB_Manual.Text = "يــدوي : وضع الشهر و السنة المحددة أسفله"
        '
        'MTBAdv_1
        '
        '
        '
        '
        Me.MTBAdv_1.BackgroundStyle.Class = "TextBoxBorder"
        Me.MTBAdv_1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MTBAdv_1.BeepOnError = True
        Me.MTBAdv_1.ButtonClear.Visible = True
        Me.MTBAdv_1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.Highlighter1.SetHighlightOnFocus(Me.MTBAdv_1, True)
        Me.MTBAdv_1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.MTBAdv_1.Location = New System.Drawing.Point(3, 60)
        Me.MTBAdv_1.Mask = "00/0000"
        Me.MTBAdv_1.Name = "MTBAdv_1"
        Me.MTBAdv_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MTBAdv_1.Size = New System.Drawing.Size(102, 20)
        Me.MTBAdv_1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MTBAdv_1.TabIndex = 3
        Me.MTBAdv_1.Text = ""
        Me.MTBAdv_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MTBAdv_1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        '
        'GP_1
        '
        Me.GP_1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_1.Controls.Add(Me.MTBAdv_1)
        Me.GP_1.Controls.Add(Me.RB_Manual)
        Me.GP_1.Controls.Add(Me.RB_Auto)
        Me.GP_1.Location = New System.Drawing.Point(12, 12)
        Me.GP_1.Name = "GP_1"
        Me.GP_1.Size = New System.Drawing.Size(230, 104)
        '
        '
        '
        Me.GP_1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_1.Style.BackColorGradientAngle = 90
        Me.GP_1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_1.Style.BorderBottomWidth = 1
        Me.GP_1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_1.Style.BorderLeftWidth = 1
        Me.GP_1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_1.Style.BorderRightWidth = 1
        Me.GP_1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_1.Style.BorderTopWidth = 1
        Me.GP_1.Style.Class = ""
        Me.GP_1.Style.CornerDiameter = 4
        Me.GP_1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_1.StyleMouseDown.Class = ""
        Me.GP_1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_1.StyleMouseOver.Class = ""
        Me.GP_1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_1.TabIndex = 4
        Me.GP_1.Text = "المرجو تحديد كيفية و ضع فترة الاستهلاك"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'TM_1
        '
        Me.TM_1.Enabled = True
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Annuler.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Annuler.Location = New System.Drawing.Point(70, 122)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(60, 24)
        Me.BTN_Annuler.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Annuler.TabIndex = 8
        Me.BTN_Annuler.Text = "الغاء"
        '
        'BTN_Ok
        '
        Me.BTN_Ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTN_Ok.Location = New System.Drawing.Point(136, 122)
        Me.BTN_Ok.Name = "BTN_Ok"
        Me.BTN_Ok.Size = New System.Drawing.Size(106, 24)
        Me.BTN_Ok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Ok.TabIndex = 7
        Me.BTN_Ok.Text = "حفظ التعديلات"
        '
        'DureeConsommationSettings
        '
        Me.AcceptButton = Me.BTN_Ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BTN_Annuler
        Me.ClientSize = New System.Drawing.Size(254, 158)
        Me.Controls.Add(Me.BTN_Annuler)
        Me.Controls.Add(Me.BTN_Ok)
        Me.Controls.Add(Me.GP_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DureeConsommationSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعديل فترة الاستهلاك"
        Me.TopMost = True
        Me.GP_1.ResumeLayout(False)
        Me.GP_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RB_Auto As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents RB_Manual As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents MTBAdv_1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents GP_1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents TM_1 As System.Windows.Forms.Timer
    Friend WithEvents BTN_Annuler As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_Ok As DevComponents.DotNetBar.ButtonX
End Class

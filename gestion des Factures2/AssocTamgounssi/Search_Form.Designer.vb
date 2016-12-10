<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Form))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.CB_Champs = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
        Me.TXT_Input = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.BTN_Cancel = New DevComponents.DotNetBar.ButtonX
        Me.BTN_Search = New DevComponents.DotNetBar.ButtonX
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
        Me.LabelX1.Location = New System.Drawing.Point(185, 15)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(77, 15)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "ابحث في عمود :"
        '
        'CB_Champs
        '
        Me.CB_Champs.DisplayMember = "Text"
        Me.CB_Champs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Champs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Champs.FormattingEnabled = True
        Me.CB_Champs.ItemHeight = 14
        Me.CB_Champs.Location = New System.Drawing.Point(12, 12)
        Me.CB_Champs.Name = "CB_Champs"
        Me.CB_Champs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CB_Champs.Size = New System.Drawing.Size(167, 20)
        Me.CB_Champs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB_Champs.TabIndex = 1
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(205, 39)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(57, 15)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "عن ما يلي :"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'TXT_Input
        '
        '
        '
        '
        Me.TXT_Input.Border.Class = "TextBoxBorder"
        Me.TXT_Input.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightOnFocus(Me.TXT_Input, True)
        Me.TXT_Input.Location = New System.Drawing.Point(12, 38)
        Me.TXT_Input.MaxLength = 100
        Me.TXT_Input.Name = "TXT_Input"
        Me.TXT_Input.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_Input.Size = New System.Drawing.Size(167, 20)
        Me.TXT_Input.TabIndex = 2
        Me.TXT_Input.WatermarkText = "بحث"
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Cancel.Location = New System.Drawing.Point(102, 64)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(77, 28)
        Me.BTN_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Cancel.TabIndex = 8
        Me.BTN_Cancel.Text = "إلغاء"
        '
        'BTN_Search
        '
        Me.BTN_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Search.Location = New System.Drawing.Point(185, 64)
        Me.BTN_Search.Name = "BTN_Search"
        Me.BTN_Search.Size = New System.Drawing.Size(77, 28)
        Me.BTN_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTN_Search.TabIndex = 7
        Me.BTN_Search.Text = "بحث"
        '
        'Search_Form
        '
        Me.AcceptButton = Me.BTN_Search
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BTN_Cancel
        Me.ClientSize = New System.Drawing.Size(274, 104)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.BTN_Search)
        Me.Controls.Add(Me.TXT_Input)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.CB_Champs)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Search_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "بحث"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CB_Champs As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents BTN_Search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TXT_Input As DevComponents.DotNetBar.Controls.TextBoxX
End Class

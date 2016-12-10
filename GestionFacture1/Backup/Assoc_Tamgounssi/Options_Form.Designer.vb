<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options_Form))
        Me.CB_Theme = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.SuspendLayout()
        '
        'CB_Theme
        '
        Me.CB_Theme.DisplayMember = "Text"
        Me.CB_Theme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Theme.FormattingEnabled = True
        Me.CB_Theme.ItemHeight = 14
        Me.CB_Theme.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.CB_Theme.Location = New System.Drawing.Point(12, 14)
        Me.CB_Theme.Name = "CB_Theme"
        Me.CB_Theme.Size = New System.Drawing.Size(215, 20)
        Me.CB_Theme.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB_Theme.TabIndex = 4
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Office 2007 Bleu"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Office 2007 Noir"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(233, 13)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(75, 22)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "شكل البرنامج :"
        '
        'Options_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 48)
        Me.Controls.Add(Me.CB_Theme)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options_Form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "خصائص"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CB_Theme As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class

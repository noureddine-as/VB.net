<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.TXT_TextToSave = New System.Windows.Forms.TextBox
        Me.BTN_AddNewLine = New System.Windows.Forms.Button
        Me.BTN_DeleteLine = New System.Windows.Forms.Button
        Me.LB_ShortCopies = New System.Windows.Forms.ListBox
        Me.BTN_Copier = New System.Windows.Forms.Button
        Me.BTN_Exit = New System.Windows.Forms.Button
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestaurerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_TextToSave
        '
        Me.TXT_TextToSave.Location = New System.Drawing.Point(12, 14)
        Me.TXT_TextToSave.Name = "TXT_TextToSave"
        Me.TXT_TextToSave.Size = New System.Drawing.Size(218, 20)
        Me.TXT_TextToSave.TabIndex = 0
        '
        'BTN_AddNewLine
        '
        Me.BTN_AddNewLine.Location = New System.Drawing.Point(236, 8)
        Me.BTN_AddNewLine.Name = "BTN_AddNewLine"
        Me.BTN_AddNewLine.Size = New System.Drawing.Size(50, 30)
        Me.BTN_AddNewLine.TabIndex = 1
        Me.BTN_AddNewLine.Text = "+"
        Me.BTN_AddNewLine.UseVisualStyleBackColor = True
        '
        'BTN_DeleteLine
        '
        Me.BTN_DeleteLine.Location = New System.Drawing.Point(292, 8)
        Me.BTN_DeleteLine.Name = "BTN_DeleteLine"
        Me.BTN_DeleteLine.Size = New System.Drawing.Size(50, 30)
        Me.BTN_DeleteLine.TabIndex = 1
        Me.BTN_DeleteLine.Text = "-"
        Me.BTN_DeleteLine.UseVisualStyleBackColor = True
        '
        'LB_ShortCopies
        '
        Me.LB_ShortCopies.BackColor = System.Drawing.SystemColors.Window
        Me.LB_ShortCopies.FormattingEnabled = True
        Me.LB_ShortCopies.Location = New System.Drawing.Point(12, 44)
        Me.LB_ShortCopies.Name = "LB_ShortCopies"
        Me.LB_ShortCopies.Size = New System.Drawing.Size(330, 108)
        Me.LB_ShortCopies.TabIndex = 5
        '
        'BTN_Copier
        '
        Me.BTN_Copier.Location = New System.Drawing.Point(136, 158)
        Me.BTN_Copier.Name = "BTN_Copier"
        Me.BTN_Copier.Size = New System.Drawing.Size(100, 35)
        Me.BTN_Copier.TabIndex = 6
        Me.BTN_Copier.Text = "Copier"
        Me.BTN_Copier.UseVisualStyleBackColor = True
        '
        'BTN_Exit
        '
        Me.BTN_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Exit.Location = New System.Drawing.Point(242, 158)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(100, 35)
        Me.BTN_Exit.TabIndex = 9
        Me.BTN_Exit.Text = "Quitter"
        Me.BTN_Exit.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Cliquez deux fois pour restaurer la fenêtre."
        Me.NotifyIcon1.BalloonTipTitle = "ShortCopy"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestaurerToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 48)
        '
        'RestaurerToolStripMenuItem
        '
        Me.RestaurerToolStripMenuItem.Name = "RestaurerToolStripMenuItem"
        Me.RestaurerToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.RestaurerToolStripMenuItem.Text = "Restaurer"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Main_Form
        '
        Me.AcceptButton = Me.BTN_Copier
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BTN_Exit
        Me.ClientSize = New System.Drawing.Size(354, 205)
        Me.Controls.Add(Me.BTN_Exit)
        Me.Controls.Add(Me.BTN_Copier)
        Me.Controls.Add(Me.LB_ShortCopies)
        Me.Controls.Add(Me.BTN_DeleteLine)
        Me.Controls.Add(Me.BTN_AddNewLine)
        Me.Controls.Add(Me.TXT_TextToSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.Text = "ShortCopy"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_TextToSave As System.Windows.Forms.TextBox
    Friend WithEvents BTN_AddNewLine As System.Windows.Forms.Button
    Friend WithEvents BTN_DeleteLine As System.Windows.Forms.Button
    Friend WithEvents LB_ShortCopies As System.Windows.Forms.ListBox
    Friend WithEvents BTN_Copier As System.Windows.Forms.Button
    Friend WithEvents BTN_Exit As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RestaurerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

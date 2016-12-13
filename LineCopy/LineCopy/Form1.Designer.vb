<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbLines = New System.Windows.Forms.ListBox
        Me.txtText = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnQuitter = New System.Windows.Forms.Button
        Me.btnCopier = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblSatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbLines
        '
        Me.lbLines.FormattingEnabled = True
        Me.lbLines.Location = New System.Drawing.Point(12, 50)
        Me.lbLines.Name = "lbLines"
        Me.lbLines.Size = New System.Drawing.Size(376, 147)
        Me.lbLines.TabIndex = 0
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(12, 21)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(272, 20)
        Me.txtText.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(342, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(46, 32)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "-"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(290, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(46, 32)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(298, 203)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(90, 32)
        Me.btnQuitter.TabIndex = 3
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnCopier
        '
        Me.btnCopier.Location = New System.Drawing.Point(202, 203)
        Me.btnCopier.Name = "btnCopier"
        Me.btnCopier.Size = New System.Drawing.Size(90, 32)
        Me.btnCopier.TabIndex = 3
        Me.btnCopier.Text = "Copier"
        Me.btnCopier.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 238)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(400, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblSatus
        '
        Me.lblSatus.Name = "lblSatus"
        Me.lblSatus.Size = New System.Drawing.Size(111, 17)
        Me.lblSatus.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 260)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCopier)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lbLines)
        Me.Name = "Form1"
        Me.Text = "LineCopy"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLines As System.Windows.Forms.ListBox
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents btnCopier As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblSatus As System.Windows.Forms.ToolStripStatusLabel

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.representation_btn = New System.Windows.Forms.Button
        Me.rep_pb = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.equation_lbl = New System.Windows.Forms.Label
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rep_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(6, 16)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 10
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackBar1.Size = New System.Drawing.Size(221, 38)
        Me.TrackBar1.TabIndex = 5
        Me.TrackBar1.TickFrequency = 5
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar1.Value = 30
        '
        'representation_btn
        '
        Me.representation_btn.Location = New System.Drawing.Point(251, 38)
        Me.representation_btn.Name = "representation_btn"
        Me.representation_btn.Size = New System.Drawing.Size(161, 32)
        Me.representation_btn.TabIndex = 4
        Me.representation_btn.Text = "تمثيل الدالة"
        Me.representation_btn.UseVisualStyleBackColor = True
        '
        'rep_pb
        '
        Me.rep_pb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rep_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rep_pb.Location = New System.Drawing.Point(12, 78)
        Me.rep_pb.Name = "rep_pb"
        Me.rep_pb.Size = New System.Drawing.Size(400, 400)
        Me.rep_pb.TabIndex = 3
        Me.rep_pb.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 60)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تكبير المعلم :"
        '
        'equation_lbl
        '
        Me.equation_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.equation_lbl.Location = New System.Drawing.Point(251, 9)
        Me.equation_lbl.Name = "equation_lbl"
        Me.equation_lbl.Size = New System.Drawing.Size(161, 26)
        Me.equation_lbl.TabIndex = 7
        Me.equation_lbl.Text = "a.x + b = 0"
        Me.equation_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AcceptButton = Me.representation_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 490)
        Me.Controls.Add(Me.equation_lbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.representation_btn)
        Me.Controls.Add(Me.rep_pb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "التمثيل المبياني للدالة"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rep_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents representation_btn As System.Windows.Forms.Button
    Friend WithEvents rep_pb As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents equation_lbl As System.Windows.Forms.Label
End Class

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.a_txt = New System.Windows.Forms.TextBox
        Me.b_txt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.observ_lbl = New System.Windows.Forms.Label
        Me.reprsentation_btn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.solution_txt = New System.Windows.Forms.TextBox
        Me.Resoudre_btn = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مثال :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "a.x + b = 0        بحيث:    *a Є IR    و    b Є IR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.a_txt)
        Me.GroupBox2.Controls.Add(Me.b_txt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 53)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "قم بإدخال المعطيات :"
        '
        'a_txt
        '
        Me.a_txt.Location = New System.Drawing.Point(50, 23)
        Me.a_txt.Name = "a_txt"
        Me.a_txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.a_txt.Size = New System.Drawing.Size(87, 20)
        Me.a_txt.TabIndex = 7
        Me.a_txt.Text = "0"
        '
        'b_txt
        '
        Me.b_txt.Location = New System.Drawing.Point(196, 23)
        Me.b_txt.Name = "b_txt"
        Me.b_txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.b_txt.Size = New System.Drawing.Size(87, 20)
        Me.b_txt.TabIndex = 10
        Me.b_txt.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "b ="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "a ="
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.observ_lbl)
        Me.GroupBox3.Controls.Add(Me.reprsentation_btn)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.solution_txt)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 91)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "الحل :"
        '
        'observ_lbl
        '
        Me.observ_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.observ_lbl.Location = New System.Drawing.Point(6, 21)
        Me.observ_lbl.Name = "observ_lbl"
        Me.observ_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.observ_lbl.Size = New System.Drawing.Size(291, 21)
        Me.observ_lbl.TabIndex = 7
        Me.observ_lbl.Text = "ملاحظة"
        Me.observ_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'reprsentation_btn
        '
        Me.reprsentation_btn.Location = New System.Drawing.Point(6, 48)
        Me.reprsentation_btn.Name = "reprsentation_btn"
        Me.reprsentation_btn.Size = New System.Drawing.Size(127, 32)
        Me.reprsentation_btn.TabIndex = 10
        Me.reprsentation_btn.Text = "التمثيل المبياني للدالة"
        Me.reprsentation_btn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "الحل:"
        '
        'solution_txt
        '
        Me.solution_txt.Location = New System.Drawing.Point(139, 55)
        Me.solution_txt.Name = "solution_txt"
        Me.solution_txt.ReadOnly = True
        Me.solution_txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.solution_txt.Size = New System.Drawing.Size(120, 20)
        Me.solution_txt.TabIndex = 9
        '
        'Resoudre_btn
        '
        Me.Resoudre_btn.Location = New System.Drawing.Point(66, 122)
        Me.Resoudre_btn.Name = "Resoudre_btn"
        Me.Resoudre_btn.Size = New System.Drawing.Size(194, 32)
        Me.Resoudre_btn.TabIndex = 0
        Me.Resoudre_btn.Text = "حل المعادلة"
        Me.Resoudre_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Resoudre_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 263)
        Me.Controls.Add(Me.Resoudre_btn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "التمثيل المبياني للدوال"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents b_txt As System.Windows.Forms.TextBox
    Friend WithEvents a_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Resoudre_btn As System.Windows.Forms.Button
    Friend WithEvents observ_lbl As System.Windows.Forms.Label
    Friend WithEvents reprsentation_btn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents solution_txt As System.Windows.Forms.TextBox

End Class

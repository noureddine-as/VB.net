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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Donnee1_TXT_b = New System.Windows.Forms.TextBox
        Me.Donnee1_TXT_a = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Resolution1_LBL_Observ = New System.Windows.Forms.Label
        Me.Resolution1_TXT_S = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BTN_Resoudre1 = New System.Windows.Forms.Button
        Me.GB_Deg1 = New System.Windows.Forms.GroupBox
        Me.GB_Deg2 = New System.Windows.Forms.GroupBox
        Me.BTN_Resoudre2 = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Resolution2_LBL_Observ = New System.Windows.Forms.Label
        Me.Resolution2_TXT_X1foisX2 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Resolution2_TXT_X1plusX2 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Resolution2_TXT_X2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Resolution2_TXT_X1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Resolution2_LBL_Delta0 = New System.Windows.Forms.Label
        Me.Resolution2_TXT_Delta = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Resolution2_TXT_S = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Donnee2_TXT_c = New System.Windows.Forms.TextBox
        Me.Donnee2_TXT_b = New System.Windows.Forms.TextBox
        Me.Donnee2_TXT_a = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.RB_1 = New System.Windows.Forms.RadioButton
        Me.RB_2 = New System.Windows.Forms.RadioButton
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InitialiserToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.DateEtHeure_SbT = New System.Windows.Forms.ToolStripStatusLabel
        Me.DateEtHeure_TIM = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GB_Deg1.SuspendLayout()
        Me.GB_Deg2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exemple :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "a.x + b = 0  ;  x Є IR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Donnee1_TXT_b)
        Me.GroupBox2.Controls.Add(Me.Donnee1_TXT_a)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Les données :"
        '
        'Donnee1_TXT_b
        '
        Me.Donnee1_TXT_b.Location = New System.Drawing.Point(213, 25)
        Me.Donnee1_TXT_b.Name = "Donnee1_TXT_b"
        Me.Donnee1_TXT_b.Size = New System.Drawing.Size(70, 20)
        Me.Donnee1_TXT_b.TabIndex = 4
        '
        'Donnee1_TXT_a
        '
        Me.Donnee1_TXT_a.Location = New System.Drawing.Point(71, 25)
        Me.Donnee1_TXT_a.Name = "Donnee1_TXT_a"
        Me.Donnee1_TXT_a.Size = New System.Drawing.Size(70, 20)
        Me.Donnee1_TXT_a.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "b ="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "a ="
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Resolution1_LBL_Observ)
        Me.GroupBox3.Controls.Add(Me.Resolution1_TXT_S)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 174)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(324, 78)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "La résolution :"
        '
        'Resolution1_LBL_Observ
        '
        Me.Resolution1_LBL_Observ.AutoSize = True
        Me.Resolution1_LBL_Observ.Location = New System.Drawing.Point(6, 24)
        Me.Resolution1_LBL_Observ.Name = "Resolution1_LBL_Observ"
        Me.Resolution1_LBL_Observ.Size = New System.Drawing.Size(66, 13)
        Me.Resolution1_LBL_Observ.TabIndex = 4
        Me.Resolution1_LBL_Observ.Text = "Observation"
        Me.Resolution1_LBL_Observ.Visible = False
        '
        'Resolution1_TXT_S
        '
        Me.Resolution1_TXT_S.Location = New System.Drawing.Point(77, 49)
        Me.Resolution1_TXT_S.Name = "Resolution1_TXT_S"
        Me.Resolution1_TXT_S.ReadOnly = True
        Me.Resolution1_TXT_S.Size = New System.Drawing.Size(241, 20)
        Me.Resolution1_TXT_S.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "La solution :"
        '
        'BTN_Resoudre1
        '
        Me.BTN_Resoudre1.Location = New System.Drawing.Point(6, 138)
        Me.BTN_Resoudre1.Name = "BTN_Resoudre1"
        Me.BTN_Resoudre1.Size = New System.Drawing.Size(324, 30)
        Me.BTN_Resoudre1.TabIndex = 3
        Me.BTN_Resoudre1.Text = "Résoudre"
        Me.BTN_Resoudre1.UseVisualStyleBackColor = True
        '
        'GB_Deg1
        '
        Me.GB_Deg1.Controls.Add(Me.GroupBox1)
        Me.GB_Deg1.Controls.Add(Me.BTN_Resoudre1)
        Me.GB_Deg1.Controls.Add(Me.GroupBox2)
        Me.GB_Deg1.Controls.Add(Me.GroupBox3)
        Me.GB_Deg1.Location = New System.Drawing.Point(12, 117)
        Me.GB_Deg1.Name = "GB_Deg1"
        Me.GB_Deg1.Size = New System.Drawing.Size(336, 257)
        Me.GB_Deg1.TabIndex = 4
        Me.GB_Deg1.TabStop = False
        Me.GB_Deg1.Text = "Les équations du premier degré :"
        '
        'GB_Deg2
        '
        Me.GB_Deg2.Controls.Add(Me.BTN_Resoudre2)
        Me.GB_Deg2.Controls.Add(Me.GroupBox8)
        Me.GB_Deg2.Controls.Add(Me.GroupBox7)
        Me.GB_Deg2.Controls.Add(Me.GroupBox6)
        Me.GB_Deg2.Location = New System.Drawing.Point(354, 29)
        Me.GB_Deg2.Name = "GB_Deg2"
        Me.GB_Deg2.Size = New System.Drawing.Size(353, 345)
        Me.GB_Deg2.TabIndex = 5
        Me.GB_Deg2.TabStop = False
        Me.GB_Deg2.Text = "Les équations du second degré :"
        '
        'BTN_Resoudre2
        '
        Me.BTN_Resoudre2.Location = New System.Drawing.Point(6, 138)
        Me.BTN_Resoudre2.Name = "BTN_Resoudre2"
        Me.BTN_Resoudre2.Size = New System.Drawing.Size(341, 30)
        Me.BTN_Resoudre2.TabIndex = 4
        Me.BTN_Resoudre2.Text = "Résoudre"
        Me.BTN_Resoudre2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Resolution2_LBL_Observ)
        Me.GroupBox8.Controls.Add(Me.Resolution2_TXT_X1foisX2)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Resolution2_TXT_X1plusX2)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Resolution2_TXT_X2)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Resolution2_TXT_X1)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Resolution2_LBL_Delta0)
        Me.GroupBox8.Controls.Add(Me.Resolution2_TXT_Delta)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Resolution2_TXT_S)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 174)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(341, 164)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "La résolution :"
        '
        'Resolution2_LBL_Observ
        '
        Me.Resolution2_LBL_Observ.AutoSize = True
        Me.Resolution2_LBL_Observ.Location = New System.Drawing.Point(6, 104)
        Me.Resolution2_LBL_Observ.Name = "Resolution2_LBL_Observ"
        Me.Resolution2_LBL_Observ.Size = New System.Drawing.Size(66, 13)
        Me.Resolution2_LBL_Observ.TabIndex = 15
        Me.Resolution2_LBL_Observ.Text = "Observation"
        Me.Resolution2_LBL_Observ.Visible = False
        '
        'Resolution2_TXT_X1foisX2
        '
        Me.Resolution2_TXT_X1foisX2.Location = New System.Drawing.Point(235, 75)
        Me.Resolution2_TXT_X1foisX2.Name = "Resolution2_TXT_X1foisX2"
        Me.Resolution2_TXT_X1foisX2.ReadOnly = True
        Me.Resolution2_TXT_X1foisX2.Size = New System.Drawing.Size(100, 20)
        Me.Resolution2_TXT_X1foisX2.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(177, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "X1 . X2 ="
        '
        'Resolution2_TXT_X1plusX2
        '
        Me.Resolution2_TXT_X1plusX2.Location = New System.Drawing.Point(66, 75)
        Me.Resolution2_TXT_X1plusX2.Name = "Resolution2_TXT_X1plusX2"
        Me.Resolution2_TXT_X1plusX2.ReadOnly = True
        Me.Resolution2_TXT_X1plusX2.Size = New System.Drawing.Size(100, 20)
        Me.Resolution2_TXT_X1plusX2.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "X1 + X2 ="
        '
        'Resolution2_TXT_X2
        '
        Me.Resolution2_TXT_X2.Location = New System.Drawing.Point(211, 49)
        Me.Resolution2_TXT_X2.Name = "Resolution2_TXT_X2"
        Me.Resolution2_TXT_X2.ReadOnly = True
        Me.Resolution2_TXT_X2.Size = New System.Drawing.Size(124, 20)
        Me.Resolution2_TXT_X2.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(177, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "X2 ="
        '
        'Resolution2_TXT_X1
        '
        Me.Resolution2_TXT_X1.Location = New System.Drawing.Point(42, 49)
        Me.Resolution2_TXT_X1.Name = "Resolution2_TXT_X1"
        Me.Resolution2_TXT_X1.ReadOnly = True
        Me.Resolution2_TXT_X1.Size = New System.Drawing.Size(124, 20)
        Me.Resolution2_TXT_X1.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "X1 ="
        '
        'Resolution2_LBL_Delta0
        '
        Me.Resolution2_LBL_Delta0.AutoSize = True
        Me.Resolution2_LBL_Delta0.Location = New System.Drawing.Point(304, 26)
        Me.Resolution2_LBL_Delta0.Name = "Resolution2_LBL_Delta0"
        Me.Resolution2_LBL_Delta0.Size = New System.Drawing.Size(29, 13)
        Me.Resolution2_LBL_Delta0.TabIndex = 6
        Me.Resolution2_LBL_Delta0.Text = "Δ   0"
        '
        'Resolution2_TXT_Delta
        '
        Me.Resolution2_TXT_Delta.Location = New System.Drawing.Point(42, 23)
        Me.Resolution2_TXT_Delta.Name = "Resolution2_TXT_Delta"
        Me.Resolution2_TXT_Delta.ReadOnly = True
        Me.Resolution2_TXT_Delta.Size = New System.Drawing.Size(256, 20)
        Me.Resolution2_TXT_Delta.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Δ  ="
        '
        'Resolution2_TXT_S
        '
        Me.Resolution2_TXT_S.Location = New System.Drawing.Point(77, 132)
        Me.Resolution2_TXT_S.Name = "Resolution2_TXT_S"
        Me.Resolution2_TXT_S.ReadOnly = True
        Me.Resolution2_TXT_S.Size = New System.Drawing.Size(258, 20)
        Me.Resolution2_TXT_S.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "La solution :"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Donnee2_TXT_c)
        Me.GroupBox7.Controls.Add(Me.Donnee2_TXT_b)
        Me.GroupBox7.Controls.Add(Me.Donnee2_TXT_a)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 72)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(341, 60)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Les données :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(233, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "c ="
        '
        'Donnee2_TXT_c
        '
        Me.Donnee2_TXT_c.Location = New System.Drawing.Point(262, 25)
        Me.Donnee2_TXT_c.Name = "Donnee2_TXT_c"
        Me.Donnee2_TXT_c.Size = New System.Drawing.Size(70, 20)
        Me.Donnee2_TXT_c.TabIndex = 5
        '
        'Donnee2_TXT_b
        '
        Me.Donnee2_TXT_b.Location = New System.Drawing.Point(151, 25)
        Me.Donnee2_TXT_b.Name = "Donnee2_TXT_b"
        Me.Donnee2_TXT_b.Size = New System.Drawing.Size(70, 20)
        Me.Donnee2_TXT_b.TabIndex = 4
        '
        'Donnee2_TXT_a
        '
        Me.Donnee2_TXT_a.Location = New System.Drawing.Point(39, 25)
        Me.Donnee2_TXT_a.Name = "Donnee2_TXT_a"
        Me.Donnee2_TXT_a.Size = New System.Drawing.Size(70, 20)
        Me.Donnee2_TXT_a.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(121, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "b ="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "a ="
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(341, 47)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Exemple :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "a.x² + b.x + c = 0  ;  x Є IR   (a ≠ 0)"
        '
        'RB_1
        '
        Me.RB_1.AutoSize = True
        Me.RB_1.Checked = True
        Me.RB_1.Location = New System.Drawing.Point(6, 21)
        Me.RB_1.Name = "RB_1"
        Me.RB_1.Size = New System.Drawing.Size(157, 17)
        Me.RB_1.TabIndex = 8
        Me.RB_1.TabStop = True
        Me.RB_1.Text = "Equations du premier degré"
        Me.RB_1.UseVisualStyleBackColor = True
        '
        'RB_2
        '
        Me.RB_2.AutoSize = True
        Me.RB_2.Location = New System.Drawing.Point(6, 45)
        Me.RB_2.Name = "RB_2"
        Me.RB_2.Size = New System.Drawing.Size(155, 17)
        Me.RB_2.TabIndex = 9
        Me.RB_2.TabStop = True
        Me.RB_2.Text = "Equations du second degré"
        Me.RB_2.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.RB_1)
        Me.GroupBox9.Controls.Add(Me.RB_2)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(336, 75)
        Me.GroupBox9.TabIndex = 10
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Votre choix :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem, Me.InitialiserToutToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(717, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.fermer_icone_9559_32
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'InitialiserToutToolStripMenuItem
        '
        Me.InitialiserToutToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.actualiser
        Me.InitialiserToutToolStripMenuItem.Name = "InitialiserToutToolStripMenuItem"
        Me.InitialiserToutToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.InitialiserToutToolStripMenuItem.Text = "Initialiser tout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AideToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.aide_point_interrogation_bouclier_icone_5530_32
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.contact_vcard_icone_8852_32
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AProposToolStripMenuItem.Text = "A propos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateEtHeure_SbT, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 376)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(717, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DateEtHeure_SbT
        '
        Me.DateEtHeure_SbT.Name = "DateEtHeure_SbT"
        Me.DateEtHeure_SbT.Size = New System.Drawing.Size(133, 17)
        Me.DateEtHeure_SbT.Text = "jj/mm/aaaa    |    00:00:00"
        '
        'DateEtHeure_TIM
        '
        Me.DateEtHeure_TIM.Enabled = True
        Me.DateEtHeure_TIM.Interval = 1
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(569, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Programmé par: Noureddine @-S"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.ToolStripStatusLabel1.ToolTipText = "Programmé par: Noureddine @-S"
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(717, 398)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GB_Deg2)
        Me.Controls.Add(Me.GB_Deg1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.Text = "Solutions d'équations - V2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GB_Deg1.ResumeLayout(False)
        Me.GB_Deg2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Donnee1_TXT_b As System.Windows.Forms.TextBox
    Friend WithEvents Donnee1_TXT_a As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Resolution1_TXT_S As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTN_Resoudre1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GB_Deg1 As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Deg2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Donnee2_TXT_c As System.Windows.Forms.TextBox
    Friend WithEvents Donnee2_TXT_b As System.Windows.Forms.TextBox
    Friend WithEvents Donnee2_TXT_a As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Resolution2_LBL_Delta0 As System.Windows.Forms.Label
    Friend WithEvents Resolution2_TXT_Delta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Resolution2_TXT_S As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Resolution2_TXT_X2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Resolution2_TXT_X1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Resolution2_LBL_Observ As System.Windows.Forms.Label
    Friend WithEvents Resolution2_TXT_X1foisX2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Resolution2_TXT_X1plusX2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Resolution1_LBL_Observ As System.Windows.Forms.Label
    Friend WithEvents BTN_Resoudre2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB_1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InitialiserToutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DateEtHeure_SbT As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DateEtHeure_TIM As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class

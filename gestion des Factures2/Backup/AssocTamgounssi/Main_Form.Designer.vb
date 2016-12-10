<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim رقم_الإشتراكLabel As System.Windows.Forms.Label
        Dim اسم_المشتركLabel As System.Windows.Forms.Label
        Dim الدليل_السابقLabel As System.Windows.Forms.Label
        Dim الدليل_الحاليLabel As System.Windows.Forms.Label
        Dim الاستهلاكLabel As System.Windows.Forms.Label
        Dim مبلغ_الاستهلاكLabel As System.Windows.Forms.Label
        Dim فترة_الاستهلاكLabel As System.Windows.Forms.Label
        Dim المجموعLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Quittance_Eau_PotableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Quittance_Eau_PotableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AT_DBDataSet = New AssocTamgounssi.AT_DBDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Quittance_Eau_PotableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DGV_1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer
        Me.SB_Menu = New DevComponents.DotNetBar.SideBar
        Me.SBP_File = New DevComponents.DotNetBar.SideBarPanelItem
        Me.SaveAsDB = New DevComponents.DotNetBar.ButtonItem
        Me.SaveAsExcel = New DevComponents.DotNetBar.ButtonItem
        Me.BTN_Restart = New DevComponents.DotNetBar.ButtonItem
        Me.BTN_Exit = New DevComponents.DotNetBar.ButtonItem
        Me.SBP_Operations = New DevComponents.DotNetBar.SideBarPanelItem
        Me.BI_Change = New DevComponents.DotNetBar.ButtonItem
        Me.BI_Calculs = New DevComponents.DotNetBar.ButtonItem
        Me.BI_Enreg = New DevComponents.DotNetBar.ButtonItem
        Me.SBP_Visualisation = New DevComponents.DotNetBar.SideBarPanelItem
        Me.BTN_First = New DevComponents.DotNetBar.ButtonItem
        Me.BTN_Precedent = New DevComponents.DotNetBar.ButtonItem
        Me.BTN_Suivant = New DevComponents.DotNetBar.ButtonItem
        Me.BTN_Dernier = New DevComponents.DotNetBar.ButtonItem
        Me.BTN_Search = New DevComponents.DotNetBar.ButtonItem
        Me.SBP_Parametres = New DevComponents.DotNetBar.SideBarPanelItem
        Me.BTN_DureeConsomm = New DevComponents.DotNetBar.ButtonItem
        Me.BTN_UPConfig = New DevComponents.DotNetBar.ButtonItem
        Me.BTN_OtherConfig = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
        Me.الدليل_الحاليTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.فترة_الاستهلاكMaskedTextBoxAdv = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
        Me.WB_1 = New DevComponents.DotNetBar.Controls.WarningBox
        Me.GP_Infos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.اسم_المشتركLabel1 = New System.Windows.Forms.Label
        Me.رقم_الإشتراكLabel1 = New System.Windows.Forms.Label
        Me.GP_Index = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.الدليل_السابقTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.GP_ConsommIfos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.مبلغ_الاستهلاكTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.الاستهلاكTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.المجموعTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SFD_1 = New System.Windows.Forms.SaveFileDialog
        Me.SFD_2 = New System.Windows.Forms.SaveFileDialog
        Me.TM_DataVerify = New System.Windows.Forms.Timer(Me.components)
        Me.Quittance_Eau_PotableTableAdapter = New AssocTamgounssi.AT_DBDataSetTableAdapters.Quittance_Eau_PotableTableAdapter
        Me.TableAdapterManager = New AssocTamgounssi.AT_DBDataSetTableAdapters.TableAdapterManager
        Me.رقمالإشتراكDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اسمالمشتركDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الدليلالسابقDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الدليلالحاليDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.الاستهلاكDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مبلغالاستهلاكDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.فترةالاستهلاكDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.المجموعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        رقم_الإشتراكLabel = New System.Windows.Forms.Label
        اسم_المشتركLabel = New System.Windows.Forms.Label
        الدليل_السابقLabel = New System.Windows.Forms.Label
        الدليل_الحاليLabel = New System.Windows.Forms.Label
        الاستهلاكLabel = New System.Windows.Forms.Label
        مبلغ_الاستهلاكLabel = New System.Windows.Forms.Label
        فترة_الاستهلاكLabel = New System.Windows.Forms.Label
        المجموعLabel = New System.Windows.Forms.Label
        CType(Me.Quittance_Eau_PotableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Quittance_Eau_PotableBindingNavigator.SuspendLayout()
        CType(Me.Quittance_Eau_PotableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AT_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Infos.SuspendLayout()
        Me.GP_Index.SuspendLayout()
        Me.GP_ConsommIfos.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'رقم_الإشتراكLabel
        '
        رقم_الإشتراكLabel.AutoSize = True
        رقم_الإشتراكLabel.BackColor = System.Drawing.Color.Transparent
        رقم_الإشتراكLabel.Location = New System.Drawing.Point(168, 7)
        رقم_الإشتراكLabel.Name = "رقم_الإشتراكLabel"
        رقم_الإشتراكLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        رقم_الإشتراكLabel.Size = New System.Drawing.Size(75, 13)
        رقم_الإشتراكLabel.TabIndex = 0
        رقم_الإشتراكLabel.Text = "رقم الإشتراك :"
        '
        'اسم_المشتركLabel
        '
        اسم_المشتركLabel.AutoSize = True
        اسم_المشتركLabel.BackColor = System.Drawing.Color.Transparent
        اسم_المشتركLabel.Location = New System.Drawing.Point(162, 38)
        اسم_المشتركLabel.Name = "اسم_المشتركLabel"
        اسم_المشتركLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        اسم_المشتركLabel.Size = New System.Drawing.Size(81, 13)
        اسم_المشتركLabel.TabIndex = 2
        اسم_المشتركLabel.Text = "اسم المشترك :"
        '
        'الدليل_السابقLabel
        '
        الدليل_السابقLabel.AutoSize = True
        الدليل_السابقLabel.BackColor = System.Drawing.Color.Transparent
        الدليل_السابقLabel.Location = New System.Drawing.Point(150, 11)
        الدليل_السابقLabel.Name = "الدليل_السابقLabel"
        الدليل_السابقLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الدليل_السابقLabel.Size = New System.Drawing.Size(78, 13)
        الدليل_السابقLabel.TabIndex = 0
        الدليل_السابقLabel.Text = "الدليل السابق :"
        '
        'الدليل_الحاليLabel
        '
        الدليل_الحاليLabel.AutoSize = True
        الدليل_الحاليLabel.BackColor = System.Drawing.Color.Transparent
        الدليل_الحاليLabel.Location = New System.Drawing.Point(154, 44)
        الدليل_الحاليLabel.Name = "الدليل_الحاليLabel"
        الدليل_الحاليLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الدليل_الحاليLabel.Size = New System.Drawing.Size(74, 13)
        الدليل_الحاليLabel.TabIndex = 2
        الدليل_الحاليLabel.Text = "الدليل الحالي :"
        '
        'الاستهلاكLabel
        '
        الاستهلاكLabel.AutoSize = True
        الاستهلاكLabel.BackColor = System.Drawing.Color.Transparent
        الاستهلاكLabel.Location = New System.Drawing.Point(174, 12)
        الاستهلاكLabel.Name = "الاستهلاكLabel"
        الاستهلاكLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        الاستهلاكLabel.Size = New System.Drawing.Size(61, 13)
        الاستهلاكLabel.TabIndex = 0
        الاستهلاكLabel.Text = "الاستهلاك :"
        '
        'مبلغ_الاستهلاكLabel
        '
        مبلغ_الاستهلاكLabel.AutoSize = True
        مبلغ_الاستهلاكLabel.BackColor = System.Drawing.Color.Transparent
        مبلغ_الاستهلاكLabel.Location = New System.Drawing.Point(151, 41)
        مبلغ_الاستهلاكLabel.Name = "مبلغ_الاستهلاكLabel"
        مبلغ_الاستهلاكLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        مبلغ_الاستهلاكLabel.Size = New System.Drawing.Size(84, 13)
        مبلغ_الاستهلاكLabel.TabIndex = 2
        مبلغ_الاستهلاكLabel.Text = "مبلغ الاستهلاك :"
        '
        'فترة_الاستهلاكLabel
        '
        فترة_الاستهلاكLabel.AutoSize = True
        فترة_الاستهلاكLabel.BackColor = System.Drawing.Color.Transparent
        فترة_الاستهلاكLabel.Location = New System.Drawing.Point(152, 72)
        فترة_الاستهلاكLabel.Name = "فترة_الاستهلاكLabel"
        فترة_الاستهلاكLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        فترة_الاستهلاكLabel.Size = New System.Drawing.Size(83, 13)
        فترة_الاستهلاكLabel.TabIndex = 4
        فترة_الاستهلاكLabel.Text = "فترة الاستهلاك :"
        '
        'المجموعLabel
        '
        المجموعLabel.AutoSize = True
        المجموعLabel.BackColor = System.Drawing.Color.Transparent
        المجموعLabel.Location = New System.Drawing.Point(183, 12)
        المجموعLabel.Name = "المجموعLabel"
        المجموعLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        المجموعLabel.Size = New System.Drawing.Size(53, 13)
        المجموعLabel.TabIndex = 0
        المجموعLabel.Text = "المجموع :"
        '
        'Quittance_Eau_PotableBindingNavigator
        '
        Me.Quittance_Eau_PotableBindingNavigator.AddNewItem = Nothing
        Me.Quittance_Eau_PotableBindingNavigator.BindingSource = Me.Quittance_Eau_PotableBindingSource
        Me.Quittance_Eau_PotableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Quittance_Eau_PotableBindingNavigator.CountItemFormat = "من أصل {0}"
        Me.Quittance_Eau_PotableBindingNavigator.DeleteItem = Nothing
        Me.Quittance_Eau_PotableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Quittance_Eau_PotableBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Quittance_Eau_PotableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.BindingNavigatorCountItem, Me.ToolStripSeparator2, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator3, Me.Quittance_Eau_PotableBindingNavigatorSaveItem})
        Me.Quittance_Eau_PotableBindingNavigator.Location = New System.Drawing.Point(0, 235)
        Me.Quittance_Eau_PotableBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.Quittance_Eau_PotableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Quittance_Eau_PotableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Quittance_Eau_PotableBindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.Quittance_Eau_PotableBindingNavigator.Name = "Quittance_Eau_PotableBindingNavigator"
        Me.Quittance_Eau_PotableBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.Quittance_Eau_PotableBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Quittance_Eau_PotableBindingNavigator.Size = New System.Drawing.Size(692, 25)
        Me.Quittance_Eau_PotableBindingNavigator.TabIndex = 0
        Me.Quittance_Eau_PotableBindingNavigator.Text = "BindingNavigator1"
        '
        'Quittance_Eau_PotableBindingSource
        '
        Me.Quittance_Eau_PotableBindingSource.DataMember = "Quittance Eau Potable"
        Me.Quittance_Eau_PotableBindingSource.DataSource = Me.AT_DBDataSet
        '
        'AT_DBDataSet
        '
        Me.AT_DBDataSet.DataSetName = "AT_DBDataSet"
        Me.AT_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(63, 22)
        Me.BindingNavigatorCountItem.Text = "من أصل {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "مجموع المشتركين"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        Me.ToolStripButton1.ToolTipText = "المشترك الأول"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        Me.ToolStripButton2.ToolTipText = "المشترك السابق"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "المشترك الحالي"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.ToolTipText = "المشترك التالي"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.ToolTipText = "المشترك الأخير"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Quittance_Eau_PotableBindingNavigatorSaveItem
        '
        Me.Quittance_Eau_PotableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Quittance_Eau_PotableBindingNavigatorSaveItem.Image = CType(resources.GetObject("Quittance_Eau_PotableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Quittance_Eau_PotableBindingNavigatorSaveItem.Name = "Quittance_Eau_PotableBindingNavigatorSaveItem"
        Me.Quittance_Eau_PotableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Quittance_Eau_PotableBindingNavigatorSaveItem.Text = "Save Data"
        Me.Quittance_Eau_PotableBindingNavigatorSaveItem.ToolTipText = "حفظ البيانات"
        '
        'DGV_1
        '
        Me.DGV_1.AllowUserToAddRows = False
        Me.DGV_1.AllowUserToDeleteRows = False
        Me.DGV_1.AllowUserToResizeRows = False
        Me.DGV_1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.رقمالإشتراكDataGridViewTextBoxColumn, Me.اسمالمشتركDataGridViewTextBoxColumn, Me.الدليلالسابقDataGridViewTextBoxColumn, Me.الدليلالحاليDataGridViewTextBoxColumn, Me.الاستهلاكDataGridViewTextBoxColumn, Me.مبلغالاستهلاكDataGridViewTextBoxColumn, Me.فترةالاستهلاكDataGridViewTextBoxColumn, Me.المجموعDataGridViewTextBoxColumn})
        Me.DGV_1.DataSource = Me.Quittance_Eau_PotableBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGV_1.Location = New System.Drawing.Point(0, 260)
        Me.DGV_1.MultiSelect = False
        Me.DGV_1.Name = "DGV_1"
        Me.DGV_1.ReadOnly = True
        Me.DGV_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_1.Size = New System.Drawing.Size(692, 167)
        Me.DGV_1.TabIndex = 18
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "DockContainerItem1"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 46)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(32, 32)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelDockContainer1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelDockContainer1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 1
        '
        'SB_Menu
        '
        Me.SB_Menu.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.SB_Menu.AllowUserCustomize = False
        Me.SB_Menu.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.SB_Menu.Dock = System.Windows.Forms.DockStyle.Right
        Me.SB_Menu.ExpandedPanel = Me.SBP_File
        Me.SB_Menu.Location = New System.Drawing.Point(537, 0)
        Me.SB_Menu.Name = "SB_Menu"
        Me.SB_Menu.Panels.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SBP_Operations, Me.SBP_Visualisation, Me.SBP_Parametres, Me.SBP_File})
        Me.SB_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SB_Menu.Size = New System.Drawing.Size(155, 235)
        Me.SB_Menu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SB_Menu.TabIndex = 23
        Me.SB_Menu.Text = "SideBar1"
        Me.SB_Menu.UsingSystemColors = True
        '
        'SBP_File
        '
        Me.SBP_File.FontBold = True
        Me.SBP_File.Name = "SBP_File"
        Me.SBP_File.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SaveAsDB, Me.SaveAsExcel, Me.BTN_Restart, Me.BTN_Exit})
        Me.SBP_File.Text = "ملف"
        '
        'SaveAsDB
        '
        Me.SaveAsDB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.SaveAsDB.Image = Global.AssocTamgounssi.My.Resources.Resources.ACCESS
        Me.SaveAsDB.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.SaveAsDB.Name = "SaveAsDB"
        Me.SaveAsDB.Text = "حفظ المعلومات في" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " قاعدة بيانات ACCESS"
        Me.SaveAsDB.Tooltip = "حفظ المعلومات في قاعدة بيانات ACCESS"
        '
        'SaveAsExcel
        '
        Me.SaveAsExcel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.SaveAsExcel.Image = Global.AssocTamgounssi.My.Resources.Resources.Excel
        Me.SaveAsExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.SaveAsExcel.Name = "SaveAsExcel"
        Me.SaveAsExcel.Text = "حفظ المعلومات في" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "جدول EXCEL"
        Me.SaveAsExcel.Tooltip = "حفظ المعلومات في جدول EXCEL"
        '
        'BTN_Restart
        '
        Me.BTN_Restart.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_Restart.Image = Global.AssocTamgounssi.My.Resources.Resources.house_go
        Me.BTN_Restart.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_Restart.Name = "BTN_Restart"
        Me.BTN_Restart.Text = "إعادة تشغيل البرنامج"
        Me.BTN_Restart.Tooltip = "إغلاق البرنامج"
        '
        'BTN_Exit
        '
        Me.BTN_Exit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_Exit.Image = Global.AssocTamgounssi.My.Resources.Resources.cancel
        Me.BTN_Exit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Text = "غلق البرنامج"
        '
        'SBP_Operations
        '
        Me.SBP_Operations.FontBold = True
        Me.SBP_Operations.Name = "SBP_Operations"
        Me.SBP_Operations.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BI_Change, Me.BI_Calculs, Me.BI_Enreg})
        Me.SBP_Operations.Text = "نافذة العمليات"
        '
        'BI_Change
        '
        Me.BI_Change.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BI_Change.Image = Global.AssocTamgounssi.My.Resources.Resources.arrow_refresh
        Me.BI_Change.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BI_Change.Name = "BI_Change"
        Me.BI_Change.Text = "1 - تبديل الأرقام"
        Me.BI_Change.Tooltip = "تبديل الدليل السابق بالدليل الحالي"
        '
        'BI_Calculs
        '
        Me.BI_Calculs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BI_Calculs.Image = Global.AssocTamgounssi.My.Resources.Resources.calculator
        Me.BI_Calculs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BI_Calculs.Name = "BI_Calculs"
        Me.BI_Calculs.Text = "2 - إنجاز الحسابات"
        Me.BI_Calculs.Tooltip = "حساب كمية الإستهلاك، مبلغ الإستهلاك و المجموع"
        '
        'BI_Enreg
        '
        Me.BI_Enreg.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BI_Enreg.Image = Global.AssocTamgounssi.My.Resources.Resources.disk
        Me.BI_Enreg.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BI_Enreg.Name = "BI_Enreg"
        Me.BI_Enreg.Text = "3 - مراجعة و حفظ النتائج"
        Me.BI_Enreg.Tooltip = "مراجعة و حفظ كل النتائج و المرور للمشترك التالي"
        '
        'SBP_Visualisation
        '
        Me.SBP_Visualisation.FontBold = True
        Me.SBP_Visualisation.Name = "SBP_Visualisation"
        Me.SBP_Visualisation.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BTN_First, Me.BTN_Precedent, Me.BTN_Suivant, Me.BTN_Dernier, Me.BTN_Search})
        Me.SBP_Visualisation.Text = "تصفح البيانات"
        '
        'BTN_First
        '
        Me.BTN_First.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_First.Image = Global.AssocTamgounssi.My.Resources.Resources.resultset_last
        Me.BTN_First.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_First.Name = "BTN_First"
        Me.BTN_First.Text = "الأول"
        Me.BTN_First.Tooltip = "المشترك الأول"
        '
        'BTN_Precedent
        '
        Me.BTN_Precedent.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_Precedent.Image = Global.AssocTamgounssi.My.Resources.Resources.resultset_next
        Me.BTN_Precedent.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_Precedent.Name = "BTN_Precedent"
        Me.BTN_Precedent.Text = "السابق"
        Me.BTN_Precedent.Tooltip = "المشترك السابق"
        '
        'BTN_Suivant
        '
        Me.BTN_Suivant.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_Suivant.Image = Global.AssocTamgounssi.My.Resources.Resources.resultset_previous
        Me.BTN_Suivant.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_Suivant.Name = "BTN_Suivant"
        Me.BTN_Suivant.Text = "التالي"
        Me.BTN_Suivant.Tooltip = "المشترك التالي"
        '
        'BTN_Dernier
        '
        Me.BTN_Dernier.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_Dernier.Image = Global.AssocTamgounssi.My.Resources.Resources.resultset_first
        Me.BTN_Dernier.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_Dernier.Name = "BTN_Dernier"
        Me.BTN_Dernier.Text = "الأخير"
        Me.BTN_Dernier.Tooltip = "المشترك الأخير"
        '
        'BTN_Search
        '
        Me.BTN_Search.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_Search.Image = Global.AssocTamgounssi.My.Resources.Resources.zoom
        Me.BTN_Search.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_Search.Name = "BTN_Search"
        Me.BTN_Search.Text = "بحث"
        Me.BTN_Search.Tooltip = "بحث"
        '
        'SBP_Parametres
        '
        Me.SBP_Parametres.FontBold = True
        Me.SBP_Parametres.Name = "SBP_Parametres"
        Me.SBP_Parametres.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BTN_DureeConsomm, Me.BTN_UPConfig, Me.BTN_OtherConfig})
        Me.SBP_Parametres.Text = "إعدادات"
        '
        'BTN_DureeConsomm
        '
        Me.BTN_DureeConsomm.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_DureeConsomm.Image = Global.AssocTamgounssi.My.Resources.Resources.date_edit
        Me.BTN_DureeConsomm.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_DureeConsomm.Name = "BTN_DureeConsomm"
        Me.BTN_DureeConsomm.Text = "تعديل فترة الإستهلاك"
        Me.BTN_DureeConsomm.Tooltip = "تعديل فترة الإستهلاك"
        '
        'BTN_UPConfig
        '
        Me.BTN_UPConfig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_UPConfig.Image = Global.AssocTamgounssi.My.Resources.Resources.user_edit
        Me.BTN_UPConfig.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_UPConfig.Name = "BTN_UPConfig"
        Me.BTN_UPConfig.Text = "تغيير معلومات الدخول"
        Me.BTN_UPConfig.Tooltip = "تغيير اسم المستخدم و كلمة المرور"
        '
        'BTN_OtherConfig
        '
        Me.BTN_OtherConfig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BTN_OtherConfig.Image = Global.AssocTamgounssi.My.Resources.Resources.wrench
        Me.BTN_OtherConfig.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_OtherConfig.Name = "BTN_OtherConfig"
        Me.BTN_OtherConfig.Text = "إعدادات أخرى"
        Me.BTN_OtherConfig.Tooltip = "إعدادات أخرى: الثمن، واجب الإشتراك و واجب المسجد"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "بحث"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'الدليل_الحاليTextBoxX
        '
        '
        '
        '
        Me.الدليل_الحاليTextBoxX.Border.Class = "TextBoxBorder"
        Me.الدليل_الحاليTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.الدليل_الحاليTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quittance_Eau_PotableBindingSource, "الدليل الحالي", True))
        Me.Highlighter1.SetHighlightOnFocus(Me.الدليل_الحاليTextBoxX, True)
        Me.الدليل_الحاليTextBoxX.Location = New System.Drawing.Point(19, 42)
        Me.الدليل_الحاليTextBoxX.Name = "الدليل_الحاليTextBoxX"
        Me.الدليل_الحاليTextBoxX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.الدليل_الحاليTextBoxX.Size = New System.Drawing.Size(125, 20)
        Me.الدليل_الحاليTextBoxX.TabIndex = 3
        Me.الدليل_الحاليTextBoxX.WatermarkText = "الدليل الحالي"
        '
        'فترة_الاستهلاكMaskedTextBoxAdv
        '
        '
        '
        '
        Me.فترة_الاستهلاكMaskedTextBoxAdv.BackgroundStyle.Class = "TextBoxBorder"
        Me.فترة_الاستهلاكMaskedTextBoxAdv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.فترة_الاستهلاكMaskedTextBoxAdv.BeepOnError = True
        Me.فترة_الاستهلاكMaskedTextBoxAdv.ButtonClear.Visible = True
        Me.فترة_الاستهلاكMaskedTextBoxAdv.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.فترة_الاستهلاكMaskedTextBoxAdv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quittance_Eau_PotableBindingSource, "فترة الاستهلاك", True))
        Me.Highlighter1.SetHighlightOnFocus(Me.فترة_الاستهلاكMaskedTextBoxAdv, True)
        Me.فترة_الاستهلاكMaskedTextBoxAdv.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.فترة_الاستهلاكMaskedTextBoxAdv.Location = New System.Drawing.Point(11, 68)
        Me.فترة_الاستهلاكMaskedTextBoxAdv.Mask = "00/0000"
        Me.فترة_الاستهلاكMaskedTextBoxAdv.Name = "فترة_الاستهلاكMaskedTextBoxAdv"
        Me.فترة_الاستهلاكMaskedTextBoxAdv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.فترة_الاستهلاكMaskedTextBoxAdv.Size = New System.Drawing.Size(134, 20)
        Me.فترة_الاستهلاكMaskedTextBoxAdv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.فترة_الاستهلاكMaskedTextBoxAdv.TabIndex = 5
        Me.فترة_الاستهلاكMaskedTextBoxAdv.Text = ""
        Me.فترة_الاستهلاكMaskedTextBoxAdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.فترة_الاستهلاكMaskedTextBoxAdv.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        '
        'WB_1
        '
        Me.WB_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.WB_1.CloseButtonVisible = False
        Me.WB_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.WB_1.Image = CType(resources.GetObject("WB_1.Image"), System.Drawing.Image)
        Me.WB_1.Location = New System.Drawing.Point(0, 0)
        Me.WB_1.Name = "WB_1"
        Me.WB_1.OptionsText = "إعدادات"
        Me.WB_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WB_1.Size = New System.Drawing.Size(537, 34)
        Me.WB_1.TabIndex = 0
        Me.WB_1.Text = "<b><font size=""9""><font color=""#BA1419""> ملحوظـة:</font></font></b> المرجو تفقد إ" & _
            "عدادات البرنامج  و إعادة تشغيله قبل العمل على البيانات ."
        '
        'GP_Infos
        '
        Me.GP_Infos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Infos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Infos.Controls.Add(اسم_المشتركLabel)
        Me.GP_Infos.Controls.Add(Me.اسم_المشتركLabel1)
        Me.GP_Infos.Controls.Add(رقم_الإشتراكLabel)
        Me.GP_Infos.Controls.Add(Me.رقم_الإشتراكLabel1)
        Me.GP_Infos.Location = New System.Drawing.Point(272, 6)
        Me.GP_Infos.Name = "GP_Infos"
        Me.GP_Infos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GP_Infos.Size = New System.Drawing.Size(252, 88)
        '
        '
        '
        Me.GP_Infos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Infos.Style.BackColorGradientAngle = 90
        Me.GP_Infos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Infos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Infos.Style.BorderBottomWidth = 1
        Me.GP_Infos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Infos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Infos.Style.BorderLeftWidth = 1
        Me.GP_Infos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Infos.Style.BorderRightWidth = 1
        Me.GP_Infos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Infos.Style.BorderTopWidth = 1
        Me.GP_Infos.Style.Class = ""
        Me.GP_Infos.Style.CornerDiameter = 4
        Me.GP_Infos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Infos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_Infos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Infos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Infos.StyleMouseDown.Class = ""
        Me.GP_Infos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Infos.StyleMouseOver.Class = ""
        Me.GP_Infos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Infos.TabIndex = 31
        Me.GP_Infos.Text = "معلومات المشترك"
        '
        'اسم_المشتركLabel1
        '
        Me.اسم_المشتركLabel1.BackColor = System.Drawing.Color.Transparent
        Me.اسم_المشتركLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quittance_Eau_PotableBindingSource, "اسم المشترك", True))
        Me.اسم_المشتركLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.اسم_المشتركLabel1.Location = New System.Drawing.Point(3, 38)
        Me.اسم_المشتركLabel1.Name = "اسم_المشتركLabel1"
        Me.اسم_المشتركLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.اسم_المشتركLabel1.Size = New System.Drawing.Size(156, 23)
        Me.اسم_المشتركLabel1.TabIndex = 3
        Me.اسم_المشتركLabel1.Text = "Label1"
        '
        'رقم_الإشتراكLabel1
        '
        Me.رقم_الإشتراكLabel1.BackColor = System.Drawing.Color.Transparent
        Me.رقم_الإشتراكLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quittance_Eau_PotableBindingSource, "رقم الإشتراك", True))
        Me.رقم_الإشتراكLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.رقم_الإشتراكLabel1.Location = New System.Drawing.Point(3, 7)
        Me.رقم_الإشتراكLabel1.Name = "رقم_الإشتراكLabel1"
        Me.رقم_الإشتراكLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.رقم_الإشتراكLabel1.Size = New System.Drawing.Size(159, 23)
        Me.رقم_الإشتراكLabel1.TabIndex = 1
        Me.رقم_الإشتراكLabel1.Text = "Label1"
        '
        'GP_Index
        '
        Me.GP_Index.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Index.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Index.Controls.Add(الدليل_الحاليLabel)
        Me.GP_Index.Controls.Add(Me.الدليل_الحاليTextBoxX)
        Me.GP_Index.Controls.Add(الدليل_السابقLabel)
        Me.GP_Index.Controls.Add(Me.الدليل_السابقTextBoxX)
        Me.GP_Index.Location = New System.Drawing.Point(272, 100)
        Me.GP_Index.Name = "GP_Index"
        Me.GP_Index.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GP_Index.Size = New System.Drawing.Size(252, 94)
        '
        '
        '
        Me.GP_Index.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Index.Style.BackColorGradientAngle = 90
        Me.GP_Index.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Index.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Index.Style.BorderBottomWidth = 1
        Me.GP_Index.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Index.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Index.Style.BorderLeftWidth = 1
        Me.GP_Index.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Index.Style.BorderRightWidth = 1
        Me.GP_Index.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Index.Style.BorderTopWidth = 1
        Me.GP_Index.Style.Class = ""
        Me.GP_Index.Style.CornerDiameter = 4
        Me.GP_Index.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Index.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_Index.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Index.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Index.StyleMouseDown.Class = ""
        Me.GP_Index.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Index.StyleMouseOver.Class = ""
        Me.GP_Index.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Index.TabIndex = 32
        Me.GP_Index.Text = "الأرقام : Index"
        '
        'الدليل_السابقTextBoxX
        '
        '
        '
        '
        Me.الدليل_السابقTextBoxX.Border.Class = "TextBoxBorder"
        Me.الدليل_السابقTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.الدليل_السابقTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quittance_Eau_PotableBindingSource, "الدليل السابق", True))
        Me.الدليل_السابقTextBoxX.Location = New System.Drawing.Point(19, 11)
        Me.الدليل_السابقTextBoxX.Name = "الدليل_السابقTextBoxX"
        Me.الدليل_السابقTextBoxX.ReadOnly = True
        Me.الدليل_السابقTextBoxX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.الدليل_السابقTextBoxX.Size = New System.Drawing.Size(125, 20)
        Me.الدليل_السابقTextBoxX.TabIndex = 1
        '
        'GP_ConsommIfos
        '
        Me.GP_ConsommIfos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_ConsommIfos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_ConsommIfos.Controls.Add(فترة_الاستهلاكLabel)
        Me.GP_ConsommIfos.Controls.Add(Me.فترة_الاستهلاكMaskedTextBoxAdv)
        Me.GP_ConsommIfos.Controls.Add(مبلغ_الاستهلاكLabel)
        Me.GP_ConsommIfos.Controls.Add(Me.مبلغ_الاستهلاكTextBoxX)
        Me.GP_ConsommIfos.Controls.Add(الاستهلاكLabel)
        Me.GP_ConsommIfos.Controls.Add(Me.الاستهلاكTextBoxX)
        Me.GP_ConsommIfos.Location = New System.Drawing.Point(14, 6)
        Me.GP_ConsommIfos.Name = "GP_ConsommIfos"
        Me.GP_ConsommIfos.Size = New System.Drawing.Size(252, 120)
        '
        '
        '
        Me.GP_ConsommIfos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_ConsommIfos.Style.BackColorGradientAngle = 90
        Me.GP_ConsommIfos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_ConsommIfos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_ConsommIfos.Style.BorderBottomWidth = 1
        Me.GP_ConsommIfos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_ConsommIfos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_ConsommIfos.Style.BorderLeftWidth = 1
        Me.GP_ConsommIfos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_ConsommIfos.Style.BorderRightWidth = 1
        Me.GP_ConsommIfos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_ConsommIfos.Style.BorderTopWidth = 1
        Me.GP_ConsommIfos.Style.Class = ""
        Me.GP_ConsommIfos.Style.CornerDiameter = 4
        Me.GP_ConsommIfos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_ConsommIfos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_ConsommIfos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_ConsommIfos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_ConsommIfos.StyleMouseDown.Class = ""
        Me.GP_ConsommIfos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_ConsommIfos.StyleMouseOver.Class = ""
        Me.GP_ConsommIfos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_ConsommIfos.TabIndex = 33
        Me.GP_ConsommIfos.Text = "معلومات الاستهلاك"
        '
        'مبلغ_الاستهلاكTextBoxX
        '
        '
        '
        '
        Me.مبلغ_الاستهلاكTextBoxX.Border.Class = "TextBoxBorder"
        Me.مبلغ_الاستهلاكTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.مبلغ_الاستهلاكTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quittance_Eau_PotableBindingSource, "مبلغ الاستهلاك", True))
        Me.مبلغ_الاستهلاكTextBoxX.Location = New System.Drawing.Point(11, 39)
        Me.مبلغ_الاستهلاكTextBoxX.Name = "مبلغ_الاستهلاكTextBoxX"
        Me.مبلغ_الاستهلاكTextBoxX.ReadOnly = True
        Me.مبلغ_الاستهلاكTextBoxX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.مبلغ_الاستهلاكTextBoxX.Size = New System.Drawing.Size(134, 20)
        Me.مبلغ_الاستهلاكTextBoxX.TabIndex = 3
        '
        'الاستهلاكTextBoxX
        '
        '
        '
        '
        Me.الاستهلاكTextBoxX.Border.Class = "TextBoxBorder"
        Me.الاستهلاكTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.الاستهلاكTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quittance_Eau_PotableBindingSource, "الاستهلاك", True))
        Me.الاستهلاكTextBoxX.Location = New System.Drawing.Point(11, 10)
        Me.الاستهلاكTextBoxX.Name = "الاستهلاكTextBoxX"
        Me.الاستهلاكTextBoxX.ReadOnly = True
        Me.الاستهلاكTextBoxX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.الاستهلاكTextBoxX.Size = New System.Drawing.Size(134, 20)
        Me.الاستهلاكTextBoxX.TabIndex = 1
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(المجموعLabel)
        Me.GroupPanel4.Controls.Add(Me.المجموعTextBoxX)
        Me.GroupPanel4.Location = New System.Drawing.Point(12, 132)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(254, 62)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.Class = ""
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.Class = ""
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.Class = ""
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 34
        Me.GroupPanel4.Text = "المجموع"
        '
        'المجموعTextBoxX
        '
        '
        '
        '
        Me.المجموعTextBoxX.Border.Class = "TextBoxBorder"
        Me.المجموعTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.المجموعTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quittance_Eau_PotableBindingSource, "المجموع", True))
        Me.المجموعTextBoxX.Location = New System.Drawing.Point(12, 10)
        Me.المجموعTextBoxX.Name = "المجموعTextBoxX"
        Me.المجموعTextBoxX.ReadOnly = True
        Me.المجموعTextBoxX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.المجموعTextBoxX.Size = New System.Drawing.Size(134, 20)
        Me.المجموعTextBoxX.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupPanel4)
        Me.Panel1.Controls.Add(Me.GP_ConsommIfos)
        Me.Panel1.Controls.Add(Me.GP_Index)
        Me.Panel1.Controls.Add(Me.GP_Infos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 201)
        Me.Panel1.TabIndex = 35
        '
        'TM_DataVerify
        '
        Me.TM_DataVerify.Enabled = True
        '
        'Quittance_Eau_PotableTableAdapter
        '
        Me.Quittance_Eau_PotableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Quittance_Eau_PotableTableAdapter = Me.Quittance_Eau_PotableTableAdapter
        Me.TableAdapterManager.UpdateOrder = AssocTamgounssi.AT_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'رقمالإشتراكDataGridViewTextBoxColumn
        '
        Me.رقمالإشتراكDataGridViewTextBoxColumn.DataPropertyName = "رقم الإشتراك"
        Me.رقمالإشتراكDataGridViewTextBoxColumn.HeaderText = "رقم الإشتراك"
        Me.رقمالإشتراكDataGridViewTextBoxColumn.Name = "رقمالإشتراكDataGridViewTextBoxColumn"
        Me.رقمالإشتراكDataGridViewTextBoxColumn.ReadOnly = True
        Me.رقمالإشتراكDataGridViewTextBoxColumn.Width = 91
        '
        'اسمالمشتركDataGridViewTextBoxColumn
        '
        Me.اسمالمشتركDataGridViewTextBoxColumn.DataPropertyName = "اسم المشترك"
        Me.اسمالمشتركDataGridViewTextBoxColumn.HeaderText = "اسم المشترك"
        Me.اسمالمشتركDataGridViewTextBoxColumn.Name = "اسمالمشتركDataGridViewTextBoxColumn"
        Me.اسمالمشتركDataGridViewTextBoxColumn.ReadOnly = True
        Me.اسمالمشتركDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'الدليلالسابقDataGridViewTextBoxColumn
        '
        Me.الدليلالسابقDataGridViewTextBoxColumn.DataPropertyName = "الدليل السابق"
        Me.الدليلالسابقDataGridViewTextBoxColumn.HeaderText = "الدليل السابق"
        Me.الدليلالسابقDataGridViewTextBoxColumn.Name = "الدليلالسابقDataGridViewTextBoxColumn"
        Me.الدليلالسابقDataGridViewTextBoxColumn.ReadOnly = True
        Me.الدليلالسابقDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'الدليلالحاليDataGridViewTextBoxColumn
        '
        Me.الدليلالحاليDataGridViewTextBoxColumn.DataPropertyName = "الدليل الحالي"
        Me.الدليلالحاليDataGridViewTextBoxColumn.HeaderText = "الدليل الحالي"
        Me.الدليلالحاليDataGridViewTextBoxColumn.Name = "الدليلالحاليDataGridViewTextBoxColumn"
        Me.الدليلالحاليDataGridViewTextBoxColumn.ReadOnly = True
        Me.الدليلالحاليDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'الاستهلاكDataGridViewTextBoxColumn
        '
        Me.الاستهلاكDataGridViewTextBoxColumn.DataPropertyName = "الاستهلاك"
        Me.الاستهلاكDataGridViewTextBoxColumn.HeaderText = "الاستهلاك"
        Me.الاستهلاكDataGridViewTextBoxColumn.Name = "الاستهلاكDataGridViewTextBoxColumn"
        Me.الاستهلاكDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مبلغالاستهلاكDataGridViewTextBoxColumn
        '
        Me.مبلغالاستهلاكDataGridViewTextBoxColumn.DataPropertyName = "مبلغ الاستهلاك"
        Me.مبلغالاستهلاكDataGridViewTextBoxColumn.HeaderText = "مبلغ الاستهلاك"
        Me.مبلغالاستهلاكDataGridViewTextBoxColumn.Name = "مبلغالاستهلاكDataGridViewTextBoxColumn"
        Me.مبلغالاستهلاكDataGridViewTextBoxColumn.ReadOnly = True
        '
        'فترةالاستهلاكDataGridViewTextBoxColumn
        '
        Me.فترةالاستهلاكDataGridViewTextBoxColumn.DataPropertyName = "فترة الاستهلاك"
        Me.فترةالاستهلاكDataGridViewTextBoxColumn.HeaderText = "فترة الاستهلاك"
        Me.فترةالاستهلاكDataGridViewTextBoxColumn.Name = "فترةالاستهلاكDataGridViewTextBoxColumn"
        Me.فترةالاستهلاكDataGridViewTextBoxColumn.ReadOnly = True
        Me.فترةالاستهلاكDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'المجموعDataGridViewTextBoxColumn
        '
        Me.المجموعDataGridViewTextBoxColumn.DataPropertyName = "المجموع"
        Me.المجموعDataGridViewTextBoxColumn.HeaderText = "المجموع"
        Me.المجموعDataGridViewTextBoxColumn.Name = "المجموعDataGridViewTextBoxColumn"
        Me.المجموعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 427)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WB_1)
        Me.Controls.Add(Me.SB_Menu)
        Me.Controls.Add(Me.Quittance_Eau_PotableBindingNavigator)
        Me.Controls.Add(Me.DGV_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IconTooltip = "برنامج جمعية تمكونسي للتنمية و التعاون"
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "جمعية تمكونسي للتنمية و التعاون"
        CType(Me.Quittance_Eau_PotableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Quittance_Eau_PotableBindingNavigator.ResumeLayout(False)
        Me.Quittance_Eau_PotableBindingNavigator.PerformLayout()
        CType(Me.Quittance_Eau_PotableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AT_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Infos.ResumeLayout(False)
        Me.GP_Infos.PerformLayout()
        Me.GP_Index.ResumeLayout(False)
        Me.GP_Index.PerformLayout()
        Me.GP_ConsommIfos.ResumeLayout(False)
        Me.GP_ConsommIfos.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AT_DBDataSet As AssocTamgounssi.AT_DBDataSet
    Friend WithEvents Quittance_Eau_PotableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quittance_Eau_PotableTableAdapter As AssocTamgounssi.AT_DBDataSetTableAdapters.Quittance_Eau_PotableTableAdapter
    Friend WithEvents TableAdapterManager As AssocTamgounssi.AT_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Quittance_Eau_PotableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Quittance_Eau_PotableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DGV_1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents SB_Menu As DevComponents.DotNetBar.SideBar
    Friend WithEvents SBP_Operations As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents BI_Change As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BI_Calculs As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BI_Enreg As DevComponents.DotNetBar.ButtonItem
    Private WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SBP_Visualisation As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents BTN_First As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTN_Precedent As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTN_Suivant As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTN_Dernier As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTN_Search As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents SBP_Parametres As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents BTN_DureeConsomm As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents WB_1 As DevComponents.DotNetBar.Controls.WarningBox
    Friend WithEvents GP_Infos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents اسم_المشتركLabel1 As System.Windows.Forms.Label
    Friend WithEvents رقم_الإشتراكLabel1 As System.Windows.Forms.Label
    Friend WithEvents GP_Index As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents الدليل_الحاليTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents الدليل_السابقTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GP_ConsommIfos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents فترة_الاستهلاكMaskedTextBoxAdv As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents مبلغ_الاستهلاكTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents الاستهلاكTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents المجموعTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BTN_UPConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTN_OtherConfig As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SBP_File As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents SaveAsDB As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SFD_1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveAsExcel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SFD_2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TM_DataVerify As System.Windows.Forms.Timer
    Friend WithEvents BTN_Restart As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BTN_Exit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents رقمالإشتراكDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اسمالمشتركDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الدليلالسابقDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الدليلالحاليDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الاستهلاكDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبلغالاستهلاكDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فترةالاستهلاكDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents المجموعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

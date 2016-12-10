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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.TXT_Nom = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_NAbonn = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_NCompteur = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_IndexPreced = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_IndexPresent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_ConsomM3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.TXT_Prix = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.TXT_PrixConsomm = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_Abonn = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.TXT_DevMosquee = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_Total = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.GP_Info = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.GP_Index = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.GP_Consomm = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.BTN_PrixConsommation = New DevComponents.DotNetBar.ButtonX
        Me.GP_DureeConsomm = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.TXT_Annee = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TXT_Mois = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.GP_Autres = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.GP_Total = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.BTN_PrixTotal = New DevComponents.DotNetBar.ButtonX
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.LBI_DateEtHeure = New DevComponents.DotNetBar.LabelItem
        Me.TM_HeureEtDate = New System.Windows.Forms.Timer(Me.components)
        Me.TM_Verification = New System.Windows.Forms.Timer(Me.components)
        Me.BTN_Options = New DevComponents.DotNetBar.ButtonX
        Me.BTN_Initialiser = New DevComponents.DotNetBar.ButtonX
        Me.BTN_Apercu = New DevComponents.DotNetBar.ButtonX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.HG_Light = New DevComponents.DotNetBar.Validator.Highlighter
        Me.GP_Info.SuspendLayout()
        Me.GP_Index.SuspendLayout()
        Me.GP_Consomm.SuspendLayout()
        Me.GP_DureeConsomm.SuspendLayout()
        Me.GP_Autres.SuspendLayout()
        Me.GP_Total.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_Nom
        '
        '
        '
        '
        Me.TXT_Nom.Border.Class = "TextBoxBorder"
        Me.TXT_Nom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_Nom, "TXT_Nom")
        Me.TXT_Nom.Name = "TXT_Nom"
        '
        'TXT_NAbonn
        '
        '
        '
        '
        Me.TXT_NAbonn.Border.Class = "TextBoxBorder"
        Me.TXT_NAbonn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_NAbonn, "TXT_NAbonn")
        Me.TXT_NAbonn.Name = "TXT_NAbonn"
        '
        'TXT_NCompteur
        '
        '
        '
        '
        Me.TXT_NCompteur.Border.Class = "TextBoxBorder"
        Me.TXT_NCompteur.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_NCompteur, "TXT_NCompteur")
        Me.TXT_NCompteur.Name = "TXT_NCompteur"
        '
        'TXT_IndexPreced
        '
        '
        '
        '
        Me.TXT_IndexPreced.Border.Class = "TextBoxBorder"
        Me.TXT_IndexPreced.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_IndexPreced, "TXT_IndexPreced")
        Me.TXT_IndexPreced.Name = "TXT_IndexPreced"
        '
        'TXT_IndexPresent
        '
        '
        '
        '
        Me.TXT_IndexPresent.Border.Class = "TextBoxBorder"
        Me.TXT_IndexPresent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_IndexPresent, "TXT_IndexPresent")
        Me.TXT_IndexPresent.Name = "TXT_IndexPresent"
        '
        'TXT_ConsomM3
        '
        '
        '
        '
        Me.TXT_ConsomM3.Border.Class = "TextBoxBorder"
        Me.TXT_ConsomM3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_ConsomM3, "TXT_ConsomM3")
        Me.TXT_ConsomM3.Name = "TXT_ConsomM3"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.Name = "LabelX1"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        Me.LabelX2.Name = "LabelX2"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.Name = "LabelX3"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX5, "LabelX5")
        Me.LabelX5.Name = "LabelX5"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX6, "LabelX6")
        Me.LabelX6.Name = "LabelX6"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX7, "LabelX7")
        Me.LabelX7.Name = "LabelX7"
        '
        'TXT_Prix
        '
        '
        '
        '
        Me.TXT_Prix.Border.Class = "TextBoxBorder"
        Me.TXT_Prix.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_Prix, "TXT_Prix")
        Me.TXT_Prix.Name = "TXT_Prix"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX8, "LabelX8")
        Me.LabelX8.Name = "LabelX8"
        '
        'TXT_PrixConsomm
        '
        '
        '
        '
        Me.TXT_PrixConsomm.Border.Class = "TextBoxBorder"
        Me.TXT_PrixConsomm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_PrixConsomm, "TXT_PrixConsomm")
        Me.TXT_PrixConsomm.Name = "TXT_PrixConsomm"
        Me.TXT_PrixConsomm.ReadOnly = True
        '
        'TXT_Abonn
        '
        '
        '
        '
        Me.TXT_Abonn.Border.Class = "TextBoxBorder"
        Me.TXT_Abonn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_Abonn, "TXT_Abonn")
        Me.TXT_Abonn.Name = "TXT_Abonn"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX9, "LabelX9")
        Me.LabelX9.Name = "LabelX9"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX10, "LabelX10")
        Me.LabelX10.Name = "LabelX10"
        '
        'TXT_DevMosquee
        '
        '
        '
        '
        Me.TXT_DevMosquee.Border.Class = "TextBoxBorder"
        Me.TXT_DevMosquee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_DevMosquee, "TXT_DevMosquee")
        Me.TXT_DevMosquee.Name = "TXT_DevMosquee"
        '
        'TXT_Total
        '
        '
        '
        '
        Me.TXT_Total.Border.Class = "TextBoxBorder"
        Me.TXT_Total.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_Total, "TXT_Total")
        Me.TXT_Total.Name = "TXT_Total"
        Me.TXT_Total.ReadOnly = True
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX11, "LabelX11")
        Me.LabelX11.Name = "LabelX11"
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX12, "LabelX12")
        Me.LabelX12.Name = "LabelX12"
        '
        'GP_Info
        '
        Me.GP_Info.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Info.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Info.Controls.Add(Me.TXT_Nom)
        Me.GP_Info.Controls.Add(Me.TXT_NAbonn)
        Me.GP_Info.Controls.Add(Me.TXT_NCompteur)
        Me.GP_Info.Controls.Add(Me.LabelX1)
        Me.GP_Info.Controls.Add(Me.LabelX2)
        Me.GP_Info.Controls.Add(Me.LabelX3)
        resources.ApplyResources(Me.GP_Info, "GP_Info")
        Me.GP_Info.Name = "GP_Info"
        '
        '
        '
        Me.GP_Info.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Info.Style.BackColorGradientAngle = 90
        Me.GP_Info.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.GP_Info.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Info.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Info.Style.BorderBottomWidth = 1
        Me.GP_Info.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Info.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Info.Style.BorderLeftWidth = 1
        Me.GP_Info.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Info.Style.BorderRightWidth = 1
        Me.GP_Info.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Info.Style.BorderTopWidth = 1
        Me.GP_Info.Style.Class = ""
        Me.GP_Info.Style.CornerDiameter = 4
        Me.GP_Info.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Info.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_Info.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Info.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Info.StyleMouseDown.Class = ""
        Me.GP_Info.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Info.StyleMouseOver.Class = ""
        Me.GP_Info.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'GP_Index
        '
        Me.GP_Index.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Index.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Index.Controls.Add(Me.TXT_IndexPreced)
        Me.GP_Index.Controls.Add(Me.TXT_IndexPresent)
        Me.GP_Index.Controls.Add(Me.LabelX5)
        Me.GP_Index.Controls.Add(Me.LabelX6)
        resources.ApplyResources(Me.GP_Index, "GP_Index")
        Me.GP_Index.Name = "GP_Index"
        '
        '
        '
        Me.GP_Index.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Index.Style.BackColorGradientAngle = 90
        Me.GP_Index.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
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
        '
        'GP_Consomm
        '
        Me.GP_Consomm.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Consomm.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Consomm.Controls.Add(Me.BTN_PrixConsommation)
        Me.GP_Consomm.Controls.Add(Me.TXT_ConsomM3)
        Me.GP_Consomm.Controls.Add(Me.LabelX7)
        Me.GP_Consomm.Controls.Add(Me.TXT_Prix)
        Me.GP_Consomm.Controls.Add(Me.LabelX8)
        Me.GP_Consomm.Controls.Add(Me.TXT_PrixConsomm)
        Me.GP_Consomm.Controls.Add(Me.LabelX9)
        resources.ApplyResources(Me.GP_Consomm, "GP_Consomm")
        Me.GP_Consomm.Name = "GP_Consomm"
        '
        '
        '
        Me.GP_Consomm.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Consomm.Style.BackColorGradientAngle = 90
        Me.GP_Consomm.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.GP_Consomm.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Consomm.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Consomm.Style.BorderBottomWidth = 1
        Me.GP_Consomm.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Consomm.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Consomm.Style.BorderLeftWidth = 1
        Me.GP_Consomm.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Consomm.Style.BorderRightWidth = 1
        Me.GP_Consomm.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Consomm.Style.BorderTopWidth = 1
        Me.GP_Consomm.Style.Class = ""
        Me.GP_Consomm.Style.CornerDiameter = 4
        Me.GP_Consomm.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Consomm.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_Consomm.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Consomm.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Consomm.StyleMouseDown.Class = ""
        Me.GP_Consomm.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Consomm.StyleMouseOver.Class = ""
        Me.GP_Consomm.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'BTN_PrixConsommation
        '
        Me.BTN_PrixConsommation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_PrixConsommation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.BTN_PrixConsommation, "BTN_PrixConsommation")
        Me.BTN_PrixConsommation.Name = "BTN_PrixConsommation"
        Me.BTN_PrixConsommation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'GP_DureeConsomm
        '
        Me.GP_DureeConsomm.BackColor = System.Drawing.Color.Transparent
        Me.GP_DureeConsomm.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_DureeConsomm.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_DureeConsomm.Controls.Add(Me.TXT_Annee)
        Me.GP_DureeConsomm.Controls.Add(Me.TXT_Mois)
        Me.GP_DureeConsomm.Controls.Add(Me.LabelX13)
        Me.GP_DureeConsomm.Controls.Add(Me.LabelX4)
        resources.ApplyResources(Me.GP_DureeConsomm, "GP_DureeConsomm")
        Me.GP_DureeConsomm.Name = "GP_DureeConsomm"
        '
        '
        '
        Me.GP_DureeConsomm.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_DureeConsomm.Style.BackColorGradientAngle = 90
        Me.GP_DureeConsomm.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.GP_DureeConsomm.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_DureeConsomm.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_DureeConsomm.Style.BorderBottomWidth = 1
        Me.GP_DureeConsomm.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_DureeConsomm.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_DureeConsomm.Style.BorderLeftWidth = 1
        Me.GP_DureeConsomm.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_DureeConsomm.Style.BorderRightWidth = 1
        Me.GP_DureeConsomm.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_DureeConsomm.Style.BorderTopWidth = 1
        Me.GP_DureeConsomm.Style.Class = ""
        Me.GP_DureeConsomm.Style.CornerDiameter = 4
        Me.GP_DureeConsomm.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_DureeConsomm.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_DureeConsomm.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_DureeConsomm.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_DureeConsomm.StyleMouseDown.Class = ""
        Me.GP_DureeConsomm.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_DureeConsomm.StyleMouseOver.Class = ""
        Me.GP_DureeConsomm.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'TXT_Annee
        '
        '
        '
        '
        Me.TXT_Annee.Border.Class = "TextBoxBorder"
        Me.TXT_Annee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_Annee, "TXT_Annee")
        Me.TXT_Annee.Name = "TXT_Annee"
        '
        'TXT_Mois
        '
        '
        '
        '
        Me.TXT_Mois.Border.Class = "TextBoxBorder"
        Me.TXT_Mois.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.TXT_Mois, "TXT_Mois")
        Me.TXT_Mois.Name = "TXT_Mois"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.Class = ""
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX13, "LabelX13")
        Me.LabelX13.Name = "LabelX13"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.Name = "LabelX4"
        '
        'GP_Autres
        '
        Me.GP_Autres.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Autres.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Autres.Controls.Add(Me.TXT_Abonn)
        Me.GP_Autres.Controls.Add(Me.LabelX10)
        Me.GP_Autres.Controls.Add(Me.TXT_DevMosquee)
        Me.GP_Autres.Controls.Add(Me.LabelX11)
        resources.ApplyResources(Me.GP_Autres, "GP_Autres")
        Me.GP_Autres.Name = "GP_Autres"
        '
        '
        '
        Me.GP_Autres.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Autres.Style.BackColorGradientAngle = 90
        Me.GP_Autres.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.GP_Autres.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Autres.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Autres.Style.BorderBottomWidth = 1
        Me.GP_Autres.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Autres.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Autres.Style.BorderLeftWidth = 1
        Me.GP_Autres.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Autres.Style.BorderRightWidth = 1
        Me.GP_Autres.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Autres.Style.BorderTopWidth = 1
        Me.GP_Autres.Style.Class = ""
        Me.GP_Autres.Style.CornerDiameter = 4
        Me.GP_Autres.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Autres.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_Autres.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Autres.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Autres.StyleMouseDown.Class = ""
        Me.GP_Autres.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Autres.StyleMouseOver.Class = ""
        Me.GP_Autres.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'GP_Total
        '
        Me.GP_Total.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Total.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Total.Controls.Add(Me.BTN_PrixTotal)
        Me.GP_Total.Controls.Add(Me.TXT_Total)
        Me.GP_Total.Controls.Add(Me.LabelX12)
        resources.ApplyResources(Me.GP_Total, "GP_Total")
        Me.GP_Total.Name = "GP_Total"
        '
        '
        '
        Me.GP_Total.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Total.Style.BackColorGradientAngle = 90
        Me.GP_Total.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.GP_Total.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Total.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Total.Style.BorderBottomWidth = 1
        Me.GP_Total.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Total.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Total.Style.BorderLeftWidth = 1
        Me.GP_Total.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Total.Style.BorderRightWidth = 1
        Me.GP_Total.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Total.Style.BorderTopWidth = 1
        Me.GP_Total.Style.Class = ""
        Me.GP_Total.Style.CornerDiameter = 4
        Me.GP_Total.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Total.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GP_Total.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Total.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Total.StyleMouseDown.Class = ""
        Me.GP_Total.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Total.StyleMouseOver.Class = ""
        Me.GP_Total.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'BTN_PrixTotal
        '
        Me.BTN_PrixTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_PrixTotal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.BTN_PrixTotal, "BTN_PrixTotal")
        Me.BTN_PrixTotal.Name = "BTN_PrixTotal"
        Me.BTN_PrixTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        '
        'Bar1
        '
        resources.ApplyResources(Me.Bar1, "Bar1")
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LBI_DateEtHeure})
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabStop = False
        '
        'LBI_DateEtHeure
        '
        Me.LBI_DateEtHeure.Name = "LBI_DateEtHeure"
        resources.ApplyResources(Me.LBI_DateEtHeure, "LBI_DateEtHeure")
        Me.LBI_DateEtHeure.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TM_HeureEtDate
        '
        Me.TM_HeureEtDate.Enabled = True
        Me.TM_HeureEtDate.Interval = 1
        '
        'TM_Verification
        '
        Me.TM_Verification.Enabled = True
        '
        'BTN_Options
        '
        Me.BTN_Options.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Options.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Options.Image = Global.AssociationTamgounssi.My.Resources.Resources.google_webmaster_tools
        Me.BTN_Options.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        resources.ApplyResources(Me.BTN_Options, "BTN_Options")
        Me.BTN_Options.Name = "BTN_Options"
        Me.BTN_Options.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'BTN_Initialiser
        '
        Me.BTN_Initialiser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Initialiser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTN_Initialiser.Image = Global.AssociationTamgounssi.My.Resources.Resources.update
        Me.BTN_Initialiser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        resources.ApplyResources(Me.BTN_Initialiser, "BTN_Initialiser")
        Me.BTN_Initialiser.Name = "BTN_Initialiser"
        Me.BTN_Initialiser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'BTN_Apercu
        '
        Me.BTN_Apercu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTN_Apercu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.BTN_Apercu, "BTN_Apercu")
        Me.BTN_Apercu.Image = Global.AssociationTamgounssi.My.Resources.Resources.slideshow
        Me.BTN_Apercu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BTN_Apercu.Name = "BTN_Apercu"
        Me.BTN_Apercu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'HG_Light
        '
        Me.HG_Light.ContainerControl = Me
        resources.ApplyResources(Me.HG_Light, "HG_Light")
        '
        'Main_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Controls.Add(Me.BTN_Options)
        Me.Controls.Add(Me.BTN_Initialiser)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTN_Apercu)
        Me.Controls.Add(Me.GP_Total)
        Me.Controls.Add(Me.GP_DureeConsomm)
        Me.Controls.Add(Me.GP_Autres)
        Me.Controls.Add(Me.GP_Consomm)
        Me.Controls.Add(Me.GP_Index)
        Me.Controls.Add(Me.GP_Info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.GP_Info.ResumeLayout(False)
        Me.GP_Index.ResumeLayout(False)
        Me.GP_Consomm.ResumeLayout(False)
        Me.GP_DureeConsomm.ResumeLayout(False)
        Me.GP_Autres.ResumeLayout(False)
        Me.GP_Total.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_Nom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_NAbonn As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_NCompteur As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_IndexPreced As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_IndexPresent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_ConsomM3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_Prix As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_PrixConsomm As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_Abonn As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TXT_DevMosquee As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_Total As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GP_Info As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GP_Index As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GP_Consomm As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GP_DureeConsomm As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TXT_Annee As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TXT_Mois As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GP_Autres As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GP_Total As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BTN_PrixConsommation As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_PrixTotal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_Apercu As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents LBI_DateEtHeure As DevComponents.DotNetBar.LabelItem
    Friend WithEvents BTN_Initialiser As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BTN_Options As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TM_HeureEtDate As System.Windows.Forms.Timer
    Friend WithEvents TM_Verification As System.Windows.Forms.Timer
    Friend WithEvents HG_Light As DevComponents.DotNetBar.Validator.Highlighter

End Class

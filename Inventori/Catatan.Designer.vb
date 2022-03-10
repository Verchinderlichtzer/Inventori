<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catatan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catatan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.PanelTotalTransaksi = New Krypton.Toolkit.KryptonGroup()
        Me.LBLTransaksiFile = New Krypton.Toolkit.KryptonLabel()
        Me.LBLCustomer = New Krypton.Toolkit.KryptonLabel()
        Me.LBLSupplier = New Krypton.Toolkit.KryptonLabel()
        Me.LBLBarang = New Krypton.Toolkit.KryptonLabel()
        Me.TCustomer = New Krypton.Toolkit.KryptonComboBox()
        Me.TSupplier = New Krypton.Toolkit.KryptonComboBox()
        Me.TBarang = New Krypton.Toolkit.KryptonComboBox()
        Me.TDari = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.CBMasuk = New Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CBPeriodik = New Krypton.Toolkit.KryptonCheckBox()
        Me.TSampai = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.LBLSampai = New Krypton.Toolkit.KryptonLabel()
        Me.LBLDari = New Krypton.Toolkit.KryptonLabel()
        Me.PemisahV = New Krypton.Toolkit.KryptonBorderEdge()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLStatus = New Krypton.Toolkit.KryptonLabel()
        Me.CBBelum = New Krypton.Toolkit.KryptonCheckBox()
        Me.CBSudah = New Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLJenis = New Krypton.Toolkit.KryptonLabel()
        Me.CBKeluar = New Krypton.Toolkit.KryptonCheckBox()
        Me.PemisahH = New Krypton.Toolkit.KryptonBorderEdge()
        Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.LBLFilter = New Krypton.Toolkit.KryptonLabel()
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        CType(Me.PanelTotalTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTotalTransaksi.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotalTransaksi.Panel.SuspendLayout()
        Me.PanelTotalTransaksi.SuspendLayout()
        CType(Me.TCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaletSekunder
        '
        Me.PaletSekunder.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletSekunder.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.Common = CType(resources.GetObject("resource.Common"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled1"), System.Drawing.Image)
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'PanelTotalTransaksi
        '
        Me.PanelTotalTransaksi.Location = New System.Drawing.Point(8, 8)
        Me.PanelTotalTransaksi.Name = "PanelTotalTransaksi"
        Me.PanelTotalTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelTotalTransaksi.Panel
        '
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.LBLTransaksiFile)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.LBLCustomer)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.LBLSupplier)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.LBLBarang)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.TCustomer)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.TSupplier)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.TBarang)
        Me.PanelTotalTransaksi.Size = New System.Drawing.Size(545, 130)
        Me.PanelTotalTransaksi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelTotalTransaksi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelTotalTransaksi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelTotalTransaksi.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelTotalTransaksi.StateCommon.Border.Width = 3
        Me.PanelTotalTransaksi.TabIndex = 114
        '
        'LBLTransaksiFile
        '
        Me.LBLTransaksiFile.AutoSize = False
        Me.LBLTransaksiFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLTransaksiFile.Location = New System.Drawing.Point(0, 0)
        Me.LBLTransaksiFile.Name = "LBLTransaksiFile"
        Me.LBLTransaksiFile.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTransaksiFile.Size = New System.Drawing.Size(539, 28)
        Me.LBLTransaksiFile.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 2, -1, -1)
        Me.LBLTransaksiFile.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTransaksiFile.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTransaksiFile.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTransaksiFile.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTransaksiFile.TabIndex = 13
        Me.LBLTransaksiFile.Values.Text = "Transaksi → Barang, Supplier, Customer"
        '
        'LBLCustomer
        '
        Me.LBLCustomer.AutoSize = False
        Me.LBLCustomer.Location = New System.Drawing.Point(3, 95)
        Me.LBLCustomer.Name = "LBLCustomer"
        Me.LBLCustomer.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLCustomer.Size = New System.Drawing.Size(98, 26)
        Me.LBLCustomer.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLCustomer.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLCustomer.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLCustomer.TabIndex = 13
        Me.LBLCustomer.Values.Text = "Customer"
        '
        'LBLSupplier
        '
        Me.LBLSupplier.AutoSize = False
        Me.LBLSupplier.Location = New System.Drawing.Point(3, 63)
        Me.LBLSupplier.Name = "LBLSupplier"
        Me.LBLSupplier.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLSupplier.Size = New System.Drawing.Size(98, 26)
        Me.LBLSupplier.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSupplier.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSupplier.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSupplier.TabIndex = 13
        Me.LBLSupplier.Values.Text = "Supplier"
        '
        'LBLBarang
        '
        Me.LBLBarang.AutoSize = False
        Me.LBLBarang.Location = New System.Drawing.Point(3, 31)
        Me.LBLBarang.Name = "LBLBarang"
        Me.LBLBarang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLBarang.Size = New System.Drawing.Size(98, 26)
        Me.LBLBarang.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBarang.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBarang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBarang.TabIndex = 13
        Me.LBLBarang.Values.Text = "Barang"
        '
        'TCustomer
        '
        Me.TCustomer.AlwaysActive = False
        Me.TCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TCustomer.DropDownHeight = 500
        Me.TCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TCustomer.DropDownWidth = 119
        Me.TCustomer.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TCustomer.IntegralHeight = False
        Me.TCustomer.Location = New System.Drawing.Point(107, 95)
        Me.TCustomer.MaxDropDownItems = 20
        Me.TCustomer.Name = "TCustomer"
        Me.TCustomer.Palette = Me.PaletSekunder
        Me.TCustomer.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TCustomer.Size = New System.Drawing.Size(429, 26)
        Me.TCustomer.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TCustomer.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TCustomer.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCustomer.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TCustomer.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TCustomer.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TCustomer.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TCustomer.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TCustomer.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TCustomer.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TCustomer.TabIndex = 2
        '
        'TSupplier
        '
        Me.TSupplier.AlwaysActive = False
        Me.TSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TSupplier.DropDownHeight = 500
        Me.TSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TSupplier.DropDownWidth = 119
        Me.TSupplier.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TSupplier.IntegralHeight = False
        Me.TSupplier.Location = New System.Drawing.Point(107, 63)
        Me.TSupplier.MaxDropDownItems = 20
        Me.TSupplier.Name = "TSupplier"
        Me.TSupplier.Palette = Me.PaletSekunder
        Me.TSupplier.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSupplier.Size = New System.Drawing.Size(429, 26)
        Me.TSupplier.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TSupplier.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSupplier.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSupplier.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TSupplier.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TSupplier.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TSupplier.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSupplier.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TSupplier.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TSupplier.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TSupplier.TabIndex = 1
        '
        'TBarang
        '
        Me.TBarang.AlwaysActive = False
        Me.TBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TBarang.DropDownHeight = 500
        Me.TBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TBarang.DropDownWidth = 119
        Me.TBarang.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TBarang.IntegralHeight = False
        Me.TBarang.Location = New System.Drawing.Point(107, 31)
        Me.TBarang.MaxDropDownItems = 20
        Me.TBarang.Name = "TBarang"
        Me.TBarang.Palette = Me.PaletSekunder
        Me.TBarang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TBarang.Size = New System.Drawing.Size(429, 26)
        Me.TBarang.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TBarang.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBarang.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBarang.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TBarang.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TBarang.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TBarang.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBarang.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TBarang.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TBarang.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TBarang.TabIndex = 0
        '
        'TDari
        '
        Me.TDari.AlwaysActive = False
        Me.TDari.CustomFormat = "dd/MM/yyyy"
        Me.TDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TDari.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TDari.Location = New System.Drawing.Point(87, 32)
        Me.TDari.Name = "TDari"
        Me.TDari.Palette = Me.PaletSekunder
        Me.TDari.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TDari.Size = New System.Drawing.Size(101, 26)
        Me.TDari.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TDari.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDari.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TDari.TabIndex = 0
        Me.TDari.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'CBMasuk
        '
        Me.CBMasuk.Location = New System.Drawing.Point(7, 32)
        Me.CBMasuk.Name = "CBMasuk"
        Me.CBMasuk.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBMasuk.Palette = Me.PaletSekunder
        Me.CBMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBMasuk.Size = New System.Drawing.Size(79, 26)
        Me.CBMasuk.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBMasuk.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBMasuk.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBMasuk.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBMasuk.TabIndex = 0
        Me.CBMasuk.Values.Text = "Masuk"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(558, 8)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        Me.KryptonGroup1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.PemisahV)
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.PemisahH)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup1.Size = New System.Drawing.Size(545, 130)
        Me.KryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.KryptonGroup1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonGroup1.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup1.StateCommon.Border.Width = 3
        Me.KryptonGroup1.TabIndex = 116
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CBPeriodik)
        Me.Panel3.Controls.Add(Me.TDari)
        Me.Panel3.Controls.Add(Me.TSampai)
        Me.Panel3.Controls.Add(Me.LBLSampai)
        Me.Panel3.Controls.Add(Me.LBLDari)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(173, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 93)
        Me.Panel3.TabIndex = 18
        '
        'CBPeriodik
        '
        Me.CBPeriodik.Location = New System.Drawing.Point(45, 3)
        Me.CBPeriodik.Name = "CBPeriodik"
        Me.CBPeriodik.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBPeriodik.Palette = Me.PaletSekunder
        Me.CBPeriodik.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBPeriodik.Size = New System.Drawing.Size(97, 26)
        Me.CBPeriodik.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBPeriodik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBPeriodik.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBPeriodik.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBPeriodik.TabIndex = 3
        Me.CBPeriodik.Values.Text = "Periodik"
        '
        'TSampai
        '
        Me.TSampai.AlwaysActive = False
        Me.TSampai.CustomFormat = "dd/MM/yyyy"
        Me.TSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TSampai.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TSampai.Location = New System.Drawing.Point(87, 64)
        Me.TSampai.Name = "TSampai"
        Me.TSampai.Palette = Me.PaletSekunder
        Me.TSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSampai.Size = New System.Drawing.Size(101, 26)
        Me.TSampai.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TSampai.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSampai.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TSampai.TabIndex = 1
        Me.TSampai.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'LBLSampai
        '
        Me.LBLSampai.AutoSize = False
        Me.LBLSampai.Location = New System.Drawing.Point(3, 64)
        Me.LBLSampai.Name = "LBLSampai"
        Me.LBLSampai.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLSampai.Size = New System.Drawing.Size(70, 26)
        Me.LBLSampai.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSampai.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSampai.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSampai.TabIndex = 13
        Me.LBLSampai.Values.Text = "Sampai"
        '
        'LBLDari
        '
        Me.LBLDari.AutoSize = False
        Me.LBLDari.Location = New System.Drawing.Point(3, 32)
        Me.LBLDari.Name = "LBLDari"
        Me.LBLDari.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLDari.Size = New System.Drawing.Size(70, 26)
        Me.LBLDari.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLDari.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLDari.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLDari.TabIndex = 13
        Me.LBLDari.Values.Text = "Dari"
        '
        'PemisahV
        '
        Me.PemisahV.Dock = System.Windows.Forms.DockStyle.Right
        Me.PemisahV.Location = New System.Drawing.Point(366, 31)
        Me.PemisahV.Name = "PemisahV"
        Me.PemisahV.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PemisahV.Size = New System.Drawing.Size(3, 93)
        Me.PemisahV.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PemisahV.StateCommon.Width = 3
        Me.PemisahV.Text = "KryptonBorderEdge4"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LBLStatus)
        Me.Panel2.Controls.Add(Me.CBBelum)
        Me.Panel2.Controls.Add(Me.CBSudah)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(369, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 93)
        Me.Panel2.TabIndex = 15
        '
        'LBLStatus
        '
        Me.LBLStatus.AutoSize = False
        Me.LBLStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLStatus.Location = New System.Drawing.Point(0, 0)
        Me.LBLStatus.Name = "LBLStatus"
        Me.LBLStatus.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLStatus.Size = New System.Drawing.Size(170, 26)
        Me.LBLStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLStatus.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLStatus.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLStatus.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLStatus.TabIndex = 13
        Me.LBLStatus.Values.Text = "Status"
        '
        'CBBelum
        '
        Me.CBBelum.Location = New System.Drawing.Point(6, 64)
        Me.CBBelum.Name = "CBBelum"
        Me.CBBelum.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBBelum.Palette = Me.PaletSekunder
        Me.CBBelum.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBBelum.Size = New System.Drawing.Size(132, 26)
        Me.CBBelum.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBBelum.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBelum.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBBelum.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBBelum.TabIndex = 1
        Me.CBBelum.Values.Text = "Belum Lunas"
        '
        'CBSudah
        '
        Me.CBSudah.Location = New System.Drawing.Point(6, 32)
        Me.CBSudah.Name = "CBSudah"
        Me.CBSudah.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBSudah.Palette = Me.PaletSekunder
        Me.CBSudah.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBSudah.Size = New System.Drawing.Size(130, 26)
        Me.CBSudah.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBSudah.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBSudah.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBSudah.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBSudah.TabIndex = 0
        Me.CBSudah.Values.Text = "Sudah Lunas"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(170, 31)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(3, 93)
        Me.KryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonBorderEdge1.StateCommon.Width = 3
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge4"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLJenis)
        Me.Panel1.Controls.Add(Me.CBKeluar)
        Me.Panel1.Controls.Add(Me.CBMasuk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 93)
        Me.Panel1.TabIndex = 14
        '
        'LBLJenis
        '
        Me.LBLJenis.AutoSize = False
        Me.LBLJenis.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLJenis.Location = New System.Drawing.Point(0, 0)
        Me.LBLJenis.Name = "LBLJenis"
        Me.LBLJenis.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLJenis.Size = New System.Drawing.Size(170, 26)
        Me.LBLJenis.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLJenis.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLJenis.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLJenis.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLJenis.TabIndex = 13
        Me.LBLJenis.Values.Text = "Jenis"
        '
        'CBKeluar
        '
        Me.CBKeluar.Location = New System.Drawing.Point(7, 64)
        Me.CBKeluar.Name = "CBKeluar"
        Me.CBKeluar.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBKeluar.Palette = Me.PaletSekunder
        Me.CBKeluar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBKeluar.Size = New System.Drawing.Size(82, 26)
        Me.CBKeluar.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBKeluar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBKeluar.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBKeluar.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBKeluar.TabIndex = 1
        Me.CBKeluar.Values.Text = "Keluar"
        '
        'PemisahH
        '
        Me.PemisahH.Dock = System.Windows.Forms.DockStyle.Top
        Me.PemisahH.Location = New System.Drawing.Point(0, 28)
        Me.PemisahH.Name = "PemisahH"
        Me.PemisahH.Size = New System.Drawing.Size(539, 3)
        Me.PemisahH.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PemisahH.StateCommon.Width = 3
        Me.PemisahH.Text = "KryptonBorderEdge1"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.AutoSize = False
        Me.KryptonLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.KryptonLabel3.Size = New System.Drawing.Size(539, 28)
        Me.KryptonLabel3.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 2, -1, -1)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel3.TabIndex = 13
        Me.KryptonLabel3.Values.Text = "Transaksi"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 176)
        Me.DGV.Name = "DGV"
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(1095, 405)
        Me.DGV.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGV.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGV.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGV.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGV.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGV.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGV.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DGV.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGV.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGV.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DGV.TabIndex = 129
        '
        'LBLFilter
        '
        Me.LBLFilter.AutoSize = False
        Me.LBLFilter.Location = New System.Drawing.Point(11, 144)
        Me.LBLFilter.Name = "LBLFilter"
        Me.LBLFilter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLFilter.Size = New System.Drawing.Size(1092, 26)
        Me.LBLFilter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFilter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFilter.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLFilter.TabIndex = 13
        Me.LBLFilter.Values.Text = "-"
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AlwaysActive = False
        Me.DGVPageCounter.Enabled = False
        Me.DGVPageCounter.Location = New System.Drawing.Point(510, 587)
        Me.DGVPageCounter.MaxLength = 255
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPageCounter.TabIndex = 166
        Me.DGVPageCounter.Tag = ""
        Me.DGVPageCounter.Text = "1 / 1"
        Me.DGVPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(478, 587)
        Me.DGVPrev.Name = "DGVPrev"
        Me.DGVPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVPrev.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPrev.Size = New System.Drawing.Size(26, 26)
        Me.DGVPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.DGVPrev.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPrev.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DGVPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVPrev.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVPrev.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVPrev.TabIndex = 164
        Me.DGVPrev.Values.Text = "◄"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(606, 587)
        Me.DGVNext.Name = "DGVNext"
        Me.DGVNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVNext.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVNext.Size = New System.Drawing.Size(26, 26)
        Me.DGVNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.DGVNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVNext.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DGVNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVNext.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVNext.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVNext.TabIndex = 165
        Me.DGVNext.Values.Text = "►"
        '
        'Catatan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.LBLFilter)
        Me.Controls.Add(Me.KryptonGroup1)
        Me.Controls.Add(Me.PanelTotalTransaksi)
        Me.Name = "Catatan"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1111, 638)
        CType(Me.PanelTotalTransaksi.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalTransaksi.Panel.ResumeLayout(False)
        CType(Me.PanelTotalTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalTransaksi.ResumeLayout(False)
        CType(Me.TCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents PanelTotalTransaksi As Krypton.Toolkit.KryptonGroup
    Friend WithEvents LBLTransaksiFile As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLCustomer As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLSupplier As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLBarang As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TCustomer As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TSupplier As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TBarang As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TDari As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents CBMasuk As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLSampai As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLDari As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLJenis As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PemisahH As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents LBLStatus As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TSampai As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents CBBelum As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents CBKeluar As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents CBSudah As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents CBPeriodik As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PemisahV As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLFilter As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
End Class

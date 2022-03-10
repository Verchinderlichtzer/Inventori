<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laporan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.RBBatang = New Krypton.Toolkit.KryptonRadioButton()
        Me.RBGaris = New Krypton.Toolkit.KryptonRadioButton()
        Me.RBKurva = New Krypton.Toolkit.KryptonRadioButton()
        Me.CBLain = New Krypton.Toolkit.KryptonCheckBox()
        Me.CBKeluar = New Krypton.Toolkit.KryptonCheckBox()
        Me.CBTransaksi = New Krypton.Toolkit.KryptonCheckBox()
        Me.CBMasuk = New Krypton.Toolkit.KryptonCheckBox()
        Me.LBLGrafik = New Krypton.Toolkit.KryptonLabel()
        Me.LBLLabaRugi = New Krypton.Toolkit.KryptonLabel()
        Me.LBLTransaksi = New Krypton.Toolkit.KryptonLabel()
        Me.PanelLapor = New Krypton.Toolkit.KryptonGroup()
        Me.LBLFilter = New Krypton.Toolkit.KryptonLabel()
        Me.PanelTotalTransaksi = New Krypton.Toolkit.KryptonGroup()
        Me.PanelTengah = New System.Windows.Forms.Panel()
        Me.PanelTahun = New System.Windows.Forms.Panel()
        Me.TTahunan = New Krypton.Toolkit.KryptonComboBox()
        Me.LBLTahunan = New Krypton.Toolkit.KryptonLabel()
        Me.Pemisah7 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelBulanan = New System.Windows.Forms.Panel()
        Me.LBLBulanan = New Krypton.Toolkit.KryptonLabel()
        Me.TBulanan = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.Pemisah6 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelPeriodik = New System.Windows.Forms.Panel()
        Me.LBLPeriodik = New Krypton.Toolkit.KryptonLabel()
        Me.LBLSampai = New Krypton.Toolkit.KryptonLabel()
        Me.TSampai = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.TDari = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.PanelKanan = New System.Windows.Forms.Panel()
        Me.TEntitas = New Krypton.Toolkit.KryptonComboBox()
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.LBLEntitas = New Krypton.Toolkit.KryptonLabel()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.Pemisah2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelKiri = New System.Windows.Forms.Panel()
        Me.PanelGrafik = New System.Windows.Forms.Panel()
        Me.Pemisah5 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelLabaRugi = New System.Windows.Forms.Panel()
        Me.Pemisah4 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelTransaksi = New System.Windows.Forms.Panel()
        Me.Pemisah3 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.PanelFile = New System.Windows.Forms.Panel()
        Me.LBLFile = New Krypton.Toolkit.KryptonLabel()
        Me.RBBarang = New Krypton.Toolkit.KryptonRadioButton()
        Me.RBSupplier = New Krypton.Toolkit.KryptonRadioButton()
        Me.RBCustomer = New Krypton.Toolkit.KryptonRadioButton()
        Me.Pemisah1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.BTNLapor = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.Dev = New Inventori.Dev()
        Me.TBLBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBarangTableAdapter = New Inventori.DevTableAdapters.TBLBarangTableAdapter()
        Me.TBLSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLSupplierTableAdapter = New Inventori.DevTableAdapters.TBLSupplierTableAdapter()
        Me.TBLCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLCustomerTableAdapter = New Inventori.DevTableAdapters.TBLCustomerTableAdapter()
        Me.TBLPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPembelianTableAdapter = New Inventori.DevTableAdapters.TBLPembelianTableAdapter()
        Me.TBLPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPenjualanTableAdapter = New Inventori.DevTableAdapters.TBLPenjualanTableAdapter()
        Me.TBLLabaRugiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLLabaRugiTableAdapter = New Inventori.DevTableAdapters.TBLLabaRugiTableAdapter()
        Me.TBLTransaksiBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLTransaksiBarangTableAdapter = New Inventori.DevTableAdapters.TBLTransaksiBarangTableAdapter()
        Me.TBLTransaksiCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLTransaksiCustomerTableAdapter = New Inventori.DevTableAdapters.TBLTransaksiCustomerTableAdapter()
        Me.TBLTransaksiSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLTransaksiSupplierTableAdapter = New Inventori.DevTableAdapters.TBLTransaksiSupplierTableAdapter()
        Me.TBLGrafikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLGrafikTableAdapter = New Inventori.DevTableAdapters.TBLGrafikTableAdapter()
        Me.TBLTransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLTransaksiTableAdapter = New Inventori.DevTableAdapters.TBLTransaksiTableAdapter()
        CType(Me.PanelLapor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelLapor.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLapor.Panel.SuspendLayout()
        Me.PanelLapor.SuspendLayout()
        CType(Me.PanelTotalTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTotalTransaksi.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotalTransaksi.Panel.SuspendLayout()
        Me.PanelTotalTransaksi.SuspendLayout()
        Me.PanelTengah.SuspendLayout()
        Me.PanelTahun.SuspendLayout()
        CType(Me.TTahunan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBulanan.SuspendLayout()
        Me.PanelPeriodik.SuspendLayout()
        Me.PanelKanan.SuspendLayout()
        CType(Me.TEntitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelKiri.SuspendLayout()
        Me.PanelGrafik.SuspendLayout()
        Me.PanelLabaRugi.SuspendLayout()
        Me.PanelTransaksi.SuspendLayout()
        Me.PanelFile.SuspendLayout()
        CType(Me.Dev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLLabaRugiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLTransaksiBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLTransaksiCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLTransaksiSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLGrafikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLTransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PaletSekunder.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
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
        '
        'RBBatang
        '
        Me.RBBatang.Location = New System.Drawing.Point(16, 29)
        Me.RBBatang.Name = "RBBatang"
        Me.RBBatang.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBBatang.Palette = Me.PaletSekunder
        Me.RBBatang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBBatang.Size = New System.Drawing.Size(81, 26)
        Me.RBBatang.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBBatang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBBatang.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBBatang.TabIndex = 83
        Me.RBBatang.Values.Text = "Batang"
        '
        'RBGaris
        '
        Me.RBGaris.Location = New System.Drawing.Point(16, 60)
        Me.RBGaris.Name = "RBGaris"
        Me.RBGaris.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBGaris.Palette = Me.PaletSekunder
        Me.RBGaris.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBGaris.Size = New System.Drawing.Size(68, 26)
        Me.RBGaris.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBGaris.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBGaris.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBGaris.TabIndex = 83
        Me.RBGaris.Values.Text = "Garis"
        '
        'RBKurva
        '
        Me.RBKurva.Location = New System.Drawing.Point(16, 91)
        Me.RBKurva.Name = "RBKurva"
        Me.RBKurva.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBKurva.Palette = Me.PaletSekunder
        Me.RBKurva.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBKurva.Size = New System.Drawing.Size(72, 26)
        Me.RBKurva.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBKurva.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBKurva.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBKurva.TabIndex = 83
        Me.RBKurva.Values.Text = "Kurva"
        '
        'CBLain
        '
        Me.CBLain.Location = New System.Drawing.Point(16, 73)
        Me.CBLain.Name = "CBLain"
        Me.CBLain.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBLain.Palette = Me.PaletSekunder
        Me.CBLain.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBLain.Size = New System.Drawing.Size(267, 26)
        Me.CBLain.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBLain.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLain.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.CBLain.TabIndex = 24
        Me.CBLain.Values.Text = "Pengeluaran / Pendapatan Lain"
        '
        'CBKeluar
        '
        Me.CBKeluar.Location = New System.Drawing.Point(16, 73)
        Me.CBKeluar.Name = "CBKeluar"
        Me.CBKeluar.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBKeluar.Palette = Me.PaletSekunder
        Me.CBKeluar.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBKeluar.Size = New System.Drawing.Size(78, 26)
        Me.CBKeluar.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBKeluar.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBKeluar.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.CBKeluar.TabIndex = 24
        Me.CBKeluar.Values.Text = "Keluar"
        '
        'CBTransaksi
        '
        Me.CBTransaksi.Location = New System.Drawing.Point(16, 41)
        Me.CBTransaksi.Name = "CBTransaksi"
        Me.CBTransaksi.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTransaksi.Palette = Me.PaletSekunder
        Me.CBTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBTransaksi.Size = New System.Drawing.Size(176, 26)
        Me.CBTransaksi.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTransaksi.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.CBTransaksi.TabIndex = 24
        Me.CBTransaksi.Values.Text = "Pembayaran Faktur"
        '
        'CBMasuk
        '
        Me.CBMasuk.Location = New System.Drawing.Point(16, 41)
        Me.CBMasuk.Name = "CBMasuk"
        Me.CBMasuk.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBMasuk.Palette = Me.PaletSekunder
        Me.CBMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBMasuk.Size = New System.Drawing.Size(75, 26)
        Me.CBMasuk.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBMasuk.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMasuk.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.CBMasuk.TabIndex = 24
        Me.CBMasuk.Values.Text = "Masuk"
        '
        'LBLGrafik
        '
        Me.LBLGrafik.AutoSize = False
        Me.LBLGrafik.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLGrafik.Location = New System.Drawing.Point(0, 0)
        Me.LBLGrafik.Name = "LBLGrafik"
        Me.LBLGrafik.Size = New System.Drawing.Size(397, 26)
        Me.LBLGrafik.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLGrafik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLGrafik.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLGrafik.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLGrafik.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLGrafik.TabIndex = 82
        Me.LBLGrafik.Values.Text = "Grafik (Tahunan)"
        '
        'LBLLabaRugi
        '
        Me.LBLLabaRugi.AutoSize = False
        Me.LBLLabaRugi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLLabaRugi.Location = New System.Drawing.Point(0, 0)
        Me.LBLLabaRugi.Name = "LBLLabaRugi"
        Me.LBLLabaRugi.Size = New System.Drawing.Size(397, 26)
        Me.LBLLabaRugi.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLLabaRugi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLLabaRugi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLLabaRugi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLabaRugi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLLabaRugi.TabIndex = 82
        Me.LBLLabaRugi.Values.Text = "Pembayaran / Laba Rugi"
        '
        'LBLTransaksi
        '
        Me.LBLTransaksi.AutoSize = False
        Me.LBLTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.LBLTransaksi.Name = "LBLTransaksi"
        Me.LBLTransaksi.Size = New System.Drawing.Size(397, 26)
        Me.LBLTransaksi.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTransaksi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTransaksi.TabIndex = 82
        Me.LBLTransaksi.Values.Text = "Transaksi"
        '
        'PanelLapor
        '
        Me.PanelLapor.Location = New System.Drawing.Point(37, 533)
        Me.PanelLapor.Name = "PanelLapor"
        Me.PanelLapor.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelLapor.Panel
        '
        Me.PanelLapor.Panel.Controls.Add(Me.LBLFilter)
        Me.PanelLapor.Size = New System.Drawing.Size(1037, 42)
        Me.PanelLapor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelLapor.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelLapor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelLapor.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelLapor.StateCommon.Border.Rounding = 0!
        Me.PanelLapor.StateCommon.Border.Width = 3
        Me.PanelLapor.TabIndex = 84
        '
        'LBLFilter
        '
        Me.LBLFilter.AutoSize = False
        Me.LBLFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBLFilter.Location = New System.Drawing.Point(0, 0)
        Me.LBLFilter.Name = "LBLFilter"
        Me.LBLFilter.Size = New System.Drawing.Size(1031, 36)
        Me.LBLFilter.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFilter.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFilter.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFilter.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLFilter.TabIndex = 83
        Me.LBLFilter.Values.Text = ""
        '
        'PanelTotalTransaksi
        '
        Me.PanelTotalTransaksi.Location = New System.Drawing.Point(37, 32)
        Me.PanelTotalTransaksi.Name = "PanelTotalTransaksi"
        Me.PanelTotalTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelTotalTransaksi.Panel
        '
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.PanelTengah)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.PanelKanan)
        Me.PanelTotalTransaksi.Panel.Controls.Add(Me.PanelKiri)
        Me.PanelTotalTransaksi.Size = New System.Drawing.Size(1037, 495)
        Me.PanelTotalTransaksi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelTotalTransaksi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelTotalTransaksi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelTotalTransaksi.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelTotalTransaksi.StateCommon.Border.Width = 3
        Me.PanelTotalTransaksi.TabIndex = 114
        '
        'PanelTengah
        '
        Me.PanelTengah.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelTengah.Controls.Add(Me.PanelTahun)
        Me.PanelTengah.Controls.Add(Me.Pemisah7)
        Me.PanelTengah.Controls.Add(Me.PanelBulanan)
        Me.PanelTengah.Controls.Add(Me.Pemisah6)
        Me.PanelTengah.Controls.Add(Me.PanelPeriodik)
        Me.PanelTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTengah.Location = New System.Drawing.Point(400, 0)
        Me.PanelTengah.Name = "PanelTengah"
        Me.PanelTengah.Size = New System.Drawing.Size(231, 489)
        Me.PanelTengah.TabIndex = 109
        '
        'PanelTahun
        '
        Me.PanelTahun.Controls.Add(Me.TTahunan)
        Me.PanelTahun.Controls.Add(Me.LBLTahunan)
        Me.PanelTahun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTahun.Location = New System.Drawing.Point(0, 328)
        Me.PanelTahun.Name = "PanelTahun"
        Me.PanelTahun.Size = New System.Drawing.Size(231, 161)
        Me.PanelTahun.TabIndex = 105
        '
        'TTahunan
        '
        Me.TTahunan.AlwaysActive = False
        Me.TTahunan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TTahunan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TTahunan.DropDownWidth = 119
        Me.TTahunan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TTahunan.IntegralHeight = False
        Me.TTahunan.Location = New System.Drawing.Point(56, 74)
        Me.TTahunan.Name = "TTahunan"
        Me.TTahunan.Palette = Me.PaletSekunder
        Me.TTahunan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TTahunan.Size = New System.Drawing.Size(119, 26)
        Me.TTahunan.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TTahunan.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTahunan.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTahunan.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TTahunan.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TTahunan.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TTahunan.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTahunan.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TTahunan.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TTahunan.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TTahunan.TabIndex = 171
        '
        'LBLTahunan
        '
        Me.LBLTahunan.AutoSize = False
        Me.LBLTahunan.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLTahunan.Location = New System.Drawing.Point(0, 0)
        Me.LBLTahunan.Name = "LBLTahunan"
        Me.LBLTahunan.Size = New System.Drawing.Size(231, 26)
        Me.LBLTahunan.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLTahunan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTahunan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTahunan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTahunan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTahunan.TabIndex = 93
        Me.LBLTahunan.Values.Text = "Tahunan"
        '
        'Pemisah7
        '
        Me.Pemisah7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pemisah7.Location = New System.Drawing.Point(0, 325)
        Me.Pemisah7.Name = "Pemisah7"
        Me.Pemisah7.Size = New System.Drawing.Size(231, 3)
        Me.Pemisah7.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Pemisah7.StateCommon.Width = 3
        Me.Pemisah7.Text = "KryptonBorderEdge1"
        '
        'PanelBulanan
        '
        Me.PanelBulanan.Controls.Add(Me.LBLBulanan)
        Me.PanelBulanan.Controls.Add(Me.TBulanan)
        Me.PanelBulanan.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBulanan.Location = New System.Drawing.Point(0, 164)
        Me.PanelBulanan.Name = "PanelBulanan"
        Me.PanelBulanan.Size = New System.Drawing.Size(231, 161)
        Me.PanelBulanan.TabIndex = 102
        '
        'LBLBulanan
        '
        Me.LBLBulanan.AutoSize = False
        Me.LBLBulanan.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLBulanan.Location = New System.Drawing.Point(0, 0)
        Me.LBLBulanan.Name = "LBLBulanan"
        Me.LBLBulanan.Size = New System.Drawing.Size(231, 26)
        Me.LBLBulanan.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLBulanan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBulanan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBulanan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBulanan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLBulanan.TabIndex = 94
        Me.LBLBulanan.Values.Text = "Bulanan"
        '
        'TBulanan
        '
        Me.TBulanan.AlwaysActive = False
        Me.TBulanan.CustomFormat = "MMMM yyyy"
        Me.TBulanan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TBulanan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TBulanan.Location = New System.Drawing.Point(37, 67)
        Me.TBulanan.Name = "TBulanan"
        Me.TBulanan.Palette = Me.PaletSekunder
        Me.TBulanan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TBulanan.Size = New System.Drawing.Size(159, 26)
        Me.TBulanan.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBulanan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TBulanan.TabIndex = 89
        Me.TBulanan.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'Pemisah6
        '
        Me.Pemisah6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pemisah6.Location = New System.Drawing.Point(0, 161)
        Me.Pemisah6.Name = "Pemisah6"
        Me.Pemisah6.Size = New System.Drawing.Size(231, 3)
        Me.Pemisah6.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Pemisah6.StateCommon.Width = 3
        Me.Pemisah6.Text = "KryptonBorderEdge1"
        '
        'PanelPeriodik
        '
        Me.PanelPeriodik.Controls.Add(Me.LBLPeriodik)
        Me.PanelPeriodik.Controls.Add(Me.LBLSampai)
        Me.PanelPeriodik.Controls.Add(Me.TSampai)
        Me.PanelPeriodik.Controls.Add(Me.TDari)
        Me.PanelPeriodik.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPeriodik.Location = New System.Drawing.Point(0, 0)
        Me.PanelPeriodik.Name = "PanelPeriodik"
        Me.PanelPeriodik.Size = New System.Drawing.Size(231, 161)
        Me.PanelPeriodik.TabIndex = 97
        '
        'LBLPeriodik
        '
        Me.LBLPeriodik.AutoSize = False
        Me.LBLPeriodik.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLPeriodik.Location = New System.Drawing.Point(0, 0)
        Me.LBLPeriodik.Name = "LBLPeriodik"
        Me.LBLPeriodik.Size = New System.Drawing.Size(231, 26)
        Me.LBLPeriodik.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLPeriodik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPeriodik.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPeriodik.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPeriodik.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLPeriodik.TabIndex = 95
        Me.LBLPeriodik.Values.Text = "Periodik"
        '
        'LBLSampai
        '
        Me.LBLSampai.AutoSize = False
        Me.LBLSampai.Location = New System.Drawing.Point(80, 70)
        Me.LBLSampai.Name = "LBLSampai"
        Me.LBLSampai.Size = New System.Drawing.Size(71, 26)
        Me.LBLSampai.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSampai.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSampai.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSampai.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLSampai.TabIndex = 92
        Me.LBLSampai.Values.Text = "Sampai"
        '
        'TSampai
        '
        Me.TSampai.AlwaysActive = False
        Me.TSampai.CustomFormat = "dd MMMM yyyy"
        Me.TSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TSampai.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TSampai.Location = New System.Drawing.Point(36, 102)
        Me.TSampai.Name = "TSampai"
        Me.TSampai.Palette = Me.PaletSekunder
        Me.TSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSampai.Size = New System.Drawing.Size(159, 26)
        Me.TSampai.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSampai.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TSampai.TabIndex = 91
        Me.TSampai.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'TDari
        '
        Me.TDari.AlwaysActive = False
        Me.TDari.CustomFormat = "dd MMMM yyyy"
        Me.TDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TDari.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TDari.Location = New System.Drawing.Point(36, 38)
        Me.TDari.Name = "TDari"
        Me.TDari.Palette = Me.PaletSekunder
        Me.TDari.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TDari.Size = New System.Drawing.Size(159, 26)
        Me.TDari.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDari.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TDari.TabIndex = 90
        Me.TDari.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'PanelKanan
        '
        Me.PanelKanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelKanan.Controls.Add(Me.TEntitas)
        Me.PanelKanan.Controls.Add(Me.DGVPageCounter)
        Me.PanelKanan.Controls.Add(Me.TCariData)
        Me.PanelKanan.Controls.Add(Me.DGVPrev)
        Me.PanelKanan.Controls.Add(Me.DGV)
        Me.PanelKanan.Controls.Add(Me.LBLEntitas)
        Me.PanelKanan.Controls.Add(Me.DGVNext)
        Me.PanelKanan.Controls.Add(Me.Pemisah2)
        Me.PanelKanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelKanan.Location = New System.Drawing.Point(631, 0)
        Me.PanelKanan.Name = "PanelKanan"
        Me.PanelKanan.Size = New System.Drawing.Size(400, 489)
        Me.PanelKanan.TabIndex = 108
        '
        'TEntitas
        '
        Me.TEntitas.AlwaysActive = False
        Me.TEntitas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TEntitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TEntitas.DropDownWidth = 119
        Me.TEntitas.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TEntitas.IntegralHeight = False
        Me.TEntitas.Items.AddRange(New Object() {"Pembelian", "Penjualan", "Barang", "Supplier", "Customer"})
        Me.TEntitas.Location = New System.Drawing.Point(9, 34)
        Me.TEntitas.Name = "TEntitas"
        Me.TEntitas.Palette = Me.PaletSekunder
        Me.TEntitas.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TEntitas.Size = New System.Drawing.Size(385, 26)
        Me.TEntitas.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TEntitas.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEntitas.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEntitas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TEntitas.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TEntitas.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TEntitas.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEntitas.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TEntitas.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TEntitas.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TEntitas.TabIndex = 171
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AlwaysActive = False
        Me.DGVPageCounter.Enabled = False
        Me.DGVPageCounter.Location = New System.Drawing.Point(156, 451)
        Me.DGVPageCounter.MaxLength = 255
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPageCounter.TabIndex = 166
        Me.DGVPageCounter.Tag = ""
        Me.DGVPageCounter.Text = "1 / 1"
        Me.DGVPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TCariData
        '
        Me.TCariData.AlwaysActive = False
        Me.TCariData.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariData.CueHint.CueHintText = "Cari data..."
        Me.TCariData.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TCariData.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariData.Location = New System.Drawing.Point(9, 63)
        Me.TCariData.MaxLength = 255
        Me.TCariData.Name = "TCariData"
        Me.TCariData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TCariData.Size = New System.Drawing.Size(385, 29)
        Me.TCariData.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateActive.Border.Rounding = 0!
        Me.TCariData.StateActive.Border.Width = 1
        Me.TCariData.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TCariData.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TCariData.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TCariData.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateCommon.Border.Rounding = 0!
        Me.TCariData.StateCommon.Border.Width = 1
        Me.TCariData.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TCariData.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TCariData.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TCariData.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateDisabled.Border.Rounding = 0!
        Me.TCariData.StateDisabled.Border.Width = 0
        Me.TCariData.TabIndex = 111
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(124, 451)
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
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(9, 94)
        Me.DGV.Name = "DGV"
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(385, 351)
        Me.DGV.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
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
        Me.DGV.TabIndex = 110
        '
        'LBLEntitas
        '
        Me.LBLEntitas.AutoSize = False
        Me.LBLEntitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLEntitas.Location = New System.Drawing.Point(3, 0)
        Me.LBLEntitas.Name = "LBLEntitas"
        Me.LBLEntitas.Size = New System.Drawing.Size(397, 26)
        Me.LBLEntitas.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLEntitas.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLEntitas.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLEntitas.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEntitas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLEntitas.TabIndex = 108
        Me.LBLEntitas.Values.Text = "Transaksi Per Entitas"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(252, 451)
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
        'Pemisah2
        '
        Me.Pemisah2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pemisah2.Location = New System.Drawing.Point(0, 0)
        Me.Pemisah2.Name = "Pemisah2"
        Me.Pemisah2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Pemisah2.Size = New System.Drawing.Size(3, 489)
        Me.Pemisah2.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Pemisah2.StateCommon.Width = 3
        Me.Pemisah2.Text = "KryptonBorderEdge1"
        '
        'PanelKiri
        '
        Me.PanelKiri.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelKiri.Controls.Add(Me.PanelGrafik)
        Me.PanelKiri.Controls.Add(Me.Pemisah5)
        Me.PanelKiri.Controls.Add(Me.PanelLabaRugi)
        Me.PanelKiri.Controls.Add(Me.Pemisah4)
        Me.PanelKiri.Controls.Add(Me.PanelTransaksi)
        Me.PanelKiri.Controls.Add(Me.Pemisah3)
        Me.PanelKiri.Controls.Add(Me.PanelFile)
        Me.PanelKiri.Controls.Add(Me.Pemisah1)
        Me.PanelKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelKiri.Location = New System.Drawing.Point(0, 0)
        Me.PanelKiri.Name = "PanelKiri"
        Me.PanelKiri.Size = New System.Drawing.Size(400, 489)
        Me.PanelKiri.TabIndex = 106
        '
        'PanelGrafik
        '
        Me.PanelGrafik.Controls.Add(Me.RBBatang)
        Me.PanelGrafik.Controls.Add(Me.RBGaris)
        Me.PanelGrafik.Controls.Add(Me.LBLGrafik)
        Me.PanelGrafik.Controls.Add(Me.RBKurva)
        Me.PanelGrafik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrafik.Location = New System.Drawing.Point(0, 369)
        Me.PanelGrafik.Name = "PanelGrafik"
        Me.PanelGrafik.Size = New System.Drawing.Size(397, 120)
        Me.PanelGrafik.TabIndex = 109
        '
        'Pemisah5
        '
        Me.Pemisah5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pemisah5.Location = New System.Drawing.Point(0, 366)
        Me.Pemisah5.Name = "Pemisah5"
        Me.Pemisah5.Size = New System.Drawing.Size(397, 3)
        Me.Pemisah5.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Pemisah5.StateCommon.Width = 3
        Me.Pemisah5.Text = "KryptonBorderEdge1"
        '
        'PanelLabaRugi
        '
        Me.PanelLabaRugi.Controls.Add(Me.LBLLabaRugi)
        Me.PanelLabaRugi.Controls.Add(Me.CBTransaksi)
        Me.PanelLabaRugi.Controls.Add(Me.CBLain)
        Me.PanelLabaRugi.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLabaRugi.Location = New System.Drawing.Point(0, 246)
        Me.PanelLabaRugi.Name = "PanelLabaRugi"
        Me.PanelLabaRugi.Size = New System.Drawing.Size(397, 120)
        Me.PanelLabaRugi.TabIndex = 106
        '
        'Pemisah4
        '
        Me.Pemisah4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pemisah4.Location = New System.Drawing.Point(0, 243)
        Me.Pemisah4.Name = "Pemisah4"
        Me.Pemisah4.Size = New System.Drawing.Size(397, 3)
        Me.Pemisah4.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Pemisah4.StateCommon.Width = 3
        Me.Pemisah4.Text = "KryptonBorderEdge1"
        '
        'PanelTransaksi
        '
        Me.PanelTransaksi.Controls.Add(Me.LBLTransaksi)
        Me.PanelTransaksi.Controls.Add(Me.CBMasuk)
        Me.PanelTransaksi.Controls.Add(Me.CBKeluar)
        Me.PanelTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTransaksi.Location = New System.Drawing.Point(0, 123)
        Me.PanelTransaksi.Name = "PanelTransaksi"
        Me.PanelTransaksi.Size = New System.Drawing.Size(397, 120)
        Me.PanelTransaksi.TabIndex = 103
        '
        'Pemisah3
        '
        Me.Pemisah3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pemisah3.Location = New System.Drawing.Point(0, 120)
        Me.Pemisah3.Name = "Pemisah3"
        Me.Pemisah3.Size = New System.Drawing.Size(397, 3)
        Me.Pemisah3.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Pemisah3.StateCommon.Width = 3
        Me.Pemisah3.Text = "KryptonBorderEdge1"
        '
        'PanelFile
        '
        Me.PanelFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelFile.Controls.Add(Me.LBLFile)
        Me.PanelFile.Controls.Add(Me.RBBarang)
        Me.PanelFile.Controls.Add(Me.RBSupplier)
        Me.PanelFile.Controls.Add(Me.RBCustomer)
        Me.PanelFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFile.Location = New System.Drawing.Point(0, 0)
        Me.PanelFile.Name = "PanelFile"
        Me.PanelFile.Size = New System.Drawing.Size(397, 120)
        Me.PanelFile.TabIndex = 97
        '
        'LBLFile
        '
        Me.LBLFile.AutoSize = False
        Me.LBLFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLFile.Location = New System.Drawing.Point(0, 0)
        Me.LBLFile.Name = "LBLFile"
        Me.LBLFile.Size = New System.Drawing.Size(397, 26)
        Me.LBLFile.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLFile.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFile.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFile.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFile.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLFile.TabIndex = 98
        Me.LBLFile.Values.Text = "File"
        '
        'RBBarang
        '
        Me.RBBarang.Location = New System.Drawing.Point(16, 29)
        Me.RBBarang.Name = "RBBarang"
        Me.RBBarang.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBBarang.Palette = Me.PaletSekunder
        Me.RBBarang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBBarang.Size = New System.Drawing.Size(81, 26)
        Me.RBBarang.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBBarang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBBarang.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBBarang.TabIndex = 84
        Me.RBBarang.Values.Text = "Barang"
        '
        'RBSupplier
        '
        Me.RBSupplier.Location = New System.Drawing.Point(16, 60)
        Me.RBSupplier.Name = "RBSupplier"
        Me.RBSupplier.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBSupplier.Palette = Me.PaletSekunder
        Me.RBSupplier.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBSupplier.Size = New System.Drawing.Size(91, 26)
        Me.RBSupplier.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBSupplier.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBSupplier.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBSupplier.TabIndex = 85
        Me.RBSupplier.Values.Text = "Supplier"
        '
        'RBCustomer
        '
        Me.RBCustomer.Location = New System.Drawing.Point(16, 90)
        Me.RBCustomer.Name = "RBCustomer"
        Me.RBCustomer.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBCustomer.Palette = Me.PaletSekunder
        Me.RBCustomer.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBCustomer.Size = New System.Drawing.Size(101, 26)
        Me.RBCustomer.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBCustomer.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCustomer.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBCustomer.TabIndex = 86
        Me.RBCustomer.Values.Text = "Customer"
        '
        'Pemisah1
        '
        Me.Pemisah1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pemisah1.Location = New System.Drawing.Point(397, 0)
        Me.Pemisah1.Name = "Pemisah1"
        Me.Pemisah1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Pemisah1.Size = New System.Drawing.Size(3, 489)
        Me.Pemisah1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Pemisah1.StateCommon.Width = 3
        Me.Pemisah1.Text = "KryptonBorderEdge1"
        '
        'BTNLapor
        '
        Me.BTNLapor.Location = New System.Drawing.Point(401, 581)
        Me.BTNLapor.Name = "BTNLapor"
        Me.BTNLapor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLapor.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLapor.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLapor.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLapor.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNLapor.Size = New System.Drawing.Size(150, 30)
        Me.BTNLapor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLapor.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLapor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLapor.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLapor.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNLapor.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLapor.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNLapor.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLapor.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNLapor.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLapor.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLapor.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNLapor.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLapor.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNLapor.TabIndex = 115
        Me.BTNLapor.Values.Text = "Tampil Laporan"
        '
        'BTNClear
        '
        Me.BTNClear.Location = New System.Drawing.Point(559, 581)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNClear.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNClear.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClear.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNClear.Size = New System.Drawing.Size(150, 30)
        Me.BTNClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNClear.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNClear.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClear.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNClear.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNClear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNClear.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNClear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNClear.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNClear.TabIndex = 115
        Me.BTNClear.Values.Text = "Clear"
        '
        'Dev
        '
        Me.Dev.DataSetName = "Dev"
        Me.Dev.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLBarangBindingSource
        '
        Me.TBLBarangBindingSource.DataMember = "TBLBarang"
        Me.TBLBarangBindingSource.DataSource = Me.Dev
        '
        'TBLBarangTableAdapter
        '
        Me.TBLBarangTableAdapter.ClearBeforeFill = True
        '
        'TBLSupplierBindingSource
        '
        Me.TBLSupplierBindingSource.DataMember = "TBLSupplier"
        Me.TBLSupplierBindingSource.DataSource = Me.Dev
        '
        'TBLSupplierTableAdapter
        '
        Me.TBLSupplierTableAdapter.ClearBeforeFill = True
        '
        'TBLCustomerBindingSource
        '
        Me.TBLCustomerBindingSource.DataMember = "TBLCustomer"
        Me.TBLCustomerBindingSource.DataSource = Me.Dev
        '
        'TBLCustomerTableAdapter
        '
        Me.TBLCustomerTableAdapter.ClearBeforeFill = True
        '
        'TBLPembelianBindingSource
        '
        Me.TBLPembelianBindingSource.DataMember = "TBLPembelian"
        Me.TBLPembelianBindingSource.DataSource = Me.Dev
        '
        'TBLPembelianTableAdapter
        '
        Me.TBLPembelianTableAdapter.ClearBeforeFill = True
        '
        'TBLPenjualanBindingSource
        '
        Me.TBLPenjualanBindingSource.DataMember = "TBLPenjualan"
        Me.TBLPenjualanBindingSource.DataSource = Me.Dev
        '
        'TBLPenjualanTableAdapter
        '
        Me.TBLPenjualanTableAdapter.ClearBeforeFill = True
        '
        'TBLLabaRugiBindingSource
        '
        Me.TBLLabaRugiBindingSource.DataMember = "TBLLabaRugi"
        Me.TBLLabaRugiBindingSource.DataSource = Me.Dev
        '
        'TBLLabaRugiTableAdapter
        '
        Me.TBLLabaRugiTableAdapter.ClearBeforeFill = True
        '
        'TBLTransaksiBarangBindingSource
        '
        Me.TBLTransaksiBarangBindingSource.DataMember = "TBLTransaksiBarang"
        Me.TBLTransaksiBarangBindingSource.DataSource = Me.Dev
        '
        'TBLTransaksiBarangTableAdapter
        '
        Me.TBLTransaksiBarangTableAdapter.ClearBeforeFill = True
        '
        'TBLTransaksiCustomerBindingSource
        '
        Me.TBLTransaksiCustomerBindingSource.DataMember = "TBLTransaksiCustomer"
        Me.TBLTransaksiCustomerBindingSource.DataSource = Me.Dev
        '
        'TBLTransaksiCustomerTableAdapter
        '
        Me.TBLTransaksiCustomerTableAdapter.ClearBeforeFill = True
        '
        'TBLTransaksiSupplierBindingSource
        '
        Me.TBLTransaksiSupplierBindingSource.DataMember = "TBLTransaksiSupplier"
        Me.TBLTransaksiSupplierBindingSource.DataSource = Me.Dev
        '
        'TBLTransaksiSupplierTableAdapter
        '
        Me.TBLTransaksiSupplierTableAdapter.ClearBeforeFill = True
        '
        'TBLGrafikBindingSource
        '
        Me.TBLGrafikBindingSource.DataMember = "TBLGrafik"
        Me.TBLGrafikBindingSource.DataSource = Me.Dev
        '
        'TBLGrafikTableAdapter
        '
        Me.TBLGrafikTableAdapter.ClearBeforeFill = True
        '
        'TBLTransaksiBindingSource
        '
        Me.TBLTransaksiBindingSource.DataMember = "TBLTransaksi"
        Me.TBLTransaksiBindingSource.DataSource = Me.Dev
        '
        'TBLTransaksiTableAdapter
        '
        Me.TBLTransaksiTableAdapter.ClearBeforeFill = True
        '
        'Laporan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.BTNLapor)
        Me.Controls.Add(Me.PanelTotalTransaksi)
        Me.Controls.Add(Me.PanelLapor)
        Me.Name = "Laporan"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1111, 638)
        CType(Me.PanelLapor.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLapor.Panel.ResumeLayout(False)
        CType(Me.PanelLapor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLapor.ResumeLayout(False)
        CType(Me.PanelTotalTransaksi.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalTransaksi.Panel.ResumeLayout(False)
        CType(Me.PanelTotalTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalTransaksi.ResumeLayout(False)
        Me.PanelTengah.ResumeLayout(False)
        Me.PanelTengah.PerformLayout()
        Me.PanelTahun.ResumeLayout(False)
        CType(Me.TTahunan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBulanan.ResumeLayout(False)
        Me.PanelPeriodik.ResumeLayout(False)
        Me.PanelKanan.ResumeLayout(False)
        Me.PanelKanan.PerformLayout()
        CType(Me.TEntitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKiri.ResumeLayout(False)
        Me.PanelKiri.PerformLayout()
        Me.PanelGrafik.ResumeLayout(False)
        Me.PanelGrafik.PerformLayout()
        Me.PanelLabaRugi.ResumeLayout(False)
        Me.PanelLabaRugi.PerformLayout()
        Me.PanelTransaksi.ResumeLayout(False)
        Me.PanelTransaksi.PerformLayout()
        Me.PanelFile.ResumeLayout(False)
        Me.PanelFile.PerformLayout()
        CType(Me.Dev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLLabaRugiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLTransaksiBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLTransaksiCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLTransaksiSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLGrafikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLTransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents CBKeluar As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents CBMasuk As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents PanelLapor As Krypton.Toolkit.KryptonGroup
    Friend WithEvents RBKurva As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBGaris As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBBatang As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents CBLain As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents CBTransaksi As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents LBLGrafik As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLLabaRugi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLTransaksi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLFilter As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelTotalTransaksi As Krypton.Toolkit.KryptonGroup
    Friend WithEvents PanelTengah As Panel
    Friend WithEvents PanelTahun As Panel
    Friend WithEvents LBLTahunan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Pemisah7 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents PanelBulanan As Panel
    Friend WithEvents LBLBulanan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TBulanan As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents Pemisah6 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents PanelPeriodik As Panel
    Friend WithEvents LBLPeriodik As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLSampai As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TSampai As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents TDari As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents PanelKanan As Panel
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents LBLEntitas As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Pemisah2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents PanelKiri As Panel
    Friend WithEvents PanelGrafik As Panel
    Friend WithEvents Pemisah5 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents PanelLabaRugi As Panel
    Friend WithEvents Pemisah4 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents PanelTransaksi As Panel
    Friend WithEvents Pemisah3 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents PanelFile As Panel
    Friend WithEvents LBLFile As Krypton.Toolkit.KryptonLabel
    Friend WithEvents RBBarang As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBSupplier As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBCustomer As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents Pemisah1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents TTahunan As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TEntitas As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents BTNLapor As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Dev As Dev
    Friend WithEvents TBLBarangBindingSource As BindingSource
    Friend WithEvents TBLBarangTableAdapter As DevTableAdapters.TBLBarangTableAdapter
    Friend WithEvents TBLSupplierBindingSource As BindingSource
    Friend WithEvents TBLSupplierTableAdapter As DevTableAdapters.TBLSupplierTableAdapter
    Friend WithEvents TBLCustomerBindingSource As BindingSource
    Friend WithEvents TBLCustomerTableAdapter As DevTableAdapters.TBLCustomerTableAdapter
    Friend WithEvents TBLPembelianBindingSource As BindingSource
    Friend WithEvents TBLPembelianTableAdapter As DevTableAdapters.TBLPembelianTableAdapter
    Friend WithEvents TBLPenjualanBindingSource As BindingSource
    Friend WithEvents TBLPenjualanTableAdapter As DevTableAdapters.TBLPenjualanTableAdapter
    Friend WithEvents TBLLabaRugiBindingSource As BindingSource
    Friend WithEvents TBLLabaRugiTableAdapter As DevTableAdapters.TBLLabaRugiTableAdapter
    Friend WithEvents TBLTransaksiBarangBindingSource As BindingSource
    Friend WithEvents TBLTransaksiBarangTableAdapter As DevTableAdapters.TBLTransaksiBarangTableAdapter
    Friend WithEvents TBLTransaksiCustomerBindingSource As BindingSource
    Friend WithEvents TBLTransaksiCustomerTableAdapter As DevTableAdapters.TBLTransaksiCustomerTableAdapter
    Friend WithEvents TBLTransaksiSupplierBindingSource As BindingSource
    Friend WithEvents TBLTransaksiSupplierTableAdapter As DevTableAdapters.TBLTransaksiSupplierTableAdapter
    Friend WithEvents TBLGrafikBindingSource As BindingSource
    Friend WithEvents TBLGrafikTableAdapter As DevTableAdapters.TBLGrafikTableAdapter
    Friend WithEvents TBLTransaksiBindingSource As BindingSource
    Friend WithEvents TBLTransaksiTableAdapter As DevTableAdapters.TBLTransaksiTableAdapter
End Class

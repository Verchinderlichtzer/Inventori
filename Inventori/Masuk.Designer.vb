<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Masuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Masuk))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.LBLKeterangan = New Krypton.Toolkit.KryptonLabel()
        Me.TKeterangan = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLFaktur = New Krypton.Toolkit.KryptonLabel()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.DGVBarang = New Krypton.Toolkit.KryptonDataGridView()
        Me.LBLSupplier = New Krypton.Toolkit.KryptonLabel()
        Me.TCariBarang = New Krypton.Toolkit.KryptonTextBox()
        Me.BTNSimpan = New Krypton.Toolkit.KryptonButton()
        Me.BTNHapus = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.LBLTglMasuk = New Krypton.Toolkit.KryptonLabel()
        Me.LBLPPN = New Krypton.Toolkit.KryptonLabel()
        Me.LBLSubtotal = New Krypton.Toolkit.KryptonLabel()
        Me.LBLBiayaLain = New Krypton.Toolkit.KryptonLabel()
        Me.LBLTerbayar = New Krypton.Toolkit.KryptonLabel()
        Me.LBLDibayar = New Krypton.Toolkit.KryptonLabel()
        Me.LBLGrandSisa = New Krypton.Toolkit.KryptonLabel()
        Me.LBLSisaKurang = New Krypton.Toolkit.KryptonLabel()
        Me.TTglMasuk = New Krypton.Toolkit.KryptonTextBox()
        Me.TPPN = New Krypton.Toolkit.KryptonTextBox()
        Me.TBiayaLain = New Krypton.Toolkit.KryptonTextBox()
        Me.TTerbayar = New Krypton.Toolkit.KryptonTextBox()
        Me.TDibayar = New Krypton.Toolkit.KryptonTextBox()
        Me.TSisaKurang = New Krypton.Toolkit.KryptonTextBox()
        Me.TGrandSisa = New Krypton.Toolkit.KryptonTextBox()
        Me.TSubtotal = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVBarangNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVBarangPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVBarangPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.Pemisah = New Krypton.Toolkit.KryptonBorderEdge()
        Me.TSupplier = New Krypton.Toolkit.KryptonComboBox()
        Me.TFaktur = New Krypton.Toolkit.KryptonComboBox()
        Me.CID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHargaBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDiskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTotalHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CKedaluwarsa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHargaJual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAwal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaletPrimer
        '
        Me.PaletPrimer.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletPrimer.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletPrimer.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.Common = CType(resources.GetObject("resource.Common"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled1"), System.Drawing.Image)
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'LBLKeterangan
        '
        Me.LBLKeterangan.AutoSize = False
        Me.LBLKeterangan.Location = New System.Drawing.Point(8, 507)
        Me.LBLKeterangan.Name = "LBLKeterangan"
        Me.LBLKeterangan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLKeterangan.Size = New System.Drawing.Size(121, 26)
        Me.LBLKeterangan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLKeterangan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLKeterangan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLKeterangan.TabIndex = 124
        Me.LBLKeterangan.Values.Text = "Keterangan :"
        '
        'TKeterangan
        '
        Me.TKeterangan.AlwaysActive = False
        Me.TKeterangan.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TKeterangan.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TKeterangan.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TKeterangan.Location = New System.Drawing.Point(8, 539)
        Me.TKeterangan.MaxLength = 255
        Me.TKeterangan.Multiline = True
        Me.TKeterangan.Name = "TKeterangan"
        Me.TKeterangan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TKeterangan.Size = New System.Drawing.Size(250, 91)
        Me.TKeterangan.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TKeterangan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TKeterangan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKeterangan.StateActive.Border.Rounding = 0!
        Me.TKeterangan.StateActive.Border.Width = 1
        Me.TKeterangan.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TKeterangan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TKeterangan.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TKeterangan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TKeterangan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKeterangan.StateCommon.Border.Rounding = 0!
        Me.TKeterangan.StateCommon.Border.Width = 1
        Me.TKeterangan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TKeterangan.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TKeterangan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TKeterangan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKeterangan.StateDisabled.Border.Rounding = 0!
        Me.TKeterangan.StateDisabled.Border.Width = 0
        Me.TKeterangan.TabIndex = 5
        '
        'LBLFaktur
        '
        Me.LBLFaktur.AutoSize = False
        Me.LBLFaktur.Location = New System.Drawing.Point(8, 8)
        Me.LBLFaktur.Name = "LBLFaktur"
        Me.LBLFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLFaktur.Size = New System.Drawing.Size(65, 26)
        Me.LBLFaktur.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFaktur.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFaktur.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLFaktur.TabIndex = 123
        Me.LBLFaktur.Values.Text = "Faktur"
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CID, Me.CNama, Me.CQty, Me.CSatuan, Me.CHargaBeli, Me.CDiskon, Me.CTotalHarga, Me.CKedaluwarsa, Me.CHargaJual, Me.CAwal})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 37)
        Me.DGV.Name = "DGV"
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DGV.Size = New System.Drawing.Size(863, 440)
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
        Me.DGV.TabIndex = 4
        '
        'DGVBarang
        '
        Me.DGVBarang.AllowUserToAddRows = False
        Me.DGVBarang.AllowUserToDeleteRows = False
        Me.DGVBarang.AllowUserToResizeColumns = False
        Me.DGVBarang.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGVBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVBarang.ColumnHeadersHeight = 27
        Me.DGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVBarang.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVBarang.HideOuterBorders = True
        Me.DGVBarang.Location = New System.Drawing.Point(877, 72)
        Me.DGVBarang.Name = "DGVBarang"
        Me.DGVBarang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVBarang.ReadOnly = True
        Me.DGVBarang.RowHeadersVisible = False
        Me.DGVBarang.RowTemplate.Height = 27
        Me.DGVBarang.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVBarang.Size = New System.Drawing.Size(226, 405)
        Me.DGVBarang.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVBarang.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGVBarang.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGVBarang.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DGVBarang.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGVBarang.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVBarang.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarang.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVBarang.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarang.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarang.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGVBarang.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarang.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVBarang.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVBarang.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DGVBarang.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarang.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGVBarang.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DGVBarang.TabIndex = 3
        '
        'LBLSupplier
        '
        Me.LBLSupplier.AutoSize = False
        Me.LBLSupplier.Location = New System.Drawing.Point(215, 8)
        Me.LBLSupplier.Name = "LBLSupplier"
        Me.LBLSupplier.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLSupplier.Size = New System.Drawing.Size(89, 26)
        Me.LBLSupplier.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSupplier.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSupplier.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSupplier.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLSupplier.TabIndex = 123
        Me.LBLSupplier.Values.Text = "Supplier"
        '
        'TCariBarang
        '
        Me.TCariBarang.AlwaysActive = False
        Me.TCariBarang.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariBarang.CueHint.CueHintText = "Cari barang..."
        Me.TCariBarang.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCariBarang.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariBarang.Location = New System.Drawing.Point(877, 37)
        Me.TCariBarang.MaxLength = 255
        Me.TCariBarang.Name = "TCariBarang"
        Me.TCariBarang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TCariBarang.Size = New System.Drawing.Size(226, 29)
        Me.TCariBarang.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TCariBarang.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariBarang.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariBarang.StateActive.Border.Rounding = 0!
        Me.TCariBarang.StateActive.Border.Width = 1
        Me.TCariBarang.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TCariBarang.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TCariBarang.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TCariBarang.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariBarang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariBarang.StateCommon.Border.Rounding = 0!
        Me.TCariBarang.StateCommon.Border.Width = 1
        Me.TCariBarang.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TCariBarang.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TCariBarang.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TCariBarang.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariBarang.StateDisabled.Border.Rounding = 0!
        Me.TCariBarang.StateDisabled.Border.Width = 0
        Me.TCariBarang.TabIndex = 2
        '
        'BTNSimpan
        '
        Me.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSimpan.Enabled = False
        Me.BTNSimpan.Location = New System.Drawing.Point(761, 520)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNSimpan.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.OverrideDefault.Border.Rounding = 0!
        Me.BTNSimpan.OverrideDefault.Border.Width = 3
        Me.BTNSimpan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSimpan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNSimpan.Size = New System.Drawing.Size(110, 110)
        Me.BTNSimpan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNSimpan.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StateCommon.Border.Rounding = 0!
        Me.BTNSimpan.StateCommon.Border.Width = 3
        Me.BTNSimpan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSimpan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNSimpan.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNSimpan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNSimpan.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StatePressed.Back.Color1 = System.Drawing.Color.White
        Me.BTNSimpan.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNSimpan.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNSimpan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTNSimpan.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNSimpan.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNSimpan.TabIndex = 9
        Me.BTNSimpan.Values.Image = Global.Inventori.My.Resources.Resources.crud_simpan_pressed
        Me.BTNSimpan.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.crud_simpan_common
        Me.BTNSimpan.Values.Text = ""
        '
        'BTNHapus
        '
        Me.BTNHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNHapus.Enabled = False
        Me.BTNHapus.Location = New System.Drawing.Point(877, 520)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNHapus.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNHapus.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNHapus.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.OverrideDefault.Border.Rounding = 0!
        Me.BTNHapus.OverrideDefault.Border.Width = 3
        Me.BTNHapus.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNHapus.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNHapus.Size = New System.Drawing.Size(110, 110)
        Me.BTNHapus.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNHapus.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNHapus.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNHapus.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StateCommon.Border.Rounding = 0!
        Me.BTNHapus.StateCommon.Border.Width = 3
        Me.BTNHapus.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNHapus.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNHapus.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNHapus.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNHapus.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapus.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNHapus.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StatePressed.Back.Color1 = System.Drawing.Color.White
        Me.BTNHapus.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNHapus.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNHapus.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTNHapus.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNHapus.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNHapus.TabIndex = 10
        Me.BTNHapus.Values.Image = Global.Inventori.My.Resources.Resources.crud_hapus_pressed
        Me.BTNHapus.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNHapus.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNHapus.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNHapus.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.crud_hapus_common
        Me.BTNHapus.Values.Text = ""
        '
        'BTNClear
        '
        Me.BTNClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNClear.Location = New System.Drawing.Point(993, 520)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNClear.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.OverrideDefault.Border.Rounding = 0!
        Me.BTNClear.OverrideDefault.Border.Width = 3
        Me.BTNClear.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClear.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNClear.Size = New System.Drawing.Size(110, 110)
        Me.BTNClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNClear.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StateCommon.Border.Rounding = 0!
        Me.BTNClear.StateCommon.Border.Width = 3
        Me.BTNClear.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClear.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNClear.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClear.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNClear.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StatePressed.Back.Color1 = System.Drawing.Color.White
        Me.BTNClear.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNClear.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNClear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTNClear.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNClear.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNClear.TabIndex = 11
        Me.BTNClear.Values.Image = Global.Inventori.My.Resources.Resources.crud_refresh_pressed
        Me.BTNClear.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNClear.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.crud_refresh_common
        Me.BTNClear.Values.Text = ""
        '
        'LBLTglMasuk
        '
        Me.LBLTglMasuk.AutoSize = False
        Me.LBLTglMasuk.Location = New System.Drawing.Point(264, 520)
        Me.LBLTglMasuk.Name = "LBLTglMasuk"
        Me.LBLTglMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTglMasuk.Size = New System.Drawing.Size(114, 26)
        Me.LBLTglMasuk.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTglMasuk.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTglMasuk.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTglMasuk.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLTglMasuk.TabIndex = 124
        Me.LBLTglMasuk.Values.Text = "Tgl Masuk :"
        Me.LBLTglMasuk.Visible = False
        '
        'LBLPPN
        '
        Me.LBLPPN.AutoSize = False
        Me.LBLPPN.Location = New System.Drawing.Point(322, 576)
        Me.LBLPPN.Name = "LBLPPN"
        Me.LBLPPN.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLPPN.Size = New System.Drawing.Size(186, 26)
        Me.LBLPPN.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPPN.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPPN.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPPN.TabIndex = 124
        Me.LBLPPN.Values.Text = "PPN :                      %"
        '
        'LBLSubtotal
        '
        Me.LBLSubtotal.AutoSize = False
        Me.LBLSubtotal.Location = New System.Drawing.Point(264, 548)
        Me.LBLSubtotal.Name = "LBLSubtotal"
        Me.LBLSubtotal.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLSubtotal.Size = New System.Drawing.Size(112, 26)
        Me.LBLSubtotal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSubtotal.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSubtotal.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSubtotal.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLSubtotal.TabIndex = 124
        Me.LBLSubtotal.Values.Text = "Subtotal :"
        '
        'LBLBiayaLain
        '
        Me.LBLBiayaLain.AutoSize = False
        Me.LBLBiayaLain.Location = New System.Drawing.Point(266, 604)
        Me.LBLBiayaLain.Name = "LBLBiayaLain"
        Me.LBLBiayaLain.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLBiayaLain.Size = New System.Drawing.Size(112, 26)
        Me.LBLBiayaLain.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBiayaLain.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBiayaLain.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBiayaLain.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLBiayaLain.TabIndex = 124
        Me.LBLBiayaLain.Values.Text = "Biaya Lain :"
        '
        'LBLTerbayar
        '
        Me.LBLTerbayar.AutoSize = False
        Me.LBLTerbayar.Location = New System.Drawing.Point(521, 520)
        Me.LBLTerbayar.Name = "LBLTerbayar"
        Me.LBLTerbayar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTerbayar.Size = New System.Drawing.Size(118, 26)
        Me.LBLTerbayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTerbayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTerbayar.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTerbayar.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLTerbayar.TabIndex = 124
        Me.LBLTerbayar.Values.Text = "Terbayar :"
        Me.LBLTerbayar.Visible = False
        '
        'LBLDibayar
        '
        Me.LBLDibayar.AutoSize = False
        Me.LBLDibayar.Location = New System.Drawing.Point(520, 576)
        Me.LBLDibayar.Name = "LBLDibayar"
        Me.LBLDibayar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLDibayar.Size = New System.Drawing.Size(118, 26)
        Me.LBLDibayar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLDibayar.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLDibayar.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLDibayar.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLDibayar.TabIndex = 124
        Me.LBLDibayar.Values.Text = "Dibayar :"
        Me.LBLDibayar.Visible = False
        '
        'LBLGrandSisa
        '
        Me.LBLGrandSisa.AutoSize = False
        Me.LBLGrandSisa.Location = New System.Drawing.Point(521, 548)
        Me.LBLGrandSisa.Name = "LBLGrandSisa"
        Me.LBLGrandSisa.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLGrandSisa.Size = New System.Drawing.Size(118, 26)
        Me.LBLGrandSisa.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLGrandSisa.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLGrandSisa.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLGrandSisa.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLGrandSisa.TabIndex = 124
        Me.LBLGrandSisa.Values.Text = "Grand Total :"
        '
        'LBLSisaKurang
        '
        Me.LBLSisaKurang.AutoSize = False
        Me.LBLSisaKurang.Location = New System.Drawing.Point(520, 604)
        Me.LBLSisaKurang.Name = "LBLSisaKurang"
        Me.LBLSisaKurang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLSisaKurang.Size = New System.Drawing.Size(118, 26)
        Me.LBLSisaKurang.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSisaKurang.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSisaKurang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSisaKurang.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLSisaKurang.TabIndex = 124
        Me.LBLSisaKurang.Values.Text = "Sisa :"
        Me.LBLSisaKurang.Visible = False
        '
        'TTglMasuk
        '
        Me.TTglMasuk.AlwaysActive = False
        Me.TTglMasuk.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTglMasuk.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTglMasuk.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTglMasuk.Enabled = False
        Me.TTglMasuk.Location = New System.Drawing.Point(374, 520)
        Me.TTglMasuk.MaxLength = 255
        Me.TTglMasuk.Name = "TTglMasuk"
        Me.TTglMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TTglMasuk.Size = New System.Drawing.Size(120, 29)
        Me.TTglMasuk.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TTglMasuk.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTglMasuk.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTglMasuk.StateActive.Border.Rounding = 0!
        Me.TTglMasuk.StateActive.Border.Width = 1
        Me.TTglMasuk.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTglMasuk.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTglMasuk.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TTglMasuk.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTglMasuk.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTglMasuk.StateCommon.Border.Rounding = 0!
        Me.TTglMasuk.StateCommon.Border.Width = 1
        Me.TTglMasuk.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTglMasuk.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTglMasuk.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTglMasuk.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTglMasuk.StateDisabled.Border.Rounding = 0!
        Me.TTglMasuk.StateDisabled.Border.Width = 0
        Me.TTglMasuk.TabIndex = 120
        Me.TTglMasuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TTglMasuk.Visible = False
        '
        'TPPN
        '
        Me.TPPN.AlwaysActive = False
        Me.TPPN.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPPN.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPPN.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPPN.Location = New System.Drawing.Point(446, 576)
        Me.TPPN.MaxLength = 2
        Me.TPPN.Name = "TPPN"
        Me.TPPN.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TPPN.Size = New System.Drawing.Size(34, 29)
        Me.TPPN.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TPPN.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPPN.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPPN.StateActive.Border.Rounding = 0!
        Me.TPPN.StateActive.Border.Width = 1
        Me.TPPN.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPPN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPPN.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TPPN.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPPN.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPPN.StateCommon.Border.Rounding = 0!
        Me.TPPN.StateCommon.Border.Width = 1
        Me.TPPN.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPPN.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPPN.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPPN.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPPN.StateDisabled.Border.Rounding = 0!
        Me.TPPN.StateDisabled.Border.Width = 0
        Me.TPPN.TabIndex = 6
        Me.TPPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBiayaLain
        '
        Me.TBiayaLain.AlwaysActive = False
        Me.TBiayaLain.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TBiayaLain.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TBiayaLain.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TBiayaLain.Location = New System.Drawing.Point(374, 604)
        Me.TBiayaLain.MaxLength = 9
        Me.TBiayaLain.Name = "TBiayaLain"
        Me.TBiayaLain.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TBiayaLain.Size = New System.Drawing.Size(120, 29)
        Me.TBiayaLain.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TBiayaLain.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBiayaLain.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBiayaLain.StateActive.Border.Rounding = 0!
        Me.TBiayaLain.StateActive.Border.Width = 1
        Me.TBiayaLain.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TBiayaLain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBiayaLain.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TBiayaLain.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBiayaLain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBiayaLain.StateCommon.Border.Rounding = 0!
        Me.TBiayaLain.StateCommon.Border.Width = 1
        Me.TBiayaLain.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBiayaLain.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TBiayaLain.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBiayaLain.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBiayaLain.StateDisabled.Border.Rounding = 0!
        Me.TBiayaLain.StateDisabled.Border.Width = 0
        Me.TBiayaLain.TabIndex = 7
        Me.TBiayaLain.Text = "0"
        Me.TBiayaLain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TTerbayar
        '
        Me.TTerbayar.AlwaysActive = False
        Me.TTerbayar.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTerbayar.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTerbayar.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTerbayar.Enabled = False
        Me.TTerbayar.Location = New System.Drawing.Point(635, 520)
        Me.TTerbayar.MaxLength = 255
        Me.TTerbayar.Name = "TTerbayar"
        Me.TTerbayar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TTerbayar.Size = New System.Drawing.Size(120, 29)
        Me.TTerbayar.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TTerbayar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTerbayar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTerbayar.StateActive.Border.Rounding = 0!
        Me.TTerbayar.StateActive.Border.Width = 1
        Me.TTerbayar.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTerbayar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTerbayar.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TTerbayar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTerbayar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTerbayar.StateCommon.Border.Rounding = 0!
        Me.TTerbayar.StateCommon.Border.Width = 1
        Me.TTerbayar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTerbayar.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTerbayar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTerbayar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTerbayar.StateDisabled.Border.Rounding = 0!
        Me.TTerbayar.StateDisabled.Border.Width = 0
        Me.TTerbayar.TabIndex = 120
        Me.TTerbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TTerbayar.Visible = False
        '
        'TDibayar
        '
        Me.TDibayar.AlwaysActive = False
        Me.TDibayar.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TDibayar.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TDibayar.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TDibayar.Location = New System.Drawing.Point(635, 576)
        Me.TDibayar.MaxLength = 9
        Me.TDibayar.Name = "TDibayar"
        Me.TDibayar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TDibayar.Size = New System.Drawing.Size(120, 29)
        Me.TDibayar.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TDibayar.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TDibayar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDibayar.StateActive.Border.Rounding = 0!
        Me.TDibayar.StateActive.Border.Width = 1
        Me.TDibayar.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TDibayar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TDibayar.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TDibayar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TDibayar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDibayar.StateCommon.Border.Rounding = 0!
        Me.TDibayar.StateCommon.Border.Width = 1
        Me.TDibayar.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TDibayar.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TDibayar.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TDibayar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDibayar.StateDisabled.Border.Rounding = 0!
        Me.TDibayar.StateDisabled.Border.Width = 0
        Me.TDibayar.TabIndex = 8
        Me.TDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TDibayar.Visible = False
        '
        'TSisaKurang
        '
        Me.TSisaKurang.AlwaysActive = False
        Me.TSisaKurang.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TSisaKurang.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TSisaKurang.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TSisaKurang.Enabled = False
        Me.TSisaKurang.Location = New System.Drawing.Point(635, 604)
        Me.TSisaKurang.MaxLength = 255
        Me.TSisaKurang.Name = "TSisaKurang"
        Me.TSisaKurang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TSisaKurang.Size = New System.Drawing.Size(120, 29)
        Me.TSisaKurang.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TSisaKurang.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TSisaKurang.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSisaKurang.StateActive.Border.Rounding = 0!
        Me.TSisaKurang.StateActive.Border.Width = 1
        Me.TSisaKurang.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TSisaKurang.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TSisaKurang.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TSisaKurang.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TSisaKurang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSisaKurang.StateCommon.Border.Rounding = 0!
        Me.TSisaKurang.StateCommon.Border.Width = 1
        Me.TSisaKurang.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSisaKurang.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TSisaKurang.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TSisaKurang.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSisaKurang.StateDisabled.Border.Rounding = 0!
        Me.TSisaKurang.StateDisabled.Border.Width = 0
        Me.TSisaKurang.TabIndex = 120
        Me.TSisaKurang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TSisaKurang.Visible = False
        '
        'TGrandSisa
        '
        Me.TGrandSisa.AlwaysActive = False
        Me.TGrandSisa.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TGrandSisa.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TGrandSisa.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TGrandSisa.Enabled = False
        Me.TGrandSisa.Location = New System.Drawing.Point(635, 548)
        Me.TGrandSisa.MaxLength = 255
        Me.TGrandSisa.Name = "TGrandSisa"
        Me.TGrandSisa.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TGrandSisa.Size = New System.Drawing.Size(120, 29)
        Me.TGrandSisa.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TGrandSisa.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TGrandSisa.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TGrandSisa.StateActive.Border.Rounding = 0!
        Me.TGrandSisa.StateActive.Border.Width = 1
        Me.TGrandSisa.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TGrandSisa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TGrandSisa.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TGrandSisa.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TGrandSisa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TGrandSisa.StateCommon.Border.Rounding = 0!
        Me.TGrandSisa.StateCommon.Border.Width = 1
        Me.TGrandSisa.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TGrandSisa.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TGrandSisa.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TGrandSisa.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TGrandSisa.StateDisabled.Border.Rounding = 0!
        Me.TGrandSisa.StateDisabled.Border.Width = 0
        Me.TGrandSisa.TabIndex = 120
        Me.TGrandSisa.Text = "0"
        Me.TGrandSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSubtotal
        '
        Me.TSubtotal.AlwaysActive = False
        Me.TSubtotal.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TSubtotal.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TSubtotal.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TSubtotal.Enabled = False
        Me.TSubtotal.Location = New System.Drawing.Point(374, 548)
        Me.TSubtotal.MaxLength = 255
        Me.TSubtotal.Name = "TSubtotal"
        Me.TSubtotal.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TSubtotal.Size = New System.Drawing.Size(120, 29)
        Me.TSubtotal.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TSubtotal.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TSubtotal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSubtotal.StateActive.Border.Rounding = 0!
        Me.TSubtotal.StateActive.Border.Width = 1
        Me.TSubtotal.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TSubtotal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TSubtotal.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TSubtotal.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TSubtotal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSubtotal.StateCommon.Border.Rounding = 0!
        Me.TSubtotal.StateCommon.Border.Width = 1
        Me.TSubtotal.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSubtotal.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TSubtotal.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TSubtotal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TSubtotal.StateDisabled.Border.Rounding = 0!
        Me.TSubtotal.StateDisabled.Border.Width = 0
        Me.TSubtotal.TabIndex = 120
        Me.TSubtotal.Text = "0"
        Me.TSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DGVBarangNext
        '
        Me.DGVBarangNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVBarangNext.Enabled = False
        Me.DGVBarangNext.Location = New System.Drawing.Point(1041, 483)
        Me.DGVBarangNext.Name = "DGVBarangNext"
        Me.DGVBarangNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangNext.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVBarangNext.Size = New System.Drawing.Size(26, 26)
        Me.DGVBarangNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.DGVBarangNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarangNext.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DGVBarangNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVBarangNext.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVBarangNext.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVBarangNext.TabIndex = 168
        Me.DGVBarangNext.Values.Text = "►"
        '
        'DGVBarangPrev
        '
        Me.DGVBarangPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVBarangPrev.Enabled = False
        Me.DGVBarangPrev.Location = New System.Drawing.Point(913, 483)
        Me.DGVBarangPrev.Name = "DGVBarangPrev"
        Me.DGVBarangPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangPrev.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVBarangPrev.Size = New System.Drawing.Size(26, 26)
        Me.DGVBarangPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBarangPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBarangPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBarangPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.DGVBarangPrev.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarangPrev.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DGVBarangPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVBarangPrev.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVBarangPrev.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVBarangPrev.TabIndex = 167
        Me.DGVBarangPrev.Values.Text = "◄"
        '
        'DGVBarangPageCounter
        '
        Me.DGVBarangPageCounter.AlwaysActive = False
        Me.DGVBarangPageCounter.Enabled = False
        Me.DGVBarangPageCounter.Location = New System.Drawing.Point(945, 483)
        Me.DGVBarangPageCounter.MaxLength = 255
        Me.DGVBarangPageCounter.Name = "DGVBarangPageCounter"
        Me.DGVBarangPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVBarangPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVBarangPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVBarangPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBarangPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVBarangPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBarangPageCounter.TabIndex = 169
        Me.DGVBarangPageCounter.Tag = ""
        Me.DGVBarangPageCounter.Text = "1 / 1"
        Me.DGVBarangPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pemisah
        '
        Me.Pemisah.Location = New System.Drawing.Point(514, 520)
        Me.Pemisah.Name = "Pemisah"
        Me.Pemisah.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Pemisah.Size = New System.Drawing.Size(2, 110)
        Me.Pemisah.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Pemisah.StateCommon.Width = 2
        Me.Pemisah.Text = "KryptonBorderEdge4"
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
        Me.TSupplier.Location = New System.Drawing.Point(310, 8)
        Me.TSupplier.MaxDropDownItems = 20
        Me.TSupplier.Name = "TSupplier"
        Me.TSupplier.Palette = Me.PaletPrimer
        Me.TSupplier.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSupplier.Size = New System.Drawing.Size(580, 26)
        Me.TSupplier.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TSupplier.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSupplier.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSupplier.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TSupplier.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TSupplier.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TSupplier.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSupplier.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TSupplier.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TSupplier.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TSupplier.TabIndex = 1
        '
        'TFaktur
        '
        Me.TFaktur.AlwaysActive = False
        Me.TFaktur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TFaktur.DropDownHeight = 500
        Me.TFaktur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TFaktur.DropDownWidth = 119
        Me.TFaktur.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TFaktur.IntegralHeight = False
        Me.TFaktur.Location = New System.Drawing.Point(79, 8)
        Me.TFaktur.MaxDropDownItems = 20
        Me.TFaktur.Name = "TFaktur"
        Me.TFaktur.Palette = Me.PaletPrimer
        Me.TFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TFaktur.Size = New System.Drawing.Size(120, 26)
        Me.TFaktur.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TFaktur.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TFaktur.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFaktur.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TFaktur.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TFaktur.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TFaktur.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TFaktur.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TFaktur.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TFaktur.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TFaktur.TabIndex = 0
        '
        'CID
        '
        Me.CID.HeaderText = "ID Barang"
        Me.CID.Name = "CID"
        Me.CID.ReadOnly = True
        Me.CID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CID.Visible = False
        Me.CID.Width = 5
        '
        'CNama
        '
        Me.CNama.HeaderText = "Nama Barang"
        Me.CNama.Name = "CNama"
        Me.CNama.ReadOnly = True
        Me.CNama.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNama.Width = 437
        '
        'CQty
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CQty.DefaultCellStyle = DataGridViewCellStyle2
        Me.CQty.HeaderText = "Qty"
        Me.CQty.MaxInputLength = 4
        Me.CQty.Name = "CQty"
        Me.CQty.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CQty.Width = 55
        '
        'CSatuan
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CSatuan.DefaultCellStyle = DataGridViewCellStyle3
        Me.CSatuan.HeaderText = "Satuan"
        Me.CSatuan.Name = "CSatuan"
        Me.CSatuan.ReadOnly = True
        Me.CSatuan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CSatuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CSatuan.Width = 80
        '
        'CHargaBeli
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CHargaBeli.DefaultCellStyle = DataGridViewCellStyle4
        Me.CHargaBeli.HeaderText = "Harga Beli"
        Me.CHargaBeli.MaxInputLength = 9
        Me.CHargaBeli.Name = "CHargaBeli"
        Me.CHargaBeli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CHargaBeli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CHargaBeli.Width = 105
        '
        'CDiskon
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CDiskon.DefaultCellStyle = DataGridViewCellStyle5
        Me.CDiskon.HeaderText = "Diskon"
        Me.CDiskon.MaxInputLength = 2
        Me.CDiskon.Name = "CDiskon"
        Me.CDiskon.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CDiskon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CDiskon.Width = 61
        '
        'CTotalHarga
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "###,###,###"
        Me.CTotalHarga.DefaultCellStyle = DataGridViewCellStyle6
        Me.CTotalHarga.HeaderText = "Total Harga"
        Me.CTotalHarga.MaxInputLength = 9
        Me.CTotalHarga.Name = "CTotalHarga"
        Me.CTotalHarga.ReadOnly = True
        Me.CTotalHarga.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTotalHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTotalHarga.Width = 107
        '
        'CKedaluwarsa
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CKedaluwarsa.DefaultCellStyle = DataGridViewCellStyle7
        Me.CKedaluwarsa.HeaderText = "Kedaluwarsa"
        Me.CKedaluwarsa.MaxInputLength = 10
        Me.CKedaluwarsa.Name = "CKedaluwarsa"
        Me.CKedaluwarsa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CKedaluwarsa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CKedaluwarsa.Visible = False
        Me.CKedaluwarsa.Width = 5
        '
        'CHargaJual
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CHargaJual.DefaultCellStyle = DataGridViewCellStyle8
        Me.CHargaJual.HeaderText = "Harga Jual"
        Me.CHargaJual.MaxInputLength = 9
        Me.CHargaJual.Name = "CHargaJual"
        Me.CHargaJual.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CHargaJual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CHargaJual.Visible = False
        Me.CHargaJual.Width = 5
        '
        'CAwal
        '
        Me.CAwal.HeaderText = "Awal"
        Me.CAwal.Name = "CAwal"
        Me.CAwal.ReadOnly = True
        Me.CAwal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CAwal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CAwal.Visible = False
        Me.CAwal.Width = 5
        '
        'Masuk
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.TSisaKurang)
        Me.Controls.Add(Me.TBiayaLain)
        Me.Controls.Add(Me.TSupplier)
        Me.Controls.Add(Me.TFaktur)
        Me.Controls.Add(Me.Pemisah)
        Me.Controls.Add(Me.TPPN)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.DGVBarangPageCounter)
        Me.Controls.Add(Me.DGVBarangPrev)
        Me.Controls.Add(Me.DGVBarangNext)
        Me.Controls.Add(Me.LBLSisaKurang)
        Me.Controls.Add(Me.LBLBiayaLain)
        Me.Controls.Add(Me.LBLGrandSisa)
        Me.Controls.Add(Me.LBLPPN)
        Me.Controls.Add(Me.LBLDibayar)
        Me.Controls.Add(Me.LBLSubtotal)
        Me.Controls.Add(Me.LBLTerbayar)
        Me.Controls.Add(Me.LBLTglMasuk)
        Me.Controls.Add(Me.LBLKeterangan)
        Me.Controls.Add(Me.TCariBarang)
        Me.Controls.Add(Me.TDibayar)
        Me.Controls.Add(Me.TGrandSisa)
        Me.Controls.Add(Me.TTerbayar)
        Me.Controls.Add(Me.TSubtotal)
        Me.Controls.Add(Me.TTglMasuk)
        Me.Controls.Add(Me.TKeterangan)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.DGVBarang)
        Me.Controls.Add(Me.LBLSupplier)
        Me.Controls.Add(Me.LBLFaktur)
        Me.Name = "Masuk"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1111, 638)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents LBLKeterangan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TKeterangan As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLFaktur As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DGVBarang As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents LBLSupplier As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TCariBarang As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BTNSimpan As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNHapus As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents LBLTglMasuk As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLPPN As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLSubtotal As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLBiayaLain As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLTerbayar As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLDibayar As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLGrandSisa As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLSisaKurang As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TTglMasuk As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TPPN As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TBiayaLain As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TTerbayar As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TDibayar As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TSisaKurang As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TGrandSisa As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TSubtotal As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVBarangNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBarangPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBarangPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Pemisah As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents TSupplier As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TFaktur As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents CID As DataGridViewTextBoxColumn
    Friend WithEvents CNama As DataGridViewTextBoxColumn
    Friend WithEvents CQty As DataGridViewTextBoxColumn
    Friend WithEvents CSatuan As DataGridViewTextBoxColumn
    Friend WithEvents CHargaBeli As DataGridViewTextBoxColumn
    Friend WithEvents CDiskon As DataGridViewTextBoxColumn
    Friend WithEvents CTotalHarga As DataGridViewTextBoxColumn
    Friend WithEvents CKedaluwarsa As DataGridViewTextBoxColumn
    Friend WithEvents CHargaJual As DataGridViewTextBoxColumn
    Friend WithEvents CAwal As DataGridViewTextBoxColumn
End Class

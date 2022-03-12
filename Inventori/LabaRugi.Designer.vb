<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabaRugi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabaRugi))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.LBLID = New Krypton.Toolkit.KryptonLabel()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.RBPengeluaran = New Krypton.Toolkit.KryptonRadioButton()
        Me.TID = New Krypton.Toolkit.KryptonTextBox()
        Me.TNominal = New Krypton.Toolkit.KryptonTextBox()
        Me.TDeskripsi = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLNominal = New Krypton.Toolkit.KryptonLabel()
        Me.LBLDeskripsi = New Krypton.Toolkit.KryptonLabel()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.RBPendapatan = New Krypton.Toolkit.KryptonRadioButton()
        Me.BTNSimpan = New Krypton.Toolkit.KryptonButton()
        Me.BTNHapus = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.CBTampilLabaRugi = New Krypton.Toolkit.KryptonCheckBox()
        Me.CBTampilFaktur = New Krypton.Toolkit.KryptonCheckBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LBLID
        '
        Me.LBLID.AutoSize = False
        Me.LBLID.Location = New System.Drawing.Point(8, 8)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLID.Size = New System.Drawing.Size(94, 26)
        Me.LBLID.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLID.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLID.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLID.TabIndex = 123
        Me.LBLID.Values.Text = "ID"
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
        Me.DGV.Location = New System.Drawing.Point(8, 104)
        Me.DGV.Name = "DGV"
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(1095, 378)
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
        Me.DGV.TabIndex = 2
        '
        'RBPengeluaran
        '
        Me.RBPengeluaran.Checked = True
        Me.RBPengeluaran.Location = New System.Drawing.Point(245, 8)
        Me.RBPengeluaran.Name = "RBPengeluaran"
        Me.RBPengeluaran.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBPengeluaran.Palette = Me.PaletPrimer
        Me.RBPengeluaran.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBPengeluaran.Size = New System.Drawing.Size(130, 26)
        Me.RBPengeluaran.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBPengeluaran.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RBPengeluaran.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.RBPengeluaran.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.RBPengeluaran.TabIndex = 115
        Me.RBPengeluaran.Values.Text = "Pengeluaran"
        '
        'TID
        '
        Me.TID.AlwaysActive = False
        Me.TID.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TID.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TID.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TID.Enabled = False
        Me.TID.Location = New System.Drawing.Point(108, 8)
        Me.TID.MaxLength = 255
        Me.TID.Name = "TID"
        Me.TID.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TID.Size = New System.Drawing.Size(110, 29)
        Me.TID.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TID.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TID.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateActive.Border.Rounding = 0!
        Me.TID.StateActive.Border.Width = 1
        Me.TID.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TID.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TID.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateCommon.Border.Rounding = 0!
        Me.TID.StateCommon.Border.Width = 1
        Me.TID.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TID.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TID.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TID.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateDisabled.Border.Rounding = 0!
        Me.TID.StateDisabled.Border.Width = 0
        Me.TID.TabIndex = 120
        Me.TID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TNominal
        '
        Me.TNominal.AlwaysActive = False
        Me.TNominal.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TNominal.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TNominal.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TNominal.Location = New System.Drawing.Point(108, 40)
        Me.TNominal.MaxLength = 8
        Me.TNominal.Name = "TNominal"
        Me.TNominal.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TNominal.Size = New System.Drawing.Size(95, 29)
        Me.TNominal.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TNominal.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNominal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNominal.StateActive.Border.Rounding = 0!
        Me.TNominal.StateActive.Border.Width = 1
        Me.TNominal.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TNominal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TNominal.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TNominal.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNominal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNominal.StateCommon.Border.Rounding = 0!
        Me.TNominal.StateCommon.Border.Width = 1
        Me.TNominal.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TNominal.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TNominal.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TNominal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNominal.StateDisabled.Border.Rounding = 0!
        Me.TNominal.StateDisabled.Border.Width = 0
        Me.TNominal.TabIndex = 0
        '
        'TDeskripsi
        '
        Me.TDeskripsi.AlwaysActive = False
        Me.TDeskripsi.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TDeskripsi.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TDeskripsi.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TDeskripsi.Location = New System.Drawing.Point(108, 72)
        Me.TDeskripsi.MaxLength = 255
        Me.TDeskripsi.Name = "TDeskripsi"
        Me.TDeskripsi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TDeskripsi.Size = New System.Drawing.Size(995, 29)
        Me.TDeskripsi.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TDeskripsi.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TDeskripsi.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDeskripsi.StateActive.Border.Rounding = 0!
        Me.TDeskripsi.StateActive.Border.Width = 1
        Me.TDeskripsi.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TDeskripsi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TDeskripsi.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TDeskripsi.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TDeskripsi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDeskripsi.StateCommon.Border.Rounding = 0!
        Me.TDeskripsi.StateCommon.Border.Width = 1
        Me.TDeskripsi.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TDeskripsi.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TDeskripsi.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TDeskripsi.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDeskripsi.StateDisabled.Border.Rounding = 0!
        Me.TDeskripsi.StateDisabled.Border.Width = 0
        Me.TDeskripsi.TabIndex = 1
        '
        'LBLNominal
        '
        Me.LBLNominal.AutoSize = False
        Me.LBLNominal.Location = New System.Drawing.Point(8, 40)
        Me.LBLNominal.Name = "LBLNominal"
        Me.LBLNominal.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLNominal.Size = New System.Drawing.Size(94, 26)
        Me.LBLNominal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLNominal.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLNominal.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLNominal.TabIndex = 123
        Me.LBLNominal.Values.Text = "Nominal"
        '
        'LBLDeskripsi
        '
        Me.LBLDeskripsi.AutoSize = False
        Me.LBLDeskripsi.Location = New System.Drawing.Point(8, 72)
        Me.LBLDeskripsi.Name = "LBLDeskripsi"
        Me.LBLDeskripsi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLDeskripsi.Size = New System.Drawing.Size(94, 26)
        Me.LBLDeskripsi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLDeskripsi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLDeskripsi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLDeskripsi.TabIndex = 123
        Me.LBLDeskripsi.Values.Text = "Deskripsi"
        '
        'TCariData
        '
        Me.TCariData.AlwaysActive = False
        Me.TCariData.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariData.CueHint.CueHintText = "Cari laba / rugi ..."
        Me.TCariData.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCariData.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariData.Location = New System.Drawing.Point(8, 520)
        Me.TCariData.MaxLength = 255
        Me.TCariData.Name = "TCariData"
        Me.TCariData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TCariData.Size = New System.Drawing.Size(747, 29)
        Me.TCariData.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateActive.Border.Rounding = 0!
        Me.TCariData.StateActive.Border.Width = 1
        Me.TCariData.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TCariData.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
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
        Me.TCariData.TabIndex = 3
        '
        'RBPendapatan
        '
        Me.RBPendapatan.Location = New System.Drawing.Point(383, 8)
        Me.RBPendapatan.Name = "RBPendapatan"
        Me.RBPendapatan.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBPendapatan.Palette = Me.PaletPrimer
        Me.RBPendapatan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBPendapatan.Size = New System.Drawing.Size(124, 26)
        Me.RBPendapatan.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBPendapatan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RBPendapatan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.RBPendapatan.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.RBPendapatan.TabIndex = 115
        Me.RBPendapatan.Values.Text = "Pendapatan"
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
        Me.BTNSimpan.TabIndex = 4
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
        Me.BTNHapus.TabIndex = 5
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
        Me.BTNClear.TabIndex = 6
        Me.BTNClear.Values.Image = Global.Inventori.My.Resources.Resources.crud_refresh_pressed
        Me.BTNClear.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNClear.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.crud_refresh_common
        Me.BTNClear.Values.Text = ""
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AlwaysActive = False
        Me.DGVPageCounter.Enabled = False
        Me.DGVPageCounter.Location = New System.Drawing.Point(510, 488)
        Me.DGVPageCounter.MaxLength = 255
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPageCounter.TabIndex = 206
        Me.DGVPageCounter.Tag = ""
        Me.DGVPageCounter.Text = "1 / 1"
        Me.DGVPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(478, 488)
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
        Me.DGVPrev.TabIndex = 204
        Me.DGVPrev.Values.Text = "◄"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(606, 488)
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
        Me.DGVNext.TabIndex = 205
        Me.DGVNext.Values.Text = "►"
        '
        'CBTampilLabaRugi
        '
        Me.CBTampilLabaRugi.Checked = True
        Me.CBTampilLabaRugi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBTampilLabaRugi.Location = New System.Drawing.Point(8, 555)
        Me.CBTampilLabaRugi.Name = "CBTampilLabaRugi"
        Me.CBTampilLabaRugi.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTampilLabaRugi.Palette = Me.PaletPrimer
        Me.CBTampilLabaRugi.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBTampilLabaRugi.Size = New System.Drawing.Size(340, 26)
        Me.CBTampilLabaRugi.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTampilLabaRugi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBTampilLabaRugi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBTampilLabaRugi.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBTampilLabaRugi.TabIndex = 207
        Me.CBTampilLabaRugi.Values.Text = "Tampil Pendapatan / Pengeluaran Lain"
        '
        'CBTampilFaktur
        '
        Me.CBTampilFaktur.Location = New System.Drawing.Point(8, 587)
        Me.CBTampilFaktur.Name = "CBTampilFaktur"
        Me.CBTampilFaktur.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTampilFaktur.Palette = Me.PaletPrimer
        Me.CBTampilFaktur.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBTampilFaktur.Size = New System.Drawing.Size(247, 26)
        Me.CBTampilFaktur.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTampilFaktur.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBTampilFaktur.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBTampilFaktur.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBTampilFaktur.TabIndex = 208
        Me.CBTampilFaktur.Values.Text = "Tampil Pembayaran Faktur"
        '
        'LabaRugi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.CBTampilLabaRugi)
        Me.Controls.Add(Me.CBTampilFaktur)
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.TCariData)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.LBLDeskripsi)
        Me.Controls.Add(Me.LBLNominal)
        Me.Controls.Add(Me.LBLID)
        Me.Controls.Add(Me.TDeskripsi)
        Me.Controls.Add(Me.TNominal)
        Me.Controls.Add(Me.RBPendapatan)
        Me.Controls.Add(Me.RBPengeluaran)
        Me.Controls.Add(Me.TID)
        Me.Name = "LabaRugi"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1111, 638)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents RBPengeluaran As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents LBLID As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TID As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TNominal As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TDeskripsi As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLNominal As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLDeskripsi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents RBPendapatan As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents BTNSimpan As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNHapus As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents CBTampilLabaRugi As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents CBTampilFaktur As Krypton.Toolkit.KryptonCheckBox
End Class

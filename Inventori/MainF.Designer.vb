<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainF))
        Me.Sidebar = New Krypton.Toolkit.KryptonPanel()
        Me.BTNLogout = New Krypton.Toolkit.KryptonButton()
        Me.BTNLaporan = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNCatatan = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLLainnya = New Krypton.Toolkit.KryptonLabel()
        Me.BTNLabaRugi = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNKeluar = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNMasuk = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLTransaksi = New Krypton.Toolkit.KryptonLabel()
        Me.BTNCustomer = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNSupplier = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNBarang = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNUser = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLFile = New Krypton.Toolkit.KryptonLabel()
        Me.Thumbnail = New Krypton.Toolkit.KryptonButton()
        Me.Header = New System.Windows.Forms.Panel()
        Me.BTNClose = New Krypton.Toolkit.KryptonButton()
        Me.BTNMinimize = New Krypton.Toolkit.KryptonButton()
        Me.LBLTitle = New Krypton.Toolkit.KryptonLabel()
        Me.PanelForm = New System.Windows.Forms.Panel()
        CType(Me.Sidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sidebar
        '
        Me.Sidebar.Controls.Add(Me.BTNLogout)
        Me.Sidebar.Controls.Add(Me.BTNLaporan)
        Me.Sidebar.Controls.Add(Me.BTNCatatan)
        Me.Sidebar.Controls.Add(Me.LBLLainnya)
        Me.Sidebar.Controls.Add(Me.BTNLabaRugi)
        Me.Sidebar.Controls.Add(Me.BTNKeluar)
        Me.Sidebar.Controls.Add(Me.BTNMasuk)
        Me.Sidebar.Controls.Add(Me.LBLTransaksi)
        Me.Sidebar.Controls.Add(Me.BTNCustomer)
        Me.Sidebar.Controls.Add(Me.BTNSupplier)
        Me.Sidebar.Controls.Add(Me.BTNBarang)
        Me.Sidebar.Controls.Add(Me.BTNUser)
        Me.Sidebar.Controls.Add(Me.LBLFile)
        Me.Sidebar.Controls.Add(Me.Thumbnail)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Sidebar.Size = New System.Drawing.Size(159, 678)
        Me.Sidebar.StateCommon.Color1 = System.Drawing.Color.White
        Me.Sidebar.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Sidebar.TabIndex = 7
        '
        'BTNLogout
        '
        Me.BTNLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNLogout.Location = New System.Drawing.Point(0, 554)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNLogout.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogout.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogout.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNLogout.Size = New System.Drawing.Size(159, 40)
        Me.BTNLogout.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.BTNLogout.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogout.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogout.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLogout.StateCommon.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLogout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNLogout.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogout.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLogout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNLogout.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLogout.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNLogout.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNLogout.TabIndex = 10
        Me.BTNLogout.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_logout_common
        Me.BTNLogout.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNLogout.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNLogout.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNLogout.Values.ImageStates.ImagePressed = Global.Inventori.My.Resources.Resources.sidebar_logout_checked
        Me.BTNLogout.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_logout_tracking
        Me.BTNLogout.Values.Text = "Logout"
        '
        'BTNLaporan
        '
        Me.BTNLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNLaporan.Location = New System.Drawing.Point(0, 514)
        Me.BTNLaporan.Name = "BTNLaporan"
        Me.BTNLaporan.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNLaporan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLaporan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNLaporan.Size = New System.Drawing.Size(159, 40)
        Me.BTNLaporan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNLaporan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNLaporan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNLaporan.StateCommon.Border.Rounding = 0!
        Me.BTNLaporan.StateCommon.Border.Width = 2
        Me.BTNLaporan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLaporan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLaporan.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNLaporan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLaporan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLaporan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLaporan.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNLaporan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNLaporan.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNLaporan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLaporan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNLaporan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNLaporan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.StatePressed.Border.Rounding = 0!
        Me.BTNLaporan.StatePressed.Border.Width = 2
        Me.BTNLaporan.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLaporan.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLaporan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNLaporan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLaporan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLaporan.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLaporan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNLaporan.TabIndex = 9
        Me.BTNLaporan.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_laporan_checked
        Me.BTNLaporan.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_laporan_common
        Me.BTNLaporan.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_laporan_tracking
        Me.BTNLaporan.Values.Text = "Laporan"
        '
        'BTNCatatan
        '
        Me.BTNCatatan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCatatan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNCatatan.Location = New System.Drawing.Point(0, 474)
        Me.BTNCatatan.Name = "BTNCatatan"
        Me.BTNCatatan.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNCatatan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNCatatan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNCatatan.Size = New System.Drawing.Size(159, 40)
        Me.BTNCatatan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNCatatan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNCatatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNCatatan.StateCommon.Border.Rounding = 0!
        Me.BTNCatatan.StateCommon.Border.Width = 2
        Me.BTNCatatan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNCatatan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNCatatan.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNCatatan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCatatan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCatatan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNCatatan.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNCatatan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNCatatan.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNCatatan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNCatatan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNCatatan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StatePressed.Border.Rounding = 0!
        Me.BTNCatatan.StatePressed.Border.Width = 2
        Me.BTNCatatan.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCatatan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNCatatan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNCatatan.TabIndex = 8
        Me.BTNCatatan.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_catatan_checked
        Me.BTNCatatan.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_catatan_common
        Me.BTNCatatan.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_catatan_tracking
        Me.BTNCatatan.Values.Text = "Catatan"
        '
        'LBLLainnya
        '
        Me.LBLLainnya.AutoSize = False
        Me.LBLLainnya.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLLainnya.Location = New System.Drawing.Point(0, 444)
        Me.LBLLainnya.Name = "LBLLainnya"
        Me.LBLLainnya.Size = New System.Drawing.Size(159, 30)
        Me.LBLLainnya.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LBLLainnya.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLLainnya.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLainnya.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLLainnya.TabIndex = 31
        Me.LBLLainnya.Values.Text = "Lainnya"
        '
        'BTNLabaRugi
        '
        Me.BTNLabaRugi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLabaRugi.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNLabaRugi.Location = New System.Drawing.Point(0, 404)
        Me.BTNLabaRugi.Name = "BTNLabaRugi"
        Me.BTNLabaRugi.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNLabaRugi.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLabaRugi.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLabaRugi.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLabaRugi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNLabaRugi.Size = New System.Drawing.Size(159, 40)
        Me.BTNLabaRugi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNLabaRugi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLabaRugi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNLabaRugi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNLabaRugi.StateCommon.Border.Rounding = 0!
        Me.BTNLabaRugi.StateCommon.Border.Width = 2
        Me.BTNLabaRugi.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLabaRugi.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLabaRugi.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNLabaRugi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLabaRugi.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLabaRugi.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLabaRugi.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNLabaRugi.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLabaRugi.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLabaRugi.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNLabaRugi.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNLabaRugi.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLabaRugi.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLabaRugi.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLabaRugi.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNLabaRugi.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNLabaRugi.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLabaRugi.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLabaRugi.StatePressed.Border.Rounding = 0!
        Me.BTNLabaRugi.StatePressed.Border.Width = 2
        Me.BTNLabaRugi.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLabaRugi.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLabaRugi.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNLabaRugi.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLabaRugi.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLabaRugi.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLabaRugi.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNLabaRugi.TabIndex = 7
        Me.BTNLabaRugi.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_transaksi_checked
        Me.BTNLabaRugi.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_transaksi_common
        Me.BTNLabaRugi.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_transaksi_tracking
        Me.BTNLabaRugi.Values.Text = "Laba Rugi"
        '
        'BTNKeluar
        '
        Me.BTNKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNKeluar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNKeluar.Location = New System.Drawing.Point(0, 364)
        Me.BTNKeluar.Name = "BTNKeluar"
        Me.BTNKeluar.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNKeluar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNKeluar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNKeluar.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNKeluar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNKeluar.Size = New System.Drawing.Size(159, 40)
        Me.BTNKeluar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNKeluar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNKeluar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNKeluar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNKeluar.StateCommon.Border.Rounding = 0!
        Me.BTNKeluar.StateCommon.Border.Width = 2
        Me.BTNKeluar.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNKeluar.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNKeluar.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNKeluar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNKeluar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKeluar.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNKeluar.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNKeluar.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNKeluar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNKeluar.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNKeluar.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNKeluar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNKeluar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNKeluar.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNKeluar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNKeluar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNKeluar.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNKeluar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNKeluar.StatePressed.Border.Rounding = 0!
        Me.BTNKeluar.StatePressed.Border.Width = 2
        Me.BTNKeluar.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNKeluar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNKeluar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNKeluar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNKeluar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNKeluar.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNKeluar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNKeluar.TabIndex = 6
        Me.BTNKeluar.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_keluar_checked
        Me.BTNKeluar.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_keluar_common
        Me.BTNKeluar.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_keluar_tracking
        Me.BTNKeluar.Values.Text = "Keluar"
        '
        'BTNMasuk
        '
        Me.BTNMasuk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNMasuk.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNMasuk.Location = New System.Drawing.Point(0, 324)
        Me.BTNMasuk.Name = "BTNMasuk"
        Me.BTNMasuk.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNMasuk.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMasuk.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNMasuk.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNMasuk.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNMasuk.Size = New System.Drawing.Size(159, 40)
        Me.BTNMasuk.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNMasuk.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMasuk.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNMasuk.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNMasuk.StateCommon.Border.Rounding = 0!
        Me.BTNMasuk.StateCommon.Border.Width = 2
        Me.BTNMasuk.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNMasuk.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNMasuk.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNMasuk.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNMasuk.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMasuk.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNMasuk.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNMasuk.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMasuk.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNMasuk.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNMasuk.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNMasuk.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMasuk.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNMasuk.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNMasuk.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNMasuk.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNMasuk.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMasuk.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNMasuk.StatePressed.Border.Rounding = 0!
        Me.BTNMasuk.StatePressed.Border.Width = 2
        Me.BTNMasuk.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNMasuk.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNMasuk.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNMasuk.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMasuk.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNMasuk.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNMasuk.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNMasuk.TabIndex = 5
        Me.BTNMasuk.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_masuk_checked
        Me.BTNMasuk.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_masuk_common
        Me.BTNMasuk.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_masuk_tracking
        Me.BTNMasuk.Values.Text = "Masuk"
        '
        'LBLTransaksi
        '
        Me.LBLTransaksi.AutoSize = False
        Me.LBLTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLTransaksi.Location = New System.Drawing.Point(0, 294)
        Me.LBLTransaksi.Name = "LBLTransaksi"
        Me.LBLTransaksi.Size = New System.Drawing.Size(159, 30)
        Me.LBLTransaksi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LBLTransaksi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTransaksi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTransaksi.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTransaksi.TabIndex = 27
        Me.LBLTransaksi.Values.Text = "Transaksi"
        '
        'BTNCustomer
        '
        Me.BTNCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNCustomer.Location = New System.Drawing.Point(0, 254)
        Me.BTNCustomer.Name = "BTNCustomer"
        Me.BTNCustomer.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNCustomer.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCustomer.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCustomer.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNCustomer.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNCustomer.Size = New System.Drawing.Size(159, 40)
        Me.BTNCustomer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNCustomer.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCustomer.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNCustomer.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNCustomer.StateCommon.Border.Rounding = 0!
        Me.BTNCustomer.StateCommon.Border.Width = 2
        Me.BTNCustomer.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNCustomer.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNCustomer.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNCustomer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCustomer.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCustomer.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNCustomer.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNCustomer.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCustomer.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCustomer.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNCustomer.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNCustomer.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCustomer.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCustomer.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCustomer.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNCustomer.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNCustomer.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCustomer.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCustomer.StatePressed.Border.Rounding = 0!
        Me.BTNCustomer.StatePressed.Border.Width = 2
        Me.BTNCustomer.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCustomer.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCustomer.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNCustomer.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCustomer.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCustomer.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCustomer.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNCustomer.TabIndex = 4
        Me.BTNCustomer.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_customer_checked
        Me.BTNCustomer.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_customer_common
        Me.BTNCustomer.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_customer_tracking
        Me.BTNCustomer.Values.Text = "Customer"
        '
        'BTNSupplier
        '
        Me.BTNSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNSupplier.Location = New System.Drawing.Point(0, 214)
        Me.BTNSupplier.Name = "BTNSupplier"
        Me.BTNSupplier.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNSupplier.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSupplier.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNSupplier.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSupplier.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNSupplier.Size = New System.Drawing.Size(159, 40)
        Me.BTNSupplier.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNSupplier.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSupplier.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNSupplier.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNSupplier.StateCommon.Border.Rounding = 0!
        Me.BTNSupplier.StateCommon.Border.Width = 2
        Me.BTNSupplier.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSupplier.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNSupplier.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNSupplier.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNSupplier.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSupplier.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNSupplier.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNSupplier.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSupplier.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNSupplier.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNSupplier.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNSupplier.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSupplier.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNSupplier.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNSupplier.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNSupplier.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNSupplier.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSupplier.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNSupplier.StatePressed.Border.Rounding = 0!
        Me.BTNSupplier.StatePressed.Border.Width = 2
        Me.BTNSupplier.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNSupplier.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNSupplier.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNSupplier.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSupplier.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNSupplier.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNSupplier.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNSupplier.TabIndex = 3
        Me.BTNSupplier.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_supplier_checked
        Me.BTNSupplier.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_supplier_common
        Me.BTNSupplier.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_supplier_tracking
        Me.BTNSupplier.Values.Text = "Supplier"
        '
        'BTNBarang
        '
        Me.BTNBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNBarang.Location = New System.Drawing.Point(0, 174)
        Me.BTNBarang.Name = "BTNBarang"
        Me.BTNBarang.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNBarang.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBarang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNBarang.Size = New System.Drawing.Size(159, 40)
        Me.BTNBarang.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNBarang.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNBarang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNBarang.StateCommon.Border.Rounding = 0!
        Me.BTNBarang.StateCommon.Border.Width = 2
        Me.BTNBarang.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBarang.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNBarang.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNBarang.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNBarang.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBarang.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNBarang.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNBarang.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNBarang.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNBarang.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBarang.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNBarang.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNBarang.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.StatePressed.Border.Rounding = 0!
        Me.BTNBarang.StatePressed.Border.Width = 2
        Me.BTNBarang.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBarang.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNBarang.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNBarang.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBarang.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBarang.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBarang.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNBarang.TabIndex = 2
        Me.BTNBarang.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_barang_checked
        Me.BTNBarang.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_barang_common
        Me.BTNBarang.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_barang_tracking
        Me.BTNBarang.Values.Text = "Barang"
        '
        'BTNUser
        '
        Me.BTNUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNUser.Location = New System.Drawing.Point(0, 134)
        Me.BTNUser.Name = "BTNUser"
        Me.BTNUser.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNUser.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNUser.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNUser.Size = New System.Drawing.Size(159, 40)
        Me.BTNUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNUser.StateCommon.Border.Rounding = 0!
        Me.BTNUser.StateCommon.Border.Width = 2
        Me.BTNUser.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNUser.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNUser.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNUser.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUser.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNUser.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNUser.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNUser.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNUser.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNUser.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNUser.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StatePressed.Border.Rounding = 0!
        Me.BTNUser.StatePressed.Border.Width = 2
        Me.BTNUser.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNUser.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNUser.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNUser.TabIndex = 1
        Me.BTNUser.Values.Image = Global.Inventori.My.Resources.Resources.sidebar_user_checked
        Me.BTNUser.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.sidebar_user_common
        Me.BTNUser.Values.ImageStates.ImageTracking = Global.Inventori.My.Resources.Resources.sidebar_user_tracking
        Me.BTNUser.Values.Text = "User"
        '
        'LBLFile
        '
        Me.LBLFile.AutoSize = False
        Me.LBLFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLFile.Location = New System.Drawing.Point(0, 104)
        Me.LBLFile.Name = "LBLFile"
        Me.LBLFile.Size = New System.Drawing.Size(159, 30)
        Me.LBLFile.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LBLFile.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFile.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFile.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLFile.TabIndex = 21
        Me.LBLFile.Values.Text = "File"
        '
        'Thumbnail
        '
        Me.Thumbnail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Thumbnail.Dock = System.Windows.Forms.DockStyle.Top
        Me.Thumbnail.Location = New System.Drawing.Point(0, 0)
        Me.Thumbnail.Name = "Thumbnail"
        Me.Thumbnail.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.Thumbnail.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Thumbnail.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Thumbnail.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Thumbnail.Size = New System.Drawing.Size(159, 104)
        Me.Thumbnail.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.Thumbnail.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Thumbnail.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.Thumbnail.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Thumbnail.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.TabIndex = 0
        Me.Thumbnail.Values.Image = Global.Inventori.My.Resources.Resources.thumbnail_pressed
        Me.Thumbnail.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.Thumbnail.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.Thumbnail.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.Thumbnail.Values.ImageStates.ImageNormal = Global.Inventori.My.Resources.Resources.thumbnail_common
        Me.Thumbnail.Values.Text = ""
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Header.Controls.Add(Me.BTNClose)
        Me.Header.Controls.Add(Me.BTNMinimize)
        Me.Header.Controls.Add(Me.LBLTitle)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(159, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1111, 40)
        Me.Header.TabIndex = 8
        '
        'BTNClose
        '
        Me.BTNClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNClose.Location = New System.Drawing.Point(1066, 0)
        Me.BTNClose.Name = "BTNClose"
        Me.BTNClose.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNClose.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClose.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClose.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNClose.Size = New System.Drawing.Size(45, 29)
        Me.BTNClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNClose.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClose.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNClose.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClose.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, 4, -1, -1)
        Me.BTNClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.BTNClose.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClose.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BTNClose.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClose.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BTNClose.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClose.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNClose.TabIndex = 131
        Me.BTNClose.Values.Text = "✕"
        '
        'BTNMinimize
        '
        Me.BTNMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMinimize.Location = New System.Drawing.Point(1021, 0)
        Me.BTNMinimize.Name = "BTNMinimize"
        Me.BTNMinimize.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNMinimize.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMinimize.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNMinimize.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNMinimize.Size = New System.Drawing.Size(45, 29)
        Me.BTNMinimize.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNMinimize.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMinimize.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNMinimize.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNMinimize.StateCommon.Content.Padding = New System.Windows.Forms.Padding(-1, -1, -1, 6)
        Me.BTNMinimize.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.BTNMinimize.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMinimize.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNMinimize.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.BTNMinimize.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMinimize.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BTNMinimize.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMinimize.TabIndex = 134
        Me.BTNMinimize.Values.Text = "‒"
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = False
        Me.LBLTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBLTitle.Location = New System.Drawing.Point(0, 0)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTitle.Size = New System.Drawing.Size(1111, 40)
        Me.LBLTitle.StateCommon.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.LBLTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.LBLTitle.TabIndex = 133
        Me.LBLTitle.Values.Text = "Title"
        '
        'PanelForm
        '
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(159, 40)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(1111, 638)
        Me.PanelForm.TabIndex = 134
        '
        'MainF
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1270, 678)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventori"
        CType(Me.Sidebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidebar.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Sidebar As Krypton.Toolkit.KryptonPanel
    Friend WithEvents Header As Panel
    Friend WithEvents BTNClose As Krypton.Toolkit.KryptonButton
    Friend WithEvents PanelForm As Panel
    Friend WithEvents BTNLogout As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNLaporan As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNCatatan As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents LBLLainnya As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNLabaRugi As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNKeluar As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNMasuk As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents LBLTransaksi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNCustomer As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNSupplier As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNBarang As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNUser As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents LBLFile As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Thumbnail As Krypton.Toolkit.KryptonButton
    Friend WithEvents LBLTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNMinimize As Krypton.Toolkit.KryptonButton
End Class

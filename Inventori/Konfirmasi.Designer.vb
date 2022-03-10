<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konfirmasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Konfirmasi))
        Me.TDeskripsi = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLTitle = New Krypton.Toolkit.KryptonLabel()
        Me.PBIcon = New System.Windows.Forms.PictureBox()
        Me.BTNTidak = New Krypton.Toolkit.KryptonButton()
        Me.BTNYa = New Krypton.Toolkit.KryptonButton()
        Me.PanelKonfirmasi = New Krypton.Toolkit.KryptonGroup()
        CType(Me.PBIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelKonfirmasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelKonfirmasi.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelKonfirmasi.Panel.SuspendLayout()
        Me.PanelKonfirmasi.SuspendLayout()
        Me.SuspendLayout()
        '
        'TDeskripsi
        '
        Me.TDeskripsi.AlwaysActive = False
        Me.TDeskripsi.Enabled = False
        Me.TDeskripsi.Location = New System.Drawing.Point(68, 40)
        Me.TDeskripsi.MaxLength = 255
        Me.TDeskripsi.Multiline = True
        Me.TDeskripsi.Name = "TDeskripsi"
        Me.TDeskripsi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TDeskripsi.Size = New System.Drawing.Size(366, 60)
        Me.TDeskripsi.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.TDeskripsi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TDeskripsi.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TDeskripsi.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.TDeskripsi.TabIndex = 130
        Me.TDeskripsi.Text = "-"
        '
        'LBLTitle
        '
        Me.LBLTitle.Location = New System.Drawing.Point(64, 10)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(18, 24)
        Me.LBLTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTitle.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLTitle.TabIndex = 129
        Me.LBLTitle.Values.Text = "-"
        '
        'PBIcon
        '
        Me.PBIcon.Image = Global.Inventori.My.Resources.Resources.konfirmasi
        Me.PBIcon.Location = New System.Drawing.Point(10, 10)
        Me.PBIcon.Name = "PBIcon"
        Me.PBIcon.Size = New System.Drawing.Size(48, 48)
        Me.PBIcon.TabIndex = 128
        Me.PBIcon.TabStop = False
        '
        'BTNTidak
        '
        Me.BTNTidak.Location = New System.Drawing.Point(317, 104)
        Me.BTNTidak.Name = "BTNTidak"
        Me.BTNTidak.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNTidak.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTidak.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNTidak.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNTidak.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNTidak.Size = New System.Drawing.Size(119, 27)
        Me.BTNTidak.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNTidak.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTidak.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNTidak.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNTidak.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNTidak.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTidak.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNTidak.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNTidak.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNTidak.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTidak.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNTidak.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNTidak.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNTidak.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNTidak.TabIndex = 126
        Me.BTNTidak.Values.Text = "Tidak"
        '
        'BTNYa
        '
        Me.BTNYa.Location = New System.Drawing.Point(192, 104)
        Me.BTNYa.Name = "BTNYa"
        Me.BTNYa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNYa.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNYa.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNYa.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNYa.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNYa.Size = New System.Drawing.Size(119, 27)
        Me.BTNYa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNYa.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNYa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNYa.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNYa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNYa.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNYa.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNYa.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNYa.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNYa.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNYa.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNYa.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNYa.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNYa.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNYa.TabIndex = 127
        Me.BTNYa.Values.Text = "Ya"
        '
        'PanelKonfirmasi
        '
        Me.PanelKonfirmasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonfirmasi.Location = New System.Drawing.Point(0, 0)
        Me.PanelKonfirmasi.Name = "PanelKonfirmasi"
        Me.PanelKonfirmasi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelKonfirmasi.Panel
        '
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.PBIcon)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.TDeskripsi)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.BTNYa)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.LBLTitle)
        Me.PanelKonfirmasi.Panel.Controls.Add(Me.BTNTidak)
        Me.PanelKonfirmasi.Size = New System.Drawing.Size(450, 145)
        Me.PanelKonfirmasi.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.PanelKonfirmasi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelKonfirmasi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelKonfirmasi.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelKonfirmasi.StateCommon.Border.Width = 2
        Me.PanelKonfirmasi.TabIndex = 133
        '
        'Konfirmasi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 145)
        Me.Controls.Add(Me.PanelKonfirmasi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Konfirmasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konfirmasi"
        CType(Me.PBIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelKonfirmasi.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKonfirmasi.Panel.ResumeLayout(False)
        Me.PanelKonfirmasi.Panel.PerformLayout()
        CType(Me.PanelKonfirmasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKonfirmasi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TDeskripsi As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PBIcon As PictureBox
    Friend WithEvents BTNTidak As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNYa As Krypton.Toolkit.KryptonButton
    Friend WithEvents PanelKonfirmasi As Krypton.Toolkit.KryptonGroup
End Class

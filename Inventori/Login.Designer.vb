<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Thumbnail = New Krypton.Toolkit.KryptonButton()
        Me.LBLUsername = New Krypton.Toolkit.KryptonLabel()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.LBLPassword = New Krypton.Toolkit.KryptonLabel()
        Me.LBLBatal = New Krypton.Toolkit.KryptonLabel()
        Me.BTNLogin = New Krypton.Toolkit.KryptonButton()
        Me.CBCookies = New Krypton.Toolkit.KryptonCheckBox()
        Me.PanelLogin = New Krypton.Toolkit.KryptonGroup()
        Me.TPassword = New Krypton.Toolkit.KryptonTextBox()
        Me.TUsername = New Krypton.Toolkit.KryptonTextBox()
        CType(Me.PanelLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelLogin.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogin.Panel.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Thumbnail
        '
        Me.Thumbnail.Cursor = System.Windows.Forms.Cursors.Default
        Me.Thumbnail.Location = New System.Drawing.Point(124, 14)
        Me.Thumbnail.Name = "Thumbnail"
        Me.Thumbnail.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.Thumbnail.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Thumbnail.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Thumbnail.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Thumbnail.Size = New System.Drawing.Size(133, 133)
        Me.Thumbnail.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.Thumbnail.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Thumbnail.TabIndex = 5
        Me.Thumbnail.Values.Image = Global.Inventori.My.Resources.Resources.thumbnail_login
        Me.Thumbnail.Values.Text = ""
        '
        'LBLUsername
        '
        Me.LBLUsername.AutoSize = False
        Me.LBLUsername.Location = New System.Drawing.Point(7, 164)
        Me.LBLUsername.Name = "LBLUsername"
        Me.LBLUsername.Size = New System.Drawing.Size(92, 26)
        Me.LBLUsername.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLUsername.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLUsername.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLUsername.TabIndex = 127
        Me.LBLUsername.Values.Text = "Username"
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
        'LBLPassword
        '
        Me.LBLPassword.AutoSize = False
        Me.LBLPassword.Location = New System.Drawing.Point(7, 246)
        Me.LBLPassword.Name = "LBLPassword"
        Me.LBLPassword.Size = New System.Drawing.Size(92, 26)
        Me.LBLPassword.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPassword.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPassword.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPassword.TabIndex = 126
        Me.LBLPassword.Values.Text = "Password"
        '
        'LBLBatal
        '
        Me.LBLBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLBatal.Location = New System.Drawing.Point(323, 407)
        Me.LBLBatal.Name = "LBLBatal"
        Me.LBLBatal.Size = New System.Drawing.Size(47, 22)
        Me.LBLBatal.StateCommon.ShortText.Color1 = System.Drawing.SystemColors.Highlight
        Me.LBLBatal.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBatal.TabIndex = 4
        Me.LBLBatal.Values.Text = "Batal"
        '
        'BTNLogin
        '
        Me.BTNLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLogin.Enabled = False
        Me.BTNLogin.Location = New System.Drawing.Point(10, 365)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLogin.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogin.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNLogin.Size = New System.Drawing.Size(360, 38)
        Me.BTNLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLogin.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogin.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNLogin.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNLogin.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNLogin.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNLogin.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNLogin.TabIndex = 3
        Me.BTNLogin.Values.Text = "Login"
        '
        'CBCookies
        '
        Me.CBCookies.Location = New System.Drawing.Point(11, 314)
        Me.CBCookies.Name = "CBCookies"
        Me.CBCookies.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBCookies.Palette = Me.PaletPrimer
        Me.CBCookies.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBCookies.Size = New System.Drawing.Size(140, 25)
        Me.CBCookies.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBCookies.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBCookies.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CBCookies.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBCookies.TabIndex = 2
        Me.CBCookies.Values.Text = "Remember Me"
        '
        'PanelLogin
        '
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelLogin.Panel
        '
        Me.PanelLogin.Panel.Controls.Add(Me.TPassword)
        Me.PanelLogin.Panel.Controls.Add(Me.TUsername)
        Me.PanelLogin.Panel.Controls.Add(Me.BTNLogin)
        Me.PanelLogin.Panel.Controls.Add(Me.CBCookies)
        Me.PanelLogin.Panel.Controls.Add(Me.Thumbnail)
        Me.PanelLogin.Panel.Controls.Add(Me.LBLBatal)
        Me.PanelLogin.Panel.Controls.Add(Me.LBLUsername)
        Me.PanelLogin.Panel.Controls.Add(Me.LBLPassword)
        Me.PanelLogin.Size = New System.Drawing.Size(384, 437)
        Me.PanelLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelLogin.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelLogin.StateCommon.Border.Color1 = System.Drawing.Color.Magenta
        Me.PanelLogin.StateCommon.Border.Color2 = System.Drawing.Color.Lime
        Me.PanelLogin.StateCommon.Border.ColorAngle = 45.0!
        Me.PanelLogin.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.PanelLogin.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelLogin.StateCommon.Border.Width = 2
        Me.PanelLogin.TabIndex = 128
        '
        'TPassword
        '
        Me.TPassword.AlwaysActive = False
        Me.TPassword.Location = New System.Drawing.Point(12, 278)
        Me.TPassword.MaxLength = 255
        Me.TPassword.Name = "TPassword"
        Me.TPassword.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TPassword.Size = New System.Drawing.Size(356, 29)
        Me.TPassword.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TPassword.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPassword.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPassword.StateActive.Border.Rounding = 0!
        Me.TPassword.StateActive.Border.Width = 1
        Me.TPassword.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPassword.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TPassword.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPassword.StateCommon.Border.Rounding = 0!
        Me.TPassword.StateCommon.Border.Width = 1
        Me.TPassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPassword.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPassword.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPassword.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPassword.StateDisabled.Border.Rounding = 0!
        Me.TPassword.StateDisabled.Border.Width = 0
        Me.TPassword.TabIndex = 1
        Me.TPassword.UseSystemPasswordChar = True
        '
        'TUsername
        '
        Me.TUsername.AlwaysActive = False
        Me.TUsername.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TUsername.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TUsername.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TUsername.Location = New System.Drawing.Point(12, 196)
        Me.TUsername.MaxLength = 255
        Me.TUsername.Name = "TUsername"
        Me.TUsername.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TUsername.Size = New System.Drawing.Size(356, 29)
        Me.TUsername.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TUsername.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUsername.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUsername.StateActive.Border.Rounding = 0!
        Me.TUsername.StateActive.Border.Width = 1
        Me.TUsername.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TUsername.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TUsername.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TUsername.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUsername.StateCommon.Border.Rounding = 0!
        Me.TUsername.StateCommon.Border.Width = 1
        Me.TUsername.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TUsername.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TUsername.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TUsername.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TUsername.StateDisabled.Border.Rounding = 0!
        Me.TUsername.StateDisabled.Border.Width = 0
        Me.TUsername.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 437)
        Me.Controls.Add(Me.PanelLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PanelLogin.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogin.Panel.ResumeLayout(False)
        Me.PanelLogin.Panel.PerformLayout()
        CType(Me.PanelLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Thumbnail As Krypton.Toolkit.KryptonButton
    Friend WithEvents LBLUsername As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents LBLPassword As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLBatal As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNLogin As Krypton.Toolkit.KryptonButton
    Friend WithEvents CBCookies As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents PanelLogin As Krypton.Toolkit.KryptonGroup
    Friend WithEvents TUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TPassword As Krypton.Toolkit.KryptonTextBox
End Class

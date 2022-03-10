<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notifikasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notifikasi))
        Me.Notif = New Krypton.Toolkit.KryptonButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Notif
        '
        Me.Notif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notif.Location = New System.Drawing.Point(0, 0)
        Me.Notif.Name = "Notif"
        Me.Notif.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.Notif.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Notif.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Notif.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Notif.Size = New System.Drawing.Size(380, 70)
        Me.Notif.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.Notif.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Notif.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Notif.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.Notif.StateCommon.Border.Width = 2
        Me.Notif.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Notif.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.Notif.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Notif.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Notif.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notif.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.Notif.TabIndex = 1
        Me.Notif.Values.Image = Global.Inventori.My.Resources.Resources.berhasil
        Me.Notif.Values.Text = "Notif"
        '
        'Timer1
        '
        '
        'Notifikasi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 70)
        Me.Controls.Add(Me.Notif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Notifikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notifikasi"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Notif As Krypton.Toolkit.KryptonButton
    Friend WithEvents Timer1 As Timer
End Class

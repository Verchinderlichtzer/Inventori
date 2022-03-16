Imports MadMilkman.Ini
Public Class Login

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Private Declare Sub keybd_event Lib "user32" (bVk As Byte, bScan As Byte, dwFlags As Integer, dwExtraInfo As Integer)
    Dim x As Integer = 45

    Public Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelLogin.Panel.MouseDown, Thumbnail.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelLogin.Panel.MouseMove, Thumbnail.MouseMove
        If MoveForm Then Location += e.Location - MoveForm_MousePosition
    End Sub

    Public Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelLogin.Panel.MouseUp, Thumbnail.MouseUp
        If e.Button = MouseButtons.Left Then MoveForm = 0
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TUsername.TextChanged, TPassword.TextChanged
        If TUsername.Text = "" Or TPassword.Text = "" Then BTNLogin.Enabled = 0 Else BTNLogin.Enabled = 1
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsKeyLocked(Keys.CapsLock) Then
            Call keybd_event(Keys.CapsLock, &H14, 1, 0)
            Call keybd_event(Keys.CapsLock, &H14, 3, 0)
        End If
        TUsername.Focus()
    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        QR("SELECT Username FROM TBLUser WHERE Username = '" & TUsername.Text & "' AND [Password] = '" & TPassword.Text & "'")
        If Not DR.HasRows Then
            Pesan("Username / Password salah", 0)
        Else
            If CBCookies.Checked = True And TUsername.Text <> "Admin" Then
                Dim Ini As New IniFile
                Ini.Load(Path & "\Dev.ini")
                Ini.Sections("konfigurasi").Keys("cookies").Value = DR(0).ToString
                Ini.Save(Path & "\Dev.ini")
            End If
            UserAktif = DR(0)
            MainF.Show()
            MainF.Thumbnail.PerformClick()
            Visible = 0
        End If
    End Sub

    Private Sub LBLBatal_Click(sender As Object, e As EventArgs) Handles LBLBatal.Click
        Application.ExitThread()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, koentji As Keys) As Boolean
        If msg.WParam.ToInt32() = Keys.Enter And BTNLogin.Enabled = True Then
            BTNLogin.PerformClick()
            Return True
        ElseIf msg.WParam.ToInt32() = Keys.Escape Then
            Application.ExitThread()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, koentji)
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.Style = &HA0000
            Return CP
        End Get
    End Property

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x += 3
        PanelLogin.StateCommon.Border.ColorAngle = x
    End Sub
End Class
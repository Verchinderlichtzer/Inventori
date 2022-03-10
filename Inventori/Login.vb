Imports MadMilkman.Ini
Public Class Login

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then Location += (e.Location - MoveForm_MousePosition)
    End Sub

    Public Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then MoveForm = 0
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TUsername.TextChanged, TPassword.TextChanged
        If TUsername.Text = "" Or TPassword.Text = "" Then BTNLogin.Enabled = 0 Else BTNLogin.Enabled = 1
    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        QR("SELECT username FROM tbluser WHERE username = '" & TUsername.Text & "' and password = '" & TPassword.Text & "'")
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

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal koentji As Keys) As Boolean
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
End Class
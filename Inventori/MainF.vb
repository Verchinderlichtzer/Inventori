Imports MadMilkman.Ini
Public Class MainF
    Friend Uc As UserControl

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub LBLTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub LBLTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseMove
        If MoveForm Then Location += (e.Location - MoveForm_MousePosition)
    End Sub

    Public Sub LBLTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseUp
        If e.Button = MouseButtons.Left Then MoveForm = 0
    End Sub

    Sub HakAkses()
        Dim Kolom = 0
        If UserAktif.ToString.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then BTNUser.Enabled = 1 Else BTNUser.Enabled = 0
        QR("SELECT Barang, Supplier, Customer, Masuk, Keluar, LabaRugi FROM TBLUser WHERE Username = '" & UserAktif & "'")
        Dim BTNMenuAkses() As Object = {BTNBarang, BTNSupplier, BTNCustomer, BTNMasuk, BTNKeluar, BTNLabaRugi} 'Semua BTNMenu, kecuali User dan Kategori Lain
        For Each BTN In BTNMenuAkses
            If DR(Kolom) = 0 Then
                BTN.Enabled = 0
                BTN.Checked = 0
            Else
                BTN.Enabled = 1
            End If
            Kolom += 1
        Next
    End Sub

    Private Sub BTNForm(sender As Object, e As EventArgs) Handles BTNUser.Click, BTNLaporan.Click, Thumbnail.Click, BTNCatatan.Click, BTNSupplier.Click, BTNMasuk.Click, BTNLabaRugi.Click, BTNKeluar.Click, BTNCustomer.Click, BTNBarang.Click
        PanelForm.Controls.Clear()
        HakAkses()
        Dim BTNMenu() As Object = {BTNUser, BTNBarang, BTNSupplier, BTNCustomer, BTNMasuk, BTNKeluar, BTNLabaRugi, BTNCatatan, BTNLaporan} 'Semua BTNMenu
        For Each x In BTNMenu
            x.Checked = 0
            If x Is sender Then x.Checked = 1
        Next
        If sender Is Thumbnail Then
            LBLTitle.Text = "Dashboard"
            LBLTitle.Values.Image = My.Resources.title_home
            Uc = New Dashboard
        ElseIf sender Is BTNUser Then
            LBLTitle.Text = "User"
            LBLTitle.Values.Image = My.Resources.title_user
            Uc = New User
        ElseIf sender Is BTNBarang Then
            LBLTitle.Text = "Barang"
            LBLTitle.Values.Image = My.Resources.title_barang
            Uc = New Barang
        ElseIf sender Is BTNSupplier Then
            LBLTitle.Text = "Supplier"
            LBLTitle.Values.Image = My.Resources.title_supplier
            Uc = New Supplier
        ElseIf sender Is BTNCustomer Then
            LBLTitle.Text = "Customer"
            LBLTitle.Values.Image = My.Resources.title_customer
            Uc = New Customer
        ElseIf sender Is BTNMasuk Then
            LBLTitle.Text = "Purchase Order"
            LBLTitle.Values.Image = My.Resources.title_masuk
            Uc = New Masuk
        ElseIf sender Is BTNKeluar Then
            LBLTitle.Text = "Keluar"
            LBLTitle.Values.Image = My.Resources.title_keluar
            Uc = New Keluar
        ElseIf sender Is BTNLabaRugi Then
            LBLTitle.Text = "Laba Rugi"
            LBLTitle.Values.Image = My.Resources.title_transaksi
            Uc = New LabaRugi
        ElseIf sender Is BTNCatatan Then
            LBLTitle.Text = "Catatan"
            LBLTitle.Values.Image = My.Resources.title_catatan
            Uc = New Catatan
        ElseIf sender Is BTNLaporan Then
            LBLTitle.Text = "Laporan"
            LBLTitle.Values.Image = My.Resources.title_laporan
            Uc = New Laporan
        End If
        PanelForm.Controls.Add(Uc)
    End Sub

    Private Sub MainF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HakAkses()
        Thumbnail.PerformClick()
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        Dim Ini As New IniFile
        Ini.Load(Path & "\Dev.ini")
        Ini.Sections("konfigurasi").Keys("cookies").Value = 0
        Ini.Save(Path & "\Dev.ini")
        Visible = 0
        Login.Show()
        Login.TUsername.Clear()
        Login.TPassword.Clear()
        Login.CBCookies.Checked = 0
        Login.TUsername.Focus()
    End Sub

    Private Sub BTNMinimize_Click(sender As Object, e As EventArgs) Handles BTNMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNClose_Click(sender As Object, e As EventArgs) Handles BTNClose.Click
        Application.ExitThread()
    End Sub

    Private Sub MainF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.Style = &HA0000
            Return CP
        End Get
    End Property
End Class
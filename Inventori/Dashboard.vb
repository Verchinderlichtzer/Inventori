Imports MadMilkman.Ini
Public Class Dashboard

    Dim KeluarHarian As Integer
    Dim KeluarMingguan As Integer
    Dim KeluarBulanan As Integer
    Dim KeluarTahunan As Integer
    Dim KeluarSemua As Integer

    Dim MasukHarian As Integer
    Dim MasukMingguan As Integer
    Dim MasukBulanan As Integer
    Dim MasukTahunan As Integer
    Dim MasukSemua As Integer

    Dim PendapatanHarian As Integer
    Dim PendapatanMingguan As Integer
    Dim PendapatanBulanan As Integer
    Dim PendapatanTahunan As Integer
    Dim PendapatanSemua As Integer

    Dim PengeluaranHarian As Integer
    Dim PengeluaranMingguan As Integer
    Dim PengeluaranBulanan As Integer
    Dim PengeluaranTahunan As Integer
    Dim PengeluaranSemua As Integer

    Sub TampilFaktur()
        TFaktur.Items.Clear()
        QRL("SELECT ID_Masuk, Tanggal FROM TBLMasuk UNION ALL SELECT ID_Keluar, Tanggal FROM TBLKeluar ORDER BY Tanggal DESC")
        Do While DR.Read
            TFaktur.Items.Add(DR(0))
        Loop
    End Sub

    Private Sub TampilRiwayat(sender As Object, e As EventArgs) Handles TFaktur.SelectedIndexChanged
        QR("SELECT SUM(TotalHarga), SUM(Diskon) FROM TBLDetailMasuk WHERE ID_Masuk = '" & TFaktur.SelectedItem & "' UNION ALL SELECT SUM(TotalHarga), SUM(Diskon) FROM TBLDetailKeluar WHERE ID_Keluar = '" & TFaktur.SelectedItem & "'")
        If Microsoft.VisualBasic.Left(TFaktur.SelectedItem, 1) = "K" Then DR.Read()
        If IsDBNull(DR(0)) Then Exit Sub
        TTotalHarga.Text = "Rp " & FormatNumber(DR(0), 0)
        TDiskon.Text = "Rp " & FormatNumber(DR(1), 0)
        QR("SELECT FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM'), Nama, Subtotal, PPN, BiayaLain, Terbayar, Status, Keterangan FROM TBLSupplier INNER JOIN TBLMasuk ON TBLSupplier.ID_Supplier = TBLMasuk.ID_Supplier WHERE ID_Masuk = '" & TFaktur.SelectedItem & "' UNION ALL SELECT FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM'), Nama, Subtotal, PPN, BiayaLain, Terbayar, Status, Keterangan FROM TBLCustomer INNER JOIN TBLKeluar ON TBLCustomer.ID_Customer = TBLKeluar.ID_Customer WHERE ID_Keluar = '" & TFaktur.SelectedItem & "'")
        LBLTanggal.Text = DR(0)
        TSupplierCustomer.Text = DR("Nama")
        TPPN.Text = "Rp " & FormatNumber(DR("PPN"), 0)
        TBiayaLain.Text = "Rp " & FormatNumber(DR("BiayaLain"), 0)
        TGrandTotal.Text = "Rp " & FormatNumber(DR("Subtotal") + DR("PPN") + DR("BiayaLain"), 0)
        TTerbayar.Text = "Rp " & FormatNumber(DR("Terbayar"), 0) & " (" & DR("Status") & ")"
        TKeterangan.Text = DR("Keterangan")
        If Microsoft.VisualBasic.Left(TFaktur.SelectedItem, 1) = "M" Then
            LBLRiwayatTransaksi.Text = "Riwayat Transaksi (Masuk)"
            LBLSupplierCustomer.Text = "Supplier"
        Else
            LBLRiwayatTransaksi.Text = "Riwayat Transaksi (Keluar)"
            LBLSupplierCustomer.Text = "Customer"
        End If
    End Sub

    Sub TampilProfil()
        QR("SELECT * FROM TBLInfo")
        TNama.Text = DR(0)
        TAlamat.Text = DR(1)
        TTelepon.Text = DR(2)
        TFax.Text = DR(3)
        TEmail.Text = DR(4)
        TWebsite.Text = DR(5)
        TPengurus.Text = DR(6)
        TJabatan.Text = DR(7)
        TBank.Text = DR(8)
        TRekening.Text = DR(9)
        TAtasNama.Text = DR(10)
    End Sub

    Sub TampilKeluar()
        QR("SELECT COUNT(*) FROM TBLKeluar")
        If IsDBNull(DR(0)) Then Exit Sub Else KeluarSemua = DR(0)
        QR("SELECT COUNT(*) FROM TBLKeluar WHERE DATEVALUE(Tanggal) = #" & Format(Today, "MM/dd/yyyy") & "#")
        KeluarHarian = DR(0)
        QR("SELECT COUNT(*) FROM TBLKeluar WHERE DATEVALUE(Tanggal) BETWEEN #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 1, Today), "MM/dd/yyyy") & "# AND #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 7, Today), "MM/dd/yyyy") & "#")
        KeluarMingguan = DR(0)
        QR("SELECT COUNT(*) FROM TBLKeluar WHERE MONTH(Tanggal) = '" & Month(Today) & "' AND YEAR(Tanggal) = '" & Year(Today) & "'")
        KeluarBulanan = DR(0)
        QR("SELECT COUNT(*) FROM TBLKeluar WHERE YEAR(Tanggal) = '" & Year(Today) & "'")
        KeluarTahunan = DR(0)
    End Sub

    Sub TampilPendapatan()
        QR("SELECT SUM(Nominal) FROM TBLBayarKeluar")
        If IsDBNull(DR(0)) Then Exit Sub Else PendapatanSemua = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayarKeluar WHERE DATEVALUE(Tanggal) = #" & Format(Today, "MM/dd/yyyy") & "#")
        If Not IsDBNull(DR(0)) Then PendapatanHarian = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayarKeluar WHERE DATEVALUE(Tanggal) BETWEEN #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 1, Today), "MM/dd/yyyy") & "# AND #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 7, Today), "MM/dd/yyyy") & "#")
        If Not IsDBNull(DR(0)) Then PendapatanMingguan = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayarKeluar WHERE MONTH(Tanggal) = '" & Month(Today) & "' AND YEAR(Tanggal) = '" & Year(Today) & "'")
        If Not IsDBNull(DR(0)) Then PendapatanBulanan = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayarKeluar WHERE YEAR(Tanggal) = '" & Year(Today) & "'")
        If Not IsDBNull(DR(0)) Then PendapatanTahunan = DR(0)
    End Sub

    Sub TampilMasuk()
        QR("SELECT COUNT(*) FROM TBLMasuk WHERE NOT Status = 'PO'")
        If IsDBNull(DR(0)) Then Exit Sub Else MasukSemua = DR(0)
        QR("SELECT COUNT(*) FROM TBLMasuk WHERE DATEVALUE(Tanggal) = #" & Format(Today, "MM/dd/yyyy") & "# AND NOT Status = 'PO'")
        MasukHarian = DR(0)
        QR("SELECT COUNT(*) FROM TBLMasuk WHERE DATEVALUE(Tanggal) BETWEEN #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 1, Today), "MM/dd/yyyy") & "# AND #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 7, Today), "MM/dd/yyyy") & "# AND NOT Status = 'PO'")
        MasukMingguan = DR(0)
        QR("SELECT COUNT(*) FROM TBLMasuk WHERE MONTH(Tanggal) = '" & Month(Today) & "' AND YEAR(Tanggal) = '" & Year(Today) & "' AND NOT Status = 'PO'")
        MasukBulanan = DR(0)
        QR("SELECT COUNT(*) FROM TBLMasuk WHERE YEAR(Tanggal) = '" & Year(Today) & "' AND NOT Status = 'PO'")
        MasukTahunan = DR(0)
    End Sub

    Sub TampilPengeluaran()
        QR("SELECT SUM(Nominal) FROM TBLBayarMasuk")
        If IsDBNull(DR(0)) Then Exit Sub Else PengeluaranSemua = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayarMasuk WHERE DATEVALUE(Tanggal) = #" & Format(Today, "MM/dd/yyyy") & "#")
        If Not IsDBNull(DR(0)) Then PengeluaranHarian = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayarMasuk WHERE DATEVALUE(Tanggal) BETWEEN #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 1, Today), "MM/dd/yyyy") & "# AND #" & Format(DateAdd(DateInterval.Day, -Weekday(Today, FirstDayOfWeek.Monday) + 7, Today), "MM/dd/yyyy") & "#")
        If Not IsDBNull(DR(0)) Then PengeluaranMingguan = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayarMasuk WHERE MONTH(Tanggal) = '" & Month(Today) & "' AND YEAR(Tanggal) = '" & Year(Today) & "'")
        If Not IsDBNull(DR(0)) Then PengeluaranBulanan = DR(0)
        QR("SELECT SUM(Nominal) FROM TBLBayarMasuk WHERE YEAR(Tanggal) = '" & Year(Today) & "'")
        If Not IsDBNull(DR(0)) Then PengeluaranTahunan = DR(0)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TPPNOtomatis.Text = PPNOtomatis
        TampilProfil()
        TampilFaktur()
        TampilKeluar()
        TampilPendapatan()
        TampilMasuk()
        TampilPengeluaran()
        LBLUserAktif.Text = UserAktif
        If UserAktif = "Admin" Then
            LBLBackupDB.Visible = 1
            LBLHapusTransaksi.Visible = 1
            TNama.ReadOnly = 0
            TAlamat.ReadOnly = 0
            TTelepon.ReadOnly = 0
            TFax.ReadOnly = 0
            TEmail.ReadOnly = 0
            TWebsite.ReadOnly = 0
            TBank.ReadOnly = 0
            TRekening.ReadOnly = 0
            TAtasNama.ReadOnly = 0
            TPengurus.ReadOnly = 0
            TJabatan.ReadOnly = 0
        Else
            LBLBackupDB.Visible = 0
            LBLHapusTransaksi.Visible = 0
            TNama.ReadOnly = 1
            TAlamat.ReadOnly = 1
            TTelepon.ReadOnly = 1
            TFax.ReadOnly = 1
            TEmail.ReadOnly = 1
            TWebsite.ReadOnly = 1
            TBank.ReadOnly = 1
            TRekening.ReadOnly = 1
            TAtasNama.ReadOnly = 1
            TPengurus.ReadOnly = 1
            TJabatan.ReadOnly = 1
        End If
        DGV.Rows.Add("Harian", KeluarHarian, PendapatanHarian, MasukHarian, PengeluaranHarian, PendapatanHarian - PengeluaranHarian)
        DGV.Rows.Add("Mingguan", KeluarMingguan, PendapatanMingguan, MasukMingguan, PengeluaranMingguan, PendapatanMingguan - PengeluaranMingguan)
        DGV.Rows.Add("Bulanan", KeluarBulanan, PendapatanBulanan, MasukBulanan, PengeluaranBulanan, PendapatanBulanan - PengeluaranBulanan)
        DGV.Rows.Add("Tahunan", KeluarTahunan, PendapatanTahunan, MasukTahunan, PengeluaranTahunan, PendapatanTahunan - PengeluaranTahunan)
        DGV.Rows.Add("Semua", KeluarSemua, PendapatanSemua, MasukSemua, PengeluaranSemua, PendapatanSemua - PengeluaranSemua)
    End Sub

    Private Sub BTNGantiPw_Click(sender As Object, e As EventArgs) Handles BTNGantiPw.Click
        QR("SELECT [Password] FROM TBLUser WHERE Username = '" & UserAktif & "'")
        If TPwLama.Text <> DR(0) Then
            Pesan("Password salah.", 0)
        Else
            QN("UPDATE TBLUser SET [Password] = '" & TPwBaru.Text & "' WHERE Username = '" & UserAktif & "'")
            Pesan("Password berhasil diubah.", 1)
            PanelGantiPw.Visible = 0
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, koentji As Keys) As Boolean
        If koentji = Keys.Enter Then
            If TPwLama.Text <> "" And TPwBaru.Text <> "" Then BTNGantiPw.PerformClick() Else BTNSimpan.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, koentji)
    End Function

    Private Sub TPPNOtomatis_TextChanged(sender As Object, e As EventArgs) Handles TPPNOtomatis.TextChanged
        Dim Ini As New IniFile
        Ini.Load(Path & "\Dev.ini")
        Ini.Sections("konfigurasi").Keys("ppn").Value = TPPNOtomatis.Text
        Ini.Save(Path & "\Dev.ini")
        If TPPNOtomatis.Text <> "" Then PPNOtomatis = TPPNOtomatis.Text
    End Sub

    Private Sub CBGantiPw_CheckedChanged(sender As Object, e As EventArgs) Handles CBGantiPw.CheckedChanged
        TPwLama.Clear()
        TPwBaru.Clear()
        If CBGantiPw.Checked = True Then PanelGantiPw.Visible = 1 Else PanelGantiPw.Visible = 0
        TPwLama.Focus()
    End Sub

    Private Sub LBLBackupDB_Click(sender As Object, e As EventArgs) Handles LBLBackupDB.Click
        With SaveFileDialog1
            .FileName = "DBInventori" & Format(Today, "yyMMdd") & ".accdb"
            .Filter = "Microsoft Access 2007 - 2016(*.accdb)|*.accdb"
            .FilterIndex = 1
        End With
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(Path & "\Dev.accdb", SaveFileDialog1.FileName, overwrite:=True)
            Pesan("Database berhasil dibackup.", 1)
        End If
    End Sub

    Private Sub LBLAuthor_Click(sender As Object, e As EventArgs) Handles LBLAuthor.Click
        Process.Start("https://www.facebook.com/Verchinderlichtzer/")
    End Sub

    Private Sub LBLHapusTransaksi_Click(sender As Object, e As EventArgs) Handles LBLHapusTransaksi.Click
        Dim Confirm As New Konfirmasi("Konfirmasi", "Hapus SEMUA data transaksi?")
        If UserAktif = "Admin" AndAlso Confirm.ShowDialog() = DialogResult.Yes Then
            Dim NamaTabel() As String = {"TBLTransaksi", "TBLKeluar", "TBLMasuk", "TBLLabaRugi"}
            For Each x In NamaTabel
                QN("DELETE FROM " & x & "")
            Next
            QN("UPDATE TBLBarang SET Stok = 0")
            Pesan("Semua data transaksi berhasil dihapus.", 1)
            TFaktur.Enabled = 0
            TampilFaktur()
            TampilKeluar()
            TampilPendapatan()
            TampilMasuk()
            TampilPengeluaran()
        End If
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        QN("UPDATE TBLInfo SET Nama = '" & TNama.Text & "', Alamat = '" & TAlamat.Text & "', Telepon = '" & TTelepon.Text & "', Fax = '" & TFax.Text & "', Email = '" & TEmail.Text & "', Website = '" & TWebsite.Text & "', Pengurus = '" & TPengurus.Text & "', Jabatan = '" & TJabatan.Text & "', Bank = '" & TBank.Text & "', Rekening = '" & TRekening.Text & "', AtasNama = '" & TAtasNama.Text & "'")
        Pesan("Info Perusahaan berhasil diubah", 1)
    End Sub
End Class
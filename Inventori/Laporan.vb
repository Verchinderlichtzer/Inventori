Imports System.Data.OleDb, Microsoft.Reporting.WinForms
Public Class Laporan

    Dim FilterJenis As String = Nothing
    Dim FilterTanggal As String = Nothing
    Dim LaporanTerpilih As String
    Dim FullQuery As String
    Dim Waktu As String
    Dim IDEntitas As String
    Dim NamaEntitas As String

    Dim TampilDeskripsi As ReportParameter
    Dim TampilNama As ReportParameter
    Dim TampilAlamat As ReportParameter
    Dim TampilTelepon As ReportParameter
    Dim TampilFax As ReportParameter
    Dim TampilEmail As ReportParameter
    Dim TampilWebsite As ReportParameter
    Dim TampilPengurus As ReportParameter
    Dim TampilJabatan As ReportParameter
    Dim TampilBank As ReportParameter
    Dim TampilRekening As ReportParameter
    Dim TampilAtasNama As ReportParameter
    Dim TampilTahun As ReportParameter
    Dim Params As ReportParameter()

    Sub Bersihkan()
        RBBarang.Checked = 0
        RBSupplier.Checked = 0
        RBCustomer.Checked = 0
        CBTransaksi.Checked = 0
        CBLain.Checked = 0
        RBBatang.Checked = 0
        RBGaris.Checked = 0
        RBKurva.Checked = 0

        CBMasuk.Checked = 0
        CBKeluar.Checked = 0
        TDari.Value = Today
        TSampai.Value = Today
        TBulanan.Value = Today
        TTahunan.SelectedIndex = 0
        TEntitas.SelectedIndex = -1
        TCariData.Clear()
        DGV.DataSource = Nothing

        FilterJenis = Nothing
        FilterTanggal = Nothing
        LBLFilter.Text = ""

        FullQuery = Nothing
        Waktu = Nothing
        IDEntitas = Nothing
        NamaEntitas = Nothing
        LaporanTerpilih = Nothing
    End Sub

    Sub TidakMemilih()
        FilterJenis = Nothing
        FilterTanggal = Nothing
        LBLFilter.Text = ""
        FullQuery = Nothing
        Waktu = Nothing
        IDEntitas = Nothing
        NamaEntitas = Nothing
        LaporanTerpilih = Nothing
    End Sub

    Private Sub Lapor(sender As Object, e As EventArgs) Handles BTNLapor.Click
        If LaporanTerpilih = Nothing Then
            Pesan("Pilih Laporan valid", 0)
            Exit Sub
        End If
        Select Case LaporanTerpilih
            Case "Supplier"
                TampilLaporan("Supplier", TBLSupplierBindingSource, "SELECT * FROM TBLSupplier", Dev.TBLSupplier)
            Case "Customer"
                TampilLaporan("Customer", TBLCustomerBindingSource, "SELECT * FROM TBLCustomer", Dev.TBLCustomer)
            Case "Barang"
                TampilLaporan("Barang", TBLBarangBindingSource, "SELECT * FROM TBLBarang", Dev.TBLBarang)
            Case "Transaksi"
                If CBMasuk.Checked = True And CBKeluar.Checked = True Then
                    FullQuery = "SELECT ID_Masuk, Tanggal, Nama, Subtotal, PPN, BiayaLain, Terbayar FROM TBLSupplier INNER JOIN TBLMasuk ON TBLSupplier.ID_Supplier = TBLMasuk.ID_Supplier WHERE NOT Status = 'PO'" & Waktu & " UNION ALL SELECT ID_Keluar, Tanggal, Nama, Subtotal, PPN, BiayaLain, Terbayar FROM TBLCustomer INNER JOIN TBLKeluar ON TBLCustomer.ID_Customer = TBLKeluar.ID_Customer WHERE NOT Status = 'x'" & Waktu & " ORDER BY 2 ASC, 1 ASC"
                ElseIf CBMasuk.Checked = True Then
                    FullQuery = "SELECT ID_Masuk, Tanggal, Nama, Subtotal, PPN, BiayaLain, Terbayar FROM TBLSupplier INNER JOIN TBLMasuk ON TBLSupplier.ID_Supplier = TBLMasuk.ID_Supplier WHERE NOT Status = 'PO'" & Waktu & " ORDER BY 2 ASC, 1 ASC"
                ElseIf CBKeluar.Checked = True Then
                    FullQuery = "SELECT ID_Keluar AS [ID_Masuk], Tanggal, Nama, Subtotal, PPN, BiayaLain, Terbayar FROM TBLCustomer INNER JOIN TBLKeluar ON TBLCustomer.ID_Customer = TBLKeluar.ID_Customer WHERE NOT Status = 'x'" & Waktu & " ORDER BY 2 ASC, 1 ASC"
                End If
                TampilLaporan("Transaksi", TBLTransaksiBindingSource, FullQuery, Dev.TBLTransaksi)
            Case "Grafik"
                FullQuery = "SELECT ID_Masuk, Tanggal, Nominal FROM TBLBayarMasuk WHERE YEAR(Tanggal) = " & TTahunan.SelectedItem & " UNION ALL SELECT ID_Keluar, Tanggal, Nominal FROM TBLBayarKeluar WHERE YEAR(Tanggal) = " & TTahunan.SelectedItem
                TampilLaporan("Grafik", TBLGrafikBindingSource, FullQuery, Dev.TBLGrafik)
            Case "LabaRugi"
                If CBTransaksi.Checked = True And CBLain.Checked = True Then
                    FullQuery = "SELECT ID_LR, Tanggal, Deskripsi, Nominal FROM TBLLabaRugi WHERE NOT ID_LR = 'x'" & Waktu & " UNION ALL SELECT ID_Masuk, Tanggal, Deskripsi, Nominal FROM TBLBayarMasuk WHERE NOT ID_Masuk = 'x'" & Waktu & " UNION ALL SELECT ID_Keluar, Tanggal, Deskripsi, Nominal FROM TBLBayarKeluar WHERE NOT ID_Keluar = 'x'" & Waktu & " ORDER BY 2 ASC"
                ElseIf CBTransaksi.Checked = True Then
                    FullQuery = "SELECT ID_Masuk AS [ID_LR], Tanggal, Deskripsi, Nominal FROM TBLBayarMasuk WHERE NOT ID_Masuk = 'x'" & Waktu & " UNION ALL SELECT ID_Keluar, Tanggal, Deskripsi, Nominal FROM TBLBayarKeluar WHERE NOT ID_Keluar = 'x'" & Waktu & " ORDER BY 2 ASC"
                ElseIf CBLain.Checked = True Then
                    FullQuery = "SELECT ID_LR, Tanggal, Deskripsi, Nominal FROM TBLLabaRugi WHERE NOT ID_LR = 'x'" & Waktu & " ORDER BY 2 ASC"
                End If
                TampilLaporan("LabaRugi", TBLLabaRugiBindingSource, FullQuery, Dev.TBLLabaRugi)
            Case "Pembelian"
                TampilLaporan("Pembelian", TBLPembelianBindingSource, FullQuery, Dev.TBLPembelian)
            Case "Penjualan"
                TampilLaporan("Penjualan", TBLPenjualanBindingSource, FullQuery, Dev.TBLPenjualan)
            Case "TransaksiBarang"
                FullQuery = "SELECT TBLMasuk.ID_Masuk, Tanggal, Nama, StokAwal, TBLDetailMasuk.Qty, StokAkhir, TotalHarga FROM TBLSupplier INNER JOIN (TBLMasuk INNER JOIN (TBLDetailMasuk INNER JOIN TBLTransaksi ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk) ON TBLSupplier.ID_Supplier = TBLMasuk.ID_Supplier WHERE NOT Status = 'PO' AND ID_Barang = " & CInt(IDEntitas) & Waktu & " UNION ALL SELECT TBLKeluar.ID_Keluar, Tanggal, Nama, StokAwal, TBLDetailKeluar.Qty, StokAkhir, TotalHarga FROM TBLCustomer INNER JOIN (TBLKeluar INNER JOIN (TBLDetailKeluar INNER JOIN TBLTransaksi ON TBLTransaksi.Faktur = TBLDetailKeluar.Faktur) ON TBLKeluar.ID_Keluar = TBLDetailKeluar.ID_Keluar) ON TBLCustomer.ID_Customer = TBLKeluar.ID_Customer WHERE ID_Barang = " & CInt(IDEntitas) & Waktu & " ORDER BY 2 ASC, 4 DESC"
                TampilLaporan("TransaksiBarang", TBLTransaksiBarangBindingSource, FullQuery, Dev.TBLTransaksiBarang)
            Case "TransaksiSupplier"
                FullQuery = "SELECT Nama, Alamat, Telepon, Email, ID_Masuk, Tanggal, Subtotal, PPN, BiayaLain, Terbayar, Status, Keterangan FROM TBLSupplier INNER JOIN TBLMasuk ON TBLSupplier.ID_Supplier = TBLMasuk.ID_Supplier WHERE TBLMasuk.ID_Supplier = " & CInt(IDEntitas) & Waktu & " ORDER BY 5 DESC"
                TampilLaporan("TransaksiSupplier", TBLTransaksiSupplierBindingSource, FullQuery, Dev.TBLTransaksiSupplier)
            Case "TransaksiCustomer"
                FullQuery = "SELECT Nama, Alamat, Telepon, Email, ID_Keluar, Tanggal, Subtotal, PPN, BiayaLain, Terbayar, Status, Keterangan FROM TBLCustomer INNER JOIN TBLKeluar ON TBLCustomer.ID_Customer = TBLKeluar.ID_Customer WHERE TBLKeluar.ID_Customer = " & CInt(IDEntitas) & Waktu & " ORDER BY 5 DESC"
                TampilLaporan("TransaksiCustomer", TBLTransaksiCustomerBindingSource, FullQuery, Dev.TBLTransaksiCustomer)
        End Select
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        Bersihkan()
    End Sub

    Sub TampilLaporan(Judul As String, BS As BindingSource, Query As String, DT As DataTable)
        TampilDeskripsi = New ReportParameter("Deskripsi", LBLFilter.Text)
        Dim CurrentReportDataSource = New ReportDataSource()
        Dev.Clear()
        Terlapor.Show()
        If RBGaris.Checked = True And Judul = "Grafik" Then
            Terlapor.RV.LocalReport.ReportEmbeddedResource = "Inventori.Laporan" & Judul & "2.rdlc"
        ElseIf RBKurva.Checked = True And Judul = "Grafik" Then
            Terlapor.RV.LocalReport.ReportEmbeddedResource = "Inventori.Laporan" & Judul & "3.rdlc"
        Else
            Terlapor.RV.LocalReport.ReportEmbeddedResource = "Inventori.Laporan" & Judul & ".rdlc"
        End If
        CurrentReportDataSource.Name = "Data" & Judul
        CurrentReportDataSource.Value = BS
        Terlapor.RV.LocalReport.DataSources.Add(CurrentReportDataSource)
        DA = New OleDbDataAdapter(Query, CONN)
        DA.Fill(DT)
        If Judul = "Grafik" Then
            Terlapor.RV.LocalReport.SetParameters(TampilTahun)
        Else
            Terlapor.RV.LocalReport.SetParameters(TampilDeskripsi)
            For Each param As ReportParameter In Params
                Terlapor.RV.LocalReport.SetParameters(param)
            Next
        End If
        Terlapor.RV.SetDisplayMode(DisplayMode.PrintLayout)
        Terlapor.RV.ZoomMode = ZoomMode.Percent
        Terlapor.RV.ZoomPercent = 100
        Terlapor.RV.RefreshReport()
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QR("SELECT * FROM TBLInfo")
        TampilNama = New ReportParameter("Nama", DR(0).ToString)
        TampilAlamat = New ReportParameter("Alamat", DR(1).ToString)
        TampilTelepon = New ReportParameter("Telepon", DR(2).ToString)
        TampilFax = New ReportParameter("Fax", DR(3).ToString)
        TampilEmail = New ReportParameter("Email", DR(4).ToString)
        TampilWebsite = New ReportParameter("Website", DR(5).ToString)
        TampilPengurus = New ReportParameter("Pengurus", DR(6).ToString)
        TampilJabatan = New ReportParameter("Jabatan", DR(7).ToString)
        TampilBank = New ReportParameter("Bank", DR(8).ToString)
        TampilRekening = New ReportParameter("Rekening", DR(9).ToString)
        TampilAtasNama = New ReportParameter("AtasNama", DR(10).ToString)
        Params = {TampilNama, TampilAlamat, TampilTelepon, TampilFax, TampilEmail, TampilWebsite, TampilPengurus, TampilJabatan, TampilBank, TampilRekening, TampilAtasNama}
        TDari.Value = Today
        TSampai.Value = Today
        TBulanan.Value = Today
        For x = Year(Today) To 2021 Step -1
            TTahunan.Items.Add(x)
        Next
        TTahunan.SelectedIndex = 0
    End Sub

    Private Sub TampilFile(sender As Object, e As EventArgs) Handles RBSupplier.CheckedChanged, RBCustomer.CheckedChanged, RBBarang.CheckedChanged
        NamaEntitas = Nothing
        If RBBarang.Checked = False And RBSupplier.Checked = False And RBCustomer.Checked = False Then Exit Sub
        If RBBarang.Checked = True Then
            LaporanTerpilih = "Barang"
        ElseIf RBSupplier.Checked = True Then
            LaporanTerpilih = "Supplier"
        ElseIf RBCustomer.Checked = True Then
            LaporanTerpilih = "Customer"
        End If
        LBLFilter.Text = "Laporan " & sender.Text
    End Sub

    Private Sub TampilTransaksi(sender As Object, e As EventArgs) Handles CBMasuk.CheckedChanged, CBKeluar.CheckedChanged
        NamaEntitas = Nothing
        If CBMasuk.Checked = False And CBKeluar.Checked = False Then
            TidakMemilih()
            Exit Sub
        End If
        If CBMasuk.Checked = True And CBKeluar.Checked = True Then
            FilterJenis = "Semua Transaksi"
        ElseIf CBMasuk.Checked = True Then
            FilterJenis = "Transaksi Masuk"
        ElseIf CBKeluar.Checked = True Then
            FilterJenis = "Transaksi Keluar"
        End If
        LaporanTerpilih = "Transaksi"
        LBLFilter.Text = FilterJenis & FilterTanggal
    End Sub

    Private Sub TampilLabaRugi(sender As Object, e As EventArgs) Handles CBTransaksi.CheckedChanged, CBLain.CheckedChanged
        NamaEntitas = Nothing
        If CBTransaksi.Checked = False And CBLain.Checked = False Then
            TidakMemilih()
            Exit Sub
        End If
        If CBTransaksi.Checked = True And CBLain.Checked = True Then
            FilterJenis = "Laba / Rugi"
        ElseIf CBTransaksi.Checked = True Then
            FilterJenis = "Pembayaran Faktur"
        ElseIf CBLain.Checked = True Then
            FilterJenis = "Pendapatan / Pengeluaran"
        End If
        LaporanTerpilih = "LabaRugi"
        LBLFilter.Text = FilterJenis & FilterTanggal
    End Sub

    Private Sub TampilGrafik(sender As Object, e As EventArgs) Handles RBKurva.CheckedChanged, RBGaris.CheckedChanged, RBBatang.CheckedChanged
        NamaEntitas = Nothing
        If RBBatang.Checked = False And RBGaris.Checked = False And RBKurva.Checked = False Then
            TidakMemilih()
            Exit Sub
        End If
        TampilTahun = New ReportParameter("Tahun", TTahunan.SelectedItem.ToString)
        FilterTanggal = " pada tahun " & TTahunan.SelectedItem
        If RBBatang.Checked = True Then
            FilterJenis = "Grafik Batang"
        ElseIf RBGaris.Checked = True Then
            FilterJenis = "Grafik Garis"
        ElseIf RBKurva.Checked = True Then
            FilterJenis = "Kurva"
        End If
        LaporanTerpilih = "Grafik"
        LBLFilter.Text = FilterJenis & FilterTanggal
    End Sub

    Private Sub TEntitas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TEntitas.SelectedIndexChanged
        If TEntitas.SelectedIndex = -1 Then
            TidakMemilih()
            Exit Sub
        End If
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        If TEntitas.SelectedIndex = -1 Then Exit Sub
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        FilterJenis = Nothing
        IDEntitas = DGV.Rows(e.RowIndex).Cells(0).Value
        If Not TEntitas.SelectedIndex = 0 Or TEntitas.SelectedIndex = 1 Then NamaEntitas = DGV.Rows(e.RowIndex).Cells(1).Value
        If TEntitas.SelectedIndex = 0 Then 'Pembelian
            LBLFilter.Text = "Faktur Pembelian " & IDEntitas
            FullQuery = "SELECT TBLMasuk.ID_Masuk, Tanggal, TBLSupplier.Nama, Alamat, Telepon, Email, TBLBarang.Nama, Qty, Satuan, Diskon, TotalHarga, Subtotal, PPN, BiayaLain, Keterangan FROM TBLBarang INNER JOIN (TBLTransaksi INNER JOIN ((TBLSupplier INNER JOIN TBLMasuk ON TBLSupplier.ID_Supplier = TBLMasuk.ID_Supplier) INNER JOIN TBLDetailMasuk ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk) ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLBarang.ID_Barang = TBLTransaksi.ID_Barang WHERE TBLMasuk.ID_Masuk = '" & IDEntitas & "'"
            LaporanTerpilih = "Pembelian"
        ElseIf TEntitas.SelectedIndex = 1 Then 'Penjualan
            LBLFilter.Text = "Faktur Penjualan " & IDEntitas
            FullQuery = "SELECT TBLKeluar.ID_Keluar, Tanggal, TBLCustomer.Nama, Alamat, Telepon, Email, TBLBarang.Nama, Qty, Satuan, Diskon, TotalHarga, Subtotal, PPN, BiayaLain, Keterangan, TBLTransaksi.ID_Barang FROM TBLBarang INNER JOIN (TBLTransaksi INNER JOIN ((TBLCustomer INNER JOIN TBLKeluar ON TBLCustomer.ID_Customer = TBLKeluar.ID_Customer) INNER JOIN TBLDetailKeluar ON TBLKeluar.ID_Keluar = TBLDetailKeluar.ID_Keluar) ON TBLTransaksi.Faktur = TBLDetailKeluar.Faktur) ON TBLBarang.ID_Barang = TBLTransaksi.ID_Barang WHERE TBLKeluar.ID_Keluar = '" & IDEntitas & "'"
            LaporanTerpilih = "Penjualan"
        ElseIf TEntitas.SelectedIndex = 2 Then 'Transaksi Barang
            FilterJenis = "Riwayat transaksi pada "
            LaporanTerpilih = "TransaksiBarang"
            LBLFilter.Text = FilterJenis & NamaEntitas & FilterTanggal
        ElseIf TEntitas.SelectedIndex = 3 Then 'Transaksi Supplier
            FilterJenis = "Riwayat transaksi dengan "
            LaporanTerpilih = "TransaksiSupplier"
            LBLFilter.Text = FilterJenis & NamaEntitas & FilterTanggal
        ElseIf TEntitas.SelectedIndex = 4 Then 'Transaksi Customer
            FilterJenis = "Riwayat transaksi dengan "
            LaporanTerpilih = "TransaksiCustomer"
            LBLFilter.Text = FilterJenis & NamaEntitas & FilterTanggal
        End If
    End Sub

#Region "Tanggal Transaksi"

    Private Sub DTPPeriodik(sender As Object, e As EventArgs) Handles TSampai.ValueChanged, TDari.ValueChanged
        If FilterJenis = Nothing Then Exit Sub
        If sender Is TDari And TDari.Value > TSampai.Value Then
            TSampai.Value = TDari.Value
        ElseIf sender Is TSampai And TSampai.Value < TDari.Value Then
            TDari.Value = TSampai.Value
        End If
        If TDari.Value = TSampai.Value Then
            FilterTanggal = " pada tanggal " & Format(TDari.Value, "dd/MM/yyyy")
        Else
            FilterTanggal = " antara tanggal " & Format(TDari.Value, "dd/MM/yyyy") & " sampai " & Format(TSampai.Value, "dd/MM/yyyy")
        End If
        Waktu = " AND (DATEVALUE(Tanggal) BETWEEN #" & TDari.Value & "# AND #" & TSampai.Value & "#)"
        If FilterJenis = "Grafik Batang" Or FilterJenis = "Grafik Garis" Or FilterJenis = "Kurva" Then Exit Sub
        If NamaEntitas = Nothing Then
            LBLFilter.Text = FilterJenis & FilterTanggal
        Else
            LBLFilter.Text = FilterJenis & NamaEntitas & FilterTanggal
        End If
    End Sub

    Private Sub TBulanan_ValueChanged(sender As Object, e As EventArgs) Handles TBulanan.ValueChanged
        If FilterJenis = Nothing Then Exit Sub
        Dim NamaBulan As String
        If Month(TBulanan.Value) = 1 Then
            NamaBulan = "Januari"
        ElseIf Month(TBulanan.Value) = 2 Then
            NamaBulan = "Februari"
        ElseIf Month(TBulanan.Value) = 3 Then
            NamaBulan = "Maret"
        ElseIf Month(TBulanan.Value) = 4 Then
            NamaBulan = "April"
        ElseIf Month(TBulanan.Value) = 5 Then
            NamaBulan = "Mei"
        ElseIf Month(TBulanan.Value) = 6 Then
            NamaBulan = "Juni"
        ElseIf Month(TBulanan.Value) = 7 Then
            NamaBulan = "Juli"
        ElseIf Month(TBulanan.Value) = 8 Then
            NamaBulan = "Agustus"
        ElseIf Month(TBulanan.Value) = 9 Then
            NamaBulan = "September"
        ElseIf Month(TBulanan.Value) = 10 Then
            NamaBulan = "Oktober"
        ElseIf Month(TBulanan.Value) = 11 Then
            NamaBulan = "November"
        Else
            NamaBulan = "Desember"
        End If
        FilterTanggal = " pada bulan " & NamaBulan & " tahun " & Year(TBulanan.Value)
        Waktu = " AND MONTH(Tanggal) = " & Month(TBulanan.Value) & " AND YEAR(Tanggal) = " & Year(TBulanan.Value)
        If FilterJenis = "Grafik Batang" Or FilterJenis = "Grafik Garis" Or FilterJenis = "Kurva" Then Exit Sub
        If NamaEntitas = Nothing Then
            LBLFilter.Text = FilterJenis & FilterTanggal
        Else
            LBLFilter.Text = FilterJenis & NamaEntitas & FilterTanggal
        End If
    End Sub

    Private Sub TTahunan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TTahunan.SelectedIndexChanged
        If FilterJenis = Nothing Then Exit Sub
        TampilTahun = New ReportParameter("Tahun", TTahunan.SelectedItem.ToString)
        FilterTanggal = " pada tahun " & TTahunan.SelectedItem
        Waktu = " AND YEAR(Tanggal) = " & TTahunan.SelectedItem
        If NamaEntitas = Nothing Then
            LBLFilter.Text = FilterJenis & FilterTanggal
        Else
            LBLFilter.Text = FilterJenis & NamaEntitas & FilterTanggal
        End If
    End Sub

#End Region

#Region "DGV Pagination"
    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        If TEntitas.SelectedIndex = 0 Then 'Pembelian
            QR("SELECT COUNT(ID_Masuk) FROM TBLMasuk WHERE ID_Masuk LIKE '%" & TCariData.Text & "%'")
        ElseIf TEntitas.SelectedIndex = 1 Then 'Penjualan
            QR("SELECT COUNT(ID_Keluar) FROM TBLKeluar WHERE ID_Keluar LIKE '%" & TCariData.Text & "%'")
        ElseIf TEntitas.SelectedIndex = 2 Then 'Transaksi Barang
            QR("SELECT COUNT(ID_Barang) FROM TBLBarang WHERE Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%'")
        ElseIf TEntitas.SelectedIndex = 3 Then 'Transaksi Supplier
            QR("SELECT COUNT(ID_Supplier) FROM TBLSupplier WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%'")
        ElseIf TEntitas.SelectedIndex = 4 Then 'Transaksi Customer
            QR("SELECT COUNT(ID_Customer) FROM TBLCustomer WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%'")
        End If
        If DR(0) Mod 12 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 12) + 1 Then DGVPrev.PerformClick()
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(DR(0) / 12) = 0, 1, Math.Ceiling(DR(0) / 12))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(DR(0) / 12) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        If TEntitas.SelectedIndex = 0 Then 'Pembelian
            QDGV("SELECT ID_Masuk AS [Faktur Pembelian] FROM TBLMasuk WHERE ID_Masuk LIKE '%" & TCariData.Text & "%' ORDER BY Tanggal DESC", DGV, FetchData, 12, 0)
        ElseIf TEntitas.SelectedIndex = 1 Then 'Penjualan
            QDGV("SELECT ID_Keluar AS [Faktur Penjualan] FROM TBLKeluar WHERE ID_Keluar LIKE '%" & TCariData.Text & "%' ORDER BY Tanggal DESC", DGV, FetchData, 12, 0)
        ElseIf TEntitas.SelectedIndex = 2 Then 'Transaksi Barang
            QDGV("SELECT ID_Barang, Nama, Nama + ' (' + Satuan + ')' AS [Daftar Barang] FROM TBLBarang WHERE Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%' ORDER BY Nama ASC", DGV, FetchData, 12, 0)
            DGV.Columns(0).Visible = 0
            DGV.Columns(1).Visible = 0
        ElseIf TEntitas.SelectedIndex = 3 Then 'Transaksi Supplier
            QDGV("SELECT ID_Supplier, Nama AS [Daftar Supplier] FROM TBLSupplier WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%' ORDER BY Nama ASC", DGV, FetchData, 12, 0)
            DGV.Columns(0).Visible = 0
        ElseIf TEntitas.SelectedIndex = 4 Then 'Transaksi Customer
            QDGV("SELECT ID_Customer, Nama AS [Daftar Customer] FROM TBLCustomer WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%' ORDER BY Nama ASC", DGV, FetchData, 12, 0)
            DGV.Columns(0).Visible = 0
        End If
        Paging()
    End Sub

    Private Sub DGVPrevClick(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 12
        DS.Clear()
        DA.Fill(DS, FetchData, 12, 0)
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNextClick(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 12
        DS.Clear()
        DA.Fill(DS, FetchData, 12, 0)
        CurrentPage += 1
        Paging()
    End Sub
#End Region

End Class
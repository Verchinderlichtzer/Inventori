﻿Public Class Catatan

    Dim FilterJenis As String
    Dim FilterTanggal As String
    Dim FilterStatus As String

    Private Sub Catatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TDari.Value = Today
        TSampai.Value = Today
        QRL("SELECT ID_Barang, Nama FROM TBLBarang ORDER BY Nama ASC")
        Do While DR.Read
            TBarang.Items.Add(DR(0) & " - " & DR(1))
        Loop
        QRL("SELECT ID_Supplier, Nama FROM TBLSupplier ORDER BY Nama ASC")
        Do While DR.Read
            TSupplier.Items.Add(DR(0) & " - " & DR(1))
        Loop
        QRL("SELECT ID_Customer, Nama FROM TBLCustomer ORDER BY Nama ASC")
        Do While DR.Read
            TCustomer.Items.Add(DR(0) & " - " & DR(1))
        Loop
        DGV.DataSource = Nothing
    End Sub

    Private Sub SupplierCustomerBarang(sender As Object, e As EventArgs) Handles TSupplier.SelectedIndexChanged, TCustomer.SelectedIndexChanged, TBarang.SelectedIndexChanged
        DGV.DataSource = Nothing
        Dim Lebar() As Integer = Nothing
        If sender Is TSupplier Then
            QDGV("SELECT ID_Masuk AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Subtotal, PPN, BiayaLain AS [Biaya Lain], Subtotal + PPN + BiayaLain AS [Grand Total], Terbayar, Status FROM TBLMasuk WHERE ID_Supplier = " & TSupplier.SelectedItem.Substring(0, TSupplier.SelectedItem.IndexOf(" ")) & " ORDER BY Tanggal DESC", DGV, FetchData, 14, 0)
            LBLFilter.Text = "Transaksi dengan Supplier " & TSupplier.SelectedItem.Substring(TSupplier.SelectedItem.IndexOf("-") + 2)
            Lebar = {115, 193, 135, 120, 134, 135, 134, 128}
        ElseIf sender Is TCustomer Then
            QDGV("SELECT ID_Keluar AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Subtotal, PPN, BiayaLain AS [Biaya Lain], Subtotal + PPN + BiayaLain AS [Grand Total], Terbayar, Status FROM TBLKeluar WHERE ID_Customer = " & TCustomer.SelectedItem.Substring(0, TCustomer.SelectedItem.IndexOf(" ")) & " ORDER BY Tanggal DESC", DGV, FetchData, 14, 0)
            LBLFilter.Text = "Transaksi dengan Customer " & TCustomer.SelectedItem.Substring(TCustomer.SelectedItem.IndexOf("-") + 2)
            Lebar = {115, 193, 135, 120, 134, 135, 134, 128}
        ElseIf sender Is TBarang Then
            QDGV("SELECT Tanggal, TBLDetailMasuk.ID_Masuk AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Nama AS [Supplier / Customer], StokAwal AS Awal, Qty, StokAkhir AS Akhir, TotalHarga / Qty AS Harga FROM TBLTransaksi INNER JOIN ((TBLSupplier INNER JOIN TBLMasuk ON TBLSupplier.ID_Supplier = TBLMasuk.ID_Supplier) INNER JOIN TBLDetailMasuk ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk) ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur WHERE TBLTransaksi.ID_Barang = " & TBarang.SelectedItem.Substring(0, TBarang.SelectedItem.IndexOf(" ")) & " UNION ALL SELECT Max(Tanggal), Max(TBLDetailKeluar.ID_Keluar), FORMAT(Max(Tanggal), 'dd/MM/yyyy HH:mm AM/PM'), Max(Nama), Max(StokAwal), Sum(Qty), Min(StokAkhir), Sum(TotalHarga) / Sum(Qty) AS Harga FROM TBLTransaksi INNER JOIN ((TBLCustomer INNER JOIN TBLKeluar ON TBLCustomer.ID_Customer = TBLKeluar.ID_Customer) INNER JOIN TBLDetailKeluar ON TBLKeluar.ID_Keluar = TBLDetailKeluar.ID_Keluar) ON TBLTransaksi.Faktur = TBLDetailKeluar.Faktur WHERE TBLTransaksi.ID_Barang = " & TBarang.SelectedItem.Substring(0, TBarang.SelectedItem.IndexOf(" ")) & " GROUP BY TBLDetailKeluar.ID_Keluar ORDER BY 1 ASC, 5 DESC", DGV, FetchData, 14, 0)
            LBLFilter.Text = "Transaksi pada Barang " & TBarang.SelectedItem.Substring(TBarang.SelectedItem.IndexOf("-") + 2)
            Lebar = {5, 115, 193, 430, 76, 76, 76, 128}
            DGV.Columns(0).Visible = 0
        End If
        Dim i = 0
        For Each x In DGV.Columns
            x.SortMode = DataGridViewColumnSortMode.NotSortable
            x.Width = Lebar(i)
            i += 1
        Next
        DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        If sender Is TSupplier Or sender Is TCustomer Then
            DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(2).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(3).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(4).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(5).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(6).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For Each Style In DGV.Rows
                If Microsoft.VisualBasic.Left(Style.Cells(0).Value, 1) = "M" Then
                    Style.Cells(5).Style.ForeColor = Color.FromArgb(220, 53, 69)
                Else
                    Style.Cells(5).Style.ForeColor = Color.FromArgb(40, 167, 69)
                End If
            Next
        ElseIf sender Is TBarang Then
            DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGV.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(7).DefaultCellStyle.Format = "###,###,###"
            For Each Style In DGV.Rows
                If Microsoft.VisualBasic.Left(Style.Cells(1).Value, 1) = "M" Then
                    Style.Cells(5).Style.ForeColor = Color.FromArgb(40, 167, 69)
                    Style.Cells(7).Style.ForeColor = Color.FromArgb(220, 53, 69)
                Else
                    Style.Cells(5).Style.ForeColor = Color.FromArgb(220, 53, 69)
                    Style.Cells(7).Style.ForeColor = Color.FromArgb(40, 167, 69)
                End If
            Next
        End If
    End Sub

    Private Sub TLR(sender As Object, e As EventArgs) Handles TSampai.ValueChanged, TDari.ValueChanged, CBSudah.CheckedChanged, CBPeriodik.CheckedChanged, CBMasuk.CheckedChanged, CBKeluar.CheckedChanged, CBBelum.CheckedChanged
        DGV.DataSource = Nothing
        Dim FullQuery As String = Nothing
        Dim QueryMasuk As String = Nothing
        Dim QueryKeluar As String = Nothing
        Dim PeriodeMasuk As String = Nothing
        Dim PeriodeKeluar As String = Nothing
        Dim StatusMasuk As String = Nothing
        Dim StatusKeluar As String = Nothing
        FilterJenis = Nothing
        FilterTanggal = Nothing
        FilterStatus = Nothing
        If sender Is TDari And TDari.Value > TSampai.Value Then
            TSampai.Value = TDari.Value
        ElseIf sender Is TSampai And TSampai.Value < TDari.Value Then
            TDari.Value = TSampai.Value
        End If
        Dim Dari As String = Format(TDari.Value, "dd/MM/yyyy")
        Dim Sampai As String = Format(TSampai.Value, "dd/MM/yyyy")
        If CBPeriodik.Checked = True And Dari = Sampai Then
            FilterTanggal = " pada Tanggal " & Dari
        ElseIf CBPeriodik.Checked = True And Dari <> Sampai Then
            FilterTanggal = " antara Tanggal " & Dari & " sampai " & Sampai
        End If
        If CBPeriodik.Checked = True Then
            TDari.Enabled = 1
            TSampai.Enabled = 1
        Else
            TDari.Enabled = 0
            TSampai.Enabled = 0
        End If

        If CBMasuk.Checked = True Then
            QueryMasuk = "SELECT Tanggal, ID_Masuk AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy') AS Tanggal, Nama AS [Supplier / Customer], Subtotal, PPN, BiayaLain AS [Biaya Lain], Subtotal + PPN + BiayaLain AS [Grand Total], Terbayar, Status FROM TBLSupplier INNER JOIN TBLMasuk ON TBLSupplier.ID_Supplier = TBLMasuk.ID_Supplier"
            FilterJenis = "Transaksi Masuk"
        End If
        If CBKeluar.Checked = True Then
            QueryKeluar = "SELECT Tanggal, ID_Keluar AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy') AS Tanggal, Nama AS [Supplier / Customer], Subtotal, PPN, BiayaLain AS [Biaya Lain], Subtotal + PPN + BiayaLain AS [Grand Total], Terbayar, Status FROM TBLCustomer INNER JOIN TBLKeluar ON TBLCustomer.ID_Customer = TBLKeluar.ID_Customer"
            FilterJenis = "Transaksi Keluar"
        End If
        If CBMasuk.Checked = True And CBKeluar.Checked = True Then FilterJenis = "Semua Transaksi"
        If (CBMasuk.Checked = True Or CBKeluar.Checked = True) And (CBPeriodik.Checked = True Or CBBelum.Checked = True Or CBSudah.Checked = True) Then
            QueryMasuk &= " WHERE "
            QueryKeluar &= " WHERE "
        End If

        If CBPeriodik.Checked = True Then
            PeriodeMasuk = "(DATEVALUE(Tanggal) BETWEEN #" & TDari.Value & "# AND #" & TSampai.Value & "#)"
            PeriodeKeluar = "(DATEVALUE(Tanggal) BETWEEN #" & TDari.Value & "# AND #" & TSampai.Value & "#)"
        End If

        If CBPeriodik.Checked = True And (CBBelum.Checked = True Or CBSudah.Checked = True) Then
            PeriodeMasuk &= " AND "
            PeriodeKeluar &= " AND "
        End If
        If CBBelum.Checked = True And CBSudah.Checked = True Then
            StatusMasuk = "(TBLMasuk.Status = 'Lunas' OR TBLMasuk.Status = 'Belum Lunas')"
            StatusKeluar = "(TBLKeluar.Status = 'Lunas' OR TBLKeluar.Status = 'Belum Lunas')"
            FilterStatus = Nothing
        ElseIf CBBelum.Checked = True Then
            StatusMasuk = "(TBLMasuk.Status = 'Belum Lunas')"
            StatusKeluar = "(TBLKeluar.Status = 'Belum Lunas')"
            FilterStatus = " yang Belum Lunas"
        ElseIf CBSudah.Checked = True Then
            StatusMasuk = "(TBLMasuk.Status = 'Lunas')"
            StatusKeluar = "(TBLKeluar.Status = 'Lunas')"
            FilterStatus = " yang Sudah Lunas"
        End If

        If CBMasuk.Checked = True And CBKeluar.Checked = True Then
            FullQuery = QueryMasuk & PeriodeMasuk & StatusMasuk & " UNION ALL " & QueryKeluar & PeriodeKeluar & StatusKeluar & " ORDER BY 1 DESC"
        ElseIf CBMasuk.Checked = True Then
            FullQuery = QueryMasuk & PeriodeMasuk & StatusMasuk & " ORDER BY 1 DESC"
        ElseIf CBKeluar.Checked = True Then
            FullQuery = QueryKeluar & PeriodeKeluar & StatusKeluar & " ORDER BY 1 DESC"
        End If
        If FullQuery IsNot Nothing Then
            QDGV(FullQuery, DGV, FetchData, 14, 0)
            DGV.Columns(0).Visible = 0
            LBLFilter.Text = FilterJenis & FilterTanggal & FilterStatus
            Dim Lebar() As Integer = {5, 115, 110, 230, 109, 95, 109, 109, 108, 109}
            Dim i = 0
            For Each x In DGV.Columns
                x.SortMode = DataGridViewColumnSortMode.NotSortable
                x.Width = Lebar(i)
                i += 1
            Next
            DGV.Columns(0).Visible = 0
            DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGV.Columns(4).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(5).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(6).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(7).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(8).DefaultCellStyle.Format = "###,###,###"
            DGV.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For Each Style In DGV.Rows
                If Microsoft.VisualBasic.Left(Style.Cells(1).Value, 1) = "M" Then
                    Style.Cells(8).Style.ForeColor = Color.FromArgb(220, 53, 69)
                Else
                    Style.Cells(8).Style.ForeColor = Color.FromArgb(40, 167, 69)
                End If
            Next
        End If
    End Sub

#Region "DGV Pagination"
    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        QR("SELECT COUNT(*) FROM TBLBarang")
        If DR(0) Mod 14 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 14) + 1 Then DGVPrev.PerformClick()
        DGVPageCounter.Text = CurrentPage & " / " & Math.Ceiling(DR(0) / 14)
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage = Math.Ceiling(DR(0) / 14) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        QDGV("SELECT * FROM TBLBarang ORDER BY ID_Barang ASC", DGV, FetchData, 14, 0)
        Paging()
    End Sub

    Private Sub DGVPrevClick(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 14
        DS.Clear()
        DA.Fill(DS, FetchData, 14, 0)
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNextClick(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 14
        DS.Clear()
        DA.Fill(DS, FetchData, 14, 0)
        CurrentPage += 1
        Paging()
    End Sub
#End Region
End Class
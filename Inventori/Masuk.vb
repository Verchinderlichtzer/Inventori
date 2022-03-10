Public Class Masuk

    Dim TglMasuk As Date
    Dim Subtotal As Integer
    Dim PPN As Integer
    Dim BiayaLain As Integer
    Dim Terbayar As Integer
    Dim GrandSisa As Integer
    Dim Dibayar As Integer
    Dim SisaKurang As Integer

    Dim BStatus As String
    Dim AStatus As String

    Sub TampilFaktur()
        TFaktur.Items.Clear()
        QR("SELECT ID_Masuk FROM TBLMasuk ORDER BY ID_Masuk DESC")
        If DR.HasRows AndAlso Mid(DR(0), 2, 6) = Format(Today, "yyMMdd") Then TFaktur.Items.Add("M" & Microsoft.VisualBasic.Right(DR(0), 8) + 1) Else TFaktur.Items.Add("M" & Format(Today, "yyMMdd") & "01")
        QRL("SELECT ID_Masuk FROM TBLMasuk WHERE Status IN('PO','Belum Lunas') ORDER BY ID_Masuk DESC")
        Do While DR.Read
            TFaktur.Items.Add(DR(0))
        Loop
        TFaktur.SelectedIndex = 0
    End Sub

    Sub Clear()
        TSupplier.SelectedIndex = -1
        DGV.Rows.Clear()
        TCariBarang.Clear()
        TampilDGV()
        TglMasuk = Now
        Subtotal = 0
        PPN = 0
        BiayaLain = 0
        Terbayar = 0
        GrandSisa = 0
        Dibayar = 0
        SisaKurang = 0
        BStatus = Nothing
        AStatus = Nothing

        TKeterangan.Clear()
        TPPN.Text = PPNOtomatis
        TBiayaLain.Clear()
        TDibayar.Clear()

        Akses("Purchase Order", 0, 0, 0, 0, "Grand Total :", "Sisa :", 0, 0, 1, 1, 1, 0)
    End Sub

    Sub Akses(TTitle As String, VTglMasuk As Integer, VTerbayar As Integer, VDibayar As Integer, VSisaKurang As Integer, XGrandSisa As String, XSisaKurang As String, VDGVC As Integer, RDGVC As Integer, RDGVC7 As Integer, EPPN As Integer, EBiayaLain As Integer, EHapus As Integer)
        MainF.LBLTitle.Text = TTitle
        LBLTglMasuk.Visible = VTglMasuk
        TTglMasuk.Visible = VTglMasuk
        LBLTerbayar.Visible = VTerbayar
        TTerbayar.Visible = VTerbayar
        LBLDibayar.Visible = VDibayar
        TDibayar.Visible = VDibayar
        LBLSisaKurang.Visible = VSisaKurang
        TSisaKurang.Visible = VSisaKurang
        LBLGrandSisa.Text = XGrandSisa
        LBLSisaKurang.Text = XSisaKurang
        DGV.Columns(7).Visible = VDGVC
        DGV.Columns(8).Visible = VDGVC
        DGV.Columns(2).ReadOnly = RDGVC
        DGV.Columns(4).ReadOnly = RDGVC
        DGV.Columns(5).ReadOnly = RDGVC
        DGV.Columns(7).ReadOnly = RDGVC7
        DGV.Columns(8).ReadOnly = RDGVC
        TPPN.Enabled = EPPN
        TBiayaLain.Enabled = EBiayaLain
        BTNHapus.Enabled = EHapus
    End Sub

    Private Sub TFaktur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TFaktur.SelectedIndexChanged
        Clear()
        QR("SELECT * FROM TBLMasuk WHERE ID_Masuk = '" & TFaktur.SelectedItem & "'")
        If Not DR.HasRows Then
            ControlOtomatis()
            Dim Lebar1() As Integer = {5, 437, 55, 80, 105, 61, 107, 5, 5, 5}
            Dim i = 0
            For Each x In DGV.Columns
                x.Width = Lebar1(i)
                i += 1
            Next
            BTNSimpan.Values.Image = My.Resources.crud_simpan_pressed
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_simpan_common
            Akses("Purchase Order", 0, 0, 0, 0, "Grand Total :", "Sisa :", 0, 0, 1, 1, 1, 0)
            Exit Sub
        ElseIf DR("Status") = "PO" Then
            Akses("Masuk", 0, 0, 1, 1, "Grand Total :", "Sisa :", 1, 0, 0, 1, 1, 1)
        Else 'Belum Lunas
            Terbayar = DR("Terbayar")
            TglMasuk = DR("Tanggal")
            Akses("Utang", 1, 1, 1, 1, "Sisa :", "Kurang :", 1, 1, 0, 0, 0, 0)
        End If
        Dim Lebar2() As Integer = {5, 224, 55, 80, 105, 61, 107, 108, 105, 5}
        Dim j = 0
        For Each x In DGV.Columns
            x.Width = Lebar2(j)
            j += 1
        Next
        For Each x In TSupplier.Items
            If x.Substring(0, x.IndexOf(" ")) = DR("ID_Supplier") Then
                TSupplier.SelectedItem = x
                Exit For
            End If
        Next
        TKeterangan.Text = DR("Keterangan")
        PPN = DR("PPN")
        TPPN.Text = DR("PPN") / DR("Subtotal") * 100
        BiayaLain = DR("BiayaLain")
        TBiayaLain.Text = DR("BiayaLain")
        BStatus = DR("Status")
        QRL("SELECT TBLTransaksi.ID_Barang, Nama, Qty, Satuan, TBLTransaksi.HargaBeli, Diskon / (Qty * TBLTransaksi.HargaBeli) * 100, Diskon / TotalHarga * 100 AS [Total Harga], FORMAT(Kedaluwarsa, 'M/d/yyyy'), TBLTransaksi.HargaJual, Stok FROM TBLBarang INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLBarang.ID_Barang = TBLTransaksi.ID_Barang WHERE TBLDetailMasuk.ID_Masuk = '" & TFaktur.SelectedItem & "'")
        Do While DR.Read
            DGV.Rows.Add(DR(0), DR(1), DR(2), DR(3), DR(4), DR(5), DR(6), DR(7).ToString, DR(8), DR(9))
        Loop
        BTNSimpan.Values.Image = My.Resources.crud_edit_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_edit_common
        Hitung()
        ControlOtomatis()
    End Sub

    Sub Hitung()
        Subtotal = 0
        For Each x In DGV.Rows
            x.Cells("CTotalHarga").Value = x.Cells("CQty").Value * x.Cells("CHargaBeli").Value * (100 - x.Cells("CDiskon").Value) / 100
            Subtotal += x.Cells("CTotalHarga").Value
        Next
        PPN = Subtotal * Val(TPPN.Text) / 100
        BiayaLain = Val(TBiayaLain.Text)
        GrandSisa = Math.Abs(Subtotal + PPN + BiayaLain - Terbayar)
        If Val(TDibayar.Text) >= GrandSisa And TFaktur.SelectedIndex > 0 Then
            AStatus = "Lunas"
            Dibayar = GrandSisa
            SisaKurang = 0
            If Not GrandSisa = 0 Then TDibayar.Text = Dibayar
        ElseIf Val(TDibayar.Text) < GrandSisa And TFaktur.SelectedIndex > 0 Then
            AStatus = "Belum Lunas"
            Dibayar = Val(TDibayar.Text)
            SisaKurang = GrandSisa - Dibayar
            If BStatus = "Belum Lunas" Then LBLSisaKurang.Text = "Kurang :" Else LBLSisaKurang.Text = "Sisa :"
        End If
    End Sub

    Sub ControlOtomatis()
        TTglMasuk.Text = Format(TglMasuk, "dd/MM/yyyy")
        TSubtotal.Text = FormatNumber(Subtotal, 0)
        TTerbayar.Text = FormatNumber(Terbayar, 0)
        TGrandSisa.Text = FormatNumber(GrandSisa, 0)
        TSisaKurang.Text = FormatNumber(SisaKurang, 0)
    End Sub

    Sub Validasi()
        For Each x In DGV.Rows
            If TFaktur.SelectedIndex = -1 Or TSupplier.SelectedIndex = -1 Or DGV.Rows.Count = 0 Or (x.Cells(7).Value <> "" And Not IsDate(x.Cells(7).Value)) Or (BStatus <> Nothing And Val(TDibayar.Text) = 0) Then
                BTNSimpan.Enabled = 0
                Exit For
            Else
                BTNSimpan.Enabled = 1
            End If
        Next
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TPPN.TextChanged, TDibayar.TextChanged, TBiayaLain.TextChanged, TSupplier.SelectedIndexChanged
        Hitung()
        ControlOtomatis()
        Validasi()
    End Sub

    Private Sub Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        DGVBarang.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        RemoveHandler TFaktur.SelectedIndexChanged, AddressOf TFaktur_SelectedIndexChanged
        TampilFaktur()
        AddHandler TFaktur.SelectedIndexChanged, AddressOf TFaktur_SelectedIndexChanged
        QRL("SELECT ID_Supplier, Nama FROM TBLSupplier ORDER BY Nama ASC")
        Do While DR.Read
            TSupplier.Items.Add(DR(0) & " - " & DR(1))
        Loop
        DGVBarang.Columns(0).Visible = 0
        DGVBarang.Columns(2).Visible = 0
        DGVBarang.Columns(3).Visible = 0
        DGVBarang.Columns(4).Visible = 0
        DGVBarang.Columns(5).Visible = 0
        DGVBarang.Columns(6).Visible = 0
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        If BStatus = Nothing Then 'PO Dibuat
            QN("INSERT INTO TBLMasuk(ID_Masuk, Tanggal, ID_Supplier, Subtotal, PPN, BiayaLain, Status, Keterangan) VALUES('" & TFaktur.SelectedItem & "',#" & Now & "#," & Val(TSupplier.SelectedItem.Substring(0, TSupplier.SelectedItem.IndexOf(" "))) & "," & Subtotal & "," & PPN & "," & BiayaLain & ",'PO','" & TKeterangan.Text & "')")
            For Each x In DGV.Rows
                QN("INSERT INTO TBLTransaksi(ID_Barang, Terbeli, HargaBeli, HargaJual) VALUES(" & x.Cells(0).Value & "," & x.Cells(2).Value & "," & x.Cells(4).Value & "," & x.Cells(8).Value & ")")
                QR("SELECT Faktur FROM TBLTransaksi ORDER BY Faktur DESC")
                QN("INSERT INTO TBLDetailMasuk VALUES('" & TFaktur.SelectedItem & "'," & DR(0) & "," & x.Cells(9).Value & "," & x.Cells(2).Value & "," & x.Cells(9).Value + x.Cells(2).Value & "," & x.Cells(2).Value * x.Cells(4).Value & "," & x.Cells(2).Value * x.Cells(4).Value * x.Cells(5).Value / 100 & ")")
            Next
            Pesan("PO berhasil dibuat", 1)
            GoTo 1
        ElseIf BStatus = "PO" Then 'PO Disetujui
            QN("UPDATE TBLMasuk SET Tanggal = #" & Now & "#, ID_Supplier = " & Val(TSupplier.SelectedItem.Substring(0, TSupplier.SelectedItem.IndexOf(" "))) & ", Subtotal = " & Subtotal & ", PPN = " & PPN & ", BiayaLain = " & BiayaLain & ", Terbayar = " & Dibayar & ", Status = '" & AStatus & "', Keterangan = '" & TKeterangan.Text & "' WHERE ID_Masuk = '" & TFaktur.SelectedItem & "'")
            QRL("SELECT Faktur FROM TBLDetailMasuk WHERE ID_Masuk = '" & TFaktur.SelectedItem & "'")
            Do While DR.Read
                QN("DELETE FROM TBLTransaksi WHERE Faktur = " & DR(0) & "")
            Loop
            QN("DELETE FROM TBLDetailMasuk WHERE ID_Masuk = '" & TFaktur.SelectedItem & "'")
            For Each x In DGV.Rows
                If IsDate(x.Cells(7).Value) Then
                    QN("INSERT INTO TBLTransaksi(ID_Barang, Terbeli, HargaBeli, HargaJual, Kedaluwarsa) VALUES(" & x.Cells(0).Value & "," & x.Cells(2).Value & "," & x.Cells(4).Value & "," & x.Cells(8).Value & ",#" & CDate(x.Cells(7).Value) & "#)")
                Else
                    QN("INSERT INTO TBLTransaksi(ID_Barang, Terbeli, HargaBeli, HargaJual) VALUES(" & x.Cells(0).Value & "," & x.Cells(2).Value & "," & x.Cells(4).Value & "," & x.Cells(8).Value & ")")
                End If
                QR("SELECT Faktur FROM TBLTransaksi ORDER BY Faktur DESC")
                QN("INSERT INTO TBLDetailMasuk VALUES('" & TFaktur.SelectedItem & "'," & DR(0) & "," & x.Cells(9).Value & "," & x.Cells(2).Value & "," & x.Cells(9).Value + x.Cells(2).Value & "," & x.Cells(2).Value * x.Cells(4).Value & "," & x.Cells(2).Value * x.Cells(4).Value * x.Cells(5).Value / 100 & ")")
                QN("UPDATE TBLBarang SET Stok = " & x.Cells(9).Value + x.Cells(2).Value & " WHERE ID_Barang = " & x.Cells(0).Value & "")
            Next
        ElseIf BStatus = "Belum Lunas" Then 'Belum Lunas
            QN("UPDATE TBLMasuk SET ID_Supplier = " & Val(TSupplier.SelectedItem.Substring(0, TSupplier.SelectedItem.IndexOf(" "))) & ", Terbayar = " & Terbayar + Dibayar & ", Status = '" & AStatus & "', Keterangan = '" & TKeterangan.Text & "' WHERE ID_Masuk = '" & TFaktur.SelectedItem & "'")
            For Each x In DGV.Rows
                QR("SELECT TBLDetailMasuk.Faktur FROM TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur WHERE ID_Masuk = '" & TFaktur.SelectedItem & "' AND ID_Barang = " & x.Cells(0).Value & "")
                If IsDate(x.Cells(7).Value) Then
                    QN("UPDATE TBLTransaksi SET Kedaluwarsa = #" & CDate(x.Cells(7).Value) & "# WHERE Faktur = " & DR(0) & "")
                Else
                    QN("UPDATE TBLTransaksi SET Kedaluwarsa = NULL WHERE Faktur = " & DR(0) & "")
                End If
            Next
        End If
        QR("SELECT COUNT(*) FROM TBLBayarMasuk WHERE ID_Masuk = '" & TFaktur.SelectedItem & "'")
        QN("INSERT INTO TBLBayarMasuk VALUES('" & TFaktur.SelectedItem & "', #" & Now & "#, 'Faktur Pembelian " & TFaktur.SelectedItem & " Pembayaran Ke-" & DR(0) + 1 & " (" & AStatus & ")', " & Dibayar & ", '" & UserAktif & "')")
        Pesan("Transaksi berhasil (" & AStatus & ")", 1)
1:      TampilFaktur()
        CONN.Dispose()
        Koneksi()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus Faktur " & TFaktur.SelectedItem & "?")
        If Confirm.ShowDialog() = DialogResult.Yes Then
            QRL("SELECT Faktur FROM TBLDetailMasuk WHERE ID_Masuk = '" & TFaktur.SelectedItem & "'")
            Do While DR.Read
                QN("DELETE FROM TBLTransaksi WHERE Faktur = " & DR(0) & "")
            Loop
            QN("DELETE FROM TBLMasuk WHERE ID_Masuk = '" & TFaktur.SelectedItem & "'")
            Pesan("Purchase Order dihapus", 1)
            TampilFaktur()
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 0
        CurrentPage = 1
        TampilFaktur()
    End Sub

    Private Sub TCariBarang_TextChanged(sender As Object, e As EventArgs) Handles TCariBarang.TextChanged
        FetchData = 0
        CurrentPage = 1
        QDGV("SELECT ID_Barang, Nama + ' (' + Satuan + ')' AS [Daftar Barang], Satuan, Stok, Nama, HargaBeli, HargaJual FROM TBLBarang WHERE Nama LIKE '%" & TCariBarang.Text & "%' OR Satuan LIKE '%" & TCariBarang.Text & "%' ORDER BY Nama ASC", DGVBarang, FetchData, 14, 0)
        Paging()
    End Sub

    Private Sub DGVBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVBarang.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        For Each x In DGV.Rows
            If x.Cells(0).Value = DGVBarang.Rows(e.RowIndex).Cells(0).Value Or BStatus = "Belum Lunas" Then Exit Sub
        Next
        DGV.Rows.Add(DGVBarang.Rows(e.RowIndex).Cells(0).Value, DGVBarang.Rows(e.RowIndex).Cells(4).Value, 1, DGVBarang.Rows(e.RowIndex).Cells(2).Value, DGVBarang.Rows(e.RowIndex).Cells(5).Value, 0, 0, "", DGVBarang.Rows(e.RowIndex).Cells(6).Value, DGVBarang.Rows(e.RowIndex).Cells(3).Value)
        Hitung()
        ControlOtomatis()
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If DGV.Rows(e.RowIndex).Cells(2).Value <= 0 Then DGV.Rows(e.RowIndex).Cells(2).Value = 1
        If DGV.Rows(e.RowIndex).Cells(4).Value <= 0 Then DGV.Rows(e.RowIndex).Cells(4).Value = 1
        If DGV.Rows(e.RowIndex).Cells(8).Value <= 0 Then DGV.Rows(e.RowIndex).Cells(8).Value = 1
        Hitung()
        ControlOtomatis()
        Validasi()
    End Sub

    Private Sub DGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        Dim Angka As TextBox = CType(e.Control, TextBox)
        Dim Tanggal As TextBox = CType(e.Control, TextBox)
        RemoveHandler Tanggal.KeyPress, AddressOf Tanggal_KeyPress
        RemoveHandler Angka.KeyPress, AddressOf Angka_KeyPress
        If DGV.CurrentCell.ColumnIndex = 7 Then
            AddHandler Tanggal.KeyPress, AddressOf Tanggal_KeyPress
        Else
            AddHandler Angka.KeyPress, AddressOf Angka_KeyPress
        End If
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If Asc(e.KeyChar) = 27 Then DGV.Rows.Remove(DGV.CurrentRow)
        Hitung()
        ControlOtomatis()
        Validasi()
    End Sub

    Private Sub InputAngka(sender As Object, e As KeyPressEventArgs) Handles TDibayar.KeyPress, TPPN.KeyPress, TBiayaLain.KeyPress
        Angka(e)
        If (sender.Text = "" And Asc(e.KeyChar) = 48) Or (sender Is TDibayar And Val(TDibayar.Text) = GrandSisa And Not Asc(e.KeyChar) = 8) Then
            e.Handled = 1
        End If
    End Sub

#Region "DGVBarang Pagination"
    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        QR("SELECT COUNT(ID_Barang) FROM TBLBarang WHERE Nama LIKE '%" & TCariBarang.Text & "%' OR Satuan LIKE '%" & TCariBarang.Text & "%'")
        If DR(0) Mod 14 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 14) + 1 Then DGVBarangPrev.PerformClick()
        DGVBarangPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(DR(0) / 14) = 0, 1, Math.Ceiling(DR(0) / 14))
        If CurrentPage = 1 Then DGVBarangPrev.Enabled = 0 Else DGVBarangPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(DR(0) / 14) Then DGVBarangNext.Enabled = 0 Else DGVBarangNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        QDGV("SELECT ID_Barang, Nama + ' (' + Satuan + ')' AS [Daftar Barang], Satuan, Stok, Nama, HargaBeli, HargaJual FROM TBLBarang ORDER BY Nama ASC", DGVBarang, FetchData, 14, 0)
        Paging()
    End Sub

    Private Sub DGVBarangPrevClick(sender As Object, e As EventArgs) Handles DGVBarangPrev.Click
        FetchData -= 14
        DS.Clear()
        DA.Fill(DS, FetchData, 14, 0)
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVBarangNextClick(sender As Object, e As EventArgs) Handles DGVBarangNext.Click
        FetchData += 14
        DS.Clear()
        DA.Fill(DS, FetchData, 14, 0)
        CurrentPage += 1
        Paging()
    End Sub
#End Region

End Class
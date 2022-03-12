Public Class Keluar

    Dim TglKeluar As Date
    Dim Subtotal As Integer
    Dim PPN As Integer
    Dim BiayaLain As Integer
    Dim Terbayar As Integer
    Dim GrandSisa As Integer
    Dim Dibayar As Integer
    Dim Kurang As Integer

    Dim BStatus As String
    Dim AStatus As String

    Dim TotalHarga As Long

    Dim IDBarang As Integer
    Dim NamaBarang As String
    Dim StokBarang As Integer
    Dim QtyBarang As Integer

    Dim TotalHargaBarangAVG As Long
    Dim TotalHargaBarang As Long

    Sub TampilFaktur()
        TFaktur.Items.Clear()
        QR("SELECT ID_Keluar FROM TBLKeluar ORDER BY ID_Keluar DESC")
        If DR.HasRows AndAlso Mid(DR(0), 2, 6) = Format(Today, "yyMMdd") Then TFaktur.Items.Add("K" & Microsoft.VisualBasic.Right(DR(0), 8) + 1) Else TFaktur.Items.Add("K" & Format(Today, "yyMMdd") & "01")
        QRL("SELECT ID_Keluar FROM TBLKeluar WHERE Status = 'Belum Lunas' ORDER BY ID_Keluar DESC")
        Do While DR.Read
            TFaktur.Items.Add(DR(0))
        Loop
        TFaktur.SelectedIndex = 0
    End Sub

    Sub Clear()
        TCustomer.SelectedIndex = -1
        TMetode.SelectedIndex = 0
        DGV.Rows.Clear()
        TCariBarang.Clear()
        TampilDGV()
        TglKeluar = Now
        Subtotal = 0
        PPN = 0
        BiayaLain = 0
        Terbayar = 0
        GrandSisa = 0
        Dibayar = 0
        Kurang = 0
        BStatus = Nothing
        AStatus = Nothing

        IDBarang = 0
        NamaBarang = Nothing
        StokBarang = 0
        QtyBarang = 0

        RemoveHandler TMetode.SelectedIndexChanged, AddressOf TMetode_SelectedIndexChanged
        TMetode.SelectedIndex = 0
        AddHandler TMetode.SelectedIndexChanged, AddressOf TMetode_SelectedIndexChanged

        TKeterangan.Clear()
        TPPN.Text = PPNOtomatis
        TBiayaLain.Clear()
        TDibayar.Clear()

        LBLDetailBarang.Text = ""
        DGVDetailBarang.Rows.Clear()

        Akses("Keluar", 1, 0, 0, 0, 1, "Grand Total :", 1, 1, 1)
    End Sub

    Sub Akses(TTitle As String, EMetode As Integer, VTglKeluar As Integer, VTerbayar As Integer, RDGV As Integer, VDGV As Integer, TGrandSisa As String, EPPN As Integer, EBiayaLain As Integer, VDetailBarang As Integer)
        MainF.LBLTitle.Text = TTitle
        TMetode.Enabled = EMetode
        LBLTglKeluar.Visible = VTglKeluar
        TTglKeluar.Visible = VTglKeluar
        LBLTerbayar.Visible = VTerbayar
        TTerbayar.Visible = VTerbayar
        DGV.ReadOnly = RDGV
        DGV.Columns(2).Visible = VDGV
        LBLGrandSisa.Text = TGrandSisa
        TPPN.Enabled = EPPN
        TBiayaLain.Enabled = EBiayaLain
        LBLDetailBarang.Visible = VDetailBarang
        DGVDetailBarang.Visible = VDetailBarang
    End Sub

    Private Sub TFaktur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TFaktur.SelectedIndexChanged
        Clear()
        QR("SELECT * FROM TBLKeluar WHERE ID_Keluar = '" & TFaktur.SelectedItem & "'")
        If Not DR.HasRows Then 'Buat Baru
            ControlOtomatis()
            DGV.Columns(1).Width = 450
            BTNSimpan.Values.Image = My.Resources.crud_simpan_pressed
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_simpan_common
            Akses("Keluar", 1, 0, 0, 0, 1, "Grand Total :", 1, 1, 1)
        Else 'Belum Lunas
            DGV.Columns(1).Width = 525
            For Each x In TCustomer.Items
                If x.Substring(0, x.IndexOf(" ")) = DR("ID_Customer") Then
                    TCustomer.SelectedItem = x
                    Exit For
                End If
            Next
            TKeterangan.Text = DR("Keterangan")
            TglKeluar = DR("Tanggal")
            PPN = DR("PPN")
            TPPN.Text = CInt(DR("PPN") / DR("Subtotal") * 100)
            BiayaLain = DR("BiayaLain")
            TBiayaLain.Text = DR("BiayaLain")
            Terbayar = DR("Terbayar")
            BStatus = DR("Status")
            TMetode.SelectedItem = DR("Metode")
            QRL("SELECT TBLBarang.ID_Barang, MAX(Nama), SUM(Stok), SUM(Qty), MAX(Satuan), SUM(Diskon) / SUM(TotalHarga) * 100, SUM(TotalHarga) - SUM(Diskon) FROM (TBLBarang INNER JOIN TBLTransaksi ON TBLBarang.ID_Barang = TBLTransaksi.ID_Barang) INNER JOIN TBLDetailKeluar ON TBLTransaksi.Faktur = TBLDetailKeluar.Faktur WHERE TBLDetailKeluar.ID_Keluar = '" & TFaktur.SelectedItem & "' GROUP BY TBLBarang.ID_Barang")
            Do While DR.Read
                DGV.Rows.Add(DR(0), DR(1), DR(2), DR(3), DR(4), CInt(DR(5)), DR(6))
            Loop
            BTNSimpan.Values.Image = My.Resources.crud_edit_pressed
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_edit_common
            Hitung()
            ControlOtomatis()
            Akses("Piutang", 0, 1, 1, 1, 0, "Sisa :", 0, 0, 0)
        End If
    End Sub

    Sub Hitung()
        Subtotal = 0
        For Each x In DGV.Rows
            Subtotal += x.Cells("CTotalHarga").Value
        Next
        PPN = Subtotal * Val(TPPN.Text) / 100
        BiayaLain = Val(TBiayaLain.Text)
        GrandSisa = Math.Abs(Subtotal + PPN + BiayaLain - Terbayar)
        If Val(TDibayar.Text) >= GrandSisa Then
            AStatus = "Lunas"
            Dibayar = GrandSisa
            Kurang = 0
            If Not GrandSisa = 0 Then TDibayar.Text = Dibayar
        ElseIf Val(TDibayar.Text) < GrandSisa Then
            AStatus = "Belum Lunas"
            Dibayar = Val(TDibayar.Text)
            Kurang = GrandSisa - Dibayar
        End If
    End Sub

    Sub ControlOtomatis()
        TTglKeluar.Text = Format(TglKeluar, "dd/MM/yyyy")
        TSubtotal.Text = FormatNumber(Subtotal, 0)
        TTerbayar.Text = FormatNumber(Terbayar, 0)
        TGrandSisa.Text = FormatNumber(GrandSisa, 0)
        TKurang.Text = FormatNumber(Kurang, 0)
    End Sub

    Private Sub TCariBarang_TextChanged(sender As Object, e As EventArgs) Handles TCariBarang.TextChanged
        TampilDGV()
    End Sub

    Private Sub DGVBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVBarang.CellMouseClick
        If e.RowIndex < 0 Or TFaktur.SelectedIndex > 0 Then Exit Sub
        For Each x In DGV.Rows
            If x.Cells(0).Value = DGVBarang.Rows(e.RowIndex).Cells(0).Value Then Exit Sub
        Next
        DGV.Rows.Add(DGVBarang.Rows(e.RowIndex).Cells(0).Value, DGVBarang.Rows(e.RowIndex).Cells(4).Value, DGVBarang.Rows(e.RowIndex).Cells(3).Value, 0, DGVBarang.Rows(e.RowIndex).Cells(2).Value, 0, 0)
        Hitung()
        ControlOtomatis()
        Validasi()
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If DGV.Rows(e.RowIndex).Cells("CQty").Value > DGV.Rows(e.RowIndex).Cells("CStok").Value Then
            DGV.Rows(e.RowIndex).Cells("CQty").Value = DGV.Rows(e.RowIndex).Cells("CStok").Value
        End If
        IDBarang = DGV.Rows(e.RowIndex).Cells("CIDBarang").Value
        NamaBarang = DGV.Rows(e.RowIndex).Cells("CNamaBarang").Value
        StokBarang = DGV.Rows(e.RowIndex).Cells("CStok").Value
        QtyBarang = DGV.Rows(e.RowIndex).Cells("CQty").Value
        TampilDGVDetailBarang()
        TotalHargaBarangAVG = 0
        TotalHargaBarang = 0
        GrandSisa = 0
        If TMetode.SelectedItem = "LIFO" Then
            QRL("SELECT Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & DGV.Rows(e.RowIndex).Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Tanggal DESC")
        ElseIf TMetode.SelectedItem = "FEFO" Then
            QRL("SELECT Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & DGV.Rows(e.RowIndex).Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Kedaluwarsa ASC, Tanggal ASC")
        Else
            QRL("SELECT Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & DGV.Rows(e.RowIndex).Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Tanggal ASC")
        End If
        TotalHarga = 0
        Do While DR.Read
            TotalHarga += (DR(0) - DR(1)) * DR(2)
            If QtyBarang >= DR(0) - DR(1) Then
                TotalHargaBarang += (DR(0) - DR(1)) * DR(2)
                QtyBarang -= DR(0) - DR(1)
            Else
                TotalHargaBarang += QtyBarang * DR(2)
                QtyBarang = 0
            End If
        Loop
        If TMetode.SelectedItem = "AVG" Then
            TotalHargaBarangAVG = CInt(DGV.Rows(e.RowIndex).Cells("CQty").Value * (TotalHarga / DGV.Rows(e.RowIndex).Cells("CStok").Value))
            DGV.Rows(e.RowIndex).Cells("CTotalHarga").Value = TotalHargaBarangAVG * (100 - DGV.Rows(e.RowIndex).Cells("CDiskon").Value) / 100
        Else
            DGV.Rows(e.RowIndex).Cells("CTotalHarga").Value = TotalHargaBarang * (100 - DGV.Rows(e.RowIndex).Cells("CDiskon").Value) / 100
        End If
        Hitung()
        ControlOtomatis()
        Validasi()
    End Sub

    Sub Validasi()
        For Each x In DGV.Rows
            If TFaktur.SelectedIndex = -1 Or TCustomer.SelectedIndex = -1 Or DGV.Rows.Count = 0 Or Val(TDibayar.Text) = 0 Or x.Cells(3).Value = 0 Then
                BTNSimpan.Enabled = 0
                Exit For
            Else
                BTNSimpan.Enabled = 1
            End If
        Next
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        IDBarang = DGV.Rows(e.RowIndex).Cells("CIDBarang").Value
        NamaBarang = DGV.Rows(e.RowIndex).Cells("CNamaBarang").Value
        StokBarang = DGV.Rows(e.RowIndex).Cells("CStok").Value
        QtyBarang = DGV.Rows(e.RowIndex).Cells("CQty").Value
        TampilDGVDetailBarang()
    End Sub

    Sub TampilDGVDetailBarang()
        If IDBarang = Nothing Or TFaktur.SelectedIndex > 0 Then Exit Sub
        Dim QtySemula As Integer = QtyBarang
        LBLDetailBarang.Text = "Detail pada barang : " & NamaBarang & " (" & QtyBarang & ")"
        DGVDetailBarang.Rows.Clear()
        If TMetode.SelectedItem = "LIFO" Then
            QRL("SELECT Stok, Satuan, TBLTransaksi.Faktur, Tanggal, Terbeli, Terjual, TBLTransaksi.HargaJual, FORMAT(Kedaluwarsa, 'dd-MM-yyyy') FROM (TBLBarang INNER JOIN TBLTransaksi ON TBLBarang.ID_Barang = TBLTransaksi.ID_Barang) INNER JOIN (TBLMasuk INNER JOIN TBLDetailMasuk ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk) ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur WHERE TBLTransaksi.ID_Barang = " & IDBarang & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Tanggal DESC")
        ElseIf TMetode.SelectedItem = "FEFO" Then
            QRL("SELECT Stok, Satuan, TBLTransaksi.Faktur, Tanggal, Terbeli, Terjual, TBLTransaksi.HargaJual, FORMAT(Kedaluwarsa, 'dd-MM-yyyy') FROM (TBLBarang INNER JOIN TBLTransaksi ON TBLBarang.ID_Barang = TBLTransaksi.ID_Barang) INNER JOIN (TBLMasuk INNER JOIN TBLDetailMasuk ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk) ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur WHERE TBLTransaksi.ID_Barang = " & IDBarang & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Kedaluwarsa ASC, Tanggal ASC")
        Else
            QRL("SELECT Stok, Satuan, TBLTransaksi.Faktur, Tanggal, Terbeli, Terjual, TBLTransaksi.HargaJual, FORMAT(Kedaluwarsa, 'dd-MM-yyyy') FROM (TBLBarang INNER JOIN TBLTransaksi ON TBLBarang.ID_Barang = TBLTransaksi.ID_Barang) INNER JOIN (TBLMasuk INNER JOIN TBLDetailMasuk ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk) ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur WHERE TBLTransaksi.ID_Barang = " & IDBarang & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Tanggal ASC")
        End If
        Do While DR.Read
            DGVDetailBarang.Rows.Add(DR(2), Format(DR(3), "dd/MM/yyyy"), DR(4) - DR(5), DR(6), 0, 0, 0, 0, DR(7))
        Loop
        For Each x In DGVDetailBarang.Rows
            If QtyBarang >= x.Cells(2).Value Then
                x.Cells(4).Value = x.Cells(2).Value
                QtyBarang -= x.Cells(2).Value
                x.Cells(7).Value = QtyBarang
            ElseIf QtyBarang > 0 Then
                x.Cells(4).Value = QtyBarang
                QtyBarang -= x.Cells(2).Value
                If x.Cells(2).Value <> x.Cells(4).Value Then x.Cells(7).Value = 0 Else x.Cells(7).Value = x.Cells(4).Value
            ElseIf QtyBarang = 0 Then
                x.Cells(4).Value = 0
            End If
            If TMetode.SelectedItem <> "AVG" Then
                x.Cells(5).Value = x.Cells(3).Value * x.Cells(4).Value
            Else
                TotalHarga = 0
                For Each y In DGVDetailBarang.Rows
                    TotalHarga += y.Cells(2).Value * y.Cells(3).Value
                Next
                x.Cells(5).Value = TotalHarga / StokBarang * x.Cells(4).Value
            End If
            x.Cells(6).Value = x.Cells(2).Value - x.Cells(4).Value
        Next
        QtyBarang = QtySemula
    End Sub

    Private Sub Keluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        DGVBarang.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        RemoveHandler TFaktur.SelectedIndexChanged, AddressOf TFaktur_SelectedIndexChanged
        TampilFaktur()
        AddHandler TFaktur.SelectedIndexChanged, AddressOf TFaktur_SelectedIndexChanged
        QRL("SELECT ID_Customer, Nama FROM tblcustomer ORDER BY Nama ASC")
        Do While DR.Read
            TCustomer.Items.Add(DR(0) & " - " & DR(1))
        Loop
        QDGV("SELECT ID_Barang, Nama + ' (' + Satuan + ')' AS [Daftar Barang], Satuan, Stok, Nama FROM TBLBarang WHERE Stok > 0 ORDER BY Nama ASC", DGVBarang, FetchData, 14, 0)
        DGVBarang.Columns(0).Visible = 0
        DGVBarang.Columns(2).Visible = 0
        DGVBarang.Columns(3).Visible = 0
        DGVBarang.Columns(4).Visible = 0
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        CONN.Dispose()
        Koneksi()
        Dim StokPerBarang As Integer
        Dim QtyPerBarang As Integer
        If BStatus = Nothing Then
            QN("INSERT INTO TBLKeluar(ID_Keluar, Tanggal, ID_Customer, Subtotal, PPN, BiayaLain, Terbayar, Status, Keterangan, Metode) VALUES('" & TFaktur.SelectedItem & "',#" & Now & "#," & Val(TCustomer.SelectedItem.Substring(0, TCustomer.SelectedItem.IndexOf(" "))) & "," & Subtotal & "," & PPN & "," & Val(TBiayaLain.Text) & "," & Dibayar & ",'" & AStatus & "','" & TKeterangan.Text & "','" & TMetode.SelectedItem & "')")
            For Each x In DGV.Rows
                TotalHarga = 0
                StokPerBarang = x.Cells("CStok").Value
                QtyPerBarang = x.Cells("CQty").Value
2:              If TMetode.SelectedItem = "LIFO" Then
                    QRL("SELECT TBLTransaksi.Faktur, Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & x.Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Tanggal DESC")
                ElseIf TMetode.SelectedItem = "FEFO" Then
                    QRL("SELECT TBLTransaksi.Faktur, Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & x.Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Kedaluwarsa ASC, Tanggal ASC")
                Else
                    QRL("SELECT TBLTransaksi.Faktur, Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & x.Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Tanggal ASC")
                End If
                If TotalHarga > 0 Then GoTo 1
                Do While DR.Read
                    TotalHarga += (DR(1) - DR(2)) * DR(3)
                Loop
                GoTo 2
1:              Do While DR.Read
                    If QtyPerBarang >= DR(1) - DR(2) Then
                        QN("UPDATE TBLTransaksi SET Terjual = " & DR(1) & " WHERE ID_Barang = " & x.Cells("CIDBarang").Value & " AND Faktur = " & DR(0) & "")
                        If TMetode.SelectedItem = "AVG" Then
                            QN("INSERT INTO TBLDetailKeluar VALUES('" & TFaktur.SelectedItem & "'," & DR(0) & "," & StokPerBarang & "," & DR(1) - DR(2) & "," & StokPerBarang - (DR(1) - DR(2)) & "," & TotalHarga / x.Cells("CStok").Value * (DR(1) - DR(2)) & "," & TotalHarga / x.Cells("CStok").Value * (DR(1) - DR(2)) * x.Cells("CDiskon").Value / 100 & ")")
                        Else
                            QN("INSERT INTO TBLDetailKeluar VALUES('" & TFaktur.SelectedItem & "'," & DR(0) & "," & StokPerBarang & "," & DR(1) - DR(2) & "," & StokPerBarang - (DR(1) - DR(2)) & "," & (DR(1) - DR(2)) * DR(3) & "," & (DR(1) - DR(2)) * DR(3) * x.Cells("CDiskon").Value / 100 & ")")
                        End If
                    Else
                        QN("UPDATE TBLTransaksi SET Terjual = " & DR(2) + QtyPerBarang & " WHERE ID_Barang = " & x.Cells("CIDBarang").Value & " AND Faktur = " & DR(0) & "")
                        If TMetode.SelectedItem = "AVG" Then
                            QN("INSERT INTO TBLDetailKeluar VALUES('" & TFaktur.SelectedItem & "'," & DR(0) & "," & StokPerBarang & "," & QtyPerBarang & "," & StokPerBarang - QtyPerBarang & "," & TotalHarga / x.Cells("CStok").Value * QtyPerBarang & "," & TotalHarga / x.Cells("CStok").Value * QtyPerBarang * x.Cells("CDiskon").Value / 100 & ")")
                        Else
                            QN("INSERT INTO TBLDetailKeluar VALUES('" & TFaktur.SelectedItem & "'," & DR(0) & "," & StokPerBarang & "," & QtyPerBarang & "," & StokPerBarang - QtyPerBarang & "," & QtyPerBarang * DR(3) & "," & QtyPerBarang * DR(3) * x.Cells("CDiskon").Value / 100 & ")")
                        End If
                    End If
                    StokPerBarang -= DR(1) - DR(2)
                    QtyPerBarang -= DR(1) - DR(2)
                    If StokPerBarang <= 0 Or QtyPerBarang <= 0 Then Exit Do
                Loop
                QN("UPDATE TBLBarang SET Stok = " & x.Cells("CStok").Value - x.Cells("CQty").Value & " WHERE ID_Barang = " & x.Cells("CIDBarang").Value & "")
            Next
        Else
            QN("UPDATE TBLKeluar SET ID_Customer = " & Val(TCustomer.SelectedItem.Substring(0, TCustomer.SelectedItem.IndexOf(" "))) & ", Terbayar = " & Terbayar + Dibayar & ", Status = '" & AStatus & "', Keterangan = '" & TKeterangan.Text & "' WHERE ID_Keluar = '" & TFaktur.SelectedItem & "'")
        End If
        QR("SELECT COUNT(*) FROM TBLBayarKeluar WHERE ID_Keluar = '" & TFaktur.SelectedItem & "'")
        QN("INSERT INTO TBLBayarKeluar VALUES('" & TFaktur.SelectedItem & "', #" & Now & "#, 'Faktur Penjualan " & TFaktur.SelectedItem & " Pembayaran Ke-" & DR(0) + 1 & " (" & AStatus & ")', " & Dibayar & ", '" & UserAktif & "')")
        Pesan("Transaksi berhasil (" & AStatus & ")", 1)
        TampilFaktur()
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        TampilFaktur()
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TCustomer.SelectedIndexChanged, TPPN.TextChanged, TDibayar.TextChanged, TBiayaLain.TextChanged
        Hitung()
        ControlOtomatis()
        Validasi()
    End Sub

    Private Sub DGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        Dim Angka As TextBox = CType(e.Control, TextBox)
        If Not DGV.CurrentCell.ColumnIndex = 0 Then AddHandler Angka.KeyPress, AddressOf Angka_KeyPress
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        DGVDetailBarang.Rows.Clear()
        If Asc(e.KeyChar) = 27 Then DGV.Rows.Remove(DGV.CurrentRow)
        LBLDetailBarang.Text = "Detail pada barang :"
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

    Private Sub TMetode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TMetode.SelectedIndexChanged
        If TFaktur.SelectedIndex > 0 Then Exit Sub
        TotalHargaBarangAVG = 0
        TotalHargaBarang = 0
        GrandSisa = 0
        For Each x In DGV.Rows
            IDBarang = x.Cells("CIDBarang").Value
            NamaBarang = x.Cells("CNamaBarang").Value
            StokBarang = x.Cells("CStok").Value
            QtyBarang = x.Cells("CQty").Value
            TampilDGVDetailBarang()
            TotalHarga = 0
            If TMetode.SelectedItem = "LIFO" Then
                QRL("SELECT Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & x.Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Tanggal DESC")
            ElseIf TMetode.SelectedItem = "FEFO" Then
                QRL("SELECT Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & x.Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Kedaluwarsa ASC, Tanggal ASC")
            Else
                QRL("SELECT Terbeli, Terjual, TBLTransaksi.HargaJual FROM TBLMasuk INNER JOIN (TBLTransaksi INNER JOIN TBLDetailMasuk ON TBLTransaksi.Faktur = TBLDetailMasuk.Faktur) ON TBLMasuk.ID_Masuk = TBLDetailMasuk.ID_Masuk WHERE TBLTransaksi.ID_Barang = " & x.Cells(0).Value & " AND Terbeli > Terjual AND NOT Status = 'PO' ORDER BY Tanggal ASC")
            End If
            Do While DR.Read
                TotalHarga += (DR(0) - DR(1)) * DR(2)
                If QtyBarang >= DR(0) - DR(1) Then
                    TotalHargaBarang += (DR(0) - DR(1)) * DR(2)
                    QtyBarang -= DR(0) - DR(1)
                Else
                    TotalHargaBarang += QtyBarang * DR(2)
                    QtyBarang = 0
                End If
            Loop
            If TMetode.SelectedItem = "AVG" Then
                TotalHargaBarangAVG = CInt(x.Cells("CQty").Value * (TotalHarga / x.Cells("CStok").Value))
                x.Cells("CTotalHarga").Value = TotalHargaBarangAVG * (100 - x.Cells("CDiskon").Value) / 100
            Else
                x.Cells("CTotalHarga").Value = TotalHargaBarang * (100 - x.Cells("CDiskon").Value) / 100
            End If
            TotalHargaBarang = 0
        Next
        Hitung()
        ControlOtomatis()
    End Sub

#Region "DGVBarang Pagination"
    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        QR("SELECT COUNT(ID_Barang) FROM TBLBarang WHERE Stok > 0 AND Nama LIKE '%" & TCariBarang.Text & "%' OR Satuan LIKE '%" & TCariBarang.Text & "%'")
        If DR(0) Mod 14 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 14) + 1 Then DGVBarangPrev.PerformClick()
        DGVBarangPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(DR(0) / 14) = 0, 1, Math.Ceiling(DR(0) / 14))
        If CurrentPage = 1 Then DGVBarangPrev.Enabled = 0 Else DGVBarangPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(DR(0) / 14) Then DGVBarangNext.Enabled = 0 Else DGVBarangNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        FetchData = 0
        CurrentPage = 1
        QDGV("SELECT ID_Barang, Nama + ' (' + Satuan + ')' AS [Daftar Barang], Satuan, Stok, Nama FROM TBLBarang WHERE Stok > 0 AND Nama LIKE '%" & TCariBarang.Text & "%' OR Satuan LIKE '%" & TCariBarang.Text & "%' ORDER BY Nama ASC", DGVBarang, FetchData, 14, 0)
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
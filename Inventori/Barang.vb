Public Class Barang

    Sub Notis()
        BTNSimpan.Values.Image = My.Resources.crud_simpan_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_simpan_common
        TID.Text = 1
        Dim x = 0
        QRL("SELECT ID_Barang FROM TBLBarang ORDER BY ID_Barang ASC")
        Do While DR.Read
            x += 1
            If Not DR.HasRows Then
                TID.Text = 1
            Else
                If DR(0) <> x Then
                    TID.Text = x
                    Exit Sub
                Else
                    TID.Text = x + 1
                End If
            End If
        Loop
    End Sub

    Sub Clear()
        Notis()
        TNama.Clear()
        TSatuan.Clear()
        TampilSatuan()
        TLokasi.Clear()
        TStok.Clear()
        TStok.Enabled = 1
        THargaBeli.Clear()
        THargaJual.Clear()
        TCariData.Clear()
        TampilDGV()
        TNama.Focus()
    End Sub

    Sub CariID()
        QR("SELECT * FROM TBLBarang WHERE ID_Barang = " & Val(TID.Text) & "")
    End Sub

    Sub TampilSatuan()
        TSatuan.AutoCompleteCustomSource.Clear()
        QRL("SELECT DISTINCT Satuan FROM TBLBarang ORDER BY Satuan")
        Do While DR.Read
            TSatuan.AutoCompleteCustomSource.Add(DR(0))
        Loop
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TSatuan.TextChanged, TNama.TextChanged
        If TNama.Text = "" Or TSatuan.Text = "" Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Dim Lebar() As Integer = {85, 270, 86, 385, 102, 102, 64}
        Dim i = 0
        For Each x In DGV.Columns
            x.SortMode = DataGridViewColumnSortMode.NotSortable
            x.Width = Lebar(i)
            i += 1
        Next
        DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(4).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(5).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        CariID()
        If Not DR.HasRows Then
            QN("INSERT INTO TBLBarang VALUES(" & Val(TID.Text) & ",'" & TNama.Text & "','" & TSatuan.Text.Substring(0, 1).ToUpper() + TSatuan.Text.Substring(1).ToLower() & "','" & TLokasi.Text & "'," & Val(THargaBeli.Text) & "," & Val(THargaJual.Text) & "," & Val(TStok.Text) & ")")
            Pesan("Barang berhasil ditambah", 1)
        Else
            QN("UPDATE TBLBarang SET Nama = '" & TNama.Text & "', Satuan = '" & TSatuan.Text.Substring(0, 1).ToUpper() + TSatuan.Text.Substring(1).ToLower() & "', Lokasi = '" & TLokasi.Text & "', HargaBeli = '" & Val(THargaBeli.Text) & "', HargaJual = '" & Val(THargaJual.Text) & "' WHERE ID_Barang = " & Val(TID.Text) & "")
            Pesan("Barang berhasil diubah", 1)
        End If
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT ID_Barang FROM TBLTransaksi WHERE ID_Barang = " & Val(TID.Text) & "")
        If DR.HasRows Then
            Pesan("Barang pernah terlibat dalam transaksi", 0)
            Exit Sub
        End If
        CariID()
        If Not DR.HasRows Then
            Pesan("ID Barang tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & DR(1) & "?")
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLBarang WHERE ID_Barang = " & Val(TID.Text) & "")
                Pesan("Barang berhasil dihapus", 1)
                Clear()
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 0
        CurrentPage = 1
        Clear()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        TID.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        CariID()
        TNama.Text = DR(1)
        TSatuan.Text = DR(2)
        TLokasi.Text = DR(3)
        THargaBeli.Text = DR(4)
        THargaJual.Text = DR(5)
        TStok.Text = DR(6)
        TStok.Enabled = 0
        BTNSimpan.Values.Image = My.Resources.crud_edit_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_edit_common
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
    End Sub

    Private Sub InputAngka(sender As Object, e As KeyPressEventArgs) Handles TStok.KeyPress, THargaBeli.KeyPress, THargaJual.KeyPress
        Angka(e)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, koentji As Keys) As Boolean
        If koentji = Keys.Enter Then
            BTNSimpan.PerformClick()
            Return True
        ElseIf koentji = Keys.Escape Then
            BTNHapus.PerformClick()
            Return True
        ElseIf koentji = Keys.Oemtilde Then
            BTNClear.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, koentji)
    End Function

#Region "DGV Pagination"
    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        QR("SELECT COUNT(ID_Barang) FROM TBLBarang WHERE Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%' OR Lokasi LIKE '%" & TCariData.Text & "%'")
        If DR(0) Mod 13 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 13) + 1 Then DGVPrev.PerformClick()
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(DR(0) / 13) = 0, 1, Math.Ceiling(DR(0) / 13))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(DR(0) / 13) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        QDGV("SELECT ID_Barang AS [ID Barang], Nama AS [Nama Barang], Satuan, Lokasi, HargaBeli AS [Harga Beli], HargaJual AS [Harga Jual], Stok FROM TBLBarang WHERE Nama LIKE '%" & TCariData.Text & "%' OR Satuan LIKE '%" & TCariData.Text & "%' OR Lokasi LIKE '%" & TCariData.Text & "%' ORDER BY ID_Barang", DGV, FetchData, 13, 0)
        Paging()
    End Sub

    Private Sub DGVPrevClick(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 13
        DS.Clear()
        DA.Fill(DS, FetchData, 13, 0)
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNextClick(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 13
        DS.Clear()
        DA.Fill(DS, FetchData, 13, 0)
        CurrentPage += 1
        Paging()
    End Sub
#End Region
End Class
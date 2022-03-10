﻿Public Class LabaRugi

    Sub Notis()
        If RBPengeluaran.Checked = True Then
            QR("SELECT ID_LR FROM TBLLabaRugi WHERE ID_LR LIKE 'R%' ORDER BY ID_LR DESC")
            If DR.HasRows AndAlso Mid(DR(0), 2, 6) = Format(Today, "yyMMdd") Then TID.Text = "R" & Microsoft.VisualBasic.Right(DR(0), 8) + 1 Else TID.Text = "R" & Format(Today, "yyMMdd") & "01"
        ElseIf RBPendapatan.Checked = True Then
            QR("SELECT ID_LR FROM TBLLabaRugi WHERE ID_LR LIKE 'L%' ORDER BY ID_LR DESC")
            If DR.HasRows AndAlso Mid(DR(0), 2, 6) = Format(Today, "yyMMdd") Then TID.Text = "L" & Microsoft.VisualBasic.Right(DR(0), 8) + 1 Else TID.Text = "L" & Format(Today, "yyMMdd") & "01"
        End If
        RBPengeluaran.Visible = 1
        RBPendapatan.Visible = 1
        BTNSimpan.Values.Image = My.Resources.crud_simpan_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_simpan_common
    End Sub

    Sub Clear()
        Notis()
        RBPengeluaran.Checked = 1
        TNominal.Clear()
        TDeskripsi.Clear()
        TCariData.Clear()
        TNominal.Focus()
    End Sub

    Sub CariLR()
        QR("SELECT ID_LR, Deskripsi, Nominal FROM TBLLabaRugi WHERE ID_LR = '" & TID.Text & "'")
    End Sub

    Private Sub Ditampilkan(sender As Object, e As EventArgs) Handles CBTampilLabaRugi.CheckedChanged, CBTampilFaktur.CheckedChanged
        TampilDGV()
    End Sub

    Private Sub LabaRugi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Notis()
        TampilDGV()
        Timer1.Start()
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TNominal.TextChanged, TDeskripsi.TextChanged, RBPengeluaran.CheckedChanged, RBPendapatan.CheckedChanged
        If TDeskripsi.Text = "" Or TNominal.Text = "" Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
        CariLR()
        If Not DR.HasRows Then Notis()
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        CariLR()
        If Not DR.HasRows Then
            QN("INSERT INTO TBLLabaRugi VALUES('" & TID.Text & "','" & Now & "','" & TDeskripsi.Text & "','" & Val(TNominal.Text) & "','" & UserAktif & "')")
            Pesan("Data berhasil disimpan", 1)
        Else
            QN("UPDATE TBLLabaRugi SET Deskripsi = '" & TDeskripsi.Text & "', Nominal = " & Val(TNominal.Text) & " WHERE ID_LR = '" & TID.Text & "'")
            Pesan("Data berhasil diubah", 1)
        End If
        TampilDGV()
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        CariLR()
        If Not DR.HasRows Then
            Pesan("ID tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & DR(0) & "?")
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLLabaRugi WHERE ID_LR = '" & TID.Text & "'")
                Pesan("Data berhasil dihapus", 1)
                TampilDGV()
                Clear()
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
        Clear()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        FetchData = 0
        CurrentPage = 1
        If CBTampilLabaRugi.Checked = True And CBTampilFaktur.Checked = True Then
            QDGV("SELECT Tanggal, ID_LR AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Deskripsi, Nominal, Username FROM TBLLabaRugi WHERE ID_LR LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' UNION ALL SELECT Tanggal, ID_Masuk, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM'), Deskripsi, Nominal, Username FROM TBLBayarMasuk WHERE ID_Masuk LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' UNION ALL SELECT Tanggal, ID_Keluar, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM'), Deskripsi, Nominal, Username FROM TBLBayarKeluar WHERE ID_Keluar LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' ORDER BY 1 DESC", DGV, FetchData, 13, 0)
        ElseIf CBTampilLabaRugi.Checked = True Then
            QDGV("SELECT Tanggal, ID_LR AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Deskripsi, Nominal, Username FROM TBLLabaRugi WHERE ID_LR LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' ORDER BY 1 DESC", DGV, FetchData, 13, 0)
        ElseIf CBTampilFaktur.Checked = True Then
            QDGV("SELECT Tanggal, ID_Masuk AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Deskripsi, Nominal, Username FROM TBLBayarMasuk WHERE ID_Masuk LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' UNION ALL SELECT Tanggal, ID_Keluar, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM'), Deskripsi, Nominal, Username FROM TBLBayarKeluar WHERE ID_Keluar LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' ORDER BY 1 DESC", DGV, FetchData, 13, 0)
        End If
        Paging()
        Timer1.Start()
    End Sub

    Private Sub InputAngka(sender As Object, e As KeyPressEventArgs) Handles TNominal.KeyPress, TID.KeyPress
        Angka(e)
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        If Microsoft.VisualBasic.Left(DGV.Rows(e.RowIndex).Cells(1).Value, 1) = "K" Or Microsoft.VisualBasic.Left(DGV.Rows(e.RowIndex).Cells(1).Value, 1) = "M" Then
            Clear()
            Exit Sub
        End If
        TID.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TDeskripsi.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        TNominal.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        RBPengeluaran.Visible = 0
        RBPendapatan.Visible = 0
        BTNSimpan.Values.Image = My.Resources.crud_edit_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_edit_common
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each Style In DGV.Rows
            If Microsoft.VisualBasic.Left(Style.Cells(1).Value, 1) = "R" Or Microsoft.VisualBasic.Left(Style.Cells(1).Value, 1) = "M" Then
                Style.Cells(4).Style.ForeColor = Color.FromArgb(220, 53, 69)
                Style.Cells(4).Style.SelectionForeColor = Color.FromArgb(220, 53, 69)
            Else 'Hijau
                Style.Cells(4).Style.ForeColor = Color.FromArgb(40, 167, 69)
                Style.Cells(4).Style.SelectionForeColor = Color.FromArgb(40, 167, 69)
            End If
        Next
        Dim Lebar() As Integer = {5, 112, 188, 548, 115, 131}
        Dim i = 0
        For Each x In DGV.Columns
            x.SortMode = DataGridViewColumnSortMode.NotSortable
            x.Width = Lebar(i)
            i += 1
        Next
        DGV.Columns(0).Visible = 0
        DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(4).DefaultCellStyle.Format = "###,###,###"
        Timer1.Stop()
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
        If CBTampilLabaRugi.Checked = True And CBTampilFaktur.Checked = True Then
            QR("SELECT SUM(TBL.TiapTabel) FROM (SELECT COUNT(ID_LR) AS TiapTabel FROM TBLLabaRugi WHERE ID_LR LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' UNION ALL SELECT COUNT(ID_Masuk) AS TiapTabel FROM TBLBayarMasuk WHERE ID_Masuk LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' UNION ALL SELECT COUNT(ID_Keluar) AS TiapTabel FROM TBLBayarKeluar WHERE ID_Keluar LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%') TBL")
        ElseIf CBTampilLabaRugi.Checked = True Then
            QR("SELECT COUNT(ID_LR) FROM TBLLabaRugi WHERE ID_LR LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%'")
        ElseIf CBTampilFaktur.Checked = True Then
            QR("SELECT SUM(TBL.TiapTabel) FROM (SELECT COUNT(ID_Masuk) AS TiapTabel FROM TBLBayarMasuk WHERE ID_Masuk LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%' UNION ALL SELECT COUNT(ID_Keluar) AS TiapTabel FROM TBLBayarKeluar WHERE ID_Keluar LIKE '%" & TCariData.Text & "%' OR Deskripsi LIKE '%" & TCariData.Text & "%' OR Username LIKE '%" & TCariData.Text & "%') TBL")
        End If
        If DR(0) Mod 13 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 13) + 1 Then DGVPrev.PerformClick()
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(DR(0) / 13) = 0, 1, Math.Ceiling(DR(0) / 13))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(DR(0) / 13) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        If CBTampilLabaRugi.Checked = True And CBTampilFaktur.Checked = True Then
            QDGV("SELECT Tanggal, ID_LR AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Deskripsi, Nominal, Username FROM TBLLabaRugi UNION ALL SELECT Tanggal, ID_Masuk, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM'), Deskripsi, Nominal, Username FROM TBLBayarMasuk UNION ALL SELECT Tanggal, ID_Keluar, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM'), Deskripsi, Nominal, Username FROM TBLBayarKeluar ORDER BY 1 DESC", DGV, FetchData, 13, 0)
        ElseIf CBTampilLabaRugi.Checked = True Then
            QDGV("SELECT Tanggal, ID_LR AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Deskripsi, Nominal, Username FROM TBLLabaRugi ORDER BY 1 DESC", DGV, FetchData, 13, 0)
        ElseIf CBTampilFaktur.Checked = True Then
            QDGV("SELECT Tanggal, ID_Masuk AS Faktur, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM') AS Tanggal, Deskripsi, Nominal, Username FROM TBLBayarMasuk UNION ALL SELECT Tanggal, ID_Keluar, FORMAT(Tanggal, 'dd/MM/yyyy HH:mm AM/PM'), Deskripsi, Nominal, Username FROM TBLBayarKeluar ORDER BY 1 DESC", DGV, FetchData, 13, 0)
        End If
        Paging()
        Timer1.Start()
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
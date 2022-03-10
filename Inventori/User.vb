Public Class User

    Sub Clear()
        TUsername.Clear()
        TPassword.Clear()
        TampilDGV()
        TCariData.Clear()
        TUsername.Focus()
    End Sub

    Sub CariID()
        QR("SELECT Username FROM TBLUser WHERE Username = '" & TUsername.Text & "'")
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TUsername.TextChanged, TPassword.TextChanged
        If TUsername.Text = "" Or TUsername.Text.Equals("Admin", StringComparison.OrdinalIgnoreCase) Or TPassword.Text = "" Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
        CariID()
        If Not DR.HasRows Then
            BTNSimpan.Values.Image = My.Resources.crud_simpan_pressed
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_simpan_common
        Else
            BTNSimpan.Values.Image = My.Resources.crud_edit_pressed
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_edit_common
        End If
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        CariID()
        If Not DR.HasRows Then
            QN("INSERT INTO TBLUser VALUES('" & TUsername.Text & "','" & TPassword.Text & "', 0, 0, 0, 0, 0, 0)")
            Pesan("User berhasil ditambah", 1)
        Else
            QN("UPDATE TBLUser SET [Password] = '" & TPassword.Text & "' WHERE Username = '" & TUsername.Text & "'")
            Pesan("User berhasil diubah", 1)
        End If
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT Username FROM TBLLabaRugi WHERE Username = '" & TUsername.Text & "' UNION ALL SELECT Username FROM TBLBayarMasuk WHERE Username = '" & TUsername.Text & "' UNION ALL SELECT Username FROM TBLBayarKeluar WHERE Username = '" & TUsername.Text & "'")
        If DR.HasRows Then
            Pesan("User pernah terlibat dalam transaksi", 0)
            Exit Sub
        End If
        CariID()
        If Not DR.HasRows Then
            Pesan("Username tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & DR(0) & "?")
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLUser WHERE Username = '" & TUsername.Text & "'")
                Pesan("User berhasil dihapus", 1)
                Clear()
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 1
        CurrentPage = 1
        Clear()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        JumlahData = 0
        FetchData = 1
        CurrentPage = 1
        Baris.Clear()
        QRL("SELECT Username, Barang, Supplier, Customer, Masuk, Keluar, LabaRugi FROM TBLUser WHERE NOT Username = 'admin' AND Username LIKE '%" & TCariData.Text & "%' ORDER BY Username ASC")
        Do While DR.Read
            JumlahData += 1
            Baris.Add({DR(0), DR(1), DR(2), DR(3), DR(4), DR(5), DR(6)})
        Loop
        Paging()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        TPassword.Clear()
        If e.ColumnIndex = 0 Then TUsername.Text = DGV.Rows(e.RowIndex).Cells(0).Value
    End Sub
    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        DGV.CommitEdit(DataGridViewDataErrorContexts.Commit)
        QN("UPDATE TBLUser SET Barang = " & DGV.Rows(e.RowIndex).Cells(1).Value & ", Supplier = " & DGV.Rows(e.RowIndex).Cells(2).Value & ", Customer = " & DGV.Rows(e.RowIndex).Cells(3).Value & ", Masuk = " & DGV.Rows(e.RowIndex).Cells(4).Value & ", Keluar = " & DGV.Rows(e.RowIndex).Cells(5).Value & ", LabaRugi = " & DGV.Rows(e.RowIndex).Cells(6).Value & " WHERE Username = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'")
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
    ReadOnly Baris As New Collection
    Dim JumlahData As Integer

    Dim FetchData As Integer = 1
    Dim CurrentPage As Integer = 1

    Sub Paging()
        DGV.Rows.Clear()
        If JumlahData Mod 14 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(JumlahData / 14) + 1 Then DGVPrev.PerformClick()
        For x = FetchData To FetchData + 13
            DGV.Rows.Add(Baris(x)(0), Baris(x)(1), Baris(x)(2), Baris(x)(3), Baris(x)(4), Baris(x)(5), Baris(x)(6))
            If x = Baris.Count Then Exit For
        Next
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(JumlahData / 14) = 0, 1, Math.Ceiling(JumlahData / 14))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(JumlahData / 14) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        JumlahData = 0
        Baris.Clear()
        QRL("SELECT Username, Barang, Supplier, Customer, Masuk, Keluar, LabaRugi FROM TBLUser WHERE NOT Username = 'Admin' ORDER BY Username ASC")
        Do While DR.Read
            JumlahData += 1
            Baris.Add({DR(0), DR(1), DR(2), DR(3), DR(4), DR(5), DR(6)})
        Loop
        Paging()
    End Sub

    Private Sub DGVPrev_Click(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 14
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNext_Click(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 14
        CurrentPage += 1
        Paging()
    End Sub
#End Region

End Class
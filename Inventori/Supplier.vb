Public Class Supplier

    Sub Notis()
        BTNSimpan.Values.Image = My.Resources.crud_simpan_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_simpan_common
        TID.Text = 1
        Dim x = 0
        QRL("SELECT ID_Supplier FROM TBLSupplier ORDER BY ID_Supplier")
        Do While DR.Read
            x += 1
            If DR.HasRows Then
                If DR(0) = x Then
                    TID.Text = x + 1
                Else
                    TID.Text = x
                    Exit Sub
                End If
            End If
        Loop
    End Sub

    Sub Clear()
        Notis()
        TNama.Clear()
        TAlamat.Clear()
        TTelepon.Clear()
        TEmail.Clear()
        TCariData.Clear()
        TampilDGV()
        TNama.Focus()
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Dim Lebar() As Integer = {102, 223, 417, 143, 209}
        Dim i = 0
        For Each x In DGV.Columns
            x.SortMode = DataGridViewColumnSortMode.NotSortable
            x.Width = Lebar(i)
            i += 1
        Next
        DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TNama.TextChanged
        If TNama.Text = "" Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
    End Sub

#Region "CRUD"
    Sub CariID()
        QR("SELECT * FROM TBLSupplier WHERE ID_Supplier = " & Val(TID.Text))
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        CariID()
        If Not DR.HasRows Then
            QN("INSERT INTO TBLSupplier VALUES(" & Val(TID.Text) & ",'" & TNama.Text & "','" & TAlamat.Text & "','" & TTelepon.Text & "','" & TEmail.Text & "')")
            Pesan("Supplier berhasil ditambah", 1)
        Else
            QN("UPDATE TBLSupplier SET Nama = '" & TNama.Text & "', Alamat = '" & TAlamat.Text & "', Telepon = '" & TTelepon.Text & "', Email = '" & TEmail.Text & "'  WHERE ID_Supplier = " & Val(TID.Text))
            Pesan("Supplier berhasil diubah", 1)
        End If
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT ID_Supplier FROM TBLMasuk WHERE ID_Supplier = " & Val(TID.Text))
        If DR.HasRows Then
            Pesan("Supplier pernah terlibat dalam transaksi", 0)
            Exit Sub
        End If
        CariID()
        If Not DR.HasRows Then
            Pesan("ID Supplier tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & DR(1) & "?")
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLSupplier WHERE ID_Supplier = " & Val(TID.Text))
                Pesan("Supplier berhasil dihapus", 1)
                Clear()
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 0
        CurrentPage = 1
        Clear()
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
#End Region

#Region "DGV"
    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        QR("SELECT COUNT(ID_Supplier) FROM TBLSupplier WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%' OR Email LIKE '%" & TCariData.Text & "%'")
        If DR(0) Mod 12 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 12) + 1 Then DGVPrev.PerformClick()
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(DR(0) / 12) = 0, 1, Math.Ceiling(DR(0) / 12))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(DR(0) / 12) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        QDGV("SELECT ID_Supplier AS [ID Supplier], Nama AS [Nama Supplier], Alamat, Telepon, Email FROM TBLSupplier WHERE Nama LIKE '%" & TCariData.Text & "%' OR Alamat LIKE '%" & TCariData.Text & "%' OR Telepon LIKE '%" & TCariData.Text & "%' OR Email LIKE '%" & TCariData.Text & "%' ORDER BY ID_Supplier ASC", DGV, FetchData, 12, 0)
        Paging()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        TID.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        CariID()
        TNama.Text = DR(1)
        TAlamat.Text = DR(2)
        TTelepon.Text = DR(3)
        TEmail.Text = DR(4)
        BTNSimpan.Values.Image = My.Resources.crud_edit_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_edit_common
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
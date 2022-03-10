Imports System.Data.OleDb, System.Environment
Module Modul
    Public CONN As OleDbConnection
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader
    Public DA As OleDbDataAdapter
    Public DS As DataSet

    Public PPNOtomatis As String
    Public UserAktif As String = Nothing
    Public Path As String = GetFolderPath(SpecialFolder.ApplicationData) & "\Dev"

    Public Sub Koneksi()
        CONN = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Path & "\Dev.accdb;Jet OLEDB:Database Password=zxc123;")
        Try
            CONN.Open()
        Catch ex As Exception
            End
        End Try
    End Sub

    Public Sub QR(QueryReader As String)
        Try
            CMD = New OleDbCommand(QueryReader, CONN)
            DR = CMD.ExecuteReader
            DR.Read()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'Application.Restart()
        End Try
    End Sub

    Public Sub QRL(QueryReaderLooping As String)
        Try
            CMD = New OleDbCommand(QueryReaderLooping, CONN)
            DR = CMD.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'Application.Restart()
        End Try
    End Sub

    Public Sub QN(QueryNonReader As String)
        Try
            CMD = New OleDbCommand(QueryNonReader, CONN)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            'Application.Restart()
        End Try
    End Sub

    Public Sub QDGV(QueryDGV As String, DataGrid As DataGridView, StartRecord As Integer, MaxRecord As Integer, SrcTable As String)
        DA = New OleDbDataAdapter(QueryDGV, CONN)
        DS = New DataSet
        DA.Fill(DS, StartRecord, MaxRecord, SrcTable)
        DataGrid.DataSource = DS.Tables(0)
    End Sub

    Public Sub Pesan(msg As String, type As Notifikasi.AlertTypeEnum)
        Dim f As New Notifikasi
        f.SetAlert(msg, type)
    End Sub

    Public Sub Angka(e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then e.Handled = True
    End Sub

    Public Sub Tanggal_KeyPress(sender As Object, e As KeyPressEventArgs) 'DGV Input Tanggal
        If Not (Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 47 And Asc(e.KeyChar) <= 57)) Then e.Handled = True
    End Sub

    Public Sub Huruf_KeyPress(sender As Object, e As KeyPressEventArgs) 'DGV Input Bebas
        If Asc(e.KeyChar) = 27 Then e.Handled = True
    End Sub

    Public Sub Angka_KeyPress(sender As Object, e As KeyPressEventArgs) 'DGV Input Angka
        Angka(e)
    End Sub

    Sub Ukur(Grid As DataGridView)
        Dim y As Integer = 0
        Dim z As String = Nothing
        For Each x In Grid.Columns
            If x.Visible = False Then Continue For
            z &= x.Width & " - "
            y += x.Width
        Next
        MsgBox(z & " | " & Grid.Width & " - " & y & " = " & Grid.Width - y, MsgBoxStyle.Information, "Harus 18")
    End Sub

End Module
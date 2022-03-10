Public Class Konfirmasi
    Private xJudul As String
    Public Property Judul As String
        Get
            Return xJudul
        End Get
        Set(value As String)
            xJudul = value
            LBLTitle.Text = value
        End Set
    End Property

    Private xDeskripsi As String
    Public Property Deskripsi As String
        Get
            Return xDeskripsi
        End Get
        Set(value As String)
            xDeskripsi = value
            TDeskripsi.Text = value
        End Set
    End Property

    Public Sub New(Judulnya As String, Deskripsinya As String)
        InitializeComponent()
        Judul = Judulnya
        Deskripsi = Deskripsinya
        PBIcon.Image = My.Resources.konfirmasi
    End Sub

    Private Sub BTNYa_Click(sender As Object, e As EventArgs) Handles BTNYa.Click
        DialogResult = vbYes
    End Sub

    Private Sub BTNTidak_Click(sender As Object, e As EventArgs) Handles BTNTidak.Click
        DialogResult = vbNo
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, koentji As Keys) As Boolean
        If koentji = Keys.Enter Then
            BTNYa.PerformClick()
            Return True
        ElseIf koentji = Keys.Escape Then
            BTNTidak.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, koentji)
    End Function
End Class
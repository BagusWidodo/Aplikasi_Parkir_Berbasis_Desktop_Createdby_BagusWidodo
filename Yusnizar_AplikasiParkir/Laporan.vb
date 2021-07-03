Imports System.Data.Odbc
Public Class Laporan

    Private Sub Laporan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call TampilData()
    End Sub

    Public Sub TampilData()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT * FROM parkir_keluar", conn)
        dt = New DataTable
        da.Fill(dt)
        DGV1.DataSource = dt

    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Menu_Utama.Enabled = True
        Me.Hide()
    End Sub
End Class
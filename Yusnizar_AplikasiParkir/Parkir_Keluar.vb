Imports System.Data.Odbc
Public Class Parkir_Keluar

    Private Sub Parkir_Keluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Public Sub PanggilData()
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM parkir_masuk WHERE no_antrian = '" & t_antrian.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            t_nopolisi.Text = dr.Item("no_polisi")
            t_jnskendaraan.Text = dr.Item("jenis_kendaraan")
            t_jammasuk.Text = dr.Item("jam_masuk")
            t_operator.Text = dr.Item("operator")

            If t_jnskendaraan.Text = "Sepeda Motor" Then
                t_tarif.Text = 2000
            Else
                t_tarif.Text = 7000
            End If

        End If
    End Sub

    Public Sub Clear()
        t_antrian.Text = ""
        t_nopolisi.Text = ""
        t_jnskendaraan.Text = ""
        t_jammasuk.Text = ""
        t_lamaparkir.Text = ""
        t_tarif.Text = ""
        t_biaya.Text = ""
        t_operator.Text = ""
        t_antrian.Focus()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        t_tanggal.Text = Format(Now, "yyyy/MM/dd")
        t_jamkeluar.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub t_antrian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_antrian.TextChanged
        Call PanggilData()
    End Sub

    Private Sub btn_proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_proses.Click
        Dim detik, menit, jam, second, biaya As Integer
        detik = DateDiff(DateInterval.Second, CDate(t_jammasuk.Text), CDate(t_jamkeluar.Text))
        menit = DateDiff(DateInterval.Minute, CDate(t_jammasuk.Text), CDate(t_jamkeluar.Text))
        jam = DateDiff(DateInterval.Hour, CDate(t_jammasuk.Text), CDate(t_jamkeluar.Text))

        menit = (detik Mod 3600) / 60
        second = (detik Mod 3600) Mod 60
        t_lamaparkir.Text = jam & ":" & menit & ":" & second

        biaya = FormatNumber((jam / 3), 0)
        t_biaya.Text = biaya * 2000
        If jam < 3 Then
            t_biaya.Text = 2000
        End If

    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Call Koneksi()
        Try
            Dim Pilihan As String
            Pilihan = MessageBox.Show("Apakah Data Ingin Disimpan?", "PARKIR KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Pilihan = vbYes Then
                Dim Simpan As String
                Simpan = "INSERT INTO parkir_keluar (no_antrian, no_polisi, jenis_kendaraan, jam_masuk, jam_keluar, lama_parkir, tarif_3jam, biaya_parkir, tanggal, operator) VALUES ('" & t_antrian.Text & "','" & t_nopolisi.Text & "','" & t_jnskendaraan.Text & "','" & t_jammasuk.Text & "','" & t_jamkeluar.Text & "','" & t_lamaparkir.Text & "','" & t_tarif.Text & "','" & t_biaya.Text & "','" & t_tanggal.Text & "','" & t_operator.Text & "')"
                Dim dc As New OdbcCommand(Simpan, conn)
                dc.ExecuteNonQuery()
                MessageBox.Show("Data Telah Disimpan", "PARKIR KELUAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Clear()
            End If
        Catch ex As Exception
            MsgBox("Data tidak dapat disimpan." & Environment.NewLine & "Karena berdasarkan No. Antrian, kendaraan telah keluar dari area parkir. ", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        Call Clear()
    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Menu_Utama.Enabled = True
        Me.Hide()
    End Sub

End Class
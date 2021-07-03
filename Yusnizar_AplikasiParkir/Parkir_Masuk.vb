Imports System.Data.Odbc
Public Class Parkir_Masuk

    Private Sub Parkir_Masuk_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call TampilData()
    End Sub

    Private Sub Parkir_Masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Call NoAntrian()
    End Sub

    Public Sub NoAntrian()
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM parkir_masuk ORDER BY no_antrian DESC LIMIT 1", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            t_antrian.Text = "00001"
        Else
            t_antrian.Text = Val(Microsoft.VisualBasic.Mid(dr.Item("no_antrian").ToString, 5, 3)) + 1

            If Len(t_antrian.Text) = 1 Then
                t_antrian.Text = "0000" & t_antrian.Text & ""
            ElseIf Len(t_antrian.Text) = 2 Then
                t_antrian.Text = "000" & t_antrian.Text & ""
            ElseIf Len(t_antrian.Text) = 3 Then
                t_antrian.Text = "00" & t_antrian.Text & ""
            End If
        End If
    End Sub

    Public Sub TampilData()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT * FROM parkir_masuk", conn)
        dt = New DataTable
        da.Fill(dt)
        DGV1.DataSource = dt
    End Sub

    Public Sub Clear()
        t_nopolisi.Text = ""
        cb_jnskendaraan.Text = ""
        t_jammasuk.Text = ""
        t_tarif.Text = ""
        t_operator.Text = ""
        t_tanggal.Text = ""
        t_nopolisi.Focus()
    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Menu_Utama.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        t_tanggal.Text = Format(Now, "yyyy/MM/dd")
        t_jammasuk.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub btn_proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cb_jnskendaraan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_jnskendaraan.SelectedIndexChanged
        If cb_jnskendaraan.Text = "Sepeda Motor" Then
            t_tarif.Text = 2000
        Else
            t_tarif.Text = 7000
        End If
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Call Koneksi()
        Try
            Dim Pilihan As String
            Pilihan = MessageBox.Show("Apakah Ingin Menyimpan Data?", "PARKIR MASUK", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Pilihan = vbYes Then
                Dim Simpan As String
                Simpan = "INSERT INTO parkir_masuk (no_antrian, no_polisi, jenis_kendaraan, jam_masuk, operator, tanggal) VALUES ('" & t_antrian.Text & "','" & t_nopolisi.Text & "','" & cb_jnskendaraan.Text & "','" & t_jammasuk.Text & "','" & t_operator.Text & "','" & t_tanggal.Text & "')"
                Dim dc As New OdbcCommand(Simpan, conn)
                dc.ExecuteNonQuery()
                MessageBox.Show("Data Telah Disimpan", "PARKIR MASUK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Clear()
                Call NoAntrian()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        Call Clear()
    End Sub

End Class
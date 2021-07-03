Imports System.Data.Odbc
Public Class Admin

    Private Sub Admin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call TampilData()
    End Sub

    Public Sub TampilData()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT * FROM admin", conn)
        dt = New DataTable
        da.Fill(dt)
        DGV1.DataSource = dt
    End Sub

    Public Sub PanggilData()
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM admin WHERE username = '" & t_username.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            t_nama.Text = dr.Item("nama_user")
            t_password.Text = dr.Item("password")
        End If
    End Sub

    Public Sub Clear()
        t_username.Text = ""
        t_nama.Text = ""
        t_password.Text = ""
        t_username.Focus()
    End Sub

    Private Sub t_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_username.TextChanged
        Call PanggilData()
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Call Koneksi()
        Try
            Dim Pilihan As String
            Pilihan = MessageBox.Show("Yakin Ingin Mengedit Data?", "FORM ADMIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Pilihan = vbYes Then
                Dim Edit As String
                Edit = "UPDATE admin SET nama_user = '" & t_nama.Text & "', password = '" & t_password.Text & "' WHERE username = '" & t_username.Text & "' "
                Dim dc As New OdbcCommand(Edit, conn)
                dc.ExecuteNonQuery()
                MessageBox.Show("Data Telah Diedit", "FORM ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Call Koneksi()
        Try
            Dim Pilihan As String
            Pilihan = MessageBox.Show("Yakin Ingin Menyimpan Data?", "FORM ADMIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Pilihan = vbYes Then
                Dim Simpan As String
                Simpan = "INSERT INTO admin (username, nama_user, password) VALUES ('" & t_username.Text & "','" & t_nama.Text & "','" & t_password.Text & "')"
                Dim dc As New OdbcCommand(Simpan, conn)
                dc.ExecuteNonQuery()
                MessageBox.Show("Data Telah Disimpan", "FORM ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Call Koneksi()
        Try
            Dim Pilihan As String
            Pilihan = MessageBox.Show("Yakin Ingin Menghapus Data?", "FORM ADMIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Pilihan = vbYes Then
                Dim Hapus As String
                Hapus = "DELETE FROM admin WHERE username = '" & t_username.Text & "' "
                Dim dc As New OdbcCommand(Hapus, conn)
                dc.ExecuteNonQuery()
                MessageBox.Show("Data Telah Dihapus", "FORM ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Menu_Utama.Enabled = True
        Me.Hide()
    End Sub
End Class
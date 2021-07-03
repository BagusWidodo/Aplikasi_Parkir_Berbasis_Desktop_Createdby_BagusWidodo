Imports System.Data.Odbc
Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menu_Utama.Show()
        Menu_Utama.Enabled = False
    End Sub

    Private Sub btn_masuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_masuk.Click
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM admin WHERE username = '" & t_username.Text & "' AND password = '" & t_pass.Text & "' ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MessageBox.Show("Username & Password Salah!!!", "FORM LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Start()
            Menu_Utama.Enabled = True
            Me.Hide()
        End If
    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Dim Keluar As String
        Keluar = MessageBox.Show("Keluar Dari Aplikasi?", "FORM LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If Keluar = vbOK Then
            End
        End If
    End Sub

End Class

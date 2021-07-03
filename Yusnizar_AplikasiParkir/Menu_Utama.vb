Public Class Menu_Utama

    Private Sub DATAADMINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAADMINToolStripMenuItem.Click
        Admin.Show()
        Me.Enabled = False
    End Sub

    Private Sub PARKIRMASUKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARKIRMASUKToolStripMenuItem.Click
        Parkir_Masuk.Show()
        Me.Enabled = False

    End Sub

    Private Sub PARKIRKELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARKIRKELUARToolStripMenuItem.Click
        Parkir_Keluar.Show()
        Me.Enabled = False
    End Sub

    Private Sub LAPORANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAPORANToolStripMenuItem.Click
        Laporan.Show()
        Me.Enabled = False
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        End
    End Sub
End Class
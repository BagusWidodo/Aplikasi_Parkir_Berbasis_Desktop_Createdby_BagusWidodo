<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DATAADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARKIRMASUKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARKIRKELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAADMINToolStripMenuItem, Me.PARKIRMASUKToolStripMenuItem, Me.PARKIRKELUARToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(672, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DATAADMINToolStripMenuItem
        '
        Me.DATAADMINToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATAADMINToolStripMenuItem.Name = "DATAADMINToolStripMenuItem"
        Me.DATAADMINToolStripMenuItem.Size = New System.Drawing.Size(114, 23)
        Me.DATAADMINToolStripMenuItem.Text = "DATA ADMIN"
        '
        'PARKIRMASUKToolStripMenuItem
        '
        Me.PARKIRMASUKToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PARKIRMASUKToolStripMenuItem.Name = "PARKIRMASUKToolStripMenuItem"
        Me.PARKIRMASUKToolStripMenuItem.Size = New System.Drawing.Size(137, 23)
        Me.PARKIRMASUKToolStripMenuItem.Text = "PARKIR MASUK"
        '
        'PARKIRKELUARToolStripMenuItem
        '
        Me.PARKIRKELUARToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PARKIRKELUARToolStripMenuItem.Name = "PARKIRKELUARToolStripMenuItem"
        Me.PARKIRKELUARToolStripMenuItem.Size = New System.Drawing.Size(143, 23)
        Me.PARKIRKELUARToolStripMenuItem.Text = "PARKIR KELUAR"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(93, 23)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(83, 23)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 410)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU UTAMA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DATAADMINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PARKIRMASUKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PARKIRKELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

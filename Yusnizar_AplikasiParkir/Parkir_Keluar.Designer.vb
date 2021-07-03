<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parkir_Keluar
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.t_jnskendaraan = New System.Windows.Forms.TextBox()
        Me.t_tanggal = New System.Windows.Forms.TextBox()
        Me.t_nopolisi = New System.Windows.Forms.TextBox()
        Me.t_jammasuk = New System.Windows.Forms.TextBox()
        Me.t_jamkeluar = New System.Windows.Forms.TextBox()
        Me.t_operator = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.t_antrian = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.t_lamaparkir = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.t_tarif = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.t_biaya = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_keluar
        '
        Me.btn_keluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_keluar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(304, 273)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 31)
        Me.btn_keluar.TabIndex = 23
        Me.btn_keluar.Text = "KELUAR"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_batal.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.Location = New System.Drawing.Point(211, 273)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 31)
        Me.btn_batal.TabIndex = 22
        Me.btn_batal.Text = "BATAL"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(116, 273)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 31)
        Me.btn_simpan.TabIndex = 25
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_proses
        '
        Me.btn_proses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_proses.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proses.Location = New System.Drawing.Point(22, 273)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(75, 31)
        Me.btn_proses.TabIndex = 24
        Me.btn_proses.Text = "PROSES"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        't_jnskendaraan
        '
        Me.t_jnskendaraan.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_jnskendaraan.Location = New System.Drawing.Point(179, 109)
        Me.t_jnskendaraan.Name = "t_jnskendaraan"
        Me.t_jnskendaraan.Size = New System.Drawing.Size(156, 23)
        Me.t_jnskendaraan.TabIndex = 19
        '
        't_tanggal
        '
        Me.t_tanggal.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_tanggal.Location = New System.Drawing.Point(179, 15)
        Me.t_tanggal.Name = "t_tanggal"
        Me.t_tanggal.Size = New System.Drawing.Size(156, 23)
        Me.t_tanggal.TabIndex = 20
        '
        't_nopolisi
        '
        Me.t_nopolisi.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_nopolisi.Location = New System.Drawing.Point(201, 149)
        Me.t_nopolisi.Name = "t_nopolisi"
        Me.t_nopolisi.Size = New System.Drawing.Size(156, 23)
        Me.t_nopolisi.TabIndex = 18
        '
        't_jammasuk
        '
        Me.t_jammasuk.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_jammasuk.Location = New System.Drawing.Point(201, 213)
        Me.t_jammasuk.Name = "t_jammasuk"
        Me.t_jammasuk.Size = New System.Drawing.Size(156, 23)
        Me.t_jammasuk.TabIndex = 16
        '
        't_jamkeluar
        '
        Me.t_jamkeluar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_jamkeluar.Location = New System.Drawing.Point(141, 15)
        Me.t_jamkeluar.Name = "t_jamkeluar"
        Me.t_jamkeluar.Size = New System.Drawing.Size(156, 23)
        Me.t_jamkeluar.TabIndex = 15
        '
        't_operator
        '
        Me.t_operator.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_operator.Location = New System.Drawing.Point(141, 141)
        Me.t_operator.Name = "t_operator"
        Me.t_operator.Size = New System.Drawing.Size(156, 23)
        Me.t_operator.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "OPERATOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "JAM KELUAR"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(631, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PARKIR KELUAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "JAM MASUK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "JENIS KENDARAAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "NO. POLISI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "NO. ANTRIAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TANGGAL"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 57)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.t_jnskendaraan)
        Me.GroupBox1.Controls.Add(Me.t_antrian)
        Me.GroupBox1.Controls.Add(Me.t_tanggal)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 186)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        't_antrian
        '
        Me.t_antrian.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_antrian.Location = New System.Drawing.Point(179, 46)
        Me.t_antrian.Name = "t_antrian"
        Me.t_antrian.Size = New System.Drawing.Size(156, 23)
        Me.t_antrian.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.t_lamaparkir)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.t_tarif)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.t_biaya)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.t_operator)
        Me.GroupBox2.Controls.Add(Me.t_jamkeluar)
        Me.GroupBox2.Location = New System.Drawing.Point(391, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 186)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "LAMA PARKIR"
        '
        't_lamaparkir
        '
        Me.t_lamaparkir.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_lamaparkir.Location = New System.Drawing.Point(141, 46)
        Me.t_lamaparkir.Name = "t_lamaparkir"
        Me.t_lamaparkir.Size = New System.Drawing.Size(156, 23)
        Me.t_lamaparkir.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "TARIF / 3 JAM"
        '
        't_tarif
        '
        Me.t_tarif.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_tarif.Location = New System.Drawing.Point(141, 77)
        Me.t_tarif.Name = "t_tarif"
        Me.t_tarif.Size = New System.Drawing.Size(156, 23)
        Me.t_tarif.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TOTAL BIAYA"
        '
        't_biaya
        '
        Me.t_biaya.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_biaya.Location = New System.Drawing.Point(141, 109)
        Me.t_biaya.Name = "t_biaya"
        Me.t_biaya.Size = New System.Drawing.Size(156, 23)
        Me.t_biaya.TabIndex = 14
        '
        'Timer1
        '
        '
        'Parkir_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 327)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.t_nopolisi)
        Me.Controls.Add(Me.t_jammasuk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Parkir_Keluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PARKIR KELUAR"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_proses As System.Windows.Forms.Button
    Friend WithEvents t_jnskendaraan As System.Windows.Forms.TextBox
    Friend WithEvents t_tanggal As System.Windows.Forms.TextBox
    Friend WithEvents t_nopolisi As System.Windows.Forms.TextBox
    Friend WithEvents t_jammasuk As System.Windows.Forms.TextBox
    Friend WithEvents t_jamkeluar As System.Windows.Forms.TextBox
    Friend WithEvents t_operator As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents t_lamaparkir As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents t_tarif As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents t_biaya As System.Windows.Forms.TextBox
    Friend WithEvents t_antrian As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

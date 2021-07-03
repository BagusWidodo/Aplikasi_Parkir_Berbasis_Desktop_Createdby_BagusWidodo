<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parkir_Masuk
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.t_operator = New System.Windows.Forms.TextBox()
        Me.t_tarif = New System.Windows.Forms.TextBox()
        Me.t_jammasuk = New System.Windows.Forms.TextBox()
        Me.cb_jnskendaraan = New System.Windows.Forms.ComboBox()
        Me.t_nopolisi = New System.Windows.Forms.TextBox()
        Me.t_antrian = New System.Windows.Forms.TextBox()
        Me.t_tanggal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(772, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PARKIR MASUK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TANGGAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "NO. ANTRIAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "NO. POLISI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "JENIS KENDARAAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "JAM MASUK"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TARIF / 3 JAM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "OPERATOR"
        '
        't_operator
        '
        Me.t_operator.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_operator.Location = New System.Drawing.Point(201, 277)
        Me.t_operator.Name = "t_operator"
        Me.t_operator.Size = New System.Drawing.Size(156, 23)
        Me.t_operator.TabIndex = 1
        '
        't_tarif
        '
        Me.t_tarif.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_tarif.Location = New System.Drawing.Point(201, 246)
        Me.t_tarif.Name = "t_tarif"
        Me.t_tarif.Size = New System.Drawing.Size(156, 23)
        Me.t_tarif.TabIndex = 1
        '
        't_jammasuk
        '
        Me.t_jammasuk.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_jammasuk.Location = New System.Drawing.Point(201, 215)
        Me.t_jammasuk.Name = "t_jammasuk"
        Me.t_jammasuk.Size = New System.Drawing.Size(156, 23)
        Me.t_jammasuk.TabIndex = 1
        '
        'cb_jnskendaraan
        '
        Me.cb_jnskendaraan.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jnskendaraan.FormattingEnabled = True
        Me.cb_jnskendaraan.Items.AddRange(New Object() {"Sepeda Motor", "Mobil"})
        Me.cb_jnskendaraan.Location = New System.Drawing.Point(201, 183)
        Me.cb_jnskendaraan.Name = "cb_jnskendaraan"
        Me.cb_jnskendaraan.Size = New System.Drawing.Size(156, 23)
        Me.cb_jnskendaraan.TabIndex = 2
        '
        't_nopolisi
        '
        Me.t_nopolisi.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_nopolisi.Location = New System.Drawing.Point(201, 151)
        Me.t_nopolisi.Name = "t_nopolisi"
        Me.t_nopolisi.Size = New System.Drawing.Size(156, 23)
        Me.t_nopolisi.TabIndex = 3
        '
        't_antrian
        '
        Me.t_antrian.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_antrian.Location = New System.Drawing.Point(201, 120)
        Me.t_antrian.Name = "t_antrian"
        Me.t_antrian.Size = New System.Drawing.Size(156, 23)
        Me.t_antrian.TabIndex = 3
        '
        't_tanggal
        '
        Me.t_tanggal.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_tanggal.Location = New System.Drawing.Point(201, 89)
        Me.t_tanggal.Name = "t_tanggal"
        Me.t_tanggal.Size = New System.Drawing.Size(156, 23)
        Me.t_tanggal.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(22, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 248)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(23, 332)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(108, 31)
        Me.btn_simpan.TabIndex = 5
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.Location = New System.Drawing.Point(147, 332)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(108, 31)
        Me.btn_batal.TabIndex = 5
        Me.btn_batal.Text = "BATAL"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(271, 332)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(108, 31)
        Me.btn_keluar.TabIndex = 5
        Me.btn_keluar.Text = "KELUAR"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(398, 78)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(393, 285)
        Me.DGV1.TabIndex = 6
        '
        'Parkir_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 384)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.t_tanggal)
        Me.Controls.Add(Me.t_antrian)
        Me.Controls.Add(Me.t_nopolisi)
        Me.Controls.Add(Me.cb_jnskendaraan)
        Me.Controls.Add(Me.t_jammasuk)
        Me.Controls.Add(Me.t_tarif)
        Me.Controls.Add(Me.t_operator)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Parkir_Masuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PARKIR MASUK"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents t_operator As System.Windows.Forms.TextBox
    Friend WithEvents t_tarif As System.Windows.Forms.TextBox
    Friend WithEvents t_jammasuk As System.Windows.Forms.TextBox
    Friend WithEvents cb_jnskendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents t_nopolisi As System.Windows.Forms.TextBox
    Friend WithEvents t_antrian As System.Windows.Forms.TextBox
    Friend WithEvents t_tanggal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
End Class

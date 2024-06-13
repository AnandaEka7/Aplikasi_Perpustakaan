<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Peminjaman
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_bataspinjam = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_totalpinjam = New System.Windows.Forms.TextBox()
        Me.txt_pinjamsekarang = New System.Windows.Forms.TextBox()
        Me.txt_pernahminjam = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_idanggota = New System.Windows.Forms.TextBox()
        Me.txt_tanggal = New System.Windows.Forms.TextBox()
        Me.txt_idpinjam = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.txt_tahun = New System.Windows.Forms.TextBox()
        Me.txt_kategori = New System.Windows.Forms.TextBox()
        Me.txt_penerbit = New System.Windows.Forms.TextBox()
        Me.txt_judul = New System.Windows.Forms.TextBox()
        Me.txt_pengarang = New System.Windows.Forms.TextBox()
        Me.txt_idbuku = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1832, 104)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(109, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Peminjaman Buku"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.AplikasiPperpus.My.Resources.Resources.write
        Me.PictureBox1.Location = New System.Drawing.Point(3, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_bataspinjam)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_totalpinjam)
        Me.GroupBox2.Controls.Add(Me.txt_pinjamsekarang)
        Me.GroupBox2.Controls.Add(Me.txt_pernahminjam)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_nama)
        Me.GroupBox2.Controls.Add(Me.txt_idanggota)
        Me.GroupBox2.Controls.Add(Me.txt_tanggal)
        Me.GroupBox2.Controls.Add(Me.txt_idpinjam)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1832, 123)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi Peminjaman"
        '
        'txt_bataspinjam
        '
        Me.txt_bataspinjam.Location = New System.Drawing.Point(1268, 71)
        Me.txt_bataspinjam.Multiline = True
        Me.txt_bataspinjam.Name = "txt_bataspinjam"
        Me.txt_bataspinjam.Size = New System.Drawing.Size(248, 26)
        Me.txt_bataspinjam.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1123, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Batas peminjaman " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_totalpinjam
        '
        Me.txt_totalpinjam.Location = New System.Drawing.Point(1268, 39)
        Me.txt_totalpinjam.Multiline = True
        Me.txt_totalpinjam.Name = "txt_totalpinjam"
        Me.txt_totalpinjam.Size = New System.Drawing.Size(248, 26)
        Me.txt_totalpinjam.TabIndex = 30
        '
        'txt_pinjamsekarang
        '
        Me.txt_pinjamsekarang.Location = New System.Drawing.Point(841, 65)
        Me.txt_pinjamsekarang.Multiline = True
        Me.txt_pinjamsekarang.Name = "txt_pinjamsekarang"
        Me.txt_pinjamsekarang.Size = New System.Drawing.Size(248, 26)
        Me.txt_pinjamsekarang.TabIndex = 29
        '
        'txt_pernahminjam
        '
        Me.txt_pernahminjam.Location = New System.Drawing.Point(841, 36)
        Me.txt_pernahminjam.Multiline = True
        Me.txt_pernahminjam.Name = "txt_pernahminjam"
        Me.txt_pernahminjam.Size = New System.Drawing.Size(248, 26)
        Me.txt_pernahminjam.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1123, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Total"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(498, 71)
        Me.txt_nama.Multiline = True
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(248, 26)
        Me.txt_nama.TabIndex = 26
        '
        'txt_idanggota
        '
        Me.txt_idanggota.Location = New System.Drawing.Point(498, 39)
        Me.txt_idanggota.Multiline = True
        Me.txt_idanggota.Name = "txt_idanggota"
        Me.txt_idanggota.Size = New System.Drawing.Size(248, 26)
        Me.txt_idanggota.TabIndex = 25
        '
        'txt_tanggal
        '
        Me.txt_tanggal.Location = New System.Drawing.Point(116, 71)
        Me.txt_tanggal.Multiline = True
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(248, 26)
        Me.txt_tanggal.TabIndex = 24
        '
        'txt_idpinjam
        '
        Me.txt_idpinjam.Location = New System.Drawing.Point(116, 42)
        Me.txt_idpinjam.Multiline = True
        Me.txt_idpinjam.Name = "txt_idpinjam"
        Me.txt_idpinjam.Size = New System.Drawing.Size(248, 26)
        Me.txt_idpinjam.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(774, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Pernah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(774, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Anggota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Pinjam"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_jumlah)
        Me.GroupBox3.Controls.Add(Me.txt_tahun)
        Me.GroupBox3.Controls.Add(Me.txt_kategori)
        Me.GroupBox3.Controls.Add(Me.txt_penerbit)
        Me.GroupBox3.Controls.Add(Me.txt_judul)
        Me.GroupBox3.Controls.Add(Me.txt_pengarang)
        Me.GroupBox3.Controls.Add(Me.txt_idbuku)
        Me.GroupBox3.Controls.Add(Me.dgv1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1832, 294)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input Transaksi"
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(1662, 24)
        Me.txt_jumlah.Multiline = True
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(142, 26)
        Me.txt_jumlah.TabIndex = 30
        '
        'txt_tahun
        '
        Me.txt_tahun.Location = New System.Drawing.Point(1531, 24)
        Me.txt_tahun.Multiline = True
        Me.txt_tahun.Name = "txt_tahun"
        Me.txt_tahun.Size = New System.Drawing.Size(137, 26)
        Me.txt_tahun.TabIndex = 29
        '
        'txt_kategori
        '
        Me.txt_kategori.Location = New System.Drawing.Point(1268, 24)
        Me.txt_kategori.Multiline = True
        Me.txt_kategori.Name = "txt_kategori"
        Me.txt_kategori.Size = New System.Drawing.Size(266, 26)
        Me.txt_kategori.TabIndex = 28
        '
        'txt_penerbit
        '
        Me.txt_penerbit.Location = New System.Drawing.Point(997, 24)
        Me.txt_penerbit.Multiline = True
        Me.txt_penerbit.Name = "txt_penerbit"
        Me.txt_penerbit.Size = New System.Drawing.Size(276, 26)
        Me.txt_penerbit.TabIndex = 27
        '
        'txt_judul
        '
        Me.txt_judul.Location = New System.Drawing.Point(265, 24)
        Me.txt_judul.Multiline = True
        Me.txt_judul.Name = "txt_judul"
        Me.txt_judul.Size = New System.Drawing.Size(470, 26)
        Me.txt_judul.TabIndex = 26
        '
        'txt_pengarang
        '
        Me.txt_pengarang.Location = New System.Drawing.Point(732, 24)
        Me.txt_pengarang.Multiline = True
        Me.txt_pengarang.Name = "txt_pengarang"
        Me.txt_pengarang.Size = New System.Drawing.Size(269, 26)
        Me.txt_pengarang.TabIndex = 25
        '
        'txt_idbuku
        '
        Me.txt_idbuku.Location = New System.Drawing.Point(67, 24)
        Me.txt_idbuku.Multiline = True
        Me.txt_idbuku.Name = "txt_idbuku"
        Me.txt_idbuku.Size = New System.Drawing.Size(204, 26)
        Me.txt_idbuku.TabIndex = 24
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv1.Location = New System.Drawing.Point(12, 56)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(1899, 167)
        Me.dgv1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Buku"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Judul"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 350
        '
        'Column3
        '
        Me.Column3.HeaderText = "Pengarang"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Penerbit"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "kategori"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "tahun"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "jumlah"
        Me.Column7.Name = "Column7"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 521)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1832, 81)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proses"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(229, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 40)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(119, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 40)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(9, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 40)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgv2)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(0, 602)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1832, 204)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sedang Dipinjam"
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(12, 24)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.RowTemplate.Height = 24
        Me.dgv2.Size = New System.Drawing.Size(1773, 163)
        Me.dgv2.TabIndex = 0
        '
        'Form_Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1832, 899)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Peminjaman"
        Me.Text = "Form_Peminjaman"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_totalpinjam As System.Windows.Forms.TextBox
    Friend WithEvents txt_pinjamsekarang As System.Windows.Forms.TextBox
    Friend WithEvents txt_pernahminjam As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_idanggota As System.Windows.Forms.TextBox
    Friend WithEvents txt_tanggal As System.Windows.Forms.TextBox
    Friend WithEvents txt_idpinjam As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_tahun As System.Windows.Forms.TextBox
    Friend WithEvents txt_kategori As System.Windows.Forms.TextBox
    Friend WithEvents txt_penerbit As System.Windows.Forms.TextBox
    Friend WithEvents txt_judul As System.Windows.Forms.TextBox
    Friend WithEvents txt_pengarang As System.Windows.Forms.TextBox
    Friend WithEvents txt_idbuku As System.Windows.Forms.TextBox
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents txt_bataspinjam As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class

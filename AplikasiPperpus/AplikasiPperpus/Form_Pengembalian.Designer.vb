<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pengembalian
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
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_idanggota = New System.Windows.Forms.TextBox()
        Me.txt_tanggal = New System.Windows.Forms.TextBox()
        Me.txt_idkembali = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_terlambat = New System.Windows.Forms.TextBox()
        Me.txt_lamapinjam = New System.Windows.Forms.TextBox()
        Me.txt_idpinjam = New System.Windows.Forms.TextBox()
        Me.txt_tglpinjam = New System.Windows.Forms.TextBox()
        Me.txt_idbuku = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_judul = New System.Windows.Forms.TextBox()
        Me.txt_denda = New System.Windows.Forms.TextBox()
        Me.cb_rusak = New System.Windows.Forms.ComboBox()
        Me.cb_hilang = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_totaldenda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dibayar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Size = New System.Drawing.Size(1924, 104)
        Me.GroupBox1.TabIndex = 4
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
        Me.Label1.Text = "Pengembalian Buku"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.AplikasiPperpus.My.Resources.Resources.buku
        Me.PictureBox1.Location = New System.Drawing.Point(3, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_nama)
        Me.GroupBox2.Controls.Add(Me.txt_idanggota)
        Me.GroupBox2.Controls.Add(Me.txt_tanggal)
        Me.GroupBox2.Controls.Add(Me.txt_idkembali)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1924, 123)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi Peminjaman"
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
        Me.txt_tanggal.Location = New System.Drawing.Point(126, 71)
        Me.txt_tanggal.Multiline = True
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(248, 26)
        Me.txt_tanggal.TabIndex = 24
        '
        'txt_idkembali
        '
        Me.txt_idkembali.Location = New System.Drawing.Point(126, 42)
        Me.txt_idkembali.Multiline = True
        Me.txt_idkembali.Name = "txt_idkembali"
        Me.txt_idkembali.Size = New System.Drawing.Size(248, 26)
        Me.txt_idkembali.TabIndex = 23
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
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Kembali"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_dibayar)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_totaldenda)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cb_hilang)
        Me.GroupBox3.Controls.Add(Me.cb_rusak)
        Me.GroupBox3.Controls.Add(Me.txt_denda)
        Me.GroupBox3.Controls.Add(Me.txt_terlambat)
        Me.GroupBox3.Controls.Add(Me.txt_lamapinjam)
        Me.GroupBox3.Controls.Add(Me.txt_idpinjam)
        Me.GroupBox3.Controls.Add(Me.txt_judul)
        Me.GroupBox3.Controls.Add(Me.txt_tglpinjam)
        Me.GroupBox3.Controls.Add(Me.txt_idbuku)
        Me.GroupBox3.Controls.Add(Me.dgv1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1924, 493)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input Transaksi"
        '
        'txt_terlambat
        '
        Me.txt_terlambat.Location = New System.Drawing.Point(1330, 24)
        Me.txt_terlambat.Multiline = True
        Me.txt_terlambat.Name = "txt_terlambat"
        Me.txt_terlambat.Size = New System.Drawing.Size(142, 26)
        Me.txt_terlambat.TabIndex = 29
        '
        'txt_lamapinjam
        '
        Me.txt_lamapinjam.Location = New System.Drawing.Point(1067, 24)
        Me.txt_lamapinjam.Multiline = True
        Me.txt_lamapinjam.Name = "txt_lamapinjam"
        Me.txt_lamapinjam.Size = New System.Drawing.Size(271, 26)
        Me.txt_lamapinjam.TabIndex = 28
        '
        'txt_idpinjam
        '
        Me.txt_idpinjam.Location = New System.Drawing.Point(796, 24)
        Me.txt_idpinjam.Multiline = True
        Me.txt_idpinjam.Name = "txt_idpinjam"
        Me.txt_idpinjam.Size = New System.Drawing.Size(280, 26)
        Me.txt_idpinjam.TabIndex = 27
        '
        'txt_tglpinjam
        '
        Me.txt_tglpinjam.Location = New System.Drawing.Point(531, 24)
        Me.txt_tglpinjam.Multiline = True
        Me.txt_tglpinjam.Name = "txt_tglpinjam"
        Me.txt_tglpinjam.Size = New System.Drawing.Size(269, 26)
        Me.txt_tglpinjam.TabIndex = 25
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
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgv1.Location = New System.Drawing.Point(12, 56)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.Size = New System.Drawing.Size(1957, 241)
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
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tanggal Pinjam"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "ID Pinjam"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Lama Pinjam"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "Terlambat"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Rusak"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Hilang"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Denda"
        Me.Column9.Name = "Column9"
        '
        'txt_judul
        '
        Me.txt_judul.Location = New System.Drawing.Point(265, 24)
        Me.txt_judul.Multiline = True
        Me.txt_judul.Name = "txt_judul"
        Me.txt_judul.Size = New System.Drawing.Size(268, 26)
        Me.txt_judul.TabIndex = 26
        '
        'txt_denda
        '
        Me.txt_denda.Location = New System.Drawing.Point(1734, 24)
        Me.txt_denda.Multiline = True
        Me.txt_denda.Name = "txt_denda"
        Me.txt_denda.Size = New System.Drawing.Size(131, 26)
        Me.txt_denda.TabIndex = 32
        '
        'cb_rusak
        '
        Me.cb_rusak.FormattingEnabled = True
        Me.cb_rusak.Items.AddRange(New Object() {"Ya ", "Tidak"})
        Me.cb_rusak.Location = New System.Drawing.Point(1469, 24)
        Me.cb_rusak.Name = "cb_rusak"
        Me.cb_rusak.Size = New System.Drawing.Size(131, 25)
        Me.cb_rusak.TabIndex = 27
        '
        'cb_hilang
        '
        Me.cb_hilang.FormattingEnabled = True
        Me.cb_hilang.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.cb_hilang.Location = New System.Drawing.Point(1598, 24)
        Me.cb_hilang.Name = "cb_hilang"
        Me.cb_hilang.Size = New System.Drawing.Size(140, 25)
        Me.cb_hilang.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(1871, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_totaldenda
        '
        Me.txt_totaldenda.Location = New System.Drawing.Point(1617, 330)
        Me.txt_totaldenda.Multiline = True
        Me.txt_totaldenda.Name = "txt_totaldenda"
        Me.txt_totaldenda.Size = New System.Drawing.Size(248, 41)
        Me.txt_totaldenda.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1432, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 29)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Total Denda"
        '
        'txt_dibayar
        '
        Me.txt_dibayar.Location = New System.Drawing.Point(1617, 377)
        Me.txt_dibayar.Multiline = True
        Me.txt_dibayar.Name = "txt_dibayar"
        Me.txt_dibayar.Size = New System.Drawing.Size(248, 42)
        Me.txt_dibayar.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1486, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 29)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Dibayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1451, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 29)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Kembalian"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1617, 425)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(248, 42)
        Me.TextBox3.TabIndex = 39
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Maroon
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(25, 332)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 50)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(245, 332)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 50)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(135, 332)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 50)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form_Pengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 745)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Pengembalian"
        Me.Text = "Form_Pengembalian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_idanggota As System.Windows.Forms.TextBox
    Friend WithEvents txt_tanggal As System.Windows.Forms.TextBox
    Friend WithEvents txt_idkembali As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_terlambat As System.Windows.Forms.TextBox
    Friend WithEvents txt_lamapinjam As System.Windows.Forms.TextBox
    Friend WithEvents txt_idpinjam As System.Windows.Forms.TextBox
    Friend WithEvents txt_tglpinjam As System.Windows.Forms.TextBox
    Friend WithEvents txt_idbuku As System.Windows.Forms.TextBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_judul As System.Windows.Forms.TextBox
    Friend WithEvents txt_denda As System.Windows.Forms.TextBox
    Friend WithEvents cb_hilang As System.Windows.Forms.ComboBox
    Friend WithEvents cb_rusak As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_dibayar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_totaldenda As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class

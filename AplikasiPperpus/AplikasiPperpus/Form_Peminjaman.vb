Imports System.Data.OleDb
Public Class Form_Peminjaman

    Sub id_pinjam_otomatis()
        Call koneksi()

        cmd = New OleDbCommand("select id_pinjam from tbl_pinjam order by id_pinjam desc", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If Not rd.HasRows = True Then
            txt_idpinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"

        Else
            If Microsoft.VisualBasic.Mid(rd.Item("id_pinjam"), 3, 6) = Format(Today, "yydd") Then
                txt_idpinjam.Text = "PJ" + Format(Microsoft.VisualBasic.Right(rd.Item("id_pinjam"), 8) + 1, "00")

            Else
                txt_idpinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"

            End If

        End If

    End Sub
    Sub bersih()

        txt_idanggota.Clear()
        txt_nama.Clear()
        txt_pernahminjam.Text = "0"
        txt_kategori.Clear()
        txt_pinjamsekarang.Text = "0"
        txt_totalpinjam.Text = "0"
        txt_idbuku.Clear()
        txt_judul.Clear()
        txt_penerbit.Clear()
        txt_pengarang.Clear()
        txt_tahun.Clear()
        txt_kategori.Clear()
        txt_jumlah.Clear()
        txt_idanggota.Focus()
        dgv1.Rows.Clear()

    End Sub
    Sub bersih_transaksi()
        txt_idbuku.Clear()
        txt_judul.Clear()
        txt_penerbit.Clear()
        txt_pengarang.Clear()
        txt_tahun.Clear()
        txt_kategori.Clear()
        txt_jumlah.Clear()
        txt_idbuku.Focus()

    End Sub
    Sub pengaturan()
        cmd = New OleDbCommand("select  * from tbl_pengaturan where id='1'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_bataspinjam.Text = rd.Item("batas_buku")
        End If
    End Sub
    Private Sub Form_Peminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call pengaturan()

        Call id_pinjam_otomatis()
        Call bersih()
        txt_tanggal.Text = Format(Today, "dd/MM/yyyy")
        dgv1.ReadOnly = True
        dgv1.Rows.Clear()
        dgv2.Rows.Clear()


    End Sub


    Private Sub txt_idanggota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_idanggota.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_anggota where id_anggota='" & txt_idanggota.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_nama.Text = rd.Item("nama_anggota")

            'menampilkan buku yang sedang dipinjam 
            da = New OleDbDataAdapter("select tbl_pinjam_detail.id_pinjam, tbl_pinjam_detail.id_buku, tbl_buku.judul, pengarang,penerbit from tbl_pinjam_detail, tbl_pinjam,tbl_buku where tbl_pinjam_detail.id_pinjam=tbl_pinjam.id_pinjam and tbl_buku.id_buku=tbl_pinjam_detail.id_buku and tbl_pinjam.id_anggota='" & txt_idanggota.Text & "' and tbl_pinjam_detail.keterangan='Dipinjam'", conn)
            ds = New DataSet
            da.Fill(ds)
            dgv2.DataSource = ds.Tables(0)
            dgv2.ReadOnly = True
            dgv2.Columns(0).HeaderText = "Id Pinjam"
            dgv2.Columns(1).HeaderText = "Id Buku"
            dgv2.Columns(2).HeaderText = "Judul Buku"
            txt_pernahminjam.Text = dgv2.RowCount - 1
            'membatasi jumlah pinjaman
            If Val(txt_pernahminjam.Text) >= Val(txt_bataspinjam.Text) Then
                MessageBox.Show("Pinjaman Sudah Maximal, Anggota ini tidak Diperbolehkan Lagi Meminjam Buku !!!")
                dgv1.Rows.Clear()
                Call bersih()
                Call bersih_transaksi()
                txt_pinjamsekarang.Clear()

            End If
        Else
            txt_nama.Clear()
            txt_pernahminjam.Text = "0"
            txt_jumlah.Text = "0"
            txt_pinjamsekarang.Text = "0"

        End If
    End Sub

    Private Sub txt_idbuku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & txt_idbuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txt_judul.Text = rd.Item("judul")
                txt_pengarang.Text = rd.Item("pengarang")
                txt_penerbit.Text = rd.Item("penerbit")
                txt_kategori.Text = rd.Item("kategori")
                txt_tahun.Text = rd.Item("tahun")
                txt_jumlah.Text = 1
                txt_jumlah.Focus()
                If Val(rd.Item("stok")) = 0 Then
                    MessageBox.Show("Stok Buku Kosong!!!")
                    Call bersih_transaksi()

                End If
            Else
                MessageBox.Show("Kode Buku Ini Belum Terdaftar!!!")
                Call bersih_transaksi()
            End If
        End If
    End Sub

    Private Sub txt_jumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_jumlah.TextChanged
        If Val(txt_jumlah.Text) > 1 Then
            MessageBox.Show("Anggota Hanya Boleh Meminjam 1 Buku !!!")
            txt_jumlah.Text = 1
        End If
    End Sub

    Private Sub txt_jumlah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_jumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txt_jumlah.Text) < 1 Then
                Exit Sub
            End If
            If txt_idanggota.Text = "" Or txt_nama.Text = "" Then
                MessageBox.Show("Pilih atau Isi Data Anggota Terlebih Dahulu..!!")
                Exit Sub
            End If
            If Val(txt_totalpinjam.Text) >= Val(txt_bataspinjam.Text) Then
                MessageBox.Show("Pinjam Sudah Maksimal!!!")
                Call bersih_transaksi()
                Exit Sub
            End If

            Dim baris1 As Integer = dgv1.RowCount - 1
            Dim id_buku As String = txt_idbuku.Text

            'mencegah meminjam buku 2 kali ketika masih dipinjam
            cmd = New OleDbCommand("select id_buku from tbl_pinjam_detail,tbl_pinjam,tbl_anggota where tbl_pinjam.id_pinjam=tbl_pinjam_detail.id_pinjam and tbl_pinjam.id_anggota=tbl_anggota.id_anggota and tbl_pinjam_detail.id_buku='" & id_buku & "' and tbl_pinjam.id_anggota='" & txt_idanggota.Text & "' and tbl_pinjam_detail.keterangan='Dipinjam'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MessageBox.Show("Buku Ini Sedang Dipinjam !!!")
                Exit Sub
            End If
            'menampilkan data buku yang akan dipinjam
            cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & txt_idbuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                dgv1.Rows.Add(txt_idbuku.Text, txt_judul.Text, txt_pengarang.Text, txt_penerbit.Text, txt_kategori.Text, txt_tahun.Text, txt_jumlah.Text)
                Call bersih_transaksi()

                'mencegah peminjaman buku yang sama
                For barisatas As Integer = 0 To dgv1.RowCount - 1
                    For barisbawah As Integer = barisatas + 1 To dgv1.RowCount - 1
                        If dgv1.Rows(barisbawah).Cells(0).Value = dgv1.Rows(barisatas).Cells(0).Value Then
                            MessageBox.Show("Buku Ini Sudah Dalam Transaksi !!!")
                            dgv1.Rows.RemoveAt(barisbawah)
                            Exit Sub
                        End If
                    Next
                Next
            End If
            'menghitung jumlah buku yang dipinjam dari yang masuk ke daftar pinjam
            txt_pinjamsekarang.Text = dgv1.RowCount - 1
            'mengihuntung total pinjaman anggota yang sekarang dengan yang sebelumnya
            txt_totalpinjam.Text = Val(txt_pernahminjam.Text) + Val(txt_pinjamsekarang.Text)

        End If
        Call bersih_transaksi()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txt_idanggota.Text = "" Or txt_nama.Text = "" Or txt_pinjamsekarang.Text = 0 Then
            MessageBox.Show("Transaksi belum lengkap,tidak ada anggota dan peminjaman buku")
            Exit Sub
        End If

        'menyimpan data transaksi ke tbl_pinjam
        cmd = New OleDbCommand("insert into tbl_pinjam values('" & txt_idpinjam.Text & _
                               "','" & txt_tanggal.Text & _
                               "','" & txt_idanggota.Text & _
                               "')", conn)
        cmd.ExecuteNonQuery()

        For baris As Integer = 0 To dgv1.RowCount - 2
            'menyimpan data ke tbl_pinjam_detail
            cmd = New OleDbCommand("insert into tbl_pinjam_detail values('" & txt_idpinjam.Text & "','" & dgv1.Rows(baris).Cells(0).Value & "','Dipinjam','1')", conn)
            cmd.ExecuteNonQuery()

            'mengurangi stok buku
            cmd = New OleDbCommand("select * from tbl_buku where id_buku'" & dgv1.Rows(baris).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                cmd = New OleDbCommand(" update tbl_buku set stok ='" & rd.Item("stok") - 1 & "' where id_buku='" & dgv1.Rows(baris).Cells(0).Value & "'", conn)
                cmd.ExecuteNonQuery()

            End If
        Next

        MessageBox.Show("Transaksi Peminjaman Berhasil disimpan!!")
        Call bersih()
        Call bersih_transaksi()
        Call id_pinjam_otomatis()
        dgv1.Rows.Clear()
        dgv2.Columns.Clear()



    End Sub

End Class
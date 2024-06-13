Imports System.Data.OleDb
Public Class Form_Input_buku
    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

        TextBox1.Focus()
    End Sub

    Private Sub Form_Input_Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call bersih()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MessageBox.Show("Data Belum Lengkap Diisi !!!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                'simpan/tambah data buku
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_buku values('" & TextBox1.Text & _
                                        "','" & TextBox2.Text & _
                                        "','" & TextBox3.Text & _
                                        "','" & TextBox4.Text & _
                                        "','" & TextBox5.Text & _
                                        "','" & ComboBox1.Text & _
                                        "','" & TextBox6.Text & _
                                        "','" & ComboBox2.Text & _
                                        "','" & DateTimePicker1.Text & _
                                        "','" & TextBox7.Text & _
                                        "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan !!!")
                Call bersih()
                Call Form_Data_Buku.tampil_data_buku()
            Else
                'edit data buku
                Call koneksi()
                cmd = New OleDbCommand("update tbl_buku set judul ='" & TextBox2.Text & _
                                        "', pengarang='" & TextBox3.Text & _
                                        "', penerbit='" & TextBox4.Text & _
                                        "', kategori='" & TextBox5.Text & _
                                        "', tahun='" & ComboBox1.Text & _
                                        "', stok='" & TextBox6.Text & _
                                        "', lokasi='" & ComboBox2.Text & _
                                        "', tanggal_masuk='" & DateTimePicker1.Text & _
                                        "', harga_buku='" & TextBox7.Text & _
                                        "'where id_buku='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diubah !!!")
                Call bersih()
                Call Form_Data_Buku.tampil_data_buku()

            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_buku where id_buku='" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd.Item("judul")
            TextBox3.Text = rd.Item("pengarang")
            TextBox4.Text = rd.Item("penerbit")
            TextBox5.Text = rd.Item("kategori")
            ComboBox1.Text = rd.Item("tahun")
            TextBox6.Text = rd.Item("stok")
            ComboBox2.Text = rd.Item("lokasi")
            DateTimePicker1.Text = rd.Item("tanggal_masuk")
            TextBox7.Text = rd.Item("harga_buku")
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call bersih()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show(" Apakah Anda Ingin Menghapus Data Ini...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("delete from tbl_buku where id_buku='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus !!!")
            Call bersih()
            Call Form_Data_Buku.tampil_data_buku()
        End If
    End Sub
End Class
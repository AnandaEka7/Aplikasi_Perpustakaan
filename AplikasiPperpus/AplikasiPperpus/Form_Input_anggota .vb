Imports System.Data.OleDb

Public Class Form_Input_anggota
    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Form_Input_anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call bersih()

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call bersih()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Data Belum Lengkap Diisi !!!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_anggota where id_anggota='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                'simpan/tambah data anggota
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_anggota values('" & TextBox1.Text & _
                                        "','" & TextBox2.Text & _
                                        "','" & TextBox3.Text & _
                                        "','" & TextBox4.Text & _
                                        "','" & TextBox5.Text & _
                                        "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan !!!")
                Call bersih()
                Call Form_Data_Anggota.tampil_data_anggota()
            Else
                'edit data anggota
                Call koneksi()
                cmd = New OleDbCommand("update tbl_anggota set nama_anggota ='" & TextBox2.Text & _
                                        "', alamat='" & TextBox3.Text & _
                                        "', telpon='" & TextBox4.Text & _
                                        "', email='" & TextBox5.Text & _
                                        "'where id_anggota='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diubah !!!")
                Call bersih()
                Call Form_Data_Anggota.tampil_data_anggota()

            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_anggota where id_anggota='" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd.Item("nama_anggota")
            TextBox3.Text = rd.Item("alamat")
            TextBox4.Text = rd.Item("telpon")
            TextBox5.Text = rd.Item("email")
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show(" Apakah Anda Ingin Menghapus Data Ini...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("delete from tbl_anggota where id_anggota='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus !!!")
            Call bersih()
            Call Form_Data_Anggota.tampil_data_anggota()
        End If
    End Sub
End Class
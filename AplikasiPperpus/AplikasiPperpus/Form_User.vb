Imports System.Data.OleDb
Public Class Form_User
    Sub tampil_data_user()
        cmd = New OleDbCommand("select * from tbl_user", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub

    Private Sub Form_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_data_user()

    End Sub
    Sub bersih()
        TextBox1.Clear()
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Data Belum Lengkap Diisi !!!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_user where id_user='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                'simpan/tambah data anggota
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_user values('" & TextBox1.Text & _
                                        "','" & TextBox2.Text & _
                                        "','" & TextBox3.Text & _
                                        "','" & TextBox4.Text & _
                                        "','" & ComboBox1.Text & _
                                        "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan !!!")
                Call bersih()
                Call tampil_data_user()

            Else
                'edit data anggota
                Call koneksi()
                cmd = New OleDbCommand("update tbl_user set nama_user ='" & TextBox2.Text & _
                                        "', user_name='" & TextBox3.Text & _
                                        "', pwd='" & TextBox4.Text & _
                                        "', level_user='" & ComboBox1.Text & _
                                        "'where id_user='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diubah !!!")
                Call bersih()
                Call tampil_data_user()


            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_user where id_user='" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd.Item("nama_user")
            TextBox3.Text = rd.Item("user_name")
            TextBox4.Text = rd.Item("pwd")
            ComboBox1.Text = rd.Item("level_user")
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show(" Apakah Anda Ingin Menghapus Data Ini...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("delete from tbl_user where id_user='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus !!!")
            Call bersih()
            Call tampil_data_user()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call bersih()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class
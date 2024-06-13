Imports System.Data.OleDb

Public Class Form_Data_Buku

    Sub tampil_data_buku()
        cmd = New OleDbCommand("select * from tbl_buku", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6), rd(7), rd(8), rd(9))
        Loop
    End Sub

    Private Sub Form_Data_Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        tampil_data_buku()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Call tampil_data_buku()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cmd = New OleDbCommand("selecT * from tbl_buku where judul like '%" & TextBox1.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6), rd(7), rd(8), rd(9))
        Loop
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form_Input_buku.ShowDialog()




    End Sub
End Class
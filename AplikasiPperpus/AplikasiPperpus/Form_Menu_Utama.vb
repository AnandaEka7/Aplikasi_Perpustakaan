Public Class Form_Menu_Utama

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LaporanPengmbalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPengmbalianToolStripMenuItem.Click

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form_Data_Buku.ShowDialog()

    End Sub

    Private Sub KatalogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KatalogToolStripMenuItem.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form_Data_Anggota.ShowDialog()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnggotaToolStripMenuItem.Click
        Form_Data_Anggota.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form_Catalog_Buku.ShowDialog()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form_User.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form_Peminjaman.ShowDialog()

    End Sub
End Class
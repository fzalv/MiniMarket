Imports System.Data.OleDb
Public Class MasterBarang

    Sub kondisiawal()
        txt_kode.Text = ""
        txt_nama.Text = ""
        txt_hrg.Text = ""
        txt_jmlh.Text = ""

        cb_kategori.Items.Clear()
        cb_satuan.Items.Clear()
        cb_kategori.Text = ""
        cb_satuan.Text = ""

        lbl_nmkategori.Text = "-"

        btn_input.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_tutup.Text = "Tutup"
        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        btn_tutup.Enabled = True
        Call munculgrid()
        Call munculkategori()
        Call munculsatuan()
    End Sub

    Sub munculgrid()
        Call koneksi()
        da = New OleDbDataAdapter("select * from tbl_barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_barang")
        DataGridView1.DataSource = (ds.Tables("tbl_barang"))
    End Sub

    Sub munculkategori()
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_kategori", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cb_kategori.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub munculsatuan()
        cb_satuan.Items.Add("Pcs")
        cb_satuan.Items.Add("Bal")
    End Sub

    Private Sub MasterBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        If btn_input.Text = "Input" Then
            btn_input.Text = "Simpan"
            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_tutup.Text = "Batal"
        Else
            If txt_kode.Text = "" Or txt_nama.Text = "" Or cb_kategori.Text = "" Or txt_hrg.Text = "" Or txt_jmlh.Text = "" Or cb_satuan.Text = "" Then
                MsgBox("Isi data dengan benar!")
            Else
                Call koneksi()
                Dim simpandata As String = "insert into tbl_barang values ('" & txt_kode.Text & "','" & txt_nama.Text & "','" & cb_kategori.Text & "','" & txt_hrg.Text & "','" & txt_jmlh.Text & "','" & cb_satuan.Text & "')"
                cmd = New OleDbCommand(simpandata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil ditambahkan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub btn_tutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tutup.Click
        If btn_tutup.Text = "Batal" Then
            Call kondisiawal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txt_kode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_barang where kodebarang = '" & txt_kode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txt_nama.Text = rd.Item("nm_barang")
                txt_hrg.Text = rd.Item("hrg_barang")
                txt_jmlh.Text = rd.Item("jmlh_barang")
                cb_satuan.Text = rd.Item("satuan_barang")
                cb_kategori.Text = rd.Item("kodekategori")
            Else
                MsgBox("Data tidak ditemukan!")
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If btn_edit.Text = "Edit" Then
            btn_edit.Text = "Simpan"
            btn_input.Enabled = False
            btn_hapus.Enabled = False
            btn_tutup.Text = "Batal"
        Else
            If txt_kode.Text = "" Or txt_nama.Text = "" Or cb_kategori.Text = "" Or txt_hrg.Text = "" Or txt_jmlh.Text = "" Or cb_satuan.Text = "" Then
                MsgBox("Isi data dengan benar!")
            Else
                Call koneksi()
                Dim editdata As String = "update tbl_barang set nm_barang='" & txt_nama.Text & "', kodekategori='" & cb_kategori.Text & "', hrg_barang='" & txt_hrg.Text & "', jmlh_barang='" & txt_jmlh.Text & "', satuan_barang='" & cb_satuan.Text & "' where kodebarang='" & txt_kode.Text & "'"
                cmd = New OleDbCommand(editdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diubah")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        If btn_hapus.Text = "Hapus" Then
            btn_hapus.Text = "Hapus Data"
            btn_edit.Enabled = False
            btn_input.Enabled = False
            btn_tutup.Text = "Batal"
        Else
            If txt_kode.Text = "" Or txt_nama.Text = "" Or cb_kategori.Text = "" Or txt_hrg.Text = "" Or txt_jmlh.Text = "" Or cb_satuan.Text = "" Then
                MsgBox("Isi data dengan benar!")
            Else
                Call koneksi()
                Dim hapusdata As String = "delete from tbl_barang where kodebarang='" & txt_kode.Text & "'"
                cmd = New OleDbCommand(hapusdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub cb_kategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_kategori.SelectedIndexChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_kategori where kodekategori='" & cb_kategori.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            lbl_nmkategori.Text = rd.Item("nm_kategori")
        End If
    End Sub
End Class
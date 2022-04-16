Imports System.Data.OleDb
Public Class MasterSupplier

    Sub kondisiawal()
        txt_kode.Text = ""
        txt_nama.Text = ""
        txt_alamat.Text = ""
        txt_telepon.Text = ""
        btn_input.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_tutup.Text = "Tutup"
        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        btn_tutup.Enabled = True
        Call munculgrid()
    End Sub

    Sub munculgrid()
        Call koneksi()
        da = New OleDbDataAdapter("select * from tbl_supplier", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_supplier")
        DataGridView1.DataSource = (ds.Tables("tbl_supplier"))
    End Sub

    Private Sub MasterSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        If btn_input.Text = "Input" Then
            btn_input.Text = "Simpan"
            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_tutup.Text = "Batal"
        Else
            If txt_kode.Text = "" Or txt_nama.Text = "" Or txt_alamat.Text = "" Or txt_telepon.Text = "" Then
                MsgBox("Isi data dengan benar!")
            Else
                Call koneksi()
                Dim simpandata As String = "insert into tbl_supplier values ('" & txt_kode.Text & "','" & txt_nama.Text & "','" & txt_alamat.Text & "','" & txt_telepon.Text & "')"
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
            cmd = New OleDbCommand("select * from tbl_supplier where kodesupplier = '" & txt_kode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txt_nama.Text = rd.Item("nm_supplier")
                txt_alamat.Text = rd.Item("almt_supplier")
                txt_telepon.Text = rd.Item("tlp_supplier")
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
            If txt_kode.Text = "" Or txt_nama.Text = "" Or txt_alamat.Text = "" Or txt_telepon.Text = "" Then
                MsgBox("Isi data dengan benar!")
            Else
                Call koneksi()
                Dim editdata As String = "update tbl_supplier set nm_supplier='" & txt_nama.Text & "', almt_supplier='" & txt_alamat.Text & "', tlp_supplier='" & txt_telepon.Text & "' where kodesupplier='" & txt_kode.Text & "'"
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
            If txt_kode.Text = "" Or txt_nama.Text = "" Or txt_alamat.Text = "" Or txt_telepon.Text = "" Then
                MsgBox("Isi data dengan benar!")
            Else
                Call koneksi()
                Dim hapusdata As String = "delete from tbl_supplier where kodesupplier='" & txt_kode.Text & "'"
                cmd = New OleDbCommand(hapusdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                Call kondisiawal()
            End If
        End If
    End Sub
End Class
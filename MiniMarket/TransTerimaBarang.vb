Imports System.Data.OleDb
Public Class TransTerimaBarang

    Sub kondisiawal()
        lbl_tgl.Text = Today
        lbl_admin.Text = MenuUtama.stnama.Text
        Call kodeotomatis()
        lbl_namasup.Text = ""
        lbl_alamatsup.Text = ""
        lbl_tlpsup.Text = ""
        Call kolom()
        lblitem.Text = 0
        lbl_total.Text = 0
        cbkodesupplier.Text = ""
    End Sub

    Sub munculsupplier()
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_supplier", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbkodesupplier.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub kodeotomatis()
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_terima where noterima in (select max(noterima) from tbl_terima)", conn)
        Dim urutankode As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutankode = "T" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            urutankode = "T" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        lbl_kodeterima.Text = urutankode
    End Sub

    Sub kolom()
        dgvterimabarang.Columns.Clear()
        dgvterimabarang.Columns.Add("Kode", "Kode")
        dgvterimabarang.Columns.Add("Nama", "Nama Barang")
        dgvterimabarang.Columns.Add("Harga", "Harga")
        dgvterimabarang.Columns.Add("Jumlah", "Jumlah")
        dgvterimabarang.Columns.Add("Subtotal", "Subtotal")
    End Sub

    Sub rumussubtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To dgvterimabarang.Rows.Count - 1
            hitung = hitung + dgvterimabarang.Rows(i).Cells(4).Value
            lbl_total.Text = hitung
        Next
    End Sub

    Sub rumuscariitem()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To dgvterimabarang.Rows.Count - 1
            hitungitem = hitungitem + dgvterimabarang.Rows(i).Cells(3).Value
            lblitem.Text = hitungitem
        Next
    End Sub

    Private Sub TransTerimaBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call munculsupplier()
        Call kondisiawal()
    End Sub

    Private Sub cbkodesupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkodesupplier.SelectedIndexChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_supplier where kodesupplier='" & cbkodesupplier.Text & "' ", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            lbl_namasup.Text = rd!nm_supplier
            lbl_alamatsup.Text = rd!almt_supplier
            lbl_tlpsup.Text = rd!tlp_supplier
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_jam.Text = TimeOfDay
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_barang where kodebarang='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Kode Barang tidak ada")
            Else
                txtkode.Text = rd.Item("KodeBarang")
                lbl_nama.Text = rd.Item("nm_barang")
                lblharga.Text = rd.Item("hrg_barang")
            End If
        End If
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If lbl_nama.Text = "" Or txtkode.Text = "" Then
            MsgBox("Silahkan masukan kode barang dahulu kemudian enter")
        Else
            dgvterimabarang.Rows.Add(New String() {txtkode.Text, lbl_nama.Text, lblharga.Text, txtjumlah.Text, lblharga.Text * txtjumlah.Text})
            Call rumussubtotal()
            txtkode.Text = ""
            lbl_nama.Text = ""
            lblharga.Text = ""
            txtjumlah.Text = ""
            Call rumuscariitem()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If lbl_namasup.Text = "" Or lbl_total.Text = "0" Then
            MsgBox("Lakukan transaksi terlebih dahulu")
        Else
            Dim simpanterima As String = "insert into tbl_terima values ('" & lbl_kodeterima.Text & "','" & lbl_tgl.Text & "','" & lbl_jam.Text & "','" & lblitem.Text & "','" & lbl_total.Text & "','" & cbkodesupplier.Text & "','" & lbl_admin.Text & "')"
            cmd = New OleDbCommand(simpanterima, conn)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To dgvterimabarang.Rows.Count - 2
                Dim simpandetail As String = "insert into tbl_detailterima values('" & lbl_kodeterima.Text & "','" & dgvterimabarang.Rows(baris).Cells(0).Value & "','" & dgvterimabarang.Rows(baris).Cells(1).Value & "','" & dgvterimabarang.Rows(baris).Cells(2).Value & "','" & dgvterimabarang.Rows(baris).Cells(3).Value & "','" & dgvterimabarang.Rows(baris).Cells(4).Value & "')"
                cmd = New OleDbCommand(simpandetail, conn)
                cmd.ExecuteNonQuery()

                cmd = New OleDbCommand("select * from tbl_barang where kodebarang='" & dgvterimabarang.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                Dim kurangstok As String = "update tbl_barang set jmlh_barang ='" & rd.Item("jmlh_barang") - dgvterimabarang.Rows(baris).Cells(3).Value & "' where kodebarang='" & dgvterimabarang.Rows(baris).Cells(0).Value & "'"
                cmd = New OleDbCommand(kurangstok, conn)
                cmd.ExecuteNonQuery()
            Next
            Call kondisiawal()
            MsgBox("Transaksi berhasil disimpan")
        End If
    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub
End Class
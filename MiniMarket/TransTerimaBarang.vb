Imports System.Data.OleDb
Public Class TransTerimaBarang

    Sub kondisiawal()
        lbl_tgl.Text = Today
        lbl_admin.Text = MenuUtama.stnama.Text
    End Sub

    Sub munculsupplier()
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_supplier", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbkodesupplier.Items.Add(rd.Item(0))
        Loop
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
End Class
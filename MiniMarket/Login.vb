Imports System.Data.OleDb

Public Class Login

    Sub unlock()
        MenuUtama.LoginToolStripMenuItem.Enabled = False
        MenuUtama.LogoutToolStripMenuItem.Enabled = True
        MenuUtama.MasterToolStripMenuItem.Enabled = True
        MenuUtama.TransaksiToolStripMenuItem.Enabled = True
        MenuUtama.LaporanToolStripMenuItem.Enabled = True

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_kode.Text = "" Or txt_pw.Text = "" Then
            MsgBox("Silahkan masukan data dengan benar!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_admin where kodeadmin='" & txt_kode.Text & "' and pw_admin='" & txt_pw.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Me.Close()
                Call unlock()
            Else
                MsgBox("Kode atau Password salah!")
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class
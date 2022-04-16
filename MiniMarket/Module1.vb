Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public rd As OleDbDataReader
    Public cmd As OleDbCommand
    Public lokasidata As String

    Public Sub koneksi()
        lokasidata = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbminimarket.accdb"
        conn = New OleDbConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then conn.Open()

    End Sub
End Module

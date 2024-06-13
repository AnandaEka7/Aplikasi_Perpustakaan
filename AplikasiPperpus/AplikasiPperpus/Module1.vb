Imports System.Data.OleDb



Module Module1
    Public cmd As OleDbCommand
    Public conn As OleDbConnection
    Public rd As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet


    Sub koneksi()
        conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=db_perpus.mdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()







        End If
    End Sub




End Module

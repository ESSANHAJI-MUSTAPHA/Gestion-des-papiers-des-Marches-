Imports System.Data.OleDb
Module Module1
    Public Cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\planconta.mdb")
    Public cmd As New OleDbCommand("select * from plan ", Cn)
    Public da As New OleDbDataAdapter(cmd)
    Public ds As New DataSet
    Public dr As OleDbDataReader
    Public cb As New OleDbCommandBuilder(da)
    '-------------------------
    Public cmd1 As New OleDbCommand("select * from Fornisseur ", Cn)
    Public da1 As New OleDbDataAdapter(cmd1)
    Public ds1 As New DataSet
    Public dr1 As OleDbDataReader
    Public cb1 As New OleDbCommandBuilder(da1)
    '---------------------------------
End Module

Imports System.Data.OleDb
Module declaration
    Public cn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public bl As Boolean
    Public st As String
    Public nbd As String

    Public Sub Connect()
        Try
            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " & nbd)
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
End Module

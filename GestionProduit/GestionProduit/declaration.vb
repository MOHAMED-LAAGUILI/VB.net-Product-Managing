Imports System.Data.OleDb
Module declaration
    Public cn As OleDbConnection ' Open cennection
    Public cmd As OleDbCommand 'Requete 
    Public dr As OleDbDataReader ' Afficher resultat
    Public bl As Boolean
    Public st As String

    Public Sub Connect()
        Try
            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = GestionProduit.accdb")
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
End Module

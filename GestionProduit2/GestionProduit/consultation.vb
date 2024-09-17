Imports System.Data.OleDb
Public Class consultation
    
    Sub RemplirComboBox2()
        Try
            Connect()
            st = "SELECT * FROM Produit"
            cmd = New OleDbCommand(st, cn) 'st = Requete & cn = Conect with DataBase
            'cmd.ExecuteReader() 'it read data and only works with SELECT
            dr = cmd.ExecuteReader ' resultat stock in dr
            ComboBox2.Items.Clear()
            While dr.Read
                ComboBox2.Items.Add(dr(0))
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub lister()
        Try
            Connect()
            If ComboBox2.Text = "" Then
                st = "SELECT commande.* , Produit.* FROM  commande, Produit where Produit.Numero = commande.numeroproduit and commande.datecmd between #" & DateTimePicker1.Text & "# and #" & DateTimePicker2.Text & "#"
                Else
                st = "SELECT commande.*, Produit.* FROM commande, Produit where Produit.Numero = commande.numeroproduit and commande.numeroproduit = '" & ComboBox2.Text & "' and commande.datecmd between #" & DateTimePicker1.Text & "# and #" & DateTimePicker2.Text & "#"
            End If
            cmd = New OleDbCommand(st, cn)
            dr = cmd.ExecuteReader
            Dgv.Rows.Clear()
            While dr.Read
                Dgv.Rows.Add(dr(0), dr(1), dr(6), dr(8), dr(2), dr(3), dr(4))
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Private Sub ComboBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.Click
        RemplirComboBox2()
    End Sub

    Private Sub btl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btl.Click
        lister()
    End Sub
End Class
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Configuration.ConfigurationManager


Public Class Produit


    Sub Nouveau()
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt1.Focus()
    End Sub
    Sub Enregistrer()
        Try
            Connect()
            st = "INSERT INTO Produit VALUES('" & txt1.Text & "','" & txt2.Text & "', " & txt3.Text & "," & txt4.Text & ")"
            '   '" & txt1.Text & "' ==> we use it for text type in access
            '   " & txt3.Text & " ==> we use it for numeric type in access
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery() 'it Return no result just save data
            cn.Close()
            MessageBox.Show("Le produit est bien enregistrer", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.None)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub lister()
        Try
            Connect()
            st = "SELECT * FROM Produit" 'Select DataBase
            cmd = New OleDbCommand(st, cn) 'st = Requete & cn = Conect with DataBase
            'cmd.ExecuteReader() 'it read data and only works with SELECT
            dr = cmd.ExecuteReader ' resultat stock in dr
            Dgv.Rows.Clear()
            While dr.Read
                Dgv.Rows.Add(dr(0), dr(1), dr(2), dr(3))
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub

    Sub Rechercher()
        Try
            Connect()
            st = "SELECT * FROM Produit where Numero ='" & txt1.Text & "'"
            cmd = New OleDbCommand(st, cn) 'st = Requete & cn = Conect with DataBase
            'cmd.ExecuteReader() 'it read data and only works with SELECT
            dr = cmd.ExecuteReader ' resultat stock in dr
            If dr.Read Then
                txt2.Text = dr(1)
                txt3.Text = dr(2)
                txt4.Text = dr(3)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub RemplirComboBox()
        Try
            Connect()
            st = "SELECT * FROM Produit"
            cmd = New OleDbCommand(st, cn) 'st = Requete & cn = Conect with DataBase
            'cmd.ExecuteReader() 'it read data and only works with SELECT
            dr = cmd.ExecuteReader ' resultat stock in dr
            txt1.Items.Clear()
            While dr.Read
                txt1.Items.Add(dr(0))
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub supprimer()
        Try
            Connect()
            st = "DELETE FROM Produit where Numero ='" & txt1.Text & "'"
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Le produit est bien supprimer", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.None)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub modifier()
        Try
            Connect()
            st = "UPDATE Produit SET Designation='" & txt2.Text & "', Quantite= " & txt3.Text & ",Prix=" & txt4.Text & " where Numero ='" & txt1.Text & "' "
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Le produit est bien modifier", "modifier", MessageBoxButtons.OK, MessageBoxIcon.None)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub validation()
        Try
            bl = False
            Connect()
            st = "SELECT * FROM Produit where Numero ='" & txt1.Text & "'"
            cmd = New OleDbCommand(st, cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                bl = True
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub

    Private Sub btl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btl.Click
        lister()
    End Sub

    Private Sub txt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.Click
        RemplirComboBox()
    End Sub

    Private Sub bte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bte.Click
        validation()
        If bl = False Then
            Enregistrer()
            Nouveau()
            lister()
        Else
            MsgBox("Le produit deja exist", MsgBoxStyle.Exclamation, "Message")
            txt1.Text = ""
            txt1.Focus()
        End If

    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn.Click
        Nouveau()
    End Sub

    Private Sub txt1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.SelectedIndexChanged
        Rechercher()
    End Sub

    Private Sub btr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btr.Click
        Rechercher()
    End Sub

    Private Sub btq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btq.Click
        End
    End Sub

    Private Sub bts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bts.Click
        If MessageBox.Show("Voulez vous supprimez l'enregistrement ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            supprimer()
            Nouveau()
        End If
    End Sub

    Private Sub btm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btm.Click
        modifier()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        commande.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        consultation.Show()
    End Sub

    Private Sub Produit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nbd = ConfigurationManager.AppSettings.Get("nombd")
    End Sub
End Class

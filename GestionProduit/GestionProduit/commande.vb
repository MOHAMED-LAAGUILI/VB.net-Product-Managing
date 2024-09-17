Imports System.Data.OleDb
Public Class commande
    Dim qtmodifier As Integer
    Sub enregistrercmd()
        Try
            Connect()
            st = "INSERT INTO commande VALUES('" & ComboBox1.Text & "','" & ComboBox2.Text & "', #" & DateTimePicker1.Value & "#," & NumericUpDown1.Value & "," & NumericUpDown2.Value & ");"
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery()
            st = "UPDATE Produit SET Quantite= " & lbqt.Text - NumericUpDown1.Value & " where Numero ='" & ComboBox2.Text & "' "
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("La commande est bien enregistrer et la quantité est bien modifier", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.None)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub lister()
        Try
            Connect()
            st = "SELECT * FROM commande"
            cmd = New OleDbCommand(st, cn)
            dr = cmd.ExecuteReader
            Dgv.Rows.Clear()
            While dr.Read
                Dgv.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub RemplirComboBox1()
        Try
            Connect()
            st = "SELECT * FROM commande"
            cmd = New OleDbCommand(st, cn) 'st = Requete & cn = Conect with DataBase
            'cmd.ExecuteReader() 'it read data and only works with SELECT
            dr = cmd.ExecuteReader ' resultat stock in dr
            ComboBox1.Items.Clear()
            While dr.Read
                ComboBox1.Items.Add(dr(0))
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
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
    Sub Recherchercmd()
        Try
            qtmodifier = 0
            Connect()
            st = "SELECT * FROM commande where numerocmd ='" & ComboBox1.Text & "'"
            cmd = New OleDbCommand(st, cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                ComboBox2.Text = dr(1)
                DateTimePicker1.Value = dr(2)
                qtmodifier = dr(3)
                NumericUpDown1.Value = dr(3)
                NumericUpDown2.Value = dr(4)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub Rechercherproduit()
        Try
            Connect()
            st = "SELECT * FROM Produit where Numero ='" & ComboBox2.Text & "'"
            cmd = New OleDbCommand(st, cn) 'st = Requete & cn = Conect with DataBase
            'cmd.ExecuteReader() 'it read data and only works with SELECT
            dr = cmd.ExecuteReader ' resultat stock in dr
            If dr.Read Then
                lbqt.Text = dr(2)
                lbprix.Text = dr(3)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub supprimer()
        Try
            Connect()
            st = "DELETE FROM commande where numerocmd ='" & ComboBox1.Text & "'"
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery()
            st = "UPDATE Produit SET Quantite= " & lbqt.Text + NumericUpDown1.Value & " where Numero ='" & ComboBox2.Text & "' "
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("La commande est bien supprimer et la quantité est bien modifier", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.None)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Sub modifier()
        Try
            qtmodifier = qtmodifier - NumericUpDown1.Value
            Connect()
            st = "UPDATE commande SET datecmd=#" & DateTimePicker1.Value & "#, qtcmd=" & NumericUpDown1.Value & " , total=" & NumericUpDown2.Value & " where numerocmd ='" & ComboBox1.Text & "'"
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery()
            st = "UPDATE Produit SET Quantite=Quantite + " & qtmodifier & " where Numero ='" & ComboBox2.Text & "' "
            cmd = New OleDbCommand(st, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("La commande est bien modifier et la quantité est bien modifier", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.None)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Private Sub btl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btl.Click
        lister()
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        RemplirComboBox1()
    End Sub

    Private Sub ComboBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.Click
        RemplirComboBox2()
    End Sub

    Private Sub btr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btr.Click
        Recherchercmd()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Recherchercmd()
        Rechercherproduit()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Rechercherproduit()
    End Sub

    Private Sub NumericUpDown1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown1.Click

        If NumericUpDown1.Value <> Nothing Then
            If NumericUpDown1.Value <= lbqt.Text Then
                NumericUpDown2.Value = NumericUpDown1.Value * lbprix.Text
            Else
                NumericUpDown1.Value = lbqt.Text
                MsgBox("la quantité d'entree est > la quantité real", MsgBoxStyle.Exclamation, "Erreur")
            End If

        End If
    End Sub

    Private Sub bte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bte.Click
        enregistrercmd()
    End Sub

    Private Sub bts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bts.Click
        If MessageBox.Show("Voulez vous supprimez l'enregistrement ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            supprimer()
            'Nouveau()
        End If
    End Sub

    Private Sub btm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btm.Click
        modifier()
    End Sub

    Private Sub commande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
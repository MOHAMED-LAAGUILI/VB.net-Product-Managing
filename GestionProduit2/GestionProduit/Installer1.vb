Imports System.ComponentModel
Imports System.Configuration.Install

Public Class Installer1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Overrides Sub Install(ByVal stateSaver As System.Collections.IDictionary)
        Dim nombd As String = Me.Context.Parameters.Item("InstallNBD")
        Dim chemin As String = Me.Context.Parameters.Item("Chemin")

        Dim fn As String = chemin & "GestionProduits.exe.config"
        Dim xmldoc As New Xml.XmlDocument
        Dim xmlnoeud As Xml.XmlNode
        xmldoc.Load(fn)
        For Each xmlnoeud In xmldoc.Item("configuration").Item("appSettings")
            If xmlnoeud.Name = "add" Then
                If xmlnoeud.Attributes.GetNamedItem("key").Value = "Nombd" Then
                    xmlnoeud.Attributes.GetNamedItem("value").Value = nombd
                End If
            End If
        Next
        xmldoc.Save(fn)

        MyBase.Install(stateSaver)
    End Sub

End Class

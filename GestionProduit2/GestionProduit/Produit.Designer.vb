<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btl = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.txt4 = New System.Windows.Forms.TextBox
        Me.Dgv = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt1 = New System.Windows.Forms.ComboBox
        Me.bte = New System.Windows.Forms.Button
        Me.btn = New System.Windows.Forms.Button
        Me.btr = New System.Windows.Forms.Button
        Me.btm = New System.Windows.Forms.Button
        Me.bts = New System.Windows.Forms.Button
        Me.btq = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btl
        '
        Me.btl.BackColor = System.Drawing.SystemColors.Control
        Me.btl.Location = New System.Drawing.Point(440, 181)
        Me.btl.Name = "btl"
        Me.btl.Size = New System.Drawing.Size(151, 29)
        Me.btl.TabIndex = 0
        Me.btl.Text = "Lister"
        Me.btl.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numéro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Designation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Quantité"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Prix"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Gestion des produits"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(160, 116)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(186, 20)
        Me.txt2.TabIndex = 2
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(160, 163)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(186, 20)
        Me.txt3.TabIndex = 2
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(160, 212)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(186, 20)
        Me.txt4.TabIndex = 2
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.Dgv.Location = New System.Drawing.Point(21, 366)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(606, 126)
        Me.Dgv.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numéro"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Designation"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantité"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Prix"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'txt1
        '
        Me.txt1.FormattingEnabled = True
        Me.txt1.Location = New System.Drawing.Point(160, 77)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(186, 21)
        Me.txt1.TabIndex = 5
        '
        'bte
        '
        Me.bte.Location = New System.Drawing.Point(440, 142)
        Me.bte.Name = "bte"
        Me.bte.Size = New System.Drawing.Size(151, 29)
        Me.bte.TabIndex = 0
        Me.bte.Text = "Enregistrer"
        Me.bte.UseVisualStyleBackColor = False
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(440, 107)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(151, 29)
        Me.btn.TabIndex = 0
        Me.btn.Text = "Nouveau"
        Me.btn.UseVisualStyleBackColor = False
        '
        'btr
        '
        Me.btr.Location = New System.Drawing.Point(440, 216)
        Me.btr.Name = "btr"
        Me.btr.Size = New System.Drawing.Size(151, 29)
        Me.btr.TabIndex = 0
        Me.btr.Text = "Rechercher"
        Me.btr.UseVisualStyleBackColor = False
        '
        'btm
        '
        Me.btm.Location = New System.Drawing.Point(440, 251)
        Me.btm.Name = "btm"
        Me.btm.Size = New System.Drawing.Size(151, 29)
        Me.btm.TabIndex = 0
        Me.btm.Text = "Modifier"
        Me.btm.UseVisualStyleBackColor = False
        '
        'bts
        '
        Me.bts.Location = New System.Drawing.Point(440, 286)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(151, 29)
        Me.bts.TabIndex = 0
        Me.bts.Text = "Supprimer"
        Me.bts.UseVisualStyleBackColor = False
        '
        'btq
        '
        Me.btq.Location = New System.Drawing.Point(440, 321)
        Me.btq.Name = "btq"
        Me.btq.Size = New System.Drawing.Size(151, 29)
        Me.btq.TabIndex = 0
        Me.btq.Text = "Quitter"
        Me.btq.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Commandes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(440, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Consultation"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Produit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 489)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.btq)
        Me.Controls.Add(Me.bts)
        Me.Controls.Add(Me.btm)
        Me.Controls.Add(Me.btr)
        Me.Controls.Add(Me.bte)
        Me.Controls.Add(Me.btl)
        Me.Name = "Produit"
        Me.Text = "Gestion des produits"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btl As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt1 As System.Windows.Forms.ComboBox
    Friend WithEvents bte As System.Windows.Forms.Button
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btr As System.Windows.Forms.Button
    Friend WithEvents btm As System.Windows.Forms.Button
    Friend WithEvents bts As System.Windows.Forms.Button
    Friend WithEvents btq As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class

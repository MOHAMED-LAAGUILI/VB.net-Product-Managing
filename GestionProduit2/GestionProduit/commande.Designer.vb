<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commande
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.Dgv = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn = New System.Windows.Forms.Button
        Me.btq = New System.Windows.Forms.Button
        Me.bts = New System.Windows.Forms.Button
        Me.btm = New System.Windows.Forms.Button
        Me.btr = New System.Windows.Forms.Button
        Me.bte = New System.Windows.Forms.Button
        Me.btl = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbqt = New System.Windows.Forms.Label
        Me.lbprix = New System.Windows.Forms.Label
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Les commandes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Numéro commande"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Numéro produit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date commande"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Quantité commande"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total commande"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(234, 82)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 31)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(234, 132)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(112, 31)
        Me.ComboBox2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(234, 181)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(161, 30)
        Me.DateTimePicker1.TabIndex = 2
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(235, 229)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(158, 30)
        Me.NumericUpDown1.TabIndex = 3
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Location = New System.Drawing.Point(234, 276)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(160, 30)
        Me.NumericUpDown2.TabIndex = 3
        '
        'Dgv
        '
        Me.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Dgv.Location = New System.Drawing.Point(0, 349)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(640, 163)
        Me.Dgv.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numéro cmd"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Numéro produit"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Date cmd"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qt cmd"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total cmd"
        Me.Column5.Name = "Column5"
        '
        'btn
        '
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn.Location = New System.Drawing.Point(472, 72)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(118, 29)
        Me.btn.TabIndex = 10
        Me.btn.Text = "Nouveau"
        Me.btn.UseVisualStyleBackColor = False
        '
        'btq
        '
        Me.btq.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btq.Location = New System.Drawing.Point(472, 286)
        Me.btq.Name = "btq"
        Me.btq.Size = New System.Drawing.Size(118, 29)
        Me.btq.TabIndex = 11
        Me.btq.Text = "Quitter"
        Me.btq.UseVisualStyleBackColor = False
        '
        'bts
        '
        Me.bts.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bts.Location = New System.Drawing.Point(472, 251)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(118, 29)
        Me.bts.TabIndex = 12
        Me.bts.Text = "Supprimer"
        Me.bts.UseVisualStyleBackColor = False
        '
        'btm
        '
        Me.btm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btm.Location = New System.Drawing.Point(472, 216)
        Me.btm.Name = "btm"
        Me.btm.Size = New System.Drawing.Size(118, 29)
        Me.btm.TabIndex = 9
        Me.btm.Text = "Modifier"
        Me.btm.UseVisualStyleBackColor = False
        '
        'btr
        '
        Me.btr.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btr.Location = New System.Drawing.Point(472, 181)
        Me.btr.Name = "btr"
        Me.btr.Size = New System.Drawing.Size(118, 29)
        Me.btr.TabIndex = 6
        Me.btr.Text = "Rechercher"
        Me.btr.UseVisualStyleBackColor = False
        '
        'bte
        '
        Me.bte.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bte.Location = New System.Drawing.Point(472, 107)
        Me.bte.Name = "bte"
        Me.bte.Size = New System.Drawing.Size(118, 29)
        Me.bte.TabIndex = 7
        Me.bte.Text = "Enregistrer"
        Me.bte.UseVisualStyleBackColor = False
        '
        'btl
        '
        Me.btl.BackColor = System.Drawing.SystemColors.Control
        Me.btl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btl.Location = New System.Drawing.Point(472, 146)
        Me.btl.Name = "btl"
        Me.btl.Size = New System.Drawing.Size(118, 29)
        Me.btl.TabIndex = 8
        Me.btl.Text = "Lister"
        Me.btl.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(348, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Qt    : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "prix  : "
        '
        'lbqt
        '
        Me.lbqt.AutoSize = True
        Me.lbqt.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbqt.Location = New System.Drawing.Point(393, 130)
        Me.lbqt.Name = "lbqt"
        Me.lbqt.Size = New System.Drawing.Size(15, 17)
        Me.lbqt.TabIndex = 13
        Me.lbqt.Text = "0"
        '
        'lbprix
        '
        Me.lbprix.AutoSize = True
        Me.lbprix.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbprix.Location = New System.Drawing.Point(393, 152)
        Me.lbprix.Name = "lbprix"
        Me.lbprix.Size = New System.Drawing.Size(15, 17)
        Me.lbprix.TabIndex = 13
        Me.lbprix.Text = "0"
        '
        'commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(640, 512)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbprix)
        Me.Controls.Add(Me.lbqt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.btq)
        Me.Controls.Add(Me.bts)
        Me.Controls.Add(Me.btm)
        Me.Controls.Add(Me.btr)
        Me.Controls.Add(Me.bte)
        Me.Controls.Add(Me.btl)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "commande"
        Me.Text = "commande"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btq As System.Windows.Forms.Button
    Friend WithEvents bts As System.Windows.Forms.Button
    Friend WithEvents btm As System.Windows.Forms.Button
    Friend WithEvents btr As System.Windows.Forms.Button
    Friend WithEvents bte As System.Windows.Forms.Button
    Friend WithEvents btl As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbqt As System.Windows.Forms.Label
    Friend WithEvents lbprix As System.Windows.Forms.Label
End Class

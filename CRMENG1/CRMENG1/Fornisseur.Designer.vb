<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornisseur
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fornisseur))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PlancontaDataSet1 = New CRMENG1.plancontaDataSet1
        Me.Tfornisseur1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_fornisseur1TableAdapter = New CRMENG1.plancontaDataSet1TableAdapters.T_fornisseur1TableAdapter
        Me.NODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FournisseurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GérantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SiègeSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RegistredecommerceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CNSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdentificationfiscaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IGRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComptebancaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BanqueouCCPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxeprofessionnellePatenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NdetélDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NdeFaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombredebondecommandeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontantdebonsdecommandecumulésDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombredeMarchésDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontantdemarchéscumulésDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.PictureBox13 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlancontaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tfornisseur1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NODataGridViewTextBoxColumn, Me.FournisseurDataGridViewTextBoxColumn, Me.GérantDataGridViewTextBoxColumn, Me.SiègeSocialDataGridViewTextBoxColumn, Me.RegistredecommerceDataGridViewTextBoxColumn, Me.CNSSDataGridViewTextBoxColumn, Me.IdentificationfiscaleDataGridViewTextBoxColumn, Me.IGRDataGridViewTextBoxColumn, Me.ComptebancaireDataGridViewTextBoxColumn, Me.BanqueouCCPDataGridViewTextBoxColumn, Me.TaxeprofessionnellePatenteDataGridViewTextBoxColumn, Me.NdetélDataGridViewTextBoxColumn, Me.NdeFaxDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.NombredebondecommandeDataGridViewTextBoxColumn, Me.MontantdebonsdecommandecumulésDataGridViewTextBoxColumn, Me.NombredeMarchésDataGridViewTextBoxColumn, Me.MontantdemarchéscumulésDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Tfornisseur1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 201)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(905, 308)
        Me.DataGridView1.TabIndex = 0
        '
        'PlancontaDataSet1
        '
        Me.PlancontaDataSet1.DataSetName = "plancontaDataSet1"
        Me.PlancontaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tfornisseur1BindingSource
        '
        Me.Tfornisseur1BindingSource.DataMember = "T_fornisseur1"
        Me.Tfornisseur1BindingSource.DataSource = Me.PlancontaDataSet1
        '
        'T_fornisseur1TableAdapter
        '
        Me.T_fornisseur1TableAdapter.ClearBeforeFill = True
        '
        'NODataGridViewTextBoxColumn
        '
        Me.NODataGridViewTextBoxColumn.DataPropertyName = "NO"
        Me.NODataGridViewTextBoxColumn.HeaderText = "NO"
        Me.NODataGridViewTextBoxColumn.Name = "NODataGridViewTextBoxColumn"
        Me.NODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FournisseurDataGridViewTextBoxColumn
        '
        Me.FournisseurDataGridViewTextBoxColumn.DataPropertyName = "Fournisseur"
        Me.FournisseurDataGridViewTextBoxColumn.HeaderText = "Fournisseur"
        Me.FournisseurDataGridViewTextBoxColumn.Name = "FournisseurDataGridViewTextBoxColumn"
        Me.FournisseurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GérantDataGridViewTextBoxColumn
        '
        Me.GérantDataGridViewTextBoxColumn.DataPropertyName = "Gérant"
        Me.GérantDataGridViewTextBoxColumn.HeaderText = "Gérant"
        Me.GérantDataGridViewTextBoxColumn.Name = "GérantDataGridViewTextBoxColumn"
        Me.GérantDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SiègeSocialDataGridViewTextBoxColumn
        '
        Me.SiègeSocialDataGridViewTextBoxColumn.DataPropertyName = "siègeSocial"
        Me.SiègeSocialDataGridViewTextBoxColumn.HeaderText = "siègeSocial"
        Me.SiègeSocialDataGridViewTextBoxColumn.Name = "SiègeSocialDataGridViewTextBoxColumn"
        Me.SiègeSocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegistredecommerceDataGridViewTextBoxColumn
        '
        Me.RegistredecommerceDataGridViewTextBoxColumn.DataPropertyName = "Registredecommerce"
        Me.RegistredecommerceDataGridViewTextBoxColumn.HeaderText = "Registredecommerce"
        Me.RegistredecommerceDataGridViewTextBoxColumn.Name = "RegistredecommerceDataGridViewTextBoxColumn"
        Me.RegistredecommerceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CNSSDataGridViewTextBoxColumn
        '
        Me.CNSSDataGridViewTextBoxColumn.DataPropertyName = "CNSS"
        Me.CNSSDataGridViewTextBoxColumn.HeaderText = "CNSS"
        Me.CNSSDataGridViewTextBoxColumn.Name = "CNSSDataGridViewTextBoxColumn"
        Me.CNSSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdentificationfiscaleDataGridViewTextBoxColumn
        '
        Me.IdentificationfiscaleDataGridViewTextBoxColumn.DataPropertyName = "Identificationfiscale"
        Me.IdentificationfiscaleDataGridViewTextBoxColumn.HeaderText = "Identificationfiscale"
        Me.IdentificationfiscaleDataGridViewTextBoxColumn.Name = "IdentificationfiscaleDataGridViewTextBoxColumn"
        Me.IdentificationfiscaleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IGRDataGridViewTextBoxColumn
        '
        Me.IGRDataGridViewTextBoxColumn.DataPropertyName = "IGR"
        Me.IGRDataGridViewTextBoxColumn.HeaderText = "IGR"
        Me.IGRDataGridViewTextBoxColumn.Name = "IGRDataGridViewTextBoxColumn"
        Me.IGRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComptebancaireDataGridViewTextBoxColumn
        '
        Me.ComptebancaireDataGridViewTextBoxColumn.DataPropertyName = "Comptebancaire"
        Me.ComptebancaireDataGridViewTextBoxColumn.HeaderText = "Comptebancaire"
        Me.ComptebancaireDataGridViewTextBoxColumn.Name = "ComptebancaireDataGridViewTextBoxColumn"
        Me.ComptebancaireDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BanqueouCCPDataGridViewTextBoxColumn
        '
        Me.BanqueouCCPDataGridViewTextBoxColumn.DataPropertyName = "BanqueouCCP"
        Me.BanqueouCCPDataGridViewTextBoxColumn.HeaderText = "BanqueouCCP"
        Me.BanqueouCCPDataGridViewTextBoxColumn.Name = "BanqueouCCPDataGridViewTextBoxColumn"
        Me.BanqueouCCPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TaxeprofessionnellePatenteDataGridViewTextBoxColumn
        '
        Me.TaxeprofessionnellePatenteDataGridViewTextBoxColumn.DataPropertyName = "Taxeprofessionnelle (Patente)"
        Me.TaxeprofessionnellePatenteDataGridViewTextBoxColumn.HeaderText = "Taxeprofessionnelle (Patente)"
        Me.TaxeprofessionnellePatenteDataGridViewTextBoxColumn.Name = "TaxeprofessionnellePatenteDataGridViewTextBoxColumn"
        Me.TaxeprofessionnellePatenteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NdetélDataGridViewTextBoxColumn
        '
        Me.NdetélDataGridViewTextBoxColumn.DataPropertyName = "N°detél"
        Me.NdetélDataGridViewTextBoxColumn.HeaderText = "N°detél"
        Me.NdetélDataGridViewTextBoxColumn.Name = "NdetélDataGridViewTextBoxColumn"
        Me.NdetélDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NdeFaxDataGridViewTextBoxColumn
        '
        Me.NdeFaxDataGridViewTextBoxColumn.DataPropertyName = "N°de Fax"
        Me.NdeFaxDataGridViewTextBoxColumn.HeaderText = "N°de Fax"
        Me.NdeFaxDataGridViewTextBoxColumn.Name = "NdeFaxDataGridViewTextBoxColumn"
        Me.NdeFaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "e-mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "e-mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombredebondecommandeDataGridViewTextBoxColumn
        '
        Me.NombredebondecommandeDataGridViewTextBoxColumn.DataPropertyName = "Nombredebondecommande"
        Me.NombredebondecommandeDataGridViewTextBoxColumn.HeaderText = "Nombredebondecommande"
        Me.NombredebondecommandeDataGridViewTextBoxColumn.Name = "NombredebondecommandeDataGridViewTextBoxColumn"
        Me.NombredebondecommandeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontantdebonsdecommandecumulésDataGridViewTextBoxColumn
        '
        Me.MontantdebonsdecommandecumulésDataGridViewTextBoxColumn.DataPropertyName = "Montantdebonsdecommandecumulés"
        Me.MontantdebonsdecommandecumulésDataGridViewTextBoxColumn.HeaderText = "Montantdebonsdecommandecumulés"
        Me.MontantdebonsdecommandecumulésDataGridViewTextBoxColumn.Name = "MontantdebonsdecommandecumulésDataGridViewTextBoxColumn"
        Me.MontantdebonsdecommandecumulésDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombredeMarchésDataGridViewTextBoxColumn
        '
        Me.NombredeMarchésDataGridViewTextBoxColumn.DataPropertyName = "NombredeMarchés"
        Me.NombredeMarchésDataGridViewTextBoxColumn.HeaderText = "NombredeMarchés"
        Me.NombredeMarchésDataGridViewTextBoxColumn.Name = "NombredeMarchésDataGridViewTextBoxColumn"
        Me.NombredeMarchésDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontantdemarchéscumulésDataGridViewTextBoxColumn
        '
        Me.MontantdemarchéscumulésDataGridViewTextBoxColumn.DataPropertyName = "Montantdemarchéscumulés"
        Me.MontantdemarchéscumulésDataGridViewTextBoxColumn.HeaderText = "Montantdemarchéscumulés"
        Me.MontantdemarchéscumulésDataGridViewTextBoxColumn.Name = "MontantdemarchéscumulésDataGridViewTextBoxColumn"
        Me.MontantdemarchéscumulésDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "La LISTE DU FORNISSEUR"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Location = New System.Drawing.Point(51, 106)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(164, 13)
        Me.Label80.TabIndex = 52
        Me.Label80.Text = "Délégation Provinciale de Guercif" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Location = New System.Drawing.Point(31, 80)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(214, 13)
        Me.Label81.TabIndex = 51
        Me.Label81.Text = "De la région de Taza-Al Hoceima- Taounate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Location = New System.Drawing.Point(8, 56)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(262, 13)
        Me.Label82.TabIndex = 54
        Me.Label82.Text = "Académie Régionale de l'Education et de la Formation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Location = New System.Drawing.Point(51, 33)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(167, 13)
        Me.Label83.TabIndex = 53
        Me.Label83.Text = "Ministère de l’Education Nationale"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Location = New System.Drawing.Point(75, 9)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(100, 13)
        Me.Label84.TabIndex = 50
        Me.Label84.Text = "Royaume Du Maroc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.BackgroundImage = CType(resources.GetObject("PictureBox13.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox13.Location = New System.Drawing.Point(802, 25)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(80, 68)
        Me.PictureBox13.TabIndex = 155
        Me.PictureBox13.TabStop = False
        '
        'Fornisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CRMENG1.My.Resources.Resources.LOGOO
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(923, 558)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.Label84)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Fornisseur"
        Me.Text = "Fornisseur"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlancontaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tfornisseur1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PlancontaDataSet1 As CRMENG1.plancontaDataSet1
    Friend WithEvents Tfornisseur1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_fornisseur1TableAdapter As CRMENG1.plancontaDataSet1TableAdapters.T_fornisseur1TableAdapter
    Friend WithEvents NODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FournisseurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GérantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiègeSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistredecommerceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNSSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificationfiscaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComptebancaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BanqueouCCPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxeprofessionnellePatenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NdetélDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NdeFaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombredebondecommandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantdebonsdecommandecumulésDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombredeMarchésDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantdemarchéscumulésDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
End Class

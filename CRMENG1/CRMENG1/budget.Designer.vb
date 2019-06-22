<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class budget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(budget))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlancontaDataSet = New CRMENG1.plancontaDataSet
        Me.PlanTableAdapter = New CRMENG1.plancontaDataSetTableAdapters.planTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox13 = New System.Windows.Forms.PictureBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlancontaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.LineDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PlanBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(774, 258)
        Me.DataGridView1.TabIndex = 0
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeDataGridViewTextBoxColumn.Width = 130
        '
        'LineDataGridViewTextBoxColumn
        '
        Me.LineDataGridViewTextBoxColumn.DataPropertyName = "Line"
        Me.LineDataGridViewTextBoxColumn.HeaderText = "Line"
        Me.LineDataGridViewTextBoxColumn.Name = "LineDataGridViewTextBoxColumn"
        Me.LineDataGridViewTextBoxColumn.ReadOnly = True
        Me.LineDataGridViewTextBoxColumn.Width = 600
        '
        'PlanBindingSource
        '
        Me.PlanBindingSource.DataMember = "plan"
        Me.PlanBindingSource.DataSource = Me.PlancontaDataSet
        '
        'PlancontaDataSet
        '
        Me.PlancontaDataSet.DataSetName = "plancontaDataSet"
        Me.PlancontaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanTableAdapter
        '
        Me.PlanTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plan contabilite"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.BackgroundImage = CType(resources.GetObject("PictureBox13.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox13.Location = New System.Drawing.Point(729, 28)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(80, 68)
        Me.PictureBox13.TabIndex = 155
        Me.PictureBox13.TabStop = False
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Location = New System.Drawing.Point(55, 101)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(164, 13)
        Me.Label80.TabIndex = 158
        Me.Label80.Text = "Délégation Provinciale de Guercif" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Location = New System.Drawing.Point(35, 75)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(214, 13)
        Me.Label81.TabIndex = 157
        Me.Label81.Text = "De la région de Taza-Al Hoceima- Taounate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Location = New System.Drawing.Point(12, 51)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(262, 13)
        Me.Label82.TabIndex = 160
        Me.Label82.Text = "Académie Régionale de l'Education et de la Formation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Location = New System.Drawing.Point(55, 28)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(167, 13)
        Me.Label83.TabIndex = 159
        Me.Label83.Text = "Ministère de l’Education Nationale"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Location = New System.Drawing.Point(79, 4)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(100, 13)
        Me.Label84.TabIndex = 156
        Me.Label84.Text = "Royaume Du Maroc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'budget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.CRMENG1.My.Resources.Resources.LOGOO
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(847, 474)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.Label84)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "budget"
        Me.Text = "budget"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlancontaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PlancontaDataSet As CRMENG1.plancontaDataSet
    Friend WithEvents PlanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTableAdapter As CRMENG1.plancontaDataSetTableAdapters.planTableAdapter
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.DT1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_EXPORT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.i_AggregationType_1 = New System.Windows.Forms.RadioButton()
        Me.i_AggregationType_0 = New System.Windows.Forms.RadioButton()
        Me.f_DeleteBefore = New System.Windows.Forms.CheckBox()
        Me.f_Compatta = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DT2 = New System.Windows.Forms.DateTimePicker()
        Me.NR_MOV = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DB_DEST = New System.Windows.Forms.Label()
        Me.DB_ORIGINE = New System.Windows.Forms.Label()
        Me.BTN_READ = New System.Windows.Forms.Button()
        Me.ExporT_MOVIMENTITableAdapter1 = New ProBatchExportMov.ProBatchDataSetTableAdapters.EXPORT_MOVIMENTITableAdapter()
        Me._840002R1DataSet1 = New ProBatchExportMov._840002R1DataSet()
        Me.V_GET_MOVTableAdapter1 = New ProBatchExportMov._840002R1DataSetTableAdapters.V_GET_MOVTableAdapter()
        Me.V_GET_MOV_COMPACTTableAdapter1 = New ProBatchExportMov._840002R1DataSetTableAdapters.V_GET_MOV_COMPACTTableAdapter()
        Me.Panel1.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel3.SuspendLayout
        CType(Me._840002R1DataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BTN_EXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(1103, 16)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(114, 38)
        Me.BTN_EXIT.TabIndex = 0
        Me.BTN_EXIT.Text = "Exit"
        Me.BTN_EXIT.UseVisualStyleBackColor = true
        '
        'DT1
        '
        Me.DT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DT1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT1.Location = New System.Drawing.Point(143, 27)
        Me.DT1.Name = "DT1"
        Me.DT1.Size = New System.Drawing.Size(144, 29)
        Me.DT1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data movimenti"
        '
        'BTN_EXPORT
        '
        Me.BTN_EXPORT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BTN_EXPORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BTN_EXPORT.Location = New System.Drawing.Point(983, 16)
        Me.BTN_EXPORT.Name = "BTN_EXPORT"
        Me.BTN_EXPORT.Size = New System.Drawing.Size(114, 38)
        Me.BTN_EXPORT.TabIndex = 3
        Me.BTN_EXPORT.Text = "Export"
        Me.BTN_EXPORT.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.f_DeleteBefore)
        Me.Panel1.Controls.Add(Me.f_Compatta)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DT2)
        Me.Panel1.Controls.Add(Me.NR_MOV)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DT1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1229, 94)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(825, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipologia aggregazione"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.i_AggregationType_1)
        Me.Panel4.Controls.Add(Me.i_AggregationType_0)
        Me.Panel4.Location = New System.Drawing.Point(825, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(224, 55)
        Me.Panel4.TabIndex = 11
        '
        'i_AggregationType_1
        '
        Me.i_AggregationType_1.AutoSize = true
        Me.i_AggregationType_1.Location = New System.Drawing.Point(3, 26)
        Me.i_AggregationType_1.Name = "i_AggregationType_1"
        Me.i_AggregationType_1.Size = New System.Drawing.Size(110, 17)
        Me.i_AggregationType_1.TabIndex = 11
        Me.i_AggregationType_1.Text = "MATERIA PRIMA"
        Me.i_AggregationType_1.UseVisualStyleBackColor = true
        '
        'i_AggregationType_0
        '
        Me.i_AggregationType_0.AutoSize = true
        Me.i_AggregationType_0.Checked = true
        Me.i_AggregationType_0.Location = New System.Drawing.Point(3, 3)
        Me.i_AggregationType_0.Name = "i_AggregationType_0"
        Me.i_AggregationType_0.Size = New System.Drawing.Size(204, 17)
        Me.i_AggregationType_0.TabIndex = 10
        Me.i_AggregationType_0.TabStop = true
        Me.i_AggregationType_0.Text = "RICETTA\CODICE MATERIA PRIMA"
        Me.i_AggregationType_0.UseVisualStyleBackColor = true
        '
        'f_DeleteBefore
        '
        Me.f_DeleteBefore.AutoSize = true
        Me.f_DeleteBefore.Location = New System.Drawing.Point(501, 52)
        Me.f_DeleteBefore.Name = "f_DeleteBefore"
        Me.f_DeleteBefore.Size = New System.Drawing.Size(217, 17)
        Me.f_DeleteBefore.TabIndex = 9
        Me.f_DeleteBefore.Text = "Elimino i dati prima di eseguire l'EXPORT"
        Me.f_DeleteBefore.UseVisualStyleBackColor = true
        '
        'f_Compatta
        '
        Me.f_Compatta.AutoSize = true
        Me.f_Compatta.Location = New System.Drawing.Point(501, 29)
        Me.f_Compatta.Name = "f_Compatta"
        Me.f_Compatta.Size = New System.Drawing.Size(270, 17)
        Me.f_Compatta.TabIndex = 8
        Me.f_Compatta.Text = "Compatta i movimenti per data\codice materia prima"
        Me.f_Compatta.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(302, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data fine"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(140, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data inizio"
        '
        'DT2
        '
        Me.DT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT2.Location = New System.Drawing.Point(305, 27)
        Me.DT2.Name = "DT2"
        Me.DT2.Size = New System.Drawing.Size(144, 29)
        Me.DT2.TabIndex = 5
        '
        'NR_MOV
        '
        Me.NR_MOV.AutoSize = true
        Me.NR_MOV.Location = New System.Drawing.Point(54, 43)
        Me.NR_MOV.Name = "NR_MOV"
        Me.NR_MOV.Size = New System.Drawing.Size(13, 13)
        Me.NR_MOV.TabIndex = 4
        Me.NR_MOV.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(27, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nr. movimenti"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1229, 727)
        Me.Panel2.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.Size = New System.Drawing.Size(602, 532)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.DB_DEST)
        Me.Panel3.Controls.Add(Me.DB_ORIGINE)
        Me.Panel3.Controls.Add(Me.BTN_READ)
        Me.Panel3.Controls.Add(Me.BTN_EXIT)
        Me.Panel3.Controls.Add(Me.BTN_EXPORT)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 661)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1229, 66)
        Me.Panel3.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Location = New System.Drawing.Point(143, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Test connessione database"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'DB_DEST
        '
        Me.DB_DEST.AutoSize = true
        Me.DB_DEST.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DB_DEST.Location = New System.Drawing.Point(386, 40)
        Me.DB_DEST.Name = "DB_DEST"
        Me.DB_DEST.Size = New System.Drawing.Size(198, 24)
        Me.DB_DEST.TabIndex = 8
        Me.DB_DEST.Text = "Database gestionale"
        '
        'DB_ORIGINE
        '
        Me.DB_ORIGINE.AutoSize = true
        Me.DB_ORIGINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DB_ORIGINE.Location = New System.Drawing.Point(386, 11)
        Me.DB_ORIGINE.Name = "DB_ORIGINE"
        Me.DB_ORIGINE.Size = New System.Drawing.Size(185, 24)
        Me.DB_ORIGINE.TabIndex = 7
        Me.DB_ORIGINE.Text = "Database Probatch"
        '
        'BTN_READ
        '
        Me.BTN_READ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BTN_READ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BTN_READ.Location = New System.Drawing.Point(12, 16)
        Me.BTN_READ.Name = "BTN_READ"
        Me.BTN_READ.Size = New System.Drawing.Size(114, 38)
        Me.BTN_READ.TabIndex = 4
        Me.BTN_READ.Text = "Read"
        Me.BTN_READ.UseVisualStyleBackColor = true
        '
        'ExporT_MOVIMENTITableAdapter1
        '
        Me.ExporT_MOVIMENTITableAdapter1.ClearBeforeFill = true
        '
        '_840002R1DataSet1
        '
        Me._840002R1DataSet1.DataSetName = "_840002R1DataSet"
        Me._840002R1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_GET_MOVTableAdapter1
        '
        Me.V_GET_MOVTableAdapter1.ClearBeforeFill = true
        '
        'V_GET_MOV_COMPACTTableAdapter1
        '
        Me.V_GET_MOV_COMPACTTableAdapter1.ClearBeforeFill = true
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 727)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMain"
        Me.Text = "Export movimenti Probatch"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.Panel2.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        CType(Me._840002R1DataSet1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents DT1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_EXPORT As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_READ As Button
    Friend WithEvents _840002R1DataSet1 As _840002R1DataSet
    Friend WithEvents V_GET_MOVTableAdapter1 As _840002R1DataSetTableAdapters.V_GET_MOVTableAdapter
    Friend WithEvents ExporT_MOVIMENTITableAdapter1 As ProBatchDataSetTableAdapters.EXPORT_MOVIMENTITableAdapter
    Friend WithEvents NR_MOV As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DT2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents f_Compatta As CheckBox
    Friend WithEvents V_GET_MOV_COMPACTTableAdapter1 As _840002R1DataSetTableAdapters.V_GET_MOV_COMPACTTableAdapter
    Friend WithEvents f_DeleteBefore As CheckBox
    Friend WithEvents DB_DEST As Label
    Friend WithEvents DB_ORIGINE As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents i_AggregationType_1 As RadioButton
    Friend WithEvents i_AggregationType_0 As RadioButton
End Class

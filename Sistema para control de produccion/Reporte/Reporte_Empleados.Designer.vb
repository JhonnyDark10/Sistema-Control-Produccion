<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Empleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_Empleados))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Sistema_AnconcitoDataSet = New Sistema_para_control_de_produccion.Sistema_AnconcitoDataSet()
        Me.VISTA_EMBARCACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTA_EMBARCACIONESTableAdapter = New Sistema_para_control_de_produccion.Sistema_AnconcitoDataSetTableAdapters.VISTA_EMBARCACIONESTableAdapter()
        Me.Sistema_AnconcitoDataSet1 = New Sistema_para_control_de_produccion.Sistema_AnconcitoDataSet1()
        Me.VISTA2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTA2TableAdapter = New Sistema_para_control_de_produccion.Sistema_AnconcitoDataSet1TableAdapters.VISTA2TableAdapter()
        CType(Me.Sistema_AnconcitoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTA_EMBARCACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sistema_AnconcitoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTA2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VISTA2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_para_control_de_produccion.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(661, 479)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sistema_AnconcitoDataSet
        '
        Me.Sistema_AnconcitoDataSet.DataSetName = "Sistema_AnconcitoDataSet"
        Me.Sistema_AnconcitoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VISTA_EMBARCACIONESBindingSource
        '
        Me.VISTA_EMBARCACIONESBindingSource.DataMember = "VISTA_EMBARCACIONES"
        Me.VISTA_EMBARCACIONESBindingSource.DataSource = Me.Sistema_AnconcitoDataSet
        '
        'VISTA_EMBARCACIONESTableAdapter
        '
        Me.VISTA_EMBARCACIONESTableAdapter.ClearBeforeFill = True
        '
        'Sistema_AnconcitoDataSet1
        '
        Me.Sistema_AnconcitoDataSet1.DataSetName = "Sistema_AnconcitoDataSet1"
        Me.Sistema_AnconcitoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VISTA2BindingSource
        '
        Me.VISTA2BindingSource.DataMember = "VISTA2"
        Me.VISTA2BindingSource.DataSource = Me.Sistema_AnconcitoDataSet1
        '
        'VISTA2TableAdapter
        '
        Me.VISTA2TableAdapter.ClearBeforeFill = True
        '
        'Reporte_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 479)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reporte_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Empleados"
        CType(Me.Sistema_AnconcitoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTA_EMBARCACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sistema_AnconcitoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTA2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VISTA_EMBARCACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sistema_AnconcitoDataSet As Sistema_para_control_de_produccion.Sistema_AnconcitoDataSet
    Friend WithEvents VISTA_EMBARCACIONESTableAdapter As Sistema_para_control_de_produccion.Sistema_AnconcitoDataSetTableAdapters.VISTA_EMBARCACIONESTableAdapter
    Friend WithEvents VISTA2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sistema_AnconcitoDataSet1 As Sistema_para_control_de_produccion.Sistema_AnconcitoDataSet1
    Friend WithEvents VISTA2TableAdapter As Sistema_para_control_de_produccion.Sistema_AnconcitoDataSet1TableAdapters.VISTA2TableAdapter
End Class

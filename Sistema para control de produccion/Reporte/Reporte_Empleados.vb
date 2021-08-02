Public Class Reporte_Empleados

   
    Private Sub Reporte_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sistema_AnconcitoDataSet1.VISTA2' Puede moverla o quitarla según sea necesario.
        Me.VISTA2TableAdapter.Fill(Me.Sistema_AnconcitoDataSet1.VISTA2)
        'TODO: esta línea de código carga datos en la tabla 'Sistema_AnconcitoDataSet.VISTA_EMBARCACIONES' Puede moverla o quitarla según sea necesario.
        Me.VISTA_EMBARCACIONESTableAdapter.Fill(Me.Sistema_AnconcitoDataSet.VISTA_EMBARCACIONES)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
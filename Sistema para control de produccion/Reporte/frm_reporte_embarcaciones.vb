Public Class frm_reporte_embarcaciones

    Private Sub frm_reporte_embarcaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sistema_AnconcitoDataSet.VISTA_EMBARCACIONES' Puede moverla o quitarla según sea necesario.
        Me.VISTA_EMBARCACIONESTableAdapter.Fill(Me.Sistema_AnconcitoDataSet.VISTA_EMBARCACIONES)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
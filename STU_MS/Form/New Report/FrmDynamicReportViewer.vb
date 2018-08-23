Public Class FrmDynamicReportViewer
    Dim reportDatasource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

    Public Sub SetupReport(ByVal dataSet As String, ByVal reportName As String, ByVal bindingSource As BindingSource)
        Try
            ReportViewer.LocalReport.Refresh()
            ReportViewer.LocalReport.DataSources.Clear()
            ReportViewer.RefreshReport()
            reportDatasource.Name = dataSet
            reportDatasource.Value = bindingSource
            ReportViewer.LocalReport.DataSources.Add(reportDatasource)
            ReportViewer.LocalReport.ReportEmbeddedResource = reportName
            ReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer.ZoomPercent = 100
            ReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
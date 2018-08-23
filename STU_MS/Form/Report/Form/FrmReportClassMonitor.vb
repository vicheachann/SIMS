Imports System.Data.SqlClient

Public Class FrmReportClassMonitor
    Shared _yearStudy As String
    ReadOnly obj As New Method
    Private sql As String
    Dim reportDatasource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
    Private Sub FrmReportClassMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call obj.OpenConnection()
            sql = "SELECT ROW_NUMBER() OVER(ORDER BY M.CLASS_ID,M.CLASS_MONITOR_NUM ASC) AS 'ROW_NUMBER', S.SNAME_KH, S.GENDER, M.YEAR_STUDY,M.CLASS_ID , C.CLASS_LETTER, M.CLASS_MONITOR_NUM, M.REMARK FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_CLASS_MONITOR AS M ON S.STUDENT_ID = M.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON M.CLASS_ID = C.CLASS_ID"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.STU_CLASS_MONITOR.Clear()
            da.Fill(DataSet1.STU_CLASS_MONITOR)
            Call obj.SendParam("paramSchoolName", obj.GetSchoolName(), ReportViewer)
            Call obj.SendParam("paramYearStudy", _yearStudy, ReportViewer)

            obj.SetupReportView(ReportViewer)
            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Shared Sub SetYearStudy(ByVal yearStudy As String)
        _yearStudy = yearStudy
    End Sub
End Class
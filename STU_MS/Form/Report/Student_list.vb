Imports System.Data.SqlClient


Public Class Student_list
    ReadOnly _obj As New Method
    Private _sqlCmd As String
    ReadOnly _reportDatasource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()


    Private Sub Teacher_CV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReportViewer1.RefreshReport()

        Try
            Call ViewAllStudentList()
            Call SetReports("DataSet1", "STU_MS.rpStudentList.rdlc", bs_dtSudentList)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub ViewAllStudentList()
        Try
            Call _obj.OpenConnection()
            _sqlCmd = "SELECT  ROW_NUMBER() OVER(ORDER BY S.SNAME_KH ASC) AS 'ROW_NUM', S.SNAME_KH, S.GENDER, CONVERT(VARCHAR(10), S.DOB,110) AS DOB, S.GUARDIAN_VILLAGE, S.S_PHONE_LINE_1, C.CLASS_LETTER ,(SELECT  MAX(SS.YEAR_STUDY) FROM dbo.TBS_STUDENT_STUDY_INFO AS SS)AS 'CURRENT_YEAR_STUDY' FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_CLASS AS C ON S.CLASS_ID = C.CLASS_ID  WHERE CLASS_LETTER = N'" & FrmStudent.cboStuCurrentClass.Text & "'  "
            cmd = New SqlCommand(_sqlCmd, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.dtSudentList.Clear()
            da.Fill(DataSet1.dtSudentList)
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SetReports(ByVal datasetName As String, ByVal reportName As String, ByVal bindingName As BindingSource)
        Try
            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.RefreshReport()
            _reportDatasource1.Name = datasetName
            _reportDatasource1.Value = bindingName
            ReportViewer1.LocalReport.DataSources.Add(_reportDatasource1)
            ReportViewer1.LocalReport.ReportEmbeddedResource = reportName
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            '   ReportViewer1.ResetPageSettings()
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            ReportViewer1.ZoomPercent = 100

            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
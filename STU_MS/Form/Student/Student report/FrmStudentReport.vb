Imports System.Data.SqlClient

Public Class FrmStudentReport

    Dim obj As New Method
    Private Sub FrmViewReport_StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call obj.OpenConnection()
            Dim sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY SNAME_KH ASC) AS 'ROW_NUMBER',SNAME_KH,CLASS_MONITOR_NUM,GENDER,DOB_2,GUARDIAN_VILLAGE,CLASS_OLD FROM dbo.V_STUDENT_LIST_ALL_STATUS WHERE YEAR_STUDY_OLD = N'2017-2018' AND CLASS_ID = 1"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.dtStudent.Clear()
            da.Fill(DataSet1.dtStudent)

            Call obj.SendParam("paramSchoolName", obj.GetSchoolName(), ReportViewer)
            Call obj.SendParam("paramYearStudy", FrmStudent.cboSearchYearStudy.Text, ReportViewer)
            Call obj.SendParam("paramClassName", FrmStudent.cboStuCurrentClass.Text, ReportViewer)

            obj.SetupReportView(ReportViewer)
            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ReportViewer.RefreshReport()
    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles ReportViewer.Load

    End Sub
End Class
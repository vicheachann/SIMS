Imports System.Data.SqlClient


Public Class Teacher_list
    ReadOnly obj As New Method
    Private sql As String
    Dim reportDatasource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()




    Private Sub Teacher_CV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReportViewer.RefreshReport()

        Call SELECT_V_TEACHER_LIST_ALL_STATUS()
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub SELECT_V_TEACHER_LIST_ALL_STATUS()
        Try
            Call obj.OpenConnection()
            sql = "SELECT [ROW_NUMBER],T_NAME_KH,GENDER,POSITION,DOB,SALARY_LEVEL,DATE_JOIN_ORGANIZATION,T_PHONE_LINE_1 FROM dbo.V_TEACHER_LIST_ALL_STATUS"
            cmd = New SqlCommand(Sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.V_TEACHER_LIST_ALL_STATUS.Clear()
            da.Fill(DataSet1.V_TEACHER_LIST_ALL_STATUS)

            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub



End Class
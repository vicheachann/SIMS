Public Class FrmReportStudentStatistic
    Dim obj As New Method
    Private Sub FrmReportStudentStatistic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataSet1.STU_STATISTIC.Clear()
        With FrmStudentStatistic
            For i As Integer = 0 To .dg.RowCount - 1
                DataSet1.STU_STATISTIC.Rows.Add(.dg.Rows(i).Cells(2).Value.ToString, .dg.Rows(i).Cells(3).Value.ToString, .dg.Rows(i).Cells(4).Value.ToString, .dg.Rows(i).Cells(5).Value.ToString, .dg.Rows(i).Cells(6).Value.ToString, .dg.Rows(i).Cells(7).Value.ToString, .dg.Rows(i).Cells(8).Value.ToString, .dg.Rows(i).Cells(9).Value.ToString, .dg.Rows(i).Cells(10).Value.ToString, .dg.Rows(i).Cells(11).Value.ToString, .dg.Rows(i).Cells(12).Value.ToString, .dg.Rows(i).Cells(13).Value.ToString, .dg.Rows(i).Cells(14).Value.ToString, .dg.Rows(i).Cells(15).Value.ToString, .dg.Rows(i).Cells(16).Value.ToString, .dg.Rows(i).Cells(17).Value.ToString, .dg.Rows(i).Cells(18).Value.ToString, .dg.Rows(i).Cells(19).Value.ToString, .dg.Rows(i).Cells(20).Value.ToString, .dg.Rows(i).Cells(21).Value.ToString, .dg.Rows(i).Cells(22).Value.ToString, .dg.Rows(i).Cells(23).Value.ToString)
            Next
        End With
        Call obj.SendParam("paramSchoolName", obj.GetSchoolName(), ReportViewer)
        Me.ReportViewer.RefreshReport()
        Me.ReportViewer.RefreshReport()
    End Sub
End Class
Public Class FrmReportStuResult912
    Dim obj As New Method
    Private Sub FrmReportStuResult912_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataSet1.STU_RESULT_9_12.Clear()
        With FrmStudentResult912
            For i As Integer = 0 To .dg.RowCount - 1
                DataSet1.STU_RESULT_9_12.Rows.Add(.dg.Rows(i).Cells(2).Value.ToString, .dg.Rows(i).Cells(10).Value.ToString, .dg.Rows(i).Cells(11).Value.ToString, .dg.Rows(i).Cells(13).Value.ToString, .dg.Rows(i).Cells(14).Value.ToString, .dg.Rows(i).Cells(15).Value.ToString, .dg.Rows(i).Cells(16).Value.ToString, .dg.Rows(i).Cells(3).Value.ToString, .dg.Rows(i).Cells(4).Value.ToString, .dg.Rows(i).Cells(6).Value.ToString, .dg.Rows(i).Cells(7).Value.ToString, .dg.Rows(i).Cells(7).Value.ToString, .dg.Rows(i).Cells(9).Value.ToString)
            Next
        End With
        Call obj.SendParam("paramSchoolName", obj.GetSchoolName(), ReportViewer)

        obj.SetupReportView(ReportViewer)
        Me.ReportViewer.RefreshReport()
    End Sub
End Class
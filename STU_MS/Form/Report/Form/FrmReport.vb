Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FrmReport
    Dim obj As New Method
    Dim reportId As Integer
    Dim sql As String
    Dim validate As New Validation

    Dim t As New Theme
    Dim reportDatasource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetReportName()
        ReportViewer.RefreshReport()

    End Sub

    Private Function GetSchoolName() As String
        Dim schoolName As String = ""
        Try
            obj.OpenConnection()
            cmd = New SqlCommand("SELECT TOP(1) SCHOOL_NAME_KH FROM dbo.TBL_SCHOOL_INFO", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                schoolName = dt.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return schoolName

    End Function


    Public Sub GetReportName()
        Try
            Call obj.OpenConnection()
            Dim sqlcom = New SqlCommand("Select TITLE_KH FROM TBL_REPORT_NAME where STATUS='True'", conn)
            da = New SqlDataAdapter(sqlcom)
            dt = New DataTable
            da.Fill(dt)
            ListReport.Items.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                ListReport.Items.Add(dt.Rows(i)(0).ToString())
            Next
            ListReport.Focus()
            ListReport.SetSelected(0, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetReportId() As Integer
        Dim reportID As Integer
        Try
            Dim sqlcom = New SqlCommand("SELECT ID FROM TBL_REPORT_NAME WHERE TITLE_EN=N'" & ListReport.SelectedItem.ToString() & "' OR TITLE_KH=N'" & ListReport.SelectedItem.ToString() & "' ", conn)
            da = New SqlDataAdapter(sqlcom)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                reportId = 0
            End If
            reportId = dt.Rows(0)(0).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return reportID
    End Function

    Private Sub ListReport_DoubleClick(sender As Object, e As EventArgs) Handles ListReport.DoubleClick
        lblView_Click(sender, e)
    End Sub


    Public Sub SetReport(ByVal dataset_name As String, ByVal Report_Name As String, ByVal Binding_name As BindingSource)
        Try
            ReportViewer.LocalReport.Refresh()
            ReportViewer.LocalReport.DataSources.Clear()
            ReportViewer.RefreshReport()
            reportDatasource.Name = dataset_name
            reportDatasource.Value = Binding_name
            ReportViewer.LocalReport.DataSources.Add(reportDatasource)
            ReportViewer.LocalReport.ReportEmbeddedResource = Report_Name

            ReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer.ZoomPercent = 100

            'ReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ''ReportViewer1.ResetPageSettings()
            'ReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent = 100
            'ReportViewer.ZoomPercent = 100

            ReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SendParam(ByVal param As String, ByVal val As String)
        Dim r(0) As ReportParameter
        r(0) = New ReportParameter(param, val, True)
        ReportViewer.LocalReport.SetParameters(New ReportParameter() {r(0)})
    End Sub

    Public Sub SelectTeacherMeetingAbsenceView()
        Try
            Call obj.OpenConnection()
            sql = "SELECT ROW_NUMBER() OVER(ORDER BY ORDINAL_NUMBER,T_NAME_KH ASC) AS 'ROW_NUMBER',T_NAME_KH,GENDER,POSITION,YEAR_STUDY,M_01,M_02,M_03,M_04,M_05,M_06,M_07,M_08,M_09,M_10,M_11,M_12 FROM dbo.V_TECHER_MEETING_ABSENT_MONTHLY where YEAR_STUDY = N'" & cboYearStudy.Text & "'"


            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.dtTeacherMeetingAbsence.Clear()
            da.Fill(DataSet1.dtTeacherMeetingAbsence)

            ReportViewer.RefreshReport()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub SELECT_STUDENT_LIST_ALLSTATUS_BY_CLASS()
        Try


            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub SELECT_STUDENT_LIST_ALLSTATUS_ALL_CLASS()
        Try
            Call obj.OpenConnection()
            sql = "SELECT ROW_NUMBER() OVER(ORDER BY SNAME_KH ASC) AS 'ROW_NUMBER',SNAME_KH,CLASS_MONITOR_NUM,GENDER,DOB_2,GUARDIAN_VILLAGE,CLASS_OLD FROM dbo.V_STUDENT_LIST_ALL_STATUS WHERE YEAR_STUDY_OLD = N'" & cboStuList_year.Text & "'"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.dtStudent.Clear()
            da.Fill(DataSet1.dtStudent)

            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub SELECT_V_TEACHER_LIST_ALL_STATUS()
        Try
            Call obj.OpenConnection()
            sql = "SELECT [ROW_NUMBER],T_NAME_KH,GENDER,POSITION,DOB,SALARY_LEVEL,DATE_JOIN_ORGANIZATION,T_PHONE_LINE_1 FROM dbo.V_TEACHER_LIST_ALL_STATUS"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.V_TEACHER_LIST_ALL_STATUS.Clear()
            da.Fill(DataSet1.V_TEACHER_LIST_ALL_STATUS)

            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub SELECT_V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE()
        Try
            Call obj.OpenConnection()
            sql = "SELECT YEAR_STUDY,[7] AS 'A7',G7,[8] AS 'A8',G8,[9] AS 'A9',G9,[10] AS 'A10',G10,[11] AS 'A11',G11,[12] AS 'A12',G12 FROM dbo.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE.Clear()
            da.Fill(DataSet1.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE)

            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub ListReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListReport.SelectedIndexChanged
        Try
            Select Case GetReportId()
                Case 1 'Teacher absence meeting
                    pnlYearStudyAndClass.Visible = False
                    pnlYearStudy.Visible = True
                    pnlStudentFormer.Visible = False
                    pnlViewButton.Location = New Point(493, 6)
                Case 2 'Student list
                    pnlYearStudyAndClass.Visible = True
                    pnlYearStudy.Visible = False
                    pnlStudentFormer.Visible = False
                    pnlViewButton.Location = New Point(647, 6)
                Case 5 ' Student former list
                    pnlYearStudyAndClass.Visible = False
                    pnlYearStudy.Visible = False
                    pnlStudentFormer.Visible = True
                    Me.pnlViewButton.Location = New System.Drawing.Point(689, 6)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CreateStudentListReport()
        Try
            Call obj.OpenConnection()
            sql = "SELECT ROW_NUMBER() OVER(ORDER BY SNAME_KH ASC) AS 'ROW_NUMBER',SNAME_KH,CLASS_MONITOR_NUM,GENDER,DOB_2,GUARDIAN_VILLAGE,CLASS_OLD FROM dbo.V_STUDENT_LIST_ALL_STATUS WHERE YEAR_STUDY_OLD = N'" & cboStuList_year.Text & "' AND CLASS_ID = " & cboStuList_class.SelectedValue & ""
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.dtStudent.Clear()
            da.Fill(DataSet1.dtStudent)

            Call SetReport("DataSet1", "STU_MS.rpStudentList.rdlc", bsStudentList)
            Call SendParam("paramYearStudy", cboStuList_year.Text)
            Call SendParam("paramClassName", cboStuList_class.Text)
            Call SendParam("paramSchoolName", obj.GetSchoolName())
            Call SendParam("paramProvince", obj.GetProvinceName())
            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CreateStudentFormerReport()
        Dim batch As String
        Dim firstYearStudy As String
        Try
            If (cboFirstYearStudy.Text = "ទាំងអស់" And cboBacth.Text = "ទាំងអស់") Then
                sql = "SELECT * FROM dbo.V_STUDENT_FORMER_LIST"
                batch = "ទាំងអស់"
                firstYearStudy = "ទាំងអស់"
            ElseIf (cboFirstYearStudy.Text = "ទាំងអស់" And cboBacth.Text <> "ទាំងអស់") Then
                sql = "SELECT * FROM dbo.V_STUDENT_FORMER_LIST WHERE BATCH_ID = " & cboBacth.SelectedValue & ""
                batch = cboBacth.Text
                firstYearStudy = "ទាំងអស់"
            ElseIf (cboFirstYearStudy.Text <> "ទាំងអស់" And cboBacth.Text = "ទាំងអស់") Then
                sql = "SELECT * FROM dbo.V_STUDENT_FORMER_LIST WHERE FIRST_YEAR_STUDY = N'" & cboFirstYearStudy.Text & "'"
                batch = "ទាំងអស់"
                firstYearStudy = cboFirstYearStudy.Text
            Else
                sql = "SELECT * FROM dbo.V_STUDENT_FORMER_LIST WHERE FIRST_YEAR_STUDY = N'" & cboFirstYearStudy.Text & "' AND BATCH_ID = " & cboBacth.SelectedValue & ""
                batch = cboBacth.Text
                firstYearStudy = cboFirstYearStudy.Text
            End If

            Call obj.OpenConnection()
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)

            DataSet1.dtStudentFormer.Clear()
            da.Fill(DataSet1.dtStudentFormer)

            Call SetReport("DataSet1", "STU_MS.rpStudentFormer.rdlc", bsStudentFormer)
            Call SendParam("paramSchoolName", obj.GetSchoolName())
            Call SendParam("paramProvince", obj.GetProvinceName())
            Call SendParam("paramBatch", batch)
            Call SendParam("paramFirstYearStudy", firstYearStudy)
            ReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub lblView_Click(sender As Object, e As EventArgs) Handles lblView.Click
        Try
            Dim sql As String = ""
            ReportViewer.Reset()

            Select Case GetReportId()
                Case 1 'Teacher absence meeting
                    If (cboYearStudy.Text = "") Then
                        obj.ShowMsg("សូមបញ្ចូលឆ្នាំសិក្សា", FrmWarning, "")
                        cboYearStudy.Focus()
                        Exit Sub
                    End If
                    Call SelectTeacherMeetingAbsenceView()
                    Call SetReport("DataSet1", "STU_MS.rpTeacherMeetingAbsence.rdlc", TeacherMeetingAbsence_BindingSource)
                    Call SendParam("paramYearStudy", cboYearStudy.Text)
                    ReportViewer.RefreshReport()


                Case 2  '-------- Student List --------

                    If (cboStuList_class.Text = "" Or cboStuList_year.Text = "") Then
                        obj.ShowMsg("សូមជ្រើសយកឆ្នាំសិក្សា និង ថ្នាក់ជាមុន", FrmWarning, "")
                        cboStuList_year.Focus()
                        Exit Sub
                    End If
                    Call CreateStudentListReport()
                Case 5 '--------------Student form list ------------------'
                    If (Validation.IsEmpty(cboFirstYearStudy, "ឆ្នាំសិក្សាដំបូង")) Then Exit Sub
                    If (Validation.IsEmpty(cboFirstYearStudy, "ជំនាន់")) Then Exit Sub
                    Call CreateStudentFormerReport()
                Case 3
                    'Teacher list
                    Call SELECT_V_TEACHER_LIST_ALL_STATUS()
                    Call SetReport("DataSet1", "STU_MS.rpTeacherList.rdlc", V_TEACHER_LIST_ALL_STATUS_BindingSource)

                Case 4
                    'V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE
                    Call SELECT_V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE()
                    Call SetReport("DataSet1", "STU_MS.rpStudentTotalYearStudyClass.rdlc", V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs)
                    Call SendParam("paramSchoolName", GetSchoolName())
                    ReportViewer.RefreshReport()

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub

    Private Sub cboStuList_year_DropDown(sender As Object, e As EventArgs) Handles cboStuList_year.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboStuList_year, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub

    Private Sub cboStuList_class_DropDown(sender As Object, e As EventArgs) Handles cboStuList_class.DropDown
        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboStuList_class, "CLASS_LETTER", "CLASS_ID")
    End Sub

    Private Sub d(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblView_MouseHover(sender As Object, e As EventArgs) Handles lblView.MouseHover
        t.Hover(lblView)
    End Sub

    Private Sub lblView_MouseLeave(sender As Object, e As EventArgs) Handles lblView.MouseLeave
        t.Leave(lblView)
    End Sub

    Private Sub cboStuList_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboStuList_year.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboStuList_class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboStuList_class.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboFirstYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboFirstYearStudy.DropDown
        obj.BindComboBoxWithAll("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboFirstYearStudy, "YEAR_STUDY_KH", "YEAR_ID")

    End Sub

    Private Sub cboBacth_DropDown(sender As Object, e As EventArgs) Handles cboBacth.DropDown
        obj.BindComboBoxWithAll("SELECT BATCH_ID,BATCH FROM dbo.TBL_BATCH ORDER BY CAST(BATCH AS INT) ", cboBacth, "BATCH", "BATCH_ID")
    End Sub

    Private Sub cboFirstYearStudy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboFirstYearStudy.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboBacth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboBacth.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboBacth_TextChanged(sender As Object, e As EventArgs) Handles cboBacth.TextChanged
        cboBacth.BackColor = Color.White
    End Sub

    Private Sub cboFirstYearStudy_TextChanged(sender As Object, e As EventArgs) Handles cboFirstYearStudy.TextChanged
        cboFirstYearStudy.BackColor = Color.White
    End Sub
End Class
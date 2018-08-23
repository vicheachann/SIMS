Imports System.Data.SqlClient

Public Class FrmTeacherMeetingAtt
    Dim obj As New Method


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub cboTeacherType_DropDown(sender As Object, e As EventArgs) Handles cboTeacherType.DropDown
        obj.BindComboBox("SELECT TEACHER_STATUS_ID,TEACHER_STATUS_KH FROM dbo.TBL_TEACHER_STATUS WHERE TEACHER_STATUS_ID NOT IN (2,3,6,9)", cboTeacherType, "TEACHER_STATUS_KH", "TEACHER_STATUS_ID")
    End Sub

    Private Sub cboPosition_DropDown(sender As Object, e As EventArgs) Handles cboPosition.DropDown
        obj.BindComboBox("SELECT POSITION FROM dbo.TBL_POSITION union select '<<All>>'  FROM dbo.TBL_POSITION  ", cboPosition, "POSITION", "POSITION")
        cboSearchTeacherName.Text = ""
    End Sub

    Private Sub cboYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub
    Private Sub GetMonthName()
        cboMonth.SelectedValue = dtDate.Value.Month
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If cboPosition.Text = "" Or cboTeacherType.Text = "" Then
            obj.ShowMsg("សូមជ្រើសរើសស្ថានភាពបុគ្គលិក និងតួនាទី", FrmWarning, "Windows Ding.wav")
            cboPosition.Focus()
            Exit Sub
        End If

        If cboPosition.Text = "<<All>>" Then
            cmd = New SqlCommand("SELECT ROW_NUMBER() OVER(ORDER BY P.ORDINAL_NUMBER ASC) AS 'ROW_NUMBER',T.TEACHER_ID, T.T_NAME_KH, T.GENDER, P.POSITION, T.T_PHONE_LINE_1 FROM dbo.TBL_TEACHER AS T INNER JOIN dbo.TBL_POSITION AS P ON T.POSITION_ID = P.POSITION_ID WHERE  T.TEACHER_STATUS_ID = " & cboTeacherType.SelectedValue & "", conn)
        Else
            cmd = New SqlCommand("SELECT ROW_NUMBER() OVER(ORDER BY P.ORDINAL_NUMBER ASC) AS 'ROW_NUMBER',T.TEACHER_ID, T.T_NAME_KH, T.GENDER, P.POSITION, T.T_PHONE_LINE_1 FROM dbo.TBL_TEACHER AS T INNER JOIN dbo.TBL_POSITION AS P ON T.POSITION_ID = P.POSITION_ID WHERE  T.TEACHER_STATUS_ID = " & cboTeacherType.SelectedValue & " and  P.POSITION = N'" & cboPosition.Text & "'", conn)

        End If

        Try
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            dgAttendance.Rows.Clear()

            For i As Integer = 0 To dt.Rows.Count - 1
                dgAttendance.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString(), False, False, False)
            Next

            'After add data to gridview, we perform count
            Call CountAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearCountArea()
        txtLow.Text = "0"
        txtLowFemale.Text = "0"
        txtNoLow.Text = "0"
        txtNoLowFemale.Text = "0"
        txtJoin.Text = "0"
        txtJoinFemale.Text = "0"
        txtTotal.Text = "0"
        txtTotalFemale.Text = "0"
    End Sub

    Private Sub cboName_DropDown(sender As Object, e As EventArgs) Handles cboSearchTeacherName.DropDown
        If cboTeacherType.Text = "" Or cboPosition.Text = "" Then
            Exit Sub
        End If

        If cboPosition.Text = "<<All>>" Then
            obj.BindComboBox("SELECT TEACHER_ID,T_NAME_KH from dbo.TBL_TEACHER where TEACHER_STATUS_ID = " & cboTeacherType.SelectedValue & "", cboSearchTeacherName, "T_NAME_KH", "TEACHER_ID")
        Else
            obj.BindComboBox("SELECT TEACHER_ID,T_NAME_KH from dbo.TBL_TEACHER AS T INNER JOIN dbo.TBL_POSITION AS P ON T.POSITION_ID = P.POSITION_ID WHERE TEACHER_STATUS_ID = " & cboTeacherType.SelectedValue & " AND P.POSITION = N'" & cboPosition.Text & "'", cboSearchTeacherName, "T_NAME_KH", "TEACHER_ID")
        End If

    End Sub

    Private Sub cbCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbCheckAll.CheckedChanged

        If dgAttendance.Rows.Count <= 0 Then
            obj.ShowMsg("សូមបញ្ជូលឈ្មោះអ្នកចូលរួមប្រជុំជាមុន", FrmWarning, "Error.wav")
            cboTeacherType.Focus()
            Exit Sub
        End If

        If cbCheckAll.Checked = True Then
            For Each rows As DataGridViewRow In dgAttendance.Rows
                rows.Cells(6).Value = False
                rows.Cells(7).Value = False
                rows.Cells(8).Value = True
            Next
            Call CountAll()
        End If
        If cbCheckAll.Checked = False Then
            For Each rows As DataGridViewRow In dgAttendance.Rows
                rows.Cells(6).Value = False
                rows.Cells(7).Value = False
                rows.Cells(8).Value = False
            Next
            Call CountAll()
        End If
    End Sub

    'load
    Private Sub FrmTeacherMeetingAtt_Load(sender As Object, e As EventArgs) Handles Me.Load
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboSummaryYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
        obj.BindComboBox("SELECT MONTHLY_ID,MONTHLY FROM dbo.TBL_MONTHLY", cboMonth, "MONTHLY", "MONTHLY_ID")

        cboMonth.SelectedValue = DateTime.Today.Month

        cboSearchYearStudy_DropDown(sender, e)

        dgAttendance.Rows.Clear()
        Call PopulateSearchGirdView()
        Call PopulateSummaryMeetingAttendance(cboSummaryYearStudy.Text)

    End Sub

    Private Sub PopulateSummaryMeetingAttendance(ByVal yearStudy)
        dgAttSummary.AutoGenerateColumns = False
        obj.BindDataGridView("SELECT ROW_NUMBER() OVER(ORDER BY ORDINAL_NUMBER,T_NAME_KH ASC) AS 'ROW_NUMBER',T_NAME_KH,GENDER,POSITION,YEAR_STUDY,M_01,M_02,M_03,M_04,M_05,M_06,M_07,M_08,M_09,M_10,M_11,M_12 FROM dbo.V_TECHER_MEETING_ABSENT_MONTHLY WHERE YEAR_STUDY = N'" & cboSummaryYearStudy.Text & "'", dgAttSummary)
    End Sub


    Private Sub dtDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged
        Call GetMonthName()
    End Sub

    Private Sub CountAll()

        Dim low As Integer = 0
        Dim lowFemale As Integer = 0
        Dim nolow As Integer = 0
        Dim noLowFemale As Integer = 0
        Dim join As Integer = 0
        Dim joinFemale As Integer = 0
        Dim totalFemale As Integer = 0


        For Each row As DataGridViewRow In dgAttendance.Rows
            'Count Low 
            If row.Cells(6).Value = True Then
                low += 1
            End If
            'Count Low Female
            If (String.Compare(row.Cells(3).Value.ToString, "ស្រី", StringComparison.InvariantCultureIgnoreCase) = 0 And row.Cells(6).Value = True) Then
                lowFemale += 1
            End If
            'Count no low
            If row.Cells(7).Value = True Then
                nolow += 1
            End If
            'Count no low girl
            If (String.Compare(row.Cells(3).Value.ToString, "ស្រី", StringComparison.InvariantCultureIgnoreCase) = 0 And row.Cells(7).Value = True) Then
                noLowFemale += 1
            End If
            'Count join
            If row.Cells(8).Value = True Then
                join += 1
            End If
            'Count join female
            If (String.Compare(row.Cells(3).Value.ToString, "ស្រី", StringComparison.InvariantCultureIgnoreCase) = 0 And row.Cells(8).Value = True) Then
                joinFemale += 1
            End If
            'Count total female
            If (String.Compare(row.Cells(3).Value.ToString, "ស្រី", StringComparison.InvariantCultureIgnoreCase) = 0) Then
                totalFemale += 1
            End If
        Next

        'Clear first and set value again
        Call ClearCountArea()

        txtLow.Text = low.ToString
        txtLowFemale.Text = lowFemale.ToString()
        txtNoLow.Text = nolow.ToString
        txtNoLowFemale.Text = noLowFemale.ToString
        txtJoin.Text = join.ToString
        txtJoinFemale.Text = joinFemale.ToString
        txtTotal.Text = dgAttendance.RowCount.ToString
        txtTotalFemale.Text = totalFemale.ToString
    End Sub


    Private Sub datagridview_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgAttendance.CurrentCellDirtyStateChanged
        'datagridview editing controls commit their values when they lose focus
        If dgAttendance.IsCurrentCellDirty Then
            dgAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Function ValidateControl() As Boolean
        Dim validateState As Boolean

        If txtMeetingTopic.Text = "" Then
            txtMeetingTopic.BackColor = Color.LavenderBlush
            txtMeetingTopic.Focus()
            validateState = False
        Else
            validateState = True
        End If


        If cboMonth.Text = "" Then
            cboMonth.BackColor = Color.LavenderBlush
            cboMonth.Focus()
            validateState = False
        Else
            validateState = True
        End If

        If cboYearStudy.Text = "" Then
            cboYearStudy.BackColor = Color.LavenderBlush
            cboYearStudy.Focus()
            validateState = False
        Else
            validateState = True
        End If

        Return validateState
    End Function

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cboMonth.Text = "" Or cboYearStudy.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
            ValidateControl()
            If ValidateControl() = False Then
                Exit Sub
            End If
            Exit Sub
        End If

        If dgAttendance.Rows.Count <= 0 Then
            obj.ShowMsg("សូមបញ្ជូលឈ្មោះអ្នកចូលរួមប្រជុំ", FrmWarning, "Error.wav")
            Exit Sub
        End If


        'Insert master 
        obj.Insert_1("INSERT INTO dbo.TBL_TEACHER_ABSENT_MEETING_MASTER(DATE_NOTE,DATE_MEETING,MEETING_TOPIC,YEAR_STUDY,MONTHLY_ID,TOTAL_STAFF,TOTAL_ABSENT_LAW,TOTAL_ABSENT_NO_LAW,TOTAL_ALL_ABSENT)VALUES(GETDATE(),'" & dtDate.Text & "',N'" & txtMeetingTopic.Text & "',N'" & cboYearStudy.Text & "'," & cboMonth.SelectedValue & "," & txtTotal.Text & "," & txtLow.Text & "," & txtNoLow.Text & "," & txtJoin.Text & ")")
        'Insert detail
        For i As Integer = 0 To dgAttendance.RowCount - 1
            obj.Insert_1("INSERT INTO  dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS(MEETING_ID,TEACHER_ID,ABSENT_STATUS_ID,[DESCRIPTION])VALUES((SELECT MAX(MEETING_ID) FROM dbo.TBL_TEACHER_ABSENT_MEETING_MASTER)," & dgAttendance.Rows(i).Cells(1).Value & "," & CheckAttandanceStatus(i) & ",N'" & dgAttendance.Rows(i).Cells(1).Value & "')")
        Next

        Call obj.ShowMsg("ទិន្នន័យរក្សាទុកបានសម្រេច!", FrmMessageSuccess, "")

        Call PopulateSearchGirdView()
    End Sub

    Private Sub txtMeetingTopic_TextChanged(sender As Object, e As EventArgs) Handles txtMeetingTopic.TextChanged
        txtMeetingTopic.BackColor = Color.White
    End Sub

    Private Sub cboMonth_TextChanged(sender As Object, e As EventArgs) Handles cboMonth.TextChanged
        cboMonth.BackColor = Color.White
    End Sub


    Private Sub cboYearStudy_TextChanged(sender As Object, e As EventArgs) Handles cboYearStudy.TextChanged
        cboYearStudy.BackColor = Color.White
    End Sub

    Private Function CheckAttandanceStatus(ByVal row) As Integer
        Dim status As Integer

        If dgAttendance.Rows(row).Cells(7).Value = True Then
            status = 3
        ElseIf dgAttendance.Rows(row).Cells(6).Value = True Then
            status = 2
        Else
            status = 1
        End If
        Return status
    End Function

    Private Sub cboSearchYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboSearchYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboSearchYearStudy, "YEAR_STUDY_KH", "YEAR_ID")

    End Sub
    Private Sub PopulateSearchGirdView()
        Try
            obj.BindDataGridView("SELECT MEETING_ID,A.DATE_MEETING,M.MONTHLY,A.YEAR_STUDY FROM dbo.TBL_TEACHER_ABSENT_MEETING_MASTER AS A INNER JOIN dbo.TBL_MONTHLY AS M ON A.MONTHLY_ID = M.MONTHLY_ID where A.YEAR_STUDY = N'" & cboSearchYearStudy.Text & "'", dgSearch)

            dgSearch.Columns(0).Visible = False
            dgSearch.Columns(1).HeaderText = "កាលបរិច្ឆេទ"
            dgSearch.Columns(2).HeaderText = "ប្រចាំខែ"
            dgSearch.Columns(3).HeaderText = "ឆ្នាំសិក្សា"

            dgSearch.Columns(1).Width = 90
            dgSearch.Columns(2).Width = 75
            dgSearch.Columns(3).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cboSearchYearStudy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchYearStudy.SelectedIndexChanged
        Call PopulateSearchGirdView()

    End Sub

    Private Sub PanelEx2_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub


    Private Sub ClearAll()
        txtMeetingTopic.Clear()
        cboYearStudy.Text = ""
        dtDate.Text = Date.Today
        GetMonthName()
        txtTotal.Text = "0"
        txtLow.Text = "0"
        txtNoLow.Text = "0"
        txtJoin.Text = "0"
        txtLowFemale.Text = "0"
        txtNoLowFemale.Text = "0"
        txtJoinFemale.Text = "0"
        txtTotalFemale.Text = "0"
        txtMeetingID.Clear()
        dgAttendance.Rows.Clear()
    End Sub

    Private Sub SelectCounted(ByVal meetingId)
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT COUNT(CASE WHEN A.ABSENT_STATUS_ID = 2 THEN 1 END) AS 'LOW',COUNT(CASE WHEN A.ABSENT_STATUS_ID = 2 AND T.GENDER = N'ស្រី' THEN 1 END) AS 'LOW_FEMALE',COUNT(CASE WHEN A.ABSENT_STATUS_ID = 3 THEN 1 END) AS 'NO_LOW',COUNT(CASE WHEN A.ABSENT_STATUS_ID = 3 AND T.GENDER = N'ស្រី' THEN 1 END) AS 'NO_LOW_FEMALE', COUNT(CASE WHEN A.ABSENT_STATUS_ID = 1 THEN 1 END) AS 'JOIN',COUNT(CASE WHEN A.ABSENT_STATUS_ID = 1 AND T.GENDER = N'ស្រី' THEN 1 END) AS 'JOIN_FEMALE',COUNT(A.ABSENT_STATUS_ID) AS 'TOTAL_STAFF',COUNT(CASE WHEN  T.GENDER = N'ស្រី' THEN 1 END) AS 'TOTAL_FEMALE' FROM  dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS AS A INNER JOIN dbo.TBL_TEACHER AS T ON A.TEACHER_ID = T.TEACHER_ID  AND A.MEETING_ID = " & meetingId & "", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                txtLow.Text = If(IsDBNull(dt.Rows(0)(0).ToString), "0", dt.Rows(0)(0).ToString)
                txtLowFemale.Text = If(IsDBNull(dt.Rows(0)(1).ToString), "0", dt.Rows(0)(1).ToString)
                txtNoLow.Text = If(IsDBNull(dt.Rows(0)(2).ToString), "0", dt.Rows(0)(2).ToString)
                txtNoLowFemale.Text = If(IsDBNull(dt.Rows(0)(3).ToString), "0", dt.Rows(0)(3).ToString)
                txtJoin.Text = If(IsDBNull(dt.Rows(0)(4).ToString), "0", dt.Rows(0)(4).ToString)
                txtJoinFemale.Text = If(IsDBNull(dt.Rows(0)(5).ToString), "0", dt.Rows(0)(5).ToString)
                txtTotal.Text = If(IsDBNull(dt.Rows(0)(6).ToString), "0", dt.Rows(0)(6).ToString)
                txtTotalFemale.Text = If(IsDBNull(dt.Rows(0)(7).ToString), "0", dt.Rows(0)(7).ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SelectMasterDetail(ByVal meetingId)
        Try
            Call ClearAll()
            'Select  master
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT M.MEETING_ID,M.MEETING_TOPIC,M.YEAR_STUDY,M.DATE_MEETING,MON.MONTHLY FROM dbo.TBL_TEACHER_ABSENT_MEETING_MASTER AS M INNER JOIN dbo.TBL_MONTHLY AS MON ON M.MONTHLY_ID = MON.MONTHLY_ID WHERE M.MEETING_ID = " & meetingId & "", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                txtMeetingID.Text = If(IsDBNull(dt.Rows(0)(0).ToString), "", dt.Rows(0)(0).ToString)
                txtMeetingTopic.Text = If(IsDBNull(dt.Rows(0)(1).ToString), "", dt.Rows(0)(1).ToString)
                cboYearStudy.Text = If(IsDBNull(dt.Rows(0)(2).ToString), "", dt.Rows(0)(2).ToString)
                dtDate.Text = If(IsDBNull(dt.Rows(0)(3).ToString), "", dt.Rows(0)(3).ToString)
                cboMonth.Text = If(IsDBNull(dt.Rows(0)(4).ToString), "", dt.Rows(0)(4).ToString)
                Call SelectCounted(meetingId)
            End If


            'Select  detail
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT ROW_NUMBER() OVER(ORDER BY P.ORDINAL_NUMBER ASC) AS 'ROWNUM',T.TEACHER_ID, T.T_NAME_KH, T.GENDER, P.POSITION, T.T_PHONE_LINE_1, D.ABSENT_STATUS_ID, D.DESCRIPTION, D.RECORD_ID FROM dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS AS D INNER JOIN dbo.TBL_TEACHER AS T ON D.TEACHER_ID = T.TEACHER_ID INNER JOIN dbo.TBL_POSITION AS P ON T.POSITION_ID = P.POSITION_ID WHERE D.MEETING_ID = " & meetingId & "", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    dgAttendance.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString(), CheckIfLow(dt.Rows(i)(6).ToString()), CheckIfNoLow(dt.Rows(i)(6).ToString()), CheckIfJoin(dt.Rows(i)(6).ToString()), dt.Rows(i)(7).ToString(), dt.Rows(i)(8).ToString())
                Next
            End If

            lblNew.Enabled = True
            btnSave.Enabled = False
            lblUpdate.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function CheckIfJoin(ByVal absentStatusID) As Boolean
        If absentStatusID = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function CheckIfNoLow(ByVal absentStatusID) As Boolean
        If absentStatusID = 3 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckIfLow(ByVal absentStatusID) As Boolean
        If absentStatusID = 2 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub dgSearch_SelectionChanged(sender As Object, e As EventArgs) Handles dgSearch.SelectionChanged
        Try
            Call SelectMasterDetail(dgSearch.SelectedCells(0).Value)
        Catch ex As Exception
            'Prevent exception first load
        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Call ClearAll()
        btnSave.Enabled = True
        lblUpdate.Enabled = False
        txtMeetingTopic.Focus()
    End Sub

    Private Sub cboSearchName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchTeacherName.SelectedIndexChanged
        Call Search()
    End Sub

    Private Sub Search()
        Try
            dgAttendance.ClearSelection()

            For i As Integer = 0 To dgAttendance.Rows.Count - 1
                If dgAttendance.Rows(i).Cells(2).Value.ToString = cboSearchTeacherName.Text Then
                    dgAttendance.CurrentCell = dgAttendance.Rows(i).Cells(2)
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub lblClearDG_Click(sender As Object, e As EventArgs) Handles lblClearDG.Click
        Try
            dgAttendance.Rows.Clear()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub lblRemove_Click(sender As Object, e As EventArgs) Handles lblRemove.Click
        If txtMeetingID.Text = "" Then
            Try
                If dgAttendance.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In dgAttendance.SelectedRows
                        dgAttendance.Rows.Remove(row)
                    Next

                    Call CountAll()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                If dgAttendance.Rows.Count > 0 Then
                    obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                    If USER_CLICK_OK = True Then
                        Call obj.Delete("DELETE FROM dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS WHERE RECORD_ID = " & dgAttendance.SelectedCells(10).Value & "")
                        Call SelectMasterDetail(dgSearch.SelectedCells(0).Value)
                        Call CountAll()

                        'UPDATE MASTER
                        Call obj.Update_1("UPDATE dbo.TBL_TEACHER_ABSENT_MEETING_MASTER SET TOTAL_STAFF = " & txtTotal.Text & ", TOTAL_ABSENT_LAW = " & txtLow.Text & " ,TOTAL_ABSENT_NO_LAW = " & txtNoLow.Text & " ,TOTAL_ALL_ABSENT = " & txtJoin.Text & " WHERE MEETING_ID = " & txtMeetingID.Text & "")

                        USER_CLICK_OK = False
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If




    End Sub

    Private Sub btnDeleteMaster_Click(sender As Object, e As EventArgs) Handles lblDeleteMaster.Click
        Try
            obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then
                Call obj.Delete_1("DELETE FROM dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS WHERE MEETING_ID = " & txtMeetingID.Text & "")
                Call obj.Delete_1("DELETE FROM dbo.TBL_TEACHER_ABSENT_MEETING_MASTER WHERE MEETING_ID = " & txtMeetingID.Text & "")

                Call obj.ShowMsg("ទិន្នន័យត្រូវបានលុប", FrmMessageSuccess, "")
                Call SelectMasterDetail(dgSearch.SelectedCells(0).Value)
                'Update Search DG
                Call PopulateSearchGirdView()

                USER_CLICK_OK = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        Try
            obj.ShowMsg("តើអ្នកចង់កែរែប្ទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then
                If cboMonth.Text = "" Or cboYearStudy.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                    ValidateControl()
                    If ValidateControl() = False Then
                        Exit Sub
                    End If
                    Exit Sub
                End If

                If dgAttendance.Rows.Count <= 0 Then
                    obj.ShowMsg("សូមបញ្ជូលឈ្មោះអ្នកចូលរួមប្រជុំ", FrmWarning, "Error.wav")
                    Exit Sub
                End If


                'Update detail
                For i As Integer = 0 To dgAttendance.RowCount - 1
                    obj.Update_1("UPDATE dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS SET ABSENT_STATUS_ID = " & CheckAttandanceStatus(i) & " ,[DESCRIPTION] = N'" & dgAttendance.Rows(i).Cells(9).Value & "' WHERE  RECORD_ID = " & dgAttendance.Rows(i).Cells(10).Value & " AND MEETING_ID = " & txtMeetingID.Text & " AND TEACHER_ID = " & dgAttendance.Rows(i).Cells(1).Value & "")
                Next
                'Update master
                Call obj.Update_1("UPDATE dbo.TBL_TEACHER_ABSENT_MEETING_MASTER SET TOTAL_ABSENT_LAW =(SELECT COUNT(CASE WHEN ABSENT_STATUS_ID = 2 THEN 1 END) FROM dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS WHERE MEETING_ID = " & txtMeetingID.Text & "), TOTAL_ABSENT_NO_LAW =(SELECT COUNT(CASE WHEN ABSENT_STATUS_ID = 3 THEN 1 END) FROM dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS WHERE MEETING_ID = " & txtMeetingID.Text & "),TOTAL_ALL_ABSENT = (SELECT COUNT(CASE WHEN ABSENT_STATUS_ID = 1 THEN 1 END) FROM dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS WHERE MEETING_ID = " & txtMeetingID.Text & "),TOTAL_STAFF = (SELECT COUNT(ABSENT_STATUS_ID) FROM dbo.TBL_TEACHER_ABSENT_MEETING_DETAILS WHERE MEETING_ID = " & txtMeetingID.Text & ") WHERE MEETING_ID = " & txtMeetingID.Text & "")

                Call obj.ShowMsg("កែប្រែបានជោគជ័យ", FrmMessageSuccess, "success.wav")
                Call SelectMasterDetail(txtMeetingID.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub PopulateFilterAttandance(ByVal absenceStatus)
        'select detail
        Call obj.OpenConnection()
        If absenceStatus = "<<All>>" Then
            cmd = New SqlCommand("SELECT  ROW_NUMBER() OVER(ORDER BY p.ordinal_number asc) as 'ROW_NUMBER',t.teacher_id, t.t_name_kh, t.gender, p.position, t.t_phone_line_1, d.absent_status_id, d.description, d.record_id FROM dbo.tbl_teacher_absent_meeting_details as d inner join dbo.tbl_teacher as t on d.teacher_id = t.teacher_id inner join dbo.tbl_position as p on t.position_id = p.position_id INNER JOIN dbo.TBL_ABSENT_STATUS AS S ON D.ABSENT_STATUS_ID = S.ABSENT_STATUS_ID  where d.meeting_id = " & dgSearch.SelectedCells(0).Value & "", conn)
        Else
            cmd = New SqlCommand("SELECT  ROW_NUMBER() OVER(ORDER BY p.ordinal_number asc) as 'ROW_NUMBER',t.teacher_id, t.t_name_kh, t.gender, p.position, t.t_phone_line_1, d.absent_status_id, d.description, d.record_id FROM dbo.tbl_teacher_absent_meeting_details as d inner join dbo.tbl_teacher as t on d.teacher_id = t.teacher_id inner join dbo.tbl_position as p on t.position_id = p.position_id INNER JOIN dbo.TBL_ABSENT_STATUS AS S ON D.ABSENT_STATUS_ID = S.ABSENT_STATUS_ID  where d.meeting_id = " & dgSearch.SelectedCells(0).Value & " and S.ABSENT_STATUS  = N'" & absenceStatus & "' ", conn)
        End If


        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        dgAttendance.Rows.Clear()

        If dt.Rows.Count > 0 Then

            For i As Integer = 0 To dt.Rows.Count - 1
                dgAttendance.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString(), CheckIfLow(dt.Rows(i)(6).ToString()), CheckIfNoLow(dt.Rows(i)(6).ToString()), CheckIfJoin(dt.Rows(i)(6).ToString()), dt.Rows(i)(7).ToString(), dt.Rows(i)(8).ToString())

            Next
        End If
    End Sub






    Private Sub cboSummaryYearStudy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSummaryYearStudy.SelectedIndexChanged
        Call PopulateSummaryMeetingAttendance(cboSummaryYearStudy.Text)
    End Sub

    Private Sub txtSearchInSumary_TextChanged(sender As Object, e As EventArgs) Handles txtSearchInSumary.TextChanged
        dgAttSummary.AutoGenerateColumns = False
        obj.BindDataGridView("SELECT ROW_NUMBER() OVER(ORDER BY ORDINAL_NUMBER,T_NAME_KH ASC) AS 'ROW_NUMBER',T_NAME_KH,GENDER,POSITION,YEAR_STUDY,M_01,M_02,M_03,M_04,M_05,M_06,M_07,M_08,M_09,M_10,M_11,M_12 FROM dbo.V_TECHER_MEETING_ABSENT_MONTHLY WHERE YEAR_STUDY = N'" & cboSummaryYearStudy.Text & "' AND T_NAME_KH LIKE N'%" & txtSearchInSumary.Text & "%'", dgAttSummary)
    End Sub

    Private CheckColIndex As Integer = 3

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAttendance.CellContentClick

        Dim checkboxIndexes As New List(Of Integer)
        checkboxIndexes.Add(dgAttendance.Columns(6).Index)
        checkboxIndexes.Add(dgAttendance.Columns(7).Index)
        checkboxIndexes.Add(dgAttendance.Columns(8).Index)


        Try
            If checkboxIndexes.Contains(e.ColumnIndex) Then
                'check for false value because event occurs before row is validated
                If dgAttendance.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                    For Each index In checkboxIndexes
                        If index <> e.ColumnIndex Then
                            dgAttendance.Rows(e.RowIndex).Cells(index).Value = False
                        End If
                    Next
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSearch.CellClick
        Call SelectMasterDetail(dgSearch.SelectedCells(0).Value)
    End Sub

    Private Sub dgAttendance_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgAttendance.CellValueChanged
        If txtMeetingID.Text = "" Then
            Call CountAll()
        End If


    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtTotalFemale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalFemale.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtJoinFemale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJoinFemale.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtJoin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJoin.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtNoLowFemale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoLowFemale.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtNoLow_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoLow.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtLow_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLow.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtLowFemale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLowFemale.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboSearchYearStudy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSearchYearStudy.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboTeacherType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTeacherType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPosition.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboSearchTeacherName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSearchTeacherName.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboMonth.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboYearStudy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboYearStudy.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboAbenceStatusType_DropDown(sender As Object, e As EventArgs) Handles cboAbenceStatusType.DropDown
        obj.BindComboBox("SELECT ABSENT_STATUS FROM dbo.TBL_ABSENT_STATUS union select '<<All>>'  FROM dbo.TBL_ABSENT_STATUS", cboAbenceStatusType, "ABSENT_STATUS", "ABSENT_STATUS")
    End Sub



    Private Sub lblFilterDataGridView_Click(sender As Object, e As EventArgs) Handles lblFilterDataGridView.Click
        Call PopulateFilterAttandance(cboAbenceStatusType.Text)
    End Sub

    Private Sub dtDate_MouseEnter(sender As Object, e As EventArgs) Handles dtDate.MouseEnter
        GetMonthName()

    End Sub
End Class
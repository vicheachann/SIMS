Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class FrmStudentAlumini
    Dim obj As New Method
    Dim ValidateState As Boolean
    Dim t As New Theme
    Dim cboStudentDropped As Boolean = False
    Dim cboTeacherDropped As Boolean = False
    Dim teacherID As Integer = 0

#Region "Shadow effect"
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW
            Return cParam
        End Get
    End Property

#End Region

    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles lblSave.MouseHover
        frm_teacher.SetHoverStyle(lblSave)
    End Sub

    Private Sub btn_update_MouseHover(sender As Object, e As EventArgs) Handles lblUpdate.MouseHover
        frm_teacher.SetHoverStyle(lblUpdate)
    End Sub

    Private Sub btn_remove_MouseHover(sender As Object, e As EventArgs) Handles lblDelete.MouseHover
        frm_teacher.SetHoverStyle(lblDelete)
    End Sub

    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles lblSave.MouseLeave
        frm_teacher.SetLeaveStyle(lblSave)
    End Sub

    Private Sub btn_update_MouseLeave(sender As Object, e As EventArgs) Handles lblUpdate.MouseLeave
        frm_teacher.SetLeaveStyle(lblUpdate)
    End Sub

    Private Sub btn_remove_MouseLeave(sender As Object, e As EventArgs) Handles lblDelete.MouseLeave
        frm_teacher.SetLeaveStyle(lblDelete)
    End Sub
    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.ResizeRedraw = True
            txtAdvancedSearch.SetWaterMark("ស្វែងរក...")

            cboSearchByYear_DropDown(sender, e)
            cboTeacher_DropDown(sender, e)
            Call SelectSearch()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("Loading error !", FrmMessageError, _ErrorSound)
        End Try
    End Sub










































    Private Sub cboStudent_Dropdown(sender As Object, e As EventArgs) Handles cboStudent.DropDown
        cboStudentDropped = True
        obj.BindComboBox("SELECT STUDENT_ID,SNAME_KH FROM dbo.TBS_STUDENT_INFO_FORMER", cboStudent, "SNAME_KH", "STUDENT_ID")
    End Sub

    Private Sub cboTeacher_DropDown(sender As Object, e As EventArgs) Handles cboTeacher.DropDown

        obj.BindComboBox("select  TEACHER_ID,T_NAME_KH from dbo.TBL_TEACHER", cboTeacher, "T_NAME_KH", "TEACHER_ID")
    End Sub

    Private Sub cbo_position_DropDown(sender As Object, e As EventArgs) Handles cboPosition.DropDown
        obj.BindComboBox("select OCCUPATION_ID,OCCUPATION_KH from dbo.TBL_OCCUPATION", cboPosition, "OCCUPATION_KH", "OCCUPATION_ID")

    End Sub

    Private Sub lbl_position_Click(sender As Object, e As EventArgs) Handles lbl_position.Click
        frm_occupation.ShowDialog()
    End Sub
    Private Sub CalculationAmount()
        Try
            Dim r As Decimal = 0
            Dim d As Decimal = 0

            For i As Integer = 0 To dgDetail.RowCount - 1
                r += Convert.ToDecimal(dgDetail.Rows(i).Cells(6).Value)
                d += Convert.ToDecimal(dgDetail.Rows(i).Cells(5).Value)
            Next

            txtAmountUSD.Text = d.ToString()
            txtAmountKHR.Text = r.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub lblInsert_Click(sender As Object, e As EventArgs) Handles lblInsert.Click
        Try
            'Empty control
            If (Validation.IsEmpty(cboStudent, "សិស្ស")) Then Exit Sub
            If (Validation.IsEmpty(cboPosition, "មុខដំណែង")) Then Exit Sub

            'Existed student

            For Each row As DataGridViewRow In dgDetail.Rows
                If cboStudent.SelectedValue = row.Cells(1).Value Then
                    obj.ShowMsg("ឈ្មោះនេះត្រូវបានបញ្ចូលរួចរាល់", FrmWarning, _WarningSound)
                    Exit Sub
                End If
            Next

            'Null value replacement
            If txtSponserAmountUSDD.Text = "" Then
                txtSponserAmountUSDD.Text = 0
            End If
            If txtSponserAmountKHR.Text = "" Then
                txtSponserAmountKHR.Text = 0
            End If

            If (txtAlumniID.Text <> "") Then
                obj.ShowMsg("តើអ្នកចង់បញ្ចូលសិស្សថ្មីដែលឬទេ ?", FrmMessageQuestion, _ShowMessageSound)
                If USER_CLICK_OK = True Then
                    obj.Insert("INSERT INTO dbo.TBS_STUDENT_ALUMNI_DETAILS (ALUMNI_ID,STUDENT_ID,POSITION_ID,SPONSOR_US,SPONSOR_KH,REMARK)VALUES(" & txtAlumniID.Text & "," & cboStudent.SelectedValue & "," & cboPosition.SelectedValue & "," & txtSponserAmountUSDD.Text & "," & txtSponserAmountKHR.Text & ",NULL)")
                    Call Selection()
                End If
            Else
                dgDetail.Rows.Add("", cboStudent.SelectedValue, cboStudent.Text, cboPosition.SelectedValue, cboPosition.Text, txtSponserAmountUSDD.Text, txtSponserAmountKHR.Text)
            End If

            lblDetailNew_Click(sender, e)
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចបញ្ចូលទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try

    End Sub

    Private Function ValidateControl_detail() As Boolean
        'student name
        If cboStudent.Text = "" Then
            cboStudent.BackColor = Color.LavenderBlush
            cboStudent.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'position
        If cboPosition.Text = "" Then
            cboPosition.BackColor = Color.LavenderBlush
            cboPosition.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If


        Return ValidateState
    End Function

    Private Function ValidateControl_master() As Boolean
        'teacher name
        If cboTeacher.Text = "" Then
            cboTeacher.BackColor = Color.LavenderBlush
            cboTeacher.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If



        Return ValidateState
    End Function

    Private Sub cbo_position_TextChanged(sender As Object, e As EventArgs) Handles cboPosition.TextChanged
        cboPosition.BackColor = Color.White
    End Sub

    Private Sub cbo_student_TextChanged(sender As Object, e As EventArgs) Handles cboStudent.TextChanged
        cboStudent.BackColor = Color.White
    End Sub



    Private Sub dgDetail_SelectionChanged(sender As Object, e As EventArgs) Handles dgDetail.SelectionChanged


        Try
            If (dgDetail.SelectedRows.Count = 0) Then
                Call ClearDetail()
                Exit Sub
            Else
                Call ClearDetail()

                lblEdit.Enabled = True
                lblRemove.Enabled = True
                lblInsert.Enabled = False

                cboStudent.Text = dgDetail.SelectedCells(2).Value
                cboPosition.Text = dgDetail.SelectedCells(4).Value
                txtSponserAmountUSDD.Text = dgDetail.SelectedCells(5).Value
                txtSponserAmountKHR.Text = dgDetail.SelectedCells(6).Value
            End If

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("បញ្ហាក្នុងការទាញទិន្នន័យ", FrmMessageError, _ErrorSound)
        End Try
    End Sub
    Private Sub ClearDetail()
        cboStudent.Text = ""
        cboPosition.Text = ""
        txtSponserAmountKHR.Text = "0"
        txtSponserAmountUSDD.Text = "0"
    End Sub

    Private Sub lblEdit_Click(sender As Object, e As EventArgs) Handles lblEdit.Click
        Try
            If dgDetail.SelectedRows.Count > 0 Then

                'Empty control
                If (Validation.IsEmpty(cboStudent, "សិស្ស")) Then Exit Sub
                If (Validation.IsEmpty(cboPosition, "មុខដំណែង")) Then Exit Sub


                'Existed student
                For Each row As DataGridViewRow In dgDetail.Rows
                    If cboStudent.SelectedValue = dgDetail.SelectedRows(0).Cells(1).Value Then
                        'Continue do nothing 
                    ElseIf cboStudent.SelectedValue = row.Cells(1).Value Then
                        obj.ShowMsg("ឈ្មោះនេះត្រូវបានបញ្ចូលរួចរាល់", FrmWarning, _WarningSound)
                        Exit Sub
                    End If
                Next

                'Null value replacement 
                If txtSponserAmountUSDD.Text = "" Then
                    txtSponserAmountUSDD.Text = 0
                End If
                If txtSponserAmountKHR.Text = "" Then
                    txtSponserAmountKHR.Text = 0
                End If



                If (txtAlumniID.Text <> "") Then 'Database record
                    obj.ShowMsg("តើអ្នកចង់កែប្រែទិន្នន័យនេះដែលឬទេ?", FrmMessageQuestion, _ShowMessageSound)
                    If USER_CLICK_OK = True Then

                        If (cboStudentDropped = False) Then
                            cboStudent_Dropdown(sender, e)
                            cboStudent.SelectedValue = dgDetail.SelectedCells(1).Value
                        End If

                        Dim positionID As String = obj.GetID("SELECT OCCUPATION_ID FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_KH = N'" & cboPosition.Text & "'")
                        obj.Update("UPDATE dbo.TBS_STUDENT_ALUMNI_DETAILS SET STUDENT_ID = " & cboStudent.SelectedValue & " ,POSITION_ID = " & positionID & " ,SPONSOR_US = " & txtSponserAmountUSDD.Text & ",SPONSOR_KH = " & txtSponserAmountKHR.Text & " ,REMARK =N'" & dgDetail.SelectedCells(7).Value & "'  WHERE RECORD_ID =" & dgDetail.SelectedCells(8).Value & " AND ALUMNI_ID = " & dgDetail.SelectedCells(9).Value & "")
                        obj.Update("UPDATE dbo.TBS_STUDENT_ALUMNI_MASTER SET AMOUNT_US = " & txtAmountUSD.Text & " ,AMOUNT_KH = " & txtAmountKHR.Text & " WHERE ALUMNI_ID = " & txtAlumniID.Text & "")
                        Call Selection()
                    End If
                Else 'Newest record (Not yet save)
                    dgDetail.SelectedRows(0).Cells(1).Value = cboStudent.SelectedValue
                    dgDetail.SelectedRows(0).Cells(2).Value = cboStudent.Text
                    dgDetail.SelectedRows(0).Cells(3).Value = cboPosition.SelectedValue
                    dgDetail.SelectedRows(0).Cells(4).Value = cboPosition.Text
                    dgDetail.SelectedRows(0).Cells(5).Value = txtSponserAmountUSDD.Text
                    dgDetail.SelectedRows(0).Cells(6).Value = txtSponserAmountKHR.Text
                End If
            Else
                obj.ShowMsg("មិនមែនព័ត៌មានសម្រាប់កែប្រែទេ " + Environment.NewLine + "សូមបញ្ចូលព័ត៌មានជាមុខ​!", FrmWarning, _WarningSound)
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការកែប្រែបាន", FrmMessageError, _ErrorSound)
        End Try

    End Sub

    Private Sub lblRemove_Click(sender As Object, e As EventArgs) Handles lblRemove.Click
        Try
            If (dgDetail.SelectedRows.Count = 0) Then
                obj.ShowMsg("មិនមែនព័ត៌មានសម្រាប់លុបនោះទេ " + Environment.NewLine + "សូមបញ្ចូលព័ត៌មានជាមុខ​!", FrmWarning, "Error.wav")
                Exit Sub
            End If

            Dim recordID As String = dgDetail.SelectedCells(8).Value
            Dim alumniID As String = dgDetail.SelectedCells(9).Value
            Dim studentID As String = dgDetail.SelectedCells(1).Value

            If (recordID = "") Then
                dgDetail.Rows.RemoveAt(dgDetail.CurrentCell.RowIndex)
            Else
                obj.ShowMsg("តើអ្នកចង់លុបទិន្នន័យនេះដែលឬទេ", FrmMessageQuestion, _SuccessSound)
                If USER_CLICK_OK = True Then
                    Call obj.Delete("DELETE FROM dbo.TBS_STUDENT_ALUMNI_DETAILS WHERE RECORD_ID = " & recordID & " AND ALUMNI_ID = " & alumniID & " AND STUDENT_ID = " & studentID & "")
                    obj.Update_1("UPDATE dbo.TBS_STUDENT_ALUMNI_MASTER SET AMOUNT_US = " & txtAmountUSD.Text & " ,AMOUNT_KH = " & txtAmountKHR.Text & " WHERE ALUMNI_ID = " & alumniID & "")
                    Call Selection()
                    USER_CLICK_OK = False
                End If
            End If

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចលុបទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        ClearMaster()
        ClearDetail()
        dgDetail.Rows.Clear()
        lblSave.Enabled = True
        lblUpdate.Enabled = False
        lblDelete.Enabled = False
        lblEdit.Enabled = False
        lblRemove.Enabled = False
        lblInsert.Enabled = True
        cboTeacher.Focus()
    End Sub
    Private Sub ClearMaster()
        cboTeacher.Text = ""
        dtDateCelebration.Text = Date.Today
        dtDateNote.Text = Date.Today
        txtAmountKHR.Clear()
        txtAmountUSD.Clear()
        txtRemark.Clear()
        txtAlumniID.Clear()
        teacherID = 0
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        Try
            'Validate on empty datagrid
            If dgDetail.RowCount <= 0 Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានជាមុខ​!", FrmWarning, "Error.wav")
                Exit Sub
            End If

            'validate on empty control
            If cboTeacher.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                ValidateControl_master()
                If ValidateControl_master() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If
            If txtAmountKHR.Text = "" Then
                txtAmountKHR.Text = 0
            End If

            If txtAmountUSD.Text = "" Then
                txtAmountUSD.Text = 0
            End If

            obj.Insert_1("INSERT INTO dbo.TBS_STUDENT_ALUMNI_MASTER(TEACHER_ID,DATE_CELEBRATION,DATE_NOTE,AMOUNT_US,AMOUNT_KH,REMARK)VALUES(" & cboTeacher.SelectedValue & ",'" & dtDateCelebration.Value & "',GETDATE()," & txtAmountUSD.Text & "," & txtAmountKHR.Text & ",N'" & txtRemark.Text & "')")
            For i As Integer = 0 To dgDetail.RowCount - 1
                obj.Insert_1("INSERT INTO dbo.TBS_STUDENT_ALUMNI_DETAILS (ALUMNI_ID,STUDENT_ID,POSITION_ID,SPONSOR_US,SPONSOR_KH,REMARK)VALUES((SELECT MAX(ALUMNI_ID) FROM dbo.TBS_STUDENT_ALUMNI_MASTER)," & dgDetail.Rows(i).Cells(1).Value & "," & dgDetail.Rows(i).Cells(3).Value & "," & dgDetail.Rows(i).Cells(5).Value & "," & dgDetail.Rows(i).Cells(6).Value & ",N'" & dgDetail.Rows(i).Cells(7).Value & "')")
            Next
            Call obj.ShowMsg("ទិន្នន័យរក្សាទុកបានសម្រេច!", FrmMessageSuccess, "")
            lblNew_Click(sender, e)
            SelectSearch()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចរក្សាទុកទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub cbo_teacher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeacher.SelectedIndexChanged
        cboTeacher.BackColor = Color.White
    End Sub

    Private Sub cboSearchByYear_DropDown(sender As Object, e As EventArgs) Handles cboSearchByYear.DropDown
        obj.BindComboBox("SELECT YEAR(DATE_CELEBRATION) AS YEAR_CELEBRATION FROM dbo.TBS_STUDENT_ALUMNI_MASTER GROUP BY YEAR(DATE_CELEBRATION)", cboSearchByYear, "YEAR_CELEBRATION", "YEAR_CELEBRATION")
    End Sub

    Private Sub cboSearchByYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchByYear.SelectedIndexChanged
        Call SelectSearch()
    End Sub

    Private Sub SelectSearch()
        Try
            Dim sql = "SELECT A.ALUMNI_ID, A.DATE_CELEBRATION FROM dbo.TBS_STUDENT_ALUMNI_MASTER AS A WHERE YEAR(A.DATE_CELEBRATION) = '" & cboSearchByYear.Text & "'"
            obj.BindDataGridView(sql, dgSearch)
            Call SetDgSearcHeader()

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("បញ្ហាក្នុងការទាញទិន្នន័យ", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub SetDgSearcHeader()
        Try
            dgSearch.Columns(0).Visible = False
            dgSearch.Columns(1).HeaderText = "កាលបរិច្ឆេទ"
            dgSearch.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '    Private Sub dg_search_SelectionChanged(sender As Object, e As EventArgs) Handles dg_search.SelectionChanged
    '        Try
    '            Call obj.OpenConnection()
    '            cmd = New SqlCommand("SELECT MISSION_ID,MISSION_NUMBER,MISSION_DATE,MISSION_MEANING,MISSION_TO,LOCATION,DESCRIPTION,DATE_NOTE" & vbCrLf &
    '"FROM dbo.TBL_TEACHER_MISSION_MASTER WHERE MISSION_ID =" & cbo_search_mission_number.SelectedValue & "", con)
    '            da = New SqlDataAdapter(cmd)
    '            dt = New DataTable
    '            da.Fill(dt)

    '            If dt.Rows.Count > 0 Then
    '                txt_MISSION_ID.Text = dt.Rows(0)(0).ToString()
    '                txt_MISSION_NUMBER.Text = dt.Rows(0)(1).ToString()
    '                dt_MISSION_DATE.Text = dt.Rows(0)(2).ToString()
    '                txt_MISSION_MEANING.Text = dt.Rows(0)(3).ToString()
    '                txt_MISSION_TO.Text = dt.Rows(0)(4).ToString()
    '                txt_LOCATION.Text = dt.Rows(0)(5).ToString()
    '                txt_DESCRIPTION.Text = dt.Rows(0)(6).ToString()
    '                dt_datenote.Text = dt.Rows(0)(7).ToString()
    '            End If

    '            Call obj.OpenConnection()
    '            cmd = New SqlCommand("SELECT TMD.RECORD_ID,T.T_NAME_KH, TMD.TEACHER_ID, TM.MISSION_POSITION_KH, TMD.MISSION_POSITION_ID, TMD.DESCRIPTION" & vbCrLf &
    '"FROM         dbo.TBL_TEACHER_MISSION_DETAIL AS TMD INNER JOIN" & vbCrLf &
    '"                      dbo.TBL_MISSION_POSITION AS TM ON TMD.MISSION_POSITION_ID = TM.MISSION_POSITION_ID INNER JOIN" & vbCrLf &
    '"                      dbo.TBL_TEACHER AS T ON TMD.TEACHER_ID = T.TEACHER_ID WHERE TMD.MISSION_ID = " & cbo_search_mission_number.SelectedValue & " ", con)

    '            da = New SqlDataAdapter(cmd)
    '            dt = New DataTable
    '            da.Fill(dt)
    '            dg_detail.Rows.Clear()

    '            If dt.Rows.Count > 0 Then

    '                For i As Integer = 0 To dt.Rows.Count - 1
    '                    dg_detail.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString())
    '                    dg_detail.Columns(2).Visible = False
    '                    dg_detail.Columns(4).Visible = False
    '                    dg_detail.Columns(0).Visible = False
    '                Next
    '            End If
    '            lbl_new.Enabled = True
    '            lbl_save.Enabled = False
    '            lbl_update.Enabled = True
    '        Catch ex As Exception
    '            error_reason = ex.Message
    '            obj.ShowMsg("ពុំស្វែងរកទិន្នន័យបានទេ!", msg_fail)
    'End Try
    'End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dg_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSearch.CellContentClick
        dgSearch_SelectionChanged(sender, e)
    End Sub

    Private Sub Selection()
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT S.ALUMNI_ID, T.T_NAME_KH, S.DATE_CELEBRATION, S.DATE_NOTE, S.AMOUNT_US, S.AMOUNT_KH, S.REMARK,S.TEACHER_ID FROM dbo.TBS_STUDENT_ALUMNI_MASTER AS S INNER JOIN dbo.TBL_TEACHER AS T ON S.TEACHER_ID = T.TEACHER_ID WHERE S.ALUMNI_ID = " & dgSearch.SelectedCells(0).Value & "", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtAlumniID.Text = If(IsDBNull(dt.Rows(0)(0).ToString), "", dt.Rows(0)(0).ToString)
                cboTeacher.Text = If(IsDBNull(dt.Rows(0)(1).ToString), "", dt.Rows(0)(1).ToString)
                dtDateCelebration.Text = If(IsDBNull(dt.Rows(0)(2).ToString), "", dt.Rows(0)(2).ToString)
                dtDateNote.Text = If(IsDBNull(dt.Rows(0)(3).ToString), "", dt.Rows(0)(3).ToString)
                txtAmountKHR.Text = If(IsDBNull(dt.Rows(0)(4).ToString), "", dt.Rows(0)(4).ToString)
                txtAmountUSD.Text = If(IsDBNull(dt.Rows(0)(5).ToString), "", dt.Rows(0)(5).ToString)
                txtRemark.Text = If(IsDBNull(dt.Rows(0)(6).ToString), "", dt.Rows(0)(6).ToString)
                teacherID = If(IsDBNull(dt.Rows(0)(7).ToString), "", dt.Rows(0)(7).ToString)
            End If
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT D.STUDENT_ID, S.SNAME_KH, D.POSITION_ID, O.OCCUPATION_KH, D.SPONSOR_US, D.SPONSOR_KH,D.REMARK, D.RECORD_ID, D.ALUMNI_ID FROM  dbo.TBS_STUDENT_ALUMNI_DETAILS AS D LEFT JOIN dbo.TBS_STUDENT_INFO_FORMER AS S ON D.STUDENT_ID = S.STUDENT_ID LEFT JOIN dbo.TBL_OCCUPATION AS O ON D.POSITION_ID = O.OCCUPATION_ID WHERE D.ALUMNI_ID =   " & dgSearch.SelectedCells(0).Value & "", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dgDetail.Rows.Clear()

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    dgDetail.Rows.Add("", dt.Rows(i)("STUDENT_ID").ToString(), dt.Rows(i)("SNAME_KH").ToString(), dt.Rows(i)("POSITION_ID").ToString(), dt.Rows(i)("OCCUPATION_KH").ToString(), dt.Rows(i)("SPONSOR_US").ToString(), dt.Rows(i)("SPONSOR_KH").ToString(), dt.Rows(i)("REMARK").ToString(), dt.Rows(i)("RECORD_ID").ToString(), dt.Rows(i)("ALUMNI_ID").ToString())
                Next
            End If

            lblNew.Enabled = True
            lblSave.Enabled = False
            lblUpdate.Enabled = True
            lblDelete.Enabled = True

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("បញ្ហាក្នុងការទាញទិន្នន័យ", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub dgSearch_SelectionChanged(sender As Object, e As EventArgs) Handles dgSearch.SelectionChanged
        Try
            If (dgSearch.SelectedRows.Count = 0) Then
                ClearMaster()
                ClearDetail()
                dgDetail.Rows.Clear()
            Else
                Call ClearMaster()
                Call Selection()
            End If
        Catch ex As Exception
            MessageBox.Show("Problem select data from database")
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        Try
            obj.ShowMsg("តើអ្នកចង់កែប្រែទិន្នន័យនេះដែលឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then

                If txtAlumniID.Text = "" Then
                    obj.ShowMsg("សូមជ្រើសរើសព័ត៌មានដែលចង់កែប្រែ", FrmWarning, _WarningSound)
                    Exit Sub
                End If

                If dgDetail.RowCount <= 0 Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានជាមុខ​!", FrmWarning, _WarningSound)
                    Exit Sub
                End If

                If cboTeacher.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, _WarningSound)
                    ValidateControl_master()
                    If ValidateControl_master() = False Then
                        Exit Sub
                    End If
                    Exit Sub
                End If

                If txtAmountKHR.Text = "" Then
                    txtAmountKHR.Text = 0
                End If

                If txtAmountUSD.Text = "" Then
                    txtAmountUSD.Text = 0
                End If

                If (cboTeacherDropped = False) Then
                    cboTeacher_DropDown(sender, e)
                    cboTeacher.SelectedValue = teacherID
                End If

                obj.Update_1("UPDATE dbo.TBS_STUDENT_ALUMNI_MASTER SET TEACHER_ID = " & cboTeacher.SelectedValue & " ,DATE_CELEBRATION = '" & dtDateCelebration.Text & "',AMOUNT_US = " & txtAmountUSD.Text & " ,AMOUNT_KH = " & txtAmountKHR.Text & ",REMARK = N'" & txtRemark.Text & "' WHERE ALUMNI_ID = " & txtAlumniID.Text & "")

                If (dgDetail.Rows.Count > 0) Then
                    For i As Integer = 0 To dgDetail.RowCount - 1
                        If (obj.CheckExisted("SELECT RECORD_ID FROM dbo.TBS_STUDENT_ALUMNI_DETAILS WHERE RECORD_ID = " & (If(dgDetail.Rows(i).Cells(8).Value Is Nothing, "0", dgDetail.Rows(i).Cells(8).Value)) & " ", "TBS_STUDENT_ALUMNI_DETAILS") = False) Then
                            obj.Insert_1("INSERT INTO dbo.TBS_STUDENT_ALUMNI_DETAILS (ALUMNI_ID,STUDENT_ID,POSITION_ID,SPONSOR_US,SPONSOR_KH,REMARK)VALUES(" & txtAlumniID.Text & "," & dgDetail.Rows(i).Cells(1).Value & "," & dgDetail.Rows(i).Cells(3).Value & "," & dgDetail.Rows(i).Cells(5).Value & "," & dgDetail.Rows(i).Cells(6).Value & ",N'" & dgDetail.Rows(i).Cells(7).Value & "')")
                        Else
                            Call obj.Update_1("UPDATE dbo.TBS_STUDENT_ALUMNI_DETAILS SET STUDENT_ID =" & dgDetail.Rows(i).Cells(1).Value.ToString() & " ,POSITION_ID = " & dgDetail.Rows(i).Cells(3).Value.ToString() & ", SPONSOR_US = " & dgDetail.Rows(i).Cells(5).Value.ToString() & ",SPONSOR_KH = " & dgDetail.Rows(i).Cells(6).Value.ToString() & ",REMARK =N'" & dgDetail.Rows(i).Cells(7).Value.ToString() & "' WHERE RECORD_ID = " & dgDetail.Rows(i).Cells(8).Value.ToString & " AND ALUMNI_ID = " & dgDetail.Rows(i).Cells(9).Value.ToString & "")
                        End If
                    Next
                End If

                Call obj.ShowMsg("ទិន្នន័យត្រូវបានកែប្រែ", FrmMessageSuccess, _SuccessSound)
                Call SelectSearch()
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចកែប្រែទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try

    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub cboTeacher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTeacher.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboStudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboStudent.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPosition.KeyPress
        e.Handled = True
    End Sub

    Private Sub dgDetail_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgDetail.RowPrePaint
        Try
            If e.RowIndex >= 0 Then
                Me.dgDetail.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                dgDetail.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Call CalculationAmount()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDetail.CellClick
        dgDetail_SelectionChanged(sender, e)
    End Sub

    Private Sub lblInsert_MouseHover(sender As Object, e As EventArgs) Handles lblInsert.MouseHover
        t.Hover(lblInsert)
    End Sub

    Private Sub lblInsert_MouseLeave(sender As Object, e As EventArgs) Handles lblInsert.MouseLeave
        t.Leave(lblInsert)
    End Sub

    Private Sub lblEdit_MouseHover(sender As Object, e As EventArgs) Handles lblEdit.MouseHover
        t.Hover(lblEdit)
    End Sub

    Private Sub lblEdit_MouseLeave(sender As Object, e As EventArgs) Handles lblEdit.MouseLeave
        t.Leave(lblEdit)
    End Sub

    Private Sub lblRemove_MouseHover(sender As Object, e As EventArgs) Handles lblRemove.MouseHover
        t.Hover(lblRemove)
    End Sub

    Private Sub lblRemove_MouseLeave(sender As Object, e As EventArgs) Handles lblRemove.MouseLeave
        t.Leave(lblRemove)
    End Sub

    Private Sub lblDetailNew_Click(sender As Object, e As EventArgs) Handles lblDetailNew.Click
        lblEdit.Enabled = False
        lblRemove.Enabled = False
        lblInsert.Enabled = True

        txtSponserAmountKHR.Text = "0"
        txtSponserAmountUSDD.Text = "0"
        cboPosition.Text = ""
        cboStudent.Text = ""
        cboStudent.Focus()
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            If (txtAlumniID.Text <> "") Then
                obj.ShowMsg("តើអ្នកចង់លុបទិន្នន័យនេះដែលឬទេ?", FrmMessageQuestion, _ShowMessageSound)
                If USER_CLICK_OK = True Then
                    obj.Delete_1("DELETE FROM dbo.TBS_STUDENT_ALUMNI_DETAILS WHERE ALUMNI_ID = " & txtAlumniID.Text & "")
                    obj.Delete_1("DELETE FROM dbo.TBS_STUDENT_ALUMNI_MASTER WHERE ALUMNI_ID = " & txtAlumniID.Text & "")
                    obj.ShowMsg("ទិន្នន័យត្រូវបានលុប", FrmMessageSuccess, _SuccessSound)
                    Call SelectSearch()
                End If
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចលុបទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub lblDetailNew_MouseHover(sender As Object, e As EventArgs) Handles lblDetailNew.MouseHover
        t.Hover(lblDetailNew)
    End Sub

    Private Sub lblDetailNew_MouseLeave(sender As Object, e As EventArgs) Handles lblDetailNew.MouseLeave
        t.Leave(lblDetailNew)
    End Sub

    Private Sub cboStudent_DropDownClosed(sender As Object, e As EventArgs) Handles cboStudent.DropDownClosed
        cboPosition.Focus()
    End Sub

    Private Sub cboPosition_DropDownClosed(sender As Object, e As EventArgs) Handles cboPosition.DropDownClosed
        txtSponserAmountUSDD.Focus()
    End Sub

    Private Sub txtAmountUSD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountUSD.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtAmountKHR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountKHR.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtSponserAmountUSDD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSponserAmountUSDD.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSponserAmountKHR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSponserAmountKHR.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAdvancedSearch_TextChanged(sender As Object, e As EventArgs) Handles txtAdvancedSearch.TextChanged
        Try
            Dim sql = "SELECT A.ALUMNI_ID, A.DATE_CELEBRATION FROM dbo.TBS_STUDENT_ALUMNI_MASTER AS A LEFT JOIN dbo.TBL_TEACHER AS T ON A.TEACHER_ID = T.TEACHER_ID  LEFT JOIN dbo.TBS_STUDENT_ALUMNI_DETAILS AS D ON A.ALUMNI_ID = D.ALUMNI_ID LEFT JOIN dbo.TBS_STUDENT_INFO_FORMER AS F ON D.STUDENT_ID = F.STUDENT_ID WHERE  ISNULL(CAST(A.DATE_CELEBRATION  AS NVARCHAR(50)),'') + ISNULL(T.T_NAME_KH,'') + ISNULL(F.SNAME_KH,'') LIKE N'%" & txtAdvancedSearch.Text & "%'"
            obj.BindDataGridView(sql, dgSearch)
            Call SetDgSearcHeader()

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("បញ្ហាក្នុងការទាញទិន្នន័យ", FrmMessageError, _ErrorSound)
        End Try
    End Sub



    Private Sub lblPrint_MouseHover(sender As Object, e As EventArgs) Handles lblPrint.MouseHover
        t.Hover(lblPrint)
    End Sub

    Private Sub lblPrint_MouseLeave(sender As Object, e As EventArgs) Handles lblPrint.MouseLeave
        t.Leave(lblPrint)
    End Sub



    Private Sub lblNew_MouseHover(sender As Object, e As EventArgs) Handles lblNew.MouseHover
        t.Hover(lblNew)
    End Sub

    Private Sub lblNew_MouseLeave(sender As Object, e As EventArgs) Handles lblNew.MouseLeave
        t.Leave(lblNew)
    End Sub

    Private Sub lblPrint_Click(sender As Object, e As EventArgs) Handles lblPrint.Click
        Try
            DataSet1.dtStudentAlumni.Clear()
            Dim rowNumber As Integer = 1
            For i As Integer = 0 To dgDetail.RowCount - 1
                DataSet1.dtStudentAlumni.Rows.Add(rowNumber, dgDetail.Rows(i).Cells(2).Value.ToString, dgDetail.Rows(i).Cells(4).Value.ToString, dgDetail.Rows(i).Cells(5).Value.ToString, dgDetail.Rows(i).Cells(6).Value.ToString, dgDetail.Rows(i).Cells(7).Value.ToString)
                rowNumber += 1
            Next

            '  
            Dim formReport As New FrmDynamicReportViewer

            formReport.SetupReport("DataSet1", "STU_MS.rpStudentAlumni.rdlc", BindingSource1)
            obj.SendParam("paramSchoolName", obj.GetSchoolName(), formReport.ReportViewer)
            obj.SendParam("paramProvince", obj.GetProvinceName(), formReport.ReportViewer)
            obj.SendParam("paramTeacherName", cboTeacher.Text, formReport.ReportViewer)
            obj.SendParam("paramCelebrationDate", dtDateCelebration.Text, formReport.ReportViewer)
            obj.SendParam("paramTotalKHR", txtAmountKHR.Text + " រៀល", formReport.ReportViewer)
            obj.SendParam("paramTotalUSDD", txtAmountUSD.Text + " ដុល្លា", formReport.ReportViewer)
            formReport.ReportViewer.RefreshReport()
            formReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class



Imports System.Data.SqlClient

Public Class frm_student_education
    Dim obj As New Method
    Dim class_id As Integer
    Dim searchMode As Boolean = False 'search as default
    Dim t As New Theme


    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles lblSave.MouseHover
        frm_teacher.SetHoverStyle(lblSave)
    End Sub


    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles lblSave.MouseLeave
        frm_teacher.SetLeaveStyle(lblSave)
    End Sub

    Private Sub frm_subject_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            lblCompanyInfro.Text = CompanyInfo.CompanyName
            lblOwnerName.Text = CompanyInfo.Name
            lblPhoneNumber.Text = CompanyInfo.Tel
            lblEmail.Text = CompanyInfo.Email
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cbo_old_year_DropDown(sender As Object, e As EventArgs) Handles cboOldYear.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboOldYear, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub
    Private Sub cbo_new_year_DropDown(sender As Object, e As EventArgs) Handles cboNewYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboNewYearStudy, "YEAR_STUDY_KH", "YEAR_ID")

    End Sub

    Private Sub cbo_old_class_DropDown(sender As Object, e As EventArgs) Handles cboOldClass.DropDown
        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboOldClass, "CLASS_LETTER", "CLASS_ID")
    End Sub

    Private Sub cbo_new_class_DropDown(sender As Object, e As EventArgs) Handles cboNewClass.DropDown
        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboNewClass, "CLASS_LETTER", "CLASS_ID")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frm_year_study.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frm_year_study.ShowDialog()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frm_class.ShowDialog()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        frm_class.ShowDialog()
    End Sub



    Private Function CHECK_IF_NEW_STUDENT() As Boolean
        Try
            cmd = New SqlCommand("SELECT YEAR_STUDY_OLD,CLASS_OLD FROM dbo.TBS_STUDENT_STUDY_INFO WHERE YEAR_STUDY_OLD= N'" & cboOldYear.Text & "' AND CLASS_OLD = N'" & cboOldClass.Text & "'", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            For i As Integer = 0 To dt.Rows.Count - 1
                If IsDBNull(dt.Rows(i)(0).ToString()) And IsDBNull(dt.Rows(i)(1).ToString()) Then
                    CHECK_IF_NEW_STUDENT = True
                Else
                    CHECK_IF_NEW_STUDENT = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return CHECK_IF_NEW_STUDENT
    End Function
    Public Sub CheckIfNewStudent()
        Try
            cmd = New SqlCommand("SELECT CLASS_OLD,YEAR_STUDY_OLD FROM dbo.TBS_STUDENT_STUDY_INFO WHERE YEAR_STUDY_OLD = " & cboOldYear.Text & " AND CLASS_OLD = " & cboOldClass.Text & "", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i)(0).ToString() And dt.Rows(i)(0).ToString Then
                    MsgBox("New Student")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Search()
        Try
            Dim selectSql As String = "SELECT S.RECORD_ID,ROW_NUMBER() OVER(ORDER BY S.STUDENT_ID ASC) AS 'ROW_NUMBER',S.STUDENT_ID,I.SNAME_KH, I.GENDER, I.STUDENT_CODE,CONVERT(CHAR(10),I.DOB,120)AS 'DOB', I.GUARDIAN_VILLAGE,S.STUDY_INFO_STATUS_ID,ST .STUDY_INFO_STATUS_KH ,S.YEAR_STUDY,C.CLASS_LETTER, NULL AS 'NEW_YEAR_STUDY', NULL AS 'NEW_CLASS', S.REMARK,MT.CLASS_MONITOR_NUM,S.CLASS_ID FROM dbo.TBS_STUDENT_STUDY_INFO AS S INNER JOIN dbo.TBS_STUDENT_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON S.CLASS_ID = C.CLASS_ID INNER JOIN dbo.TBS_STUDENT_STUDY_INFO_STATUS AS ST ON S.STUDY_INFO_STATUS_ID = ST .STUDY_INFO_STATUS_ID LEFT  JOIN dbo.TBS_STUDENT_CLASS_MONITOR AS MT ON S.STUDENT_ID = MT.STUDENT_ID WHERE I.STUDENT_STATUS_ID NOT IN(2,3,4,6)"

            If cboOldYear.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
                cboOldYear.BackColor = Color.LavenderBlush
                cboOldYear.Focus()
                Exit Sub
            End If
            If cboOldClass.Text = "" Then
                searchMode = True
                cmd = New SqlCommand(selectSql + "  AND S.YEAR_STUDY = N'" & cboOldYear.Text & "' ", conn)
            Else
                searchMode = False
                cmd = New SqlCommand(selectSql + "  AND S.YEAR_STUDY = N'" & cboOldYear.Text & "' AND S.CLASS_ID = " & cboOldClass.SelectedValue & "", conn)
            End If

            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If (dt.Rows.Count <= 0) Then
                obj.ShowMsg("មិនមានទិន្នន័យ", FrmWarning, "")
                dg.Rows.Clear()
                Exit Sub
            Else
                cbCheckAll.Checked = False
                dg.Rows.Clear()
                For i As Integer = 0 To dt.Rows.Count - 1
                    dg.Rows.Add(dt.Rows(i)(0).ToString(), False, dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString(), dt.Rows(i)(6).ToString(), dt.Rows(i)(7).ToString(), dt.Rows(i)(8).ToString(), dt.Rows(i)(9).ToString(), dt.Rows(i)(10).ToString(), dt.Rows(i)(11).ToString(), dt.Rows(i)(12).ToString(), "", dt.Rows(i)(13).ToString(), dt.Rows(i)(14).ToString(), dt.Rows(i)(15).ToString(), dt.Rows(i)(16).ToString())
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub lbl_search_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        Call Search()
    End Sub

    Private Function CheckIsFirst() As Boolean
        Dim NULL As Boolean = True
        cmd = New SqlCommand("SELECT YEAR_STUDY_OLD,CLASS_OLD from dbo.TBS_STUDENT_STUDY_INFO", conn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)

        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)(0).ToString IsNot "" And dt.Rows(i)(1).ToString IsNot "" Then
                NULL = False
            End If
        Next
        Return NULL
    End Function

    Private Sub cbo_old_class_TextChanged(sender As Object, e As EventArgs) Handles cboOldClass.TextChanged
        cboOldClass.BackColor = Color.White
    End Sub

    Private Sub cbo_old_year_TextChanged(sender As Object, e As EventArgs) Handles cboOldYear.TextChanged
        cboOldYear.BackColor = Color.White
    End Sub
    Public Function isRowSelected() As Boolean
        For i As Integer = 0 To dg.Rows.Count - 1
            If dg.Rows(i).Cells(1).Value = True Then Return True
        Next
        Return False
    End Function
    Private Sub lbl_upgrade_class_Click(sender As Object, e As EventArgs) Handles lbl_upgrade_class.Click

        dg.EndEdit()
        If searchMode = True Then
            obj.ShowMsg("សូមជ្រើសរើសថ្នាក់ជាមុន", FrmWarning, "Windows Ding.wav")
            Exit Sub
        End If

        If dg.Rows.Count <= 0 Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានជាមុន", FrmWarning, "Windows Ding.wav")
            Exit Sub
        End If

        If isRowSelected() = False Then
            obj.ShowMsg("អ្នកមិនទាន់ជ្រើសរើសសិស្សនោះទេ។ " & vbCrLf & "តើអ្នកចង់រើសយកទាំងអស់ដែលឬទេ?", FrmMessageQuestion, "")
            If USER_CLICK_OK = True Then
                cbCheckAll.Checked = True
            End If
            Exit Sub
        End If

        If cboNewYearStudy.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
            cboNewYearStudy.BackColor = Color.LavenderBlush
            cboNewYearStudy.Focus()
            Exit Sub
        End If

        If cboNewClass.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
            cboNewClass.BackColor = Color.LavenderBlush
            cboNewClass.Focus()
            Exit Sub
        End If
        'Rows index 11 is Old Year Study
        If SplitYear(dg.Rows(0).Cells(11).Value) > SplitYear(cboNewYearStudy.Text) Then
            cboNewYearStudy.BackColor = Color.LavenderBlush
            cboNewYearStudy.Focus()
            obj.ShowMsg("ឆ្នាំសិក្សាថ្មីមិនអាចតូចជាងឆ្នាំសិក្សាចាស់", FrmWarning, "Windows Ding.wav")
            Exit Sub
        End If

        If SplitYear(dg.Rows(0).Cells(11).Value) = SplitYear(cboNewYearStudy.Text) Then
            cboNewYearStudy.BackColor = Color.LavenderBlush
            cboNewYearStudy.Focus()
            obj.ShowMsg("ឆ្នាំសិក្សាថ្មីមិនដូចឆ្នាំសិក្សាចាស់", FrmWarning, "Windows Ding.wav")
            Exit Sub
        End If
        If dg.Rows(0).Cells(12).Value = cboNewClass.Text Then
            obj.ShowMsg("ថ្នាក់ថ្មីមិនអាចដូចថ្នាក់ចាស់ទេ !", FrmWarning, "Windows Ding.wav")
            cboNewClass.BackColor = Color.LavenderBlush
            cboNewClass.Focus()
            Exit Sub
        End If
        If ValidateClass(dg.Rows(0).Cells(12).Value, cboNewClass.Text) = False Then
            cboNewClass.BackColor = Color.LavenderBlush
            cboNewClass.Focus()
            obj.ShowMsg("ថ្នាក់ថ្មីមិនអាចតូចជាងថ្នាក់ចាស់ទេ !", FrmWarning, "Windows Ding.wav")
            Exit Sub
        End If

        If (SplitYear(cboNewYearStudy.Text)) <> (Convert.ToInt32(SplitYear(cboOldYear.Text)) + 1).ToString Then
            cboNewYearStudy.BackColor = Color.LavenderBlush
            cboNewYearStudy.Focus()
            obj.ShowMsg("មិនអាចធ្វើការតំឡើងថ្នាក់ខុសលំដាប់ឆ្នាំសិក្សាបានទេ", FrmWarning, "Windows Ding.wav")
            Exit Sub
        End If

        If (Convert.ToInt32(cboNewClass.Text.Substring(0, cboNewClass.Text.Length - 1))) <> (Convert.ToInt32(cboOldClass.Text.Substring(0, cboOldClass.Text.Length - 1))) + 1 Then
            cboNewClass.BackColor = Color.LavenderBlush
            cboNewClass.Focus()
            obj.ShowMsg("មិនអាចធ្វើការតំឡើងថ្នាក់ខុសលំដាប់ថ្នាក់បានទេ", FrmWarning, "Windows Ding.wav")
            Exit Sub
        End If

        obj.ShowMsg("តើអ្នកចង់តំឡើងថ្នាក់ពីឆ្នាំសិក្សា " & dg.Rows(0).Cells(11).Value & " ថ្នាក់ទី " & dg.Rows(0).Cells(12).Value & "" & vbCrLf & " ទៅឆ្នាំសិក្សា " & cboNewYearStudy.Text & " ថ្នាក់ទី " & cboNewClass.Text & " ដែលឬទេ ?", msg_question_big, "")
        If USER_CLICK_OK = True Then

            If RecordExist() = True Then
                obj.ShowMsg("ព័ត៌មាននេះបានបញ្ចូលរួចរាល់ហើយ !", FrmWarning, "Windows Ding.wav")
                Exit Sub
            End If

            class_id = cboNewClass.SelectedValue
            lblSave.Enabled = True

            ' Call RemoveUncheckedRows()
            For Each rows As DataGridViewRow In dg.Rows
                If (rows.Cells(1).Value = True) Then

                    rows.Cells(9).Value = 1
                    rows.Cells(10).Value = "ឡើងថ្នាក់"
                    rows.Cells(13).Value = cboNewYearStudy.Text
                    rows.Cells(14).Value = cboNewClass.SelectedValue
                    rows.Cells(15).Value = cboNewClass.Text
                    'Else
                    '    rows.Cells(9).Value = 2
                    '    rows.Cells(10).Value = "ត្រួតថ្នាក់"
                End If
            Next
        End If
    End Sub
    Private Sub RemoveUncheckedRows()
        Try
            For j = dg.RowCount - 1 To 0 Step -1
                If dg(0, j).Value = False Then dg.Rows.RemoveAt(j)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CountSearchResult()
        Try
            Dim girl As Integer = 0

            If dg.Rows.Count > 0 Then
                For i As Integer = 0 To dg.RowCount - 1
                    If (dg.Rows(i).Cells(5).Value.ToString = "ស្រី") Then
                        girl += 1
                    End If
                Next
            End If
            lblTotalSearch.Text = dg.Rows.Count.ToString
            lblTotalSearchGirl.Text = girl.ToString
        Catch ex As Exception
            lblTotalSearch.Text = "0"
            lblTotalSearchGirl.Text = "0"
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CountSelectedStudent()
        Try
            Dim toal As Integer = 0
            Dim girl As Integer = 0

            If dg.Rows.Count > 0 Then
                For i As Integer = 0 To dg.RowCount - 1
                    If (dg.Rows(i).Cells(1).Value = True) Then
                        toal += 1
                        If (dg.Rows(i).Cells(5).Value.ToString = "ស្រី") Then
                            girl += 1
                        End If
                    End If
                Next
            End If
            lblTotalSelected.Text = toal.ToString
            lblTotalSelectedGirl.Text = girl.ToString
        Catch ex As Exception
            lblTotalSelected.Text = "0"
            lblTotalSelectedGirl.Text = "0"
            MessageBox.Show(ex.Message)
        End Try
    End Sub







    Private Sub cbo_new_class_TextChanged(sender As Object, e As EventArgs) Handles cboNewClass.TextChanged
        cboNewClass.BackColor = Color.White
    End Sub

    Private Sub cbo_new_year_TextChanged(sender As Object, e As EventArgs) Handles cboNewYearStudy.TextChanged
        cboNewYearStudy.BackColor = Color.White
    End Sub

    Private Sub cb_check_all_CheckedChanged(sender As Object, e As EventArgs) Handles cbCheckAll.CheckedChanged



        If cbCheckAll.Checked = True Then
            For Each rows As DataGridViewRow In dg.Rows
                rows.Cells(1).Value = True
            Next
        Else
            For Each rows As DataGridViewRow In dg.Rows
                rows.Cells(1).Value = False
            Next
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        dg.EndEdit()
        Try
            If isRowSelected() = False Then
                obj.ShowMsg("អ្នកមិនទាន់ជ្រើសរើសសិស្សនោះទេ។ " & vbCrLf & "តើអ្នកចង់រើសយកទាំងអស់ដែលឬទេ?", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    cbCheckAll.Checked = True
                End If
                Exit Sub
            End If

            If class_id = Nothing Then
                obj.ShowMsg("សូមតំឡើងថ្នាក់សិស្សជាមុន", FrmWarning, "Windows Ding.wav")
                Exit Sub
            End If

            If (cboTeacher.Text = "") Then
                obj.ShowMsg("សូមបញ្ចូលអ្នកបញ្ចូល", FrmWarning, "Windows Ding.wav")
                cboTeacher.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            obj.ShowMsg("តើអ្នកចង់រក្សាទុកការដំឡើងថ្នាក់នេះដែលឬទេ ?", FrmMessageQuestion, "")
            If USER_CLICK_OK = True Then
                For i As Integer = 0 To dg.RowCount - 1
                    Dim isSelected As Boolean = dg.Rows(i).Cells(1).Value
                    If isSelected = True Then
                        obj.InsertNoMsg("INSERT INTO dbo.TBS_STUDENT_STUDY_INFO (STUDENT_ID,CLASS_ID,YEAR_STUDY,CLASS_OLD,YEAR_STUDY_OLD,REMARK,DATE_NOTE,STUDY_INFO_STATUS_ID,TEACHER_ID)VALUES(" & dg.Rows(i).Cells(3).Value & "," & dg.Rows(i).Cells(14).Value & ",N'" & dg.Rows(i).Cells(13).Value & "',N'" & dg.Rows(i).Cells(12).Value & "',N'" & dg.Rows(i).Cells(11).Value & "',N'" & dg.Rows(i).Cells(16).Value & "',GETDATE()," & dg.Rows(i).Cells(9).Value & "," & cboTeacher.SelectedValue & ")")
                    End If
                Next
                Call obj.ShowMsg("រក្សាទុកបានជោគជ័យ", FrmMessageSuccess, "success.wav")
                FrmStudent.SelectStudent()
                lblSave.Enabled = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Dim conc As String = cboNewYearStudy.Text
        Dim s As String() = conc.Split("-")
        Dim s1 As String = s(0)

        MsgBox(s1)

    End Sub

    Public Function SplitYear(ByVal sentence As String) As Integer
        Dim s As String() = sentence.Split("-")
        Dim s1 As String = s(0)
        Return Convert.ToInt32(s1)
    End Function
    Public Function SplitYearLast(ByVal sentence As String) As Integer
        Dim s As String() = sentence.Split("-")
        Dim s1 As String = s(1)
        Return Convert.ToInt32(s1)
    End Function

    Public Function ValidateClass(ByVal class_old As String, ByVal class_new As String) As Boolean
        Dim a As String = class_old.Substring(0, class_old.Length - 1)
        Dim b As String = class_new.Substring(0, class_new.Length - 1)
        If Convert.ToInt32(a) >= Convert.ToInt32(b) Then
            ValidateClass = False
        Else
            ValidateClass = True
        End If
        Return ValidateClass
    End Function






    Private Sub Label7_Click_1(sender As Object, e As EventArgs)
        Call CheckIfNewStudent()
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        lbl_search_Click(sender, e)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picUpgradeClass.Click
        lbl_upgrade_class_Click(sender, e)
    End Sub



    Private Function RecordExist() As Boolean
        Dim totalRow As Integer = 0
        Dim ds As New DataSet()

        For i As Integer = 0 To dg.RowCount - 1
            da = New SqlDataAdapter("Select  RECORD_ID from dbo.TBS_STUDENT_STUDY_INFO where STUDENT_ID = " & dg.Rows(i).Cells(2).Value & "  And YEAR_STUDY = N'" & cboNewYearStudy.Text & "'", conn)
            da.Fill(ds, "TBS_STUDENT_STUDY_INFO")
            totalRow = Convert.ToInt32(ds.Tables("TBS_STUDENT_STUDY_INFO").Rows.Count)
        Next

        If (totalRow > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cbo_old_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboOldYear.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_new_year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboNewYearStudy.KeyPress
        e.Handled = True
    End Sub
    Private Sub cbo_new_class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboNewClass.KeyPress
        e.Handled = True
    End Sub

    Private Sub Clear()
        dg.Rows.Clear()
        cboNewClass.Text = ""
        cboOldClass.Text = ""
        cboOldYear.Text = ""
        cboNewYearStudy.Text = ""
        cbCheckAll.Checked = False

    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Clear()
        cboOldYear.Focus()
    End Sub

    Private Sub cb_check_all_Click(sender As Object, e As EventArgs) Handles cbCheckAll.Click
        If (dg.Rows.Count <= 0) Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានជាមុន", FrmWarning, "Windows Ding.wav")
            cbCheckAll.Checked = False
            Exit Sub
        End If
    End Sub

    Private Sub lblNew_MouseHover(sender As Object, e As EventArgs) Handles lblNew.MouseHover
        t.Hover(lblNew)
    End Sub

    Private Sub lblNew_MouseLeave(sender As Object, e As EventArgs) Handles lblNew.MouseLeave
        t.Leave(lblNew)
    End Sub

    Private Sub dg_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dg.RowPrePaint
        Try
            If e.RowIndex >= 0 Then
                Call CountSearchResult()
                Call CountSelectedStudent()
                Call ChangeRowColor()

                dg.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        dg.EndEdit()
    End Sub

    Private Sub lblChangeStudyInfoStatus_Click(sender As Object, e As EventArgs) Handles lblChangStudyInfoStatus.Click
        Try
            Dim frm As New FrmChangeClass
            If isRowSelected() = False Then
                obj.ShowMsg("សូមជ្រើសរើសសិស្សជាមុន", FrmWarning, "")
                Exit Sub
            End If
            With frm
                For i As Integer = 0 To dg.Rows.Count - 1
                    If (dg.Rows(i).Cells(1).Value = True) Then
                        .dg.Rows.Add(dg.Rows(i).Cells(0).Value, dg.Rows(i).Cells(1).Value, "", dg.Rows(i).Cells(3).Value, dg.Rows(i).Cells(4).Value, dg.Rows(i).Cells(5).Value, dg.Rows(i).Cells(6).Value, dg.Rows(i).Cells(7).Value, dg.Rows(i).Cells(8).Value, dg.Rows(i).Cells(9).Value, dg.Rows(i).Cells(10).Value, dg.Rows(i).Cells(11).Value, dg.Rows(i).Cells(12).Value, dg.Rows(i).Cells(13).Value, dg.Rows(i).Cells(14).Value, dg.Rows(i).Cells(15).Value, dg.Rows(i).Cells(16).Value, dg.Rows(i).Cells(17).Value)
                    End If
                Next
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChangeRowColor()
        Try
            For i As Integer = 0 To dg.Rows.Count - 1
                If dg.Rows(i).Cells(1).Value = False Then
                    dg.Rows(i).DefaultCellStyle.BackColor = Color.White
                Else
                    dg.Rows(i).DefaultCellStyle.BackColor = Color.LightCyan
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblRevertSelection_Click(sender As Object, e As EventArgs) Handles lblRevertSelection.Click
        Try
            If (dg.Rows.Count > 0) Then
                For i As Integer = 0 To dg.Rows.Count - 1
                    If (dg.Rows(i).Cells(1).Value = True) Then
                        dg.Rows(i).Cells(1).Value = False
                    Else
                        dg.Rows(i).Cells(1).Value = True
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblChangStudyInfoStatus_MouseHover(sender As Object, e As EventArgs) Handles lblChangStudyInfoStatus.MouseHover
        t.Hover(lblChangStudyInfoStatus)
    End Sub

    Private Sub lblChangStudyInfoStatus_MouseLeave(sender As Object, e As EventArgs) Handles lblChangStudyInfoStatus.MouseLeave
        t.Leave(lblChangStudyInfoStatus)
    End Sub

    Private Sub lblPrint_MouseHover(sender As Object, e As EventArgs) Handles lblPrint.MouseHover
        t.Hover(lblPrint)
    End Sub

    Private Sub lblPrint_MouseLeave(sender As Object, e As EventArgs) Handles lblPrint.MouseLeave
        t.Leave(lblPrint)
    End Sub

    Private Sub lblRevertSelection_MouseHover(sender As Object, e As EventArgs) Handles lblRevertSelection.MouseHover
        t.Hover(lblRevertSelection)
    End Sub

    Private Sub lblRevertSelection_MouseLeave(sender As Object, e As EventArgs) Handles lblRevertSelection.MouseLeave
        t.Leave(lblRevertSelection)
    End Sub

    Private Sub lblDelete_MouseHover(sender As Object, e As EventArgs) Handles lblDelete.MouseHover
        t.Hover(lblDelete)
    End Sub

    Private Sub lblDelete_MouseLeave(sender As Object, e As EventArgs) Handles lblDelete.MouseLeave
        t.Leave(lblDelete)
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            obj.ShowMsg("តើអ្នកចង់លុបព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "")
            If USER_CLICK_OK = True Then
                For i As Integer = 0 To dg.Rows.Count - 1
                    If (dg.Rows(i).Cells(1).Value = True) Then
                        obj.Delete_1("DELETE FROM dbo.TBS_STUDENT_STUDY_INFO WHERE RECORD_ID =" & dg.Rows(i).Cells(0).Value & " AND STUDENT_ID = " & dg.Rows(i).Cells(3).Value & " AND CLASS_ID = " & dg.Rows(i).Cells(18).Value & " AND YEAR_STUDY = N'" & dg.Rows(i).Cells(11).Value & "'")
                    End If

                Next
                Call obj.ShowMsg("លុបបានជោគជ័យ", FrmMessageSuccess, "success.wav")
                Call Search()
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបាន!", FrmMessageError, "")
        End Try
    End Sub

    Private Sub lblPrint_Click(sender As Object, e As EventArgs) Handles lblPrint.Click
        Try
            If cboOldYear.Text = "" Then
                obj.ShowMsg("សូមជ្រើសរើសឆ្នាំសិក្សា", FrmWarning, "Windows Ding.wav")
                cboOldYear.BackColor = Color.LavenderBlush
                cboOldYear.Focus()
                Exit Sub
            End If
            If cboOldClass.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលជ្រើសរើសថ្នាក់", FrmWarning, "Windows Ding.wav")
                cboOldClass.BackColor = Color.LavenderBlush
                cboOldClass.Focus()
                Exit Sub
            End If
            PrintReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PrintReport()
        Try
            DataSet1.dtStudent.Clear()
            Call obj.OpenConnection()
            Dim sql As String = "SELECT ROW_NUMBER() OVER(ORDER BY SNAME_KH ASC) AS 'ROW_NUMBER',SNAME_KH,CLASS_MONITOR_NUM,GENDER,DOB_2,GUARDIAN_VILLAGE,CLASS_OLD FROM dbo.V_STUDENT_LIST_ALL_STATUS WHERE YEAR_STUDY_OLD = N'" & cboOldYear.Text & "' AND CLASS_ID = " & cboOldClass.SelectedValue & ""
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            DataSet1.dtStudent.Clear()
            da.Fill(DataSet1.dtStudent)

            Dim formReport As New FrmDynamicReportViewer

            formReport.SetupReport("DataSet1", "STU_MS.rpStudentList.rdlc", bsStudentList)

            obj.SendParam("paramSchoolName", obj.GetSchoolName(), formReport.ReportViewer)
            obj.SendParam("paramProvince", obj.GetProvinceName(), formReport.ReportViewer)
            obj.SendParam("paramClassName", cboOldClass.Text, formReport.ReportViewer)
            obj.SendParam("paramYearStudy", cboOldYear.Text, formReport.ReportViewer)
            formReport.ReportViewer.RefreshReport()
            formReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboTeacher_DropDown(sender As Object, e As EventArgs) Handles cboTeacher.DropDown
        obj.BindComboBox("SELECT  TEACHER_ID,T_NAME_KH FROM dbo.TBL_TEACHER WHERE TEACHER_STATUS_ID  IN(1,6)", cboTeacher, "T_NAME_KH", "TEACHER_ID")
    End Sub

    Private Sub cboTeacher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTeacher.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboTeacher_TextChanged(sender As Object, e As EventArgs) Handles cboTeacher.TextChanged
        cboTeacher.BackColor = Color.White
    End Sub

    Private Sub picChangeStudyStatus_MouseHover(sender As Object, e As EventArgs) Handles picChangeStudyStatus.MouseHover
        t.Hover(lblChangStudyInfoStatus)
    End Sub

    Private Sub picChangeStudyStatus_MouseLeave(sender As Object, e As EventArgs) Handles picChangeStudyStatus.MouseLeave
        t.Leave(lblChangStudyInfoStatus)
    End Sub

    Private Sub picPrint_MouseHover(sender As Object, e As EventArgs) Handles picPrint.MouseHover
        t.Hover(lblPrint)
    End Sub

    Private Sub picPrint_MouseLeave(sender As Object, e As EventArgs) Handles picPrint.MouseLeave
        t.Leave(lblPrint)
    End Sub

    Private Sub picPrint_Click(sender As Object, e As EventArgs) Handles picPrint.Click
        lblPrint_Click(sender, e)
    End Sub

    Private Sub picChangeStudyStatus_Click(sender As Object, e As EventArgs) Handles picChangeStudyStatus.Click
        lblChangeStudyInfoStatus_Click(sender, e)
    End Sub
End Class
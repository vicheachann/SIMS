Imports System.Data.SqlClient

Public Class FrmStudyInfo
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

    Private Function UserInSearchMode() As Boolean
        Dim result As Boolean = False
        If (cboOldClass.Text = Nothing) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Public Sub SelectSearchResult()
        Try
            Dim sql As String = "SELECT TOP (100) PERCENT  S.RECORD_ID,S.RECORD_ID_CONTROL_CLASS ,S.STUDENT_ID,I.SNAME_KH, I.GENDER, I.STUDENT_CODE,CONVERT(CHAR(10),I.DOB,120)AS 'DOB', I.GUARDIAN_VILLAGE,S.STUDY_INFO_STATUS_ID,ST .STUDY_INFO_STATUS_KH ,S.YEAR_STUDY,C.CLASS_LETTER, NULL AS 'NEW_YEAR_STUDY', NULL AS 'NEW_CLASS', S.REMARK,MT.CLASS_MONITOR_NUM,S.CLASS_ID,(SELECT RESULT FROM [dbo].[F_SEARCH_STUDENT](S.STUDENT_ID,'" & cboOldYear.Text & "')WHERE [STUDENT_ID]=S.STUDENT_ID) AS 'EXIST_NEXT_YEAR' FROM dbo.TBS_STUDENT_STUDY_INFO AS S INNER JOIN dbo.TBS_STUDENT_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON S.CLASS_ID = C.CLASS_ID INNER JOIN dbo.TBS_STUDENT_STUDY_INFO_STATUS AS ST ON S.STUDY_INFO_STATUS_ID = ST .STUDY_INFO_STATUS_ID LEFT  JOIN dbo.TBS_STUDENT_CLASS_MONITOR AS MT ON S.STUDENT_ID = MT.STUDENT_ID "

            If (Validation.IsEmpty(cboOldYear, "ឆ្នាំសិក្សា")) Then Exit Sub

            If (UserInSearchMode() = True) Then
                searchMode = True
                cmd = New SqlCommand(sql + "  WHERE S.YEAR_STUDY = N'" & cboOldYear.Text & "'  ORDER BY S.YEAR_STUDY, S.CLASS_ID, I.SNAME_KH", conn)
            Else
                searchMode = False
                cmd = New SqlCommand(sql + "   WHERE S.YEAR_STUDY = N'" & cboOldYear.Text & "' AND S.CLASS_ID = " & cboOldClass.SelectedValue & " ORDER BY S.YEAR_STUDY, S.CLASS_ID, I.SNAME_KH", conn)
            End If
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If (dt.Rows.Count <= 0) Then
                obj.ShowMsg("មិនមានទិន្នន័យ", FrmWarning, WARNING_SOUND)
                DataGridView1.Rows.Clear()
                Exit Sub
            Else
                cbCheckAll.Checked = False
                DataGridView1.Rows.Clear()
                For i As Integer = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add(dt.Rows(i)("RECORD_ID").ToString(), False, dt.Rows(i)("RECORD_ID_CONTROL_CLASS").ToString(), dt.Rows(i)("STUDENT_ID").ToString(), dt.Rows(i)("SNAME_KH").ToString(), dt.Rows(i)("GENDER").ToString(), dt.Rows(i)("STUDENT_CODE").ToString(), dt.Rows(i)("DOB").ToString(), dt.Rows(i)("GUARDIAN_VILLAGE").ToString(), dt.Rows(i)("STUDY_INFO_STATUS_ID").ToString(), dt.Rows(i)("STUDY_INFO_STATUS_KH").ToString(), dt.Rows(i)("YEAR_STUDY").ToString(), dt.Rows(i)("CLASS_LETTER").ToString(), dt.Rows(i)("NEW_YEAR_STUDY").ToString(), "", dt.Rows(i)("NEW_CLASS").ToString(), dt.Rows(i)("REMARK").ToString(), dt.Rows(i)("CLASS_MONITOR_NUM").ToString(), dt.Rows(i)("CLASS_ID").ToString(), dt.Rows(i)("EXIST_NEXT_YEAR"))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        Call SelectSearchResult()
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
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(1).Value = True Then Return True
        Next
        Return False
    End Function

    Private Function StudentAlreadyUpgrade() As Boolean
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If (DataGridView1.Rows(i).Cells("CHECKBOX").Value = True) Then
                    If DataGridView1.Rows(i).Cells("NEXT_YEAR_CLASS").Value.ToString = "YES" Then
                        obj.ShowMsg("សិស្សបានជ្រើសរើសបានតំឡើងថ្នាក់រួចរាល់ហើយ", FrmWarning, WARNING_SOUND)
                        Return True
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
    Private Function IfUserCheckOnDroppedStudentForUpgrade() As Boolean
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells("CHECKBOX").Value = True And DataGridView1.Rows(i).Cells("STUDY_STATUS_ID").Value = STUDY_INFO_STATUS.DROP Then
                    obj.ShowMsg("មិនអនុញ្ញាតអោយដំឡើងសិស្សដែលបោះបង់", FrmWarning, WARNING_SOUND)
                    Return True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Function IfUserCheckOnTransferredOutStudentForUpgrade() As Boolean
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells("CHECKBOX").Value = True And DataGridView1.Rows(i).Cells("STUDY_STATUS_ID").Value = STUDY_INFO_STATUS.TRANSFER_OUT Then
                    obj.ShowMsg("មិនអនុញ្ញាតអោយដំឡើងសិស្សដែលផ្ទេរចេញ", FrmWarning, WARNING_SOUND)
                    Return True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Function IfUserNotCheckAnyCheckbox() As Boolean
        Try
            If isRowSelected() = False Then
                obj.ShowMsg("អ្នកមិនទាន់ជ្រើសរើសសិស្សនោះទេ។ " & vbCrLf & "តើអ្នកចង់រើសយកទាំងអស់ដែលឬទេ?", FrmMessageQuestionLarge, POP_SOUND)
                If USER_CLICK_OK = True Then
                    cbCheckAll.Checked = True
                End If
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Function IfHasNoAnyStudentForUpgrade() As Boolean
        Try
            If DataGridView1.Rows.Count <= 0 Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានជាមុន", FrmWarning, WARNING_SOUND)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Function IfUserSearchTheWholeYearStudy() As Boolean
        Try
            If searchMode = True Then
                obj.ShowMsg("សូមជ្រើសរើសថ្នាក់ជាមុន", FrmWarning, WARNING_SOUND)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
    Private Function IfNewYearStudySmallerThenOldYearStudy() As Boolean
        Try
            If SplitYear(DataGridView1.Rows(0).Cells("OLD_YEAR_STUDY").Value) > SplitYear(cboNewYearStudy.Text) Then
                cboNewYearStudy.BackColor = Color.LavenderBlush
                cboNewYearStudy.Focus()
                obj.ShowMsg("ឆ្នាំសិក្សាថ្មីមិនអាចតូចជាងឆ្នាំសិក្សាចាស់", FrmWarning, WARNING_SOUND)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
    Private Function IfNewYearStudyEqualOldYearStudy() As Boolean
        Try
            If SplitYear(DataGridView1.Rows(0).Cells("OLD_YEAR_STUDY").Value) = SplitYear(cboNewYearStudy.Text) Then
                cboNewYearStudy.BackColor = Color.LavenderBlush
                cboNewYearStudy.Focus()
                obj.ShowMsg("ឆ្នាំសិក្សាថ្មីមិនដូចឆ្នាំសិក្សាចាស់", FrmWarning, "Windows Ding.wav")
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Function IfNewClassEqualToOldClass() As Boolean
        Try
            If DataGridView1.Rows(0).Cells("OLD_CLASS").Value = cboNewClass.Text Then
                obj.ShowMsg("ថ្នាក់ថ្មីមិនអាចដូចថ្នាក់ចាស់ទេ !", FrmWarning, WARNING_SOUND)
                cboNewClass.BackColor = Color.LavenderBlush
                cboNewClass.Focus()
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
    Private Function IfNewClassSmallerThenOldClass() As Boolean
        Try
            If ValidateClass(DataGridView1.Rows(0).Cells("OLD_CLASS").Value, cboNewClass.Text) = False Then
                cboNewClass.BackColor = Color.LavenderBlush
                cboNewClass.Focus()
                obj.ShowMsg("ថ្នាក់ថ្មីមិនអាចតូចជាងថ្នាក់ចាស់ទេ !", FrmWarning, "Windows Ding.wav")
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
    Private Function IfNotOrderYearStudy() As Boolean
        Try
            If (SplitYear(cboNewYearStudy.Text)) <> (Convert.ToInt32(SplitYear(cboOldYear.Text)) + 1).ToString Then
                cboNewYearStudy.BackColor = Color.LavenderBlush
                cboNewYearStudy.Focus()
                obj.ShowMsg("មិនអាចធ្វើការតំឡើងថ្នាក់ខុសលំដាប់ឆ្នាំសិក្សាបានទេ", FrmWarning, WARNING_SOUND)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Function IfNotOrderClass() As Boolean
        Try
            If (Convert.ToInt32(cboNewClass.Text.Substring(0, cboNewClass.Text.Length - 1))) <> (Convert.ToInt32(cboOldClass.Text.Substring(0, cboOldClass.Text.Length - 1))) + 1 Then
                cboNewClass.BackColor = Color.LavenderBlush
                cboNewClass.Focus()
                obj.ShowMsg("មិនអាចធ្វើការតំឡើងថ្នាក់ខុសលំដាប់ថ្នាក់បានទេ", FrmWarning, WARNING_SOUND)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Sub lblUpgradeClass_Click(sender As Object, e As EventArgs) Handles lblUpgradeClass.Click

        DataGridView1.EndEdit()

        If (IfUserSearchTheWholeYearStudy()) Then Exit Sub
        If (IfHasNoAnyStudentForUpgrade()) Then Exit Sub
        If (IfUserNotCheckAnyCheckbox()) Then Exit Sub
        If (StudentAlreadyUpgrade()) Then Exit Sub
        If (IfUserCheckOnDroppedStudentForUpgrade()) Then Exit Sub
        If (IfUserCheckOnTransferredOutStudentForUpgrade()) Then Exit Sub
        If (Validation.IsEmpty(cboNewYearStudy)) Then Exit Sub
        If (Validation.IsEmpty(cboNewClass)) Then Exit Sub
        If (IfNewYearStudySmallerThenOldYearStudy()) Then Exit Sub
        If (IfNewYearStudyEqualOldYearStudy()) Then Exit Sub
        If (IfNewClassEqualToOldClass()) Then Exit Sub
        If (IfNewClassSmallerThenOldClass()) Then Exit Sub
        If (IfNotOrderYearStudy()) Then Exit Sub
        If (IfNotOrderClass()) Then Exit Sub

        obj.ShowMsg("តើអ្នកចង់តំឡើងថ្នាក់ពីឆ្នាំសិក្សា " & DataGridView1.Rows(0).Cells(11).Value & " ថ្នាក់ទី " & DataGridView1.Rows(0).Cells(12).Value & "" & vbCrLf & " ទៅឆ្នាំសិក្សា " & cboNewYearStudy.Text & " ថ្នាក់ទី " & cboNewClass.Text & " ដែលឬទេ ?", FrmMessageQuestionLarge, "")
        If USER_CLICK_OK = True Then

            class_id = cboNewClass.SelectedValue
            lblSave.Enabled = True

            For Each rows As DataGridViewRow In DataGridView1.Rows
                If (rows.Cells("CHECKBOX").Value = True) Then
                    rows.Cells("STUDY_STATUS_ID").Value = STUDY_INFO_STATUS.NEW_CLASS
                    rows.Cells("STUDY_STATUS_KH").Value = "ឡើងថ្នាក់"
                    rows.Cells("NEW_YEAR_STUDY").Value = cboNewYearStudy.Text
                    rows.Cells("NEW_CLASS_ID").Value = cboNewClass.SelectedValue
                    rows.Cells("NEW_CLASS_KH").Value = cboNewClass.Text
                End If
            Next


        End If
    End Sub


    Private Sub CountSearchResult()
        Try
            Dim girl As Integer = 0

            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    If (DataGridView1.Rows(i).Cells(5).Value.ToString = "ស្រី") Then
                        girl += 1
                    End If
                Next
            End If
            lblTotalSearch.Text = DataGridView1.Rows.Count.ToString
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

            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    If (DataGridView1.Rows(i).Cells(1).Value = True) Then
                        toal += 1
                        If (DataGridView1.Rows(i).Cells(5).Value.ToString = "ស្រី") Then
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

    Private Sub cbCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbCheckAll.CheckedChanged
        If cbCheckAll.Checked = True Then
            For Each rows As DataGridViewRow In DataGridView1.Rows
                rows.Cells("CHECKBOX").Value = True
            Next
            UncheckStudentDropAndTransferOut()
        Else
            For Each rows As DataGridViewRow In DataGridView1.Rows
                rows.Cells("CHECKBOX").Value = False
            Next
        End If
    End Sub

    Private Sub UncheckStudentDropAndTransferOut()
        For Each rows As DataGridViewRow In DataGridView1.Rows
            If (rows.Cells("STUDY_STATUS_ID").Value.ToString = STUDY_INFO_STATUS.DROP) Then
                rows.Cells("CHECKBOX").Value = False
            End If
            If (rows.Cells("STUDY_STATUS_ID").Value.ToString = STUDY_INFO_STATUS.TRANSFER_OUT) Then
                rows.Cells("CHECKBOX").Value = False
            End If
        Next
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        DataGridView1.EndEdit()
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
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    Dim isSelected As Boolean = DataGridView1.Rows(i).Cells(1).Value
                    If isSelected = True Then
                        obj.InsertNoMsg("INSERT INTO dbo.TBS_STUDENT_STUDY_INFO (STUDENT_ID,CLASS_ID,YEAR_STUDY,CLASS_OLD,YEAR_STUDY_OLD,REMARK,DATE_NOTE,STUDY_INFO_STATUS_ID,TEACHER_ID)VALUES(" & DataGridView1.Rows(i).Cells(3).Value & "," & DataGridView1.Rows(i).Cells(14).Value & ",N'" & DataGridView1.Rows(i).Cells(13).Value & "',N'" & DataGridView1.Rows(i).Cells(12).Value & "',N'" & DataGridView1.Rows(i).Cells(11).Value & "',N'" & DataGridView1.Rows(i).Cells(16).Value & "',GETDATE()," & DataGridView1.Rows(i).Cells(9).Value & "," & cboTeacher.SelectedValue & ")")
                    End If
                Next
                obj.ReOrderList(DataGridView1.Rows(0).Cells("NEW_CLASS_ID").Value, DataGridView1.Rows(0).Cells("NEW_YEAR_STUDY").Value)
                Call obj.ShowMsg("រក្សាទុកបានជោគជ័យ", FrmMessageSuccess, SUCCESS_SOUND)
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
        lblSearch_Click(sender, e)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picUpgradeClass.Click
        lblUpgradeClass_Click(sender, e)
    End Sub



    Private Function CheckIfStudentExistInYearStudy() As Boolean
        Try
            Dim totalRow As Integer = 0
            Dim ds As New DataSet()

            For i As Integer = 0 To DataGridView1.RowCount - 1
                da = New SqlDataAdapter("SELECT  RECORD_ID from dbo.TBS_STUDENT_STUDY_INFO WHERE STUDENT_ID = " & DataGridView1.Rows(i).Cells("STUDENT_ID").Value & "  AND YEAR_STUDY = N'" & cboNewYearStudy.Text & "'", conn)
                da.Fill(ds, "TBS_STUDENT_STUDY_INFO")
                totalRow = Convert.ToInt32(ds.Tables("TBS_STUDENT_STUDY_INFO").Rows.Count)
            Next

            If (totalRow > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot check record exist")
            MessageBox.Show(ex.Message)
        End Try
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
        DataGridView1.Rows.Clear()
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
        If (DataGridView1.Rows.Count <= 0) Then
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

    Private Sub dg_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        Try
            If e.RowIndex >= 0 Then
                CountSearchResult()
                CountSelectedStudent()
                ChangeRowColor()
                AlignCenterColumn()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AlignCenterColumn()
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.EndEdit()
    End Sub

    Private Sub lblChangeStudyInfoStatus_Click(sender As Object, e As EventArgs) Handles lblChangStudyInfoStatus.Click
        Try
            Dim frm As New FrmChangeClass
            If isRowSelected() = False Then
                obj.ShowMsg("សូមជ្រើសរើសសិស្សជាមុន", FrmWarning, "")
                Exit Sub
            End If
            With frm
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    If (DataGridView1.Rows(i).Cells(1).Value = True) Then
                        .dg.Rows.Add(DataGridView1.Rows(i).Cells(0).Value, DataGridView1.Rows(i).Cells(1).Value, "", DataGridView1.Rows(i).Cells(3).Value, DataGridView1.Rows(i).Cells(4).Value, DataGridView1.Rows(i).Cells(5).Value, DataGridView1.Rows(i).Cells(6).Value, DataGridView1.Rows(i).Cells(7).Value, DataGridView1.Rows(i).Cells(8).Value, DataGridView1.Rows(i).Cells(9).Value, DataGridView1.Rows(i).Cells(10).Value, DataGridView1.Rows(i).Cells(11).Value, DataGridView1.Rows(i).Cells(12).Value, DataGridView1.Rows(i).Cells(13).Value, DataGridView1.Rows(i).Cells(14).Value, DataGridView1.Rows(i).Cells(15).Value, DataGridView1.Rows(i).Cells(16).Value, DataGridView1.Rows(i).Cells(17).Value)
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
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(1).Value = False Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightCyan
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblRevertSelection_Click(sender As Object, e As EventArgs) Handles lblRevertSelection.Click
        Try
            If (DataGridView1.Rows.Count > 0) Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    If (DataGridView1.Rows(i).Cells(1).Value = True) Then
                        DataGridView1.Rows(i).Cells(1).Value = False
                    Else
                        DataGridView1.Rows(i).Cells(1).Value = True
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
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    If (DataGridView1.Rows(i).Cells(1).Value = True) Then
                        obj.Delete_1("DELETE FROM dbo.TBS_STUDENT_STUDY_INFO WHERE RECORD_ID =" & DataGridView1.Rows(i).Cells(0).Value & " AND STUDENT_ID = " & DataGridView1.Rows(i).Cells(3).Value & " AND CLASS_ID = " & DataGridView1.Rows(i).Cells(18).Value & " AND YEAR_STUDY = N'" & DataGridView1.Rows(i).Cells(11).Value & "'")
                    End If

                Next
                Call obj.ShowMsg("លុបបានជោគជ័យ", FrmMessageSuccess, "success.wav")
                Call SelectSearchResult()
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
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

    Private Sub dg_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'Try
        '    If (dg.SelectedRows(0).Cells("CHECKBOX").Value = True) Then
        '        If (dg.SelectedRows(0).Cells("STUDY_STATUS_ID").Value = STUDY_INFO_STATUS.DROP) Then
        '            MessageBox.Show("cANNOT")
        '            dg.SelectedRows(0).Cells("CHECKBOX").Value = False
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
End Class
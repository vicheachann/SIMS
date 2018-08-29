Imports System.Data.SqlClient

Public Class FrmChangeClass
    Dim obj As New Method
    Dim t As New Theme

    Public Shared test As String = "hello"
    Public Shared studentID As Integer()

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frm_student_education.Search()
        Close()
    End Sub
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
    Private Sub cboNewClass_DropDown(sender As Object, e As EventArgs) Handles cboDynamic.DropDown
        'obj.Bind_combobox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboDynamic, "CLASS_LETTER", "CLASS_ID")
    End Sub

    Private Sub dg_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dg.RowPrePaint
        Try
            If (dg.RowCount > 0) Then
                Call CountSearchResult()
                Me.dg.Rows(e.RowIndex).Cells(2).Value = e.RowIndex + 1
                dg.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dg.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbFailedStudent.CheckedChanged
        Try
            If rbFailedStudent.Checked = True Then
                pnl1.Visible = True
                lblDynamic.Text = "ឆ្នាំសិក្សាថ្មី"
                lblSave.Text = "យល់ព្រម"
                cboDynamic.Focus()
                cboDynamic.DataSource = Nothing
                obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboDynamic, "YEAR_STUDY_KH", "YEAR_ID")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rbChangeClass_CheckedChanged(sender As Object, e As EventArgs) Handles rbChangeClass.CheckedChanged
        Try
            If rbChangeClass.Checked = True Then
                pnl1.Visible = True
                lblDynamic.Text = "ផ្ទេរទៅថ្នាក់"
                lblSave.Text = "ប្តូរថ្នាក់"
                cboDynamic.Focus()
                cboDynamic.DataSource = Nothing
                obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboDynamic, "CLASS_LETTER", "CLASS_ID")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        Try
            If (rbFailedStudent.Checked = True) Then
                If cboDynamic.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
                    cboDynamic.BackColor = Color.LavenderBlush
                    cboDynamic.Focus()
                    Exit Sub
                End If

                If frm_student_education.SplitYear(dg.Rows(0).Cells(11).Value) > frm_student_education.SplitYear(cboDynamic.Text) Then
                    cboDynamic.BackColor = Color.LavenderBlush
                    cboDynamic.Focus()
                    obj.ShowMsg("ឆ្នាំសិក្សាថ្មីមិនអាចតូចជាងឆ្នាំសិក្សាចាស់", FrmWarning, "Windows Ding.wav")
                    Exit Sub
                End If

                If frm_student_education.SplitYear(dg.Rows(0).Cells(11).Value) = frm_student_education.SplitYear(cboDynamic.Text) Then
                    cboDynamic.BackColor = Color.LavenderBlush
                    cboDynamic.Focus()
                    obj.ShowMsg("ឆ្នាំសិក្សាថ្មីមិនដូចឆ្នាំសិក្សាចាស់", FrmWarning, "Windows Ding.wav")
                    Exit Sub
                End If

                If (frm_student_education.SplitYear(cboDynamic.Text)) <> (Convert.ToInt32(frm_student_education.SplitYear(dg.Rows(0).Cells(11).Value)) + 1).ToString Then
                    cboDynamic.BackColor = Color.LavenderBlush
                    cboDynamic.Focus()
                    obj.ShowMsg("មិនអាចធ្វើការតំឡើងថ្នាក់ខុសលំដាប់ឆ្នាំសិក្សាបានទេ", FrmWarning, "Windows Ding.wav")
                    Exit Sub
                End If


                If (dg.Rows.Count > 0) Then
                    obj.ShowMsg("តើអ្នកចង់កំណត់សិស្សរៀនត្រួតថ្នាក់ដែលឬទេ ?", FrmMessageQuestion, "")
                    If USER_CLICK_OK = True Then
                        For i As Integer = 0 To dg.RowCount - 1
                            obj.InsertNoMsg("INSERT INTO dbo.TBS_STUDENT_STUDY_INFO (STUDENT_ID,CLASS_ID,YEAR_STUDY,CLASS_OLD,YEAR_STUDY_OLD,REMARK,DATE_NOTE,STUDY_INFO_STATUS_ID,TEACHER_ID)VALUES(" & dg.Rows(i).Cells(3).Value & "," & GetClassID(dg.Rows(i).Cells(12).Value) & ",N'" & cboDynamic.Text & "',N'" & dg.Rows(i).Cells(12).Value & "',N'" & dg.Rows(i).Cells(11).Value & "',N'" & dg.Rows(i).Cells(16).Value & "',GETDATE(),2,10)")
                        Next
                        Call obj.ShowMsg("រក្សាទុកបានជោគជ័យ", FrmMessageSuccess, "success.wav")
                    End If
                End If
            ElseIf (rbChangeClass.Checked = True) Then

                If cboDynamic.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
                    cboDynamic.BackColor = Color.LavenderBlush
                    cboDynamic.Focus()
                    Exit Sub
                End If

                If (cboDynamic.Text = dg.Rows(0).Cells(12).Value) Then
                    obj.ShowMsg("មិនអាចប្តូរទៅថ្នាក់ដដែល", FrmWarning, "Windows Ding.wav")
                    cboDynamic.BackColor = Color.LavenderBlush
                    cboDynamic.Focus()
                    Exit Sub
                End If

                If ValidateClass(dg.Rows(0).Cells(12).Value, cboDynamic.Text) = False Then
                    cboDynamic.BackColor = Color.LavenderBlush
                    cboDynamic.Focus()
                    obj.ShowMsg("ថ្នាក់ថ្មីមិនអាចតូចជាងថ្នាក់ចាស់ទេ !", FrmWarning, "Windows Ding.wav")
                    Exit Sub
                End If

                If (dg.Rows.Count > 0) Then
                    obj.ShowMsg("តើអ្នកចង់ប្តូរថ្នាក់សិស្សដែលឬទេ ?", FrmMessageQuestion, "")
                    If USER_CLICK_OK = True Then
                        For I As Integer = 0 To dg.Rows.Count - 1
                            obj.UpdateNoMsg("UPDATE dbo.TBS_STUDENT_STUDY_INFO SET CLASS_ID = " & cboDynamic.SelectedValue & " WHERE STUDENT_ID = " & dg.Rows(I).Cells(3).Value & " ")
                        Next
                        Call obj.ShowMsg("កែប្រែបានជោគជ័យ", FrmMessageSuccess, "success.wav")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetClassID(ByVal className As String) As String
        Dim classID As String = ""
        Try

            cmd = New SqlCommand("SELECT TOP(1) CLASS_ID FROM dbo.TBS_CLASS WHERE CLASS_LETTER = N'" & className & "'", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                classID = dt.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return classID
    End Function

    Public Function ValidateClass(ByVal class_old As String, ByVal class_new As String) As Boolean
        Dim a As String = class_old.Substring(0, class_old.Length - 1)
        Dim b As String = class_new.Substring(0, class_new.Length - 1)
        If Convert.ToInt32(a) > Convert.ToInt32(b) Then
            ValidateClass = False
        Else
            ValidateClass = True
        End If
        Return ValidateClass
    End Function

    Private Sub rbTranferIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbTranferIn.CheckedChanged
        Try
            If (rbTranferIn.Checked = True) Then
                pnl1.Visible = False
                If (dg.Rows.Count > 0) Then
                    obj.ShowMsg("តើអ្នកចង់កំណត់ជាសិស្សផ្ទេរចូលដែលឬទេ ?", FrmMessageQuestion, "")
                    If USER_CLICK_OK = True Then



                        For I As Integer = 0 To dg.Rows.Count - 1
                            obj.UpdateNoMsg("UPDATE dbo.TBS_STUDENT_STUDY_INFO SET STUDY_INFO_STATUS_ID = 3 WHERE STUDENT_ID = " & dg.Rows(I).Cells(3).Value & " ")
                        Next
                        Call obj.ShowMsg("កែប្រែបានជោគជ័យ", FrmMessageSuccess, "success.wav")


                    End If
                Else
                    obj.ShowMsg("មិនមានទិន្នន័យ", FrmWarning, "")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rbtransferOut_CheckedChanged(sender As Object, e As EventArgs) Handles rbtransferOut.CheckedChanged
        Try
            If (rbtransferOut.Checked = True) Then
                pnl1.Visible = False
                If (dg.Rows.Count > 0) Then
                    obj.ShowMsg("តើអ្នកចង់កំណត់ជាសិស្សផ្ទេរចេញដែលឬទេ ?", FrmMessageQuestion, "")
                    If USER_CLICK_OK = True Then
                        For I As Integer = 0 To dg.Rows.Count - 1
                            obj.UpdateNoMsg("UPDATE dbo.TBS_STUDENT_STUDY_INFO SET STUDY_INFO_STATUS_ID = 4 WHERE STUDENT_ID = " & dg.Rows(I).Cells(3).Value & " ")
                        Next
                        Call obj.ShowMsg("កែប្រែបានជោគជ័យ", FrmMessageSuccess, "success.wav")
                    End If
                Else
                    obj.ShowMsg("មិនមានទិន្នន័យ", FrmWarning, "")
                End If
            End If
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

    Private Sub rbFailedStudent_MouseHover(sender As Object, e As EventArgs) Handles rbFailedStudent.MouseHover
        rbFailedStudent.ForeColor = Color.Red
    End Sub

    Private Sub rbFailedStudent_MouseLeave(sender As Object, e As EventArgs) Handles rbFailedStudent.MouseLeave
        rbFailedStudent.ForeColor = Color.Navy
    End Sub

    Private Sub rbChangeClass_MouseHover(sender As Object, e As EventArgs) Handles rbChangeClass.MouseHover
        rbChangeClass.ForeColor = Color.Red
    End Sub

    Private Sub rbChangeClass_MouseLeave(sender As Object, e As EventArgs) Handles rbChangeClass.MouseLeave
        rbChangeClass.ForeColor = Color.Navy
    End Sub

    Private Sub rbTranferIn_MouseHover(sender As Object, e As EventArgs) Handles rbTranferIn.MouseHover
        rbTranferIn.ForeColor = Color.Red
    End Sub

    Private Sub rbTranferIn_MouseLeave(sender As Object, e As EventArgs) Handles rbTranferIn.MouseLeave
        rbTranferIn.ForeColor = Color.Navy
    End Sub

    Private Sub rbtransferOut_MouseHover(sender As Object, e As EventArgs) Handles rbtransferOut.MouseHover
        rbtransferOut.ForeColor = Color.Red
    End Sub

    Private Sub rbtransferOut_MouseLeave(sender As Object, e As EventArgs) Handles rbtransferOut.MouseLeave
        rbtransferOut.ForeColor = Color.Navy
    End Sub



    Private Sub lblSave_MouseHover(sender As Object, e As EventArgs) Handles lblSave.MouseHover
        t.Hover(lblSave)
    End Sub

    Private Sub lblSave_MouseLeave(sender As Object, e As EventArgs) Handles lblSave.MouseLeave
        lblSave.ForeColor = Color.Navy
    End Sub

    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub



    Private Sub rbDropStudy_MouseHover(sender As Object, e As EventArgs) Handles rbDropStudy.MouseHover
        rbDropStudy.ForeColor = Color.Red
    End Sub

    Private Sub rbDropStudy_MouseLeave(sender As Object, e As EventArgs) Handles rbDropStudy.MouseLeave
        rbDropStudy.ForeColor = Color.Navy
    End Sub

    Private Sub rbDropStudy_CheckedChanged(sender As Object, e As EventArgs) Handles rbDropStudy.CheckedChanged
        Try
            If (rbDropStudy.Checked = True) Then
                pnl1.Visible = False
                obj.ShowMsg("តើអ្នកចង់បញ្ចូលក្នុងសិស្សបោះបង់ការសិក្សាដែលឬទេ ?", msg_question_big, "")
                If USER_CLICK_OK = True Then
                    For i As Integer = 0 To dg.Rows.Count - 1
                        obj.InsertNoMsg("INSERT INTO dbo.TBS_STUDENT_STOP_STUDY(STUDENT_ID,FLAGE)VALUES(" & dg.Rows(i).Cells(3).Value & ",0)")
                        obj.UpdateNoMsg("UPDATE  dbo.TBS_STUDENT_INFO SET STUDENT_STATUS_ID = 4  WHERE STUDENT_ID = " & dg.Rows(i).Cells(3).Value & "")
                    Next
                    dg.Rows.Clear()
                    frm_student_stop_study.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblChangeToStudentFormer_MouseHover(sender As Object, e As EventArgs) Handles lblChangeToStudentFormer.MouseHover
        t.Hover(lblChangeToStudentFormer)
    End Sub

    Private Sub lblChangeToStudentFormer_MouseLeave(sender As Object, e As EventArgs) Handles lblChangeToStudentFormer.MouseLeave
        t.Leave(lblChangeToStudentFormer)
    End Sub

    Private Sub lblChangeToStudentFormer_Click(sender As Object, e As EventArgs) Handles lblChangeToStudentFormer.Click
        obj.ShowMsg("តើអ្នកចង់បញ្ចូលព័ត៌មានទាំងអស់នេះទៅជាអតីតសិស្សដែលឬទេ ?", msg_question_big, "")
        If USER_CLICK_OK = True Then
            Try
                Call GetStudentID()
                frmChangeStudentStatus.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
    Private Sub GetStudentID()
        Try
            If (dg.Rows.Count > 0) Then
                studentID = New Integer(dg.RowCount - 1) {}
                For i As Integer = 0 To dg.Rows.Count - 1
                    studentID(i) = dg.Rows(i).Cells(3).Value
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
Imports System.Data.SqlClient

Public Class frm_student_stop_study
    Dim obj As New Method
    Dim t As New Theme
    Dim ValidateState As Boolean
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Try
            Call FrmStudent.SelectStudent()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
    Private Sub frm_subject_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call cbo_stop_reason_DropDown(sender, e)
            Call cbo_teacher_DropDown(sender, e)
            txtSearch.SetWaterMark("ស្វែងរក...")
            Call Selection()
            Call PreInsertSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label13_MouseHover(sender As Object, e As EventArgs) Handles lblNew.MouseHover
        frm_teacher.SetHoverStyle(lblNew)
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles lblNew.MouseLeave
        frm_teacher.SetLeaveStyle(lblNew)
    End Sub

    Private Function ValidateControl() As Boolean

        If cboStudentName.Text = "" Then
            cboStudentName.BackColor = Color.LavenderBlush
            cboStudentName.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If

        If cboReason.Text = "" Then
            cboReason.BackColor = Color.LavenderBlush
            cboReason.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If

        If cbo_year_study.Text = "" Then
            cbo_year_study.BackColor = Color.LavenderBlush
            cbo_year_study.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If

        If cbo_class_stop.Text = "" Then
            cbo_class_stop.BackColor = Color.LavenderBlush
            cbo_class_stop.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If

        Return ValidateState
    End Function

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        Try
            If cboStudentName.Text = "" Or cboReason.Text = "" Or cbo_year_study.Text = "" Or cbo_class_stop.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                ValidateControl()
                If ValidateControl() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If

            obj.Insert("INSERT INTO dbo.TBS_STUDENT_STOP_STUDY (STUDENT_ID,STUDENT_STOP_REASON_ID,[DESCRIPTION],DATE_STOP,YEAR_STUDY,CLASS_STOP,DATE_NOTE,FLAGE)VALUES(" & cboStudentName.SelectedValue & "," & cboReason.SelectedValue & ",N'" & txt_des.Text & "','" & dtDateStop.Text & "',N'" & cbo_year_study.Text & "',N'" & cbo_class_stop.Text & "',GETDATE(),1)")
            obj.UpdateNoMsg("UPDATE  dbo.TBS_STUDENT_INFO SET STUDENT_STATUS_ID = 4  WHERE STUDENT_ID = " & cboStudentName.SelectedValue & "")
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការបញ្ជូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub cbo_teacher_DropDown(sender As Object, e As EventArgs) Handles cboStudentName.DropDown
        obj.BindComboBox("SELECT STUDENT_ID,SNAME_KH FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_STATUS_ID = 1", cboStudentName, "SNAME_KH", "STUDENT_ID")
    End Sub

    Private Sub Selection()
        Try
            Dim SQL As String
            SQL = "SELECT S.RECORD_ID,ROW_NUMBER() OVER(ORDER BY S.RECORD_ID ASC) AS 'ROW_NUM', S.STUDENT_ID, I.SNAME_KH, R.STUDENT_STOP_REASON_KH, S.DATE_STOP, S.YEAR_STUDY, S.CLASS_STOP,S.[DESCRIPTION], S.DATE_NOTE FROM dbo.TBS_STUDENT_STOP_STUDY AS S INNER JOIN dbo.TBS_STUDENT_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_STUDENT_STOP_REASON AS R ON S.STUDENT_STOP_REASON_ID = R.STUDENT_STOP_REASON_ID WHERE S.FLAGE = 1"
            obj.BindDataGridView(SQL, dgMain)
            Call SetTitle()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub PreInsertSelection()
        Try
            obj.BindDataGridView("SELECT S.RECORD_ID,ROW_NUMBER() OVER(ORDER BY S.RECORD_ID ASC) AS 'ROW_NUM', I.SNAME_KH FROM dbo.TBS_STUDENT_STOP_STUDY AS S INNER JOIN dbo.TBS_STUDENT_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID WHERE  FLAGE = 0", dgPreInsert)
            dgPreInsert.Columns(0).Visible = False 'RECORD_ID
            dgPreInsert.Columns(1).HeaderText = "លរ"
            dgPreInsert.Columns(1).Width = 50
            dgPreInsert.Columns(2).HeaderText = "ឈ្មោះ"
            dgPreInsert.Columns(2).Width = 200
            dgPreInsert.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub SetTitle()
        dgMain.Columns(0).Visible = False 'Record ID

        dgMain.Columns(1).HeaderText = "លរ"
        dgMain.Columns(1).Width = 50

        dgMain.Columns(2).Visible = False 'Student Id

        dgMain.Columns(3).HeaderText = "ឈ្មោះសិស្ស"
        dgMain.Columns(3).Width = 130

        dgMain.Columns(4).HeaderText = "មូលហេតុ"
        dgMain.Columns(4).Width = 200

        dgMain.Columns(5).HeaderText = "ថ្ងៃឈប់"
        dgMain.Columns(5).Width = 120

        dgMain.Columns(6).HeaderText = "ឆ្នាំសិក្សា"
        dgMain.Columns(6).Width = 120

        dgMain.Columns(7).HeaderText = "ថ្នាក់ឈប់"
        dgMain.Columns(7).Width = 80

        dgMain.Columns(8).HeaderText = "ផ្សេងៗ"
        dgMain.Columns(8).Width = 400

        dgMain.Columns(9).Visible = False 'Datenote

        dgMain.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub Clear()
        cboStudentName.Text = ""
        cboReason.Text = ""
        txt_des.Clear()
        dtDateStop.Text = "10/25/1996"
        cbo_year_study.Text = ""
        cbo_class_stop.Text = ""
        dt_datenote.Text = Date.Today

    End Sub


    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Clear()

        cboStudentName.Enabled = True
        lblSave.Enabled = True
        lblUpdate.Enabled = False
        lblDelete.Enabled = False
        lblUpdate.Text = "កែប្រែ"
        Me.lblDelete.Location = New System.Drawing.Point(742, 262)
        cboStudentName.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        Try
            If (dgMain.Rows.Count > 0) Then
                idx = dgMain.SelectedCells(0).RowIndex.ToString()
            End If

            obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "")
            If USER_CLICK_OK = True Then

                If cboStudentName.Text = "" Or cboReason.Text = "" Or cbo_year_study.Text = "" Or cbo_class_stop.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                    ValidateControl()
                    If ValidateControl() = False Then
                        Exit Sub
                    End If
                    Exit Sub
                End If
                obj.Update("UPDATE dbo.TBS_STUDENT_STOP_STUDY SET STUDENT_STOP_REASON_ID = " & cboReason.SelectedValue & ",DESCRIPTION = N'" & txt_des.Text & "',DATE_STOP = '" & dtDateStop.Text & "',YEAR_STUDY = N'" & cbo_year_study.Text & "',CLASS_STOP =N'" & cbo_class_stop.Text & "',FLAGE = 1 WHERE RECORD_ID = " & txtRecordID.Text & "")
                Call Selection()
                Call PreInsertSelection()

                dgMain.Rows(idx).Selected = True
                dgMain.CurrentCell = dgMain.SelectedCells(1)
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការកែប្រែបាន", FrmMessageError, "")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            obj.ShowMsg("តើអ្នកចង់លុបព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "")
            If USER_CLICK_OK = True Then
                obj.Delete("DELETE from dbo.TBS_STUDENT_STOP_STUDY WHERE RECORD_ID = " & txtRecordID.Text & "")
                obj.UpdateNoMsg("UPDATE  dbo.TBS_STUDENT_INFO Set STUDENT_STATUS_ID = 1  WHERE STUDENT_ID = " & dgMain.SelectedCells(2).Value & "")
                Call Selection()
                Call PreInsertSelection()
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបាន!", FrmMessageError, "")
        End Try
    End Sub

    Private Sub cbo_year_study_DropDown(sender As Object, e As EventArgs) Handles cbo_year_study.DropDown
        obj.BindComboBox("Select YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cbo_year_study, "YEAR_STUDY_KH", "YEAR_ID")

    End Sub

    Private Sub cbo_class_stop_DropDown(sender As Object, e As EventArgs) Handles cbo_class_stop.DropDown
        obj.BindComboBox("Select CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cbo_class_stop, "CLASS_LETTER", "CLASS_ID")
    End Sub

    Private Sub lbl_class_stop_Click(sender As Object, e As EventArgs) Handles lbl_class_stop.Click
        frm_class.ShowDialog()
    End Sub

    Private Sub lbl_year_study_Click(sender As Object, e As EventArgs) Handles lbl_year_study.Click
        frm_year_study.ShowDialog()
    End Sub

    Private Sub cbo_stop_reason_DropDown(sender As Object, e As EventArgs) Handles cboReason.DropDown
        obj.BindComboBox("Select STUDENT_STOP_REASON_ID,STUDENT_STOP_REASON_KH FROM dbo.TBS_STUDENT_STOP_REASON", cboReason, "STUDENT_STOP_REASON_KH", "STUDENT_STOP_REASON_ID")
    End Sub

    Private Sub cbo_stop_reason_TextChanged(sender As Object, e As EventArgs) Handles cboReason.TextChanged
        cboReason.BackColor = Color.White
    End Sub

    Private Sub cbo_student_name_TextChanged(sender As Object, e As EventArgs) Handles cboStudentName.TextChanged
        cboStudentName.BackColor = Color.White
    End Sub

    Private Sub cbo_year_study_TextChanged(sender As Object, e As EventArgs) Handles cbo_year_study.TextChanged
        cbo_year_study.BackColor = Color.White
    End Sub

    Private Sub cbo_class_stop_TextChanged(sender As Object, e As EventArgs) Handles cbo_class_stop.TextChanged
        cbo_class_stop.BackColor = Color.White
    End Sub



    Private Sub lbl_reason_Click(sender As Object, e As EventArgs) Handles lbl_reason.Click
        FrmStudentDropStudyReason.ShowDialog()
    End Sub

    Private Sub datagridview_SelectionChanged_1(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Call MainSelectionChange()
    End Sub

    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.Hover(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        txtSearch.Clear()
        Call Selection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim SQL As String
            SQL = "Select S.RECORD_ID,ROW_NUMBER() OVER(ORDER BY S.RECORD_ID ASC) As 'ROW_NUM', S.STUDENT_ID, I.SNAME_KH, R.STUDENT_STOP_REASON_KH, S.DATE_STOP, S.YEAR_STUDY, S.CLASS_STOP,S.[DESCRIPTION], S.DATE_NOTE FROM dbo.TBS_STUDENT_STOP_STUDY AS S INNER JOIN dbo.TBS_STUDENT_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_STUDENT_STOP_REASON AS R ON S.STUDENT_STOP_REASON_ID = R.STUDENT_STOP_REASON_ID WHERE  I.SNAME_KH + CAST(S.DATE_STOP AS NVARCHAR(50))+ S.YEAR_STUDY + S.CLASS_STOP +CAST(S.STUDENT_ID  AS NVARCHAR(50))  LIKE N'%" & txtSearch.Text & "%'"
            obj.BindDataGridView(SQL, dgMain)
            Call SetTitle()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub dgIncomplete_SelectionChanged(sender As Object, e As EventArgs) Handles dgPreInsert.SelectionChanged
        Call PreInsertSelectionChange()
    End Sub



    Private Sub dgPreInsert_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPreInsert.CellClick
        Call PreInsertSelectionChange()
    End Sub
    Private Sub MainSelectionChange()
        Try
            If (dgMain.SelectedRows.Count = 0) Then
                Exit Sub
            Else
                lblSave.Enabled = False
                lblUpdate.Enabled = True
                lblDelete.Enabled = True
                lblNew.Enabled = True
                cboStudentName.Enabled = False
                lblUpdate.Text = "កែប្រែ"
                Me.lblDelete.Location = New System.Drawing.Point(742, 262)

                Call Clear()

                txtRecordID.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(0).Value)
                cboStudentName.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(3).Value)
                cboReason.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(4).Value)
                txt_des.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(8).Value)
                dtDateStop.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(5).Value)
                cbo_year_study.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(6).Value)
                cbo_class_stop.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(7).Value)
                dt_datenote.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(9).Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PreInsertSelectionChange()
        Try
            lblSave.Enabled = False
            lblUpdate.Enabled = True
            lblDelete.Enabled = True
            lblUpdate.Text = "បញ្ចូលព័ត៌មាន"
            cboStudentName.Enabled = False
            cboReason.Focus()
            Me.lblDelete.Location = New System.Drawing.Point(800, 262)

            If (dgPreInsert.SelectedRows.Count = 0) Then
                Exit Sub
            Else
                If dgPreInsert.Rows.Count > 0 Then
                    Clear()
                    txtRecordID.Text = obj.IfDbNull(dgPreInsert.SelectedCells(0).Value)
                    cboStudentName.Text = obj.IfDbNull(dgPreInsert.SelectedCells(2).Value)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellClick
        Call MainSelectionChange()
    End Sub

    Private Sub cbo_class_stop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_class_stop.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_year_study_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_year_study.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboReason_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboReason.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboStudentName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboStudentName.KeyPress
        e.Handled = True
    End Sub
End Class
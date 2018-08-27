Public Class frm_student_suspent
    Dim obj As New Method
    Dim ValidateState As Boolean
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Call FrmStudent.SelectStudent()
        Me.Close()
    End Sub

    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles btn_save.MouseHover
        frm_teacher.SetHoverStyle(btn_save)

    End Sub

    Private Sub btn_update_MouseHover(sender As Object, e As EventArgs) Handles btn_update.MouseHover
        frm_teacher.SetHoverStyle(btn_update)
    End Sub

    Private Sub btn_remove_MouseHover(sender As Object, e As EventArgs) Handles btn_delete.MouseHover
        frm_teacher.SetHoverStyle(btn_delete)

    End Sub

    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_save.MouseLeave
        frm_teacher.SetLeaveStyle(btn_save)
    End Sub

    Private Sub btn_update_MouseLeave(sender As Object, e As EventArgs) Handles btn_update.MouseLeave
        frm_teacher.SetLeaveStyle(btn_update)
    End Sub

    Private Sub btn_remove_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
        frm_teacher.SetLeaveStyle(btn_delete)
    End Sub



    Private Sub frm_subject_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call Selection()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Label13_MouseHover(sender As Object, e As EventArgs) Handles btn_new.MouseHover
        frm_teacher.SetHoverStyle(btn_new)
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles btn_new.MouseLeave
        frm_teacher.SetLeaveStyle(btn_new)
    End Sub

    Private Function ValidateControl() As Boolean
        'Name
        If cbo_student_name.Text = "" Then
            cbo_student_name.BackColor = Color.LavenderBlush
            cbo_student_name.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'Duration
        If txt_duration.Text = "" Then
            txt_duration.BackColor = Color.LavenderBlush
            txt_duration.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'reason
        If txt_reason.Text = "" Then
            txt_reason.BackColor = Color.LavenderBlush
            txt_reason.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        Return ValidateState
    End Function

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If cbo_student_name.Text = "" Or txt_duration.Text = "" Or txt_reason.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                ValidateControl()
                If ValidateControl() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If
            obj.Insert("INSERT INTO dbo.TBS_STUDENT_SUSPEND (STUDENT_ID,[START_DATE],END_DATE,DURATION,REASON," & vbCrLf &
"[DESCRIPTION],DATE_NOTE)VALUES(" & cbo_student_name.SelectedValue & ",'" & dt_start_date.Text & "','" & dt_end_date.Text & "'," & txt_duration.Text & ",N'" & txt_reason.Text & "',N'" & txt_remark.Text & "',GETDATE())")

            Call UpdateStudentStatus()
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការបញ្ជូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub cbo_teacher_DropDown(sender As Object, e As EventArgs) Handles cbo_student_name.DropDown
        obj.BindComboBox("SELECT STUDENT_ID,SNAME_KH FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_STATUS_ID = 1", cbo_student_name, "SNAME_KH", "STUDENT_ID")


    End Sub











    Private Sub Selection()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT SS.RECORD_ID,ROW_NUMBER() OVER(ORDER BY SS.RECORD_ID asc) AS 'ROW_NUM',SS.STUDENT_ID,S.SNAME_KH,SS.[START_DATE],SS.END_DATE,SS.DURATION,SS.REASON,SS.[DESCRIPTION],SS.DATE_NOTE FROM dbo.TBS_STUDENT_SUSPEND AS SS INNER JOIN dbo.TBS_STUDENT_INFO AS S ON  SS.STUDENT_ID = S.STUDENT_ID "
            obj.BindDataGridView(SqlQueryStr, datagrid)
            Call SetTitle()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub SetTitle()
        datagrid.Columns(0).Visible = False 'Record ID
        datagrid.Columns(2).Visible = False 'StudentID
        datagrid.Columns(9).Visible = False 'Datenote

        datagrid.Columns(1).HeaderText = "លរ"
        datagrid.Columns(1).Width = 50

        datagrid.Columns(3).HeaderText = "ឈ្មោះសិស្ស"
        datagrid.Columns(3).Width = 200


        datagrid.Columns(4).HeaderText = "ថ្ងៃចាប់ផ្តើមព្យួរ"
        datagrid.Columns(4).Width = 200

        datagrid.Columns(5).HeaderText = "ថ្ងៃចូលរៀនវិញ"
        datagrid.Columns(5).Width = 200

        datagrid.Columns(6).HeaderText = "រយៈពេល"
        datagrid.Columns(6).Width = 100

        datagrid.Columns(7).HeaderText = "មូលហេតុ"
        datagrid.Columns(7).Width = 200

        datagrid.Columns(8).HeaderText = "ផ្សេងៗ"
        datagrid.Columns(8).Width = 300



    End Sub

    Private Sub Clear()
        cbo_student_name.Text = ""
        dt_start_date.Text = Date.Today
        dt_end_date.Text = Date.Today
        txt_duration.Clear()
        txt_reason.Clear()
        txt_remark.Clear()


    End Sub
    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        Try

            Call cbo_teacher_DropDown(sender, e)


            If datagrid.RowCount > 0 Then
                Call Clear()

                cbo_student_name.Text = If(datagrid.SelectedRows(0).Cells(3).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(3).Value)
                dt_start_date.Text = If(datagrid.SelectedRows(0).Cells(4).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(4).Value)
                dt_end_date.Text = If(datagrid.SelectedRows(0).Cells(5).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(5).Value)
                txt_duration.Text = If(datagrid.SelectedRows(0).Cells(6).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(6).Value)
                txt_reason.Text = If(datagrid.SelectedRows(0).Cells(7).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(7).Value)
                txt_remark.Text = If(datagrid.SelectedRows(0).Cells(8).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(8).Value)
                dt_datenote.Text = If(datagrid.SelectedRows(0).Cells(9).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(9).Value)



                btn_save.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
                btn_new.Enabled = True
                cbo_student_name.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Clear()
        cbo_student_name.Enabled = True
        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False

        cbo_student_name.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            idx = datagrid.SelectedCells(0).RowIndex.ToString()
            obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then

                'Validate
                If cbo_student_name.Text = "" Or txt_duration.Text = "" Or txt_reason.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                    ValidateControl()
                    If ValidateControl() = False Then
                        Exit Sub
                    End If
                    Exit Sub
                End If
                'Update SQL
                obj.Update("UPDATE dbo.TBS_STUDENT_SUSPEND set START_DATE = '" & dt_start_date.Text & "',END_DATE = '" & dt_end_date.Text & "',DURATION = " & txt_duration.Text & "," & vbCrLf &
"REASON = N'" & txt_reason.Text & "',DESCRIPTION = N'" & txt_remark.Text & "' WHERE RECORD_ID =" & datagrid.SelectedCells(0).Value & " AND STUDENT_ID = " & datagrid.SelectedCells(2).Value & "  AND START_DATE = '" & datagrid.SelectedCells(4).Value & "'")

                Call Selection()
                datagrid.Rows(idx).Selected = True
                datagrid.CurrentCell = datagrid.SelectedCells(1)
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការកែប្រែបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            obj.ShowMsg("តើអ្នកចង់លប់ព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then
                obj.Delete("DELETE FROM dbo.TBS_STUDENT_SUSPEND WHERE RECORD_ID =" & datagrid.SelectedCells(0).Value & " AND STUDENT_ID = " & datagrid.SelectedCells(2).Value & "  AND START_DATE = '" & datagrid.SelectedCells(4).Value & "'")
                obj.UpdateNoMsg("UPDATE dbo.TBS_STUDENT_INFO SET STUDENT_STATUS_ID = 1 WHERE STUDENT_ID = " & datagrid.SelectedCells(2).Value & "")
                Call Selection()
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបាន!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub lbl_class_stop_Click(sender As Object, e As EventArgs)
        frm_class.ShowDialog()
    End Sub

    Private Sub lbl_year_study_Click(sender As Object, e As EventArgs)
        frm_year_study.ShowDialog()
    End Sub


    Private Sub UpdateStudentStatus()
        Try
            obj.UpdateNoMsg("UPDATE dbo.TBS_STUDENT_INFO SET STUDENT_STATUS_ID = 2 WHERE STUDENT_ID = " & cbo_student_name.SelectedValue & "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   
    
    Private Sub cbo_student_name_TextChanged(sender As Object, e As EventArgs) Handles cbo_student_name.TextChanged
        cbo_student_name.BackColor = Color.White

    End Sub

    Private Sub txt_duration_TextChanged(sender As Object, e As EventArgs) Handles txt_duration.TextChanged
        txt_duration.BackColor = Color.White
    End Sub

    Private Sub txt_reason_TextChanged(sender As Object, e As EventArgs) Handles txt_reason.TextChanged
        txt_reason.BackColor = Color.White
    End Sub

    Private Sub cbo_student_name_DropDownClosed(sender As Object, e As EventArgs) Handles cbo_student_name.DropDownClosed

    End Sub

    Private Sub txt_duration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_duration.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT SS.RECORD_ID,ROW_NUMBER() OVER(ORDER BY SS.RECORD_ID asc) AS 'ROW_NUM',SS.STUDENT_ID,S.SNAME_KH,SS.[START_DATE],SS.END_DATE,SS.DURATION,SS.REASON,SS.[DESCRIPTION],SS.DATE_NOTE FROM dbo.TBS_STUDENT_SUSPEND AS SS INNER JOIN dbo.TBS_STUDENT_INFO AS S ON  SS.STUDENT_ID = S.STUDENT_ID WHERE CAST(SS.STUDENT_ID   AS NVARCHAR(50)) + SS.REASON + S.SNAME_KH + CAST(SS.END_DATE   AS NVARCHAR(50)) + CAST(SS.START_DATE   AS NVARCHAR(50))LIKE N'%" & txtSearch.Text & "%'"
            obj.BindDataGridView(SqlQueryStr, datagrid)
            Call SetTitle()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        txtSearch.Clear()
        Call Selection()
    End Sub
    Dim t As New Theme
    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.Hover(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)
    End Sub
End Class
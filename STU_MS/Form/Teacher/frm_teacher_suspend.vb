Public Class frm_teacher_suspend
    Dim obj As New Method
    Dim ValidateState As Boolean
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
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

        If txt_suspend_letter_num.Text = "" Then
            txt_suspend_letter_num.BackColor = Color.LavenderBlush
            txt_suspend_letter_num.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
       
        If txt_suspend_num.Text = "" Then
            txt_suspend_num.BackColor = Color.LavenderBlush
            txt_suspend_num.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        If cbo_teacher.Text = "" Then
            cbo_teacher.BackColor = Color.LavenderBlush
            cbo_teacher.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        If txt_reason.Text = "" Then
            txt_reason.BackColor = Color.LavenderBlush
            txt_reason.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        If txt_duration.Text = "" Then
            txt_duration.BackColor = Color.LavenderBlush
            txt_duration.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        Return ValidateState
    End Function

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_suspend_letter_num.Text = "" Or txt_suspend_num.Text = "" Or cbo_teacher.Text = "" Or txt_reason.Text = "" Or txt_duration.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                ValidateControl()
                If ValidateControl() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If
            'End Validate
            obj.Insert("INSERT INTO dbo.TBL_TEACHER_SUSPEND (SUSPEND_LETTER_NUMBER," & vbCrLf &
"SUSPEND_NUMER,TEACHER_ID,[START_DATE],END_DATE,DURATION,REASON,[DESCRIPTION]," & vbCrLf &
"DATE_NOTE)VALUES(N'" & txt_suspend_letter_num.Text & "',N'" & txt_suspend_num.Text & "'," & cbo_teacher.SelectedValue & ",'" & dt_start_date.Text & "','" & dt_end_date.Text & "'," & txt_duration.Text & ",N'" & txt_reason.Text & "',N'" & txt_remark.Text & "',GETDATE())")
            obj.UpdateNoMsg("UPDATE dbo.TBL_TEACHER SET TEACHER_STATUS_ID = 2 WHERE TEACHER_ID =" & cbo_teacher.SelectedValue & "")
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការបញ្ជូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub cbo_teacher_DropDown(sender As Object, e As EventArgs) Handles cbo_teacher.DropDown
        obj.BindComboBox("select  TEACHER_ID,T_NAME_KH from dbo.TBL_TEACHER where TEACHER_STATUS_ID != 2", cbo_teacher, "T_NAME_KH", "TEACHER_ID")

    End Sub

 

    

    Private Sub cbo_teacher_TextChanged(sender As Object, e As EventArgs) Handles cbo_teacher.TextChanged
        cbo_teacher.BackColor = Color.White

    End Sub


    Private Sub txt_letter_number_TextChanged(sender As Object, e As EventArgs) Handles txt_suspend_letter_num.TextChanged
        txt_suspend_letter_num.BackColor = Color.White

    End Sub


    Private Sub Selection()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     TS.RECORD_ID,ROW_NUMBER ()OVER(ORDER BY TS.RECORD_ID ASC )AS 'ORDER_NUMBER', TS.SUSPEND_LETTER_NUMBER, TS.SUSPEND_NUMER, TS.TEACHER_ID, T.T_NAME_KH, TS.START_DATE, TS.END_DATE, CAST(TS.DURATION AS INT), TS.REASON, TS.DESCRIPTION, " & vbCrLf &
"                      TS.DATE_NOTE" & vbCrLf &
"FROM         dbo.TBL_TEACHER_SUSPEND AS TS INNER JOIN" & vbCrLf &
"                      dbo.TBL_TEACHER AS T ON TS.TEACHER_ID = T.TEACHER_ID"


            obj.BindDataGridView(SqlQueryStr, datagrid)
            Call SetTitle()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub SetTitle()
        datagrid.Columns(0).Visible = False 'Record ID
        datagrid.Columns(4).Visible = False 'Teacher ID
        datagrid.Columns(11).Visible = False 'Date Note

        datagrid.Columns(1).HeaderText = "លរ"
        datagrid.Columns(1).Width = 50

        datagrid.Columns(2).HeaderText = "លេខលិខិតព្យួរការងារ"
        datagrid.Columns(2).Width = 130

        datagrid.Columns(3).HeaderText = "លេខព្យួរការងារ"
        datagrid.Columns(3).Width = 130

        datagrid.Columns(5).HeaderText = "ឈ្មោះគ្រូបង្រៀន"
        datagrid.Columns(5).Width = 200



        datagrid.Columns(6).HeaderText = "ថ្ងៃខែព្យួរការងារ"
        datagrid.Columns(6).Width = 200

        datagrid.Columns(7).HeaderText = "ថ្ងៃខែចូលបម្រើការងារវិញ"
        datagrid.Columns(7).Width = 200

        datagrid.Columns(8).HeaderText = "រយៈព្យួរការងារ"
        datagrid.Columns(8).Width = 150

        datagrid.Columns(9).HeaderText = "មូលហេតុ"
        datagrid.Columns(9).Width = 300
        datagrid.Columns(10).HeaderText = "ផ្សេងៗ"
        datagrid.Columns(10).Width = 150


    End Sub

    Private Sub Clear()
        txt_suspend_letter_num.Clear()
        txt_suspend_num.Clear()
        cbo_teacher.Text = ""
        txt_reason.Clear()
        dt_start_date.Text = Date.Today
        dt_end_date.Text = Date.Today
        txt_duration.Clear()
        txt_remark.Clear()
        dt_datenote.Text = Date.Today
    End Sub
    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        Try
            Call cbo_teacher_DropDown(sender, e)

            Call Clear()

            If datagrid.RowCount > 0 Then
                txt_suspend_letter_num.Text = datagrid.SelectedRows(0).Cells(2).Value.ToString
                txt_suspend_num.Text = datagrid.SelectedRows(0).Cells(3).Value.ToString
                cbo_teacher.Text = datagrid.SelectedRows(0).Cells(5).Value.ToString
                txt_reason.Text = datagrid.SelectedRows(0).Cells(9).Value.ToString
                dt_start_date.Text = datagrid.SelectedRows(0).Cells(6).Value.ToString
                dt_end_date.Text = datagrid.SelectedRows(0).Cells(7).Value.ToString
                txt_duration.Text = datagrid.SelectedRows(0).Cells(8).Value.ToString
                txt_remark.Text = datagrid.SelectedRows(0).Cells(10).Value.ToString
                dt_datenote.Text = datagrid.SelectedRows(0).Cells(11).Value.ToString

                btn_save.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
                btn_new.Enabled = True
                cbo_teacher.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        cbo_teacher.Enabled = True

        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
        Clear()
        txt_suspend_letter_num.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            idx = datagrid.SelectedCells(0).RowIndex.ToString()
            obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then

                'Validate
                If txt_suspend_letter_num.Text = "" Or txt_suspend_num.Text = "" Or cbo_teacher.Text = "" Or txt_reason.Text = "" Or txt_duration.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                    ValidateControl()
                    If ValidateControl() = False Then
                        Exit Sub
                    End If
                    Exit Sub
                End If
                     


                obj.Update("UPDATE dbo.TBL_TEACHER_SUSPEND SET " & vbCrLf &
"SUSPEND_LETTER_NUMBER = N'" & txt_suspend_letter_num.Text & "'," & vbCrLf &
"SUSPEND_NUMER = N'" & txt_suspend_num.Text & "'," & vbCrLf &
"TEACHER_ID = " & cbo_teacher.SelectedValue & "," & vbCrLf &
"[START_DATE] = '" & dt_start_date.Text & "'," & vbCrLf &
"END_DATE = '" & dt_end_date.Text & "'," & vbCrLf &
"DURATION = " & txt_duration.Text & "," & vbCrLf &
"REASON = N'" & txt_reason.Text & "'," & vbCrLf &
"[DESCRIPTION] = N'" & txt_remark.Text & "'" & vbCrLf &
"WHERE RECORD_ID = " & datagrid.SelectedRows(0).Cells(0).Value & " AND TEACHER_ID = " & datagrid.SelectedRows(0).Cells(4).Value & " AND  START_DATE = '" & datagrid.SelectedRows(0).Cells(6).Value & "'")
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
                obj.Delete("DELETE FROM dbo.TBL_TEACHER_SUSPEND WHERE TEACHER_ID =" & datagrid.SelectedRows(0).Cells(4).Value & "  AND START_DATE = '" & datagrid.SelectedRows(0).Cells(6).Value & "' AND RECORD_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")
                Call Selection()
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបាន!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub txt_suspend_num_TextChanged(sender As Object, e As EventArgs) Handles txt_suspend_num.TextChanged
        txt_suspend_num.BackColor = Color.White

    End Sub

    Private Sub txt_reason_TextChanged(sender As Object, e As EventArgs) Handles txt_reason.TextChanged
        txt_reason.BackColor = Color.White
    End Sub

    Private Sub txt_duration_TextChanged(sender As Object, e As EventArgs) Handles txt_duration.TextChanged
        txt_duration.BackColor = Color.White

    End Sub

    Private Sub lbl_adv_search_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_adv_search.LinkClicked
        PanelAdvSearch.BringToFront()
        Try
            If lbl_adv_search.Text = "ស្វែងរក >>>" Then
                Do While PanelAdvSearch.Width < 997
                    PanelAdvSearch.Width += 15
                    Application.DoEvents()
                Loop
                PanelAdvSearch.Width = 997
                lbl_adv_search.Text = "ស្វែងរក <<<"
                txt_ad_search.Focus()
            Else
                Do While PanelAdvSearch.Width > 0
                    PanelAdvSearch.Width -= 15
                    Application.DoEvents()
                Loop
                PanelAdvSearch.Width = 0
                lbl_adv_search.Text = "ស្វែងរក >>>"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_ad_search_TextChanged(sender As Object, e As EventArgs) Handles txt_ad_search.TextChanged
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     TS.RECORD_ID,ROW_NUMBER ()OVER(ORDER BY TS.RECORD_ID ASC )AS 'ORDER_NUMBER', TS.SUSPEND_LETTER_NUMBER, TS.SUSPEND_NUMER, TS.TEACHER_ID, T.T_NAME_KH, TS.START_DATE, TS.END_DATE, CAST(TS.DURATION AS INT), TS.REASON, TS.[DESCRIPTION],TS.DATE_NOTE FROM dbo.TBL_TEACHER_SUSPEND AS TS INNER JOIN dbo.TBL_TEACHER AS T ON TS.TEACHER_ID = T.TEACHER_ID" & vbCrLf &
"WHERE TS.SUSPEND_LETTER_NUMBER + CAST(TS.TEACHER_ID AS NVARCHAR(50))+T.T_NAME_KH+T.T_NAME_LATIN + TS.SUSPEND_NUMER + CAST(TS.[START_DATE] AS NVARCHAR(50))+  CAST(TS.END_DATE AS NVARCHAR(50))+ CAST(TS.DURATION AS NVARCHAR(50)) + TS.REASON + TS.[DESCRIPTION]   LIKE N'%" & txt_ad_search.Text & "%'"


            obj.BindDataGridView(SqlQueryStr, datagrid)
            Call SetTitle()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub
End Class
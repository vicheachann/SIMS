Public Class frm_student_blame_letter
    Dim obj As New Method
    Dim ValidateState As Boolean
    Dim t As New Theme
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
            Call cbo_lettertype_DropDown(sender, e)
            Call cbo_student_name_DropDown(sender, e)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Clear()
        cbo_student_name.Enabled = True
        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False

        txt_content.Focus()
    End Sub

    Private Sub Clear()
        txt_content.Clear()
        txt_file_address.Clear()
        txt_letter_number.Clear()
        txt_remark.Clear()
        cbo_lettertype.Text = ""
        cbo_student_name.Text = ""
        dt_date_letter.Text = Date.Today
        dt_datenote.Text = Date.Today

    End Sub

    Private Sub cbo_student_name_DropDown(sender As Object, e As EventArgs) Handles cbo_student_name.DropDown
        obj.BindComboBox("SELECT STUDENT_ID,SNAME_KH FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_STATUS_ID = 1", cbo_student_name, "SNAME_KH", "STUDENT_ID")

    End Sub

    Private Sub cbo_lettertype_DropDown(sender As Object, e As EventArgs) Handles cbo_lettertype.DropDown
        Try
            obj.BindComboBox("select LETTER_TYPE_ID,LETTER_TYPE_KH from dbo.TBL_LETTER_TYPE", cbo_lettertype, "LETTER_TYPE_KH", "LETTER_TYPE_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidateControl() As Boolean
        'content
        If txt_content.Text = "" Then
            txt_content.BackColor = Color.LavenderBlush
            txt_content.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'letter number
        If txt_letter_number.Text = "" Then
            txt_letter_number.BackColor = Color.LavenderBlush
            txt_letter_number.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'student name
        If cbo_student_name.Text = "" Then
            cbo_student_name.BackColor = Color.LavenderBlush
            cbo_student_name.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'letter type
        If cbo_lettertype.Text = "" Then
            cbo_lettertype.BackColor = Color.LavenderBlush
            cbo_lettertype.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If


        Return ValidateState
    End Function

    Private Sub txt_content_TextChanged(sender As Object, e As EventArgs) Handles txt_content.TextChanged
        txt_content.BackColor = Color.White
    End Sub

    Private Sub txt_letter_number_TextChanged(sender As Object, e As EventArgs) Handles txt_letter_number.TextChanged
        txt_letter_number.BackColor = Color.White

    End Sub

    Private Sub cbo_student_name_TextChanged(sender As Object, e As EventArgs) Handles cbo_student_name.TextChanged
        cbo_student_name.BackColor = Color.White

    End Sub

    Private Sub cbo_lettertype_TextChanged(sender As Object, e As EventArgs) Handles cbo_lettertype.TextChanged
        cbo_lettertype.BackColor = Color.White
    End Sub

 
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            'Validation
            If txt_content.Text = "" Or txt_letter_number.Text = "" Or cbo_student_name.Text = "" Or cbo_lettertype.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                ValidateControl()
                If ValidateControl() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If

            'Insert Query
            obj.Insert("INSERT INTO dbo.TBS_STUDENT_LETTER_PRAISE_BLAME_LETTER " & vbCrLf &
"(LETTER_NUMBER,STUDENT_ID,LETTER_CONTENT,DATE_LETTER," & vbCrLf &
"DATE_NOTE,LETTER_TYPE_ID" & vbCrLf &
")VALUES(N'" & txt_letter_number.Text & "'," & cbo_student_name.SelectedValue & ",N'" & txt_content.Text & "','" & dt_date_letter.Text & "',GETDATE()," & cbo_lettertype.SelectedValue & ")")
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការបញ្ជូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub Selection()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT A.STUDENT_LETTER_ID,ROW_NUMBER() OVER(ORDER BY A.STUDENT_LETTER_ID asc) AS 'ROW_NUM', A.LETTER_NUMBER, A.STUDENT_ID, S.SNAME_KH, A.LETTER_CONTENT, A.DATE_LETTER, A.DATE_NOTE, L.LETTER_TYPE_KH, A.REMARK, A.FILE_ADDRESS FROM dbo.TBS_STUDENT_LETTER_PRAISE_BLAME_LETTER AS A INNER JOIN dbo.TBS_STUDENT_INFO AS S ON A.STUDENT_ID = S.STUDENT_ID INNER JOIN dbo.TBL_LETTER_TYPE AS L ON A.LETTER_TYPE_ID = L.LETTER_TYPE_ID"


            obj.BindDataGridView(SqlQueryStr, datagrid)
            Call SetTitle()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub SetTitle()
        datagrid.Columns(0).Visible = False 'Record ID



        datagrid.Columns(1).HeaderText = "លរ"
        datagrid.Columns(1).Width = 50

        datagrid.Columns(2).HeaderText = "លេខលិខិត"
        datagrid.Columns(2).Width = 110

        datagrid.Columns(3).Visible = False 'StudentID

        datagrid.Columns(4).HeaderText = "ឈ្មោះសិស្ស"
        datagrid.Columns(4).Width = 120

        datagrid.Columns(5).HeaderText = "ខ្លឹមសារលិខិត"
        datagrid.Columns(5).Width = 300

        datagrid.Columns(6).HeaderText = "ថ្ងៃខែទទួលបានលិខិត"
        datagrid.Columns(6).Width = 160

        datagrid.Columns(7).Visible = False 'Datenote

        datagrid.Columns(8).HeaderText = "ប្រភេទលិខិត"
        datagrid.Columns(8).Width = 130

        datagrid.Columns(9).HeaderText = "ផ្សេងៗ"
        datagrid.Columns(9).Width = 200

        datagrid.Columns(10).HeaderText = "ឯកសារភ្ជាប់"
        datagrid.Columns(10).Width = 100

        datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        Try

            If datagrid.RowCount > 0 Then
                Call Clear()

                txt_content.Text = If(datagrid.SelectedRows(0).Cells(5).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(5).Value)
                txt_letter_number.Text = If(datagrid.SelectedRows(0).Cells(2).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(2).Value)
                cbo_student_name.Text = If(datagrid.SelectedRows(0).Cells(4).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(4).Value)
                dt_date_letter.Text = If(datagrid.SelectedRows(0).Cells(6).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(6).Value)
                cbo_lettertype.Text = If(datagrid.SelectedRows(0).Cells(8).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(8).Value)
                txt_remark.Text = If(datagrid.SelectedRows(0).Cells(9).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(9).Value)
                dt_datenote.Text = If(datagrid.SelectedRows(0).Cells(7).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(7).Value)

                btn_save.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
                btn_new.Enabled = True
                cbo_student_name.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            idx = datagrid.SelectedCells(0).RowIndex.ToString()
            obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then

                'Validate
                If txt_content.Text = "" Or txt_letter_number.Text = "" Or cbo_student_name.Text = "" Or cbo_lettertype.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                    ValidateControl()
                    If ValidateControl() = False Then
                        Exit Sub
                    End If
                    Exit Sub
                End If
                'Update SQL
                obj.Update("UPDATE dbo.TBS_STUDENT_LETTER_PRAISE_BLAME_LETTER SET LETTER_NUMBER = N'" & txt_letter_number.Text & "',LETTER_CONTENT = N'" & txt_content.Text & "',DATE_LETTER = '" & dt_date_letter.Text & "',LETTER_TYPE_ID = " & cbo_lettertype.SelectedValue & " ,REMARK = N'" & txt_remark.Text & "',FILE_ADDRESS = N'" & txt_file_address.Text & "' WHERE STUDENT_LETTER_ID = " & datagrid.SelectedCells(0).Value & "")

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
            obj.ShowMsg("តើអ្នកចង់លុបព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then
                obj.Delete("DELETE FROM dbo.TBS_STUDENT_LETTER_PRAISE_BLAME_LETTER WHERE STUDENT_LETTER_ID = " & datagrid.SelectedCells(0).Value & "")
                Call Selection()
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបាន!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub btn_new_MouseHover(sender As Object, e As EventArgs) Handles btn_new.MouseHover
        t.Hover(btn_new)
    End Sub

    Private Sub btn_new_MouseLeave(sender As Object, e As EventArgs) Handles btn_new.MouseLeave
        t.Leave(btn_new)
    End Sub

    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.Hover(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT A.STUDENT_LETTER_ID,ROW_NUMBER() OVER(ORDER BY A.STUDENT_LETTER_ID asc) AS 'ROW_NUM', A.LETTER_NUMBER, A.STUDENT_ID, S.SNAME_KH, A.LETTER_CONTENT, A.DATE_LETTER, A.DATE_NOTE, L.LETTER_TYPE_KH, A.REMARK, A.FILE_ADDRESS FROM dbo.TBS_STUDENT_LETTER_PRAISE_BLAME_LETTER AS A INNER JOIN dbo.TBS_STUDENT_INFO AS S ON A.STUDENT_ID = S.STUDENT_ID INNER JOIN dbo.TBL_LETTER_TYPE AS L ON A.LETTER_TYPE_ID = L.LETTER_TYPE_ID WHERE A.LETTER_NUMBER  + CAST(A.STUDENT_ID AS NVARCHAR(50)) + A.LETTER_CONTENT + S.SNAME_KH + A.LETTER_CONTENT +L.LETTER_TYPE_KH COLLATE DATABASE_DEFAULT LIKE N'%" & txtSearch.Text & "%'"
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
End Class
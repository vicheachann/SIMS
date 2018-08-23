Public Class frm_blame_letter
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
            SelectLetter()
        Catch ex As Exception

        End Try
    End Sub

   
   

  

    

  

  

    Private Sub Label13_MouseHover(sender As Object, e As EventArgs) Handles btn_new.MouseHover
        frm_teacher.SetHoverStyle(btn_new)
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles btn_new.MouseLeave
        frm_teacher.SetLeaveStyle(btn_new)
    End Sub

    Private Sub cbo_letter_type_ID_DropDown(sender As Object, e As EventArgs) Handles cbo_letter_type_ID.DropDown
        Try
            obj.BindComboBox("select LETTER_TYPE_ID,LETTER_TYPE_KH from dbo.TBL_LETTER_TYPE", cbo_letter_type_ID, "LETTER_TYPE_KH", "LETTER_TYPE_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try


            If txt_letter_content.Text = "" Or cbo_letter_type_ID.Text = "" Or cbo_teacher.Text = "" Or txt_letter_number.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                If txt_letter_content.Text = "" Then
                    txt_letter_content.BackColor = Color.LavenderBlush
                    txt_letter_content.Focus()
                    ValidateState = False
                Else
                    ValidateState = True
                End If

                If txt_letter_number.Text = "" Then
                    txt_letter_number.BackColor = Color.LavenderBlush
                    txt_letter_number.Focus()
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
                If cbo_letter_type_ID.Text = "" Then
                    cbo_letter_type_ID.BackColor = Color.LavenderBlush
                    cbo_letter_type_ID.Focus()
                    ValidateState = False
                Else
                    ValidateState = True
                End If

                If ValidateState = False Then
                    Exit Sub
                End If

                Exit Sub
            End If

            obj.Insert("INSERT INTO dbo.TBL_TEACHER_LETTER_PRAISE_BLAME_LETTER" & vbCrLf &
"(" & vbCrLf &
"LETTER_NUMBER,TEACHER_ID," & vbCrLf &
"LETTER_CONTENT," & vbCrLf &
"DATE_LETTER," & vbCrLf &
"DATE_NOTE," & vbCrLf &
"LETTER_TYPE_ID," & vbCrLf &
"REMARK)" & vbCrLf &
"values(N'" & txt_letter_number.Text & "'," & vbCrLf &
"" & cbo_teacher.SelectedValue & "," & vbCrLf &
"N'" & txt_letter_content.Text & "'," & vbCrLf &
"'" & dt_letter_date_note.Text & "'," & vbCrLf &
"'" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "'," & vbCrLf &
"" & cbo_letter_type_ID.SelectedValue & "," & vbCrLf &
"N'" & txt_letter_remark.Text & "'" & vbCrLf &
")")
            '' Call SelectLetter()
            btn_save.Enabled = False
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub cbo_teacher_DropDown(sender As Object, e As EventArgs) Handles cbo_teacher.DropDown
        obj.BindComboBox("select  TEACHER_ID,T_NAME_KH from dbo.TBL_TEACHER", cbo_teacher, "T_NAME_KH", "TEACHER_ID")

    End Sub

    Private Sub txt_letter_content_TextChanged(sender As Object, e As EventArgs) Handles txt_letter_content.TextChanged
        txt_letter_content.BackColor = Color.White
    End Sub

    Private Sub cbo_letter_type_ID_TextChanged(sender As Object, e As EventArgs) Handles cbo_letter_type_ID.TextChanged
        cbo_letter_type_ID.BackColor = Color.White
    End Sub

    Private Sub cbo_teacher_TextChanged(sender As Object, e As EventArgs) Handles cbo_teacher.TextChanged
        cbo_teacher.BackColor = Color.White

    End Sub


    Private Sub txt_letter_number_TextChanged(sender As Object, e As EventArgs) Handles txt_letter_number.TextChanged
        txt_letter_number.BackColor = Color.White

    End Sub


    Private Sub SelectLetter()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     TL.TEACHER_LETTER_ID,ROW_NUMBER() OVER(ORDER BY TL.TEACHER_LETTER_ID ASC)AS 'ORDER_NUMBER',   TL.LETTER_NUMBER, T.T_NAME_KH, TL.LETTER_CONTENT, TL.DATE_NOTE, TL.DATE_LETTER, TT.LETTER_TYPE_KH, TL.REMARK, TL.FILE_ADDRESS" & vbCrLf &
"FROM         dbo.TBL_TEACHER_LETTER_PRAISE_BLAME_LETTER AS TL INNER JOIN" & vbCrLf &
"                      dbo.TBL_TEACHER AS T ON TL.TEACHER_ID = T.TEACHER_ID INNER JOIN" & vbCrLf &
"                      dbo.TBL_LETTER_TYPE AS TT ON TL.LETTER_TYPE_ID = TT.LETTER_TYPE_ID"
            obj.BindDataGridView(SqlQueryStr, datagrid)
            Call SetTitle()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub SetTitle()
        datagrid.Columns(0).Visible = False 'Record ID
        datagrid.Columns(9).Visible = False 'File
        datagrid.Columns(5).Visible = False 'Datenote

        datagrid.Columns(1).HeaderText = "លរ"
        datagrid.Columns(1).Width = 50

        datagrid.Columns(2).HeaderText = "លេខលិខិត"
        datagrid.Columns(2).Width = 120

        datagrid.Columns(3).HeaderText = "ឈ្មោះគ្រូបង្រៀន"
        datagrid.Columns(3).Width = 180

        datagrid.Columns(4).HeaderText = "ខ្លឹមសារលិខិត"
        datagrid.Columns(4).Width = 500

      

        datagrid.Columns(6).HeaderText = "ថ្ងៃខែទទួលលិខិត"
        datagrid.Columns(6).Width = 200

        datagrid.Columns(7).HeaderText = "ប្រភេទលិខិត"
        datagrid.Columns(7).Width = 130

        datagrid.Columns(8).HeaderText = "ផ្សេងៗ"
        datagrid.Columns(8).Width = 500

       

    End Sub

    Private Sub Clear()
        txt_letter_content.Clear()
        txt_letter_number.Clear()
        txt_letter_remark.Clear()
        txt_file_address.Clear()
        dt_date_letter.Text = Date.Today
        cbo_letter_type_ID.Text = ""
        cbo_teacher.Text = ""
    End Sub
    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        Try
            Call cbo_letter_type_ID_DropDown(sender, e)
            Call cbo_teacher_DropDown(sender, e)

            Call Clear()

            If datagrid.RowCount > 0 Then
                txt_letter_content.Text = datagrid.SelectedRows(0).Cells(4).Value.ToString
                txt_letter_number.Text = datagrid.SelectedRows(0).Cells(2).Value.ToString
                dt_date_letter.Text = datagrid.SelectedRows(0).Cells(6).Value.ToString
                cbo_letter_type_ID.Text = datagrid.SelectedRows(0).Cells(7).Value.ToString
                txt_letter_remark.Text = datagrid.SelectedRows(0).Cells(8).Value.ToString
                cbo_teacher.Text = datagrid.SelectedRows(0).Cells(3).Value.ToString


                btn_save.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
                btn_new.Enabled = True
                
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
        Clear()
        txt_letter_content.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            idx = datagrid.SelectedCells(0).RowIndex.ToString()
            obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then

                'Validate
                If txt_letter_content.Text = "" Or cbo_letter_type_ID.Text = "" Or cbo_teacher.Text = "" Or txt_letter_number.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                    If txt_letter_content.Text = "" Then
                        txt_letter_content.BackColor = Color.LavenderBlush
                        txt_letter_content.Focus()
                        ValidateState = False
                    Else
                        ValidateState = True
                    End If

                    If txt_letter_number.Text = "" Then
                        txt_letter_number.BackColor = Color.LavenderBlush
                        txt_letter_number.Focus()
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
                    If cbo_letter_type_ID.Text = "" Then
                        cbo_letter_type_ID.BackColor = Color.LavenderBlush
                        cbo_letter_type_ID.Focus()
                        ValidateState = False
                    Else
                        ValidateState = True
                    End If

                    If ValidateState = False Then
                        Exit Sub
                    End If

                    Exit Sub
                End If
                'end validate

                obj.Update("UPDATE dbo.TBL_TEACHER_LETTER_PRAISE_BLAME_LETTER SET " & vbCrLf &
"LETTER_NUMBER = N'" & txt_letter_number.Text & "',TEACHER_ID= " & cbo_teacher.SelectedValue & ",LETTER_CONTENT = N'" & txt_letter_content.Text & "',DATE_LETTER = '" & dt_date_letter.Text & "'," & vbCrLf &
"LETTER_TYPE_ID  = " & cbo_letter_type_ID.SelectedValue & " ,REMARK = N'" & txt_letter_remark.Text & "' WHERE TEACHER_LETTER_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")

                Call SelectLetter()
                'want when update selected current row
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
                obj.Delete("DELETE FROM dbo.TBL_TEACHER_LETTER_PRAISE_BLAME_LETTER WHERE TEACHER_LETTER_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")
                SelectLetter()
                USER_CLICK_OK = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
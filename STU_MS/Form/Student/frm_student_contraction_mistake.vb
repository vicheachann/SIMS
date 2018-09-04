Public Class frm_student_contraction_mistake
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
        cbo_by_staff.Text = USERNAME
        cbo_by_staff.ValueMember = USER_ID

        cbo_contract_type_DropDown(sender, e)
        cbo_student_name_DropDown(sender, e)
        Try
            Call Selection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Clear()
        cbo_student_name.Enabled = True
        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False

        txt_meaning.Focus()
    End Sub

    Private Sub cbo_student_name_DropDown(sender As Object, e As EventArgs) Handles cbo_student_name.DropDown
        obj.BindComboBox("SELECT STUDENT_ID,SNAME_KH FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_STATUS_ID = 1", cbo_student_name, "SNAME_KH", "STUDENT_ID")

    End Sub

    Private Sub cbo_contract_type_DropDown(sender As Object, e As EventArgs) Handles cbo_contract_type.DropDown
        obj.BindComboBox("SELECT CONTRACTION_MISTAKE_TYPE_ID,CONTRACTION_TYPE_KH FROM dbo.TBL_CONTRACTION_MISTAKE_TYPE", cbo_contract_type, "CONTRACTION_TYPE_KH", "CONTRACTION_MISTAKE_TYPE_ID")
    End Sub
    Private Sub Clear()
        txt_meaning.Clear()
        cbo_student_name.Text = ""
        dt_contract_date.Text = Date.Today
        dt_datenote.Text = Date.Today
        cbo_contract_type.Text = ""
        txt_witness_1.Clear()
        txt_witness_2.Clear()
        txt_witness_3.Clear()
        txt_witness_4.Clear()
        txt_remark.Clear()
    End Sub

    Private Function ValidateControl() As Boolean
        'meaning
        If txt_meaning.Text = "" Then
            txt_meaning.BackColor = Color.LavenderBlush
            txt_meaning.Focus()
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
        'contract type
        If cbo_contract_type.Text = "" Then
            cbo_contract_type.BackColor = Color.LavenderBlush
            cbo_contract_type.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        Return ValidateState
    End Function

    Private Sub txt_meaning_TextChanged(sender As Object, e As EventArgs) Handles txt_meaning.TextChanged
        txt_meaning.BackColor = Color.White
    End Sub

    Private Sub cbo_student_name_TextChanged(sender As Object, e As EventArgs) Handles cbo_student_name.TextChanged
        cbo_student_name.BackColor = Color.White
    End Sub

    Private Sub cbo_contract_type_TextChanged(sender As Object, e As EventArgs) Handles cbo_contract_type.TextChanged
        cbo_contract_type.BackColor = Color.White
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            'Validation
            If txt_meaning.Text = "" Or cbo_contract_type.Text = "" Or cbo_student_name.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                ValidateControl()
                If ValidateControl() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If
            obj.Insert("INSERT INTO dbo.TBS_STUDENT_CONTRACTION_MISTAKE(STUDENT_ID,DATE_NOTE,DATE_CONTRACTION,CONTRACTION_TYPE_ID,CONTRACTION_MEANING,WITNESS_1,WITNESS_2,WITNESS_3,WITNESS_4,[DESCRIPTION],BY_STAFF)VALUES(" & cbo_student_name.SelectedValue & ",GETDATE(),'" & dt_contract_date.Text & "'," & cbo_contract_type.SelectedValue & ",N'" & txt_meaning.Text & "',N'" & txt_witness_1.Text & "',N'" & txt_witness_2.Text & "',N'" & txt_witness_3.Text & "',N'" & txt_witness_4.Text & "',N'" & txt_remark.Text & "'," & USER_ID & ")")


            Call Selection()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការបញ្ជូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub Selection()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT SCM.CONTRACTION_MISTAKE_ID,ROW_NUMBER() OVER(ORDER BY SCM.CONTRACTION_MISTAKE_ID asc) AS 'ROW_NUMBER', SCM.STUDENT_ID, SI.SNAME_KH, SCM.DATE_NOTE, SCM.DATE_CONTRACTION, CMT.CONTRACTION_TYPE_KH, SCM.CONTRACTION_MEANING, SCM.WITNESS_1, SCM.WITNESS_2, SCM.WITNESS_3, SCM.WITNESS_4, SCM.DESCRIPTION, T.T_NAME_KH FROM dbo.TBS_STUDENT_CONTRACTION_MISTAKE AS SCM INNER JOIN dbo.TBS_STUDENT_INFO AS SI ON SCM.STUDENT_ID = SI.STUDENT_ID INNER JOIN dbo.TBL_CONTRACTION_MISTAKE_TYPE AS CMT ON SCM.CONTRACTION_TYPE_ID = CMT.CONTRACTION_MISTAKE_TYPE_ID INNER JOIN dbo.TBL_TEACHER AS T ON SCM.BY_STAFF = T.TEACHER_ID"
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
        datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        datagrid.Columns(2).Visible = False 'StudentID

        datagrid.Columns(3).HeaderText = "ឈ្មោះសិស្ស"
        datagrid.Columns(3).Width = 200

        datagrid.Columns(4).Visible = False  'DATENOTE

        datagrid.Columns(5).HeaderText = "កាលបរិច្ឆេទចុះកិច្ចសន្យា"
        datagrid.Columns(5).Width = 180


        datagrid.Columns(6).HeaderText = "ប្រភេទកិច្ចសន្យា"
        datagrid.Columns(6).Width = 130

        datagrid.Columns(7).HeaderText = "ខ្លឹមសារកិច្ចសន្យា"
        datagrid.Columns(7).Width = 300

        datagrid.Columns(8).HeaderText = "សាក្សីទី១"
        datagrid.Columns(8).Width = 130

        datagrid.Columns(9).HeaderText = "សាក្សីទី២"
        datagrid.Columns(9).Width = 130

        datagrid.Columns(10).HeaderText = "សាក្សីទី៣"
        datagrid.Columns(10).Width = 130

        datagrid.Columns(11).HeaderText = "សាក្សីទី៤"
        datagrid.Columns(11).Width = 130

        datagrid.Columns(12).HeaderText = "ផ្សេងៗ"
        datagrid.Columns(12).Width = 200

        datagrid.Columns(13).HeaderText = "បញ្ចូលដោយ"
        datagrid.Columns(13).Width = 130

    End Sub

    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        Try
            If datagrid.RowCount > 0 Then
                Call Clear()
                txt_meaning.Text = If(datagrid.SelectedRows(0).Cells(7).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(7).Value)
                cbo_student_name.Text = If(datagrid.SelectedRows(0).Cells(3).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(3).Value)
                dt_contract_date.Text = If(datagrid.SelectedRows(0).Cells(5).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(5).Value)
                cbo_contract_type.Text = If(datagrid.SelectedRows(0).Cells(6).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(6).Value)
                cbo_by_staff.Text = If(datagrid.SelectedRows(0).Cells(13).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(13).Value)
                txt_witness_1.Text = If(datagrid.SelectedRows(0).Cells(8).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(8).Value)
                txt_witness_2.Text = If(datagrid.SelectedRows(0).Cells(9).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(9).Value)
                txt_witness_3.Text = If(datagrid.SelectedRows(0).Cells(10).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(10).Value)
                txt_witness_4.Text = If(datagrid.SelectedRows(0).Cells(11).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(11).Value)
                txt_remark.Text = If(datagrid.SelectedRows(0).Cells(12).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(12).Value)
                dt_datenote.Text = If(datagrid.SelectedRows(0).Cells(4).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(4).Value)

                btn_save.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
                btn_new.Enabled = True

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            idx = datagrid.SelectedCells(0).RowIndex.ToString()
            obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then


                'Validation
                If txt_meaning.Text = "" Or cbo_contract_type.Text = "" Or cbo_student_name.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                    ValidateControl()
                    If ValidateControl() = False Then
                        Exit Sub
                    End If
                    Exit Sub
                End If
                'Update SQL
                obj.Update("UPDATE dbo.TBS_STUDENT_CONTRACTION_MISTAKE SET STUDENT_ID = " & cbo_student_name.SelectedValue & " ,DATE_CONTRACTION = '" & dt_contract_date.Text & "' ,CONTRACTION_TYPE_ID = " & cbo_contract_type.SelectedValue & "," & vbCrLf &
"CONTRACTION_MEANING = N'" & txt_meaning.Text & "',WITNESS_1 = N'" & txt_witness_1.Text & "',WITNESS_2 =N'" & txt_witness_2.Text & "',WITNESS_3 = N'" & txt_witness_3.Text & "',WITNESS_4 = N'" & txt_witness_4.Text & "'," & vbCrLf &
"[DESCRIPTION] = N'" & txt_remark.Text & "',BY_STAFF = " & USER_ID & " WHERE CONTRACTION_MISTAKE_ID = " & datagrid.SelectedCells(0).Value & " ")

                Call Selection()
                datagrid.Rows(idx).Selected = True
                datagrid.CurrentCell = datagrid.SelectedCells(1)
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការកែប្រែបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            obj.ShowMsg("តើអ្នកចង់លុបព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then
                obj.Delete("DELETE FROM dbo.TBS_STUDENT_CONTRACTION_MISTAKE WHERE CONTRACTION_MISTAKE_ID = " & datagrid.SelectedCells(0).Value & "")
                Call Selection()
                USER_CLICK_OK = False
            End If
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបាន!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frm_contract_mistake_type.ShowDialog()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT SCM.CONTRACTION_MISTAKE_ID,ROW_NUMBER() OVER(ORDER BY SCM.CONTRACTION_MISTAKE_ID asc) AS 'ROW_NUMBER', SCM.STUDENT_ID, SI.SNAME_KH, SCM.DATE_NOTE, SCM.DATE_CONTRACTION, CMT.CONTRACTION_TYPE_KH, SCM.CONTRACTION_MEANING, SCM.WITNESS_1, SCM.WITNESS_2, SCM.WITNESS_3, SCM.WITNESS_4, SCM.DESCRIPTION, T.T_NAME_KH FROM dbo.TBS_STUDENT_CONTRACTION_MISTAKE AS SCM INNER JOIN dbo.TBS_STUDENT_INFO AS SI ON SCM.STUDENT_ID = SI.STUDENT_ID INNER JOIN dbo.TBL_CONTRACTION_MISTAKE_TYPE AS CMT ON SCM.CONTRACTION_TYPE_ID = CMT.CONTRACTION_MISTAKE_TYPE_ID INNER JOIN dbo.TBL_TEACHER AS T ON SCM.BY_STAFF = T.TEACHER_ID WHERE CAST(SCM.STUDENT_ID AS NVARCHAR(50)) + SI.SNAME_KH + CAST(SCM.DATE_CONTRACTION AS NVARCHAR(50))+ CMT.CONTRACTION_TYPE_KH + SCM.CONTRACTION_MEANING + SCM.WITNESS_1 + SCM.WITNESS_2  + SCM.WITNESS_3  + SCM.WITNESS_4 + T.T_NAME_KH    LIKE N'%" & txtSearch.Text & "%'"
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

    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.Hover(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)
    End Sub

    Private Sub btn_new_MouseHover(sender As Object, e As EventArgs) Handles btn_new.MouseHover
        t.Hover(btn_new)
    End Sub

    Private Sub btn_new_MouseLeave(sender As Object, e As EventArgs) Handles btn_new.MouseLeave
        t.Leave(btn_new)
    End Sub
End Class
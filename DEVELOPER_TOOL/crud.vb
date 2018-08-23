Public Class frm_subject
    Dim obj As New GeneralMethod
    Dim t As New Theme
    Dim SelectMaxOrdinalSql As String = "SELECT MAX(SUB_ORDER) FROM dbo.TBL_SUBJECT"
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
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

    Private Sub Selection()
        Try
            obj.Bind_DataGrid("SELECT SUBJECT_ID,ROW_NUMBER() OVER(ORDER BY SUB_ORDER ASC)AS 'ROW_NUMBER',SUB_CODE,SUBJECT_KH,SUBJECT_EN,SUB_SHORT_NAME,SUB_ORDER,GRADE_12_MIN_SCORE,GRADE_12_MAX_SCORE,GRADE_12_MULTIPLE,MIN_SCORE,MAX_SCORE,MULTIPLE FROM dbo.TBL_SUBJECT WHERE SUB_STATUS = 1", dg)
            Call SetColHeader()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetColHeader()
        Try
            dg.Columns(0).Visible = False 'ID
            dg.Columns(1).HeaderText = "??"
            dg.Columns(1).Width = 50
            dg.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg.Columns(2).HeaderText = "??????"
            dg.Columns(2).Width = 80
            dg.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg.Columns(3).HeaderText = "?????????(?????)"
            dg.Columns(3).Width = 120

            dg.Columns(4).HeaderText = "?????????(??????)"
            dg.Columns(4).Width = 120

            dg.Columns(5).HeaderText = "?????????"
            dg.Columns(5).Width = 90

            dg.Columns(6).HeaderText = "?????????"
            dg.Columns(6).Width = 100
            dg.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg.Columns(7).HeaderText = "??????????????(????)"
            dg.Columns(7).Width = 140
            dg.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg.Columns(8).HeaderText = "????????????????(????)"
            dg.Columns(8).Width = 140
            dg.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            dg.Columns(9).HeaderText = "?????(????)"
            dg.Columns(9).Width = 140
            dg.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            dg.Columns(10).HeaderText = "??????????????"
            dg.Columns(10).Width = 130
            dg.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg.Columns(11).HeaderText = "????????????????"
            dg.Columns(11).Width = 130
            dg.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            dg.Columns(12).HeaderText = "?????"
            dg.Columns(12).Width = 130
            dg.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_subject_Load(sender As Object, e As EventArgs) Handles Me.Load
        Selection()
    End Sub


    Private Sub Clear()
        txtNo.Clear()
        txtCode.Clear()
        txtTitleEn.Clear()
        txtTitleKh.Clear()
        txtShortName.Clear()
        txtOrdinalNumber.Clear()
        txtMin12.Text = "0"
        txtMax12.Text = "0"
        txtMulti12.Text = "0"
        txtMax.Text = "0"
        txtMin.Text = "0"
        txtMulti.Text = "0"
    End Sub



    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Clear()
        lblDelete.Enabled = False
        lblUpdate.Enabled = False
        lblSave.Enabled = True
        txtOrdinalNumber.Enabled = False
        txtCode.Focus()
        txtOrdinalNumber.Text = obj.GetLastOrdinalNumber("SELECT MAX(SUB_ORDER) FROM dbo.TBL_SUBJECT")
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label13_MouseHover(sender As Object, e As EventArgs) Handles lblNew.MouseHover
        frm_teacher.SetHoverStyle(lblNew)
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles lblNew.MouseLeave
        frm_teacher.SetLeaveStyle(lblNew)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        Try
            If txtCode.Text = "" Then
                obj.ShowMsg("??????????????????????????", frm_warning, "")
                txtCode.Focus()
                txtCode.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txtTitleKh.Text = "" Then
                obj.ShowMsg("???????????????????????", frm_warning, "")
                txtTitleKh.Focus()
                txtTitleKh.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If obj.CheckCode("SELECT SUB_CODE FROM dbo.TBL_SUBJECT WHERE SUB_CODE = N'" & txtCode.Text & "'") = True Then
                txtCode.BackColor = Color.LavenderBlush
                txtCode.Focus()
                Exit Sub
            End If

            obj.Insert_SQL("INSERT INTO dbo.TBL_SUBJECT(SUB_CODE,SUBJECT_KH,SUBJECT_EN,SUB_SHORT_NAME,SUB_ORDER,SUB_STATUS,GRADE_12_MIN_SCORE,GRADE_12_MAX_SCORE,GRADE_12_MULTIPLE,MIN_SCORE,MAX_SCORE,MULTIPLE)VALUES(N'" & txtCode.Text & "',N'" & txtTitleKh.Text & "',N'" & txtTitleEn.Text & "',N'" & txtShortName.Text & "'," & txtOrdinalNumber.Text & ",1," & txtMin12.Text & "," & txtMax12.Text & "," & txtMulti12.Text & "," & txtMin.Text & "," & txtMax.Text & "," & txtMulti.Text & ")")
            Call Selection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtOrdinalNumber_TextChanged(sender As Object, e As EventArgs) Handles txtOrdinalNumber.TextChanged
        txtOrdinalNumber.BackColor = Color.White
    End Sub

    Private Sub txtTitleKh_TextChanged(sender As Object, e As EventArgs) Handles txtTitleKh.TextChanged
        txtTitleKh.BackColor = Color.White
    End Sub

    Private Sub dg_SelectionChanged(sender As Object, e As EventArgs) Handles dg.SelectionChanged
        Try
            lblSave.Enabled = False
            lblUpdate.Enabled = True
            lblDelete.Enabled = True
            txtOrdinalNumber.Enabled = True
            If (dg.SelectedRows.Count = 0) Then
                Exit Sub
            Else
                Clear()
                txtNo.Text = obj.CheckIfDBNull(dg.SelectedCells(1).Value)
                txtCode.Text = obj.CheckIfDBNull(dg.SelectedCells(2).Value)
                txtTitleKh.Text = obj.CheckIfDBNull(dg.SelectedCells(3).Value)
                txtTitleEn.Text = obj.CheckIfDBNull(dg.SelectedCells(4).Value)
                txtShortName.Text = obj.CheckIfDBNull(dg.SelectedCells(5).Value)
                txtOrdinalNumber.Text = obj.CheckIfDBNull(dg.SelectedCells(6).Value)
                txtMin12.Text = obj.CheckIfDBNull(dg.SelectedCells(7).Value)
                txtMax12.Text = obj.CheckIfDBNull(dg.SelectedCells(8).Value)
                txtMulti12.Text = obj.CheckIfDBNull(dg.SelectedCells(9).Value)
                txtMin.Text = obj.CheckIfDBNull(dg.SelectedCells(10).Value)
                txtMax.Text = obj.CheckIfDBNull(dg.SelectedCells(11).Value)
                txtMulti.Text = obj.CheckIfDBNull(dg.SelectedCells(12).Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            obj.ShowMsg("?????????????????????????????", msg_question, "ShowMessage.wav")
            If QuestionResult = True Then
                obj.Delete_SQL("DELETE FROM dbo.TBL_SUBJECT WHERE SUBJECT_ID =  " & dg.SelectedCells(0).Value & "")
                Call Selection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCheckCode_Click(sender As Object, e As EventArgs) Handles btnCheckCode.Click
        obj.CheckCode("SELECT SUB_CODE FROM dbo.TBL_SUBJECT WHERE SUB_CODE = N'" & txtCode.Text & "'")
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        txtCode.BackColor = Color.White
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        obj.ShowMsg("????????????????????????????????", msg_question, "ShowMessage.wav")
        If QuestionResult = True Then
            idx = dg.SelectedCells(0).RowIndex.ToString()

            Try
                If txtCode.Text = "" Then
                    obj.ShowMsg("??????????????????????????", frm_warning, "")
                    txtCode.Focus()
                    txtCode.BackColor = Color.LavenderBlush
                    Exit Sub
                End If
                If txtTitleKh.Text = "" Then
                    obj.ShowMsg("???????????????????????", frm_warning, "")
                    txtTitleKh.Focus()
                    txtTitleKh.BackColor = Color.LavenderBlush
                    Exit Sub
                End If

                If obj.CheckCodeWhenUpdate("SELECT SUB_CODE FROM dbo.TBL_SUBJECT WHERE SUB_CODE = N'" & txtCode.Text & "'", dg.SelectedCells(2).Value, txtCode.Text) = True Then
                    txtCode.BackColor = Color.LavenderBlush
                    txtCode.Focus()
                    Exit Sub
                End If

                If (txtOrdinalNumber.Text <> dg.SelectedCells(6).Value) Then
                    If (txtOrdinalNumber.Text >= Convert.ToInt32(obj.GetLastOrdinalNumber(SelectMaxOrdinalSql))) Then
                        obj.ShowMsg("???????????????????????????????", frm_warning, "")
                        txtOrdinalNumber.Text = Convert.ToInt32(obj.GetLastOrdinalNumber(SelectMaxOrdinalSql)) - 1.ToString
                        txtOrdinalNumber.Focus()
                        Exit Sub
                    End If
                End If

                obj.Update_SQL("UPDATE dbo.TBL_SUBJECT SET SUB_CODE = N'" & txtCode.Text & "',SUBJECT_KH = N'" & txtTitleKh.Text & "',SUBJECT_EN =N'" & txtTitleEn.Text & "',SUB_SHORT_NAME = N'" & txtShortName.Text & "',SUB_ORDER = " & txtOrdinalNumber.Text & " ,GRADE_12_MIN_SCORE = " & txtMin12.Text & ",GRADE_12_MAX_SCORE=" & txtMax12.Text & ",GRADE_12_MULTIPLE =" & txtMulti12.Text & " ,MIN_SCORE = " & txtMin.Text & " ,MAX_SCORE = " & txtMax.Text & ",MULTIPLE = " & txtMulti.Text & " WHERE SUBJECT_ID = " & dg.SelectedCells(0).Value & "")

                If (dg.SelectedCells(6).Value > Convert.ToInt32(txtOrdinalNumber.Text)) Then
                    obj.Update_SQL_WITHOUT_MSG("UPDATE dbo.TBL_SUBJECT SET SUB_ORDER = SUB_ORDER +1 WHERE SUB_ORDER >= " & txtOrdinalNumber.Text & " AND SUB_ORDER <= " & dg.SelectedCells(6).Value & ";")
                    obj.Update_SQL_WITHOUT_MSG("UPDATE dbo.TBL_SUBJECT SET SUB_ORDER  = " & txtOrdinalNumber.Text & " WHERE SUBJECT_ID = " & dg.SelectedCells(0).Value & ";")
                Else
                    obj.Update_SQL_WITHOUT_MSG("UPDATE dbo.TBL_SUBJECT SET SUB_ORDER = SUB_ORDER -1 WHERE SUB_ORDER >= " & dg.SelectedCells(6).Value & " AND SUB_ORDER <= " & txtOrdinalNumber.Text & ";")
                    obj.Update_SQL_WITHOUT_MSG("UPDATE dbo.TBL_SUBJECT SET SUB_ORDER  = " & txtOrdinalNumber.Text & " WHERE SUBJECT_ID = " & dg.SelectedCells(0).Value & ";")
                End If



                Call Selection()
                dg.Rows(idx).Selected = True
                dg.CurrentCell = dg.SelectedCells(1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub IncrementRows()
        Dim i = dg.CurrentRow.Index
        Dim num As Integer
        If Integer.TryParse(txtOrdinalNumber.Text, num) Then
            With dg
                .Rows(i).Cells(6).Value = num
            End With
            For j As Integer = i + 1 To dg.Rows.Count - 1
                num += 1
                dg.Rows(j).Cells(6).Value = num
            Next
        Else
            MessageBox.Show("Please enter a valid number.")

        End If
    End Sub

    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.SetHoverStyle(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.SetLeaveStyle(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        Call Selection()
    End Sub

    Private Sub txtOrdinalNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrdinalNumber.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMin12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMin12.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMax12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMax12.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMulti12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMulti12.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMin.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMax.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMulti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMulti.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            obj.Bind_DataGrid("SELECT SUBJECT_ID,ROW_NUMBER() OVER(ORDER BY SUB_ORDER ASC)AS 'ROW_NUMBER',SUB_CODE,SUBJECT_KH,SUBJECT_EN,SUB_SHORT_NAME,SUB_ORDER,GRADE_12_MIN_SCORE,GRADE_12_MAX_SCORE,GRADE_12_MULTIPLE,MIN_SCORE,MAX_SCORE,MULTIPLE FROM dbo.TBL_SUBJECT WHERE SUB_STATUS = 1 AND SUBJECT_KH + SUBJECT_EN + SUB_SHORT_NAME + CAST(SUB_ORDER AS NVARCHAR(50))+ SUB_CODE  LIKE N'%" & txtSearch.Text & "%'", dg)
            Call SetColHeader()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
Public Class frm_grade
    Dim obj As New Method
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub










    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_update_MouseHover(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_update_MouseLeave(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_delete_MouseHover(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call Selection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Selection()
        obj.OpenConnection()

        Try
            obj.BindDataGridView("SELECT GRADE_ID,ROW_NUMBER() OVER(ORDER BY GRADE asc) AS 'ROW_NUM',GRADE,GRADE_LETTER FROM dbo.TBL_GRADE", datagrid)
            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "ល.រ"
            datagrid.Columns(2).HeaderText = "ថ្នាក់ទី"
            datagrid.Columns(3).HeaderText = "ឈ្មោះថ្នាក់"

            datagrid.Columns(1).Width = 100
            datagrid.Columns(2).Width = 323
            datagrid.Columns(3).Width = 323


        Catch ex As Exception

        End Try
    End Sub
    Public Sub clear()
        txt_no.Clear()
        txt_grade.Clear()
        txt_grade_letter.Clear()

    End Sub
   Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        clear()
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_save.Enabled = True

        txt_grade.Focus()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_grade.Text = "" Or txt_grade_letter.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")
                txt_grade.Focus()
                Exit Sub
            End If

            For Each row As DataGridViewRow In datagrid.Rows
                If txt_grade.Text = row.Cells(1).Value Then
                    obj.ShowMsg("សុំទោស !ថ្នាក់ទី " & txt_grade.Text & " បានបញ្ចូលរួចរាល់", FrmMessageError, "Error.wav")
                    Exit Sub
                End If
            Next


            obj.Insert("INSERT INTO dbo.TBL_GRADE (GRADE,GRADE_LETTER)VALUES(" & txt_grade.Text & ",N'" & txt_grade_letter.Text & "')")
            Call Selection()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

  

    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        'Try
        '    If txt_grade.Text = "" Or txt_grade_letter.Text = "" Then
        '        obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", msg_fail)
        '        txt_grade.Focus()
        '        Exit Sub
        '    End If
        '    For Each row As DataGridViewRow In datagrid.Rows
        '        If txt_grade_letter.Text = row.Cells(2).Value Then
        '            obj.ShowMsg("សុំទោស !លេខ " & txt_grade_letter.Text & " បានបញ្ចូលរួចរាល់", msg_fail)
        '            Exit Sub
        '        End If
        '    Next

        '    obj.Update_SQL("UPDATE dbo.TBL_POSITION SET POSITION = N'" & txt_grade.Text & "',ORDINAL_NUMBER = " & txt_grade_letter.Text & " WHERE POSITION_ID =" & datagrid.SelectedRows(0).Cells(0).Value & "")
        '    Call Selection()
        'Catch ex As Exception
        '    error_reason = ex.Message
        '    obj.ShowMsg(ex.Message, frm_success)
        'End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        'Try
        '    If datagrid.SelectedRows.Count > 0 Then
        '        obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", msg_question)
        '        If question_result = True Then
        '            obj.Delete_SQL("DELETE FROM  dbo.TBL_POSITION WHERE  POSITION_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")

        '            Call Selection()
        '            question_result = False
        '        Else
        '            Exit Sub
        '        End If
        '    Else

        '    End If
        'Catch ex As Exception
        '    obj.ShowMsg(ex.Message, msg_fail)
        'End Try
    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub txt_grade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_grade.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        Try
            clear()
            txt_no.Text = datagrid.SelectedRows(0).Cells(1).Value
            txt_grade.Text = datagrid.SelectedRows(0).Cells(2).Value
            txt_grade_letter.Text = datagrid.SelectedRows(0).Cells(3).Value
        Catch ex As Exception

        End Try
    End Sub
End Class
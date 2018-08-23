Public Class frm_batchs
    Dim obj As New Method
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
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
            obj.BindDataGridView("SELECT BATCH_ID,ROW_NUMBER() OVER(ORDER BY BATCH_ID ASC) AS 'ROW_NUM',BATCH,YEAR_STUDY FROM dbo.TBL_BATCH", datagrid)
            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "ល.រ"
            datagrid.Columns(2).HeaderText = "ជំនាន់"
            datagrid.Columns(3).HeaderText = "ឆ្នាំសិក្សា"

            datagrid.Columns(1).Width = 50
            datagrid.Columns(2).Width = 348
            datagrid.Columns(3).Width = 348

            datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception

        End Try
    End Sub
    Public Sub clear()
        txt_no.Clear()
        txt_batch.Clear()
        cbo_year_study.Text = ""
    End Sub
    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        Try
            clear()
            txt_no.Text = datagrid.SelectedRows(0).Cells(1).Value
            txt_batch.Text = datagrid.SelectedRows(0).Cells(2).Value
            cbo_year_study.Text = datagrid.SelectedRows(0).Cells(3).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        clear()
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_save.Enabled = True

        txt_batch.Focus()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_batch.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                txt_batch.Focus()
                Exit Sub
            End If
            'For Each row As DataGridViewRow In datagrid.Rows
            '    If txt_batch.Text = row.Cells(2).Value Then
            '        obj.ShowMsg("សុំទោស !លេខ " & txt_batch.Text & " បានបញ្ចូលរួចរាល់", msg_fail)
            '        Exit Sub
            '    End If
            'Next


            obj.Insert("INSERT INTO dbo.TBL_BATCH (BATCH,YEAR_STUDY)VALUES(N'" & txt_batch.Text & "',N'" & cbo_year_study.Text & "')")
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub txt_ordinal_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_batch.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            If txt_batch.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                txt_batch.Focus()
                Exit Sub
            End If

          
            obj.Update("UPDATE dbo.TBL_BATCH SET BATCH = N'" & txt_batch.Text & "',YEAR_STUDY = N'" & cbo_year_study.Text & "' WHERE BATCH_ID =" & datagrid.SelectedRows(0).Cells(0).Value & "")
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Try
            If datagrid.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE FROM  dbo.TBL_BATCH WHERE  BATCH_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")

                    Call Selection()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub cbo_year_study_DropDown(sender As Object, e As EventArgs) Handles cbo_year_study.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cbo_year_study, "YEAR_STUDY_KH", "YEAR_STUDY_KH")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frm_year_study.ShowDialog()
    End Sub
End Class
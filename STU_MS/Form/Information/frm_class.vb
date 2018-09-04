Public Class frm_class
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


    Private Sub frm_position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call Selection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Selection()
        obj.OpenConnection()

        Try
            obj.BindDataGridView("SELECT CLASS_ID,ROW_NUMBER() OVER(ORDER BY CLASS_ID asc) AS 'ROW_NUM',CLASS_LETTER,CLASS_NUMBER FROM dbo.TBS_CLASS", datagrid)
            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "ល.រ"
            datagrid.Columns(2).HeaderText = "ឈ្មោះថ្នាក់"
            datagrid.Columns(3).HeaderText = "ថ្នាក់ទី"

            datagrid.Columns(1).Width = 50
            datagrid.Columns(2).Width = 348
            datagrid.Columns(3).Width = 348

            datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception

        End Try
    End Sub
    Public Sub clear()
        txt_no.Clear()
        txt_class_letter.Clear()
        txt_class_number.Clear()

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        clear()
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_save.Enabled = True

        txt_class_letter.Focus()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_class_letter.Text = "" Or txt_class_number.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                txt_class_letter.Focus()
                Exit Sub
            End If

            For Each row As DataGridViewRow In datagrid.Rows
                If txt_class_letter.Text = row.Cells(2).Value Then
                    obj.ShowMsg("សុំទោស !ថ្នាក់ទី " & txt_class_letter.Text & " បានបញ្ចូលរួចរាល់", FrmWarning, "")
                    Exit Sub
                End If
            Next


            obj.Insert("INSERT INTO dbo.TBS_CLASS (CLASS_LETTER,CLASS_NUMBER)VALUES(N'" & txt_class_letter.Text & "',N'" & txt_class_number.Text & "')")
            Call Selection()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub



    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        Try

            If txt_class_letter.Text = "" Or txt_class_number.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                txt_class_letter.Focus()
                Exit Sub
            End If

            For Each row As DataGridViewRow In datagrid.Rows
                If txt_class_letter.Text = datagrid.SelectedCells(2).Value Then
                Else
                    If txt_class_letter.Text = row.Cells(2).Value Then
                        obj.ShowMsg("សុំទោស !ថ្នាក់ទី " & txt_class_letter.Text & " បានបញ្ចូលរួចរាល់", FrmWarning, "")
                        Exit Sub
                    End If
                End If
               
            Next


            obj.Update("UPDATE dbo.TBS_CLASS SET CLASS_LETTER = N'" & txt_class_letter.Text & "',CLASS_NUMBER = N'" & txt_class_number.Text & "' WHERE CLASS_ID =" & datagrid.SelectedRows(0).Cells(0).Value & "")
            Call Selection()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Try
            If datagrid.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE FROM dbo.TBS_CLASS WHERE  CLASS_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")

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


    Private Sub txt_grade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_class_letter.KeyPress
        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If
    End Sub

    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        Try
            clear()
            txt_no.Text = datagrid.SelectedRows(0).Cells(1).Value
            txt_class_letter.Text = datagrid.SelectedRows(0).Cells(2).Value
            txt_class_number.Text = datagrid.SelectedRows(0).Cells(3).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            obj.BindDataGridView("SELECT CLASS_ID,ROW_NUMBER() OVER(ORDER BY CLASS_ID asc) AS 'ROW_NUM',CLASS_LETTER,CLASS_NUMBER FROM dbo.TBS_CLASS WHERE CLASS_LETTER LIKE N'%" & txtSearch.Text & "%'", datagrid)
            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "ល.រ"
            datagrid.Columns(2).HeaderText = "ឈ្មោះថ្នាក់"
            datagrid.Columns(3).HeaderText = "ថ្នាក់ទី"

            datagrid.Columns(1).Width = 50
            datagrid.Columns(2).Width = 348
            datagrid.Columns(3).Width = 348

            datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception
        End Try

    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        Call Selection()
    End Sub
End Class
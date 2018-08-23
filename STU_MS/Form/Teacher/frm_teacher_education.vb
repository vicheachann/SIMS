Public Class frm_teacher_education
    Dim obj As New Method
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub frm_office_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call Selection()
            cbo_lv_DropDown(sender, e)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Selection()
        obj.OpenConnection()

        Try
            obj.BindDataGridView("SELECT EDUCATION_ID,ROW_NUMBER() OVER(ORDER BY EDUCATION_ID asc) AS 'ROW_NUM',EDUCATION_KH,EDUCATION_EN,A.EDUCATION_LEVEL_KH,REMARK FROM dbo.TBL_EDUCATION INNER JOIN dbo.TBL_EDUCATION_LEVEL AS A ON dbo.TBL_EDUCATION.EDUCATION_LEVEL_ID = A.EDUCATION_LEVEL_ID", datagrid)

            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "ល.រ"
            datagrid.Columns(2).HeaderText = "កម្រិតវប្បធម៌ (KH)"
            datagrid.Columns(3).HeaderText = "កម្រិតវប្បធម៌ (EN) "
            datagrid.Columns(4).HeaderText = "កម្រិតការសិក្សា"
            datagrid.Columns(5).HeaderText = "ផ្សេងៗ"

            datagrid.Columns(1).Width = 100
            datagrid.Columns(5).Width = 192

            datagrid.Columns(2).Width = 248

            datagrid.Columns(3).Width = 248
            datagrid.Columns(4).Width = 280
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        clear()
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_save.Enabled = True

        txt_kh.Focus()
    End Sub

    Private Sub DG_T_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        cbo_lv_DropDown(sender, e)
        Try
            clear()
            txt_no.Text = If(datagrid.SelectedRows(0).Cells(1).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(1).Value)
            txt_kh.Text = If(datagrid.SelectedRows(0).Cells(2).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(2).Value)
            txt_en.Text = If(datagrid.SelectedRows(0).Cells(3).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(3).Value)
            cbo_lv.Text = If(datagrid.SelectedRows(0).Cells(4).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(4).Value)
            txt_remark.Text = If(datagrid.SelectedRows(0).Cells(5).Value Is DBNull.Value, "", datagrid.SelectedRows(0).Cells(5).Value)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub clear()
        txt_no.Clear()
        txt_en.Clear()
        txt_kh.Clear()
        txt_remark.Clear()
        cbo_lv.Text = ""

    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try

            If txt_kh.Text = "" And cbo_lv.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")
                txt_kh.Focus()
                Exit Sub
            End If

            obj.Insert("INSERT INTO dbo.TBL_EDUCATION(EDUCATION_KH,EDUCATION_EN,EDUCATION_LEVEL_ID,REMARK)VALUES(N'" & txt_kh.Text & "',N'" & txt_en.Text & "'," & cbo_lv.SelectedValue & ",N'" & txt_remark.Text & "')")
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            If txt_kh.Text = "" And cbo_lv.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")
                txt_kh.Focus()
                Exit Sub
            End If

            obj.Update("UPDATE dbo.TBL_EDUCATION SET EDUCATION_KH = N'" & txt_kh.Text & "',EDUCATION_EN = N'" & txt_en.Text & "',EDUCATION_LEVEL_ID=" & cbo_lv.SelectedValue & ",REMARK = N'" & txt_remark.Text & "' WHERE EDUCATION_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Try
            If datagrid.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE FROM  dbo.TBL_EDUCATION WHERE  EDUCATION_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")
                    '  E.EDUCATION_ID, E.EDUCATION_KH, L.EDUCATION_LEVEL_KH, E.REMARK FROM       dbo.TBL_EDUCATION AS E INNER JOIN  dbo.TBL_EDUCATION_LEVEL AS L ON E.EDUCATION_LEVEL_ID = L.EDUCATION_LEVEL_ID", datagrid)

                    Call Selection()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        frm_teacher.SetHoverStyle(Label3)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        frm_teacher.SetLeaveStyle(Label3)
    End Sub

    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_save.MouseLeave
        frm_teacher.SetLeaveStyle(btn_save)
    End Sub

    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles btn_save.MouseHover
        frm_teacher.SetHoverStyle(btn_save)
    End Sub

    Private Sub btn_update_MouseHover(sender As Object, e As EventArgs) Handles btn_update.MouseHover
        frm_teacher.SetHoverStyle(btn_update)

    End Sub

    Private Sub btn_update_MouseLeave(sender As Object, e As EventArgs) Handles btn_update.MouseLeave
        frm_teacher.SetLeaveStyle(btn_update)

    End Sub

    Private Sub btn_delete_MouseHover(sender As Object, e As EventArgs) Handles btn_delete.MouseHover
        frm_teacher.SetHoverStyle(btn_delete)

    End Sub

    Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
        frm_teacher.SetLeaveStyle(btn_delete)

    End Sub

    Private Sub cbo_lv_DropDown(sender As Object, e As EventArgs) Handles cbo_lv.DropDown
        obj.BindComboBox("SELECT EDUCATION_LEVEL_ID,EDUCATION_LEVEL_KH FROM dbo.TBL_EDUCATION_LEVEL", cbo_lv, "EDUCATION_LEVEL_KH", "EDUCATION_LEVEL_ID")

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frm_education_level.ShowDialog()
    End Sub
End Class
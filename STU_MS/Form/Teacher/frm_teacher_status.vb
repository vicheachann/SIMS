Public Class frm_teacher_status
    Dim obj As New Method
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub frm_office_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SelectOffice()
    End Sub
    Private Sub SelectOffice()
        obj.OpenConnection()

        Try
            obj.BindDataGridView("select TEACHER_STATUS_ID,ROW_NUMBER() OVER(ORDER BY TEACHER_STATUS_ID asc) AS 'ROW_NUM',TEACHER_STATUS_KH from dbo.TBL_TEACHER_STATUS", datagrid)

            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "ល.រ"
            datagrid.Columns(2).HeaderText = "ស្ថានភាពការងារ"

            datagrid.Columns(1).Width = 100
            datagrid.Columns(2).Width = 646


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        txt_kh.Clear()
        txt_no.Clear()
        txt_kh.Focus()

        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_save.Enabled = True
    End Sub

  

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_kh.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")
                txt_kh.Focus()
                Exit Sub
            End If

            obj.Insert("insert into dbo.TBL_TEACHER_STATUS(TEACHER_STATUS_KH)values(N'" & txt_kh.Text & "')")
            Call SelectOffice()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            If txt_kh.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")
                txt_kh.Focus()
                Exit Sub
            End If

            obj.Update("update dbo.TBL_TEACHER_STATUS set TEACHER_STATUS_KH = N'" & txt_kh.Text & "' where TEACHER_STATUS_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")
            Call SelectOffice()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        'Try
        '    obj.Insert_SQL("delete from dbo.TBL_TEACHER_STATUS where  TEACHER_STATUS_ID = " & DG_T.SelectedRows(0).Cells(0).Value & "")
        '    Call SelectOffice()
        'Catch ex As Exception
        '    obj.ShowMsg(ex.Message, msg_fail)
        'End Try

        Try
            If datagrid.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEACHER_STATUS where  TEACHER_STATUS_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")

                    Call SelectOffice()
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

    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        Try

            txt_no.Text = datagrid.SelectedRows(0).Cells(1).Value
            txt_kh.Text = datagrid.SelectedRows(0).Cells(2).Value

        Catch ex As Exception

        End Try
    End Sub
End Class
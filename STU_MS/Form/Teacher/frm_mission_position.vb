Public Class frm_mission_position
    Dim obj As New Method
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub frm_office_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call Selection()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Selection()
        obj.OpenConnection()

        Try
            obj.BindDataGridView("SELECT MISSION_POSITION_ID,MISSION_POSITION_KH FROM dbo.TBL_MISSION_POSITION", datagrid)
            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "បេសកម្ម"

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

        txt_mission.Focus()
    End Sub

    Private Sub DG_T_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        Try
            clear()

            txt_mission.Text = datagrid.SelectedRows(0).Cells(1).Value
        Catch ex As Exception

        End Try

    End Sub
    Public Sub clear()
        txt_mission.Clear()

    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_mission.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")
                txt_mission.Focus()
                Exit Sub
            End If

            obj.Insert("INSERT INTO dbo.TBL_MISSION_POSITION(MISSION_POSITION_KH)VALUES(N'" & txt_mission.Text & "')")
            Call Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            If txt_mission.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")
                txt_mission.Focus()
                Exit Sub
            End If

            obj.Update("UPDATE dbo.TBL_MISSION_POSITION SET MISSION_POSITION_KH = N'" & txt_mission.Text & "'  WHERE MISSION_POSITION_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")
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
                    obj.Delete("DELETE FROM  dbo.TBL_MISSION_POSITION WHERE  MISSION_POSITION_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")

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
End Class
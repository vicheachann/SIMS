﻿Public Class frm_student_status
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
            obj.BindDataGridView("SELECT STUDENT_STATUS_ID,ROW_NUMBER() OVER(ORDER BY STUDENT_STATUS_ID asc) AS 'ROW_NUM',STUDENT_STATUS_KH,STUDENT_STATUS_EN FROM dbo.TBS_STUDENT_STATUS", datagrid)
            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "ល.រ"
            datagrid.Columns(2).HeaderText = "ស្ថានភាពសិស្ស(ខ្មែរ)"
            datagrid.Columns(3).HeaderText = "ស្ថានភាពសិស្ស(ឡាតាំង)"

            datagrid.Columns(1).Width = 50
            datagrid.Columns(2).Width = 348
            datagrid.Columns(3).Width = 348
            datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        Catch ex As Exception

        End Try
    End Sub
    Public Sub clear()
        txt_no.Clear()
        txt_en.Clear()
        txt_kh.Clear()
    End Sub
    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        Try
            clear()
            txt_no.Text = datagrid.SelectedRows(0).Cells(1).Value
            txt_kh.Text = datagrid.SelectedRows(0).Cells(2).Value
            txt_en.Text = datagrid.SelectedRows(0).Cells(3).Value

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        clear()
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_save.Enabled = True

        txt_kh.Focus()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_kh.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                txt_kh.Focus()
                Exit Sub
            End If



            obj.Insert("INSERT INTO dbo.TBS_STUDENT_STATUS (STUDENT_STATUS_KH,STUDENT_STATUS_EN)VALUES(N'" & txt_kh.Text & "',N'" & txt_en.Text & "')")
            Call Selection()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub



    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            If txt_kh.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                txt_kh.Focus()
                Exit Sub
            End If


            obj.Update("UPDATE dbo.TBS_STUDENT_STATUS SET STUDENT_STATUS_KH = N'" & txt_kh.Text & "',STUDENT_STATUS_EN = N'" & txt_en.Text & "' WHERE STUDENT_STATUS_ID =" & datagrid.SelectedRows(0).Cells(0).Value & "")
            Call Selection()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Try
            If datagrid.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE FROM  dbo.TBS_STUDENT_STATUS WHERE  STUDENT_STATUS_ID = " & datagrid.SelectedRows(0).Cells(0).Value & "")
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

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub


End Class
Public Class FrmStudentDropStudyReason
    Dim obj As New Method
    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        clear()
        lblUpdate.Enabled = False
        lblDelete.Enabled = False
        lblSave.Enabled = True
        txtStopReasonKh.Focus()
    End Sub

    Public Sub clear()
        txtNo.Clear()
        txtStopReasonKh.Clear()
        txtStopReasonEn.Clear()
    End Sub

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        Try
            If txtStopReasonKh.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "")
                txtStopReasonKh.BackColor = Color.MistyRose
                txtStopReasonKh.Focus()
                Exit Sub
            End If

            obj.Insert("INSERT INTO dbo.TBS_STUDENT_STOP_REASON(STUDENT_STOP_REASON_KH,STUDENT_STOP_REASON_EN)VALUES(N'" & txtStopReasonKh.Text & "',N'" & txtStopReasonEn.Text & "')")
            Call Selection()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub txtStopReasonKh_TextChanged(sender As Object, e As EventArgs) Handles txtStopReasonKh.TextChanged
        txtStopReasonKh.BackColor = Color.White
    End Sub

    Private Sub Selection()
        obj.OpenConnection()

        Try
            obj.BindDataGridView("SELECT STUDENT_STOP_REASON_ID,ROW_NUMBER() OVER(ORDER BY STUDENT_STOP_REASON_KH asc) AS 'ROW_NUM',STUDENT_STOP_REASON_KH,STUDENT_STOP_REASON_EN FROM dbo.TBS_STUDENT_STOP_REASON", datagrid)

            datagrid.Columns(0).Visible = False
            datagrid.Columns(1).HeaderText = "ល.រ"
            datagrid.Columns(2).HeaderText = "មូលហេតុបោះបង់ (ខ្មែរ)"
            datagrid.Columns(3).HeaderText = "មូលហេតុបោះបង់ (ឡាំតាំង"

            datagrid.Columns(1).Width = 100
            datagrid.Columns(2).Width = 323
            datagrid.Columns(3).Width = 323

            datagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmStudentDropStudyReason_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Selection()
    End Sub

    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        lblSave.Enabled = False
        lblDelete.Enabled = True
        lblUpdate.Enabled = True
        Try
            clear()
            txtNo.Text = datagrid.SelectedRows(0).Cells(1).Value
            txtStopReasonKh.Text = datagrid.SelectedRows(0).Cells(2).Value
            txtStopReasonEn.Text = datagrid.SelectedRows(0).Cells(3).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        Try
            obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែលឬទេ?", FrmMessageQuestion, "")
            If USER_CLICK_OK = True Then

                If txtStopReasonKh.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "")
                    txtStopReasonKh.BackColor = Color.MistyRose
                    txtStopReasonKh.Focus()
                    Exit Sub
                End If

                obj.Insert("UPDATE dbo.TBS_STUDENT_STOP_REASON SET STUDENT_STOP_REASON_KH = N'" & txtStopReasonKh.Text & "', STUDENT_STOP_REASON_EN = N'" & txtStopReasonEn.Text & "' WHERE STUDENT_STOP_REASON_ID = " & datagrid.SelectedCells(1).Value & "")
                Call Selection()
            End If
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            If (datagrid.Rows.Count > 0) Then
                obj.ShowMsg("តើអ្នកចង់លុបព័ត៌មាននេះដែលឬទេ?", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE FROM dbo.TBS_STUDENT_STOP_REASON WHERE STUDENT_STOP_REASON_ID = " & datagrid.SelectedCells(1).Value & "")
                    Call Selection()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
End Class
Imports System.Data.SqlClient
Public Class frm_teacher_mission
    Dim obj As New Method

    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub cbo_teacher_DropDown(sender As Object, e As EventArgs) Handles cboTeacher.DropDown
        obj.BindComboBox("SELECT  TEACHER_ID,T_NAME_KH FROM dbo.TBL_TEACHER WHERE TEACHER_STATUS_ID  IN(1,6)", cboTeacher, "T_NAME_KH", "TEACHER_ID")
    End Sub
    Private Sub cbo_mission_DropDown(sender As Object, e As EventArgs) Handles cboMission.DropDown
        obj.BindComboBox("select MISSION_POSITION_ID, MISSION_POSITION_KH from dbo.TBL_MISSION_POSITION", cboMission, "MISSION_POSITION_KH", "MISSION_POSITION_ID")
    End Sub

    Private Sub lbl_insert_Click(sender As Object, e As EventArgs) Handles lblInsert.Click
        For Each row As DataGridViewRow In dg.Rows
            If cboTeacher.SelectedValue = row.Cells(2).Value Then
                obj.ShowMsg("បានបញ្ចូលរួចរាល់,សូមជ្រើសរើសបុគ្គលិកផ្សេងៗ", FrmWarning, "")
                Exit Sub
            End If
        Next

        If cboTeacher.Text = "" Or cboMission.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
            Exit Sub
        End If




        dg.Rows.Add(New String() {"", cboTeacher.Text, cboTeacher.SelectedValue, cboMission.Text, cboMission.SelectedValue, txtDes.Text})
        cboTeacher.Text = ""
        cboMission.Text = ""
        txtDes.Clear()
        cboTeacher.Focus()

    End Sub

    Private Sub lbl_remove_Click(sender As Object, e As EventArgs) Handles lblRemove.Click
        If dg.SelectedRows.Count > 0 Then

            If txtMissionId.Text <> "" Then
                ' Call obj.Delete_SQL_WM("DELETE FROM dbo.TBL_TEACHER_MISSION_DETAIL WHERE MISSION_ID=" & txt_MISSION_ID.Text & " AND RECORD_ID=" & dg_detail.SelectedCells(0).Value.ToString() & "")
                Call obj.Delete_1("DELETE FROM dbo.TBL_TEACHER_MISSION_DETAIL WHERE MISSION_ID=" & txtMissionId.Text & " AND RECORD_ID=" & dg.SelectedCells(0).Value.ToString() & "")

            End If
            dg.Rows.RemoveAt(dg.CurrentCell.RowIndex)
        Else

        End If

    End Sub

    Private Sub dg_detail_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dg.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dg.RowHeadersDefaultCellStyle.ForeColor)

            e.Graphics.DrawString(CInt(e.RowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture)) + 1, dg.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub lbl_save_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        If dg.RowCount <= 0 Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានជាមុន", FrmWarning, "Windows Ding.wav")
            cboTeacher.Focus()
            Exit Sub
        End If


        If txtMissionNumber.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលលេខបេសកម្ម", FrmWarning, "")
            txtMissionNumber.Focus()
            txtMissionNumber.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If txtMissionMeaning.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលខ្លឹមសារបេសកម្ម", FrmWarning, "")
            txtMissionMeaning.Focus()
            txtMissionMeaning.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If txtMissionTo.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលបេសកម្មទៅកាន់", FrmWarning, "")
            txtMissionTo.Focus()
            txtMissionTo.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        obj.InsertNoMsg("INSERT INTO dbo.TBL_TEACHER_MISSION_MASTER(MISSION_NUMBER,MISSION_DATE,MISSION_MEANING,MISSION_TO,LOCATION,[DESCRIPTION],DATE_NOTE)VALUES(N'" & txtMissionNumber.Text & "','" & dtMissionDate.Text & "',N'" & txtMissionMeaning.Text & "',N'" & txtMissionTo.Text & "',N'" & txtLocation.Text & "',N'" & txtRemark.Text & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')")

        For i As Integer = 0 To dg.RowCount - 1
            Call obj.InsertNoMsg("INSERT INTO  dbo.TBL_TEACHER_MISSION_DETAIL (MISSION_ID, TEACHER_ID, MISSION_POSITION_ID, [DESCRIPTION], DATE_NOTE)VALUES((Select MAX(MISSION_ID) FROM dbo.TBL_TEACHER_MISSION_MASTER)," & dg.Rows(i).Cells(2).Value & "," & dg.Rows(i).Cells(4).Value & ",N'" & dg.Rows(i).Cells(5).Value.ToString & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')")
        Next
        Call obj.ShowMsg("ទិន្នន័យរក្សាទុកបានសម្រេច!", FrmMessageSuccess, "")
    End Sub

    'Private Sub cbo_search_mission_number_DropDown(sender As Object, e As EventArgs)
    '    obj.Bind_combobox("SELECT MISSION_ID,MISSION_NUMBER FROM dbo.TBL_TEACHER_MISSION_MASTER", cbo_search_mission_number, "MISSION_NUMBER", "MISSION_ID")
    '    cbo_mission_DropDown(sender, e)
    '    cbo_teacher_DropDown(sender, e)
    'End Sub

    '    Private Sub cbo_search_mission_number_SelectedIndexChanged(sender As Object, e As EventArgs)
    '        Try
    '            Call obj.OpenConnection()
    '            cmd = New SqlCommand("SELECT MISSION_ID,MISSION_NUMBER,MISSION_DATE,MISSION_MEANING,MISSION_TO,LOCATION,DESCRIPTION,DATE_NOTE" & vbCrLf &
    '"FROM dbo.TBL_TEACHER_MISSION_MASTER WHERE MISSION_ID =" & cbo_search_mission_number.SelectedValue & "", con)
    '            da = New SqlDataAdapter(cmd)
    '            dt = New DataTable
    '            da.Fill(dt)

    '            If dt.Rows.Count > 0 Then
    '                txt_MISSION_ID.Text = dt.Rows(0)(0).ToString()
    '                txt_MISSION_NUMBER.Text = dt.Rows(0)(1).ToString()
    '                dt_MISSION_DATE.Text = dt.Rows(0)(2).ToString()
    '                txt_MISSION_MEANING.Text = dt.Rows(0)(3).ToString()
    '                txt_MISSION_TO.Text = dt.Rows(0)(4).ToString()
    '                txt_LOCATION.Text = dt.Rows(0)(5).ToString()
    '                txt_DESCRIPTION.Text = dt.Rows(0)(6).ToString()
    '                dt_DATENOTE.Text = dt.Rows(0)(7).ToString()
    '            End If

    '            Call obj.OpenConnection()
    '            cmd = New SqlCommand("SELECT TMD.RECORD_ID,T.T_NAME_KH, TMD.TEACHER_ID, TM.MISSION_POSITION_KH, TMD.MISSION_POSITION_ID, TMD.DESCRIPTION" & vbCrLf &
    '"FROM         dbo.TBL_TEACHER_MISSION_DETAIL AS TMD INNER JOIN" & vbCrLf &
    '"                      dbo.TBL_MISSION_POSITION AS TM ON TMD.MISSION_POSITION_ID = TM.MISSION_POSITION_ID INNER JOIN" & vbCrLf &
    '"                      dbo.TBL_TEACHER AS T ON TMD.TEACHER_ID = T.TEACHER_ID WHERE TMD.MISSION_ID = " & cbo_search_mission_number.SelectedValue & " ", con)

    '            da = New SqlDataAdapter(cmd)
    '            dt = New DataTable
    '            da.Fill(dt)
    '            dg_detail.Rows.Clear()

    '            If dt.Rows.Count > 0 Then

    '                For i As Integer = 0 To dt.Rows.Count - 1
    '                    dg_detail.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString())
    '                    dg_detail.Columns(2).Visible = False
    '                    dg_detail.Columns(4).Visible = False
    '                    dg_detail.Columns(0).Visible = False
    '                Next
    '            End If
    '            lbl_new.Enabled = True
    '            lbl_save.Enabled = False
    '            lbl_update.Enabled = True
    '        Catch ex As Exception
    '            error_reason = ex.Message
    '            obj.ShowMsg("ពុំស្វែងរកទិន្នន័យបានទេ!", msg_fail, "Error.wav")
    '        End Try
    '    End Sub

    Private Sub lbl_new_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Call Clear()
        txtMissionNumber.Focus()
        lblNew.Enabled = False
        lblSave.Enabled = True
        lblUpdate.Enabled = False

    End Sub

    Private Sub Clear()
        txtMissionId.Clear()
        txtMissionNumber.Clear()
        dtMissionDate.Text = Date.Today
        txtMissionMeaning.Clear()
        txtMissionTo.Clear()
        txtLocation.Clear()
        txtRemark.Clear()
        dtDatenote.Text = Date.Today
        dg.Rows.Clear()
    End Sub

    Private Sub lbl_update_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        obj.ShowMsg("តើអ្នកចង់កែប្រែទិន្នន័យនេះដែលឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then

            If dg.RowCount <= 0 Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានជាមុន", FrmWarning, "Windows Ding.wav")
                cboTeacher.Focus()
                Exit Sub
            End If


            If txtMissionNumber.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលលេខបេសកម្ម", FrmWarning, "")
                txtMissionNumber.Focus()
                txtMissionNumber.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txtMissionMeaning.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលខ្លឹមសារបេសកម្ម", FrmWarning, "")
                txtMissionMeaning.Focus()
                txtMissionMeaning.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txtMissionTo.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលបេសកម្មទៅកាន់", FrmWarning, "")
                txtMissionTo.Focus()
                txtMissionTo.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            'Update master
            obj.UpdateNoMsg("UPDATE dbo.TBL_TEACHER_MISSION_MASTER SET MISSION_NUMBER = N'" & txtMissionNumber.Text & "' , MISSION_DATE = '" & dtMissionDate.Value & "',MISSION_MEANING = N'" & txtMissionMeaning.Text & "',MISSION_TO = N'" & txtMissionTo.Text & "',LOCATION = N'" & txtLocation.Text & "', [DESCRIPTION] = '" & txtRemark.Text & "' WHERE MISSION_ID =" & txtMissionId.Text & "")

            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT RECORD_ID FROM dbo.TBL_TEACHER_MISSION_DETAIL WHERE (MISSION_ID =" & txtMissionId.Text & ") ", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            For i As Integer = 0 To dg.RowCount - 1
                Try
                    If dt.Rows(i)(0).ToString() = dg.Rows(i).Cells(0).Value.ToString() Then
                        Call obj.UpdateNoMsg("UPDATE dbo.TBL_TEACHER_MISSION_DETAIL SET TEACHER_ID= " & dg.Rows(i).Cells(2).Value & ",MISSION_POSITION_ID = " & dg.Rows(i).Cells(4).Value & ",[DESCRIPTION] = N'" & dg.Rows(i).Cells(5).Value & "' WHERE RECORD_ID = " & dg.Rows(i).Cells(0).Value & " AND MISSION_ID = " & txtMissionId.Text & "")
                    End If
                Catch ex As Exception
                    Call obj.InsertNoMsg("INSERT INTO dbo.TBL_TEACHER_MISSION_DETAIL(MISSION_ID,TEACHER_ID,MISSION_POSITION_ID,[DESCRIPTION],DATE_NOTE)VALUES(" & txtMissionId.Text & "," & dg.Rows(i).Cells(2).Value & "," & dg.Rows(i).Cells(4).Value & ",N'" & dg.Rows(i).Cells(5).Value & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')")
                End Try
            Next

            obj.ShowMsg("កែប្រែបានសម្រច", FrmMessageSuccess, "")
            Call SelectSearch()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub dg_detail_SelectionChanged(sender As Object, e As EventArgs) Handles dg.SelectionChanged
        lblInsert.Enabled = False
        Try


            cboTeacher.Text = dg.SelectedRows(0).Cells(1).Value.ToString
            cboMission.Text = dg.SelectedRows(0).Cells(3).Value.ToString
            txtDes.Text = dg.SelectedRows(0).Cells(5).Value.ToString


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lblEdit.Click
        Try

            For Each row As DataGridViewRow In dg.Rows
                If cboTeacher.SelectedValue = dg.SelectedRows(0).Cells(2).Value Then
                ElseIf cboTeacher.SelectedValue = row.Cells(2).Value Then
                    obj.ShowMsg("បានបញ្ចូលរួចរាល់,សូមជ្រើសរើសបុគ្គលិកផ្សេងៗ", FrmWarning, "")
                    Exit Sub
                End If
            Next

            If cboTeacher.Text = "" Or cboMission.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                Exit Sub
            End If
            dg.SelectedRows(0).Cells(1).Value = cboTeacher.Text
            dg.SelectedRows(0).Cells(2).Value = cboTeacher.SelectedValue
            dg.SelectedRows(0).Cells(3).Value = cboMission.Text
            dg.SelectedRows(0).Cells(4).Value = cboMission.SelectedValue
            dg.SelectedRows(0).Cells(5).Value = txtDes.Text

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("Cannot update", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub txt_document_Click(sender As Object, e As EventArgs) Handles txtAttactment.Click

    End Sub

    Private Sub txt_document_TextChanged(sender As Object, e As EventArgs) Handles txtAttactment.TextChanged

    End Sub

    Private Sub lbl_delete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then
                obj.Delete_1("DELETE FROM dbo.TBL_TEACHER_MISSION_DETAIL WHERE MISSION_ID = " & txtMissionId.Text & "")
                obj.Delete_1("DELETE FROM dbo.TBL_TEACHER_MISSION_MASTER WHERE MISSION_ID = " & txtMissionId.Text & "")

                obj.ShowMsg("ទិន្នន័យត្រូវបានលុប", FrmMessageSuccess, "")

                ''Call Selection()
                USER_CLICK_OK = False
                'cbo_search_mission_number_DropDown(sender, e)
            Else
                Exit Sub
            End If

        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        frm_mission_position.ShowDialog()
    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub txt_MISSION_ID_TextChanged(sender As Object, e As EventArgs) Handles txtMissionId.TextChanged

    End Sub

    Private Sub txtMissionNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMissionNumber.TextChanged
        txtMissionNumber.BackColor = Color.White
    End Sub

    Private Sub txtMissionTo_TextChanged(sender As Object, e As EventArgs) Handles txtMissionTo.TextChanged
        txtMissionTo.BackColor = Color.White

    End Sub

    Private Sub txtMissionMeaning_TextChanged(sender As Object, e As EventArgs) Handles txtMissionMeaning.TextChanged
        txtMissionMeaning.BackColor = Color.White
    End Sub

    Private Sub SelectSearch()
        obj.BindDataGridView("SELECT MISSION_ID,MISSION_NUMBER,MISSION_DATE FROM dbo.TBL_TEACHER_MISSION_MASTER", dgSearch)

        dgSearch.Columns(0).Visible = False 'ID
        dgSearch.Columns(1).HeaderText = "លេខបេសកម្ម"
        dgSearch.Columns(2).HeaderText = "កាលបរិច្ឆេទ"

        dgSearch.Columns(1).Width = 130
        dgSearch.Columns(2).Width = 100
    End Sub

    Private Sub frm_teacher_mission_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelectSearch()
    End Sub

    Private Sub dgSearch_SelectionChanged(sender As Object, e As EventArgs) Handles dgSearch.SelectionChanged
        Try
            Call Clear()

            'Select master
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT MISSION_ID,MISSION_NUMBER,MISSION_DATE,MISSION_MEANING,MISSION_TO,LOCATION,DESCRIPTION,DATE_NOTE FROM dbo.TBL_TEACHER_MISSION_MASTER WHERE MISSION_ID =" & dgSearch.SelectedCells(0).Value & "", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                txtMissionId.Text = dt.Rows(0)(0).ToString()
                txtMissionNumber.Text = dt.Rows(0)(1).ToString()
                dtMissionDate.Text = dt.Rows(0)(2).ToString()
                txtMissionMeaning.Text = dt.Rows(0)(3).ToString()
                txtMissionTo.Text = dt.Rows(0)(4).ToString()
                txtLocation.Text = dt.Rows(0)(5).ToString()
                txtRemark.Text = dt.Rows(0)(6).ToString()
                dtDatenote.Text = dt.Rows(0)(7).ToString()
            End If

            'Select detail
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT TMD.RECORD_ID,T.T_NAME_KH, TMD.TEACHER_ID, TM.MISSION_POSITION_KH, TMD.MISSION_POSITION_ID, TMD.DESCRIPTION FROM dbo.TBL_TEACHER_MISSION_DETAIL AS TMD INNER JOIN dbo.TBL_MISSION_POSITION AS TM ON TMD.MISSION_POSITION_ID = TM.MISSION_POSITION_ID INNER JOIN dbo.TBL_TEACHER AS T ON TMD.TEACHER_ID = T.TEACHER_ID WHERE TMD.MISSION_ID = " & dgSearch.SelectedCells(0).Value & " ", conn)

            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                For i As Integer = 0 To dt.Rows.Count - 1
                    dg.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString())
                Next
            End If

            lblSave.Enabled = False
            lblUpdate.Enabled = True
            lblDelete.Enabled = True

        Catch ex As Exception
            ' error_reason = ex.Message
            ' obj.ShowMsg("ពុំស្វែងរកទិន្នន័យបានទេ!", msg_fail, "Error.wav")
        End Try
    End Sub

    Private Sub lblDetailNew_Click(sender As Object, e As EventArgs) Handles lblDetailNew.Click
        lblInsert.Enabled = True
        cboTeacher.Focus()

        cboTeacher.Text = ""
        cboMission.Text = ""
        txtDes.Clear()
    End Sub

    Private Sub cboTeacher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTeacher.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboMission_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboMission.KeyPress
        e.Handled = True
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)
        MessageBox.Show(dg.SelectedCells(4).Value.ToString)
    End Sub
End Class
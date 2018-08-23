Imports System.Data.SqlClient

Public Class frm_class_monitor
    Dim obj As New Method
    Dim class_id As Integer
    Dim Search_only As Boolean
    Dim t As New Theme

    Dim SELECT_FIRST_WITHOUT_CLASS As String
    Dim SELECT_FIRST_WITH_CLASS As String


    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub MoveRow(ByVal i As Integer)

        Try

            If (dgSelected.SelectedCells.Count > 0) Then

                Dim curr_index As Integer = Me.dgSelected.CurrentCell.RowIndex

                Dim curr_col_index As Integer = Me.dgSelected.CurrentCell.ColumnIndex

                Dim curr_row As DataGridViewRow = Me.dgSelected.CurrentRow

                Me.dgSelected.Rows.Remove(curr_row)

                Me.dgSelected.Rows.Insert(curr_index + i, curr_row)

                Me.dgSelected.CurrentCell = Me.dgSelected(curr_col_index, curr_index + i)

            End If

        Catch ex As Exception

            ' do nothing if error encountered while trying to move the row up or down

        End Try

    End Sub
















    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub









    Private Sub cbo_year_study_DropDown(sender As Object, e As EventArgs) Handles cboSearchYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboSearchYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub

    Private Sub cbo_class_DropDown(sender As Object, e As EventArgs) Handles cboSearchClass.DropDown
        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboSearchClass, "CLASS_LETTER", "CLASS_ID")

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
        frm_class.ShowDialog()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        frm_year_study.ShowDialog()
    End Sub

    Private Sub lbl_search_Click_1(sender As Object, e As EventArgs) Handles lbl_search.Click

        If cboSearchYearStudy.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
            cboSearchYearStudy.BackColor = Color.LavenderBlush
            cboSearchYearStudy.Focus()
            Exit Sub
        End If
        If cboSearchClass.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
            cboSearchClass.BackColor = Color.LavenderBlush
            cboSearchClass.Focus()
            Exit Sub
        End If

        Try
            Call AddStudentToSearchGrid(cboSearchYearStudy.Text, cboSearchClass.SelectedValue)
            Call SelectExistedClassMonitor(cboSearchYearStudy.Text, cboSearchClass.SelectedValue)
            Call DisableSaveIfHasRow()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DisableSaveIfHasRow()
        If (dgSelected.Rows.Count > 0) Then
            lblSave.Enabled = False
            lblUpdate.Enabled = True
        Else
            lblSave.Enabled = True
            lblUpdate.Enabled = False
        End If
    End Sub

    Private Sub SelectExistedClassMonitor(ByVal yearStudy As String, ByVal classID As String)
        Try
            cmd = New SqlCommand("SELECT ROW_NUMBER() OVER(ORDER BY C.CLASS_MONITOR_NUM ASC) AS 'ROW_NUMBER',I.STUDENT_ID, I.SNAME_KH, I.GENDER, dbo.TBS_CLASS.CLASS_LETTER, C.CLASS_MONITOR_NUM, C.YEAR_STUDY, C.CLASS_ID, C.RECORD_ID FROM dbo.TBS_STUDENT_CLASS_MONITOR AS C INNER JOIN dbo.TBS_STUDENT_INFO AS I ON C.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_CLASS ON C.CLASS_ID = dbo.TBS_CLASS.CLASS_ID WHERE YEAR_STUDY =N'" & yearStudy & "' AND C.CLASS_ID  = " & classID & "", conn)

            da = New SqlDataAdapter(cmd)
            GlobalVariable.dt = New DataTable
            da.Fill(GlobalVariable.dt)

            dgSelected.Rows.Clear()
            For i As Integer = 0 To GlobalVariable.dt.Rows.Count - 1
                dgSelected.Rows.Add(GlobalVariable.dt.Rows(i)(0).ToString(), GlobalVariable.dt.Rows(i)(1).ToString(), GlobalVariable.dt.Rows(i)(2).ToString(), GlobalVariable.dt.Rows(i)(3).ToString(), GlobalVariable.dt.Rows(i)(4).ToString(), GlobalVariable.dt.Rows(i)(5).ToString(), GlobalVariable.dt.Rows(i)(6).ToString(), GlobalVariable.dt.Rows(i)(7).ToString(), GlobalVariable.dt.Rows(i)(8).ToString())
            Next

            dgSelected.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgSelected.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgSelected.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgSelected.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Call CountClassMonitor()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_class_TextChanged(sender As Object, e As EventArgs) Handles cboSearchClass.TextChanged
        cboSearchClass.BackColor = Color.White

    End Sub

    Private Sub cbo_year_study_TextChanged(sender As Object, e As EventArgs) Handles cboSearchYearStudy.TextChanged
        cboSearchYearStudy.BackColor = Color.White

    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If dgSearch.Rows.Count > 0 Then
            If (CheckExisted("SELECT  STUDENT_ID,YEAR_STUDY,CLASS_ID FROM dbo.TBS_STUDENT_CLASS_MONITOR WHERE STUDENT_ID = " & dgSearch.SelectedCells(1).Value & " AND YEAR_STUDY = N'" & dgSearch.SelectedCells(4).Value & "' AND CLASS_ID = " & dgSearch.SelectedCells(5).Value & "", "TBS_STUDENT_CLASS_MONITOR") = False) Then
                dgSelected.Rows.Add(1, dgSearch.SelectedCells(1).Value, dgSearch.SelectedCells(2).Value, dgSearch.SelectedCells(3).Value, dgSearch.SelectedCells(6).Value, 1, dgSearch.SelectedCells(4).Value, dgSearch.SelectedCells(5).Value)
                dgSearch.Rows.Remove(dgSearch.SelectedRows(0))
                Call CountClassMonitor()
            Else
                obj.ShowMsg("ឈ្មោះ " & dgSearch.SelectedCells(2).Value & " បានជ្រើសរើសរួចរាល់ហើយ", FrmWarning, "Windows Ding.wav")
            End If
        End If
    End Sub

    Private Sub dg_selected_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgSelected.RowPrePaint
        If e.RowIndex >= 0 Then
            Me.dgSelected.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
            Me.dgSelected.Rows(e.RowIndex).Cells(5).Value = e.RowIndex + 1
        End If
    End Sub



    Dim rowIndex As Integer
    Dim table As New DataTable("table")
    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles btn_up.Click
        Try

            If dgSelected.CurrentCell.RowIndex = 0 Then
                Exit Sub
            End If
            MoveRow(-1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_down_Click(sender As Object, e As EventArgs) Handles btn_down.Click
        Try
            If Me.dgSelected.CurrentCell.RowIndex = dgSelected.RowCount - 1 Then
                Exit Sub
            End If
            MoveRow(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CountClassMonitor()
        Dim totalGirlSelected As Integer = 0
        lblTotalSelected.Text = dgSelected.Rows.Count.ToString

        If dgSelected.Rows.Count > 0 Then
            For i As Integer = 0 To dgSelected.RowCount - 1
                If (dgSelected.Rows(i).Cells(3).Value.ToString = "ស្រី") Then
                    totalGirlSelected += 1
                End If
            Next
        End If
        lblTotalSelected.Text = dgSelected.Rows.Count.ToString
        lblTotalGirlSelected.Text = totalGirlSelected.ToString
    End Sub

    Private Sub DG_SEARCH_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSearch.CellDoubleClick
        btn_select_Click(sender, e)
    End Sub

    Private Sub btn_moveBack_Click(sender As Object, e As EventArgs) Handles btn_moveBack.Click

        If dgSelected.SelectedRows.Count > 0 Then

            If (CheckExisted("SELECT  STUDENT_ID,YEAR_STUDY,CLASS_ID FROM dbo.TBS_STUDENT_CLASS_MONITOR WHERE STUDENT_ID = " & dgSelected.SelectedCells(1).Value & " AND YEAR_STUDY = N'" & dgSelected.SelectedCells(6).Value & "' AND CLASS_ID = " & dgSelected.SelectedCells(7).Value & "", "TBS_STUDENT_CLASS_MONITOR") = True) Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    Call obj.Delete("DELETE FROM dbo.TBS_STUDENT_CLASS_MONITOR WHERE STUDENT_ID = " & dgSelected.SelectedCells(1).Value & " AND YEAR_STUDY = N'" & dgSelected.SelectedCells(6).Value & "' AND CLASS_ID = " & dgSelected.SelectedCells(7).Value & "")
                    dgSearch.Rows.Add(1, dgSelected.SelectedCells(1).Value, dgSelected.SelectedCells(2).Value, dgSelected.SelectedCells(3).Value, dgSelected.SelectedCells(6).Value, dgSelected.SelectedCells(7).Value, dgSelected.SelectedCells(4).Value)
                    dgSelected.Rows.Remove(dgSelected.SelectedRows(0))
                    USER_CLICK_OK = False
                End If
            Else
                dgSearch.Rows.Add(1, dgSelected.SelectedCells(1).Value, dgSelected.SelectedCells(2).Value, dgSelected.SelectedCells(3).Value, dgSelected.SelectedCells(6).Value, dgSelected.SelectedCells(7).Value, dgSelected.SelectedCells(4).Value)
                dgSelected.Rows.Remove(dgSelected.SelectedRows(0))
            End If

        Else
            obj.ShowMsg("មិនមែនព័ត៌មានសម្រាប់លុបនោះទេ " + Environment.NewLine + "សូមបញ្ចូលព័ត៌មានជាមុខ​!", FrmWarning, "Error.wav")
        End If
    End Sub

    Public Function CheckExisted(ByVal sSql As String, ByVal table As String) As Boolean
        Try
            Dim totalRow As Long = 0
            Dim da As New SqlDataAdapter(sSql, conn)
            Dim ds As New DataSet()

            da.Fill(ds, table)

            totalRow = Convert.ToInt32(ds.Tables(table).Rows.Count)
            If (totalRow > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function


    Private Sub DG_SEARCH_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgSearch.RowPrePaint
        If e.RowIndex >= 0 Then
            Me.dgSearch.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1

        End If
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles lblSave.Click
        If dgSelected.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To dgSelected.RowCount - 1
                    If (CheckExisted("SELECT  STUDENT_ID,YEAR_STUDY,CLASS_ID FROM dbo.TBS_STUDENT_CLASS_MONITOR WHERE STUDENT_ID = " & dgSelected.Rows(i).Cells(1).Value & " AND YEAR_STUDY = N'" & dgSelected.Rows(i).Cells(6).Value & "' AND CLASS_ID = " & dgSelected.Rows(i).Cells(7).Value & "", "TBS_STUDENT_CLASS_MONITOR") = False) Then
                        obj.Insert_1("INSERT INTO dbo.TBS_STUDENT_CLASS_MONITOR(STUDENT_ID,YEAR_STUDY,CLASS_ID,CLASS_MONITOR_NUM, REMARK,DATE_NOTE)VALUES(" & dgSelected.Rows(i).Cells(1).Value & ",N'" & dgSelected.Rows(i).Cells(6).Value & "'," & dgSelected.Rows(i).Cells(7).Value & "," & dgSelected.Rows(i).Cells(5).Value & ",'',GETDATE())")
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Call obj.ShowMsg("រក្សាទុកបានជោគជ័យ", FrmMessageSuccess, "success.wav")
        Else
            obj.ShowMsg("សូមស្វែងរកព័ត៌មានជាមុន", FrmWarning, "")
        End If
    End Sub

    Private Sub lbl_new_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        dgSearch.Rows.Clear()
        dgSelected.Rows.Clear()
        lblTotalSelected.Text = "0"
        lblTotalGirlSelected.Text = "0"

        cboSearchClass.Text = ""
        cboSearchYearStudy.Text = ""
        lblSave.Enabled = True
        lblUpdate.Enabled = False

        cboSearchYearStudy.Focus()
    End Sub


    Private Sub CountGenderYearStudy_tabView()
        dr = obj.SelectData("SELECT COUNT(CASE WHEN S.GENDER =N'ស្រី' THEN 1 END) AS 'NUM_GIRL' FROM dbo.TBS_STUDENT_CLASS_MONITOR AS M  INNER JOIN dbo.TBS_STUDENT_INFO AS S on M.STUDENT_ID = S.STUDENT_ID WHERE M.YEAR_STUDY = N'" & cboYearStudy.Text & "'")
        Try
            'Reset first
            lblTotalClassMonitor.Text = "0"
            lblTotalClassMonitorGirl.Text = "0"

            If dr.HasRows Then
                While dr.Read
                    lblTotalClassMonitorGirl.Text = If(dr.IsDBNull(0), "0", dr.GetValue(0).ToString)
                End While
            End If

            lblTotalClassMonitor.Text = dgDisplay.Rows.Count.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CountGenderClass_tabView()
        dr = obj.SelectData("SELECT COUNT(CASE WHEN S.GENDER =N'ស្រី' THEN 1 END) AS 'NUM_GIRL' FROM dbo.TBS_STUDENT_CLASS_MONITOR AS M  INNER JOIN dbo.TBS_STUDENT_INFO AS S on M.STUDENT_ID = S.STUDENT_ID WHERE M.YEAR_STUDY = N'" & cboYearStudy.Text & "' AND M.CLASS_ID = " & cboClass.SelectedValue & "")
        Try
            'Reset first
            lblTotalClassMonitor.Text = "0"
            lblTotalClassMonitorGirl.Text = "0"

            If dr.HasRows Then
                While dr.Read
                    lblTotalClassMonitorGirl.Text = If(dr.IsDBNull(0), "0", dr.GetValue(0).ToString)
                End While
            End If

            lblTotalClassMonitor.Text = dgDisplay.Rows.Count.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CountFemaleYearAndClass()
        dr = obj.SelectData("SELECT count(case when S.GENDER =N'ស្រី' then 1 end) as male_cnt from dbo.TBS_STUDENT_CLASS_MONITOR as M  inner join dbo.TBS_STUDENT_INFO AS S on M.STUDENT_ID = S.STUDENT_ID WHERE M.YEAR_STUDY = N'" & cboYearStudy.Text & "' AND M.CLASS_ID = " & cboClass.SelectedValue & "")
        Try
            If dr.HasRows Then
                While dr.Read
                    lblTotalClassMonitorGirl.Text = If(dr.IsDBNull(0), "", dr.GetValue(0).ToString)
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SelectAll_tabView(ByVal yearStudy As String)
        Try
            obj.BindDataGridView("SELECT ROW_NUMBER() OVER(ORDER BY M.CLASS_ID,M.CLASS_MONITOR_NUM ASC) AS 'ROW_NUMBER',S.STUDENT_ID, S.SNAME_KH, S.GENDER, M.YEAR_STUDY,M.CLASS_ID , C.CLASS_LETTER, M.CLASS_MONITOR_NUM, M.REMARK FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_CLASS_MONITOR AS M ON S.STUDENT_ID = M.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON M.CLASS_ID = C.CLASS_ID WHERE M.YEAR_STUDY = N'" & yearStudy & "' ", dgDisplay)
            Call SetTitile_tabView()
            Call CountGenderYearStudy_tabView()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SelectWithClass_tabView(ByVal yearStudy As String, ByVal classID As Integer)
        Try
            obj.BindDataGridView("SELECT ROW_NUMBER() OVER(ORDER BY M.CLASS_ID,M.CLASS_MONITOR_NUM ASC) AS 'ROW_NUMBER',S.STUDENT_ID, S.SNAME_KH, S.GENDER, M.YEAR_STUDY,M.CLASS_ID , C.CLASS_LETTER, M.CLASS_MONITOR_NUM, M.REMARK FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_CLASS_MONITOR AS M ON S.STUDENT_ID = M.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON M.CLASS_ID = C.CLASS_ID WHERE M.YEAR_STUDY = N'" & yearStudy & "' AND M.CLASS_ID = " & classID & " ", dgDisplay)
            Call SetTitile_tabView()
            Call CountGenderClass_tabView()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click

        If cboYearStudy.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
            cboYearStudy.BackColor = Color.LavenderBlush
            cboYearStudy.Focus()
            Exit Sub
        End If

        If cboYearStudy.Text IsNot "" And cboClass.Text = "" Then
            Call SelectAll_tabView(cboYearStudy.Text)
        Else
            Call SelectWithClass_tabView(cboYearStudy.Text, cboClass.SelectedValue)
        End If
    End Sub
    Private Sub SetTitile_tabView()
        dgDisplay.Columns(0).HeaderText = "ល.រ"
        dgDisplay.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgDisplay.Columns(0).Width = 50


        dgDisplay.Columns(1).HeaderText = "លេខកូដ"
        dgDisplay.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgDisplay.Columns(1).Width = 80


        dgDisplay.Columns(2).HeaderText = "ឈ្មោះសិស្ស"
        dgDisplay.Columns(2).Width = 180

        dgDisplay.Columns(3).HeaderText = "ភេទ"
        dgDisplay.Columns(3).Width = 60

        dgDisplay.Columns(4).HeaderText = "ឆ្នាំសិក្សា"
        dgDisplay.Columns(4).Width = 100

        dgDisplay.Columns(5).Visible = False  ' CLASS_ID

        dgDisplay.Columns(6).HeaderText = "ថ្នាក់"
        dgDisplay.Columns(6).Width = 50
        dgDisplay.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        dgDisplay.Columns(7).HeaderText = "ប្រធានទី"
        dgDisplay.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgDisplay.Columns(7).Width = 70


        dgDisplay.Columns(8).HeaderText = "ផ្សេងៗ"
        dgDisplay.Columns(8).Width = 600
    End Sub

    Private Sub cboYearStudy_TextChanged(sender As Object, e As EventArgs) Handles cboYearStudy.TextChanged
        cboYearStudy.BackColor = Color.White
    End Sub

    Private Sub cboYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboYearStudy, "YEAR_STUDY_KH", "YEAR_ID")

    End Sub

    Private Sub cboClass_DropDown(sender As Object, e As EventArgs) Handles cboClass.DropDown
        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboClass, "CLASS_LETTER", "CLASS_ID")

    End Sub

    Private Sub dg_selected_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSelected.CellDoubleClick
        btn_moveBack_Click(sender, e)
    End Sub

    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles lblSave.MouseHover
        t.Hover(lblSave)
    End Sub

    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles lblSave.MouseLeave
        t.Leave(lblSave)
    End Sub

    Private Sub lbl_new_MouseHover(sender As Object, e As EventArgs) Handles lblNew.MouseHover
        t.Hover(lblNew)
    End Sub

    Private Sub lbl_new_MouseLeave(sender As Object, e As EventArgs) Handles lblNew.MouseLeave
        t.Leave(lblNew)
    End Sub

    Private Sub lblUpdate_MouseHover(sender As Object, e As EventArgs) Handles lblUpdate.MouseHover
        t.Hover(lblUpdate)
    End Sub

    Private Sub lblUpdate_MouseLeave(sender As Object, e As EventArgs) Handles lblUpdate.MouseLeave
        t.Leave(lblUpdate)
    End Sub



    Private Sub AddStudentToSearchGrid(ByVal yearStudy As String, ByVal classID As String)
        Try
            cmd = New SqlCommand("SELECT  ROW_NUMBER() OVER(ORDER BY S.SNAME_KH ASC) AS 'rOW_NUM',   S.STUDENT_ID, S.SNAME_KH, S.GENDER, I.YEAR_STUDY, I.CLASS_ID, C.CLASS_LETTER FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_STUDY_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON I.CLASS_ID = C.CLASS_ID WHERE I.YEAR_STUDY = N'" & yearStudy & "' AND I.CLASS_ID = " & classID & " AND S.STUDENT_STATUS_ID IN (1,5)", conn)

            da = New SqlDataAdapter(cmd)
            GlobalVariable.dt = New DataTable
            da.Fill(GlobalVariable.dt)

            dgSearch.Rows.Clear()
            dgSelected.Rows.Clear()
            For i As Integer = 0 To GlobalVariable.dt.Rows.Count - 1
                dgSearch.Rows.Add(1, GlobalVariable.dt.Rows(i)(1).ToString(), GlobalVariable.dt.Rows(i)(2).ToString(), GlobalVariable.dt.Rows(i)(3).ToString(), GlobalVariable.dt.Rows(i)(4).ToString(), GlobalVariable.dt.Rows(i)(5).ToString(), GlobalVariable.dt.Rows(i)(6).ToString())
            Next

            dgSearch.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgSearch.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgSearch.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgSearch.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgSearch.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            If dgSelected.Rows.Count > 0 Then
                For i As Integer = 0 To dgSelected.RowCount - 1
                    Try
                        If (obj.CheckExisted("SELECT RECORD_ID FROM dbo.TBS_STUDENT_CLASS_MONITOR WHERE RECORD_ID = " & dgSelected.Rows(i).Cells(8).Value & "", "TBS_STUDENT_CLASS_MONITOR" & "")) = True Then
                            Call obj.Update_1("UPDATE dbo.TBS_STUDENT_CLASS_MONITOR SET CLASS_MONITOR_NUM = " & dgSelected.Rows(i).Cells(5).Value & " WHERE RECORD_ID = " & dgSelected.Rows(i).Cells(8).Value & "")
                        Else
                            obj.Insert_1("INSERT INTO dbo.TBS_STUDENT_CLASS_MONITOR(STUDENT_ID,YEAR_STUDY,CLASS_ID,CLASS_MONITOR_NUM, REMARK,DATE_NOTE)VALUES(" & dgSelected.Rows(i).Cells(1).Value & ",N'" & dgSelected.Rows(i).Cells(6).Value & "'," & dgSelected.Rows(i).Cells(7).Value & "," & dgSelected.Rows(i).Cells(5).Value & ",'',GETDATE())")
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Next
                obj.ShowMsg("ព័ត៌មានត្រូវបានកែប្រែ", FrmMessageSuccess, "")

            Else
                obj.ShowMsg("សូមស្វែងរកព័ត៌មានជាមុន", FrmWarning, "")
            End If
        End If
    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        If cboYearStudy.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
            cboYearStudy.BackColor = Color.LavenderBlush
            cboYearStudy.Focus()
            Exit Sub
        End If

        Call SelectAll_tabView(cboYearStudy.Text)
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        lbl_search_Click_1(sender, e)
    End Sub

    Private Sub txtAdSearch_TextChanged(sender As Object, e As EventArgs) Handles txtAdSearch.TextChanged
        Try
            obj.BindDataGridView("SELECT ROW_NUMBER() OVER(ORDER BY M.CLASS_ID,M.CLASS_MONITOR_NUM ASC) AS 'ROW_NUMBER',S.STUDENT_ID, S.SNAME_KH, S.GENDER, M.YEAR_STUDY,M.CLASS_ID , C.CLASS_LETTER, M.CLASS_MONITOR_NUM, M.REMARK FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_CLASS_MONITOR AS M ON S.STUDENT_ID = M.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON M.CLASS_ID = C.CLASS_ID WHERE S.SNAME_KH+M.YEAR_STUDY+S.GENDER   LIKE N'%" & txtAdSearch.Text & "%'", dgDisplay)
            Call SetTitile_tabView()
            Call CountGenderYearStudy_tabView()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.Hover(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)
    End Sub

    Private Sub lblPrint_MouseHover(sender As Object, e As EventArgs) Handles lblPrint.MouseHover
        t.Hover(lblPrint)
    End Sub

    Private Sub lblPrint_MouseLeave(sender As Object, e As EventArgs) Handles lblPrint.MouseLeave
        t.Leave(lblPrint)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        frm_class.ShowDialog()
    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        frm_class.ShowDialog()
    End Sub

    Private Sub lblPrint_Click(sender As Object, e As EventArgs) Handles lblPrint.Click
        If cboYearStudy.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Windows Ding.wav")
            cboYearStudy.BackColor = Color.LavenderBlush
            cboYearStudy.Focus()
            Exit Sub
        End If

        Try
            FrmReportClassMonitor.SetYearStudy(cboYearStudy.Text)
            FrmReportClassMonitor.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub picPrint_Click(sender As Object, e As EventArgs) Handles picPrint.Click
        lblPrint_Click(sender, e)
    End Sub

    Private Sub frm_class_monitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtAdSearch.SetWaterMark("បញ្ចូលព័ត៌មានដែលចង់ស្វែងរក...")
    End Sub
End Class
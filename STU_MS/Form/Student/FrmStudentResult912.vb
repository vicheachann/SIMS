Public Class FrmStudentResult912
    Dim obj As New Method
    Dim t As New Theme
    Dim sqlSelectData As String = "SELECT SR.RESULT_ID,ROW_NUMBER() OVER(ORDER BY SR.YEAR_STUDY DESC) AS 'ROW_NUMBER', SR.YEAR_STUDY, SR.GRADE_12_NUM_ALL, SR.GRADE_12_NUM_GIRL, SR.GRADE_12_NUM_GIRL_PERCENT, SR.GRADE_12_PASSED_NUM, SR.GRADE_12_PASSED_PERCENT, SR.GRADE_12_PASSED_GIRL, SR.GRADE_12_PASSED_GIRL_PERCENT, SR.GRADE_9_NUM_ALL, SR.GRADE_9_NUM_GIRL, SR.GRADE_9_NUM_GIRL_PERCENT, SR.GRADE_9_PASSED_NUM,SR.GRADE_9_PASSED_PERCENT, SR.GRADE_9_PASSED_GIRL, SR.GRADE_9_PASSED_GIRL_PERCENT, SR.BY_STAFF, T.T_NAME_KH FROM dbo.TBS_STUDENT_RESULT_9_12 AS SR INNER JOIN dbo.TBL_TEACHER AS T ON SR.BY_STAFF = T.TEACHER_ID  "



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        Try
            If cboYearStudy.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលឆ្នាំសិក្សា", FrmWarning, "")
                cboYearStudy.Focus()
                cboYearStudy.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If cboByStaff.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលអ្នកបញ្ជូល", FrmWarning, "")
                cboByStaff.Focus()
                cboByStaff.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt12NumAll.Text = "" Or txt12NumAll.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលសិស្សសរុប", FrmWarning, "")
                txt12NumAll.Focus()
                txt12NumAll.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt12NumGirl.Text = "" Or txt12NumGirl.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សស្រីសរុប", FrmWarning, "")
                txt12NumGirl.Focus()
                txt12NumGirl.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt12PassedNum.Text = "" Or txt12PassedNum.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនអ្នកជាប់សរុប", FrmWarning, "")
                txt12PassedNum.Focus()
                txt12PassedNum.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt12PassedGirl.Text = "" Or txt12PassedGirl.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សជាប់ស្រី", FrmWarning, "")
                txt12PassedGirl.Focus()
                txt12PassedGirl.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt9NumAll.Text = "" Or txt9NumAll.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្ស", FrmWarning, "")
                txt9NumAll.Focus()
                txt9NumAll.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt9NumGirl.Text = "" Or txt9NumGirl.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សស្រី", FrmWarning, "")
                txt9NumGirl.Focus()
                txt9NumGirl.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt9PassedNum.Text = "" Or txt9PassedNum.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សជាប់", FrmWarning, "")
                txt9PassedNum.Focus()
                txt9PassedNum.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txt9PassedGirl.Text = "" Or txt9PassedGirl.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សជាប់ស្រី", FrmWarning, "")
                txt9PassedGirl.Focus()
                txt9PassedGirl.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            obj.Insert("INSERT INTO dbo.TBS_STUDENT_RESULT_9_12(DATE_NOTE,YEAR_STUDY,GRADE_12_NUM_ALL,GRADE_12_NUM_GIRL,GRADE_12_PASSED_NUM,GRADE_12_PASSED_GIRL,GRADE_9_NUM_ALL,GRADE_9_NUM_GIRL,GRADE_9_PASSED_NUM,GRADE_9_PASSED_GIRL,BY_STAFF)VALUES(GETDATE (),N'" & cboYearStudy.Text & "'," & txt12NumAll.Text & "," & txt12NumGirl.Text & "," & txt12PassedNum.Text & "," & txt12PassedGirl.Text & "," & txt9NumAll.Text & "," & txt9NumGirl.Text & "," & txt9PassedNum.Text & "," & txt9PassedGirl.Text & "," & cboByStaff.SelectedValue & ")")

            Call Selection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboByStaff_DropDown(sender As Object, e As EventArgs) Handles cboByStaff.DropDown
        obj.BindComboBox("SELECT  TEACHER_ID,T_NAME_KH FROM dbo.TBL_TEACHER WHERE TEACHER_STATUS_ID  IN(1,6)", cboByStaff, "T_NAME_KH", "TEACHER_ID")

    End Sub

    Private Sub cboYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub

    Private Sub Selection()
        Try
            obj.BindDataGridView(sqlSelectData, dg)
            SetColHeader()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetColHeader()

        Try
            dg.Columns(0).Visible = False 'RECORD_ID

            dg.Columns(1).HeaderText = "លរ"
            dg.Columns(1).Width = 40
            dg.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dg.Columns(2).HeaderText = "ឆ្នាំសិក្សា"
            dg.Columns(2).Width = 90

            dg.Columns(3).HeaderText = "ទុតិយភូមិ(សរុប)"
            dg.Columns(3).Width = 120

            dg.Columns(4).HeaderText = "ស្រី"
            dg.Columns(4).Width = 100

            dg.Columns(5).HeaderText = "ភាគរយ"
            dg.Columns(5).Width = 100

            dg.Columns(6).HeaderText = "ជាប់សរុប"
            dg.Columns(6).Width = 100

            dg.Columns(7).HeaderText = "ភាគរយ"
            dg.Columns(7).Width = 100

            dg.Columns(8).HeaderText = "ស្រី"
            dg.Columns(8).Width = 100

            dg.Columns(9).HeaderText = "ភាគរយ"
            dg.Columns(9).Width = 100

            dg.Columns(10).HeaderText = "បឋមភូមិ(សរុប)"
            dg.Columns(10).Width = 120

            dg.Columns(11).HeaderText = "ស្រី"
            dg.Columns(11).Width = 100

            dg.Columns(12).HeaderText = "ភាគរយ"
            dg.Columns(12).Width = 100

            dg.Columns(13).HeaderText = "ជាប់សរុប"
            dg.Columns(13).Width = 100

            dg.Columns(14).HeaderText = "ភាគរយ"
            dg.Columns(14).Width = 100

            dg.Columns(15).HeaderText = "ស្រី"
            dg.Columns(15).Width = 100

            dg.Columns(16).HeaderText = "ភាគរយ"
            dg.Columns(16).Width = 100

            dg.Columns(17).Visible = False 'ByStaffID

            dg.Columns(18).Visible = False 'ByStaffName

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FrmStudentResult912_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Selection()

    End Sub

    Private Sub txt12NumAll_TextChanged(sender As Object, e As EventArgs) Handles txt12NumAll.TextChanged
        txt12NumAll.BackColor = Color.White

    End Sub

    Private Sub txt12NumGirl_TextChanged(sender As Object, e As EventArgs) Handles txt12NumGirl.TextChanged
        txt12NumGirl.BackColor = Color.White
    End Sub

    Private Sub txt12numGirlPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt12numGirlPercent.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt12PassedPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt12PassedPercent.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPassedGirlPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt12PassedGirlPercent.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt9NumGirlPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt9NumGirlPercent.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt9PassedPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt9PassedPercent.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt9PassedGirlPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt9PassedGirlPercent.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt12NumAll_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt12NumAll.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt12NumGirl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt12NumGirl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt12PassedNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt12PassedNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub txt12PassedGirl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt12PassedGirl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt9NumAll_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt9NumAll.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt9NumGirl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt9NumGirl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt9Passed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt9PassedNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt9PassedGirl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt9PassedGirl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt12PassedNum_TextChanged(sender As Object, e As EventArgs) Handles txt12PassedNum.TextChanged
        txt12PassedNum.BackColor = Color.White
    End Sub

    Private Sub txt12PassedGirl_TextChanged(sender As Object, e As EventArgs) Handles txt12PassedGirl.TextChanged
        txt12PassedGirl.BackColor = Color.White
    End Sub

    Private Sub txt9NumAll_TextChanged(sender As Object, e As EventArgs) Handles txt9NumAll.TextChanged
        txt9NumAll.BackColor = Color.White

    End Sub

    Private Sub txt9NumGirl_TextChanged(sender As Object, e As EventArgs) Handles txt9NumGirl.TextChanged
        txt9NumGirl.BackColor = Color.White

    End Sub

    Private Sub txt9Passed_TextChanged(sender As Object, e As EventArgs) Handles txt9PassedNum.TextChanged
        txt9PassedNum.BackColor = Color.White

    End Sub

    Private Sub txt9PassedGirl_TextChanged(sender As Object, e As EventArgs) Handles txt9PassedGirl.TextChanged
        txt9PassedGirl.BackColor = Color.White

    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Clear()
        cboYearStudy.Focus()
        lblUpdate.Enabled = False
        lblDelete.Enabled = False
        lblSave.Enabled = True
        cboByStaff.Enabled = True
    End Sub

    Private Sub Clear()
        cboByStaff.Text = ""
        cboYearStudy.Text = ""

        txt12NumAll.Text = "0"
        txt12NumGirl.Text = "0"
        txt12PassedNum.Text = "0"
        txt12PassedGirl.Text = "0"

        txt9NumAll.Text = "0"
        txt9NumGirl.Text = "0"
        txt9PassedNum.Text = "0"
        txt9PassedGirl.Text = "0"

        txt12numGirlPercent.Text = "0"
        txt12PassedPercent.Text = "0"
        txt12PassedGirlPercent.Text = "0"

        txt9NumGirlPercent.Text = "0"
        txt9PassedPercent.Text = "0"
        txt9PassedGirlPercent.Text = "0"
    End Sub

    Private Sub dg_SelectionChanged(sender As Object, e As EventArgs) Handles dg.SelectionChanged
        Try
            lblSave.Enabled = False
            lblUpdate.Enabled = True
            lblDelete.Enabled = True
            cboByStaff.Enabled = False

            If (dg.Rows.Count > 0) Then
                Call Clear()

                cboYearStudy.Text = obj.IfDbNull(dg.SelectedCells(2).Value)
                cboByStaff.Text = obj.IfDbNull(dg.SelectedCells(18).Value)

                txt12NumAll.Text = obj.IfDbNull(dg.SelectedCells(3).Value)
                txt12NumGirl.Text = obj.IfDbNull(dg.SelectedCells(4).Value)
                txt12numGirlPercent.Text = obj.IfDbNull(dg.SelectedCells(5).Value)
                txt12PassedNum.Text = obj.IfDbNull(dg.SelectedCells(6).Value)
                txt12PassedPercent.Text = obj.IfDbNull(dg.SelectedCells(7).Value)
                txt12PassedGirl.Text = obj.IfDbNull(dg.SelectedCells(8).Value)
                txt12PassedGirlPercent.Text = obj.IfDbNull(dg.SelectedCells(9).Value)

                txt9NumAll.Text = obj.IfDbNull(dg.SelectedCells(10).Value)
                txt9NumGirl.Text = obj.IfDbNull(dg.SelectedCells(11).Value)
                txt9NumGirlPercent.Text = obj.IfDbNull(dg.SelectedCells(12).Value)
                txt9PassedNum.Text = obj.IfDbNull(dg.SelectedCells(13).Value)
                txt9PassedPercent.Text = obj.IfDbNull(dg.SelectedCells(14).Value)
                txt9PassedGirl.Text = obj.IfDbNull(dg.SelectedCells(15).Value)
                txt9PassedGirlPercent.Text = obj.IfDbNull(dg.SelectedCells(16).Value)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែលឬទេ ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            If cboYearStudy.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលឆ្នាំសិក្សា", FrmWarning, "")
                cboYearStudy.Focus()
                cboYearStudy.BackColor = Color.LavenderBlush
                Exit Sub
            End If



            If txt12NumAll.Text = "" Or txt12NumAll.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលសិស្សសរុប", FrmWarning, "")
                txt12NumAll.Focus()
                txt12NumAll.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt12NumGirl.Text = "" Or txt12NumGirl.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សស្រីសរុប", FrmWarning, "")
                txt12NumGirl.Focus()
                txt12NumGirl.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt12PassedNum.Text = "" Or txt12PassedNum.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនអ្នកជាប់សរុប", FrmWarning, "")
                txt12PassedNum.Focus()
                txt12PassedNum.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt12PassedGirl.Text = "" Or txt12PassedGirl.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សជាប់ស្រី", FrmWarning, "")
                txt12PassedGirl.Focus()
                txt12PassedGirl.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt9NumAll.Text = "" Or txt9NumAll.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្ស", FrmWarning, "")
                txt9NumAll.Focus()
                txt9NumAll.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt9NumGirl.Text = "" Or txt9NumGirl.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សស្រី", FrmWarning, "")
                txt9NumGirl.Focus()
                txt9NumGirl.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If txt9PassedNum.Text = "" Or txt9PassedNum.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សជាប់", FrmWarning, "")
                txt9PassedNum.Focus()
                txt9PassedNum.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txt9PassedGirl.Text = "" Or txt9PassedGirl.Text = "0" Then
                obj.ShowMsg("សូមបញ្ចូលចំនួនសិស្សជាប់ស្រី", FrmWarning, "")
                txt9PassedGirl.Focus()
                txt9PassedGirl.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            Try
                obj.Update("UPDATE dbo.TBS_STUDENT_RESULT_9_12 SET YEAR_STUDY=N'" & cboYearStudy.Text & "',GRADE_12_NUM_ALL = " & txt12NumAll.Text & ",GRADE_12_NUM_GIRL = " & txt12NumGirl.Text & ",GRADE_12_PASSED_NUM=" & txt12PassedNum.Text & ",GRADE_12_PASSED_GIRL = " & txt12PassedGirl.Text & ",GRADE_9_NUM_ALL=" & txt9NumAll.Text & ",GRADE_9_NUM_GIRL=" & txt9NumGirl.Text & ",GRADE_9_PASSED_NUM=" & txt9PassedNum.Text & ",GRADE_9_PASSED_GIRL =" & txt9PassedGirl.Text & " WHERE RESULT_ID = " & dg.SelectedCells(0).Value & " ")
                Call Selection()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then
                obj.Delete("DELETE FROM dbo.TBS_STUDENT_RESULT_9_12 WHERE RESULT_ID = " & dg.SelectedCells(0).Value & "")
                Call Selection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        Call Selection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            obj.BindDataGridView(sqlSelectData + " WHERE YEAR_STUDY + T.T_NAME_KH LIKE N'%" & txtSearch.Text & "%'", dg)
            SetColHeader()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblNew_MouseHover(sender As Object, e As EventArgs) Handles lblNew.MouseHover
        t.Hover(lblNew)
    End Sub

    Private Sub lblNew_MouseLeave(sender As Object, e As EventArgs) Handles lblNew.MouseLeave
        t.Leave(lblNew)
    End Sub

    Private Sub lblSave_MouseHover(sender As Object, e As EventArgs) Handles lblSave.MouseHover
        t.Hover(lblSave)
    End Sub

    Private Sub lblSave_MouseLeave(sender As Object, e As EventArgs) Handles lblSave.MouseLeave
        t.Leave(lblSave)

    End Sub

    Private Sub lblUpdate_MouseHover(sender As Object, e As EventArgs) Handles lblUpdate.MouseHover
        t.Hover(lblUpdate)
    End Sub

    Private Sub lblUpdate_MouseLeave(sender As Object, e As EventArgs) Handles lblUpdate.MouseLeave
        t.Leave(lblUpdate)
    End Sub

    Private Sub lblDelete_MouseHover(sender As Object, e As EventArgs) Handles lblDelete.MouseHover
        t.Hover(lblDelete)
    End Sub

    Private Sub lblDelete_MouseLeave(sender As Object, e As EventArgs) Handles lblDelete.MouseLeave
        t.Leave(lblDelete)

    End Sub

    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.Hover(lblDisplayAll)

    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)

    End Sub

    Private Sub lblYearStudy_Click(sender As Object, e As EventArgs) Handles lblYearStudy.Click
        frm_year_study.ShowDialog()
    End Sub

    Private Sub lblPrintReport_MouseHover(sender As Object, e As EventArgs) Handles lblPrintReport.MouseHover
        t.Hover(lblPrintReport)
    End Sub

    Private Sub lblPrintReport_MouseLeave(sender As Object, e As EventArgs) Handles lblPrintReport.MouseLeave
        t.Leave(lblPrintReport)
    End Sub

    Private Sub lblPrintReport_Click(sender As Object, e As EventArgs) Handles lblPrintReport.Click
        Try
            FrmReportStuResult912.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Calculate_12_GirlPercent()
        Try
            txt12numGirlPercent.Text = (Convert.ToDecimal(txt12NumGirl.Text) / Convert.ToDecimal(txt12NumAll.Text) * 100).ToString("N2")
        Catch ex As Exception
            txt12numGirlPercent.Text = "0"
        End Try
    End Sub
    Private Sub Calculate_9_GirlPercent()
        Try
            txt9NumGirlPercent.Text = (Convert.ToDecimal(txt9NumGirl.Text) / Convert.ToDecimal(txt9NumAll.Text) * 100).ToString("N2")
        Catch ex As Exception
            txt9NumGirlPercent.Text = "0"
        End Try
    End Sub


    Private Sub Calculate_12_PassedGirlPercent()
        Try
            txt12PassedGirlPercent.Text = (Convert.ToDecimal(txt12PassedGirl.Text) / Convert.ToDecimal(txt12PassedNum.Text) * 100).ToString("N2")
        Catch ex As Exception
            txt12PassedGirlPercent.Text = "0"
        End Try
    End Sub

    Private Sub Calculate_9_PassedGirlPercent()
        Try
            txt9PassedGirlPercent.Text = (Convert.ToDecimal(txt9PassedGirl.Text) / Convert.ToDecimal(txt9PassedNum.Text) * 100).ToString("N2")
        Catch ex As Exception
            txt9PassedGirlPercent.Text = "0"
        End Try
    End Sub
    Private Sub Calculate_12_PassedPercent()
        Try
            txt12PassedPercent.Text = (Convert.ToDecimal(txt12PassedNum.Text) / Convert.ToDecimal(txt12NumAll.Text) * 100).ToString("N2")
        Catch ex As Exception
            txt12PassedPercent.Text = "0"
        End Try
    End Sub

    Private Sub Calculate_9_PassedPercent()
        Try
            txt9PassedPercent.Text = (Convert.ToDecimal(txt9PassedNum.Text) / Convert.ToDecimal(txt9NumAll.Text) * 100).ToString("N2")
        Catch ex As Exception
            txt9PassedPercent.Text = "0"
        End Try
    End Sub

    Private Sub txt12NumGirl_KeyUp(sender As Object, e As KeyEventArgs) Handles txt12NumGirl.KeyUp
        Calculate_12_GirlPercent()
    End Sub

    Private Sub txt12NumAll_KeyUp(sender As Object, e As KeyEventArgs) Handles txt12NumAll.KeyUp
        Calculate_12_GirlPercent()
        Calculate_12_PassedPercent()
        Calculate_12_PassedGirlPercent()
    End Sub

    Private Sub txt12PassedNum_KeyUp(sender As Object, e As KeyEventArgs) Handles txt12PassedNum.KeyUp
        Calculate_12_PassedPercent()
    End Sub

    Private Sub txt12PassedGirl_KeyUp(sender As Object, e As KeyEventArgs) Handles txt12PassedGirl.KeyUp
        Calculate_12_PassedGirlPercent()
    End Sub

    Private Sub txt9NumGirl_KeyUp(sender As Object, e As KeyEventArgs) Handles txt9NumGirl.KeyUp
        Call Calculate_9_GirlPercent()
    End Sub

    Private Sub txt9NumAll_KeyUp(sender As Object, e As KeyEventArgs) Handles txt9NumAll.KeyUp
        Call Calculate_9_GirlPercent()
        Call Calculate_9_PassedPercent()
        Call Calculate_9_PassedGirlPercent()
    End Sub

    Private Sub txt9PassedNum_KeyUp(sender As Object, e As KeyEventArgs) Handles txt9PassedNum.KeyUp
        Call Calculate_9_PassedPercent()
    End Sub

    Private Sub txt9PassedGirl_KeyUp(sender As Object, e As KeyEventArgs) Handles txt9PassedGirl.KeyUp
        Call Calculate_9_PassedGirlPercent()
    End Sub
End Class
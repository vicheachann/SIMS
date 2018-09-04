Imports System.Data.SqlClient
Public Class FrmStuCard
    Dim obj As New Method
    Dim t As New Theme
    Dim print As New FrmPrintStudentCard
    Dim databaseData As Boolean = False
    Dim selectStudentSQL As String = "SELECT ROW_NUMBER() OVER(ORDER BY C.CLASS_NUMBER,C.CLASS_LETTER ASC) AS 'ROW_NUMBER',S.STUDENT_ID,'111'AS'STUDENT_ID_IN_LIST',S.STUDENT_ID_SCHOOL,S.STUDENT_CODE, S.SNAME_KH,S.SNAME_LATIN, S.GENDER,dbo.F_DATE_KHMER(S.DOB) AS 'DOB_KHMER',(S.POB_PROVINCE+' ('+S.POB_VILLAGE+')')AS 'POB',I.YEAR_STUDY,I.CLASS_ID,C.CLASS_LETTER,S.FATHER_NAME ,S.MOTHER_NAME,C.CLASS_NUMBER,S.STUDENT_PHOTO,(SELECT SCHOOL_NAME_KH  FROM dbo.TBL_SCHOOL_INFO)AS 'SCHOOL_NAME',(SELECT PROVINCE FROM dbo.TBL_SCHOOL_INFO)AS 'PROVINCE_NAME' ,S.DOB FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_STUDY_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON I.CLASS_ID = C.CLASS_ID "

    'Declare instance of Crystal Report rpt
    Dim StudentCard_1 As New StudentCard_1
    Dim StudentCard_2 As New StudentCard_2
    Dim StudentCard_3 As New StudentCard_3
    Dim StudentCard_4 As New StudentCard_4
    Dim StudentCard_5 As New StudentCard_5
    Dim StudentCard_6 As New StudentCard_6
    Dim StudentCard_7 As New StudentCard_7
    Dim StudentCard_8 As New StudentCard

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btnCloase.Click
        Close()
    End Sub

    Private Sub GroupPanel1_Click(sender As Object, e As EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub cboYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
        cboYearStudy.BackColor = Color.White
    End Sub

    Private Sub cboClass_DropDown(sender As Object, e As EventArgs) Handles cboClass.DropDown
        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboClass, "CLASS_LETTER", "CLASS_ID")
        cboClass.BackColor = Color.White
    End Sub

    Private Sub SelectStudentByYear(ByVal yearStudy As String)
        Try
            cmd = New SqlCommand(selectStudentSQL + " WHERE YEAR_STUDY = N'" & yearStudy & "' ", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If (dt.Rows.Count > 0) Then
                dgSearch.Rows.Clear()
                For i As Integer = 0 To dt.Rows.Count - 1
                    dgSearch.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString(), dt.Rows(i)(6).ToString(), dt.Rows(i)(7).ToString(), dt.Rows(i)(8).ToString(), dt.Rows(i)(9).ToString(), dt.Rows(i)(10).ToString(), dt.Rows(i)(11).ToString(), dt.Rows(i)(12).ToString(), dt.Rows(i)(13).ToString(), dt.Rows(i)(14).ToString(), dt.Rows(i)(15).ToString(), dt.Rows(i)(16), dt.Rows(i)(17), dt.Rows(i)(18), dt.Rows(i)(19))
                Next

                Call CountSearchResult()
                dgSearch.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgSearch.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgSearch.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgSearch.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                obj.ShowMsg("មិនមានទិន្នន័យ", FrmWarning, "")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SelectStudentByYearAndClass(ByVal yearStudy As String, ByVal classID As Integer)
        Try
            cmd = New SqlCommand("SELECT ROW_NUMBER() OVER(ORDER BY C.CLASS_NUMBER,C.CLASS_LETTER ASC) AS 'ROW_NUMBER',S.STUDENT_ID,'111'AS'ORDER_ID',S.STUDENT_ID_SCHOOL,S.STUDENT_CODE, S.SNAME_KH,S.SNAME_LATIN, S.GENDER,dbo.F_DATE_KHMER(S.DOB),(S.POB_PROVINCE+' ('+S.POB_VILLAGE+')')AS 'POB',I.YEAR_STUDY,I.CLASS_ID,C.CLASS_LETTER,S.FATHER_NAME ,S.MOTHER_NAME,C.CLASS_NUMBER,S.STUDENT_PHOTO,(SELECT SCHOOL_NAME_KH FROM dbo.TBL_SCHOOL_INFO),(SELECT PROVINCE FROM dbo.TBL_SCHOOL_INFO),S.DOB  FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_STUDY_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON I.CLASS_ID = C.CLASS_ID WHERE YEAR_STUDY = N'" & yearStudy & "' AND I.CLASS_ID = " & classID & " ", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If (dt.Rows.Count > 0) Then
                dgSearch.Rows.Clear()
                For i As Integer = 0 To dt.Rows.Count - 1
                    dgSearch.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString(), dt.Rows(i)(6).ToString(), dt.Rows(i)(7).ToString(), dt.Rows(i)(8).ToString(), dt.Rows(i)(9).ToString(), dt.Rows(i)(10).ToString(), dt.Rows(i)(11).ToString(), dt.Rows(i)(12).ToString(), dt.Rows(i)(13).ToString(), dt.Rows(i)(14).ToString(), dt.Rows(i)(15).ToString(), dt.Rows(i)(16), dt.Rows(i)(17), dt.Rows(i)(18), dt.Rows(i)(19))
                Next
                Call CountSearchResult()
                dgSearch.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgSearch.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgSearch.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgSearch.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Else
                obj.ShowMsg("មិនមានទិន្នន័យ", FrmWarning, "")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        Try
            If cboYearStudy.Text = "" Then
                obj.ShowMsg("សូមជ្រើសរើសឆ្នាំសិក្សាជាមុន", FrmWarning, "Windows Ding.wav")
                cboYearStudy.BackColor = Color.LavenderBlush
                cboYearStudy.Focus()
                Exit Sub
            End If

            If (cboYearStudy.Text IsNot "" And cboOrdinalNum.Text = "" And cboClass.Text = "") Then
                Call SelectStudentByYear(cboYearStudy.Text)

            ElseIf ((cboYearStudy.Text IsNot "" And cboOrdinalNum.Text = "" And cboClass.Text IsNot "")) Then

                Call SelectStudentByYearAndClass(cboYearStudy.Text, cboClass.SelectedValue)
            Else
                MessageBox.Show("Search by Ordinal number...")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgSelected_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgSelected.RowPrePaint
        Try
            If e.RowIndex >= 0 Then
                Me.dgSelected.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                Call CountSelected()
                dgSelected.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgSelected.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgSelected.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSearch.CellDoubleClick
        Try
            If dgSelected.RowCount > 0 Then
                For i As Integer = 0 To dgSelected.RowCount - 1
                    If (dgSearch.SelectedCells(1).Value.ToString = dgSelected.Rows(i).Cells(1).Value.ToString) Then
                        obj.ShowMsg("សិស្សបានជ្រើសរើសរួចរាល់", FrmWarning, "")
                        Exit Sub
                    End If
                Next
            End If

            If (dgSearch.Rows.Count > 0) Then
                dgSelected.Rows.Add("", dgSearch.SelectedCells(1).Value, dgSearch.SelectedCells(2).Value, dgSearch.SelectedCells(3).Value, dgSearch.SelectedCells(4).Value, dgSearch.SelectedCells(5).Value, dgSearch.SelectedCells(6).Value, dgSearch.SelectedCells(7).Value, dgSearch.SelectedCells(8).Value, dgSearch.SelectedCells(9).Value, dgSearch.SelectedCells(10).Value, dgSearch.SelectedCells(11).Value, dgSearch.SelectedCells(12).Value, dgSearch.SelectedCells(13).Value, dgSearch.SelectedCells(14).Value, dgSearch.SelectedCells(15).Value, dgSearch.SelectedCells(16).Value, dgSearch.SelectedCells(17).Value, dgSearch.SelectedCells(18).Value, dgSearch.SelectedCells(19).Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            If dgSelected.SelectedRows.Count > 0 Then
                Call obj.ShowMsg("តើអ្នកចង់លុបទិន្នន័យនេះដែលឬទេ?", FrmMessageQuestion, POP_SOUND)
                If USER_CLICK_OK = True Then

                    If (dgSelected.SelectedCells(20).Value = "") Then
                        dgSelected.Rows.Remove(dgSelected.SelectedRows(0))
                    Else
                        obj.Delete("DELETE FROM dbo.TBS_STUDENT_PRINT_CARD WHERE RECORD_ID =" & dgSelected.SelectedCells(20).Value & " AND STUDENT_ID = " & dgSelected.SelectedCells(1).Value & "")
                        Call SelectStuCard()
                    End If
                End If
            Else
                Call obj.ShowMsg("មិនមានទិន្នន័យសម្រាប់លុប", FrmWarning, ERROR_SOUND)
            End If
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("មិនអាចលុបទិន្នន័យនេះបាន", FrmMessageError, ERROR_SOUND)
        End Try
    End Sub

    Private Sub CountSelected()
        Try
            lblCountSelected.Text = dgSelected.RowCount.ToString
        Catch ex As Exception
            lblCountSelected.Text = "0"
        End Try
    End Sub
    Private Sub CountSearchResult()
        Try
            lblCountSearchResult.Text = dgSearch.RowCount.ToString
        Catch ex As Exception
            lblCountSearchResult.Text = "0"
        End Try
    End Sub

    Private Sub lblPrintByClass_Click(sender As Object, e As EventArgs) Handles lblPrintByClass.Click

        Try
            If (cboClass.Text = "") Then
                obj.ShowMsg("សូមជ្រើសរើសថ្នាក់ជាមុន", FrmWarning, "")
                Exit Sub
            End If
            obj.OpenConnection()
            cmd = New SqlCommand("SELECT ROW_NUMBER() OVER(ORDER BY C.CLASS_NUMBER,C.CLASS_LETTER ASC) AS 'ROW_NUMBER',S.STUDENT_ID,'111'AS'ORDER_ID',S.STUDENT_ID_SCHOOL,S.STUDENT_CODE, S.SNAME_KH,S.SNAME_LATIN, S.GENDER,dbo.F_DATE_KHMER(S.DOB),(S.POB_PROVINCE+' ('+S.POB_VILLAGE+')')AS 'POB',I.YEAR_STUDY,I.CLASS_ID,C.CLASS_LETTER,S.FATHER_NAME ,S.MOTHER_NAME,C.CLASS_NUMBER,S.STUDENT_PHOTO,(SELECT SCHOOL_NAME_KH FROM dbo.TBL_SCHOOL_INFO),(SELECT PROVINCE FROM dbo.TBL_SCHOOL_INFO)  FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_STUDY_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON I.CLASS_ID = C.CLASS_ID WHERE YEAR_STUDY = N'" & cboYearStudy.Text & "' AND I.CLASS_ID = " & cboClass.SelectedValue & " ", conn)
            da = New SqlDataAdapter(cmd)
            DataSet1.STU_CARD.Clear()
            da.Fill(DataSet1.STU_CARD)
            If (DataSet1.STU_CARD.Rows.Count <= 0) Then
                obj.ShowMsg("មិនមានទិន្នន័យ", FrmWarning, "")
                Exit Sub
            End If
            Call PrintCardBySelectedCardSize()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub PrintCardBySelectedCardSize()
        Try
            Dim frmPrint As New FrmPrintStudentCard

            Cursor = Cursors.WaitCursor
            Application.DoEvents()

            If (cboCardType.SelectedIndex = 7) Then '8 cards
                StudentCard_8.SetDataSource(DataSet1.Tables("STU_CARD"))
                frmPrint.CrystalReportViewer1.ReportSource = StudentCard_8
                frmPrint.CrystalReportViewer1.RefreshReport()
                frmPrint.ShowDialog()
            ElseIf (cboCardType.SelectedIndex = 6) Then '7 cards
                StudentCard_7.SetDataSource(DataSet1.Tables("STU_CARD"))
                frmPrint.CrystalReportViewer1.ReportSource = StudentCard_7
                frmPrint.CrystalReportViewer1.RefreshReport()
                frmPrint.ShowDialog()
            ElseIf (cboCardType.SelectedIndex = 5) Then '6 cards
                StudentCard_6.SetDataSource(DataSet1.Tables("STU_CARD"))
                frmPrint.CrystalReportViewer1.ReportSource = StudentCard_6
                frmPrint.CrystalReportViewer1.RefreshReport()
                frmPrint.ShowDialog()
            ElseIf (cboCardType.SelectedIndex = 4) Then '5 cards
                StudentCard_5.SetDataSource(DataSet1.Tables("STU_CARD"))
                frmPrint.CrystalReportViewer1.ReportSource = StudentCard_5
                frmPrint.CrystalReportViewer1.RefreshReport()
                frmPrint.ShowDialog()
            ElseIf (cboCardType.SelectedIndex = 3) Then '4 cards
                StudentCard_4.SetDataSource(DataSet1.Tables("STU_CARD"))
                frmPrint.CrystalReportViewer1.ReportSource = StudentCard_4
                frmPrint.CrystalReportViewer1.RefreshReport()
                frmPrint.ShowDialog()
            ElseIf (cboCardType.SelectedIndex = 2) Then '3 cards
                StudentCard_3.SetDataSource(DataSet1.Tables("STU_CARD"))
                frmPrint.CrystalReportViewer1.ReportSource = StudentCard_3
                frmPrint.CrystalReportViewer1.RefreshReport()
                frmPrint.ShowDialog()
            ElseIf (cboCardType.SelectedIndex = 1) Then '2 cards
                StudentCard_2.SetDataSource(DataSet1.Tables("STU_CARD"))
                frmPrint.CrystalReportViewer1.ReportSource = StudentCard_2
                frmPrint.CrystalReportViewer1.RefreshReport()
                frmPrint.ShowDialog()
            ElseIf (cboCardType.SelectedIndex = 0) Then '1 card
                StudentCard_1.SetDataSource(DataSet1.Tables("STU_CARD"))
                frmPrint.CrystalReportViewer1.ReportSource = StudentCard_1
                frmPrint.CrystalReportViewer1.RefreshReport()
                frmPrint.ShowDialog()
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub AddDataToDataSet()
        Try
            DataSet1.STU_CARD.Clear()
            For i As Integer = 0 To dgSelected.RowCount - 1
                DataSet1.STU_CARD.Rows.Add(dgSelected.Rows(i).Cells(3).Value, dgSelected.Rows(i).Cells(10).Value.ToString, dgSelected.Rows(i).Cells(5).Value.ToString, dgSelected.Rows(i).Cells(7).Value.ToString, dgSelected.Rows(i).Cells(8).Value.ToString, dgSelected.Rows(i).Cells(9).Value.ToString, dgSelected.Rows(i).Cells(13).Value.ToString, dgSelected.Rows(i).Cells(14).Value.ToString, dgSelected.Rows(i).Cells(12).Value.ToString, dgSelected.Rows(i).Cells(16).Value, dgSelected.Rows(i).Cells(17).Value, dgSelected.Rows(i).Cells(18).Value)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub lblPrintFromList_Click(sender As Object, e As EventArgs) Handles lblPrintFromList.Click
        Try
            Dim frmPrint As New FrmPrintStudentCard

            If dgSelected.Rows.Count <= 0 Then
                obj.ShowMsg("សូមជ្រើសរើសសិស្សជាមុន", FrmWarning, "")
                Exit Sub
            End If
            Call AddDataToDataSet()
            Cursor = Cursors.WaitCursor
            Application.DoEvents()
            Call PrintCardBySelectedCardSize()
            Cursor = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboCardType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCardType.KeyPress
        e.Handled = True
    End Sub

    Private Sub FrmStuCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If cboCardType.Items.Count > 0 Then
                cboCardType.SelectedIndex = 7
            End If
            txtSearch.SetWaterMark("ស្វែងរក...")
            Call SelectStuCard()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblPrint_MouseHover(sender As Object, e As EventArgs) Handles lblPrintFromList.MouseHover
        t.Hover(lblPrintFromList)
    End Sub
    Private Sub lblPrint_MouseLeave(sender As Object, e As EventArgs) Handles lblPrintFromList.MouseLeave
        t.Leave(lblPrintFromList)
    End Sub

    Private Sub lblDelete_MouseHover(sender As Object, e As EventArgs) Handles lblDelete.MouseHover
        t.Hover(lblDelete)
    End Sub

    Private Sub lblDelete_MouseLeave(sender As Object, e As EventArgs) Handles lblDelete.MouseLeave
        t.Leave(lblDelete)
    End Sub

    Private Sub lblSave_MouseHover(sender As Object, e As EventArgs) Handles lblSave.MouseHover
        t.Hover(lblSave)
    End Sub

    Private Sub lblSave_MouseLeave(sender As Object, e As EventArgs) Handles lblSave.MouseLeave
        t.Leave(lblSave)
    End Sub

    Private Sub lblNew_MouseHover(sender As Object, e As EventArgs) Handles lblNew.MouseHover
        t.Hover(lblNew)
    End Sub

    Private Sub lblNew_MouseLeave(sender As Object, e As EventArgs) Handles lblNew.MouseLeave
        t.Leave(lblNew)
    End Sub

    Private Sub lblDeleteAll_Click(sender As Object, e As EventArgs) Handles lblDeleteAll.Click
        Try
            If dgSelected.SelectedRows.Count > 0 Then
                Call obj.ShowMsg("តើអ្នកចង់លុបទិន្នន័យទាំងអស់ដែលឬទេ?", FrmMessageQuestion, POP_SOUND)
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE  FROM dbo.TBS_STUDENT_PRINT_CARD")
                    Call SelectStuCard()
                    dgSelected.Rows.Clear()
                End If
            Else
                Call obj.ShowMsg("មិនមានទិន្នន័យសម្រាប់លុប", FrmWarning, ERROR_SOUND)
            End If
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("មិនអាចលុបទិន្នន័យនេះបាន", FrmMessageError, ERROR_SOUND)
        End Try
    End Sub

    Private Sub lblSearch_MouseHover(sender As Object, e As EventArgs) Handles lblSearch.MouseHover
        t.Hover(lblSearch)
    End Sub

    Private Sub lblSearch_MouseLeave(sender As Object, e As EventArgs) Handles lblSearch.MouseLeave
        t.Leave(lblSearch)
    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Try
            dgSearch.Rows.Clear()
            dgSelected.Rows.Clear()
            lblCountSelected.Text = "0"
            lblCountSearchResult.Text = "0"
            cboYearStudy.Focus()
            lblSave.Enabled = True
            lblUpdate.Enabled = False


            databaseData = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        Try
            If dgSelected.Rows.Count <= 0 Then
                obj.ShowMsg("សូមជ្រើសរើសសិស្សជាមុន", FrmWarning, "")
                Exit Sub
            End If

            If (cbValidityCard.Checked = False) Then
                obj.ShowMsg("តើអ្នកចង់បញ្ចូលសុពលភាពកាតដែលឬទេ ?", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    cbValidityCard.Checked = True
                    Exit Sub
                End If
            End If

            obj.ShowMsg("តើអ្នកចង់រក្សាទុកព័ត៌មាននេះដែលឬទេ ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then
                For i As Integer = 0 To dgSelected.Rows.Count - 1
                    obj.InsertNoMsg("INSERT INTO dbo.TBS_STUDENT_PRINT_CARD (STUDENT_ID, ORDER_ID, STUDENT_ID_SCHOOL, STUDENT_CODE, SNAME_KH, SNAME_LATIN, GENDER, DOB, POB, YEAR_STUDY, CLASS_ID, CLASS_LETTER, FATHER_NAME, MOTHER_NAME, DATE_START, DATE_END, DATE_PRINT)VALUES(" & dgSelected.Rows(i).Cells(1).Value & "," & dgSelected.Rows(i).Cells(2).Value & ",N'" & dgSelected.Rows(i).Cells(3).Value & "',N'" & dgSelected.Rows(i).Cells(4).Value & "',N'" & dgSelected.Rows(i).Cells(5).Value & "',N'" & dgSelected.Rows(i).Cells(6).Value & "',N'" & dgSelected.Rows(i).Cells(7).Value & "','" & dgSelected.Rows(i).Cells(19).Value & "',N'" & dgSelected.Rows(i).Cells(9).Value & "',N'" & dgSelected.Rows(i).Cells(10).Value & "'," & dgSelected.Rows(i).Cells(11).Value & ",N'" & dgSelected.Rows(i).Cells(12).Value & "',N'" & dgSelected.Rows(i).Cells(13).Value & "',N'" & dgSelected.Rows(i).Cells(14).Value & "','" & dtStartDate.Text & "','" & dtEndDate.Text & "',GETDATE())")
                Next
                obj.ShowMsg("រក្សាទុកបានជោគជ័យ", FrmMessageSuccess, "")
            End If

        Catch ex As Exception
            obj.ShowMsg("មិនអាចរក្សាទុកបាន", FrmMessageError, "")
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblPrintByClass_MouseHover(sender As Object, e As EventArgs) Handles lblPrintByClass.MouseHover
        t.Hover(lblPrintByClass)
    End Sub

    Private Sub lblPrintByClass_MouseLeave(sender As Object, e As EventArgs) Handles lblPrintByClass.MouseLeave
        t.Leave(lblPrintByClass)
    End Sub

    Private Sub lblPrintByOrdinalNum_MouseHover(sender As Object, e As EventArgs) Handles lblPrintByOrdinalNum.MouseHover
        t.Hover(lblPrintByOrdinalNum)
    End Sub

    Private Sub lblPrintByOrdinalNum_MouseLeave(sender As Object, e As EventArgs) Handles lblPrintByOrdinalNum.MouseLeave
        t.Leave(lblPrintByOrdinalNum)
    End Sub

    Private Sub lblPrintAll_MouseHover(sender As Object, e As EventArgs) Handles lblPrintAll.MouseHover
        t.Hover(lblPrintAll)
    End Sub

    Private Sub lblPrintAll_MouseLeave(sender As Object, e As EventArgs) Handles lblPrintAll.MouseLeave
        t.Leave(lblPrintAll)
    End Sub

    Private Sub lblPrintAll_Click(sender As Object, e As EventArgs) Handles lblPrintAll.Click
        Try
            If (cboYearStudy.Text = "") Then
                obj.ShowMsg("សូមជ្រើសរើសឆ្នាំសិក្សា", FrmWarning, "")
                cboYearStudy.BackColor = Color.LavenderBlush
                cboYearStudy.Focus()
                Exit Sub
            End If
            obj.OpenConnection()
            cmd = New SqlCommand("SELECT ROW_NUMBER() OVER(ORDER BY C.CLASS_NUMBER,C.CLASS_LETTER ASC) AS 'ROW_NUMBER',S.STUDENT_ID,'111'AS'ORDER_ID',S.STUDENT_ID_SCHOOL,S.STUDENT_CODE, S.SNAME_KH,S.SNAME_LATIN, S.GENDER,dbo.F_DATE_KHMER(S.DOB),(S.POB_PROVINCE+' ('+S.POB_VILLAGE+')')AS 'POB',I.YEAR_STUDY,I.CLASS_ID,C.CLASS_LETTER,S.FATHER_NAME ,S.MOTHER_NAME,C.CLASS_NUMBER,S.STUDENT_PHOTO,(SELECT SCHOOL_NAME_KH FROM dbo.TBL_SCHOOL_INFO),(SELECT PROVINCE FROM dbo.TBL_SCHOOL_INFO)  FROM dbo.TBS_STUDENT_INFO AS S INNER JOIN dbo.TBS_STUDENT_STUDY_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN dbo.TBS_CLASS AS C ON I.CLASS_ID = C.CLASS_ID WHERE YEAR_STUDY = N'" & cboYearStudy.Text & "' ORDER BY C.CLASS_NUMBER", conn)
            da = New SqlDataAdapter(cmd)
            DataSet1.STU_CARD.Clear()
            da.Fill(DataSet1.STU_CARD)

            If (DataSet1.STU_CARD.Rows.Count <= 0) Then
                obj.ShowMsg("មិនមានទិន្នន័យ", FrmWarning, "")
                Exit Sub
            End If
            Call PrintCardBySelectedCardSize()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboYearStudy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearStudy.SelectedIndexChanged
        cboYearStudy.BackColor = Color.White
    End Sub

    Private Sub cboValidityCard_CheckedChanged(sender As Object, e As EventArgs) Handles cbValidityCard.CheckedChanged
        Try
            If (cbValidityCard.Checked = True) Then

                dtStartDate.Enabled = True
                dtEndDate.Enabled = True
                dtStartDate.Value = Date.Today
                dtEndDate.Value = Date.Today
            Else
                dtStartDate.Enabled = False
                dtEndDate.Enabled = False
                dtStartDate.Text = "1/1/1990"
                dtEndDate.Text = "1/1/1990"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub lblUpdate_MouseHover(sender As Object, e As EventArgs) Handles lblUpdate.MouseHover
        t.Hover(lblUpdate)
    End Sub

    Private Sub lblUpdate_MouseLeave(sender As Object, e As EventArgs) Handles lblUpdate.MouseLeave
        t.Leave(lblUpdate)
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        Try

            Call obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, POP_SOUND)
            If USER_CLICK_OK = True Then

                If (dgSelected.Rows.Count > 0) Then
                    For i As Integer = 0 To dgSelected.RowCount - 1
                        If (obj.CheckExisted("SELECT RECORD_ID FROM dbo.TBS_STUDENT_PRINT_CARD WHERE RECORD_ID = " & (If(dgSelected.Rows(i).Cells(20).Value Is Nothing, "0", dgSelected.Rows(i).Cells(20).Value)) & " ", "TBS_STUDENT_PRINT_CARD") = False) Then
                            obj.InsertNoMsg("INSERT INTO dbo.TBS_STUDENT_PRINT_CARD (STUDENT_ID,ORDER_ID,STUDENT_ID_SCHOOL,STUDENT_CODE,SNAME_KH,SNAME_LATIN,GENDER,DOB,POB,YEAR_STUDY,CLASS_ID,CLASS_LETTER,FATHER_NAME ,MOTHER_NAME,DATE_START,DATE_END,DATE_PRINT)VALUES(" & dgSelected.Rows(i).Cells(1).Value & "," & dgSelected.Rows(i).Cells(2).Value & ",N'" & dgSelected.Rows(i).Cells(3).Value & "',N'" & dgSelected.Rows(i).Cells(4).Value & "',N'" & dgSelected.Rows(i).Cells(5).Value & "',N'" & dgSelected.Rows(i).Cells(6).Value & "',N'" & dgSelected.Rows(i).Cells(7).Value & "','" & dgSelected.Rows(i).Cells(19).Value & "',N'" & dgSelected.Rows(i).Cells(9).Value & "',N'" & dgSelected.Rows(i).Cells(10).Value & "'," & dgSelected.Rows(i).Cells(11).Value & ",N'" & dgSelected.Rows(i).Cells(12).Value & "',N'" & dgSelected.Rows(i).Cells(13).Value & "',N'" & dgSelected.Rows(i).Cells(14).Value & "','" & dtStartDate.Text & "','" & dtEndDate.Text & "',GETDATE())")
                        End If
                    Next
                End If
                obj.ShowMsg("កែប្រែបានសម្រច", FrmMessageSuccess, "")
                Call SelectStuCard()

            End If
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("មិនអាចកែប្រែបាន", FrmMessageError, ERROR_SOUND)
        End Try
    End Sub



    '--------   selection ---------
    Private Sub SelectStuCard()
        Try
            Dim selectStuCardSql As String = "SELECT   ROW_NUMBER() OVER(ORDER BY CL.CLASS_NUMBER,CL.CLASS_LETTER ASC) AS 'ROW_NUMBER',  C.STUDENT_ID, C.ORDER_ID, C.STUDENT_ID_SCHOOL, C.STUDENT_CODE, C.SNAME_KH, C.SNAME_LATIN, C.GENDER, dbo.F_DATE_KHMER(C.DOB)AS 'DOB', C.POB, C.YEAR_STUDY, C.CLASS_ID, C.CLASS_LETTER,C.FATHER_NAME, C.MOTHER_NAME, CL.CLASS_NUMBER, I.STUDENT_PHOTO, dbo.TBL_SCHOOL_INFO.SCHOOL_NAME_KH, dbo.TBL_SCHOOL_INFO.PROVINCE,C.DOB AS 'DOB_DB_FORMAT',RECORD_ID FROM dbo.TBS_STUDENT_PRINT_CARD AS C INNER JOIN dbo.TBS_CLASS AS CL ON C.CLASS_ID = CL.CLASS_ID INNER JOIN dbo.TBS_STUDENT_INFO AS I ON C.STUDENT_ID = I.STUDENT_ID CROSS JOIN dbo.TBL_SCHOOL_INFO"

            cmd = New SqlCommand(selectStuCardSql, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                lblSave.Enabled = False
                lblUpdate.Enabled = True

                dgSelected.Rows.Clear()

                For i As Integer = 0 To dt.Rows.Count - 1
                    dgSelected.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString(), dt.Rows(i)(6).ToString(), dt.Rows(i)(7).ToString(), dt.Rows(i)(8).ToString(), dt.Rows(i)(9).ToString(), dt.Rows(i)(10).ToString(), dt.Rows(i)(11).ToString(), dt.Rows(i)(12).ToString(), dt.Rows(i)(13).ToString(), dt.Rows(i)(14).ToString(), dt.Rows(i)(15).ToString(), dt.Rows(i)(16).ToString(), dt.Rows(i)(17).ToString(), dt.Rows(i)(18).ToString(), dt.Rows(i)(19).ToString(), dt.Rows(i)(20).ToString())
                Next

            Else
                lblSave.Enabled = True
                lblUpdate.Enabled = False
            End If
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("មិនអាចទាញទិន្នន័យបាន", FrmMessageError, ERROR_SOUND)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim selectStuCardSql As String = "SELECT   ROW_NUMBER() OVER(ORDER BY CL.CLASS_NUMBER,CL.CLASS_LETTER ASC) AS 'ROW_NUMBER',  C.STUDENT_ID, C.ORDER_ID, C.STUDENT_ID_SCHOOL, C.STUDENT_CODE, C.SNAME_KH, C.SNAME_LATIN, C.GENDER, dbo.F_DATE_KHMER(C.DOB)AS 'DOB', C.POB, C.YEAR_STUDY, C.CLASS_ID, C.CLASS_LETTER,C.FATHER_NAME, C.MOTHER_NAME, CL.CLASS_NUMBER, I.STUDENT_PHOTO, dbo.TBL_SCHOOL_INFO.SCHOOL_NAME_KH, dbo.TBL_SCHOOL_INFO.PROVINCE,C.DOB AS 'DOB_DB_FORMAT',RECORD_ID FROM dbo.TBS_STUDENT_PRINT_CARD AS C INNER JOIN dbo.TBS_CLASS AS CL ON C.CLASS_ID = CL.CLASS_ID INNER JOIN dbo.TBS_STUDENT_INFO AS I ON C.STUDENT_ID = I.STUDENT_ID CROSS JOIN dbo.TBL_SCHOOL_INFO WHERE ISNULL (C.STUDENT_ID_SCHOOL,'')+ ISNULL (C.SNAME_KH,'')+ ISNULL(C.CLASS_LETTER,'') + ISNULL(C.YEAR_STUDY,'') LIKE N'%" & txtSearch.Text & "%'"

            cmd = New SqlCommand(selectStuCardSql, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                lblSave.Enabled = False
                lblUpdate.Enabled = True

                dgSelected.Rows.Clear()

                For i As Integer = 0 To dt.Rows.Count - 1
                    dgSelected.Rows.Add(dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString(), dt.Rows(i)(2).ToString(), dt.Rows(i)(3).ToString(), dt.Rows(i)(4).ToString(), dt.Rows(i)(5).ToString(), dt.Rows(i)(6).ToString(), dt.Rows(i)(7).ToString(), dt.Rows(i)(8).ToString(), dt.Rows(i)(9).ToString(), dt.Rows(i)(10).ToString(), dt.Rows(i)(11).ToString(), dt.Rows(i)(12).ToString(), dt.Rows(i)(13).ToString(), dt.Rows(i)(14).ToString(), dt.Rows(i)(15).ToString(), dt.Rows(i)(16).ToString(), dt.Rows(i)(17).ToString(), dt.Rows(i)(18).ToString(), dt.Rows(i)(19).ToString(), dt.Rows(i)(20).ToString())
                Next

            Else
                dgSelected.Rows.Clear()
                lblSave.Enabled = True
                lblUpdate.Enabled = False

            End If
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("មិនអាចទាញទិន្នន័យបាន", FrmMessageError, ERROR_SOUND)
        End Try
    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        SelectStuCard()
    End Sub

    Private Sub picPrintFromList_MouseHover(sender As Object, e As EventArgs) Handles picPrintFromList.MouseHover
        t.Hover(lblPrintFromList)
    End Sub

    Private Sub picPrintFromList_MouseLeave(sender As Object, e As EventArgs) Handles picPrintFromList.MouseLeave
        t.Leave(lblPrintFromList)
    End Sub

    Private Sub picPrintFromList_Click(sender As Object, e As EventArgs) Handles picPrintFromList.Click
        lblPrintFromList_Click(sender, e)
    End Sub

    Private Sub cboYearStudy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboYearStudy.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboYearStudy_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles cboYearStudy.MouseDoubleClick
        frm_year_study.ShowDialog()
    End Sub

    Private Sub cboClass_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles cboClass.MouseDoubleClick
        frm_class.ShowDialog()
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        lblSearch_Click(sender, e)
    End Sub

    Private Sub picSearch_MouseHover(sender As Object, e As EventArgs) Handles picSearch.MouseHover
        t.Hover(lblSearch)
    End Sub

    Private Sub picSearch_MouseLeave(sender As Object, e As EventArgs) Handles picSearch.MouseLeave
        t.Leave(lblSearch)
    End Sub

    Private Sub picDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles picDisplayAll.MouseHover
        t.Hover(lblDisplayAll)
    End Sub

    Private Sub picDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles picDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)
    End Sub

    Private Sub picDisplayAll_Click(sender As Object, e As EventArgs) Handles picDisplayAll.Click
        lblDisplayAll_Click(sender, e)
    End Sub
End Class
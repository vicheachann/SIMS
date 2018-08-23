Public Class FrmStudentStatistic
    Dim obj As New Method
    Dim t As New Theme



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub cboYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles lblSave.Click

        If cboYearStudy.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលឆ្នាំសិក្សា", FrmWarning, "")
            cboYearStudy.Focus()
            cboYearStudy.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_7_class.Text = "" Or txt_7_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_7_class.Focus()
            txt_7_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_7_total.Text = "" Or txt_7_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_7_total.Focus()
            txt_7_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_8_class.Text = "" Or txt_8_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_8_class.Focus()
            txt_8_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_8_total.Text = "" Or txt_8_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_8_total.Focus()
            txt_8_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_9_class.Text = "" Or txt_9_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_9_class.Focus()
            txt_9_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_9_total.Text = "" Or txt_9_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_9_total.Focus()
            txt_9_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_10_class.Text = "" Or txt_10_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_10_class.Focus()
            txt_10_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_10_total.Text = "" Or txt_10_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_10_total.Focus()
            txt_10_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_11_class.Text = "" Or txt_11_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_11_class.Focus()
            txt_11_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_11_total.Text = "" Or txt_11_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_11_total.Focus()
            txt_11_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_12_class.Text = "" Or txt_12_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_12_class.Focus()
            txt_12_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_12_total.Text = "" Or txt_12_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_12_total.Focus()
            txt_12_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        obj.Insert("INSERT INTO dbo.TBS_STUDENT_STATISTIC(YEAR_STUDY,CLASS_7,CLASS_7_STUDENT,CLASS_7_STUDENT_GIRL,CLASS_8,CLASS_8_STUDENT,CLASS_8_STUDENT_GIRL,CLASS_9,CLASS_9_STUDENT,CLASS_9_STUDENT_GIRL,CLASS_10,CLASS_10_STUDENT,CLASS_10_STUDENT_GIRL,CLASS_11,CLASS_11_STUDENT,CLASS_11_STUDENT_GIRL,CLASS_12,CLASS_12_STUDENT,CLASS_12_STUDENT_GIRL,CLASS_TOTAL,STUDENT_TOTAL,STUDENT_TOTAL_GIRL)VALUES(N'" & cboYearStudy.Text & "'," & txt_7_class.Text & "," & txt_7_total.Text & "," & txt_7_girl.Text & "," & txt_8_class.Text & "," & txt_8_total.Text & "," & txt_8_girl.Text & "," & txt_9_class.Text & "," & txt_9_total.Text & "," & txt_9_girl.Text & "," & txt_10_class.Text & "," & txt_10_total.Text & "," & txt_10_girl.Text & "," & txt_11_class.Text & "," & txt_11_total.Text & "," & txt_11_girl.Text & "," & txt_12_class.Text & "," & txt_12_total.Text & "," & txt_12_girl.Text & "," & txtTotalClass.Text & "," & txtTotalStudent.Text & "," & txtTotalGirl.Text & ")")

        Call Selection()

    End Sub

    Private Sub CalculateTotal()
        Try
            Call PreventEmptyString()

            txtTotalClass.Text = (Convert.ToInt32(txt_7_class.Text) + Convert.ToInt32(txt_8_class.Text) + Convert.ToInt32(txt_9_class.Text) + Convert.ToInt32(txt_10_class.Text) + Convert.ToInt32(txt_11_class.Text) + Convert.ToInt32(txt_12_class.Text)).ToString()
            txtTotalStudent.Text = (Convert.ToInt32(txt_7_total.Text) + Convert.ToInt32(txt_8_total.Text) + Convert.ToInt32(txt_9_total.Text) + Convert.ToInt32(txt_10_total.Text) + Convert.ToInt32(txt_11_total.Text) + Convert.ToInt32(txt_12_total.Text)).ToString()
            txtTotalGirl.Text = (Convert.ToInt32(txt_7_girl.Text) + Convert.ToInt32(txt_8_girl.Text) + Convert.ToInt32(txt_9_girl.Text) + Convert.ToInt32(txt_10_girl.Text) + Convert.ToInt32(txt_11_girl.Text) + Convert.ToInt32(txt_12_girl.Text)).ToString()
        Catch
        End Try
    End Sub



    Private Sub txt_7_class_TextChanged(sender As Object, e As EventArgs) Handles txt_7_class.TextChanged
        CalculateTotal()
        txt_7_class.BackColor = Color.White

    End Sub

    Private Sub txt_7_total_TextChanged(sender As Object, e As EventArgs) Handles txt_7_total.TextChanged
        CalculateTotal()
        txt_7_total.BackColor = Color.White

    End Sub

    Private Sub txt_7_girl_TextChanged(sender As Object, e As EventArgs) Handles txt_7_girl.TextChanged
        CalculateTotal()
        txt_7_girl.BackColor = Color.White

    End Sub

    Private Sub txt_8_class_TextChanged(sender As Object, e As EventArgs) Handles txt_8_class.TextChanged
        CalculateTotal()
        txt_8_class.BackColor = Color.White

    End Sub

    Private Sub txt_8_total_TextChanged(sender As Object, e As EventArgs) Handles txt_8_total.TextChanged
        CalculateTotal()
        txt_8_total.BackColor = Color.White

    End Sub

    Private Sub txt_8_girl_TextChanged(sender As Object, e As EventArgs) Handles txt_8_girl.TextChanged
        CalculateTotal()

    End Sub

    Private Sub txt_9_class_TextChanged(sender As Object, e As EventArgs) Handles txt_9_class.TextChanged
        CalculateTotal()
        txt_9_class.BackColor = Color.White

    End Sub

    Private Sub txt_9_total_TextChanged(sender As Object, e As EventArgs) Handles txt_9_total.TextChanged
        CalculateTotal()
        txt_9_total.BackColor = Color.White
    End Sub

    Private Sub txt_9_girl_TextChanged(sender As Object, e As EventArgs) Handles txt_9_girl.TextChanged
        CalculateTotal()

    End Sub

    Private Sub txt_10_class_TextChanged(sender As Object, e As EventArgs) Handles txt_10_class.TextChanged
        CalculateTotal()
        txt_10_class.BackColor = Color.White
    End Sub

    Private Sub txt_10_total_TextChanged(sender As Object, e As EventArgs) Handles txt_10_total.TextChanged
        CalculateTotal()
        txt_10_total.BackColor = Color.White
    End Sub

    Private Sub txt_10_girl_TextChanged(sender As Object, e As EventArgs) Handles txt_10_girl.TextChanged
        CalculateTotal()

    End Sub

    Private Sub txt_11_class_TextChanged(sender As Object, e As EventArgs) Handles txt_11_class.TextChanged
        CalculateTotal()
        txt_11_class.BackColor = Color.White

    End Sub

    Private Sub txt_11_total_TextChanged(sender As Object, e As EventArgs) Handles txt_11_total.TextChanged
        CalculateTotal()
        txt_11_total.BackColor = Color.White

    End Sub

    Private Sub txt_11_girl_TextChanged(sender As Object, e As EventArgs) Handles txt_11_girl.TextChanged
        CalculateTotal()
    End Sub

    Private Sub txt_12_class_TextChanged(sender As Object, e As EventArgs) Handles txt_12_class.TextChanged
        CalculateTotal()
        txt_12_class.BackColor = Color.White

    End Sub

    Private Sub txt_12_total_TextChanged(sender As Object, e As EventArgs) Handles txt_12_total.TextChanged
        CalculateTotal()
        txt_12_total.BackColor = Color.White

    End Sub

    Private Sub txt_12_girl_TextChanged(sender As Object, e As EventArgs) Handles txt_12_girl.TextChanged
        CalculateTotal()
    End Sub

    Private Sub Selection()
        Try
            obj.BindDataGridView("SELECT STUDENT_STATISTIC_ID,ROW_NUMBER() OVER(ORDER BY YEAR_STUDY DESC) AS 'ROW_NUMBER',YEAR_STUDY,CLASS_7 ,CLASS_7_STUDENT,CLASS_7_STUDENT_GIRL,CLASS_8,CLASS_8_STUDENT,CLASS_8_STUDENT_GIRL,CLASS_9,CLASS_9_STUDENT,CLASS_9_STUDENT_GIRL,CLASS_10 ,CLASS_10_STUDENT ,CLASS_10_STUDENT_GIRL,CLASS_11,CLASS_11_STUDENT,CLASS_11_STUDENT_GIRL,CLASS_12 ,CLASS_12_STUDENT,CLASS_12_STUDENT_GIRL,CLASS_TOTAL ,STUDENT_TOTAL ,STUDENT_TOTAL_GIRL FROM dbo.TBS_STUDENT_STATISTIC", dg)
            Call SetColHeader()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetColHeader()

        dg.Columns(0).Visible = False 'RECORD_ID

        dg.Columns(1).HeaderText = "លរ"
        dg.Columns(1).Width = 50

        dg.Columns(2).HeaderText = "ឆ្នាំសិក្សា"
        dg.Columns(2).Width = 120

        dg.Columns(3).HeaderText = "ថ្នាក់ទី៧សរុប"
        dg.Columns(3).Width = 120

        dg.Columns(4).HeaderText = "ទី៧សិស្សសរុប"
        dg.Columns(4).Width = 120

        dg.Columns(5).HeaderText = "ទី៧សិស្សស្រីសរុប"
        dg.Columns(5).Width = 140

        dg.Columns(6).HeaderText = "ថ្នាក់ទី៨សរុប"
        dg.Columns(6).Width = 120

        dg.Columns(7).HeaderText = "ទី៨សិស្សសរុប"
        dg.Columns(7).Width = 120

        dg.Columns(8).HeaderText = "ទី៨សិស្សស្រីសរុប"
        dg.Columns(8).Width = 140

        dg.Columns(9).HeaderText = "ថ្នាក់ទី៩សរុប"
        dg.Columns(9).Width = 120

        dg.Columns(10).HeaderText = "ទី៩សិស្សសរុប"
        dg.Columns(10).Width = 120

        dg.Columns(11).HeaderText = "ទី៩សិស្សស្រីសរុប"
        dg.Columns(11).Width = 140

        dg.Columns(12).HeaderText = "ថ្នាក់ទី១០សរុប"
        dg.Columns(12).Width = 120

        dg.Columns(13).HeaderText = "ទី១០សិស្សសរុប"
        dg.Columns(13).Width = 120

        dg.Columns(14).HeaderText = "ទី១០សិស្សស្រីសរុប"
        dg.Columns(14).Width = 140

        dg.Columns(15).HeaderText = "ថ្នាក់ទី១១សរុប"
        dg.Columns(15).Width = 120

        dg.Columns(16).HeaderText = "ទី១១សិស្សសរុប"
        dg.Columns(16).Width = 120

        dg.Columns(17).HeaderText = "ទី១១សិស្សស្រីសរុប"
        dg.Columns(17).Width = 140

        dg.Columns(18).HeaderText = "ថ្នាក់ទី១២សរុប"
        dg.Columns(18).Width = 120

        dg.Columns(19).HeaderText = "ទី១២សិស្សសរុប"
        dg.Columns(19).Width = 120

        dg.Columns(20).HeaderText = "ទី១២សិស្សស្រីសរុប"
        dg.Columns(20).Width = 140

        dg.Columns(21).HeaderText = "ថ្នាក់សរុបរួម"
        dg.Columns(21).Width = 120

        dg.Columns(22).HeaderText = "សិស្សសរុបទាំងអស់"
        dg.Columns(22).Width = 120

        dg.Columns(23).HeaderText = "សិស្សសរុបស្រី"
        dg.Columns(23).Width = 140


    End Sub

    Private Sub FrmStudentStatistic_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Selection()
    End Sub


    Private Sub Clear()
        cboYearStudy.Text = ""
        txt_7_class.Text = "0"
        txt_8_class.Text = "0"
        txt_9_class.Text = "0"
        txt_10_class.Text = "0"
        txt_11_class.Text = "0"
        txt_12_class.Text = "0"

        txt_7_total.Text = "0"
        txt_8_total.Text = "0"
        txt_9_total.Text = "0"
        txt_10_total.Text = "0"
        txt_11_total.Text = "0"
        txt_12_total.Text = "0"

        txt_7_girl.Text = "0"
        txt_8_girl.Text = "0"
        txt_9_girl.Text = "0"
        txt_10_girl.Text = "0"
        txt_11_girl.Text = "0"
        txt_12_girl.Text = "0"

        txtTotalClass.Text = "0"
        txtTotalStudent.Text = "0"
        txtTotalGirl.Text = "0"

    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Call Clear()
        cboYearStudy.Focus()

        lblUpdate.Enabled = False
        lblDelete.Enabled = False
        lblSave.Enabled = True
    End Sub

    Private Sub dg_SelectionChanged(sender As Object, e As EventArgs) Handles dg.SelectionChanged
        Try
            lblSave.Enabled = False
            lblUpdate.Enabled = True
            lblDelete.Enabled = True


            If (dg.Rows.Count > 0) Then
                Call Clear()
                cboYearStudy.Text = If(dg.SelectedRows(0).Cells(2).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(2).Value.ToString)

                txt_7_class.Text = If(dg.SelectedRows(0).Cells(3).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(3).Value.ToString)
                txt_7_total.Text = If(dg.SelectedRows(0).Cells(4).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(4).Value.ToString)
                txt_7_girl.Text = If(dg.SelectedRows(0).Cells(5).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(5).Value.ToString)


                txt_8_class.Text = If(dg.SelectedRows(0).Cells(6).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(6).Value.ToString)
                txt_8_total.Text = If(dg.SelectedRows(0).Cells(7).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(7).Value.ToString)
                txt_8_girl.Text = If(dg.SelectedRows(0).Cells(8).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(8).Value.ToString)

                txt_9_class.Text = If(dg.SelectedRows(0).Cells(9).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(9).Value.ToString)
                txt_9_total.Text = If(dg.SelectedRows(0).Cells(10).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(10).Value.ToString)
                txt_9_girl.Text = If(dg.SelectedRows(0).Cells(11).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(11).Value.ToString)

                txt_10_class.Text = If(dg.SelectedRows(0).Cells(12).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(12).Value.ToString)
                txt_10_total.Text = If(dg.SelectedRows(0).Cells(13).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(13).Value.ToString)
                txt_10_girl.Text = If(dg.SelectedRows(0).Cells(14).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(14).Value.ToString)

                txt_11_class.Text = If(dg.SelectedRows(0).Cells(15).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(15).Value.ToString)
                txt_11_total.Text = If(dg.SelectedRows(0).Cells(16).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(16).Value.ToString)
                txt_11_girl.Text = If(dg.SelectedRows(0).Cells(17).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(17).Value.ToString)


                txt_12_class.Text = If(dg.SelectedRows(0).Cells(18).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(18).Value.ToString)
                txt_12_total.Text = If(dg.SelectedRows(0).Cells(19).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(19).Value.ToString)
                txt_12_girl.Text = If(dg.SelectedRows(0).Cells(20).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(20).Value.ToString)


                txtTotalClass.Text = If(dg.SelectedRows(0).Cells(21).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(21).Value.ToString)
                txtTotalStudent.Text = If(dg.SelectedRows(0).Cells(22).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(22).Value.ToString)
                txtTotalGirl.Text = If(dg.SelectedRows(0).Cells(23).Value Is DBNull.Value, "0", dg.SelectedRows(0).Cells(23).Value.ToString)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_7_class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_7_class.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_7_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_7_total.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_7_girl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_7_girl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_8_class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_8_class.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_8_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_8_total.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_8_girl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_8_girl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_9_class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_9_class.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_9_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_9_total.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_9_girl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_9_girl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_10_class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_10_class.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_10_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_10_total.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_10_girl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_10_girl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_11_class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_11_class.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_11_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_11_total.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_11_girl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_11_girl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_12_class_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_12_class.KeyPress
        obj.Insert("dsdasdasdas")
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_12_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_12_total.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_12_girl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_12_girl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTotalClass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalClass.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtTotalStudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalStudent.KeyPress
        e.Handled = True

    End Sub

    Private Sub txtTotalGirl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalGirl.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboYearStudy_TextChanged(sender As Object, e As EventArgs) Handles cboYearStudy.TextChanged
        cboYearStudy.BackColor = Color.White
    End Sub

    Private Sub cboYearStudy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboYearStudy.KeyPress
        e.Handled = True
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click


        If cboYearStudy.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលឆ្នាំសិក្សា", FrmWarning, "")
            cboYearStudy.Focus()
            cboYearStudy.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_7_class.Text = "" Or txt_7_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_7_class.Focus()
            txt_7_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_7_total.Text = "" Or txt_7_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_7_total.Focus()
            txt_7_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_8_class.Text = "" Or txt_8_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_8_class.Focus()
            txt_8_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_8_total.Text = "" Or txt_8_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_8_total.Focus()
            txt_8_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_9_class.Text = "" Or txt_9_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_9_class.Focus()
            txt_9_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_9_total.Text = "" Or txt_9_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_9_total.Focus()
            txt_9_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_10_class.Text = "" Or txt_10_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_10_class.Focus()
            txt_10_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_10_total.Text = "" Or txt_10_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_10_total.Focus()
            txt_10_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_11_class.Text = "" Or txt_11_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_11_class.Focus()
            txt_11_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_11_total.Text = "" Or txt_11_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_11_total.Focus()
            txt_11_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_12_class.Text = "" Or txt_12_class.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_12_class.Focus()
            txt_12_class.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txt_12_total.Text = "" Or txt_12_total.Text = "0" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មាន", FrmWarning, "")
            txt_12_total.Focus()
            txt_12_total.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែលឬទេ ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            Call PreventEmptyString()
            obj.Update("UPDATE dbo.TBS_STUDENT_STATISTIC SET YEAR_STUDY = N'" & cboYearStudy.Text & "', CLASS_7 = " & txt_7_class.Text & ",CLASS_7_STUDENT = " & txt_7_total.Text & ",CLASS_7_STUDENT_GIRL = " & txt_7_girl.Text & ", CLASS_8 =" & txt_8_class.Text & ",CLASS_8_STUDENT =" & txt_8_total.Text & ",CLASS_8_STUDENT_GIRL= " & txt_8_girl.Text & ",CLASS_9= " & txt_9_class.Text & ",CLASS_9_STUDENT= " & txt_9_total.Text & ",CLASS_9_STUDENT_GIRL= " & txt_9_girl.Text & ",CLASS_10= " & txt_10_class.Text & ",CLASS_10_STUDENT= " & txt_10_total.Text & ",CLASS_10_STUDENT_GIRL= " & txt_10_girl.Text & ",CLASS_11 = " & txt_11_class.Text & ",CLASS_11_STUDENT= " & txt_11_total.Text & ",CLASS_11_STUDENT_GIRL = " & txt_11_girl.Text & ",CLASS_12= " & txt_12_class.Text & ",CLASS_12_STUDENT= " & txt_12_total.Text & ",CLASS_12_STUDENT_GIRL= " & txt_12_girl.Text & ",CLASS_TOTAL= " & txtTotalClass.Text & ",STUDENT_TOTAL= " & txtTotalStudent.Text & ",STUDENT_TOTAL_GIRL = " & txtTotalGirl.Text & " WHERE STUDENT_STATISTIC_ID = " & dg.SelectedCells(0).Value & " ")
            Call Selection()
        End If

    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            obj.Delete("DELETE FROM dbo.TBS_STUDENT_STATISTIC WHERE STUDENT_STATISTIC_ID = " & dg.SelectedCells(0).Value & "")
            Call Selection()
        End If
    End Sub

    Private Sub PreventEmptyString()
        If txt_7_class.Text = "" Then
            txt_7_class.Text = 0
        End If
        If txt_7_total.Text = "" Then
            txt_7_total.Text = 0
        End If
        If txt_7_girl.Text = "" Then
            txt_7_girl.Text = 0
        End If
        If txt_8_class.Text = "" Then
            txt_8_class.Text = 0
        End If
        If txt_8_total.Text = "" Then
            txt_8_total.Text = 0
        End If
        If txt_8_girl.Text = "" Then
            txt_8_girl.Text = 0
        End If

        If txt_9_class.Text = "" Then
            txt_9_class.Text = 0
        End If
        If txt_9_total.Text = "" Then
            txt_9_total.Text = 0
        End If
        If txt_9_girl.Text = "" Then
            txt_9_girl.Text = 0
        End If

        If txt_10_class.Text = "" Then
            txt_10_class.Text = 0
        End If
        If txt_10_total.Text = "" Then
            txt_10_total.Text = 0
        End If
        If txt_10_girl.Text = "" Then
            txt_10_girl.Text = 0
        End If

        If txt_11_class.Text = "" Then
            txt_11_class.Text = 0
        End If
        If txt_11_total.Text = "" Then
            txt_11_total.Text = 0
        End If
        If txt_11_girl.Text = "" Then
            txt_11_girl.Text = 0
        End If

        If txt_12_class.Text = "" Then
            txt_12_class.Text = 0
        End If
        If txt_12_total.Text = "" Then
            txt_12_total.Text = 0
        End If
        If txt_12_girl.Text = "" Then
            txt_12_girl.Text = 0
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            obj.BindDataGridView("SELECT STUDENT_STATISTIC_ID,ROW_NUMBER() OVER(ORDER BY YEAR_STUDY DESC) AS 'ROW_NUMBER',YEAR_STUDY,CLASS_7 ,CLASS_7_STUDENT,CLASS_7_STUDENT_GIRL,CLASS_8,CLASS_8_STUDENT,CLASS_8_STUDENT_GIRL,CLASS_9,CLASS_9_STUDENT,CLASS_9_STUDENT_GIRL,CLASS_10 ,CLASS_10_STUDENT ,CLASS_10_STUDENT_GIRL,CLASS_11,CLASS_11_STUDENT,CLASS_11_STUDENT_GIRL,CLASS_12 ,CLASS_12_STUDENT,CLASS_12_STUDENT_GIRL,CLASS_TOTAL ,STUDENT_TOTAL ,STUDENT_TOTAL_GIRL FROM dbo.TBS_STUDENT_STATISTIC WHERE YEAR_STUDY LIKE N'%" & txtSearch.Text & "%'", dg)
            Call SetColHeader()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        Try
            Call Selection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.Hover(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)
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

    Private Sub lblPrintReport_MouseHover(sender As Object, e As EventArgs) Handles lblPrintReport.MouseHover
        t.Hover(lblPrintReport)
    End Sub

    Private Sub lblPrintReport_MouseLeave(sender As Object, e As EventArgs) Handles lblPrintReport.MouseLeave
        t.Leave(lblPrintReport)
    End Sub

    Private Sub lblPrintReport_Click(sender As Object, e As EventArgs) Handles lblPrintReport.Click
        Try
            FrmReportStudentStatistic.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
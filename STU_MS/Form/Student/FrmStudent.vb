Imports System.IO
Imports System.Data.SqlClient
Public Class FrmStudent

    Dim obj As New Method
    Dim t As New Theme
    Dim sql As String
    Dim studentSelectionSql As String = "SELECT TOP (100) S.STUDENT_ID,ROW_NUMBER ()OVER(ORDER BY S.STUDENT_ID ASC )AS 'ORDER_NUMBER',S.STUDENT_ID_SCHOOL, S.STUDENT_CODE, S.SNAME_KH,S.SNAME_LATIN,S.GENDER, S.DOB,B.BATCH,H.HEALTHY_KH,S.ORDINAL_CHILD,S.BOY_NUMBER,S.GIRL_NUMBER,S.TOTAL_SIBLING,L.LIVELIHOOD_KH,S.S_PHONE_LINE_1,S.S_PHONE_LINE_2,S.EMAIL_1,S.JOIN_SCHOOL_DATE,S.FIRST_YEAR_STUDY, CL.CLASS_LETTER, S.CLASS_SCORE_12, S.CLASS_RANK,S.FINAL_12_GRADE_LETTER,S.FINAL_12_GRADE_SCORE,S.[DESCRIPTION],SS.STUDENT_STATUS_KH,S.STUDENT_PHOTO,S.FATHER_NAME,(SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE  OCCUPATION_ID = FATHER_OCCUPATION_ID) AS FATHER_OCCUPATION,S.FATHER_PHONE_LINE_1,S.FATHER_PHONE_LINE_2,S.MOTHER_NAME,(SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_ID = MOTHER_OCCUPATION_ID) As MOTHER_OCCUPATION,S.MOTHER_PHONE_LINE_1,S.MOTHER_PHONE_LINE_2,S.GUARDIAN_NAME,(SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_ID = S.GUARDIAN_OCCUPATION_ID  )AS GUARDIAN_OCCUPATION,S.GUARDIAN_PHONE_LINE_1,S.GUARDIAN_PHONE_LINE_2 FROM dbo.TBS_STUDENT_INFO AS S LEFT JOIN dbo.TBL_BATCH As B On S.BATCH_ID = B.BATCH LEFT JOIN dbo.TBL_HEALTHY As H On S.HEALTHY_ID = H.HEALTHY_ID LEFT JOIN dbo.TBL_LIVELIHOOD As L On S.LIVELIHOOD_ID = L.LIVELIHOOD_ID INNER JOIN dbo.TBS_STUDENT_STATUS AS SS ON S.STUDENT_STATUS_ID = SS.STUDENT_STATUS_ID  INNER JOIN dbo.TBS_CLASS As CL On S.CLASS_ID = CL.CLASS_ID  "

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub InsertStudent()

    End Sub



    Private Sub lblStuSave_Click(sender As Object, e As EventArgs) Handles lblStuSave.Click
        Try


            If (Validation.IsEmpty(txtStuSchoolCode, "អត្តលេខសាលា")) Then Exit Sub
            If (Validation.IsEmpty(txtStuCode, "អត្តលេខសិស្ស")) Then Exit Sub
            If (Validation.IsEmpty(txtStuNameKh, "ឈ្មោះសិស្ស")) Then Exit Sub
            If (Validation.IsEmpty(cboStuGender, "ភេទ")) Then Exit Sub
            If (Validation.IsEmpty(txtStuChildOrdinal, "លំដាប់កូន")) Then Exit Sub
            If (Validation.IsEmpty(cboStuCurrentClass, "ថ្នាក់បច្ចុប្បន្ន")) Then Exit Sub
            If (Validation.IsEmpty(cboStuStatus, "ស្ថានភាពសិស្ស")) Then Exit Sub
            If (Validation.IsEmpty(cboStuBatch, "ជំនាន់")) Then Exit Sub

            If CheckSchoolCode() = True Then
                txtStuSchoolCode.BackColor = Color.LavenderBlush
                txtStuSchoolCode.Focus()
                Exit Sub
            End If

            If (cbStuDOB.Checked = False) Then
                obj.ShowMsg("តើអ្នកចង់បញ្ចូលថ្ងៃខែឆ្នាំកំណើតដែលឬទេ ?", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    cbStuDOB.Checked = True
                End If
            End If

            If (cbStuJoinDate.Checked = False) Then
                obj.ShowMsg("តើអ្នកចង់បញ្ចូលថ្ងៃចូលរៀនដែលឬទេ ?", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    cbStuJoinDate.Checked = True
                End If
            End If


            Dim healthID As String = obj.GetID("SELECT HEALTHY_ID FROM dbo.TBL_HEALTHY WHERE HEALTHY_KH = N'" & cboStuHealth.Text & "'")
            Dim livelihoodID As String = obj.GetID("SELECT LIVELIHOOD_ID FROM dbo.TBL_LIVELIHOOD WHERE LIVELIHOOD_KH = N'" & cboStuLivehood.Text & "'")

            obj.Insert("INSERT INTO dbo.TBS_STUDENT_INFO(STUDENT_ID_SCHOOL,STUDENT_CODE,SNAME_KH,SNAME_LATIN,GENDER,DOB,BATCH_ID,HEALTHY_ID,ORDINAL_CHILD,BOY_NUMBER,GIRL_NUMBER,TOTAL_SIBLING,LIVELIHOOD_ID,S_PHONE_LINE_1,S_PHONE_LINE_2,EMAIL_1,JOIN_SCHOOL_DATE,FIRST_YEAR_STUDY,CLASS_ID,CLASS_SCORE_12,CLASS_RANK,FINAL_12_GRADE_LETTER,FINAL_12_GRADE_SCORE,[DESCRIPTION],STUDENT_STATUS_ID)VALUES(" & txtStuSchoolCode.Text & ",N'" & txtStuCode.Text & "',N'" & txtStuNameKh.Text & "',N'" & txtStuNameEn.Text & "',N'" & cboStuGender.Text & "','" & dtStuDOB.Text & "'," & cboStuBatch.SelectedValue & "," & healthID & "," & txtStuChildOrdinal.Text & ",N'" & txtStuNumBoy.Text & "',N'" & txtStuNumGirl.Text & "',N'" & txtStuTotalSibling.Text & "'," & livelihoodID & ",N'" & txtStuPhone1.Text & "',N'" & txtStuPhone2.Text & "',N'" & txtStuEmail.Text & "','" & dtStuJoinSchoolDate.Text & "',N'" & cboStuFirstYearStudy.Text & "'," & cboStuCurrentClass.SelectedValue & "," & ConvertToDecimal(txtStuClassScore12.Text) & ",N'" & txtStuClassRank.Text & "',N'" & txtStuFinal12GradeLetter.Text & "'," & ConvertToDecimal(txtStuFinal12GradeScore.Text) & ",N'" & txtStuRemark.Text & "'," & cboStuStatus.SelectedValue & ")")
            Call SelectStudent()

        Catch ex As Exception
            obj.ShowMsg("មិនអាចបញ្ចូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
            Exit Sub
        End Try
    End Sub





    Private Sub txt_school_code_TextChanged(sender As Object, e As EventArgs) Handles txtStuSchoolCode.TextChanged
        txtStuSchoolCode.BackColor = Color.White
    End Sub
    Private Sub txt_student_code_TextChanged(sender As Object, e As EventArgs) Handles txtStuCode.TextChanged
        txtStuCode.BackColor = Color.White
    End Sub
    Private Sub txt_stu_name_kh_TextChanged(sender As Object, e As EventArgs) Handles txtStuNameKh.TextChanged
        txtStuNameKh.BackColor = Color.White
    End Sub
    Private Sub cbo_stu_gender_TextChanged(sender As Object, e As EventArgs) Handles cboStuGender.TextChanged
        cboStuGender.BackColor = Color.White
    End Sub
    Private Sub cbo_stu_batch_ID_TextChanged(sender As Object, e As EventArgs) Handles cboStuBatch.TextChanged
        cboStuBatch.BackColor = Color.White
    End Sub
    Private Sub cbo_stu_health_ID_TextChanged(sender As Object, e As EventArgs) Handles cboStuHealth.TextChanged
        cboStuHealth.BackColor = Color.White
    End Sub
    Private Sub cbo_livehood_ID_TextChanged(sender As Object, e As EventArgs) Handles cboStuLivehood.TextChanged
        cboStuLivehood.BackColor = Color.White
    End Sub
    Private Sub cbo_STUDENT_STATUS_ID_TextChanged(sender As Object, e As EventArgs) Handles cboStuStatus.TextChanged
        cboStuStatus.BackColor = Color.White
    End Sub
    Private Sub cbo_stu_batch_ID_DropDown(sender As Object, e As EventArgs) Handles cboStuBatch.DropDown
        Bind.Batch(cboStuBatch)
    End Sub

    Private Sub cbo_stu_health_ID_DropDown(sender As Object, e As EventArgs) Handles cboStuHealth.DropDown
        Bind.Health(cboStuHealth)
    End Sub

    Private Sub cbo_livehood_ID_DropDown(sender As Object, e As EventArgs) Handles cboStuLivehood.DropDown
        Bind.Livelyhood(cboStuLivehood)
    End Sub

    Private Sub cbo_STUDENT_STATUS_ID_DropDown(sender As Object, e As EventArgs) Handles cboStuStatus.DropDown
        Bind.StudentStatus(cboStuStatus)
    End Sub

    Private Sub frm_student_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Cursor = Cursors.AppStarting

            CompanyInfo.SetCompanyInfo(lblCompanyInfo)
            txt_ad_search.SetWaterMark("ស្វែងរកព័ត៌មានសិស្ស")
            Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Public Sub SelectStudent()
        Try
            obj.BindDataGridView(studentSelectionSql + " WHERE S.STUDENT_STATUS_ID = " & StuStatusStudying & "", dgMain)
            Call SetDgMainHeader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SetDgMainHeader()
        dgMain.Columns(0).Visible = False 'Record ID
        dgMain.Columns(27).Visible = False 'PHOTO
        dgMain.Columns(28).Visible = False 'FATHER_NAME
        dgMain.Columns(29).Visible = False 'FATHER OCCUPATION
        dgMain.Columns(30).Visible = False 'FATHER_PHONE_1
        dgMain.Columns(31).Visible = False 'FATHER_PHONE_2
        dgMain.Columns(32).Visible = False 'MOTHER_NAME
        dgMain.Columns(33).Visible = False
        dgMain.Columns(34).Visible = False 'MOTHER_OCCUPATION
        dgMain.Columns(35).Visible = False 'MOTHER_PHONE_1
        dgMain.Columns(36).Visible = False 'MOTHER_PHONE_2
        dgMain.Columns(37).Visible = False
        dgMain.Columns(38).Visible = False
        dgMain.Columns(39).Visible = False


        dgMain.Columns(1).HeaderText = "លរ"
        dgMain.Columns(1).Width = 50

        dgMain.Columns(2).HeaderText = "អត្តលេខ(សាលា)"
        dgMain.Columns(2).Width = 150

        dgMain.Columns(3).HeaderText = "លេខកូដសិស្ស"
        dgMain.Columns(3).Width = 120

        dgMain.Columns(4).HeaderText = "ឈ្មោះសិស្ស(ខ្មែរ)"
        dgMain.Columns(4).Width = 200

        dgMain.Columns(5).HeaderText = "ឈ្មោះសិស្ស(ឡាតាំង)"
        dgMain.Columns(5).Width = 200

        dgMain.Columns(6).HeaderText = "ភេទ"
        dgMain.Columns(6).Width = 80

        dgMain.Columns(7).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        dgMain.Columns(7).Width = 120

        dgMain.Columns(8).HeaderText = "ជំនាន់"
        dgMain.Columns(8).Width = 70

        dgMain.Columns(9).HeaderText = "ស្ថានភាពសុខភាព"
        dgMain.Columns(9).Width = 150

        dgMain.Columns(10).HeaderText = "ជាកូនទី"
        dgMain.Columns(10).Width = 80

        dgMain.Columns(11).HeaderText = "ប្រុស"
        dgMain.Columns(11).Width = 60

        dgMain.Columns(12).HeaderText = "ស្រី"
        dgMain.Columns(12).Width = 60

        dgMain.Columns(13).HeaderText = "បងប្អូនសរុប"
        dgMain.Columns(13).Width = 120

        dgMain.Columns(13).HeaderText = "បងប្អូនសរុប"
        dgMain.Columns(13).Width = 120


        dgMain.Columns(14).HeaderText = "ការចិញ្ចឹមជីវិត"
        dgMain.Columns(14).Width = 200

        dgMain.Columns(15).HeaderText = "លេខទូរស័ព្ទទី១"
        dgMain.Columns(15).Width = 170

        dgMain.Columns(16).HeaderText = "លេខទូរស័ព្ទទី២"
        dgMain.Columns(16).Width = 170

        dgMain.Columns(17).HeaderText = "អ៊ីម៉ែល"
        dgMain.Columns(17).Width = 150

        dgMain.Columns(18).HeaderText = "ថ្ងៃចូលរៀន"
        dgMain.Columns(18).Width = 150

        dgMain.Columns(19).HeaderText = "ឆ្នាំសិក្សាដំបូង"
        dgMain.Columns(19).Width = 130

        dgMain.Columns(20).HeaderText = "ថ្នាក់បច្ចុប្បន្ន"
        dgMain.Columns(20).Width = 100

        dgMain.Columns(21).HeaderText = "ពិន្ទុប្រចាំឆ្នាំ(ទី១២)"
        dgMain.Columns(21).Width = 180

        dgMain.Columns(22).HeaderText = "ចំណាត់ថ្នាក់"
        dgMain.Columns(22).Width = 150

        dgMain.Columns(23).HeaderText = "និទ្ទេស"
        dgMain.Columns(23).Width = 100

        dgMain.Columns(24).HeaderText = "លំដាប់ពិន្ទុ្"
        dgMain.Columns(24).Width = 100

        dgMain.Columns(25).HeaderText = "ផ្សេងៗ"
        dgMain.Columns(25).Width = 100

        dgMain.Columns(26).HeaderText = "ស្ថានភាពសិស្ស"
        dgMain.Columns(26).Width = 120

    End Sub
    Private Sub ClearBasicInfo()
        txtStuID.Clear()
        txtStuSchoolCode.Clear()
        txtStuCode.Clear()
        txtStuNameKh.Clear()
        txtStuNameEn.Clear()
        cboStuGender.Text = ""
        dtStuDOB.Text = "1/1/1900"

        cboStuBatch.Text = ""
        cboStuHealth.Text = ""
        txtStuChildOrdinal.Clear()
        txtStuNumBoy.Clear()
        txtStuNumGirl.Clear()
        txtStuTotalSibling.Clear()
        cboStuLivehood.Text = ""
        txtStuPhone1.Clear()
        txtStuPhone2.Clear()
        txtStuEmail.Clear()
        dtStuJoinSchoolDate.Text = "1/1/1900"
        cboStuFirstYearStudy.Text = ""
        cboStuCurrentClass.Text = ""
        txtStuClassScore12.Clear()
        txtStuClassRank.Clear()
        txtStuFinal12GradeLetter.Clear()
        txtStuFinal12GradeScore.Clear()
        txtStuRemark.Clear()
        cboStuStatus.Text = ""
        pic_student.BackgroundImage = Nothing

        cbStuDOB.Checked = False
        cbStuJoinDate.Checked = False
    End Sub

    Private Sub lblNewStudent_Click(sender As Object, e As EventArgs) Handles lblStuNew.Click
        Try
            'Combobox default
            cboStuStatus.Enabled = True
            cboStuCurrentClass.Enabled = True
            cboStuFirstYearStudy.Enabled = True

            'Button default
            lblStuUpdate.Enabled = False
            lblStuSave.Enabled = True

            'Clear other tab as well
            Call ClearBasicInfo()
            Call ClearAddress()
            Call ClearGuardian()
            Call ClearEducation()
            Call ClearSkill()
            Call ClearSibling()
            Call ClearLangugue()


            txtStuSchoolCode.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblStudentUpdate_Click(sender As Object, e As EventArgs) Handles lblStuUpdate.Click
        Try

            If (dgMain.Rows.Count > 0) Then

                obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, _ShowMessageSound)
                If USER_CLICK_OK = True Then

                    If (Validation.IsEmpty(txtStuSchoolCode, "អត្តលេខសាលា")) Then Exit Sub
                    If (Validation.IsEmpty(txtStuCode, "អត្តលេខសិស្ស")) Then Exit Sub
                    If (Validation.IsEmpty(txtStuNameKh, "ឈ្មោះសិស្ស")) Then Exit Sub
                    If (Validation.IsEmpty(cboStuGender, "ភេទ")) Then Exit Sub
                    If (Validation.IsEmpty(txtStuChildOrdinal, "លំដាប់នៃកូន")) Then Exit Sub
                    If (Validation.IsEmpty(cboStuCurrentClass, "ថ្នាក់បច្ចុប្បន្ន")) Then Exit Sub
                    If (Validation.IsEmpty(cboStuStatus, "ស្ថានភាពសិស្ស")) Then Exit Sub

                    idx = dgMain.SelectedCells(0).RowIndex.ToString()

                    If CheckSchoolCode_update() = True Then
                        txtStuSchoolCode.BackColor = Color.LavenderBlush
                        txtStuSchoolCode.Focus()
                        Exit Sub
                    End If

                    If CheckStudentCode_update() = True Then
                        txtStuCode.BackColor = Color.LavenderBlush
                        txtStuCode.Focus()
                        Exit Sub
                    End If
                    If (cbStuDOB.Checked = False) Then
                        obj.ShowMsg("តើអ្នកចង់បញ្ចូលថ្ងៃខែឆ្នាំកំណើតដែលឬទេ ?", FrmMessageQuestion, _ShowMessageSound)
                        If USER_CLICK_OK = True Then
                            cbStuDOB.Checked = True
                            Exit Sub
                        End If
                    End If
                    If (cbStuJoinDate.Checked = False) Then
                        obj.ShowMsg("តើអ្នកចង់បញ្ចូលថ្ងៃចូលរៀនដែលឬទេ ?", FrmMessageQuestion, _ShowMessageSound)
                        If USER_CLICK_OK = True Then
                            cbStuJoinDate.Checked = True
                            Exit Sub
                        End If
                    End If

                    Dim batchID As String = obj.GetID("SELECT  BATCH_ID FROM dbo.TBL_BATCH WHERE BATCH = " & cboStuBatch.Text & "")
                    Dim healthID As String = obj.GetID("SELECT HEALTHY_ID FROM dbo.TBL_HEALTHY WHERE HEALTHY_KH = N'" & cboStuHealth.Text & "'")
                    Dim livelihoodID As String = obj.GetID("SELECT LIVELIHOOD_ID FROM dbo.TBL_LIVELIHOOD WHERE LIVELIHOOD_KH = N'" & cboStuLivehood.Text & "'")

                    Call obj.Update("UPDATE dbo.TBS_STUDENT_INFO SET STUDENT_ID_SCHOOL = N'" & txtStuSchoolCode.Text & "' , STUDENT_CODE = N'" & txtStuCode.Text & "', SNAME_KH = N'" & txtStuNameKh.Text & "', SNAME_LATIN = N'" & txtStuNameEn.Text & "' ,GENDER =N'" & cboStuGender.Text & "' ,DOB = '" & dtStuDOB.Value & "',BATCH_ID = " & batchID & ",HEALTHY_ID = " & healthID & ",ORDINAL_CHILD = " & txtStuChildOrdinal.Text & " ,BOY_NUMBER = " & txtStuNumBoy.Text & " , GIRL_NUMBER = " & txtStuNumGirl.Text & " , TOTAL_SIBLING = " & txtStuTotalSibling.Text & " , LIVELIHOOD_ID = " & livelihoodID & ", S_PHONE_LINE_1 = N'" & txtStuPhone1.Text & "' , S_PHONE_LINE_2 = N'" & txtStuPhone2.Text & "',EMAIL_1 = N'" & txtStuEmail.Text & "',FIRST_YEAR_STUDY = N'" & cboStuFirstYearStudy.Text & "' ,CLASS_SCORE_12 = " & txtStuClassScore12.Text & ",CLASS_RANK = N'" & txtStuClassRank.Text & "',FINAL_12_GRADE_LETTER =N'" & txtStuFinal12GradeLetter.Text & "',FINAL_12_GRADE_SCORE =" & txtStuFinal12GradeScore.Text & " , [DESCRIPTION] = N'" & txtStuRemark.Text & "' ,JOIN_SCHOOL_DATE = '" & dtStuJoinSchoolDate.Value & "' WHERE STUDENT_ID = " & txtStuID.Text & " ")

                    Call SelectStudent()

                    dgMain.Rows(idx).Selected = True
                    dgMain.CurrentCell = dgMain.SelectedCells(1)
                End If
            Else
                obj.ShowMsg("មិនមានព័ត៌មានសម្រាប់កែប្រែ", FrmWarning, _WarningSound)
                lblNewStudent_Click(sender, e)
            End If

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចកែប្រែបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Function ConvertToDecimal(ByRef value As String) As Decimal
        If String.IsNullOrEmpty(value) Then
            value = "0"
        End If
        Return Convert.ToDecimal(value)
    End Function
    Private Function ConvertToDInt(ByRef value As String) As Integer
        If String.IsNullOrEmpty(value) Then
            value = "0"
        End If
        Return Convert.ToInt32(value)
    End Function

    Private Sub cbo_father_occupation_DropDown(sender As Object, e As EventArgs) Handles cboFatherOccupation.DropDown
        Bind.Occupation(cboFatherOccupation)
    End Sub

    Private Sub cbo_mother_occupation_DropDown(sender As Object, e As EventArgs) Handles cboMotherOccupation.DropDown
        Bind.Occupation(cboMotherOccupation)
    End Sub


    Private Sub lblSaveFamily_Click(sender As Object, e As EventArgs) Handles lblFamilySave.Click
        Try
            Call obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, _ShowMessageSound)
            If USER_CLICK_OK = True Then
                idx = dgMain.SelectedCells(0).RowIndex.ToString()

                Dim fatherOcuppcationID As String = obj.GetID("SELECT OCCUPATION_ID FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_KH = N'" & cboFatherOccupation.Text & "'")
                Dim motherOcuppationID As String = obj.GetID("SELECT OCCUPATION_ID FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_KH = N'" & cboMotherOccupation.Text & "'")
                Dim guaOccupationID As String = obj.GetID("SELECT OCCUPATION_ID FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_KH = N'" & cboGuaOccupation.Text & "'")

                Call obj.Update_1("UPDATE dbo.TBS_STUDENT_INFO SET FATHER_NAME = N'" & txtFatherName.Text & "',FATHER_OCCUPATION_ID= " & fatherOcuppcationID & ",FATHER_PHONE_LINE_1= N'" & txtFatherPhone1.Text & "',FATHER_PHONE_LINE_2= N'" & txtFatherPhone2.Text & "',MOTHER_NAME= N'" & txtMotherName.Text & "',MOTHER_OCCUPATION_ID = " & motherOcuppationID & ",MOTHER_PHONE_LINE_1= N'" & txtMotherPhone1.Text & "',MOTHER_PHONE_LINE_2= N'" & txtMotherPhone2.Text & "',GUARDIAN_NAME= N'" & txtGuaName.Text & "',GUARDIAN_OCCUPATION_ID= " & guaOccupationID & ",GUARDIAN_PHONE_LINE_1= N'" & txtGuaPhone1.Text & "',GUARDIAN_PHONE_LINE_2= N'" & txtGuaPhone2.Text & "' WHERE STUDENT_ID = " & dgMain.SelectedRows(0).Cells(0).Value & "")

                obj.ShowMsg("បញ្ចូលព័ត៌មានបានជោគជ័យ", FrmMessageSuccess, _SuccessSound)
                Call SelectStudent()
                dgMain.Rows(idx).Selected = True
                dgMain.CurrentCell = dgMain.SelectedCells(1)

            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចកែប្រែបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub


    Private Sub SelectAddress()
        Dim selectSql As String = "SELECT POB_PROVINCE,POB_DISTRICT,POB_COMMUNE,POB_VILLAGE,POB_HOUSE_NO,POB_STREET,POB_GROUP," & vbCrLf &
                                    "GUARDIAN_PROVINCE,GUARDIAN_DISTRICT,GUARDIAN_COMMUNE,GUARDIAN_VILLAGE,GUARDIAN_HOUSE_NO,GUARDIAN_STREET FROM dbo.TBS_STUDENT_INFO" & vbCrLf &
                                    "WHERE STUDENT_ID = " & dgMain.SelectedCells(0).Value & ""

        dr = obj.SelectData(selectSql)
        Try
            If dr.HasRows Then
                While dr.Read
                    'Place Of Birth
                    cboPobProvince.Text = If(dr.IsDBNull(0), "", dr.GetString(0))
                    cboPobDistrict.Text = If(dr.IsDBNull(1), "", dr.GetString(1))
                    cboPobCommune.Text = If(dr.IsDBNull(2), "", dr.GetString(2))
                    cboPobVillage.Text = If(dr.IsDBNull(3), "", dr.GetString(3))
                    txt_POB_home_num.Text = If(dr.IsDBNull(4), "", dr.GetString(4))
                    txt_POB_street_num.Text = If(dr.IsDBNull(5), "", dr.GetString(5))
                    txt_POB_group.Text = If(dr.IsDBNull(6), "", dr.GetString(6))

                    'Current Address
                    cboCurrentProvince.Text = If(dr.IsDBNull(7), "", dr.GetString(7))
                    cboCurrentDistrict.Text = If(dr.IsDBNull(8), "", dr.GetString(8))
                    cboCurrentCommune.Text = If(dr.IsDBNull(9), "", dr.GetString(9))
                    cboCurrentVillage.Text = If(dr.IsDBNull(10), "", dr.GetString(10))
                    txtCurrentHomeNumber.Text = If(dr.IsDBNull(11), "", dr.GetString(11))
                    txtCurrentStreetName.Text = If(dr.IsDBNull(12), "", dr.GetString(12))

                End While
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចទាយទិន្នន័យពី Server បានទេ !", FrmMessageError, "Error.wav")
        End Try


    End Sub
    Private Sub ClearGuardian()
        txtFatherName.Clear()
        txtFatherPhone1.Clear()
        txtFatherPhone2.Clear()
        cboFatherOccupation.Text = ""
        cboMotherOccupation.Text = ""
        txtMotherName.Clear()
        txtMotherPhone1.Clear()
        txtMotherPhone2.Clear()
        txtGuaName.Clear()
        txtGuaPhone1.Clear()
        txtGuaPhone2.Clear()
        cboGuaOccupation.Text = ""
    End Sub


    Private Sub cbo_gua_occupation_DropDown(sender As Object, e As EventArgs) Handles cboGuaOccupation.DropDown
        Bind.Occupation(cboGuaOccupation)
    End Sub

    Private Sub cbo_stu_first_year_study_TextChanged(sender As Object, e As EventArgs) Handles cboStuFirstYearStudy.SelectedIndexChanged
        cboStuFirstYearStudy.BackColor = Color.White
    End Sub





    Private Sub cbo_stu_first_year_study_TextChanged_1(sender As Object, e As EventArgs) Handles cboStuFirstYearStudy.TextChanged
        cboStuFirstYearStudy.BackColor = Color.White
    End Sub

    Private Sub cbo_stu_first_year_study_DropDown(sender As Object, e As EventArgs) Handles cboStuFirstYearStudy.DropDown
        Bind.YearStudy(cboStuFirstYearStudy)
    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label76.Click
        frm_occupation.ShowDialog()
    End Sub

    Private Sub Label98_Click(sender As Object, e As EventArgs) Handles Label98.Click
        frm_occupation.ShowDialog()

    End Sub

    Private Sub lbl_oc_Click(sender As Object, e As EventArgs) Handles lbl_oc.Click
        frm_occupation.ShowDialog()

    End Sub

    Private Sub lblNewFamily_Click(sender As Object, e As EventArgs) Handles lblNewFamily.Click
        Call ClearGuardian()
        txtFatherName.Focus()
    End Sub

    Private Sub lbl_browe_student_pic_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_browe_student_pic.LinkClicked
        Call obj.Browe(pic_student)

    End Sub
    Public Shared Function GetPhoto(ByVal filePath As String) As Byte()
        Dim stream As FileStream = New FileStream(
           filePath, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(stream)
        Dim photo() As Byte = reader.ReadBytes(stream.Length)
        reader.Close()
        stream.Close()
        Return photo
    End Function
    Private Sub lbl_stu_save_photo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_stu_save_photo.LinkClicked
        Try
            If pic_student.BackgroundImage Is Nothing Then
                Call obj.ShowMsg("សូមជ្រើសរើសរូបភាពជាមុន!", FrmWarning, "Error.wav")
                Exit Sub
            End If
            Call obj.OpenConnection()
            Dim photo() As Byte = GetPhoto(photoFilePath)
            cmd = New SqlCommand("UPDATE dbo.TBS_STUDENT_INFO SET STUDENT_PHOTO=@Photo WHERE STUDENT_ID=" & dgMain.SelectedRows(0).Cells(0).Value & " ", conn)
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            cmd.ExecuteNonQuery()
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            Call obj.ShowMsg("រូបភាពកែប្រែបានសម្រេច", FrmMessageSuccess, "")
            Call SelectStudent()

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("ពុំអាចកែប្រែរូបភាពបានទេ!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub cbo_address_province_DropDown(sender As Object, e As EventArgs) Handles cboPobProvince.DropDown
        Try
            Bind.Province(cboPobProvince)

            cboPobDistrict.Text = ""
            cboPobCommune.Text = ""
            cboPobVillage.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_address_destrict_DropDown(sender As Object, e As EventArgs) Handles cboPobDistrict.DropDown
        Try
            Bind.District(cboPobDistrict, cboPobProvince)

            cboPobCommune.Text = ""
            cboPobVillage.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_address_commune_DropDown(sender As Object, e As EventArgs) Handles cboPobCommune.DropDown
        Try
            Bind.Commune(cboPobCommune, cboPobDistrict)
            cboPobVillage.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_address_village_DropDown(sender As Object, e As EventArgs) Handles cboPobVillage.DropDown
        Try
            Bind.Village(cboPobVillage, cboPobCommune, cboPobDistrict, cboPobProvince)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ClearEducation()

        Try
            If (dgStudyInfo.Rows.Count >= 0) Then
                dgStudyInfo.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RefreshCombobox(sender As Object, e As EventArgs)
        Try
            'refreah bomx the the 
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ClearAllTab()
        Try
            Call ClearGuardian()
            Call ClearBasicInfo()
            Call ClearSibling()
            Call ClearSkill()
            Call ClearLangugue()
            Call ClearEducation()
            Call ClearAddress()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dg_main_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Try

            If (dgMain.SelectedRows.Count = 0) Then
                lblSearchResult.Text = "0 នាក់"
                ClearAllTab()
                Exit Sub
            Else
                lblStuSave.Enabled = False
                lblStuUpdate.Enabled = True
                lblStuNew.Enabled = True
                cboStuStatus.Enabled = False
                cboStuCurrentClass.Enabled = False
                cboStuFirstYearStudy.Enabled = False

                Call ClearGuardian()
                Call ClearBasicInfo()
                Call ClearSibling()
                Call ClearSkill()
                Call ClearLangugue()
                Call ClearEducation()
                Call ClearAddress()

                txtStuID.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(0).Value)
                txtStuSchoolCode.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(2).Value)
                txtStuCode.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(3).Value)
                txtStuNameKh.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(4).Value)
                txtStuNameEn.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(5).Value)
                cboStuGender.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(6).Value)
                Call CheckIfHasDOB()
                cboStuBatch.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(8).Value)
                cboStuHealth.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(9).Value)
                txtStuChildOrdinal.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(10).Value)
                txtStuNumBoy.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(11).Value)
                txtStuNumGirl.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(12).Value)
                txtStuTotalSibling.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(13).Value)
                cboStuLivehood.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(14).Value)
                txtStuPhone1.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(15).Value)
                txtStuPhone2.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(16).Value)
                txtStuEmail.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(17).Value)
                Call CheckIfHasJoinSchoolDate()
                cboStuFirstYearStudy.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(19).Value)
                cboStuCurrentClass.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(20).Value)
                txtStuClassScore12.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(21).Value)
                txtStuClassRank.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(22).Value)
                txtStuFinal12GradeLetter.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(23).Value)
                txtStuFinal12GradeScore.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(24).Value)
                txtStuRemark.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(25).Value)
                cboStuStatus.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(26).Value)
                If dgMain.SelectedCells(27).Value.ToString() = "" Then
                    pic_student.BackgroundImage = Nothing
                Else
                    Call obj.Show_Photo(dgMain.SelectedCells(27).Value, pic_student)
                End If
                txtFatherName.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(28).Value)
                cboFatherOccupation.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(29).Value)
                txtFatherPhone1.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(30).Value)
                txtFatherPhone2.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(31).Value)
                txtMotherName.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(32).Value)
                cboMotherOccupation.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(33).Value)
                txtMotherPhone1.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(34).Value)
                txtMotherPhone2.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(35).Value)
                txtGuaName.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(36).Value)
                cboGuaOccupation.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(37).Value)
                txtGuaPhone1.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(38).Value)
                txtGuaPhone2.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(39).Value)

                Call SelectAddress()
                Call SelectStuStudyInfo()
                Call SelectSibling()
                Call SelectSkill()
                Call SelectLangugue()

                Call CheckGuardianHasValue()
                Call CheckAddressHasValue()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckGuardianHasValue()
        If txtFatherName.Text = "" Then
            lblFamilySave.Text = "រក្សាទុក"
            txtFatherName.Focus()

        ElseIf txtFatherName.Text IsNot "" Then
            lblFamilySave.Text = "កែប្រែ"
        End If
    End Sub

    Private Sub CheckAddressHasValue()
        If cboPobProvince.Text = "" And cboCurrentProvince.Text = "" Then
            lblAddressSave.Text = "រក្សាទុក"
            cboPobProvince.Focus()
        Else
            lblAddressSave.Text = "កែប្រែ"
        End If
    End Sub


    Private Sub lbl_address_new_Click(sender As Object, e As EventArgs) Handles lblAddressNew.Click
        Call ClearAddress()
        cboPobProvince.Focus()
    End Sub
    Public Sub ClearAddress()
        'Place Of Birth
        cboPobProvince.Text = ""
        cboPobDistrict.Text = ""
        cboPobCommune.Text = ""
        cboPobVillage.Text = ""
        txt_POB_home_num.Clear()
        txt_POB_street_num.Clear()
        txt_POB_group.Clear()

        'Current Address
        cboCurrentProvince.Text = ""
        cboCurrentDistrict.Text = ""
        cboCurrentCommune.Text = ""
        cboCurrentVillage.Text = ""
        txtCurrentHomeNumber.Clear()
        txtCurrentStreetName.Clear()

    End Sub



    Private Sub cbo_current_province_DropDown(sender As Object, e As EventArgs) Handles cboCurrentProvince.DropDown
        Bind.Province(cboCurrentProvince)
        cboCurrentDistrict.Text = ""
        cboCurrentCommune.Text = ""
        cboCurrentVillage.Text = ""
    End Sub

    Private Sub cbo_current_destrict_DropDown(sender As Object, e As EventArgs) Handles cboCurrentDistrict.DropDown
        Bind.District(cboCurrentDistrict, cboCurrentProvince)
        cboCurrentCommune.Text = ""
        cboCurrentVillage.Text = ""
    End Sub

    Private Sub cbo_current_commune_DropDown(sender As Object, e As EventArgs) Handles cboCurrentCommune.DropDown
        Bind.Commune(cboCurrentCommune, cboCurrentDistrict)
        cboCurrentVillage.Text = ""
    End Sub

    Private Sub cbo_current_village_DropDown(sender As Object, e As EventArgs) Handles cboCurrentVillage.DropDown
        Bind.Village(cboCurrentVillage, cboCurrentCommune, cboCurrentDistrict, cboCurrentProvince)
    End Sub


    Private Function ValidateSibling() As Boolean

        Dim validateState As Boolean

        If txt_sibling_name.Text = "" Then
            txt_sibling_name.BackColor = Color.LavenderBlush
            txt_sibling_name.Focus()
            validateState = False
        Else
            validateState = True
        End If

        If cbo_sibling_sex.Text = "" Then
            cbo_sibling_sex.BackColor = Color.LavenderBlush
            cbo_sibling_sex.Focus()
            validateState = False
        Else
            validateState = True
        End If

        If txt_sibling_child_order.Text = "" Then
            txt_sibling_child_order.BackColor = Color.LavenderBlush
            txt_sibling_child_order.Focus()
            validateState = False
        Else
            validateState = True
        End If
        Return validateState
    End Function

    Private Sub lbl_sibling_save_Click(sender As Object, e As EventArgs) Handles lbl_sibling_save.Click
        idx = dgMain.SelectedCells(0).RowIndex.ToString()
        Try
            If txt_sibling_name.Text = "" Or cbo_sibling_sex.Text = "" Or txt_sibling_child_order.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                Call ValidateSibling()
                If ValidateSibling() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If

            obj.Insert("INSERT INTO dbo.TBS_STUDENT_SIBLING(STUDENT_ID,SIBLING_NAME,GENDER,SIBLING_DOB,CHILD_ORDER)VALUES(" & dgMain.SelectedCells(0).Value & ",N'" & txt_sibling_name.Text & "',N'" & cbo_sibling_sex.Text & "','" & dt_sibling_DOB.Text & "'," & txt_sibling_child_order.Text & ")")
            Call SelectStudent()
            dgMain.Rows(idx).Selected = True
            dgMain.CurrentCell = dgMain.SelectedCells(1)
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចបញ្ចូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
            Exit Sub
        End Try
    End Sub

    Private Sub txt_sibling_name_TextChanged(sender As Object, e As EventArgs) Handles txt_sibling_name.TextChanged
        txt_sibling_name.BackColor = Color.White
    End Sub

    Private Sub cbo_sibling_sex_TextChanged(sender As Object, e As EventArgs) Handles cbo_sibling_sex.TextChanged
        cbo_sibling_sex.BackColor = Color.White

    End Sub

    Private Sub txt_sibling_child_order_TextChanged(sender As Object, e As EventArgs) Handles txt_sibling_child_order.TextChanged
        txt_sibling_child_order.BackColor = Color.White
    End Sub

    Private Sub ClearSibling()
        txt_sibling_name.Clear()
        cbo_sibling_sex.Text = ""
        dt_sibling_DOB.Text = "1/1/1990"
        txt_sibling_child_order.Clear()

    End Sub

    Private Sub lbl_sibling_new_Click(sender As Object, e As EventArgs) Handles lblSiblingNew.Click
        Call ClearSibling()
        txt_sibling_name.Focus()
        lbl_sibling_update.Enabled = False
        lbl_sibling_delete.Enabled = False
        lbl_sibling_save.Enabled = True
    End Sub
    Private Sub SelectSibling()
        Try
            obj.BindDataGridView("SELECT RECORD_ID, STUDENT_ID,ROW_NUMBER() OVER(ORDER BY RECORD_ID desc) AS 'RowNum', SIBLING_NAME, GENDER, SIBLING_DOB, CHILD_ORDER FROM dbo.TBS_STUDENT_SIBLING WHERE STUDENT_ID=" & dgMain.SelectedCells(0).Value & "", dgSibling)
            Call SetTitleSibling()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetTitleSibling()
        dgSibling.Columns(0).Visible = False  'Record ID
        dgSibling.Columns(1).Visible = False 'Student ID



        dgSibling.Columns(2).HeaderText = "លរ"
        dgSibling.Columns(2).Width = 150

        dgSibling.Columns(3).HeaderText = "ឈ្មោះ"
        dgSibling.Columns(3).Width = 500

        dgSibling.Columns(4).HeaderText = "ភេទ"
        dgSibling.Columns(4).Width = 150
        dgSibling.Columns(5).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        dgSibling.Columns(5).Width = 300
        dgSibling.Columns(6).HeaderText = "ជាកូនទី"
        dgSibling.Columns(6).Width = 200



    End Sub

    Private Sub dg_sibling_SelectionChanged(sender As Object, e As EventArgs) Handles dgSibling.SelectionChanged


        Try
            'Call cbo_child_occupation_DropDown(sender, e)
            Call ClearSibling()

            If dgSibling.RowCount > 0 Then
                txt_sibling_name.Text = dgSibling.SelectedRows(0).Cells(3).Value.ToString
                cbo_sibling_sex.Text = dgSibling.SelectedRows(0).Cells(4).Value.ToString
                dt_sibling_DOB.Text = dgSibling.SelectedRows(0).Cells(5).Value.ToString
                txt_sibling_child_order.Text = dgSibling.SelectedRows(0).Cells(6).Value.ToString

                lbl_sibling_save.Enabled = False
                lbl_sibling_update.Enabled = True
                lbl_sibling_delete.Enabled = True
                lblSiblingNew.Enabled = True
            Else

                lbl_sibling_new_Click(sender, e)
            End If
        Catch ex As Exception
            'exception will fired
        End Try
    End Sub

    Private Sub lbl_sibling_update_Click(sender As Object, e As EventArgs) Handles lbl_sibling_update.Click

        Try
            If (dgSibling.Rows.Count > 0) Then
                Call obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    idx = dgSibling.SelectedCells(0).RowIndex.ToString()
                    If txt_sibling_name.Text = "" Or cbo_sibling_sex.Text = "" Or txt_sibling_child_order.Text = "" Then
                        obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                        Call ValidateSibling()
                        If ValidateSibling() = False Then
                            Exit Sub
                        End If
                        Exit Sub
                    End If

                    obj.Update("UPDATE dbo.TBS_STUDENT_SIBLING SET SIBLING_NAME = N'" & txt_sibling_name.Text & "',GENDER = N'" & cbo_sibling_sex.Text & "',SIBLING_DOB = '" & dt_sibling_DOB.Text & "',CHILD_ORDER =  " & txt_sibling_child_order.Text & "​ WHERE RECORD_ID =" & dgSibling.SelectedRows(0).Cells(0).Value & " AND STUDENT_ID =" & dgSibling.SelectedRows(0).Cells(1).Value & " AND SIBLING_NAME = N'" & dgSibling.SelectedRows(0).Cells(3).Value & "'")
                    Call SelectSibling()

                    dgSibling.Rows(idx).Selected = True
                    dgSibling.CurrentCell = dgSibling.SelectedCells(2)
                End If
            Else
                obj.ShowMsg("មិនមានព័ត៌មានដើម្បីកែប្រែនោះទេ !", FrmWarning, "")
                lbl_sibling_new_Click(sender, e)
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការកែប្រែព័ត៌មាននេះបាន!", FrmMessageError, "Error.wav")
        End Try

    End Sub

    Private Sub txt_sibling_child_order_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sibling_child_order.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub lbl_sibling_delete_Click(sender As Object, e As EventArgs) Handles lbl_sibling_delete.Click

        Try

            If (dgSibling.Rows.Count > 0) Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE FROM dbo.TBS_STUDENT_SIBLING  WHERE RECORD_ID =" & dgSibling.SelectedRows(0).Cells(0).Value & " AND STUDENT_ID =" & dgSibling.SelectedRows(0).Cells(1).Value & " AND SIBLING_NAME = N'" & dgSibling.SelectedRows(0).Cells(3).Value & "'")
                    Call SelectSibling()
                End If

            Else
                obj.ShowMsg("មិនមានព័ត៌មានដើម្បីលុបបានទេ !", FrmWarning, "")
                lbl_sibling_new_Click(sender, e)
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបានទេ!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub cbo_skill_DropDown(sender As Object, e As EventArgs) Handles cboSkill.DropDown
        Bind.Skill(cboSkill)
    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles lblSkillSave.Click
        Try
            If cboSkill.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                Call ValidateSkill()
                If ValidateSkill() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If
            obj.Insert("INSERT INTO dbo.TBS_STUDENT_SKILL " & vbCrLf &
"(STUDENT_ID,SKILL_ID,[DESCRIPTION],DATE_NOTE)VALUES" & vbCrLf &
"(" & dgMain.SelectedCells(0).Value & "," & cboSkill.SelectedValue & ",N'" & txt_skill_description.Text & "',GETDATE())")
            Call SelectSkill()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចបញ្ចូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
            Exit Sub
        End Try
    End Sub

    Private Function ValidateSkill() As Boolean

        Dim ValidateState As Boolean

        If cboSkill.Text = "" Then
            cboSkill.BackColor = Color.LavenderBlush
            cboSkill.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If



        Return ValidateState
    End Function

    Private Sub cbo_skill_TextChanged(sender As Object, e As EventArgs) Handles cboSkill.TextChanged
        cboSkill.BackColor = Color.White

    End Sub

    Private Sub lbl_skill_new_Click(sender As Object, e As EventArgs) Handles lblSkillNew.Click
        Call ClearSkill()
        cboSkill.Focus()
        lblSkillUpdate.Enabled = False
        lblSkillDelete.Enabled = False
        lblSkillSave.Enabled = True
    End Sub

    Private Sub ClearSkill()
        cboSkill.Text = ""
        txt_skill_description.Clear()
        dt_skill_date_note.Text = Date.Today
    End Sub

    Private Sub SelectSkill()
        Try
            obj.BindDataGridView("SELECT     S.RECORD_ID, S.STUDENT_ID, S.DATE_NOTE,ROW_NUMBER() OVER(ORDER BY S.RECORD_ID desc) AS 'RowNum', SK.SKILL_KH, S.DESCRIPTION,S.SKILL_ID" & vbCrLf &
"FROM         dbo.TBS_STUDENT_SKILL AS S INNER JOIN" & vbCrLf &
"                      dbo.TBL_SKILL AS SK ON S.SKILL_ID = SK.SKILL_ID WHERE S.STUDENT_ID = " & dgMain.SelectedCells(0).Value & "", dgSkill)
            Call SetTitleSkill()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetTitleSkill()
        dgSkill.Columns(0).Visible = False  'Record ID
        dgSkill.Columns(1).Visible = False 'Student ID
        dgSkill.Columns(2).Visible = False 'DateNote
        dgSkill.Columns(6).Visible = False 'SKILL_ID



        dgSkill.Columns(3).HeaderText = "លរ"
        dgSkill.Columns(3).Width = 150

        dgSkill.Columns(4).HeaderText = "ជំនាញ"
        dgSkill.Columns(4).Width = 300

        dgSkill.Columns(5).HeaderText = "មតិយោបល់"
        dgSkill.Columns(5).Width = 800




    End Sub

    Private Sub dg_skill_SelectionChanged(sender As Object, e As EventArgs) Handles dgSkill.SelectionChanged


        Try
            Call cbo_skill_DropDown(sender, e)
            Call ClearSkill()

            If dgSkill.RowCount > 0 Then
                cboSkill.Text = dgSkill.SelectedRows(0).Cells(4).Value.ToString
                txt_skill_description.Text = dgSkill.SelectedRows(0).Cells(5).Value.ToString
                dt_skill_date_note.Text = dgSkill.SelectedRows(0).Cells(2).Value.ToString

                lblSkillUpdate.Enabled = True
                lblSkillDelete.Enabled = True
                lblSkillSave.Enabled = False
                lblSkillNew.Enabled = True
            Else
                Call lbl_skill_new_Click(sender, e)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_skill_update_Click(sender As Object, e As EventArgs) Handles lblSkillUpdate.Click
        Try
            If (dgSkill.Rows.Count > 0) Then

                Call obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, _ShowMessageSound)

                If USER_CLICK_OK = True Then
                    idx = dgSkill.SelectedCells(0).RowIndex.ToString()

                    If cboSkill.Text = "" Then
                        obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                        Call ValidateSkill()
                        If ValidateSkill() = False Then
                            Exit Sub
                        End If
                        Exit Sub
                    End If

                    Dim skillID As String = obj.GetID("SELECT SKILL_ID FROM dbo.TBL_SKILL WHERE SKILL_KH = N'" & cboSkill.Text & "'")
                    obj.Update("UPDATE dbo.TBS_STUDENT_SKILL SET SKILL_ID =" & skillID & " ,DESCRIPTION = N'" & txt_skill_description.Text & "' WHERE RECORD_ID =" & dgSkill.SelectedCells(0).Value & " AND STUDENT_ID =" & dgSkill.SelectedCells(1).Value & " AND SKILL_ID =" & dgSkill.SelectedCells(6).Value & " ")

                    Call SelectSkill()
                    dgSkill.Rows(idx).Selected = True
                    dgSkill.CurrentCell = dgSkill.SelectedCells(3)
                End If
            Else
                obj.ShowMsg("មិនមានព័ត៌មានដើម្បីកែប្រែនោះទេ !", FrmWarning, "")
                lbl_skill_new_Click(sender, e)
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការកែប្រែព័ត៌មាននេះបាន!", FrmMessageError, _ErrorSound)
        End Try

    End Sub

    Private Sub lbl_skill_delete_Click(sender As Object, e As EventArgs) Handles lblSkillDelete.Click
        Try
            If (dgSkill.Rows.Count > 0) Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE FROM dbo.TBS_STUDENT_SKILL WHERE RECORD_ID =" & dgSkill.SelectedCells(0).Value & " AND STUDENT_ID =" & dgSkill.SelectedCells(1).Value & " AND SKILL_ID =" & dgSkill.SelectedCells(6).Value & "")
                    Call SelectSkill()
                End If

            Else
                obj.ShowMsg("មិនមានព័ត៌មានដើម្បីលុបបានទេ !", FrmWarning, "")
                lbl_skill_new_Click(sender, e)
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបានទេ!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub cbo_lag_DropDown(sender As Object, e As EventArgs) Handles cboLangugue.DropDown
        Bind.Langugue(cboLangugue)
    End Sub

    Private Sub lbl_lang_save_Click(sender As Object, e As EventArgs) Handles lblLangSave.Click
        Try
            If cboLangugue.Text = "" Or cbo_read.Text = "" Or cbo_speak.Text = "" Or cbo_write.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                Call ValidateLang()
                If ValidateLang() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If

            For Each row As DataGridViewRow In dgLanguage.Rows
                If cboLangugue.SelectedValue = row.Cells(2).Value Then
                    obj.ShowMsg(cboLangugue.Text + " បានបញ្ចូលរួចរាល់ !", FrmMessageError, "Error.wav")
                    Exit Sub
                End If
            Next


            obj.Insert("INSERT INTO dbo.TBS_STUDENT_LANGUAGE " & vbCrLf &
"(STUDENT_ID,LANGUAGE_ID,READING,SPEAKING,WRITING)VALUES" & vbCrLf &
"(" & dgMain.SelectedCells(0).Value & "," & cboLangugue.SelectedValue & ",N'" & cbo_read.Text & "',N'" & cbo_speak.Text & "',N'" & cbo_write.Text & "')")
            Call SelectLangugue()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចបញ្ចូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
            Exit Sub
        End Try
    End Sub

    Private Function ValidateLang() As Boolean

        Dim ValidateState As Boolean

        If cboLangugue.Text = "" Then
            cboLangugue.BackColor = Color.LavenderBlush
            cboLangugue.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        If cbo_write.Text = "" Then
            cbo_write.BackColor = Color.LavenderBlush
            cbo_write.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        If cbo_speak.Text = "" Then
            cbo_speak.BackColor = Color.LavenderBlush
            cbo_speak.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If

        If cbo_read.Text = "" Then
            cbo_read.BackColor = Color.LavenderBlush
            cbo_read.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If

        Return ValidateState
    End Function

    Private Sub SelectLangugue()
        Try
            obj.BindDataGridView("SELECT     S.RECOR_ID, S.STUDENT_ID, S.LANGUAGE_ID,ROW_NUMBER() OVER(ORDER BY S.RECOR_ID desc) AS 'RowNum', L.LANGUAGE_KH, S.READING, S.SPEAKING, S.WRITING" & vbCrLf &
"FROM         dbo.TBS_STUDENT_LANGUAGE AS S INNER JOIN" & vbCrLf &
"                      dbo.TBL_LANGUAGE AS L ON S.LANGUAGE_ID = L.LANGUAGE_ID WHERE   S.STUDENT_ID = " & dgMain.SelectedCells(0).Value & "", dgLanguage)
            Call SetTitleLang()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetTitleLang()
        dgLanguage.Columns(0).Visible = False  'Record ID
        dgLanguage.Columns(1).Visible = False 'Student ID
        dgLanguage.Columns(2).Visible = False 'LangID

        dgLanguage.Columns(3).HeaderText = "លរ"
        dgLanguage.Columns(3).Width = 50

        dgLanguage.Columns(4).HeaderText = "ភាសា"
        dgLanguage.Columns(4).Width = 350

        dgLanguage.Columns(5).HeaderText = "ការអាន"
        dgLanguage.Columns(5).Width = 130

        dgLanguage.Columns(6).HeaderText = "ការនិយាយ"
        dgLanguage.Columns(6).Width = 130

        dgLanguage.Columns(7).HeaderText = "ការសរសេរ"
        dgLanguage.Columns(7).Width = 130




    End Sub
    Private Sub SetTitleStuStudyInfo()
        dgStudyInfo.Columns(0).Visible = False  'Record ID
        dgStudyInfo.Columns(1).HeaderText = "លរ"
        dgStudyInfo.Columns(1).Width = 50
        dgStudyInfo.Columns(2).Visible = False 'student ID
        dgStudyInfo.Columns(3).HeaderText = "ឆ្នាំសិក្សា"
        dgStudyInfo.Columns(3).Width = 120
        dgStudyInfo.Columns(4).HeaderText = "ថ្នាក់"
        dgStudyInfo.Columns(4).Width = 100
        dgStudyInfo.Columns(5).HeaderText = "ឆ្នាំសិក្សាចាស់"
        dgStudyInfo.Columns(5).Width = 120
        dgStudyInfo.Columns(6).HeaderText = "ថ្នាក់ចាស់"
        dgStudyInfo.Columns(6).Width = 100
        dgStudyInfo.Columns(7).HeaderText = "ស្ថានភាពនៃការសិក្សា"
        dgStudyInfo.Columns(7).Width = 180
        dgStudyInfo.Columns(8).HeaderText = "ផ្សេងៗ"
        dgStudyInfo.Columns(8).Width = 700
    End Sub

    Public Sub ClearLangugue()
        cboLangugue.Text = ""
        cbo_read.Text = ""
        cbo_write.Text = ""
        cbo_speak.Text = ""
    End Sub

    Private Sub lbl_lag_new_Click(sender As Object, e As EventArgs) Handles lblLangNew.Click
        Call ClearLangugue()
        cboLangugue.Focus()
        lblLangUpdate.Enabled = False
        lblLangDelete.Enabled = False
        lblLangSave.Enabled = True
    End Sub

    Private Sub dg_language_SelectionChanged(sender As Object, e As EventArgs) Handles dgLanguage.SelectionChanged
        Try
            Call cbo_lag_DropDown(sender, e)
            Call ClearLangugue()

            If dgLanguage.RowCount > 0 Then

                cboLangugue.Text = dgLanguage.SelectedRows(0).Cells(4).Value.ToString
                cbo_write.Text = dgLanguage.SelectedRows(0).Cells(5).Value.ToString
                cbo_speak.Text = dgLanguage.SelectedRows(0).Cells(6).Value.ToString
                cbo_read.Text = dgLanguage.SelectedRows(0).Cells(7).Value.ToString


                lblLangUpdate.Enabled = True
                lblLangDelete.Enabled = True
                lblLangSave.Enabled = False
                lblLangNew.Enabled = True
            Else
                Call lbl_skill_new_Click(sender, e)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_lang_update_Click(sender As Object, e As EventArgs) Handles lblLangUpdate.Click
        Try
            If (dgLanguage.Rows.Count > 0) Then

                Call obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")

                If USER_CLICK_OK = True Then
                    idx = dgLanguage.SelectedCells(0).RowIndex.ToString()

                    If cboLangugue.Text = "" Or cbo_read.Text = "" Or cbo_speak.Text = "" Or cbo_write.Text = "" Then
                        obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                        Call ValidateLang()
                        If ValidateLang() = False Then
                            Exit Sub
                        End If
                        Exit Sub
                    End If

                    Dim langugueID As String = obj.GetID("SELECT LANGUAGE_ID FROM dbo.TBL_LANGUAGE WHERE LANGUAGE_KH = N'" & cboLangugue.Text & "'")
                    obj.Update("UPDATE dbo.TBS_STUDENT_LANGUAGE SET  LANGUAGE_ID =" & langugueID & " ,READING = N'" & cbo_read.Text & "',SPEAKING = N'" & cbo_speak.Text & "',WRITING = N'" & cbo_write.Text & "' WHERE RECOR_ID = " & dgLanguage.SelectedCells(0).Value & " AND STUDENT_ID =" & dgLanguage.SelectedCells(1).Value & " AND LANGUAGE_ID =" & dgLanguage.SelectedCells(2).Value & " ")
                    Call SelectLangugue()

                    dgLanguage.Rows(idx).Selected = True
                    dgLanguage.CurrentCell = dgLanguage.SelectedCells(3)
                    USER_CLICK_OK = False
                End If

            Else
                obj.ShowMsg("មិនមានព័ត៌មានដើម្បីកែប្រែនោះទេ !", FrmWarning, "")
                lbl_lag_new_Click(sender, e)
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការកែប្រែព័ត៌មាននេះបាន!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub lbl_lang_delete_Click(sender As Object, e As EventArgs) Handles lblLangDelete.Click
        Try
            If (dgLanguage.Rows.Count > 0) Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("DELETE FROM dbo.TBS_STUDENT_LANGUAGE WHERE RECOR_ID = " & dgLanguage.SelectedCells(0).Value & " AND STUDENT_ID =" & dgLanguage.SelectedCells(1).Value & " AND LANGUAGE_ID =" & dgLanguage.SelectedCells(2).Value & "")
                    Call SelectLangugue()
                End If

            Else
                obj.ShowMsg("មិនមានព័ត៌មានដើម្បីលុបបានទេ !", FrmWarning, "")
                lbl_lag_new_Click(sender, e)
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការលុបព័ត៌មាននេះបានទេ!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub HoverStyle(ByVal lbl As Label)
        lbl.ForeColor = Color.Red
    End Sub
    Private Sub LeaveStyle(ByVal lbl As Label)
        lbl.ForeColor = Color.MediumBlue
    End Sub



    Private Sub lbl_lang_delete_MouseHover(sender As Object, e As EventArgs) Handles lblLangDelete.MouseHover
        Call HoverStyle(lblLangDelete)
    End Sub

    Private Sub lbl_lang_delete_MouseLeave(sender As Object, e As EventArgs) Handles lblLangDelete.MouseLeave
        Call LeaveStyle(lblLangDelete)
    End Sub

    Private Sub lbl_lang_update_MouseHover(sender As Object, e As EventArgs) Handles lblLangUpdate.MouseHover
        Call HoverStyle(lblLangUpdate)
    End Sub

    Private Sub lbl_lang_update_MouseLeave(sender As Object, e As EventArgs) Handles lblLangUpdate.MouseLeave
        Call LeaveStyle(lblLangUpdate)
    End Sub

    Private Sub lbl_lang_save_MouseHover(sender As Object, e As EventArgs) Handles lblLangSave.MouseHover
        Call HoverStyle(lblLangSave)

    End Sub

    Private Sub lbl_lang_save_MouseLeave(sender As Object, e As EventArgs) Handles lblLangSave.MouseLeave
        Call LeaveStyle(lblLangSave)

    End Sub

    Private Sub lbl_lag_new_MouseHover(sender As Object, e As EventArgs) Handles lblLangNew.MouseHover
        Call HoverStyle(lblLangNew)
    End Sub

    Private Sub lbl_lag_new_MouseLeave(sender As Object, e As EventArgs) Handles lblLangNew.MouseLeave
        Call LeaveStyle(lblLangNew)
    End Sub

    Private Sub cbo_write_TextChanged(sender As Object, e As EventArgs) Handles cbo_write.TextChanged
        cbo_write.BackColor = Color.White
    End Sub

    Private Sub cbo_speak_TextChanged(sender As Object, e As EventArgs) Handles cbo_speak.TextChanged
        cbo_speak.BackColor = Color.White
    End Sub

    Private Sub cbo_read_TextChanged(sender As Object, e As EventArgs) Handles cbo_read.TextChanged
        cbo_read.BackColor = Color.White

    End Sub

    Private Sub cbo_lag_TextChanged(sender As Object, e As EventArgs) Handles cboLangugue.TextChanged
        cboLangugue.BackColor = Color.White
    End Sub

    Private Sub lbl_skill_new_MouseHover(sender As Object, e As EventArgs) Handles lblSkillNew.MouseHover
        Call HoverStyle(lblSkillNew)
    End Sub

    Private Sub lbl_skill_new_MouseLeave(sender As Object, e As EventArgs) Handles lblSkillNew.MouseLeave
        Call LeaveStyle(lblSkillNew)

    End Sub

    Private Sub lbl_skill_save_MouseHover(sender As Object, e As EventArgs) Handles lblSkillSave.MouseHover
        Call HoverStyle(lblSkillSave)
    End Sub

    Private Sub lbl_skill_save_MouseLeave(sender As Object, e As EventArgs) Handles lblSkillSave.MouseLeave
        Call LeaveStyle(lblSkillSave)
    End Sub

    Private Sub lbl_skill_update_MouseHover(sender As Object, e As EventArgs) Handles lblSkillUpdate.MouseHover
        Call HoverStyle(lblSkillUpdate)
    End Sub

    Private Sub lbl_skill_update_MouseLeave(sender As Object, e As EventArgs) Handles lblSkillUpdate.MouseLeave
        Call LeaveStyle(lblSkillUpdate)

    End Sub

    Private Sub lbl_skill_delete_MouseHover(sender As Object, e As EventArgs) Handles lblSkillDelete.MouseHover
        Call HoverStyle(lblSkillDelete)
    End Sub

    Private Sub lbl_skill_delete_MouseLeave(sender As Object, e As EventArgs) Handles lblSkillDelete.MouseLeave
        Call LeaveStyle(lblSkillDelete)

    End Sub

    Private Sub lbl_sibling_new_MouseHover(sender As Object, e As EventArgs) Handles lblSiblingNew.MouseHover
        Call HoverStyle(lblSiblingNew)
    End Sub

    Private Sub lbl_sibling_new_MouseLeave(sender As Object, e As EventArgs) Handles lblSiblingNew.MouseLeave
        Call LeaveStyle(lblSiblingNew)

    End Sub

    Private Sub lbl_sibling_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_sibling_save.MouseHover
        Call HoverStyle(lbl_sibling_save)
    End Sub

    Private Sub lbl_sibling_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_sibling_save.MouseLeave
        Call LeaveStyle(lbl_sibling_save)
    End Sub

    Private Sub lbl_sibling_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_sibling_update.MouseHover
        Call HoverStyle(lbl_sibling_update)
    End Sub

    Private Sub lbl_sibling_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_sibling_update.MouseLeave
        Call LeaveStyle(lbl_sibling_update)
    End Sub

    Private Sub lbl_sibling_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_sibling_delete.MouseHover
        Call HoverStyle(lbl_sibling_delete)
    End Sub

    Private Sub lbl_sibling_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_sibling_delete.MouseLeave
        Call LeaveStyle(lbl_sibling_delete)
    End Sub

    Private Sub lbl_address_new_MouseHover(sender As Object, e As EventArgs) Handles lblAddressNew.MouseHover
        Call HoverStyle(lblAddressNew)
    End Sub

    Private Sub lbl_address_new_MouseLeave(sender As Object, e As EventArgs) Handles lblAddressNew.MouseLeave
        Call LeaveStyle(lblAddressNew)
    End Sub

    Private Sub lbl_address_save_MouseHover(sender As Object, e As EventArgs) Handles lblAddressSave.MouseHover
        Call HoverStyle(lblAddressSave)
    End Sub

    Private Sub lbl_address_save_MouseLeave(sender As Object, e As EventArgs) Handles lblAddressSave.MouseLeave
        Call LeaveStyle(lblAddressSave)
    End Sub

    Private Sub lbl_gua_new_MouseHover(sender As Object, e As EventArgs) Handles lblNewFamily.MouseHover
        Call HoverStyle(lblNewFamily)

    End Sub

    Private Sub lbl_gua_new_MouseLeave(sender As Object, e As EventArgs) Handles lblNewFamily.MouseLeave
        Call LeaveStyle(lblNewFamily)
    End Sub

    Private Sub lbl_save_gua_MouseHover(sender As Object, e As EventArgs) Handles lblFamilySave.MouseHover
        Call HoverStyle(lblFamilySave)

    End Sub

    Private Sub lbl_save_gua_MouseLeave(sender As Object, e As EventArgs) Handles lblFamilySave.MouseLeave
        Call LeaveStyle(lblFamilySave)

    End Sub

    Private Sub btn_stu_new_MouseHover(sender As Object, e As EventArgs) Handles lblStuNew.MouseHover
        Call HoverStyle(lblStuNew)

    End Sub

    Private Sub btn_stu_new_MouseLeave(sender As Object, e As EventArgs) Handles lblStuNew.MouseLeave
        Call LeaveStyle(lblStuNew)
    End Sub

    Private Sub btn_stu_save_MouseHover(sender As Object, e As EventArgs) Handles lblStuSave.MouseHover
        Call HoverStyle(lblStuSave)

    End Sub

    Private Sub btn_stu_save_MouseLeave(sender As Object, e As EventArgs) Handles lblStuSave.MouseLeave
        Call LeaveStyle(lblStuSave)

    End Sub

    Private Sub btn_stu_update_MouseHover(sender As Object, e As EventArgs) Handles lblStuUpdate.MouseHover
        Call HoverStyle(lblStuUpdate)

    End Sub

    Private Sub btn_stu_update_MouseLeave(sender As Object, e As EventArgs) Handles lblStuUpdate.MouseLeave
        Call LeaveStyle(lblStuUpdate)

    End Sub




    Private Sub lbl_adv_search_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_adv_search.LinkClicked
        PanelAdvSearch.BringToFront()
        Try
            If lbl_adv_search.Text = "ស្វែងរកកម្រិតខ្ពស់ >>>" Then
                Do While PanelAdvSearch.Width < 1111
                    PanelAdvSearch.Width += 4
                    Application.DoEvents()
                Loop
                PanelAdvSearch.Width = 1111
                lbl_adv_search.Text = "ស្វែងរកកម្រិតខ្ពស់ <<<"
                txt_ad_search.Focus()
            Else
                Do While PanelAdvSearch.Width > 0
                    PanelAdvSearch.Width -= 4
                    Application.DoEvents()
                Loop
                PanelAdvSearch.Width = 0
                lbl_adv_search.Text = "ស្វែងរកកម្រិតខ្ពស់ >>>"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_staff_Code_DropDown(sender As Object, e As EventArgs) Handles cboSearchCode.DropDown
        Try
            cboSearchName.Text = ""
            cboSearchYearStudy.Text = ""
            cboSearchClass.Text = ""

            obj.BindComboBox("SELECT STUDENT_ID,STUDENT_CODE FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_STATUS_ID IN(1,5) AND STUDENT_CODE IS NOT NULL", cboSearchCode, "STUDENT_CODE", "STUDENT_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_search_code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchCode.SelectedIndexChanged
        Try
            obj.BindDataGridView(studentSelectionSql + " WHERE S.STUDENT_ID = " & cboSearchCode.SelectedValue & "", dgMain)
            SetDgMainHeader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_seach_name_DropDown(sender As Object, e As EventArgs) Handles cboSearchName.DropDown
        Try
            cboSearchClass.Text = ""
            cboSearchCode.Text = ""
            cboSearchClass.Text = ""

            obj.BindComboBox("SELECT STUDENT_ID,SNAME_KH FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_STATUS_ID IN( " & StuStatusStudying & "," & StuStatusNew & ")", cboSearchName, "SNAME_KH", "STUDENT_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_seach_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchName.SelectedIndexChanged
        Try
            obj.BindDataGridView(studentSelectionSql + " WHERE S.STUDENT_ID = " & cboSearchName.SelectedValue & "", dgMain)
            SetDgMainHeader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox4_DropDown(sender As Object, e As EventArgs) Handles cboSearchYearStudy.DropDown
        Try
            cboSearchCode.Text = ""
            cboSearchName.Text = ""
            cboSearchClass.Text = ""

            obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboSearchYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_search_class_DropDown(sender As Object, e As EventArgs) Handles cboSearchClass.DropDown
        cboSearchCode.Text = ""
        cboSearchName.Text = ""

        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboSearchClass, "CLASS_LETTER", "CLASS_ID")

    End Sub

    Private Sub cbo_current_class_DropDown(sender As Object, e As EventArgs) Handles cboStuCurrentClass.DropDown
        Bind.Classes(cboStuCurrentClass)
    End Sub

    Private Sub cbo_search_class_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchClass.SelectedIndexChanged

        'If cboSearchYearStudy.Text = "" Then
        '    obj.ShowMsg("សូមបញ្ចូលឆ្នាំសិក្សាជាមុន", frm_warning, "Windows Ding.wav")
        '    cboSearchYearStudy.BackColor = Color.LavenderBlush
        '    cboSearchYearStudy.Focus()
        '    Exit Sub
        'End If

        'Try
        '    obj.Bind_DataGrid(studentSelectionStr + " WHERE S.STUDENT_STATUS_ID = " & StuStatusStudying & " AND STUDY_INFO.YEAR_STUDY = N'" & cboSearchYearStudy.Text & "' AND S.CLASS_ID = " & cboSearchClass.SelectedValue & "", dg_main)
        '    SetTitleStudent()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub lbl_display_all_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        cboSearchCode.Text = ""
        cboSearchName.Text = ""
        cboSearchYearStudy.Text = ""
        cboSearchClass.Text = ""


        Application.DoEvents()
        Call SelectStudent()

    End Sub

    Private Sub txt_ad_search_TextChanged(sender As Object, e As EventArgs) Handles txt_ad_search.TextChanged
        Try
            obj.BindDataGridView(studentSelectionSql + " WHERE  ISNULL(S.STUDENT_ID_SCHOOL,'') + ISNULL(S.STUDENT_CODE,'') + ISNULL(S.SNAME_KH,'') + ISNULL(S.SNAME_LATIN,'') + ISNULL(S.GENDER,'') + ISNULL(CAST(S.DOB AS NVARCHAR(50)),'') + ISNULL(H.HEALTHY_KH,'') + ISNULL(S.S_PHONE_LINE_1,'') + ISNULL(S.S_PHONE_LINE_2,'') + ISNULL(S.EMAIL_1,'') + ISNULL(CAST(S.JOIN_SCHOOL_DATE AS NVARCHAR(50)),'')+ ISNULL (S.FATHER_NAME ,'') + ISNULL((SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE  OCCUPATION_ID = FATHER_OCCUPATION_ID),'') + ISNULL(S.FATHER_PHONE_LINE_1,'') + ISNULL(S.MOTHER_NAME,'') + ISNULL((SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_ID = MOTHER_OCCUPATION_ID),'') + ISNULL(S.MOTHER_PHONE_LINE_1,'') + ISNULL(S.GUARDIAN_NAME,'') + ISNULL((SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_ID = S.GUARDIAN_OCCUPATION_ID),'') + ISNULL(S.GUARDIAN_PHONE_LINE_1,'') + S.FIRST_YEAR_STUDY + SS.STUDENT_STATUS_KH + CL.CLASS_LETTER LIKE N'%" & txt_ad_search.Text & "%'", dgMain)
            SetDgMainHeader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LBL_BATCH_Click(sender As Object, e As EventArgs) Handles LBL_BATCH.Click
        frm_batchs.ShowDialog()
    End Sub

    Private Sub lbl_heathy_Click(sender As Object, e As EventArgs) Handles lbl_heathy.Click
        frm_heathy.ShowDialog()
    End Sub

    Private Sub lbl_student_status_Click(sender As Object, e As EventArgs) Handles lbl_student_status.Click
        frm_student_status.ShowDialog()
    End Sub

    Private Sub lbl_lang_Click(sender As Object, e As EventArgs) Handles lbl_lang.Click
        frm_langugae.ShowDialog()
    End Sub

    Private Sub lbl_skill_Click(sender As Object, e As EventArgs) Handles lbl_skill.Click
        frm_skill.ShowDialog()
    End Sub

    Private Sub lbl_check_school_code_Click(sender As Object, e As EventArgs) Handles lbl_check_school_code.Click
        Call CheckSchoolCode()
    End Sub



    Private Function CheckSchoolCode() As Boolean
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT STUDENT_ID_SCHOOL FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_ID_SCHOOL = N'" & txtStuSchoolCode.Text & "'", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Call obj.ShowMsg("លេខកូដនេះមានរួចរាល់", FrmWarning, "Error.wav")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
        End Try
        Return CheckSchoolCode
    End Function

    Private Function CheckSchoolCode_update() As Boolean
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT STUDENT_ID_SCHOOL FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_ID_SCHOOL = N'" & txtStuSchoolCode.Text & "'", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dgMain.SelectedCells(2).Value = txtStuSchoolCode.Text Then
                Return False
            Else
                If dt.Rows.Count > 0 Then
                    Call obj.ShowMsg("លេខកូដនេះមានរួចរាល់", FrmWarning, "Error.wav")
                    Return True
                Else
                    Return False
                End If
            End If


        Catch ex As Exception
        End Try
        Return CheckSchoolCode_update
    End Function

    Private Sub cbo_current_class_TextChanged(sender As Object, e As EventArgs) Handles cboStuCurrentClass.TextChanged
        cboStuCurrentClass.BackColor = Color.White

    End Sub

    Private Function CheckStudentCode() As Boolean
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT STUDENT_CODE FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_CODE = N'" & txtStuCode.Text & "'", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Call obj.ShowMsg("លេខកូដនេះមានរួចរាល់", FrmWarning, "Error.wav")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
        End Try
        Return CheckStudentCode
    End Function

    Private Sub lbl_check_student_code_Click(sender As Object, e As EventArgs) Handles lbl_check_student_code.Click
        Call CheckStudentCode()
    End Sub


    Private Function CheckStudentCode_update() As Boolean
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT STUDENT_CODE FROM dbo.TBS_STUDENT_INFO WHERE STUDENT_CODE = N'" & txtStuCode.Text & "'", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dgMain.SelectedCells(3).Value = txtStuCode.Text Then
                Return False
            Else
                If dt.Rows.Count > 0 Then
                    Call obj.ShowMsg("លេខកូដនេះមានរួចរាល់", FrmWarning, "Error.wav")
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
        End Try
        Return CheckStudentCode_update
    End Function

    Private Sub lbl_year_study_Click(sender As Object, e As EventArgs) Handles lbl_year_study.Click
        frm_year_study.ShowDialog()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        frm_class.ShowDialog()
    End Sub


    Private Sub cbo_search_year_study_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchYearStudy.SelectedIndexChanged
        'cboSearchYearStudy.BackColor = Color.White
        'Try
        '    obj.Bind_DataGrid(studentSelectionStr + " INNER JOIN dbo.TBS_STUDENT_STUDY_INFO AS S_INFO ON S.STUDENT_ID = S_INFO.STUDENT_ID WHERE S_INFO.YEAR_STUDY = N'" & cboSearchYearStudy.Text & "' AND S.STUDENT_STATUS_ID = " & StuStatusStudying & "", dg_main)
        '    SetTitleStudent()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub



    Private Sub CalculateSubling()
        txtStuTotalSibling.Text = ConvertToDInt(txtStuNumBoy.Text) + ConvertToDInt(txtStuNumGirl.Text) + 1
    End Sub

    Private Sub txt_stu_num_boy_TextChanged(sender As Object, e As EventArgs) Handles txtStuNumBoy.TextChanged
        CalculateSubling()
    End Sub

    Private Sub txt_stu_num_girl_TextChanged(sender As Object, e As EventArgs) Handles txtStuNumGirl.TextChanged
        CalculateSubling()
    End Sub

    Private Sub SelectStuStudyInfo()
        Try

            sql = "SELECT     I.RECORD_ID,ROW_NUMBER() OVER(ORDER BY I.RECORD_ID DESC) AS 'ROW_NUM', I.STUDENT_ID, I.YEAR_STUDY, C.CLASS_LETTER, I.YEAR_STUDY_OLD, I.CLASS_OLD, X.STUDY_INFO_STATUS_KH,I.REMARK" & vbCrLf &
"FROM         dbo.TBS_STUDENT_INFO AS S INNER JOIN" & vbCrLf &
"                      dbo.TBS_STUDENT_STUDY_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN" & vbCrLf &
"                      dbo.TBS_CLASS AS C ON I.CLASS_ID = C.CLASS_ID INNER JOIN" & vbCrLf &
"                      dbo.TBS_STUDENT_STUDY_INFO_STATUS AS X ON I.STUDY_INFO_STATUS_ID = X.STUDY_INFO_STATUS_ID" & vbCrLf &
"                      WHERE I.STUDENT_ID = " & dgMain.SelectedRows(0).Cells(0).Value & ""
            obj.BindDataGridView(sql, dgStudyInfo)

            Call SetTitleStuStudyInfo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblStuStudySearch_Click(sender As Object, e As EventArgs) Handles lblStuStudySearch.Click
        Try

            sql = "SELECT     I.RECORD_ID,ROW_NUMBER() OVER(ORDER BY I.RECORD_ID DESC) AS 'ROW_NUM', I.STUDENT_ID, I.YEAR_STUDY, C.CLASS_LETTER, I.YEAR_STUDY_OLD, I.CLASS_OLD, X.STUDY_INFO_STATUS_KH,I.REMARK" & vbCrLf &
"FROM         dbo.TBS_STUDENT_INFO AS S INNER JOIN" & vbCrLf &
"                      dbo.TBS_STUDENT_STUDY_INFO AS I ON S.STUDENT_ID = I.STUDENT_ID INNER JOIN" & vbCrLf &
"                      dbo.TBS_CLASS AS C ON I.CLASS_ID = C.CLASS_ID INNER JOIN" & vbCrLf &
"                      dbo.TBS_STUDENT_STUDY_INFO_STATUS AS X ON I.STUDY_INFO_STATUS_ID = X.STUDY_INFO_STATUS_ID" & vbCrLf &
"                      WHERE I.STUDENT_ID = " & dgMain.SelectedRows(0).Cells(0).Value & " AND I.YEAR_STUDY + C.CLASS_LETTER + ISNULL(I.YEAR_STUDY_OLD,'') + ISNULL(I.CLASS_OLD,'') LIKE N'%" & txtStudentStudySearch.Text & "%'  "
            obj.BindDataGridView(sql, dgStudyInfo)

            Call SetTitleStuStudyInfo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblStudentStudyDisplayAll_Click(sender As Object, e As EventArgs) Handles lblStudentStudyDisplayAll.Click
        txtStudentStudySearch.Clear()
        Call SelectStuStudyInfo()
    End Sub

    Private Sub lblStuStudySearch_MouseHover(sender As Object, e As EventArgs) Handles lblStuStudySearch.MouseHover
        lblStuStudySearch.ForeColor = Color.Red
    End Sub

    Private Sub lblStuStudySearch_MouseLeave(sender As Object, e As EventArgs) Handles lblStuStudySearch.MouseLeave
        lblStuStudySearch.ForeColor = Color.MediumBlue
    End Sub

    Private Sub lblStudentStudyDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblStudentStudyDisplayAll.MouseHover
        lblStudentStudyDisplayAll.ForeColor = Color.Red
    End Sub

    Private Sub lblStudentStudyDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblStudentStudyDisplayAll.MouseLeave
        lblStudentStudyDisplayAll.ForeColor = Color.MediumBlue
    End Sub

    Private Sub lbl_staff_list_Click(sender As Object, e As EventArgs) Handles lblPrintStudentList.Click
        Try
            If (Validation.IsEmptyControl(cboSearchYearStudy, "សូមជ្រើសរើសឆ្នាំសិក្សាជាមុន")) Then Exit Sub
            FrmStudentReport.ShowDialog()
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
    Private Sub CountSearchResult()
        Try
            lblSearchResult.Text = dgMain.Rows.Count.ToString + " អ្នក"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            lblSearchResult.Text = "0 នាក់"
        End Try
    End Sub

    Private Sub dgMain_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgMain.RowPrePaint
        Try
            Call CountSearchResult()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lbl_adv_search_MouseHover(sender As Object, e As EventArgs) Handles lbl_adv_search.MouseHover
        t.Hover(lbl_adv_search)
    End Sub

    Private Sub lbl_adv_search_MouseLeave(sender As Object, e As EventArgs) Handles lbl_adv_search.MouseLeave
        t.Leave(lbl_adv_search)
    End Sub

    Private Sub lblClearTxtAdSearch_Click(sender As Object, e As EventArgs) Handles lblClearTxtAdSearch.Click
        txt_ad_search.Clear()
        txt_ad_search.Focus()
    End Sub

    Private Sub lblClearTxtAdSearch_MouseHover(sender As Object, e As EventArgs) Handles lblClearTxtAdSearch.MouseHover
        t.Hover(lblClearTxtAdSearch)
    End Sub

    Private Sub lblClearTxtAdSearch_MouseLeave(sender As Object, e As EventArgs) Handles lblClearTxtAdSearch.MouseLeave
        t.Leave(lblClearTxtAdSearch)
    End Sub

    Private Sub cboStuGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboStuGender.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbStuDOB_CheckedChanged(sender As Object, e As EventArgs) Handles cbStuDOB.CheckedChanged
        Try
            If (cbStuDOB.Checked = True) Then
                dtStuDOB.Text = "1/1/1996"
                dtStuDOB.Enabled = True
            Else
                dtStuDOB.Text = "1/1/1900"
                dtStuDOB.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbo_skill_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSkill.KeyPress
        e.Handled = True
    End Sub

    Private Sub dgLanguage_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLanguage.CellClick
        dg_language_SelectionChanged(sender, e)
    End Sub

    Private Sub CheckIfHasDOB()
        Try
            If (dgMain.SelectedCells(7).Value IsNot DBNull.Value) Then 'Prevent Null from Database
                If (dgMain.SelectedCells(7).Value <> "1/1/1900") Then
                    cbStuDOB.Checked = True
                    dtStuDOB.Value = dgMain.SelectedCells(7).Value
                Else
                    cbStuDOB.Checked = False
                End If
            Else
                cbStuDOB.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CheckIfHasJoinSchoolDate()
        Try
            If (dgMain.SelectedCells(18).Value IsNot DBNull.Value) Then 'Prevent Null from Database
                If (dgMain.SelectedCells(18).Value <> "1/1/1900") Then
                    cbStuJoinDate.Checked = True
                    dtStuJoinSchoolDate.Value = dgMain.SelectedCells(18).Value
                Else
                    cbStuJoinDate.Checked = False
                End If
            Else
                cbStuJoinDate.Checked = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbStuJoinDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbStuJoinDate.CheckedChanged
        Try
            If (cbStuJoinDate.Checked = True) Then
                dtStuJoinSchoolDate.Text = Date.Today
                dtStuJoinSchoolDate.Enabled = True
            Else
                dtStuJoinSchoolDate.Text = "1/1/1900"
                dtStuJoinSchoolDate.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblPrintStudentList_MouseHover(sender As Object, e As EventArgs) Handles lblPrintStudentList.MouseHover
        t.Hover(lblPrintStudentList)
    End Sub

    Private Sub lblPrintStudentList_MouseLeave(sender As Object, e As EventArgs) Handles lblPrintStudentList.MouseLeave
        t.Leave(lblPrintStudentList)
    End Sub

    Private Sub lblAddressSave_Click(sender As Object, e As EventArgs) Handles lblAddressSave.Click
        Try
            Dim sql = "UPDATE dbo.TBS_STUDENT_INFO SET POB_PROVINCE = N'" & cboPobProvince.Text & "',POB_DISTRICT= N'" & cboPobDistrict.Text & "',POB_COMMUNE= N'" & cboPobCommune.Text & "',POB_VILLAGE= N'" & cboPobVillage.Text & "',POB_HOUSE_NO= N'" & txt_POB_home_num.Text & "',POB_STREET= N'" & txt_POB_street_num.Text & "',POB_GROUP= N'" & txt_POB_group.Text & "',GUARDIAN_PROVINCE= N'" & cboCurrentProvince.Text & "',GUARDIAN_DISTRICT= N'" & cboCurrentDistrict.Text & "',GUARDIAN_COMMUNE= N'" & cboCurrentCommune.Text & "',GUARDIAN_VILLAGE= N'" & cboCurrentVillage.Text & "',GUARDIAN_HOUSE_NO= N'" & txtCurrentHomeNumber.Text & "',GUARDIAN_STREET= N'" & txtCurrentStreetName.Text & "' WHERE STUDENT_ID = " & dgMain.SelectedCells(0).Value & ""

            If lblAddressSave.Text = "កែប្រែ" Then

                Call obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    Call obj.Update(sql)
                    Call SelectStudent()
                    dgMain.Rows(idx).Selected = True
                    dgMain.CurrentCell = dgMain.SelectedCells(1)
                    USER_CLICK_OK = False
                End If
            ElseIf lblAddressSave.Text = "រក្សាទុក" Then
                Call obj.Update_1(sql)
                obj.ShowMsg("បញ្ចូលព័ត៌មានបានជោគជ័យ", FrmMessageSuccess, _SuccessSound)
                Call SelectStudent()
                dgMain.Rows(idx).Selected = True
                dgMain.CurrentCell = dgMain.SelectedCells(1)
            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចរក្សាទុកទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub


End Class
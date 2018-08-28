Imports System.Data.SqlClient
Imports System.IO

Public Class FrmStudentFormer
    Dim obj As New Method
    Dim selectStudentSql As String = "SELECT TOP(100) S.RECORD_ID,S.STUDENT_ID_SCHOOL,S.STUDENT_CODE,S.SNAME_KH,S.SNAME_LATIN ,S.GENDER,S.DOB,S.S_PHONE_LINE_1,S.S_PHONE_LINE_2,S.EMAIL_1,S.JOIN_SCHOOL_DATE,S.FIRST_YEAR_STUDY,S.STUDENT_PHOTO,S.[DESCRIPTION],S.BATCH_ID,B.BATCH,S.STOP_YEAR_STUDY FROM dbo.TBS_STUDENT_INFO_FORMER AS S LEFT JOIN dbo.TBL_BATCH AS B ON S.BATCH_ID = B.BATCH_ID "
    Dim t As New Theme
    Dim batch As String                     'SEND BATCH TO REPORT PARAM
    Dim selectReportSql As String



    Private Sub FrmStudentFormer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cursor = Cursors.AppStarting

            SetCompanyInfo()
            txtAdvancedSearch.SetWaterMark("ស្វែងរក....")
            SelectStudent()

            Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblStuSave_Click(sender As Object, e As EventArgs) Handles lblStuSave.Click
        Try
            If (Validation.IsEmpty(txtStuNameKh, "ឈ្មោះសិស្ស")) Then Exit Sub
            Dim batchID As String = obj.GetID("SELECT BATCH_ID FROM dbo.TBL_BATCH WHERE BATCH = " & obj.ReplaceNullWithZero(cboBatch.Text) & "")
            obj.Insert("INSERT INTO dbo.TBS_STUDENT_INFO_FORMER(STUDENT_ID,STUDENT_ID_SCHOOL,STUDENT_CODE,SNAME_KH,SNAME_LATIN,GENDER,DOB,S_PHONE_LINE_1,S_PHONE_LINE_2,EMAIL_1,JOIN_SCHOOL_DATE,FIRST_YEAR_STUDY,[DESCRIPTION],BATCH_ID,STOP_YEAR_STUDY)VALUES(NULL,N'" & txtStuIDSchool.Text & "',N'" & txtStuCode.Text & "',N'" & txtStuNameKh.Text & "','" & txtStuNameEn.Text & "',N'" & cboStuGender.Text & "','" & dtStuDOB.Value & "',N'" & txtStuPhone1.Text & "',N'" & txtStuPhone2.Text & "',N'" & txtStuEmail.Text & "','" & dtStuJoinSchoolDate.Value & "',N'" & cboStuFirstYearStudy.Text & "',N'" & txtStuRemark.Text & "'," & batchID & ",N'" & cboStopYearStudy.Text & "')")
            Call SelectStudent()
        Catch ex As Exception
            obj.ShowMsg("មិនអាចបញ្ចូលព័ត៌មានបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub
    Public Sub SelectStudent()
        Try
            obj.BindDataGridView(selectStudentSql, dgMain)
            SetDgMainHeader()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចទាញទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub SetDgMainHeader()
        dgMain.Columns(0).Visible = False 'Student ID
        dgMain.Columns(1).HeaderText = "អត្តលេខសាលា"
        dgMain.Columns(1).Width = 120
        dgMain.Columns(2).HeaderText = "អត្តលេខសិស្ស"
        dgMain.Columns(2).Width = 120
        dgMain.Columns(3).HeaderText = "គ្តោតនាមនិងនាម(ខ្មែរ)"
        dgMain.Columns(3).Width = 220
        dgMain.Columns(4).HeaderText = "គ្តោតនាមនិងនាម(ឡាតាំង)"
        dgMain.Columns(4).Width = 220
        dgMain.Columns(5).HeaderText = "ភេទ"
        dgMain.Columns(5).Width = 70
        dgMain.Columns(6).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        dgMain.Columns(6).Width = 120
        dgMain.Columns(7).HeaderText = "លេខទូរស័ព្ទទី១"
        dgMain.Columns(7).Width = 125
        dgMain.Columns(8).HeaderText = "លេខទូរស័ព្ទទី២"
        dgMain.Columns(8).Width = 125
        dgMain.Columns(9).HeaderText = "អ៊ីមែល"
        dgMain.Columns(9).Width = 120
        dgMain.Columns(10).HeaderText = "ថ្ងៃចូលរៀន"
        dgMain.Columns(10).Width = 120
        dgMain.Columns(11).HeaderText = "ឆ្នាំសិក្សាដំបូង"
        dgMain.Columns(11).Width = 120
        dgMain.Columns(12).Visible = False 'Student Photo
        dgMain.Columns(13).Visible = False 'Remark
        dgMain.Columns(14).Visible = False ' Bacth ID
        dgMain.Columns(15).HeaderText = "ជំនាន់"
        dgMain.Columns(15).Width = 90
        dgMain.Columns(16).HeaderText = "ឆ្នាំបញ្ចប់"
        dgMain.Columns(16).Width = 120
    End Sub
    Private Sub cboStuFirstYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboStuFirstYearStudy.DropDown
        Bind.YearStudy(cboStuFirstYearStudy)
    End Sub

    Private Sub lblStuNew_Click(sender As Object, e As EventArgs) Handles lblStuNew.Click
        Try
            lblStuUpdate.Enabled = False
            lblStuSave.Enabled = True

            Call ClearStudentInfo()
            Call ClearAddress()
            Call ClearGuardian()

            txtStuIDSchool.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearStudentInfo()
        txtRecordID.Clear()
        txtStuIDSchool.Clear()
        txtStuCode.Clear()
        txtStuNameKh.Clear()
        txtStuNameEn.Clear()
        cboStuGender.Text = ""
        dtStuDOB.Text = "1/1/1900"
        txtStuPhone1.Clear()
        txtStuPhone2.Clear()
        txtStuEmail.Clear()
        dtStuJoinSchoolDate.Text = "1/1/1900"
        cboStuFirstYearStudy.Text = ""
        txtStuRemark.Clear()
        pic_student.BackgroundImage = Nothing
        cboBatch.Text = ""
        cboStopYearStudy.Text = ""
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

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Close()
    End Sub

    Private Sub cboStuGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStuGender.SelectedIndexChanged
        cboStuGender.BackColor = Color.White
    End Sub

    Private Sub txtStuSchoolCode_TextChanged(sender As Object, e As EventArgs) Handles txtStuIDSchool.TextChanged
        txtStuIDSchool.BackColor = Color.White
    End Sub

    Private Sub txtStuCode_TextChanged(sender As Object, e As EventArgs) Handles txtStuCode.TextChanged
        txtStuCode.BackColor = Color.White
    End Sub

    Private Sub txtStuNameKh_TextChanged(sender As Object, e As EventArgs) Handles txtStuNameKh.TextChanged
        txtStuNameKh.BackColor = Color.White
    End Sub

    Private Sub cboStuFirstYearStudy_TextChanged(sender As Object, e As EventArgs) Handles cboStuFirstYearStudy.TextChanged
        cboStuFirstYearStudy.BackColor = Color.White
    End Sub

    Private Sub ClearAllTab()
        Call ClearGuardian()
        Call ClearStudentInfo()
        Call ClearAddress()
    End Sub
    Private Sub dgMain_SelectionChanged(sender As Object, e As EventArgs) Handles dgMain.SelectionChanged
        Try
            If (dgMain.SelectedRows.Count = 0) Then
                lblSearchResult.Text = "0 នាក់"
                ClearAllTab()
                Exit Sub
            Else

                lblStuSave.Enabled = False
                lblStuUpdate.Enabled = True
                lblStuNew.Enabled = True

                Call ClearStudentInfo()
                Call ClearGuardian()
                Call ClearAddress()

                txtRecordID.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(0).Value)
                txtStuIDSchool.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(1).Value)
                txtStuCode.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(2).Value)
                txtStuNameKh.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(3).Value)
                txtStuNameEn.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(4).Value)
                cboStuGender.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(5).Value)
                txtStuPhone1.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(7).Value)
                txtStuPhone2.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(8).Value)
                txtStuEmail.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(9).Value)
                cboStuFirstYearStudy.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(11).Value)
                txtStuRemark.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(13).Value)
                dtStuDOB.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(6).Value)
                cboBatch.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(15).Value)
                cboStopYearStudy.Text = obj.IfDbNull(dgMain.SelectedRows(0).Cells(16).Value)

                If dgMain.SelectedCells(12).Value.ToString() = "" Then
                    pic_student.BackgroundImage = Nothing
                Else
                    Call obj.Show_Photo(dgMain.SelectedCells(12).Value, pic_student)
                End If

                Call SelectParentInfo()
                Call SelectAddressInfo()


                If txtFatherName.Text = "" Then
                    lblParentSave.Text = "រក្សាទុក"
                    txtFatherName.Focus()

                ElseIf txtFatherName.Text IsNot "" Then
                    lblParentSave.Text = "កែប្រែ"
                End If

                If cboPobProvince.Text = "" And cboCurrentProvince.Text = "" Then
                    lblAddressSave.Text = "រក្សាទុក"
                    cboPobProvince.Focus()
                Else
                    lblAddressSave.Text = "កែប្រែ"
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lblStuUpdate_Click(sender As Object, e As EventArgs) Handles lblStuUpdate.Click
        Try
            If (dgMain.Rows.Count > 0) Then

                obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, _ShowMessageSound)
                If USER_CLICK_OK = True Then

                    If (Validation.IsEmpty(txtStuNameKh, "ឈ្មោះសិស្ស")) Then Exit Sub

                    idx = dgMain.SelectedCells(0).RowIndex.ToString()

                    Dim batchID As String = obj.GetID("SELECT BATCH_ID FROM dbo.TBL_BATCH WHERE BATCH = " & obj.ReplaceNullWithZero(cboBatch.Text) & "")
                    obj.Update("UPDATE dbo.TBS_STUDENT_INFO_FORMER SET STUDENT_ID_SCHOOL = N'" & txtStuIDSchool.Text & "',STUDENT_CODE = N'" & txtStuCode.Text & "',SNAME_KH = N'" & txtStuNameKh.Text & "',SNAME_LATIN = N'" & txtStuNameEn.Text & "',GENDER =N'" & cboStuGender.Text & "',S_PHONE_LINE_1 = N'" & txtStuPhone1.Text & "',S_PHONE_LINE_2 = N'" & txtStuPhone2.Text & "',EMAIL_1 = N'" & txtStuEmail.Text & "',JOIN_SCHOOL_DATE = '" & dtStuJoinSchoolDate.Value & "',FIRST_YEAR_STUDY = N'" & cboStuFirstYearStudy.Text & "',STOP_YEAR_STUDY = N'" & cboStopYearStudy.Text & "',[DESCRIPTION] = N'" & txtStuRemark.Text & "', BATCH_ID = " & batchID & " WHERE STUDENT_ID = " & dgMain.SelectedCells(0).Value & "")
                    Call SelectStudent()

                    dgMain.Rows(idx).Selected = True
                    dgMain.CurrentCell = dgMain.SelectedCells(1)
                End If
            Else
                obj.ShowMsg("មិនមានព័ត៌មានសម្រាប់កែប្រែ", FrmWarning, _WarningSound)
                lblStuNew_Click(sender, e)
            End If

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចកែប្រែបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub
    Private Function CheckStudentCode_update() As Boolean
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT STUDENT_CODE FROM dbo.TBS_STUDENT_INFO_FORMER WHERE STUDENT_CODE = N'" & txtStuCode.Text & "'", conn)
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

    Private Sub cboFatherOccupation_DropDown(sender As Object, e As EventArgs) Handles cboFatherOccupation.DropDown
        Bind.Occupation(cboFatherOccupation)
    End Sub

    Private Sub cboMotherOccupation_DropDown(sender As Object, e As EventArgs) Handles cboMotherOccupation.DropDown
        Bind.Occupation(cboMotherOccupation)
    End Sub

    Private Sub lblFamilySave_Click(sender As Object, e As EventArgs) Handles lblParentSave.Click
        Try
            Call obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, _ShowMessageSound)
            If USER_CLICK_OK = True Then
                idx = dgMain.SelectedCells(0).RowIndex.ToString()

                Dim fatherOcuppcationID As String = obj.GetID("SELECT OCCUPATION_ID FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_KH = N'" & cboFatherOccupation.Text & "'")
                Dim motherOcuppationID As String = obj.GetID("SELECT OCCUPATION_ID FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_KH = N'" & cboMotherOccupation.Text & "'")
                Dim guaOccupationID As String = obj.GetID("SELECT OCCUPATION_ID FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_KH = N'" & cboGuaOccupation.Text & "'")

                Call obj.UpdateNoMsg("UPDATE dbo.TBS_STUDENT_INFO_FORMER SET FATHER_NAME = N'" & txtFatherName.Text & "',FATHER_OCCUPATION_ID= " & fatherOcuppcationID & ",FATHER_PHONE_LINE_1= N'" & txtFatherPhone1.Text & "',FATHER_PHONE_LINE_2= N'" & txtFatherPhone2.Text & "',MOTHER_NAME= N'" & txtMotherName.Text & "',MOTHER_OCCUPATION_ID = " & motherOcuppationID & ",MOTHER_PHONE_LINE_1= N'" & txtMotherPhone1.Text & "',MOTHER_PHONE_LINE_2= N'" & txtMotherPhone2.Text & "',GUARDIAN_NAME= N'" & txtGuaName.Text & "',GUARDIAN_OCCUPATION_ID= " & guaOccupationID & ",GUARDIAN_PHONE_LINE_1= N'" & txtGuaPhone1.Text & "',GUARDIAN_PHONE_LINE_2= N'" & txtGuaPhone2.Text & "' WHERE STUDENT_ID = " & dgMain.SelectedRows(0).Cells(0).Value & "")

                If (lblParentSave.Text = "រក្សាទុក") Then
                    obj.ShowMsg("បញ្ចូលព័ត៌មានបានជោគជ័យ", FrmMessageSuccess, _SuccessSound)
                Else
                    obj.ShowMsg("ព័ត៌មានត្រូវបានកែប្រែ", FrmMessageSuccess, _SuccessSound)
                End If
                Call SelectStudent()

                dgMain.Rows(idx).Selected = True
                dgMain.CurrentCell = dgMain.SelectedCells(1)

            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចកែប្រែបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub



    Private Sub SelectAddressInfo()
        Dim selectSql As String = "SELECT POB_PROVINCE,POB_DISTRICT,POB_COMMUNE,POB_VILLAGE,POB_HOUSE_NO,POB_STREET,POB_GROUP,GUARDIAN_PROVINCE,GUARDIAN_DISTRICT,GUARDIAN_COMMUNE,GUARDIAN_VILLAGE,GUARDIAN_HOUSE_NO,GUARDIAN_STREET FROM dbo.TBS_STUDENT_INFO_FORMER WHERE STUDENT_ID = " & dgMain.SelectedCells(0).Value & ""
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
            dr.Close()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចទាយទិន្នន័យពី Server បានទេ !", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub SelectParentInfo()

        Dim selectSql As String = "SELECT FATHER_NAME,(SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE  OCCUPATION_ID = FATHER_OCCUPATION_ID) AS 'FATHER_OCCUPATION',FATHER_PHONE_LINE_1,FATHER_PHONE_LINE_2,MOTHER_NAME,(SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_ID =  MOTHER_OCCUPATION_ID)AS 'MOTHER_OCCUPATION', MOTHER_PHONE_LINE_1,MOTHER_PHONE_LINE_2,GUARDIAN_NAME,(SELECT OCCUPATION_KH FROM dbo.TBL_OCCUPATION WHERE OCCUPATION_ID =  GUARDIAN_OCCUPATION_ID)AS 'GUARDIAN_OCCUPATION',GUARDIAN_PHONE_LINE_1,GUARDIAN_PHONE_LINE_2 FROM dbo.TBS_STUDENT_INFO_FORMER WHERE STUDENT_ID = " & dgMain.SelectedCells(0).Value & " "
        dr = obj.SelectData(selectSql)
        Try
            If dr.HasRows Then
                While dr.Read

                    txtFatherName.Text = If(dr.IsDBNull(0), "", dr.GetString(0))
                    cboFatherOccupation.Text = If(dr.IsDBNull(1), "", dr.GetString(1))
                    txtFatherPhone1.Text = If(dr.IsDBNull(2), "", dr.GetString(2))
                    txtFatherPhone2.Text = If(dr.IsDBNull(3), "", dr.GetString(3))
                    txtMotherName.Text = If(dr.IsDBNull(4), "", dr.GetString(4))
                    cboMotherOccupation.Text = If(dr.IsDBNull(5), "", dr.GetString(5))
                    txtMotherPhone1.Text = If(dr.IsDBNull(6), "", dr.GetString(6))
                    txtMotherPhone2.Text = If(dr.IsDBNull(7), "", dr.GetString(7))
                    txtGuaName.Text = If(dr.IsDBNull(8), "", dr.GetString(8))
                    cboGuaOccupation.Text = If(dr.IsDBNull(9), "", dr.GetString(9))
                    txtGuaPhone1.Text = If(dr.IsDBNull(10), "", dr.GetString(10))
                    txtGuaPhone2.Text = If(dr.IsDBNull(11), "", dr.GetString(11))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចទាយទិន្នន័យពី Server បានទេ !", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub lblNewFamily_Click(sender As Object, e As EventArgs) Handles lblParentNew.Click
        Call ClearGuardian()
        txtFatherName.Focus()
    End Sub

    Private Sub lblAddressNew_Click(sender As Object, e As EventArgs) Handles lblAddressNew.Click
        Call ClearAddress()
        cboPobProvince.Focus()
    End Sub

    Private Sub cboPobProvince_DropDown(sender As Object, e As EventArgs) Handles cboPobProvince.DropDown
        Try
            Bind.Province(cboPobProvince)

            cboPobDistrict.Text = ""
            cboPobCommune.Text = ""
            cboPobVillage.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboPobDistrict_DropDown(sender As Object, e As EventArgs) Handles cboPobDistrict.DropDown
        Try
            Bind.District(cboPobDistrict, cboPobProvince)

            cboPobCommune.Text = ""
            cboPobVillage.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboPobCommune_DropDown(sender As Object, e As EventArgs) Handles cboPobCommune.DropDown
        Try
            Bind.Commune(cboPobCommune, cboPobDistrict)
            cboPobVillage.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboPobVillage_DropDown(sender As Object, e As EventArgs) Handles cboPobVillage.DropDown
        Try
            Bind.Village(cboPobVillage, cboPobCommune, cboPobDistrict, cboPobProvince)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboCurrentProvince_DropDown(sender As Object, e As EventArgs) Handles cboCurrentProvince.DropDown
        Bind.Province(cboCurrentProvince)
        cboCurrentDistrict.Text = ""
        cboCurrentCommune.Text = ""
        cboCurrentVillage.Text = ""
    End Sub

    Private Sub cboCurrentDistrict_DropDown(sender As Object, e As EventArgs) Handles cboCurrentDistrict.DropDown
        Bind.District(cboCurrentDistrict, cboCurrentProvince)
        cboCurrentCommune.Text = ""
        cboCurrentVillage.Text = ""
    End Sub

    Private Sub cboCurrentCommune_DropDown(sender As Object, e As EventArgs) Handles cboCurrentCommune.DropDown
        Bind.Commune(cboCurrentCommune, cboCurrentDistrict)
        cboCurrentVillage.Text = ""
    End Sub

    Private Sub cboCurrentVillage_DropDown(sender As Object, e As EventArgs) Handles cboCurrentVillage.DropDown
        Bind.Village(cboCurrentVillage, cboCurrentCommune, cboCurrentDistrict, cboCurrentProvince)
    End Sub

    Private Sub lblAddressSave_Click(sender As Object, e As EventArgs) Handles lblAddressSave.Click
        Try
            Dim sql = "UPDATE dbo.TBS_STUDENT_INFO_FORMER SET POB_PROVINCE = N'" & cboPobProvince.Text & "',POB_DISTRICT= N'" & cboPobDistrict.Text & "',POB_COMMUNE= N'" & cboPobCommune.Text & "',POB_VILLAGE= N'" & cboPobVillage.Text & "',POB_HOUSE_NO= N'" & txt_POB_home_num.Text & "',POB_STREET= N'" & txt_POB_street_num.Text & "',POB_GROUP= N'" & txt_POB_group.Text & "',GUARDIAN_PROVINCE= N'" & cboCurrentProvince.Text & "',GUARDIAN_DISTRICT= N'" & cboCurrentDistrict.Text & "',GUARDIAN_COMMUNE= N'" & cboCurrentCommune.Text & "',GUARDIAN_VILLAGE= N'" & cboCurrentVillage.Text & "',GUARDIAN_HOUSE_NO= N'" & txtCurrentHomeNumber.Text & "',GUARDIAN_STREET= N'" & txtCurrentStreetName.Text & "' WHERE STUDENT_ID = " & dgMain.SelectedCells(0).Value & ""

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
                Call obj.UpdateNoMsg(sql)
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

    Private Sub lblNewFamily_MouseHover(sender As Object, e As EventArgs) Handles lblParentNew.MouseHover
        t.Hover(lblParentNew)
    End Sub

    Private Sub lblNewFamily_MouseLeave(sender As Object, e As EventArgs) Handles lblParentNew.MouseLeave
        t.Leave(lblParentNew)
    End Sub

    Private Sub lblStuNew_MouseHover(sender As Object, e As EventArgs) Handles lblStuNew.MouseHover
        t.Hover(lblStuNew)
    End Sub

    Private Sub lblStuNew_MouseLeave(sender As Object, e As EventArgs) Handles lblStuNew.MouseLeave
        t.Leave(lblStuNew)
    End Sub

    Private Sub lblStuSave_MouseHover(sender As Object, e As EventArgs) Handles lblStuSave.MouseHover
        t.Hover(lblStuSave)
    End Sub

    Private Sub lblStuSave_MouseLeave(sender As Object, e As EventArgs) Handles lblStuSave.MouseLeave
        t.Leave(lblStuSave)
    End Sub

    Private Sub lblStuUpdate_MouseHover(sender As Object, e As EventArgs) Handles lblStuUpdate.MouseHover
        t.Hover(lblStuUpdate)
    End Sub

    Private Sub lblStuUpdate_MouseLeave(sender As Object, e As EventArgs) Handles lblStuUpdate.MouseLeave
        t.Leave(lblStuUpdate)
    End Sub

    Private Sub lblParentSave_MouseHover(sender As Object, e As EventArgs) Handles lblParentSave.MouseHover
        t.Hover(lblParentSave)
    End Sub

    Private Sub lblParentSave_MouseLeave(sender As Object, e As EventArgs) Handles lblParentSave.MouseLeave
        t.Leave(lblParentSave)
    End Sub

    Private Sub lblAddressSave_MouseHover(sender As Object, e As EventArgs) Handles lblAddressSave.MouseHover
        t.Hover(lblAddressSave)
    End Sub

    Private Sub lblAddressSave_MouseLeave(sender As Object, e As EventArgs) Handles lblAddressSave.MouseLeave
        t.Leave(lblAddressSave)
    End Sub

    Private Sub lblAddressNew_MouseHover(sender As Object, e As EventArgs) Handles lblAddressNew.MouseHover
        t.Hover(lblAddressNew)
    End Sub

    Private Sub lblAddressNew_MouseLeave(sender As Object, e As EventArgs) Handles lblAddressNew.MouseLeave
        t.Leave(lblAddressNew)
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

    Private Sub cboStudentName_DropDown(sender As Object, e As EventArgs) Handles cboStudentName.DropDown
        obj.BindComboBox("SELECT STUDENT_ID,SNAME_KH FROM dbo.TBS_STUDENT_INFO_FORMER", cboStudentName, "SNAME_KH", "STUDENT_ID")
    End Sub

    Private Sub cboStudentName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentName.SelectedIndexChanged
        Try
            obj.BindDataGridView(selectStudentSql + "  WHERE S.STUDENT_ID = " & cboStudentName.SelectedValue & "", dgMain)
            SetDgMainHeader()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចទាញទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub lblDisplayAll_Click(sender As Object, e As EventArgs) Handles lblDisplayAll.Click
        SelectStudent()
    End Sub

    Private Sub cboSearchYear_DropDown(sender As Object, e As EventArgs) Handles cboSearchYear.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboSearchYear, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub

    Private Sub cboSearchYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchYear.SelectedIndexChanged
        Try
            obj.BindDataGridView(selectStudentSql + "  WHERE S.FIRST_YEAR_STUDY = N'" & cboSearchYear.Text & "'", dgMain)
            SetDgMainHeader()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចទាញទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub txt_ad_search_TextChanged(sender As Object, e As EventArgs) Handles txt_ad_search.TextChanged

    End Sub

    Private Sub txtAdvancedSearch_TextChanged(sender As Object, e As EventArgs) Handles txtAdvancedSearch.TextChanged
        Try
            obj.BindDataGridView(selectStudentSql + "  WHERE S.STUDENT_CODE + S.STUDENT_ID_SCHOOL + S.SNAME_KH + S.SNAME_LATIN + S.S_PHONE_LINE_1 + S.S_PHONE_LINE_2 + S.EMAIL_1 + S.FIRST_YEAR_STUDY  LIKE N'%" & txtAdvancedSearch.Text & "%'", dgMain)
            SetDgMainHeader()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("មិនអាចទាញទិន្នន័យបាន", FrmMessageError, _ErrorSound)
        End Try
    End Sub
    Private Sub CountSearchResult()
        Try
            lblSearchResult.Text = "0 នាក់"
            lblSearchResult.Text = dgMain.Rows.Count.ToString + " នាក់"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            lblSearchResult.Text = "0"
        End Try
    End Sub

    Private Sub dgMain_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgMain.RowPrePaint
        Try
            Call CountSearchResult()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lbl_browe_student_pic_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblOpenPhoto.LinkClicked
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
    Private Sub lbl_stu_save_photo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSavePhoto.LinkClicked
        Try
            If pic_student.BackgroundImage Is Nothing Then
                Call obj.ShowMsg("សូមជ្រើសរើសរូបភាពជាមុន!", FrmWarning, "Error.wav")
                Exit Sub
            End If
            Call obj.OpenConnection()
            Dim photo() As Byte = GetPhoto(photoFilePath)
            cmd = New SqlCommand("UPDATE dbo.TBS_STUDENT_INFO_FORMER SET STUDENT_PHOTO=@Photo WHERE STUDENT_ID=" & dgMain.SelectedRows(0).Cells(0).Value & " ", conn)
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            cmd.ExecuteNonQuery()
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            Call obj.ShowMsg("រូបភាពកែប្រែបានសម្រេច", FrmMessageSuccess, _SuccessSound)
            Call SelectStudent()

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("ពុំអាចកែប្រែរូបភាពបានទេ!", FrmMessageError, _ErrorSound)
        End Try
    End Sub

    Private Sub lbl_browe_student_pic_MouseHover(sender As Object, e As EventArgs) Handles lblOpenPhoto.MouseHover
        t.Hover(lblOpenPhoto)
    End Sub

    Private Sub lbl_browe_student_pic_MouseLeave(sender As Object, e As EventArgs) Handles lblOpenPhoto.MouseLeave
        t.Leave(lblOpenPhoto)
    End Sub

    Private Sub lbl_stu_save_photo_MouseHover(sender As Object, e As EventArgs) Handles lblSavePhoto.MouseHover
        t.Hover(lblSavePhoto)
    End Sub

    Private Sub lblSavePhoto_MouseLeave(sender As Object, e As EventArgs) Handles lblSavePhoto.MouseLeave
        t.Leave(lblSavePhoto)
    End Sub

    Private Sub lblDisplayAll_MouseHover(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseHover
        t.Hover(lblDisplayAll)
    End Sub

    Private Sub lblDisplayAll_MouseLeave(sender As Object, e As EventArgs) Handles lblDisplayAll.MouseLeave
        t.Leave(lblDisplayAll)
    End Sub

    Private Sub lblPrintStudent_MouseHover(sender As Object, e As EventArgs) Handles lblPrintStudent.MouseHover
        t.Hover(lblPrintStudent)
    End Sub

    Private Sub lblPrintStudent_MouseLeave(sender As Object, e As EventArgs) Handles lblPrintStudent.MouseLeave
        t.Leave(lblPrintStudent)
    End Sub

    Private Sub cboBatch_DropDown(sender As Object, e As EventArgs) Handles cboBatch.DropDown
        Bind.Batch(cboBatch)
    End Sub

    Private Sub DetermineWhatToQuery()
        Try
            Dim batchID As String
            If (cboStuFirstYearStudy.Text = "" And cboBatch.Text = "") Then
                selectReportSql = "SELECT * FROM dbo.V_STUDENT_FORMER_LIST"
                batch = "ទាំងអស់"
            ElseIf (cboStuFirstYearStudy.Text = "" And cboBatch.Text <> "") Then
                batchID = obj.GetID("SELECT BATCH_ID FROM dbo.TBL_BATCH WHERE BATCH = N'" & cboBatch.Text & "'")
                selectReportSql = "SELECT * FROM dbo.V_STUDENT_FORMER_LIST WHERE BATCH_ID = " & batchID & ""
                batch = cboBatch.Text
            ElseIf (cboStuFirstYearStudy.Text <> "" And cboBatch.Text = "") Then
                selectReportSql = "SELECT * FROM dbo.V_STUDENT_FORMER_LIST WHERE FIRST_YEAR_STUDY = N'" & cboStuFirstYearStudy.Text & "'"
                batch = "ទាំងអស់"
            Else
                batchID = obj.GetID("SELECT BATCH_ID FROM dbo.TBL_BATCH WHERE BATCH = N'" & cboBatch.Text & "'")
                selectReportSql = "SELECT * FROM dbo.V_STUDENT_FORMER_LIST WHERE FIRST_YEAR_STUDY = N'" & cboStuFirstYearStudy.Text & "' AND BATCH_ID = " & batchID & ""
                batch = cboBatch.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblPrintStudent_Click(sender As Object, e As EventArgs) Handles lblPrintStudent.Click
        Try
            Call obj.OpenConnection()
            DetermineWhatToQuery()
            cmd = New SqlCommand(selectReportSql, conn)
            da = New SqlDataAdapter(cmd)
            DataSet1.dtStudentFormer.Clear()
            da.Fill(DataSet1.dtStudentFormer)
            Dim FrmViewReport As New FrmDynamicReportViewer
            FrmViewReport.SetupReport("DataSet1", "STU_MS.rpStudentFormer.rdlc", BindingSource1)
            obj.SendParam("paramSchoolName", obj.GetSchoolName(), FrmViewReport.ReportViewer)
            obj.SendParam("paramProvince", obj.GetProvinceName(), FrmViewReport.ReportViewer)
            obj.SendParam("paramBatch", batch, FrmViewReport.ReportViewer)
            FrmViewReport.ReportViewer.RefreshReport()
            FrmViewReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboStopYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboStopYearStudy.DropDown
        Bind.YearStudy(cboStopYearStudy)
    End Sub

    Private Sub SetCompanyInfo()
        lblCompanyInfro.Text = CompanyInfo.CompanyName
        lblOwnerName.Text = CompanyInfo.Name
        lblPhoneNumber.Text = CompanyInfo.Tel
        lblEmail.Text = CompanyInfo.Email
    End Sub
End Class
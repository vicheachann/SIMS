Imports System.IO
Imports System.Data.SqlClient

Public Class frm_teacher

    Dim obj As New Method
    Dim dateJoinPosition As String
    Dim dateJoinOrg As String
    Dim dateNOMINATE_DATE As String
    Dim t As New Theme
    Dim SqlSelectTeacher As String = "SELECT T.TEACHER_ID,ROW_NUMBER() OVER(ORDER BY T.TEACHER_ID ASC) AS 'Order number', T.TEACHER_CODE, T.T_ID_CARD, T.T_NAME_KH, T.T_NAME_LATIN, T.GENDER, T.DOB, R.RELIGION_KH, T.DATE_JOIN_ORGANIZATION, T.JOIN_WORK_NUMBER,T.JOIN_WORK_DATE, T.RETIRED_NUMBER, T.RETIRED_DATAE, T.NOMINATE_NUMBER, T.NOMINATE_DATE, O.OFFICE_KH, P.POSITION, T.DATE_POSITION, T.LETTER_NUMBER,SL.SALARY_LEVEL, T.BIRTH_PROVINCE, T.BIRTH_DISTRICT, T.BIRTH_COMMUNE, T.BIRTH_VILLAGE, T.BIRTH_HOUSE_NUM, T.BIRTH_STREET, T.CURRENT_PROVINCE, T.CURRENT_DISTRICT,T.CURRENT_COMMUNE, T.CURRENT_VILLAGE, T.CURRENT_HOUSE_NUM, T.CURRENT_STREET, T.PHOTOS, TS.TEACHER_STATUS_KH, T.T_PHONE_LINE_1, T.T_PHONE_LINE_2, T.EMAIL_1,T.EMAIL_2, M.MARRY_STATUS_KH FROM dbo.TBL_TEACHER AS T INNER JOIN dbo.TBL_RELIGION AS R ON T.RELIGION_ID = R.RELIGION_ID INNER JOIN dbo.TBL_OFFICE AS O ON T.OFFICE_ID = O.OFFICE_ID INNER JOIN  dbo.TBL_POSITION AS P ON T.POSITION_ID = P.POSITION_ID INNER JOIN dbo.TBL_SALARY_LEVEL AS SL ON T.SALARY_LEVEL_ID = SL.SALARY_LEVEL_ID INNER JOIN dbo.TBL_TEACHER_STATUS AS TS ON T.TEACHER_STATUS_ID = TS.TEACHER_STATUS_ID INNER JOIN  dbo.TBL_MARRY_STATUS AS M ON T.MARRY_STATUS_ID = M.MARRY_STATUS_ID WHERE T.TEACHER_STATUS_ID NOT IN (2,3,4,6,9)"

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub lbl_office_Click(sender As Object, e As EventArgs) Handles lbl_office.Click
        frm_office.ShowDialog()
    End Sub
    Private Sub lbl_position_Click(sender As Object, e As EventArgs) Handles lbl_position.Click
        frm_position.ShowDialog()
    End Sub
    Private Sub cbo_office_DropDown(sender As Object, e As EventArgs) Handles cbo_T_office.DropDown
        obj.BindComboBox("select OFFICE_ID,OFFICE_KH from dbo.TBL_OFFICE", cbo_T_office, "OFFICE_KH", "OFFICE_ID")
    End Sub
    Private Sub cbo_position_DropDown(sender As Object, e As EventArgs) Handles cbo_T_position.DropDown
        obj.BindComboBox("select POSITION_ID,POSITION from dbo.TBL_POSITION  order by ORDINAL_NUMBER", cbo_T_position, "POSITION", "POSITION_ID")
    End Sub
    Private Sub cbo_T_salary_level_ID_DropDown(sender As Object, e As EventArgs) Handles cbo_T_salary_level_ID.DropDown
        obj.BindComboBox("select SALARY_LEVEL_ID,SALARY_LEVEL from dbo.TBL_SALARY_LEVEL", cbo_T_salary_level_ID, "SALARY_LEVEL", "SALARY_LEVEL_ID")
    End Sub
    Private Sub cbo_T_religion_ID_DropDown(sender As Object, e As EventArgs) Handles cbo_T_religion_ID.DropDown
        obj.BindComboBox("select RELIGION_ID,RELIGION_KH from dbo.TBL_RELIGION", cbo_T_religion_ID, "RELIGION_KH", "RELIGION_ID")

    End Sub
    Private Sub cbo_T_marry_status_DropDown(sender As Object, e As EventArgs) Handles cbo_T_marry_status.DropDown
        obj.BindComboBox("select MARRY_STATUS_ID,MARRY_STATUS_KH from dbo.TBL_MARRY_STATUS", cbo_T_marry_status, "MARRY_STATUS_KH", "MARRY_STATUS_ID")
    End Sub
    Private Sub cbo_T_teacher_status_ID_DropDown(sender As Object, e As EventArgs) Handles cbo_T_teacher_status_ID.DropDown
        obj.BindComboBox("select TEACHER_STATUS_ID, TEACHER_STATUS_KH from dbo.TBL_TEACHER_STATUS", cbo_T_teacher_status_ID, "TEACHER_STATUS_KH", "TEACHER_STATUS_ID")

    End Sub

    Private Function ValidateControl() As Boolean
        Dim ValidateState As Boolean
        'Teacher Code
        If txt_T_teacher_code.Text = "" Then
            txt_T_teacher_code.BackColor = Color.LavenderBlush
            txt_T_teacher_code.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'ID Card
        If txt_T_ID_card.Text = "" Then
            txt_T_ID_card.BackColor = Color.LavenderBlush
            txt_T_ID_card.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'Name KH 
        If txt_T_name_kh.Text = "" Then
            txt_T_name_kh.BackColor = Color.LavenderBlush
            txt_T_name_kh.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'Gender
        If cbo_T_gender.Text = "" Then
            cbo_T_gender.BackColor = Color.LavenderBlush
            cbo_T_gender.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'Teachet status
        If cbo_T_teacher_status_ID.Text = "" Then
            cbo_T_teacher_status_ID.BackColor = Color.LavenderBlush
            cbo_T_teacher_status_ID.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'Office
        If cbo_T_office.Text = "" Then
            cbo_T_office.BackColor = Color.LavenderBlush
            cbo_T_office.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If

        'Position
        If cbo_T_position.Text = "" Then
            cbo_T_position.BackColor = Color.LavenderBlush
            cbo_T_position.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If

        'Salary Level
        If cbo_T_salary_level_ID.Text = "" Then
            cbo_T_salary_level_ID.BackColor = Color.LavenderBlush
            cbo_T_salary_level_ID.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'Religion
        If cbo_T_religion_ID.Text = "" Then
            cbo_T_religion_ID.BackColor = Color.LavenderBlush
            cbo_T_religion_ID.Focus()
            ValidateState = False
        Else
            ValidateState = True
        End If
        'cbo_T_marry_status
        If cbo_T_marry_status.Text = "" Then
            cbo_T_marry_status.BackColor = Color.LavenderBlush
            cbo_T_marry_status.Focus()
            ValidateState = False
        Else
            Return ValidateState
        End If
        Return ValidateState
    End Function

    Private Sub btn_T_save_Click(sender As Object, e As EventArgs) Handles btn_T_save.Click
        Try

            If txt_T_teacher_code.Text = "" Or txt_T_ID_card.Text = "" Or txt_T_name_kh.Text = "" Or cbo_T_gender.Text = "" Or cbo_T_teacher_status_ID.Text = "" Or cbo_T_position.Text = "" Or cbo_T_office.Text = "" Or cbo_T_salary_level_ID.Text = "" Or cbo_T_religion_ID.Text = "" Or cbo_T_marry_status.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                ValidateControl()
                If ValidateControl() = False Then
                    Exit Sub
                End If
                Exit Sub
            End If

            If frm_class_monitor.CheckExisted("SELECT TEACHER_CODE FROM dbo.TBL_TEACHER WHERE TEACHER_CODE = N'" & txt_T_teacher_code.Text & "'", "TBL_TEACHER") = True Then
                obj.ShowMsg("លេខកូដត្មានរួចរាល់ហើយ", FrmWarning, "")
                txt_T_teacher_code.Select()
                Exit Sub
            End If



            'Validating
            If cb_join_org.Checked = False Or cb_date_position.Checked = False Then
                obj.ShowMsg("តើអ្នកចង់បញ្ចូលថ្ងៃចូលបម្រើអង្គភាព និង " & vbCrLf & "ថ្ងៃខែទទួលបានមុខងារដែលឬទេ? ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    If cb_NOMINATE_DATE.Checked = False Then
                        cb_NOMINATE_DATE.Checked = True
                        Exit Sub
                    End If
                    If cb_join_org.Checked = False Then
                        cb_join_org.Checked = True
                        Exit Sub
                    End If
                    If cb_date_position.Checked = False Then
                        cb_date_position.Checked = True
                        Exit Sub
                    End If
                    Exit Sub
                ElseIf USER_CLICK_OK = False Then

                End If
            End If
            'Validating





            CheckIfDateIsCheck()
            obj.Insert("INSERT INTO dbo.TBL_TEACHER(TEACHER_CODE,T_ID_CARD,T_NAME_KH,T_NAME_LATIN,GENDER,DOB,JOIN_WORK_DATE,DATE_JOIN_ORGANIZATION,OFFICE_ID,POSITION_ID,DATE_POSITION,LETTER_NUMBER,SALARY_LEVEL_ID,RELIGION_ID,MARRY_STATUS_ID,TEACHER_STATUS_ID,T_PHONE_LINE_1,T_PHONE_LINE_2,EMAIL_1,EMAIL_2,JOIN_WORK_NUMBER,NOMINATE_NUMBER,RETIRED_NUMBER,RETIRED_DATAE,NOMINATE_DATE)values(N'" & txt_T_teacher_code.Text & "'," & txt_T_ID_card.Text & ",N'" & txt_T_name_kh.Text & "',N'" & txt_T_name_en.Text & "',N'" & cbo_T_gender.Text & "','" & dt_T_DOB.Value & "','" & dt_T_JOIN_WORK_DATE.Value & "','" & dateJoinOrg & "'," & cbo_T_office.SelectedValue & "," & cbo_T_position.SelectedValue & ",'" & dateJoinPosition & "',N'" & txt_T_letter_number.Text & "'," & cbo_T_salary_level_ID.SelectedValue & "," & cbo_T_religion_ID.SelectedValue & "," & cbo_T_marry_status.SelectedValue & "," & cbo_T_teacher_status_ID.SelectedValue & ",N'" & txt_T_phone_1.Text & "',N'" & txt_T_phone_2.Text & "',N'" & txt_T_email_1.Text & "',N'" & txt_T_email_2.Text & "',N'" & txt_join_work_num.Text & "',N'" & txt_NOMINATE_NUMBER.Text & "',N'" & txt_RETIRED_NUMBER.Text & "','" & dt_RETIRED_DATAE.Text & "','" & dateNOMINATE_DATE & "')")
            SelectTeacher()
            'Move to last ROW
            dg_main.Rows(dg_main.Rows.Count - 1).Selected = True
            dg_main.CurrentCell = dg_main.SelectedCells(1)

            btn_t_update.Enabled = True
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub
    Private Sub CheckIfDateIsCheck()
        If cb_join_org.Checked = True Then
            dateJoinOrg = dt_T_date_join_organization.Value
        Else
            dateJoinOrg = ""
        End If

        If cb_date_position.Checked = True Then
            dateJoinPosition = dt_T_date_position.Value
        Else
            dateJoinPosition = ""
        End If

        If cb_NOMINATE_DATE.Checked = True Then
            dateNOMINATE_DATE = dt_NOMINATE_DATE.Value
        Else
            dateNOMINATE_DATE = ""
        End If
    End Sub
    Private Sub cb_disable_date_position_CheckedChanged(sender As Object, e As EventArgs) Handles cb_date_position.CheckedChanged
        If cb_date_position.Checked = True Then
            dt_T_date_position.Enabled = True
        Else
            dt_T_date_position.Enabled = False
        End If
    End Sub

    Private Sub cb_disble_date_org_CheckedChanged(sender As Object, e As EventArgs) Handles cb_join_org.CheckedChanged
        If cb_join_org.Checked = True Then
            dt_T_date_join_organization.Enabled = True

        Else
            dt_T_date_join_organization.Enabled = False

        End If
    End Sub

    Private Sub frm_teacher_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim DesignScreenWidth As Integer = 1600
        'Dim DesignScreenHeight As Integer = 1200
        'Dim CurrentScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim CurrentScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        'Dim RatioX As Double = CurrentScreenWidth / DesignScreenWidth
        'Dim RatioY As Double = CurrentScreenHeight / DesignScreenHeight
        'For Each iControl In Me.Controls
        '    With iControl
        '        If (.GetType.GetProperty("Width").CanRead) Then .Width = CInt(.Width * RatioX)
        '        If (.GetType.GetProperty("Height").CanRead) Then .Height = CInt(.Height * RatioY)
        '        If (.GetType.GetProperty("Top").CanRead) Then .Top = CInt(.Top * RatioX)
        '        If (.GetType.GetProperty("Left").CanRead) Then .Left = CInt(.Left * RatioY)
        '    End With
        'Next

    End Sub
    Private Sub SelectTeacherEducation()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     TE.RECORD_ID,ROW_NUMBER() OVER(ORDER BY TE.RECORD_ID ASC) AS 'ល.រ', T.T_NAME_KH, E.EDUCATION_KH, TE.SCHOOL_NAME, TE.PLACE_OF_STUDY, TE.DATE_START, TE.DATE_END, TE.DATE_RECEIVE, EL.EDUCATION_LEVEL_KH, TE.REMARK, " & vbCrLf &
            "                      TE.PHOTO" & vbCrLf &
            "FROM         dbo.TBL_TEACHER_EDUCATION AS TE INNER JOIN" & vbCrLf &
            "                      dbo.TBL_TEACHER AS T ON TE.TEACHER_ID = T.TEACHER_ID INNER JOIN" & vbCrLf &
            "                      dbo.TBL_EDUCATION AS E ON TE.EDUCATION_ID = E.EDUCATION_ID INNER JOIN" & vbCrLf &
            "                      dbo.TBL_EDUCATION_LEVEL AS EL ON TE.EDUCATION_LEVEL_ID = EL.EDUCATION_LEVEL_ID where TE.TEACHER_ID =" & dg_main.SelectedRows(0).Cells(0).Value & " "



            obj.BindDataGridView(SqlQueryStr, dg_education_level)
            Call SetDgTeacherEduTitle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SelectTeacher()
        Try
            obj.BindDataGridView(SqlSelectTeacher, dg_main)
            SetDgTeacherTitle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''
    Private Sub SetDgTeacherEduTitle()
        'Hide ID 
        dg_education_level.Columns(0).Visible = False


        dg_education_level.Columns(1).HeaderText = "ល.រ"
        dg_education_level.Columns(1).Width = 50

        dg_education_level.Columns(2).Visible = False


        dg_education_level.Columns(3).HeaderText = "កម្រិតវប្បធម៌"
        dg_education_level.Columns(3).Width = 250

        dg_education_level.Columns(4).HeaderText = "សាលា"
        dg_education_level.Columns(4).Width = 250

        dg_education_level.Columns(5).HeaderText = "ទីកន្លែងសិក្សា"
        dg_education_level.Columns(5).Width = 180

        dg_education_level.Columns(6).HeaderText = "ថ្ងៃចាប់ផ្តើម"
        dg_education_level.Columns(6).Width = 120

        dg_education_level.Columns(7).HeaderText = "ថ្ងៃបញ្ចប់"
        dg_education_level.Columns(7).Width = 120

        dg_education_level.Columns(8).HeaderText = "ថ្ងៃទទួលសញ្ញាប័ត្រ"
        dg_education_level.Columns(8).Width = 160

        dg_education_level.Columns(9).HeaderText = "កម្រិត"
        dg_education_level.Columns(9).Width = 250

        dg_education_level.Columns(10).HeaderText = "ផ្សេងៗ"
        dg_education_level.Columns(10).Width = 200

        dg_education_level.Columns(11).Visible = False
    End Sub
    Private Sub SetDgTeacherTitle()

        dg_main.Columns(0).Visible = False 'ID


        dg_main.Columns(1).HeaderText = "ល.រ"
        dg_main.Columns(1).Width = 50

        dg_main.Columns(2).HeaderText = "អត្តលេខ"
        dg_main.Columns(2).Width = 80

        dg_main.Columns(3).HeaderText = "អត្តសញ្ញាណប័ណ្ណ"
        dg_main.Columns(3).Width = 140

        dg_main.Columns(4).HeaderText = "ឈ្មោះបុគ្គលិក(ខ្មែរ)"
        dg_main.Columns(4).Width = 180

        dg_main.Columns(5).HeaderText = "ឈ្មោះបុគ្គលិក(ឡាតាំង)"
        dg_main.Columns(5).Width = 180

        dg_main.Columns(6).HeaderText = "ភេទ"
        dg_main.Columns(6).Width = 55

        dg_main.Columns(7).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        dg_main.Columns(7).Width = 120

        dg_main.Columns(8).HeaderText = "សាសនា"
        dg_main.Columns(8).Width = 130

        dg_main.Columns(9).HeaderText = "ថ្ងៃចូលបម្រើអង្គភាព"
        dg_main.Columns(9).Width = 150

        dg_main.Columns(10).HeaderText = "ប្រកាសលេខ"
        dg_main.Columns(10).Width = 125

        dg_main.Columns(11).HeaderText = "ថ្ងៃចូលបម្រើរដ្ឋ"
        dg_main.Columns(11).Width = 125


        dg_main.Columns(12).HeaderText = "លេខប្រកាសចូលនិវត្តន៏"
        dg_main.Columns(12).Width = 200

        dg_main.Columns(13).HeaderText = "ថ្ងៃខែចូលនិវត្តន៏"
        dg_main.Columns(13).Width = 200


        dg_main.Columns(14).HeaderText = "ប្រកាសលេខតែងតាំងស៊ប់"
        dg_main.Columns(14).Width = 220

        dg_main.Columns(15).HeaderText = "ថ្ងៃខែតែងតាំងស៊ប់"
        dg_main.Columns(15).Width = 220

        dg_main.Columns(16).Visible = False 'Office

        dg_main.Columns(17).HeaderText = "មុខងារ"
        dg_main.Columns(17).Width = 150

        dg_main.Columns(18).HeaderText = "ថ្ងៃទទួលបានមុខងារ"
        dg_main.Columns(18).Width = 150

        dg_main.Columns(19).HeaderText = "លេខលិខិត"
        dg_main.Columns(19).Width = 150

        dg_main.Columns(20).HeaderText = "កាំប្រាក់ចុងក្រោយ"
        dg_main.Columns(20).Width = 150

        'dg_main.Columns(21).HeaderText = "ទីកន្លែងកំណើត"
        'dg_main.Columns(21).Width = 150
        dg_main.Columns(21).Visible = False


        'dg_main.Columns(22).HeaderText = "ស្រុក"
        'dg_main.Columns(22).Width = 150
        dg_main.Columns(22).Visible = False

        'dg_main.Columns(23).HeaderText = "ឃុំ"
        'dg_main.Columns(23).Width = 150
        dg_main.Columns(23).Visible = False

        'dg_main.Columns(24).HeaderText = "ភូមិ"
        'dg_main.Columns(24).Width = 150
        dg_main.Columns(24).Visible = False


        'dg_main.Columns(25).HeaderText = "លេខផ្ទះ"
        'dg_main.Columns(25).Width = 150
        dg_main.Columns(25).Visible = False

        'dg_main.Columns(26).HeaderText = "ផ្លូវ"
        'dg_main.Columns(26).Width = 150
        dg_main.Columns(26).Visible = False

        'dg_main.Columns(27).HeaderText = "អាសយដ្ឋានបច្ចុប្បន្ន"
        'dg_main.Columns(27).Width = 150
        dg_main.Columns(27).Visible = False

        'dg_main.Columns(28).HeaderText = "ស្រុក"
        'dg_main.Columns(28).Width = 150
        dg_main.Columns(28).Visible = False


        'dg_main.Columns(29).HeaderText = "ឃុំ"
        'dg_main.Columns(29).Width = 150
        dg_main.Columns(29).Visible = False

        'dg_main.Columns(30).HeaderText = "ភូមិ"
        'dg_main.Columns(30).Width = 150
        dg_main.Columns(30).Visible = False

        'dg_main.Columns(31).HeaderText = "លេខផ្ទះ"
        'dg_main.Columns(31).Width = 150
        dg_main.Columns(31).Visible = False


        'dg_main.Columns(32).HeaderText = "ផ្លូវ"
        'dg_main.Columns(32).Width = 150
        dg_main.Columns(32).Visible = False

        dg_main.Columns(33).Visible = False

        dg_main.Columns(34).HeaderText = "ស្ថានភាពការងារ"
        dg_main.Columns(34).Width = 150

        dg_main.Columns(35).HeaderText = "លេខទូរស័ព្ទទី១"
        dg_main.Columns(35).Width = 150

        dg_main.Columns(36).HeaderText = "លេខទូរស័ព្ទទី២"
        dg_main.Columns(36).Width = 150

        dg_main.Columns(37).HeaderText = "អ៊ីម៉េលទី១"
        dg_main.Columns(37).Width = 200

        dg_main.Columns(38).HeaderText = "អ៊ីម៉េលទី១"
        dg_main.Columns(38).Width = 200

        dg_main.Columns(39).HeaderText = "ស្ថានភាពគ្រួសារ"
        dg_main.Columns(39).Width = 150
    End Sub



    Private Sub btn_t_new_Click(sender As Object, e As EventArgs) Handles btn_t_new.Click

        ClearTabGeneralInfo()
        txt_T_teacher_code.Focus()

        btn_t_delete.Enabled = False
        btn_t_update.Enabled = False
        btn_T_save.Enabled = True
    End Sub

    Private Sub cbo_birth_province_DropDown(sender As Object, e As EventArgs) Handles cbo_birth_province.DropDown
        Try
            Bind.Province(cbo_birth_province)
            cbo_birth_district.Text = ""
            cbo_birth_common.Text = ""
            cbo_birth_village.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_birth_district_DropDown(sender As Object, e As EventArgs) Handles cbo_birth_district.DropDown
        Try
            Bind.District(cbo_birth_district, cbo_birth_province)
            cbo_birth_common.Text = ""
            cbo_birth_village.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_birth_common_DropDown(sender As Object, e As EventArgs) Handles cbo_birth_common.DropDown
        Try
            Bind.Commune(cbo_birth_common, cbo_birth_district)
            cbo_birth_village.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_birth_village_DropDown(sender As Object, e As EventArgs) Handles cbo_birth_village.DropDown
        Try
            Bind.Village(cbo_birth_village, cbo_birth_common, cbo_birth_district, cbo_birth_province)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo_current_province_DropDown(sender As Object, e As EventArgs) Handles cbo_current_province.DropDown
        Try
            Bind.Province(cbo_current_province)
            cbo_current_district.Text = ""
            cbo_current_common.Text = ""
            cbo_current_village.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_current_district_DropDown(sender As Object, e As EventArgs) Handles cbo_current_district.DropDown
        Try
            Bind.District(cbo_current_district, cbo_current_province)
            cbo_current_common.Text = ""
            cbo_current_village.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_current_common_DropDown(sender As Object, e As EventArgs) Handles cbo_current_common.DropDown
        Try
            Bind.Commune(cbo_current_common, cbo_current_district)
            cbo_current_village.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_current_village_DropDown(sender As Object, e As EventArgs) Handles cbo_current_village.DropDown
        Try
            Bind.Village(cbo_current_village, cbo_current_common, cbo_current_district, cbo_current_province)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_address_save_Click(sender As Object, e As EventArgs) Handles btn_address_save.Click
        Try
            idx = dg_main.SelectedCells(0).RowIndex.ToString()


            If dg_main.SelectedRows.Count < 0 Then
                obj.ShowMsg("សូបជ្រើសរើសបុគ្គលិកដែលចង់បញ្ចូល", FrmMessageError, "Error.wav")
                Exit Sub
            End If

            obj.Insert("UPDATE dbo.TBL_TEACHER" & vbCrLf &
"   SET [BIRTH_PROVINCE] = N'" & cbo_birth_province.Text & "'" & vbCrLf &
"      ,[BIRTH_DISTRICT] = N'" & cbo_birth_district.Text & "'" & vbCrLf &
"      ,[BIRTH_COMMUNE] = N'" & cbo_birth_common.Text & "'" & vbCrLf &
"      ,[BIRTH_VILLAGE] = N'" & cbo_birth_village.Text & "'" & vbCrLf &
"      ,[BIRTH_HOUSE_NUM] = N'" & txt_birth_house_num.Text & "'" & vbCrLf &
"      ,[BIRTH_STREET] = N'" & txt_birth_street.Text & "'" & vbCrLf &
"      ,[CURRENT_PROVINCE] = N'" & cbo_current_province.Text & "'" & vbCrLf &
"      ,[CURRENT_DISTRICT] = N'" & cbo_current_district.Text & "'" & vbCrLf &
"      ,[CURRENT_COMMUNE] = N'" & cbo_current_common.Text & "'" & vbCrLf &
"      ,[CURRENT_VILLAGE] = N'" & cbo_current_village.Text & "'" & vbCrLf &
"      ,[CURRENT_HOUSE_NUM] = N'" & txt_current_house_num.Text & "'" & vbCrLf &
"      ,[CURRENT_STREET] = N'" & txt_current_street.Text & "'" & vbCrLf &
" WHERE TEACHER_ID= " & dg_main.SelectedRows(0).Cells(0).Value & "")

            Call SelectTeacher()

            dg_main.Rows(idx).Selected = True
            dg_main.CurrentCell = dg_main.SelectedCells(1)
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("មិនអាចបញ្ចូលនិន្នន័យបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub CheckIsAddressIsAreadyEnter()

    End Sub


    Private Sub ClearTabAddress()
        cbo_birth_province.Text = ""
        cbo_birth_district.Text = ""
        cbo_birth_common.Text = ""
        cbo_birth_village.Text = ""
        txt_birth_house_num.Clear()
        txt_birth_street.Clear()

        cbo_current_province.Text = ""
        cbo_current_district.Text = ""
        cbo_current_common.Text = ""
        cbo_current_village.Text = ""
        txt_current_house_num.Clear()
        txt_current_street.Clear()
    End Sub
    Private Sub ClearTabGeneralInfo()

        txt_NOMINATE_NUMBER.Clear()
        txt_T_teacher_code.Clear()
        txt_T_ID_card.Clear()
        txt_T_name_kh.Clear()
        txt_T_name_en.Clear()
        cbo_T_teacher_status_ID.Text = ""
        cbo_T_office.Text = ""
        cbo_T_position.Text = ""
        txt_T_letter_number.Clear()
        cbo_T_salary_level_ID.Text = ""
        cbo_T_religion_ID.Text = ""
        cbo_T_marry_status.Text = ""
        txt_T_phone_1.Clear()
        txt_T_phone_2.Clear()
        txt_RETIRED_NUMBER.Clear()
        txt_T_email_1.Clear()
        txt_T_email_2.Clear()
        cbo_T_gender.Text = ""
        txt_join_work_num.Clear()
        Picturebox_teacher.BackgroundImage = Nothing
        dt_RETIRED_DATAE.Text = Date.Today
        dt_T_date_join_organization.Text = Date.Today
        dt_T_JOIN_WORK_DATE.Text = Date.Today
        dt_NOMINATE_DATE.Text = Date.Today
        dt_T_date_position.Text = Date.Today

        cb_date_position.Checked = False
        cb_NOMINATE_DATE.Checked = False
        cb_join_org.Checked = False
    End Sub

    Private Sub cbo_education_ID_DropDown(sender As Object, e As EventArgs) Handles cbo_education_ID.DropDown
        Try
            obj.BindComboBox("select EDUCATION_ID,EDUCATION_KH from dbo.TBL_EDUCATION", cbo_education_ID, "EDUCATION_KH", "EDUCATION_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_education_level_ID_DropDown(sender As Object, e As EventArgs) Handles cbo_education_level_ID.DropDown
        Try
            obj.BindComboBox("select EDUCATION_LEVEL_ID,EDUCATION_LEVEL_KH from dbo.TBL_EDUCATION_LEVEL", cbo_education_level_ID, "EDUCATION_LEVEL_KH", "EDUCATION_LEVEL_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ClearEducationLevel()
        cbo_education_ID.Text = ""
        cbo_education_ID.Focus()
        txt_school_name.Clear()
        txt_place_of_study.Clear()
        cbo_education_level_ID.Text = ""
        txt_remark.Clear()
        pic_cerf.BackgroundImage = Nothing

    End Sub

    Private Sub lbl_education_save_Click(sender As Object, e As EventArgs) Handles lbl_education_save.Click
        Try
            '/////  validation /////
            If cbo_education_ID.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូល កម្រិតវប្បធម៌ ", FrmWarning, "")
                cbo_education_ID.Focus()
                cbo_education_ID.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txt_school_name.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលឈ្មោះសាលា ! ", FrmWarning, "")
                txt_school_name.Focus()
                txt_school_name.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If cbo_education_level_ID.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលកម្រិតសិក្សា ! ", FrmWarning, "")
                cbo_education_level_ID.Focus()
                cbo_education_level_ID.BackColor = Color.LavenderBlush
                Exit Sub
            End If





            ''  If cbo_education_ID .Text = 
            For Each row As DataGridViewRow In dg_education_level.Rows
                If cbo_education_ID.Text = row.Cells(3).Value Then
                    obj.ShowMsg("បានបញ្ចូលរួចរាល់", FrmMessageError, "Error.wav")
                    Exit Sub
                End If
            Next



            obj.Insert("insert into dbo.TBL_TEACHER_EDUCATION(TEACHER_ID," & vbCrLf &
"EDUCATION_ID," & vbCrLf &
"SCHOOL_NAME," & vbCrLf &
"PLACE_OF_STUDY," & vbCrLf &
"DATE_START," & vbCrLf &
"DATE_END," & vbCrLf &
"DATE_RECEIVE," & vbCrLf &
"DATE_NOTE," & vbCrLf &
"EDUCATION_LEVEL_ID," & vbCrLf &
"REMARK" & vbCrLf &
")values(" & dg_main.SelectedRows(0).Cells(0).Value & "," & cbo_education_ID.SelectedValue & ",N'" & txt_school_name.Text & "',N'" & txt_place_of_study.Text & "','" & dt_start_date.Text & "','" & dt_end_date.Text & "','" & dt_date_recievd.Text & "','" & Date.Today.ToString & "'," & cbo_education_level_ID.SelectedValue & ",N'" & txt_remark.Text & "'" & vbCrLf &
")")
            SelectTeacherEducation()
            lbl_education_save.Enabled = False
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub



    Private Sub lbl_education_new_Click(sender As Object, e As EventArgs) Handles lbl_education_new.Click
        lbl_education_save.Enabled = True
        lbl_edu_update.Enabled = False
        lbl_edu_delete.Enabled = False
        ClearEducationLevel()

        cbo_education_ID.Focus()
    End Sub

    Private Sub btn_stu_update_Click(sender As Object, e As EventArgs) Handles btn_t_update.Click
        If dg_main.Rows.Count > 0 Then

            obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
            If USER_CLICK_OK = True Then

                Try
                    If txt_T_teacher_code.Text = "" Or txt_T_ID_card.Text = "" Or txt_T_name_kh.Text = "" Or cbo_T_gender.Text = "" Or cbo_T_teacher_status_ID.Text = "" Or cbo_T_position.Text = "" Or cbo_T_office.Text = "" Or cbo_T_salary_level_ID.Text = "" Or cbo_T_religion_ID.Text = "" Or cbo_T_marry_status.Text = "" Then
                        obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
                        ValidateControl()
                        If ValidateControl() = False Then
                            Exit Sub
                        End If
                        Exit Sub
                    End If

                    If txt_T_teacher_code.Text = dg_main.SelectedCells(2).Value Then

                    Else
                        If frm_class_monitor.CheckExisted("SELECT TEACHER_CODE FROM dbo.TBL_TEACHER WHERE TEACHER_CODE = N'" & txt_T_teacher_code.Text & "'", "TBL_TEACHER") = True Then
                            obj.ShowMsg("លេខកូដត្មានរួចរាល់ហើយ", FrmWarning, "")
                            txt_T_teacher_code.Select()
                            Exit Sub
                        End If
                    End If


                    idx = dg_main.SelectedCells(0).RowIndex.ToString()
                    Call obj.Update("update dbo.TBL_TEACHER set TEACHER_CODE = N'" & txt_T_teacher_code.Text & "'," & vbCrLf &
                                "T_ID_CARD = " & txt_T_ID_card.Text & "," & vbCrLf &
                                "T_NAME_KH=N'" & txt_T_name_kh.Text & "'," & vbCrLf &
                                "T_NAME_LATIN=N'" & txt_T_name_en.Text & "'," & vbCrLf &
                                "GENDER= N'" & cbo_T_gender.Text & " '," & vbCrLf &
                                "DOB= '" & dt_T_DOB.Value & "'," & vbCrLf &
                                "TEACHER_STATUS_ID=" & cbo_T_teacher_status_ID.SelectedValue & "," & vbCrLf &
                                "JOIN_WORK_DATE='" & dt_T_JOIN_WORK_DATE.Value & "'," & vbCrLf &
                                "DATE_JOIN_ORGANIZATION='" & dt_T_date_join_organization.Value & "'," & vbCrLf &
                                "OFFICE_ID=" & cbo_T_office.SelectedValue & "," & vbCrLf &
                                "POSITION_ID=" & cbo_T_position.SelectedValue & "," & vbCrLf &
                                "DATE_POSITION=' " & dt_T_date_position.Value & "'," & vbCrLf &
                                "LETTER_NUMBER =N'" & txt_T_letter_number.Text & "'," & vbCrLf &
                                "SALARY_LEVEL_ID =" & cbo_T_salary_level_ID.SelectedValue & "," & vbCrLf &
                                "RELIGION_ID = " & cbo_T_religion_ID.SelectedValue & "," & vbCrLf &
                                "MARRY_STATUS_ID =" & cbo_T_marry_status.SelectedValue & "," & vbCrLf &
                                " T_PHONE_LINE_1 = N'" & txt_T_phone_1.Text & "'," & vbCrLf &
                                " T_PHONE_LINE_2 =N'" & txt_T_phone_2.Text & "'," & vbCrLf &
                                "EMAIL_1 = N'" & txt_T_email_1.Text & "'," & vbCrLf &
                                "JOIN_WORK_NUMBER = N'" & txt_join_work_num.Text & "'," & vbCrLf &
                                 "NOMINATE_NUMBER = N'" & txt_NOMINATE_NUMBER.Text & "'," & vbCrLf &
                                             "RETIRED_NUMBER = N'" & txt_RETIRED_NUMBER.Text & "'," & vbCrLf &
                                             "RETIRED_DATAE = '" & dt_RETIRED_DATAE.Text & "'," & vbCrLf &
                                             "NOMINATE_DATE = '" & dt_NOMINATE_DATE.Text & "'," & vbCrLf &
                                             "EMAIL_2 = N'" & txt_T_email_2.Text & "' where TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & "")

                    SelectTeacher()
                    'want when update selected current row
                    dg_main.Rows(idx).Selected = True
                    dg_main.CurrentCell = dg_main.SelectedCells(1)
                Catch ex As Exception
                    Call obj.ShowMsg("មិនអាចកែប្រែបាន", FrmMessageError, "Error.wav")
                End Try
            End If

        Else
            obj.ShowMsg("មិនមានទិន្នន័យ", FrmMessageError, "Error.wav")
        End If

    End Sub



    Private Sub btn_address_new_Click(sender As Object, e As EventArgs) Handles btn_address_new.Click
        ClearTabAddress()
        cbo_birth_province.Focus()
    End Sub

    Private Sub btn_browe_teacher_photo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_browe_teacher_photo.LinkClicked
        Call obj.Browe(Picturebox_teacher)
    End Sub
    Public Shared Function GetPhoto(ByVal filePath As String) As Byte()
        Dim stream As FileStream = New FileStream( _
           filePath, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(stream)
        Dim photo() As Byte = reader.ReadBytes(stream.Length)
        reader.Close()
        stream.Close()
        Return photo
    End Function
    Private Sub btn_save_photo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_save_photo.LinkClicked
        Try
            If Picturebox_teacher.BackgroundImage Is Nothing Then
                Call obj.ShowMsg("សូមជ្រើសរើសរូបភាពជាមុន!", FrmWarning, "Error.wav")
                Exit Sub
            End If
            Call obj.OpenConnection()
            Dim photo() As Byte = GetPhoto(photoFilePath)
            cmd = New SqlCommand("UPDATE dbo.TBL_TEACHER SET PHOTOS=@Photo WHERE TEACHER_ID=N'" & dg_main.SelectedRows(0).Cells(0).Value & "' ", conn)
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            cmd.ExecuteNonQuery()
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            Call obj.ShowMsg("រូបភាពកែប្រែបានសម្រេច", FrmMessageSuccess, "")
            Call SelectTeacher()
            '' DG_Empoyee.Rows(idx).Selected = True
            '' DG_Empoyee.CurrentCell = DG_Empoyee.SelectedCells(1)
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("ពុំអាចកែប្រែរូបភាពបានទេ!", FrmMessageError, "Error.wav")
        End Try
    End Sub



    Private Sub lbl_cert_browse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_cert_browse.LinkClicked
        Call obj.Browe(pic_cerf)
    End Sub

    Private Sub lbl_insert_cerf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_insert_cerf.LinkClicked
        Try

            If pic_cerf.BackgroundImage Is Nothing Then
                Call obj.ShowMsg("សូមជ្រើសរើសរូបភាពជាមុន!", FrmMessageError, "Error.wav")
                Exit Sub
            End If

            Call obj.OpenConnection()

            idx = dg_education_level.SelectedCells(0).RowIndex.ToString()

            Dim photo() As Byte = GetPhoto(photoFilePath)
            cmd = New SqlCommand("UPDATE dbo.TBL_TEACHER_EDUCATION SET PHOTO=@Photo WHERE RECORD_ID =" & dg_education_level.SelectedRows(0).Cells(0).Value & " ", conn)
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            cmd.ExecuteNonQuery()
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            Call obj.ShowMsg("រូបភាពកែប្រែបានសម្រេច", FrmMessageSuccess, "")


            Call SelectTeacherEducation()
            dg_education_level.Rows(idx).Selected = True
            dg_education_level.CurrentCell = dg_education_level.SelectedCells(1)

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("ពុំអាចកែប្រែរូបភាពបានទេ!", FrmMessageError, "Error.wav")
        End Try
    End Sub




    Private Sub dg_main_SelectionChanged(sender As Object, e As EventArgs) Handles dg_main.SelectionChanged
        Try
            Call cbo_T_teacher_status_ID_DropDown(sender, e)
            Call cbo_office_DropDown(sender, e)
            Call cbo_position_DropDown(sender, e)
            Call cbo_T_salary_level_ID_DropDown(sender, e)
            Call cbo_T_religion_ID_DropDown(sender, e)
            Call cbo_T_marry_status_DropDown(sender, e)


            lbl_education_new_Click(sender, e)
            lbl_professional_new_Click(sender, e)
            lbl_tr_new_Click(sender, e)
            lbl_lag_new_Click(sender, e)
            lbl_spouse_new_Click(sender, e)
            lbl_child_new_Click(sender, e)
            lbl_teaching_new_Click(sender, e)
            lbl_ex_new_Click(sender, e)


            btn_T_save.Enabled = False
            btn_t_delete.Enabled = True
            btn_t_update.Enabled = True
            btn_t_new.Enabled = True

            If dg_main.RowCount > 0 Then
                ClearTabGeneralInfo()
                ClearTabAddress()
                ClearChildren()
                ClearEducationLevel()
                ClearLanagugue()
                ClearSpouse()
                ClearTeacherProfessional()
                ClearTeaching()
                ClearTraningCourse()

                txt_T_teacher_code.Text = If(dg_main.SelectedRows(0).Cells(2).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(2).Value)

                txt_T_ID_card.Text = If(dg_main.SelectedRows(0).Cells(3).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(3).Value)
                txt_T_name_kh.Text = If(dg_main.SelectedRows(0).Cells(4).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(4).Value)
                txt_T_name_en.Text = If(dg_main.SelectedRows(0).Cells(5).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(5).Value)
                cbo_T_gender.Text = If(dg_main.SelectedRows(0).Cells(6).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(6).Value)
                dt_T_DOB.Text = If(dg_main.SelectedRows(0).Cells(7).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(7).Value)
                cbo_T_teacher_status_ID.Text = If(dg_main.SelectedRows(0).Cells(34).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(34).Value)
                cbo_T_office.Text = If(dg_main.SelectedRows(0).Cells(16).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(16).Value)
                txt_join_work_num.Text = If(dg_main.SelectedRows(0).Cells(10).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(10).Value)
                dt_T_JOIN_WORK_DATE.Text = If(dg_main.SelectedRows(0).Cells(11).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(11).Value)
                txt_NOMINATE_NUMBER.Text = If(dg_main.SelectedRows(0).Cells(14).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(14).Value)

                dt_NOMINATE_DATE.Text = If(dg_main.SelectedRows(0).Cells(15).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(15).Value)
                dt_T_date_join_organization.Text = If(dg_main.SelectedRows(0).Cells(9).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(9).Value)

                txt_RETIRED_NUMBER.Text = If(dg_main.SelectedRows(0).Cells(12).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(12).Value)
                dt_RETIRED_DATAE.Text = If(dg_main.SelectedRows(0).Cells(13).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(13).Value)
                cbo_T_position.Text = If(dg_main.SelectedRows(0).Cells(17).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(17).Value)
                dt_T_date_position.Text = If(dg_main.SelectedRows(0).Cells(18).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(18).Value)
                txt_T_letter_number.Text = If(dg_main.SelectedRows(0).Cells(19).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(19).Value)
                cbo_T_salary_level_ID.Text = If(dg_main.SelectedRows(0).Cells(20).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(20).Value)
                cbo_T_religion_ID.Text = If(dg_main.SelectedRows(0).Cells(8).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(8).Value)
                cbo_T_marry_status.Text = If(dg_main.SelectedRows(0).Cells(39).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(39).Value)
                txt_T_phone_1.Text = If(dg_main.SelectedRows(0).Cells(35).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(35).Value)
                txt_T_phone_2.Text = If(dg_main.SelectedRows(0).Cells(36).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(36).Value)
                txt_T_email_1.Text = If(dg_main.SelectedRows(0).Cells(37).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(37).Value)
                txt_T_email_2.Text = If(dg_main.SelectedRows(0).Cells(38).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(38).Value)






                If dg_main.SelectedCells(33).Value.ToString() = "" Then
                    Picturebox_teacher.BackgroundImage = Nothing
                Else
                    Call obj.Show_Photo(dg_main.SelectedCells(33).Value, Picturebox_teacher)
                End If


                'tab address

                ' CheckIsAddressIsAreadyEnter()
                cbo_birth_province.Text = If(dg_main.SelectedRows(0).Cells(21).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(21).Value.ToString)
                cbo_birth_district.Text = If(dg_main.SelectedRows(0).Cells(22).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(22).Value.ToString)
                cbo_birth_common.Text = If(dg_main.SelectedRows(0).Cells(23).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(23).Value.ToString)
                cbo_birth_village.Text = If(dg_main.SelectedRows(0).Cells(24).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(24).Value.ToString)
                txt_birth_house_num.Text = If(dg_main.SelectedRows(0).Cells(25).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(25).Value.ToString)
                txt_birth_street.Text = If(dg_main.SelectedRows(0).Cells(26).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(26).Value.ToString)

                cbo_current_province.Text = If(dg_main.SelectedRows(0).Cells(27).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(27).Value.ToString)
                cbo_current_district.Text = If(dg_main.SelectedRows(0).Cells(28).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(28).Value.ToString)
                cbo_current_common.Text = If(dg_main.SelectedRows(0).Cells(29).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(29).Value.ToString)
                cbo_current_village.Text = If(dg_main.SelectedRows(0).Cells(30).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(30).Value.ToString)
                txt_current_house_num.Text = If(dg_main.SelectedRows(0).Cells(31).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(31).Value.ToString)
                txt_current_street.Text = If(dg_main.SelectedRows(0).Cells(32).Value Is DBNull.Value, "", dg_main.SelectedRows(0).Cells(32).Value.ToString)

                Call SelectTeacherEducation()
                Call SelectTeacherProfessional()
                Call SelectTeacherTrainning()
                Call SelectLanguage()
                Call SelectSpouse()
                Call SelectTeacherChildren()
                Call SelectTeacherTeaching()
                Call SelectTeacherExperience()
                Call SelectLetter()




                If cbo_birth_province.Text = "" And cbo_current_province.Text = "" Then
                    btn_address_save.Text = "រក្សាទុក"

                ElseIf cbo_birth_province.Text IsNot "" Or cbo_current_province.Text IsNot "" Then
                    btn_address_save.Text = "កែប្រែ"
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub







    Private Sub cb_pernament_CheckedChanged(sender As Object, e As EventArgs) Handles cb_NOMINATE_DATE.CheckedChanged
        If cb_NOMINATE_DATE.Checked = True Then
            dt_NOMINATE_DATE.Enabled = True

        Else
            dt_NOMINATE_DATE.Enabled = False

        End If
    End Sub

    Private Sub lbl_edu_update_Click(sender As Object, e As EventArgs) Handles lbl_edu_update.Click
        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            Try
                idx = dg_education_level.SelectedCells(0).RowIndex.ToString()

                '/////  validation /////
                If cbo_education_ID.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូល កម្រិតវប្បធម៌ ", FrmWarning, "")
                    cbo_education_ID.Focus()
                    cbo_education_ID.BackColor = Color.LavenderBlush
                    Exit Sub
                End If
                If txt_school_name.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលឈ្មោះសាលា ! ", FrmWarning, "")
                    txt_school_name.Focus()
                    txt_school_name.BackColor = Color.LavenderBlush
                    Exit Sub
                End If
                If cbo_education_level_ID.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលកម្រិតសិក្សា ! ", FrmWarning, "")
                    cbo_education_level_ID.Focus()
                    cbo_education_level_ID.BackColor = Color.LavenderBlush
                    Exit Sub
                End If




                obj.Update("update dbo.tbl_teacher_education set " & vbCrLf &
                "education_id = " & cbo_education_ID.SelectedValue & ",  " & vbCrLf &
                "school_name = N'" & txt_school_name.Text & "'," & vbCrLf &
                "place_of_study = N'" & txt_place_of_study.Text & "', " & vbCrLf &
                "date_start = '" & dt_start_date.Text & "'," & vbCrLf &
                "date_end = '" & dt_end_date.Text & "'," & vbCrLf &
                "date_receive = '" & dt_date_recievd.Text & "'," & vbCrLf &
                "education_level_id = " & cbo_education_level_ID.SelectedValue & ", " & vbCrLf &
                "remark = N'" & txt_remark.Text & "' where record_id = " & dg_education_level.SelectedRows(0).Cells(0).Value & "")
                SelectTeacherEducation()

                'Keep Current row after update :(
                dg_education_level.Rows(idx).Selected = True
                dg_education_level.CurrentCell = dg_education_level.SelectedCells(1)

            Catch ex As Exception
                EXCEPTION_MESSAGE = ex.Message
                obj.ShowMsg("Cannot update", FrmMessageError, "Error.wav")
            End Try
        End If



    End Sub

    Private Sub dg_education_level_SelectionChanged(sender As Object, e As EventArgs) Handles dg_education_level.SelectionChanged
        Try
            'Refresh value in Combobox
            Call cbo_education_ID_DropDown(sender, e)
            Call cbo_education_level_ID_DropDown(sender, e)

            Call ClearEducationLevel()

            If dg_education_level.RowCount > 0 Then
                cbo_education_ID.Text = dg_education_level.SelectedRows(0).Cells(3).Value.ToString
                txt_school_name.Text = dg_education_level.SelectedRows(0).Cells(4).Value.ToString
                txt_place_of_study.Text = dg_education_level.SelectedRows(0).Cells(5).Value.ToString
                cbo_education_level_ID.Text = dg_education_level.SelectedRows(0).Cells(9).Value.ToString
                dt_start_date.Text = dg_education_level.SelectedRows(0).Cells(6).Value.ToString
                dt_end_date.Text = dg_education_level.SelectedRows(0).Cells(7).Value.ToString
                dt_date_recievd.Text = dg_education_level.SelectedRows(0).Cells(8).Value.ToString
                txt_remark.Text = dg_education_level.SelectedRows(0).Cells(10).Value.ToString

                If dg_education_level.SelectedCells(11).Value.ToString() = "" Then
                    pic_cerf.BackgroundImage = Nothing
                Else
                    Call obj.Show_Photo(dg_education_level.SelectedCells(11).Value, pic_cerf)
                End If

                lbl_education_save.Enabled = False
                lbl_edu_delete.Enabled = True
                lbl_edu_update.Enabled = True
                lbl_education_new.Enabled = True
            Else

                Call lbl_education_new_Click(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_edu_delete_Click(sender As Object, e As EventArgs) Handles lbl_edu_delete.Click
        Try
            If dg_education_level.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEACHER_EDUCATION where RECORD_ID = " & dg_education_level.SelectedRows(0).Cells(0).Value & "")
                    SelectTeacherEducation()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else
                obj.ShowMsg("មិនអាចធ្វើការលុបបានទេ", FrmMessageError, "Error.wav")
            End If
        Catch ex As Exception

        End Try
    End Sub
    'Minimize
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lbl_professional_save_Click(sender As Object, e As EventArgs) Handles lbl_professional_save.Click
        Try
            '/////  validation /////
            If cbo_professional_ID.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូល កម្រិតវិជ្ជាជីវៈ  ", FrmWarning, "")
                cbo_professional_ID.Focus()
                cbo_professional_ID.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txt_first_professional.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលយ៉ាងតិច​ ១ ឯកទេស  ", FrmWarning, "")
                txt_first_professional.Focus()
                txt_first_professional.BackColor = Color.LavenderBlush
                Exit Sub
            End If


            For Each row As DataGridViewRow In dg_teacher_professional.Rows
                If cbo_professional_ID.Text = row.Cells(2).Value Then
                    cbo_professional_ID.BackColor = Color.LavenderBlush
                    obj.ShowMsg("" & cbo_professional_ID.Text & " បានបញ្ចូលរួចរាល់", FrmWarning, "")
                    Exit Sub
                End If
            Next

            obj.Insert("INSERT into dbo.TBL_TEAHCER_PROFESSIONAL" & vbCrLf &
"(TEACHER_ID,PROFESSIONAL_ID,FIRST_PROFESSIONAL,SECOND_PROFESSIONAL," & vbCrLf &
"DATE_RECIEVE,DATE_NOTE,REMARK,SCHOOL_NAME,LOCATION" & vbCrLf &
") values" & vbCrLf &
"(" & dg_main.SelectedRows(0).Cells(0).Value & "," & cbo_professional_ID.SelectedValue & ",N'" & txt_first_professional.Text & "',N'" & txt_secend_professional.Text & "','" & dt_professional_date_receievd.Text & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "',N'" & txt_professional_remark.Text & "',N'" & txt_professional_school_name.Text & "',N'" & txt_professional_location.Text & "')")

            Call SelectTeacherProfessional()
            lbl_professional_save.Enabled = False
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub cbo_professional_ID_DropDown(sender As Object, e As EventArgs) Handles cbo_professional_ID.DropDown
        Try
            obj.BindComboBox("select PROFESSIONAL_ID,PROFESSIONAL_KH from dbo.TBL_PROFESSIONAL_LEVEL order by PROFESSIONAL_KH", cbo_professional_ID, "PROFESSIONAL_KH", "PROFESSIONAL_ID")
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("Can't get data from server !", FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub SelectTeacherProfessional()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT TP.RECORD_ID,ROW_NUMBER() OVER(ORDER BY TP.RECORD_ID ASC) AS 'ល.រ', PL.PROFESSIONAL_KH,TP.FIRST_PROFESSIONAL,TP.SECOND_PROFESSIONAL," & vbCrLf &
"TP.DATE_RECIEVE,TP.SCHOOL_NAME,TP.LOCATION,TP.REMARK FROM dbo.TBL_TEAHCER_PROFESSIONAL AS TP " & vbCrLf &
"INNER JOIN dbo.TBL_PROFESSIONAL_LEVEL AS PL ON TP.PROFESSIONAL_ID = PL.PROFESSIONAL_ID where TP.TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & " "
            obj.BindDataGridView(SqlQueryStr, dg_teacher_professional)
            Call SetDgTeacherProfessionalTitle()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("Can't get data from server !", FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub SetDgTeacherProfessionalTitle()
        'hide ID
        dg_teacher_professional.Columns(0).Visible = False

        dg_teacher_professional.Columns(1).HeaderText = "ល.រ"
        dg_teacher_professional.Columns(1).Width = 50

        dg_teacher_professional.Columns(2).HeaderText = "កម្រិតវិជ្ជាជីវៈ"
        dg_teacher_professional.Columns(2).Width = 250

        dg_teacher_professional.Columns(3).HeaderText = "ឯកទេសទី១"
        dg_teacher_professional.Columns(3).Width = 200

        dg_teacher_professional.Columns(4).HeaderText = "ឯកទេសទី២"
        dg_teacher_professional.Columns(4).Width = 200

        dg_teacher_professional.Columns(5).HeaderText = "ថ្ងៃទទួលបានឯកទេស"
        dg_teacher_professional.Columns(5).Width = 200

        dg_teacher_professional.Columns(6).HeaderText = "សាលា"
        dg_teacher_professional.Columns(6).Width = 200

        dg_teacher_professional.Columns(7).HeaderText = "ទីកន្លែងសិក្សា"
        dg_teacher_professional.Columns(7).Width = 200

        dg_teacher_professional.Columns(8).HeaderText = "ផ្សេងៗ"
        dg_teacher_professional.Columns(8).Width = 200
    End Sub

    Private Sub lbl_professional_new_Click(sender As Object, e As EventArgs) Handles lbl_professional_new.Click
        lbl_professional_save.Enabled = True
        lbl_professional_update.Enabled = False
        lbl_professional_delete.Enabled = False

        ClearTeacherProfessional()

        cbo_professional_ID.Focus()
    End Sub

    Private Sub ClearTeacherProfessional()
        cbo_professional_ID.Text = ""
        txt_first_professional.Clear()
        txt_secend_professional.Clear()
        dt_professional_date_receievd.Text = "1990-01-01"
        txt_professional_school_name.Clear()
        txt_professional_location.Clear()
        txt_professional_remark.Clear()

        '' cbo_professional_ID.Focus()
    End Sub

    Private Sub dg_teacher_professional_SelectionChanged(sender As Object, e As EventArgs) Handles dg_teacher_professional.SelectionChanged
        Try
            'Refresh combbox
            Call cbo_professional_ID_DropDown(sender, e)
            Call ClearTeacherProfessional()

            If dg_teacher_professional.RowCount > 0 Then
                cbo_professional_ID.Text = dg_teacher_professional.SelectedRows(0).Cells(2).Value.ToString
                txt_first_professional.Text = dg_teacher_professional.SelectedRows(0).Cells(3).Value.ToString
                txt_secend_professional.Text = dg_teacher_professional.SelectedRows(0).Cells(4).Value.ToString
                dt_professional_date_receievd.Text = dg_teacher_professional.SelectedRows(0).Cells(5).Value.ToString
                txt_professional_school_name.Text = dg_teacher_professional.SelectedRows(0).Cells(6).Value.ToString
                txt_professional_location.Text = dg_teacher_professional.SelectedRows(0).Cells(7).Value.ToString
                txt_professional_remark.Text = dg_teacher_professional.SelectedRows(0).Cells(8).Value.ToString


                lbl_professional_save.Enabled = False
                lbl_professional_delete.Enabled = True
                lbl_professional_update.Enabled = True
                lbl_professional_new.Enabled = True
            Else
                Call lbl_professional_new_Click(sender, e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lbl_professional_update_Click(sender As Object, e As EventArgs) Handles lbl_professional_update.Click
        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            Try
                idx = dg_teacher_professional.SelectedCells(0).RowIndex.ToString()

                '/////  validation /////
                If cbo_professional_ID.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូល កម្រិតវិជ្ជាជីវៈ  ", FrmWarning, "")
                    cbo_professional_ID.Focus()
                    cbo_professional_ID.BackColor = Color.LavenderBlush
                    Exit Sub
                End If
                If txt_first_professional.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលយ៉ាងតិច​ ១ ឯកទេស  ", FrmWarning, "")
                    txt_first_professional.Focus()
                    txt_first_professional.BackColor = Color.LavenderBlush
                    Exit Sub
                End If

                If (cbo_professional_ID.Text <> dg_teacher_professional.SelectedCells(2).Value.ToString) Then
                    For Each row As DataGridViewRow In dg_teacher_professional.Rows
                        If cbo_professional_ID.Text = row.Cells(2).Value Then
                            cbo_professional_ID.BackColor = Color.LavenderBlush
                            obj.ShowMsg("" & cbo_professional_ID.Text & " បានបញ្ចូលរួចរាល់", FrmWarning, "")
                            Exit Sub
                        End If
                    Next
                End If

                obj.Update("update dbo.TBL_TEAHCER_PROFESSIONAL set " & vbCrLf &
"PROFESSIONAL_ID =" & cbo_professional_ID.SelectedValue & "," & vbCrLf &
"FIRST_PROFESSIONAL = N'" & txt_first_professional.Text & "'," & vbCrLf &
"SECOND_PROFESSIONAL = N'" & txt_secend_professional.Text & "'," & vbCrLf &
"DATE_RECIEVE = '" & dt_professional_date_receievd.Text & "', " & vbCrLf &
"REMARK = N'" & txt_professional_remark.Text & "'," & vbCrLf &
"SCHOOL_NAME = N'" & txt_professional_school_name.Text & "'," & vbCrLf &
"LOCATION = N'" & txt_professional_location.Text & "'" & vbCrLf &
"where RECORD_ID = " & dg_teacher_professional.SelectedRows(0).Cells(0).Value & "")

                SelectTeacherProfessional()

                dg_teacher_professional.Rows(idx).Selected = True
                dg_teacher_professional.CurrentCell = dg_teacher_professional.SelectedCells(1)


            Catch ex As Exception
                EXCEPTION_MESSAGE = ex.Message
                obj.ShowMsg("Cannot update", FrmMessageError, "Error.wav")
            End Try

        End If


    End Sub

    Private Sub lbl_professional_delete_Click(sender As Object, e As EventArgs) Handles lbl_professional_delete.Click
        Try
            If dg_teacher_professional.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEAHCER_PROFESSIONAL where RECORD_ID = " & dg_teacher_professional.SelectedRows(0).Cells(0).Value & "")

                    SelectTeacherProfessional()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub lbl_tr_save_Click(sender As Object, e As EventArgs) Handles lbl_tr_save.Click
        Try
            '/////  validation /////
            If txt_trainning_course.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូល វគ្គខ្លីៗ   ", FrmWarning, "")
                txt_trainning_course.Focus()
                txt_trainning_course.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txt_duration.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលរយ:ពេលនៃការសិក្សាវគ្គខ្លីៗ", FrmWarning, "")
                txt_duration.Focus()
                txt_duration.BackColor = Color.LavenderBlush
                Exit Sub
            End If




            If dg_main.SelectedRows.Count > 0 Then
                obj.Insert("insert into dbo.TBL_TEACHER_TRAINING (" & vbCrLf &
"TEACHER_ID,TRAINING_COURCE,DURATION," & vbCrLf &
"DATE_START,DATE_END,ORGANIZE_BY,SPONSOR_BY,DATE_NOTE,LOCATION,SCHOOL_NAME" & vbCrLf &
")" & vbCrLf &
"values(" & dg_main.SelectedRows(0).Cells(0).Value & ",N'" & txt_trainning_course.Text & "',N'" & txt_duration.Text & "',N'" & dt_tr_date_start.Text & "','" & dt_tr_date_end.Text & "',N'" & txt_orgazine_by.Text & "',N'" & txt_sponsor_by.Text & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "',N'" & txt_tr_location.Text & "',N'" & txt_tr_school_name.Text & "')")
            End If


            Call SelectTeacherTrainning()
            '' lbl_professional_save.Enabled = False
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub SelectTeacherTrainning()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     RECORD_ID,ROW_NUMBER() OVER(ORDER BY RECORD_ID ASC) AS 'Order Number', TRAINING_COURCE, DURATION, DATE_START, DATE_END, ORGANIZE_BY, SPONSOR_BY, SCHOOL_NAME, LOCATION" & vbCrLf &
"FROM         dbo.TBL_TEACHER_TRAINING where TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & ""




            obj.BindDataGridView(SqlQueryStr, dg_trainning)
            SetTitleDgTrainning()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SetTitleDgTrainning()
        dg_trainning.Columns(0).Visible = False


        dg_trainning.Columns(1).HeaderText = "ល.រ"
        dg_trainning.Columns(1).Width = 50

        dg_trainning.Columns(2).HeaderText = "វគ្គខ្លីៗ"
        dg_trainning.Columns(2).Width = 400

        dg_trainning.Columns(3).HeaderText = "រយ:ពេល"
        dg_trainning.Columns(3).Width = 100

        dg_trainning.Columns(4).HeaderText = "ថ្ងៃចាប់ផ្តើម"
        dg_trainning.Columns(4).Width = 150

        dg_trainning.Columns(5).HeaderText = "ថ្ងៃបញ្ចប់"
        dg_trainning.Columns(5).Width = 150

        dg_trainning.Columns(6).HeaderText = "រៀបចំដោយ"
        dg_trainning.Columns(6).Width = 250

        dg_trainning.Columns(7).HeaderText = "ឧបត្ថម្ភដោយ"
        dg_trainning.Columns(7).Width = 250

        dg_trainning.Columns(8).HeaderText = "សាលា"
        dg_trainning.Columns(8).Width = 200

        dg_trainning.Columns(9).HeaderText = "ទីកន្លែងសិក្សា"
        dg_trainning.Columns(9).Width = 300

    End Sub

    Private Sub dg_trainning_SelectionChanged(sender As Object, e As EventArgs) Handles dg_trainning.SelectionChanged
        Try
            Call ClearLanagugue()

            If dg_trainning.RowCount > 0 Then
                txt_trainning_course.Text = dg_trainning.SelectedRows(0).Cells(2).Value.ToString
                txt_duration.Text = dg_trainning.SelectedRows(0).Cells(3).Value.ToString
                dt_tr_date_start.Text = dg_trainning.SelectedRows(0).Cells(4).Value.ToString
                dt_tr_date_end.Text = dg_trainning.SelectedRows(0).Cells(5).Value.ToString
                txt_orgazine_by.Text = dg_trainning.SelectedRows(0).Cells(6).Value.ToString
                txt_sponsor_by.Text = dg_trainning.SelectedRows(0).Cells(7).Value.ToString
                txt_tr_school_name.Text = dg_trainning.SelectedRows(0).Cells(8).Value.ToString
                txt_tr_location.Text = dg_trainning.SelectedRows(0).Cells(9).Value.ToString

                lbl_tr_save.Enabled = False
                lbl_tr_delete.Enabled = True
                lbl_tr_update.Enabled = True
                lbl_tr_new.Enabled = True

            Else
                lbl_lag_new_Click(sender, e)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_tr_new_Click(sender As Object, e As EventArgs) Handles lbl_tr_new.Click
        ClearTraningCourse()

        lbl_tr_save.Enabled = True
        lbl_tr_update.Enabled = False
        lbl_tr_delete.Enabled = False
        txt_trainning_course.Focus()


    End Sub

    Public Sub ClearTraningCourse()
        txt_trainning_course.Clear()
        txt_duration.Clear()
        dt_tr_date_start.Text = "1990-01-01"
        dt_tr_date_end.Text = "1990-01-01"
        txt_orgazine_by.Clear()
        txt_sponsor_by.Clear()
        txt_tr_school_name.Clear()
        txt_tr_location.Clear()


    End Sub

    Private Sub lbl_tr_update_Click(sender As Object, e As EventArgs) Handles lbl_tr_update.Click

        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            Try
                idx = dg_trainning.SelectedCells(0).RowIndex.ToString()

                '/////  validation /////
                If txt_trainning_course.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូល វគ្គខ្លីៗ   ", FrmWarning, "")
                    txt_trainning_course.Focus()
                    txt_trainning_course.BackColor = Color.LavenderBlush
                    Exit Sub
                End If
                If txt_duration.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលរយ:ពេលនៃការសិក្សាវគ្គខ្លីៗ", FrmWarning, "")
                    txt_duration.Focus()
                    txt_duration.BackColor = Color.LavenderBlush
                    Exit Sub
                End If


                If dg_trainning.SelectedRows.Count > 0 Then
                    obj.Update("update dbo.TBL_TEACHER_TRAINING set" & vbCrLf &
    " TRAINING_COURCE = N'" & txt_trainning_course.Text & "'," & vbCrLf &
    " DURATION = N'" & txt_duration.Text & "'," & vbCrLf &
    " DATE_START= '" & dt_tr_date_start.Text & "'," & vbCrLf &
    " DATE_END= '" & dt_tr_date_end.Text & "'," & vbCrLf &
    " ORGANIZE_BY= N'" & txt_orgazine_by.Text & "'," & vbCrLf &
    " SPONSOR_BY= N'" & txt_sponsor_by.Text & "'," & vbCrLf &
    " LOCATION= N'" & txt_tr_location.Text & "'," & vbCrLf &
    " SCHOOL_NAME= N'" & txt_tr_school_name.Text & "'" & vbCrLf &
    " where RECORD_ID =" & dg_trainning.SelectedRows(0).Cells(0).Value & "")
                End If
                SelectTeacherTrainning()
                dg_trainning.Rows(idx).Selected = True
                dg_trainning.CurrentCell = dg_trainning.SelectedCells(1)


            Catch ex As Exception
                EXCEPTION_MESSAGE = ex.Message
                obj.ShowMsg("Cannot update", FrmMessageError, "Error.wav")
            End Try
        End If
    End Sub


    Private Sub lbl_tr_delete_Click(sender As Object, e As EventArgs) Handles lbl_tr_delete.Click
        Try
            If dg_trainning.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEACHER_TRAINING where RECORD_ID = " & dg_trainning.SelectedRows(0).Cells(0).Value & "")

                    SelectTeacherTrainning()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo_lag_DropDown(sender As Object, e As EventArgs) Handles cbo_lag.DropDown
        Try
            obj.BindComboBox("select LANGUAGE_ID,LANGUAGE_KH from dbo.TBL_LANGUAGE", cbo_lag, "LANGUAGE_KH", "LANGUAGE_ID")
        Catch ex As Exception
            obj.ShowMsg("Cannot get data from server", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub lbl_lang_save_Click(sender As Object, e As EventArgs) Handles lbl_lang_save.Click
        Try


            '/////  validation /////
            If cbo_lag.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូល ភាសា", FrmWarning, "")
                cbo_lag.Focus()
                cbo_lag.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If cbo_read.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលកំរិតនៃការអាន", FrmWarning, "")
                cbo_read.Focus()
                cbo_read.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If cbo_write.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលកំរិតនៃការសរសេរ", FrmWarning, "")
                cbo_write.Focus()
                cbo_write.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If cbo_speak.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលកំរិតនៃការនិយាយ", FrmWarning, "")
                cbo_speak.Focus()
                cbo_speak.BackColor = Color.LavenderBlush
                Exit Sub
            End If


            For Each row As DataGridViewRow In dg_language.Rows
                If cbo_lag.Text = row.Cells(2).Value Then
                    obj.ShowMsg(cbo_lag.Text + " បានបញ្ចូលរួចរាល់ !", FrmWarning, "Error.wav")
                    Exit Sub
                End If
            Next


            If dg_main.SelectedRows.Count > 0 Then
                obj.Insert("insert into dbo.TBL_TEACHER_LANGUAGE (TEACHER_ID,LANGUAGE_ID,READING,SPEAKING,WRITING,DATE_NOTE) values" & vbCrLf &
                                                                        "(" & dg_main.SelectedRows(0).Cells(0).Value & "," & cbo_lag.SelectedValue & ",N'" & cbo_read.Text & "',N'" & cbo_speak.Text & "',N'" & cbo_write.Text & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')")
            End If


            Call SelectLanguage()

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Public Sub SelectLanguage()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT dbo.TBL_TEACHER_LANGUAGE.RECORD_ID,ROW_NUMBER() OVER(ORDER BY RECORD_ID ASC) AS 'Order number', dbo.TBL_LANGUAGE.LANGUAGE_KH, dbo.TBL_TEACHER_LANGUAGE.READING, dbo.TBL_TEACHER_LANGUAGE.SPEAKING,dbo.TBL_TEACHER_LANGUAGE.WRITING,dbo.TBL_TEACHER_LANGUAGE.DATE_NOTE,dbo.TBL_TEACHER_LANGUAGE.LANGUAGE_ID " & vbCrLf &
"FROM dbo.TBL_LANGUAGE INNER JOIN" & vbCrLf &
"                      dbo.TBL_TEACHER_LANGUAGE ON dbo.TBL_LANGUAGE.LANGUAGE_ID = dbo.TBL_TEACHER_LANGUAGE.LANGUAGE_ID where  TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & ""

            obj.BindDataGridView(SqlQueryStr, dg_language)
            SetTitleLangauge()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub
    Public Sub SetTitleLangauge()
        dg_language.Columns(0).Visible = False  'Hide ID 
        dg_language.Columns(1).HeaderText = "ល.រ"
        dg_language.Columns(1).Width = 60
        dg_language.Columns(2).HeaderText = "ភាសា"
        dg_language.Columns(2).Width = 200

        dg_language.Columns(3).HeaderText = "ការអាន"
        dg_language.Columns(3).Width = 180

        dg_language.Columns(4).HeaderText = "ការនិយាយ"
        dg_language.Columns(4).Width = 180

        dg_language.Columns(5).HeaderText = "ការសរសេរ"
        dg_language.Columns(5).Width = 180

        dg_language.Columns(6).Visible = False 'Hide Datenote
        dg_language.Columns(7).Visible = False  'Hide Langugue_ID
    End Sub

    Private Sub lbl_lag_new_Click(sender As Object, e As EventArgs) Handles lbl_lag_new.Click

        ClearLanagugue()

        lbl_lang_save.Enabled = True
        lbl_lang_update.Enabled = False
        lbl_lang_delete.Enabled = False
        cbo_lag.Focus()

    End Sub
    Public Sub ClearLanagugue()
        cbo_lag.Text = ""
        cbo_read.Text = ""
        cbo_write.Text = ""
        cbo_speak.Text = ""
        dt_lang_date_note.Text = Date.Today
    End Sub

    Private Sub dg_language_SelectionChanged(sender As Object, e As EventArgs) Handles dg_language.SelectionChanged
        Try

            Call cbo_lag_DropDown(sender, e)
            Call ClearLanagugue()

            If dg_language.RowCount > 0 Then
                cbo_lag.Text = dg_language.SelectedRows(0).Cells(2).Value.ToString
                cbo_read.Text = dg_language.SelectedRows(0).Cells(3).Value.ToString
                cbo_speak.Text = dg_language.SelectedRows(0).Cells(4).Value.ToString
                cbo_write.Text = dg_language.SelectedRows(0).Cells(5).Value.ToString
                dt_lang_date_note.Text = dg_language.SelectedRows(0).Cells(6).Value.ToString

                lbl_lang_save.Enabled = False
                lbl_lang_delete.Enabled = True
                lbl_lang_update.Enabled = True
                lbl_lag_new.Enabled = True

            Else
                lbl_lag_new_Click(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_lang_update_Click(sender As Object, e As EventArgs) Handles lbl_lang_update.Click

        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            Try
                idx = dg_language.SelectedCells(0).RowIndex.ToString()

                '/////  validation /////
                If cbo_lag.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូល ភាសា", FrmWarning, "")
                    cbo_lag.Focus()
                    cbo_lag.BackColor = Color.LavenderBlush
                    Exit Sub
                End If
                If cbo_read.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលកំរិតនៃការអាន", FrmWarning, "")
                    cbo_read.Focus()
                    cbo_read.BackColor = Color.LavenderBlush
                    Exit Sub
                End If
                If cbo_write.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលកំរិតនៃការសរសេរ", FrmWarning, "")
                    cbo_write.Focus()
                    cbo_write.BackColor = Color.LavenderBlush
                    Exit Sub
                End If
                If cbo_speak.Text = "" Then
                    obj.ShowMsg("សូមបញ្ចូលកំរិតនៃការនិយាយ", FrmWarning, "")
                    cbo_speak.Focus()
                    cbo_speak.BackColor = Color.LavenderBlush
                    Exit Sub
                End If

                If (cbo_lag.Text <> dg_language.SelectedCells(2).Value) Then
                    For Each row As DataGridViewRow In dg_language.Rows
                        If cbo_lag.Text = row.Cells(2).Value Then
                            obj.ShowMsg(cbo_lag.Text + " បានបញ្ចូលរួចរាល់ !", FrmWarning, "Error.wav")
                            Exit Sub
                        End If
                    Next
                End If

                obj.Update("UPDATE dbo.TBL_TEACHER_LANGUAGE SET LANGUAGE_ID = " & cbo_lag.SelectedValue & ",READING = N'" & cbo_read.Text & "',SPEAKING = N'" & cbo_speak.Text & "',WRITING = N'" & cbo_write.Text & "' WHERE TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & " AND LANGUAGE_ID = " & dg_language.SelectedRows(0).Cells(7).Value & " ")
                Call SelectLanguage()


                dg_language.Rows(idx).Selected = True
                dg_language.CurrentCell = dg_language.SelectedCells(1)


            Catch ex As Exception
                EXCEPTION_MESSAGE = ex.Message
                obj.ShowMsg("Problem while updating process... !", FrmMessageError, "Error.wav")
            End Try
        End If
    End Sub

    Private Sub lbl_lang_delete_Click(sender As Object, e As EventArgs) Handles lbl_lang_delete.Click
        Try
            If dg_language.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEACHER_LANGUAGE where RECORD_ID = " & dg_language.SelectedRows(0).Cells(0).Value & "")

                    Call SelectLanguage()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub









    Private Sub dg_letter_SelectionChanged(sender As Object, e As EventArgs) Handles dg_letter.SelectionChanged


    End Sub





    Private Sub lbl_spouse_new_Click(sender As Object, e As EventArgs) Handles lbl_spouse_new.Click

        txt_spouse_name_kh.Focus()
        pic_spouse.BackgroundImage = Nothing
        lbl_spouse_update.Enabled = False
        lbl_spouse_delete.Enabled = False
        lbl_spouse_save.Enabled = True

        Call ClearSpouse()
    End Sub

    Public Sub ClearSpouse()
        txt_spouse_name_kh.Clear()
        txt_spouse_name_en.Clear()
        dt_spouse_dob.Text = "1996-01-01"
        txt_spouse_remark.Clear()
        cbo_spouse_occupation.Text = ""
        txt_spouse_tel_1.Clear()
        txt_spouse_tel_2.Clear()
        dt_spouse_datenote.Text = Date.Today
    End Sub
    Private Sub lbl_spouse_save_Click(sender As Object, e As EventArgs) Handles lbl_spouse_save.Click
        Try




            If txt_spouse_name_kh.Text = "" Or cbo_spouse_occupation.Text = "" Or dt_spouse_dob.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")
                txt_spouse_name_kh.Focus()
                Exit Sub
            End If


            obj.Insert("insert into dbo.TBL_TEACHER_SPOUSE (" & vbCrLf &
"TEACHER_ID,SPOUSE_NAME_KH,SPOUSE_NAME_LATIN," & vbCrLf &
"SPOUSE_DOB,OCCUPATION_ID,PHONE_LINE_1,PHONE_LINE_2," & vbCrLf &
"DATE_NOTE,REMARK" & vbCrLf &
")values(" & dg_main.SelectedRows(0).Cells(0).Value & ",N'" & txt_spouse_name_kh.Text & "',N'" & txt_spouse_name_en.Text & "','" & dt_spouse_dob.Text & "'," & cbo_spouse_occupation.SelectedValue & ",N'" & txt_spouse_tel_1.Text & "',N'" & txt_spouse_tel_2.Text & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "',N'" & txt_spouse_remark.Text & "')")
            Call SelectSpouse()
            lbl_spouse_save.Enabled = False
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub cbo_spouse_occupation_DropDown(sender As Object, e As EventArgs) Handles cbo_spouse_occupation.DropDown
        Try
            obj.BindComboBox("select OCCUPATION_ID,OCCUPATION_KH from dbo.TBL_OCCUPATION", cbo_spouse_occupation, "OCCUPATION_KH", "OCCUPATION_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SelectSpouse()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     TP.RECORD_ID,ROW_NUMBER() OVER(ORDER BY TP.RECORD_ID ASC) AS 'Order Number', TP.SPOUSE_NAME_KH, TP.SPOUSE_NAME_LATIN, TP.SPOUSE_DOB, O.OCCUPATION_KH, TP.PHONE_LINE_1, TP.PHONE_LINE_2, TP.REMARK, TP.DATE_NOTE,TP.PHOTO" & vbCrLf &
"FROM         dbo.TBL_TEACHER_SPOUSE AS TP INNER JOIN" & vbCrLf &
"                      dbo.TBL_OCCUPATION AS O ON TP.OCCUPATION_ID = O.OCCUPATION_ID WHERE TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & ""

            obj.BindDataGridView(SqlQueryStr, dg_spouse)
            Call SetTitleSpouse()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub

    Public Sub SetTitleSpouse()
        dg_spouse.Columns(0).Visible = False

        dg_spouse.Columns(1).HeaderText = "ល.រ"
        dg_spouse.Columns(1).Width = 80

        dg_spouse.Columns(2).HeaderText = "ឈ្មោះខ្មែរ"
        dg_spouse.Columns(2).Width = 150

        dg_spouse.Columns(3).HeaderText = "ឈ្មោះឡាតាំង"
        dg_spouse.Columns(3).Width = 150

        dg_spouse.Columns(4).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        dg_spouse.Columns(4).Width = 180

        dg_spouse.Columns(5).HeaderText = "មុខរបរ"
        dg_spouse.Columns(5).Width = 170

        dg_spouse.Columns(6).HeaderText = "លេខទូរស័ព្ទទី១"
        dg_spouse.Columns(6).Width = 150

        dg_spouse.Columns(7).HeaderText = "លេខទូរស័ព្ទទី២"
        dg_spouse.Columns(7).Width = 150

        dg_spouse.Columns(8).HeaderText = "ផ្សេងៗ"
        dg_spouse.Columns(8).Width = 300

        dg_spouse.Columns(9).Visible = False
        dg_spouse.Columns(10).Visible = False
    End Sub

    Private Sub dg_spouse_SelectionChanged(sender As Object, e As EventArgs) Handles dg_spouse.SelectionChanged
        Try
            Call cbo_spouse_occupation_DropDown(sender, e)
            Call ClearSpouse()

            If dg_spouse.RowCount > 0 Then
                txt_spouse_name_kh.Text = dg_spouse.SelectedRows(0).Cells(2).Value.ToString
                txt_spouse_name_en.Text = dg_spouse.SelectedRows(0).Cells(3).Value.ToString
                dt_spouse_dob.Text = dg_spouse.SelectedRows(0).Cells(4).Value.ToString
                txt_spouse_remark.Text = dg_spouse.SelectedRows(0).Cells(8).Value.ToString
                cbo_spouse_occupation.Text = dg_spouse.SelectedRows(0).Cells(5).Value.ToString
                txt_spouse_tel_1.Text = dg_spouse.SelectedRows(0).Cells(6).Value.ToString
                txt_spouse_tel_2.Text = dg_spouse.SelectedRows(0).Cells(7).Value.ToString
                dt_spouse_datenote.Text = dg_spouse.SelectedRows(0).Cells(9).Value.ToString


                If dg_spouse.SelectedCells(10).Value.ToString() = "" Then
                    pic_spouse.BackgroundImage = Nothing
                Else
                    Call obj.Show_Photo(dg_spouse.SelectedCells(10).Value, pic_spouse)
                End If

                lbl_spouse_save.Enabled = False
                lbl_spouse_update.Enabled = True
                lbl_spouse_delete.Enabled = True
                lbl_spouse_new.Enabled = True

            Else
                lbl_spouse_new_Click(sender, e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lbl_spouse_update_Click(sender As Object, e As EventArgs) Handles lbl_spouse_update.Click
        Try
            idx = dg_spouse.SelectedCells(0).RowIndex.ToString()

            If txt_spouse_name_kh.Text = "" Or cbo_spouse_occupation.Text = "" Or dt_spouse_dob.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "ShowMessage.wav")
                txt_spouse_name_kh.Focus()
                Exit Sub
            End If

            obj.Update("update dbo.TBL_TEACHER_SPOUSE set " & vbCrLf &
"SPOUSE_NAME_KH = N'" & txt_spouse_name_kh.Text & "'," & vbCrLf &
"SPOUSE_NAME_LATIN = N'" & txt_spouse_name_en.Text & "'," & vbCrLf &
"SPOUSE_DOB = '" & dt_spouse_dob.Text & "'," & vbCrLf &
"OCCUPATION_ID = " & cbo_spouse_occupation.SelectedValue & "," & vbCrLf &
"PHONE_LINE_1 =N'" & txt_spouse_tel_1.Text & "'," & vbCrLf &
"PHONE_LINE_2 = N'" & txt_spouse_tel_2.Text & "'," & vbCrLf &
"REMARK = N'" & txt_spouse_remark.Text & "' where RECORD_ID = " & dg_spouse.SelectedRows(0).Cells(0).Value & " and TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & " and SPOUSE_NAME_KH = N'" & dg_spouse.SelectedRows(0).Cells(2).Value.ToString & "' ")


            Call SelectSpouse()
            'want when update selected current row
            dg_spouse.Rows(idx).Selected = True
            dg_spouse.CurrentCell = dg_spouse.SelectedCells(1)


        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("Cannot update", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub lbl_spouse_delete_Click(sender As Object, e As EventArgs) Handles lbl_spouse_delete.Click
        Try
            If dg_spouse.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "ShowMessage.wav")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEACHER_SPOUSE where RECORD_ID = " & dg_spouse.SelectedRows(0).Cells(0).Value & " and TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & " and SPOUSE_NAME_KH = N'" & dg_spouse.SelectedRows(0).Cells(2).Value.ToString & "'")

                    Call SelectSpouse()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub lbl_spouse_search_photo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_spouse_search_photo.LinkClicked
        Call obj.Browe(pic_spouse)
    End Sub

    Private Sub lbl_spouse_insert_photo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_spouse_insert_photo.LinkClicked
        Try
            If pic_spouse.BackgroundImage Is Nothing Then
                Call obj.ShowMsg("សូមជ្រើសរើសរូបភាពជាមុន!", FrmMessageError, "")
                Exit Sub
            End If
            Call obj.OpenConnection()
            Dim photo() As Byte = GetPhoto(photoFilePath)
            cmd = New SqlCommand("UPDATE dbo.TBL_TEACHER_SPOUSE SET PHOTO=@Photo where RECORD_ID = " & dg_spouse.SelectedRows(0).Cells(0).Value & " and TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & " and SPOUSE_NAME_KH = N'" & dg_spouse.SelectedRows(0).Cells(2).Value.ToString & "'  ", conn)
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            cmd.ExecuteNonQuery()
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            Call obj.ShowMsg("រូបភាពកែប្រែបានសម្រេច", FrmMessageSuccess, "")
            Call SelectTeacher()
            '' DG_Empoyee.Rows(idx).Selected = True
            '' DG_Empoyee.CurrentCell = DG_Empoyee.SelectedCells(1)
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("ពុំអាចកែប្រែរូបភាពបានទេ!", FrmMessageError, "")
        End Try
    End Sub

    Private Sub cbo_child_occupation_DropDown(sender As Object, e As EventArgs) Handles cbo_child_occupation.DropDown
        Try
            obj.BindComboBox("select OCCUPATION_ID,OCCUPATION_KH from dbo.TBL_OCCUPATION", cbo_child_occupation, "OCCUPATION_KH", "OCCUPATION_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbl_child_save_Click(sender As Object, e As EventArgs) Handles lbl_child_save.Click

        Try

            If txt_child_name_kh.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលឈ្មោះ", FrmWarning, "")
                txt_child_name_kh.Focus()
                txt_child_name_kh.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If cbo_child_sex.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលភេទ", FrmWarning, "")
                cbo_child_sex.Focus()
                cbo_child_sex.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If cbo_child_occupation.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលមុខរបរ", FrmWarning, "")
                cbo_child_occupation.Focus()
                cbo_child_occupation.BackColor = Color.LavenderBlush
                Exit Sub
            End If




            obj.Insert("insert into dbo.TBL_TEACHER_CHILDREN (" & vbCrLf &
"TEACHER_ID," & vbCrLf &
"CHILDREN_NAME_KH," & vbCrLf &
"CHILREN_LATIN," & vbCrLf &
"GENDER," & vbCrLf &
"CHILD_DOB," & vbCrLf &
"OCCUPATION_ID," & vbCrLf &
"REMARK," & vbCrLf &
"DATE_NOTE" & vbCrLf &
")values(" & dg_main.SelectedRows(0).Cells(0).Value & ",N'" & txt_child_name_kh.Text & "',N'" & txt_child_name_en.Text & "',N'" & cbo_child_sex.Text & "','" & dt_child_dob.Text & "'," & cbo_child_occupation.SelectedValue & ",N'" & txt_child_remark.Text & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')")

            Call SelectTeacherChildren()

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub SelectTeacherChildren()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     C.RECORD_ID,ROW_NUMBER() OVER(ORDER BY C.RECORD_ID ASC) AS 'Order Number', C.CHILDREN_NAME_KH, C.CHILREN_LATIN, C.GENDER, C.CHILD_DOB, O.OCCUPATION_KH, C.REMARK, C.DATE_NOTE, C.PHOTO" & vbCrLf &
"FROM         dbo.TBL_TEACHER_CHILDREN AS C INNER JOIN" & vbCrLf &
"                      dbo.TBL_OCCUPATION AS O ON C.OCCUPATION_ID = O.OCCUPATION_ID WHERE C.TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & ""

            obj.BindDataGridView(SqlQueryStr, dg_child)
            Call SettitleChild()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub SettitleChild()
        'hide ID
        dg_child.Columns(0).Visible = False

        dg_child.Columns(1).HeaderText = "ល.រ"
        dg_child.Columns(1).Width = 80

        dg_child.Columns(2).HeaderText = "ឈ្មោះខ្មែរ"
        dg_child.Columns(2).Width = 250

        dg_child.Columns(3).HeaderText = "ឈ្មោះឡាតាំង"
        dg_child.Columns(3).Width = 200

        dg_child.Columns(4).HeaderText = "ភេទ"
        dg_child.Columns(4).Width = 200

        dg_child.Columns(5).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        dg_child.Columns(5).Width = 200

        dg_child.Columns(6).HeaderText = "មុខរបរ"
        dg_child.Columns(6).Width = 200

        dg_child.Columns(7).HeaderText = "ផ្សេងៗ"

        dg_child.Columns(8).Visible = False 'DateNote
        dg_child.Columns(9).Visible = False 'Photo 


        dg_child.Columns(7).Width = 200
    End Sub

    Private Sub lbl_child_new_Click(sender As Object, e As EventArgs) Handles lbl_child_new.Click

        txt_child_name_kh.Focus()
        lbl_child_update.Enabled = False
        lbl_child_delete.Enabled = False
        lbl_child_save.Enabled = True

        Call ClearChildren()
    End Sub
    Public Sub ClearChildren()
        txt_child_name_kh.Clear()
        txt_child_name_en.Clear()
        cbo_child_sex.Text = ""
        dt_child_dob.Text = "1996-01-01"
        txt_child_remark.Clear()
        cbo_child_occupation.Text = ""
        dt_child_datenote.Text = Date.Today
        pic_child.BackgroundImage = Nothing
    End Sub
    Private Sub dg_child_SelectionChanged(sender As Object, e As EventArgs) Handles dg_child.SelectionChanged
        Try
            Call cbo_child_occupation_DropDown(sender, e)
            Call ClearChildren()

            If dg_child.RowCount > 0 Then
                txt_child_name_kh.Text = dg_child.SelectedRows(0).Cells(2).Value.ToString
                txt_child_name_en.Text = dg_child.SelectedRows(0).Cells(3).Value.ToString
                cbo_child_sex.Text = dg_child.SelectedRows(0).Cells(4).Value.ToString
                dt_child_dob.Text = dg_child.SelectedRows(0).Cells(5).Value.ToString
                txt_child_remark.Text = dg_child.SelectedRows(0).Cells(7).Value.ToString
                cbo_child_occupation.Text = dg_child.SelectedRows(0).Cells(6).Value.ToString
                dt_child_datenote.Text = dg_child.SelectedRows(0).Cells(8).Value.ToString



                If dg_child.SelectedCells(9).Value.ToString() = "" Then
                    pic_child.BackgroundImage = Nothing
                Else
                    Call obj.Show_Photo(dg_child.SelectedCells(9).Value, pic_child)
                End If

                lbl_child_save.Enabled = False
                lbl_child_update.Enabled = True
                lbl_child_delete.Enabled = True
                lbl_child_new.Enabled = True
            Else
                Call lbl_child_new_Click(sender, e)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_child_update_Click(sender As Object, e As EventArgs) Handles lbl_child_update.Click
        Try
            idx = dg_child.SelectedCells(0).RowIndex.ToString()

            If txt_child_name_kh.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលឈ្មោះ", FrmWarning, "")
                txt_child_name_kh.Focus()
                txt_child_name_kh.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If cbo_child_sex.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលភេទ", FrmWarning, "")
                cbo_child_sex.Focus()
                cbo_child_sex.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If cbo_child_occupation.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលមុខរបរ", FrmWarning, "")
                cbo_child_occupation.Focus()
                cbo_child_occupation.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            obj.Update("UPDATE dbo.TBL_TEACHER_CHILDREN SET CHILDREN_NAME_KH = N'" & txt_child_name_kh.Text & "',CHILREN_LATIN = N'" & txt_child_name_en.Text & "',GENDER = N'" & cbo_child_sex.Text & "',CHILD_DOB = '" & dt_child_dob.Text & "',OCCUPATION_ID = " & cbo_child_occupation.SelectedValue & ",REMARK = N'" & txt_child_remark.Text & "' WHERE TEACHER_ID =" & dg_main.SelectedRows(0).Cells(0).Value & " AND CHILDREN_NAME_KH = N'" & dg_child.SelectedRows(0).Cells(2).Value.ToString & "'")

            Call SelectTeacherChildren()
            'want when update selected current row
            dg_child.Rows(idx).Selected = True
            dg_child.CurrentCell = dg_child.SelectedCells(1)


        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("Cannot update", FrmMessageError, "")
        End Try
    End Sub

    Private Sub lbl_pic_child_search_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_pic_child_search.LinkClicked
        obj.Browe(pic_child)
    End Sub

    Private Sub lbl_pic_child_insert_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_pic_child_insert.LinkClicked
        Try
            If pic_child.BackgroundImage Is Nothing Then
                Call obj.ShowMsg("សូមជ្រើសរើសរូបភាពជាមុន!", FrmMessageError, "")
                Exit Sub
            End If

            idx = dg_child.SelectedCells(0).RowIndex.ToString()
            Call obj.OpenConnection()
            Dim photo() As Byte = GetPhoto(photoFilePath)
            cmd = New SqlCommand("UPDATE dbo.TBL_TEACHER_CHILDREN SET PHOTO=@Photo where TEACHER_ID =" & dg_main.SelectedRows(0).Cells(0).Value & " AND CHILDREN_NAME_KH = N'" & dg_child.SelectedRows(0).Cells(2).Value.ToString & "'", conn)
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            cmd.ExecuteNonQuery()
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            Call obj.ShowMsg("រូបភាពកែប្រែបានសម្រេច", FrmMessageSuccess, "")
            Call SelectTeacherChildren()
            dg_child.Rows(idx).Selected = True
            dg_child.CurrentCell = dg_child.SelectedCells(1)

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("ពុំអាចកែប្រែរូបភាពបានទេ!", FrmMessageError, "")
        End Try
    End Sub

    Private Sub lbl_child_delete_Click(sender As Object, e As EventArgs) Handles lbl_child_delete.Click
        Try
            If dg_spouse.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEACHER_CHILDREN where RECORD_ID = " & dg_child.SelectedRows(0).Cells(0).Value & " AND TEACHER_ID =" & dg_main.SelectedRows(0).Cells(0).Value & " AND CHILDREN_NAME_KH = N'" & dg_child.SelectedRows(0).Cells(2).Value.ToString & "' ")

                    Call SelectTeacherChildren()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub cbo_subject_DropDown(sender As Object, e As EventArgs) Handles cbo_subject.DropDown
        Try
            obj.BindComboBox("select SUBJECT_ID,SUBJECT_KH from dbo.TBL_SUBJECT", cbo_subject, "SUBJECT_KH", "SUBJECT_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_grade_DropDown(sender As Object, e As EventArgs) Handles cbo_grade.DropDown
        Try
            obj.BindComboBox("select GRADE_ID,GRADE from dbo.TBL_GRADE", cbo_grade, "GRADE", "GRADE_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_year_study_DropDown(sender As Object, e As EventArgs) Handles cbo_year_study.DropDown
        Try
            obj.BindComboBox("select YEAR_ID,YEAR_STUDY_KH from dbo.TBL_YEAR_STUDY", cbo_year_study, "YEAR_STUDY_KH", "YEAR_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbl_teaching_save_Click(sender As Object, e As EventArgs) Handles lbl_teaching_save.Click
        Try
            If cbo_grade.Text = "" Or cbo_subject.Text = "" Or cbo_year_study.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "")
                cbo_grade.Focus()
                Exit Sub
            End If

            'Insert 
            obj.Insert("insert into dbo.TBL_TEACHER_TEACH" & vbCrLf &
"(" & vbCrLf &
"TEACHER_ID,SUBJECT_ID,GRADE,YEAR_STUDY,DATE_NOTE" & vbCrLf &
")" & vbCrLf &
"values(" & dg_main.SelectedRows(0).Cells(0).Value & "," & cbo_subject.SelectedValue & "," & cbo_grade.Text & ",N'" & cbo_year_study.Text & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')")

            Call SelectTeacherTeaching()

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub SelectTeacherTeaching()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     T.RECORD_ID,ROW_NUMBER() OVER(ORDER BY T.RECORD_ID ASC) AS 'Order Number',  S.SUBJECT_KH, T.GRADE, T.YEAR_STUDY, T.DATE_NOTE" & vbCrLf &
"FROM         dbo.TBL_TEACHER_TEACH AS T INNER JOIN" & vbCrLf &
"                      dbo.TBL_SUBJECT AS S ON T.SUBJECT_ID = S.SUBJECT_ID WHERE TEACHER_ID =" & dg_main.SelectedRows(0).Cells(0).Value & ""
            obj.BindDataGridView(SqlQueryStr, dg_teaching)
            Call SettitleTeaching()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub SettitleTeaching()
        'hide ID
        dg_teaching.Columns(0).Visible = False

        dg_teaching.Columns(1).HeaderText = "ល.រ"
        dg_teaching.Columns(1).Width = 80

        dg_teaching.Columns(2).HeaderText = "មុខវិជ្ជា"
        dg_teaching.Columns(2).Width = 250

        dg_teaching.Columns(3).HeaderText = "ថ្នាក់"
        dg_teaching.Columns(3).Width = 200

        dg_teaching.Columns(4).HeaderText = "ឆ្នាំសិក្សា"
        dg_teaching.Columns(4).Width = 200

        dg_teaching.Columns(5).Visible = False




    End Sub

    Private Sub lbl_teaching_new_Click(sender As Object, e As EventArgs) Handles lbl_teaching_new.Click


        cbo_subject.Focus()
        lbl_teaching_update.Enabled = False
        lbl_teaching_delete.Enabled = False
        lbl_teaching_save.Enabled = True

        Call ClearTeaching()
    End Sub

    Private Sub ClearTeaching()
        cbo_subject.Text = ""
        cbo_grade.Text = ""
        cbo_year_study.Text = ""
        dt_teaching_datenote.Text = Date.Today
    End Sub
    Private Sub dg_teaching_SelectionChanged(sender As Object, e As EventArgs) Handles dg_teaching.SelectionChanged
        Try



            Call cbo_subject_DropDown(sender, e)
            Call cbo_grade_DropDown(sender, e)
            Call cbo_year_study_DropDown(sender, e)
            Call ClearTeaching()

            If dg_teaching.RowCount > 0 Then
                cbo_subject.Text = dg_teaching.SelectedRows(0).Cells(2).Value.ToString
                cbo_grade.Text = dg_teaching.SelectedRows(0).Cells(3).Value.ToString
                cbo_year_study.Text = dg_teaching.SelectedRows(0).Cells(4).Value.ToString
                dt_teaching_datenote.Text = dg_teaching.SelectedRows(0).Cells(5).Value.ToString

                lbl_teaching_save.Enabled = False
                lbl_teaching_update.Enabled = True
                lbl_teaching_delete.Enabled = True
                lbl_teaching_new.Enabled = True
            Else
                Call lbl_teaching_new_Click(sender, e)
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_teaching_update_Click(sender As Object, e As EventArgs) Handles lbl_teaching_update.Click
        Try
            idx = dg_teaching.SelectedCells(0).RowIndex.ToString()

            If cbo_grade.Text = "" Or cbo_subject.Text = "" Or cbo_year_study.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "")
                cbo_grade.Focus()
                Exit Sub
            End If

            obj.Update("update dbo.TBL_TEACHER_TEACH set" & vbCrLf &
  "SUBJECT_ID = " & cbo_subject.SelectedValue & " ,GRADE = " & cbo_grade.Text & ", YEAR_STUDY =N'" & cbo_year_study.Text & "'  where RECORD_ID = " & dg_teaching.SelectedRows(0).Cells(0).Value & " AND TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & ""
          )

            Call SelectTeacherTeaching()
            'want when update selected current row
            dg_teaching.Rows(idx).Selected = True
            dg_teaching.CurrentCell = dg_teaching.SelectedCells(1)


        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("Cannot update", FrmMessageError, "")
        End Try
    End Sub

    Private Sub lbl_teaching_delete_Click(sender As Object, e As EventArgs) Handles lbl_teaching_delete.Click
        Try
            If dg_teaching.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEACHER_TEACH where RECORD_ID = " & dg_teaching.SelectedRows(0).Cells(0).Value & " AND TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & "")

                    Call SelectTeacherTeaching()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub


    Private Sub lbl_professional_new_MouseHover(sender As Object, e As EventArgs) Handles lbl_professional_new.MouseHover
        SetHoverStyle(lbl_professional_new)
    End Sub

    Private Sub lbl_professional_new_MouseLeave(sender As Object, e As EventArgs) Handles lbl_professional_new.MouseLeave
        SetLeaveStyle(lbl_professional_new)
    End Sub

    Private Sub lbl_professional_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_professional_save.MouseHover
        SetHoverStyle(lbl_professional_save)
    End Sub

    Private Sub lbl_professional_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_professional_save.MouseLeave
        SetLeaveStyle(lbl_professional_save)
    End Sub

    Private Sub lbl_prfessional_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_professional_update.MouseHover
        SetHoverStyle(lbl_professional_update)
    End Sub

    Private Sub lbl_professional_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_professional_update.MouseLeave
        SetLeaveStyle(lbl_professional_update)
    End Sub

    Private Sub lbl_professional_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_professional_delete.MouseHover
        SetHoverStyle(lbl_professional_delete)

    End Sub

    Private Sub lbl_professional_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_professional_delete.MouseLeave
        SetLeaveStyle(lbl_professional_delete)
    End Sub

    Private Sub lbl_tr_new_MouseHover(sender As Object, e As EventArgs) Handles lbl_tr_new.MouseHover
        SetHoverStyle(lbl_tr_new)
    End Sub

    Private Sub lbl_tr_new_MouseLeave(sender As Object, e As EventArgs) Handles lbl_tr_new.MouseLeave
        SetLeaveStyle(lbl_tr_new)
    End Sub

    Private Sub lbl_tr_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_tr_save.MouseHover
        SetHoverStyle(lbl_tr_save)
    End Sub

    Private Sub lbl_tr_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_tr_save.MouseLeave
        SetLeaveStyle(lbl_tr_save)
    End Sub

    Private Sub lbl_tr_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_tr_update.MouseHover
        SetHoverStyle(lbl_tr_update)
    End Sub

    Private Sub lbl_tr_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_tr_update.MouseLeave
        SetLeaveStyle(lbl_tr_update)
    End Sub

    Private Sub lbl_tr_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_tr_delete.MouseHover
        SetHoverStyle(lbl_tr_delete)
    End Sub

    Private Sub lbl_tr_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_tr_delete.MouseLeave
        SetLeaveStyle(lbl_tr_delete)
    End Sub

    Private Sub lbl_lag_new_MouseHover(sender As Object, e As EventArgs) Handles lbl_lag_new.MouseHover
        SetHoverStyle(lbl_lag_new)
    End Sub

    Private Sub lbl_lag_new_MouseLeave(sender As Object, e As EventArgs) Handles lbl_lag_new.MouseLeave
        SetLeaveStyle(lbl_lag_new)
    End Sub

    Private Sub lbl_lang_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_lang_save.MouseHover
        SetHoverStyle(lbl_lang_save)

    End Sub

    Private Sub lbl_lang_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_lang_save.MouseLeave
        SetLeaveStyle(lbl_lang_save)

    End Sub

    Private Sub lbl_lang_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_lang_update.MouseHover
        SetHoverStyle(lbl_lang_update)

    End Sub

    Private Sub lbl_lang_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_lang_update.MouseLeave
        SetLeaveStyle(lbl_lang_update)
    End Sub

    Private Sub lbl_lang_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_lang_delete.MouseHover
        SetHoverStyle(lbl_lang_delete)
    End Sub

    Private Sub lbl_lang_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_lang_delete.MouseLeave
        SetLeaveStyle(lbl_lang_delete)
    End Sub

    Private Sub lbl_spouse_new_MouseHover(sender As Object, e As EventArgs) Handles lbl_spouse_new.MouseHover
        SetHoverStyle(lbl_spouse_new)
    End Sub

    Private Sub lbl_spouse_new_MouseLeave(sender As Object, e As EventArgs) Handles lbl_spouse_new.MouseLeave
        SetLeaveStyle(lbl_spouse_new)
    End Sub

    Private Sub lbl_spouse_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_spouse_save.MouseHover
        SetHoverStyle(lbl_spouse_save)
    End Sub

    Private Sub lbl_spouse_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_spouse_save.MouseLeave
        SetLeaveStyle(lbl_spouse_save)
    End Sub

    Private Sub lbl_spouse_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_spouse_update.MouseHover
        SetHoverStyle(lbl_spouse_update)
    End Sub

    Private Sub lbl_spouse_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_spouse_update.MouseLeave
        SetLeaveStyle(lbl_spouse_update)
    End Sub

    Private Sub lbl_spouse_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_spouse_delete.MouseHover
        SetHoverStyle(lbl_spouse_delete)
    End Sub

    Private Sub lbl_spouse_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_spouse_delete.MouseLeave
        SetLeaveStyle(lbl_spouse_delete)
    End Sub

    Private Sub lbl_spouse_search_photo_MouseHover(sender As Object, e As EventArgs) Handles lbl_spouse_search_photo.MouseHover
        SetHoverStyle(lbl_spouse_search_photo)
    End Sub

    Private Sub lbl_spouse_search_photo_MouseLeave(sender As Object, e As EventArgs) Handles lbl_spouse_search_photo.MouseLeave
        SetLeaveStyle(lbl_spouse_search_photo)
    End Sub

    Private Sub lbl_spouse_insert_photo_MouseHover(sender As Object, e As EventArgs) Handles lbl_spouse_insert_photo.MouseHover
        SetHoverStyle(lbl_spouse_insert_photo)
    End Sub

    Private Sub lbl_spouse_insert_photo_MouseLeave(sender As Object, e As EventArgs) Handles lbl_spouse_insert_photo.MouseLeave
        SetLeaveStyle(lbl_spouse_insert_photo)
    End Sub

    Private Sub lbl_child_new_MouseHover(sender As Object, e As EventArgs) Handles lbl_child_new.MouseHover
        SetHoverStyle(lbl_child_new)
    End Sub

    Private Sub lbl_child_new_MouseLeave(sender As Object, e As EventArgs) Handles lbl_child_new.MouseLeave
        SetLeaveStyle(lbl_child_new)
    End Sub

    Private Sub lbl_child_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_child_save.MouseHover
        SetHoverStyle(lbl_child_save)
    End Sub

    Private Sub lbl_child_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_child_save.MouseLeave
        SetLeaveStyle(lbl_child_save)

    End Sub

    Private Sub lbl_child_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_child_update.MouseHover
        SetHoverStyle(lbl_child_update)

    End Sub

    Private Sub lbl_child_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_child_update.MouseLeave
        SetLeaveStyle(lbl_child_update)

    End Sub

    Private Sub lbl_child_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_child_delete.MouseHover
        SetHoverStyle(lbl_child_delete)

    End Sub

    Private Sub lbl_child_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_child_delete.MouseLeave
        SetLeaveStyle(lbl_child_delete)

    End Sub

    Private Sub lbl_teaching_new_MouseHover(sender As Object, e As EventArgs) Handles lbl_teaching_new.MouseHover
        SetHoverStyle(lbl_teaching_new)
    End Sub

    Private Sub lbl_teaching_new_MouseLeave(sender As Object, e As EventArgs) Handles lbl_teaching_new.MouseLeave
        SetLeaveStyle(lbl_teaching_new)

    End Sub

    Private Sub lbl_teaching_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_teaching_save.MouseHover
        SetHoverStyle(lbl_teaching_save)
    End Sub

    Private Sub lbl_teaching_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_teaching_save.MouseLeave
        SetLeaveStyle(lbl_teaching_save)
    End Sub



    Private Sub lbl_teaching_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_teaching_update.MouseHover
        SetHoverStyle(lbl_teaching_update)
    End Sub

    Private Sub lbl_teaching_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_teaching_update.MouseLeave
        SetLeaveStyle(lbl_teaching_update)
    End Sub

    Private Sub lbl_teaching_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_teaching_delete.MouseHover
        SetHoverStyle(lbl_teaching_delete)
    End Sub

    Private Sub lbl_teaching_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_teaching_delete.MouseLeave
        SetLeaveStyle(lbl_teaching_delete)
    End Sub

    Private Sub btn_t_new_MouseHover(sender As Object, e As EventArgs) Handles btn_t_new.MouseHover
        SetHoverStyle(btn_t_new)
    End Sub

    Private Sub btn_t_new_MouseLeave(sender As Object, e As EventArgs) Handles btn_t_new.MouseLeave
        SetLeaveStyle(btn_t_new)
    End Sub

    Private Sub btn_T_save_MouseHover(sender As Object, e As EventArgs) Handles btn_T_save.MouseHover
        SetHoverStyle(btn_T_save)

    End Sub

    Private Sub btn_T_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_T_save.MouseLeave
        SetLeaveStyle(btn_T_save)

    End Sub

    Private Sub btn_t_update_MouseHover(sender As Object, e As EventArgs) Handles btn_t_update.MouseHover
        SetHoverStyle(btn_t_update)
    End Sub

    Private Sub btn_t_update_MouseLeave(sender As Object, e As EventArgs) Handles btn_t_update.MouseLeave
        SetLeaveStyle(btn_t_update)
    End Sub

    Private Sub btn_t_delete_MouseHover(sender As Object, e As EventArgs) Handles btn_t_delete.MouseHover
        SetHoverStyle(btn_t_delete)
    End Sub

    Private Sub btn_t_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_t_delete.MouseLeave
        SetLeaveStyle(btn_t_delete)
    End Sub

    Public Sub SetLeaveStyle(ByVal lbl As Label)
        lbl.ForeColor = Color.MediumBlue
    End Sub
    Public Sub SetHoverStyle(ByVal lbl As Label)
        lbl.ForeColor = Color.Red
    End Sub

    Private Sub btn_address_new_MouseHover(sender As Object, e As EventArgs) Handles btn_address_new.MouseHover
        SetHoverStyle(btn_address_new)
    End Sub

    Private Sub btn_address_new_MouseLeave(sender As Object, e As EventArgs) Handles btn_address_new.MouseLeave
        SetLeaveStyle(btn_address_new)
    End Sub

    Private Sub btn_address_save_MouseHover(sender As Object, e As EventArgs) Handles btn_address_save.MouseHover
        SetHoverStyle(btn_address_save)

    End Sub

    Private Sub btn_address_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_address_save.MouseLeave
        SetLeaveStyle(btn_address_save)

    End Sub

    Private Sub lbl_education_new_MouseHover(sender As Object, e As EventArgs) Handles lbl_education_new.MouseHover
        SetHoverStyle(lbl_education_new)

    End Sub

    Private Sub lbl_education_new_MouseLeave(sender As Object, e As EventArgs) Handles lbl_education_new.MouseLeave
        SetLeaveStyle(lbl_education_new)

    End Sub

    Private Sub lbl_education_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_education_save.MouseHover
        SetHoverStyle(lbl_education_save)

    End Sub

    Private Sub lbl_education_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_education_save.MouseLeave
        SetLeaveStyle(lbl_education_save)

    End Sub

    Private Sub lbl_edu_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_edu_update.MouseHover
        SetHoverStyle(lbl_edu_update)

    End Sub

    Private Sub lbl_edu_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_edu_update.MouseLeave
        SetLeaveStyle(lbl_edu_update)

    End Sub

    Private Sub lbl_edu_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_edu_delete.MouseHover
        SetHoverStyle(lbl_edu_delete)

    End Sub

    Private Sub lbl_edu_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_edu_delete.MouseLeave
        SetLeaveStyle(lbl_edu_delete)
    End Sub

    Private Sub lbl_staff_list_MouseHover(sender As Object, e As EventArgs) Handles lblTeacherNameList.MouseHover
        SetHoverStyle(lblTeacherNameList)

    End Sub

    Private Sub lbl_staff_list_MouseLeave(sender As Object, e As EventArgs) Handles lblTeacherNameList.MouseLeave
        SetLeaveStyle(lblTeacherNameList)
    End Sub

    Private Sub lbl_staff_background_MouseHover(sender As Object, e As EventArgs) Handles lblTeacherCV.MouseHover
        SetHoverStyle(lblTeacherCV)
    End Sub

    Private Sub lbl_staff_background_MouseLeave(sender As Object, e As EventArgs) Handles lblTeacherCV.MouseLeave
        SetLeaveStyle(lblTeacherCV)
    End Sub

    Private Sub cbo_staff_Code_DropDown(sender As Object, e As EventArgs) Handles cbo_staff_Code.DropDown
        obj.BindComboBox("SELECT TEACHER_CODE from dbo.TBL_TEACHER", cbo_staff_Code, "TEACHER_CODE", "TEACHER_CODE")
    End Sub


    Private Sub cbo_staff_Code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_staff_Code.SelectedIndexChanged
        Try
            obj.BindDataGridView(SqlSelectTeacher + "  AND T.TEACHER_CODE = N'" & cbo_staff_Code.Text & "'", dg_main)
            SetDgTeacherTitle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbl_adv_search_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_adv_search.LinkClicked
        PanelAdvSearch.BringToFront()
        Try
            If lbl_adv_search.Text = "ស្វែងរកកម្រិតខ្ពស់ >>>" Then
                Do While PanelAdvSearch.Width < 1010
                    PanelAdvSearch.Width += 4
                    Application.DoEvents()
                Loop
                PanelAdvSearch.Width = 1010
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

    Private Sub cbo_seach_teacher_name_DropDown(sender As Object, e As EventArgs) Handles cbo_seach_teacher_name.DropDown
        obj.BindComboBox("select  TEACHER_ID,T_NAME_KH from dbo.TBL_TEACHER", cbo_seach_teacher_name, "T_NAME_KH", "TEACHER_ID")
    End Sub

    Private Sub cbo_seach_teacher_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_seach_teacher_name.SelectedIndexChanged
        Try
            obj.BindDataGridView(SqlSelectTeacher + " AND T.T_NAME_KH = N'" & cbo_seach_teacher_name.Text & "'", dg_main)
            SetDgTeacherTitle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbl_display_all_MouseHover(sender As Object, e As EventArgs) Handles lbl_display_all.MouseHover
        SetHoverStyle(lbl_display_all)
    End Sub

    Private Sub lbl_display_all_MouseLeave(sender As Object, e As EventArgs) Handles lbl_display_all.MouseLeave
        SetLeaveStyle(lbl_display_all)
    End Sub

    Private Sub lbl_display_all_Click(sender As Object, e As EventArgs) Handles lbl_display_all.Click
        cbo_staff_Code.Text = ""
        cbo_seach_teacher_name.Text = ""
        Call SelectTeacher()
    End Sub

    Private Sub txt_ad_search_TextChanged(sender As Object, e As EventArgs) Handles txt_ad_search.TextChanged
        Try
            obj.BindDataGridView(SqlSelectTeacher + " AND CAST(T.TEACHER_ID AS NVARCHAR(50))+ CAST(T.T_ID_CARD AS NVARCHAR(50))+ISNULL(T.T_NAME_KH+T.T_NAME_LATIN,'') + ISNULL(R.RELIGION_KH,'') + ISNULL(T.GENDER,'') + CAST(T.DOB AS NVARCHAR(50)) LIKE N'%" & txt_ad_search.Text & "%'", dg_main)
            SetDgTeacherTitle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        frm_teacher_status.ShowDialog()
    End Sub



    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        frm_marry_status.ShowDialog()
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        frm_religion.ShowDialog()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        frm_salary_level.ShowDialog()
    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click
        frm_teacher_education.ShowDialog()
    End Sub

    Private Sub lbl_position_experience_Click(sender As Object, e As EventArgs) Handles lbl_position_experience.Click
        frm_position.ShowDialog()
    End Sub

    Private Sub cbo_ex_positon_DropDown(sender As Object, e As EventArgs) Handles cboExPosition.DropDown
        obj.BindComboBox("select POSITION_ID,POSITION from dbo.TBL_POSITION  order by ORDINAL_NUMBER", cboExPosition, "POSITION", "POSITION_ID")

    End Sub

    Private Sub lbl_ex_save_Click(sender As Object, e As EventArgs) Handles lbl_ex_save.Click

        Try

            If cboExPosition.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                cboExPosition.Focus()
                cboExPosition.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txtExCompany.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                txtExCompany.Focus()
                txtExCompany.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If (txtExSalary.Text = "") Then
                txtExSalary.Text = "0.00"
            End If


            obj.Insert("INSERT INTO dbo.TBL_TEACHER_EXPERIENCE(TEACHER_ID, POSITION_ID, COMPANY, HIREDATE, Location, STOP_DATE, SUPPORT, SALARY, DECRIPTION)VALUES(" & dg_main.SelectedRows(0).Cells(0).Value & "," & cboExPosition.SelectedValue & ",N'" & txtExCompany.Text & "','" & dtExHireDate.Text & "',N'" & txtExCompanyLocation.Text & "','" & dtExStopWork.Text & "',N'" & txtExSupport.Text & "'," & txtExSalary.Text & ",N'" & txtExRemark.Text & "')")
            Call SelectTeacherExperience()

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub SelectTeacherExperience()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     T.RECORD_ID,ROW_NUMBER() OVER(ORDER BY T.RECORD_ID ASC) AS 'Order Number', P.POSITION, T.COMPANY, T.HIREDATE, T.LOCATION, T.STOP_DATE, T.SUPPORT, T.SALARY, T.DECRIPTION,T.POSITION_ID" & vbCrLf &
"FROM         dbo.TBL_TEACHER_EXPERIENCE AS T INNER JOIN" & vbCrLf &
"                      dbo.TBL_POSITION AS P ON T.POSITION_ID = P.POSITION_ID WHERE T.TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & ""



            obj.BindDataGridView(SqlQueryStr, dg_ex)
            Call SetTitleExp()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub
    Private Sub SetTitleExp()
        'hide ID
        dg_ex.Columns(0).Visible = False

        dg_ex.Columns(1).HeaderText = "ល.រ"
        dg_ex.Columns(1).Width = 80

        dg_ex.Columns(2).HeaderText = "មុខដំណែង"
        dg_ex.Columns(2).Width = 200

        dg_ex.Columns(3).HeaderText = "ក្រុមហ៊ុន"
        dg_ex.Columns(3).Width = 300

        dg_ex.Columns(4).HeaderText = "ថ្ងៃចូលធ្វើការ"
        dg_ex.Columns(4).Width = 200

        dg_ex.Columns(5).HeaderText = "អាសយដ្ឋានក្រុមហ៊ុន"
        dg_ex.Columns(5).Width = 300

        dg_ex.Columns(6).HeaderText = "ថ្ងៃលាលែងពីការងារ"
        dg_ex.Columns(6).Width = 250

        dg_ex.Columns(7).HeaderText = "Support"
        dg_ex.Columns(7).Width = 200

        dg_ex.Columns(8).HeaderText = "ប្រាក់ខែ"
        dg_ex.Columns(8).Width = 150

        dg_ex.Columns(9).HeaderText = "ផ្សេងៗ"
        dg_ex.Columns(9).Width = 150

        dg_ex.Columns(10).Visible = False
    End Sub

    Private Sub lbl_ex_new_Click(sender As Object, e As EventArgs) Handles lbl_ex_new.Click
        cboExPosition.Focus()
        lbl_ex_update.Enabled = False
        lbl_ex_delete.Enabled = False
        lbl_ex_save.Enabled = True

        Call ClearEX()
    End Sub
    Public Sub ClearEX()

        cboExPosition.Text = ""
        txtExCompany.Clear()
        dtExHireDate.Text = Date.Today
        dtExStopWork.Text = Date.Today
        txtExSupport.Clear()
        txtExSalary.Clear()
        txtExCompanyLocation.Clear()
        txtExRemark.Clear()

    End Sub

    Private Sub dg_ex_SelectionChanged(sender As Object, e As EventArgs) Handles dg_ex.SelectionChanged
        Try
            Call cbo_ex_positon_DropDown(sender, e)
            Call ClearEX()

            If dg_ex.RowCount > 0 Then
                cboExPosition.Text = dg_ex.SelectedRows(0).Cells(2).Value.ToString
                txtExCompany.Text = dg_ex.SelectedRows(0).Cells(3).Value.ToString
                dtExHireDate.Text = dg_ex.SelectedRows(0).Cells(4).Value.ToString
                txtExCompanyLocation.Text = dg_ex.SelectedRows(0).Cells(5).Value.ToString
                dtExStopWork.Text = dg_ex.SelectedRows(0).Cells(6).Value.ToString
                txtExSupport.Text = dg_ex.SelectedRows(0).Cells(7).Value.ToString
                txtExSalary.Text = dg_ex.SelectedRows(0).Cells(8).Value.ToString
                txtExRemark.Text = dg_ex.SelectedRows(0).Cells(9).Value.ToString



                lbl_ex_save.Enabled = False
                lbl_ex_update.Enabled = True
                lbl_ex_delete.Enabled = True
                lbl_ex_new.Enabled = True

            Else
                lbl_ex_new_Click(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_ex_update_Click(sender As Object, e As EventArgs) Handles lbl_ex_update.Click
        Try
            idx = dg_ex.SelectedCells(0).RowIndex.ToString()
            'Validate
            If cboExPosition.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                cboExPosition.Focus()
                cboExPosition.BackColor = Color.LavenderBlush
                Exit Sub
            End If
            If txtExCompany.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                txtExCompany.Focus()
                txtExCompany.BackColor = Color.LavenderBlush
                Exit Sub
            End If

            If (txtExSalary.Text = "") Then
                txtExSalary.Text = "0.00"
            End If
            '--------------------------------------------

            obj.Update("UPDATE dbo.TBL_TEACHER_EXPERIENCE SET POSITION_ID = " & cboExPosition.SelectedValue & ",COMPANY = N'" & txtExCompany.Text & "',HIREDATE = '" & dtExHireDate.Text & "',LOCATION = N'" & txtExCompanyLocation.Text & "',STOP_DATE = '" & dtExStopWork.Text & "',SUPPORT = N'" & txtExSupport.Text & "',SALARY = " & CDbl(txtExSalary.Text) & " ,DECRIPTION = N'" & txtExRemark.Text & "' WHERE RECORD_ID = " & dg_ex.SelectedRows(0).Cells(0).Value & "AND TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & " AND POSITION_ID = " & dg_ex.SelectedRows(0).Cells(10).Value & " AND COMPANY = N'" & dg_ex.SelectedRows(0).Cells(3).Value & "' AND HIREDATE = '" & dg_ex.SelectedRows(0).Cells(4).Value & "'")
            Call SelectTeacherExperience()
            dg_ex.Rows(idx).Selected = True
            dg_ex.CurrentCell = dg_ex.SelectedCells(1)

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg("Cannot update", FrmMessageError, "")
        End Try
    End Sub

    Private Sub lbl_ex_delete_Click(sender As Object, e As EventArgs) Handles lbl_ex_delete.Click
        Try
            If dg_ex.SelectedRows.Count > 0 Then
                obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "")
                If USER_CLICK_OK = True Then
                    obj.Delete("delete from dbo.TBL_TEACHER_EXPERIENCE  WHERE RECORD_ID = " & dg_ex.SelectedRows(0).Cells(0).Value & "" & vbCrLf &
"AND TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & " AND POSITION_ID = " & dg_ex.SelectedRows(0).Cells(10).Value & " AND COMPANY = N'" & dg_ex.SelectedRows(0).Cells(3).Value & "' AND HIREDATE = '" & dg_ex.SelectedRows(0).Cells(4).Value & "'")

                    Call SelectTeacherExperience()
                    USER_CLICK_OK = False
                Else
                    Exit Sub
                End If
            Else

            End If
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub lbl_ex_new_MouseHover(sender As Object, e As EventArgs) Handles lbl_ex_new.MouseHover
        t.Hover(lbl_ex_new)

    End Sub

    Private Sub lbl_ex_new_MouseLeave(sender As Object, e As EventArgs) Handles lbl_ex_new.MouseLeave
        t.Leave(lbl_ex_new)
    End Sub

    Private Sub lbl_ex_save_MouseHover(sender As Object, e As EventArgs) Handles lbl_ex_save.MouseHover
        t.Hover(lbl_ex_save)

    End Sub

    Private Sub lbl_ex_save_MouseLeave(sender As Object, e As EventArgs) Handles lbl_ex_save.MouseLeave
        t.Leave(lbl_ex_save)
    End Sub

    Private Sub lbl_ex_update_MouseHover(sender As Object, e As EventArgs) Handles lbl_ex_update.MouseHover
        t.Hover(lbl_ex_update)

    End Sub

    Private Sub lbl_ex_update_MouseLeave(sender As Object, e As EventArgs) Handles lbl_ex_update.MouseLeave
        t.Leave(lbl_ex_update)
    End Sub

    Private Sub lbl_ex_delete_MouseLeave(sender As Object, e As EventArgs) Handles lbl_ex_delete.MouseLeave
        t.Leave(lbl_ex_delete)

    End Sub

    Private Sub lbl_ex_delete_MouseHover(sender As Object, e As EventArgs) Handles lbl_ex_delete.MouseHover
        t.Hover(lbl_ex_delete)
    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click
        frm_education_level.ShowDialog()
    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click
        frm_professional_level.ShowDialog()
    End Sub

    Private Sub Label89_Click(sender As Object, e As EventArgs) Handles Label89.Click
        frm_langugae.ShowDialog()
    End Sub

    Private Sub Label108_Click(sender As Object, e As EventArgs) Handles Label108.Click
        frm_occupation.ShowDialog()
    End Sub

    Private Sub Label116_Click(sender As Object, e As EventArgs) Handles Label116.Click
        frm_occupation.ShowDialog()
    End Sub

    Private Sub Label129_Click(sender As Object, e As EventArgs) Handles Label129.Click
        Try
            frm_subject.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo_T_marry_status_TextChanged(sender As Object, e As EventArgs) Handles cbo_T_marry_status.TextChanged
        cbo_T_marry_status.BackColor = Color.White

    End Sub

    Private Sub cbo_T_religion_ID_TextChanged(sender As Object, e As EventArgs) Handles cbo_T_religion_ID.TextChanged
        cbo_T_religion_ID.BackColor = Color.White

    End Sub

    Private Sub cbo_T_salary_level_ID_TextChanged(sender As Object, e As EventArgs) Handles cbo_T_salary_level_ID.TextChanged
        cbo_T_salary_level_ID.BackColor = Color.White

    End Sub

    Private Sub cbo_T_position_TextChanged(sender As Object, e As EventArgs) Handles cbo_T_position.TextChanged
        cbo_T_position.BackColor = Color.White

    End Sub

    Private Sub cbo_T_office_TextChanged(sender As Object, e As EventArgs) Handles cbo_T_office.TextChanged
        cbo_T_office.BackColor = Color.White

    End Sub

    Private Sub cbo_T_teacher_status_ID_TextChanged(sender As Object, e As EventArgs) Handles cbo_T_teacher_status_ID.TextChanged
        cbo_T_teacher_status_ID.BackColor = Color.White

    End Sub

    Private Sub cbo_T_gender_TextChanged(sender As Object, e As EventArgs) Handles cbo_T_gender.TextChanged
        cbo_T_gender.BackColor = Color.White

    End Sub


    Private Sub txt_T_name_kh_TextChanged(sender As Object, e As EventArgs) Handles txt_T_name_kh.TextChanged
        txt_T_name_kh.BackColor = Color.White

    End Sub

    Private Sub txt_T_ID_card_TextChanged(sender As Object, e As EventArgs) Handles txt_T_ID_card.TextChanged
        txt_T_ID_card.BackColor = Color.White

    End Sub

    Private Sub txt_T_teacher_code_TextChanged(sender As Object, e As EventArgs) Handles txt_T_teacher_code.TextChanged
        txt_T_teacher_code.BackColor = Color.White

    End Sub

    Private Sub txt_T_ID_card_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_T_ID_card.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SelectLetter()
        Try
            Dim SqlQueryStr As String
            SqlQueryStr = "SELECT     TL.TEACHER_LETTER_ID,ROW_NUMBER() OVER(ORDER BY TL.TEACHER_LETTER_ID ASC)AS 'ORDER_NUMBER',   TL.LETTER_NUMBER, T.T_NAME_KH, TL.LETTER_CONTENT, TL.DATE_NOTE, TL.DATE_LETTER, TT.LETTER_TYPE_KH, TL.REMARK, TL.FILE_ADDRESS" & vbCrLf &
"FROM         dbo.TBL_TEACHER_LETTER_PRAISE_BLAME_LETTER AS TL INNER JOIN" & vbCrLf &
"                      dbo.TBL_TEACHER AS T ON TL.TEACHER_ID = T.TEACHER_ID INNER JOIN" & vbCrLf &
"                      dbo.TBL_LETTER_TYPE AS TT ON TL.LETTER_TYPE_ID = TT.LETTER_TYPE_ID WHERE TL.TEACHER_ID = " & dg_main.SelectedRows(0).Cells(0).Value & " "
            obj.BindDataGridView(SqlQueryStr, dg_letter)
            Call SetTitleLetter()
        Catch ex As Exception
            obj.ShowMsg(ex.Message, FrmMessageError, "")
        End Try
    End Sub

    Private Sub SetTitleLetter()
        dg_letter.Columns(0).Visible = False 'Record ID
        dg_letter.Columns(9).Visible = False 'File
        dg_letter.Columns(5).Visible = False 'Datenote

        dg_letter.Columns(1).HeaderText = "លរ"
        dg_letter.Columns(1).Width = 50

        dg_letter.Columns(2).HeaderText = "លេខលិខិត"
        dg_letter.Columns(2).Width = 120

        dg_letter.Columns(3).HeaderText = "ឈ្មោះគ្រូបង្រៀន"
        dg_letter.Columns(3).Width = 180

        dg_letter.Columns(4).HeaderText = "ខ្លឹមសារលិខិត"
        dg_letter.Columns(4).Width = 500



        dg_letter.Columns(6).HeaderText = "ថ្ងៃខែទទួលលិខិត"
        dg_letter.Columns(6).Width = 200

        dg_letter.Columns(7).HeaderText = "ប្រភេទលិខិត"
        dg_letter.Columns(7).Width = 130

        dg_letter.Columns(8).HeaderText = "ផ្សេងៗ"
        dg_letter.Columns(8).Width = 500



    End Sub

    Private Sub lblCheckID_Click(sender As Object, e As EventArgs) Handles lblCheckID.Click
        If frm_class_monitor.CheckExisted("SELECT TEACHER_CODE FROM dbo.TBL_TEACHER WHERE TEACHER_CODE = N'" & txt_T_teacher_code.Text & "'", "TBL_TEACHER") = True Then
            obj.ShowMsg("លេខកូដមានរួចរាល់ហើយ", FrmWarning, "")
            txt_T_teacher_code.Select()
            txt_T_teacher_code.Focus()

        Else
            obj.ShowMsg("មិនទាន់មានលេខកូដនេះទេ", FrmMessageSuccess, "")
        End If
    End Sub

    Private Sub lblTeacherCV_Click(sender As Object, e As EventArgs) Handles lblTeacherCV.Click
        Teacher_CV.ShowDialog()
    End Sub

    Private Sub lblTeacherNameList_Click(sender As Object, e As EventArgs) Handles lblTeacherNameList.Click
        Try
            Teacher_list.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PanelEx2_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub cboExPosition_TextChanged(sender As Object, e As EventArgs) Handles cboExPosition.TextChanged
        cboExPosition.BackColor = Color.White
    End Sub

    Private Sub txtExCompany_TextChanged(sender As Object, e As EventArgs) Handles txtExCompany.TextChanged
        txtExCompany.BackColor = Color.White
    End Sub

    Private Sub cboExPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboExPosition.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_child_name_kh_TextChanged(sender As Object, e As EventArgs) Handles txt_child_name_kh.TextChanged
        txt_child_name_kh.BackColor = Color.White
    End Sub

    Private Sub cbo_child_sex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_child_sex.SelectedIndexChanged
        cbo_child_sex.BackColor = Color.White
    End Sub

    Private Sub cbo_child_occupation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_child_occupation.SelectedIndexChanged
        cbo_child_occupation.BackColor = Color.White
    End Sub

    Private Sub cbo_child_occupation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_child_occupation.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_education_ID_TextChanged(sender As Object, e As EventArgs) Handles cbo_education_ID.TextChanged
        cbo_education_ID.BackColor = Color.White
    End Sub

    Private Sub txt_school_name_TextChanged(sender As Object, e As EventArgs) Handles txt_school_name.TextChanged
        txt_school_name.BackColor = Color.White

    End Sub

    Private Sub cbo_education_level_ID_TextChanged(sender As Object, e As EventArgs) Handles cbo_education_level_ID.TextChanged
        cbo_education_level_ID.BackColor = Color.White

    End Sub

    Private Sub cbo_education_level_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_education_level_ID.KeyPress
        e.Handled = True

    End Sub

    Private Sub cbo_education_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_education_ID.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_professional_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_professional_ID.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_lag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_lag.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_read_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_read.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_speak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_speak.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_write_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_write.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_spouse_occupation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_spouse_occupation.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_child_sex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_child_sex.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_subject_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_subject.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_grade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_grade.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_year_study_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_year_study.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_professional_ID_TextChanged(sender As Object, e As EventArgs) Handles cbo_professional_ID.TextChanged
        cbo_professional_ID.BackColor = Color.White

    End Sub

    Private Sub txt_first_professional_TextChanged(sender As Object, e As EventArgs) Handles txt_first_professional.TextChanged
        txt_first_professional.BackColor = Color.White

    End Sub

    Private Sub txt_duration_TextChanged(sender As Object, e As EventArgs) Handles txt_duration.TextChanged
        txt_duration.BackColor = Color.White

    End Sub

    Private Sub txt_trainning_course_TextChanged(sender As Object, e As EventArgs) Handles txt_trainning_course.TextChanged
        txt_trainning_course.BackColor = Color.White
    End Sub

    Private Sub cbo_lag_TextChanged(sender As Object, e As EventArgs) Handles cbo_lag.TextChanged
        cbo_lag.BackColor = Color.White

    End Sub

    Private Sub cbo_read_TextChanged(sender As Object, e As EventArgs) Handles cbo_read.TextChanged
        cbo_read.BackColor = Color.White
    End Sub

    Private Sub cbo_speak_TextChanged(sender As Object, e As EventArgs) Handles cbo_speak.TextChanged
        cbo_speak.BackColor = Color.White

    End Sub

    Private Sub cbo_write_TextChanged(sender As Object, e As EventArgs) Handles cbo_write.TextChanged
        cbo_write.BackColor = Color.White
    End Sub
End Class
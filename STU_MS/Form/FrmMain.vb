Imports System.Data.SqlClient

Public Class FrmMain
    ReadOnly t As New Theme
    Dim obj As New Method



    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub lbl_student_info_Click(sender As Object, e As EventArgs) Handles lblStudent.Click
        Try
            FrmStudent.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lbl_student_score_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_student_score.Click
        Try
            frm_score.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lbl_student_langugue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_student_langugue.Click
        frm_langugae.ShowDialog()
    End Sub

    Private Sub lbl_subject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_subject.Click
        frm_subject.ShowDialog()
    End Sub



    Private Sub lbl_skill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_skill.Click
        frm_skill.ShowDialog()
    End Sub

    Private Sub lbl_group_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_group.Click
        frm_class.ShowDialog()
    End Sub









    Private Sub lbl_batch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_batch.Click
        frm_batchs.ShowDialog()
    End Sub



    Private Sub lbl_add_user_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_add_user.Click
        frm_add_user.ShowDialog()
    End Sub

    Private Sub lbl_edit_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_edit_user.Click
        frm_edit_user.ShowDialog()
    End Sub

    Private Sub lbl_enable_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_enable_user.Click
        frm_enable_user.ShowDialog()
    End Sub



    Private Sub lbl_change_password_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_change_password.Click
        frm_change_password.ShowDialog()
    End Sub



    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        obj.ShowMsg("តើអ្នកចង់ចាកចេញពីកម្មវិធីនេះដែលឬទេ ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            Environment.Exit(0)
        End If

    End Sub







































    '-----------------------------------------------------------------------------------------------------------'

    Private Sub pic_edituser_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_edituser.MouseMove
        Me.pic_edituser.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_changepassword_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_changepassword.MouseMove
        Me.pic_changepassword.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_enableuser_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_enableuser.MouseMove
        Me.pic_enableuser.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_adduser_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_adduser.MouseMove
        Me.pic_adduser.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_adduser_MouseLeave(sender As Object, e As EventArgs) Handles pic_adduser.MouseLeave
        Me.pic_adduser.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub pic_edituser_MouseLeave(sender As Object, e As EventArgs) Handles pic_edituser.MouseLeave
        Me.pic_edituser.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub pic_changepassword_MouseLeave(sender As Object, e As EventArgs) Handles pic_changepassword.MouseLeave
        Me.pic_changepassword.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub pic_enableuser_MouseLeave(sender As Object, e As EventArgs) Handles pic_enableuser.MouseLeave
        Me.pic_enableuser.Size = New System.Drawing.Size(33, 30)

    End Sub


    Private Sub pic_adduser_Click(sender As Object, e As EventArgs) Handles pic_adduser.Click
        frm_add_user.ShowDialog()
    End Sub

    Private Sub pic_edituser_Click(sender As Object, e As EventArgs) Handles pic_edituser.Click
        frm_edit_user.ShowDialog()
    End Sub

    Private Sub pic_changepassword_Click(sender As Object, e As EventArgs) Handles pic_changepassword.Click
        frm_change_password.ShowDialog()
    End Sub

    Private Sub pic_enableuser_Click(sender As Object, e As EventArgs) Handles pic_enableuser.Click
        frm_enable_user.ShowDialog()
    End Sub

    Private Sub pic_student_info_Click(sender As Object, e As EventArgs) Handles pic_student_info.Click
        FrmStudent.ShowDialog()
    End Sub

    Private Sub pic_score_Click(sender As Object, e As EventArgs) Handles pic_score.Click
        frm_score.ShowDialog()
    End Sub

    Private Sub pic_lang_Click(sender As Object, e As EventArgs) Handles pic_lang.Click
        frm_langugae.ShowDialog()
    End Sub

    Private Sub pic_subject_Click(sender As Object, e As EventArgs) Handles pic_subject.Click
        frm_subject.ShowDialog()

    End Sub



    Private Sub pic_skill_Click(sender As Object, e As EventArgs) Handles pic_skill.Click
        frm_skill.ShowDialog()
    End Sub

    Private Sub pic_class_Click(sender As Object, e As EventArgs) Handles pic_class.Click
        frm_grade.ShowDialog()

    End Sub





    Private Sub pic_batch_Click(sender As Object, e As EventArgs) Handles pic_batch.Click
        frm_batchs.ShowDialog()
    End Sub



    'Private Sub lbl_staff_MouseHover(sender As Object, e As EventArgs) Handles lbl_staff.MouseHover
    '    Me.lbl_staff.Font = New System.Drawing.Font("Khmer OS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Me.lbl_staff.ForeColor = Color.MidnightBlue
    'End Sub

    'Private Sub lbl_staff_MouseLeave(sender As Object, e As EventArgs) Handles lbl_staff.MouseLeave
    '    Me.lbl_staff.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '    Me.lbl_staff.ForeColor = Color.MediumBlue
    'End Sub
















    Private Sub pic_staff_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_staff.MouseMove
        Me.pic_staff.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_staff_MouseLeave(sender As Object, e As EventArgs) Handles pic_staff.MouseLeave
        Me.pic_staff.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub pic_salary_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_salary.MouseMove
        Me.pic_salary.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_salary_MouseLeave(sender As Object, e As EventArgs) Handles pic_salary.MouseLeave
        Me.pic_salary.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub pic_retired_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_retired.MouseMove
        Me.pic_retired.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_retired_MouseLeave(sender As Object, e As EventArgs) Handles pic_retired.MouseLeave
        Me.pic_retired.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub pic_skip_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_skip.MouseMove
        Me.pic_skip.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_skip_MouseLeave(sender As Object, e As EventArgs) Handles pic_skip.MouseLeave
        Me.pic_skip.Size = New System.Drawing.Size(33, 30)
    End Sub



    Private Sub pic_att_MouseMove(sender As Object, e As MouseEventArgs) Handles picStuAttendance.MouseMove
        Me.picStuAttendance.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_att_MouseLeave(sender As Object, e As EventArgs) Handles picStuAttendance.MouseLeave
        picStuAttendance.Size = New Size(33, 30)
    End Sub



    Private Sub pic_invite_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_invite.MouseMove
        pic_invite.Size = New Size(35, 33)
    End Sub

    Private Sub pic_invite_MouseLeave(sender As Object, e As EventArgs) Handles pic_invite.MouseLeave
        pic_invite.Size = New Size(33, 30)
    End Sub


    Private Sub pic_stu_card_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_stu_card.MouseMove
        pic_stu_card.Size = New Size(35, 33)
    End Sub

    Private Sub pic_stu_card_MouseLeave(sender As Object, e As EventArgs) Handles pic_stu_card.MouseLeave
        pic_stu_card.Size = New Size(33, 30)
    End Sub

    Private Sub pic_app_card_stu_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_app_card_stu.MouseMove
        pic_app_card_stu.Size = New Size(35, 33)
    End Sub

    Private Sub pic_app_card_stu_MouseLeave(sender As Object, e As EventArgs) Handles pic_app_card_stu.MouseLeave
        pic_app_card_stu.Size = New Size(33, 30)
    End Sub

    Private Sub pic_3_good_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_3_good.MouseMove
        pic_3_good.Size = New Size(35, 33)
    End Sub

    Private Sub pic_3_good_MouseLeave(sender As Object, e As EventArgs) Handles pic_3_good.MouseLeave
        pic_3_good.Size = New Size(33, 30)
    End Sub

    Private Sub pic_teacher_pp_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_teacher_pp.MouseMove
        pic_teacher_pp.Size = New Size(35, 33)
    End Sub

    Private Sub pic_teacher_pp_MouseLeave(sender As Object, e As EventArgs) Handles pic_teacher_pp.MouseLeave
        pic_teacher_pp.Size = New Size(33, 30)
    End Sub

    Private Sub pic_teacher_card_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_teacher_card.MouseMove
        pic_teacher_card.Size = New Size(35, 33)
    End Sub

    Private Sub pic_teacher_card_MouseLeave(sender As Object, e As EventArgs) Handles pic_teacher_card.MouseLeave
        pic_teacher_card.Size = New Size(33, 30)
    End Sub

    Private Sub pic_report_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_report.MouseMove
        pic_report.Size = New Size(35, 33)
    End Sub

    Private Sub pic_report_MouseLeave(sender As Object, e As EventArgs) Handles pic_report.MouseLeave
        pic_report.Size = New Size(33, 30)
    End Sub









    Private Sub pic_province_MouseLeave(sender As Object, e As EventArgs) Handles pic_province.MouseLeave
        pic_province.Size = New Size(33, 30)
    End Sub

    Private Sub pic_province_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_province.MouseMove
        pic_province.Size = New Size(35, 33)
    End Sub





    Private Sub pic_occupation_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_occupation.MouseMove
        pic_occupation.Size = New Size(35, 33)
    End Sub

    Private Sub pic_occupation_MouseLeave(sender As Object, e As EventArgs) Handles pic_occupation.MouseLeave
        pic_occupation.Size = New Size(33, 30)
    End Sub

    Private Sub lbl_occupation_Click(sender As Object, e As EventArgs) Handles lbl_occupation.Click
        frm_occupation.ShowDialog()
    End Sub

    Private Sub pic_occupation_Click(sender As Object, e As EventArgs) Handles pic_occupation.Click
        frm_occupation.ShowDialog()
    End Sub

    Private Sub lbl_province_Click(sender As Object, e As EventArgs) Handles lbl_province.Click
        frm_province.ShowDialog()
    End Sub

    Private Sub pic_province_Click(sender As Object, e As EventArgs) Handles pic_province.Click
        frm_province.ShowDialog()

    End Sub


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Enabled = True
            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
            Call Me.t.DefaultTheme_1()
            CompanyInfo.SetCompanyInfo(lblCompanyInfro)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub SetUpTheme()
        t.SetHeaderBackColor(pnl_header)
        t.SetColorExp(exp_user_info)
        t.SetColorExp(exp_staff)
        t.SetColorExp(exp_card)
        t.SetColorExp(exp_stu)
        t.SetColorExp(exp_other)
        t.SetColorExp(exp_maintainent)
        t.SetColorExp(exp_report)
        t.SetColorExp(exp_user_role)

        t.SetLabelForeColor(lbl_year_retire, lbl_office, lbl_position, lbl_user_name, lbl_user_exit, lbl_teacher_supspend, lbl_salary, lbl_staff, lbl_retired_staff, lbl_occupation, lbl_province, lbl_3_good, lbl_teacher_app, lbl_app_card_stu, lbl_teacher_card, lblStuCard, lbl_report, lbl_change_password, lbl_add_user, lbl_enable_user, lbl_edit_user, lbl_invite, lblStuAttendance, lbl_batch, lbl_group, lbl_skill, lbl_subject, lbl_student_langugue, lbl_student_score, lblStudent)
    End Sub

    Private Sub lbl_student_info_MouseHover(sender As Object, e As EventArgs) Handles lblStudent.MouseHover
        t.Hover(lblStudent)
    End Sub

    Private Sub lbl_att_MouseHover(sender As Object, e As EventArgs) Handles lblStuAttendance.MouseHover
        t.Hover(lblStuAttendance)
    End Sub

    Private Sub lbl_student_score_MouseHover(sender As Object, e As EventArgs) Handles lbl_student_score.MouseHover
        t.Hover(lbl_student_score)

    End Sub

    Private Sub lbl_student_langugue_MouseHover(sender As Object, e As EventArgs) Handles lbl_student_langugue.MouseHover
        t.Hover(lbl_student_langugue)

    End Sub

    Private Sub lbl_subject_MouseHover(sender As Object, e As EventArgs) Handles lbl_subject.MouseHover
        t.Hover(lbl_subject)

    End Sub

    Private Sub lbl_semester_MouseHover(sender As Object, e As EventArgs)


    End Sub

    Private Sub lbl_skill_MouseHover(sender As Object, e As EventArgs) Handles lbl_skill.MouseHover
        t.Hover(lbl_skill)

    End Sub

    Private Sub lbl_group_MouseHover(sender As Object, e As EventArgs) Handles lbl_group.MouseHover
        t.Hover(lbl_group)

    End Sub

    Private Sub lbl_invite_MouseHover(sender As Object, e As EventArgs) Handles lbl_invite.MouseHover
        t.Hover(lbl_invite)

    End Sub



    Private Sub lbl_batch_MouseHover(sender As Object, e As EventArgs) Handles lbl_batch.MouseHover
        t.Hover(lbl_batch)


    End Sub

    Private Sub lbl_student_info_MouseLeave(sender As Object, e As EventArgs) Handles lblStudent.MouseLeave
        t.Leave(lblStudent)

    End Sub

    Private Sub lbl_att_MouseLeave(sender As Object, e As EventArgs) Handles lblStuAttendance.MouseLeave
        t.Leave(lblStuAttendance)

    End Sub

    Private Sub lbl_student_score_MouseLeave(sender As Object, e As EventArgs) Handles lbl_student_score.MouseLeave
        t.Leave(lbl_student_score)

    End Sub

    Private Sub lbl_student_langugue_MouseLeave(sender As Object, e As EventArgs) Handles lbl_student_langugue.MouseLeave
        t.Leave(lbl_student_langugue)

    End Sub

    Private Sub lbl_subject_MouseLeave(sender As Object, e As EventArgs) Handles lbl_subject.MouseLeave
        t.Leave(lbl_subject)

    End Sub



    Private Sub lbl_skill_MouseLeave(sender As Object, e As EventArgs) Handles lbl_skill.MouseLeave
        t.Leave(lbl_skill)

    End Sub

    Private Sub lbl_group_MouseLeave(sender As Object, e As EventArgs) Handles lbl_group.MouseLeave
        t.Leave(lbl_group)

    End Sub

    Private Sub lbl_invite_MouseLeave(sender As Object, e As EventArgs) Handles lbl_invite.MouseLeave
        t.Leave(lbl_invite)

    End Sub



    Private Sub lbl_batch_MouseLeave(sender As Object, e As EventArgs) Handles lbl_batch.MouseLeave
        t.Leave(lbl_batch)
    End Sub

    '<--------------------------------->'
    Private Sub lbl_staff_MouseHover(sender As Object, e As EventArgs) Handles lbl_staff.MouseHover
        t.Hover(lbl_staff)
    End Sub
    Private Sub lbl_salary_MouseHover(sender As Object, e As EventArgs) Handles lbl_salary.MouseHover
        t.Hover(lbl_salary)

    End Sub
    Private Sub lbl_retired_staff_MouseHover(sender As Object, e As EventArgs) Handles lbl_retired_staff.MouseHover
        t.Hover(lbl_retired_staff)

    End Sub
    Private Sub lbl_skip_staff_MouseHover(sender As Object, e As EventArgs) Handles lbl_teacher_supspend.MouseHover
        t.Hover(lbl_teacher_supspend)

    End Sub

    Private Sub lbl_staff_MouseLeave(sender As Object, e As EventArgs) Handles lbl_staff.MouseLeave
        t.Leave(lbl_staff)
    End Sub
    Private Sub lbl_salary_MouseLeave(sender As Object, e As EventArgs) Handles lbl_salary.MouseLeave
        t.Leave(lbl_salary)

    End Sub
    Private Sub lbl_retired_staff_MouseLeave(sender As Object, e As EventArgs) Handles lbl_retired_staff.MouseLeave
        t.Leave(lbl_retired_staff)

    End Sub
    Private Sub lbl_skip_staff_MouseLeave(sender As Object, e As EventArgs) Handles lbl_teacher_supspend.MouseLeave
        t.Leave(lbl_teacher_supspend)

    End Sub

    Private Sub lbl_province_MouseHover(sender As Object, e As EventArgs) Handles lbl_province.MouseHover
        t.Hover(lbl_province)
    End Sub
    Private Sub lbl_occupation_MouseHover(sender As Object, e As EventArgs) Handles lbl_occupation.MouseHover
        t.Hover(lbl_occupation)
    End Sub
    Private Sub lbl_province_MouseLeave(sender As Object, e As EventArgs) Handles lbl_province.MouseLeave
        t.Leave(lbl_province)
    End Sub
    Private Sub lbl_occupation_MouseLeave(sender As Object, e As EventArgs) Handles lbl_occupation.MouseLeave
        t.Leave(lbl_occupation)
    End Sub

    Private Sub lbl_student_card_MouseHover(sender As Object, e As EventArgs) Handles lblStuCard.MouseHover
        t.Hover(lblStuCard)
    End Sub

    Private Sub lbl_student_card_MouseLeave(sender As Object, e As EventArgs) Handles lblStuCard.MouseLeave
        t.Leave(lblStuCard)
    End Sub

    Private Sub lbl_teacher_card_MouseHover(sender As Object, e As EventArgs) Handles lbl_teacher_card.MouseHover
        t.Hover(lbl_teacher_card)
    End Sub

    Private Sub lbl_teacher_card_MouseLeave(sender As Object, e As EventArgs) Handles lbl_teacher_card.MouseLeave
        t.Leave(lbl_teacher_card)
    End Sub

    Private Sub lbl_app_card_stu_MouseHover(sender As Object, e As EventArgs) Handles lbl_app_card_stu.MouseHover
        t.Hover(lbl_app_card_stu)
    End Sub

    Private Sub lbl_app_card_stu_MouseLeave(sender As Object, e As EventArgs) Handles lbl_app_card_stu.MouseLeave
        t.Leave(lbl_app_card_stu)
    End Sub

    Private Sub lbl_3_good_MouseHover(sender As Object, e As EventArgs) Handles lbl_3_good.MouseHover
        t.Hover(lbl_3_good)
    End Sub

    Private Sub lbl_3_good_MouseLeave(sender As Object, e As EventArgs) Handles lbl_3_good.MouseLeave
        t.Leave(lbl_3_good)
    End Sub

    Private Sub lbl_teacher_app_MouseHover(sender As Object, e As EventArgs) Handles lbl_teacher_app.MouseHover
        t.Hover(lbl_teacher_app)
    End Sub

    Private Sub lbl_teacher_app_MouseLeave(sender As Object, e As EventArgs) Handles lbl_teacher_app.MouseLeave
        t.Leave(lbl_teacher_app)
    End Sub
    Private Sub lbl_report_MouseHover(sender As Object, e As EventArgs) Handles lbl_report.MouseHover
        t.Hover(lbl_report)
    End Sub


    Private Sub lbl_report_MouseLeave(sender As Object, e As EventArgs) Handles lbl_report.MouseLeave
        t.Leave(lbl_report)
    End Sub

    Private Sub lbl_add_user_MouseHover(sender As Object, e As EventArgs) Handles lbl_add_user.MouseHover
        t.Hover(lbl_add_user)
    End Sub

    Private Sub lbl_edit_user_MouseHover(sender As Object, e As EventArgs) Handles lbl_edit_user.MouseHover
        t.Hover(lbl_edit_user)
    End Sub

    Private Sub lbl_change_password_MouseHover(sender As Object, e As EventArgs) Handles lbl_change_password.MouseHover
        t.Hover(lbl_change_password)
    End Sub

    Private Sub lbl_enable_user_MouseHover(sender As Object, e As EventArgs) Handles lbl_enable_user.MouseHover
        t.Hover(lbl_enable_user)
    End Sub

    Private Sub lbl_add_user_MouseLeave(sender As Object, e As EventArgs) Handles lbl_add_user.MouseLeave
        t.Leave(lbl_add_user)
    End Sub

    Private Sub lbl_edit_user_MouseLeave(sender As Object, e As EventArgs) Handles lbl_edit_user.MouseLeave
        t.Leave(lbl_edit_user)

    End Sub

    Private Sub lbl_change_password_MouseLeave(sender As Object, e As EventArgs) Handles lbl_change_password.MouseLeave
        t.Leave(lbl_change_password)
    End Sub

    Private Sub lbl_enable_user_MouseLeave(sender As Object, e As EventArgs) Handles lbl_enable_user.MouseLeave
        t.Leave(lbl_enable_user)
    End Sub









    Private Sub C_DodgerBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_SkyBlue.Click
        Call t.SkyBlue()
    End Sub

    Private Sub C_Default_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_Default.Click
        Call t.DefaultTheme()
    End Sub

    Private Sub C_Navy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_Green.Click
        Call t.Green()
    End Sub

    Private Sub C_Orange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_LightGreen.Click
        Call t.LightGreen()
    End Sub

    Private Sub C_Crismon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_DarkBlue.Click
        Call t.DarkBlue()
    End Sub



    Private Sub ButtonItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_Blue.Click
        Call t.Blue()
    End Sub


    Private Sub lbl_staff_Click(sender As Object, e As EventArgs) Handles lbl_staff.Click
        frm_teacher.ShowDialog()
    End Sub

    Private Sub lbl_position_MouseHover(sender As Object, e As EventArgs) Handles lbl_position.MouseHover
        t.Hover(lbl_position)
    End Sub

    Private Sub lbl_position_MouseLeave(sender As Object, e As EventArgs) Handles lbl_position.MouseLeave
        t.Leave(lbl_position)
    End Sub

    Private Sub pic_position_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_position.MouseMove
        Me.pic_position.Size = New System.Drawing.Size(35, 33)

    End Sub

    Private Sub pic_position_MouseLeave(sender As Object, e As EventArgs) Handles pic_position.MouseLeave
        Me.pic_position.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub pic_position_Click(sender As Object, e As EventArgs) Handles pic_position.Click
        frm_position.ShowDialog()
    End Sub

    Private Sub lbl_position_Click(sender As Object, e As EventArgs) Handles lbl_position.Click
        frm_position.ShowDialog()
    End Sub

    Private Sub pic_office_Click(sender As Object, e As EventArgs) Handles pic_office.Click
        frm_office.ShowDialog()
    End Sub

    Private Sub lbl_office_Click(sender As Object, e As EventArgs) Handles lbl_office.Click
        frm_office.ShowDialog()
    End Sub

    Private Sub pic_office_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_office.MouseMove
        Me.pic_office.Size = New System.Drawing.Size(35, 33)

    End Sub

    Private Sub pic_office_MouseLeave(sender As Object, e As EventArgs) Handles pic_office.MouseLeave
        Me.pic_office.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub lbl_office_MouseHover(sender As Object, e As EventArgs) Handles lbl_office.MouseHover
        t.Hover(lbl_office)

    End Sub

    Private Sub lbl_office_MouseLeave(sender As Object, e As EventArgs) Handles lbl_office.MouseLeave
        t.Leave(lbl_office)
    End Sub

    Private Sub lbl_year_retire_MouseLeave(sender As Object, e As EventArgs) Handles lbl_year_retire.MouseLeave
        t.Leave(lbl_year_retire)
    End Sub

    Private Sub lbl_year_retire_MouseHover(sender As Object, e As EventArgs) Handles lbl_year_retire.MouseHover
        t.Hover(lbl_year_retire)
    End Sub

    Private Sub PictureBox6_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseMove
        Me.PictureBox6.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        Me.PictureBox6.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frm_teacher_status.ShowDialog()
    End Sub

    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover
        t.Hover(Label5)
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        t.Leave(Label5)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frm_teacher_status.ShowDialog()
    End Sub

    Private Sub lbl_mission_MouseHover(sender As Object, e As EventArgs) Handles lbl_mission.MouseHover
        t.Hover(lbl_mission)
    End Sub

    Private Sub lbl_mission_MouseLeave(sender As Object, e As EventArgs) Handles lbl_mission.MouseLeave
        t.Leave(lbl_mission)
    End Sub

    Private Sub pic_mission_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_mission.MouseMove
        Me.pic_mission.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_mission_MouseLeave(sender As Object, e As EventArgs) Handles pic_mission.MouseLeave
        Me.pic_mission.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub lbl_mission_Click(sender As Object, e As EventArgs) Handles lbl_mission.Click
        frm_teacher_mission.ShowDialog()
    End Sub

    Private Sub pic_mission_Click(sender As Object, e As EventArgs) Handles pic_mission.Click
        frm_teacher_mission.ShowDialog()
    End Sub

    Private Sub lbl_salary_Click(sender As Object, e As EventArgs) Handles lbl_salary.Click
        Try
            frm_salary_level.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pic_salary_Click(sender As Object, e As EventArgs) Handles pic_salary.Click
        frm_salary_level.ShowDialog()
    End Sub

    Private Sub lbl_religion_MouseHover(sender As Object, e As EventArgs) Handles lbl_religion.MouseHover
        t.Hover(lbl_religion)
    End Sub

    Private Sub lbl_religion_MouseLeave(sender As Object, e As EventArgs) Handles lbl_religion.MouseLeave
        t.Leave(lbl_religion)
    End Sub

    Private Sub pic_religion_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_religion.MouseMove
        Me.pic_religion.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_religion_MouseLeave(sender As Object, e As EventArgs) Handles pic_religion.MouseLeave
        Me.pic_religion.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub lbl_religion_Click(sender As Object, e As EventArgs) Handles lbl_religion.Click
        Try
            frm_religion.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pic_religion_Click(sender As Object, e As EventArgs) Handles pic_religion.Click
        Try
            frm_religion.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pic_marry_status_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_marry_status.MouseMove
        Me.pic_marry_status.Size = New System.Drawing.Size(35, 33)

    End Sub

    Private Sub pic_marry_status_MouseUp(sender As Object, e As MouseEventArgs) Handles pic_marry_status.MouseUp
        Me.pic_marry_status.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub lbl_marry_status_MouseHover(sender As Object, e As EventArgs) Handles lbl_marry_status.MouseHover
        t.Hover(lbl_marry_status)
    End Sub

    Private Sub lbl_marry_status_MouseLeave(sender As Object, e As EventArgs) Handles lbl_marry_status.MouseLeave
        t.Leave(lbl_marry_status)


    End Sub

    Private Sub lbl_marry_status_Click(sender As Object, e As EventArgs) Handles lbl_marry_status.Click
        frm_marry_status.ShowDialog()
    End Sub



    Private Sub pic_marry_status_Click(sender As Object, e As EventArgs) Handles pic_marry_status.Click
        frm_marry_status.ShowDialog()

    End Sub

    Private Sub lbl_education_Click(sender As Object, e As EventArgs) Handles lbl_education.Click
        frm_teacher_education.ShowDialog()
    End Sub

    Private Sub lbl_education_MouseHover(sender As Object, e As EventArgs) Handles lbl_education.MouseHover
        t.Hover(lbl_education)
    End Sub

    Private Sub lbl_education_MouseLeave(sender As Object, e As EventArgs) Handles lbl_education.MouseLeave
        t.Leave(lbl_education)

    End Sub

    Private Sub pic_education_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_education.MouseMove
        Me.pic_education.Size = New System.Drawing.Size(35, 33)


    End Sub

    Private Sub pic_education_MouseLeave(sender As Object, e As EventArgs) Handles pic_education.MouseLeave
        Me.pic_education.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub pic_professsional_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_professsional.MouseMove
        Me.pic_professsional.Size = New System.Drawing.Size(35, 33)

    End Sub

    Private Sub pic_professsional_MouseLeave(sender As Object, e As EventArgs) Handles pic_professsional.MouseLeave
        Me.pic_professsional.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub lbl_professional_MouseHover(sender As Object, e As EventArgs) Handles lbl_professional.MouseHover
        t.Hover(lbl_professional)

    End Sub

    Private Sub lbl_professional_MouseLeave(sender As Object, e As EventArgs) Handles lbl_professional.MouseLeave
        t.Leave(lbl_professional)
    End Sub

    Private Sub lbl_professional_Click(sender As Object, e As EventArgs) Handles lbl_professional.Click
        frm_professional_level.ShowDialog()
    End Sub

    Private Sub pic_professsional_Click(sender As Object, e As EventArgs) Handles pic_professsional.Click
        frm_professional_level.ShowDialog()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lbl_user_exit_MouseLeave(sender As Object, e As EventArgs) Handles lbl_user_exit.MouseLeave
        t.Leave(lbl_user_exit)
    End Sub

    Private Sub lbl_user_exit_MouseHover(sender As Object, e As EventArgs) Handles lbl_user_exit.MouseHover
        t.Hover(lbl_user_exit)
    End Sub

    Private Sub lbl_user_exit_Click(sender As Object, e As EventArgs) Handles lbl_user_exit.Click
        USERNAME = ""
        USER_STATUS = ""
        PHOTO = Nothing
        FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub pic_blame_letter_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_blame_letter.MouseMove
        Me.pic_blame_letter.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_blame_letter_MouseLeave(sender As Object, e As EventArgs) Handles pic_blame_letter.MouseLeave
        Me.pic_blame_letter.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub lbl_blame_MouseHover(sender As Object, e As EventArgs) Handles lbl_blame.MouseHover
        t.Hover(lbl_blame)
    End Sub

    Private Sub lbl_blame_MouseLeave(sender As Object, e As EventArgs) Handles lbl_blame.MouseLeave
        t.Leave(lbl_blame)
    End Sub

    Private Sub lbl_blame_Click(sender As Object, e As EventArgs) Handles lbl_blame.Click
        frm_blame_letter.ShowDialog()
    End Sub

    Private Sub lbl_teacher_supspend_Click(sender As Object, e As EventArgs) Handles lbl_teacher_supspend.Click
        frm_teacher_suspend.ShowDialog()
    End Sub

    Private Sub pic_skip_Click(sender As Object, e As EventArgs) Handles pic_skip.Click
        frm_teacher_suspend.ShowDialog()

    End Sub

    Private Sub lbl_student_blame_letter_MouseHover(sender As Object, e As EventArgs) Handles lbl_student_blame_letter.MouseHover
        t.Hover(lbl_student_blame_letter)
    End Sub

    Private Sub lbl_student_blame_letter_MouseLeave(sender As Object, e As EventArgs) Handles lbl_student_blame_letter.MouseLeave
        t.Leave(lbl_student_blame_letter)
    End Sub

    Private Sub pic_stu_blame_letter_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_stu_blame_letter.MouseMove
        Me.pic_stu_blame_letter.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_stu_blame_letter_MouseLeave(sender As Object, e As EventArgs) Handles pic_stu_blame_letter.MouseLeave
        Me.pic_stu_blame_letter.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub lbl_promise_MouseHover(sender As Object, e As EventArgs) Handles lbl_promise.MouseHover
        t.Hover(lbl_promise)

    End Sub

    Private Sub lbl_promise_MouseLeave(sender As Object, e As EventArgs) Handles lbl_promise.MouseLeave
        t.Leave(lbl_promise)
    End Sub

    Private Sub pic_promise_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_promise.MouseMove
        Me.pic_promise.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_promise_MouseLeave(sender As Object, e As EventArgs) Handles pic_promise.MouseLeave
        Me.pic_promise.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub lbl_teacher_promise_MouseHover(sender As Object, e As EventArgs) Handles lbl_teacher_promise.MouseHover
        t.Hover(lbl_teacher_promise)

    End Sub

    Private Sub lbl_teacher_promise_MouseLeave(sender As Object, e As EventArgs) Handles lbl_teacher_promise.MouseLeave
        t.Leave(lbl_teacher_promise)

    End Sub

    Private Sub pic_teacher_promise_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_teacher_promise.MouseMove
        Me.pic_teacher_promise.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_teacher_promise_MouseLeave(sender As Object, e As EventArgs) Handles pic_teacher_promise.MouseLeave
        Me.pic_teacher_promise.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub lbl_student_education_Click(sender As Object, e As EventArgs) Handles lblStuEducation.Click
        frm_student_education.ShowDialog()
    End Sub

    Private Sub lbl_student_education_MouseHover(sender As Object, e As EventArgs) Handles lblStuEducation.MouseHover
        t.Hover(lblStuEducation)
    End Sub

    Private Sub lbl_student_education_MouseLeave(sender As Object, e As EventArgs) Handles lblStuEducation.MouseLeave
        t.Leave(lblStuEducation)
    End Sub

    Private Sub lbl_year_study_MouseHover(sender As Object, e As EventArgs) Handles lbl_year_study.MouseHover

        t.Hover(lbl_year_study)
    End Sub

    Private Sub lbl_year_study_MouseLeave(sender As Object, e As EventArgs) Handles lbl_year_study.MouseLeave
        t.Leave(lbl_year_study)
    End Sub

    Private Sub pic_year_study_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_year_study.MouseMove
        Me.pic_year_study.Size = New System.Drawing.Size(35, 33)

    End Sub

    Private Sub pic_year_study_MouseLeave(sender As Object, e As EventArgs) Handles pic_year_study.MouseLeave
        Me.pic_year_study.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub lbl_year_study_Click(sender As Object, e As EventArgs) Handles lbl_year_study.Click
        frm_year_study.ShowDialog()
    End Sub

    Private Sub pic_year_study_Click(sender As Object, e As EventArgs) Handles pic_year_study.Click
        frm_year_study.ShowDialog()
    End Sub

    Private Sub lbl_heath_Click(sender As Object, e As EventArgs) Handles lbl_heath.Click
        frm_heathy.ShowDialog()
    End Sub

    Private Sub pic_health_Click(sender As Object, e As EventArgs) Handles pic_health.Click
        frm_heathy.ShowDialog()
    End Sub

    Private Sub lbl_student_status_Click(sender As Object, e As EventArgs) Handles lbl_student_status.Click
        frm_student_status.ShowDialog()
    End Sub

    Private Sub pic_student_status_Click(sender As Object, e As EventArgs) Handles pic_student_status.Click
        frm_student_status.ShowDialog()

    End Sub


    Private Sub lbl_stu_stop_study_Click(sender As Object, e As EventArgs) Handles lbl_stu_stop_study.Click
        frm_student_stop_study.ShowDialog()
    End Sub

    Private Sub pic_stu_stop_study_Click(sender As Object, e As EventArgs) Handles pic_stu_stop_study.Click
        frm_student_stop_study.ShowDialog()

    End Sub

    Private Sub lbl_student_suspend_Click(sender As Object, e As EventArgs) Handles lbl_student_suspend.Click
        frm_student_suspent.ShowDialog()
    End Sub

    Private Sub pic_student_suspent_Click(sender As Object, e As EventArgs) Handles pic_student_suspent.Click
        frm_student_suspent.ShowDialog()
    End Sub

    Private Sub lbl_student_blame_letter_Click(sender As Object, e As EventArgs) Handles lbl_student_blame_letter.Click
        frm_student_blame_letter.ShowDialog()
    End Sub

    Private Sub pic_stu_blame_letter_Click(sender As Object, e As EventArgs) Handles pic_stu_blame_letter.Click
        frm_student_blame_letter.ShowDialog()

    End Sub

    Private Sub lbl_promise_Click(sender As Object, e As EventArgs) Handles lbl_promise.Click
        frm_student_contraction_mistake.ShowDialog()
    End Sub

    Private Sub pic_promise_Click(sender As Object, e As EventArgs) Handles pic_promise.Click
        frm_student_contraction_mistake.ShowDialog()
    End Sub

    Private Sub lbl_contract_mistake_type_Click(sender As Object, e As EventArgs) Handles lbl_contract_mistake_type.Click
        frm_contract_mistake_type.ShowDialog()
    End Sub

    Private Sub pic_contract_mistake_type_Click(sender As Object, e As EventArgs) Handles pic_contract_mistake_type.Click
        frm_contract_mistake_type.ShowDialog()
    End Sub

    Private Sub lbl_student_alumni_Click(sender As Object, e As EventArgs) Handles lbl_student_alumni.Click
        FrmStudentAlumini.ShowDialog()
    End Sub

    Private Sub pic_student_alumni_Click(sender As Object, e As EventArgs) Handles pic_student_alumni.Click
        FrmStudentAlumini.ShowDialog()
    End Sub

    Private Sub lbl_student_alumni_MouseHover(sender As Object, e As EventArgs) Handles lbl_student_alumni.MouseHover
        t.Hover(lbl_student_alumni)
    End Sub

    Private Sub lbl_student_alumni_MouseLeave(sender As Object, e As EventArgs) Handles lbl_student_alumni.MouseLeave

        t.Leave(lbl_student_alumni)
    End Sub

    Private Sub pic_student_alumni_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_student_alumni.MouseMove
        Me.pic_student_alumni.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_student_alumni_MouseLeave(sender As Object, e As EventArgs) Handles pic_student_alumni.MouseLeave

        Me.pic_student_alumni.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub lbl_student_suspend_MouseHover(sender As Object, e As EventArgs) Handles lbl_student_suspend.MouseHover
        t.Hover(lbl_student_suspend)
    End Sub

    Private Sub lbl_student_suspend_MouseLeave(sender As Object, e As EventArgs) Handles lbl_student_suspend.MouseLeave
        t.Leave(lbl_student_suspend)
    End Sub

    Private Sub pic_student_suspent_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_student_suspent.MouseMove
        Me.pic_student_suspent.Size = New System.Drawing.Size(35, 33)
    End Sub

    Private Sub pic_student_suspent_MouseLeave(sender As Object, e As EventArgs) Handles pic_student_suspent.MouseLeave

        Me.pic_student_suspent.Size = New System.Drawing.Size(33, 30)
    End Sub

    Private Sub lbl_stu_stop_study_MouseHover(sender As Object, e As EventArgs) Handles lbl_stu_stop_study.MouseHover
        t.Hover(lbl_stu_stop_study)
    End Sub

    Private Sub lbl_stu_stop_study_MouseLeave(sender As Object, e As EventArgs) Handles lbl_stu_stop_study.MouseLeave
        t.Leave(lbl_stu_stop_study)
    End Sub

    Private Sub pic_stu_stop_study_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_stu_stop_study.MouseMove
        Me.pic_stu_stop_study.Size = New System.Drawing.Size(35, 33)

    End Sub

    Private Sub pic_stu_stop_study_MouseLeave(sender As Object, e As EventArgs) Handles pic_stu_stop_study.MouseLeave
        Me.pic_stu_stop_study.Size = New System.Drawing.Size(33, 30)

    End Sub

    Private Sub Label7_MouseHover(sender As Object, e As EventArgs) Handles lblClassMonitor.MouseHover
        t.Hover(lblClassMonitor)
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles lblClassMonitor.MouseLeave
        t.Leave(lblClassMonitor)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblClassMonitor.Click
        frm_class_monitor.Show()
    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles picClassMonitor.Click
        frm_class_monitor.Show()
    End Sub

    Private Sub lbl_teacher_promise_Click(sender As Object, e As EventArgs) Handles lbl_teacher_promise.Click

    End Sub

    Private Sub lbl_report_Click(sender As Object, e As EventArgs) Handles lbl_report.Click
        FrmReport.ShowDialog()
    End Sub

    Private Sub lblTeacherMeetingAtt_Click(sender As Object, e As EventArgs) Handles lblTeacherMeetingAtt.Click
        FrmTeacherMeetingAtt.ShowDialog()

    End Sub

    Private Sub picTeacherMeetingAtt_Click(sender As Object, e As EventArgs) Handles picTeacherMeetingAtt.Click
        FrmTeacherMeetingAtt.ShowDialog()

    End Sub

    Private Sub lblSchool_Click(sender As Object, e As EventArgs) Handles lblSchool.Click
        frm_school.ShowDialog()
    End Sub

    Private Sub lblTeacherTransfer_Click(sender As Object, e As EventArgs) Handles lblTeacherTransfer.Click
        FrmTeacherTransfer.ShowDialog()
    End Sub

    Private Sub picSchool_Click(sender As Object, e As EventArgs) Handles picSchool.Click
        frm_school.ShowDialog()
    End Sub

    Private Sub lblStudentResult_Click(sender As Object, e As EventArgs) Handles lblStudentResult.Click
        FrmStudentResult912.ShowDialog()
    End Sub

    Private Sub lblStudentStatistic_Click(sender As Object, e As EventArgs) Handles lblStudentStatistic.Click
        FrmStudentStatistic.ShowDialog()
    End Sub

    Private Sub picStudentStatistic_Click(sender As Object, e As EventArgs) Handles picStudentStatistic.Click
        FrmStudentStatistic.ShowDialog()

    End Sub

    Private Sub lblStuCard_Click(sender As Object, e As EventArgs) Handles lblStuCard.Click
        FrmStuCard.ShowDialog()
    End Sub

    Private Sub lblStopReason_Click(sender As Object, e As EventArgs) Handles lblStopReason.Click
        Try
            FrmStudentDropStudyReason.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblCurrentDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub lblStudentFormer_Click(sender As Object, e As EventArgs) Handles lblStudentFormer.Click
        Try
            FrmStudentFormer.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblStudentFormer_MouseHover(sender As Object, e As EventArgs) Handles lblStudentFormer.MouseHover
        t.Hover(lblStudentFormer)
    End Sub

    Private Sub lblStudentFormer_MouseLeave(sender As Object, e As EventArgs) Handles lblStudentFormer.MouseLeave
        t.Leave(lblStudentFormer)
    End Sub

    Private Sub picStudentFormer_Click(sender As Object, e As EventArgs) Handles picStudentFormer.Click
        Try
            FrmStudentFormer.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub picStuEducation_MouseHover(sender As Object, e As EventArgs) Handles picStuEducation.MouseHover
        t.Hover(lblStuEducation)
    End Sub
    Private Sub picStuEducation_MouseLeave(sender As Object, e As EventArgs) Handles picStuEducation.MouseLeave
        t.Leave(lblStuEducation)
    End Sub
    Private Sub picStuEducation_Click(sender As Object, e As EventArgs) Handles picStuEducation.Click
        Try
            frm_student_education.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pic_student_info_MouseHover(sender As Object, e As EventArgs) Handles pic_student_info.MouseHover
        t.Hover(lblStudent)
    End Sub
    Private Sub pic_student_info_MouseLeave(sender As Object, e As EventArgs) Handles pic_student_info.MouseLeave
        t.Leave(lblStudent)
    End Sub
End Class
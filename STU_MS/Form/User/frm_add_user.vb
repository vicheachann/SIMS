Public Class frm_add_user
    Dim obj As New Method
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs)
    End Sub

    Private Sub btn_new_MouseHover(sender As Object, e As EventArgs)
    End Sub

    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs)
    End Sub

    Private Sub btn_new_MouseLeave(sender As Object, e As EventArgs)
    End Sub

    Private Sub lbl_save_Click(sender As Object, e As EventArgs) Handles lbl_save.Click
        Dim ValidateStatus As Boolean
        If cbo_staff.Text = "" Or txt_login_name.Text = "" Or cbo_user_status.Text = "" Or txt_password.Text = "" Or txt_confirm_password.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmMessageError, "Error.wav")

        End If
        If cbo_staff.Text = "" Then
            cbo_staff.BackColor = Color.LavenderBlush
            cbo_staff.Focus()
            ValidateStatus = False
        Else
            ValidateStatus = True
        End If
        If txt_login_name.Text = "" Then
            txt_login_name.BackColor = Color.LavenderBlush
            txt_login_name.Focus()
            ValidateStatus = False
        Else
            ValidateStatus = True
        End If
        If cbo_user_status.Text = "" Then
            cbo_user_status.BackColor = Color.LavenderBlush
            cbo_user_status.Focus()
            ValidateStatus = False
        Else
            ValidateStatus = True
        End If
        If txt_password.Text = "" Then
            txt_password.BackColor = Color.LavenderBlush
            txt_password.Focus()
            ValidateStatus = False
        Else
            ValidateStatus = True
        End If
        If txt_confirm_password.Text = "" Then
            txt_confirm_password.BackColor = Color.LavenderBlush
            txt_confirm_password.Focus()
            ValidateStatus = False
        Else
            ValidateStatus = True
        End If

        If ValidateStatus = False Then
            Exit Sub
        End If

        If txt_password.Text <> txt_confirm_password.Text Then
            txt_confirm_password.BackColor = Color.LavenderBlush
            obj.ShowMsg("បញ្ជាក់លេខសម្ងាត់មិនដូចគ្នា", FrmMessageError, "Error.wav")
            txt_confirm_password.Focus()
            Exit Sub
        End If






        Try
            obj.Insert("INSERT INTO dbo.TBL_USERS (EM_ID,[USER_NAME],[PASSWORD],USER_STATUS,CREATE_DATE,[DESCRIPTION],[STATUS],BY_STAFF)VALUES" & vbCrLf &
"(" & cbo_staff.SelectedValue & ",N'" & txt_login_name.Text & "',CONVERT(BINARY(50), '" & txt_password.Text & "', 0),N'" & cbo_user_status.Text & "',GETDATE(),N'" & txt_remark.Text & "',N'" & enable_user.Value.ToString & "'," & cbo_staff.SelectedValue & ")")
            Call Clear()
            Call Selection()


        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageError, "Error.wav")
        End Try
    End Sub
    Private Sub cbo_staff_TextChanged(sender As Object, e As EventArgs) Handles cbo_staff.TextChanged
        cbo_staff.BackColor = Color.White
    End Sub
    Private Sub txt_login_name_TextChanged(sender As Object, e As EventArgs) Handles txt_login_name.TextChanged
        txt_login_name.BackColor = Color.White
    End Sub
    Private Sub cbo_user_status_TextChanged(sender As Object, e As EventArgs) Handles cbo_user_status.TextChanged
        cbo_user_status.BackColor = Color.White
    End Sub
    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        txt_password.BackColor = Color.White
    End Sub
    Private Sub txt_confirm_password_TextChanged(sender As Object, e As EventArgs) Handles txt_confirm_password.TextChanged
        txt_confirm_password.BackColor = Color.White
    End Sub

    Private Sub cbo_staff_DropDown(sender As Object, e As EventArgs) Handles cbo_staff.DropDown
        obj.BindComboBox("select TEACHER_ID,T_NAME_KH from dbo.TBL_TEACHER", cbo_staff, "T_NAME_KH", "TEACHER_ID")

    End Sub

    Public Sub Selection()
        obj.OpenConnection()

        Try
            obj.BindDataGridView("SELECT     U.USER_ID,ROW_NUMBER ()OVER(ORDER BY U.USER_ID ASC)AS 'ORDER_NUMBER',  U.EM_ID, T.T_NAME_KH, U.USER_NAME, U.USER_STATUS, CONVERT(NVARCHAR(10), U.CREATE_DATE,105) AS 'Create Date', U.DESCRIPTION," & vbCrLf &
" U.STATUS, U.BY_STAFF, T.T_NAME_KH AS Expr1" & vbCrLf &
"FROM         dbo.TBL_TEACHER AS T INNER JOIN" & vbCrLf &
"                      dbo.TBL_USERS AS U ON T.TEACHER_ID = U.EM_ID", datagrid)
            datagrid.Columns(0).Visible = False
            datagrid.Columns(2).Visible = False ' EM_ID
            datagrid.Columns(9).Visible = False 'BY_STAFF

            datagrid.Columns(1).HeaderText = "លរ"
            datagrid.Columns(1).Width = 50
            datagrid.Columns(3).HeaderText = "ឈ្មោះបុគ្គលិក"
            datagrid.Columns(3).Width = 200
            datagrid.Columns(4).HeaderText = "Username"
            datagrid.Columns(4).Width = 200
            datagrid.Columns(5).HeaderText = "ប្រភេទអ្នកប្រើប្រាស់"
            datagrid.Columns(5).Width = 200
            datagrid.Columns(6).HeaderText = "ថ្ងៃបង្កើត"
            datagrid.Columns(6).Width = 150
            datagrid.Columns(7).HeaderText = "ផ្សេងៗ"
            datagrid.Columns(7).Width = 200
            datagrid.Columns(8).HeaderText = "បើកសិទ្ធិ"
            datagrid.Columns(8).Width = 100
            datagrid.Columns(10).HeaderText = "បញ្ចូលដោយបុគ្គលិក"
            datagrid.Columns(10).Width = 200

            'datagrid.Columns(10).Visible = False



        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_add_user_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Selection()
    End Sub

    Private Sub lbl_new_Click(sender As Object, e As EventArgs) Handles lbl_new.Click
        Call Clear()
        cbo_staff.Focus()
    End Sub
    Private Sub Clear()
        cbo_staff.Text = ""
        txt_login_name.Clear()
        cbo_user_status.Text = ""
        enable_user.Value = True
        txt_password.Clear()
        txt_confirm_password.Clear()
        txt_remark.Clear()
        dt_datenote.Text = Date.Today
    End Sub
End Class
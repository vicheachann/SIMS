Public Class frm_edit_user
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
    Private Sub clear()
        txt_new_username.Clear()
        txt_remark.Clear()

    End Sub
   
    
    Private Sub cbo_user_DropDown(sender As Object, e As EventArgs) Handles cbo_user.DropDown
        obj.BindComboBox("SELECT USER_ID,USER_NAME FROM dbo.TBL_USERS", cbo_user, "USER_NAME", "USER_ID")
        Call clear()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        If cbo_user.Text = "" Or txt_new_username.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "Error.wav")
            txt_new_username.Focus()
            Exit Sub
        End If

        obj.Update("UPDATE dbo.TBL_USERS SET USER_NAME = N'" & txt_new_username.Text & "', DESCRIPTION = N'" & txt_remark.Text & "' WHERE USER_ID =" & cbo_user.SelectedValue & " ")
        frm_add_user.selection()
    End Sub

    Private Sub cbo_user_DropDownClosed(sender As Object, e As EventArgs) Handles cbo_user.DropDownClosed
        txt_new_username.Focus()
    End Sub
End Class
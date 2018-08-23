Public Class frm_change_password
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



    Private Sub cboUser_DropDown(sender As Object, e As EventArgs) Handles cboUser.DropDown
        obj.BindComboBox("SELECT USER_NAME FROM dbo.TBL_USERS ORDER BY USER_NAME", cboUser, "USER_NAME", "USER_NAME")
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        obj.GetPassword(cboUser.Text)

        If String.Compare(txt_old_password.Text, USER_PASSWORD.ToString, False) = 1 Then
            Call obj.ShowMsg("ពាក្យសម្ងាត់មិនត្រឹមត្រូវ", FrmWarning, "Error.wav")
            Exit Sub
        End If

        If txt_new_password.Text <> txt_confirm_new_password.Text Then
            Call obj.ShowMsg("ពាក្យសម្ងាត់មិនដូចគ្នា", FrmWarning, "Error.wav")

            Exit Sub
        End If

        If txt_old_password.Text = txt_new_password.Text Then
            Call obj.ShowMsg("ពាក្យសម្ងាត់ថ្មីមិនអាចចូចពាក្យសម្ងាត់ចាស់", FrmWarning, "Error.wav")
            Exit Sub
        End If

        obj.Update("UPDATE dbo.TBL_USERS SET PASSWORD = CONVERT(BINARY(50),'" & txt_new_password.Text & "') WHERE USER_NAME = N'" & cboUser.Text & "'")
    End Sub
End Class
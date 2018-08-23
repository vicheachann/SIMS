Public Class frm_enable_user
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



    Private Sub cbo_user_DropDown(sender As Object, e As EventArgs) Handles cbo_user.DropDown
        obj.BindComboBox("SELECT USER_ID,USER_NAME FROM dbo.TBL_USERS", cbo_user, "USER_NAME", "USER_ID")

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If cbo_user.Text = "" Then
            obj.ShowMsg("សូមជ្រើសរើសអ្នកប្រើប្រាស់ជាមុន", FrmWarning, "Error.wav")
            cbo_user.Focus()
            Exit Sub
        End If

        Try
            Dim a As String
            If enable.Value = True Then
                a = "Enable"
            Else
                a = "Disalbe"
            End If
            Call obj.Update_1("UPDATE TBL_USERS SET [STATUS] = '" & enable.Value.ToString & "' WHERE USER_NAME = N'" & cbo_user.Text & "' ")
            obj.ShowMsg("ព័ត៌មានអ្នកប្រើប្រាស់ត្រូវបានកែប្រែជោគជ័យ", FrmMessageSuccess, "")
            frm_add_user.Selection()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            obj.ShowMsg("មិនអាចធ្វើការកែប្រែបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub
End Class
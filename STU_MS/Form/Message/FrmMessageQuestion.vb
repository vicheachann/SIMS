Public Class FrmMessageQuestion

    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btnOkClick(sender As Object, e As EventArgs) Handles btnOk.Click
        USER_CLICK_OK = True
        Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNO.Click
        USER_CLICK_OK = False
        Close()
    End Sub

    Private Sub FrmMessageQuestion_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblMessage.Text = _MessageTitile
        lblTitle.Text = CompanyInfo.CompanyName.ToString
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        USER_CLICK_OK = False
        Me.Close()
    End Sub
End Class
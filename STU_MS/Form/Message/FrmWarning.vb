Public Class FrmWarning

    Private Sub frm_success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTittle.Text = CompanyInfo.CompanyName
        lblMessage.Text = _MessageTitile
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
End Class
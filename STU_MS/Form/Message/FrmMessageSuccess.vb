Public Class FrmMessageSuccess
    Dim i As Integer = 0
    Private Sub frm_success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessageTitle.Text = CompanyInfo.CompanyName
        lblMessage.Text = _MessageTitile
        Timer1.Enabled = True
    End Sub



    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        If i = 13 Then
            Close()
            Timer1.Enabled = False
            i = 0
        End If
    End Sub
End Class
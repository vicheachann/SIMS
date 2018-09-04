Public Class FrmMessageError

    Private Sub lblShowException_Click(sender As Object, e As EventArgs) Handles lblShowException.Click
        MsgBox(EXCEPTION_MESSAGE)
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Text = _MessageTitile
        lblTitle.Text = CompanyInfo.CompanyName
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub


End Class
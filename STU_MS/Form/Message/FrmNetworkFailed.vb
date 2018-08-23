Public Class FrmNetworkFailed
    Dim i As Integer = 0



    Private Sub FrmNetworkFailed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub lblConStr_Click(sender As Object, e As EventArgs) Handles lblConStr.Click
        frm_write.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Process.GetCurrentProcess().Kill()
    End Sub
End Class
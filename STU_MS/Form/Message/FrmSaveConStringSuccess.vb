Public Class FrmSaveConStringSuccess
    Dim i As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        If i = 7 Then
            Close()
            Timer1.Enabled = False
            i = 0
        End If
    End Sub

    Private Sub FrmSaveConStringSuccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class
﻿Public Class FrmMessageQuestionLarge

    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub



    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        USER_CLICK_OK = False
        Me.Close()
    End Sub

    Private Sub msg_question_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_message.Text = _MessageTitile
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        USER_CLICK_OK = True
        Me.Close()
    End Sub

    Private Sub btnNO_Click(sender As Object, e As EventArgs) Handles btnNO.Click
        USER_CLICK_OK = False
        Me.Close()
    End Sub
End Class
Public Class frm_score


    Private Sub PanelEx2_MouseDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

   
    Private Sub btn_close_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub


  

 
   


    Private Sub btn_search_MouseHover(sender As Object, e As EventArgs) Handles btn_search.MouseHover
        Me.btn_search.Font = New System.Drawing.Font("Khmer OS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = Color.MidnightBlue
    End Sub

  

    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles btn_save.MouseHover
        Me.btn_save.Font = New System.Drawing.Font("Khmer OS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = Color.MidnightBlue
    End Sub




    Private Sub btn_clear_MouseHover(sender As Object, e As EventArgs) Handles btn_clear.MouseHover
        Me.btn_clear.Font = New System.Drawing.Font("Khmer OS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub btn_search_MouseLeave(sender As Object, e As EventArgs) Handles btn_search.MouseLeave
        Me.btn_search.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = Color.MediumBlue

    End Sub


    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_save.MouseLeave
        Me.btn_save.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = Color.MediumBlue

    End Sub



   

    Private Sub btn_clear_MouseLeave(sender As Object, e As EventArgs) Handles btn_clear.MouseLeave
        Me.btn_clear.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = Color.MediumBlue

    End Sub

   
End Class
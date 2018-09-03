Public Class FrmReStudy
    Dim obj As New Method
    Public Shared fromFrmStudent As Boolean = False
#Region "Shadow effect"
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW
            Return cParam
        End Get
    End Property

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub dgReStudy_SelectionChanged(sender As Object, e As EventArgs) Handles dgReStudy.SelectionChanged
        Try
            MessageBox.Show("From Student")
            If (fromFrmStudent = True) Then
                MessageBox.Show("From Student")
            Else
                If (dgReStudy.SelectedRows.Count = 0) Then
                    MessageBox.Show("Excute selection change")
                    'Call ClearDetail()
                    Exit Sub
                Else
                    MessageBox.Show("Excute selection change")
                    'lblEdit.Enabled = True
                    'lblRemove.Enabled = True
                    'lblInsert.Enabled = False

                    'cboStudent.Text = dgDetail.SelectedCells(2).Value
                    'cboPosition.Text = dgDetail.SelectedCells(4).Value
                    'txtSponserAmountUSDD.Text = dgDetail.SelectedCells(5).Value
                    'txtSponserAmountKHR.Text = dgDetail.SelectedCells(6).Value
                End If

            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("បញ្ហាក្នុងការទាញទិន្នន័យ", FrmMessageError, _ErrorSound)
        End Try
    End Sub



#End Region
End Class
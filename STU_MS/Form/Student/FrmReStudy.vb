Imports System.Data.SqlClient

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

#End Region

    Public Sub Clear()
        txtStudentID.Clear()
        txtStuNameKh.Clear()
        txtStuNameEn.Clear()
        cboStuGender.Text = ""
        cboLastYearStudy.Text = ""
        cboLastClass.Text = ""
        dtStuDOB.Text = "1/1/1900"
        cboNewClass.Text = ""
        cboNewYearStudy.Text = ""
        txtLastOrderID.Clear()
        txtRemark.Clear()
        pic_student.BackgroundImage = Nothing
    End Sub

    Public Sub GetLastYearStudy(ByVal studentID As String)
        Try
            obj.OpenConnection()
            cmd = New SqlCommand("SELECT MAX(RECORD_ID),YEAR_STUDY  FROM dbo.TBS_STUDENT_STUDY_INFO WHERE STUDENT_ID = " & studentID & " GROUP BY RECORD_ID,YEAR_STUDY", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cboLastYearStudy.Text = dt.Rows(0)("YEAR_STUDY").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


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

    Private Sub cboNewYearStudy_DropDown(sender As Object, e As EventArgs) Handles cboNewYearStudy.DropDown
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY ORDER BY YEAR_STUDY_KH DESC", cboNewYearStudy, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub

    Private Sub cboNewClass_DropDown(sender As Object, e As EventArgs) Handles cboNewClass.DropDown
        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cboNewClass, "CLASS_LETTER", "CLASS_ID")
    End Sub

    Private Sub cboNewClass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboNewClass.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboNewYearStudy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboNewYearStudy.KeyPress
        e.Handled = True
    End Sub
    Dim t As New Theme
    Private Sub lblInsertLastOrder_MouseHover(sender As Object, e As EventArgs) Handles lblInsertLastOrder.MouseHover
        t.Hover(lblInsertLastOrder)
    End Sub

    Private Sub lblInsertLastOrder_MouseLeave(sender As Object, e As EventArgs) Handles lblInsertLastOrder.MouseLeave
        t.Leave(lblInsertLastOrder)
    End Sub

    Private Sub picInsertLast_MouseHover(sender As Object, e As EventArgs) Handles picInsertLast.MouseHover
        t.Hover(lblInsertLastOrder)
    End Sub

    Private Sub picInsertLast_MouseLeave(sender As Object, e As EventArgs) Handles picInsertLast.MouseLeave
        t.Leave(lblInsertLastOrder)
    End Sub

    Private Sub lblInsertReOrder_MouseHover(sender As Object, e As EventArgs) Handles lblInsertReOrder.MouseHover
        t.Hover(lblInsertReOrder)
    End Sub

    Private Sub lblInsertReOrder_MouseLeave(sender As Object, e As EventArgs) Handles lblInsertReOrder.MouseLeave
        t.Leave(lblInsertReOrder)
    End Sub

    Private Sub picInsertReOrder_MouseHover(sender As Object, e As EventArgs) Handles picInsertReOrder.MouseHover
        t.Hover(lblInsertReOrder)
    End Sub

    Private Sub picInsertReOrder_MouseLeave(sender As Object, e As EventArgs) Handles picInsertReOrder.MouseLeave
        t.Leave(lblInsertReOrder)
    End Sub

    Private Sub lblUpdate_MouseHover(sender As Object, e As EventArgs) Handles lblUpdate.MouseHover
        t.Hover(lblUpdate)
    End Sub

    Private Sub lblUpdate_MouseLeave(sender As Object, e As EventArgs) Handles lblUpdate.MouseLeave
        t.Leave(lblUpdate)
    End Sub

    Private Sub lblDelete_MouseHover(sender As Object, e As EventArgs) Handles lblDelete.MouseHover
        t.Hover(lblDelete)
    End Sub

    Private Sub lblDelete_MouseLeave(sender As Object, e As EventArgs) Handles lblDelete.MouseLeave
        t.Leave(lblDelete)
    End Sub
End Class
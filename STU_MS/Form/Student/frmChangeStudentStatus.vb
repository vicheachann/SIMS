Public Class frmChangeStudentStatus
    Dim t As New Theme
    Dim obj As New Method
    Public arrayIndex As Integer
    Public studentID As Integer() = New Integer(arrayIndex) {}
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

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub lblOk_MouseHover(sender As Object, e As EventArgs) Handles lblOk.MouseHover
        t.Hover(lblOk)
    End Sub

    Private Sub lblOk_MouseLeave(sender As Object, e As EventArgs) Handles lblOk.MouseLeave
        t.Leave(lblOk)
    End Sub

    Private Sub lblClose_MouseHover(sender As Object, e As EventArgs) Handles lblClose.MouseHover
        t.Hover(lblClose)
    End Sub

    Private Sub lblClose_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        t.Leave(lblClose)
    End Sub

    Private Sub cboStudentstatus_DropDown(sender As Object, e As EventArgs) Handles cboStudentstatus.DropDown
        obj.BindComboBox("SELECT STUDENT_STATUS_ID,STUDENT_STATUS_KH FROM dbo.TBS_STUDENT_STATUS WHERE STUDENT_STATUS_ID NOT IN(1,5)", cboStudentstatus, "STUDENT_STATUS_KH", "STUDENT_STATUS_ID")
    End Sub

    Private Sub lblOk_Click(sender As Object, e As EventArgs) Handles lblOk.Click
        Try
            If (Validation.IsEmpty(cboStudentstatus, "ស្ថានភាពសិក្សា")) Then Exit Sub
            obj.ShowMsg("តើអ្នកចង់បញ្ចូលព័ត៌មានទាំងអស់នេះ" & vbCrLf & "ទៅជាអតីតសិស្សដែលឬទេ ?", FrmMessageQuestion, "")
            If USER_CLICK_OK = True Then
                For Each id In FrmChangeClass.studentID
                    obj.UpdateNoMsg("UPDATE dbo.TBS_STUDENT_INFO SET STUDENT_STATUS_ID = " & cboStudentstatus.SelectedValue & " WHERE STUDENT_ID = " & id & " ")
                    obj.InsertToStudentFormer(id)
                Next
                obj.ShowMsg("រក្សាទុកបានជោគជ័យ", FrmMessageSuccess, SUCCESS_SOUND)
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboStudentstatus_TextChanged(sender As Object, e As EventArgs) Handles cboStudentstatus.TextChanged
        cboStudentstatus.BackColor = Color.White
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Close()
    End Sub

    Private Sub cboStudentstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboStudentstatus.KeyPress
        e.Handled = True
    End Sub

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    '    For Each a In FrmChangeClass.studentID
    '        MessageBox.Show(a)
    '    Next

    'End Sub
End Class
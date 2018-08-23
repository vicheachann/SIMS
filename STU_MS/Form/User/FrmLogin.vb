Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class FrmLogin

    Dim connectionString As String = My.Computer.FileSystem.ReadAllText("../../ConnectionString/connectionStr.txt")
    Dim sqlcnn As SqlConnection = New SqlConnection(connectionString)
    Dim obj As New Method
    Dim t As New Theme
    Dim directory As String = My.Application.Info.DirectoryPath



    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        _ConnectionString = connectionString
    End Sub

    Private Sub frm_login_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub pnlHeader_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeader.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub









    Private Sub lbl_connection_MouseHover(sender As Object, e As EventArgs) Handles lblConnectionSetting.MouseHover
        t.Hover(lblConnectionSetting)
    End Sub

    Private Sub lbl_connection_MouseLeave(sender As Object, e As EventArgs) Handles lblConnectionSetting.MouseLeave
        t.Leave(lblConnectionSetting)
    End Sub



    Private Sub lbl_connection_Click(sender As Object, e As EventArgs)
        frm_write.ShowDialog()
    End Sub

    Private Sub cboUserDropDown(sender As Object, e As EventArgs) Handles cboUserName.DropDown
        obj.BindComboBox("SELECT [USER_NAME] FROM dbo.TBL_USERS WHERE STATUS = 'TRUE'", cboUserName, "USER_NAME", "USER_NAME")
    End Sub

    Private Sub cbo_user_DropDownClosed(sender As Object, e As EventArgs) Handles cboUserName.DropDownClosed
        txtPassword.Focus()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub
    Public Function IsConnected(ByRef Conn As SqlConnection) As Boolean
        If Conn IsNot Nothing Then Return (Conn.State = ConnectionState.Open)
        Return False
    End Function




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub lblConnectionSetting_Click(sender As Object, e As EventArgs) Handles lblConnectionSetting.Click
        Try
            frm_write.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Login()
        Try
            If (Validation.IsEmpty(cboUserName, "អ្នកប្រើប្រាស់")) Then Exit Sub
            If (Validation.IsEmpty(cboUserName, "ពាក្យសម្ងាត់")) Then Exit Sub

            GetUserInformation()
            USER_PASSWORD = obj.GetPassword("SELECT CAST(PASSWORD AS VARCHAR(MAX)) FROM dbo.TBL_USERS WHERE USER_NAME =N'" & cboUserName.Text & "'")

            If String.Compare(txtPassword.Text, USER_PASSWORD.ToString, False) = 0 Then

                Cursor = Cursors.AppStarting

                FrmMain.lbl_user_name.Text = USERNAME
                FrmMain.lbl_user_position.Text = USER_STATUS

                If PHOTO Is Nothing Then
                    FrmMain.pic_user.Image = My.Resources.Resources.empty_photo
                Else
                    Call obj.Show_Photo(PHOTO, FrmMain.pic_user)
                End If


                Call FrmStudent.SelectStudent()
                Call frm_teacher.SelectTeacher()

                Cursor = Cursors.Default
                txtPassword.Text = ""
                Me.Hide()
                FrmMain.Show()
            Else
                txtPassword.Clear()
                txtPassword.Focus()
                obj.ShowMsg("ព័ត៌មានអ្នកប្រើប្រាស់មិនត្រឹមត្រូវ !", FrmWarning, "Error.wav")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            sqlcnn.Open()
            sqlcnn.Close()
        Catch ex As Exception
            Hide()
            FrmNetworkFailed.Show()
        End Try
    End Sub

    Public Sub GetUserInformation()
        Try
            Call obj.OpenConnection()
            Dim sqlCmd = "SELECT U.EM_ID,U.[USER_NAME],cast(U.PASSWORD as varchar(max)),U.USER_STATUS ,T.PHOTOS,T.T_NAME_KH  FROM dbo.TBL_TEACHER AS T INNER JOIN dbo.TBL_USERS AS U ON T.TEACHER_ID = U.EM_ID WHERE U.USER_NAME  = N'" & cboUserName.Text & "'"
            cmd = New SqlCommand(sqlCmd, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                USER_ID = dt.Rows(0)(0).ToString()
                USER_STATUS = dt.Rows(0)(3).ToString()
                Try
                    PHOTO = dt.Rows(0)(4)
                Catch ex As Exception
                End Try
                USERNAME = dt.Rows(0)(5).ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            FrmNetworkFailed.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover
        btnLogin.ForeColor = Color.Green
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.ForeColor = Color.Black
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.ForeColor = Color.Red
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.ForeColor = Color.Black
    End Sub
End Class
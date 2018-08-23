Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Win32
Public Class frm_write
    Dim directory As String = My.Application.Info.DirectoryPath
    Dim obj As New Method






    Private Sub frm_write_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub
    Dim t As New Theme


    Private Sub cboServerName_DropDown(sender As Object, e As EventArgs) Handles cboServerName.DropDown
        Try
            Cursor = Cursors.WaitCursor
            cboServerName.DataSource = SearchNetwork.APINetworkItems.GetAllComputersInDomain
            Cursor = Cursors.Default
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDatabase_DropDown(sender As Object, e As EventArgs) Handles cboDatabase.DropDown
        Try
            Me.Cursor = Cursors.WaitCursor
            conn = New SqlConnection("SERVER=" & Trim(cboServerName.Text) & ";DATABASE=Master;Trusted_Connection=false;User=" & Trim(txtUser.Text) & ";Password=" & txtPassword.Text & "")
            If conn.State = ConnectionState.Open Then
                conn.Close()
            Else
                conn.Open()
            End If
            cboDatabase.Items.Clear()
            cmd = New SqlCommand("SELECT * FROM master.sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                cboDatabase.Items.Add(dr(0))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lblTestConnection_Click(sender As Object, e As EventArgs)
        If cboServerName.Text = "" Then
            obj.ShowMsg("Please enter Server Name", FrmWarning, "")
            cboServerName.Focus()
            Exit Sub
        End If

        If txtUser.Text = "" Then
            obj.ShowMsg("Please enter User", FrmWarning, "")
            txtUser.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            obj.ShowMsg("Please enter Password", FrmWarning, "")
            txtPassword.Focus()
            Exit Sub
        End If
        If cboDatabase.Text = "" Then
            obj.ShowMsg("Please enter Database name", FrmWarning, "")
            cboDatabase.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cboServerName.Text = "" Then
            obj.ShowMsg("Please enter Server Name", FrmWarning, "")
            cboServerName.Focus()
            Exit Sub
        End If

        If txtUser.Text = "" Then
            obj.ShowMsg("Please enter User", FrmWarning, "")
            txtUser.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            obj.ShowMsg("Please enter Password", FrmWarning, "")
            txtPassword.Focus()
            Exit Sub
        End If
        If cboDatabase.Text = "" Then
            obj.ShowMsg("Please enter Database name", FrmWarning, "")
            cboDatabase.Focus()
            Exit Sub
        End If

        Try
            Cursor = Cursors.WaitCursor

            conn = New SqlConnection("Server=" & cboServerName.Text.Trim() & ";Database=" & cboDatabase.Text.Trim() & "; Trusted_Connection= false ; User =" & txtUser.Text.Trim() & "; Password=" & txtPassword.Text & " ")

            Dim sw As New StreamWriter("../../ConnectionString/connectionStr.txt", False)

            sw.Write("Server=" & cboServerName.Text.Trim() & ";Database=" & cboDatabase.Text.Trim() & "; Trusted_Connection=false;User=" & txtUser.Text.Trim() & ";Password=" & txtPassword.Text.Trim() & "")
            sw.Close()
            Cursor = Cursors.Default

            FrmSaveConStringSuccess.ShowDialog()
            Shell(Application.ExecutablePath)
            ButtonX1_Click(sender, e)
            ' End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Not success")
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Close()
            'Application.Exit()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Close()
    End Sub

    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
End Class
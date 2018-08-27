Imports System.Data.SqlClient
Imports System.IO

Public Class FrmTeacherTransfer
    Dim obj As New Method
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frm_teacher.SelectTeacher() 'Refresh Teacher list
        Close()
    End Sub

    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub cboTeacher_DropDown(sender As Object, e As EventArgs) Handles cboTeacher.DropDown
        obj.BindComboBox("SELECT  TEACHER_ID,T_NAME_KH FROM dbo.TBL_TEACHER WHERE TEACHER_STATUS_ID  IN(1,6)", cboTeacher, "T_NAME_KH", "TEACHER_ID")

    End Sub

    Private Sub cboTransferToProvince_DropDown(sender As Object, e As EventArgs) Handles cboTransferToProvince.DropDown
        Bind.Province(cboTransferToProvince)
    End Sub

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles lblSave.Click

        If cboTeacher.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលគ្រូជាមុន", FrmWarning, "")
            cboTeacher.Focus()
            cboTeacher.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboCurrentSubject.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលមុខវិជ្ជាបង្រៀន", FrmWarning, "")
            cboCurrentSubject.Focus()
            cboCurrentSubject.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboTeacherManager.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលនាយកសាលា", FrmWarning, "")
            cboTeacherManager.Focus()
            cboTeacherManager.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If txtObjective.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលកម្មវត្ថុ", FrmWarning, "")
            txtObjective.Focus()
            txtObjective.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If txtReason.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលមូលហេតុផ្ទេរ", FrmWarning, "")
            txtReason.Focus()
            txtReason.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txtTransferTo.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
            txtTransferTo.Focus()
            txtTransferTo.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboTransferToProvince.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលខេត្តផ្ទេរ", FrmWarning, "")
            cboTransferToProvince.Focus()
            cboTransferToProvince.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        Try
            obj.InsertNoMsg("INSERT INTO dbo.TBL_TEACHER_TRANSFER (TEACHER_ID,DATE_TRANSFER,DATE_NOTE,TRANSFER_TO,TRANSFER_PROVINCE,TRANSFER_REASON,[DESCRIPTION],CURRENT_SUBJECT,TEACHER_ID_MANAGER,DISTRICT_MANAGER,OBJECTIVE)VALUES(" & cboTeacher.SelectedValue & ",'" & dtTransferDate.Value & "',GETDATE(),N'" & txtTransferTo.Text & "',N'" & cboTransferToProvince.Text & "',N'" & txtReason.Text & "',N'" & txtRemark.Text & "',N'" & cboCurrentSubject.Text & "'," & cboTeacherManager.SelectedValue & ",N'" & txtDistrictManager.Text & "',N'" & txtObjective.Text & "')")
            obj.UpdateNoMsg("UPDATE dbo.TBL_TEACHER SET TEACHER_STATUS_ID = 3 WHERE TEACHER_ID = " & cboTeacher.SelectedValue & "")

            Call obj.ShowMsg("រក្សាទុកបានជោគជ័យ", FrmMessageSuccess, "success.wav")
            Call Selection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub Clear()
        cboTeacher.Text = ""
        dtTransferDate.Text = Date.Today
        txtTransferTo.Clear()
        cboTransferToProvince.Text = ""
        txtReason.Clear()
        txtRemark.Clear()

        cboCurrentSubject.Text = ""
        cboTeacherManager.Text = ""
        txtDistrictManager.Clear()
        txtObjective.Clear()
    End Sub

    Private Sub cboTeacher_TextChanged(sender As Object, e As EventArgs) Handles cboTeacher.TextChanged
        cboTeacher.BackColor = Color.White
    End Sub

    Private Sub txtTransferTo_TextChanged(sender As Object, e As EventArgs) Handles txtTransferTo.TextChanged
        txtTransferTo.BackColor = Color.White
    End Sub

    Private Sub cboTransferToProvince_TextChanged(sender As Object, e As EventArgs) Handles cboTransferToProvince.TextChanged
        cboTransferToProvince.BackColor = Color.White

    End Sub

    Private Sub txtReason_TextChanged(sender As Object, e As EventArgs) Handles txtReason.TextChanged
        txtReason.BackColor = Color.White

    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Clear()

        lblUpdate.Enabled = False
        lblDelete.Enabled = False
        lblSave.Enabled = True

        cboTeacher.Enabled = True
        cboTeacher.Focus()

    End Sub

    Private Sub Selection()
        Try
            obj.BindDataGridView("SELECT     TT.RECORD_ID, TT.TEACHER_ID,ROW_NUMBER() OVER(ORDER BY TT.RECORD_ID DESC) AS 'ROW_NUMBER', T.T_NAME_KH, TT.CURRENT_SUBJECT,(SELECT T_NAME_KH FROM dbo.TBL_TEACHER WHERE TEACHER_ID = TEACHER_ID_MANAGER ) AS 'TEACHER_MANAGER',TT.DISTRICT_MANAGER, TT.OBJECTIVE, TT.TRANSFER_REASON, TT.TRANSFER_TO, TT.TRANSFER_PROVINCE,TT.DATE_TRANSFER, TT.YEAR_STUDY, TT.DESCRIPTION, TT.FILE_PHOTO FROM dbo.TBL_TEACHER_TRANSFER AS TT INNER JOIN dbo.TBL_TEACHER AS T ON TT.TEACHER_ID = T.TEACHER_ID", dg)

            Call SetColHeader()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetColHeader()

        dg.Columns(0).Visible = False 'RECORD_ID
        dg.Columns(1).Visible = False 'TEACHER_ID

        dg.Columns(2).HeaderText = "លរ"
        dg.Columns(2).Width = 50

        dg.Columns(3).HeaderText = "ឈ្មោះ"
        dg.Columns(3).Width = 120

        dg.Columns(4).HeaderText = "មុខវិជ្ជា"
        dg.Columns(4).Width = 120

        dg.Columns(5).HeaderText = "នាយក"
        dg.Columns(5).Width = 120

        dg.Columns(6).HeaderText = "ប្រធានការិយាល័យអប់រំស្រុក"
        dg.Columns(6).Width = 200

        dg.Columns(7).HeaderText = "កម្មវត្ថុ"
        dg.Columns(7).Width = 150

        dg.Columns(8).HeaderText = "មូលហេតុ"
        dg.Columns(8).Width = 200

        dg.Columns(9).HeaderText = "ផ្ទេរទៅ"
        dg.Columns(9).Width = 180

        dg.Columns(10).HeaderText = "ខេត្ត"
        dg.Columns(10).Width = 150

        dg.Columns(11).HeaderText = "កាលបរិច្ឆេទផ្ទេរ"
        dg.Columns(11).Width = 120

        dg.Columns(12).HeaderText = "ឆ្នាំសិក្សា"
        dg.Columns(12).Width = 100

        dg.Columns(13).HeaderText = "ផ្សេងៗ"
        dg.Columns(13).Width = 200

        dg.Columns(14).Visible = False 'FILE_PHOTO
    End Sub

    Private Sub FrmTeacherTransfer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Selection()
    End Sub

    Private Sub dg_SelectionChanged(sender As Object, e As EventArgs) Handles dg.SelectionChanged
        Clear()

        lblSave.Enabled = False
        lblDelete.Enabled = True
        lblUpdate.Enabled = True

        cboTeacher.Enabled = False
        Try
            cboTeacher.Text = If(dg.SelectedRows(0).Cells(3).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(3).Value)
            dtTransferDate.Text = If(dg.SelectedRows(0).Cells(4).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(4).Value)
            txtTransferTo.Text = If(dg.SelectedRows(0).Cells(5).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(5).Value)
            cboTransferToProvince.Text = If(dg.SelectedRows(0).Cells(6).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(6).Value)
            txtReason.Text = If(dg.SelectedRows(0).Cells(7).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(7).Value)
            txtRemark.Text = If(dg.SelectedRows(0).Cells(9).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(9).Value)

            If dg.SelectedCells(8).Value.ToString() = "" Then
                picFile.BackgroundImage = Nothing
            Else
                Call obj.Show_Photo(dg.SelectedCells(8).Value, picFile)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click

        If cboTeacher.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលគ្រូជាមុន", FrmWarning, "")
            cboTeacher.Focus()
            cboTeacher.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboCurrentSubject.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលមុខវិជ្ជាបង្រៀន", FrmWarning, "")
            cboCurrentSubject.Focus()
            cboCurrentSubject.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboTeacherManager.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលនាយកសាលា", FrmWarning, "")
            cboTeacherManager.Focus()
            cboTeacherManager.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If txtObjective.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលកម្មវត្ថុ", FrmWarning, "")
            txtObjective.Focus()
            txtObjective.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If txtReason.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលមូលហេតុផ្ទេរ", FrmWarning, "")
            txtReason.Focus()
            txtReason.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If txtTransferTo.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
            txtTransferTo.Focus()
            txtTransferTo.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboTransferToProvince.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលខេត្តផ្ទេរ", FrmWarning, "")
            cboTransferToProvince.Focus()
            cboTransferToProvince.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then

            Try
                obj.Update("UPDATE dbo.TBL_TEACHER_TRANSFER SET DATE_TRANSFER = '" & dtTransferDate.Value & "',TRANSFER_TO= N'" & txtTransferTo.Text & "',TRANSFER_PROVINCE = N'" & cboTransferToProvince.Text & "',TRANSFER_REASON =N'" & txtReason.Text & "',[DESCRIPTION]=N'" & txtRemark.Text & "' WHERE RECORD_ID = " & dg.SelectedCells(0).Value & " AND TEACHER_ID = " & dg.SelectedCells(1).Value & "AND DATE_TRANSFER = '" & dg.SelectedCells(4).Value & "'")
                Call Selection()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        obj.ShowMsg("តើអ្នកចង់លុបព័ត៏មាននេះដែលឬទេ ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            obj.Delete("DELETE FROM dbo.TBL_TEACHER_TRANSFER WHERE RECORD_ID = " & dg.SelectedCells(0).Value & " AND TEACHER_ID = " & dg.SelectedCells(1).Value & "AND DATE_TRANSFER = '" & dg.SelectedCells(4).Value & "'")
            obj.UpdateNoMsg("UPDATE dbo.TBL_TEACHER SET TEACHER_STATUS_ID = 1 WHERE TEACHER_ID = " & dg.SelectedCells(1).Value & "")
            Call Selection()

        End If

    End Sub

    Private Sub lblOpenImg_Click(sender As Object, e As EventArgs) Handles lblOpenImg.Click
        Call obj.Browe(picFile)

    End Sub

    Private Sub lblSaveImg_Click(sender As Object, e As EventArgs) Handles lblSaveImg.Click
        Try
            If picFile.BackgroundImage Is Nothing Then
                Call obj.ShowMsg("សូមជ្រើសរើសរូបភាពជាមុន!", FrmWarning, "Error.wav")
                Exit Sub
            End If
            Call obj.OpenConnection()
            Dim photo() As Byte = GetPhoto(photoFilePath)
            cmd = New SqlCommand("UPDATE dbo.TBL_TEACHER_TRANSFER SET FILE_PHOTO=@Photo WHERE RECORD_ID = " & dg.SelectedCells(0).Value & " AND TEACHER_ID = " & dg.SelectedCells(1).Value & "AND DATE_TRANSFER = '" & dg.SelectedCells(4).Value & "'", conn)
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            cmd.ExecuteNonQuery()
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            Call obj.ShowMsg("រូបភាពកែប្រែបានសម្រេច", FrmMessageSuccess, "")
            Call Selection()

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call obj.ShowMsg("ពុំអាចកែប្រែរូបភាពបានទេ!", FrmMessageError, "Error.wav")
        End Try
    End Sub
    Public Shared Function GetPhoto(ByVal filePath As String) As Byte()
        Dim stream As FileStream = New FileStream(
           filePath, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(stream)
        Dim photo() As Byte = reader.ReadBytes(stream.Length)
        reader.Close()
        stream.Close()
        Return photo
    End Function

    Private Sub txtObjective_TextChanged(sender As Object, e As EventArgs) Handles txtObjective.TextChanged
        txtObjective.BackColor = Color.White
    End Sub

    Private Sub cboTeacherIDManager_TextChanged(sender As Object, e As EventArgs) Handles cboTeacherManager.TextChanged
        cboTeacherManager.BackColor = Color.White
    End Sub

    Private Sub cboCurrentSubject_TextChanged(sender As Object, e As EventArgs) Handles cboCurrentSubject.TextChanged
        cboCurrentSubject.BackColor = Color.White
    End Sub

    Private Sub cboTeacherManager_DropDown(sender As Object, e As EventArgs) Handles cboTeacherManager.DropDown
        obj.BindComboBox("SELECT  TEACHER_ID,T_NAME_KH FROM dbo.TBL_TEACHER WHERE TEACHER_STATUS_ID  IN(1,6)", cboTeacherManager, "T_NAME_KH", "TEACHER_ID")

    End Sub

    Private Sub cboCurrentSubject_DropDown(sender As Object, e As EventArgs) Handles cboCurrentSubject.DropDown
        obj.BindComboBox("SELECT SUBJECT_ID,SUBJECT_KH FROM dbo.TBL_SUBJECT", cboCurrentSubject, "SUBJECT_KH", "SUBJECT_ID")

    End Sub

    Private Sub cboCurrentSubject_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCurrentSubject.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboTeacherManager_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTeacherManager.KeyPress
        e.Handled = True

    End Sub

    Private Sub cboTeacher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTeacher.KeyPress
        e.Handled = True

    End Sub

    Private Sub cboTransferToProvince_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTransferToProvince.KeyPress
        e.Handled = True

    End Sub
End Class
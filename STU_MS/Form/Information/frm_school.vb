Imports System.Data.SqlClient
Imports System.IO

Public Class frm_school
    Dim obj As New Method
    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub PanelEx2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub Selection()
        obj.OpenConnection()

        Try

            obj.BindDataGridView("SELECT SCHOOL_ID,ROW_NUMBER() OVER(ORDER BY SCHOOL_ID ASC) AS 'ROW_NUM',SCHOOL_NAME_KH,SCHOOL_NAME_LATIN,PROVINCE,DISTRICT,COMMUNE,VILLAGE,STREET,PHONE_LINE_1,PHONE_LINE_2,EMAIL_ADDRESS,DESCRIPTION,SCHOOL_LOGO FROM dbo.TBL_SCHOOL_INFO", dg)
            SetColumnHeader()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetColumnHeader()
        dg.Columns(0).Visible = False 'ID

        dg.Columns(1).HeaderText = "ល.រ"
        dg.Columns(1).Width = 55

        dg.Columns(2).HeaderText = "ឈ្មោះខ្មែរ"
        dg.Columns(2).Width = 200

        dg.Columns(3).HeaderText = "ឈ្មោះឡាតាំង"
        dg.Columns(3).Width = 200

        dg.Columns(4).HeaderText = "ខេត្ត"
        dg.Columns(4).Width = 150

        dg.Columns(5).HeaderText = "ស្រុក"
        dg.Columns(5).Width = 150

        dg.Columns(6).HeaderText = "ឃុំ"
        dg.Columns(6).Width = 150

        dg.Columns(7).HeaderText = "ភូមិ"
        dg.Columns(7).Width = 150

        dg.Columns(8).HeaderText = "ផ្លូវ"
        dg.Columns(8).Width = 150

        dg.Columns(9).HeaderText = "លេខទូរស័ព្ទ(១)"
        dg.Columns(9).Width = 150

        dg.Columns(10).HeaderText = "លេខទូរស័ព្ទ(២)"
        dg.Columns(10).Width = 150

        dg.Columns(11).HeaderText = "អ៊ីមែល"
        dg.Columns(11).Width = 150

        dg.Columns(12).HeaderText = "ផ្សេងៗ"
        dg.Columns(12).Width = 200


        dg.Columns(13).Visible = False 'File logo



    End Sub


    Private Sub frm_school_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Selection()
        Call SetupForm()
    End Sub

    Private Sub SetupForm()
        If (dg.Rows.Count > 0) Then
            lblSave.Enabled = False
        End If
    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Clear()
        txtNameKh.Focus()
        lblUpdate.Enabled = False
        lblDelete.Enabled = False
        lblSave.Enabled = True
    End Sub

    Private Sub Clear()
        txtRowNumber.Clear()
        txtNameKh.Clear()
        txtNameEn.Clear()
        cboProvince.Text = ""
        cboDistrict.Text = ""
        cboCommune.Text = ""
        cboVillage.Text = ""
        txtStreet.Clear()
        txtTel1.Clear()
        txtTel2.Clear()
        txtEmail.Clear()
        txtRemark.Clear()
        picLogo.BackgroundImage = Nothing


    End Sub

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        '------ validate -----
        If (dg.Rows.Count > 0) Then
            obj.ShowMsg("សាលាបានបញ្ចូលរួចរាល់ហើយ", FrmWarning, "")
            Exit Sub
        End If
        If txtNameKh.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលឈ្មោះសាលា", FrmWarning, "")
            txtNameKh.Focus()
            txtNameKh.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboProvince.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលខេត្ត", FrmWarning, "")
            cboProvince.Focus()
            cboProvince.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboDistrict.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលស្រុក", FrmWarning, "")
            cboDistrict.Focus()
            cboDistrict.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboCommune.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលឃុំ", FrmWarning, "")
            cboCommune.Focus()
            cboCommune.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If cboVillage.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលភូមិ", FrmWarning, "")
            cboVillage.Focus()
            cboVillage.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        Try
            obj.Insert("INSERT INTO dbo.TBL_SCHOOL_INFO (SCHOOL_NAME_KH,SCHOOL_NAME_LATIN,PROVINCE,DISTRICT,COMMUNE,VILLAGE,STREET,PHONE_LINE_1,PHONE_LINE_2,EMAIL_ADDRESS,[DESCRIPTION])VALUES(N'" & txtNameKh.Text & "','" & txtNameEn.Text & "',N'" & cboProvince.Text & "',N'" & cboDistrict.Text & "',N'" & cboCommune.Text & "',N'" & cboVillage.Text & "',N'" & txtStreet.Text & "',N'" & txtTel1.Text & "',N'" & txtTel2.Text & "',N'" & txtEmail.Text & "',N'" & txtRemark.Text & "')")
            Call Selection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
    Private Sub txtNameKh_TextChanged(sender As Object, e As EventArgs) Handles txtNameKh.TextChanged
        txtNameKh.BackColor = Color.White
    End Sub

    Private Sub dg_SelectionChanged(sender As Object, e As EventArgs) Handles dg.SelectionChanged
        lblSave.Enabled = False
        lblDelete.Enabled = True
        lblUpdate.Enabled = True
        Try
            Clear()
            txtRowNumber.Text = If(dg.SelectedRows(0).Cells(1).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(1).Value)
            txtNameKh.Text = If(dg.SelectedRows(0).Cells(2).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(2).Value)
            txtNameEn.Text = If(dg.SelectedRows(0).Cells(3).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(3).Value)
            cboProvince.Text = If(dg.SelectedRows(0).Cells(4).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(4).Value)
            cboDistrict.Text = If(dg.SelectedRows(0).Cells(5).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(5).Value)
            cboCommune.Text = If(dg.SelectedRows(0).Cells(6).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(6).Value)
            cboVillage.Text = If(dg.SelectedRows(0).Cells(7).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(7).Value)
            txtStreet.Text = If(dg.SelectedRows(0).Cells(8).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(8).Value)
            txtTel1.Text = If(dg.SelectedRows(0).Cells(9).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(9).Value)
            txtTel2.Text = If(dg.SelectedRows(0).Cells(10).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(10).Value)
            txtEmail.Text = If(dg.SelectedRows(0).Cells(11).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(11).Value)
            txtRemark.Text = If(dg.SelectedRows(0).Cells(12).Value Is DBNull.Value, "", dg.SelectedRows(0).Cells(12).Value)

            If dg.SelectedCells(13).Value.ToString() = "" Then
                picLogo.BackgroundImage = Nothing
            Else
                Call obj.Show_Photo(dg.SelectedCells(13).Value, picLogo)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblSearchImg_Click(sender As Object, e As EventArgs) Handles lblSearchImg.Click
        Call obj.Browe(picLogo)

    End Sub

    Private Sub lblInsertImg_Click(sender As Object, e As EventArgs) Handles lblInsertImg.Click
        Try
            If picLogo.BackgroundImage Is Nothing Then
                Call obj.ShowMsg("សូមជ្រើសរើសរូបភាពជាមុន!", FrmWarning, "Error.wav")
                Exit Sub
            End If
            Call obj.OpenConnection()
            Dim photo() As Byte = GetPhoto(photoFilePath)
            cmd = New SqlCommand("UPDATE dbo.TBL_SCHOOL_INFO SET SCHOOL_LOGO=@Photo WHERE SCHOOL_ID=N'" & dg.SelectedRows(0).Cells(0).Value & "' ", conn)
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            cmd.ExecuteNonQuery()
            cmd.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo
            Call obj.ShowMsg("រូបភាពកែប្រែបានសម្រេច", FrmMessageSuccess, "")
            Call Selection()

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            Call obj.ShowMsg("ពុំអាចកែប្រែរូបភាពបានទេ!", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        '------ validate -----

        If txtNameKh.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលឈ្មោះសាលា", FrmWarning, "")
            txtNameKh.Focus()
            txtNameKh.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboProvince.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលខេត្ត", FrmWarning, "")
            cboProvince.Focus()
            cboProvince.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboDistrict.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលស្រុក", FrmWarning, "")
            cboDistrict.Focus()
            cboDistrict.BackColor = Color.LavenderBlush
            Exit Sub
        End If
        If cboCommune.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលឃុំ", FrmWarning, "")
            cboCommune.Focus()
            cboCommune.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        If cboVillage.Text = "" Then
            obj.ShowMsg("សូមបញ្ចូលភូមិ", FrmWarning, "")
            cboVillage.Focus()
            cboVillage.BackColor = Color.LavenderBlush
            Exit Sub
        End If

        obj.ShowMsg("តើអ្នកចង់កែប្រែព័ត៌មាននេះដែរឬទេ?", FrmMessageQuestion, "ShowMessage.wav")
        If USER_CLICK_OK = True Then
            Try
                obj.Update("UPDATE dbo.TBL_SCHOOL_INFO SET SCHOOL_NAME_KH = N'" & txtNameKh.Text & "' , SCHOOL_NAME_LATIN = N'" & txtNameEn.Text & "', PROVINCE = N'" & cboProvince.Text & "', DISTRICT = N'" & cboDistrict.Text & "', COMMUNE = N'" & cboCommune.Text & "',VILLAGE =N'" & cboVillage.Text & "',STREET = N'" & txtStreet.Text & "',PHONE_LINE_1 = N'" & txtTel1.Text & "',PHONE_LINE_2 = N'" & txtTel2.Text & "',EMAIL_ADDRESS =N'" & txtEmail.Text & "',[DESCRIPTION] = N'" & txtRemark.Text & "' WHERE SCHOOL_ID =" & dg.SelectedCells(0).Value & " ")
                Call Selection()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub cboProvince_DropDown(sender As Object, e As EventArgs) Handles cboProvince.DropDown
        Bind.Province(cboProvince)
        cboDistrict.Text = ""
        cboCommune.Text = ""
        cboVillage.Text = ""
    End Sub

    Private Sub cboDistrict_DropDown(sender As Object, e As EventArgs) Handles cboDistrict.DropDown
        Bind.District(cboDistrict, cboProvince)
        cboCommune.Text = ""
        cboVillage.Text = ""
    End Sub

    Private Sub cboCommune_DropDown(sender As Object, e As EventArgs) Handles cboCommune.DropDown
        Bind.Commune(cboCommune, cboDistrict)
        cboVillage.Text = ""
    End Sub

    Private Sub cboVillage_DropDown(sender As Object, e As EventArgs) Handles cboVillage.DropDown
        Bind.Village(cboVillage, cboCommune, cboDistrict, cboProvince)
    End Sub

    Private Sub cboCommune_TextChanged(sender As Object, e As EventArgs) Handles cboCommune.TextChanged
        cboCommune.BackColor = Color.White
    End Sub

    Private Sub cboDistrict_TextChanged(sender As Object, e As EventArgs) Handles cboDistrict.TextChanged
        cboDistrict.BackColor = Color.White
    End Sub

    Private Sub cboProvince_TextChanged(sender As Object, e As EventArgs) Handles cboProvince.TextChanged
        cboProvince.BackColor = Color.White
    End Sub

    Private Sub cboVillage_TextChanged(sender As Object, e As EventArgs) Handles cboVillage.TextChanged
        cboVillage.BackColor = Color.White
    End Sub

    Private Sub txtStreet_TextChanged(sender As Object, e As EventArgs) Handles txtStreet.TextChanged
        txtStreet.BackColor = Color.White
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            obj.ShowMsg("តើអ្នកចង់លុបទីន្នន័យនេះដែលឬទេ", FrmMessageQuestion, "")
            If USER_CLICK_OK = True Then
                obj.Delete("DELETE dbo.TBL_SCHOOL_INFO WHERE SCHOOL_ID = " & dg.SelectedCells(0).Value & "")
                Selection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
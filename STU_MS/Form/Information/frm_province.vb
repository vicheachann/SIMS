Public Class frm_province
    Dim obj As New Method
    Private Sub PanelEx2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub



  
    Private Sub Selection()
        obj.OpenConnection()

        Try
            obj.BindDataGridView("Select top(500) ROW_NUMBER() OVER(ORDER BY Province_Unicode ASC) AS 'row_num',PCode,Province_Unicode,District_Unicode,Commune_Unicode,Villague_Unicode from dbo.TblProvince_Khmer_Unicode ", datagrid)

            Call SetTitle()
          
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SetTitle()
        datagrid.Columns(0).HeaderText = "ល.រ"
        datagrid.Columns(1).HeaderText = "P-CODE"
        datagrid.Columns(2).HeaderText = "ខេត្ត/ក្រុង"
        datagrid.Columns(3).HeaderText = "ស្រុក/ខ័ណ្ឌ"
        datagrid.Columns(4).HeaderText = "ឃុំ/សង្កាត់"
        datagrid.Columns(5).HeaderText = "ភូមិ"

        datagrid.Columns(0).Width = 50
        datagrid.Columns(1).Width = 100
        datagrid.Columns(2).Width = 200
        datagrid.Columns(3).Width = 200
        datagrid.Columns(4).Width = 200
        datagrid.Columns(5).Width = 200
    End Sub

   
    Private Sub frm_province_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Call Selection()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Clear()
        txtPCode.Clear()
        cboProvince.Text = ""
        cboVillage.Text = ""
        cboDistrict.Text = ""
        cboCommune.Text = ""
        txtNo.Clear()
    End Sub
    Private Sub datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles datagrid.SelectionChanged
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True
        Try
            clear()
            txtNo.Text = datagrid.SelectedRows(0).Cells(0).Value
            txtPCode.Text = datagrid.SelectedRows(0).Cells(1).Value
            cboProvince.Text = datagrid.SelectedRows(0).Cells(2).Value
            cboDistrict.Text = datagrid.SelectedRows(0).Cells(3).Value
            cboCommune.Text = datagrid.SelectedRows(0).Cells(4).Value
            cboVillage.Text = datagrid.SelectedRows(0).Cells(5).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        Clear()
        btn_delete.Enabled = False
        btn_update.Enabled = False
        btn_save.Enabled = True

        txtPCode.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            If txtPCode.Text = "" Or cboProvince.Text = "" Or cboDistrict.Text = "" Or cboCommune.Text = "" Or cboVillage.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                txtPCode.Focus()
                Exit Sub
            End If

            If txtPCode.Text = datagrid.SelectedCells(1).Value Then
                obj.Update("UPDATE dbo.TblProvince_Khmer_Unicode SET PCode = " & txtPCode.Text & ", Province_Unicode = N'" & cboProvince.Text & "', District_Unicode = N'" & cboDistrict.Text & "',Commune_Unicode = N'" & cboCommune.Text & "',Villague_Unicode = N'" & cboVillage.Text & "' WHERE PCode = " & datagrid.SelectedCells(1).Value & "")
                Call Selection()
            Else
                If frm_class_monitor.CheckExisted("SELECT PCode from dbo.TblProvince_Khmer_Unicode where PCode =" & txtPCode.Text & "", "TblProvince_Khmer_Unicode") = True Then
                    obj.ShowMsg("លេខកូដខេត្តមានរួចរាល់ហើយ", FrmWarning, "")
                    txtPCode.Focus()
                    Exit Sub
                End If
            End If
            

           
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub


    Private Sub lblCheck_Click(sender As Object, e As EventArgs) Handles lblCheck.Click
        If frm_class_monitor.CheckExisted("SELECT PCode from dbo.TblProvince_Khmer_Unicode where PCode =" & txtPCode.Text & "", "TblProvince_Khmer_Unicode") = True Then
            obj.ShowMsg("លេខកូដខេត្តមានរួចរាល់ហើយ", FrmWarning, "")
            txtPCode.Focus()

        Else
            obj.ShowMsg("មិនទាន់មានលេខកូដនេះទេ", FrmMessageSuccess, "")
        End If
    End Sub
    Private Sub btn_update_MouseHover(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_update_MouseLeave(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If txtPCode.Text = "" Then
                obj.ShowMsg("ជ្រើសព័ត៌មានដែលចង់លុប", FrmWarning, "")
                Exit Sub
            End If

            obj.Delete("delete from dbo.TblProvince_Khmer_Unicode where PCode = " & datagrid.SelectedCells(1).Value & "")
            Call Selection()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        If txtSearch.Text = "" Then
            Call Selection()
            Exit Sub
        End If
        Try
            obj.BindDataGridView("Select  ROW_NUMBER() OVER(ORDER BY Province_Unicode ASC) AS 'row_num',PCode,Province_Unicode,District_Unicode,Commune_Unicode,Villague_Unicode from dbo.TblProvince_Khmer_Unicode where CAST(PCode AS NVARCHAR(50)) + Province_Unicode + District_Unicode + Commune_Unicode + Villague_Unicode like N'%" & txtSearch.Text & "%'", datagrid)

            Call SetTitle()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txtPCode.Text = "" Or cboProvince.Text = "" Or cboDistrict.Text = "" Or cboCommune.Text = "" Or cboVillage.Text = "" Then
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, "")
                txtPCode.Focus()
                Exit Sub
            End If

            If frm_class_monitor.CheckExisted("SELECT PCode from dbo.TblProvince_Khmer_Unicode where PCode =" & txtPCode.Text & "", "TblProvince_Khmer_Unicode") = True Then
                obj.ShowMsg("លេខកូដខេត្តមានរួចរាល់ហើយ", FrmWarning, "")
                txtPCode.Focus()
                Exit Sub
            End If

            obj.Insert("INSERT dbo.TblProvince_Khmer_Unicode (PCode,Province_Unicode,District_Unicode,Commune_Unicode,Villague_Unicode)VALUES(" & txtPCode.Text & ",N'" & cboProvince.Text & "',N'" & cboDistrict.Text & "',N'" & cboCommune.Text & "',N'" & cboVillage.Text & "')")
            Call Selection()

        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            obj.ShowMsg(ex.Message, FrmMessageSuccess, "")
        End Try
    End Sub
End Class
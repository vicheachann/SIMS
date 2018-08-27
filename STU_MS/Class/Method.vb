Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Reporting.WinForms


Public Class Method

    Public Sub InsertNoMsg(ByVal SQL As String)
        Try
            OpenConnection()
            cmd = New SqlCommand(SQL, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            ShowMsg("មិនអាចបញ្ចូលទិន្នន័យបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub

    Public Sub OpenConnection()
        Try
            conn = New SqlConnection(_ConnectionString)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
        Catch ex As Exception
            MsgBox("Cannot connect to server")
        End Try
    End Sub

    Public Sub BindDataGridView(ByVal sql As String, ByVal datagrid As DataGridView)
        Try
            Call OpenConnection()
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            datagrid.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CheckNullControl(ByVal txt As TextBox)
        If (String.IsNullOrWhiteSpace(txt.Text)) Then
            txt.Text = 0
        End If
    End Sub

    Public Function IfDbNull(ByVal value As Object) As String
        Return If(value Is Nothing, "", value.ToString())
    End Function






    Public Sub BindComboBox(ByVal sql As String, ByVal cbo As ComboBox, ByVal displayMember As String, ByVal valueMember As String)
        Try
            Call OpenConnection()
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            cbo.DisplayMember = displayMember
            cbo.ValueMember = valueMember
            cbo.DataSource = dt
            conn.Close()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call ShowMsg("មិនអាចទាញទិន្នន័យបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub
    Public Sub BindComboBoxWithAll(ByVal sql As String, ByVal cbo As ComboBox, ByVal displayMember As String, ByVal valueMember As String)
        Try
            Call OpenConnection()
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            Dim r As DataRow = dt.NewRow()
            Try
                r(valueMember) = 0
                r(displayMember) = "ទាំងអស់"
            Catch ex As Exception
                Throw ex
            End Try
            dt.Rows.InsertAt(r, 0)


            cbo.DisplayMember = displayMember
            cbo.ValueMember = valueMember
            cbo.DataSource = dt
            conn.Close()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call ShowMsg("មិនអាចទាញទិន្នន័យបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub
    Public Sub Delete(ByVal sql As String)
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            Call ShowMsg("ទិន្នន័យត្រូវបានលុប", FrmMessageSuccess, "")

        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call ShowMsg("មិនអាចលុបបាន", FrmMessageError, "Error.wav")


        End Try
        USER_CLICK_OK = False
    End Sub

    Public Sub Delete_1(ByVal sql As String)
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call ShowMsg("មិនអាចលុបបាន", FrmMessageError, "Error.wav")


        End Try
        USER_CLICK_OK = False
    End Sub
    'Public Sub Delete_SQL_WM(ByVal sql As String)
    '    Try
    '        OpenConnection()
    '        cmd = New SqlCommand(sql, con)
    '        cmd.ExecuteNonQuery()


    '    Catch ex As Exception
    '        error_reason = ex.Message
    '        Call ShowMsg("មិនអាចលុបបាន", msg_fail)


    '    End Try
    '    question_result = False
    'End Sub
    Public Sub Insert(ByVal sql As String)
        Try
            OpenConnection()

            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Call ShowMsg("រក្សាទុកបានជោគជ័យ", FrmMessageSuccess, "success.wav")
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call ShowMsg("មិនអាចបញ្ចូលទិន្នន័យបាន", FrmMessageError, "Error.wav")
        End Try
    End Sub
    Public Sub Update(ByVal sql As String)
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Call ShowMsg("កែប្រែបានជោគជ័យ", FrmMessageSuccess, "success.wav")
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call ShowMsg("មិនអាចកែប្រែបាន", FrmMessageError, "Error.wav")

        End Try
    End Sub

    Public Sub UpdateNoMsg(ByVal sql As String)
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call ShowMsg("មិនអាចកែប្រែបាន", FrmMessageError, "Error.wav")

        End Try
    End Sub

    Public Function SelectData(ByVal sql As String)
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception

        End Try
        Return dr
    End Function
    Public Sub ShowMsg(ByVal lab As String, ByVal frm As Form, ByVal sounds As String)
        Try
            _MessageTitile = lab
            SOUND(sounds)
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SOUND(ByVal Sounds As String)
        Try
            Dim Sound As New System.Media.SoundPlayer()
            Sound.SoundLocation = "../../media/" + Sounds
            Sound.Load()
            Sound.Play()
        Catch ex As Exception
        End Try
    End Sub



    Public Sub Browe(ByRef Pic As PictureBox)
        Try
            Dim open As New OpenFileDialog()
            open.Filter = "Image file (*.jpg; *.png; *.gif;  *.bmp ) |*.jpg; *.png; *.gif;  *.bmp "
            If open.ShowDialog() = DialogResult.OK Then
                Pic.BackgroundImage = New Bitmap(open.FileName)
                Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
                f = New FileInfo(open.FileName)
                file_Name = f.Name.ToString()
                photoFilePath = open.FileName
            Else

            End If
        Catch ex As Exception
            _ExceptionMessage = ex.Message
            Call ShowMsg("Can't open file browser!", FrmMessageError, "Error.wav")
        End Try
    End Sub





    Public Sub Show_Photo(ByVal Photo() As Byte, ByVal Pic_Box As PictureBox)
        Try
            bytBLOBData = Photo
            stmBLOBData = New MemoryStream(bytBLOBData)
            Pic_Box.BackgroundImage = Image.FromStream(stmBLOBData)
            Pic_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Catch ex As Exception
        End Try
    End Sub
    Dim sqlCmd



    'Public Sub Get_Password(ByVal user_name As String)
    '    Try
    '        Call OpenConnection()
    '        cmd = New SqlCommand("GET_PASSWORD", con)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandTimeout = 180
    '        cmd.Parameters.Add("@USER_NAME", SqlDbType.NVarChar)
    '        cmd.Parameters("@USER_NAME").Value = user_name
    '        cmd.ExecuteReader()

    '        Call OpenConnection()
    '        cmd = New SqlCommand("SELECT PWD FROM TBL_PWD", con)
    '        da = New SqlDataAdapter(cmd)
    '        dt = New DataTable
    '        da.Fill(dt)
    '        User_Password = dt.Rows(0)(0).ToString()
    '        User_Password = "AG" + Val(User_Password.Substring(2, User_Password.Length - 2)).ToString()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Exit Sub
    '    End Try
    'End Sub

    Dim generat_pwd As Integer


    Public Function GetPassword(ByVal sql As String) As String
        Dim password As String = ""

        Try
            dr = SelectData(sql)
            If dr.HasRows Then
                While dr.Read
                    password = dr.GetValue(0)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
        Return password
    End Function



    Public Function CheckExisted(ByVal sSql As String, ByVal table As String) As Boolean
        Try
            Dim totalRow As Long = 0
            Dim da As New SqlDataAdapter(sSql, conn)
            Dim ds As New DataSet()

            da.Fill(ds, table)

            totalRow = Convert.ToInt32(ds.Tables(table).Rows.Count)
            If (totalRow > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return CheckExisted
    End Function
    Public Function GetSchoolName() As String
        Dim schoolName As String = ""
        Try
            OpenConnection()
            cmd = New SqlCommand("SELECT TOP(1) SCHOOL_NAME_KH FROM dbo.TBL_SCHOOL_INFO", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                schoolName = dt.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return schoolName
    End Function
    Public Function GetProvinceName() As String
        Dim province As String = ""
        Try
            OpenConnection()
            cmd = New SqlCommand("SELECT TOP(1) PROVINCE FROM dbo.TBL_SCHOOL_INFO", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                province = dt.Rows(0)(0).ToString()
            Else
                MessageBox.Show("Cannot retrive Province name from server...!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return province
    End Function

    Public Function GetLastOrdinalNumber(ByVal sql As String) As String
        Dim lastOrdinalNumber As Integer
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                If (IsDBNull(dt.Rows(0)(0))) Then
                    lastOrdinalNumber = 1
                Else
                    lastOrdinalNumber = dt.Rows(0)(0)
                    lastOrdinalNumber += 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lastOrdinalNumber
    End Function

    Public Sub SendParam(ByVal param As String, ByVal val As String, ByVal reportViewer As ReportViewer)
        Dim r(0) As ReportParameter
        r(0) = New ReportParameter(param, val, True)
        reportViewer.LocalReport.SetParameters(New ReportParameter() {r(0)})
    End Sub

    Public Sub SetupReportView(ByVal reportViewer As ReportViewer)
        reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        reportViewer.ZoomPercent = 100
    End Sub

    Public Function CheckCode(ByVal sql As String) As Boolean
        Try
            Call OpenConnection()
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Call ShowMsg("លេខកូដនេះមានរួចរាល់", FrmWarning, "Error.wav")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return CheckCode
    End Function

    Public Function CheckCodeWhenUpdate(ByVal sql As String, ByVal dataGridValue As String, ByVal newCode As String) As Boolean
        Try
            Call OpenConnection()
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dataGridValue = newCode Then
                Return False
            Else
                If dt.Rows.Count > 0 Then
                    Call ShowMsg("លេខកូដនេះមានរួចរាល់", FrmWarning, "Error.wav")

                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
        End Try
        Return CheckCodeWhenUpdate
    End Function


    Public Function GetID(ByVal sql As String) As String
        'use GetID when
        Dim ID As String = "null"
        Try
            OpenConnection()
            cmd = New SqlCommand(sql, conn)
            Dim da = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If (dt.Rows.Count > 0) Then
                ID = dt.Rows(0)(0)
            Else
                ID = "null"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, CompanyInfo.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ID
    End Function
    Public Function ReplaceNullWithZero(ByVal text As String) As String
        Dim value As String = "0"
        Try
            If (text = "") Then
                value = "0"
            Else
                value = text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return value
    End Function

    Public Function IsAlreadyInsert(ByVal dg As DataGridView, ByVal cellIndex As Integer, ByVal insertValue As String) As Boolean
        Dim existed As Boolean = False
        Try
            For Each row As DataGridViewRow In dg.Rows
                If insertValue = row.Cells(cellIndex).Value Then
                    ShowMsg("ព័ត៌មាននេះបានបញ្ចូលរួចរាល់ !", FrmWarning, _WarningSound)
                    existed = True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return existed
    End Function
    Public Function IsNewestRecord(ByVal id As String) As Boolean
        Dim newest As Boolean = False
        If (id = "") Then
            newest = True
        End If
        Return newest
    End Function
    Public Function IsEmptyDataGridView(ByVal dg As DataGridView) As Boolean
        Dim empty As Boolean = False
        If dg.RowCount <= 0 Then
            ShowMsg("សូមបញ្ចូលព័ត៌មានជាមុខ​!", FrmWarning, "Error.wav")
            empty = True
        End If
        Return empty
    End Function


End Class

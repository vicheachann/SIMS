<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_student_stop_study
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRecordID = New System.Windows.Forms.TextBox()
        Me.dgPreInsert = New System.Windows.Forms.DataGridView()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.lblDisplayAll = New System.Windows.Forms.Label()
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_class_stop = New System.Windows.Forms.ComboBox()
        Me.cbo_year_study = New System.Windows.Forms.ComboBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.cboReason = New System.Windows.Forms.ComboBox()
        Me.PanelAdvSearch = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dt_datenote = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_reason = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboStudentName = New System.Windows.Forms.ComboBox()
        Me.lbl_class_stop = New System.Windows.Forms.Label()
        Me.dtDateStop = New System.Windows.Forms.DateTimePicker()
        Me.lbl_year_study = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgPreInsert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdvSearch.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.txtRecordID)
        Me.PanelEx1.Controls.Add(Me.dgPreInsert)
        Me.PanelEx1.Controls.Add(Me.picSearch)
        Me.PanelEx1.Controls.Add(Me.lblDisplayAll)
        Me.PanelEx1.Controls.Add(Me.dgMain)
        Me.PanelEx1.Controls.Add(Me.txtSearch)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.cbo_class_stop)
        Me.PanelEx1.Controls.Add(Me.cbo_year_study)
        Me.PanelEx1.Controls.Add(Me.txt_des)
        Me.PanelEx1.Controls.Add(Me.cboReason)
        Me.PanelEx1.Controls.Add(Me.PanelAdvSearch)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.dt_datenote)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.lbl_reason)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.cboStudentName)
        Me.PanelEx1.Controls.Add(Me.lbl_class_stop)
        Me.PanelEx1.Controls.Add(Me.dtDateStop)
        Me.PanelEx1.Controls.Add(Me.lbl_year_study)
        Me.PanelEx1.Controls.Add(Me.lblNew)
        Me.PanelEx1.Controls.Add(Me.lblDelete)
        Me.PanelEx1.Controls.Add(Me.lblUpdate)
        Me.PanelEx1.Controls.Add(Me.lblSave)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1186, 671)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.SkyBlue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label10.Location = New System.Drawing.Point(552, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 38)
        Me.Label10.TabIndex = 230
        '
        'txtRecordID
        '
        Me.txtRecordID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtRecordID.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecordID.Location = New System.Drawing.Point(459, 206)
        Me.txtRecordID.Name = "txtRecordID"
        Me.txtRecordID.Size = New System.Drawing.Size(212, 40)
        Me.txtRecordID.TabIndex = 228
        Me.txtRecordID.Visible = False
        '
        'dgPreInsert
        '
        Me.dgPreInsert.AllowUserToAddRows = False
        Me.dgPreInsert.AllowUserToDeleteRows = False
        Me.dgPreInsert.AllowUserToResizeColumns = False
        Me.dgPreInsert.AllowUserToResizeRows = False
        Me.dgPreInsert.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgPreInsert.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgPreInsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPreInsert.Location = New System.Drawing.Point(11, 76)
        Me.dgPreInsert.MultiSelect = False
        Me.dgPreInsert.Name = "dgPreInsert"
        Me.dgPreInsert.ReadOnly = True
        Me.dgPreInsert.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPreInsert.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgPreInsert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgPreInsert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPreInsert.Size = New System.Drawing.Size(228, 178)
        Me.dgPreInsert.TabIndex = 227
        '
        'picSearch
        '
        Me.picSearch.BackColor = System.Drawing.Color.White
        Me.picSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSearch.Image = Global.STU_MS.My.Resources.Resources.SEARCH_324
        Me.picSearch.Location = New System.Drawing.Point(17, 264)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(33, 30)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSearch.TabIndex = 226
        Me.picSearch.TabStop = False
        '
        'lblDisplayAll
        '
        Me.lblDisplayAll.AutoSize = True
        Me.lblDisplayAll.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDisplayAll.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayAll.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblDisplayAll.Location = New System.Drawing.Point(245, 262)
        Me.lblDisplayAll.Name = "lblDisplayAll"
        Me.lblDisplayAll.Size = New System.Drawing.Size(147, 38)
        Me.lblDisplayAll.TabIndex = 225
        Me.lblDisplayAll.Text = "បង្ហាញទាំងអស់"
        '
        'dgMain
        '
        Me.dgMain.AllowUserToAddRows = False
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToResizeColumns = False
        Me.dgMain.AllowUserToResizeRows = False
        Me.dgMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Location = New System.Drawing.Point(9, 304)
        Me.dgMain.MultiSelect = False
        Me.dgMain.Name = "dgMain"
        Me.dgMain.ReadOnly = True
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(1165, 357)
        Me.dgMain.TabIndex = 224
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(11, 260)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(228, 38)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(779, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 30)
        Me.Label8.TabIndex = 221
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(777, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 30)
        Me.Label7.TabIndex = 220
        Me.Label7.Text = "*"
        '
        'cbo_class_stop
        '
        Me.cbo_class_stop.DropDownHeight = 130
        Me.cbo_class_stop.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_class_stop.FormattingEnabled = True
        Me.cbo_class_stop.IntegralHeight = False
        Me.cbo_class_stop.Location = New System.Drawing.Point(800, 162)
        Me.cbo_class_stop.Name = "cbo_class_stop"
        Me.cbo_class_stop.Size = New System.Drawing.Size(212, 40)
        Me.cbo_class_stop.TabIndex = 219
        '
        'cbo_year_study
        '
        Me.cbo_year_study.DropDownHeight = 130
        Me.cbo_year_study.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_year_study.FormattingEnabled = True
        Me.cbo_year_study.IntegralHeight = False
        Me.cbo_year_study.Location = New System.Drawing.Point(800, 119)
        Me.cbo_year_study.Name = "cbo_year_study"
        Me.cbo_year_study.Size = New System.Drawing.Size(212, 40)
        Me.cbo_year_study.TabIndex = 218
        '
        'txt_des
        '
        Me.txt_des.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_des.Location = New System.Drawing.Point(459, 163)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(212, 40)
        Me.txt_des.TabIndex = 217
        '
        'cboReason
        '
        Me.cboReason.DropDownHeight = 130
        Me.cboReason.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReason.FormattingEnabled = True
        Me.cboReason.IntegralHeight = False
        Me.cboReason.Location = New System.Drawing.Point(459, 120)
        Me.cboReason.Name = "cboReason"
        Me.cboReason.Size = New System.Drawing.Size(212, 40)
        Me.cboReason.TabIndex = 216
        '
        'PanelAdvSearch
        '
        Me.PanelAdvSearch.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelAdvSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelAdvSearch.Controls.Add(Me.PictureBox3)
        Me.PanelAdvSearch.Location = New System.Drawing.Point(139, 42)
        Me.PanelAdvSearch.Name = "PanelAdvSearch"
        Me.PanelAdvSearch.Size = New System.Drawing.Size(0, 44)
        Me.PanelAdvSearch.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelAdvSearch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelAdvSearch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelAdvSearch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelAdvSearch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelAdvSearch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelAdvSearch.Style.GradientAngle = 90
        Me.PanelAdvSearch.TabIndex = 215
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.STU_MS.My.Resources.Resources.search_blue
        Me.PictureBox3.Location = New System.Drawing.Point(771, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 74
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(438, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 30)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(439, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 30)
        Me.Label11.TabIndex = 212
        Me.Label11.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(688, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 32)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "ថ្ងៃបញ្ចូល"
        '
        'dt_datenote
        '
        Me.dt_datenote.CustomFormat = "yyyy-MM-dd"
        Me.dt_datenote.Enabled = False
        Me.dt_datenote.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dt_datenote.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_datenote.Location = New System.Drawing.Point(800, 205)
        Me.dt_datenote.Name = "dt_datenote"
        Me.dt_datenote.Size = New System.Drawing.Size(212, 38)
        Me.dt_datenote.TabIndex = 209
        Me.dt_datenote.Value = New Date(2018, 8, 11, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(688, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 32)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "ថ្ងៃឈប់"
        '
        'lbl_reason
        '
        Me.lbl_reason.AutoSize = True
        Me.lbl_reason.BackColor = System.Drawing.Color.Transparent
        Me.lbl_reason.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_reason.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reason.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl_reason.Location = New System.Drawing.Point(337, 122)
        Me.lbl_reason.Name = "lbl_reason"
        Me.lbl_reason.Size = New System.Drawing.Size(81, 32)
        Me.lbl_reason.TabIndex = 202
        Me.lbl_reason.Text = "មូលហេតុ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(756, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 30)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 32)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "ឈ្មោះសិស្ស"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 32)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "បន្ថែមផ្សេងៗ"
        '
        'cboStudentName
        '
        Me.cboStudentName.DropDownHeight = 130
        Me.cboStudentName.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudentName.FormattingEnabled = True
        Me.cboStudentName.IntegralHeight = False
        Me.cboStudentName.Location = New System.Drawing.Point(459, 77)
        Me.cboStudentName.Name = "cboStudentName"
        Me.cboStudentName.Size = New System.Drawing.Size(212, 40)
        Me.cboStudentName.TabIndex = 188
        '
        'lbl_class_stop
        '
        Me.lbl_class_stop.AutoSize = True
        Me.lbl_class_stop.BackColor = System.Drawing.Color.Transparent
        Me.lbl_class_stop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_class_stop.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_class_stop.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl_class_stop.Location = New System.Drawing.Point(688, 168)
        Me.lbl_class_stop.Name = "lbl_class_stop"
        Me.lbl_class_stop.Size = New System.Drawing.Size(81, 32)
        Me.lbl_class_stop.TabIndex = 178
        Me.lbl_class_stop.Text = "ថ្នាក់ឈប់"
        '
        'dtDateStop
        '
        Me.dtDateStop.CustomFormat = "yyyy-MM-dd"
        Me.dtDateStop.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateStop.Location = New System.Drawing.Point(800, 76)
        Me.dtDateStop.Name = "dtDateStop"
        Me.dtDateStop.Size = New System.Drawing.Size(212, 40)
        Me.dtDateStop.TabIndex = 177
        Me.dtDateStop.Value = New Date(1996, 10, 25, 0, 0, 0, 0)
        '
        'lbl_year_study
        '
        Me.lbl_year_study.AutoSize = True
        Me.lbl_year_study.BackColor = System.Drawing.Color.Transparent
        Me.lbl_year_study.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_year_study.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year_study.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl_year_study.Location = New System.Drawing.Point(688, 125)
        Me.lbl_year_study.Name = "lbl_year_study"
        Me.lbl_year_study.Size = New System.Drawing.Size(75, 32)
        Me.lbl_year_study.TabIndex = 176
        Me.lbl_year_study.Text = "ឆ្នាំសិក្សា"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.BackColor = System.Drawing.Color.Transparent
        Me.lblNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNew.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblNew.Location = New System.Drawing.Point(475, 262)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(89, 38)
        Me.lblNew.TabIndex = 143
        Me.lblNew.Text = "បញ្ចូលថ្មី"
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.BackColor = System.Drawing.Color.Transparent
        Me.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDelete.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblDelete.Location = New System.Drawing.Point(742, 262)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(53, 38)
        Me.lblDelete.TabIndex = 108
        Me.lblDelete.Text = "លុប"
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUpdate.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblUpdate.Location = New System.Drawing.Point(662, 262)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(66, 38)
        Me.lblUpdate.TabIndex = 107
        Me.lblUpdate.Text = "កែប្រែ"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.BackColor = System.Drawing.Color.Transparent
        Me.lblSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSave.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblSave.Location = New System.Drawing.Point(575, 262)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(80, 38)
        Me.lblSave.TabIndex = 106
        Me.lblSave.Text = "រក្សាទុក"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.PictureBox1)
        Me.PanelEx2.Controls.Add(Me.btn_close)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1186, 42)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.RoyalBlue
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.DodgerBlue
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.skiddll
        Me.PictureBox1.Location = New System.Drawing.Point(4, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 201
        Me.PictureBox1.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.STU_MS.My.Resources.Resources.red_close_button_png_image_2878
        Me.btn_close.Location = New System.Drawing.Point(1146, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 32)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 10
        Me.btn_close.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "សិស្សបោះបង់ការសិក្សា"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(7, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 32)
        Me.Label6.TabIndex = 229
        Me.Label6.Text = "ព័ត៌មានមិនទាន់បញ្ចូល :"
        '
        'frm_student_stop_study
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 671)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_student_stop_study"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.dgPreInsert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdvSearch.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btn_close As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDelete As System.Windows.Forms.Label
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents lbl_class_stop As System.Windows.Forms.Label
    Friend WithEvents dtDateStop As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_year_study As System.Windows.Forms.Label
    Friend WithEvents cboStudentName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_reason As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dt_datenote As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PanelAdvSearch As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbo_class_stop As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_year_study As System.Windows.Forms.ComboBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents cboReason As System.Windows.Forms.ComboBox
    Friend WithEvents dgMain As DataGridView
    Friend WithEvents lblDisplayAll As Label
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents dgPreInsert As DataGridView
    Friend WithEvents txtRecordID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_student_suspent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lblDisplayAll = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_remark = New System.Windows.Forms.TextBox()
        Me.txt_reason = New System.Windows.Forms.TextBox()
        Me.dt_end_date = New System.Windows.Forms.DateTimePicker()
        Me.dt_start_date = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_duration = New System.Windows.Forms.TextBox()
        Me.PanelAdvSearch = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dt_datenote = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_student_name = New System.Windows.Forms.ComboBox()
        Me.btn_new = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdvSearch.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.lblDisplayAll)
        Me.PanelEx1.Controls.Add(Me.PictureBox2)
        Me.PanelEx1.Controls.Add(Me.txtSearch)
        Me.PanelEx1.Controls.Add(Me.Label14)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.txt_remark)
        Me.PanelEx1.Controls.Add(Me.txt_reason)
        Me.PanelEx1.Controls.Add(Me.dt_end_date)
        Me.PanelEx1.Controls.Add(Me.dt_start_date)
        Me.PanelEx1.Controls.Add(Me.Label13)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.txt_duration)
        Me.PanelEx1.Controls.Add(Me.PanelAdvSearch)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.dt_datenote)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.datagrid)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.cbo_student_name)
        Me.PanelEx1.Controls.Add(Me.btn_new)
        Me.PanelEx1.Controls.Add(Me.btn_delete)
        Me.PanelEx1.Controls.Add(Me.btn_update)
        Me.PanelEx1.Controls.Add(Me.btn_save)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1269, 671)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'lblDisplayAll
        '
        Me.lblDisplayAll.AutoSize = True
        Me.lblDisplayAll.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDisplayAll.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayAll.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblDisplayAll.Location = New System.Drawing.Point(216, 249)
        Me.lblDisplayAll.Name = "lblDisplayAll"
        Me.lblDisplayAll.Size = New System.Drawing.Size(147, 38)
        Me.lblDisplayAll.TabIndex = 235
        Me.lblDisplayAll.Text = "បង្ហាញទាំងអស់"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.STU_MS.My.Resources.Resources.Search_42342
        Me.PictureBox2.Location = New System.Drawing.Point(173, 252)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 234
        Me.PictureBox2.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(4, 248)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(205, 38)
        Me.txtSearch.TabIndex = 233
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(752, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 30)
        Me.Label14.TabIndex = 232
        Me.Label14.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(276, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 30)
        Me.Label9.TabIndex = 231
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(309, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 30)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(309, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 30)
        Me.Label7.TabIndex = 229
        Me.Label7.Text = "*"
        '
        'txt_remark
        '
        Me.txt_remark.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remark.Location = New System.Drawing.Point(789, 106)
        Me.txt_remark.Multiline = True
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.Size = New System.Drawing.Size(283, 125)
        Me.txt_remark.TabIndex = 228
        '
        'txt_reason
        '
        Me.txt_reason.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reason.Location = New System.Drawing.Point(789, 63)
        Me.txt_reason.Name = "txt_reason"
        Me.txt_reason.Size = New System.Drawing.Size(283, 40)
        Me.txt_reason.TabIndex = 227
        '
        'dt_end_date
        '
        Me.dt_end_date.CustomFormat = "yyyy-MM-dd"
        Me.dt_end_date.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_end_date.Location = New System.Drawing.Point(386, 149)
        Me.dt_end_date.Name = "dt_end_date"
        Me.dt_end_date.Size = New System.Drawing.Size(283, 40)
        Me.dt_end_date.TabIndex = 226
        Me.dt_end_date.Value = New Date(2018, 4, 24, 0, 0, 0, 0)
        '
        'dt_start_date
        '
        Me.dt_start_date.CustomFormat = "yyyy-MM-dd"
        Me.dt_start_date.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_start_date.Location = New System.Drawing.Point(386, 106)
        Me.dt_start_date.Name = "dt_start_date"
        Me.dt_start_date.Size = New System.Drawing.Size(283, 40)
        Me.dt_start_date.TabIndex = 225
        Me.dt_start_date.Value = New Date(2018, 4, 24, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(677, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 32)
        Me.Label13.TabIndex = 224
        Me.Label13.Text = "ផ្សេងៗ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(200, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 32)
        Me.Label10.TabIndex = 223
        Me.Label10.Text = "រយៈពេល"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 32)
        Me.Label6.TabIndex = 222
        Me.Label6.Text = "ថ្ងៃចាប់ផ្តើមព្យួរ"
        '
        'txt_duration
        '
        Me.txt_duration.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_duration.Location = New System.Drawing.Point(386, 191)
        Me.txt_duration.Name = "txt_duration"
        Me.txt_duration.Size = New System.Drawing.Size(283, 40)
        Me.txt_duration.TabIndex = 217
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
        Me.Label12.Location = New System.Drawing.Point(294, 69)
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
        Me.Label11.Location = New System.Drawing.Point(300, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 30)
        Me.Label11.TabIndex = 212
        Me.Label11.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(1041, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 30)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "ថ្ងៃបញ្ចូល"
        '
        'dt_datenote
        '
        Me.dt_datenote.CustomFormat = "yyyy-MM-dd"
        Me.dt_datenote.Enabled = False
        Me.dt_datenote.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dt_datenote.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_datenote.Location = New System.Drawing.Point(1122, 245)
        Me.dt_datenote.Name = "dt_datenote"
        Me.dt_datenote.Size = New System.Drawing.Size(144, 38)
        Me.dt_datenote.TabIndex = 209
        Me.dt_datenote.Value = New Date(1996, 10, 25, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(677, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 32)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "មូលហេតុ"
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AllowUserToResizeColumns = False
        Me.datagrid.AllowUserToResizeRows = False
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.Location = New System.Drawing.Point(3, 292)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(1263, 376)
        Me.datagrid.TabIndex = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 68)
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
        Me.Label2.Location = New System.Drawing.Point(200, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 32)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "ថ្ងៃចូលរៀនវិញ"
        '
        'cbo_student_name
        '
        Me.cbo_student_name.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_student_name.FormattingEnabled = True
        Me.cbo_student_name.Location = New System.Drawing.Point(386, 64)
        Me.cbo_student_name.Name = "cbo_student_name"
        Me.cbo_student_name.Size = New System.Drawing.Size(283, 40)
        Me.cbo_student_name.TabIndex = 188
        '
        'btn_new
        '
        Me.btn_new.AutoSize = True
        Me.btn_new.BackColor = System.Drawing.Color.Transparent
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_new.Location = New System.Drawing.Point(531, 249)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(31, 38)
        Me.btn_new.TabIndex = 143
        Me.btn_new.Text = "ថ្មី"
        '
        'btn_delete
        '
        Me.btn_delete.AutoSize = True
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_delete.Location = New System.Drawing.Point(716, 249)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(53, 38)
        Me.btn_delete.TabIndex = 108
        Me.btn_delete.Text = "លុប"
        '
        'btn_update
        '
        Me.btn_update.AutoSize = True
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_update.Location = New System.Drawing.Point(648, 249)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(66, 38)
        Me.btn_update.TabIndex = 107
        Me.btn_update.Text = "កែប្រែ"
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_save.Location = New System.Drawing.Point(565, 249)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 38)
        Me.btn_save.TabIndex = 106
        Me.btn_save.Text = "រក្សាទុក"
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
        Me.PanelEx2.Size = New System.Drawing.Size(1269, 42)
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
        Me.btn_close.Location = New System.Drawing.Point(1222, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 32)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 10
        Me.btn_close.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(530, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ព័ត៌មានសិស្សព្យួរការសិក្សា"
        '
        'frm_student_suspent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 671)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_student_suspent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdvSearch.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn_delete As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Label
    Friend WithEvents cbo_student_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dt_datenote As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PanelAdvSearch As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_duration As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_remark As System.Windows.Forms.TextBox
    Friend WithEvents txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents dt_end_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_start_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDisplayAll As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtSearch As TextBox
End Class

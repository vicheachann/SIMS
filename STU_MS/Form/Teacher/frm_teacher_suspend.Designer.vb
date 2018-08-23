<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_teacher_suspend
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dt_end_date = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_suspend_num = New System.Windows.Forms.TextBox()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_duration = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_suspend_letter_num = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_teacher = New System.Windows.Forms.ComboBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.dt_start_date = New System.Windows.Forms.DateTimePicker()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_reason = New System.Windows.Forms.TextBox()
        Me.txt_remark = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dt_datenote = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_adv_search = New System.Windows.Forms.LinkLabel()
        Me.PanelAdvSearch = New DevComponents.DotNetBar.PanelEx()
        Me.txt_ad_search = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelEx1.SuspendLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.PanelAdvSearch.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PictureBox2)
        Me.PanelEx1.Controls.Add(Me.PanelAdvSearch)
        Me.PanelEx1.Controls.Add(Me.lbl_adv_search)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.dt_datenote)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.txt_remark)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.txt_reason)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.dt_end_date)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.txt_suspend_num)
        Me.PanelEx1.Controls.Add(Me.datagrid)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.txt_duration)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.txt_suspend_letter_num)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.cbo_teacher)
        Me.PanelEx1.Controls.Add(Me.Label99)
        Me.PanelEx1.Controls.Add(Me.dt_start_date)
        Me.PanelEx1.Controls.Add(Me.Label98)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(620, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 30)
        Me.Label7.TabIndex = 204
        Me.Label7.Text = "រយៈពេលព្យួរ"
        '
        'dt_end_date
        '
        Me.dt_end_date.CustomFormat = "yyyy-MM-dd"
        Me.dt_end_date.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_end_date.Location = New System.Drawing.Point(763, 135)
        Me.dt_end_date.Name = "dt_end_date"
        Me.dt_end_date.Size = New System.Drawing.Size(283, 38)
        Me.dt_end_date.TabIndex = 203
        Me.dt_end_date.Value = New Date(1996, 10, 25, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(190, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 30)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "លេខព្យួរ"
        '
        'txt_suspend_num
        '
        Me.txt_suspend_num.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_suspend_num.Location = New System.Drawing.Point(325, 138)
        Me.txt_suspend_num.Name = "txt_suspend_num"
        Me.txt_suspend_num.Size = New System.Drawing.Size(283, 38)
        Me.txt_suspend_num.TabIndex = 201
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
        Me.datagrid.Location = New System.Drawing.Point(3, 308)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(1263, 360)
        Me.datagrid.TabIndex = 200
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(262, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 30)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "*"
        '
        'txt_duration
        '
        Me.txt_duration.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_duration.Location = New System.Drawing.Point(763, 178)
        Me.txt_duration.Name = "txt_duration"
        Me.txt_duration.Size = New System.Drawing.Size(283, 38)
        Me.txt_duration.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(190, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 30)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "លេខលិខិតព្យួរ"
        '
        'txt_suspend_letter_num
        '
        Me.txt_suspend_letter_num.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_suspend_letter_num.Location = New System.Drawing.Point(325, 94)
        Me.txt_suspend_letter_num.Name = "txt_suspend_letter_num"
        Me.txt_suspend_letter_num.Size = New System.Drawing.Size(283, 38)
        Me.txt_suspend_letter_num.TabIndex = 190
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(190, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 30)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "គ្រូបង្រៀន"
        '
        'cbo_teacher
        '
        Me.cbo_teacher.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cbo_teacher.FormattingEnabled = True
        Me.cbo_teacher.Location = New System.Drawing.Point(325, 182)
        Me.cbo_teacher.Name = "cbo_teacher"
        Me.cbo_teacher.Size = New System.Drawing.Size(283, 38)
        Me.cbo_teacher.TabIndex = 188
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label99.Location = New System.Drawing.Point(620, 141)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(121, 30)
        Me.Label99.TabIndex = 178
        Me.Label99.Text = "ថ្ងៃចូលធ្វើការវិញ"
        '
        'dt_start_date
        '
        Me.dt_start_date.CustomFormat = "yyyy-MM-dd"
        Me.dt_start_date.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_start_date.Location = New System.Drawing.Point(763, 91)
        Me.dt_start_date.Name = "dt_start_date"
        Me.dt_start_date.Size = New System.Drawing.Size(283, 38)
        Me.dt_start_date.TabIndex = 177
        Me.dt_start_date.Value = New Date(1996, 10, 25, 0, 0, 0, 0)
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label98.Location = New System.Drawing.Point(620, 95)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(99, 30)
        Me.Label98.TabIndex = 176
        Me.Label98.Text = "ថ្ងៃព្យួរការងារ"
        '
        'btn_new
        '
        Me.btn_new.AutoSize = True
        Me.btn_new.BackColor = System.Drawing.Color.Transparent
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_new.Location = New System.Drawing.Point(538, 265)
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
        Me.btn_delete.Location = New System.Drawing.Point(723, 265)
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
        Me.btn_update.Location = New System.Drawing.Point(655, 265)
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
        Me.btn_save.Location = New System.Drawing.Point(571, 265)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(530, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "បុគ្គលិកព្យួរការងារ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(190, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 30)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "មូលហេតុ"
        '
        'txt_reason
        '
        Me.txt_reason.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_reason.Location = New System.Drawing.Point(325, 226)
        Me.txt_reason.Name = "txt_reason"
        Me.txt_reason.Size = New System.Drawing.Size(283, 38)
        Me.txt_reason.TabIndex = 205
        '
        'txt_remark
        '
        Me.txt_remark.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_remark.Location = New System.Drawing.Point(763, 222)
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.Size = New System.Drawing.Size(283, 38)
        Me.txt_remark.TabIndex = 207
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label10.Location = New System.Drawing.Point(620, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 30)
        Me.Label10.TabIndex = 208
        Me.Label10.Text = "ផ្សេងៗ"
        '
        'dt_datenote
        '
        Me.dt_datenote.CustomFormat = "yyyy-MM-dd"
        Me.dt_datenote.Enabled = False
        Me.dt_datenote.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dt_datenote.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_datenote.Location = New System.Drawing.Point(1142, 264)
        Me.dt_datenote.Name = "dt_datenote"
        Me.dt_datenote.Size = New System.Drawing.Size(124, 38)
        Me.dt_datenote.TabIndex = 209
        Me.dt_datenote.Value = New Date(1996, 10, 25, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(1061, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 30)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "ថ្ងៃបញ្ចូល"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(262, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 30)
        Me.Label8.TabIndex = 211
        Me.Label8.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(253, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 30)
        Me.Label11.TabIndex = 212
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(293, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 30)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = "*"
        '
        'lbl_adv_search
        '
        Me.lbl_adv_search.AutoSize = True
        Me.lbl_adv_search.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adv_search.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl_adv_search.LinkColor = System.Drawing.Color.MediumBlue
        Me.lbl_adv_search.Location = New System.Drawing.Point(35, 50)
        Me.lbl_adv_search.Name = "lbl_adv_search"
        Me.lbl_adv_search.Size = New System.Drawing.Size(101, 32)
        Me.lbl_adv_search.TabIndex = 214
        Me.lbl_adv_search.TabStop = True
        Me.lbl_adv_search.Text = "ស្វែងរក >>>"
        '
        'PanelAdvSearch
        '
        Me.PanelAdvSearch.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelAdvSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelAdvSearch.Controls.Add(Me.PictureBox3)
        Me.PanelAdvSearch.Controls.Add(Me.txt_ad_search)
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
        'txt_ad_search
        '
        Me.txt_ad_search.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ad_search.Location = New System.Drawing.Point(221, 3)
        Me.txt_ad_search.Name = "txt_ad_search"
        Me.txt_ad_search.Size = New System.Drawing.Size(595, 38)
        Me.txt_ad_search.TabIndex = 0
        Me.txt_ad_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.position
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
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.STU_MS.My.Resources.Resources.search_blue
        Me.PictureBox2.Location = New System.Drawing.Point(1, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'frm_teacher_suspend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 671)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_teacher_suspend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.PanelAdvSearch.ResumeLayout(False)
        Me.PanelAdvSearch.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents dt_start_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents cbo_teacher As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_suspend_letter_num As System.Windows.Forms.TextBox
    Friend WithEvents txt_duration As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dt_end_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_suspend_num As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_remark As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dt_datenote As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_adv_search As System.Windows.Forms.LinkLabel
    Friend WithEvents PanelAdvSearch As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_ad_search As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

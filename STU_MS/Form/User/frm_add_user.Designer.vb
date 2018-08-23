<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_user
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dt_datenote = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.enable_user = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_confirm_password = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_remark = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_user_status = New System.Windows.Forms.ComboBox()
        Me.cbo_staff = New System.Windows.Forms.ComboBox()
        Me.txt_login_name = New System.Windows.Forms.TextBox()
        Me.lbl_save = New System.Windows.Forms.Label()
        Me.lbl_new = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label_exit = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.datagrid)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.lbl_save)
        Me.PanelEx1.Controls.Add(Me.lbl_new)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(905, 546)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AllowUserToOrderColumns = True
        Me.datagrid.AllowUserToResizeColumns = False
        Me.datagrid.AllowUserToResizeRows = False
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.Location = New System.Drawing.Point(10, 283)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid.RowTemplate.Height = 25
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(883, 252)
        Me.datagrid.TabIndex = 152
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Label15)
        Me.GroupPanel1.Controls.Add(Me.dt_datenote)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.Label13)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.enable_user)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label11)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.txt_confirm_password)
        Me.GroupPanel1.Controls.Add(Me.txt_password)
        Me.GroupPanel1.Controls.Add(Me.txt_remark)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.cbo_user_status)
        Me.GroupPanel1.Controls.Add(Me.cbo_staff)
        Me.GroupPanel1.Controls.Add(Me.txt_login_name)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 39)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(905, 202)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 120
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(443, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 32)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "ថ្ងៃបញ្ចូល"
        '
        'dt_datenote
        '
        Me.dt_datenote.CustomFormat = "yyyy-MM-dd"
        Me.dt_datenote.Enabled = False
        Me.dt_datenote.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_datenote.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_datenote.Location = New System.Drawing.Point(602, 142)
        Me.dt_datenote.Name = "dt_datenote"
        Me.dt_datenote.Size = New System.Drawing.Size(254, 40)
        Me.dt_datenote.TabIndex = 137
        Me.dt_datenote.Value = New Date(2018, 4, 2, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(582, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 27)
        Me.Label14.TabIndex = 135
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(533, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 27)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(159, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 27)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(113, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 27)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(121, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 27)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 32)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "បើកសិទ្ធិ"
        '
        'enable_user
        '
        '
        '
        '
        Me.enable_user.BackgroundStyle.Class = ""
        Me.enable_user.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.enable_user.Location = New System.Drawing.Point(183, 149)
        Me.enable_user.Name = "enable_user"
        Me.enable_user.Size = New System.Drawing.Size(66, 22)
        Me.enable_user.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.enable_user.TabIndex = 121
        Me.enable_user.Value = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 32)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "ផ្សេងៗ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 32)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "ឈ្មោះ Login "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 32)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "ឈ្មោះបុគ្គលិក"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(443, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 32)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "បញ្ជាក់លេខសង្ងាត់ "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(443, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 32)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "លេខសង្ងាត់"
        '
        'txt_confirm_password
        '
        Me.txt_confirm_password.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirm_password.Location = New System.Drawing.Point(602, 56)
        Me.txt_confirm_password.Name = "txt_confirm_password"
        Me.txt_confirm_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirm_password.Size = New System.Drawing.Size(254, 40)
        Me.txt_confirm_password.TabIndex = 124
        Me.txt_confirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(602, 13)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(254, 40)
        Me.txt_password.TabIndex = 123
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_remark
        '
        Me.txt_remark.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remark.Location = New System.Drawing.Point(602, 99)
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.Size = New System.Drawing.Size(254, 40)
        Me.txt_remark.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 32)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "ប្រភេទអ្នកប្រើប្រាស់"
        '
        'cbo_user_status
        '
        Me.cbo_user_status.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_user_status.FormattingEnabled = True
        Me.cbo_user_status.Items.AddRange(New Object() {"Administrator", "User"})
        Me.cbo_user_status.Location = New System.Drawing.Point(183, 102)
        Me.cbo_user_status.Name = "cbo_user_status"
        Me.cbo_user_status.Size = New System.Drawing.Size(254, 40)
        Me.cbo_user_status.TabIndex = 120
        '
        'cbo_staff
        '
        Me.cbo_staff.BackColor = System.Drawing.SystemColors.Window
        Me.cbo_staff.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_staff.FormattingEnabled = True
        Me.cbo_staff.Location = New System.Drawing.Point(183, 14)
        Me.cbo_staff.Name = "cbo_staff"
        Me.cbo_staff.Size = New System.Drawing.Size(254, 40)
        Me.cbo_staff.TabIndex = 119
        '
        'txt_login_name
        '
        Me.txt_login_name.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_name.Location = New System.Drawing.Point(183, 58)
        Me.txt_login_name.Name = "txt_login_name"
        Me.txt_login_name.Size = New System.Drawing.Size(254, 40)
        Me.txt_login_name.TabIndex = 30
        '
        'lbl_save
        '
        Me.lbl_save.AutoSize = True
        Me.lbl_save.BackColor = System.Drawing.Color.Transparent
        Me.lbl_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_save.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_save.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl_save.Location = New System.Drawing.Point(440, 245)
        Me.lbl_save.Name = "lbl_save"
        Me.lbl_save.Size = New System.Drawing.Size(73, 34)
        Me.lbl_save.TabIndex = 149
        Me.lbl_save.Text = "រក្សាទុក"
        '
        'lbl_new
        '
        Me.lbl_new.AutoSize = True
        Me.lbl_new.BackColor = System.Drawing.Color.Transparent
        Me.lbl_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_new.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl_new.Location = New System.Drawing.Point(409, 245)
        Me.lbl_new.Name = "lbl_new"
        Me.lbl_new.Size = New System.Drawing.Size(28, 34)
        Me.lbl_new.TabIndex = 148
        Me.lbl_new.Text = "ថ្មី"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.btn_close)
        Me.PanelEx2.Controls.Add(Me.PictureBox4)
        Me.PanelEx2.Controls.Add(Me.label_exit)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(905, 39)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.DodgerBlue
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.RoyalBlue
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 10
        '
        'btn_close
        '
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.STU_MS.My.Resources.Resources.red_close_button_png_image_2878
        Me.btn_close.Location = New System.Drawing.Point(866, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 32)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 10
        Me.btn_close.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.STU_MS.My.Resources.Resources.Apps_preferences_desktop_user_password_icon
        Me.PictureBox4.Location = New System.Drawing.Point(7, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'label_exit
        '
        Me.label_exit.AutoSize = True
        Me.label_exit.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_exit.ForeColor = System.Drawing.SystemColors.Info
        Me.label_exit.LinkColor = System.Drawing.Color.White
        Me.label_exit.Location = New System.Drawing.Point(1291, 9)
        Me.label_exit.Name = "label_exit"
        Me.label_exit.Size = New System.Drawing.Size(67, 27)
        Me.label_exit.TabIndex = 10
        Me.label_exit.TabStop = True
        Me.label_exit.Text = "ចាកចេញ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(371, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ព័ត៌មានអ្នកប្រើប្រាស់"
        '
        'frm_add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 546)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_add_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btn_close As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents label_exit As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_login_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents enable_user As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_confirm_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_remark As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_user_status As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_staff As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_save As System.Windows.Forms.Label
    Friend WithEvents lbl_new As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dt_datenote As System.Windows.Forms.DateTimePicker
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
End Class

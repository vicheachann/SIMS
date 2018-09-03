<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReStudy
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgReStudy = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cboStuCurrentClass = New System.Windows.Forms.ComboBox()
        Me.cboStuFirstYearStudy = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_year_study = New System.Windows.Forms.Label()
        Me.pic_student = New System.Windows.Forms.PictureBox()
        Me.dtStuDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStuNameEn = New System.Windows.Forms.TextBox()
        Me.txtStuNameKh = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboStuGender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx3.SuspendLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dgReStudy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlHeader.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlHeader.Controls.Add(Me.PictureBox4)
        Me.pnlHeader.Controls.Add(Me.btn_close)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1111, 42)
        Me.pnlHeader.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlHeader.Style.BackColor1.Color = System.Drawing.Color.RoyalBlue
        Me.pnlHeader.Style.BackColor2.Color = System.Drawing.Color.DodgerBlue
        Me.pnlHeader.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlHeader.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlHeader.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlHeader.Style.GradientAngle = 90
        Me.pnlHeader.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.STU_MS.My.Resources.Resources.minimize_box_blue
        Me.PictureBox4.Location = New System.Drawing.Point(1032, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 203
        Me.PictureBox4.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.STU_MS.My.Resources.Resources.red_close_button_png_image_2878
        Me.btn_close.Location = New System.Drawing.Point(1067, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 32)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 202
        Me.btn_close.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.skiddll
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 201
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "សិស្សសុំចូលរៀនឡើងវិញ"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.Label14)
        Me.PanelEx3.Controls.Add(Me.picSearch)
        Me.PanelEx3.Controls.Add(Me.lblSearch)
        Me.PanelEx3.Controls.Add(Me.TextBox3)
        Me.PanelEx3.Controls.Add(Me.Label13)
        Me.PanelEx3.Controls.Add(Me.Label10)
        Me.PanelEx3.Controls.Add(Me.GroupPanel1)
        Me.PanelEx3.Controls.Add(Me.dgReStudy)
        Me.PanelEx3.Controls.Add(Me.Label6)
        Me.PanelEx3.Controls.Add(Me.GroupPanel2)
        Me.PanelEx3.Controls.Add(Me.Label2)
        Me.PanelEx3.Controls.Add(Me.lblSave)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(0, 42)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1111, 649)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 348
        Me.PanelEx3.Text = "​"
        '
        'picSearch
        '
        Me.picSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSearch.Image = Global.STU_MS.My.Resources.Resources.SEARCH_324
        Me.picSearch.Location = New System.Drawing.Point(235, 303)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(33, 30)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSearch.TabIndex = 372
        Me.picSearch.TabStop = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearch.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline)
        Me.lblSearch.ForeColor = System.Drawing.Color.Blue
        Me.lblSearch.Location = New System.Drawing.Point(262, 300)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(81, 38)
        Me.lblSearch.TabIndex = 373
        Me.lblSearch.Text = "ស្វែងរក"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.TextBox3.Location = New System.Drawing.Point(7, 300)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(222, 38)
        Me.TextBox3.TabIndex = 367
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(1017, 299)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 38)
        Me.Label13.TabIndex = 371
        Me.Label13.Text = "លុប"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(953, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 38)
        Me.Label10.TabIndex = 370
        Me.Label10.Text = "កែប្រែ"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.TextBox2)
        Me.GroupPanel1.Controls.Add(Me.TextBox1)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.ComboBox2)
        Me.GroupPanel1.Controls.Add(Me.ComboBox1)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Location = New System.Drawing.Point(9, 223)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1093, 48)
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
        Me.GroupPanel1.TabIndex = 367
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(419, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 32)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "ល.រចុងក្រោយ"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.TextBox2.Location = New System.Drawing.Point(537, 1)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 38)
        Me.TextBox2.TabIndex = 367
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.TextBox1.Location = New System.Drawing.Point(673, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(411, 38)
        Me.TextBox1.TabIndex = 367
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 32)
        Me.Label8.TabIndex = 340
        Me.Label8.Text = "សុំចូលរៀនថ្នាក់ទី"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(604, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 32)
        Me.Label5.TabIndex = 368
        Me.Label5.Text = "ផ្សេងៗ"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.ComboBox2.Location = New System.Drawing.Point(319, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(96, 38)
        Me.ComboBox2.TabIndex = 365
        Me.ComboBox2.Text = "2018-2017"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.ComboBox1.Location = New System.Drawing.Point(142, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(75, 38)
        Me.ComboBox1.TabIndex = 363
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 32)
        Me.Label4.TabIndex = 364
        Me.Label4.Text = "ក្នុងឆ្នាំសិក្សា"
        '
        'dgReStudy
        '
        Me.dgReStudy.AllowUserToAddRows = False
        Me.dgReStudy.AllowUserToDeleteRows = False
        Me.dgReStudy.AllowUserToResizeColumns = False
        Me.dgReStudy.AllowUserToResizeRows = False
        Me.dgReStudy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgReStudy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReStudy.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgReStudy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReStudy.Location = New System.Drawing.Point(7, 343)
        Me.dgReStudy.MultiSelect = False
        Me.dgReStudy.Name = "dgReStudy"
        Me.dgReStudy.ReadOnly = True
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReStudy.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgReStudy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReStudy.Size = New System.Drawing.Size(1096, 298)
        Me.dgReStudy.TabIndex = 369
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(433, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(268, 38)
        Me.Label6.TabIndex = 367
        Me.Label6.Text = "បញ្ចូលទៅលេខរៀងចុងក្រោយ"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cboStuCurrentClass)
        Me.GroupPanel2.Controls.Add(Me.cboStuFirstYearStudy)
        Me.GroupPanel2.Controls.Add(Me.Label25)
        Me.GroupPanel2.Controls.Add(Me.lbl_year_study)
        Me.GroupPanel2.Controls.Add(Me.pic_student)
        Me.GroupPanel2.Controls.Add(Me.dtStuDOB)
        Me.GroupPanel2.Controls.Add(Me.Label12)
        Me.GroupPanel2.Controls.Add(Me.Label81)
        Me.GroupPanel2.Controls.Add(Me.Label80)
        Me.GroupPanel2.Controls.Add(Me.Label3)
        Me.GroupPanel2.Controls.Add(Me.Label9)
        Me.GroupPanel2.Controls.Add(Me.txtStuNameEn)
        Me.GroupPanel2.Controls.Add(Me.txtStuNameKh)
        Me.GroupPanel2.Controls.Add(Me.Label11)
        Me.GroupPanel2.Controls.Add(Me.cboStuGender)
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 35)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1087, 185)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 363
        '
        'cboStuCurrentClass
        '
        Me.cboStuCurrentClass.DropDownHeight = 200
        Me.cboStuCurrentClass.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboStuCurrentClass.FormattingEnabled = True
        Me.cboStuCurrentClass.IntegralHeight = False
        Me.cboStuCurrentClass.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.cboStuCurrentClass.Location = New System.Drawing.Point(670, 110)
        Me.cboStuCurrentClass.Name = "cboStuCurrentClass"
        Me.cboStuCurrentClass.Size = New System.Drawing.Size(234, 38)
        Me.cboStuCurrentClass.TabIndex = 366
        '
        'cboStuFirstYearStudy
        '
        Me.cboStuFirstYearStudy.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboStuFirstYearStudy.FormattingEnabled = True
        Me.cboStuFirstYearStudy.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.cboStuFirstYearStudy.Location = New System.Drawing.Point(670, 66)
        Me.cboStuFirstYearStudy.Name = "cboStuFirstYearStudy"
        Me.cboStuFirstYearStudy.Size = New System.Drawing.Size(234, 38)
        Me.cboStuFirstYearStudy.TabIndex = 365
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label25.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(495, 114)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 30)
        Me.Label25.TabIndex = 364
        Me.Label25.Text = "ថ្នាក់ឈប់ចុងក្រោយ"
        '
        'lbl_year_study
        '
        Me.lbl_year_study.AutoSize = True
        Me.lbl_year_study.BackColor = System.Drawing.Color.Transparent
        Me.lbl_year_study.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_year_study.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year_study.ForeColor = System.Drawing.Color.Black
        Me.lbl_year_study.Location = New System.Drawing.Point(495, 72)
        Me.lbl_year_study.Name = "lbl_year_study"
        Me.lbl_year_study.Size = New System.Drawing.Size(171, 30)
        Me.lbl_year_study.TabIndex = 363
        Me.lbl_year_study.Text = "ឆ្នាំសិក្សាឈប់ចុងក្រោយ"
        '
        'pic_student
        '
        Me.pic_student.BackColor = System.Drawing.Color.White
        Me.pic_student.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_student.Location = New System.Drawing.Point(950, 21)
        Me.pic_student.Name = "pic_student"
        Me.pic_student.Size = New System.Drawing.Size(103, 136)
        Me.pic_student.TabIndex = 362
        Me.pic_student.TabStop = False
        '
        'dtStuDOB
        '
        Me.dtStuDOB.CustomFormat = "yyyy-MM-dd"
        Me.dtStuDOB.Enabled = False
        Me.dtStuDOB.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dtStuDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStuDOB.Location = New System.Drawing.Point(670, 21)
        Me.dtStuDOB.Name = "dtStuDOB"
        Me.dtStuDOB.Size = New System.Drawing.Size(234, 38)
        Me.dtStuDOB.TabIndex = 361
        Me.dtStuDOB.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(495, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 30)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "ថ្ងៃខែឆ្នាំកំណើត"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Brown
        Me.Label81.Location = New System.Drawing.Point(136, 68)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(78, 30)
        Me.Label81.TabIndex = 359
        Me.Label81.Text = "(ឡាតាំង) "
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.Brown
        Me.Label80.Location = New System.Drawing.Point(139, 27)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(46, 30)
        Me.Label80.TabIndex = 358
        Me.Label80.Text = "(ខ្មែរ)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 30)
        Me.Label3.TabIndex = 357
        Me.Label3.Text = "ឈ្មោះ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(89, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 30)
        Me.Label9.TabIndex = 356
        Me.Label9.Text = "ឈ្មោះ"
        '
        'txtStuNameEn
        '
        Me.txtStuNameEn.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txtStuNameEn.Location = New System.Drawing.Point(215, 66)
        Me.txtStuNameEn.Name = "txtStuNameEn"
        Me.txtStuNameEn.Size = New System.Drawing.Size(234, 38)
        Me.txtStuNameEn.TabIndex = 355
        '
        'txtStuNameKh
        '
        Me.txtStuNameKh.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txtStuNameKh.Location = New System.Drawing.Point(215, 22)
        Me.txtStuNameKh.Name = "txtStuNameKh"
        Me.txtStuNameKh.Size = New System.Drawing.Size(234, 38)
        Me.txtStuNameKh.TabIndex = 354
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(94, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 30)
        Me.Label11.TabIndex = 352
        Me.Label11.Text = "ភេទ"
        '
        'cboStuGender
        '
        Me.cboStuGender.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboStuGender.FormattingEnabled = True
        Me.cboStuGender.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.cboStuGender.Location = New System.Drawing.Point(215, 110)
        Me.cboStuGender.Name = "cboStuGender"
        Me.cboStuGender.Size = New System.Drawing.Size(234, 38)
        Me.cboStuGender.TabIndex = 353
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Muol Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(496, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 27)
        Me.Label2.TabIndex = 204
        Me.Label2.Text = "ព័ត៌មានសិស្ស"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.BackColor = System.Drawing.Color.Transparent
        Me.lblSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSave.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.Blue
        Me.lblSave.Location = New System.Drawing.Point(705, 299)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(244, 38)
        Me.lblSave.TabIndex = 106
        Me.lblSave.Text = "បញ្ចូលនិងតំរៀបលេខរៀងថ្មី"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(396, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 38)
        Me.Label14.TabIndex = 374
        Me.Label14.Text = "ថ្មី"
        '
        'FrmReStudy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 691)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReStudy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReStudy"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.dgReStudy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_close As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSave As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStuNameEn As TextBox
    Friend WithEvents txtStuNameKh As TextBox
    Friend WithEvents cboStuGender As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dtStuDOB As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pic_student As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cboStuCurrentClass As ComboBox
    Friend WithEvents cboStuFirstYearStudy As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_year_study As Label
    Friend WithEvents dgReStudy As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents Label14 As Label
End Class

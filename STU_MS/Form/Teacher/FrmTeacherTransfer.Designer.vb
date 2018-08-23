<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTeacherTransfer
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSaveImg = New System.Windows.Forms.Label()
        Me.lblOpenImg = New System.Windows.Forms.Label()
        Me.picFile = New System.Windows.Forms.PictureBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.cboTransferToProvince = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTeacher = New System.Windows.Forms.ComboBox()
        Me.txtTransferTo = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.dtTransferDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.cboCurrentSubject = New System.Windows.Forms.ComboBox()
        Me.cboTeacherManager = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDistrictManager = New System.Windows.Forms.TextBox()
        Me.txtObjective = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PanelEx4.SuspendLayout()
        CType(Me.picFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.Label17)
        Me.PanelEx4.Controls.Add(Me.Label16)
        Me.PanelEx4.Controls.Add(Me.Label15)
        Me.PanelEx4.Controls.Add(Me.Label12)
        Me.PanelEx4.Controls.Add(Me.txtObjective)
        Me.PanelEx4.Controls.Add(Me.txtDistrictManager)
        Me.PanelEx4.Controls.Add(Me.Label11)
        Me.PanelEx4.Controls.Add(Me.Label7)
        Me.PanelEx4.Controls.Add(Me.Label6)
        Me.PanelEx4.Controls.Add(Me.cboTeacherManager)
        Me.PanelEx4.Controls.Add(Me.cboCurrentSubject)
        Me.PanelEx4.Controls.Add(Me.Label10)
        Me.PanelEx4.Controls.Add(Me.Label9)
        Me.PanelEx4.Controls.Add(Me.Label8)
        Me.PanelEx4.Controls.Add(Me.lblSaveImg)
        Me.PanelEx4.Controls.Add(Me.lblOpenImg)
        Me.PanelEx4.Controls.Add(Me.picFile)
        Me.PanelEx4.Controls.Add(Me.txtRemark)
        Me.PanelEx4.Controls.Add(Me.txtReason)
        Me.PanelEx4.Controls.Add(Me.cboTransferToProvince)
        Me.PanelEx4.Controls.Add(Me.Label5)
        Me.PanelEx4.Controls.Add(Me.Label4)
        Me.PanelEx4.Controls.Add(Me.Label3)
        Me.PanelEx4.Controls.Add(Me.Label2)
        Me.PanelEx4.Controls.Add(Me.cboTeacher)
        Me.PanelEx4.Controls.Add(Me.txtTransferTo)
        Me.PanelEx4.Controls.Add(Me.dg)
        Me.PanelEx4.Controls.Add(Me.lblDelete)
        Me.PanelEx4.Controls.Add(Me.lblUpdate)
        Me.PanelEx4.Controls.Add(Me.lblSave)
        Me.PanelEx4.Controls.Add(Me.lblNew)
        Me.PanelEx4.Controls.Add(Me.Label118)
        Me.PanelEx4.Controls.Add(Me.Label34)
        Me.PanelEx4.Controls.Add(Me.dtTransferDate)
        Me.PanelEx4.Controls.Add(Me.Label14)
        Me.PanelEx4.Controls.Add(Me.Label13)
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 39)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(1135, 622)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.DodgerBlue
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(502, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 32)
        Me.Label10.TabIndex = 359
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(502, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 32)
        Me.Label9.TabIndex = 358
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(502, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 32)
        Me.Label8.TabIndex = 357
        Me.Label8.Text = "*"
        '
        'lblSaveImg
        '
        Me.lblSaveImg.AutoSize = True
        Me.lblSaveImg.BackColor = System.Drawing.Color.Transparent
        Me.lblSaveImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSaveImg.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaveImg.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblSaveImg.Location = New System.Drawing.Point(1045, 248)
        Me.lblSaveImg.Name = "lblSaveImg"
        Me.lblSaveImg.Size = New System.Drawing.Size(75, 38)
        Me.lblSaveImg.TabIndex = 356
        Me.lblSaveImg.Text = "បញ្ចូល"
        '
        'lblOpenImg
        '
        Me.lblOpenImg.AutoSize = True
        Me.lblOpenImg.BackColor = System.Drawing.Color.Transparent
        Me.lblOpenImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOpenImg.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenImg.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblOpenImg.Location = New System.Drawing.Point(839, 248)
        Me.lblOpenImg.Name = "lblOpenImg"
        Me.lblOpenImg.Size = New System.Drawing.Size(202, 38)
        Me.lblOpenImg.TabIndex = 355
        Me.lblOpenImg.Text = "ស្វែងរករូបភាពឯកសារ"
        '
        'picFile
        '
        Me.picFile.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFile.Location = New System.Drawing.Point(938, 12)
        Me.picFile.Name = "picFile"
        Me.picFile.Size = New System.Drawing.Size(182, 204)
        Me.picFile.TabIndex = 354
        Me.picFile.TabStop = False
        '
        'txtRemark
        '
        Me.txtRemark.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txtRemark.Location = New System.Drawing.Point(766, 12)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(161, 79)
        Me.txtRemark.TabIndex = 353
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txtReason.Location = New System.Drawing.Point(526, 12)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReason.Size = New System.Drawing.Size(161, 79)
        Me.txtReason.TabIndex = 352
        '
        'cboTransferToProvince
        '
        Me.cboTransferToProvince.DropDownHeight = 140
        Me.cboTransferToProvince.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboTransferToProvince.FormattingEnabled = True
        Me.cboTransferToProvince.IntegralHeight = False
        Me.cboTransferToProvince.Location = New System.Drawing.Point(526, 135)
        Me.cboTransferToProvince.Name = "cboTransferToProvince"
        Me.cboTransferToProvince.Size = New System.Drawing.Size(161, 38)
        Me.cboTransferToProvince.TabIndex = 351
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(698, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 32)
        Me.Label5.TabIndex = 350
        Me.Label5.Text = "ផ្សេងៗ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(385, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 32)
        Me.Label4.TabIndex = 349
        Me.Label4.Text = "មូលហេតុ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(385, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 32)
        Me.Label3.TabIndex = 348
        Me.Label3.Text = "ខេត្ត"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(385, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 32)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "ផ្ទេរទៅ"
        '
        'cboTeacher
        '
        Me.cboTeacher.DropDownHeight = 130
        Me.cboTeacher.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboTeacher.FormattingEnabled = True
        Me.cboTeacher.IntegralHeight = False
        Me.cboTeacher.Location = New System.Drawing.Point(221, 12)
        Me.cboTeacher.Name = "cboTeacher"
        Me.cboTeacher.Size = New System.Drawing.Size(161, 38)
        Me.cboTeacher.TabIndex = 346
        '
        'txtTransferTo
        '
        Me.txtTransferTo.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txtTransferTo.Location = New System.Drawing.Point(526, 94)
        Me.txtTransferTo.Name = "txtTransferTo"
        Me.txtTransferTo.Size = New System.Drawing.Size(161, 38)
        Me.txtTransferTo.TabIndex = 173
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToOrderColumns = True
        Me.dg.AllowUserToResizeColumns = False
        Me.dg.AllowUserToResizeRows = False
        Me.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(7, 300)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dg.RowTemplate.Height = 25
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1117, 315)
        Me.dg.TabIndex = 110
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.BackColor = System.Drawing.Color.Transparent
        Me.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDelete.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblDelete.Location = New System.Drawing.Point(620, 248)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(53, 38)
        Me.lblDelete.TabIndex = 193
        Me.lblDelete.Text = "លុប"
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUpdate.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblUpdate.Location = New System.Drawing.Point(552, 249)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(66, 38)
        Me.lblUpdate.TabIndex = 192
        Me.lblUpdate.Text = "កែប្រែ"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.BackColor = System.Drawing.Color.Transparent
        Me.lblSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSave.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblSave.Location = New System.Drawing.Point(476, 249)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(80, 38)
        Me.lblSave.TabIndex = 191
        Me.lblSave.Text = "រក្សាទុក"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.BackColor = System.Drawing.Color.Transparent
        Me.lblNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNew.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblNew.Location = New System.Drawing.Point(385, 249)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(89, 38)
        Me.lblNew.TabIndex = 190
        Me.lblNew.Text = "បញ្ចូលថ្មី"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.BackColor = System.Drawing.Color.Transparent
        Me.Label118.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label118.Location = New System.Drawing.Point(9, 16)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(87, 32)
        Me.Label118.TabIndex = 176
        Me.Label118.Text = "គ្រូបង្រៀន"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label34.Location = New System.Drawing.Point(385, 178)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(123, 32)
        Me.Label34.TabIndex = 180
        Me.Label34.Text = "កាលបរិច្ឆេទផ្ទេរ"
        '
        'dtTransferDate
        '
        Me.dtTransferDate.CustomFormat = "yyyy-MM-dd"
        Me.dtTransferDate.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dtTransferDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTransferDate.Location = New System.Drawing.Point(526, 178)
        Me.dtTransferDate.Name = "dtTransferDate"
        Me.dtTransferDate.Size = New System.Drawing.Size(161, 38)
        Me.dtTransferDate.TabIndex = 181
        Me.dtTransferDate.Value = New Date(2018, 3, 7, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(502, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 32)
        Me.Label14.TabIndex = 345
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(197, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 32)
        Me.Label13.TabIndex = 344
        Me.Label13.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(523, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "គ្រូផ្ទេរ"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.STU_MS.My.Resources.Resources.transfer
        Me.PictureBox4.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.STU_MS.My.Resources.Resources.red_close_button_png_image_2878
        Me.btnClose.Location = New System.Drawing.Point(1094, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 32)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 10
        Me.btnClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.minimize_box_blue
        Me.PictureBox1.Location = New System.Drawing.Point(1056, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.PictureBox1)
        Me.PanelEx2.Controls.Add(Me.btnClose)
        Me.PanelEx2.Controls.Add(Me.PictureBox4)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1135, 39)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.RoyalBlue
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.DodgerBlue
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 11
        '
        'cboCurrentSubject
        '
        Me.cboCurrentSubject.DropDownHeight = 140
        Me.cboCurrentSubject.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboCurrentSubject.FormattingEnabled = True
        Me.cboCurrentSubject.IntegralHeight = False
        Me.cboCurrentSubject.Location = New System.Drawing.Point(221, 53)
        Me.cboCurrentSubject.Name = "cboCurrentSubject"
        Me.cboCurrentSubject.Size = New System.Drawing.Size(161, 38)
        Me.cboCurrentSubject.TabIndex = 360
        '
        'cboTeacherManager
        '
        Me.cboTeacherManager.DropDownHeight = 140
        Me.cboTeacherManager.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboTeacherManager.FormattingEnabled = True
        Me.cboTeacherManager.IntegralHeight = False
        Me.cboTeacherManager.Location = New System.Drawing.Point(221, 94)
        Me.cboTeacherManager.Name = "cboTeacherManager"
        Me.cboTeacherManager.Size = New System.Drawing.Size(161, 38)
        Me.cboTeacherManager.TabIndex = 361
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(9, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 32)
        Me.Label6.TabIndex = 362
        Me.Label6.Text = "នាយកសាលា"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(9, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 32)
        Me.Label7.TabIndex = 363
        Me.Label7.Text = "បង្រៀនមុខវិជ្ជា"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(9, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(213, 32)
        Me.Label11.TabIndex = 365
        Me.Label11.Text = "ប្រធានការិយាល័យអប់រំស្រុក"
        '
        'txtDistrictManager
        '
        Me.txtDistrictManager.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txtDistrictManager.Location = New System.Drawing.Point(221, 135)
        Me.txtDistrictManager.Name = "txtDistrictManager"
        Me.txtDistrictManager.Size = New System.Drawing.Size(161, 38)
        Me.txtDistrictManager.TabIndex = 366
        '
        'txtObjective
        '
        Me.txtObjective.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txtObjective.Location = New System.Drawing.Point(221, 176)
        Me.txtObjective.Name = "txtObjective"
        Me.txtObjective.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObjective.Size = New System.Drawing.Size(161, 38)
        Me.txtObjective.TabIndex = 367
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(9, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 32)
        Me.Label12.TabIndex = 368
        Me.Label12.Text = "កម្មវត្ថុ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(197, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 32)
        Me.Label15.TabIndex = 369
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(198, 178)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 32)
        Me.Label16.TabIndex = 370
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(198, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 32)
        Me.Label17.TabIndex = 371
        Me.Label17.Text = "*"
        '
        'FrmTeacherTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 661)
        Me.Controls.Add(Me.PanelEx4)
        Me.Controls.Add(Me.PanelEx2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTeacherTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTeacherTransfer"
        Me.PanelEx4.ResumeLayout(False)
        Me.PanelEx4.PerformLayout()
        CType(Me.picFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cboTeacher As ComboBox
    Friend WithEvents txtTransferTo As TextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents lblDelete As Label
    Friend WithEvents lblUpdate As Label
    Friend WithEvents lblSave As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents dtTransferDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSaveImg As Label
    Friend WithEvents lblOpenImg As Label
    Friend WithEvents picFile As PictureBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents cboTransferToProvince As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtObjective As TextBox
    Friend WithEvents txtDistrictManager As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboTeacherManager As ComboBox
    Friend WithEvents cboCurrentSubject As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class

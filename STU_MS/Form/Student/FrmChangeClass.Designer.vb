<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChangeClass
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblChangeToStudentFormer = New System.Windows.Forms.Label()
        Me.PAll = New System.Windows.Forms.Panel()
        Me.rbDropStudy = New System.Windows.Forms.RadioButton()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.lblDynamic = New System.Windows.Forms.Label()
        Me.cboDynamic = New System.Windows.Forms.ComboBox()
        Me.rbChangeClass = New System.Windows.Forms.RadioButton()
        Me.rbTranferIn = New System.Windows.Forms.RadioButton()
        Me.rbtransferOut = New System.Windows.Forms.RadioButton()
        Me.rbFailedStudent = New System.Windows.Forms.RadioButton()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotalSelectedGirl = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotalSearchGirl = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotalSearch = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.dg)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1203, 504)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeColumns = False
        Me.dg.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Khmer OS", 10.0!)
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column17, Me.Column10, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column11, Me.Column12, Me.Column15, Me.Column14, Me.Column6, Me.Column7, Me.Column8, Me.Column16, Me.Column9, Me.Column13, Me.Column18})
        Me.dg.Location = New System.Drawing.Point(6, 92)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dg.RowHeadersVisible = False
        Me.dg.RowTemplate.Height = 25
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1194, 361)
        Me.dg.TabIndex = 309
        '
        'Column17
        '
        Me.Column17.HeaderText = "RECORD_ID"
        Me.Column17.Name = "Column17"
        Me.Column17.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        Me.Column10.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "ល.រ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "STUDENT_ID"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        Me.Column2.Width = 5
        '
        'Column3
        '
        Me.Column3.HeaderText = "ឈ្មោះសិស្ស"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "ភេទ"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "លេខកូដ"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'Column11
        '
        Me.Column11.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 120
        '
        'Column12
        '
        Me.Column12.HeaderText = "ភូមិ"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "STUDY_STATUS_ID"
        Me.Column15.Name = "Column15"
        Me.Column15.Visible = False
        '
        'Column14
        '
        Me.Column14.HeaderText = "ស្ថានភាពសិក្សា"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "ឆ្នាំសិក្សាចាស់"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 115
        '
        'Column7
        '
        Me.Column7.HeaderText = "ថ្នាក់ចាស់"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "ឆ្នាំសិក្សាថ្មី"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 115
        '
        'Column16
        '
        Me.Column16.HeaderText = "NEW_CLASS_ID"
        Me.Column16.Name = "Column16"
        Me.Column16.Visible = False
        '
        'Column9
        '
        Me.Column9.HeaderText = "ថ្នាក់ថ្មី"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 70
        '
        'Column13
        '
        Me.Column13.HeaderText = "ផ្សេងៗ"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 150
        '
        'Column18
        '
        Me.Column18.HeaderText = "ប្រធានទី"
        Me.Column18.Name = "Column18"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.lblChangeToStudentFormer)
        Me.GroupPanel1.Controls.Add(Me.PAll)
        Me.GroupPanel1.Controls.Add(Me.rbDropStudy)
        Me.GroupPanel1.Controls.Add(Me.pnl1)
        Me.GroupPanel1.Controls.Add(Me.rbChangeClass)
        Me.GroupPanel1.Controls.Add(Me.rbTranferIn)
        Me.GroupPanel1.Controls.Add(Me.rbtransferOut)
        Me.GroupPanel1.Controls.Add(Me.rbFailedStudent)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 39)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1203, 52)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.Color.SkyBlue
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground2
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
        Me.GroupPanel1.TabIndex = 308
        '
        'lblChangeToStudentFormer
        '
        Me.lblChangeToStudentFormer.AutoSize = True
        Me.lblChangeToStudentFormer.BackColor = System.Drawing.Color.Transparent
        Me.lblChangeToStudentFormer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblChangeToStudentFormer.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeToStudentFormer.ForeColor = System.Drawing.Color.Blue
        Me.lblChangeToStudentFormer.Location = New System.Drawing.Point(596, 4)
        Me.lblChangeToStudentFormer.Name = "lblChangeToStudentFormer"
        Me.lblChangeToStudentFormer.Size = New System.Drawing.Size(153, 38)
        Me.lblChangeToStudentFormer.TabIndex = 228
        Me.lblChangeToStudentFormer.Text = "ប្តូរជាអតីតសិស្ស"
        '
        'PAll
        '
        Me.PAll.BackColor = System.Drawing.Color.Transparent
        Me.PAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PAll.Location = New System.Drawing.Point(774, 1)
        Me.PAll.Name = "PAll"
        Me.PAll.Size = New System.Drawing.Size(1, 45)
        Me.PAll.TabIndex = 229
        '
        'rbDropStudy
        '
        Me.rbDropStudy.AutoSize = True
        Me.rbDropStudy.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDropStudy.ForeColor = System.Drawing.Color.Navy
        Me.rbDropStudy.Location = New System.Drawing.Point(408, 2)
        Me.rbDropStudy.Name = "rbDropStudy"
        Me.rbDropStudy.Size = New System.Drawing.Size(181, 42)
        Me.rbDropStudy.TabIndex = 227
        Me.rbDropStudy.Text = "បោះបង់ការសិក្សា"
        Me.rbDropStudy.UseVisualStyleBackColor = True
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.lblSave)
        Me.pnl1.Controls.Add(Me.lblDynamic)
        Me.pnl1.Controls.Add(Me.cboDynamic)
        Me.pnl1.Location = New System.Drawing.Point(800, -1)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(387, 47)
        Me.pnl1.TabIndex = 227
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.BackColor = System.Drawing.Color.Transparent
        Me.lblSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSave.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.Blue
        Me.lblSave.Location = New System.Drawing.Point(258, 4)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(80, 38)
        Me.lblSave.TabIndex = 227
        Me.lblSave.Text = "រក្សាទុក"
        '
        'lblDynamic
        '
        Me.lblDynamic.AutoSize = True
        Me.lblDynamic.BackColor = System.Drawing.Color.Transparent
        Me.lblDynamic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDynamic.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDynamic.ForeColor = System.Drawing.Color.Black
        Me.lblDynamic.Location = New System.Drawing.Point(5, 4)
        Me.lblDynamic.Name = "lblDynamic"
        Me.lblDynamic.Size = New System.Drawing.Size(103, 38)
        Me.lblDynamic.TabIndex = 217
        Me.lblDynamic.Text = "ឆ្នាំសិក្សាថ្មី"
        '
        'cboDynamic
        '
        Me.cboDynamic.DropDownHeight = 200
        Me.cboDynamic.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboDynamic.FormattingEnabled = True
        Me.cboDynamic.IntegralHeight = False
        Me.cboDynamic.Location = New System.Drawing.Point(144, 3)
        Me.cboDynamic.Name = "cboDynamic"
        Me.cboDynamic.Size = New System.Drawing.Size(107, 38)
        Me.cboDynamic.TabIndex = 216
        '
        'rbChangeClass
        '
        Me.rbChangeClass.AutoSize = True
        Me.rbChangeClass.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbChangeClass.ForeColor = System.Drawing.Color.Navy
        Me.rbChangeClass.Location = New System.Drawing.Point(114, 2)
        Me.rbChangeClass.Name = "rbChangeClass"
        Me.rbChangeClass.Size = New System.Drawing.Size(92, 42)
        Me.rbChangeClass.TabIndex = 226
        Me.rbChangeClass.Text = "ប្តូរថ្នាក់"
        Me.rbChangeClass.UseVisualStyleBackColor = True
        '
        'rbTranferIn
        '
        Me.rbTranferIn.AutoSize = True
        Me.rbTranferIn.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTranferIn.ForeColor = System.Drawing.Color.Navy
        Me.rbTranferIn.Location = New System.Drawing.Point(207, 2)
        Me.rbTranferIn.Name = "rbTranferIn"
        Me.rbTranferIn.Size = New System.Drawing.Size(99, 42)
        Me.rbTranferIn.TabIndex = 225
        Me.rbTranferIn.Text = "ផ្ទេរចូល"
        Me.rbTranferIn.UseVisualStyleBackColor = True
        '
        'rbtransferOut
        '
        Me.rbtransferOut.AutoSize = True
        Me.rbtransferOut.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtransferOut.ForeColor = System.Drawing.Color.Navy
        Me.rbtransferOut.Location = New System.Drawing.Point(307, 2)
        Me.rbtransferOut.Name = "rbtransferOut"
        Me.rbtransferOut.Size = New System.Drawing.Size(106, 42)
        Me.rbtransferOut.TabIndex = 224
        Me.rbtransferOut.Text = "ផ្ទេរចេញ"
        Me.rbtransferOut.UseVisualStyleBackColor = True
        '
        'rbFailedStudent
        '
        Me.rbFailedStudent.AutoSize = True
        Me.rbFailedStudent.Checked = True
        Me.rbFailedStudent.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFailedStudent.ForeColor = System.Drawing.Color.Navy
        Me.rbFailedStudent.Location = New System.Drawing.Point(8, 2)
        Me.rbFailedStudent.Name = "rbFailedStudent"
        Me.rbFailedStudent.Size = New System.Drawing.Size(106, 42)
        Me.rbFailedStudent.TabIndex = 223
        Me.rbFailedStudent.TabStop = True
        Me.rbFailedStudent.Text = "ត្រួតថ្នាក់"
        Me.rbFailedStudent.UseVisualStyleBackColor = True
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.Label11)
        Me.PanelEx3.Controls.Add(Me.lblTotalSelectedGirl)
        Me.PanelEx3.Controls.Add(Me.Label18)
        Me.PanelEx3.Controls.Add(Me.lblTotalSearchGirl)
        Me.PanelEx3.Controls.Add(Me.Label15)
        Me.PanelEx3.Controls.Add(Me.lblTotalSearch)
        Me.PanelEx3.Controls.Add(Me.Label14)
        Me.PanelEx3.Location = New System.Drawing.Point(4, 457)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1196, 42)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.Color = System.Drawing.Color.PowderBlue
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.Color.SkyBlue
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 307
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer OS Bokor", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1299, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 38)
        Me.Label11.TabIndex = 307
        Me.Label11.Text = "នាក់ "
        '
        'lblTotalSelectedGirl
        '
        Me.lblTotalSelectedGirl.AutoSize = True
        Me.lblTotalSelectedGirl.Font = New System.Drawing.Font("Khmer OS Bokor", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSelectedGirl.ForeColor = System.Drawing.Color.Red
        Me.lblTotalSelectedGirl.Location = New System.Drawing.Point(1265, 4)
        Me.lblTotalSelectedGirl.Name = "lblTotalSelectedGirl"
        Me.lblTotalSelectedGirl.Size = New System.Drawing.Size(26, 38)
        Me.lblTotalSelectedGirl.TabIndex = 306
        Me.lblTotalSelectedGirl.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Khmer OS Bokor", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(319, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 38)
        Me.Label18.TabIndex = 301
        Me.Label18.Text = "នាក់ "
        '
        'lblTotalSearchGirl
        '
        Me.lblTotalSearchGirl.AutoSize = True
        Me.lblTotalSearchGirl.Font = New System.Drawing.Font("Khmer OS Bokor", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSearchGirl.ForeColor = System.Drawing.Color.Red
        Me.lblTotalSearchGirl.Location = New System.Drawing.Point(261, 4)
        Me.lblTotalSearchGirl.Name = "lblTotalSearchGirl"
        Me.lblTotalSearchGirl.Size = New System.Drawing.Size(26, 38)
        Me.lblTotalSearchGirl.TabIndex = 300
        Me.lblTotalSearchGirl.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Khmer OS Bokor", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(139, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 38)
        Me.Label15.TabIndex = 299
        Me.Label15.Text = "នាក់  ស្រីចំនួន :"
        '
        'lblTotalSearch
        '
        Me.lblTotalSearch.AutoSize = True
        Me.lblTotalSearch.Font = New System.Drawing.Font("Khmer OS Bokor", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSearch.ForeColor = System.Drawing.Color.Red
        Me.lblTotalSearch.Location = New System.Drawing.Point(98, 4)
        Me.lblTotalSearch.Name = "lblTotalSearch"
        Me.lblTotalSearch.Size = New System.Drawing.Size(26, 38)
        Me.lblTotalSearch.TabIndex = 298
        Me.lblTotalSearch.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Khmer OS Bokor", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 38)
        Me.Label14.TabIndex = 297
        Me.Label14.Text = "សិស្សចំនួន"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.btnClose)
        Me.PanelEx2.Controls.Add(Me.PictureBox4)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1203, 39)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.DodgerBlue
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.RoyalBlue
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.STU_MS.My.Resources.Resources.red_close_button_png_image_2878
        Me.btnClose.Location = New System.Drawing.Point(1159, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 32)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 10
        Me.btnClose.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.STU_MS.My.Resources.Resources.new_student
        Me.PictureBox4.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ប្តូរស្ថានភាពសិក្សាសិស្ស"
        '
        'FrmChangeClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 504)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmChangeClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDynamic As Label
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotalSelectedGirl As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTotalSearchGirl As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotalSearch As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents rbChangeClass As RadioButton
    Friend WithEvents rbTranferIn As RadioButton
    Friend WithEvents rbtransferOut As RadioButton
    Friend WithEvents rbFailedStudent As RadioButton
    Friend WithEvents lblSave As Label
    Friend WithEvents pnl1 As Panel
    Friend WithEvents PAll As Panel
    Friend WithEvents lblChangeToStudentFormer As Label
    Public WithEvents dg As DataGridView
    Public WithEvents rbDropStudy As RadioButton
    Public WithEvents cboDynamic As ComboBox
End Class

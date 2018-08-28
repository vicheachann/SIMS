<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReport
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.pic_student_info = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ListReport = New System.Windows.Forms.ListBox()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.pnlStudentFormer = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboBacth = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboFirstYearStudy = New System.Windows.Forms.ComboBox()
        Me.pnlYearStudyAndClass = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboStuList_class = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboStuList_year = New System.Windows.Forms.ComboBox()
        Me.pnlViewButton = New System.Windows.Forms.Panel()
        Me.lblView = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlYearStudy = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboYearStudy = New System.Windows.Forms.ComboBox()
        Me.DataSet1 = New STU_MS.DataSet1()
        Me.TeacherMeetingAbsence_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsStudentList = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_TEACHER_LIST_ALL_STATUS_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsStudentFormer = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlReportList = New System.Windows.Forms.Panel()
        Me.pnlReportViewer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCompanyInfro = New System.Windows.Forms.Label()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Label()
        Me.PanelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_student_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.pnlStudentFormer.SuspendLayout()
        Me.pnlYearStudyAndClass.SuspendLayout()
        Me.pnlViewButton.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlYearStudy.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherMeetingAbsence_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStudentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_TEACHER_LIST_ALL_STATUS_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStudentFormer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReportList.SuspendLayout()
        Me.pnlReportViewer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelEx7.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.PictureBox2)
        Me.PanelEx2.Controls.Add(Me.btn_close)
        Me.PanelEx2.Controls.Add(Me.pic_student_info)
        Me.PanelEx2.Controls.Add(Me.Label1)
        Me.PanelEx2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1370, 43)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.DodgerBlue
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.RoyalBlue
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.STU_MS.My.Resources.Resources.minimize_box_blue
        Me.PictureBox2.Location = New System.Drawing.Point(1286, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.STU_MS.My.Resources.Resources.red_close_button_png_image_2878
        Me.btn_close.Location = New System.Drawing.Point(1325, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 32)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 11
        Me.btn_close.TabStop = False
        '
        'pic_student_info
        '
        Me.pic_student_info.Image = Global.STU_MS.My.Resources.Resources.report
        Me.pic_student_info.Location = New System.Drawing.Point(5, 4)
        Me.pic_student_info.Name = "pic_student_info"
        Me.pic_student_info.Size = New System.Drawing.Size(39, 35)
        Me.pic_student_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_student_info.TabIndex = 10
        Me.pic_student_info.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "របាយការណ៍"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Panel1)
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx7)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 43)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1370, 745)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 11
        '
        'ListReport
        '
        Me.ListReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListReport.Font = New System.Drawing.Font("Khmer", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListReport.FormattingEnabled = True
        Me.ListReport.ItemHeight = 26
        Me.ListReport.Items.AddRange(New Object() {"Report1", "Report2", "Report3"})
        Me.ListReport.Location = New System.Drawing.Point(5, 5)
        Me.ListReport.Name = "ListReport"
        Me.ListReport.Size = New System.Drawing.Size(245, 640)
        Me.ListReport.TabIndex = 169
        '
        'ReportViewer
        '
        Me.ReportViewer.BackColor = System.Drawing.Color.Silver
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.Location = New System.Drawing.Point(5, 5)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(1105, 640)
        Me.ReportViewer.TabIndex = 2
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.pnlStudentFormer)
        Me.PanelEx3.Controls.Add(Me.pnlYearStudyAndClass)
        Me.PanelEx3.Controls.Add(Me.pnlViewButton)
        Me.PanelEx3.Controls.Add(Me.pnlYearStudy)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1370, 61)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.Color.LightSteelBlue
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 0
        '
        'pnlStudentFormer
        '
        Me.pnlStudentFormer.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlStudentFormer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnlStudentFormer.Controls.Add(Me.Label6)
        Me.pnlStudentFormer.Controls.Add(Me.cboBacth)
        Me.pnlStudentFormer.Controls.Add(Me.Label7)
        Me.pnlStudentFormer.Controls.Add(Me.cboFirstYearStudy)
        Me.pnlStudentFormer.Location = New System.Drawing.Point(272, 6)
        Me.pnlStudentFormer.Name = "pnlStudentFormer"
        Me.pnlStudentFormer.Size = New System.Drawing.Size(410, 49)
        '
        '
        '
        Me.pnlStudentFormer.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlStudentFormer.Style.BackColorGradientAngle = 90
        Me.pnlStudentFormer.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlStudentFormer.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlStudentFormer.Style.BorderBottomWidth = 1
        Me.pnlStudentFormer.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlStudentFormer.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlStudentFormer.Style.BorderLeftWidth = 1
        Me.pnlStudentFormer.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlStudentFormer.Style.BorderRightWidth = 1
        Me.pnlStudentFormer.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlStudentFormer.Style.BorderTopWidth = 1
        Me.pnlStudentFormer.Style.Class = ""
        Me.pnlStudentFormer.Style.CornerDiameter = 4
        Me.pnlStudentFormer.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnlStudentFormer.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.pnlStudentFormer.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlStudentFormer.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnlStudentFormer.StyleMouseDown.Class = ""
        Me.pnlStudentFormer.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnlStudentFormer.StyleMouseOver.Class = ""
        Me.pnlStudentFormer.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnlStudentFormer.TabIndex = 346
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(0, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 34)
        Me.Label6.TabIndex = 302
        Me.Label6.Text = "ឆ្នាំសិក្សាដំបូង"
        '
        'cboBacth
        '
        Me.cboBacth.DropDownHeight = 135
        Me.cboBacth.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboBacth.FormattingEnabled = True
        Me.cboBacth.IntegralHeight = False
        Me.cboBacth.Location = New System.Drawing.Point(294, 2)
        Me.cboBacth.Name = "cboBacth"
        Me.cboBacth.Size = New System.Drawing.Size(103, 38)
        Me.cboBacth.TabIndex = 303
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(230, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 34)
        Me.Label7.TabIndex = 304
        Me.Label7.Text = "ជំនាន់"
        '
        'cboFirstYearStudy
        '
        Me.cboFirstYearStudy.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboFirstYearStudy.FormattingEnabled = True
        Me.cboFirstYearStudy.Location = New System.Drawing.Point(126, 2)
        Me.cboFirstYearStudy.Name = "cboFirstYearStudy"
        Me.cboFirstYearStudy.Size = New System.Drawing.Size(103, 38)
        Me.cboFirstYearStudy.TabIndex = 301
        '
        'pnlYearStudyAndClass
        '
        Me.pnlYearStudyAndClass.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlYearStudyAndClass.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnlYearStudyAndClass.Controls.Add(Me.Label4)
        Me.pnlYearStudyAndClass.Controls.Add(Me.cboStuList_class)
        Me.pnlYearStudyAndClass.Controls.Add(Me.Label5)
        Me.pnlYearStudyAndClass.Controls.Add(Me.cboStuList_year)
        Me.pnlYearStudyAndClass.Location = New System.Drawing.Point(271, 6)
        Me.pnlYearStudyAndClass.Name = "pnlYearStudyAndClass"
        Me.pnlYearStudyAndClass.Size = New System.Drawing.Size(362, 49)
        '
        '
        '
        Me.pnlYearStudyAndClass.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlYearStudyAndClass.Style.BackColorGradientAngle = 90
        Me.pnlYearStudyAndClass.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlYearStudyAndClass.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlYearStudyAndClass.Style.BorderBottomWidth = 1
        Me.pnlYearStudyAndClass.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlYearStudyAndClass.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlYearStudyAndClass.Style.BorderLeftWidth = 1
        Me.pnlYearStudyAndClass.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlYearStudyAndClass.Style.BorderRightWidth = 1
        Me.pnlYearStudyAndClass.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlYearStudyAndClass.Style.BorderTopWidth = 1
        Me.pnlYearStudyAndClass.Style.Class = ""
        Me.pnlYearStudyAndClass.Style.CornerDiameter = 4
        Me.pnlYearStudyAndClass.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnlYearStudyAndClass.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.pnlYearStudyAndClass.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlYearStudyAndClass.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnlYearStudyAndClass.StyleMouseDown.Class = ""
        Me.pnlYearStudyAndClass.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnlYearStudyAndClass.StyleMouseOver.Class = ""
        Me.pnlYearStudyAndClass.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnlYearStudyAndClass.TabIndex = 345
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(0, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 34)
        Me.Label4.TabIndex = 302
        Me.Label4.Text = "ឆ្នាំសិក្សា"
        '
        'cboStuList_class
        '
        Me.cboStuList_class.DropDownHeight = 135
        Me.cboStuList_class.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboStuList_class.FormattingEnabled = True
        Me.cboStuList_class.IntegralHeight = False
        Me.cboStuList_class.Location = New System.Drawing.Point(242, 2)
        Me.cboStuList_class.Name = "cboStuList_class"
        Me.cboStuList_class.Size = New System.Drawing.Size(103, 38)
        Me.cboStuList_class.TabIndex = 303
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(193, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 34)
        Me.Label5.TabIndex = 304
        Me.Label5.Text = "ថ្នាក់"
        '
        'cboStuList_year
        '
        Me.cboStuList_year.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboStuList_year.FormattingEnabled = True
        Me.cboStuList_year.Location = New System.Drawing.Point(85, 2)
        Me.cboStuList_year.Name = "cboStuList_year"
        Me.cboStuList_year.Size = New System.Drawing.Size(103, 38)
        Me.cboStuList_year.TabIndex = 301
        '
        'pnlViewButton
        '
        Me.pnlViewButton.Controls.Add(Me.lblView)
        Me.pnlViewButton.Controls.Add(Me.PictureBox1)
        Me.pnlViewButton.Location = New System.Drawing.Point(689, 6)
        Me.pnlViewButton.Name = "pnlViewButton"
        Me.pnlViewButton.Size = New System.Drawing.Size(108, 49)
        Me.pnlViewButton.TabIndex = 347
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.BackColor = System.Drawing.Color.Transparent
        Me.lblView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblView.Font = New System.Drawing.Font("Khmer OS", 12.75!)
        Me.lblView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblView.Location = New System.Drawing.Point(49, 7)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(53, 34)
        Me.lblView.TabIndex = 303
        Me.lblView.Text = "មើល"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.icons8_view_48
        Me.PictureBox1.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 306
        Me.PictureBox1.TabStop = False
        '
        'pnlYearStudy
        '
        Me.pnlYearStudy.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlYearStudy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnlYearStudy.Controls.Add(Me.Label2)
        Me.pnlYearStudy.Controls.Add(Me.cboYearStudy)
        Me.pnlYearStudy.Location = New System.Drawing.Point(271, 6)
        Me.pnlYearStudy.Name = "pnlYearStudy"
        Me.pnlYearStudy.Size = New System.Drawing.Size(203, 49)
        '
        '
        '
        Me.pnlYearStudy.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlYearStudy.Style.BackColorGradientAngle = 90
        Me.pnlYearStudy.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlYearStudy.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlYearStudy.Style.BorderBottomWidth = 1
        Me.pnlYearStudy.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlYearStudy.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlYearStudy.Style.BorderLeftWidth = 1
        Me.pnlYearStudy.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlYearStudy.Style.BorderRightWidth = 1
        Me.pnlYearStudy.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnlYearStudy.Style.BorderTopWidth = 1
        Me.pnlYearStudy.Style.Class = ""
        Me.pnlYearStudy.Style.CornerDiameter = 4
        Me.pnlYearStudy.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnlYearStudy.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.pnlYearStudy.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlYearStudy.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnlYearStudy.StyleMouseDown.Class = ""
        Me.pnlYearStudy.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnlYearStudy.StyleMouseOver.Class = ""
        Me.pnlYearStudy.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnlYearStudy.TabIndex = 346
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 34)
        Me.Label2.TabIndex = 302
        Me.Label2.Text = "ឆ្នាំសិក្សា"
        '
        'cboYearStudy
        '
        Me.cboYearStudy.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboYearStudy.FormattingEnabled = True
        Me.cboYearStudy.Location = New System.Drawing.Point(88, 2)
        Me.cboYearStudy.Name = "cboYearStudy"
        Me.cboYearStudy.Size = New System.Drawing.Size(103, 38)
        Me.cboYearStudy.TabIndex = 301
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherMeetingAbsence_BindingSource
        '
        Me.TeacherMeetingAbsence_BindingSource.DataMember = "dtTeacherMeetingAbsence"
        Me.TeacherMeetingAbsence_BindingSource.DataSource = Me.DataSet1
        '
        'bsStudentList
        '
        Me.bsStudentList.DataMember = "dtStudent"
        Me.bsStudentList.DataSource = Me.DataSet1
        '
        'V_TEACHER_LIST_ALL_STATUS_BindingSource
        '
        Me.V_TEACHER_LIST_ALL_STATUS_BindingSource.DataMember = "V_TEACHER_LIST_ALL_STATUS"
        Me.V_TEACHER_LIST_ALL_STATUS_BindingSource.DataSource = Me.DataSet1
        '
        'V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs
        '
        Me.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs.DataMember = "V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE"
        Me.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs.DataSource = Me.DataSet1
        '
        'bsStudentFormer
        '
        Me.bsStudentFormer.DataMember = "dtStudentFormer"
        Me.bsStudentFormer.DataSource = Me.DataSet1
        '
        'pnlReportList
        '
        Me.pnlReportList.Controls.Add(Me.ListReport)
        Me.pnlReportList.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlReportList.Location = New System.Drawing.Point(0, 0)
        Me.pnlReportList.Name = "pnlReportList"
        Me.pnlReportList.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlReportList.Size = New System.Drawing.Size(255, 650)
        Me.pnlReportList.TabIndex = 297
        '
        'pnlReportViewer
        '
        Me.pnlReportViewer.Controls.Add(Me.ReportViewer)
        Me.pnlReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReportViewer.Location = New System.Drawing.Point(255, 0)
        Me.pnlReportViewer.Name = "pnlReportViewer"
        Me.pnlReportViewer.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlReportViewer.Size = New System.Drawing.Size(1115, 650)
        Me.pnlReportViewer.TabIndex = 298
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlReportViewer)
        Me.Panel1.Controls.Add(Me.pnlReportList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 650)
        Me.Panel1.TabIndex = 299
        '
        'lblCompanyInfro
        '
        Me.lblCompanyInfro.AutoSize = True
        Me.lblCompanyInfro.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyInfro.Location = New System.Drawing.Point(6, 2)
        Me.lblCompanyInfro.Name = "lblCompanyInfro"
        Me.lblCompanyInfro.Size = New System.Drawing.Size(210, 27)
        Me.lblCompanyInfro.TabIndex = 232
        Me.lblCompanyInfro.Text = "Smart Business Software Solution"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerName.Location = New System.Drawing.Point(306, 3)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(43, 27)
        Me.lblOwnerName.TabIndex = 233
        Me.lblOwnerName.Text = "name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(637, 2)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 27)
        Me.lblEmail.TabIndex = 230
        Me.lblEmail.Text = "emai "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(387, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 27)
        Me.Label16.TabIndex = 234
        Me.Label16.Text = "លេខទូរស័ព្ទ៖"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(583, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 27)
        Me.Label15.TabIndex = 231
        Me.Label15.Text = "Email ៖"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(471, 3)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(89, 27)
        Me.lblPhoneNumber.TabIndex = 235
        Me.lblPhoneNumber.Text = "00000000000"
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(218, 3)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(89, 27)
        Me.a.TabIndex = 229
        Me.a.Text = "- ទំនាក់ទំនង "
        '
        'PanelEx7
        '
        Me.PanelEx7.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx7.Controls.Add(Me.a)
        Me.PanelEx7.Controls.Add(Me.lblPhoneNumber)
        Me.PanelEx7.Controls.Add(Me.Label15)
        Me.PanelEx7.Controls.Add(Me.Label16)
        Me.PanelEx7.Controls.Add(Me.lblEmail)
        Me.PanelEx7.Controls.Add(Me.lblOwnerName)
        Me.PanelEx7.Controls.Add(Me.lblCompanyInfro)
        Me.PanelEx7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx7.Location = New System.Drawing.Point(0, 711)
        Me.PanelEx7.Name = "PanelEx7"
        Me.PanelEx7.Size = New System.Drawing.Size(1370, 34)
        Me.PanelEx7.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx7.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelEx7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PanelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx7.Style.GradientAngle = 90
        Me.PanelEx7.TabIndex = 296
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1370, 788)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.PanelEx2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_student_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.pnlStudentFormer.ResumeLayout(False)
        Me.pnlStudentFormer.PerformLayout()
        Me.pnlYearStudyAndClass.ResumeLayout(False)
        Me.pnlYearStudyAndClass.PerformLayout()
        Me.pnlViewButton.ResumeLayout(False)
        Me.pnlViewButton.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlYearStudy.ResumeLayout(False)
        Me.pnlYearStudy.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherMeetingAbsence_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStudentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_TEACHER_LIST_ALL_STATUS_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStudentFormer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReportList.ResumeLayout(False)
        Me.pnlReportViewer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelEx7.ResumeLayout(False)
        Me.PanelEx7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_close As System.Windows.Forms.PictureBox
    Friend WithEvents pic_student_info As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ListReport As ListBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TeacherMeetingAbsence_BindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents cboYearStudy As ComboBox
    Friend WithEvents lblView As Label
    Friend WithEvents cboStuList_class As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboStuList_year As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bsStudentList As BindingSource
    Friend WithEvents V_TEACHER_LIST_ALL_STATUS_BindingSource As BindingSource
    Friend WithEvents V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs As BindingSource
    Friend WithEvents pnlYearStudyAndClass As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents pnlYearStudy As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents pnlViewButton As Panel
    Friend WithEvents pnlStudentFormer As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents cboBacth As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboFirstYearStudy As ComboBox
    Friend WithEvents bsStudentFormer As BindingSource
    Friend WithEvents pnlReportList As Panel
    Friend WithEvents pnlReportViewer As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents a As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents lblCompanyInfro As Label
End Class

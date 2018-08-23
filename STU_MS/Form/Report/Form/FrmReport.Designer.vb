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
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListReport = New System.Windows.Forms.ListBox()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.pnlStuList = New System.Windows.Forms.Panel()
        Me.cboStuList_class = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboStuList_year = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlYearStudy = New System.Windows.Forms.Panel()
        Me.cboYearStudy = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblView = New System.Windows.Forms.Label()
        Me.DataSet1 = New STU_MS.DataSet1()
        Me.TeacherMeetingAbsence_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_STUDENT_LIST_ALL_STATUS_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_TEACHER_LIST_ALL_STATUS_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_student_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.pnlStuList.SuspendLayout()
        Me.pnlYearStudy.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherMeetingAbsence_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_STUDENT_LIST_ALL_STATUS_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_TEACHER_LIST_ALL_STATUS_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "របាយការណ៍"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx4)
        Me.PanelEx1.Controls.Add(Me.ListReport)
        Me.PanelEx1.Controls.Add(Me.ReportViewer)
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 43)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1370, 530)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 11
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.Label3)
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx4.Location = New System.Drawing.Point(0, 505)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(1370, 25)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.PowderBlue
        Me.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.CornflowerBlue
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 170
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Design by Smart Business Software Solution"
        '
        'ListReport
        '
        Me.ListReport.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListReport.FormattingEnabled = True
        Me.ListReport.ItemHeight = 30
        Me.ListReport.Items.AddRange(New Object() {"Report1", "Report2", "Report3"})
        Me.ListReport.Location = New System.Drawing.Point(5, 62)
        Me.ListReport.Name = "ListReport"
        Me.ListReport.Size = New System.Drawing.Size(265, 634)
        Me.ListReport.TabIndex = 169
        '
        'ReportViewer
        '
        Me.ReportViewer.Location = New System.Drawing.Point(276, 61)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(1082, 635)
        Me.ReportViewer.TabIndex = 2
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.pnlStuList)
        Me.PanelEx3.Controls.Add(Me.pnlYearStudy)
        Me.PanelEx3.Controls.Add(Me.PictureBox1)
        Me.PanelEx3.Controls.Add(Me.lblView)
        Me.PanelEx3.Location = New System.Drawing.Point(3, 2)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1355, 53)
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
        'pnlStuList
        '
        Me.pnlStuList.Controls.Add(Me.cboStuList_class)
        Me.pnlStuList.Controls.Add(Me.Label5)
        Me.pnlStuList.Controls.Add(Me.cboStuList_year)
        Me.pnlStuList.Controls.Add(Me.Label4)
        Me.pnlStuList.Location = New System.Drawing.Point(224, 3)
        Me.pnlStuList.Name = "pnlStuList"
        Me.pnlStuList.Size = New System.Drawing.Size(404, 47)
        Me.pnlStuList.TabIndex = 305
        Me.pnlStuList.Visible = False
        '
        'cboStuList_class
        '
        Me.cboStuList_class.DropDownHeight = 135
        Me.cboStuList_class.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboStuList_class.FormattingEnabled = True
        Me.cboStuList_class.IntegralHeight = False
        Me.cboStuList_class.Location = New System.Drawing.Point(267, 4)
        Me.cboStuList_class.Name = "cboStuList_class"
        Me.cboStuList_class.Size = New System.Drawing.Size(128, 38)
        Me.cboStuList_class.TabIndex = 303
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(218, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 34)
        Me.Label5.TabIndex = 304
        Me.Label5.Text = "ថ្នាក់"
        '
        'cboStuList_year
        '
        Me.cboStuList_year.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboStuList_year.FormattingEnabled = True
        Me.cboStuList_year.Location = New System.Drawing.Point(79, 4)
        Me.cboStuList_year.Name = "cboStuList_year"
        Me.cboStuList_year.Size = New System.Drawing.Size(128, 38)
        Me.cboStuList_year.TabIndex = 301
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 34)
        Me.Label4.TabIndex = 302
        Me.Label4.Text = "ឆ្នាំសិក្សា"
        '
        'pnlYearStudy
        '
        Me.pnlYearStudy.Controls.Add(Me.cboYearStudy)
        Me.pnlYearStudy.Controls.Add(Me.Label2)
        Me.pnlYearStudy.Location = New System.Drawing.Point(223, 2)
        Me.pnlYearStudy.Name = "pnlYearStudy"
        Me.pnlYearStudy.Size = New System.Drawing.Size(214, 47)
        Me.pnlYearStudy.TabIndex = 304
        '
        'cboYearStudy
        '
        Me.cboYearStudy.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cboYearStudy.FormattingEnabled = True
        Me.cboYearStudy.Location = New System.Drawing.Point(79, 4)
        Me.cboYearStudy.Name = "cboYearStudy"
        Me.cboYearStudy.Size = New System.Drawing.Size(128, 38)
        Me.cboYearStudy.TabIndex = 301
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 34)
        Me.Label2.TabIndex = 302
        Me.Label2.Text = "ឆ្នាំសិក្សា"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.icons8_view_48
        Me.PictureBox1.Location = New System.Drawing.Point(14, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 306
        Me.PictureBox1.TabStop = False
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.BackColor = System.Drawing.Color.Transparent
        Me.lblView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblView.Font = New System.Drawing.Font("Khmer OS", 12.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblView.ForeColor = System.Drawing.Color.Blue
        Me.lblView.Location = New System.Drawing.Point(59, 8)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(148, 34)
        Me.lblView.TabIndex = 303
        Me.lblView.Text = "មើលរបាយការណ៏"
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
        'V_STUDENT_LIST_ALL_STATUS_BindingSource
        '
        Me.V_STUDENT_LIST_ALL_STATUS_BindingSource.DataMember = "V_STUDENT_LIST_ALL_STATUS"
        Me.V_STUDENT_LIST_ALL_STATUS_BindingSource.DataSource = Me.DataSet1
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
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1370, 573)
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
        Me.PanelEx4.ResumeLayout(False)
        Me.PanelEx4.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        Me.pnlStuList.ResumeLayout(False)
        Me.pnlStuList.PerformLayout()
        Me.pnlYearStudy.ResumeLayout(False)
        Me.pnlYearStudy.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherMeetingAbsence_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_STUDENT_LIST_ALL_STATUS_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_TEACHER_LIST_ALL_STATUS_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label3 As Label
    Friend WithEvents lblView As Label
    Friend WithEvents pnlYearStudy As Panel
    Friend WithEvents pnlStuList As Panel
    Friend WithEvents cboStuList_class As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboStuList_year As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents V_STUDENT_LIST_ALL_STATUS_BindingSource As BindingSource
    Friend WithEvents V_TEACHER_LIST_ALL_STATUS_BindingSource As BindingSource
    Friend WithEvents V_STUDENT_TOTAL_YEAR_STUDY_CLASS_COMPLETE_bs As BindingSource
End Class

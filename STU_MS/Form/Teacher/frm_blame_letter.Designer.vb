<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_blame_letter
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
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_file_address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_letter_number = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_teacher = New System.Windows.Forms.ComboBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_letter_remark = New System.Windows.Forms.TextBox()
        Me.dt_letter_date_note = New System.Windows.Forms.DateTimePicker()
        Me.cbo_letter_type_ID = New System.Windows.Forms.ComboBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.dt_date_letter = New System.Windows.Forms.DateTimePicker()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txt_letter_content = New System.Windows.Forms.TextBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.datagrid)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.txt_file_address)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.txt_letter_number)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.cbo_teacher)
        Me.PanelEx1.Controls.Add(Me.Label94)
        Me.PanelEx1.Controls.Add(Me.Label56)
        Me.PanelEx1.Controls.Add(Me.txt_letter_remark)
        Me.PanelEx1.Controls.Add(Me.dt_letter_date_note)
        Me.PanelEx1.Controls.Add(Me.cbo_letter_type_ID)
        Me.PanelEx1.Controls.Add(Me.Label99)
        Me.PanelEx1.Controls.Add(Me.dt_date_letter)
        Me.PanelEx1.Controls.Add(Me.Label98)
        Me.PanelEx1.Controls.Add(Me.txt_letter_content)
        Me.PanelEx1.Controls.Add(Me.Label97)
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
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AllowUserToResizeColumns = False
        Me.datagrid.AllowUserToResizeRows = False
        Me.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.Location = New System.Drawing.Point(3, 365)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(1263, 303)
        Me.datagrid.TabIndex = 200
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(710, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 30)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(251, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 30)
        Me.Label8.TabIndex = 197
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(269, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 30)
        Me.Label7.TabIndex = 196
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(240, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 30)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(1039, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 30)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "ស្វែងរកឯកសារ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(634, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 30)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "ឯកសារ"
        '
        'txt_file_address
        '
        Me.txt_file_address.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_file_address.Location = New System.Drawing.Point(750, 231)
        Me.txt_file_address.Name = "txt_file_address"
        Me.txt_file_address.Size = New System.Drawing.Size(283, 38)
        Me.txt_file_address.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(162, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 30)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "លេខលិខិត"
        '
        'txt_letter_number
        '
        Me.txt_letter_number.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_letter_number.Location = New System.Drawing.Point(335, 190)
        Me.txt_letter_number.Name = "txt_letter_number"
        Me.txt_letter_number.Size = New System.Drawing.Size(283, 38)
        Me.txt_letter_number.TabIndex = 190
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(634, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 30)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "គ្រូបង្រៀន"
        '
        'cbo_teacher
        '
        Me.cbo_teacher.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cbo_teacher.FormattingEnabled = True
        Me.cbo_teacher.Location = New System.Drawing.Point(750, 190)
        Me.cbo_teacher.Name = "cbo_teacher"
        Me.cbo_teacher.Size = New System.Drawing.Size(283, 38)
        Me.cbo_teacher.TabIndex = 188
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.Red
        Me.Label94.Location = New System.Drawing.Point(256, 52)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(19, 30)
        Me.Label94.TabIndex = 187
        Me.Label94.Text = "*"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label56.Location = New System.Drawing.Point(634, 277)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(58, 30)
        Me.Label56.TabIndex = 183
        Me.Label56.Text = "ផ្សេងៗ"
        '
        'txt_letter_remark
        '
        Me.txt_letter_remark.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_letter_remark.Location = New System.Drawing.Point(750, 272)
        Me.txt_letter_remark.Name = "txt_letter_remark"
        Me.txt_letter_remark.Size = New System.Drawing.Size(283, 38)
        Me.txt_letter_remark.TabIndex = 182
        '
        'dt_letter_date_note
        '
        Me.dt_letter_date_note.CustomFormat = "yyyy-MM-dd"
        Me.dt_letter_date_note.Enabled = False
        Me.dt_letter_date_note.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dt_letter_date_note.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_letter_date_note.Location = New System.Drawing.Point(746, 277)
        Me.dt_letter_date_note.Name = "dt_letter_date_note"
        Me.dt_letter_date_note.Size = New System.Drawing.Size(283, 38)
        Me.dt_letter_date_note.TabIndex = 181
        Me.dt_letter_date_note.Value = New Date(2018, 3, 7, 0, 0, 0, 0)
        Me.dt_letter_date_note.Visible = False
        '
        'cbo_letter_type_ID
        '
        Me.cbo_letter_type_ID.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.cbo_letter_type_ID.FormattingEnabled = True
        Me.cbo_letter_type_ID.Location = New System.Drawing.Point(335, 272)
        Me.cbo_letter_type_ID.Name = "cbo_letter_type_ID"
        Me.cbo_letter_type_ID.Size = New System.Drawing.Size(283, 38)
        Me.cbo_letter_type_ID.TabIndex = 179
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label99.Location = New System.Drawing.Point(162, 279)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(97, 30)
        Me.Label99.TabIndex = 178
        Me.Label99.Text = "ប្រភេទលិខិត"
        '
        'dt_date_letter
        '
        Me.dt_date_letter.CustomFormat = "yyyy-MM-dd"
        Me.dt_date_letter.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.dt_date_letter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_date_letter.Location = New System.Drawing.Point(335, 231)
        Me.dt_date_letter.Name = "dt_date_letter"
        Me.dt_date_letter.Size = New System.Drawing.Size(283, 38)
        Me.dt_date_letter.TabIndex = 177
        Me.dt_date_letter.Value = New Date(1996, 10, 25, 0, 0, 0, 0)
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label98.Location = New System.Drawing.Point(162, 238)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(114, 30)
        Me.Label98.TabIndex = 176
        Me.Label98.Text = "ថ្ងៃខែទទួលបាន"
        '
        'txt_letter_content
        '
        Me.txt_letter_content.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.txt_letter_content.Location = New System.Drawing.Point(335, 55)
        Me.txt_letter_content.Multiline = True
        Me.txt_letter_content.Name = "txt_letter_content"
        Me.txt_letter_content.Size = New System.Drawing.Size(698, 129)
        Me.txt_letter_content.TabIndex = 175
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.Label97.Location = New System.Drawing.Point(162, 52)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(103, 30)
        Me.Label97.TabIndex = 174
        Me.Label97.Text = "ខ្លឹមសារលិខិត"
        '
        'btn_new
        '
        Me.btn_new.AutoSize = True
        Me.btn_new.BackColor = System.Drawing.Color.Transparent
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_new.Location = New System.Drawing.Point(536, 324)
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
        Me.btn_delete.Location = New System.Drawing.Point(721, 324)
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
        Me.btn_update.Location = New System.Drawing.Point(653, 324)
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
        Me.btn_save.Location = New System.Drawing.Point(569, 324)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 38)
        Me.btn_save.TabIndex = 106
        Me.btn_save.Text = "រក្សាទុក"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
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
        Me.Label1.Size = New System.Drawing.Size(203, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ការសរសើរ/ស្តីបន្ទោស"
        '
        'frm_blame_letter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 671)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_blame_letter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
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
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txt_letter_remark As System.Windows.Forms.TextBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents dt_date_letter As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents txt_letter_content As System.Windows.Forms.TextBox
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents dt_letter_date_note As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents cbo_teacher As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_letter_type_ID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_letter_number As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_file_address As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
End Class

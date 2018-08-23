<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_position
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ordinal_num = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Label()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label_exit = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.Label105)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.txt_no)
        Me.PanelEx1.Controls.Add(Me.datagrid)
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.txt_ordinal_num)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.btn_delete)
        Me.PanelEx1.Controls.Add(Me.btn_update)
        Me.PanelEx1.Controls.Add(Me.btn_save)
        Me.PanelEx1.Controls.Add(Me.txt_position)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS", 11.25!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(760, 509)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(263, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 30)
        Me.Label6.TabIndex = 256
        Me.Label6.Text = "*"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.BackColor = System.Drawing.Color.Transparent
        Me.Label105.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.ForeColor = System.Drawing.Color.Red
        Me.Label105.Location = New System.Drawing.Point(259, 102)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(19, 30)
        Me.Label105.TabIndex = 255
        Me.Label105.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 38)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "ល.រ"
        '
        'txt_no
        '
        Me.txt_no.Enabled = False
        Me.txt_no.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no.Location = New System.Drawing.Point(289, 56)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(459, 40)
        Me.txt_no.TabIndex = 252
        Me.txt_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.Location = New System.Drawing.Point(6, 240)
        Me.datagrid.MultiSelect = False
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.RowHeadersVisible = False
        Me.datagrid.RowTemplate.Height = 25
        Me.datagrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid.Size = New System.Drawing.Size(746, 265)
        Me.datagrid.TabIndex = 123
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.position
        Me.PictureBox1.Location = New System.Drawing.Point(14, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 38)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "លេខលំដាប់ "
        '
        'txt_ordinal_num
        '
        Me.txt_ordinal_num.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ordinal_num.Location = New System.Drawing.Point(289, 148)
        Me.txt_ordinal_num.Name = "txt_ordinal_num"
        Me.txt_ordinal_num.Size = New System.Drawing.Size(459, 40)
        Me.txt_ordinal_num.TabIndex = 121
        Me.txt_ordinal_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(271, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 38)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "ថ្មី"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 38)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "មុខដំណែង "
        '
        'btn_delete
        '
        Me.btn_delete.AutoSize = True
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_delete.Location = New System.Drawing.Point(455, 191)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(53, 38)
        Me.btn_delete.TabIndex = 118
        Me.btn_delete.Text = "លុប"
        '
        'btn_update
        '
        Me.btn_update.AutoSize = True
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_update.Location = New System.Drawing.Point(386, 191)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(66, 38)
        Me.btn_update.TabIndex = 117
        Me.btn_update.Text = "កែប្រែ"
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_save.Location = New System.Drawing.Point(308, 191)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 38)
        Me.btn_save.TabIndex = 116
        Me.btn_save.Text = "រក្សាទុក"
        '
        'txt_position
        '
        Me.txt_position.BackColor = System.Drawing.Color.White
        Me.txt_position.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_position.Location = New System.Drawing.Point(289, 102)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(459, 40)
        Me.txt_position.TabIndex = 115
        Me.txt_position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.PanelEx2.Size = New System.Drawing.Size(760, 39)
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
        Me.btn_close.Location = New System.Drawing.Point(717, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(35, 32)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 10
        Me.btn_close.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.STU_MS.My.Resources.Resources.information
        Me.PictureBox4.Location = New System.Drawing.Point(6, 4)
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
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(307, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "មុខតំណែង"
        '
        'frm_position
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 509)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_position"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ordinal_num As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Label
    Friend WithEvents txt_position As System.Windows.Forms.TextBox
    Friend WithEvents datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_no As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
End Class

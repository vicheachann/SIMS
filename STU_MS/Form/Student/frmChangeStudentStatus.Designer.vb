<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChangeStudentStatus
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
        Me.pnlHeader = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.cboStudentstatus = New System.Windows.Forms.ComboBox()
        Me.lblOk = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pic_student_info = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.pic_student_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlHeader.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlHeader.Controls.Add(Me.picClose)
        Me.pnlHeader.Controls.Add(Me.pic_student_info)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(373, 38)
        Me.pnlHeader.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlHeader.Style.BackColor1.Color = System.Drawing.Color.DodgerBlue
        Me.pnlHeader.Style.BackColor2.Color = System.Drawing.Color.RoyalBlue
        Me.pnlHeader.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlHeader.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlHeader.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlHeader.Style.GradientAngle = 90
        Me.pnlHeader.TabIndex = 1
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.PanelEx1.Controls.Add(Me.lblClose)
        Me.PanelEx1.Controls.Add(Me.cboStudentstatus)
        Me.PanelEx1.Controls.Add(Me.lblOk)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 38)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(373, 152)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 2
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline)
        Me.lblClose.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblClose.Location = New System.Drawing.Point(194, 93)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(84, 38)
        Me.lblClose.TabIndex = 182
        Me.lblClose.Text = "បោះបង់"
        '
        'cboStudentstatus
        '
        Me.cboStudentstatus.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.cboStudentstatus.FormattingEnabled = True
        Me.cboStudentstatus.Location = New System.Drawing.Point(167, 31)
        Me.cboStudentstatus.Name = "cboStudentstatus"
        Me.cboStudentstatus.Size = New System.Drawing.Size(147, 40)
        Me.cboStudentstatus.TabIndex = 181
        '
        'lblOk
        '
        Me.lblOk.AutoSize = True
        Me.lblOk.BackColor = System.Drawing.Color.Transparent
        Me.lblOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOk.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Underline)
        Me.lblOk.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblOk.Location = New System.Drawing.Point(92, 93)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(96, 38)
        Me.lblOk.TabIndex = 180
        Me.lblOk.Text = "យល់ព្រម"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ស្ថានភាពសិក្សា"
        '
        'pic_student_info
        '
        Me.pic_student_info.Image = Global.STU_MS.My.Resources.Resources.Notary_icon
        Me.pic_student_info.Location = New System.Drawing.Point(2, 3)
        Me.pic_student_info.Name = "pic_student_info"
        Me.pic_student_info.Size = New System.Drawing.Size(39, 35)
        Me.pic_student_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_student_info.TabIndex = 184
        Me.pic_student_info.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "ប្តូរជាអតីតសិស្ស"
        '
        'picClose
        '
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Image = Global.STU_MS.My.Resources.Resources.red_close_button_png_image_2878
        Me.picClose.Location = New System.Drawing.Point(346, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(22, 23)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 185
        Me.picClose.TabStop = False
        '
        'frmChangeStudentStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 190)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangeStudentStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChangeStudentStatus"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.pic_student_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblClose As Label
    Friend WithEvents cboStudentstatus As ComboBox
    Friend WithEvents lblOk As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pic_student_info As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picClose As PictureBox
End Class

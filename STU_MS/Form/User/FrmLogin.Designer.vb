<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.cboUserName = New System.Windows.Forms.ComboBox()
        Me.lblConnectionSetting = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnLogin = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlHeader = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.PanelEx1.Controls.Add(Me.cboUserName)
        Me.PanelEx1.Controls.Add(Me.lblConnectionSetting)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.txtPassword)
        Me.PanelEx1.Controls.Add(Me.btnExit)
        Me.PanelEx1.Controls.Add(Me.btnLogin)
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.pnlHeader)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(576, 272)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'cboUserName
        '
        Me.cboUserName.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.cboUserName.FormattingEnabled = True
        Me.cboUserName.Location = New System.Drawing.Point(269, 94)
        Me.cboUserName.Name = "cboUserName"
        Me.cboUserName.Size = New System.Drawing.Size(293, 40)
        Me.cboUserName.TabIndex = 181
        Me.cboUserName.Text = "admin"
        '
        'lblConnectionSetting
        '
        Me.lblConnectionSetting.AutoSize = True
        Me.lblConnectionSetting.BackColor = System.Drawing.Color.Transparent
        Me.lblConnectionSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblConnectionSetting.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectionSetting.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblConnectionSetting.Location = New System.Drawing.Point(10, 216)
        Me.lblConnectionSetting.Name = "lblConnectionSetting"
        Me.lblConnectionSetting.Size = New System.Drawing.Size(129, 32)
        Me.lblConnectionSetting.TabIndex = 180
        Me.lblConnectionSetting.Text = "កំណត់ការតភ្ជាប់"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 30)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "លេខសំងាត់"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ឈ្មោះអ្នកប្រើប្រាស់"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(269, 143)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(295, 40)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.Text = "123"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(370, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 33)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "ចាកចេញ"
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(268, 214)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 34)
        Me.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "យល់ព្រម"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.Apps_preferences_desktop_user_password_icon
        Me.PictureBox1.Location = New System.Drawing.Point(13, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlHeader.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.picExit)
        Me.pnlHeader.Controls.Add(Me.PictureBox2)
        Me.pnlHeader.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(576, 62)
        Me.pnlHeader.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlHeader.Style.BackColor1.Color = System.Drawing.Color.DodgerBlue
        Me.pnlHeader.Style.BackColor2.Color = System.Drawing.Color.RoyalBlue
        Me.pnlHeader.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlHeader.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlHeader.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlHeader.Style.GradientAngle = 90
        Me.pnlHeader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(122, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 38)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ប្រព័ន្ធគ្រប់គ្រងព័ត៌មានសាលារៀន"
        '
        'picExit
        '
        Me.picExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExit.Image = Global.STU_MS.My.Resources.Resources.red_close_button_png_image_2878
        Me.picExit.Location = New System.Drawing.Point(554, 3)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(19, 20)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExit.TabIndex = 12
        Me.picExit.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.STU_MS.My.Resources.Resources.BSS
        Me.PictureBox2.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 272)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnlHeader As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblConnectionSetting As System.Windows.Forms.Label
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
    Friend WithEvents cboUserName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As Label
End Class

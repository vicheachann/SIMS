﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarning
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
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label_exit = New System.Windows.Forms.LinkLabel()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX1.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(339, 151)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(139, 33)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 13
        Me.ButtonX1.Text = "យល់ព្រម"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.lblMessage)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(499, 196)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(107, 79)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(63, 32)
        Me.lblMessage.TabIndex = 14
        Me.lblMessage.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STU_MS.My.Resources.Resources.infor
        Me.PictureBox1.Location = New System.Drawing.Point(13, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.btn_close)
        Me.PanelEx2.Controls.Add(Me.PictureBox4)
        Me.PanelEx2.Controls.Add(Me.label_exit)
        Me.PanelEx2.Controls.Add(Me.lblTittle)
        Me.PanelEx2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(499, 33)
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
        Me.btn_close.Location = New System.Drawing.Point(463, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(31, 31)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 10
        Me.btn_close.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.STU_MS.My.Resources.Resources.BSS
        Me.PictureBox4.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 22)
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
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.BackColor = System.Drawing.Color.Transparent
        Me.lblTittle.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.ForeColor = System.Drawing.Color.White
        Me.lblTittle.Location = New System.Drawing.Point(43, 3)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(100, 30)
        Me.lblTittle.TabIndex = 8
        Me.lblTittle.Text = "message title"
        '
        'FrmWarning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 196)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWarning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btn_close As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents label_exit As System.Windows.Forms.LinkLabel
    Friend WithEvents lblTittle As System.Windows.Forms.Label
End Class

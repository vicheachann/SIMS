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
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlHeader.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlHeader.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(373, 21)
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
        Me.PanelEx1.Location = New System.Drawing.Point(0, 21)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(373, 169)
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
        Me.lblClose.Location = New System.Drawing.Point(250, 96)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(84, 38)
        Me.lblClose.TabIndex = 182
        Me.lblClose.Text = "បោះបង់"
        '
        'cboStudentstatus
        '
        Me.cboStudentstatus.Font = New System.Drawing.Font("Khmer OS", 12.0!)
        Me.cboStudentstatus.FormattingEnabled = True
        Me.cboStudentstatus.Location = New System.Drawing.Point(167, 35)
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
        Me.lblOk.Location = New System.Drawing.Point(159, 97)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(96, 38)
        Me.lblOk.TabIndex = 180
        Me.lblOk.Text = "យល់ព្រម"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ស្ថានភាពសិក្សា"
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
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblClose As Label
    Friend WithEvents cboStudentstatus As ComboBox
    Friend WithEvents lblOk As Label
    Friend WithEvents Label2 As Label
End Class

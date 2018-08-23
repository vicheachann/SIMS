Public Class Theme
    Public Sub SetColorExp(ByVal exp_panel As DevComponents.DotNetBar.ExpandablePanel)
        'SET MENU BACK COLOR
        exp_panel.Style.BackColor1.Color = EXP_MAIN_COLOR_1
        exp_panel.Style.BackColor2.Color = EXP_MAIN_COLOR_2
        'SET TITLE BACK COLOR
        exp_panel.TitleStyle.BackColor1.Color = EXP_TITLE_BACK_COLOR_1
        exp_panel.TitleStyle.BackColor2.Color = EXP_TITLE_BACK_COLOR_2
        'SET TITLE FORE COLOR
        exp_panel.TitleStyle.ForeColor.Color = EXP_TITLE_FORE_COLOR
    End Sub


    Public Sub SetLabelForeColor(ByVal ParamArray lbl() As Label)
        Dim i As Integer
        For i = 0 To UBound(lbl)
            lbl(i).ForeColor = LBL_MENU_FORE_COLOR
        Next i
    End Sub


    Public Sub Hover(ByVal lbl As Label)
        lbl.ForeColor = Color.Red
    End Sub
    Public Sub Leave(ByVal lbl As Label)
        lbl.ForeColor = Color.Blue
    End Sub
    Public Sub SetHeaderBackColor(ByVal pnl As DevComponents.DotNetBar.PanelEx)
        pnl.Style.BackColor1.Color = HEADER_COLOR_1
        pnl.Style.BackColor2.Color = HEADER_COLOR_2
    End Sub

    Public Sub SkyBlue()
   
        HEADER_COLOR_1 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(220, Byte), Integer))
        HEADER_COLOR_2 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(220, Byte), Integer))
        FrmMain.SetUpTheme()
    End Sub
    Public Sub DefaultTheme()
        HEADER_COLOR_1 = Color.DodgerBlue
        HEADER_COLOR_2 = Color.RoyalBlue
        EXP_TITLE_BACK_COLOR_1 = ColorTranslator.FromHtml("#1874CD")
        EXP_TITLE_BACK_COLOR_2 = ColorTranslator.FromHtml("#1874CD")
        EXP_MAIN_COLOR_1 = ColorTranslator.FromHtml("#1874CD")
        EXP_MAIN_COLOR_2 = ColorTranslator.FromHtml("#1874CD")
        EXP_TITLE_FORE_COLOR = Color.White
        LBL_MENU_FORE_COLOR = Color.White
        FrmMain.SetUpTheme()
    End Sub
    Public Sub DefaultTheme_1()
        HEADER_COLOR_1 = Color.DodgerBlue
        HEADER_COLOR_2 = Color.RoyalBlue

        'EXP_TITLE_BACK_COLOR_1 = Color.DodgerBlue
        'EXP_TITLE_BACK_COLOR_2 = Color.RoyalBlue
        'EXP_MAIN_COLOR_1 = ColorTranslator.FromHtml("#4ea1fc")
        'EXP_MAIN_COLOR_2 = ColorTranslator.FromHtml("#4ea1fc")
        EXP_TITLE_FORE_COLOR = Color.Black

        LBL_MENU_FORE_COLOR = Color.Blue
        FrmMain.SetUpTheme()
    End Sub

    Public Sub Green()
        HEADER_COLOR_1 = ColorTranslator.FromHtml("#008f95")
        HEADER_COLOR_2 = ColorTranslator.FromHtml("#02b5bc")
        'EXP_TITLE_BACK_COLOR_1 = ColorTranslator.FromHtml("#008f95")
        'EXP_TITLE_BACK_COLOR_2 = ColorTranslator.FromHtml("#008f95")
        'EXP_MAIN_COLOR_1 = ColorTranslator.FromHtml("#02b5bc")
        'EXP_MAIN_COLOR_2 = ColorTranslator.FromHtml("#02b5bc")
        'EXP_TITLE_FORE_COLOR = Color.White
        'LBL_MENU_FORE_COLOR = Color.White
        FrmMain.SetUpTheme()
    End Sub
    Public Sub LightGreen()
        HEADER_COLOR_1 = ColorTranslator.FromHtml("#11cbc0")
        HEADER_COLOR_2 = ColorTranslator.FromHtml("#0df2e4")
        'EXP_TITLE_BACK_COLOR_1 = ColorTranslator.FromHtml("#11cbc0")
        'EXP_TITLE_BACK_COLOR_2 = ColorTranslator.FromHtml("#0df2e4")
        'EXP_MAIN_COLOR_1 = ColorTranslator.FromHtml("#d9fdfb")
        'EXP_MAIN_COLOR_2 = ColorTranslator.FromHtml("#d9fdfb")
        'EXP_TITLE_FORE_COLOR = Color.Black
        'LBL_MENU_FORE_COLOR = Color.Black
        FrmMain.SetUpTheme()


    End Sub
    Public Sub DarkBlue()
        'EXP_MAIN_COLOR_1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(218, Byte), Integer))
        'EXP_MAIN_COLOR_2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(218, Byte), Integer))
        'EXP_TITLE_BACK_COLOR_1 = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(192, Byte), Integer))
        'EXP_TITLE_BACK_COLOR_2 = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(192, Byte), Integer))
        'EXP_TITLE_FORE_COLOR = Color.White
        'LBL_MENU_FORE_COLOR = Color.White
        HEADER_COLOR_1 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(192, Byte), Integer))
        HEADER_COLOR_2 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(192, Byte), Integer))
        FrmMain.SetUpTheme()
    End Sub
    Public Sub Blue()
        'EXP_MAIN_COLOR_1 = ColorTranslator.FromHtml("#088eff")
        'EXP_MAIN_COLOR_2 = ColorTranslator.FromHtml("#088eff")

        'EXP_TITLE_BACK_COLOR_1 = ColorTranslator.FromHtml("#088eff")
        'EXP_TITLE_BACK_COLOR_2 = ColorTranslator.FromHtml("#088eff")
        'EXP_TITLE_FORE_COLOR = Color.White
        'LBL_MENU_FORE_COLOR = Color.White

        HEADER_COLOR_1 = ColorTranslator.FromHtml("#269cfe")
        HEADER_COLOR_2 = ColorTranslator.FromHtml("#269cfe")
        FrmMain.SetUpTheme()
    End Sub
End Class

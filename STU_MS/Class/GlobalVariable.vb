Imports System.Data.SqlClient
Imports System.IO
Module GlobalVariable


    'Connection Component ADO.NET
    Public _ConnectionString As String
    Public _ServerName As String
    Public _ComputerName As String
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dt As DataTable
    Public dr As SqlDataReader




    Public EXP_MAIN_COLOR_1 As Color
    Public EXP_MAIN_COLOR_2 As Color
    Public EXP_TITLE_BACK_COLOR_1 As Color
    Public EXP_TITLE_BACK_COLOR_2 As Color
    Public EXP_TITLE_FORE_COLOR As Color
    Public LBL_MENU_FORE_COLOR As Color
    Public HEADER_COLOR_1 As Color
    Public HEADER_COLOR_2 As Color



    'Message
    Public _MessageTitile As String
    Public _ExceptionMessage As String
    Public USER_CLICK_OK As Boolean

    ' File Brower Dialog
    Public f, i As FileInfo
    Public file_Name As String
    Public photoFilePath As String
    Public bytBLOBData() As Byte
    Public stmBLOBData As New MemoryStream

    Public idx As Integer
    Public USER_ID As Integer
    Public USERNAME As String
    Public PHOTO() As Byte
    Public USER_STATUS As String
    Public studentID As Integer
    Public no As Integer
    Public USER_PASSWORD As String
    Public User_Password_Log As String



    'Sound File name
    Public _WarningSound As String = "warning.wav"
    Public _SuccessSound As String = "success.wav"
    Public _ShowMessageSound As String = "ShowMessage.wav"
    Public _ErrorSound As String = "Error.wav"
End Module

Imports System.Runtime.InteropServices

Module Movefrm
    <DllImport("user32.dll")> _
    Public Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HTCAPTION As Integer = 2
End Module
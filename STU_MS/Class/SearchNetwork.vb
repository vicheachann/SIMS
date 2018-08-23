Imports System.DirectoryServices
Imports System.Runtime.InteropServices

Namespace SearchNetwork
    Public Class DirectoryServicesNetworkItems
        Public Shared Function GetComputers(ByVal Network As String) As String()
            Dim compList As New List(Of String)
            Dim dEntry As DirectoryEntry = New DirectoryEntry("LDAP://" & Network)
            Dim dSearcher As DirectorySearcher = New DirectorySearcher(dEntry)
            dSearcher.Filter = ("(objectClass=computer)")

            Dim sResult As SearchResult
            For Each sResult In dSearcher.FindAll()
                compList.Add(sResult.GetDirectoryEntry().Name.ToString())
            Next

            Return compList.ToArray
        End Function
    End Class

    Public Class APINetworkItems
        Private Declare Function NetApiBufferFree Lib "netapi32" _
         (ByVal BufPtr As IntPtr) As Integer

        Private Declare Unicode Function NetServerEnum Lib "netapi32" _
        (ByVal Servername As IntPtr,
        ByVal Level As Integer,
        ByRef bufptr As IntPtr,
        ByVal PrefMaxLen As Integer,
        ByRef entriesread As Integer,
        ByRef TotalEntries As Integer,
        ByVal serverType As Integer,
        ByVal Domain As IntPtr,
        ByVal ResumeHandle As Integer) As Integer

        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
        Public Structure SERVER_INFO_101
            Dim dwPlatformID As Integer
            Dim lpszServerName As String
            Dim dwVersionMajor As Integer
            Dim dwVersionMinor As Integer
            Dim dwType As Integer
            Dim lpszComment As String
        End Structure

        Private Declare Function lstrlenW Lib "kernel32" (ByVal lpString As Integer) As Integer
        'Windows type used to call the Net API
        Private Const MAX_PREFERRED_LENGTH As Integer = -1
        Private Const NERR_SUCCESS As Integer = 0
        Private Const ERROR_MORE_DATA As Integer = 234
        Private Const SV_TYPE_WORKSTATION As Integer = &H1S
        Private Const SV_TYPE_SERVER As Integer = &H2S
        Private Const SV_TYPE_SQLSERVER As Integer = &H4S
        Private Const SV_TYPE_DOMAIN_CTRL As Integer = &H8S
        Private Const SV_TYPE_DOMAIN_BAKCTRL As Integer = &H10S
        Private Const SV_TYPE_TIME_SOURCE As Integer = &H20S
        Private Const SV_TYPE_AFP As Integer = &H40S
        Private Const SV_TYPE_NOVELL As Integer = &H80S
        Private Const SV_TYPE_DOMAIN_MEMBER As Integer = &H100S
        Private Const SV_TYPE_PRINTQ_SERVER As Integer = &H200S
        Private Const SV_TYPE_DIALIN_SERVER As Integer = &H400S
        Private Const SV_TYPE_XENIX_SERVER As Integer = &H800S
        Private Const SV_TYPE_SERVER_UNIX As Integer = SV_TYPE_XENIX_SERVER
        Private Const SV_TYPE_NT As Integer = &H1000S
        Private Const SV_TYPE_WFW As Integer = &H2000S
        Private Const SV_TYPE_SERVER_MFPN As Integer = &H4000S
        Private Const SV_TYPE_SERVER_NT As Integer = &H8000S
        Private Const SV_TYPE_POTENTIAL_BROWSER As Integer = &H10000
        Private Const SV_TYPE_BACKUP_BROWSER As Integer = &H20000
        Private Const SV_TYPE_MASTER_BROWSER As Integer = &H40000
        Private Const SV_TYPE_DOMAIN_MASTER As Integer = &H80000
        Private Const SV_TYPE_SERVER_OSF As Integer = &H100000
        Private Const SV_TYPE_SERVER_VMS As Integer = &H200000
        Private Const SV_TYPE_WINDOWS As Integer = &H400000  'Windows95 and above
        Private Const SV_TYPE_DFS As Integer = &H800000  'Root of a DFS tree
        Private Const SV_TYPE_CLUSTER_NT As Integer = &H1000000  'NT Cluster
        Private Const SV_TYPE_TERMINALSERVER As Integer = &H2000000  'TerminalServer
        Private Const SV_TYPE_DCE As Integer = &H10000000  'IBM DSS
        Private Const SV_TYPE_ALTERNATE_XPORT As Integer = &H20000000  'rtnalternate transport
        Private Const SV_TYPE_LOCAL_LIST_ONLY As Integer = &H40000000  'rtn localonly
        Private Const SV_TYPE_DOMAIN_ENUM As Integer = &H80000000
        Private Const SV_TYPE_ALL As Integer = &HFFFFFFFF
        Private Const SV_PLATFORM_ID_OS2 As Integer = 400
        Private Const SV_PLATFORM_ID_NT As Integer = 500
        'Mask applied to svX_version_major in
        'order to obtain the major version number.
        Private Const MAJOR_VERSION_MASK As Integer = &HFS

        <StructLayout(LayoutKind.Sequential)> Public Structure SERVER_INFO_100
            Dim sv100_platform_id As Integer
            Dim sv100_name As Integer
        End Structure

        Public Shared Function GetAllComputersInDomain() As String()
            Dim bufptr As IntPtr
            Dim dwEntriesread As Integer
            Dim dwTotalentries As Integer
            Dim dwResumehandle As Integer
            Dim se101 As SERVER_INFO_101 = New SERVER_INFO_101
            Dim success As Integer
            Dim nStructSize As Integer
            Dim cnt As Integer
            nStructSize = Marshal.SizeOf(se101)

            success = NetServerEnum(IntPtr.Zero, 101, bufptr, MAX_PREFERRED_LENGTH, dwEntriesread, dwTotalentries, SV_TYPE_NT, IntPtr.Zero, dwResumehandle)

            Dim resSC As New List(Of String)
            If success = NERR_SUCCESS And success <> ERROR_MORE_DATA Then
                'LOOP THROUGH AND ADD THE COMPUTER NAME TO THE LIST
                For cnt = 0 To dwEntriesread - 1
                    se101 = DirectCast(Marshal.PtrToStructure(New IntPtr(bufptr.ToInt32 + (nStructSize * cnt)), GetType(SERVER_INFO_101)), SERVER_INFO_101)
                    resSC.Add(se101.lpszServerName)
                Next
            End If
            'CLEAN UP
            Call NetApiBufferFree(bufptr)
            'RETURN THE COMPUTERS
            Return resSC.ToArray
        End Function

    End Class
End Namespace

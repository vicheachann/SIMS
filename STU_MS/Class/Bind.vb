Imports System.Data.SqlClient

Public Class Bind
    Private Shared obj As New Method
    Public Shared Sub Batch(ByVal cbo As ComboBox)
        obj.BindComboBox("SELECT BATCH_ID,BATCH FROM dbo.TBL_BATCH", cbo, "BATCH", "BATCH_ID")
    End Sub
    Public Shared Sub Health(ByVal cbo As ComboBox)
        obj.BindComboBox("SELECT HEALTHY_ID,HEALTHY_KH FROM dbo.TBL_HEALTHY", cbo, "HEALTHY_KH", "HEALTHY_ID")
    End Sub
    Public Shared Sub Livelyhood(ByVal cbo As ComboBox)
        obj.BindComboBox("SELECT LIVELIHOOD_ID,LIVELIHOOD_KH FROM dbo.TBL_LIVELIHOOD", cbo, "LIVELIHOOD_KH", "LIVELIHOOD_ID")
    End Sub
    Public Shared Sub YearStudy(ByVal cbo As ComboBox)
        obj.BindComboBox("SELECT YEAR_ID,YEAR_STUDY_KH FROM dbo.TBL_YEAR_STUDY order by YEAR_STUDY_KH DESC", cbo, "YEAR_STUDY_KH", "YEAR_ID")
    End Sub
    Public Shared Sub Classes(ByVal cbo As ComboBox)
        obj.BindComboBox("SELECT CLASS_ID,CLASS_LETTER FROM dbo.TBS_CLASS", cbo, "CLASS_LETTER", "CLASS_ID")
    End Sub
    Public Shared Sub StudentStatus(ByVal cbo As ComboBox)
        obj.BindComboBox("SELECT STUDENT_STATUS_ID,STUDENT_STATUS_KH FROM dbo.TBS_STUDENT_STATUS", cbo, "STUDENT_STATUS_KH", "STUDENT_STATUS_ID")
    End Sub

    Public Shared Sub Occupation(ByVal cbo As ComboBox)
        obj.BindComboBox("select OCCUPATION_ID,OCCUPATION_KH from dbo.TBL_OCCUPATION", cbo, "OCCUPATION_KH", "OCCUPATION_ID")
    End Sub
    Public Shared Sub Skill(ByVal cbo As ComboBox)
        obj.BindComboBox("SELECT SKILL_ID,SKILL_KH FROM dbo.TBL_SKILL", cbo, "SKILL_KH", "SKILL_ID")
    End Sub
    Public Shared Sub Langugue(ByVal cbo As ComboBox)
        obj.BindComboBox("select LANGUAGE_ID,LANGUAGE_KH from dbo.TBL_LANGUAGE", cbo, "LANGUAGE_KH", "LANGUAGE_ID")
    End Sub

    Public Shared Sub Province(ByVal cboProvince As ComboBox)
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT DISTINCT Province_Unicode FROM dbo.TblProvince_Khmer_Unicode ORDER BY Province_Unicode", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            cboProvince.DisplayMember = "Province_Unicode"
            cboProvince.DataSource = dt
            conn.Close()
        Catch ex As Exception
            EXCEPTION_MESSAGE = ex.Message
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub District(ByVal cboDistict As ComboBox, ByVal cboProvice As ComboBox)
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT DISTINCT District_Unicode FROM  TblProvince_Khmer_Unicode WHERE Province_Unicode = N'" & cboProvice.Text & "' ORDER BY District_Unicode ", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            cboDistict.DisplayMember = "District_Unicode"
            cboDistict.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub Commune(ByVal cboCommune As ComboBox, ByVal cboDistrict As ComboBox)
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT DISTINCT Commune_Unicode FROM TblProvince_Khmer_Unicode WHERE District_Unicode = N'" & cboDistrict.Text & "' ORDER BY Commune_Unicode ", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            cboCommune.DisplayMember = "Commune_Unicode"
            cboCommune.DataSource = dt
            conn.Close()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub Village(ByVal cboVillage As ComboBox, ByVal cboCommune As ComboBox, ByVal cboDistrict As ComboBox, ByVal cboProvince As ComboBox)
        Try
            Call obj.OpenConnection()
            cmd = New SqlCommand("SELECT DISTINCT Villague_Unicode FROM TblProvince_Khmer_Unicode WHERE Province_Unicode = N'" & cboProvince.Text & "' and District_Unicode = N'" & cboDistrict.Text & "' and Commune_Unicode = N'" & cboCommune.Text & "' ORDER BY Villague_Unicode", conn)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            cboVillage.DisplayMember = "Villague_Unicode"
            cboVillage.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Can't get data from server")
        End Try
    End Sub
End Class

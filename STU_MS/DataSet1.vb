Partial Class DataSet1
    Partial Public Class STU_STATISTICDataTable


    End Class

    Partial Public Class STU_RESULT_9_12DataTable
        Private Sub STU_RESULT_9_12DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.GRADE_12_NUM_GIRLColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class dtStudentDataTable
        Private Sub dtStudentDataTable_dtStudentRowChanging(sender As Object, e As dtStudentRowChangeEvent) Handles Me.dtStudentRowChanging

        End Sub

    End Class

    Partial Public Class dtTeacherMeetingAbsenceDataTable
        Private Sub dtTeacherMeetingAbsenceDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ROW_NUMBERColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub dtTeacherMeetingAbsenceDataTable_dtTeacherMeetingAbsenceRowChanging(sender As Object, e As dtTeacherMeetingAbsenceRowChangeEvent) Handles Me.dtTeacherMeetingAbsenceRowChanging

        End Sub

    End Class

    Partial Class V_TEACHER_LIST_ALL_STATUSDataTable
        Private Sub V_TEACHER_LIST_ALL_STATUSDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SALARY_LEVELColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Public Class Validation
    Shared obj As New Method

    'Validate on ComboBox with Missing Field name
    Public Shared Function IsEmpty(ByVal cbo As ComboBox, ByVal missingField As String) As Boolean
        Dim result As Boolean = False
        Try
            If (cbo.Text = "") Then
                cbo.BackColor = Color.LavenderBlush
                cbo.Focus()
                result = True
                obj.ShowMsg("សូមបញ្ចូល" + missingField + "ជាមុន", FrmWarning, WARNING_SOUND)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function

    'Validate on ComboBox without Missing Field name
    Public Shared Function IsEmpty(ByVal cbo As ComboBox) As Boolean
        Dim result As Boolean = False
        Try
            If (cbo.Text = "") Then
                cbo.BackColor = Color.LavenderBlush
                cbo.Focus()
                result = True
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, WARNING_SOUND)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function

    'Validate on TextBox with Missing Field name
    Public Shared Function IsEmpty(ByVal textBox As TextBox, ByVal missingField As String) As Boolean
        Dim result As Boolean = False
        Try
            If (textBox.Text = "") Then
                textBox.BackColor = Color.LavenderBlush
                textBox.Focus()
                result = True
                obj.ShowMsg("សូមបញ្ចូល" + missingField + "ជាមុន", FrmWarning, WARNING_SOUND)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function

    'Validate on TextBox without Missing Field name
    Public Shared Function IsEmpty(ByVal textBox As TextBox) As Boolean
        Dim result As Boolean = False
        Try
            If (textBox.Text = "") Then
                textBox.BackColor = Color.LavenderBlush
                textBox.Focus()
                result = True
                obj.ShowMsg("សូមបញ្ចូលព័ត៌មានចាំបាច់", FrmWarning, WARNING_SOUND)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function

    '---------------------------------------------------------------------------
    Public Shared Function IsEmptyControl(ByVal cbo As ComboBox, ByVal message As String) As Boolean
        Dim result As Boolean = False
        Try
            If (cbo.Text = "") Then
                cbo.BackColor = Color.LavenderBlush
                cbo.Focus()
                result = True
                obj.ShowMsg(message, FrmWarning, WARNING_SOUND)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function

End Class

Module tonp
    Public Function toNepali(ByVal integer_value As String) As String
        Dim add_data As New String(""), s_g As New String(""), retrive As New String("")
        For i = 1 To Len(integer_value)
            retrive = Mid(integer_value, i, 1)
            Select Case retrive
                Case "1"
                    s_g = "१"
                Case "2"
                    s_g = "२"
                Case "3"
                    s_g = "३"
                Case "4"
                    s_g = "४"
                Case "5"
                    s_g = "५"
                Case "6"
                    s_g = "६"
                Case "7"
                    s_g = "७"
                Case "8"
                    s_g = "८"
                Case "9"
                    s_g = "९"
                Case "0"
                    s_g = "०"
                Case "A"
                    s_g = "बिहानी"
                Case "P"
                    s_g = "बेलुकी"
                Case "M"
                    s_g = ""
                Case Else
                    s_g = retrive
            End Select
            add_data = add_data + s_g
        Next
        Return add_data
    End Function
End Module

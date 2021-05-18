Public Class DateConverter
    'By Kiran Pantha || www.kiranpantha.com.np || blog.kiranpantha.com.np || info@kiranpantha.com.np || 
    '                || info@mailkiranpantha.com.np
	'
    'This object prototype lets you convert Nepali Date (i.e. BS) to English Date (i.e. AD) and vice versa
    ' and perform Unix Timestamp conversions
	'
	'Limitation: Only work between the range 1994 AD - 2033 AD i.e. 2000 B.S. 2089
	'
	'||||| How It Works |||||
	'
	'Example #1
	'Dim DC as New DateConverter(New Date(1996, 1, 21))
	'MessageBox.Show("Date in BS : " & DC.ToBS())
	'MessageBox.Show("Unix Timestamp: " & DC.GetUnixTimeStamp())
	'
	'Example #2
	'Dim DC as New DateConverter()
	'MessageBox.Show("1996/1/21 in BS : " & DC.ToBS(New Date(1996,1,21))
	'MessageBox.Show("2052/10/7 in AD : " & DC.ToAD(New Date(2052,10,7))
	'MessageBox.Show("Date from Unix Timestamp: " & DC.GetUnixTimeStamp(114804000))
	
    Private _Date As Date

    Public Sub New()    'Class constructor
        Me._Date = Today.Date
    End Sub
    Public Sub New(ByVal givenDate As Date)    'Class construtor (overloaded)
        Me._Date = givenDate
    End Sub

    Private Function getData(ByVal A As Integer, ByVal B As Integer) As Integer
        Dim bs()() As Integer
        ReDim bs(90)

        'The following data allows the coversion between the range 1944-2033 (AD) only
        bs(0) = {2000, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(1) = {2001, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(2) = {2002, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(3) = {2003, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(4) = {2004, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(5) = {2005, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(6) = {2006, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(7) = {2007, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(8) = {2008, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}

        bs(9) = {2009, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(10) = {2010, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(11) = {2011, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(12) = {2012, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}

        bs(13) = {2013, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(14) = {2014, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(15) = {2015, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(16) = {2016, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}

        bs(17) = {2017, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(18) = {2018, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(19) = {2019, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(20) = {2020, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(21) = {2021, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(22) = {2022, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}

        bs(23) = {2023, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(24) = {2024, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(25) = {2025, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(26) = {2026, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(27) = {2027, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(28) = {2028, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(29) = {2029, 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30}

        bs(30) = {2030, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(31) = {2031, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(32) = {2032, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(33) = {2033, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(34) = {2034, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(35) = {2035, 30, 32, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}

        bs(36) = {2036, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(37) = {2037, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(38) = {2038, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(39) = {2039, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}

        bs(40) = {2040, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(41) = {2041, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(42) = {2042, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(43) = {2043, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}

        bs(44) = {2044, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(45) = {2045, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(46) = {2046, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(47) = {2047, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(48) = {2048, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(49) = {2049, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}

        bs(50) = {2050, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(51) = {2051, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(52) = {2052, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(53) = {2053, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}

        bs(54) = {2054, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(55) = {2055, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(56) = {2056, 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30}

        bs(57) = {2057, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(58) = {2058, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(59) = {2059, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(60) = {2060, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(61) = {2061, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(62) = {2062, 30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31}

        bs(63) = {2063, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(64) = {2064, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(65) = {2065, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(66) = {2066, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31}

        bs(67) = {2067, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(68) = {2068, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(69) = {2069, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(70) = {2070, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30}

        bs(71) = {2071, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(72) = {2072, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30}

        bs(73) = {2073, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31}

        bs(74) = {2074, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(75) = {2075, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(76) = {2076, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}

        bs(77) = {2077, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31}

        bs(78) = {2078, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(79) = {2079, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30}

        bs(80) = {2080, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30}

        bs(81) = {2081, 31, 31, 32, 32, 31, 30, 30, 30, 29, 30, 30, 30}

        bs(82) = {2082, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30}

        bs(83) = {2083, 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30}

        bs(84) = {2084, 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30}

        bs(85) = {2085, 31, 32, 31, 32, 30, 31, 30, 30, 29, 30, 30, 30}

        bs(86) = {2086, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30}

        bs(87) = {2087, 31, 31, 32, 31, 31, 31, 30, 30, 29, 30, 30, 30}

        bs(88) = {2088, 30, 31, 32, 32, 30, 31, 30, 30, 29, 30, 30, 30}

        bs(89) = {2089, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30}

        bs(90) = {2090, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30}

        Return (bs(A)(B))
        Return (bs(A)(B))
    End Function

    Public Function IsLeapYear(ByVal year As Integer) As Boolean    'Calculates whether a english year is leap year or not
        If (year Mod 100 = 0) Then
            If (year Mod 400 = 0) Then
                Return True
            Else
                Return False
            End If
        Else
            If (year Mod 4 = 0) Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function GetNepaliMonth(ByVal month As Integer) As String
        Select Case (month)

            Case 1
                Return "बैशाख"
            Case 2
                Return "जेष्ठ"
            Case 3
                Return "असार"
            Case 4
                Return "श्रावण"
            Case 5
                Return "भाद्र"
            Case 6
                Return "आश्विन"
            Case 7
                Return "कार्तिक"
            Case 8
                Return "मंसिर"
            Case 9
                Return "पुष"
            Case 10
                Return "माघ"
            Case 11
                Return "फागुन"
            Case 12
                Return "चैत्र"
            Case Else
                Return Nothing
        End Select

    End Function

    Public Function GetEnglishMonth(ByVal month As Integer) As String
        Select Case (month)

            Case 1
                Return "January"
            Case 2
                Return "February"
            Case 3
                Return "March"
            Case 4
                Return "April"
            Case 5
                Return "May"
            Case 6
                Return "June"
            Case 7
                Return "July"
            Case 8
                Return "August"
            Case 9
                Return "September"
            Case 10
                Return "October"
            Case 11
                Return "November"
            Case 12
                Return "December"
            Case Else
                Return Nothing
        End Select
    End Function
    Public Function GetDayOfWeek(ByVal day As Integer) As String

        Select Case (day)
            Case 0
                Return "आइतबार"
            Case 1
                Return "सोमबार"
            Case 2
                Return "मंगलबार"
            Case 3
                Return "बुधबार"
            Case 4
                Return "बिहिबार"
            Case 5
                Return "शुक्रबार"
            Case 6
                Return "शनिबार"
            Case Else
                Return Nothing
        End Select
    End Function
    Public Function GetDayOfWeek_en(ByVal day As Integer) As String

        Select Case (day)
            Case 0
                Return "Sunday"
            Case 1
                Return "Monday"
            Case 2
                Return "Tuesday"
            Case 3
                Return "Wednesday"
            Case 4
                Return "Thursday"
            Case 5
                Return "Friday"
            Case 6
                Return "Saturday"
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function ToAD() As Date
        Return (Me.ToAD(Me._Date))
    End Function

    Public Function ToAD(ByVal gDate As Date) As Date
        Dim def_eyy, def_emm, def_edd, def_nyy, def_nmm, def_ndd, total_eDays, total_nDays, a, day, m, y, i, j, k, numDay As Integer

        'Initialize english date
        def_eyy = 1943
        def_emm = 4
        def_edd = 13

        'Equivalent nepali date
        def_nyy = 2000
        def_nmm = 1
        def_ndd = 1

        'Initializations
        total_eDays = 0
        total_nDays = 0
        a = 0
        day = 3
        m = 0
        i = 0

        k = 0
        numDay = 0

        Dim yy As Integer = gDate.Year
        Dim mm As Integer = gDate.Month
        Dim dd As Integer = gDate.Day

        Dim month() As Integer, lmonth() As Integer
        ReDim month(13), lmonth(13)

        month = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        lmonth = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

        While (i < (yy - def_nyy))
            j = 1
            While (j <= 12)
                total_nDays += getData(k, j)
                j += 1
            End While

            i += 1
            k += 1
        End While

        j = 1
        While (j < mm)
            total_nDays += getData(k, j)
            j += 1
        End While
        total_nDays += dd

        total_eDays = def_edd
        m = def_emm
        y = def_eyy

        While (Not total_nDays = 0)

            If (IsLeapYear(y)) Then
                a = lmonth(m)
            Else
                a = month(m)
            End If

            total_eDays += 1
            day += 1

            If (total_eDays > a) Then
                m += 1
                total_eDays = 1

                If (m > 12) Then
                    y += 1
                    m = 1
                End If
            End If

            If (day > 7) Then day = 1
            total_nDays -= 1

        End While
        numDay = day

        Return DateSerial(y, m, total_eDays)
    End Function

    Public Function ToBS()
        Return (Me.ToBS(Me._Date))
    End Function

    Public Function ToBS(ByVal gDate As Date) As Date
        Dim month() As Integer, lmonth() As Integer
        ReDim month(13), lmonth(13)

        'Breaking given english date
        Dim yy, mm, dd As Integer
        yy = gDate.Year
        mm = gDate.Month
        dd = gDate.Day

        'English month data
        month = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        lmonth = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

        Dim def_eyy, def_nyy, def_nmm, def_ndd, total_eDays, total_nDays, a, day, m, y, i, j, numDay As Integer

        'Initialize english date
        def_eyy = 1944

        'Equivalent nepali date
        def_nyy = 2000
        def_nmm = 9
        def_ndd = 16

        'Initializations
        total_eDays = 0
        total_nDays = 0
        a = 0
        day = 6
        m = 0
        i = 0
        j = 0
        numDay = 0

        'Count total number of days in terms of year
        While (i < (yy - def_eyy))
            j = 0
            If (IsLeapYear(def_eyy + i)) Then
                While (j < 12)
                    total_eDays += lmonth(j)
                    j += 1
                End While
            Else
                While (j < 12)
                    total_eDays += month(j)
                    j += 1
                End While

            End If
            i += 1
        End While

        'Count total number of days in terms of month
        i = 0
        While (i < (mm - 1))
            If (Me.IsLeapYear(yy)) Then
                total_eDays += lmonth(i)
            Else
                total_eDays += month(i)
            End If
            i += 1
        End While

        'Count total number of days in terms of dates
        total_eDays += dd

        i = 0
        j = def_nmm
        total_nDays = def_ndd
        m = def_nmm
        y = def_nyy

        'Count nepali date from array
        While (Not total_eDays = 0)
            a = Me.getData(i, j)
            total_nDays += 1
            day += 1

            If (total_nDays > a) Then
                m += 1
                total_nDays = 1
                j += 1
            End If

            If (day > 7) Then day = 1
            If (m > 12) Then
                y += 1
                m = 1
            End If

            If (j > 12) Then
                j = 1
                i += 1
            End If
            total_eDays -= 1
        End While

        numDay = day
        If (dc_form.lbl.Text = "conv") Then
            dc_form.lbl.Text = ""
            dc_form.lbl.Text = numDay
        End If
        Return (DateSerial(y, m, total_nDays))
    End Function

    Public Function GetUnixTimestamp() As Double
        'create Timespan by subtracting the value provided from the Unix Epoch
        Dim span As TimeSpan = (_Date - New DateTime(1970, 1, 1, 0, 0, 0, 0).ToUniversalTime)
        'return the total seconds (which is a UNIX timestamp)
        Return span.TotalSeconds
    End Function

    Public Function GetUnixTimestamp(ByVal gDate As Date) As Double 'Overloads
        'create Timespan by subtracting the value provided from the Unix Epoch
        Dim span As TimeSpan = (gDate - New DateTime(1970, 1, 1, 0, 0, 0, 0).ToUniversalTime)
        'return the total seconds (which is a UNIX timestamp)
        Return span.TotalSeconds
    End Function

    Public Function FormatUnixTime(ByVal timestamp As Double) As DateTime
        Dim startUnixTime As New DateTime(1970, 1, 1, 0, 0, 0, 0)
        Return startUnixTime.AddSeconds(timestamp).ToUniversalTime
    End Function

End Class

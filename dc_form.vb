Public Class dc_form
    Dim kiran As Integer
    Private Sub dc_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl.Text = ""
        Me.BackgroundImage = main_form.BackgroundImage
        kiran = 1
        For i = 2000 To 2089
            yyyy.Items.Add(Mid(Str(i), 2, 4))
        Next
        mm.Items.AddRange({"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        dd.Items.AddRange({"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        For i = 13 To 31
            dd.Items.Add(Mid(Str(i), 2, 2))
        Next
    End Sub

    Private Sub dc_form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
       
    End Sub

    Private Sub xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xit.Click
        Me.Close()
    End Sub

   
    Private Sub GO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GO.Click
        Dim kiran_convert As New DateConverter, dayinnp, monthinnp, yearinnp, day_word As String, get_value As Date
        'On Error GoTo kiran
        If (yyyy.SelectedItem <> "" And mm.SelectedItem <> "" And dd.SelectedItem <> "") Then
            If kiran = 2 Then
                lbl.Text = "conv"
                get_value = kiran_convert.ToBS(DateAndTime.DateSerial(yyyy.SelectedItem, mm.SelectedItem, dd.SelectedItem))
                monthinnp = kiran_convert.GetNepaliMonth(get_value.Month)
                yearinnp = toNepali(get_value.Year)
                dayinnp = toNepali(get_value.Day)
                day_word = kiran_convert.GetDayOfWeek(lbl.Text - 1)
                result.Text = yearinnp + " साल " + monthinnp + "को " + dayinnp + " गते " + day_word

            Else
                lbl.Text = "conv"
                get_value = kiran_convert.ToAD(DateSerial(yyyy.SelectedItem, mm.SelectedItem, dd.SelectedItem))
                monthinnp = kiran_convert.GetEnglishMonth(get_value.Month)
                yearinnp = (get_value.Year)
                dayinnp = (get_value.Day)
                day_word = kiran_convert.GetDayOfWeek_en(get_value.DayOfWeek)
                'for 1st etc.
                result.Text = dayinnp + " " + monthinnp + " " + yearinnp + " " + day_word
            End If
            My.Computer.Clipboard.SetText(result.Text)
            conv.Text = "The converted date is copid to clipboard"
        End If
        GoTo kiranend
kiran:
        MsgBox("ERROR IN ENTERED VALUE", vbExclamation, "ERROR " & Err.Description)
kiranend:
    End Sub
    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Kiran_xx.Text = "" Then
                Kiran_xx.Text = e.X
            End If
            If kiran_yy.Text = "" Then
                kiran_yy.Text = e.Y
            End If
            If Asc(Kiran_xx.Text) < e.X Then
                Me.Left = Me.Left + 2
            Else
                Me.Left = Me.Left - 2
            End If
            If Asc(kiran_yy.Text) < e.Y Then
                Me.Top = Me.Top + 2
            Else
                Me.Top = Me.Top - 2
            End If
            Kiran_xx.Text = e.X
            kiran_yy.Text = e.Y
        End If
        If (Me.Left < 0) Then
            Me.Left = 0
        End If
        If (Me.Top < 0) Then
            Me.Top = 0
        End If
    End Sub

    Private Sub ad_bs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ad_bs.Click
        yyyy.Items.Clear()
        mm.Items.Clear()
        dd.Items.Clear()
        result.Text = ""
        conv.Text = ""
        lbl.Text = ""
        If kiran = 1 Then
            kiran = 2
            ad_bs.Image = My.Resources.ad
            my_convert.Text = "Convert AD to BS"
            lbl_hero.Text = "AD → BS"
            For i = 1994 To 2034
                yyyy.Items.Add(Mid(Str(i), 2, 4))
            Next
            mm.Items.AddRange({"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
            dd.Items.AddRange({"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
            For i = 13 To 31
                dd.Items.Add(Mid(Str(i), 2, 2))
            Next
        Else
            kiran = 1
            ad_bs.Image = My.Resources.BS
            my_convert.Text = "Convert BS to AD"
            lbl_hero.Text = "BS → AD"
            For i = 2000 To 2089
                yyyy.Items.Add(Mid(Str(i), 2, 4))
            Next
            mm.Items.AddRange({"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
            dd.Items.AddRange({"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
            For i = 13 To 31
                dd.Items.Add(Mid(Str(i), 2, 2))
            Next
        End If
    End Sub

    '    Private Sub yyyy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If yyyy.TextLength.ToString = "4" Then
    '            mm.Focus()
    '        Else
    '            yyyy.Focus()
    '        End If
    '    End Sub

    '    Private Sub mm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If mm.TextLength.ToString = "2" Then
    '            dd.Focus()
    '        Else
    '            mm.Focus()
    '        End If
    '    End Sub

    '    Private Sub dd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If dd.TextLength.ToString = "2" Then
    '            GO.Focus()
    '        Else
    '            dd.Focus()
    '        End If
    '    End Sub

    Private Sub yyyy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yyyy.SelectedIndexChanged
        mm.Focus()
    End Sub

    Private Sub dd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dd.SelectedIndexChanged
        dd.Focus()
    End Sub

    Private Sub mm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mm.SelectedIndexChanged
        GO.Focus()
    End Sub

    Private Sub xit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles xit.MouseHover
        xit.Image = My.Resources.bright_close
    End Sub

    Private Sub xit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles xit.MouseLeave
        xit.Image = My.Resources.close
    End Sub

    Private Sub xit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles xit.MouseMove
        xit.Image = My.Resources.bright_close
    End Sub

    Private Sub result_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles result.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

End Class
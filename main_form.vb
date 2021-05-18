Public Class main_form

    Private Sub main_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' menu_obj.Left = Me.Left
        ' menu_obj.Top = Me.Top - menu_obj.Width
        date_refresh()
        Me.Opacity = 0.9
        Me.Top = My.Computer.Screen.WorkingArea.Height - Me.Height
        Me.Left = My.Computer.Screen.WorkingArea.Width
        me_goto.Enabled = True
    End Sub
    Function date_refresh()
        Dim kiran As New DateConverter, dayinnp, monthinnp, yearinnp, day_word As String, get_value As Date
        get_value = kiran.ToBS(DateAndTime.Today)
        monthinnp = kiran.GetNepaliMonth(get_value.Month)
        yearinnp = toNepali(get_value.Year)
        dayinnp = toNepali(get_value.Day)
        day_word = kiran.GetDayOfWeek(DateAndTime.Today.DayOfWeek)
        dateinnp.Text = yearinnp + " साल " + monthinnp + "को " + dayinnp + " गते " + day_word
        Return 1
    End Function
    Function time_in_np()
        Dim middle As String
        middle = DateAndTime.TimeOfDay
        timeinnp.Text = toNepali(middle)
        Return ""
    End Function

    Private Sub main_form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        '  If e.Button = Windows.Forms.MouseButtons.Right Then
        'menu_obj.Left = Me.Left
        'menu_obj.Top = Me.Top - menu_obj.Height
        ' menu_obj.Show()
        ' End If
    End Sub

    Private Sub main_form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If kiran_X.Text = "" Then
                kiran_X.Text = e.X
            End If
            If kiran_Y.Text = "" Then
                kiran_Y.Text = e.Y
            End If
            If Asc(kiran_X.Text) < e.X Then
                Me.Left = Me.Left + 1
            Else
                Me.Left = Me.Left - 1
            End If
            If Asc(kiran_Y.Text) < e.Y Then
                Me.Top = Me.Top + 1
            Else
                Me.Top = Me.Top - 1
            End If
            kiran_X.Text = e.X
            kiran_Y.Text = e.Y
        End If
        If Me.Left > (My.Computer.Screen.WorkingArea.Width - Me.Width) Then
            me_goto.Enabled = True
        End If
        If (Me.Left < 0) Then
            Me.Left = 0
        End If
        me_height.Enabled = True
    End Sub

    Private Sub me_height_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles me_height.Tick
        If Me.Top < 0 Then
            Me.Top = 0
        End If
        If Me.Top > My.Computer.Screen.WorkingArea.Height - Me.Height Then
            Me.Top = My.Computer.Screen.WorkingArea.Height - Me.Height
        End If
        me_height.Enabled = False
    End Sub

    Private Sub me_goto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles me_goto.Tick
        While ((Me.Left - (My.Computer.Screen.WorkingArea.Width - Me.Width)) > 0)
            Me.Left = Me.Left - 1
        End While
        'Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width
        me_goto.Enabled = False
    End Sub

    Private Sub time_go_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time_go.Tick
        time_in_np()
    End Sub

    Private Sub date_go_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles date_go.Tick
        date_refresh()
    End Sub

    Private Sub timeinnp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' If e.Button = Windows.Forms.MouseButtons.Right Then
        'menu_obj.Left = Me.Left
        ' menu_obj.Top = Me.Top - menu_obj.Height
        ' menu_obj.Show()
        ' End If
    End Sub

   

    Private Sub timeinnp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        main_form_MouseMove(sender, e)
    End Sub

    Private Sub dateinnp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dateinnp.MouseDown
        '  If e.Button = Windows.Forms.MouseButtons.Right Then
        'menu_obj.Left = Me.Left
        ' menu_obj.Top = Me.Top - menu_obj.Height
        ' menu_obj.Show()
        ' End If
    End Sub

    Private Sub dateinnp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dateinnp.MouseMove
        main_form_MouseMove(sender, e)
    End Sub

    Private Sub moveme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moveme.Click
        kiransoft_me.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        kiransoft_me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        kiransoft_me.Close()
        opacity_form.Close()
        dc_form.Close()
    End Sub

    Private Sub Ncell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ncell.Click
        Ncell.Checked = True
        SkyBlue.Checked = False
        Green.Checked = False
        Blue.Checked = False
        Red.Checked = False
        Me.BackgroundImage = My.Resources.ncell
    End Sub

    Private Sub SkyBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkyBlue.Click
        Ncell.Checked = False
        SkyBlue.Checked = True
        Green.Checked = False
        Blue.Checked = False
        Red.Checked = False
        Me.BackgroundImage = My.Resources.sky
    End Sub

    Private Sub Green_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Green.Click
        Ncell.Checked = False
        SkyBlue.Checked = False
        Green.Checked = True
        Blue.Checked = False
        Red.Checked = False
        Me.BackgroundImage = My.Resources.green
    End Sub

    Private Sub Blue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue.Click
        Ncell.Checked = False
        SkyBlue.Checked = False
        Green.Checked = False
        Blue.Checked = True
        Red.Checked = False
        Me.BackgroundImage = My.Resources.blue
    End Sub

    Private Sub Red_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Red.Click
        Ncell.Checked = False
        SkyBlue.Checked = False
        Green.Checked = False
        Blue.Checked = False
        Red.Checked = True
        Me.BackgroundImage = My.Resources.red
    End Sub

   
    Private Sub trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trans.Click
        opacity_form.Show()
    End Sub


    Private Sub dateinnp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateinnp.Click

    End Sub

    Private Sub converter_menu_item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles converter_menu_item.Click
        dc_form.Show()
    End Sub

    Private Sub date_and_time_menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles date_and_time_menu.Opening

    End Sub

    Private Sub timeinnp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
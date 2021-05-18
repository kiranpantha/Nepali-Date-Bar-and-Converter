Public Class Kiran_Pantha
    Private Sub kiranpantha_time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kiranpantha_time.Tick
        main_form.Show()
        Me.Close()
    End Sub

    Private Sub Kiran_Pantha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mywebsite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles mywebsite.LinkClicked
        On Error GoTo endd
        Shell("C:/Program files/Internet Explorer/IEXPLORE.exe " & mywebsite.Text)
        GoTo enddd
endd:
enddd:
    End Sub

    Private Sub fb_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles fb_lnk.LinkClicked
        On Error GoTo endd
        Shell("C:/Program files/Internet Explorer/IEXPLORE.exe " & fb_lnk.Text)
        GoTo enddd
endd:
enddd:
    End Sub
End Class
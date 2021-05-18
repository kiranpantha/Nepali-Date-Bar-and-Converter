Public NotInheritable Class kiransoft_me

  

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        desc.Text = My.Application.Info.Description
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = ApplicationTitle + " by Kiran Pantha"
    End Sub
    Private Sub fb_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fb_img.Click
        On Error GoTo endd
        Shell("explorer.exe " & mywebsite.Text)
        GoTo enddd
endd:
enddd:
    End Sub

    Private Sub fb_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles fb_lnk.LinkClicked
        On Error GoTo endd
        Shell("explorer.exe " & fb_lnk.Text)
        GoTo enddd
endd:
enddd:
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles mywebsite.LinkClicked
        On Error GoTo endd
        Shell("explorer.exe " & mywebsite.Text)
        GoTo enddd
endd:
enddd:
    End Sub

    Private Sub endme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endme.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class

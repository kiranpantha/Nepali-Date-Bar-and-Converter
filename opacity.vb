Public Class opacity_form

    Private Sub opaci_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opaci.Scroll
        main_form.Opacity = opaci.Value / 100
    End Sub

    Private Sub opacity_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opaci.Value = main_form.Opacity * 99
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
Public Class ControlsForm

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text &=
"XXXXXXXXXXXXXXXXXXXXXXXX" & vbNewLine &
"XXXXXXXXXXXXXXXXXXXXXXXX" & vbNewLine &
"XXXXXXXXXXXXXXXXXXXXXXXX" & vbNewLine &
"XXXXXXXXXXXXXXXXXXXXXXXX" & vbNewLine &
"XXXXXXXXXXXXXXXXXXXXXXXX"

    End Sub

    Private Sub ControlsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = My.Resources.cute_baby_kittens_15
    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles HelpTopMenuItem.Click

    End Sub

    Private Sub AboutTopMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click

    End Sub
End Class

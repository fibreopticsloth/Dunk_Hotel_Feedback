Public Class frm_splash
    Private Sub pic_logo_Click(sender As Object, e As EventArgs) Handles pic_logo.Click
        'Allows the images to have transparent backgrounds.
        pic_logo.Parent = Me
        pic_logo.BackColor = Color.Transparent
    End Sub
    Private Sub frm_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enable and start the timer.
        timer_splash.Enabled = True
        timer_splash.Start()
    End Sub

    Private Sub timer_splash_Tick(sender As Object, e As EventArgs) Handles timer_splash.Tick
        'After 3 seconds, hide the splash screen and show the feedback form.
        Me.Hide()
        frm_feedback.Show()
        timer_splash.Start()
        timer_splash.Enabled = False
    End Sub
End Class
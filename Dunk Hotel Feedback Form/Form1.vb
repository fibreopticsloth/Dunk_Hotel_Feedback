Public Class frm_feedback
    'Creates a variable to hold whether or not the program is currently in use.
    Dim in_use As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_DataDataSet.tbl_Feedback' dataset from the Feedback Table in the Hotel Database.
        Me.Tbl_FeedbackTableAdapter.Fill(Me.Hotel_DataDataSet.tbl_Feedback)
        'These lines allow the images to have transparent backgrounds.
        pic_logo.Parent = pic_leftbackground
        pic_logo.BackColor = Color.Transparent
        lbl_thanks.Parent = Me
        lbl_thanks.BackColor = Color.Transparent
        lbl_name.Parent = Me
        lbl_name.BackColor = Color.Transparent
        lbl_rating.Parent = Me
        lbl_rating.BackColor = Color.Transparent
        lbl_feedback.Parent = Me
        lbl_feedback.BackColor = Color.Transparent
        lbl_timer.Parent = Me
        lbl_timer.BackColor = Color.Transparent
        pic_arrow.Parent = Me
        pic_arrow.BackColor = Color.Transparent
    End Sub
    Public Sub reset_form()
        'Clear the text boxes and focus the first field.
        txt_name.Clear()
        txt_rating.SelectedIndex = -1
        txt_feedback.Clear()
        txt_name.Select()
    End Sub
    Private Sub pic_arrow_Click(sender As Object, e As EventArgs) Handles pic_arrow.Click
        'Checks that all fields have been filled.
        If txt_name.Text = "" Or txt_rating.Text = "" Or txt_feedback.Text = "" Then
            'If not, return an error telling the user to fill all fields.
            MessageBox.Show("You must fill in all fields", "Error")
            'If all fields are filled in...
        Else
            'Run the insert query on the feedback table adapter, inserting the contents of the form into the feedback database.
            Me.Tbl_FeedbackTableAdapter.InsertQuery(txt_name.Text, txt_rating.Text, txt_feedback.Text)
            'Show a message box confirming that the data has been submitted successfully.
            MessageBox.Show("Thank You For Your Feedback!", "Success")
            'Runs the reset_form subroutine.
            reset_form()
            'Declares that the form is no longer in use.
            in_use = False
            'Resets the timeout timer.
            timeout_reset()
        End If
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Show the login form.
        frm_login.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the application.
        Application.Exit()
    End Sub
    'Declare a variable holding the number of ticks the timeout timer has reached.
    Dim tick_no As Integer = 0
    'Reset the timeout timer.
    Public Sub timeout_reset()
        'Check to see if the form is in use.
        If in_use = True Then
            'If so, reset the timer.
            timer_timeout.Enabled = False
            timer_timeout.Enabled = True
            'Set the number of ticks back to 60.
            tick_no = 0
            'Hide the timeout alert.
            lbl_timer.Visible = False
            lbl_timer.Text = "Timeout in 60 seconds"
        Else
            'If the form is not in use, hide the alert.
            lbl_timer.Visible = False
            'Disable the timeout timer.
            timer_timeout.Enabled = False
            'Reset the alert text.
            lbl_timer.Text = "Timeout in 60 seconds"
        End If
    End Sub
    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged
        'If the user starts filling in the form, set in_use to true.
        in_use = True
        'Reset the timeout timer if the user resumes using the form.
        timeout_reset()
    End Sub
    Private Sub txt_rating_TextChanged(sender As Object, e As EventArgs) Handles txt_rating.TextChanged
        'If the user starts filling in the form, set in_use to true.
        in_use = True
        'Reset the timeout timer if the user resumes using the form.
        timeout_reset()
    End Sub
    Private Sub txt_feedback_TextChanged(sender As Object, e As EventArgs) Handles txt_feedback.TextChanged
        'If the user starts filling in the form, set in_use to true.
        in_use = True
        'Reset the timeout timer if the user resumes using the form.
        timeout_reset()
    End Sub
    Private Sub timer_timeout_Tick(sender As Object, e As EventArgs) Handles timer_timeout.Tick
        'After each tick of the timeout timer (everys 1s), add 1 to the tick_no variable.
        tick_no += 1
        'Update the alert text to tell the user how much time is left in their session.
        lbl_timer.Text = "Timeout in " + (60 - tick_no).ToString + " seconds"
        'Ensure that the alert only shows if the user has less than 30 seconds until timeout.
        If tick_no > 29 Then
            lbl_timer.Visible = True
        End If
        'If it has been 60 seconds without the form being used...
        If tick_no = 60 Then
            'Reset the form.
            reset_form()
            'Declare that the form is not in use.
            in_use = False
            'Reset the timeout timer.
            timeout_reset()
        End If
    End Sub
End Class

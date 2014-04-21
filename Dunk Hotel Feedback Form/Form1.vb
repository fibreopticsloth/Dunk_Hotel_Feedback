Public Class frm_feedback
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
        pic_arrow.Parent = Me
        pic_arrow.BackColor = Color.Transparent
    End Sub
    Private Sub pic_arrow_Click(sender As Object, e As EventArgs) Handles pic_arrow.Click
        'Run the insert query on the feedback table adapter, inserting the contents of the form into the feedback database.
        Me.Tbl_FeedbackTableAdapter.InsertQuery(txt_name.Text, txt_rating.Text, txt_feedback.Text)
        'Show a message box confirming that the data has been submitted successfully.
        MessageBox.Show("Thank You For Your Feedback!", "Success")
        'Clear the text boxes and focus the first field.
        txt_name.Clear()
        txt_rating.Text = ""
        txt_feedback.Clear()
        txt_name.Select()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Show the login form.
        frm_login.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the application.
        Application.Exit()
    End Sub
End Class

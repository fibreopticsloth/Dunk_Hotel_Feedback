Public Class frm_adminpanel
    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_DataDataSet.tbl_Feedback' table.
        Me.Tbl_FeedbackTableAdapter.Fill(Me.Hotel_DataDataSet.tbl_Feedback)
    End Sub
    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        'Resets the admin panel by filling the dataset with the contents of the table.
        Me.Tbl_FeedbackTableAdapter.Fill(Me.Hotel_DataDataSet.tbl_Feedback)
        'Clear the search box.
        txt_searchterm.Clear()
        txt_searchterm.Select()
    End Sub
    Private Sub txt_searchterm_TextChanged(sender As Object, e As EventArgs) Handles txt_searchterm.TextChanged
        'Run the 'FillBySearchTerm' query on the data adapter, which searches the dataset for the contents of the search box.
        Me.Tbl_FeedbackTableAdapter.FillBySearchTerm(Me.Hotel_DataDataSet.tbl_Feedback, txt_searchterm.Text, txt_searchterm.Text)
    End Sub
End Class
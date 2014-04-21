<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_feedback
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_feedback))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.pic_leftbackground = New System.Windows.Forms.PictureBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_feedback = New System.Windows.Forms.TextBox()
        Me.lbl_thanks = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.lbl_feedback = New System.Windows.Forms.Label()
        Me.pic_arrow = New System.Windows.Forms.PictureBox()
        Me.txt_rating = New System.Windows.Forms.ComboBox()
        Me.Hotel_DataDataSet = New Dunk_Hotel_Feedback_Form.Hotel_DataDataSet()
        Me.Tbl_FeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_FeedbackTableAdapter = New Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.tbl_FeedbackTableAdapter()
        Me.TableAdapterManager = New Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_leftbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotel_DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_FeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 570)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pic_logo
        '
        Me.pic_logo.Image = Global.Dunk_Hotel_Feedback_Form.My.Resources.Resources.logo
        Me.pic_logo.Location = New System.Drawing.Point(35, 177)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(180, 158)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 3
        Me.pic_logo.TabStop = False
        '
        'pic_leftbackground
        '
        Me.pic_leftbackground.BackgroundImage = Global.Dunk_Hotel_Feedback_Form.My.Resources.Resources.honey_im_subtle
        Me.pic_leftbackground.Location = New System.Drawing.Point(0, 24)
        Me.pic_leftbackground.Name = "pic_leftbackground"
        Me.pic_leftbackground.Size = New System.Drawing.Size(258, 556)
        Me.pic_leftbackground.TabIndex = 0
        Me.pic_leftbackground.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(427, 167)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(191, 26)
        Me.txt_name.TabIndex = 0
        '
        'txt_feedback
        '
        Me.txt_feedback.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_feedback.Location = New System.Drawing.Point(427, 258)
        Me.txt_feedback.Multiline = True
        Me.txt_feedback.Name = "txt_feedback"
        Me.txt_feedback.Size = New System.Drawing.Size(482, 177)
        Me.txt_feedback.TabIndex = 2
        '
        'lbl_thanks
        '
        Me.lbl_thanks.AutoSize = True
        Me.lbl_thanks.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_thanks.ForeColor = System.Drawing.Color.White
        Me.lbl_thanks.Location = New System.Drawing.Point(377, 74)
        Me.lbl_thanks.Name = "lbl_thanks"
        Me.lbl_thanks.Size = New System.Drawing.Size(487, 44)
        Me.lbl_thanks.TabIndex = 7
        Me.lbl_thanks.Text = "Thank You for staying at Dunk Hotel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please feel free to leave any feedback you m" & _
    "ay have"
        Me.lbl_thanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(364, 170)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 18)
        Me.lbl_name.TabIndex = 8
        Me.lbl_name.Text = "Name:"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rating.ForeColor = System.Drawing.Color.White
        Me.lbl_rating.Location = New System.Drawing.Point(359, 215)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(62, 18)
        Me.lbl_rating.TabIndex = 9
        Me.lbl_rating.Text = "Rating:"
        Me.lbl_rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_feedback
        '
        Me.lbl_feedback.AutoSize = True
        Me.lbl_feedback.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_feedback.ForeColor = System.Drawing.Color.White
        Me.lbl_feedback.Location = New System.Drawing.Point(333, 261)
        Me.lbl_feedback.Name = "lbl_feedback"
        Me.lbl_feedback.Size = New System.Drawing.Size(88, 18)
        Me.lbl_feedback.TabIndex = 10
        Me.lbl_feedback.Text = "Feedback:"
        Me.lbl_feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_arrow
        '
        Me.pic_arrow.Image = Global.Dunk_Hotel_Feedback_Form.My.Resources.Resources.arrow
        Me.pic_arrow.Location = New System.Drawing.Point(837, 458)
        Me.pic_arrow.Name = "pic_arrow"
        Me.pic_arrow.Size = New System.Drawing.Size(72, 62)
        Me.pic_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_arrow.TabIndex = 11
        Me.pic_arrow.TabStop = False
        '
        'txt_rating
        '
        Me.txt_rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_rating.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rating.FormattingEnabled = True
        Me.txt_rating.Items.AddRange(New Object() {"Excellent", "Very Good", "Good", "Satisfactory", "Poor", "Very Poor", "Unnacceptable"})
        Me.txt_rating.Location = New System.Drawing.Point(427, 212)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(191, 26)
        Me.txt_rating.TabIndex = 1
        '
        'Hotel_DataDataSet
        '
        Me.Hotel_DataDataSet.DataSetName = "Hotel_DataDataSet"
        Me.Hotel_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_FeedbackBindingSource
        '
        Me.Tbl_FeedbackBindingSource.DataMember = "tbl_Feedback"
        Me.Tbl_FeedbackBindingSource.DataSource = Me.Hotel_DataDataSet
        '
        'Tbl_FeedbackTableAdapter
        '
        Me.Tbl_FeedbackTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_FeedbackTableAdapter = Me.Tbl_FeedbackTableAdapter
        Me.TableAdapterManager.UpdateOrder = Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frm_feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dunk_Hotel_Feedback_Form.My.Resources.Resources.dvsup
        Me.ClientSize = New System.Drawing.Size(984, 592)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.pic_arrow)
        Me.Controls.Add(Me.lbl_feedback)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_thanks)
        Me.Controls.Add(Me.txt_feedback)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pic_leftbackground)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 630)
        Me.MinimumSize = New System.Drawing.Size(1000, 630)
        Me.Name = "frm_feedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dunk Hotel Feedback"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_leftbackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotel_DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_FeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_leftbackground As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_feedback As System.Windows.Forms.TextBox
    Friend WithEvents lbl_thanks As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_rating As System.Windows.Forms.Label
    Friend WithEvents lbl_feedback As System.Windows.Forms.Label
    Friend WithEvents pic_arrow As System.Windows.Forms.PictureBox
    Friend WithEvents Hotel_DataDataSet As Dunk_Hotel_Feedback_Form.Hotel_DataDataSet
    Friend WithEvents Tbl_FeedbackBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_FeedbackTableAdapter As Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.tbl_FeedbackTableAdapter
    Friend WithEvents TableAdapterManager As Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txt_rating As System.Windows.Forms.ComboBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

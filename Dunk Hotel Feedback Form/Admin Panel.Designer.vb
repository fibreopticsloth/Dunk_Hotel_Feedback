<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adminpanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adminpanel))
        Me.Hotel_DataDataSet = New Dunk_Hotel_Feedback_Form.Hotel_DataDataSet()
        Me.Tbl_FeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_FeedbackTableAdapter = New Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.tbl_FeedbackTableAdapter()
        Me.TableAdapterManager = New Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_FeedbackDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_searchterm = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        CType(Me.Hotel_DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_FeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_FeedbackDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Tbl_FeedbackDataGridView
        '
        Me.Tbl_FeedbackDataGridView.AutoGenerateColumns = False
        Me.Tbl_FeedbackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_FeedbackDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Tbl_FeedbackDataGridView.DataSource = Me.Tbl_FeedbackBindingSource
        Me.Tbl_FeedbackDataGridView.Location = New System.Drawing.Point(-1, 43)
        Me.Tbl_FeedbackDataGridView.Name = "Tbl_FeedbackDataGridView"
        Me.Tbl_FeedbackDataGridView.Size = New System.Drawing.Size(643, 319)
        Me.Tbl_FeedbackDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Rating"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Rating"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Feedback"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Feedback"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'txt_searchterm
        '
        Me.txt_searchterm.Location = New System.Drawing.Point(199, 12)
        Me.txt_searchterm.Name = "txt_searchterm"
        Me.txt_searchterm.Size = New System.Drawing.Size(148, 20)
        Me.txt_searchterm.TabIndex = 10
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(353, 10)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 11
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(554, 9)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'frm_adminpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 361)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txt_searchterm)
        Me.Controls.Add(Me.Tbl_FeedbackDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_adminpanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Panel"
        CType(Me.Hotel_DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_FeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_FeedbackDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hotel_DataDataSet As Dunk_Hotel_Feedback_Form.Hotel_DataDataSet
    Friend WithEvents Tbl_FeedbackBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_FeedbackTableAdapter As Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.tbl_FeedbackTableAdapter
    Friend WithEvents TableAdapterManager As Dunk_Hotel_Feedback_Form.Hotel_DataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_FeedbackDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_searchterm As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_reset As System.Windows.Forms.Button
End Class

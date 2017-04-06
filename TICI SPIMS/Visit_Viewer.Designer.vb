<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visit_Viewer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Rtt_data2 = New System.Windows.Forms.RichTextBox()
        Me.Rtt_data3 = New System.Windows.Forms.RichTextBox()
        Me.Rtt_data1 = New System.Windows.Forms.RichTextBox()
        Me.DG_transactions = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_addchrg = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditPatientInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintThisRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.asd = New System.Windows.Forms.GroupBox()
        Me.ptdgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DG_transactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.asd.SuspendLayout()
        CType(Me.ptdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rtt_data2
        '
        Me.Rtt_data2.Enabled = False
        Me.Rtt_data2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtt_data2.Location = New System.Drawing.Point(743, 95)
        Me.Rtt_data2.Name = "Rtt_data2"
        Me.Rtt_data2.Size = New System.Drawing.Size(249, 91)
        Me.Rtt_data2.TabIndex = 1
        Me.Rtt_data2.Text = ""
        '
        'Rtt_data3
        '
        Me.Rtt_data3.Enabled = False
        Me.Rtt_data3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtt_data3.Location = New System.Drawing.Point(478, 231)
        Me.Rtt_data3.Name = "Rtt_data3"
        Me.Rtt_data3.Size = New System.Drawing.Size(249, 115)
        Me.Rtt_data3.TabIndex = 2
        Me.Rtt_data3.Text = ""
        '
        'Rtt_data1
        '
        Me.Rtt_data1.Enabled = False
        Me.Rtt_data1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtt_data1.Location = New System.Drawing.Point(478, 96)
        Me.Rtt_data1.Name = "Rtt_data1"
        Me.Rtt_data1.Size = New System.Drawing.Size(249, 91)
        Me.Rtt_data1.TabIndex = 4
        Me.Rtt_data1.Text = ""
        '
        'DG_transactions
        '
        Me.DG_transactions.AllowUserToAddRows = False
        Me.DG_transactions.AllowUserToDeleteRows = False
        Me.DG_transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_transactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.chname})
        Me.DG_transactions.Location = New System.Drawing.Point(745, 230)
        Me.DG_transactions.Name = "DG_transactions"
        Me.DG_transactions.ReadOnly = True
        Me.DG_transactions.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DG_transactions.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_transactions.Size = New System.Drawing.Size(247, 115)
        Me.DG_transactions.TabIndex = 5
        '
        'ID
        '
        Me.ID.FillWeight = 50.76142!
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'chname
        '
        Me.chname.FillWeight = 149.2386!
        Me.chname.HeaderText = "Charge Name"
        Me.chname.Name = "chname"
        Me.chname.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(743, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "TRANSACTIONS"
        '
        'btn_addchrg
        '
        Me.btn_addchrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_addchrg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addchrg.Enabled = False
        Me.btn_addchrg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_addchrg.FlatAppearance.BorderSize = 3
        Me.btn_addchrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addchrg.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addchrg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_addchrg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addchrg.Location = New System.Drawing.Point(829, 435)
        Me.btn_addchrg.Name = "btn_addchrg"
        Me.btn_addchrg.Size = New System.Drawing.Size(163, 63)
        Me.btn_addchrg.TabIndex = 8
        Me.btn_addchrg.Text = "ADD CHARGES"
        Me.btn_addchrg.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Enabled = False
        Me.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 3
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.Location = New System.Drawing.Point(610, 435)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(213, 63)
        Me.btn_update.TabIndex = 7
        Me.btn_update.Text = "UPDATE "
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(474, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "HISTORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(737, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "DIAGNOSIS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(474, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ANCILLARY"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1004, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordToolStripMenuItem, Me.ToolStripSeparator1, Me.EditPatientInformationToolStripMenuItem, Me.DeleteRecordToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewRecordToolStripMenuItem
        '
        Me.NewRecordToolStripMenuItem.Name = "NewRecordToolStripMenuItem"
        Me.NewRecordToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NewRecordToolStripMenuItem.Text = "New Record"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(144, 6)
        '
        'EditPatientInformationToolStripMenuItem
        '
        Me.EditPatientInformationToolStripMenuItem.Name = "EditPatientInformationToolStripMenuItem"
        Me.EditPatientInformationToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.EditPatientInformationToolStripMenuItem.Text = "Edit Record"
        '
        'DeleteRecordToolStripMenuItem
        '
        Me.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem"
        Me.DeleteRecordToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DeleteRecordToolStripMenuItem.Text = "Delete Record"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintThisRecordToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'PrintThisRecordToolStripMenuItem
        '
        Me.PrintThisRecordToolStripMenuItem.Name = "PrintThisRecordToolStripMenuItem"
        Me.PrintThisRecordToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PrintThisRecordToolStripMenuItem.Text = "Print This Record"
        '
        'asd
        '
        Me.asd.Controls.Add(Me.ptdgv)
        Me.asd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.asd.Location = New System.Drawing.Point(14, 53)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(452, 445)
        Me.asd.TabIndex = 16
        Me.asd.TabStop = False
        Me.asd.Text = "PATIENT INFORMATION"
        '
        'ptdgv
        '
        Me.ptdgv.AllowUserToAddRows = False
        Me.ptdgv.AllowUserToDeleteRows = False
        Me.ptdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ptdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ptdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.ptdgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptdgv.Location = New System.Drawing.Point(3, 18)
        Me.ptdgv.Name = "ptdgv"
        Me.ptdgv.ReadOnly = True
        Me.ptdgv.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.ptdgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ptdgv.Size = New System.Drawing.Size(446, 424)
        Me.ptdgv.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.FillWeight = 71.06599!
        Me.Column1.HeaderText = "Identifier"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 128.934!
        Me.Column2.HeaderText = "Data"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Visit_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 510)
        Me.Controls.Add(Me.asd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_addchrg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DG_transactions)
        Me.Controls.Add(Me.Rtt_data1)
        Me.Controls.Add(Me.Rtt_data3)
        Me.Controls.Add(Me.Rtt_data2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Visit_Viewer"
        Me.Text = "Form1"
        CType(Me.DG_transactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.asd.ResumeLayout(False)
        CType(Me.ptdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rtt_data2 As RichTextBox
    Friend WithEvents Rtt_data3 As RichTextBox
    Friend WithEvents Rtt_data1 As RichTextBox
    Friend WithEvents DG_transactions As DataGridView
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_addchrg As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EditPatientInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintThisRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents chname As DataGridViewTextBoxColumn
    Friend WithEvents asd As GroupBox
    Friend WithEvents ptdgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class

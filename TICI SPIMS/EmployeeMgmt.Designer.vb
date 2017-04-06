<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeMgmt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeMgmt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCrRx = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCrPwPw = New System.Windows.Forms.TextBox()
        Me.txtCrPw = New System.Windows.Forms.TextBox()
        Me.txtCrUsername = New System.Windows.Forms.TextBox()
        Me.txtCrName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtUpRx = New System.Windows.Forms.ComboBox()
        Me.txtUpPw = New System.Windows.Forms.TextBox()
        Me.txtUpUser = New System.Windows.Forms.TextBox()
        Me.txtUpName = New System.Windows.Forms.TextBox()
        Me.empdgv = New System.Windows.Forms.DataGridView()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.empdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtCrRx)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCrPwPw)
        Me.GroupBox1.Controls.Add(Me.txtCrPw)
        Me.GroupBox1.Controls.Add(Me.txtCrUsername)
        Me.GroupBox1.Controls.Add(Me.txtCrName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 271)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add User"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(179, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CREATE USER"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtCrRx
        '
        Me.txtCrRx.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrRx.FormattingEnabled = True
        Me.txtCrRx.Items.AddRange(New Object() {"Level 1 - Patient Records", "Level 2 - Cashiering / Patient Records", "Level 3 - Admin / Cashiering / Patient Records"})
        Me.txtCrRx.Location = New System.Drawing.Point(127, 186)
        Me.txtCrRx.Name = "txtCrRx"
        Me.txtCrRx.Size = New System.Drawing.Size(280, 25)
        Me.txtCrRx.TabIndex = 5
        Me.txtCrRx.Text = "Choose one..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.AliceBlue
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(55, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Restriction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.AliceBlue
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Re-enter Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.AliceBlue
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(60, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.AliceBlue
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(57, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.AliceBlue
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(58, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full Name"
        '
        'txtCrPwPw
        '
        Me.txtCrPwPw.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtCrPwPw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrPwPw.Location = New System.Drawing.Point(127, 150)
        Me.txtCrPwPw.Name = "txtCrPwPw"
        Me.txtCrPwPw.Size = New System.Drawing.Size(280, 30)
        Me.txtCrPwPw.TabIndex = 4
        Me.txtCrPwPw.UseSystemPasswordChar = True
        '
        'txtCrPw
        '
        Me.txtCrPw.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtCrPw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrPw.Location = New System.Drawing.Point(127, 114)
        Me.txtCrPw.Name = "txtCrPw"
        Me.txtCrPw.Size = New System.Drawing.Size(280, 30)
        Me.txtCrPw.TabIndex = 3
        Me.txtCrPw.UseSystemPasswordChar = True
        '
        'txtCrUsername
        '
        Me.txtCrUsername.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtCrUsername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrUsername.Location = New System.Drawing.Point(127, 78)
        Me.txtCrUsername.Name = "txtCrUsername"
        Me.txtCrUsername.Size = New System.Drawing.Size(280, 30)
        Me.txtCrUsername.TabIndex = 2
        '
        'txtCrName
        '
        Me.txtCrName.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtCrName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCrName.Location = New System.Drawing.Point(127, 42)
        Me.txtCrName.Name = "txtCrName"
        Me.txtCrName.Size = New System.Drawing.Size(280, 30)
        Me.txtCrName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(60, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Full Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(59, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Username"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(62, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Re-enter Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(57, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Restriction"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Enabled = False
        Me.TextBox9.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox9.Location = New System.Drawing.Point(130, 186)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(280, 30)
        Me.TextBox9.TabIndex = 0
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox8.Location = New System.Drawing.Point(130, 155)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(280, 30)
        Me.TextBox8.TabIndex = 0
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox7.Location = New System.Drawing.Point(130, 119)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(280, 30)
        Me.TextBox7.TabIndex = 0
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox6.Location = New System.Drawing.Point(130, 83)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(280, 30)
        Me.TextBox6.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox5.Location = New System.Drawing.Point(130, 46)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(280, 30)
        Me.TextBox5.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtUpRx)
        Me.GroupBox2.Controls.Add(Me.txtUpPw)
        Me.GroupBox2.Controls.Add(Me.txtUpUser)
        Me.GroupBox2.Controls.Add(Me.txtUpName)
        Me.GroupBox2.Controls.Add(Me.empdgv)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(444, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 483)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "USER LIST"
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.BackColor = System.Drawing.Color.AliceBlue
        Me.txtID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtID.Location = New System.Drawing.Point(6, 385)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(66, 17)
        Me.txtID.TabIndex = 21
        Me.txtID.Text = "Full Name"
        Me.txtID.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.AliceBlue
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(70, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Restriction"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.AliceBlue
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(75, 320)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 17)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.AliceBlue
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(72, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Username"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.AliceBlue
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(73, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 17)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Full Name"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(156, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 41)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "DELETE"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(302, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 41)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "UPDATE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtUpRx
        '
        Me.txtUpRx.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUpRx.FormattingEnabled = True
        Me.txtUpRx.Items.AddRange(New Object() {"Level 1 - Patient Records", "Level 2 - Cashiering / Patient Records", "Level 3 - Admin / Cashiering / Patient Records"})
        Me.txtUpRx.Location = New System.Drawing.Point(142, 352)
        Me.txtUpRx.Name = "txtUpRx"
        Me.txtUpRx.Size = New System.Drawing.Size(280, 25)
        Me.txtUpRx.TabIndex = 10
        Me.txtUpRx.Text = "Choose one..."
        '
        'txtUpPw
        '
        Me.txtUpPw.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtUpPw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUpPw.Location = New System.Drawing.Point(142, 313)
        Me.txtUpPw.Name = "txtUpPw"
        Me.txtUpPw.Size = New System.Drawing.Size(280, 30)
        Me.txtUpPw.TabIndex = 9
        Me.txtUpPw.UseSystemPasswordChar = True
        '
        'txtUpUser
        '
        Me.txtUpUser.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtUpUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUpUser.Location = New System.Drawing.Point(142, 277)
        Me.txtUpUser.Name = "txtUpUser"
        Me.txtUpUser.Size = New System.Drawing.Size(280, 30)
        Me.txtUpUser.TabIndex = 8
        '
        'txtUpName
        '
        Me.txtUpName.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtUpName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUpName.Location = New System.Drawing.Point(142, 241)
        Me.txtUpName.Name = "txtUpName"
        Me.txtUpName.Size = New System.Drawing.Size(280, 30)
        Me.txtUpName.TabIndex = 7
        '
        'empdgv
        '
        Me.empdgv.AllowUserToAddRows = False
        Me.empdgv.AllowUserToDeleteRows = False
        Me.empdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.NullValue = "NULL"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.empdgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.empdgv.Location = New System.Drawing.Point(22, 51)
        Me.empdgv.MultiSelect = False
        Me.empdgv.Name = "empdgv"
        Me.empdgv.ReadOnly = True
        Me.empdgv.RowHeadersVisible = False
        Me.empdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.empdgv.Size = New System.Drawing.Size(400, 186)
        Me.empdgv.TabIndex = 0
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Enabled = False
        Me.TextBox10.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox10.Location = New System.Drawing.Point(145, 351)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(280, 30)
        Me.TextBox10.TabIndex = 11
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox12.Location = New System.Drawing.Point(145, 317)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(280, 30)
        Me.TextBox12.TabIndex = 13
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Enabled = False
        Me.TextBox13.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox13.Location = New System.Drawing.Point(145, 281)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(280, 30)
        Me.TextBox13.TabIndex = 14
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Enabled = False
        Me.TextBox14.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.TextBox14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox14.Location = New System.Drawing.Point(145, 244)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(280, 30)
        Me.TextBox14.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(72, 358)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 17)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Restriction"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(77, 323)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 17)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Password"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(74, 287)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Username"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(75, 251)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 17)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Full Name"
        '
        'EmployeeMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(916, 501)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "EmployeeMgmt"
        Me.Text = "EmployeeMgmt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.empdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCrPwPw As TextBox
    Friend WithEvents txtCrPw As TextBox
    Friend WithEvents txtCrUsername As TextBox
    Friend WithEvents txtCrName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCrRx As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents empdgv As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtUpRx As ComboBox
    Friend WithEvents txtUpPw As TextBox
    Friend WithEvents txtUpUser As TextBox
    Friend WithEvents txtUpName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtID As Label
    Friend WithEvents full_ame As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KaryawanForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tblKaryawan = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastlogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_karywan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jabatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.detailPanel = New System.Windows.Forms.Panel()
        Me.dtLastLogin = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtUsername = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtIsUser = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtHp = New System.Windows.Forms.Label()
        Me.dtEmail = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtJabatan = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtNamaLengkap = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pAdd = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tNIk = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tHp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.titleForm = New System.Windows.Forms.Label()
        Me.id_update = New System.Windows.Forms.TextBox()
        CType(Me.tblKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detailPanel.SuspendLayout()
        Me.pAdd.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.btnUpdate.SuspendLayout()
        Me.btnSimpan.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblKaryawan
        '
        Me.tblKaryawan.AllowUserToAddRows = False
        Me.tblKaryawan.AllowUserToDeleteRows = False
        Me.tblKaryawan.AllowUserToResizeRows = False
        Me.tblKaryawan.BackgroundColor = System.Drawing.Color.White
        Me.tblKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblKaryawan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblKaryawan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tblKaryawan.ColumnHeadersHeight = 40
        Me.tblKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.nama, Me.email, Me.hp, Me.lastlogin, Me.id_karywan, Me.username, Me.jabatan, Me.nik})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblKaryawan.DefaultCellStyle = DataGridViewCellStyle8
        Me.tblKaryawan.Location = New System.Drawing.Point(0, 1)
        Me.tblKaryawan.MultiSelect = False
        Me.tblKaryawan.Name = "tblKaryawan"
        Me.tblKaryawan.RowHeadersVisible = False
        Me.tblKaryawan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblKaryawan.ShowEditingIcon = False
        Me.tblKaryawan.Size = New System.Drawing.Size(500, 441)
        Me.tblKaryawan.TabIndex = 0
        '
        'no
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.no.DefaultCellStyle = DataGridViewCellStyle6
        Me.no.FillWeight = 60.0!
        Me.no.Frozen = True
        Me.no.HeaderText = "No"
        Me.no.MaxInputLength = 7
        Me.no.MinimumWidth = 60
        Me.no.Name = "no"
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 60
        '
        'nama
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.nama.DefaultCellStyle = DataGridViewCellStyle7
        Me.nama.FillWeight = 170.0!
        Me.nama.HeaderText = "Nama Karyawan"
        Me.nama.MinimumWidth = 170
        Me.nama.Name = "nama"
        Me.nama.Width = 170
        '
        'email
        '
        Me.email.FillWeight = 150.0!
        Me.email.HeaderText = "E-mail"
        Me.email.MinimumWidth = 150
        Me.email.Name = "email"
        Me.email.Visible = False
        Me.email.Width = 150
        '
        'hp
        '
        Me.hp.FillWeight = 150.0!
        Me.hp.HeaderText = "Handphone"
        Me.hp.MinimumWidth = 150
        Me.hp.Name = "hp"
        Me.hp.Width = 150
        '
        'lastlogin
        '
        Me.lastlogin.FillWeight = 120.0!
        Me.lastlogin.HeaderText = "Last Login"
        Me.lastlogin.MinimumWidth = 120
        Me.lastlogin.Name = "lastlogin"
        Me.lastlogin.Width = 120
        '
        'id_karywan
        '
        Me.id_karywan.HeaderText = "ID_karyawan"
        Me.id_karywan.Name = "id_karywan"
        Me.id_karywan.Visible = False
        '
        'username
        '
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.Visible = False
        '
        'jabatan
        '
        Me.jabatan.HeaderText = "jabatan"
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Visible = False
        '
        'nik
        '
        Me.nik.HeaderText = "NIK"
        Me.nik.Name = "nik"
        Me.nik.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.plus
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 458)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(207, 44)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "       Tambah Karyawan"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'detailPanel
        '
        Me.detailPanel.BackColor = System.Drawing.Color.White
        Me.detailPanel.Controls.Add(Me.dtLastLogin)
        Me.detailPanel.Controls.Add(Me.Label13)
        Me.detailPanel.Controls.Add(Me.dtUsername)
        Me.detailPanel.Controls.Add(Me.Label11)
        Me.detailPanel.Controls.Add(Me.dtIsUser)
        Me.detailPanel.Controls.Add(Me.Label9)
        Me.detailPanel.Controls.Add(Me.dtHp)
        Me.detailPanel.Controls.Add(Me.dtEmail)
        Me.detailPanel.Controls.Add(Me.Label6)
        Me.detailPanel.Controls.Add(Me.dtJabatan)
        Me.detailPanel.Controls.Add(Me.Label4)
        Me.detailPanel.Controls.Add(Me.dtNamaLengkap)
        Me.detailPanel.Controls.Add(Me.Label2)
        Me.detailPanel.Controls.Add(Me.Label1)
        Me.detailPanel.Location = New System.Drawing.Point(506, 0)
        Me.detailPanel.Name = "detailPanel"
        Me.detailPanel.Size = New System.Drawing.Size(289, 442)
        Me.detailPanel.TabIndex = 17
        '
        'dtLastLogin
        '
        Me.dtLastLogin.AutoSize = True
        Me.dtLastLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtLastLogin.Location = New System.Drawing.Point(31, 315)
        Me.dtLastLogin.Name = "dtLastLogin"
        Me.dtLastLogin.Size = New System.Drawing.Size(130, 17)
        Me.dtLastLogin.TabIndex = 13
        Me.dtLastLogin.Text = "07/01/2018 12:00:32"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 298)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Terakhir Login :"
        '
        'dtUsername
        '
        Me.dtUsername.AutoSize = True
        Me.dtUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtUsername.Location = New System.Drawing.Point(31, 271)
        Me.dtUsername.Name = "dtUsername"
        Me.dtUsername.Size = New System.Drawing.Size(50, 17)
        Me.dtUsername.TabIndex = 11
        Me.dtUsername.Text = "admin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 254)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Username :"
        '
        'dtIsUser
        '
        Me.dtIsUser.AutoSize = True
        Me.dtIsUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtIsUser.Location = New System.Drawing.Point(30, 227)
        Me.dtIsUser.Name = "dtIsUser"
        Me.dtIsUser.Size = New System.Drawing.Size(41, 17)
        Me.dtIsUser.TabIndex = 9
        Me.dtIsUser.Text = "Tidak"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Is User :"
        '
        'dtHp
        '
        Me.dtHp.AutoSize = True
        Me.dtHp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtHp.Location = New System.Drawing.Point(30, 181)
        Me.dtHp.Name = "dtHp"
        Me.dtHp.Size = New System.Drawing.Size(106, 17)
        Me.dtHp.TabIndex = 7
        Me.dtHp.Text = "08571745330022"
        '
        'dtEmail
        '
        Me.dtEmail.AutoSize = True
        Me.dtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtEmail.Location = New System.Drawing.Point(30, 164)
        Me.dtEmail.Name = "dtEmail"
        Me.dtEmail.Size = New System.Drawing.Size(105, 17)
        Me.dtEmail.TabIndex = 6
        Me.dtEmail.Text = "me@dani.work"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contact :"
        '
        'dtJabatan
        '
        Me.dtJabatan.AutoSize = True
        Me.dtJabatan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtJabatan.Location = New System.Drawing.Point(30, 119)
        Me.dtJabatan.Name = "dtJabatan"
        Me.dtJabatan.Size = New System.Drawing.Size(100, 17)
        Me.dtJabatan.TabIndex = 4
        Me.dtJabatan.Text = "Admin Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jabatan :"
        '
        'dtNamaLengkap
        '
        Me.dtNamaLengkap.AutoSize = True
        Me.dtNamaLengkap.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtNamaLengkap.Location = New System.Drawing.Point(30, 74)
        Me.dtNamaLengkap.Name = "dtNamaLengkap"
        Me.dtNamaLengkap.Size = New System.Drawing.Size(180, 17)
        Me.dtNamaLengkap.TabIndex = 2
        Me.dtNamaLengkap.Text = "Muhamad Yusup Hamdani"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Lengkap :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informasi Detail"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pAdd
        '
        Me.pAdd.BackColor = System.Drawing.Color.White
        Me.pAdd.Controls.Add(Me.Button1)
        Me.pAdd.Controls.Add(Me.Panel5)
        Me.pAdd.Controls.Add(Me.btnUpdate)
        Me.pAdd.Controls.Add(Me.Label8)
        Me.pAdd.Controls.Add(Me.btnSimpan)
        Me.pAdd.Controls.Add(Me.Panel4)
        Me.pAdd.Controls.Add(Me.Label7)
        Me.pAdd.Controls.Add(Me.Panel3)
        Me.pAdd.Controls.Add(Me.Label5)
        Me.pAdd.Controls.Add(Me.Panel2)
        Me.pAdd.Controls.Add(Me.Label3)
        Me.pAdd.Controls.Add(Me.titleForm)
        Me.pAdd.Location = New System.Drawing.Point(211, 12)
        Me.pAdd.Name = "pAdd"
        Me.pAdd.Size = New System.Drawing.Size(289, 442)
        Me.pAdd.TabIndex = 18
        Me.pAdd.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.cancel
        Me.Button1.Location = New System.Drawing.Point(250, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 40)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.tNIk)
        Me.Panel5.Location = New System.Drawing.Point(23, 141)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(246, 41)
        Me.Panel5.TabIndex = 1
        '
        'tNIk
        '
        Me.tNIk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tNIk.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNIk.ForeColor = System.Drawing.Color.DimGray
        Me.tNIk.Location = New System.Drawing.Point(11, 9)
        Me.tNIk.Name = "tNIk"
        Me.tNIk.Size = New System.Drawing.Size(223, 20)
        Me.tNIk.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Controls.Add(Me.Button8)
        Me.btnUpdate.Controls.Add(Me.Button9)
        Me.btnUpdate.Location = New System.Drawing.Point(23, 390)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(246, 54)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.garbage
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(122, 1)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(123, 41)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "       Delete"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.update
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(-1, 1)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button9.Size = New System.Drawing.Size(123, 41)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "       Update"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "NIK :"
        '
        'btnSimpan
        '
        Me.btnSimpan.Controls.Add(Me.Button6)
        Me.btnSimpan.Controls.Add(Me.Button4)
        Me.btnSimpan.Location = New System.Drawing.Point(23, 328)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(246, 56)
        Me.btnSimpan.TabIndex = 17
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.cancel
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(124, 2)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(122, 42)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "        Reset"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.update
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1, 2)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(123, 42)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "       Simpan"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.tEmail)
        Me.Panel4.Location = New System.Drawing.Point(23, 284)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 41)
        Me.Panel4.TabIndex = 3
        '
        'tEmail
        '
        Me.tEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tEmail.ForeColor = System.Drawing.Color.DimGray
        Me.tEmail.Location = New System.Drawing.Point(11, 9)
        Me.tEmail.MaxLength = 50
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(223, 20)
        Me.tEmail.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "E-Mail :"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tHp)
        Me.Panel3.Location = New System.Drawing.Point(23, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 41)
        Me.Panel3.TabIndex = 2
        '
        'tHp
        '
        Me.tHp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tHp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHp.ForeColor = System.Drawing.Color.DimGray
        Me.tHp.Location = New System.Drawing.Point(11, 9)
        Me.tHp.MaxLength = 15
        Me.tHp.Name = "tHp"
        Me.tHp.Size = New System.Drawing.Size(223, 20)
        Me.tHp.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Handphone :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tNama)
        Me.Panel2.Location = New System.Drawing.Point(23, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 41)
        Me.Panel2.TabIndex = 0
        '
        'tNama
        '
        Me.tNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tNama.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNama.ForeColor = System.Drawing.Color.DimGray
        Me.tNama.Location = New System.Drawing.Point(11, 9)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(223, 20)
        Me.tNama.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Lengkap :"
        '
        'titleForm
        '
        Me.titleForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.titleForm.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.titleForm.ForeColor = System.Drawing.Color.White
        Me.titleForm.Location = New System.Drawing.Point(0, 0)
        Me.titleForm.Name = "titleForm"
        Me.titleForm.Size = New System.Drawing.Size(298, 40)
        Me.titleForm.TabIndex = 0
        Me.titleForm.Text = "Form Tambah"
        Me.titleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'id_update
        '
        Me.id_update.Location = New System.Drawing.Point(760, 467)
        Me.id_update.Name = "id_update"
        Me.id_update.Size = New System.Drawing.Size(24, 20)
        Me.id_update.TabIndex = 19
        '
        'KaryawanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 543)
        Me.Controls.Add(Me.id_update)
        Me.Controls.Add(Me.pAdd)
        Me.Controls.Add(Me.detailPanel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tblKaryawan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KaryawanForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  BarangForm"
        CType(Me.tblKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detailPanel.ResumeLayout(False)
        Me.detailPanel.PerformLayout()
        Me.pAdd.ResumeLayout(False)
        Me.pAdd.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.btnUpdate.ResumeLayout(False)
        Me.btnSimpan.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents detailPanel As System.Windows.Forms.Panel
    Friend WithEvents dtNamaLengkap As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtLastLogin As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtUsername As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtIsUser As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtHp As System.Windows.Forms.Label
    Friend WithEvents dtEmail As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtJabatan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pAdd As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tHp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents titleForm As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tNIk As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lastlogin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_karywan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jabatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_update As System.Windows.Forms.TextBox
End Class

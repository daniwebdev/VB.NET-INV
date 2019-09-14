<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tblUser = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hak_akses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastlogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pAdd = New System.Windows.Forms.Panel()
        Me.tIdUser = New System.Windows.Forms.TextBox()
        Me.closeUpdate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.tblKaryawan = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tHakAkses = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tNIk = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tidK = New System.Windows.Forms.TextBox()
        CType(Me.tblUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pAdd.SuspendLayout()
        Me.btnUpdate.SuspendLayout()
        CType(Me.tblKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.btnSimpan.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblUser
        '
        Me.tblUser.AllowUserToAddRows = False
        Me.tblUser.AllowUserToDeleteRows = False
        Me.tblUser.AllowUserToResizeRows = False
        Me.tblUser.BackgroundColor = System.Drawing.Color.White
        Me.tblUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblUser.ColumnHeadersHeight = 40
        Me.tblUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.username, Me.nama, Me.hak_akses, Me.lastlogin, Me.id_user})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblUser.DefaultCellStyle = DataGridViewCellStyle4
        Me.tblUser.Location = New System.Drawing.Point(0, 0)
        Me.tblUser.MultiSelect = False
        Me.tblUser.Name = "tblUser"
        Me.tblUser.ReadOnly = True
        Me.tblUser.RowHeadersVisible = False
        Me.tblUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblUser.ShowEditingIcon = False
        Me.tblUser.Size = New System.Drawing.Size(500, 543)
        Me.tblUser.TabIndex = 1
        '
        'no
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.no.DefaultCellStyle = DataGridViewCellStyle2
        Me.no.FillWeight = 60.0!
        Me.no.Frozen = True
        Me.no.HeaderText = "No"
        Me.no.MaxInputLength = 7
        Me.no.MinimumWidth = 60
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 60
        '
        'username
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.username.DefaultCellStyle = DataGridViewCellStyle3
        Me.username.FillWeight = 170.0!
        Me.username.HeaderText = "Username"
        Me.username.MinimumWidth = 170
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 170
        '
        'nama
        '
        Me.nama.FillWeight = 150.0!
        Me.nama.HeaderText = "Nama Karyawan"
        Me.nama.MinimumWidth = 150
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.Width = 150
        '
        'hak_akses
        '
        Me.hak_akses.FillWeight = 150.0!
        Me.hak_akses.HeaderText = "Hak Akses"
        Me.hak_akses.MinimumWidth = 150
        Me.hak_akses.Name = "hak_akses"
        Me.hak_akses.ReadOnly = True
        Me.hak_akses.Width = 150
        '
        'lastlogin
        '
        Me.lastlogin.FillWeight = 120.0!
        Me.lastlogin.HeaderText = "Last Login"
        Me.lastlogin.MinimumWidth = 120
        Me.lastlogin.Name = "lastlogin"
        Me.lastlogin.ReadOnly = True
        Me.lastlogin.Width = 120
        '
        'id_user
        '
        Me.id_user.HeaderText = "ID_karyawan"
        Me.id_user.Name = "id_user"
        Me.id_user.ReadOnly = True
        Me.id_user.Visible = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(298, 40)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Form Tambah"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pAdd
        '
        Me.pAdd.BackColor = System.Drawing.Color.White
        Me.pAdd.Controls.Add(Me.tIdUser)
        Me.pAdd.Controls.Add(Me.closeUpdate)
        Me.pAdd.Controls.Add(Me.btnUpdate)
        Me.pAdd.Controls.Add(Me.tblKaryawan)
        Me.pAdd.Controls.Add(Me.tHakAkses)
        Me.pAdd.Controls.Add(Me.Label1)
        Me.pAdd.Controls.Add(Me.Panel5)
        Me.pAdd.Controls.Add(Me.Label8)
        Me.pAdd.Controls.Add(Me.btnSimpan)
        Me.pAdd.Controls.Add(Me.Panel4)
        Me.pAdd.Controls.Add(Me.Label7)
        Me.pAdd.Controls.Add(Me.Panel3)
        Me.pAdd.Controls.Add(Me.Label5)
        Me.pAdd.Controls.Add(Me.Panel2)
        Me.pAdd.Controls.Add(Me.Label3)
        Me.pAdd.Controls.Add(Me.Label21)
        Me.pAdd.Controls.Add(Me.Button2)
        Me.pAdd.Location = New System.Drawing.Point(506, 0)
        Me.pAdd.Name = "pAdd"
        Me.pAdd.Size = New System.Drawing.Size(289, 543)
        Me.pAdd.TabIndex = 19
        '
        'tIdUser
        '
        Me.tIdUser.Location = New System.Drawing.Point(267, 460)
        Me.tIdUser.Name = "tIdUser"
        Me.tIdUser.Size = New System.Drawing.Size(22, 20)
        Me.tIdUser.TabIndex = 22
        Me.tIdUser.Visible = False
        '
        'closeUpdate
        '
        Me.closeUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.closeUpdate.FlatAppearance.BorderSize = 0
        Me.closeUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.closeUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.closeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeUpdate.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.cancel
        Me.closeUpdate.Location = New System.Drawing.Point(250, 1)
        Me.closeUpdate.Name = "closeUpdate"
        Me.closeUpdate.Size = New System.Drawing.Size(39, 39)
        Me.closeUpdate.TabIndex = 22
        Me.closeUpdate.UseVisualStyleBackColor = False
        Me.closeUpdate.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Controls.Add(Me.Button8)
        Me.btnUpdate.Controls.Add(Me.Button9)
        Me.btnUpdate.Location = New System.Drawing.Point(23, 477)
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
        Me.tblKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.namaK, Me.nik, Me.idK})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblKaryawan.DefaultCellStyle = DataGridViewCellStyle7
        Me.tblKaryawan.Location = New System.Drawing.Point(0, 39)
        Me.tblKaryawan.MultiSelect = False
        Me.tblKaryawan.Name = "tblKaryawan"
        Me.tblKaryawan.RowHeadersVisible = False
        Me.tblKaryawan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblKaryawan.ShowEditingIcon = False
        Me.tblKaryawan.Size = New System.Drawing.Size(289, 289)
        Me.tblKaryawan.TabIndex = 20
        Me.tblKaryawan.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'namaK
        '
        Me.namaK.FillWeight = 148.0!
        Me.namaK.HeaderText = "Nama Karyawan"
        Me.namaK.MinimumWidth = 148
        Me.namaK.Name = "namaK"
        Me.namaK.Width = 148
        '
        'nik
        '
        Me.nik.HeaderText = "NIK"
        Me.nik.MinimumWidth = 100
        Me.nik.Name = "nik"
        '
        'idK
        '
        Me.idK.HeaderText = "ID_karyawan"
        Me.idK.Name = "idK"
        Me.idK.Visible = False
        '
        'tHakAkses
        '
        Me.tHakAkses.FormattingEnabled = True
        Me.tHakAkses.Location = New System.Drawing.Point(24, 356)
        Me.tHakAkses.Name = "tHakAkses"
        Me.tHakAkses.Size = New System.Drawing.Size(246, 21)
        Me.tHakAkses.TabIndex = 19
        Me.tHakAkses.Tag = ""
        Me.tHakAkses.Text = "- Pilih -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Hak Akses :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Menu
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
        Me.tNIk.ReadOnly = True
        Me.tNIk.Size = New System.Drawing.Size(223, 20)
        Me.tNIk.TabIndex = 1
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
        Me.btnSimpan.Location = New System.Drawing.Point(23, 398)
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
        Me.Panel4.Controls.Add(Me.tPass)
        Me.Panel4.Location = New System.Drawing.Point(23, 284)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 41)
        Me.Panel4.TabIndex = 3
        '
        'tPass
        '
        Me.tPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPass.ForeColor = System.Drawing.Color.DimGray
        Me.tPass.Location = New System.Drawing.Point(11, 9)
        Me.tPass.MaxLength = 50
        Me.tPass.Name = "tPass"
        Me.tPass.Size = New System.Drawing.Size(223, 20)
        Me.tPass.TabIndex = 3
        Me.tPass.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Password :"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tUsername)
        Me.Panel3.Location = New System.Drawing.Point(23, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 41)
        Me.Panel3.TabIndex = 2
        '
        'tUsername
        '
        Me.tUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsername.ForeColor = System.Drawing.Color.DimGray
        Me.tUsername.Location = New System.Drawing.Point(11, 9)
        Me.tUsername.MaxLength = 15
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(223, 20)
        Me.tUsername.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Username :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tNama)
        Me.Panel2.Location = New System.Drawing.Point(23, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 41)
        Me.Panel2.TabIndex = 0
        '
        'tNama
        '
        Me.tNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tNama.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNama.ForeColor = System.Drawing.Color.DimGray
        Me.tNama.Location = New System.Drawing.Point(11, 9)
        Me.tNama.Name = "tNama"
        Me.tNama.ReadOnly = True
        Me.tNama.Size = New System.Drawing.Size(167, 20)
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.loupe
        Me.Button2.Location = New System.Drawing.Point(216, 73)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 41)
        Me.Button2.TabIndex = 6
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tidK
        '
        Me.tidK.Location = New System.Drawing.Point(742, 460)
        Me.tidK.Name = "tidK"
        Me.tidK.Size = New System.Drawing.Size(22, 20)
        Me.tidK.TabIndex = 21
        Me.tidK.Visible = False
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(796, 543)
        Me.Controls.Add(Me.tidK)
        Me.Controls.Add(Me.pAdd)
        Me.Controls.Add(Me.tblUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.tblUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pAdd.ResumeLayout(False)
        Me.pAdd.PerformLayout()
        Me.btnUpdate.ResumeLayout(False)
        CType(Me.tblKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
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
    Friend WithEvents tblUser As System.Windows.Forms.DataGridView
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents pAdd As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tNIk As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tPass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hak_akses As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lastlogin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tblKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tidK As System.Windows.Forms.TextBox
    Friend WithEvents tHakAkses As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents closeUpdate As System.Windows.Forms.Button
    Friend WithEvents tIdUser As System.Windows.Forms.TextBox
End Class

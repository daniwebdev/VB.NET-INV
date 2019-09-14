<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarangForm
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tblBarang = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_beli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnTambahBarang = New System.Windows.Forms.Button()
        Me.barangType = New System.Windows.Forms.TextBox()
        Me.tblBarangMasuk = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masukNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masukKode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masukQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masukSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masukTgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masukKaryawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_masuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_karyawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblBarangKeluar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_cust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.karyawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tblBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblBarangMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblBarangKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblBarang
        '
        Me.tblBarang.AllowUserToAddRows = False
        Me.tblBarang.AllowUserToDeleteRows = False
        Me.tblBarang.AllowUserToResizeRows = False
        Me.tblBarang.BackgroundColor = System.Drawing.Color.White
        Me.tblBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblBarang.ColumnHeadersHeight = 40
        Me.tblBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tblBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.nama, Me.kode, Me.stok, Me.satuan, Me.harga_jual, Me.harga_beli, Me.id})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblBarang.DefaultCellStyle = DataGridViewCellStyle4
        Me.tblBarang.Location = New System.Drawing.Point(0, 1)
        Me.tblBarang.MultiSelect = False
        Me.tblBarang.Name = "tblBarang"
        Me.tblBarang.ReadOnly = True
        Me.tblBarang.RowHeadersVisible = False
        Me.tblBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblBarang.Size = New System.Drawing.Size(796, 441)
        Me.tblBarang.TabIndex = 0
        '
        'no
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.no.DefaultCellStyle = DataGridViewCellStyle2
        Me.no.FillWeight = 50.0!
        Me.no.Frozen = True
        Me.no.HeaderText = "No"
        Me.no.MaxInputLength = 7
        Me.no.MinimumWidth = 50
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 50
        '
        'nama
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.nama.DefaultCellStyle = DataGridViewCellStyle3
        Me.nama.FillWeight = 200.0!
        Me.nama.Frozen = True
        Me.nama.HeaderText = "Nama Barang"
        Me.nama.MinimumWidth = 200
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.Width = 200
        '
        'kode
        '
        Me.kode.FillWeight = 140.0!
        Me.kode.HeaderText = "Kode"
        Me.kode.MinimumWidth = 140
        Me.kode.Name = "kode"
        Me.kode.ReadOnly = True
        Me.kode.Width = 140
        '
        'stok
        '
        Me.stok.FillWeight = 105.0!
        Me.stok.HeaderText = "Stok"
        Me.stok.MinimumWidth = 105
        Me.stok.Name = "stok"
        Me.stok.ReadOnly = True
        Me.stok.Width = 105
        '
        'satuan
        '
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.ReadOnly = True
        '
        'harga_jual
        '
        Me.harga_jual.FillWeight = 150.0!
        Me.harga_jual.HeaderText = "Harga Jual"
        Me.harga_jual.MinimumWidth = 150
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.ReadOnly = True
        Me.harga_jual.Width = 150
        '
        'harga_beli
        '
        Me.harga_beli.FillWeight = 150.0!
        Me.harga_beli.HeaderText = "Harga Beli"
        Me.harga_beli.MinimumWidth = 150
        Me.harga_beli.Name = "harga_beli"
        Me.harga_beli.ReadOnly = True
        Me.harga_beli.Width = 150
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.database
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(634, 458)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(162, 44)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "       Data Barang"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
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
        Me.Button2.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.export
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(266, 458)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(192, 44)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "       Barang Keluar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Button3.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.import
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(458, 458)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(176, 44)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "       Barang Masuk"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnTambahBarang
        '
        Me.btnTambahBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnTambahBarang.FlatAppearance.BorderSize = 0
        Me.btnTambahBarang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnTambahBarang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahBarang.ForeColor = System.Drawing.Color.White
        Me.btnTambahBarang.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.plus
        Me.btnTambahBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambahBarang.Location = New System.Drawing.Point(0, 458)
        Me.btnTambahBarang.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTambahBarang.Name = "btnTambahBarang"
        Me.btnTambahBarang.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnTambahBarang.Size = New System.Drawing.Size(134, 44)
        Me.btnTambahBarang.TabIndex = 4
        Me.btnTambahBarang.Text = "       Tambah"
        Me.btnTambahBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambahBarang.UseVisualStyleBackColor = False
        '
        'barangType
        '
        Me.barangType.Location = New System.Drawing.Point(0, 511)
        Me.barangType.Name = "barangType"
        Me.barangType.Size = New System.Drawing.Size(100, 20)
        Me.barangType.TabIndex = 17
        Me.barangType.Text = "data"
        Me.barangType.Visible = False
        '
        'tblBarangMasuk
        '
        Me.tblBarangMasuk.AllowUserToAddRows = False
        Me.tblBarangMasuk.AllowUserToDeleteRows = False
        Me.tblBarangMasuk.AllowUserToResizeRows = False
        Me.tblBarangMasuk.BackgroundColor = System.Drawing.Color.White
        Me.tblBarangMasuk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblBarangMasuk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblBarangMasuk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tblBarangMasuk.ColumnHeadersHeight = 40
        Me.tblBarangMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tblBarangMasuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.masukNama, Me.masukKode, Me.masukQty, Me.masukSatuan, Me.masukTgl, Me.masukKaryawan, Me.id_masuk, Me.id_karyawan})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblBarangMasuk.DefaultCellStyle = DataGridViewCellStyle9
        Me.tblBarangMasuk.Location = New System.Drawing.Point(51, 1)
        Me.tblBarangMasuk.MultiSelect = False
        Me.tblBarangMasuk.Name = "tblBarangMasuk"
        Me.tblBarangMasuk.ReadOnly = True
        Me.tblBarangMasuk.RowHeadersVisible = False
        Me.tblBarangMasuk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblBarangMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblBarangMasuk.Size = New System.Drawing.Size(796, 441)
        Me.tblBarangMasuk.TabIndex = 18
        Me.tblBarangMasuk.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'masukNama
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.masukNama.DefaultCellStyle = DataGridViewCellStyle7
        Me.masukNama.FillWeight = 200.0!
        Me.masukNama.Frozen = True
        Me.masukNama.HeaderText = "Nama Barang"
        Me.masukNama.MinimumWidth = 200
        Me.masukNama.Name = "masukNama"
        Me.masukNama.ReadOnly = True
        Me.masukNama.Width = 200
        '
        'masukKode
        '
        Me.masukKode.FillWeight = 140.0!
        Me.masukKode.HeaderText = "Kode"
        Me.masukKode.MinimumWidth = 140
        Me.masukKode.Name = "masukKode"
        Me.masukKode.ReadOnly = True
        Me.masukKode.Width = 140
        '
        'masukQty
        '
        Me.masukQty.FillWeight = 105.0!
        Me.masukQty.HeaderText = "Qty"
        Me.masukQty.MinimumWidth = 105
        Me.masukQty.Name = "masukQty"
        Me.masukQty.ReadOnly = True
        Me.masukQty.Width = 105
        '
        'masukSatuan
        '
        Me.masukSatuan.HeaderText = "Satuan"
        Me.masukSatuan.Name = "masukSatuan"
        Me.masukSatuan.ReadOnly = True
        '
        'masukTgl
        '
        Me.masukTgl.FillWeight = 150.0!
        Me.masukTgl.HeaderText = "Tanggal Masuk"
        Me.masukTgl.MinimumWidth = 150
        Me.masukTgl.Name = "masukTgl"
        Me.masukTgl.ReadOnly = True
        Me.masukTgl.Width = 150
        '
        'masukKaryawan
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.masukKaryawan.DefaultCellStyle = DataGridViewCellStyle8
        Me.masukKaryawan.FillWeight = 150.0!
        Me.masukKaryawan.HeaderText = "Karyawan"
        Me.masukKaryawan.MinimumWidth = 150
        Me.masukKaryawan.Name = "masukKaryawan"
        Me.masukKaryawan.ReadOnly = True
        Me.masukKaryawan.Width = 150
        '
        'id_masuk
        '
        Me.id_masuk.HeaderText = "ID"
        Me.id_masuk.Name = "id_masuk"
        Me.id_masuk.ReadOnly = True
        Me.id_masuk.Visible = False
        '
        'id_karyawan
        '
        Me.id_karyawan.HeaderText = "ID_karyawan"
        Me.id_karyawan.Name = "id_karyawan"
        Me.id_karyawan.ReadOnly = True
        Me.id_karyawan.Visible = False
        '
        'tblBarangKeluar
        '
        Me.tblBarangKeluar.AllowUserToAddRows = False
        Me.tblBarangKeluar.AllowUserToDeleteRows = False
        Me.tblBarangKeluar.AllowUserToResizeRows = False
        Me.tblBarangKeluar.BackgroundColor = System.Drawing.Color.White
        Me.tblBarangKeluar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblBarangKeluar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblBarangKeluar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.tblBarangKeluar.ColumnHeadersHeight = 40
        Me.tblBarangKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tblBarangKeluar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.qty, Me.DataGridViewTextBoxColumn6, Me.waktu, Me.nama_cust, Me.karyawan, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblBarangKeluar.DefaultCellStyle = DataGridViewCellStyle13
        Me.tblBarangKeluar.Location = New System.Drawing.Point(159, 1)
        Me.tblBarangKeluar.MultiSelect = False
        Me.tblBarangKeluar.Name = "tblBarangKeluar"
        Me.tblBarangKeluar.ReadOnly = True
        Me.tblBarangKeluar.RowHeadersVisible = False
        Me.tblBarangKeluar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblBarangKeluar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblBarangKeluar.Size = New System.Drawing.Size(796, 441)
        Me.tblBarangKeluar.TabIndex = 19
        Me.tblBarangKeluar.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "No"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn3.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 140.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 140
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 105.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kode TRX"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 105
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 105
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Satuan"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'waktu
        '
        Me.waktu.HeaderText = "Waktu"
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        '
        'nama_cust
        '
        Me.nama_cust.HeaderText = "Nama Pembeli"
        Me.nama_cust.Name = "nama_cust"
        Me.nama_cust.ReadOnly = True
        '
        'karyawan
        '
        Me.karyawan.HeaderText = "Karyawan"
        Me.karyawan.Name = "karyawan"
        Me.karyawan.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID_karyawan"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'BarangForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 543)
        Me.Controls.Add(Me.tblBarangKeluar)
        Me.Controls.Add(Me.tblBarangMasuk)
        Me.Controls.Add(Me.barangType)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnTambahBarang)
        Me.Controls.Add(Me.tblBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BarangForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  BarangForm"
        CType(Me.tblBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblBarangMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblBarangKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblBarang As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambahBarang As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents barangType As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_beli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tblBarangMasuk As System.Windows.Forms.DataGridView
    Friend WithEvents tblBarangKeluar As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waktu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_cust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents karyawan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents masukNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents masukKode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents masukQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents masukSatuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents masukTgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents masukKaryawan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_masuk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_karyawan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

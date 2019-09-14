<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.tblHistoryActivity = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.karyawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.tblHistoryActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblBarangMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblHistoryActivity
        '
        Me.tblHistoryActivity.AllowUserToAddRows = False
        Me.tblHistoryActivity.AllowUserToDeleteRows = False
        Me.tblHistoryActivity.AllowUserToResizeRows = False
        Me.tblHistoryActivity.BackgroundColor = System.Drawing.Color.White
        Me.tblHistoryActivity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tblHistoryActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblHistoryActivity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblHistoryActivity.ColumnHeadersHeight = 40
        Me.tblHistoryActivity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.label, Me.waktu, Me.karyawan})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblHistoryActivity.DefaultCellStyle = DataGridViewCellStyle4
        Me.tblHistoryActivity.Location = New System.Drawing.Point(2, 2)
        Me.tblHistoryActivity.MultiSelect = False
        Me.tblHistoryActivity.Name = "tblHistoryActivity"
        Me.tblHistoryActivity.RowHeadersVisible = False
        Me.tblHistoryActivity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblHistoryActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblHistoryActivity.ShowEditingIcon = False
        Me.tblHistoryActivity.Size = New System.Drawing.Size(762, 389)
        Me.tblHistoryActivity.TabIndex = 2
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
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 60
        '
        'label
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.label.DefaultCellStyle = DataGridViewCellStyle3
        Me.label.FillWeight = 230.0!
        Me.label.HeaderText = "Activity"
        Me.label.MinimumWidth = 230
        Me.label.Name = "label"
        Me.label.Width = 230
        '
        'waktu
        '
        Me.waktu.FillWeight = 180.0!
        Me.waktu.HeaderText = "Waktu"
        Me.waktu.MinimumWidth = 180
        Me.waktu.Name = "waktu"
        Me.waktu.Width = 180
        '
        'karyawan
        '
        Me.karyawan.FillWeight = 200.0!
        Me.karyawan.HeaderText = "Karyawan"
        Me.karyawan.MinimumWidth = 200
        Me.karyawan.Name = "karyawan"
        Me.karyawan.Width = 200
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
        Me.tblBarangMasuk.Location = New System.Drawing.Point(2, 2)
        Me.tblBarangMasuk.MultiSelect = False
        Me.tblBarangMasuk.Name = "tblBarangMasuk"
        Me.tblBarangMasuk.ReadOnly = True
        Me.tblBarangMasuk.RowHeadersVisible = False
        Me.tblBarangMasuk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblBarangMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblBarangMasuk.Size = New System.Drawing.Size(762, 389)
        Me.tblBarangMasuk.TabIndex = 19
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.plus
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(470, 405)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(166, 44)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "       Barang Masuk"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(649, 405)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(115, 44)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "       Activity"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 465)
        Me.Controls.Add(Me.tblBarangMasuk)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tblHistoryActivity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        CType(Me.tblHistoryActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblBarangMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHistoryActivity As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents label As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waktu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents karyawan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tblBarangMasuk As System.Windows.Forms.DataGridView
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

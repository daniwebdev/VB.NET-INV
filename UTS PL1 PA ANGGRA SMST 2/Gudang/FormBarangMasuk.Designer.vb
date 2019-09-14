<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarangMasuk
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
        Me.tblBarang = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pAdd = New System.Windows.Forms.Panel()
        Me.tIdBarang = New System.Windows.Forms.TextBox()
        Me.closeUpdate = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tKode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tQty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.tblBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pAdd.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.btnSimpan.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.tblBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.nama, Me.kode, Me.stok, Me.satuan, Me.id})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblBarang.DefaultCellStyle = DataGridViewCellStyle4
        Me.tblBarang.Location = New System.Drawing.Point(-1, -1)
        Me.tblBarang.MultiSelect = False
        Me.tblBarang.Name = "tblBarang"
        Me.tblBarang.ReadOnly = True
        Me.tblBarang.RowHeadersVisible = False
        Me.tblBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.tblBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblBarang.Size = New System.Drawing.Size(469, 454)
        Me.tblBarang.TabIndex = 1
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
        Me.kode.FillWeight = 180.0!
        Me.kode.HeaderText = "Kode"
        Me.kode.MinimumWidth = 180
        Me.kode.Name = "kode"
        Me.kode.ReadOnly = True
        Me.kode.Width = 180
        '
        'stok
        '
        Me.stok.FillWeight = 160.0!
        Me.stok.HeaderText = "Stok"
        Me.stok.MinimumWidth = 160
        Me.stok.Name = "stok"
        Me.stok.ReadOnly = True
        Me.stok.Width = 160
        '
        'satuan
        '
        Me.satuan.FillWeight = 150.0!
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.MinimumWidth = 150
        Me.satuan.Name = "satuan"
        Me.satuan.ReadOnly = True
        Me.satuan.Width = 150
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'pAdd
        '
        Me.pAdd.BackColor = System.Drawing.Color.White
        Me.pAdd.Controls.Add(Me.tIdBarang)
        Me.pAdd.Controls.Add(Me.closeUpdate)
        Me.pAdd.Controls.Add(Me.Panel5)
        Me.pAdd.Controls.Add(Me.Label8)
        Me.pAdd.Controls.Add(Me.btnSimpan)
        Me.pAdd.Controls.Add(Me.Panel3)
        Me.pAdd.Controls.Add(Me.Label5)
        Me.pAdd.Controls.Add(Me.Panel2)
        Me.pAdd.Controls.Add(Me.Label3)
        Me.pAdd.Controls.Add(Me.Label21)
        Me.pAdd.Location = New System.Drawing.Point(474, -1)
        Me.pAdd.Name = "pAdd"
        Me.pAdd.Size = New System.Drawing.Size(289, 454)
        Me.pAdd.TabIndex = 20
        '
        'tIdBarang
        '
        Me.tIdBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tIdBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tIdBarang.ForeColor = System.Drawing.Color.DimGray
        Me.tIdBarang.Location = New System.Drawing.Point(24, 341)
        Me.tIdBarang.MaxLength = 15
        Me.tIdBarang.Name = "tIdBarang"
        Me.tIdBarang.Size = New System.Drawing.Size(34, 27)
        Me.tIdBarang.TabIndex = 3
        Me.tIdBarang.Visible = False
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.tKode)
        Me.Panel5.Location = New System.Drawing.Point(23, 141)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(246, 41)
        Me.Panel5.TabIndex = 1
        '
        'tKode
        '
        Me.tKode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tKode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKode.ForeColor = System.Drawing.Color.DimGray
        Me.tKode.Location = New System.Drawing.Point(11, 9)
        Me.tKode.Name = "tKode"
        Me.tKode.ReadOnly = True
        Me.tKode.Size = New System.Drawing.Size(223, 20)
        Me.tKode.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Kode :"
        '
        'btnSimpan
        '
        Me.btnSimpan.Controls.Add(Me.Button6)
        Me.btnSimpan.Controls.Add(Me.Button4)
        Me.btnSimpan.Location = New System.Drawing.Point(23, 270)
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
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tQty)
        Me.Panel3.Location = New System.Drawing.Point(23, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 41)
        Me.Panel3.TabIndex = 2
        '
        'tQty
        '
        Me.tQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tQty.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tQty.ForeColor = System.Drawing.Color.DimGray
        Me.tQty.Location = New System.Drawing.Point(11, 9)
        Me.tQty.MaxLength = 15
        Me.tQty.Name = "tQty"
        Me.tQty.Size = New System.Drawing.Size(223, 20)
        Me.tQty.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Qty Masuk :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Menu
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
        Me.tNama.ReadOnly = True
        Me.tNama.Size = New System.Drawing.Size(223, 20)
        Me.tNama.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Barang"
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
        'FormBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 465)
        Me.Controls.Add(Me.pAdd)
        Me.Controls.Add(Me.tblBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBarangMasuk"
        CType(Me.tblBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pAdd.ResumeLayout(False)
        Me.pAdd.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.btnSimpan.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblBarang As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pAdd As System.Windows.Forms.Panel
    Friend WithEvents closeUpdate As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tKode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tQty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tIdBarang As System.Windows.Forms.TextBox
End Class

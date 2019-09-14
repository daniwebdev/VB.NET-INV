Public Class BarangForm
    Public Sub loadBarang()
        tblBarang.Rows.Clear()
        Dim no As Integer = 1
        _DB("open")
        dbQuery("CALL load_barang('master')", "open")
        Do While Not record.EOF
            Dim nama,
                kode,
                stok,
                satuan,
                harga_jual,
                harga_beli, id As String
            nama = record.Fields("nama").Value
            kode = record.Fields("kode").Value
            stok = record.Fields("stok").Value
            satuan = record.Fields("satuan").Value
            harga_jual = record.Fields("harga_jual").Value
            harga_beli = record.Fields("harga_beli").Value
            id = record.Fields("id_barang").Value
            tblBarang.Rows.Add(no, nama, kode, stok, satuan, harga_jual, harga_beli, id)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub
    Public Sub loadBarangMasuk()
        tblBarangMasuk.Rows.Clear()
        Dim no As Integer = 1
        _DB("open")
        dbQuery("CALL load_barang('masuk')", "open")
        Do While Not record.EOF
            Dim nama,
                kode,
                qty,
                satuan,
                tanggal,
                id_masuk,
                id_karyawan,
                karyawan As String
            nama = record.Fields("nama").Value
            kode = record.Fields("kode_barang").Value
            tanggal = record.Fields("tanggal_masuk").Value
            qty = record.Fields("qty").Value
            karyawan = record.Fields("nama_lengkap").Value
            id_masuk = record.Fields("id_masuk").Value
            id_karyawan = record.Fields("masuk_karyawan_id").Value
            satuan = record.Fields("satuan").Value


            tblBarangMasuk.Rows.Add(no, nama, kode, qty, satuan, tanggal, karyawan, id_masuk, id_karyawan)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub
    Public Sub loadBarangKeluar()
        tblBarangKeluar.Rows.Clear()
        Dim no As Integer = 1
        _DB("open")
        dbQuery("CALL load_barang('keluar')", "open")
        Do While Not record.EOF
            Dim nama,
                kode,
                kode_trx,
                qty,
                harga,
                waktu,
                karyawan,
                nama_cust,
                satuan,
                karyawan_id,
                keluar_id As String
            nama = record.Fields("nama").Value
            kode = record.Fields("kode").Value
            kode_trx = record.Fields("kode_trx").Value.ToString
            qty = record.Fields("qty").Value
            harga = record.Fields("harga").Value.ToString
            waktu = record.Fields("timestamp").Value.ToString
            karyawan = record.Fields("nama_lengkap").Value.ToString
            nama_cust = record.Fields("nama_cust").Value.ToString
            karyawan_id = record.Fields("karyawan_id").Value.ToString
            keluar_id = record.Fields("id_keluar").Value.ToString
            satuan = record.Fields("satuan").Value.ToString

            tblBarangKeluar.Rows.Add(no, nama, kode, kode_trx, qty, satuan, waktu, nama_cust, karyawan, keluar_id, karyawan_id)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub

    Private Sub BarangForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainForm
        Me.BackColor = MainForm.BackColor
        tblBarangMasuk.Visible = False
        tblBarangKeluar.Visible = False
        tblBarangMasuk.Location = tblBarang.Location
        tblBarangKeluar.Location = tblBarang.Location

        'Load DataGrid Barang Master from MySQL Database
        loadBarang()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahBarang.Click
        BarangAdd.MdiParent = MainForm
        BarangAdd.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        barangType.Text = "masuk"
        tblBarang.Visible = False
        tblBarangMasuk.Visible = True
        tblBarangKeluar.Visible = False
        btnTambahBarang.Visible = False

        loadBarangMasuk()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        barangType.Text = "keluar"
        btnTambahBarang.Visible = False
        tblBarang.Visible = False
        tblBarangMasuk.Visible = False
        tblBarangKeluar.Visible = True

        loadBarangKeluar()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        barangType.Text = "data"
        btnTambahBarang.Visible = True
        tblBarang.Visible = True
        tblBarangMasuk.Visible = False
        tblBarangKeluar.Visible = False
    End Sub

    Private Sub tblBarang_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblBarang.CellDoubleClick
        Dim id As Integer
        Dim nama, kode, satuan, jual, beli As String

        id = tblBarang.Rows.Item(e.RowIndex).Cells("id").Value
        nama = tblBarang.Rows.Item(e.RowIndex).Cells("nama").Value
        satuan = tblBarang.Rows.Item(e.RowIndex).Cells("satuan").Value
        kode = tblBarang.Rows.Item(e.RowIndex).Cells("kode").Value
        jual = tblBarang.Rows.Item(e.RowIndex).Cells("harga_jual").Value
        beli = tblBarang.Rows.Item(e.RowIndex).Cells("harga_beli").Value

        BarangAdd.id_barang.Text = id
        BarangAdd.tSatuan.Text = satuan
        BarangAdd.tKode.Text = kode
        BarangAdd.tHBeli.Text = beli
        BarangAdd.tHJual.Text = jual
        BarangAdd.tNamaBarang.Text = nama

        BarangAdd.MdiParent = MainForm
        BarangAdd.Show()
        Me.Enabled = False
    End Sub
End Class
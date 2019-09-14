Public Class History

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

    Public Sub activity()
        _DB("open")
        dbQuery("CALL log_get('login', " & MainForm.id_karyawan.Text & ")", "open")
        Dim no As Integer = 1
        Do While Not record.EOF
            tblHistoryActivity.Rows.Add(no, record.Fields("label").Value, record.Fields("timestamp").Value, record.Fields("nama_lengkap").Value)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub
    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        activity()
        tblBarangMasuk.Visible = False
        tblHistoryActivity.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        loadBarangMasuk()
        tblBarangMasuk.Visible = True
        tblHistoryActivity.Visible = False
    End Sub
End Class
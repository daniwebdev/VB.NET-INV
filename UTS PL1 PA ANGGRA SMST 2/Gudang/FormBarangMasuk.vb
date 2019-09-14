Public Class FormBarangMasuk

    Public Sub loadBarang()
        tblBarang.Rows.Clear()
        Dim no As Integer = 1
        _DB("open")
        dbQuery("CALL load_barang('master')", "open")
        Do While Not record.EOF
            Dim nama,
                kode,
                stok,
                satuan, id As String
            nama = record.Fields("nama").Value
            kode = record.Fields("kode").Value
            stok = record.Fields("stok").Value
            satuan = record.Fields("satuan").Value
            id = record.Fields("id_barang").Value
            tblBarang.Rows.Add(no, nama, kode, stok, satuan, id)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub


    Private Sub FormBarangMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = MainForm.BackColor
        loadBarang()
    End Sub

    Private Sub tblBarang_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblBarang.CellDoubleClick
        Dim data As DataGridViewRow = tblBarang.Rows.Item(e.RowIndex)
        If e.RowIndex > -1 Then
            tNama.Text = data.Cells(1).Value
            tKode.Text = data.Cells(2).Value
            tIdBarang.Text = data.Cells(5).Value
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Not tIdBarang.Text = "" And tQty.Text > 0 Then
            _DB("open")
            dbQuery("CALL barangMasuk('" & tIdBarang.Text & "', '" & tQty.Text & "', '" & MainForm.id_karyawan.Text & "')")
            _DB("close")
            MsgBox("Berhasil!")
            tNama.Clear()
            tKode.Clear()
            tIdBarang.Clear()
            tQty.Clear()
            loadBarang()
        End If
    End Sub

    Private Sub tQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tQty.KeyPress
        Angka(e)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tNama.Clear()
        tKode.Clear()
        tIdBarang.Clear()
        tQty.Clear()
    End Sub
End Class
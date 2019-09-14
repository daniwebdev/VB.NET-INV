Public Class BarangAdd
    Public Sub generateKode()
        Dim kode As String
        _DB("open")
        dbQuery("CALL get_kd()", "open")
        If Not record.EOF Then
            kode = record.Fields("data_kd").Value
        Else
            kode = 1
        End If
        tKode.Text = "BR00" & kode + 1
        _DB("close")
    End Sub

    Private Sub tNamaBarang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNamaBarang.GotFocus
        tNamaBarang.BackColor = Color.Linen
        pNamaBarang.BackColor = Color.Linen
    End Sub

    Private Sub tnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tNamaBarang.KeyPress
        Huruf(e)
        If e.KeyChar = Chr(13) Then
            tHJual.Focus()
        End If
    End Sub

    Private Sub tbeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tHBeli.KeyPress
        Angka(e)
    End Sub

    Private Sub tjual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tHJual.KeyPress
        Angka(e)
        If e.KeyChar = Chr(13) Then
            tHBeli.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tNamaBarang.Clear()
        tHJual.Clear()
        tHBeli.Clear()
        tSatuan.Clear()
        generateKode()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BarangAdd_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        BarangForm.Enabled = True
        BarangForm.Focus()
        BarangForm.loadBarang()
        tHJual.Clear()
        tHBeli.Clear()
        tSatuan.Clear()
    End Sub

    Private Sub tNamaBarang_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tNamaBarang.LostFocus
        tNamaBarang.BackColor = Color.White
        pNamaBarang.BackColor = Color.White
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case MsgBox("Data sudah benar..?", vbYesNo + vbInformation, "Tambah Barang")
            Case vbYes
                Dim kode, nama, jual, beli, satuan As String
                Dim karyawan As Integer = MainForm.id_karyawan.Text
                kode = tKode.Text
                nama = tNamaBarang.Text.ToUpper
                jual = tHJual.Text
                beli = tHBeli.Text
                satuan = tSatuan.Text
                If Not nama = "" And Not satuan = "" Then
                    Try
                        _DB("open")
                        dbQuery("CALL add_barang('" & kode & "', '" & nama & "', '" & satuan & "', '" & jual & "', '" & beli & "', '" & karyawan & "')")
                        _DB("close")
                        Select Case MsgBox("Tambah Barang Lagi", vbYesNo + vbQuestion, "Tambah Barang")
                            Case vbNo
                                Me.Close()
                            Case vbYes
                                generateKode()
                                tNamaBarang.Clear()
                                tHJual.Clear()
                                tHBeli.Clear()
                                tSatuan.Clear()
                        End Select
                    Catch ex As Exception
                        MsgBox("Terjadi Kesalahan! DB")
                    End Try
                Else
                    MsgBox("Nama dan Satuan Wajib di isi", vbInformation, "Simpan Barang")
                End If
        End Select
    End Sub

    Private Sub BarangAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not id_barang.Text = "" Then
            pAdd.Visible = False
            pUpdate.Location = pAdd.Location
            pUpdate.Visible = True
        Else
            generateKode()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Select Case MsgBox("Apakah anda yakin..?", vbYesNo + vbQuestion, "Delete Barang")
            Case vbYes
                _DB("open")
                dbQuery("CALL delete_master('barang', '" & id_barang.Text & "')")
                _DB("close")
                Me.Close()
                BarangForm.loadBarang()
        End Select
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim id, nama, satuan, jual, beli, updateId As String
        id = id_barang.Text
        nama = tNamaBarang.Text
        satuan = tSatuan.Text
        jual = tHJual.Text
        beli = tHBeli.Text
        updateId = MainForm.id_karyawan.Text
        Try
            _DB("open")
            dbQuery("CALL update_barang('" & id & "', '" & nama & "', '" & satuan & "', '" & jual & "', '" & beli & "', '" & updateId & "')")
            _DB("close")
            MsgBox("Data telah di update!", vbInformation, "Update Barang")
            Me.Close()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan")
        End Try
    End Sub
End Class
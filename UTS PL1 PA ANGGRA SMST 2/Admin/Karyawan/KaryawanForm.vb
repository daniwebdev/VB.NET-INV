Public Class KaryawanForm
    Public Sub loadData()
        Dim no As Integer = 1
        tblKaryawan.Rows.Clear()
        _DB("open")
        dbQuery("CALL karyawan_get(NULL)", "open")
        Do While Not record.EOF
            tblKaryawan.Rows.Add(no, record.Fields("nama_lengkap").Value, record.Fields("email").Value, record.Fields("no_hp").Value, record.Fields("last_login").Value, record.Fields("id_karyawan").Value, record.Fields("username").Value, record.Fields("title").Value, record.Fields("nik").Value)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub
    Public Sub getDetail(Optional ByVal rowIndex As Integer = 0)
        dtNamaLengkap.Text = tblKaryawan.Rows.Item(rowIndex).Cells(1).Value
        dtEmail.Text = tblKaryawan.Rows.Item(rowIndex).Cells(2).Value
        dtHp.Text = tblKaryawan.Rows.Item(rowIndex).Cells(3).Value
        If Not IsDBNull(tblKaryawan.Rows.Item(rowIndex).Cells(4).Value) Then
            dtLastLogin.Text = tblKaryawan.Rows.Item(rowIndex).Cells(4).Value
        Else
            dtLastLogin.Text = "-"
        End If
        If IsDBNull(tblKaryawan.Rows.Item(rowIndex).Cells("Username").Value) Then
            dtUsername.Text = "-"
            dtJabatan.Text = "-"
            dtIsUser.Text = "Tidak"
            dtIsUser.ForeColor = Color.Red
        Else
            dtUsername.Text = tblKaryawan.Rows.Item(rowIndex).Cells("Username").Value
            dtJabatan.Text = tblKaryawan.Rows.Item(rowIndex).Cells("jabatan").Value
            dtIsUser.Text = "YA"
            dtIsUser.ForeColor = Color.Green
        End If
    End Sub
    Private Sub BarangForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
        getDetail()
        Me.BackColor = MainForm.BackColor
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BarangAdd.MdiParent = MainForm
        BarangAdd.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        titleForm.Text = "Form Tambah"
        detailPanel.Visible = False
        pAdd.Location = detailPanel.Location
        pAdd.Visible = True
        btnUpdate.Visible = False
        btnSimpan.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tblKaryawan_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblKaryawan.CellDoubleClick
        titleForm.Text = "Form Update"
        Dim Gdata As DataGridViewRow = tblKaryawan.Rows.Item(e.RowIndex)
        Dim nama, email, hp, id, nik As String
        nama = Gdata.Cells("nama").Value
        email = Gdata.Cells("email").Value
        hp = Gdata.Cells("hp").Value
        id = Gdata.Cells("id_karywan").Value
        nik = Gdata.Cells("nik").Value
        tNama.Text = nama
        tNIk.Text = nik
        tHp.Text = hp
        tEmail.Text = email
        id_update.Text = id

        detailPanel.Visible = False
        pAdd.Location = detailPanel.Location
        pAdd.Visible = True
        btnUpdate.Location = btnSimpan.Location
        btnSimpan.Visible = False
        btnUpdate.Visible = True
    End Sub

    Private Sub tblKaryawan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblKaryawan.CellClick
        If e.RowIndex > -1 Then
            getDetail(e.RowIndex)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pAdd.Visible = False
        detailPanel.Visible = True
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim nama, nik, email, hp As String
        nama = tNama.Text
        nik = tNIk.Text
        email = tEmail.Text
        hp = tHp.Text
        If Not nama = "" And Not nik = "" And Not hp = "" Then
            Try
                _DB("open")
                dbQuery("CALL karyawan_add('" & nik & "', '" & nama & "', '" & email & "', '" & hp & "')")
                _DB("close")
                MsgBox("Data telah ditambahkan!", vbInformation, "Simpan Karyawan")
                loadData()
                getDetail()

                Select Case MsgBox("Tambah Karyawan Lagi?", vbYesNo + vbInformation, "Tambah Karyawan")
                    Case vbNo
                        tNama.Clear()
                        tNIk.Clear()
                        tEmail.Clear()
                        tHp.Clear()
                        pAdd.Visible = False
                        detailPanel.Visible = True
                    Case vbYes
                        tNama.Clear()
                        tNIk.Clear()
                        tEmail.Clear()
                        tHp.Clear()
                        tNama.Focus()
                End Select
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan")
            End Try
        Else
            MsgBox("Form (Nama, NIK, HP) Wajib di isi", vbOK + vbInformation, "Simpan Karyawan")
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pAdd.Visible = False
        btnUpdate.Visible = False
        btnSimpan.Visible = True
        detailPanel.Visible = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim nama, nik, email, hp, id As String
        nama = tNama.Text
        nik = tNIk.Text
        email = tEmail.Text
        hp = tHp.Text
        id = id_update.Text

        If Not nama = "" And Not nik = "" And Not hp = "" And Not id = "" Then
            Try
                _DB("open")
                dbQuery("CALL update_karyawan('" & id & "', '" & nik & "', '" & nama & "', '" & email & "', '" & hp & "')")
                _DB("close")
                MsgBox("Data telah update!", vbInformation, "Update Karyawan")
                loadData()
                getDetail()

                tNama.Clear()
                tNIk.Clear()
                tEmail.Clear()
                tHp.Clear()
                pAdd.Visible = False
                detailPanel.Visible = True
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan")
            End Try
        Else
            MsgBox("Form (Nama, NIK, HP) Wajib di isi", vbOK + vbInformation, "Update Karyawan")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Select Case MsgBox("Apakah anda yakin?", vbYesNo + vbQuestion, "Hapus Karyawan")
            Case vbYes
                _DB("open")
                dbQuery("CALL delete_master('karyawan', '" & id_update.Text & "')")
                _DB("close")
                loadData()
                getDetail()

                tNama.Clear()
                tNIk.Clear()
                tEmail.Clear()
                tHp.Clear()
                pAdd.Visible = False
                detailPanel.Visible = True
        End Select
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tNama.Clear()
        tNIk.Clear()
        tEmail.Clear()
        tHp.Clear()
        tNama.Focus()
    End Sub
End Class
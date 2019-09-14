Public Class FormUser

    Public Sub loadUser()
        tblUser.Rows.Clear()
        _DB("open")
        dbQuery("CALL user_get()", "open")
        Dim no As Integer = 1
        Do While Not record.EOF
            tblUser.Rows.Add(no, record.Fields("username").Value, record.Fields("nama_lengkap").Value, record.Fields("title").Value, record.Fields("last_login").Value, record.Fields("userId").Value)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub

    Public Sub loadKaryawan()
        _DB("open")
        dbQuery("CALL karyawan_get(NULL)", "open")
        Dim no As Integer = 1
        Do While Not record.EOF
            tblKaryawan.Rows.Add(no, record.Fields("nama_lengkap").Value, record.Fields("nik").Value, record.Fields("id_karyawan").Value)
                record.MoveNext()
                no += 1
        Loop
        _DB("close")
    End Sub

    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = MainForm.BackColor
        loadKaryawan()
        loadUser()

        _DB("open")
        dbQuery("select * from hak_akses", "open")
        Do While Not record.EOF
            tHakAkses.Items.Add(record.Fields("title").Value)
            record.MoveNext()
        Loop
        _DB("close")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tblKaryawan.Visible = True

    End Sub

    Private Sub tblKaryawan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblKaryawan.CellClick
        If e.RowIndex > -1 Then
            Dim data As DataGridViewRow = tblKaryawan.Rows.Item(e.RowIndex)
            tNama.Text = data.Cells("namaK").Value
            tNIk.Text = data.Cells("nik").Value
            tidK.Text = data.Cells("idK").Value
            tblKaryawan.Visible = False
            tUsername.Focus()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tNama.Clear()
        tNIk.Clear()
        tidK.Clear()
        tUsername.Clear()
        tPass.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim hak_aksess As Integer
        hak_aksess = tHakAkses.SelectedIndex + 1
        If Not tUsername.Text = "" And Not tidK.Text = "" And Not hak_aksess = 0 Then
            _DB("open")
            dbQuery("CALL user_add('" & tUsername.Text & "', '" & tPass.Text & "', '" & tidK.Text & "', '" & hak_aksess & "')")
            _DB("close")
            loadUser()
            btnSimpan.Visible = True
            closeUpdate.Visible = False
            tNama.Clear()
            tNIk.Clear()
            tidK.Clear()
            tUsername.Clear()
            tPass.Clear()
            tidK.Clear()
            MsgBox("User telah di tambahkan!", vbInformation, "Tambah User")
        Else
            MsgBox("Form Harus Lengkap!", vbInformation, "Tambah User")
        End If

    End Sub

    Private Sub tblUser_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tblUser.CellDoubleClick
        Dim data As DataGridViewRow = tblUser.Rows.Item(e.RowIndex)
        btnUpdate.Location = btnSimpan.Location
        closeUpdate.Visible = True
        btnSimpan.Visible = False
        btnUpdate.Visible = True
        tIdUser.Text = data.Cells("id_user").Value
        tNama.Text = data.Cells("nama").Value
        'tNIk.Text = data.Cells("nik").Value
        tUsername.Text = data.Cells("username").Value
        tIdUser.Text = data.Cells("id_user").Value
        tHakAkses.SelectedItem = data.Cells("hak_akses").Value
        tPass.Clear()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeUpdate.Click
        closeUpdate.Visible = False
        btnSimpan.Visible = True
        btnUpdate.Visible = False
        tNama.Clear()
        tNIk.Clear()
        tidK.Clear()
        tUsername.Clear()
        tPass.Clear()
        tHakAkses.SelectedIndex = -1
        tHakAkses.Text = "- Pilih -"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Not tIdUser.Text = "" And Not tUsername.Text = "" And Not tPass.Text = "" Then
            _DB("open")
            dbQuery("CALL user_update('" & tIdUser.Text & "', '" & tUsername.Text & "', '" & tPass.Text & "', '" & tHakAkses.SelectedIndex + 1 & "')")
            _DB("close")
            MsgBox("Data Telah di Perbaharui!", vbInformation, "Update User")
            loadUser()
            btnUpdate.Visible = False
            btnSimpan.Visible = True
            closeUpdate.Visible = False
            tNama.Clear()
            tNIk.Clear()
            tidK.Clear()
            tUsername.Clear()
            tPass.Clear()
            tIdUser.Clear()
        Else
            MsgBox("Form Harus Lengkap!", vbInformation, "Update User")
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Select Case MsgBox("Anda Yakin..?", vbYesNo + vbQuestion, "Delete User")
            Case vbYes
                _DB("open")
                dbQuery("CALL delete_master('user', '" & tIdUser.Text & "')")
                _DB("close")
                loadUser()
                btnUpdate.Visible = False
                btnSimpan.Visible = True
                closeUpdate.Visible = False
                tNama.Clear()
                tNIk.Clear()
                tidK.Clear()
                tUsername.Clear()
                tPass.Clear()
                tIdUser.Clear()
                MsgBox("User Telah di Hapus!", vbOKOnly, "Delete User")
        End Select
    End Sub
End Class
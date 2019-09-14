Public Class loginForm

    Private Sub loginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Enabled = False
        LoginConfirm.Show()
        LoginConfirm.confLable.Text = "Silahkan Hubungi Bagian Administrasi"
        LoginConfirm.TopMost = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username, password, full_name, nama_akses As String
        Dim hak_akses As Integer
        username = tUsername.Text
        password = tPassword.Text

        Try
            sql.Connection = connect
            sql.CommandText = "SELECT [user].*, [karyawan].*, [hak_akses].* FROM [user]" _
                & "LEFT JOIN [karyawan] ON [user].karyawan_id = [karyawan].id " _
                & "LEFT JOIN [hak_akses] ON [user].hak_akses = [hak_akses].id " _
                & "WHERE [user].username = '" & username & "' AND [user].password = '" & password & "'"
            sql.Connection.Open()
            result = sql.ExecuteReader

            If result.Read Then
                hak_akses = result!hak_akses
                full_name = result!nama_lengkap
                nama_akses = result!judul
                MainForm.id_karyawan.Text = result!karyawan_Id
                MainForm.id_karyawan.Text = result!karyawan_Id
                MainForm.labelNamaLengkap.Text = full_name
                MainForm.labelHakAkses.Text = nama_akses

                tUsername.Clear()
                tPassword.Clear()

                MainForm.Show()
                MainForm.Focus()
                Me.Hide()
                If hak_akses = 2 Then
                    MainForm.menuKasir.Visible = False
                    MainForm.menuGudang.Visible = False
                    MainForm.menuAdmin.Visible = True
                    MainForm.cariBarang.Visible = False

                ElseIf hak_akses = 1 Then
                    MainForm.menuAdmin.Visible = False
                    MainForm.menuKasir.Visible = False
                    MainForm.menuGudang.Visible = True
                    MainForm.cariBarang.Visible = False

                    MainForm.menuGudang.Location = MainForm.menuAdmin.Location
                ElseIf hak_akses = 3 Then
                    MainForm.menuAdmin.Visible = False
                    MainForm.menuGudang.Visible = False
                    MainForm.menuKasir.Visible = True
                    MainForm.cariBarang.Visible = False

                    MainForm.menuKasir.Location = MainForm.menuAdmin.Location
                Else
                    MsgBox("Gagal")
                End If

            End If
        Catch ex As Exception
            MsgBox("Can not open connection ! " & ex.ToString())
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
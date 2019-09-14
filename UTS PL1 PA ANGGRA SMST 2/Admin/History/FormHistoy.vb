Public Class FormHistoy

    Public Sub activity()
        _DB("open")
        dbQuery("CALL log_get('login', NULL)", "open")
        Dim no As Integer = 1
        Do While Not record.EOF
            tblHistoryActivity.Rows.Add(no, record.Fields("label").Value, record.Fields("timestamp").Value, record.Fields("nama_lengkap").Value)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub
    Public Sub hargaHistory()
        _DB("open")
        dbQuery("CALL log_get('harga', NULL)", "open")
        Dim no As Integer = 1
        Do While Not record.EOF
            perubahanHarga.Rows.Add(no, record.Fields("label").Value, record.Fields("timestamp").Value, record.Fields("nama").Value, record.Fields("data").Value, record.Fields("nama_lengkap").Value)
            record.MoveNext()
            no += 1
        Loop
        _DB("close")
    End Sub


    Private Sub FormHistoy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = MainForm.BackColor
        activity()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hargaHistory()
        perubahanHarga.Visible = True
        tblHistoryActivity.Visible = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        activity()
        perubahanHarga.Visible = False
        tblHistoryActivity.Visible = True
    End Sub
End Class
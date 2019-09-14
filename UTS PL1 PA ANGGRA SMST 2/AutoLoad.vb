Imports System.Data.SqlClient
Imports System.IO

Module AutoLoad
    Public koneksi As New ADODB.Connection
    Public record As New ADODB.Recordset

    Dim ConnectString As String = "Data Source=localhost;Initial Catalog=uasdb;User ID=sa;Password=@123;Integrated Security=SSPI"

    Public connect As New SqlConnection(ConnectString)
    Public sql As New SqlCommand
    Public result As SqlDataReader

    Dim dataUser As String

    Public Sub _DB(ByVal type As String)
        Try
            If type = "open" Then
                'koneksi.Open("DSN=UTS_PL1")
                koneksi.ConnectionString = "Provider=SQLNCLI11;" _
                    & "Server=UASDB;" _
                    & "Database=uasdb;" _
                    & "Integrated Security=SSPI;" _
                    & "DataTypeCompatibility=80;" _
                    & "MARS Connection=True;"
                koneksi.Open()

            ElseIf type = "close" Then
                koneksi.Close()
            End If
        Catch ex As Exception
            MsgBox("Check Koneksi Database DSN : Error Koneksi" & vbNewLine & vbNewLine & ex.ToString)
        End Try
    End Sub

    Public Sub dbQuery(ByVal query As String, Optional ByVal type As String = "")
        If type = "open" Then
            record.Open(query, koneksi, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Else
            koneksi.Execute(query)
        End If
    End Sub

    Public Sub Angka(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub Huruf(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) AndAlso Not Char.IsControl(e.KeyChar) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub resetForm()
        For Each formCh As Form In MainForm.MdiChildren
            formCh.Close()
        Next
    End Sub
End Module

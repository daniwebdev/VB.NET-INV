Public Class MainForm
    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (ByVal hWnd As System.IntPtr, ByVal nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ' SET BACKGROUND COLOR AND REMOVE BORDER FROM MDICLIENT CONTROL
        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                c.BackColor = Color.DimGray
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width = c.Width + 1
                Exit For
            End If
        Next
        Dim ctlMDI As MdiClient
        ' Loop through all of the form's controls looking ' for the control of type MdiClient. 
        For Each ctl In Me.Controls
            Try ' Attempt to cast the control to type MdiClient. 
                ctlMDI = CType(ctl, MdiClient) ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MainConfirm.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        resetForm()
        If Not Application.OpenForms().OfType(Of BarangForm).Any Then
            BarangForm.Show()
        Else
            BarangForm.Hide()
        End If
    End Sub

    Private Sub tCariBarang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCariBarang.GotFocus
        If tCariBarang.Text = "Cari Barang ..." Then
            tCariBarang.Text = ""
        End If
    End Sub

    Private Sub tCariBarang_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tCariBarang.LostFocus
        If tCariBarang.Text = "" Then
            tCariBarang.Text = "Cari Barang ..."
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeText.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timeText.Text = Date.Now.ToString("HH:mm:ss")
        dateText.Text = Date.Now.ToString("ddd, dd MMM yyyy")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        resetForm()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        resetForm()
        KaryawanForm.MdiParent = Me
        KaryawanForm.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        resetForm()
        FormUser.MdiParent = Me
        FormUser.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        resetForm()
        FormHistoy.MdiParent = Me
        FormHistoy.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        resetForm()
        FormBarangMasuk.MdiParent = Me
        FormBarangMasuk.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        resetForm()
        History.MdiParent = Me
        History.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        resetForm()
        KasirFrom.MdiParent = Me
        KasirFrom.Show()
    End Sub
End Class


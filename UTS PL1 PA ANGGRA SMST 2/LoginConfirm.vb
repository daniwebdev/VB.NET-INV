Public Class LoginConfirm

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        hPanel.BackColor = Color.FromArgb(46, 204, 113) 'success
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hPanel.BackColor = Color.FromArgb(52, 152, 219) 'primer
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        hPanel.BackColor = Color.FromArgb(231, 76, 60) 'error
        RGB(52, 73, 94)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        hPanel.BackColor = Color.FromArgb(241, 196, 15) 'warning

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        hPanel.BackColor = Color.FromArgb(52, 73, 94) 'default
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub LoginConfirm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        loginForm.Enabled = True
    End Sub

    Private Sub LoginConfirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If type.Text = "error" Then
            hPanel.BackColor = Color.FromArgb(231, 76, 60)
        End If
    End Sub
End Class
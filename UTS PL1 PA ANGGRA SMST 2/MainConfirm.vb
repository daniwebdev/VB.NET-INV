Public Class MainConfirm

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
        MainForm.Enabled = True
        Me.Hide()
        MainForm.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MainForm.Enabled = True
        Me.Hide()
        MainForm.Focus()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        MainForm.Enabled = True
        MainForm.Hide()
        loginForm.Show()
        For Each formCh As Form In MainForm.MdiChildren
            formCh.Close()
        Next
    End Sub
End Class
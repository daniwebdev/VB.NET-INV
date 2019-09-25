<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginConfirm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.hPanel = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.confLable = New System.Windows.Forms.Label()
        Me.type = New System.Windows.Forms.TextBox()
        Me.hPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'hPanel
        '
        Me.hPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.hPanel.Controls.Add(Me.Button6)
        Me.hPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.hPanel.Location = New System.Drawing.Point(0, 0)
        Me.hPanel.Name = "hPanel"
        Me.hPanel.Size = New System.Drawing.Size(317, 45)
        Me.hPanel.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.UTS_PL1_PA_ANGGRA_SMST_2.My.Resources.Resources.cancel
        Me.Button6.Location = New System.Drawing.Point(267, -1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(49, 48)
        Me.Button6.TabIndex = 2
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 16)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "primer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 17)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "warning"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 18)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "error"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 20)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "success"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 20)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "default"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(307, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(71, 96)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Visible = False
        '
        'confLable
        '
        Me.confLable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.confLable.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confLable.Location = New System.Drawing.Point(23, 74)
        Me.confLable.Name = "confLable"
        Me.confLable.Size = New System.Drawing.Size(278, 70)
        Me.confLable.TabIndex = 2
        Me.confLable.Text = "Label1"
        Me.confLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'type
        '
        Me.type.Location = New System.Drawing.Point(13, 52)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(100, 20)
        Me.type.TabIndex = 3
        Me.type.Visible = False
        '
        'LoginConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(317, 189)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.confLable)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.hPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginConfirm"
        Me.hPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hPanel As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents confLable As System.Windows.Forms.Label
    Friend WithEvents type As System.Windows.Forms.TextBox
End Class

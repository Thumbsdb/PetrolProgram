<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        lblUsr = New Label()
        lblPsw = New Label()
        btnMenu = New Button()
        txtUsr = New TextBox()
        txtPsw = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' lblUsr
        ' 
        lblUsr.AutoSize = True
        lblUsr.Location = New Point(24, 12)
        lblUsr.Name = "lblUsr"
        lblUsr.Size = New Size(60, 15)
        lblUsr.TabIndex = 0
        lblUsr.Text = "Username"
        ' 
        ' lblPsw
        ' 
        lblPsw.AutoSize = True
        lblPsw.Location = New Point(27, 52)
        lblPsw.Name = "lblPsw"
        lblPsw.Size = New Size(57, 15)
        lblPsw.TabIndex = 1
        lblPsw.Text = "Password"
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(27, 78)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(75, 23)
        btnMenu.TabIndex = 4
        btnMenu.Text = "Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' txtUsr
        ' 
        txtUsr.Location = New Point(90, 12)
        txtUsr.Name = "txtUsr"
        txtUsr.Size = New Size(159, 23)
        txtUsr.TabIndex = 1
        ' 
        ' txtPsw
        ' 
        txtPsw.Location = New Point(90, 49)
        txtPsw.Name = "txtPsw"
        txtPsw.PasswordChar = "*"c
        txtPsw.Size = New Size(159, 23)
        txtPsw.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(108, 78)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(141, 23)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(261, 112)
        Controls.Add(btnLogin)
        Controls.Add(txtPsw)
        Controls.Add(txtUsr)
        Controls.Add(btnMenu)
        Controls.Add(lblPsw)
        Controls.Add(lblUsr)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsr As Label
    Friend WithEvents lblPsw As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents txtUsr As TextBox
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents btnLogin As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginChange
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
        lblPwdVal = New Label()
        Label3 = New Label()
        lblUsrVal = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnUptLgn = New Button()
        lblPsw = New Label()
        lblUsr = New Label()
        txtPsw = New TextBox()
        txtUsr = New TextBox()
        SuspendLayout()
        ' 
        ' lblPwdVal
        ' 
        lblPwdVal.AutoSize = True
        lblPwdVal.Location = New Point(409, 56)
        lblPwdVal.Name = "lblPwdVal"
        lblPwdVal.Size = New Size(58, 15)
        lblPwdVal.TabIndex = 30
        lblPwdVal.Text = "lblPwdVal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(338, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 29
        Label3.Text = "Password:"
        ' 
        ' lblUsrVal
        ' 
        lblUsrVal.AutoSize = True
        lblUsrVal.Location = New Point(409, 41)
        lblUsrVal.Name = "lblUsrVal"
        lblUsrVal.Size = New Size(52, 15)
        lblUsrVal.TabIndex = 28
        lblUsrVal.Text = "lblUsrVal"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(338, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 27
        Label5.Text = "Username:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(338, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(201, 15)
        Label6.TabIndex = 26
        Label6.Text = "The Current Username and Password"
        ' 
        ' btnUptLgn
        ' 
        btnUptLgn.Location = New Point(234, 48)
        btnUptLgn.Name = "btnUptLgn"
        btnUptLgn.Size = New Size(75, 23)
        btnUptLgn.TabIndex = 25
        btnUptLgn.Text = "Update"
        btnUptLgn.UseVisualStyleBackColor = True
        ' 
        ' lblPsw
        ' 
        lblPsw.AutoSize = True
        lblPsw.Location = New Point(128, 31)
        lblPsw.Name = "lblPsw"
        lblPsw.Size = New Size(57, 15)
        lblPsw.TabIndex = 24
        lblPsw.Text = "Password"
        ' 
        ' lblUsr
        ' 
        lblUsr.AutoSize = True
        lblUsr.Location = New Point(22, 31)
        lblUsr.Name = "lblUsr"
        lblUsr.Size = New Size(60, 15)
        lblUsr.TabIndex = 23
        lblUsr.Text = "Username"
        ' 
        ' txtPsw
        ' 
        txtPsw.Location = New Point(128, 49)
        txtPsw.Name = "txtPsw"
        txtPsw.Size = New Size(100, 23)
        txtPsw.TabIndex = 22
        ' 
        ' txtUsr
        ' 
        txtUsr.Location = New Point(22, 49)
        txtUsr.Name = "txtUsr"
        txtUsr.Size = New Size(100, 23)
        txtUsr.TabIndex = 21
        ' 
        ' LoginChange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(588, 92)
        Controls.Add(lblPwdVal)
        Controls.Add(Label3)
        Controls.Add(lblUsrVal)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(btnUptLgn)
        Controls.Add(lblPsw)
        Controls.Add(lblUsr)
        Controls.Add(txtPsw)
        Controls.Add(txtUsr)
        Name = "LoginChange"
        Text = "LoginChange"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPwdVal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUsrVal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUptLgn As Button
    Friend WithEvents lblPsw As Label
    Friend WithEvents lblUsr As Label
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents txtUsr As TextBox
End Class

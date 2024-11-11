<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug
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
        Label1 = New Label()
        btnLogin = New Button()
        btnMenu = New Button()
        btnSplash = New Button()
        btnLogedIn = New Button()
        btnExit = New Button()
        btnGame = New Button()
        btnHelp = New Button()
        btnPay = New Button()
        btnCeckout = New Button()
        btnDashboard = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 37)
        Label1.TabIndex = 0
        Label1.Text = "All Forums"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(12, 49)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 1
        btnLogin.Text = "btnLogin"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(12, 107)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(75, 23)
        btnMenu.TabIndex = 3
        btnMenu.Text = "btnMenu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' btnSplash
        ' 
        btnSplash.Location = New Point(12, 136)
        btnSplash.Name = "btnSplash"
        btnSplash.Size = New Size(75, 23)
        btnSplash.TabIndex = 4
        btnSplash.Text = "btnSplash"
        btnSplash.UseVisualStyleBackColor = True
        ' 
        ' btnLogedIn
        ' 
        btnLogedIn.Location = New Point(12, 78)
        btnLogedIn.Name = "btnLogedIn"
        btnLogedIn.Size = New Size(83, 23)
        btnLogedIn.TabIndex = 2
        btnLogedIn.Text = "btnLogedIn"
        btnLogedIn.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(376, 415)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 100
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnGame
        ' 
        btnGame.Location = New Point(12, 165)
        btnGame.Name = "btnGame"
        btnGame.Size = New Size(75, 23)
        btnGame.TabIndex = 5
        btnGame.Text = "btnGame"
        btnGame.UseVisualStyleBackColor = True
        ' 
        ' btnHelp
        ' 
        btnHelp.Location = New Point(12, 194)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(75, 23)
        btnHelp.TabIndex = 6
        btnHelp.Text = "btnHelp"
        btnHelp.UseVisualStyleBackColor = True
        ' 
        ' btnPay
        ' 
        btnPay.Location = New Point(12, 223)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(75, 23)
        btnPay.TabIndex = 7
        btnPay.Text = "btnPay"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' btnCeckout
        ' 
        btnCeckout.Location = New Point(12, 252)
        btnCeckout.Name = "btnCeckout"
        btnCeckout.Size = New Size(83, 23)
        btnCeckout.TabIndex = 8
        btnCeckout.Text = "btnCeckout"
        btnCeckout.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(12, 281)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(90, 23)
        btnDashboard.TabIndex = 9
        btnDashboard.Text = "btnDashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Debug
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 450)
        Controls.Add(btnDashboard)
        Controls.Add(btnCeckout)
        Controls.Add(btnPay)
        Controls.Add(btnHelp)
        Controls.Add(btnGame)
        Controls.Add(btnExit)
        Controls.Add(btnLogedIn)
        Controls.Add(btnSplash)
        Controls.Add(btnMenu)
        Controls.Add(btnLogin)
        Controls.Add(Label1)
        Name = "Debug"
        Text = "Debug"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnSplash As Button
    Friend WithEvents btnLogedIn As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGame As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents btnCeckout As Button
    Friend WithEvents btnDashboard As Button
End Class

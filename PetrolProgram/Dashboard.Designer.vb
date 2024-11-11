<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        txtPtl = New TextBox()
        txtDsl = New TextBox()
        lblPtl = New Label()
        lblDsl = New Label()
        btnMenu = New Button()
        lblPsw = New Label()
        lblUsr = New Label()
        txtPsw = New TextBox()
        txtUsr = New TextBox()
        btnUptFul = New Button()
        btnUptLgn = New Button()
        Label1 = New Label()
        lbl = New Label()
        lblPtlCst = New Label()
        lbl2 = New Label()
        lblDslCst = New Label()
        SuspendLayout()
        ' 
        ' txtPtl
        ' 
        txtPtl.Location = New Point(12, 27)
        txtPtl.Name = "txtPtl"
        txtPtl.Size = New Size(100, 23)
        txtPtl.TabIndex = 0
        ' 
        ' txtDsl
        ' 
        txtDsl.Location = New Point(118, 27)
        txtDsl.Name = "txtDsl"
        txtDsl.Size = New Size(100, 23)
        txtDsl.TabIndex = 1
        ' 
        ' lblPtl
        ' 
        lblPtl.AutoSize = True
        lblPtl.Location = New Point(12, 9)
        lblPtl.Name = "lblPtl"
        lblPtl.Size = New Size(65, 15)
        lblPtl.TabIndex = 2
        lblPtl.Text = "Petrol Cost"
        ' 
        ' lblDsl
        ' 
        lblDsl.AutoSize = True
        lblDsl.Location = New Point(118, 9)
        lblDsl.Name = "lblDsl"
        lblDsl.Size = New Size(65, 15)
        lblDsl.TabIndex = 3
        lblDsl.Text = "Diesel Cost"
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(12, 78)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(75, 23)
        btnMenu.TabIndex = 4
        btnMenu.Text = "Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' lblPsw
        ' 
        lblPsw.AutoSize = True
        lblPsw.Location = New Point(118, 125)
        lblPsw.Name = "lblPsw"
        lblPsw.Size = New Size(57, 15)
        lblPsw.TabIndex = 8
        lblPsw.Text = "Password"
        ' 
        ' lblUsr
        ' 
        lblUsr.AutoSize = True
        lblUsr.Location = New Point(12, 125)
        lblUsr.Name = "lblUsr"
        lblUsr.Size = New Size(60, 15)
        lblUsr.TabIndex = 7
        lblUsr.Text = "Username"
        ' 
        ' txtPsw
        ' 
        txtPsw.Location = New Point(118, 143)
        txtPsw.Name = "txtPsw"
        txtPsw.Size = New Size(100, 23)
        txtPsw.TabIndex = 6
        ' 
        ' txtUsr
        ' 
        txtUsr.Location = New Point(12, 143)
        txtUsr.Name = "txtUsr"
        txtUsr.Size = New Size(100, 23)
        txtUsr.TabIndex = 5
        ' 
        ' btnUptFul
        ' 
        btnUptFul.Location = New Point(224, 27)
        btnUptFul.Name = "btnUptFul"
        btnUptFul.Size = New Size(75, 23)
        btnUptFul.TabIndex = 9
        btnUptFul.Text = "Update"
        btnUptFul.UseVisualStyleBackColor = True
        ' 
        ' btnUptLgn
        ' 
        btnUptLgn.Location = New Point(224, 142)
        btnUptLgn.Name = "btnUptLgn"
        btnUptLgn.Size = New Size(75, 23)
        btnUptLgn.TabIndex = 10
        btnUptLgn.Text = "Update"
        btnUptLgn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(325, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 15)
        Label1.TabIndex = 11
        Label1.Text = "The Current Price of Petrol and Diesel"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(325, 31)
        lbl.Name = "lbl"
        lbl.Size = New Size(65, 15)
        lbl.TabIndex = 12
        lbl.Text = "Petrol Cost"
        ' 
        ' lblPtlCst
        ' 
        lblPtlCst.AutoSize = True
        lblPtlCst.Location = New Point(396, 31)
        lblPtlCst.Name = "lblPtlCst"
        lblPtlCst.Size = New Size(41, 15)
        lblPtlCst.TabIndex = 13
        lblPtlCst.Text = "Label3"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Location = New Point(325, 46)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(65, 15)
        lbl2.TabIndex = 14
        lbl2.Text = "Diesel Cost"
        ' 
        ' lblDslCst
        ' 
        lblDslCst.AutoSize = True
        lblDslCst.Location = New Point(396, 46)
        lblDslCst.Name = "lblDslCst"
        lblDslCst.Size = New Size(41, 15)
        lblDslCst.TabIndex = 15
        lblDslCst.Text = "Label5"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 189)
        Controls.Add(lblDslCst)
        Controls.Add(lbl2)
        Controls.Add(lblPtlCst)
        Controls.Add(lbl)
        Controls.Add(Label1)
        Controls.Add(btnUptLgn)
        Controls.Add(btnUptFul)
        Controls.Add(lblPsw)
        Controls.Add(lblUsr)
        Controls.Add(txtPsw)
        Controls.Add(txtUsr)
        Controls.Add(btnMenu)
        Controls.Add(lblDsl)
        Controls.Add(lblPtl)
        Controls.Add(txtDsl)
        Controls.Add(txtPtl)
        Name = "Dashboard"
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPtl As TextBox
    Friend WithEvents txtDsl As TextBox
    Friend WithEvents lblPtl As Label
    Friend WithEvents lblDsl As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblPsw As Label
    Friend WithEvents lblUsr As Label
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents txtUsr As TextBox
    Friend WithEvents btnUptFul As Button
    Friend WithEvents btnUptLgn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblPtlCst As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblDslCst As Label
End Class

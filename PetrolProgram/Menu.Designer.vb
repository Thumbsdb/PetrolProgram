<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        btnExt = New Button()
        btnLgn = New Button()
        btnStr = New Button()
        btnOpt = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExt
        ' 
        btnExt.Font = New Font("Segoe UI", 18.0F)
        btnExt.Location = New Point(12, 205)
        btnExt.Name = "btnExt"
        btnExt.Size = New Size(96, 45)
        btnExt.TabIndex = 4
        btnExt.Text = "Exit"
        btnExt.UseVisualStyleBackColor = True
        ' 
        ' btnLgn
        ' 
        btnLgn.Font = New Font("Segoe UI", 18.0F)
        btnLgn.Location = New Point(12, 136)
        btnLgn.Name = "btnLgn"
        btnLgn.Size = New Size(96, 45)
        btnLgn.TabIndex = 3
        btnLgn.Text = "Login"
        btnLgn.UseVisualStyleBackColor = True
        ' 
        ' btnStr
        ' 
        btnStr.Font = New Font("Segoe UI", 18.0F)
        btnStr.Location = New Point(12, 37)
        btnStr.Name = "btnStr"
        btnStr.Size = New Size(96, 45)
        btnStr.TabIndex = 1
        btnStr.Text = "Start"
        btnStr.UseVisualStyleBackColor = True
        ' 
        ' btnOpt
        ' 
        btnOpt.Font = New Font("Segoe UI", 18.0F)
        btnOpt.Location = New Point(12, 85)
        btnOpt.Name = "btnOpt"
        btnOpt.Size = New Size(96, 45)
        btnOpt.TabIndex = 2
        btnOpt.Text = "Help"
        btnOpt.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.istockphoto_1421951888_612x612
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(114, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(321, 213)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 5
        Label1.Text = "*Company Name"
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(447, 254)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnOpt)
        Controls.Add(btnStr)
        Controls.Add(btnLgn)
        Controls.Add(btnExt)
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExt As Button
    Friend WithEvents btnLgn As Button
    Friend WithEvents btnStr As Button
    Friend WithEvents btnOpt As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class

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
        lblTitle = New Label()
        btnDebug = New Button()
        SuspendLayout()
        ' 
        ' btnExt
        ' 
        btnExt.Location = New Point(12, 155)
        btnExt.Name = "btnExt"
        btnExt.Size = New Size(75, 23)
        btnExt.TabIndex = 4
        btnExt.Text = "Exit"
        btnExt.UseVisualStyleBackColor = True
        ' 
        ' btnLgn
        ' 
        btnLgn.Location = New Point(12, 126)
        btnLgn.Name = "btnLgn"
        btnLgn.Size = New Size(75, 23)
        btnLgn.TabIndex = 3
        btnLgn.Text = "Login"
        btnLgn.UseVisualStyleBackColor = True
        ' 
        ' btnStr
        ' 
        btnStr.FlatStyle = FlatStyle.Popup
        btnStr.Font = New Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStr.Location = New Point(12, 43)
        btnStr.Name = "btnStr"
        btnStr.Size = New Size(113, 48)
        btnStr.TabIndex = 1
        btnStr.Text = "Start"
        btnStr.UseVisualStyleBackColor = True
        ' 
        ' btnOpt
        ' 
        btnOpt.Location = New Point(12, 97)
        btnOpt.Name = "btnOpt"
        btnOpt.Size = New Size(75, 23)
        btnOpt.TabIndex = 2
        btnOpt.Text = "Options"
        btnOpt.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(319, 76)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(107, 15)
        lblTitle.TabIndex = 4
        lblTitle.Text = "Petrol Pump Game"
        ' 
        ' btnDebug
        ' 
        btnDebug.Location = New Point(12, 192)
        btnDebug.Name = "btnDebug"
        btnDebug.Size = New Size(75, 23)
        btnDebug.TabIndex = 5
        btnDebug.Text = "Debug"
        btnDebug.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(525, 411)
        Controls.Add(btnDebug)
        Controls.Add(lblTitle)
        Controls.Add(btnOpt)
        Controls.Add(btnStr)
        Controls.Add(btnLgn)
        Controls.Add(btnExt)
        Name = "Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExt As Button
    Friend WithEvents btnLgn As Button
    Friend WithEvents btnStr As Button
    Friend WithEvents btnOpt As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDebug As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        components = New ComponentModel.Container()
        btnMnu = New Button()
        btnFul = New Button()
        btnCut = New Button()
        lblFul = New Label()
        lblCst = New Label()
        lblDsl = New Label()
        lblPtl = New Label()
        Timer1 = New Timer(components)
        lblDslNum = New Label()
        lblPtlNum = New Label()
        lblFulNum = New Label()
        lblCstNum = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        SuspendLayout()
        ' 
        ' btnMnu
        ' 
        btnMnu.Location = New Point(92, 146)
        btnMnu.Name = "btnMnu"
        btnMnu.Size = New Size(75, 23)
        btnMnu.TabIndex = 0
        btnMnu.Text = "Menu"
        btnMnu.UseVisualStyleBackColor = True
        ' 
        ' btnFul
        ' 
        btnFul.Location = New Point(92, 106)
        btnFul.Name = "btnFul"
        btnFul.Size = New Size(93, 23)
        btnFul.TabIndex = 1
        btnFul.Text = "Start Fueling"
        btnFul.UseVisualStyleBackColor = True
        ' 
        ' btnCut
        ' 
        btnCut.Location = New Point(265, 106)
        btnCut.Name = "btnCut"
        btnCut.Size = New Size(75, 23)
        btnCut.TabIndex = 2
        btnCut.Text = "Checkout"
        btnCut.UseVisualStyleBackColor = True
        ' 
        ' lblFul
        ' 
        lblFul.AutoSize = True
        lblFul.Location = New Point(45, 33)
        lblFul.Name = "lblFul"
        lblFul.Size = New Size(29, 15)
        lblFul.TabIndex = 3
        lblFul.Text = "Fuel"
        ' 
        ' lblCst
        ' 
        lblCst.AutoSize = True
        lblCst.Location = New Point(45, 65)
        lblCst.Name = "lblCst"
        lblCst.Size = New Size(31, 15)
        lblCst.TabIndex = 4
        lblCst.Text = "Cost"
        ' 
        ' lblDsl
        ' 
        lblDsl.AutoSize = True
        lblDsl.Location = New Point(202, 65)
        lblDsl.Name = "lblDsl"
        lblDsl.Size = New Size(47, 15)
        lblDsl.TabIndex = 8
        lblDsl.Text = "Diseal £"
        ' 
        ' lblPtl
        ' 
        lblPtl.AutoSize = True
        lblPtl.Location = New Point(202, 33)
        lblPtl.Name = "lblPtl"
        lblPtl.Size = New Size(47, 15)
        lblPtl.TabIndex = 7
        lblPtl.Text = "Petrol £"
        ' 
        ' lblDslNum
        ' 
        lblDslNum.AutoSize = True
        lblDslNum.Location = New Point(255, 65)
        lblDslNum.Name = "lblDslNum"
        lblDslNum.Size = New Size(63, 15)
        lblDslNum.TabIndex = 9
        lblDslNum.Text = "lblDslNum"
        ' 
        ' lblPtlNum
        ' 
        lblPtlNum.AutoSize = True
        lblPtlNum.Location = New Point(255, 33)
        lblPtlNum.Name = "lblPtlNum"
        lblPtlNum.Size = New Size(61, 15)
        lblPtlNum.TabIndex = 10
        lblPtlNum.Text = "lblPtlNum"
        ' 
        ' lblFulNum
        ' 
        lblFulNum.AutoSize = True
        lblFulNum.Location = New Point(92, 33)
        lblFulNum.Name = "lblFulNum"
        lblFulNum.Size = New Size(13, 15)
        lblFulNum.TabIndex = 11
        lblFulNum.Text = "0"
        ' 
        ' lblCstNum
        ' 
        lblCstNum.AutoSize = True
        lblCstNum.Location = New Point(92, 65)
        lblCstNum.Name = "lblCstNum"
        lblCstNum.Size = New Size(64, 15)
        lblCstNum.TabIndex = 12
        lblCstNum.Text = "lblCstNum"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(347, 65)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 19)
        RadioButton1.TabIndex = 13
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(347, 29)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(97, 19)
        RadioButton2.TabIndex = 14
        RadioButton2.TabStop = True
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Game
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(lblCstNum)
        Controls.Add(lblFulNum)
        Controls.Add(lblPtlNum)
        Controls.Add(lblDslNum)
        Controls.Add(lblDsl)
        Controls.Add(lblPtl)
        Controls.Add(lblCst)
        Controls.Add(lblFul)
        Controls.Add(btnCut)
        Controls.Add(btnFul)
        Controls.Add(btnMnu)
        Name = "Game"
        Text = "Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnMnu As Button
    Friend WithEvents btnFul As Button
    Friend WithEvents btnCut As Button
    Friend WithEvents lblFul As Label
    Friend WithEvents lblCst As Label
    Friend WithEvents lblDsl As Label
    Friend WithEvents lblPtl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDslNum As Label
    Friend WithEvents lblPtlNum As Label
    Friend WithEvents lblFulNum As Label
    Friend WithEvents lblCstNum As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class

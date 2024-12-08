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
        rdoDiesel = New RadioButton()
        rdoPetrol = New RadioButton()
        PicPump = New PictureBox()
        CType(PicPump, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnMnu
        ' 
        btnMnu.Location = New Point(169, 118)
        btnMnu.Name = "btnMnu"
        btnMnu.Size = New Size(75, 23)
        btnMnu.TabIndex = 0
        btnMnu.Text = "Menu"
        btnMnu.UseVisualStyleBackColor = True
        ' 
        ' btnFul
        ' 
        btnFul.Location = New Point(250, 118)
        btnFul.Name = "btnFul"
        btnFul.Size = New Size(111, 23)
        btnFul.TabIndex = 1
        btnFul.Text = "Start Fueling"
        btnFul.UseVisualStyleBackColor = True
        ' 
        ' btnCut
        ' 
        btnCut.Location = New Point(367, 118)
        btnCut.Name = "btnCut"
        btnCut.Size = New Size(75, 23)
        btnCut.TabIndex = 2
        btnCut.Text = "Checkout"
        btnCut.UseVisualStyleBackColor = True
        ' 
        ' lblFul
        ' 
        lblFul.AutoSize = True
        lblFul.Location = New Point(169, 12)
        lblFul.Name = "lblFul"
        lblFul.Size = New Size(29, 15)
        lblFul.TabIndex = 3
        lblFul.Text = "Fuel"
        ' 
        ' lblCst
        ' 
        lblCst.AutoSize = True
        lblCst.Location = New Point(169, 44)
        lblCst.Name = "lblCst"
        lblCst.Size = New Size(31, 15)
        lblCst.TabIndex = 4
        lblCst.Text = "Cost"
        ' 
        ' lblDsl
        ' 
        lblDsl.AutoSize = True
        lblDsl.Location = New Point(326, 44)
        lblDsl.Name = "lblDsl"
        lblDsl.Size = New Size(38, 15)
        lblDsl.TabIndex = 8
        lblDsl.Text = "Diesel"
        ' 
        ' lblPtl
        ' 
        lblPtl.AutoSize = True
        lblPtl.Location = New Point(326, 12)
        lblPtl.Name = "lblPtl"
        lblPtl.Size = New Size(38, 15)
        lblPtl.TabIndex = 7
        lblPtl.Text = "Petrol"
        ' 
        ' lblDslNum
        ' 
        lblDslNum.AutoSize = True
        lblDslNum.Location = New Point(379, 44)
        lblDslNum.Name = "lblDslNum"
        lblDslNum.Size = New Size(63, 15)
        lblDslNum.TabIndex = 9
        lblDslNum.Text = "lblDslNum"
        ' 
        ' lblPtlNum
        ' 
        lblPtlNum.AutoSize = True
        lblPtlNum.Location = New Point(379, 12)
        lblPtlNum.Name = "lblPtlNum"
        lblPtlNum.Size = New Size(61, 15)
        lblPtlNum.TabIndex = 10
        lblPtlNum.Text = "lblPtlNum"
        ' 
        ' lblFulNum
        ' 
        lblFulNum.AutoSize = True
        lblFulNum.Location = New Point(216, 12)
        lblFulNum.Name = "lblFulNum"
        lblFulNum.Size = New Size(27, 15)
        lblFulNum.TabIndex = 11
        lblFulNum.Text = "0 /L"
        ' 
        ' lblCstNum
        ' 
        lblCstNum.AutoSize = True
        lblCstNum.Location = New Point(216, 44)
        lblCstNum.Name = "lblCstNum"
        lblCstNum.Size = New Size(19, 15)
        lblCstNum.TabIndex = 12
        lblCstNum.Text = "£0"
        ' 
        ' rdoDiesel
        ' 
        rdoDiesel.AutoSize = True
        rdoDiesel.Location = New Point(335, 82)
        rdoDiesel.Name = "rdoDiesel"
        rdoDiesel.Size = New Size(105, 19)
        rdoDiesel.TabIndex = 13
        rdoDiesel.TabStop = True
        rdoDiesel.Text = "Click For Diesel"
        rdoDiesel.UseVisualStyleBackColor = True
        ' 
        ' rdoPetrol
        ' 
        rdoPetrol.AutoSize = True
        rdoPetrol.Location = New Point(169, 82)
        rdoPetrol.Name = "rdoPetrol"
        rdoPetrol.Size = New Size(105, 19)
        rdoPetrol.TabIndex = 14
        rdoPetrol.TabStop = True
        rdoPetrol.Text = "Click For Petrol"
        rdoPetrol.UseVisualStyleBackColor = True
        ' 
        ' PicPump
        ' 
        PicPump.BackgroundImage = My.Resources.Resources.gas_pump_3971793_1920
        PicPump.BackgroundImageLayout = ImageLayout.Zoom
        PicPump.Image = My.Resources.Resources.gas_pump_3971793_1920
        PicPump.Location = New Point(12, 12)
        PicPump.Name = "PicPump"
        PicPump.Size = New Size(139, 137)
        PicPump.TabIndex = 15
        PicPump.TabStop = False
        ' 
        ' Game
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(458, 157)
        Controls.Add(PicPump)
        Controls.Add(rdoPetrol)
        Controls.Add(rdoDiesel)
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
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game"
        CType(PicPump, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents rdoDiesel As RadioButton
    Friend WithEvents rdoPetrol As RadioButton
    Friend WithEvents PicPump As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuelChange
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
        lblDslCst = New Label()
        lbl2 = New Label()
        lblPtlCst = New Label()
        lbl = New Label()
        Label1 = New Label()
        btnUptFul = New Button()
        lblDsl = New Label()
        lblPtl = New Label()
        txtDsl = New TextBox()
        txtPtl = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lblDslCst
        ' 
        lblDslCst.AutoSize = True
        lblDslCst.Location = New Point(286, 64)
        lblDslCst.Name = "lblDslCst"
        lblDslCst.Size = New Size(53, 15)
        lblDslCst.TabIndex = 25
        lblDslCst.Text = "lblDslCst"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Location = New Point(214, 64)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(65, 15)
        lbl2.TabIndex = 24
        lbl2.Text = "Diesel Cost"
        ' 
        ' lblPtlCst
        ' 
        lblPtlCst.AutoSize = True
        lblPtlCst.Location = New Point(285, 33)
        lblPtlCst.Name = "lblPtlCst"
        lblPtlCst.Size = New Size(54, 15)
        lblPtlCst.TabIndex = 23
        lblPtlCst.Text = " lblPtlCst"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(214, 33)
        lbl.Name = "lbl"
        lbl.Size = New Size(65, 15)
        lbl.TabIndex = 22
        lbl.Text = "Petrol Cost"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(214, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 15)
        Label1.TabIndex = 21
        Label1.Text = "The Current Price of Petrol and Diesel"
        ' 
        ' btnUptFul
        ' 
        btnUptFul.Location = New Point(19, 90)
        btnUptFul.Name = "btnUptFul"
        btnUptFul.Size = New Size(75, 23)
        btnUptFul.TabIndex = 20
        btnUptFul.Text = "Update"
        btnUptFul.UseVisualStyleBackColor = True
        ' 
        ' lblDsl
        ' 
        lblDsl.AutoSize = True
        lblDsl.Location = New Point(19, 64)
        lblDsl.Name = "lblDsl"
        lblDsl.Size = New Size(65, 15)
        lblDsl.TabIndex = 19
        lblDsl.Text = "Diesel Cost"
        ' 
        ' lblPtl
        ' 
        lblPtl.AutoSize = True
        lblPtl.Location = New Point(19, 33)
        lblPtl.Name = "lblPtl"
        lblPtl.Size = New Size(65, 15)
        lblPtl.TabIndex = 18
        lblPtl.Text = "Petrol Cost"
        ' 
        ' txtDsl
        ' 
        txtDsl.Location = New Point(90, 61)
        txtDsl.Name = "txtDsl"
        txtDsl.Size = New Size(100, 23)
        txtDsl.TabIndex = 17
        ' 
        ' txtPtl
        ' 
        txtPtl.Location = New Point(90, 33)
        txtPtl.Name = "txtPtl"
        txtPtl.Size = New Size(100, 23)
        txtPtl.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 26
        Label2.Text = "Fuel price changer"
        ' 
        ' FuelChange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(428, 125)
        Controls.Add(Label2)
        Controls.Add(lblDslCst)
        Controls.Add(lbl2)
        Controls.Add(lblPtlCst)
        Controls.Add(lbl)
        Controls.Add(Label1)
        Controls.Add(btnUptFul)
        Controls.Add(lblDsl)
        Controls.Add(lblPtl)
        Controls.Add(txtDsl)
        Controls.Add(txtPtl)
        Name = "FuelChange"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDslCst As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblPtlCst As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUptFul As Button
    Friend WithEvents lblDsl As Label
    Friend WithEvents lblPtl As Label
    Friend WithEvents txtDsl As TextBox
    Friend WithEvents txtPtl As TextBox
    Friend WithEvents Label2 As Label
End Class

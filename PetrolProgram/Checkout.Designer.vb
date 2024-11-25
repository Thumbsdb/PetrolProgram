<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Label2 = New Label()
        lblLtrNum = New Label()
        lblFulNum = New Label()
        btnMnu = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 0
        Label1.Text = "Fuel Cost "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 1
        Label2.Text = "Liters"
        ' 
        ' lblLtrNum
        ' 
        lblLtrNum.AutoSize = True
        lblLtrNum.Location = New Point(94, 21)
        lblLtrNum.Name = "lblLtrNum"
        lblLtrNum.Size = New Size(61, 15)
        lblLtrNum.TabIndex = 2
        lblLtrNum.Text = "lblLtrNum"
        ' 
        ' lblFulNum
        ' 
        lblFulNum.AutoSize = True
        lblFulNum.Location = New Point(94, 52)
        lblFulNum.Name = "lblFulNum"
        lblFulNum.Size = New Size(63, 15)
        lblFulNum.TabIndex = 3
        lblFulNum.Text = "lblFulNum"
        ' 
        ' btnMnu
        ' 
        btnMnu.Location = New Point(17, 77)
        btnMnu.Name = "btnMnu"
        btnMnu.Size = New Size(75, 23)
        btnMnu.TabIndex = 4
        btnMnu.Text = "Menu"
        btnMnu.UseVisualStyleBackColor = True
        ' 
        ' Checkout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnMnu)
        Controls.Add(lblFulNum)
        Controls.Add(lblLtrNum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Checkout"
        Text = "Checkout"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLtrNum As Label
    Friend WithEvents lblFulNum As Label
    Friend WithEvents btnMnu As Button
End Class

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
        btnMenu = New Button()
        btnFulChge = New Button()
        btnLgnChge = New Button()
        btnRpt = New Button()
        SuspendLayout()
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(12, 112)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(93, 24)
        btnMenu.TabIndex = 4
        btnMenu.Text = "Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' btnFulChge
        ' 
        btnFulChge.Location = New Point(12, 12)
        btnFulChge.Name = "btnFulChge"
        btnFulChge.Size = New Size(93, 26)
        btnFulChge.TabIndex = 21
        btnFulChge.Text = "Fuel Change"
        btnFulChge.UseVisualStyleBackColor = True
        ' 
        ' btnLgnChge
        ' 
        btnLgnChge.Location = New Point(12, 41)
        btnLgnChge.Name = "btnLgnChge"
        btnLgnChge.Size = New Size(93, 26)
        btnLgnChge.TabIndex = 22
        btnLgnChge.Text = "Login Change"
        btnLgnChge.UseVisualStyleBackColor = True
        ' 
        ' btnRpt
        ' 
        btnRpt.Location = New Point(12, 69)
        btnRpt.Name = "btnRpt"
        btnRpt.Size = New Size(93, 26)
        btnRpt.TabIndex = 23
        btnRpt.Text = "Reports"
        btnRpt.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(120, 146)
        Controls.Add(btnRpt)
        Controls.Add(btnLgnChge)
        Controls.Add(btnFulChge)
        Controls.Add(btnMenu)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnFulChge As Button
    Friend WithEvents btnLgnChge As Button
    Friend WithEvents btnRpt As Button
End Class

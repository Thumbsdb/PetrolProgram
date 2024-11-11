<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogedIn
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
        btnMenu = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(132, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(457, 124)
        Label1.TabIndex = 0
        Label1.Text = "Loged In"
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(287, 347)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(75, 23)
        btnMenu.TabIndex = 1
        btnMenu.Text = "Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' LogedIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnMenu)
        Controls.Add(Label1)
        Name = "LogedIn"
        Text = "LogedIn"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMenu As Button
End Class

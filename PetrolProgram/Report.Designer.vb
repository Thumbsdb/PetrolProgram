<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        lblIncome = New Label()
        lblSolded = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 15)
        Label1.TabIndex = 0
        Label1.Text = "Today's Solded Liters:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 1
        Label2.Text = "Today's Income:"
        ' 
        ' lblIncome
        ' 
        lblIncome.AutoSize = True
        lblIncome.Location = New Point(147, 48)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(60, 15)
        lblIncome.TabIndex = 2
        lblIncome.Text = "lblIncome"
        ' 
        ' lblSolded
        ' 
        lblSolded.AutoSize = True
        lblSolded.Location = New Point(147, 18)
        lblSolded.Name = "lblSolded"
        lblSolded.Size = New Size(56, 15)
        lblSolded.TabIndex = 3
        lblSolded.Text = "lblSolded"
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(238, 95)
        Controls.Add(lblSolded)
        Controls.Add(lblIncome)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Report"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents lblSolded As Label
End Class

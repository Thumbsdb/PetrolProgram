<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        btnDebug = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Greek_Empire
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.Greek_Empire
        resources.ApplyResources(PictureBox2, "PictureBox2")
        PictureBox2.Name = "PictureBox2"
        PictureBox2.TabStop = False
        ' 
        ' btnDebug
        ' 
        resources.ApplyResources(btnDebug, "btnDebug")
        btnDebug.Name = "btnDebug"
        btnDebug.UseVisualStyleBackColor = True
        ' 
        ' SplashScreen
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        ControlBox = False
        Controls.Add(btnDebug)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SplashScreen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnDebug As Button

End Class

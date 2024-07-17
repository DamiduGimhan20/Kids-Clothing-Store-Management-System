<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
    Inherits System.Windows.Forms.Form


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


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(243, 496)
        ProgressBar1.Margin = New Padding(4, 3, 4, 3)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(531, 20)
        ProgressBar1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Uighur", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(217, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(618, 57)
        Label1.TabIndex = 1
        Label1.Text = "Kids Clothing Store Management System"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 30
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(299, 69)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(432, 381)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(377, 469)
        Label2.Name = "Label2"
        Label2.Size = New Size(298, 23)
        Label2.TabIndex = 4
        Label2.Text = "Preparing your Fashion adventure..."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(876, 518)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 23)
        Label3.TabIndex = 5
        Label3.Text = "Version 1.0.0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(320, 519)
        Label4.Name = "Label4"
        Label4.Size = New Size(394, 23)
        Label4.TabIndex = 6
        Label4.Text = "© 2024 Kids Clothing Store. All rights reserved."
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1000, 550)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreen"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
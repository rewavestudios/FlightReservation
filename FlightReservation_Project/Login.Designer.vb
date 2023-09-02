<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        PictureBox1 = New PictureBox()
        tbUsername = New TextBox()
        tbPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnSubmit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.airplane_icon
        PictureBox1.Location = New Point(245, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(516, 370)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(314, 433)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(228, 23)
        tbUsername.TabIndex = 1
        ' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(314, 489)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(228, 23)
        tbPassword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(245, 436)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(245, 492)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(593, 433)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(168, 79)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1009, 591)
        Controls.Add(btnSubmit)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbPassword)
        Controls.Add(tbUsername)
        Controls.Add(PictureBox1)
        Name = "Login"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
End Class

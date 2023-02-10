<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.LoginButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passBox = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.userBox = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ToolTipClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaGradient2Panel1
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLinePanel1)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaShadowPanel1)
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(1920, 1030)
        Me.GunaGradient2Panel1.TabIndex = 0
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.White
        Me.GunaLinePanel1.Controls.Add(Me.GunaControlBox3)
        Me.GunaLinePanel1.Controls.Add(Me.GunaControlBox2)
        Me.GunaLinePanel1.Controls.Add(Me.GunaControlBox1)
        Me.GunaLinePanel1.Controls.Add(Me.Label3)
        Me.GunaLinePanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1920, 34)
        Me.GunaLinePanel1.TabIndex = 6
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaControlBox3.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox3.IconSize = 30.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(1779, 0)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox3.Size = New System.Drawing.Size(51, 34)
        Me.GunaControlBox3.TabIndex = 60
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.GunaControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.IconSize = 30.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(1830, 0)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 34)
        Me.GunaControlBox2.TabIndex = 59
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 30.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1875, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 34)
        Me.GunaControlBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CN Fuel Management System (CNFMS)"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(31, 29)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 58
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.LoginButton)
        Me.GunaShadowPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaShadowPanel1.Controls.Add(Me.passBox)
        Me.GunaShadowPanel1.Controls.Add(Me.Label5)
        Me.GunaShadowPanel1.Controls.Add(Me.userBox)
        Me.GunaShadowPanel1.Controls.Add(Me.Label4)
        Me.GunaShadowPanel1.Controls.Add(Me.Label2)
        Me.GunaShadowPanel1.Controls.Add(Me.Label1)
        Me.GunaShadowPanel1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(725, 306)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(504, 320)
        Me.GunaShadowPanel1.TabIndex = 5
        '
        'LoginButton
        '
        Me.LoginButton.AnimationHoverSpeed = 0.07!
        Me.LoginButton.AnimationSpeed = 0.03!
        Me.LoginButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LoginButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LoginButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LoginButton.FocusedColor = System.Drawing.Color.Empty
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Image = Nothing
        Me.LoginButton.ImageOffsetX = 15
        Me.LoginButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.LoginButton.Location = New System.Drawing.Point(379, 258)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LoginButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LoginButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LoginButton.OnHoverForeColor = System.Drawing.Color.White
        Me.LoginButton.OnHoverImage = Nothing
        Me.LoginButton.OnPressedColor = System.Drawing.Color.Black
        Me.LoginButton.Size = New System.Drawing.Size(91, 39)
        Me.LoginButton.TabIndex = 63
        Me.LoginButton.Text = "Login"
        Me.LoginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'passBox
        '
        Me.passBox.BackColor = System.Drawing.Color.Transparent
        Me.passBox.BaseColor = System.Drawing.Color.White
        Me.passBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.passBox.BorderSize = 1
        Me.passBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passBox.FocusedBaseColor = System.Drawing.Color.White
        Me.passBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.passBox.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.passBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.passBox.Location = New System.Drawing.Point(32, 212)
        Me.passBox.Name = "passBox"
        Me.passBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passBox.Size = New System.Drawing.Size(438, 30)
        Me.passBox.TabIndex = 14
        Me.passBox.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password"
        '
        'userBox
        '
        Me.userBox.BackColor = System.Drawing.Color.Transparent
        Me.userBox.BaseColor = System.Drawing.Color.White
        Me.userBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.userBox.BorderSize = 1
        Me.userBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.userBox.FocusedBaseColor = System.Drawing.Color.White
        Me.userBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.userBox.FocusedForeColor = System.Drawing.Color.DimGray
        Me.userBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBox.ForeColor = System.Drawing.Color.Black
        Me.userBox.Location = New System.Drawing.Point(32, 146)
        Me.userBox.Name = "userBox"
        Me.userBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userBox.Size = New System.Drawing.Size(438, 30)
        Me.userBox.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(531, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your credentials below to proceed to the system's dashboard"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(78, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Authentication"
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'ToolTipClose
        '
        Me.ToolTipClose.AutomaticDelay = 200
        Me.ToolTipClose.Tag = "Close"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.LoginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1030)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CN Fuel Management System"
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents passBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents userBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTipClose As ToolTip
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents LoginButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
End Class

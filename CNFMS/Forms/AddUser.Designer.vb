<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.confirmPwTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.closeButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.pwTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.cotactTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.saveButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.UsernameTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.emailTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.MnameTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.LnameTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.roleTxtBox = New Guna.UI.WinForms.GunaTextBox()
        Me.FnameTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.topPanel = New Guna.UI.WinForms.GunaLinePanel()
        Me.exitButton = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLinePanel1.SuspendLayout()
        Me.topPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.White
        Me.GunaLinePanel1.Controls.Add(Me.Label10)
        Me.GunaLinePanel1.Controls.Add(Me.Label9)
        Me.GunaLinePanel1.Controls.Add(Me.Label6)
        Me.GunaLinePanel1.Controls.Add(Me.Label4)
        Me.GunaLinePanel1.Controls.Add(Me.Label3)
        Me.GunaLinePanel1.Controls.Add(Me.Label7)
        Me.GunaLinePanel1.Controls.Add(Me.Label8)
        Me.GunaLinePanel1.Controls.Add(Me.Label2)
        Me.GunaLinePanel1.Controls.Add(Me.Label1)
        Me.GunaLinePanel1.Controls.Add(Me.confirmPwTxt)
        Me.GunaLinePanel1.Controls.Add(Me.closeButton)
        Me.GunaLinePanel1.Controls.Add(Me.pwTxt)
        Me.GunaLinePanel1.Controls.Add(Me.cotactTextBox)
        Me.GunaLinePanel1.Controls.Add(Me.saveButton)
        Me.GunaLinePanel1.Controls.Add(Me.UsernameTextBox)
        Me.GunaLinePanel1.Controls.Add(Me.emailTextBox)
        Me.GunaLinePanel1.Controls.Add(Me.MnameTxt)
        Me.GunaLinePanel1.Controls.Add(Me.LnameTxt)
        Me.GunaLinePanel1.Controls.Add(Me.roleTxtBox)
        Me.GunaLinePanel1.Controls.Add(Me.FnameTxt)
        Me.GunaLinePanel1.Controls.Add(Me.Label5)
        Me.GunaLinePanel1.Controls.Add(Me.topPanel)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(992, 675)
        Me.GunaLinePanel1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(516, 491)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 17)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Confirm Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(62, 491)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 17)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "New Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(516, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Contact #"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(62, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(62, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = " Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(516, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Middle Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(62, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(516, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Role"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(62, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "First Name"
        '
        'confirmPwTxt
        '
        Me.confirmPwTxt.BackColor = System.Drawing.Color.Transparent
        Me.confirmPwTxt.BaseColor = System.Drawing.Color.White
        Me.confirmPwTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.confirmPwTxt.BorderSize = 1
        Me.confirmPwTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmPwTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.confirmPwTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.confirmPwTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.confirmPwTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPwTxt.ForeColor = System.Drawing.Color.Black
        Me.confirmPwTxt.Location = New System.Drawing.Point(520, 517)
        Me.confirmPwTxt.MaxLength = 999999
        Me.confirmPwTxt.Name = "confirmPwTxt"
        Me.confirmPwTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.confirmPwTxt.Radius = 5
        Me.confirmPwTxt.Size = New System.Drawing.Size(411, 37)
        Me.confirmPwTxt.TabIndex = 8
        Me.confirmPwTxt.TextOffsetX = 5
        Me.confirmPwTxt.UseSystemPasswordChar = True
        '
        'closeButton
        '
        Me.closeButton.AnimationHoverSpeed = 0.07!
        Me.closeButton.AnimationSpeed = 0.03!
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.BaseColor1 = System.Drawing.Color.White
        Me.closeButton.BaseColor2 = System.Drawing.Color.White
        Me.closeButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.closeButton.BorderSize = 1
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.closeButton.FocusedColor = System.Drawing.Color.Empty
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.closeButton.Image = Nothing
        Me.closeButton.ImageOffsetX = 15
        Me.closeButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.closeButton.Location = New System.Drawing.Point(707, 591)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.closeButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.closeButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.closeButton.OnHoverForeColor = System.Drawing.Color.White
        Me.closeButton.OnHoverImage = Nothing
        Me.closeButton.OnPressedColor = System.Drawing.Color.Black
        Me.closeButton.Radius = 5
        Me.closeButton.Size = New System.Drawing.Size(107, 50)
        Me.closeButton.TabIndex = 10
        Me.closeButton.Text = "Cancel"
        Me.closeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pwTxt
        '
        Me.pwTxt.BackColor = System.Drawing.Color.Transparent
        Me.pwTxt.BaseColor = System.Drawing.Color.White
        Me.pwTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pwTxt.BorderSize = 1
        Me.pwTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pwTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.pwTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pwTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.pwTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwTxt.ForeColor = System.Drawing.Color.Black
        Me.pwTxt.Location = New System.Drawing.Point(66, 517)
        Me.pwTxt.MaxLength = 999999
        Me.pwTxt.Name = "pwTxt"
        Me.pwTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.pwTxt.Radius = 5
        Me.pwTxt.Size = New System.Drawing.Size(411, 37)
        Me.pwTxt.TabIndex = 7
        Me.pwTxt.TextOffsetX = 5
        Me.pwTxt.UseSystemPasswordChar = True
        '
        'cotactTextBox
        '
        Me.cotactTextBox.BackColor = System.Drawing.Color.Transparent
        Me.cotactTextBox.BaseColor = System.Drawing.Color.White
        Me.cotactTextBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cotactTextBox.BorderSize = 1
        Me.cotactTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cotactTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.cotactTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cotactTextBox.FocusedForeColor = System.Drawing.Color.Black
        Me.cotactTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cotactTextBox.ForeColor = System.Drawing.Color.Black
        Me.cotactTextBox.Location = New System.Drawing.Point(520, 331)
        Me.cotactTextBox.MaxLength = 11
        Me.cotactTextBox.Name = "cotactTextBox"
        Me.cotactTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cotactTextBox.Radius = 5
        Me.cotactTextBox.Size = New System.Drawing.Size(411, 37)
        Me.cotactTextBox.TabIndex = 5
        Me.cotactTextBox.TextOffsetX = 5
        '
        'saveButton
        '
        Me.saveButton.AnimationHoverSpeed = 0.07!
        Me.saveButton.AnimationSpeed = 0.03!
        Me.saveButton.BackColor = System.Drawing.Color.Transparent
        Me.saveButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveButton.FocusedColor = System.Drawing.Color.Empty
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.White
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saveButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.saveButton.Location = New System.Drawing.Point(824, 591)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.saveButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.saveButton.OnHoverForeColor = System.Drawing.Color.White
        Me.saveButton.OnHoverImage = Nothing
        Me.saveButton.OnPressedColor = System.Drawing.Color.Black
        Me.saveButton.Radius = 6
        Me.saveButton.Size = New System.Drawing.Size(107, 50)
        Me.saveButton.TabIndex = 9
        Me.saveButton.Text = "Save"
        Me.saveButton.TextOffsetX = 15
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.UsernameTextBox.BaseColor = System.Drawing.Color.White
        Me.UsernameTextBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.UsernameTextBox.BorderSize = 1
        Me.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.UsernameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.UsernameTextBox.FocusedForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.Location = New System.Drawing.Point(66, 436)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.Radius = 5
        Me.UsernameTextBox.Size = New System.Drawing.Size(411, 37)
        Me.UsernameTextBox.TabIndex = 6
        Me.UsernameTextBox.TextOffsetX = 5
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.Color.Transparent
        Me.emailTextBox.BaseColor = System.Drawing.Color.White
        Me.emailTextBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.emailTextBox.BorderSize = 1
        Me.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.emailTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.emailTextBox.FocusedForeColor = System.Drawing.Color.Black
        Me.emailTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTextBox.ForeColor = System.Drawing.Color.Black
        Me.emailTextBox.Location = New System.Drawing.Point(66, 331)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailTextBox.Radius = 5
        Me.emailTextBox.Size = New System.Drawing.Size(411, 37)
        Me.emailTextBox.TabIndex = 4
        Me.emailTextBox.TextOffsetX = 5
        '
        'MnameTxt
        '
        Me.MnameTxt.BackColor = System.Drawing.Color.Transparent
        Me.MnameTxt.BaseColor = System.Drawing.Color.White
        Me.MnameTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.MnameTxt.BorderSize = 1
        Me.MnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MnameTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.MnameTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MnameTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.MnameTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnameTxt.ForeColor = System.Drawing.Color.Black
        Me.MnameTxt.Location = New System.Drawing.Point(520, 179)
        Me.MnameTxt.MaxLength = 3000
        Me.MnameTxt.Name = "MnameTxt"
        Me.MnameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MnameTxt.Radius = 5
        Me.MnameTxt.Size = New System.Drawing.Size(411, 37)
        Me.MnameTxt.TabIndex = 2
        Me.MnameTxt.TextOffsetX = 5
        '
        'LnameTxt
        '
        Me.LnameTxt.BackColor = System.Drawing.Color.Transparent
        Me.LnameTxt.BaseColor = System.Drawing.Color.White
        Me.LnameTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LnameTxt.BorderSize = 1
        Me.LnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LnameTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.LnameTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LnameTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.LnameTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameTxt.ForeColor = System.Drawing.Color.Black
        Me.LnameTxt.Location = New System.Drawing.Point(66, 256)
        Me.LnameTxt.Name = "LnameTxt"
        Me.LnameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LnameTxt.Radius = 5
        Me.LnameTxt.Size = New System.Drawing.Size(411, 37)
        Me.LnameTxt.TabIndex = 3
        Me.LnameTxt.TextOffsetX = 5
        '
        'roleTxtBox
        '
        Me.roleTxtBox.BackColor = System.Drawing.Color.Transparent
        Me.roleTxtBox.BaseColor = System.Drawing.Color.White
        Me.roleTxtBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.roleTxtBox.BorderSize = 1
        Me.roleTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.roleTxtBox.Enabled = False
        Me.roleTxtBox.FocusedBaseColor = System.Drawing.Color.White
        Me.roleTxtBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.roleTxtBox.FocusedForeColor = System.Drawing.Color.Black
        Me.roleTxtBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roleTxtBox.ForeColor = System.Drawing.Color.Black
        Me.roleTxtBox.Location = New System.Drawing.Point(520, 256)
        Me.roleTxtBox.Name = "roleTxtBox"
        Me.roleTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.roleTxtBox.Radius = 5
        Me.roleTxtBox.Size = New System.Drawing.Size(268, 37)
        Me.roleTxtBox.TabIndex = 5
        Me.roleTxtBox.Text = "ADMIN"
        Me.roleTxtBox.TextOffsetX = 5
        '
        'FnameTxt
        '
        Me.FnameTxt.BackColor = System.Drawing.Color.Transparent
        Me.FnameTxt.BaseColor = System.Drawing.Color.White
        Me.FnameTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.FnameTxt.BorderSize = 1
        Me.FnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FnameTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.FnameTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FnameTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.FnameTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FnameTxt.ForeColor = System.Drawing.Color.Black
        Me.FnameTxt.Location = New System.Drawing.Point(66, 179)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FnameTxt.Radius = 5
        Me.FnameTxt.Size = New System.Drawing.Size(411, 37)
        Me.FnameTxt.TabIndex = 1
        Me.FnameTxt.TextOffsetX = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 25)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "CREATE ACCOUNT"
        '
        'topPanel
        '
        Me.topPanel.Controls.Add(Me.exitButton)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.LineColor = System.Drawing.Color.Black
        Me.topPanel.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(992, 40)
        Me.topPanel.TabIndex = 79
        '
        'exitButton
        '
        Me.exitButton.AnimationHoverSpeed = 0.07!
        Me.exitButton.AnimationSpeed = 0.03!
        Me.exitButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.exitButton.BorderColor = System.Drawing.Color.Black
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.exitButton.FocusedColor = System.Drawing.Color.Empty
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.exitButton.ForeColor = System.Drawing.Color.White
        Me.exitButton.Image = CType(resources.GetObject("exitButton.Image"), System.Drawing.Image)
        Me.exitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.exitButton.ImageSize = New System.Drawing.Size(20, 20)
        Me.exitButton.Location = New System.Drawing.Point(916, 0)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.exitButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exitButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exitButton.OnHoverImage = Nothing
        Me.exitButton.OnPressedColor = System.Drawing.Color.Black
        Me.exitButton.Size = New System.Drawing.Size(76, 40)
        Me.exitButton.TabIndex = 65
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.topPanel
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 675)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUser"
        Me.TopMost = True
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.topPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents topPanel As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents exitButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents closeButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cotactTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents saveButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents UsernameTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents emailTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents MnameTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LnameTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents roleTxtBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents FnameTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pwTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents confirmPwTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmployee))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.topPanel = New Guna.UI.WinForms.GunaLinePanel()
        Me.exitButton = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.FnameTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.positionTxtBox = New Guna.UI.WinForms.GunaTextBox()
        Me.emailTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.addressTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.cotactTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.closeButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MnameTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LnameTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.saveButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.topPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 40)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Employee Information"
        '
        'topPanel
        '
        Me.topPanel.Controls.Add(Me.exitButton)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.LineColor = System.Drawing.Color.Black
        Me.topPanel.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(602, 40)
        Me.topPanel.TabIndex = 78
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
        Me.exitButton.Location = New System.Drawing.Point(526, 0)
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
        'FnameTxt
        '
        Me.FnameTxt.BackColor = System.Drawing.Color.Transparent
        Me.FnameTxt.BaseColor = System.Drawing.Color.White
        Me.FnameTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.FnameTxt.BorderSize = 1
        Me.FnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FnameTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.FnameTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.FnameTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.FnameTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FnameTxt.ForeColor = System.Drawing.Color.Black
        Me.FnameTxt.Location = New System.Drawing.Point(29, 145)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FnameTxt.Radius = 5
        Me.FnameTxt.Size = New System.Drawing.Size(544, 37)
        Me.FnameTxt.TabIndex = 1
        Me.FnameTxt.TextOffsetX = 5
        '
        'positionTxtBox
        '
        Me.positionTxtBox.BackColor = System.Drawing.Color.Transparent
        Me.positionTxtBox.BaseColor = System.Drawing.Color.White
        Me.positionTxtBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.positionTxtBox.BorderSize = 1
        Me.positionTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.positionTxtBox.FocusedBaseColor = System.Drawing.Color.White
        Me.positionTxtBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.positionTxtBox.FocusedForeColor = System.Drawing.Color.Black
        Me.positionTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positionTxtBox.ForeColor = System.Drawing.Color.Black
        Me.positionTxtBox.Location = New System.Drawing.Point(29, 377)
        Me.positionTxtBox.Name = "positionTxtBox"
        Me.positionTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.positionTxtBox.Radius = 5
        Me.positionTxtBox.Size = New System.Drawing.Size(544, 37)
        Me.positionTxtBox.TabIndex = 4
        Me.positionTxtBox.TextOffsetX = 5
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.Color.Transparent
        Me.emailTextBox.BaseColor = System.Drawing.Color.White
        Me.emailTextBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.emailTextBox.BorderSize = 1
        Me.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.emailTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.emailTextBox.FocusedForeColor = System.Drawing.Color.Black
        Me.emailTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTextBox.ForeColor = System.Drawing.Color.Black
        Me.emailTextBox.Location = New System.Drawing.Point(29, 454)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailTextBox.Radius = 5
        Me.emailTextBox.Size = New System.Drawing.Size(544, 37)
        Me.emailTextBox.TabIndex = 5
        Me.emailTextBox.TextOffsetX = 5
        '
        'addressTextBox
        '
        Me.addressTextBox.BackColor = System.Drawing.Color.Transparent
        Me.addressTextBox.BaseColor = System.Drawing.Color.White
        Me.addressTextBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.addressTextBox.BorderSize = 1
        Me.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.addressTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.addressTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.addressTextBox.FocusedForeColor = System.Drawing.Color.Black
        Me.addressTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.ForeColor = System.Drawing.Color.Black
        Me.addressTextBox.Location = New System.Drawing.Point(29, 533)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addressTextBox.Radius = 5
        Me.addressTextBox.Size = New System.Drawing.Size(544, 37)
        Me.addressTextBox.TabIndex = 6
        Me.addressTextBox.TextOffsetX = 5
        '
        'cotactTextBox
        '
        Me.cotactTextBox.BackColor = System.Drawing.Color.Transparent
        Me.cotactTextBox.BaseColor = System.Drawing.Color.White
        Me.cotactTextBox.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cotactTextBox.BorderSize = 1
        Me.cotactTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cotactTextBox.FocusedBaseColor = System.Drawing.Color.White
        Me.cotactTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cotactTextBox.FocusedForeColor = System.Drawing.Color.Black
        Me.cotactTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cotactTextBox.ForeColor = System.Drawing.Color.Black
        Me.cotactTextBox.Location = New System.Drawing.Point(29, 612)
        Me.cotactTextBox.MaxLength = 11
        Me.cotactTextBox.Name = "cotactTextBox"
        Me.cotactTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cotactTextBox.Radius = 5
        Me.cotactTextBox.Size = New System.Drawing.Size(544, 37)
        Me.cotactTextBox.TabIndex = 7
        Me.cotactTextBox.TextOffsetX = 5
        '
        'closeButton
        '
        Me.closeButton.AnimationHoverSpeed = 0.07!
        Me.closeButton.AnimationSpeed = 0.03!
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.BaseColor1 = System.Drawing.Color.White
        Me.closeButton.BaseColor2 = System.Drawing.Color.White
        Me.closeButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.BorderSize = 1
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.closeButton.FocusedColor = System.Drawing.Color.Empty
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.Image = Nothing
        Me.closeButton.ImageOffsetX = 15
        Me.closeButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.closeButton.Location = New System.Drawing.Point(353, 675)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.OnHoverForeColor = System.Drawing.Color.White
        Me.closeButton.OnHoverImage = Nothing
        Me.closeButton.OnPressedColor = System.Drawing.Color.Black
        Me.closeButton.Radius = 5
        Me.closeButton.Size = New System.Drawing.Size(107, 50)
        Me.closeButton.TabIndex = 9
        Me.closeButton.Text = "Cancel"
        Me.closeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Enter First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Enter Designation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Enter Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 507)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 23)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Enter Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(25, 586)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 23)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Enter Contact #"
        '
        'MnameTxt
        '
        Me.MnameTxt.BackColor = System.Drawing.Color.Transparent
        Me.MnameTxt.BaseColor = System.Drawing.Color.White
        Me.MnameTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.MnameTxt.BorderSize = 1
        Me.MnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MnameTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.MnameTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.MnameTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.MnameTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnameTxt.ForeColor = System.Drawing.Color.Black
        Me.MnameTxt.Location = New System.Drawing.Point(29, 219)
        Me.MnameTxt.MaxLength = 3000
        Me.MnameTxt.Name = "MnameTxt"
        Me.MnameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MnameTxt.Radius = 5
        Me.MnameTxt.Size = New System.Drawing.Size(544, 37)
        Me.MnameTxt.TabIndex = 2
        Me.MnameTxt.TextOffsetX = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(25, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 23)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Enter Middle Name"
        '
        'LnameTxt
        '
        Me.LnameTxt.BackColor = System.Drawing.Color.Transparent
        Me.LnameTxt.BaseColor = System.Drawing.Color.White
        Me.LnameTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.LnameTxt.BorderSize = 1
        Me.LnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LnameTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.LnameTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LnameTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.LnameTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameTxt.ForeColor = System.Drawing.Color.Black
        Me.LnameTxt.Location = New System.Drawing.Point(29, 301)
        Me.LnameTxt.Name = "LnameTxt"
        Me.LnameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LnameTxt.Radius = 5
        Me.LnameTxt.Size = New System.Drawing.Size(544, 37)
        Me.LnameTxt.TabIndex = 3
        Me.LnameTxt.TextOffsetX = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(25, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 23)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Enter Last Name"
        '
        'saveButton
        '
        Me.saveButton.AnimationHoverSpeed = 0.07!
        Me.saveButton.AnimationSpeed = 0.03!
        Me.saveButton.BackColor = System.Drawing.Color.Transparent
        Me.saveButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveButton.FocusedColor = System.Drawing.Color.Empty
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.White
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saveButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.saveButton.Location = New System.Drawing.Point(466, 675)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.saveButton.OnHoverForeColor = System.Drawing.Color.White
        Me.saveButton.OnHoverImage = Nothing
        Me.saveButton.OnPressedColor = System.Drawing.Color.Black
        Me.saveButton.Radius = 6
        Me.saveButton.Size = New System.Drawing.Size(107, 50)
        Me.saveButton.TabIndex = 8
        Me.saveButton.Text = "Save"
        Me.saveButton.TextOffsetX = 15
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 751)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.cotactTextBox)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.MnameTxt)
        Me.Controls.Add(Me.LnameTxt)
        Me.Controls.Add(Me.positionTxtBox)
        Me.Controls.Add(Me.FnameTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.topPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddEmployee"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEmployee"
        Me.TopMost = True
        Me.topPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents topPanel As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents FnameTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents positionTxtBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents emailTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents addressTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cotactTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents exitButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents closeButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents saveButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MnameTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LnameTxt As Guna.UI.WinForms.GunaTextBox
End Class

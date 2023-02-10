<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddIsland2Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddIsland2Report))
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.DateTimePickerFrom = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.timecombox = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pumpCombox = New Guna.UI.WinForms.GunaComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.closeButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.litersOutTxt3 = New Guna.UI.WinForms.GunaTextBox()
        Me.litersOutTxt2 = New Guna.UI.WinForms.GunaTextBox()
        Me.litersOutTxt1 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.saveButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.topPanel = New Guna.UI.WinForms.GunaLinePanel()
        Me.exitButton = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaLinePanel2.SuspendLayout()
        Me.topPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.Controls.Add(Me.DateTimePickerFrom)
        Me.GunaLinePanel2.Controls.Add(Me.timecombox)
        Me.GunaLinePanel2.Controls.Add(Me.Label1)
        Me.GunaLinePanel2.Controls.Add(Me.pumpCombox)
        Me.GunaLinePanel2.Controls.Add(Me.Label6)
        Me.GunaLinePanel2.Controls.Add(Me.Label2)
        Me.GunaLinePanel2.Controls.Add(Me.closeButton)
        Me.GunaLinePanel2.Controls.Add(Me.litersOutTxt3)
        Me.GunaLinePanel2.Controls.Add(Me.litersOutTxt2)
        Me.GunaLinePanel2.Controls.Add(Me.litersOutTxt1)
        Me.GunaLinePanel2.Controls.Add(Me.Label8)
        Me.GunaLinePanel2.Controls.Add(Me.Label4)
        Me.GunaLinePanel2.Controls.Add(Me.saveButton)
        Me.GunaLinePanel2.Controls.Add(Me.Label5)
        Me.GunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(0, 40)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(602, 620)
        Me.GunaLinePanel2.TabIndex = 80
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerFrom.BaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePickerFrom.CustomFormat = Nothing
        Me.DateTimePickerFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerFrom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.ForeColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(41, 191)
        Me.DateTimePickerFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateTimePickerFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateTimePickerFrom.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Radius = 5
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(306, 45)
        Me.DateTimePickerFrom.TabIndex = 89
        Me.DateTimePickerFrom.Text = "11/8/2022"
        Me.DateTimePickerFrom.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'timecombox
        '
        Me.timecombox.AllowDrop = True
        Me.timecombox.BackColor = System.Drawing.Color.Transparent
        Me.timecombox.BaseColor = System.Drawing.Color.White
        Me.timecombox.BorderColor = System.Drawing.Color.Silver
        Me.timecombox.BorderSize = 1
        Me.timecombox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.timecombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.timecombox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.timecombox.FocusedColor = System.Drawing.Color.Empty
        Me.timecombox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timecombox.ForeColor = System.Drawing.Color.Black
        Me.timecombox.FormattingEnabled = True
        Me.timecombox.IntegralHeight = False
        Me.timecombox.ItemHeight = 37
        Me.timecombox.Location = New System.Drawing.Point(353, 191)
        Me.timecombox.MaxDropDownItems = 5
        Me.timecombox.Name = "timecombox"
        Me.timecombox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.timecombox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.timecombox.Radius = 5
        Me.timecombox.Size = New System.Drawing.Size(204, 43)
        Me.timecombox.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 23)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Cut-Off Date and Time"
        '
        'pumpCombox
        '
        Me.pumpCombox.BackColor = System.Drawing.Color.Transparent
        Me.pumpCombox.BaseColor = System.Drawing.Color.White
        Me.pumpCombox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.pumpCombox.BorderSize = 1
        Me.pumpCombox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.pumpCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pumpCombox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pumpCombox.FocusedColor = System.Drawing.Color.Empty
        Me.pumpCombox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pumpCombox.ForeColor = System.Drawing.Color.Black
        Me.pumpCombox.FormattingEnabled = True
        Me.pumpCombox.ItemHeight = 37
        Me.pumpCombox.Items.AddRange(New Object() {"Pump 1", "Pump 2", "Pump 3", "Pump 4", "Pump 5 ", "Pump 6"})
        Me.pumpCombox.Location = New System.Drawing.Point(41, 82)
        Me.pumpCombox.Name = "pumpCombox"
        Me.pumpCombox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.pumpCombox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.pumpCombox.Radius = 5
        Me.pumpCombox.Size = New System.Drawing.Size(516, 43)
        Me.pumpCombox.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(41, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 23)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Liters Out (Diesel)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 23)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Liters Out (Premium)"
        '
        'closeButton
        '
        Me.closeButton.AnimationHoverSpeed = 0.07!
        Me.closeButton.AnimationSpeed = 0.03!
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.closeButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.closeButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.closeButton.FocusedColor = System.Drawing.Color.Empty
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Image = Nothing
        Me.closeButton.ImageOffsetX = 15
        Me.closeButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.closeButton.Location = New System.Drawing.Point(337, 527)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.closeButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.closeButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.closeButton.OnHoverForeColor = System.Drawing.Color.White
        Me.closeButton.OnHoverImage = Nothing
        Me.closeButton.OnPressedColor = System.Drawing.Color.Black
        Me.closeButton.Radius = 5
        Me.closeButton.Size = New System.Drawing.Size(107, 50)
        Me.closeButton.TabIndex = 82
        Me.closeButton.Text = "Cancel"
        Me.closeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'litersOutTxt3
        '
        Me.litersOutTxt3.BackColor = System.Drawing.Color.Transparent
        Me.litersOutTxt3.BaseColor = System.Drawing.Color.White
        Me.litersOutTxt3.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.litersOutTxt3.BorderSize = 1
        Me.litersOutTxt3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.litersOutTxt3.FocusedBaseColor = System.Drawing.Color.White
        Me.litersOutTxt3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.litersOutTxt3.FocusedForeColor = System.Drawing.Color.Black
        Me.litersOutTxt3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.litersOutTxt3.ForeColor = System.Drawing.Color.Black
        Me.litersOutTxt3.Location = New System.Drawing.Point(45, 451)
        Me.litersOutTxt3.Name = "litersOutTxt3"
        Me.litersOutTxt3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.litersOutTxt3.Radius = 5
        Me.litersOutTxt3.Size = New System.Drawing.Size(512, 37)
        Me.litersOutTxt3.TabIndex = 74
        Me.litersOutTxt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.litersOutTxt3.TextOffsetX = 5
        '
        'litersOutTxt2
        '
        Me.litersOutTxt2.BackColor = System.Drawing.Color.Transparent
        Me.litersOutTxt2.BaseColor = System.Drawing.Color.White
        Me.litersOutTxt2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.litersOutTxt2.BorderSize = 1
        Me.litersOutTxt2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.litersOutTxt2.FocusedBaseColor = System.Drawing.Color.White
        Me.litersOutTxt2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.litersOutTxt2.FocusedForeColor = System.Drawing.Color.Black
        Me.litersOutTxt2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.litersOutTxt2.ForeColor = System.Drawing.Color.Black
        Me.litersOutTxt2.Location = New System.Drawing.Point(45, 363)
        Me.litersOutTxt2.Name = "litersOutTxt2"
        Me.litersOutTxt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.litersOutTxt2.Radius = 5
        Me.litersOutTxt2.Size = New System.Drawing.Size(512, 37)
        Me.litersOutTxt2.TabIndex = 73
        Me.litersOutTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.litersOutTxt2.TextOffsetX = 5
        '
        'litersOutTxt1
        '
        Me.litersOutTxt1.BackColor = System.Drawing.Color.Transparent
        Me.litersOutTxt1.BaseColor = System.Drawing.Color.White
        Me.litersOutTxt1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.litersOutTxt1.BorderSize = 1
        Me.litersOutTxt1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.litersOutTxt1.FocusedBaseColor = System.Drawing.Color.White
        Me.litersOutTxt1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.litersOutTxt1.FocusedForeColor = System.Drawing.Color.Black
        Me.litersOutTxt1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.litersOutTxt1.ForeColor = System.Drawing.Color.Black
        Me.litersOutTxt1.Location = New System.Drawing.Point(45, 281)
        Me.litersOutTxt1.Name = "litersOutTxt1"
        Me.litersOutTxt1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.litersOutTxt1.Radius = 5
        Me.litersOutTxt1.Size = New System.Drawing.Size(512, 37)
        Me.litersOutTxt1.TabIndex = 72
        Me.litersOutTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.litersOutTxt1.TextOffsetX = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(41, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 23)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Pump"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 23)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Liters Out (Regular)"
        '
        'saveButton
        '
        Me.saveButton.AnimationHoverSpeed = 0.07!
        Me.saveButton.AnimationSpeed = 0.03!
        Me.saveButton.BackColor = System.Drawing.Color.Transparent
        Me.saveButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.saveButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.saveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.saveButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveButton.FocusedColor = System.Drawing.Color.Empty
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.White
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageOffsetX = 5
        Me.saveButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.saveButton.Location = New System.Drawing.Point(450, 527)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.saveButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.saveButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.saveButton.OnHoverForeColor = System.Drawing.Color.White
        Me.saveButton.OnHoverImage = Nothing
        Me.saveButton.OnPressedColor = System.Drawing.Color.Black
        Me.saveButton.Radius = 6
        Me.saveButton.Size = New System.Drawing.Size(107, 50)
        Me.saveButton.TabIndex = 68
        Me.saveButton.Text = "Save"
        Me.saveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saveButton.TextOffsetX = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 40)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ISLAND 2 REPORT"
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
        'AddIsland2Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 660)
        Me.Controls.Add(Me.GunaLinePanel2)
        Me.Controls.Add(Me.topPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddIsland2Report"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddIsland2Report"
        Me.TopMost = True
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel2.PerformLayout()
        Me.topPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents pumpCombox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents closeButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents litersOutTxt3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents litersOutTxt2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents litersOutTxt1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents saveButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label5 As Label
    Friend WithEvents topPanel As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents exitButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents DateTimePickerFrom As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents timecombox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
End Class

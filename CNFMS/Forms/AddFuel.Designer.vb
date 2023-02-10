<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddFuel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddFuel))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.quantityFuel1 = New Guna.UI.WinForms.GunaTextBox()
        Me.quantityFuel2 = New Guna.UI.WinForms.GunaTextBox()
        Me.closeButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.quantityFuel3 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.exitButton = New Guna.UI.WinForms.GunaButton()
        Me.saveButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.DateTimePickerFrom = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.timecombox = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dutyDaysTxt = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        CType(Me.dutyDaysTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Liters (Regular)"
        '
        'quantityFuel1
        '
        Me.quantityFuel1.BackColor = System.Drawing.Color.Transparent
        Me.quantityFuel1.BaseColor = System.Drawing.Color.White
        Me.quantityFuel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.quantityFuel1.BorderSize = 1
        Me.quantityFuel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quantityFuel1.FocusedBaseColor = System.Drawing.Color.White
        Me.quantityFuel1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.quantityFuel1.FocusedForeColor = System.Drawing.Color.Black
        Me.quantityFuel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityFuel1.ForeColor = System.Drawing.Color.Black
        Me.quantityFuel1.Location = New System.Drawing.Point(41, 199)
        Me.quantityFuel1.Name = "quantityFuel1"
        Me.quantityFuel1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.quantityFuel1.Size = New System.Drawing.Size(291, 35)
        Me.quantityFuel1.TabIndex = 3
        Me.quantityFuel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.quantityFuel1.TextOffsetX = 5
        '
        'quantityFuel2
        '
        Me.quantityFuel2.BackColor = System.Drawing.Color.Transparent
        Me.quantityFuel2.BaseColor = System.Drawing.Color.White
        Me.quantityFuel2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.quantityFuel2.BorderSize = 1
        Me.quantityFuel2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quantityFuel2.FocusedBaseColor = System.Drawing.Color.White
        Me.quantityFuel2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.quantityFuel2.FocusedForeColor = System.Drawing.Color.Black
        Me.quantityFuel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityFuel2.ForeColor = System.Drawing.Color.Black
        Me.quantityFuel2.Location = New System.Drawing.Point(41, 284)
        Me.quantityFuel2.Name = "quantityFuel2"
        Me.quantityFuel2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.quantityFuel2.Size = New System.Drawing.Size(291, 35)
        Me.quantityFuel2.TabIndex = 4
        Me.quantityFuel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.quantityFuel2.TextOffsetX = 5
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
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.Image = Nothing
        Me.closeButton.ImageOffsetX = 15
        Me.closeButton.ImageSize = New System.Drawing.Size(20, 20)
        Me.closeButton.Location = New System.Drawing.Point(377, 427)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.closeButton.OnHoverForeColor = System.Drawing.Color.White
        Me.closeButton.OnHoverImage = Nothing
        Me.closeButton.OnPressedColor = System.Drawing.Color.Black
        Me.closeButton.Size = New System.Drawing.Size(90, 50)
        Me.closeButton.TabIndex = 62
        Me.closeButton.Text = "Cancel"
        Me.closeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Add Fuel"
        '
        'quantityFuel3
        '
        Me.quantityFuel3.BackColor = System.Drawing.Color.Transparent
        Me.quantityFuel3.BaseColor = System.Drawing.Color.White
        Me.quantityFuel3.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.quantityFuel3.BorderSize = 1
        Me.quantityFuel3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quantityFuel3.FocusedBaseColor = System.Drawing.Color.White
        Me.quantityFuel3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.quantityFuel3.FocusedForeColor = System.Drawing.Color.Black
        Me.quantityFuel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityFuel3.ForeColor = System.Drawing.Color.Black
        Me.quantityFuel3.Location = New System.Drawing.Point(41, 361)
        Me.quantityFuel3.Name = "quantityFuel3"
        Me.quantityFuel3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.quantityFuel3.Size = New System.Drawing.Size(291, 35)
        Me.quantityFuel3.TabIndex = 5
        Me.quantityFuel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.quantityFuel3.TextOffsetX = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Liters (Premium)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Liters (Diesel)"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'exitButton
        '
        Me.exitButton.AnimationHoverSpeed = 0.07!
        Me.exitButton.AnimationSpeed = 0.03!
        Me.exitButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.exitButton.BorderColor = System.Drawing.Color.Black
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exitButton.FocusedColor = System.Drawing.Color.Empty
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.exitButton.ForeColor = System.Drawing.Color.White
        Me.exitButton.Image = CType(resources.GetObject("exitButton.Image"), System.Drawing.Image)
        Me.exitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.exitButton.ImageSize = New System.Drawing.Size(20, 20)
        Me.exitButton.Location = New System.Drawing.Point(534, -2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.exitButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exitButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exitButton.OnHoverImage = Nothing
        Me.exitButton.OnPressedColor = System.Drawing.Color.Black
        Me.exitButton.Size = New System.Drawing.Size(76, 42)
        Me.exitButton.TabIndex = 64
        '
        'saveButton
        '
        Me.saveButton.AnimationHoverSpeed = 0.07!
        Me.saveButton.AnimationSpeed = 0.03!
        Me.saveButton.BackColor = System.Drawing.Color.Transparent
        Me.saveButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.BorderSize = 1
        Me.saveButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveButton.FocusedColor = System.Drawing.Color.Empty
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.White
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saveButton.ImageOffsetX = 5
        Me.saveButton.ImageSize = New System.Drawing.Size(15, 15)
        Me.saveButton.Location = New System.Drawing.Point(473, 427)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverForeColor = System.Drawing.Color.White
        Me.saveButton.OnHoverImage = Nothing
        Me.saveButton.OnPressedColor = System.Drawing.Color.Black
        Me.saveButton.Size = New System.Drawing.Size(90, 50)
        Me.saveButton.TabIndex = 63
        Me.saveButton.Text = "Save"
        Me.saveButton.TextOffsetX = 15
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerFrom.BaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePickerFrom.CustomFormat = Nothing
        Me.DateTimePickerFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerFrom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.ForeColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(41, 123)
        Me.DateTimePickerFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateTimePickerFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateTimePickerFrom.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(291, 35)
        Me.DateTimePickerFrom.TabIndex = 92
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
        Me.timecombox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timecombox.ForeColor = System.Drawing.Color.Black
        Me.timecombox.FormattingEnabled = True
        Me.timecombox.IntegralHeight = False
        Me.timecombox.ItemHeight = 30
        Me.timecombox.Location = New System.Drawing.Point(354, 123)
        Me.timecombox.MaxDropDownItems = 5
        Me.timecombox.Name = "timecombox"
        Me.timecombox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.timecombox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.timecombox.Size = New System.Drawing.Size(204, 36)
        Me.timecombox.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Date and Time Added"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(351, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Price (Diesel)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(351, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Price (Premium)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(351, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 17)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Price (Regular)"
        '
        'dutyDaysTxt
        '
        Me.dutyDaysTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dutyDaysTxt.DecimalPlaces = 2
        Me.dutyDaysTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dutyDaysTxt.Location = New System.Drawing.Point(354, 199)
        Me.dutyDaysTxt.Name = "dutyDaysTxt"
        Me.dutyDaysTxt.Size = New System.Drawing.Size(204, 33)
        Me.dutyDaysTxt.TabIndex = 99
        Me.dutyDaysTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(354, 288)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(204, 33)
        Me.NumericUpDown1.TabIndex = 100
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(354, 365)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(204, 33)
        Me.NumericUpDown2.TabIndex = 101
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AddFuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(608, 495)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.dutyDaysTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePickerFrom)
        Me.Controls.Add(Me.timecombox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.quantityFuel3)
        Me.Controls.Add(Me.quantityFuel2)
        Me.Controls.Add(Me.quantityFuel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddFuel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddFuel"
        Me.TopMost = True
        CType(Me.dutyDaysTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents quantityFuel1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents quantityFuel2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents closeButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents saveButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label5 As Label
    Friend WithEvents quantityFuel3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents exitButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents DateTimePickerFrom As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents timecombox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents dutyDaysTxt As NumericUpDown
End Class

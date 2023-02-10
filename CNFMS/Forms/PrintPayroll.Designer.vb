<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintPayroll))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.DateToPicker = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.TopPanel = New Guna.UI.WinForms.GunaPanel()
        Me.exitButton = New Guna.UI.WinForms.GunaButton()
        Me.DateFromPicker = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.saveButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GunaPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(464, 241)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.DateToPicker)
        Me.GunaPanel1.Controls.Add(Me.TopPanel)
        Me.GunaPanel1.Controls.Add(Me.DateFromPicker)
        Me.GunaPanel1.Controls.Add(Me.Label17)
        Me.GunaPanel1.Controls.Add(Me.Label14)
        Me.GunaPanel1.Controls.Add(Me.Label16)
        Me.GunaPanel1.Controls.Add(Me.saveButton)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(3, 3)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(458, 235)
        Me.GunaPanel1.TabIndex = 1
        '
        'DateToPicker
        '
        Me.DateToPicker.BackColor = System.Drawing.Color.Transparent
        Me.DateToPicker.BaseColor = System.Drawing.Color.White
        Me.DateToPicker.BorderColor = System.Drawing.Color.Silver
        Me.DateToPicker.CustomFormat = "0"
        Me.DateToPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateToPicker.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateToPicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToPicker.ForeColor = System.Drawing.Color.Black
        Me.DateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateToPicker.Location = New System.Drawing.Point(261, 114)
        Me.DateToPicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateToPicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateToPicker.Name = "DateToPicker"
        Me.DateToPicker.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateToPicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateToPicker.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateToPicker.OnPressedColor = System.Drawing.Color.Black
        Me.DateToPicker.Radius = 5
        Me.DateToPicker.Size = New System.Drawing.Size(142, 37)
        Me.DateToPicker.TabIndex = 105
        Me.DateToPicker.Text = "11/8/2022"
        Me.DateToPicker.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.exitButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(458, 37)
        Me.TopPanel.TabIndex = 130
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
        Me.exitButton.Location = New System.Drawing.Point(399, 0)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.exitButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exitButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exitButton.OnHoverImage = Nothing
        Me.exitButton.OnPressedColor = System.Drawing.Color.Black
        Me.exitButton.Size = New System.Drawing.Size(59, 37)
        Me.exitButton.TabIndex = 4
        '
        'DateFromPicker
        '
        Me.DateFromPicker.BackColor = System.Drawing.Color.Transparent
        Me.DateFromPicker.BaseColor = System.Drawing.Color.White
        Me.DateFromPicker.BorderColor = System.Drawing.Color.Silver
        Me.DateFromPicker.CustomFormat = "0"
        Me.DateFromPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateFromPicker.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateFromPicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFromPicker.ForeColor = System.Drawing.Color.Black
        Me.DateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFromPicker.Location = New System.Drawing.Point(84, 114)
        Me.DateFromPicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateFromPicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateFromPicker.Name = "DateFromPicker"
        Me.DateFromPicker.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateFromPicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateFromPicker.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateFromPicker.OnPressedColor = System.Drawing.Color.Black
        Me.DateFromPicker.Radius = 5
        Me.DateFromPicker.Size = New System.Drawing.Size(141, 37)
        Me.DateFromPicker.TabIndex = 104
        Me.DateFromPicker.Text = "11/8/2022"
        Me.DateFromPicker.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(258, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Period To"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(-4, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(458, 33)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Select Period"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(81, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 17)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Period From"
        '
        'saveButton
        '
        Me.saveButton.AnimationHoverSpeed = 0.07!
        Me.saveButton.AnimationSpeed = 0.03!
        Me.saveButton.BackColor = System.Drawing.Color.Transparent
        Me.saveButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.saveButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.saveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.saveButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveButton.FocusedColor = System.Drawing.Color.Empty
        Me.saveButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.White
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saveButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.saveButton.Location = New System.Drawing.Point(146, 171)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.saveButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.saveButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.saveButton.OnHoverForeColor = System.Drawing.Color.White
        Me.saveButton.OnHoverImage = Nothing
        Me.saveButton.OnPressedColor = System.Drawing.Color.Black
        Me.saveButton.Radius = 6
        Me.saveButton.Size = New System.Drawing.Size(157, 39)
        Me.saveButton.TabIndex = 128
        Me.saveButton.Text = "Procced to Print"
        Me.saveButton.TextOffsetX = 10
        '
        'PrintPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 241)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrintPayroll"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintPayroll"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents TopPanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents exitButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label14 As Label
    Friend WithEvents saveButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents DateToPicker As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents DateFromPicker As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
End Class

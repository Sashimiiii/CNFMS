<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPayrollPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPayrollPanel))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.basicDailyTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.sssTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.phicTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.hdmTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.OTTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.employmentIDTxt = New System.Windows.Forms.Label()
        Me.nameFullTxt = New System.Windows.Forms.Label()
        Me.jobTxt = New System.Windows.Forms.Label()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.dutyDaysTxt = New System.Windows.Forms.NumericUpDown()
        Me.ComputeButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.saveButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.DateToPicker = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.DateFromPicker = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TotalNetPay = New System.Windows.Forms.Label()
        Me.TotalDeducTxt = New System.Windows.Forms.Label()
        Me.TotalPayTxt = New System.Windows.Forms.Label()
        Me.basicPayTxt = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RegularHolidayTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.specialHolidayTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.dutyDaysTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 33)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "/ PAYROLL "
        '
        'basicDailyTxt
        '
        Me.basicDailyTxt.BackColor = System.Drawing.Color.Transparent
        Me.basicDailyTxt.BaseColor = System.Drawing.Color.White
        Me.basicDailyTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.basicDailyTxt.BorderSize = 1
        Me.basicDailyTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.basicDailyTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.basicDailyTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.basicDailyTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.basicDailyTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basicDailyTxt.ForeColor = System.Drawing.Color.Black
        Me.basicDailyTxt.Location = New System.Drawing.Point(255, 458)
        Me.basicDailyTxt.Name = "basicDailyTxt"
        Me.basicDailyTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.basicDailyTxt.Radius = 5
        Me.basicDailyTxt.Size = New System.Drawing.Size(180, 37)
        Me.basicDailyTxt.TabIndex = 3
        Me.basicDailyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.basicDailyTxt.TextOffsetX = 5
        '
        'sssTxt
        '
        Me.sssTxt.BackColor = System.Drawing.Color.Transparent
        Me.sssTxt.BaseColor = System.Drawing.Color.White
        Me.sssTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.sssTxt.BorderSize = 1
        Me.sssTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sssTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.sssTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sssTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.sssTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sssTxt.ForeColor = System.Drawing.Color.Black
        Me.sssTxt.Location = New System.Drawing.Point(711, 458)
        Me.sssTxt.Name = "sssTxt"
        Me.sssTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.sssTxt.Radius = 5
        Me.sssTxt.Size = New System.Drawing.Size(395, 37)
        Me.sssTxt.TabIndex = 8
        Me.sssTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.sssTxt.TextOffsetX = 5
        '
        'phicTxt
        '
        Me.phicTxt.BackColor = System.Drawing.Color.Transparent
        Me.phicTxt.BaseColor = System.Drawing.Color.White
        Me.phicTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.phicTxt.BorderSize = 1
        Me.phicTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phicTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.phicTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.phicTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.phicTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phicTxt.ForeColor = System.Drawing.Color.Black
        Me.phicTxt.Location = New System.Drawing.Point(710, 529)
        Me.phicTxt.Name = "phicTxt"
        Me.phicTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phicTxt.Radius = 5
        Me.phicTxt.Size = New System.Drawing.Size(395, 37)
        Me.phicTxt.TabIndex = 9
        Me.phicTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.phicTxt.TextOffsetX = 5
        '
        'hdmTxt
        '
        Me.hdmTxt.BackColor = System.Drawing.Color.Transparent
        Me.hdmTxt.BaseColor = System.Drawing.Color.White
        Me.hdmTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.hdmTxt.BorderSize = 1
        Me.hdmTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hdmTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.hdmTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.hdmTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.hdmTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdmTxt.ForeColor = System.Drawing.Color.Black
        Me.hdmTxt.Location = New System.Drawing.Point(710, 602)
        Me.hdmTxt.Name = "hdmTxt"
        Me.hdmTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.hdmTxt.Radius = 5
        Me.hdmTxt.Size = New System.Drawing.Size(395, 37)
        Me.hdmTxt.TabIndex = 10
        Me.hdmTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.hdmTxt.TextOffsetX = 5
        '
        'OTTxt
        '
        Me.OTTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.OTTxt.BackColor = System.Drawing.Color.Transparent
        Me.OTTxt.BaseColor = System.Drawing.Color.White
        Me.OTTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.OTTxt.BorderSize = 1
        Me.OTTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OTTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.OTTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.OTTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.OTTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OTTxt.ForeColor = System.Drawing.Color.Black
        Me.OTTxt.Location = New System.Drawing.Point(711, 394)
        Me.OTTxt.MaxLength = 11
        Me.OTTxt.Name = "OTTxt"
        Me.OTTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OTTxt.Radius = 5
        Me.OTTxt.Size = New System.Drawing.Size(395, 37)
        Me.OTTxt.TabIndex = 7
        Me.OTTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OTTxt.TextOffsetX = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(707, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "OT PAY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(251, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Basic Daily"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(707, 434)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 17)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "SSS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(466, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "#Days Duty"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(706, 503)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "PHILHEALTH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1135, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "BASIC SALARY:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(707, 578)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 17)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "HDMF"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label5)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(161, 227)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(1393, 57)
        Me.GunaElipsePanel1.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1393, 57)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "PAYROLL MANAGEMENT SYSTEM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'employmentIDTxt
        '
        Me.employmentIDTxt.BackColor = System.Drawing.Color.White
        Me.employmentIDTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employmentIDTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.employmentIDTxt.Location = New System.Drawing.Point(0, 70)
        Me.employmentIDTxt.Name = "employmentIDTxt"
        Me.employmentIDTxt.Size = New System.Drawing.Size(1691, 43)
        Me.employmentIDTxt.TabIndex = 120
        Me.employmentIDTxt.Text = "EMPLOYMENT ID"
        Me.employmentIDTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameFullTxt
        '
        Me.nameFullTxt.BackColor = System.Drawing.Color.White
        Me.nameFullTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameFullTxt.ForeColor = System.Drawing.Color.Black
        Me.nameFullTxt.Location = New System.Drawing.Point(3, 113)
        Me.nameFullTxt.Name = "nameFullTxt"
        Me.nameFullTxt.Size = New System.Drawing.Size(1685, 56)
        Me.nameFullTxt.TabIndex = 119
        Me.nameFullTxt.Text = "NAME"
        Me.nameFullTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'jobTxt
        '
        Me.jobTxt.BackColor = System.Drawing.Color.White
        Me.jobTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.jobTxt.Location = New System.Drawing.Point(0, 169)
        Me.jobTxt.Name = "jobTxt"
        Me.jobTxt.Size = New System.Drawing.Size(1688, 40)
        Me.jobTxt.TabIndex = 118
        Me.jobTxt.Text = "DESIGNATION"
        Me.jobTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.dutyDaysTxt)
        Me.GunaPanel1.Controls.Add(Me.ComputeButton)
        Me.GunaPanel1.Controls.Add(Me.saveButton)
        Me.GunaPanel1.Controls.Add(Me.jobTxt)
        Me.GunaPanel1.Controls.Add(Me.nameFullTxt)
        Me.GunaPanel1.Controls.Add(Me.employmentIDTxt)
        Me.GunaPanel1.Controls.Add(Me.GunaElipsePanel1)
        Me.GunaPanel1.Controls.Add(Me.DateToPicker)
        Me.GunaPanel1.Controls.Add(Me.DateFromPicker)
        Me.GunaPanel1.Controls.Add(Me.Label13)
        Me.GunaPanel1.Controls.Add(Me.Label18)
        Me.GunaPanel1.Controls.Add(Me.Label12)
        Me.GunaPanel1.Controls.Add(Me.TotalNetPay)
        Me.GunaPanel1.Controls.Add(Me.TotalDeducTxt)
        Me.GunaPanel1.Controls.Add(Me.TotalPayTxt)
        Me.GunaPanel1.Controls.Add(Me.basicPayTxt)
        Me.GunaPanel1.Controls.Add(Me.Label22)
        Me.GunaPanel1.Controls.Add(Me.Label20)
        Me.GunaPanel1.Controls.Add(Me.Label14)
        Me.GunaPanel1.Controls.Add(Me.Label4)
        Me.GunaPanel1.Controls.Add(Me.Label11)
        Me.GunaPanel1.Controls.Add(Me.Label3)
        Me.GunaPanel1.Controls.Add(Me.Label9)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Controls.Add(Me.Label7)
        Me.GunaPanel1.Controls.Add(Me.Label17)
        Me.GunaPanel1.Controls.Add(Me.Label16)
        Me.GunaPanel1.Controls.Add(Me.RegularHolidayTxt)
        Me.GunaPanel1.Controls.Add(Me.OTTxt)
        Me.GunaPanel1.Controls.Add(Me.hdmTxt)
        Me.GunaPanel1.Controls.Add(Me.phicTxt)
        Me.GunaPanel1.Controls.Add(Me.specialHolidayTxt)
        Me.GunaPanel1.Controls.Add(Me.sssTxt)
        Me.GunaPanel1.Controls.Add(Me.basicDailyTxt)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.TabIndex = 0
        '
        'dutyDaysTxt
        '
        Me.dutyDaysTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dutyDaysTxt.DecimalPlaces = 2
        Me.dutyDaysTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dutyDaysTxt.Location = New System.Drawing.Point(470, 458)
        Me.dutyDaysTxt.Name = "dutyDaysTxt"
        Me.dutyDaysTxt.Size = New System.Drawing.Size(180, 33)
        Me.dutyDaysTxt.TabIndex = 4
        Me.dutyDaysTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComputeButton
        '
        Me.ComputeButton.AnimationHoverSpeed = 0.07!
        Me.ComputeButton.AnimationSpeed = 0.03!
        Me.ComputeButton.BackColor = System.Drawing.Color.Transparent
        Me.ComputeButton.BaseColor1 = System.Drawing.Color.White
        Me.ComputeButton.BaseColor2 = System.Drawing.Color.White
        Me.ComputeButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ComputeButton.BorderSize = 1
        Me.ComputeButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ComputeButton.FocusedColor = System.Drawing.Color.Empty
        Me.ComputeButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ComputeButton.Image = Nothing
        Me.ComputeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ComputeButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.ComputeButton.Location = New System.Drawing.Point(1177, 656)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ComputeButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ComputeButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ComputeButton.OnHoverForeColor = System.Drawing.Color.White
        Me.ComputeButton.OnHoverImage = Nothing
        Me.ComputeButton.OnPressedColor = System.Drawing.Color.Black
        Me.ComputeButton.Radius = 6
        Me.ComputeButton.Size = New System.Drawing.Size(146, 46)
        Me.ComputeButton.TabIndex = 12
        Me.ComputeButton.Text = "Calculate"
        Me.ComputeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'saveButton
        '
        Me.saveButton.AnimationHoverSpeed = 0.07!
        Me.saveButton.AnimationSpeed = 0.03!
        Me.saveButton.BackColor = System.Drawing.Color.Transparent
        Me.saveButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.saveButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveButton.Enabled = False
        Me.saveButton.FocusedColor = System.Drawing.Color.Empty
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.White
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saveButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.saveButton.Location = New System.Drawing.Point(165, 789)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.saveButton.OnHoverForeColor = System.Drawing.Color.White
        Me.saveButton.OnHoverImage = Nothing
        Me.saveButton.OnPressedColor = System.Drawing.Color.Black
        Me.saveButton.Radius = 6
        Me.saveButton.Size = New System.Drawing.Size(179, 50)
        Me.saveButton.TabIndex = 13
        Me.saveButton.Text = "Submit  Changes"
        Me.saveButton.TextOffsetX = 10
        '
        'DateToPicker
        '
        Me.DateToPicker.BackColor = System.Drawing.Color.Transparent
        Me.DateToPicker.BaseColor = System.Drawing.Color.White
        Me.DateToPicker.BorderColor = System.Drawing.Color.Silver
        Me.DateToPicker.CustomFormat = "0"
        Me.DateToPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateToPicker.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateToPicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateToPicker.ForeColor = System.Drawing.Color.Black
        Me.DateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateToPicker.Location = New System.Drawing.Point(470, 394)
        Me.DateToPicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateToPicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateToPicker.Name = "DateToPicker"
        Me.DateToPicker.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateToPicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateToPicker.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateToPicker.OnPressedColor = System.Drawing.Color.Black
        Me.DateToPicker.Radius = 5
        Me.DateToPicker.Size = New System.Drawing.Size(180, 37)
        Me.DateToPicker.TabIndex = 2
        Me.DateToPicker.Text = "11/8/2022"
        Me.DateToPicker.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'DateFromPicker
        '
        Me.DateFromPicker.BackColor = System.Drawing.Color.Transparent
        Me.DateFromPicker.BaseColor = System.Drawing.Color.White
        Me.DateFromPicker.BorderColor = System.Drawing.Color.Silver
        Me.DateFromPicker.CustomFormat = "0"
        Me.DateFromPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateFromPicker.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateFromPicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFromPicker.ForeColor = System.Drawing.Color.Black
        Me.DateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFromPicker.Location = New System.Drawing.Point(255, 394)
        Me.DateFromPicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateFromPicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateFromPicker.Name = "DateFromPicker"
        Me.DateFromPicker.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateFromPicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateFromPicker.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DateFromPicker.OnPressedColor = System.Drawing.Color.Black
        Me.DateFromPicker.Radius = 5
        Me.DateFromPicker.Size = New System.Drawing.Size(180, 37)
        Me.DateFromPicker.TabIndex = 1
        Me.DateFromPicker.Text = "11/8/2022"
        Me.DateFromPicker.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(251, 503)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 17)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Regular Holiday"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(251, 578)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 17)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "Special Holiday"
        '
        'TotalNetPay
        '
        Me.TotalNetPay.AutoSize = True
        Me.TotalNetPay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNetPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TotalNetPay.Location = New System.Drawing.Point(1279, 609)
        Me.TotalNetPay.Name = "TotalNetPay"
        Me.TotalNetPay.Size = New System.Drawing.Size(44, 17)
        Me.TotalNetPay.TabIndex = 98
        Me.TotalNetPay.Text = "P 0.00"
        '
        'TotalDeducTxt
        '
        Me.TotalDeducTxt.AutoSize = True
        Me.TotalDeducTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDeducTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TotalDeducTxt.Location = New System.Drawing.Point(1279, 531)
        Me.TotalDeducTxt.Name = "TotalDeducTxt"
        Me.TotalDeducTxt.Size = New System.Drawing.Size(44, 17)
        Me.TotalDeducTxt.TabIndex = 98
        Me.TotalDeducTxt.Text = "P 0.00"
        '
        'TotalPayTxt
        '
        Me.TotalPayTxt.AutoSize = True
        Me.TotalPayTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPayTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TotalPayTxt.Location = New System.Drawing.Point(1279, 465)
        Me.TotalPayTxt.Name = "TotalPayTxt"
        Me.TotalPayTxt.Size = New System.Drawing.Size(44, 17)
        Me.TotalPayTxt.TabIndex = 98
        Me.TotalPayTxt.Text = "P 0.00"
        '
        'basicPayTxt
        '
        Me.basicPayTxt.AutoSize = True
        Me.basicPayTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basicPayTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.basicPayTxt.Location = New System.Drawing.Point(1279, 394)
        Me.basicPayTxt.Name = "basicPayTxt"
        Me.basicPayTxt.Size = New System.Drawing.Size(44, 17)
        Me.basicPayTxt.TabIndex = 98
        Me.basicPayTxt.Text = "P 0.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(1135, 609)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 98
        Me.Label22.Text = " NET PAY:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(1135, 531)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 17)
        Me.Label20.TabIndex = 98
        Me.Label20.Text = "TOTAL DEDUCTION:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(1135, 465)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 17)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "TOTAL PAY:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(466, 368)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 17)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Period To"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(251, 368)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 17)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Period From"
        '
        'RegularHolidayTxt
        '
        Me.RegularHolidayTxt.BackColor = System.Drawing.Color.Transparent
        Me.RegularHolidayTxt.BaseColor = System.Drawing.Color.White
        Me.RegularHolidayTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.RegularHolidayTxt.BorderSize = 1
        Me.RegularHolidayTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RegularHolidayTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.RegularHolidayTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.RegularHolidayTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.RegularHolidayTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegularHolidayTxt.ForeColor = System.Drawing.Color.Black
        Me.RegularHolidayTxt.Location = New System.Drawing.Point(255, 529)
        Me.RegularHolidayTxt.MaxLength = 11
        Me.RegularHolidayTxt.Name = "RegularHolidayTxt"
        Me.RegularHolidayTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RegularHolidayTxt.Radius = 5
        Me.RegularHolidayTxt.Size = New System.Drawing.Size(395, 37)
        Me.RegularHolidayTxt.TabIndex = 5
        Me.RegularHolidayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RegularHolidayTxt.TextOffsetX = 5
        '
        'specialHolidayTxt
        '
        Me.specialHolidayTxt.BackColor = System.Drawing.Color.Transparent
        Me.specialHolidayTxt.BaseColor = System.Drawing.Color.White
        Me.specialHolidayTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.specialHolidayTxt.BorderSize = 1
        Me.specialHolidayTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.specialHolidayTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.specialHolidayTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.specialHolidayTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.specialHolidayTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialHolidayTxt.ForeColor = System.Drawing.Color.Black
        Me.specialHolidayTxt.Location = New System.Drawing.Point(255, 602)
        Me.specialHolidayTxt.Name = "specialHolidayTxt"
        Me.specialHolidayTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.specialHolidayTxt.Radius = 5
        Me.specialHolidayTxt.Size = New System.Drawing.Size(395, 37)
        Me.specialHolidayTxt.TabIndex = 6
        Me.specialHolidayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.specialHolidayTxt.TextOffsetX = 5
        '
        'AddPayrollPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "AddPayrollPanel"
        Me.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.dutyDaysTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents basicDailyTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents sssTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents phicTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents hdmTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents OTTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label5 As Label
    Friend WithEvents employmentIDTxt As Label
    Friend WithEvents nameFullTxt As Label
    Friend WithEvents jobTxt As Label
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents DateToPicker As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents DateFromPicker As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents RegularHolidayTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents saveButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label18 As Label
    Friend WithEvents specialHolidayTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ComputeButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dutyDaysTxt As NumericUpDown
    Friend WithEvents basicPayTxt As Label
    Friend WithEvents TotalNetPay As Label
    Friend WithEvents TotalDeducTxt As Label
    Friend WithEvents TotalPayTxt As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label14 As Label
End Class

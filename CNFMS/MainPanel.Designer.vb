<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPanel))
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.topPanel = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.maximizedButton = New Guna.UI.WinForms.GunaButton()
        Me.exitButton = New Guna.UI.WinForms.GunaButton()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.FillPanel = New Guna.UI.WinForms.GunaLinePanel()
        Me.sidebarpanel = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaButton9 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinePanel3 = New Guna.UI.WinForms.GunaLinePanel()
        Me.AdminButton = New Guna.UI.WinForms.GunaButton()
        Me.PayrollButton = New Guna.UI.WinForms.GunaButton()
        Me.EmployeeButton = New Guna.UI.WinForms.GunaButton()
        Me.SalesReportButton = New Guna.UI.WinForms.GunaButton()
        Me.CutOffButton = New Guna.UI.WinForms.GunaButton()
        Me.fuelsideButton = New Guna.UI.WinForms.GunaButton()
        Me.inventoryButton = New Guna.UI.WinForms.GunaButton()
        Me.dashboardButton = New Guna.UI.WinForms.GunaButton()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.slidePanelButton = New Guna.UI.WinForms.GunaButton()
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.topPanel.SuspendLayout()
        Me.TableLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.sidebarpanel.SuspendLayout()
        Me.GunaLinePanel3.SuspendLayout()
        Me.GunaLinePanel2.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.topPanel
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.Transparent
        Me.topPanel.Controls.Add(Me.maximizedButton)
        Me.topPanel.Controls.Add(Me.exitButton)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.GradientColor1 = System.Drawing.Color.White
        Me.topPanel.GradientColor2 = System.Drawing.Color.White
        Me.topPanel.Location = New System.Drawing.Point(185, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(1729, 42)
        Me.topPanel.TabIndex = 1
        '
        'maximizedButton
        '
        Me.maximizedButton.AnimationHoverSpeed = 0.07!
        Me.maximizedButton.AnimationSpeed = 0.03!
        Me.maximizedButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.maximizedButton.BorderColor = System.Drawing.Color.Black
        Me.maximizedButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.maximizedButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.maximizedButton.FocusedColor = System.Drawing.Color.Empty
        Me.maximizedButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.maximizedButton.ForeColor = System.Drawing.Color.White
        Me.maximizedButton.Image = CType(resources.GetObject("maximizedButton.Image"), System.Drawing.Image)
        Me.maximizedButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maximizedButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.maximizedButton.Location = New System.Drawing.Point(1577, 0)
        Me.maximizedButton.Name = "maximizedButton"
        Me.maximizedButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.maximizedButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.maximizedButton.OnHoverForeColor = System.Drawing.Color.White
        Me.maximizedButton.OnHoverImage = Nothing
        Me.maximizedButton.OnPressedColor = System.Drawing.Color.Black
        Me.maximizedButton.Size = New System.Drawing.Size(76, 42)
        Me.maximizedButton.TabIndex = 3
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
        Me.exitButton.Location = New System.Drawing.Point(1653, 0)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.exitButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exitButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exitButton.OnHoverImage = Nothing
        Me.exitButton.OnPressedColor = System.Drawing.Color.Black
        Me.exitButton.Size = New System.Drawing.Size(76, 42)
        Me.exitButton.TabIndex = 2
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TableLayoutPanel.ColumnCount = 1
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.10045!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.89954!))
        Me.TableLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 1
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(1920, 1030)
        Me.TableLayoutPanel.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.FillPanel)
        Me.Panel1.Controls.Add(Me.topPanel)
        Me.Panel1.Controls.Add(Me.sidebarpanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.GradientColor1 = System.Drawing.Color.White
        Me.Panel1.GradientColor2 = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1914, 1024)
        Me.Panel1.TabIndex = 0
        '
        'FillPanel
        '
        Me.FillPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FillPanel.LineColor = System.Drawing.Color.Black
        Me.FillPanel.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.FillPanel.Location = New System.Drawing.Point(185, 42)
        Me.FillPanel.Name = "FillPanel"
        Me.FillPanel.Size = New System.Drawing.Size(1729, 982)
        Me.FillPanel.TabIndex = 2
        '
        'sidebarpanel
        '
        Me.sidebarpanel.BackColor = System.Drawing.Color.Transparent
        Me.sidebarpanel.Controls.Add(Me.GunaButton9)
        Me.sidebarpanel.Controls.Add(Me.GunaLinePanel3)
        Me.sidebarpanel.Controls.Add(Me.GunaLinePanel2)
        Me.sidebarpanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarpanel.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sidebarpanel.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sidebarpanel.Location = New System.Drawing.Point(0, 0)
        Me.sidebarpanel.Name = "sidebarpanel"
        Me.sidebarpanel.Size = New System.Drawing.Size(185, 1024)
        Me.sidebarpanel.TabIndex = 0
        '
        'GunaButton9
        '
        Me.GunaButton9.AnimationHoverSpeed = 0.07!
        Me.GunaButton9.AnimationSpeed = 0.03!
        Me.GunaButton9.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton9.BorderColor = System.Drawing.Color.Black
        Me.GunaButton9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton9.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton9.ForeColor = System.Drawing.Color.White
        Me.GunaButton9.Image = CType(resources.GetObject("GunaButton9.Image"), System.Drawing.Image)
        Me.GunaButton9.ImageOffsetX = 10
        Me.GunaButton9.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton9.Location = New System.Drawing.Point(0, 777)
        Me.GunaButton9.Name = "GunaButton9"
        Me.GunaButton9.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton9.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton9.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaButton9.OnHoverImage = CType(resources.GetObject("GunaButton9.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton9.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton9.Size = New System.Drawing.Size(185, 53)
        Me.GunaButton9.TabIndex = 10
        Me.GunaButton9.Text = "Sign-Out"
        Me.GunaButton9.TextOffsetX = 10
        '
        'GunaLinePanel3
        '
        Me.GunaLinePanel3.Controls.Add(Me.AdminButton)
        Me.GunaLinePanel3.Controls.Add(Me.PayrollButton)
        Me.GunaLinePanel3.Controls.Add(Me.EmployeeButton)
        Me.GunaLinePanel3.Controls.Add(Me.SalesReportButton)
        Me.GunaLinePanel3.Controls.Add(Me.CutOffButton)
        Me.GunaLinePanel3.Controls.Add(Me.fuelsideButton)
        Me.GunaLinePanel3.Controls.Add(Me.inventoryButton)
        Me.GunaLinePanel3.Controls.Add(Me.dashboardButton)
        Me.GunaLinePanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel3.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel3.Location = New System.Drawing.Point(0, 134)
        Me.GunaLinePanel3.Name = "GunaLinePanel3"
        Me.GunaLinePanel3.Size = New System.Drawing.Size(185, 643)
        Me.GunaLinePanel3.TabIndex = 2
        '
        'AdminButton
        '
        Me.AdminButton.AnimationHoverSpeed = 0.07!
        Me.AdminButton.AnimationSpeed = 0.03!
        Me.AdminButton.BaseColor = System.Drawing.Color.Transparent
        Me.AdminButton.BorderColor = System.Drawing.Color.Black
        Me.AdminButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AdminButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminButton.FocusedColor = System.Drawing.Color.Empty
        Me.AdminButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminButton.ForeColor = System.Drawing.Color.White
        Me.AdminButton.Image = CType(resources.GetObject("AdminButton.Image"), System.Drawing.Image)
        Me.AdminButton.ImageOffsetX = 10
        Me.AdminButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.AdminButton.Location = New System.Drawing.Point(0, 371)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.AdminButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.AdminButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.AdminButton.OnHoverImage = CType(resources.GetObject("AdminButton.OnHoverImage"), System.Drawing.Image)
        Me.AdminButton.OnPressedColor = System.Drawing.Color.Black
        Me.AdminButton.Size = New System.Drawing.Size(185, 53)
        Me.AdminButton.TabIndex = 15
        Me.AdminButton.Text = "Administrator"
        Me.AdminButton.TextOffsetX = 10
        '
        'PayrollButton
        '
        Me.PayrollButton.AnimationHoverSpeed = 0.07!
        Me.PayrollButton.AnimationSpeed = 0.03!
        Me.PayrollButton.BaseColor = System.Drawing.Color.Transparent
        Me.PayrollButton.BorderColor = System.Drawing.Color.Black
        Me.PayrollButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PayrollButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PayrollButton.FocusedColor = System.Drawing.Color.Empty
        Me.PayrollButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayrollButton.ForeColor = System.Drawing.Color.White
        Me.PayrollButton.Image = CType(resources.GetObject("PayrollButton.Image"), System.Drawing.Image)
        Me.PayrollButton.ImageOffsetX = 10
        Me.PayrollButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.PayrollButton.Location = New System.Drawing.Point(0, 318)
        Me.PayrollButton.Name = "PayrollButton"
        Me.PayrollButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.PayrollButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PayrollButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.PayrollButton.OnHoverImage = CType(resources.GetObject("PayrollButton.OnHoverImage"), System.Drawing.Image)
        Me.PayrollButton.OnPressedColor = System.Drawing.Color.Black
        Me.PayrollButton.Size = New System.Drawing.Size(185, 53)
        Me.PayrollButton.TabIndex = 14
        Me.PayrollButton.Text = "Payroll"
        Me.PayrollButton.TextOffsetX = 10
        '
        'EmployeeButton
        '
        Me.EmployeeButton.AnimationHoverSpeed = 0.07!
        Me.EmployeeButton.AnimationSpeed = 0.03!
        Me.EmployeeButton.BaseColor = System.Drawing.Color.Transparent
        Me.EmployeeButton.BorderColor = System.Drawing.Color.Black
        Me.EmployeeButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.EmployeeButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeButton.FocusedColor = System.Drawing.Color.Empty
        Me.EmployeeButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeButton.ForeColor = System.Drawing.Color.White
        Me.EmployeeButton.Image = CType(resources.GetObject("EmployeeButton.Image"), System.Drawing.Image)
        Me.EmployeeButton.ImageOffsetX = 10
        Me.EmployeeButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.EmployeeButton.Location = New System.Drawing.Point(0, 265)
        Me.EmployeeButton.Name = "EmployeeButton"
        Me.EmployeeButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.EmployeeButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.EmployeeButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.EmployeeButton.OnHoverImage = CType(resources.GetObject("EmployeeButton.OnHoverImage"), System.Drawing.Image)
        Me.EmployeeButton.OnPressedColor = System.Drawing.Color.Black
        Me.EmployeeButton.Size = New System.Drawing.Size(185, 53)
        Me.EmployeeButton.TabIndex = 13
        Me.EmployeeButton.Text = "Employees"
        Me.EmployeeButton.TextOffsetX = 10
        '
        'SalesReportButton
        '
        Me.SalesReportButton.AnimationHoverSpeed = 0.07!
        Me.SalesReportButton.AnimationSpeed = 0.03!
        Me.SalesReportButton.BaseColor = System.Drawing.Color.Transparent
        Me.SalesReportButton.BorderColor = System.Drawing.Color.Black
        Me.SalesReportButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SalesReportButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SalesReportButton.FocusedColor = System.Drawing.Color.Empty
        Me.SalesReportButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesReportButton.ForeColor = System.Drawing.Color.White
        Me.SalesReportButton.Image = CType(resources.GetObject("SalesReportButton.Image"), System.Drawing.Image)
        Me.SalesReportButton.ImageOffsetX = 10
        Me.SalesReportButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.SalesReportButton.Location = New System.Drawing.Point(0, 212)
        Me.SalesReportButton.Name = "SalesReportButton"
        Me.SalesReportButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.SalesReportButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.SalesReportButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.SalesReportButton.OnHoverImage = CType(resources.GetObject("SalesReportButton.OnHoverImage"), System.Drawing.Image)
        Me.SalesReportButton.OnPressedColor = System.Drawing.Color.Black
        Me.SalesReportButton.Size = New System.Drawing.Size(185, 53)
        Me.SalesReportButton.TabIndex = 12
        Me.SalesReportButton.Text = "Sales Report"
        Me.SalesReportButton.TextOffsetX = 10
        '
        'CutOffButton
        '
        Me.CutOffButton.AnimationHoverSpeed = 0.07!
        Me.CutOffButton.AnimationSpeed = 0.03!
        Me.CutOffButton.BaseColor = System.Drawing.Color.Transparent
        Me.CutOffButton.BorderColor = System.Drawing.Color.Black
        Me.CutOffButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CutOffButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CutOffButton.FocusedColor = System.Drawing.Color.Empty
        Me.CutOffButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CutOffButton.ForeColor = System.Drawing.Color.White
        Me.CutOffButton.Image = CType(resources.GetObject("CutOffButton.Image"), System.Drawing.Image)
        Me.CutOffButton.ImageOffsetX = 10
        Me.CutOffButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.CutOffButton.Location = New System.Drawing.Point(0, 159)
        Me.CutOffButton.Name = "CutOffButton"
        Me.CutOffButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.CutOffButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CutOffButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.CutOffButton.OnHoverImage = CType(resources.GetObject("CutOffButton.OnHoverImage"), System.Drawing.Image)
        Me.CutOffButton.OnPressedColor = System.Drawing.Color.Black
        Me.CutOffButton.Size = New System.Drawing.Size(185, 53)
        Me.CutOffButton.TabIndex = 11
        Me.CutOffButton.Text = "Cut-Off"
        Me.CutOffButton.TextOffsetX = 10
        '
        'fuelsideButton
        '
        Me.fuelsideButton.AnimationHoverSpeed = 0.07!
        Me.fuelsideButton.AnimationSpeed = 0.03!
        Me.fuelsideButton.BaseColor = System.Drawing.Color.Transparent
        Me.fuelsideButton.BorderColor = System.Drawing.Color.Black
        Me.fuelsideButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.fuelsideButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.fuelsideButton.FocusedColor = System.Drawing.Color.Empty
        Me.fuelsideButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fuelsideButton.ForeColor = System.Drawing.Color.White
        Me.fuelsideButton.Image = CType(resources.GetObject("fuelsideButton.Image"), System.Drawing.Image)
        Me.fuelsideButton.ImageOffsetX = 10
        Me.fuelsideButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.fuelsideButton.Location = New System.Drawing.Point(0, 106)
        Me.fuelsideButton.Name = "fuelsideButton"
        Me.fuelsideButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.fuelsideButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.fuelsideButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.fuelsideButton.OnHoverImage = CType(resources.GetObject("fuelsideButton.OnHoverImage"), System.Drawing.Image)
        Me.fuelsideButton.OnPressedColor = System.Drawing.Color.Black
        Me.fuelsideButton.Size = New System.Drawing.Size(185, 53)
        Me.fuelsideButton.TabIndex = 10
        Me.fuelsideButton.Text = "Fuel Report"
        Me.fuelsideButton.TextOffsetX = 10
        '
        'inventoryButton
        '
        Me.inventoryButton.AnimationHoverSpeed = 0.07!
        Me.inventoryButton.AnimationSpeed = 0.03!
        Me.inventoryButton.BaseColor = System.Drawing.Color.Transparent
        Me.inventoryButton.BorderColor = System.Drawing.Color.Black
        Me.inventoryButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.inventoryButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.inventoryButton.FocusedColor = System.Drawing.Color.Empty
        Me.inventoryButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryButton.ForeColor = System.Drawing.Color.White
        Me.inventoryButton.Image = CType(resources.GetObject("inventoryButton.Image"), System.Drawing.Image)
        Me.inventoryButton.ImageOffsetX = 10
        Me.inventoryButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.inventoryButton.Location = New System.Drawing.Point(0, 53)
        Me.inventoryButton.Name = "inventoryButton"
        Me.inventoryButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.inventoryButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.inventoryButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.inventoryButton.OnHoverImage = CType(resources.GetObject("inventoryButton.OnHoverImage"), System.Drawing.Image)
        Me.inventoryButton.OnPressedColor = System.Drawing.Color.Black
        Me.inventoryButton.Size = New System.Drawing.Size(185, 53)
        Me.inventoryButton.TabIndex = 3
        Me.inventoryButton.Text = "Inventory"
        Me.inventoryButton.TextOffsetX = 10
        '
        'dashboardButton
        '
        Me.dashboardButton.AnimationHoverSpeed = 0.07!
        Me.dashboardButton.AnimationSpeed = 0.03!
        Me.dashboardButton.BaseColor = System.Drawing.Color.Transparent
        Me.dashboardButton.BorderColor = System.Drawing.Color.Black
        Me.dashboardButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboardButton.FocusedColor = System.Drawing.Color.Empty
        Me.dashboardButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardButton.ForeColor = System.Drawing.Color.White
        Me.dashboardButton.Image = CType(resources.GetObject("dashboardButton.Image"), System.Drawing.Image)
        Me.dashboardButton.ImageOffsetX = 10
        Me.dashboardButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.dashboardButton.Location = New System.Drawing.Point(0, 0)
        Me.dashboardButton.Name = "dashboardButton"
        Me.dashboardButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.dashboardButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.dashboardButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.dashboardButton.OnHoverImage = CType(resources.GetObject("dashboardButton.OnHoverImage"), System.Drawing.Image)
        Me.dashboardButton.OnPressedColor = System.Drawing.Color.Black
        Me.dashboardButton.Size = New System.Drawing.Size(185, 53)
        Me.dashboardButton.TabIndex = 2
        Me.dashboardButton.Text = "Dashboard"
        Me.dashboardButton.TextOffsetX = 10
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.Controls.Add(Me.GunaPanel1)
        Me.GunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(185, 134)
        Me.GunaLinePanel2.TabIndex = 1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.slidePanelButton)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(185, 52)
        Me.GunaPanel1.TabIndex = 4
        '
        'slidePanelButton
        '
        Me.slidePanelButton.AnimationHoverSpeed = 0.07!
        Me.slidePanelButton.AnimationSpeed = 0.03!
        Me.slidePanelButton.BaseColor = System.Drawing.Color.Transparent
        Me.slidePanelButton.BorderColor = System.Drawing.Color.Black
        Me.slidePanelButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.slidePanelButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.slidePanelButton.FocusedColor = System.Drawing.Color.Empty
        Me.slidePanelButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slidePanelButton.ForeColor = System.Drawing.Color.White
        Me.slidePanelButton.Image = CType(resources.GetObject("slidePanelButton.Image"), System.Drawing.Image)
        Me.slidePanelButton.ImageOffsetX = 10
        Me.slidePanelButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.slidePanelButton.Location = New System.Drawing.Point(112, 0)
        Me.slidePanelButton.Name = "slidePanelButton"
        Me.slidePanelButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.slidePanelButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.slidePanelButton.OnHoverForeColor = System.Drawing.Color.Black
        Me.slidePanelButton.OnHoverImage = CType(resources.GetObject("slidePanelButton.OnHoverImage"), System.Drawing.Image)
        Me.slidePanelButton.OnPressedColor = System.Drawing.Color.Black
        Me.slidePanelButton.Size = New System.Drawing.Size(73, 52)
        Me.slidePanelButton.TabIndex = 3
        Me.slidePanelButton.TextOffsetX = 10
        '
        'animationTimer
        '
        Me.animationTimer.Interval = 10
        '
        'MainPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1030)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1920, 1030)
        Me.Name = "MainPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainPanel"
        Me.topPanel.ResumeLayout(False)
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.sidebarpanel.ResumeLayout(False)
        Me.GunaLinePanel3.ResumeLayout(False)
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents sidebarpanel As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents topPanel As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents exitButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents dashboardButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinePanel3 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents animationTimer As Timer
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents inventoryButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton9 As Guna.UI.WinForms.GunaButton
    Friend WithEvents slidePanelButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents AdminButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents PayrollButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents EmployeeButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents SalesReportButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents CutOffButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents fuelsideButton As Guna.UI.WinForms.GunaButton
    Friend WithEvents FillPanel As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents maximizedButton As Guna.UI.WinForms.GunaButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayrollPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollPanel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.SearchTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.exportExcelButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.PrintButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.addButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.payrollTable = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleteData = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GunaPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.payrollTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.SearchTxt)
        Me.GunaPanel1.Controls.Add(Me.GroupBox1)
        Me.GunaPanel1.Controls.Add(Me.payrollTable)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1729, 982)
        Me.GunaPanel1.TabIndex = 0
        '
        'SearchTxt
        '
        Me.SearchTxt.BackColor = System.Drawing.Color.Transparent
        Me.SearchTxt.BaseColor = System.Drawing.Color.White
        Me.SearchTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.SearchTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.SearchTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.SearchTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxt.ForeColor = System.Drawing.Color.Black
        Me.SearchTxt.Location = New System.Drawing.Point(50, 106)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTxt.Radius = 20
        Me.SearchTxt.Size = New System.Drawing.Size(742, 49)
        Me.SearchTxt.TabIndex = 87
        Me.SearchTxt.Text = "Search"
        Me.SearchTxt.TextOffsetX = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.exportExcelButton)
        Me.GroupBox1.Controls.Add(Me.PrintButton)
        Me.GroupBox1.Controls.Add(Me.addButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 849)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1659, 104)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " ADD, PRINT"
        '
        'exportExcelButton
        '
        Me.exportExcelButton.AnimationHoverSpeed = 0.07!
        Me.exportExcelButton.AnimationSpeed = 0.03!
        Me.exportExcelButton.BackColor = System.Drawing.Color.Transparent
        Me.exportExcelButton.BaseColor1 = System.Drawing.Color.BlueViolet
        Me.exportExcelButton.BaseColor2 = System.Drawing.Color.BlueViolet
        Me.exportExcelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.exportExcelButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exportExcelButton.FocusedColor = System.Drawing.Color.Empty
        Me.exportExcelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportExcelButton.ForeColor = System.Drawing.Color.White
        Me.exportExcelButton.Image = CType(resources.GetObject("exportExcelButton.Image"), System.Drawing.Image)
        Me.exportExcelButton.ImageOffsetX = 15
        Me.exportExcelButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.exportExcelButton.Location = New System.Drawing.Point(307, 28)
        Me.exportExcelButton.Name = "exportExcelButton"
        Me.exportExcelButton.OnHoverBaseColor1 = System.Drawing.Color.BlueViolet
        Me.exportExcelButton.OnHoverBaseColor2 = System.Drawing.Color.BlueViolet
        Me.exportExcelButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exportExcelButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exportExcelButton.OnHoverImage = Nothing
        Me.exportExcelButton.OnPressedColor = System.Drawing.Color.Black
        Me.exportExcelButton.Radius = 5
        Me.exportExcelButton.Size = New System.Drawing.Size(144, 45)
        Me.exportExcelButton.TabIndex = 93
        Me.exportExcelButton.Text = "Archived"
        '
        'PrintButton
        '
        Me.PrintButton.AnimationHoverSpeed = 0.07!
        Me.PrintButton.AnimationSpeed = 0.03!
        Me.PrintButton.BackColor = System.Drawing.Color.Transparent
        Me.PrintButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.PrintButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PrintButton.FocusedColor = System.Drawing.Color.Empty
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.White
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.ImageOffsetX = 15
        Me.PrintButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.PrintButton.Location = New System.Drawing.Point(175, 28)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PrintButton.OnHoverForeColor = System.Drawing.Color.White
        Me.PrintButton.OnHoverImage = Nothing
        Me.PrintButton.OnPressedColor = System.Drawing.Color.Black
        Me.PrintButton.Radius = 5
        Me.PrintButton.Size = New System.Drawing.Size(126, 45)
        Me.PrintButton.TabIndex = 92
        Me.PrintButton.Text = "Print"
        '
        'addButton
        '
        Me.addButton.AnimationHoverSpeed = 0.07!
        Me.addButton.AnimationSpeed = 0.03!
        Me.addButton.BackColor = System.Drawing.Color.Transparent
        Me.addButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.addButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.addButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.addButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.addButton.FocusedColor = System.Drawing.Color.Empty
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.Color.White
        Me.addButton.Image = CType(resources.GetObject("addButton.Image"), System.Drawing.Image)
        Me.addButton.ImageOffsetX = 15
        Me.addButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.addButton.Location = New System.Drawing.Point(33, 28)
        Me.addButton.Name = "addButton"
        Me.addButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.addButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.addButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.addButton.OnHoverForeColor = System.Drawing.Color.White
        Me.addButton.OnHoverImage = Nothing
        Me.addButton.OnPressedColor = System.Drawing.Color.Black
        Me.addButton.Radius = 5
        Me.addButton.Size = New System.Drawing.Size(126, 45)
        Me.addButton.TabIndex = 86
        Me.addButton.Text = "Add"
        '
        'payrollTable
        '
        Me.payrollTable.AllowUserToAddRows = False
        Me.payrollTable.AllowUserToResizeColumns = False
        Me.payrollTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.payrollTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.payrollTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.payrollTable.BackgroundColor = System.Drawing.Color.White
        Me.payrollTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.payrollTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.payrollTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.payrollTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.payrollTable.ColumnHeadersHeight = 60
        Me.payrollTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column16, Me.Column17, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column10, Me.Column7, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.deleteData})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.payrollTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.payrollTable.EnableHeadersVisualStyles = False
        Me.payrollTable.GridColor = System.Drawing.Color.LightGray
        Me.payrollTable.Location = New System.Drawing.Point(50, 175)
        Me.payrollTable.Name = "payrollTable"
        Me.payrollTable.ReadOnly = True
        Me.payrollTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.payrollTable.RowHeadersVisible = False
        Me.payrollTable.RowHeadersWidth = 55
        Me.payrollTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.payrollTable.RowTemplate.Height = 50
        Me.payrollTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.payrollTable.ShowCellErrors = False
        Me.payrollTable.ShowRowErrors = False
        Me.payrollTable.Size = New System.Drawing.Size(1659, 648)
        Me.payrollTable.StandardTab = True
        Me.payrollTable.TabIndex = 88
        Me.payrollTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WhiteGrid
        Me.payrollTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.payrollTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.payrollTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.payrollTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.payrollTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.payrollTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.payrollTable.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.payrollTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.payrollTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.payrollTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payrollTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.payrollTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.payrollTable.ThemeStyle.HeaderStyle.Height = 60
        Me.payrollTable.ThemeStyle.ReadOnly = True
        Me.payrollTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.payrollTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.payrollTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payrollTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.payrollTable.ThemeStyle.RowsStyle.Height = 50
        Me.payrollTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.payrollTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Id"
        Me.Column9.FillWeight = 50.0!
        Me.Column9.HeaderText = "ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 50
        '
        'Column16
        '
        Me.Column16.DataPropertyName = "DateFrom"
        Me.Column16.HeaderText = "Period From"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 115
        '
        'Column17
        '
        Me.Column17.DataPropertyName = "DateTo"
        Me.Column17.HeaderText = "Period To"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 96
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Name_Employee"
        Me.Column1.FillWeight = 130.0!
        Me.Column1.HeaderText = "Employee"
        Me.Column1.MinimumWidth = 130
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 130
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Designation"
        Me.Column2.HeaderText = "Designation"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 126
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "BasicDaily"
        Me.Column3.FillWeight = 80.0!
        Me.Column3.HeaderText = "Daily Pay"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 96
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "numberDays"
        Me.Column4.FillWeight = 40.0!
        Me.Column4.HeaderText = "# Duty Days"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 113
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "BasicPay"
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "Basic Pay"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 95
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "RegularHoliday"
        Me.Column6.FillWeight = 50.0!
        Me.Column6.HeaderText = "Regular Holiday"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 142
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "SpecialHoliday"
        Me.Column8.FillWeight = 50.0!
        Me.Column8.HeaderText = "Special Holiday"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 139
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "OT"
        Me.Column10.FillWeight = 120.0!
        Me.Column10.HeaderText = "OT"
        Me.Column10.MinimumWidth = 120
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 120
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "TotalPay"
        Me.Column7.HeaderText = "Total Pay"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 94
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "SSS"
        Me.Column11.FillWeight = 50.0!
        Me.Column11.HeaderText = "SSS"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 60
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "PHIC"
        Me.Column12.FillWeight = 50.0!
        Me.Column12.HeaderText = "PHIC"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 70
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "HDMF"
        Me.Column13.FillWeight = 50.0!
        Me.Column13.HeaderText = "HDMF"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 80
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "TotalDeduction"
        Me.Column14.HeaderText = "Total Deductions"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 148
        '
        'Column15
        '
        Me.Column15.DataPropertyName = "NetPay"
        Me.Column15.FillWeight = 120.0!
        Me.Column15.HeaderText = "Net Pay"
        Me.Column15.MinimumWidth = 100
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'deleteData
        '
        Me.deleteData.FillWeight = 80.0!
        Me.deleteData.HeaderText = ""
        Me.deleteData.Image = CType(resources.GetObject("deleteData.Image"), System.Drawing.Image)
        Me.deleteData.MinimumWidth = 50
        Me.deleteData.Name = "deleteData"
        Me.deleteData.ReadOnly = True
        Me.deleteData.Width = 50
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 33)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "/ PAYROLL MANAGEMENT SYSTEM"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 30.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.MinimumWidth = 50
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 81
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.FillWeight = 30.0!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 80
        '
        'PayrollPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "PayrollPanel"
        Me.Size = New System.Drawing.Size(1729, 982)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.payrollTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents payrollTable As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents addButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents SearchTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrintButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents deleteData As DataGridViewImageColumn
    Friend WithEvents exportExcelButton As Guna.UI.WinForms.GunaGradientButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FuelReportPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FuelReportPanel))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PrintButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.exportPDFButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.exportExcelButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerFrom = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.DateTimePickerTo = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.showAllButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.filterButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.fuelReportTable = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GunaPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fuelReportTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.GroupBox2)
        Me.GunaPanel1.Controls.Add(Me.GroupBox1)
        Me.GunaPanel1.Controls.Add(Me.fuelReportTable)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1691, 982)
        Me.GunaPanel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PrintButton)
        Me.GroupBox2.Controls.Add(Me.exportPDFButton)
        Me.GroupBox2.Controls.Add(Me.exportExcelButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(99, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1492, 113)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRINT, EXPORT"
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
        Me.PrintButton.Location = New System.Drawing.Point(17, 46)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.PrintButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PrintButton.OnHoverForeColor = System.Drawing.Color.White
        Me.PrintButton.OnHoverImage = Nothing
        Me.PrintButton.OnPressedColor = System.Drawing.Color.Black
        Me.PrintButton.Radius = 5
        Me.PrintButton.Size = New System.Drawing.Size(126, 45)
        Me.PrintButton.TabIndex = 70
        Me.PrintButton.Text = "Print"
        '
        'exportPDFButton
        '
        Me.exportPDFButton.AnimationHoverSpeed = 0.07!
        Me.exportPDFButton.AnimationSpeed = 0.03!
        Me.exportPDFButton.BackColor = System.Drawing.Color.Transparent
        Me.exportPDFButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.exportPDFButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.exportPDFButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.exportPDFButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exportPDFButton.FocusedColor = System.Drawing.Color.Empty
        Me.exportPDFButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportPDFButton.ForeColor = System.Drawing.Color.White
        Me.exportPDFButton.Image = CType(resources.GetObject("exportPDFButton.Image"), System.Drawing.Image)
        Me.exportPDFButton.ImageOffsetX = 15
        Me.exportPDFButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.exportPDFButton.Location = New System.Drawing.Point(149, 46)
        Me.exportPDFButton.Name = "exportPDFButton"
        Me.exportPDFButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.exportPDFButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.exportPDFButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exportPDFButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exportPDFButton.OnHoverImage = Nothing
        Me.exportPDFButton.OnPressedColor = System.Drawing.Color.Black
        Me.exportPDFButton.Radius = 5
        Me.exportPDFButton.Size = New System.Drawing.Size(126, 45)
        Me.exportPDFButton.TabIndex = 69
        Me.exportPDFButton.Text = "PDF"
        '
        'exportExcelButton
        '
        Me.exportExcelButton.AnimationHoverSpeed = 0.07!
        Me.exportExcelButton.AnimationSpeed = 0.03!
        Me.exportExcelButton.BackColor = System.Drawing.Color.Transparent
        Me.exportExcelButton.BaseColor1 = System.Drawing.Color.ForestGreen
        Me.exportExcelButton.BaseColor2 = System.Drawing.Color.ForestGreen
        Me.exportExcelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.exportExcelButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exportExcelButton.FocusedColor = System.Drawing.Color.Empty
        Me.exportExcelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportExcelButton.ForeColor = System.Drawing.Color.White
        Me.exportExcelButton.Image = CType(resources.GetObject("exportExcelButton.Image"), System.Drawing.Image)
        Me.exportExcelButton.ImageOffsetX = 15
        Me.exportExcelButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.exportExcelButton.Location = New System.Drawing.Point(281, 46)
        Me.exportExcelButton.Name = "exportExcelButton"
        Me.exportExcelButton.OnHoverBaseColor1 = System.Drawing.Color.ForestGreen
        Me.exportExcelButton.OnHoverBaseColor2 = System.Drawing.Color.ForestGreen
        Me.exportExcelButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.exportExcelButton.OnHoverForeColor = System.Drawing.Color.White
        Me.exportExcelButton.OnHoverImage = Nothing
        Me.exportExcelButton.OnPressedColor = System.Drawing.Color.Black
        Me.exportExcelButton.Radius = 5
        Me.exportExcelButton.Size = New System.Drawing.Size(126, 45)
        Me.exportExcelButton.TabIndex = 68
        Me.exportExcelButton.Text = "Excel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerFrom)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBox1.Controls.Add(Me.showAllButton)
        Me.GroupBox1.Controls.Add(Me.filterButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(99, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1492, 123)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(288, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 23)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Date to"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Date From"
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerFrom.BaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePickerFrom.CustomFormat = Nothing
        Me.DateTimePickerFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerFrom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.ForeColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(17, 55)
        Me.DateTimePickerFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DateTimePickerFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DateTimePickerFrom.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Radius = 5
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(230, 45)
        Me.DateTimePickerFrom.TabIndex = 73
        Me.DateTimePickerFrom.Text = "11/8/2022"
        Me.DateTimePickerFrom.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerTo.BaseColor = System.Drawing.Color.White
        Me.DateTimePickerTo.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePickerTo.CustomFormat = Nothing
        Me.DateTimePickerTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerTo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTo.ForeColor = System.Drawing.Color.Black
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerTo.Location = New System.Drawing.Point(292, 55)
        Me.DateTimePickerTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePickerTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DateTimePickerTo.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DateTimePickerTo.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePickerTo.Radius = 5
        Me.DateTimePickerTo.Size = New System.Drawing.Size(230, 45)
        Me.DateTimePickerTo.TabIndex = 74
        Me.DateTimePickerTo.Text = "11/8/2022"
        Me.DateTimePickerTo.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'showAllButton
        '
        Me.showAllButton.AnimationHoverSpeed = 0.07!
        Me.showAllButton.AnimationSpeed = 0.03!
        Me.showAllButton.BackColor = System.Drawing.Color.Transparent
        Me.showAllButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.showAllButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.showAllButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.showAllButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.showAllButton.FocusedColor = System.Drawing.Color.Empty
        Me.showAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showAllButton.ForeColor = System.Drawing.Color.White
        Me.showAllButton.Image = CType(resources.GetObject("showAllButton.Image"), System.Drawing.Image)
        Me.showAllButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.showAllButton.Location = New System.Drawing.Point(696, 55)
        Me.showAllButton.Name = "showAllButton"
        Me.showAllButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.showAllButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.showAllButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.showAllButton.OnHoverForeColor = System.Drawing.Color.White
        Me.showAllButton.OnHoverImage = Nothing
        Me.showAllButton.OnPressedColor = System.Drawing.Color.Black
        Me.showAllButton.Radius = 5
        Me.showAllButton.Size = New System.Drawing.Size(126, 45)
        Me.showAllButton.TabIndex = 71
        Me.showAllButton.Text = "Show All"
        '
        'filterButton
        '
        Me.filterButton.AnimationHoverSpeed = 0.07!
        Me.filterButton.AnimationSpeed = 0.03!
        Me.filterButton.BackColor = System.Drawing.Color.Transparent
        Me.filterButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.filterButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.filterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.filterButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.filterButton.FocusedColor = System.Drawing.Color.Empty
        Me.filterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterButton.ForeColor = System.Drawing.Color.White
        Me.filterButton.Image = CType(resources.GetObject("filterButton.Image"), System.Drawing.Image)
        Me.filterButton.ImageOffsetX = 15
        Me.filterButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.filterButton.Location = New System.Drawing.Point(564, 55)
        Me.filterButton.Name = "filterButton"
        Me.filterButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.filterButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.filterButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.filterButton.OnHoverForeColor = System.Drawing.Color.White
        Me.filterButton.OnHoverImage = Nothing
        Me.filterButton.OnPressedColor = System.Drawing.Color.Black
        Me.filterButton.Radius = 5
        Me.filterButton.Size = New System.Drawing.Size(126, 45)
        Me.filterButton.TabIndex = 72
        Me.filterButton.Text = "Filter"
        '
        'fuelReportTable
        '
        Me.fuelReportTable.AllowUserToAddRows = False
        Me.fuelReportTable.AllowUserToResizeColumns = False
        Me.fuelReportTable.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.fuelReportTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.fuelReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.fuelReportTable.BackgroundColor = System.Drawing.Color.White
        Me.fuelReportTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fuelReportTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fuelReportTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.fuelReportTable.ColumnHeadersHeight = 60
        Me.fuelReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.fuelReportTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fuelReportTable.DefaultCellStyle = DataGridViewCellStyle6
        Me.fuelReportTable.EnableHeadersVisualStyles = False
        Me.fuelReportTable.GridColor = System.Drawing.Color.LightGray
        Me.fuelReportTable.Location = New System.Drawing.Point(99, 370)
        Me.fuelReportTable.Name = "fuelReportTable"
        Me.fuelReportTable.ReadOnly = True
        Me.fuelReportTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.fuelReportTable.RowHeadersVisible = False
        Me.fuelReportTable.RowHeadersWidth = 55
        Me.fuelReportTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.fuelReportTable.RowTemplate.Height = 40
        Me.fuelReportTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.fuelReportTable.ShowCellErrors = False
        Me.fuelReportTable.ShowRowErrors = False
        Me.fuelReportTable.Size = New System.Drawing.Size(1492, 528)
        Me.fuelReportTable.StandardTab = True
        Me.fuelReportTable.TabIndex = 74
        Me.fuelReportTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WhiteGrid
        Me.fuelReportTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.fuelReportTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.fuelReportTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.fuelReportTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.fuelReportTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.fuelReportTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.fuelReportTable.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.fuelReportTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.fuelReportTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.fuelReportTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fuelReportTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.fuelReportTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.fuelReportTable.ThemeStyle.HeaderStyle.Height = 60
        Me.fuelReportTable.ThemeStyle.ReadOnly = True
        Me.fuelReportTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.fuelReportTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.fuelReportTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fuelReportTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.fuelReportTable.ThemeStyle.RowsStyle.Height = 40
        Me.fuelReportTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.fuelReportTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Id"
        Me.Column9.FillWeight = 50.0!
        Me.Column9.HeaderText = "ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Date_added"
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Regular"
        Me.Column2.HeaderText = "Regular (Liters)"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Premium"
        Me.Column3.HeaderText = "Premium (Liters)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Diesel"
        Me.Column4.HeaderText = "Diesel (Liters)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Price_Regular"
        Me.Column6.FillWeight = 60.0!
        Me.Column6.HeaderText = "Price Regular"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Price_Premium"
        Me.Column7.FillWeight = 60.0!
        Me.Column7.HeaderText = "Price Premium"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Price_Diesel"
        Me.Column8.FillWeight = 60.0!
        Me.Column8.HeaderText = "Price   Diesel"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(36, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 33)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "/ INVENTORY / ARCHIVE INVENTORY REPORT"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 30.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 70
        '
        'FuelReportPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "FuelReportPanel"
        Me.Size = New System.Drawing.Size(1691, 982)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fuelReportTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents fuelReportTable As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerFrom As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents DateTimePickerTo As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents exportExcelButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents exportPDFButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents PrintButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents showAllButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents filterButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox2 As GroupBox
End Class

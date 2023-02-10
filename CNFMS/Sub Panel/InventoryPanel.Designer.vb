<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryPanel))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerFrom = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.addFuelButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.inventory_table = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deduction = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GunaLinePanel7 = New Guna.UI.WinForms.GunaLinePanel()
        Me.priceTxt3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GunaLinePanel6 = New Guna.UI.WinForms.GunaLinePanel()
        Me.priceTxt2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GunaLinePanel3 = New Guna.UI.WinForms.GunaLinePanel()
        Me.priceTxt1 = New System.Windows.Forms.Label()
        Me.priceTxt = New System.Windows.Forms.Label()
        Me.GunaLinePanel5 = New Guna.UI.WinForms.GunaLinePanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.showTotalTxt = New System.Windows.Forms.Label()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showPremiumTxt = New System.Windows.Forms.Label()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalLiters_RegularTxt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GunaPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.inventory_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel7.SuspendLayout()
        Me.GunaLinePanel6.SuspendLayout()
        Me.GunaLinePanel3.SuspendLayout()
        Me.GunaLinePanel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.GroupBox1)
        Me.GunaPanel1.Controls.Add(Me.inventory_table)
        Me.GunaPanel1.Controls.Add(Me.GunaLinePanel7)
        Me.GunaPanel1.Controls.Add(Me.GunaLinePanel6)
        Me.GunaPanel1.Controls.Add(Me.GunaLinePanel3)
        Me.GunaPanel1.Controls.Add(Me.GunaLinePanel5)
        Me.GunaPanel1.Controls.Add(Me.GunaLinePanel1)
        Me.GunaPanel1.Controls.Add(Me.GunaLinePanel2)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1691, 982)
        Me.GunaPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePickerFrom)
        Me.GroupBox1.Controls.Add(Me.GunaGradientButton2)
        Me.GroupBox1.Controls.Add(Me.addFuelButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(121, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1492, 107)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADD INVENTORY, UPDATE PRICE"
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerFrom.BaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateTimePickerFrom.CustomFormat = Nothing
        Me.DateTimePickerFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePickerFrom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.ForeColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(14, 42)
        Me.DateTimePickerFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePickerFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateTimePickerFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.DateTimePickerFrom.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePickerFrom.Radius = 5
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(315, 45)
        Me.DateTimePickerFrom.TabIndex = 76
        Me.DateTimePickerFrom.Text = "Tuesday, November 8, 2022"
        Me.DateTimePickerFrom.Value = New Date(2022, 11, 8, 1, 26, 20, 819)
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = CType(resources.GetObject("GunaGradientButton2.Image"), System.Drawing.Image)
        Me.GunaGradientButton2.ImageOffsetX = 15
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(477, 42)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 5
        Me.GunaGradientButton2.Size = New System.Drawing.Size(126, 45)
        Me.GunaGradientButton2.TabIndex = 75
        Me.GunaGradientButton2.Text = "Price"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaGradientButton2.TextOffsetX = 25
        '
        'addFuelButton
        '
        Me.addFuelButton.AnimationHoverSpeed = 0.07!
        Me.addFuelButton.AnimationSpeed = 0.03!
        Me.addFuelButton.BackColor = System.Drawing.Color.Transparent
        Me.addFuelButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.addFuelButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.addFuelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.addFuelButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.addFuelButton.FocusedColor = System.Drawing.Color.Empty
        Me.addFuelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addFuelButton.ForeColor = System.Drawing.Color.White
        Me.addFuelButton.Image = CType(resources.GetObject("addFuelButton.Image"), System.Drawing.Image)
        Me.addFuelButton.ImageOffsetX = 15
        Me.addFuelButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.addFuelButton.Location = New System.Drawing.Point(345, 42)
        Me.addFuelButton.Name = "addFuelButton"
        Me.addFuelButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.addFuelButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.addFuelButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.addFuelButton.OnHoverForeColor = System.Drawing.Color.White
        Me.addFuelButton.OnHoverImage = Nothing
        Me.addFuelButton.OnPressedColor = System.Drawing.Color.Black
        Me.addFuelButton.Radius = 5
        Me.addFuelButton.Size = New System.Drawing.Size(126, 45)
        Me.addFuelButton.TabIndex = 73
        Me.addFuelButton.Text = "Add"
        '
        'inventory_table
        '
        Me.inventory_table.AllowUserToAddRows = False
        Me.inventory_table.AllowUserToResizeColumns = False
        Me.inventory_table.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.inventory_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.inventory_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.inventory_table.BackgroundColor = System.Drawing.Color.White
        Me.inventory_table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inventory_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inventory_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.inventory_table.ColumnHeadersHeight = 60
        Me.inventory_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.inventory_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column8, Me.deduction})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.inventory_table.DefaultCellStyle = DataGridViewCellStyle7
        Me.inventory_table.EnableHeadersVisualStyles = False
        Me.inventory_table.GridColor = System.Drawing.Color.LightGray
        Me.inventory_table.Location = New System.Drawing.Point(121, 422)
        Me.inventory_table.Name = "inventory_table"
        Me.inventory_table.ReadOnly = True
        Me.inventory_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inventory_table.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.inventory_table.RowHeadersVisible = False
        Me.inventory_table.RowHeadersWidth = 55
        Me.inventory_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.inventory_table.RowTemplate.Height = 40
        Me.inventory_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventory_table.ShowCellErrors = False
        Me.inventory_table.ShowRowErrors = False
        Me.inventory_table.Size = New System.Drawing.Size(1492, 485)
        Me.inventory_table.StandardTab = True
        Me.inventory_table.TabIndex = 73
        Me.inventory_table.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WhiteGrid
        Me.inventory_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.inventory_table.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.inventory_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.inventory_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.inventory_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.inventory_table.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.inventory_table.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.inventory_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.inventory_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.inventory_table.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventory_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.inventory_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.inventory_table.ThemeStyle.HeaderStyle.Height = 60
        Me.inventory_table.ThemeStyle.ReadOnly = True
        Me.inventory_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.inventory_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.inventory_table.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventory_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.inventory_table.ThemeStyle.RowsStyle.Height = 40
        Me.inventory_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.inventory_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Id"
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "ID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Premium"
        Me.Column3.HeaderText = "Premium (Liters)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Diesel"
        Me.Column4.HeaderText = "Diesel (Liters)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Price_Regular"
        Me.Column6.FillWeight = 50.0!
        Me.Column6.HeaderText = "Price Regular"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Price_Premium"
        Me.Column7.FillWeight = 60.0!
        Me.Column7.HeaderText = "Price Premium"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Price_Diesel"
        Me.Column8.FillWeight = 50.0!
        Me.Column8.HeaderText = "Price Diesel"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'deduction
        '
        Me.deduction.FillWeight = 25.0!
        Me.deduction.HeaderText = ""
        Me.deduction.Image = CType(resources.GetObject("deduction.Image"), System.Drawing.Image)
        Me.deduction.Name = "deduction"
        Me.deduction.ReadOnly = True
        '
        'GunaLinePanel7
        '
        Me.GunaLinePanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.GunaLinePanel7.Controls.Add(Me.priceTxt3)
        Me.GunaLinePanel7.Controls.Add(Me.Label15)
        Me.GunaLinePanel7.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel7.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel7.Location = New System.Drawing.Point(1164, 187)
        Me.GunaLinePanel7.Name = "GunaLinePanel7"
        Me.GunaLinePanel7.Size = New System.Drawing.Size(449, 57)
        Me.GunaLinePanel7.TabIndex = 59
        '
        'priceTxt3
        '
        Me.priceTxt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.priceTxt3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceTxt3.ForeColor = System.Drawing.Color.White
        Me.priceTxt3.Location = New System.Drawing.Point(198, 0)
        Me.priceTxt3.Name = "priceTxt3"
        Me.priceTxt3.Size = New System.Drawing.Size(250, 57)
        Me.priceTxt3.TabIndex = 1
        Me.priceTxt3.Text = "P 00.00"
        Me.priceTxt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(-7, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(303, 53)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "PRICE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLinePanel6
        '
        Me.GunaLinePanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.GunaLinePanel6.Controls.Add(Me.priceTxt2)
        Me.GunaLinePanel6.Controls.Add(Me.Label13)
        Me.GunaLinePanel6.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel6.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel6.Location = New System.Drawing.Point(645, 187)
        Me.GunaLinePanel6.Name = "GunaLinePanel6"
        Me.GunaLinePanel6.Size = New System.Drawing.Size(449, 57)
        Me.GunaLinePanel6.TabIndex = 59
        '
        'priceTxt2
        '
        Me.priceTxt2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceTxt2.ForeColor = System.Drawing.Color.White
        Me.priceTxt2.Location = New System.Drawing.Point(189, -2)
        Me.priceTxt2.Name = "priceTxt2"
        Me.priceTxt2.Size = New System.Drawing.Size(260, 57)
        Me.priceTxt2.TabIndex = 1
        Me.priceTxt2.Text = "P 00.00"
        Me.priceTxt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, -3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(277, 57)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "PRICE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLinePanel3
        '
        Me.GunaLinePanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaLinePanel3.Controls.Add(Me.priceTxt1)
        Me.GunaLinePanel3.Controls.Add(Me.priceTxt)
        Me.GunaLinePanel3.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel3.Location = New System.Drawing.Point(121, 186)
        Me.GunaLinePanel3.Name = "GunaLinePanel3"
        Me.GunaLinePanel3.Size = New System.Drawing.Size(449, 57)
        Me.GunaLinePanel3.TabIndex = 59
        '
        'priceTxt1
        '
        Me.priceTxt1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceTxt1.ForeColor = System.Drawing.Color.White
        Me.priceTxt1.Location = New System.Drawing.Point(188, -2)
        Me.priceTxt1.Name = "priceTxt1"
        Me.priceTxt1.Size = New System.Drawing.Size(261, 57)
        Me.priceTxt1.TabIndex = 1
        Me.priceTxt1.Text = "P 00.00"
        Me.priceTxt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'priceTxt
        '
        Me.priceTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceTxt.ForeColor = System.Drawing.Color.White
        Me.priceTxt.Location = New System.Drawing.Point(0, 1)
        Me.priceTxt.Name = "priceTxt"
        Me.priceTxt.Size = New System.Drawing.Size(299, 57)
        Me.priceTxt.TabIndex = 1
        Me.priceTxt.Text = "PRICE"
        Me.priceTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLinePanel5
        '
        Me.GunaLinePanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.GunaLinePanel5.Controls.Add(Me.PictureBox3)
        Me.GunaLinePanel5.Controls.Add(Me.Label4)
        Me.GunaLinePanel5.Controls.Add(Me.showTotalTxt)
        Me.GunaLinePanel5.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel5.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel5.Location = New System.Drawing.Point(1164, 80)
        Me.GunaLinePanel5.Name = "GunaLinePanel5"
        Me.GunaLinePanel5.Size = New System.Drawing.Size(449, 107)
        Me.GunaLinePanel5.TabIndex = 58
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(357, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 81)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Liters Diesel (Available)"
        '
        'showTotalTxt
        '
        Me.showTotalTxt.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showTotalTxt.ForeColor = System.Drawing.Color.White
        Me.showTotalTxt.Location = New System.Drawing.Point(7, 20)
        Me.showTotalTxt.Name = "showTotalTxt"
        Me.showTotalTxt.Size = New System.Drawing.Size(310, 43)
        Me.showTotalTxt.TabIndex = 1
        Me.showTotalTxt.Text = "00"
        Me.showTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.PictureBox2)
        Me.GunaLinePanel1.Controls.Add(Me.Label1)
        Me.GunaLinePanel1.Controls.Add(Me.showPremiumTxt)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(645, 80)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(449, 107)
        Me.GunaLinePanel1.TabIndex = 58
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(356, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 81)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Liters Premium (Available)"
        '
        'showPremiumTxt
        '
        Me.showPremiumTxt.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPremiumTxt.ForeColor = System.Drawing.Color.White
        Me.showPremiumTxt.Location = New System.Drawing.Point(8, 26)
        Me.showPremiumTxt.Name = "showPremiumTxt"
        Me.showPremiumTxt.Size = New System.Drawing.Size(303, 43)
        Me.showPremiumTxt.TabIndex = 1
        Me.showPremiumTxt.Text = "00"
        Me.showPremiumTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaLinePanel2.Controls.Add(Me.PictureBox1)
        Me.GunaLinePanel2.Controls.Add(Me.Label7)
        Me.GunaLinePanel2.Controls.Add(Me.TotalLiters_RegularTxt)
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(121, 80)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(449, 107)
        Me.GunaLinePanel2.TabIndex = 58
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(356, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 81)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(10, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(289, 27)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total Liters Regular (Available)"
        '
        'TotalLiters_RegularTxt
        '
        Me.TotalLiters_RegularTxt.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLiters_RegularTxt.ForeColor = System.Drawing.Color.White
        Me.TotalLiters_RegularTxt.Location = New System.Drawing.Point(16, 26)
        Me.TotalLiters_RegularTxt.Name = "TotalLiters_RegularTxt"
        Me.TotalLiters_RegularTxt.Size = New System.Drawing.Size(315, 43)
        Me.TotalLiters_RegularTxt.TabIndex = 1
        Me.TotalLiters_RegularTxt.Text = "00"
        Me.TotalLiters_RegularTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 33)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "/ INVENTORY"
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 30.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 68
        '
        'InventoryPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "InventoryPanel"
        Me.Size = New System.Drawing.Size(1691, 982)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.inventory_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel7.ResumeLayout(False)
        Me.GunaLinePanel6.ResumeLayout(False)
        Me.GunaLinePanel3.ResumeLayout(False)
        Me.GunaLinePanel5.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents TotalLiters_RegularTxt As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GunaLinePanel5 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label4 As Label
    Friend WithEvents showTotalTxt As Label
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label1 As Label
    Friend WithEvents showPremiumTxt As Label
    Friend WithEvents priceTxt As Label
    Friend WithEvents GunaLinePanel3 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel7 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents priceTxt3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GunaLinePanel6 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents priceTxt2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents inventory_table As Guna.UI.WinForms.GunaDataGridView
    Public WithEvents priceTxt1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents addFuelButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DateTimePickerFrom As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents deduction As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class

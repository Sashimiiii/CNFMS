<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PriceFuelPanel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PriceFuelPanel))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.priceTable = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.updatePriceFuel3 = New Guna.UI.WinForms.GunaTextBox()
        Me.updatePriceFuel2 = New Guna.UI.WinForms.GunaTextBox()
        Me.updatePriceFuel1 = New Guna.UI.WinForms.GunaTextBox()
        Me.saveButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.priceTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.White
        Me.GunaLinePanel1.Controls.Add(Me.priceTable)
        Me.GunaLinePanel1.Controls.Add(Me.Label6)
        Me.GunaLinePanel1.Controls.Add(Me.Label5)
        Me.GunaLinePanel1.Controls.Add(Me.Label8)
        Me.GunaLinePanel1.Controls.Add(Me.Label9)
        Me.GunaLinePanel1.Controls.Add(Me.updatePriceFuel3)
        Me.GunaLinePanel1.Controls.Add(Me.updatePriceFuel2)
        Me.GunaLinePanel1.Controls.Add(Me.updatePriceFuel1)
        Me.GunaLinePanel1.Controls.Add(Me.saveButton)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaLinePanel1.TabIndex = 0
        '
        'priceTable
        '
        Me.priceTable.AllowUserToAddRows = False
        Me.priceTable.AllowUserToResizeColumns = False
        Me.priceTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.priceTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.priceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.priceTable.BackgroundColor = System.Drawing.Color.White
        Me.priceTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.priceTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.priceTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.priceTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.priceTable.ColumnHeadersHeight = 60
        Me.priceTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.priceTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.priceTable.EnableHeadersVisualStyles = False
        Me.priceTable.GridColor = System.Drawing.Color.LightGray
        Me.priceTable.Location = New System.Drawing.Point(68, 91)
        Me.priceTable.Name = "priceTable"
        Me.priceTable.ReadOnly = True
        Me.priceTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.priceTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.priceTable.RowHeadersVisible = False
        Me.priceTable.RowHeadersWidth = 55
        Me.priceTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.priceTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.priceTable.RowTemplate.Height = 50
        Me.priceTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.priceTable.ShowCellErrors = False
        Me.priceTable.ShowRowErrors = False
        Me.priceTable.Size = New System.Drawing.Size(1534, 130)
        Me.priceTable.StandardTab = True
        Me.priceTable.TabIndex = 132
        Me.priceTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WhiteGrid
        Me.priceTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.priceTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.priceTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.priceTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.priceTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.priceTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.priceTable.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.priceTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.priceTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.priceTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.priceTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.priceTable.ThemeStyle.HeaderStyle.Height = 60
        Me.priceTable.ThemeStyle.ReadOnly = True
        Me.priceTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.priceTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.priceTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.priceTable.ThemeStyle.RowsStyle.Height = 50
        Me.priceTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.priceTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(596, 525)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 23)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Retailed Price Diesel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(596, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 23)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Retailed Price Regular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(596, 440)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 23)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Retailed Price Premium"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(753, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 37)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Update Price"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updatePriceFuel3
        '
        Me.updatePriceFuel3.BackColor = System.Drawing.Color.Transparent
        Me.updatePriceFuel3.BaseColor = System.Drawing.Color.White
        Me.updatePriceFuel3.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.updatePriceFuel3.BorderSize = 1
        Me.updatePriceFuel3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.updatePriceFuel3.FocusedBaseColor = System.Drawing.Color.White
        Me.updatePriceFuel3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.updatePriceFuel3.FocusedForeColor = System.Drawing.Color.Black
        Me.updatePriceFuel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePriceFuel3.ForeColor = System.Drawing.Color.Black
        Me.updatePriceFuel3.Location = New System.Drawing.Point(600, 560)
        Me.updatePriceFuel3.MaxLength = 5
        Me.updatePriceFuel3.Name = "updatePriceFuel3"
        Me.updatePriceFuel3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.updatePriceFuel3.Radius = 6
        Me.updatePriceFuel3.Size = New System.Drawing.Size(473, 37)
        Me.updatePriceFuel3.TabIndex = 126
        Me.updatePriceFuel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.updatePriceFuel3.TextOffsetX = 10
        '
        'updatePriceFuel2
        '
        Me.updatePriceFuel2.BackColor = System.Drawing.Color.Transparent
        Me.updatePriceFuel2.BaseColor = System.Drawing.Color.White
        Me.updatePriceFuel2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.updatePriceFuel2.BorderSize = 1
        Me.updatePriceFuel2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.updatePriceFuel2.FocusedBaseColor = System.Drawing.Color.White
        Me.updatePriceFuel2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.updatePriceFuel2.FocusedForeColor = System.Drawing.Color.Black
        Me.updatePriceFuel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePriceFuel2.ForeColor = System.Drawing.Color.Black
        Me.updatePriceFuel2.Location = New System.Drawing.Point(600, 470)
        Me.updatePriceFuel2.MaxLength = 5
        Me.updatePriceFuel2.Name = "updatePriceFuel2"
        Me.updatePriceFuel2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.updatePriceFuel2.Radius = 6
        Me.updatePriceFuel2.Size = New System.Drawing.Size(473, 37)
        Me.updatePriceFuel2.TabIndex = 125
        Me.updatePriceFuel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.updatePriceFuel2.TextOffsetX = 10
        '
        'updatePriceFuel1
        '
        Me.updatePriceFuel1.BackColor = System.Drawing.Color.Transparent
        Me.updatePriceFuel1.BaseColor = System.Drawing.Color.White
        Me.updatePriceFuel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.updatePriceFuel1.BorderSize = 1
        Me.updatePriceFuel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.updatePriceFuel1.FocusedBaseColor = System.Drawing.Color.White
        Me.updatePriceFuel1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.updatePriceFuel1.FocusedForeColor = System.Drawing.Color.Black
        Me.updatePriceFuel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePriceFuel1.ForeColor = System.Drawing.Color.Black
        Me.updatePriceFuel1.Location = New System.Drawing.Point(600, 370)
        Me.updatePriceFuel1.MaxLength = 5
        Me.updatePriceFuel1.Name = "updatePriceFuel1"
        Me.updatePriceFuel1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.updatePriceFuel1.Radius = 6
        Me.updatePriceFuel1.Size = New System.Drawing.Size(473, 37)
        Me.updatePriceFuel1.TabIndex = 124
        Me.updatePriceFuel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.updatePriceFuel1.TextOffsetX = 10
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
        Me.saveButton.FocusedColor = System.Drawing.Color.Empty
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.White
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saveButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.saveButton.Location = New System.Drawing.Point(600, 639)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.saveButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.saveButton.OnHoverForeColor = System.Drawing.Color.White
        Me.saveButton.OnHoverImage = Nothing
        Me.saveButton.OnPressedColor = System.Drawing.Color.Black
        Me.saveButton.Radius = 6
        Me.saveButton.Size = New System.Drawing.Size(190, 50)
        Me.saveButton.TabIndex = 117
        Me.saveButton.Text = "Submit  Changes"
        Me.saveButton.TextOffsetX = 10
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "price_fuel1"
        Me.Column9.FillWeight = 55.0!
        Me.Column9.HeaderText = "Regular"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "price_fuel2"
        Me.Column1.HeaderText = "Premium"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "price_fuel3"
        Me.Column2.FillWeight = 70.0!
        Me.Column2.HeaderText = "Diesel"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'PriceFuelPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Name = "PriceFuelPanel"
        Me.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.priceTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents saveButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents updatePriceFuel3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents updatePriceFuel2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents updatePriceFuel1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents priceTable As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class

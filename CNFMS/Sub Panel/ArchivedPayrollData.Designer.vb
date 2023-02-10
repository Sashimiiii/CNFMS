<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArchivedPayrollData
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArchivedPayrollData))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ArchivedpayrollTable = New Guna.UI.WinForms.GunaDataGridView()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exportPDFButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.ArchivedpayrollTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ArchivedpayrollTable)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1691, 982)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(506, 33)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "/ ARCHIVED PAYROLL DATA"
        '
        'ArchivedpayrollTable
        '
        Me.ArchivedpayrollTable.AllowUserToAddRows = False
        Me.ArchivedpayrollTable.AllowUserToResizeColumns = False
        Me.ArchivedpayrollTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ArchivedpayrollTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ArchivedpayrollTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ArchivedpayrollTable.BackgroundColor = System.Drawing.Color.White
        Me.ArchivedpayrollTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ArchivedpayrollTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ArchivedpayrollTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ArchivedpayrollTable.ColumnHeadersHeight = 60
        Me.ArchivedpayrollTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column16, Me.Column17, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column10, Me.Column7, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.deleteData})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ArchivedpayrollTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.ArchivedpayrollTable.EnableHeadersVisualStyles = False
        Me.ArchivedpayrollTable.GridColor = System.Drawing.Color.LightGray
        Me.ArchivedpayrollTable.Location = New System.Drawing.Point(33, 111)
        Me.ArchivedpayrollTable.Name = "ArchivedpayrollTable"
        Me.ArchivedpayrollTable.ReadOnly = True
        Me.ArchivedpayrollTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ArchivedpayrollTable.RowHeadersVisible = False
        Me.ArchivedpayrollTable.RowHeadersWidth = 55
        Me.ArchivedpayrollTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ArchivedpayrollTable.RowTemplate.Height = 50
        Me.ArchivedpayrollTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ArchivedpayrollTable.ShowCellErrors = False
        Me.ArchivedpayrollTable.ShowRowErrors = False
        Me.ArchivedpayrollTable.Size = New System.Drawing.Size(1617, 668)
        Me.ArchivedpayrollTable.StandardTab = True
        Me.ArchivedpayrollTable.TabIndex = 89
        Me.ArchivedpayrollTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WhiteGrid
        Me.ArchivedpayrollTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ArchivedpayrollTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ArchivedpayrollTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ArchivedpayrollTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ArchivedpayrollTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ArchivedpayrollTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ArchivedpayrollTable.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.ArchivedpayrollTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.ArchivedpayrollTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.ArchivedpayrollTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivedpayrollTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.ArchivedpayrollTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ArchivedpayrollTable.ThemeStyle.HeaderStyle.Height = 60
        Me.ArchivedpayrollTable.ThemeStyle.ReadOnly = True
        Me.ArchivedpayrollTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ArchivedpayrollTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.ArchivedpayrollTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivedpayrollTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ArchivedpayrollTable.ThemeStyle.RowsStyle.Height = 50
        Me.ArchivedpayrollTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ArchivedpayrollTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Id"
        Me.Column9.FillWeight = 50.0!
        Me.Column9.HeaderText = "No."
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 67
        '
        'Column16
        '
        Me.Column16.DataPropertyName = "DateFrom"
        Me.Column16.HeaderText = "Period From"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 132
        '
        'Column17
        '
        Me.Column17.DataPropertyName = "DateTo"
        Me.Column17.HeaderText = "Period To"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 109
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
        Me.Column2.Width = 142
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "BasicDaily"
        Me.Column3.FillWeight = 80.0!
        Me.Column3.HeaderText = "Daily Pay"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 106
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "numberDays"
        Me.Column4.FillWeight = 40.0!
        Me.Column4.HeaderText = "# Duty Days"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 129
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "BasicPay"
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "Basic Pay"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 106
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "RegularHoliday"
        Me.Column6.FillWeight = 50.0!
        Me.Column6.HeaderText = "Regular Holiday"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 162
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "SpecialHoliday"
        Me.Column8.FillWeight = 50.0!
        Me.Column8.HeaderText = "Special Holiday"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 156
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
        Me.Column7.Width = 105
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "SSS"
        Me.Column11.FillWeight = 50.0!
        Me.Column11.HeaderText = "SSS"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 68
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "PHIC"
        Me.Column12.FillWeight = 50.0!
        Me.Column12.HeaderText = "PHIC"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 80
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "HDMF"
        Me.Column13.FillWeight = 50.0!
        Me.Column13.HeaderText = "HDMF"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 92
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "TotalDeduction"
        Me.Column14.HeaderText = "Total Deductions"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 167
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.exportPDFButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(33, 797)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1617, 113)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EXPORT"
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
        Me.exportPDFButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportPDFButton.ForeColor = System.Drawing.Color.White
        Me.exportPDFButton.Image = CType(resources.GetObject("exportPDFButton.Image"), System.Drawing.Image)
        Me.exportPDFButton.ImageOffsetX = 15
        Me.exportPDFButton.ImageSize = New System.Drawing.Size(30, 30)
        Me.exportPDFButton.Location = New System.Drawing.Point(17, 46)
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 80.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.MinimumWidth = 50
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'ArchivedPayrollData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ArchivedPayrollData"
        Me.Size = New System.Drawing.Size(1691, 982)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ArchivedpayrollTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents exportPDFButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents ArchivedpayrollTable As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label2 As Label
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
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class

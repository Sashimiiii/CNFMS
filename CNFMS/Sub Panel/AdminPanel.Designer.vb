<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPanel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.addButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.AdminTable = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updateData = New System.Windows.Forms.DataGridViewImageColumn()
        Me.deleteData = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SearchTxt = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.AdminTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.addButton)
        Me.GunaPanel1.Controls.Add(Me.AdminTable)
        Me.GunaPanel1.Controls.Add(Me.SearchTxt)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.TabIndex = 0
        '
        'addButton
        '
        Me.addButton.AnimationHoverSpeed = 0.07!
        Me.addButton.AnimationSpeed = 0.03!
        Me.addButton.BackColor = System.Drawing.Color.Transparent
        Me.addButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.addButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.addButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.addButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.addButton.FocusedColor = System.Drawing.Color.Empty
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.Color.White
        Me.addButton.Image = CType(resources.GetObject("addButton.Image"), System.Drawing.Image)
        Me.addButton.ImageOffsetX = 15
        Me.addButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.addButton.Location = New System.Drawing.Point(65, 906)
        Me.addButton.Name = "addButton"
        Me.addButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.addButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.addButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.addButton.OnHoverForeColor = System.Drawing.Color.White
        Me.addButton.OnHoverImage = Nothing
        Me.addButton.OnPressedColor = System.Drawing.Color.Black
        Me.addButton.Radius = 5
        Me.addButton.Size = New System.Drawing.Size(129, 51)
        Me.addButton.TabIndex = 91
        Me.addButton.Text = "Add New"
        '
        'AdminTable
        '
        Me.AdminTable.AllowUserToAddRows = False
        Me.AdminTable.AllowUserToResizeColumns = False
        Me.AdminTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.AdminTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AdminTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AdminTable.BackgroundColor = System.Drawing.Color.White
        Me.AdminTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AdminTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.AdminTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdminTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AdminTable.ColumnHeadersHeight = 60
        Me.AdminTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.updateData, Me.deleteData})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AdminTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.AdminTable.EnableHeadersVisualStyles = False
        Me.AdminTable.GridColor = System.Drawing.Color.LightGray
        Me.AdminTable.Location = New System.Drawing.Point(65, 155)
        Me.AdminTable.Name = "AdminTable"
        Me.AdminTable.ReadOnly = True
        Me.AdminTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AdminTable.RowHeadersVisible = False
        Me.AdminTable.RowHeadersWidth = 55
        Me.AdminTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AdminTable.RowTemplate.Height = 50
        Me.AdminTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AdminTable.ShowCellErrors = False
        Me.AdminTable.ShowRowErrors = False
        Me.AdminTable.Size = New System.Drawing.Size(1534, 713)
        Me.AdminTable.StandardTab = True
        Me.AdminTable.TabIndex = 90
        Me.AdminTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WhiteGrid
        Me.AdminTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AdminTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.AdminTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.AdminTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.AdminTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.AdminTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.AdminTable.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.AdminTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AdminTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AdminTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.AdminTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.AdminTable.ThemeStyle.HeaderStyle.Height = 60
        Me.AdminTable.ThemeStyle.ReadOnly = True
        Me.AdminTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AdminTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.AdminTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.AdminTable.ThemeStyle.RowsStyle.Height = 50
        Me.AdminTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.AdminTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Id"
        Me.Column9.FillWeight = 55.0!
        Me.Column9.HeaderText = "ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Username"
        Me.Column5.HeaderText = "Username"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "fullname"
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "contact_number"
        Me.Column2.HeaderText = "Contact #"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "email"
        Me.Column3.HeaderText = "Email"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "role"
        Me.Column4.HeaderText = "Role"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'updateData
        '
        Me.updateData.FillWeight = 20.0!
        Me.updateData.HeaderText = ""
        Me.updateData.Image = CType(resources.GetObject("updateData.Image"), System.Drawing.Image)
        Me.updateData.Name = "updateData"
        Me.updateData.ReadOnly = True
        '
        'deleteData
        '
        Me.deleteData.FillWeight = 20.0!
        Me.deleteData.HeaderText = ""
        Me.deleteData.Image = CType(resources.GetObject("deleteData.Image"), System.Drawing.Image)
        Me.deleteData.Name = "deleteData"
        Me.deleteData.ReadOnly = True
        '
        'SearchTxt
        '
        Me.SearchTxt.BackColor = System.Drawing.Color.Transparent
        Me.SearchTxt.BaseColor = System.Drawing.Color.White
        Me.SearchTxt.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTxt.FocusedBaseColor = System.Drawing.Color.White
        Me.SearchTxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.SearchTxt.FocusedForeColor = System.Drawing.Color.Black
        Me.SearchTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxt.ForeColor = System.Drawing.Color.Black
        Me.SearchTxt.Location = New System.Drawing.Point(65, 86)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTxt.Radius = 5
        Me.SearchTxt.Size = New System.Drawing.Size(1534, 49)
        Me.SearchTxt.TabIndex = 89
        Me.SearchTxt.Text = "Search"
        Me.SearchTxt.TextOffsetX = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(506, 33)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "/ ADMIN"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 20.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 51
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.FillWeight = 20.0!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 52
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "AdminPanel"
        Me.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.AdminTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchTxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents AdminTable As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents updateData As DataGridViewImageColumn
    Friend WithEvents deleteData As DataGridViewImageColumn
    Friend WithEvents addButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
End Class

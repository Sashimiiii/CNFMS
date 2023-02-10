<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintIsland3Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintIsland3Report))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.backButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.Island3Viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.backButton)
        Me.GunaPanel1.Controls.Add(Me.Island3Viewer)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.TabIndex = 0
        '
        'backButton
        '
        Me.backButton.AnimationHoverSpeed = 0.07!
        Me.backButton.AnimationSpeed = 0.03!
        Me.backButton.BackColor = System.Drawing.Color.Transparent
        Me.backButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.backButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.backButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.backButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.backButton.FocusedColor = System.Drawing.Color.Empty
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.Color.White
        Me.backButton.Image = CType(resources.GetObject("backButton.Image"), System.Drawing.Image)
        Me.backButton.ImageOffsetX = 15
        Me.backButton.ImageSize = New System.Drawing.Size(22, 22)
        Me.backButton.Location = New System.Drawing.Point(3, 77)
        Me.backButton.Name = "backButton"
        Me.backButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.backButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.backButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.backButton.OnHoverForeColor = System.Drawing.Color.White
        Me.backButton.OnHoverImage = Nothing
        Me.backButton.OnPressedColor = System.Drawing.Color.Black
        Me.backButton.Radius = 5
        Me.backButton.Size = New System.Drawing.Size(149, 54)
        Me.backButton.TabIndex = 86
        Me.backButton.Text = "Go Back"
        '
        'Island3Viewer
        '
        Me.Island3Viewer.ActiveViewIndex = -1
        Me.Island3Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Island3Viewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.Island3Viewer.Location = New System.Drawing.Point(0, 136)
        Me.Island3Viewer.Name = "Island3Viewer"
        Me.Island3Viewer.ShowCloseButton = False
        Me.Island3Viewer.ShowCopyButton = False
        Me.Island3Viewer.ShowExportButton = False
        Me.Island3Viewer.ShowGroupTreeButton = False
        Me.Island3Viewer.ShowLogo = False
        Me.Island3Viewer.ShowParameterPanelButton = False
        Me.Island3Viewer.ShowTextSearchButton = False
        Me.Island3Viewer.Size = New System.Drawing.Size(1685, 848)
        Me.Island3Viewer.TabIndex = 85
        Me.Island3Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(506, 33)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "/ CUT-OFF / ISLAND 3/ SHOW REPORT"
        '
        'PrintIsland3Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "PrintIsland3Report"
        Me.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents backButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Island3Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As Label
End Class

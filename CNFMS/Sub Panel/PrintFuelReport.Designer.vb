<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintFuelReport
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
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.FuelReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.White
        Me.GunaLinePanel1.Controls.Add(Me.FuelReportViewer)
        Me.GunaLinePanel1.Controls.Add(Me.Label2)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1729, 982)
        Me.GunaLinePanel1.TabIndex = 0
        '
        'FuelReportViewer
        '
        Me.FuelReportViewer.ActiveViewIndex = -1
        Me.FuelReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FuelReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.FuelReportViewer.Location = New System.Drawing.Point(0, 64)
        Me.FuelReportViewer.Name = "FuelReportViewer"
        Me.FuelReportViewer.ShowCloseButton = False
        Me.FuelReportViewer.ShowCopyButton = False
        Me.FuelReportViewer.ShowExportButton = False
        Me.FuelReportViewer.ShowGroupTreeButton = False
        Me.FuelReportViewer.ShowLogo = False
        Me.FuelReportViewer.ShowParameterPanelButton = False
        Me.FuelReportViewer.ShowTextSearchButton = False
        Me.FuelReportViewer.Size = New System.Drawing.Size(1729, 918)
        Me.FuelReportViewer.TabIndex = 58
        Me.FuelReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(506, 33)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "/ INVENTORY / FUEL REPORT / SHOW REPORT"
        '
        'PrintFuelReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Name = "PrintFuelReport"
        Me.Size = New System.Drawing.Size(1729, 982)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label2 As Label
    Friend WithEvents FuelReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class

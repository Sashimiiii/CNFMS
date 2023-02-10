<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportViewerPayroll
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
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.PayrollPrintViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.PayrollPrintViewer)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.TabIndex = 0
        '
        'PayrollPrintViewer
        '
        Me.PayrollPrintViewer.ActiveViewIndex = -1
        Me.PayrollPrintViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PayrollPrintViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.PayrollPrintViewer.Location = New System.Drawing.Point(3, 32)
        Me.PayrollPrintViewer.Name = "PayrollPrintViewer"
        Me.PayrollPrintViewer.ShowCloseButton = False
        Me.PayrollPrintViewer.ShowCopyButton = False
        Me.PayrollPrintViewer.ShowExportButton = False
        Me.PayrollPrintViewer.ShowGroupTreeButton = False
        Me.PayrollPrintViewer.ShowLogo = False
        Me.PayrollPrintViewer.ShowParameterPanelButton = False
        Me.PayrollPrintViewer.ShowTextSearchButton = False
        Me.PayrollPrintViewer.Size = New System.Drawing.Size(1685, 969)
        Me.PayrollPrintViewer.TabIndex = 89
        Me.PayrollPrintViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ExportViewerPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "ExportViewerPayroll"
        Me.Size = New System.Drawing.Size(1691, 1032)
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PayrollPrintViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class

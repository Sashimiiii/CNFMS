Public Class ArchivedPayrolPdf
    Public Shared PassDateFrom As String = ""
    Public Shared PassDateTo As String = ""
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ArchivedPayrolPdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        DateFromPicker.Value = DateTime.Now
        DateToPicker.Value = DateTime.Now
    End Sub
    Private Sub showreportPanel()
        Dim ShowReport As New ExportViewerPayroll
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowReport.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowReport)
    End Sub
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Me.Close()
        showreportPanel()
        Dim showPrintView As New ExportViewerPayroll
        showPrintView.export_pdf_format()
    End Sub

    Private Sub DateFromPicker_ValueChanged(sender As Object, e As EventArgs) Handles DateFromPicker.ValueChanged
        PassDateFrom = DateFromPicker.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub DateToPicker_ValueChanged(sender As Object, e As EventArgs) Handles DateToPicker.ValueChanged
        PassDateTo = DateToPicker.Value.ToString("yyyy-MM-dd")
    End Sub


End Class
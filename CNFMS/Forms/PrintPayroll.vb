Imports CNFMS.PrintPreviewPayroll
Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Public Class PrintPayroll
    Public Shared PassDateFrom As String = ""
    Public Shared PassDateTo As String = ""
    Dim dialog1 As DialogResult
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property 'CreateParams

    Private Sub PrintPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        DateFromPicker.Value = DateTime.Now
        DateToPicker.Value = DateTime.Now
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Private Sub showreportPanel()
        Dim ShowReport As New PrintPreviewPayroll
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowReport.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowReport)
    End Sub
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Me.Close()
        showreportPanel()
        Dim PrintDialog As New PrintDialog()
        If PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            rpt1.PrintOptions.PrinterName = PrintDialog.PrinterSettings.PrinterName
            rpt1.PrintToPrinter(PrintDialog.PrinterSettings.Copies, PrintDialog.PrinterSettings.Collate, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)

            Using sqlcommand4 As New MySqlCommand()
                Dim PrintOnly As Integer = 1
                With sqlcommand4
                    .CommandText = "UPDATE payroll_data SET print = @printss WHERE print = 0"
                    .Parameters.AddWithValue("@printss", PrintOnly)
                    .Connection = SQLString
                End With
                Try
                    ConnectSQL()
                    sqlcommand4.ExecuteNonQuery()
                    dialog1 = MessageBox.Show("Successfully Printed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

        End If
    End Sub

    Private Sub DateFromPicker_ValueChanged(sender As Object, e As EventArgs) Handles DateFromPicker.ValueChanged
        PassDateFrom = DateFromPicker.Value.ToString("MMM. dd")
    End Sub

    Private Sub DateToPicker_ValueChanged(sender As Object, e As EventArgs) Handles DateToPicker.ValueChanged
        PassDateTo = DateToPicker.Value.ToString("MMM. dd, yyyy")
    End Sub
End Class
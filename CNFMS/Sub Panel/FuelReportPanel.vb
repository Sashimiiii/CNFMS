Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CNFMS.PrintFuelReport
Imports Excel = Microsoft.Office.Interop.Excel

Public Class FuelReportPanel
    Dim dialog1 As DialogResult
    Public Shared PassDateFrom As String = ""
    Public Shared PassDateTo As String = ""

    Public Shared DateFromInventory As String = ""
    Public Shared DateToInventory As String = ""

    Dim dateChartFrom As Date
    Dim dateChartTo As Date

    Private Sub loadInventory()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            Dim dateFrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
            Dim dateTo = DateTimePickerTo.Value.ToString("yyyy-MM-dd")

            With sqlcommand
                '.CommandText = "SELECT inventoryfuel.Id, inventoryfuel.Date_added, inventoryfuel.Regular, inventoryfuel.Premium, inventoryfuel.Diesel, showFuel.price_Fuel, showFuel1.price_Fuel, showFuel2.price_Fuel FROM inventoryfuel JOIN fuelprice AS showFuel ON showFuel.id = inventoryfuel.Price_Regular JOIN fuelprice AS showFuel1 ON showFuel1.id = inventoryfuel.Price_Premium JOIN fuelprice AS showFuel2 ON showFuel2.id = inventoryfuel.Price_Diesel"
                .CommandText = "SELECT Id, Date_added, Regular, Premium, Diesel, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM inventoryfuel"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                fuelReportTable.DataSource = dataTables
                'inventory_table.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub

    Private Sub filterInventory()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            Dim dateFrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
            Dim dateTo = DateTimePickerTo.Value.ToString("yyyy-MM-dd")
            With sqlcommand
                .CommandText = "SELECT Id, Date_added, Regular, Premium, Diesel, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM inventoryfuel WHERE DATE(Date_added) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@datepickerFrom", dateFrom)
                .Parameters.AddWithValue("@datepickerTo", dateTo)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                fuelReportTable.DataSource = dataTables
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub



    Private Sub FuelReportPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePickerFrom.Value = New DateTime((Now.Year), Now.Month, 1)
        DateTimePickerTo.Value = DateSerial(Year(DateTimePickerFrom.Value), Month(DateTimePickerFrom.Value) + 1, 0)
        loadInventory()
    End Sub


    Private Sub filterButton_Click_1(sender As Object, e As EventArgs) Handles filterButton.Click
        filterInventory()
    End Sub

    Private Sub showAllButton_Click(sender As Object, e As EventArgs) Handles showAllButton.Click
        loadInventory()
    End Sub
    Private Sub showreportPanel()
        Dim ShowReport As New PrintFuelReport
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowReport.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowReport)
    End Sub
    Private Sub PrintButton_Click_1(sender As Object, e As EventArgs) Handles PrintButton.Click

        showreportPanel()
        Dim PrintDialog As New PrintDialog()
        If PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            rpt.PrintOptions.PrinterName = PrintDialog.PrinterSettings.PrinterName
            rpt.PrintToPrinter(PrintDialog.PrinterSettings.Copies, PrintDialog.PrinterSettings.Collate, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)
        End If
    End Sub

    Private Sub DateTimePickerFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFrom.ValueChanged
        PassDateFrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
        DateFromInventory = DateTimePickerFrom.Value.ToString("MMM. dd, yyyy")
    End Sub

    Private Sub DateTimePickerTo_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerTo.ValueChanged
        PassDateTo = DateTimePickerTo.Value.ToString("yyyy-MM-dd")
        DateToInventory = DateTimePickerTo.Value.ToString("MMM. dd, yyyy")
    End Sub

    Private Sub exportPDFButton_Click(sender As Object, e As EventArgs) Handles exportPDFButton.Click
        showreportPanel()
        Dim showPrintFuel As New PrintFuelReport
        showPrintFuel.export_pdf_format()
    End Sub

    Private Sub exportExcelButton_Click(sender As Object, e As EventArgs) Handles exportExcelButton.Click
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dt As New DataTable
            Dim dateFrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
            Dim dateTo = DateTimePickerTo.Value.ToString("yyyy-MM-dd")
            With sqlcommand
                .CommandText = "SELECT Date_added, Regular, Premium, Diesel, Price_Regular, Price_Premium, Price_Diesel FROM inventoryfuel WHERE DATE(Date_added) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@datepickerFrom", dateFrom)
                .Parameters.AddWithValue("@datepickerTo", dateTo)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dt.Clear()
                dataAdapter.Fill(dt)

                Dim f As FolderBrowserDialog = New FolderBrowserDialog
                Try
                    If f.ShowDialog() = DialogResult.OK Then
                        'This section help you if your language is not English.
                        System.Threading.Thread.CurrentThread.CurrentCulture =
                        System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
                        Dim oExcel As Excel.Application
                        Dim oBook As Excel.Workbook
                        Dim oSheet As Excel.Worksheet
                        oExcel = CreateObject("Excel.Application")
                        oBook = oExcel.Workbooks.Add(Type.Missing)
                        oSheet = oBook.Worksheets(1)

                        Dim dc As System.Data.DataColumn
                        Dim dr As System.Data.DataRow
                        Dim colIndex As Integer = 0
                        Dim rowIndex As Integer = 0

                        'Export the Columns to excel file
                        For Each dc In dt.Columns
                            colIndex = colIndex + 1
                            oSheet.Cells(1, colIndex) = dc.ColumnName
                        Next

                        'Export the rows to excel file
                        For Each dr In dt.Rows
                            rowIndex = rowIndex + 1
                            colIndex = 0
                            For Each dc In dt.Columns
                                colIndex = colIndex + 1
                                oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                            Next
                        Next

                        'Set final path
                        Dim fileName As String = "\CN Inventory Stock Report" + ".xls"
                        Dim finalPath = f.SelectedPath + fileName
                        oSheet.Columns.AutoFit()
                        'Save file in final path
                        oBook.SaveAs(finalPath, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

                        'Release the objects
                        releaseObject(oSheet)
                        oBook.Close(False, Type.Missing, Type.Missing)
                        releaseObject(oBook)
                        oExcel.Quit()
                        releaseObject(oExcel)
                        'Some time Office application does not quit after automation: 
                        'so i am calling GC.Collect method.
                        GC.Collect()

                        dialog1 = MessageBox.Show("Export done successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
                End Try
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub fuelReportTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles fuelReportTable.CellContentClick

    End Sub
End Class

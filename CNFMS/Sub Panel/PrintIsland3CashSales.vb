Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CNFMS.Island3CashSalePanel






Public Class PrintIsland3CashSales
    Public Shared rpt1 As New Island3CashSalesCrystalReport
    Dim dialog1 As DialogResult

    Dim Island3TotalCashSale As String = "0.00"
    Private Sub TOTALSALES()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT CONCAT('₱ ', FORMAT(SUM(Total_Sale),2)) AS Total_Sale FROM island3_cashsale WHERE Pump_name = @pumps AND DATE(Date_CutOff) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@pumps", Island3PumpName)
                .Parameters.AddWithValue("@datepickerFrom", PassDateFromIsland3)
                .Parameters.AddWithValue("@datepickerTo", PassDateToIsland3)
                .Connection = SQLString
            End With
            Try
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader

                    While dataReader.Read()
                        If IsDBNull(dataReader(0)) Then
                            dialog1 = MessageBox.Show("NO RECORDS FOUND!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Island3TotalCashSale = dataReader.GetString(0)

                        End If
                    End While
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub showCrystalReport()
        Using sqlcommand1 As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dt As New DataTable
            With sqlcommand1
                .CommandText = "SELECT DATE_FORMAT(Date_CutOff, '%m/%d/%Y %h:%i %p')AS Date_CutOff, CONCAT('₱ ', FORMAT(SalesRegular,2)) AS SalesRegular, CONCAT('₱ ', FORMAT(SalesPremium,2)) AS SalesPremium, CONCAT('₱ ', FORMAT(SalesDiesel,2)) AS SalesDiesel, CONCAT('₱ ', FORMAT(Total_Sale,2)) AS Total_Sale, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS  Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM island3_cashsale WHERE Pump_name = @pumps AND DATE(Date_CutOff) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@pumps", Island3PumpName)
                .Parameters.AddWithValue("@datepickerFrom", PassDateFromIsland3)
                .Parameters.AddWithValue("@datepickerTo", PassDateToIsland3)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand1
                dt.Clear()
                dataAdapter.Fill(dt)

                rpt1.Database.Tables("island3_cashsale").SetDataSource(dt)
                Island3Viewer.ReportSource = Nothing
                Island3Viewer.ReportSource = rpt1

                Dim TotalTxt1 As TextObject = DirectCast(rpt1.ReportDefinition.Sections("Section4").ReportObjects("TotalSalesTxt"), TextObject)
                Dim TotalTxt4 As TextObject = DirectCast(rpt1.ReportDefinition.Sections("Section1").ReportObjects("date_log"), TextObject)
                Dim TotalTxt5 As TextObject = DirectCast(rpt1.ReportDefinition.Sections("Section1").ReportObjects("pump_name"), TextObject)




                TotalTxt1.Text = Island3TotalCashSale
                TotalTxt4.Text = Island3DateFrom + " - " + Island3DateTo
                TotalTxt5.Text = Island3PumpName
                Island3Viewer.Refresh()
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Public Sub export_pdf_format()
        Dim cExportOptions As ExportOptions
        Dim cDestination As New DiskFileDestinationOptions
        Dim cFormatOptions As New PdfRtfWordFormatOptions
        Try
            SaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                cDestination.DiskFileName = SaveFileDialog1.FileName
                cExportOptions = rpt1.ExportOptions
                With cExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .ExportDestinationOptions = cDestination
                    .ExportFormatOptions = cFormatOptions
                End With
                rpt1.Export()
                dialog1 = MessageBox.Show("Export Completed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Dim Island3PanelShow As New Island3CashSalePanel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        Island3PanelShow.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(Island3PanelShow)
    End Sub

    Private Sub PrintIsland3CashSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TOTALSALES()
        showCrystalReport()
    End Sub

    Private Sub Island3Viewer_Load(sender As Object, e As EventArgs) Handles Island3Viewer.Load

    End Sub
End Class

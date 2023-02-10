Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CNFMS.Island1CashSalePanel



Public Class PrintIsland1CashSales
    Public Shared rpt1 As New Island1CashSalesCrystalReport
    Dim dialog1 As DialogResult
    Dim Island1TotalCashSale As String = "0.00"
    Private Sub TOTALSALES()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT CONCAT('₱ ', FORMAT(SUM(Total_Sale),2)) AS Total_Sale FROM island1_cashsale WHERE Pump_name = @pumps AND DATE(Date_CutOff) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@pumps", Island1PumpName)
                .Parameters.AddWithValue("@datepickerFrom", PassDateFromIsland1)
                .Parameters.AddWithValue("@datepickerTo", PassDateToIsland1)
                .Connection = SQLString
            End With
            Try
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader

                    While dataReader.Read()
                        If IsDBNull(dataReader(0)) Then
                            dialog1 = MessageBox.Show("NO RECORDS FOUND!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Island1TotalCashSale = dataReader.GetString(0)

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
                .CommandText = "SELECT DATE_FORMAT(Date_CutOff, '%m/%d/%Y %h:%i %p')AS Date_CutOff, CONCAT('₱ ', FORMAT(SalesRegular,2)) AS SalesRegular, CONCAT('₱ ', FORMAT(SalesPremium,2)) AS SalesPremium, CONCAT('₱ ', FORMAT(SalesDiesel,2)) AS SalesDiesel, CONCAT('₱ ', FORMAT(Total_Sale,2)) AS Total_Sale, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS  Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel ,2)) AS Price_Diesel FROM island1_cashsale WHERE Pump_name = @pumps AND DATE(Date_CutOff) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@pumps", Island1PumpName)
                .Parameters.AddWithValue("@datepickerFrom", PassDateFromIsland1)
                .Parameters.AddWithValue("@datepickerTo", PassDateToIsland1)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand1
                dt.Clear()
                dataAdapter.Fill(dt)

                rpt1.Database.Tables("island1_cashsale").SetDataSource(dt)
                Island1Viewer.ReportSource = Nothing
                Island1Viewer.ReportSource = rpt1
                Dim TotalTxt1 As TextObject = DirectCast(rpt1.ReportDefinition.Sections("Section4").ReportObjects("TotalCashSalesTxt"), TextObject)
                Dim TotalTxt4 As TextObject = DirectCast(rpt1.ReportDefinition.Sections("Section1").ReportObjects("date_log"), TextObject)
                Dim TotalTxt5 As TextObject = DirectCast(rpt1.ReportDefinition.Sections("Section1").ReportObjects("pump_name"), TextObject)


                TotalTxt4.Text = Island1DateFrom + " - " + Island1DateTo
                TotalTxt5.Text = Island1PumpName
                TotalTxt1.Text = Island1TotalCashSale
                Island1Viewer.Refresh()
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
        Dim Island1PanelShow As New Island1CashSalePanel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        Island1PanelShow.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(Island1PanelShow)
    End Sub

    Private Sub PrintIsland1CashSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TOTALSALES()
        showCrystalReport()

    End Sub

    Private Sub Island1Viewer_Load(sender As Object, e As EventArgs) Handles Island1Viewer.Load

    End Sub
End Class

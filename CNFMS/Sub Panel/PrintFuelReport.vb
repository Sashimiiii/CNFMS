Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CNFMS.FuelReportPanel



Public Class PrintFuelReport

    Public Shared rpt As New CrystalFuelReport
    Dim dialog1 As DialogResult

    Dim resultTxtRegular As String = "00.00"
    Dim resultTxtPremium As String = "00.00"
    Dim resultTxtDiesel As String = "00.00"
    Private Sub displayMonthly()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT SUM(Regular), SUM(Premium), SUM(Diesel) FROM inventoryfuel WHERE DATE(Date_added) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@datepickerFrom", PassDateFrom)
                .Parameters.AddWithValue("@datepickerTo", PassDateTo)
                .Connection = SQLString
            End With
            Try
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader

                    While dataReader.Read()
                        If IsDBNull(dataReader(0)) Then
                            dialog1 = MessageBox.Show("NO RECORDS FOUND!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            resultTxtRegular = dataReader.GetString(0)
                            resultTxtPremium = dataReader.GetString(1)
                            resultTxtDiesel = dataReader.GetString(2)
                        End If
                    End While
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub showCrystalFuelReport()
        Using sqlcommand1 As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dt As New DataTable
            With sqlcommand1
                .CommandText = "SELECT DATE_FORMAT(Date_added, '%m/%d/%Y %h:%i %p')AS Date_added, Regular, Premium, Diesel, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM inventoryfuel WHERE DATE(Date_added) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@datepickerFrom", PassDateFrom)
                .Parameters.AddWithValue("@datepickerTo", PassDateTo)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand1
                dt.Clear()
                dataAdapter.Fill(dt)

                rpt.Database.Tables("inventoryfuel").SetDataSource(dt)
                FuelReportViewer.ReportSource = Nothing
                FuelReportViewer.ReportSource = rpt
                Dim TotalTxt1 As TextObject = DirectCast(rpt.ReportDefinition.Sections("Section4").ReportObjects("TotalRegular"), TextObject)
                Dim TotalTxt2 As TextObject = DirectCast(rpt.ReportDefinition.Sections("Section4").ReportObjects("TotalPremium"), TextObject)
                Dim TotalTxt3 As TextObject = DirectCast(rpt.ReportDefinition.Sections("Section4").ReportObjects("TotalDiesel"), TextObject)
                Dim TotalTxt4 As TextObject = DirectCast(rpt.ReportDefinition.Sections("Section1").ReportObjects("date_log"), TextObject)
                TotalTxt1.Text = resultTxtRegular
                TotalTxt2.Text = resultTxtPremium
                TotalTxt3.Text = resultTxtDiesel
                TotalTxt4.Text = DateFromInventory + " - " + DateToInventory
                FuelReportViewer.Refresh()
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
                cExportOptions = rpt.ExportOptions
                With cExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .ExportDestinationOptions = cDestination
                    .ExportFormatOptions = cFormatOptions
                End With
                rpt.Export()
                dialog1 = MessageBox.Show("Export Completed!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ShowFuelReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayMonthly()
        showCrystalFuelReport()
    End Sub


End Class

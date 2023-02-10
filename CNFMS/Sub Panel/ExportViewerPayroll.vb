Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CNFMS.ArchivedPayrolPdf


Public Class ExportViewerPayroll
    Public Shared rpt2 As New PayrollData
    Dim dialog1 As DialogResult

    Dim BasicPayText As String = ""
    Dim RegularHolidayText As String = ""
    Dim SpecialHolidayText As String = ""
    Dim OTText As String = ""
    Dim TotalPayText As String = ""
    Dim SSSText As String = ""
    Dim PHICText As String = ""
    Dim HDMFText As String = ""
    Dim TotalDeductionText As String = ""
    Dim NetPayText As String = ""
    Private Sub TOTALLiters()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand

                .CommandText = "SELECT SUM(BasicPay), SUM(RegularHoliday), SUM(SpecialHoliday), SUM(OT), SUM(TotalPay), SUM(SSS), SUM(PHIC), SUM(HDMF), SUM(TotalDeduction), SUM(NetPay) FROM payroll_data WHERE print = 1 AND DateFrom = @dateFrom AND DateTo = @dateTo"
                .Parameters.AddWithValue("@dateFrom", PassDateFrom)
                .Parameters.AddWithValue("@dateTo", PassDateTo)
                .Connection = SQLString
            End With
            Try
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader

                    While dataReader.Read()
                        If IsDBNull(dataReader(0)) Or Equals("0") Then
                            BasicPayText = "-"
                        ElseIf IsDBNull(dataReader(1)) Then
                            RegularHolidayText = "-"
                        ElseIf IsDBNull(dataReader(2)) Then
                            SpecialHolidayText = "-"
                        ElseIf IsDBNull(dataReader(3)) Then
                            OTText = "-"
                        ElseIf IsDBNull(dataReader(4)) Then
                            TotalPayText = "-"
                        ElseIf IsDBNull(dataReader(5)) Or Equals("0") Then
                            SSSText = "-"
                        ElseIf IsDBNull(dataReader(6)) Then
                            PHICText = "-"
                        ElseIf IsDBNull(dataReader(7)) Then
                            HDMFText = "-"
                        ElseIf IsDBNull(dataReader(0)) Then
                            TotalDeductionText = "-"
                        ElseIf IsDBNull(dataReader(0)) Then
                            NetPayText = "-"
                        Else
                            BasicPayText = dataReader.GetString(0)
                            RegularHolidayText = dataReader.GetString(1)
                            SpecialHolidayText = dataReader.GetString(2)
                            OTText = dataReader.GetString(3)
                            TotalPayText = dataReader.GetString(4)
                            SSSText = dataReader.GetString(5)
                            PHICText = dataReader.GetString(6)
                            HDMFText = dataReader.GetString(7)
                            TotalDeductionText = dataReader.GetString(8)
                            NetPayText = dataReader.GetString(9)

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
                .CommandText = "SELECT FORMAT(ROW_NUMBER() OVER (ORDER BY Id), 0) AS Id, Name_Employee, Designation, BasicDaily, numberDays, CONCAT('₱ ', FORMAT(BasicPay,2)) AS BasicPay, NULLIF(RegularHoliday,0) AS RegularHoliday, NULLIF(SpecialHoliday,0) AS SpecialHoliday, CONCAT('₱ ', FORMAT(OT,2)) AS OT, CONCAT('₱ ', FORMAT(TotalPay,2)) AS TotalPay, NULLIF(SSS,0) AS SSS, NULLIF(PHIC,0) AS PHIC, NULLIF(HDMF,0) AS HDMF, NULLIF(TotalDeduction,0) AS TotalDeduction, CONCAT('₱ ', FORMAT(NetPay,2)) AS NetPay FROM payroll_data WHERE print = 1 AND DateFrom = @dateFrom AND DateTo = @dateTo"
                .Parameters.AddWithValue("@dateFrom", PassDateFrom)
                .Parameters.AddWithValue("@dateTo", PassDateTo)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand1
                dt.Clear()
                dataAdapter.Fill(dt)

                rpt2.Database.Tables("payroll_data").SetDataSource(dt)
                PayrollPrintViewer.ReportSource = Nothing
                PayrollPrintViewer.ReportSource = rpt2

                Dim TotalTxt0 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section1").ReportObjects("date_log"), TextObject)
                Dim TotalTxt1 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalBasicPay"), TextObject)
                Dim TotalTxt2 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalRHPay"), TextObject)
                Dim TotalTxt3 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalSpecialPay"), TextObject)
                Dim TotalTxt4 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalOTPay"), TextObject)
                Dim TotalTxt5 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalPay"), TextObject)
                Dim TotalTxt6 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalSSS"), TextObject)
                Dim TotalTxt7 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalPHIC"), TextObject)
                Dim TotalTxt8 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalHDMF"), TextObject)
                Dim TotalTxt9 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalDeduc"), TextObject)
                Dim TotalTxt10 As TextObject = DirectCast(rpt2.ReportDefinition.Sections("Section3").ReportObjects("totalNetPay"), TextObject)


                TotalTxt0.Text = PassDateFrom + " - " + PassDateTo
                TotalTxt1.Text = BasicPayText
                TotalTxt2.Text = RegularHolidayText
                TotalTxt3.Text = SpecialHolidayText
                TotalTxt4.Text = OTText
                TotalTxt5.Text = TotalPayText
                TotalTxt6.Text = SSSText
                TotalTxt7.Text = PHICText
                TotalTxt8.Text = HDMFText
                TotalTxt9.Text = TotalDeductionText
                TotalTxt10.Text = NetPayText
                PayrollPrintViewer.Refresh()
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub PayrollPrintViewer_Load(sender As Object, e As EventArgs) Handles PayrollPrintViewer.Load
        TOTALLiters()
        Threading.Thread.Sleep(1000)
        showCrystalReport()
    End Sub

    Public Sub export_pdf_format()
        Dim cExportOptions As ExportOptions
        Dim cDestination As New DiskFileDestinationOptions
        Dim cFormatOptions As New PdfRtfWordFormatOptions
        Try
            SaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                cDestination.DiskFileName = SaveFileDialog1.FileName
                cExportOptions = rpt2.ExportOptions
                With cExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .ExportDestinationOptions = cDestination
                    .ExportFormatOptions = cFormatOptions
                End With
                rpt2.Export()
                dialog1 = MessageBox.Show("Export Completed!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

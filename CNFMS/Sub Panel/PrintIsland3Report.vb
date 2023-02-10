Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CNFMS.Island3Panel




Public Class PrintIsland3Report
    Public Shared rpt3 As New CrystalReportIsland3CutOff
    Dim dialog1 As DialogResult

    Dim TotalRegular As Decimal
    Dim TotalPremium As Decimal
    Dim TotalDiesel As Decimal

    Private Sub TOTALLiters()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT SUM(LitersOut_Regular), SUM(LitersOut_Premium), SUM(LitersOut_Diesel) FROM island3_report WHERE Pump_name = @pumps AND DATE(Date_cutOff) BETWEEN @datepickerFrom AND @datepickerTo"
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
                            TotalRegular = dataReader.GetString(0)
                            TotalPremium = dataReader.GetString(1)
                            TotalDiesel = dataReader.GetString(2)
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
                .CommandText = "SELECT Pump_name, DATE_FORMAT(Date_cutOff, '%m/%d/%Y %h:%i %p')AS Date_cutOff, LitersOut_Regular, LitersOut_Premium, LitersOut_Diesel, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM island3_report WHERE Pump_name = @pumps AND DATE(Date_cutOff) BETWEEN @datepickerFrom AND @datepickerTo"
                .Parameters.AddWithValue("@pumps", Island3PumpName)
                .Parameters.AddWithValue("@datepickerFrom", PassDateFromIsland3)
                .Parameters.AddWithValue("@datepickerTo", PassDateToIsland3)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand1
                dt.Clear()
                dataAdapter.Fill(dt)
                rpt3.Database.Tables("island3_report").SetDataSource(dt)
                Island3Viewer.ReportSource = Nothing
                Island3Viewer.ReportSource = rpt3
                Dim TotalTxt1 As TextObject = DirectCast(rpt3.ReportDefinition.Sections("Section4").ReportObjects("TotalRegular"), TextObject)
                Dim TotalTxt2 As TextObject = DirectCast(rpt3.ReportDefinition.Sections("Section4").ReportObjects("TotalPremium"), TextObject)
                Dim TotalTxt3 As TextObject = DirectCast(rpt3.ReportDefinition.Sections("Section4").ReportObjects("TotalDiesel"), TextObject)
                Dim TotalTxt4 As TextObject = DirectCast(rpt3.ReportDefinition.Sections("Section1").ReportObjects("date_log"), TextObject)
                Dim TotalTxt5 As TextObject = DirectCast(rpt3.ReportDefinition.Sections("Section1").ReportObjects("pump_name"), TextObject)



                TotalTxt1.Text = TotalRegular
                TotalTxt2.Text = TotalPremium
                TotalTxt3.Text = TotalDiesel
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
                cExportOptions = rpt3.ExportOptions
                With cExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .ExportDestinationOptions = cDestination
                    .ExportFormatOptions = cFormatOptions
                End With
                rpt3.Export()
                dialog1 = MessageBox.Show("Export Completed!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub PrintIsland3Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TOTALLiters()
        showCrystalFuelReport()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Dim Island3PanelShow As New Island3Panel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        Island3PanelShow.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(Island3PanelShow)
    End Sub

    Private Sub Island3Viewer_Load(sender As Object, e As EventArgs) Handles Island3Viewer.Load

    End Sub
End Class

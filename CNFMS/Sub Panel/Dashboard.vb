Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CNFMS.LoginForm
Public Class Dashboard
    Dim dialog1 As DialogResult

    Dim dateChartFrom As Date
    Dim dateChartTo As Date

    Dim DatePassFrom As Date
    Dim DatePassTo As Date

    Dim island1Sale As Decimal
    Dim island2Sale As Decimal
    Dim island3Sale As Decimal

    Dim island1SaleGraph As Decimal
    Dim island2SaleGraph As Decimal
    Dim island3SaleGraph As Decimal

    Dim island1Sale1 As Decimal
    Dim island2Sale2 As Decimal
    Dim island3Sale3 As Decimal

    Dim pumpName1 As String = ""
    Dim pumpName2 As String = ""
    Dim pumpName3 As String = ""
    Private Sub showFuelInfo()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT * FROM fuelprice"
                .Connection = SQLString
            End With
            Try
                Dim showTxt1 As String = ""
                Dim showTxt2 As String = ""
                Dim showTxt3 As String = ""
                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    If dataReader.Read Then
                        showTxt1 = dataReader.GetString(4)
                        totalRegularLiterstxt.Text = dataReader.GetString(7)
                        showTxt2 = dataReader.GetString(5)
                        TotalPremiumLitersTxt.Text = dataReader.GetString(8)
                        showTxt3 = dataReader.GetString(6)
                        TotalDiesellitersTxt.Text = dataReader.GetString(9)
                    End If
                End Using
                priceRegularTxt.Text = "₱  " + showTxt1
                pricePremiumTxt.Text = "₱  " + showTxt2
                priceDieselTxt.Text = "₱  " + showTxt3

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    'Private Sub showGraph()
    '    Dim fullDate1 As String = ""
    '    Dim fullDate2 As String = ""
    '    dateChartFrom = New DateTime((Now.Year), Now.Month, 1)
    '    dateChartTo = DateSerial(Year(dateChartFrom), Month(dateChartFrom) + 1, 0)
    '    fullDate1 = dateChartFrom.ToString("yyyy-MM-") + dateChartTo.ToString("dd")
    '    fullDate2 = dateChartFrom.ToString("yyyy-MM-dd")
    '    Using sqlcommand As New MySqlCommand()
    '        With sqlcommand
    '            .CommandText = "SELECT Pump_Name, Total_Sale FROM island1_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
    '            .Parameters.AddWithValue("@date1", fullDate2)
    '            .Parameters.AddWithValue("@date2", fullDate1)
    '            .Connection = SQLString
    '        End With
    '        Try


    '            ConnectSQL()
    '            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
    '                While dataReader.Read
    '                    If IsDBNull(dataReader(0)) Then
    '                    Else

    '                        island1SaleGraph = dataReader.GetString(1)
    '                        pumpName1 = dataReader.GetString(0)
    '                        ChartTotalLiters.Series("Island 1").Points.AddXY(pumpName1, Decimal.Parse(island1SaleGraph))
    '                    End If
    '                End While
    '            End Using

    '        Catch ex As Exception
    '            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using


    '    Using sqlcommand1 As New MySqlCommand()
    '        With sqlcommand1
    '            .CommandText = "SELECT Pump_Name, Total_Sale FROM island2_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
    '            .Parameters.AddWithValue("@date1", fullDate2)
    '            .Parameters.AddWithValue("@date2", fullDate1)
    '            .Connection = SQLString
    '        End With
    '        Try

    '            ConnectSQL()
    '            Using dataReader As MySqlDataReader = sqlcommand1.ExecuteReader
    '                While dataReader.Read
    '                    If IsDBNull(dataReader(0)) Then
    '                    Else
    '                        pumpName2 = dataReader.GetString(0)
    '                        island2SaleGraph = dataReader.GetString(1)
    '                        ChartTotalLiters.Series("Island 2").Points.AddXY(pumpName2, Decimal.Parse(island2SaleGraph))

    '                    End If

    '                End While
    '            End Using

    '        Catch ex As Exception
    '            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using

    '    Using sqlcommand2 As New MySqlCommand()
    '        With sqlcommand2
    '            .CommandText = "SELECT Pump_Name, Total_Sale FROM island3_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
    '            .Parameters.AddWithValue("@date1", fullDate2)
    '            .Parameters.AddWithValue("@date2", fullDate1)
    '            .Connection = SQLString
    '        End With
    '        Try

    '            ConnectSQL()
    '            Using dataReader As MySqlDataReader = sqlcommand2.ExecuteReader
    '                While dataReader.Read
    '                    If IsDBNull(dataReader(0)) Then
    '                    Else
    '                        pumpName3 = dataReader.GetString(0)
    '                        island3SaleGraph = dataReader.GetString(1)
    '                        ChartTotalLiters.Series("Island 3").Points.AddXY(pumpName3, Decimal.Parse(island3SaleGraph))
    '                    End If

    '                End While
    '            End Using

    '        Catch ex As Exception
    '            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using

    '    Dim fulldate3 As Date
    '    Dim fulldate4 As Date
    '    ChartTotalLiters.ChartAreas(0).AxisX.MajorGrid.Enabled = False
    '    ChartTotalLiters.ChartAreas(0).AxisY.MajorGrid.Enabled = True
    '    ChartTotalLiters.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Silver

    '    fulldate3 = dateChartFrom.ToString("yyyy-MM-") + dateChartTo.ToString("dd")
    '    fulldate4 = dateChartFrom.ToString("yyyy-MM-dd")
    '    dateFromToTxt.Text = fulldate4 + " - " + fulldate3
    'End Sub

    Private Sub showMonthSale()
        Dim fullDate1 As String = ""
        Dim fullDate2 As String = ""
        dateChartFrom = New DateTime((Now.Year), Now.Month, 1)
        dateChartTo = DateSerial(Year(dateChartFrom), Month(dateChartFrom) + 1, 0)
        fullDate1 = dateChartFrom.ToString("yyyy-MM-") + dateChartTo.ToString("dd")
        fullDate2 = dateChartFrom.ToString("yyyy-MM-dd")
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT SUM(Total_Sale) FROM island1_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
                .Parameters.AddWithValue("@date1", fullDate2)
                .Parameters.AddWithValue("@date2", fullDate1)
                .Connection = SQLString
            End With
            Try


                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    While dataReader.Read
                        If IsDBNull(dataReader(0)) Then
                        Else
                            island1Sale = dataReader.GetString(0)
                        End If
                    End While
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using


        Using sqlcommand1 As New MySqlCommand()
            With sqlcommand1
                .CommandText = "SELECT SUM(Total_Sale) FROM island2_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
                .Parameters.AddWithValue("@date1", fullDate2)
                .Parameters.AddWithValue("@date2", fullDate1)
                .Connection = SQLString
            End With
            Try

                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand1.ExecuteReader
                    While dataReader.Read
                        If IsDBNull(dataReader(0)) Then
                        Else
                            island2Sale = dataReader.GetString(0)
                        End If

                    End While
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Using sqlcommand2 As New MySqlCommand()
            With sqlcommand2
                .CommandText = "SELECT SUM(Total_Sale) FROM island3_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
                .Parameters.AddWithValue("@date1", fullDate2)
                .Parameters.AddWithValue("@date2", fullDate1)
                .Connection = SQLString
            End With
            Try

                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand2.ExecuteReader
                    While dataReader.Read
                        If IsDBNull(dataReader(0)) Then
                        Else
                            island3Sale = dataReader.GetString(0)
                        End If

                    End While
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        monthlySaleTxt.Text = Format(Val(Decimal.Parse(island1Sale) + Decimal.Parse(island2Sale) + Decimal.Parse(island3Sale)), "₱ 0,0.00")

    End Sub


    Private Sub showDailySale()
        Dim fullDate1 As String = ""
        dateChartFrom = DateTime.Now
        fullDate1 = dateChartFrom.ToString("yyyy-MM-dd")

        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT SUM(Total_Sale) FROM island1_cashsale WHERE DATE(Date_CutOff) = @date1"
                .Parameters.AddWithValue("@date1", fullDate1)
                .Connection = SQLString
            End With
            Try


                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    While dataReader.Read
                        If IsDBNull(dataReader(0)) Then
                            ''island1Sale1 = "₱ 00.00"
                        Else
                            island1Sale1 = dataReader.GetString(0)
                        End If
                    End While

                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using


        Using sqlcommand1 As New MySqlCommand()
            With sqlcommand1
                .CommandText = "SELECT SUM(Total_Sale) FROM island2_cashsale WHERE DATE(Date_CutOff) = @date1"
                .Parameters.AddWithValue("@date1", fullDate1)
                .Connection = SQLString
            End With
            Try

                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand1.ExecuteReader
                    While dataReader.Read
                        If IsDBNull(dataReader(0)) Then
                        Else
                            island2Sale2 = dataReader.GetString(0)

                        End If

                    End While
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Using sqlcommand2 As New MySqlCommand()
            With sqlcommand2
                .CommandText = "SELECT SUM(Total_Sale) FROM island3_cashsale WHERE DATE(Date_CutOff) = @date1"
                .Parameters.AddWithValue("@date1", fullDate1)
                .Connection = SQLString
            End With
            Try

                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand2.ExecuteReader
                    While dataReader.Read
                        If IsDBNull(dataReader(0)) Then
                        Else
                            island3Sale3 = dataReader.GetString(0)
                        End If

                    End While
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using


        dailysaleTxt.Text = Format(Val(Decimal.Parse(island1Sale1) + Decimal.Parse(island2Sale2) + Decimal.Parse(island3Sale3)), "₱ 0.00")


    End Sub










    'Private Sub showChartDailySaleIsland1()
    '    Using sqlcommand As New MySqlCommand()
    '        Dim fullDate1 As String = ""
    '        Dim fullDate2 As String = ""
    '        dateChartFrom = New DateTime((Now.Year), Now.Month, 1)
    '        dateChartTo = DateSerial(Year(dateChartFrom), Month(dateChartFrom) + 1, 0)
    '        fullDate1 = dateChartFrom.ToString("yyyy-MM-") + dateChartTo.ToString("dd")
    '        fullDate2 = dateChartFrom.ToString("yyyy-MM-dd")

    '        With sqlcommand
    '            .CommandText = "SELECT DATE_FORMAT(Date_CutOff, '%d') AS Date_added, Total_Sale FROM island1_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
    '            .Parameters.AddWithValue("@date1", fullDate2)
    '            .Parameters.AddWithValue("@date2", fullDate1)
    '            .Connection = SQLString
    '        End With
    '        Try

    '            ConnectSQL()
    '            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
    '                While dataReader.Read
    '                    ChartTotalLiters.Series("ISLAND 1").Points.AddXY(dataReader.GetString(0), dataReader.GetDecimal("Total_Sale"))
    '                End While
    '            End Using
    '            ChartTotalLiters.ChartAreas(0).AxisX.MajorGrid.Enabled = False
    '            ChartTotalLiters.ChartAreas(0).AxisY.MajorGrid.Enabled = False
    '        Catch ex As Exception
    '            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using
    'End Sub

    'Private Sub showChartDailySaleIsland2()
    '    Using sqlcommand As New MySqlCommand()
    '        Dim fullDate1 As String = ""
    '        Dim fullDate2 As String = ""
    '        dateChartFrom = New DateTime((Now.Year), Now.Month, 1)
    '        dateChartTo = DateSerial(Year(dateChartFrom), Month(dateChartFrom) + 1, 0)
    '        fullDate1 = dateChartFrom.ToString("yyyy-MM-") + dateChartTo.ToString("dd")
    '        fullDate2 = dateChartFrom.ToString("yyyy-MM-dd")

    '        With sqlcommand
    '            .CommandText = "SELECT DATE_FORMAT(Date_CutOff, '%d') AS Date_added, Total_Sale FROM island2_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
    '            .Parameters.AddWithValue("@date1", fullDate2)
    '            .Parameters.AddWithValue("@date2", fullDate1)
    '            .Connection = SQLString
    '        End With
    '        Try

    '            ConnectSQL()
    '            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
    '                While dataReader.Read
    '                    ChartTotalLiters.Series("ISLAND 2").Points.AddXY(dataReader.GetString(0), dataReader.GetDecimal("Total_Sale"))
    '                End While
    '            End Using
    '            ChartTotalLiters.ChartAreas(0).AxisX.MajorGrid.Enabled = False
    '            ChartTotalLiters.ChartAreas(0).AxisY.MajorGrid.Enabled = False
    '        Catch ex As Exception
    '            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using
    'End Sub

    'Private Sub showChartDailySaleIsland3()
    '    Using sqlcommand As New MySqlCommand()
    '        Dim fullDate1 As String = ""
    '        Dim fullDate2 As String = ""
    '        dateChartFrom = New DateTime((Now.Year), Now.Month, 1)
    '        dateChartTo = DateSerial(Year(dateChartFrom), Month(dateChartFrom) + 1, 0)
    '        fullDate1 = dateChartFrom.ToString("yyyy-MM-") + dateChartTo.ToString("dd")
    '        fullDate2 = dateChartFrom.ToString("yyyy-MM-dd")

    '        With sqlcommand
    '            .CommandText = "SELECT DATE_FORMAT(Date_CutOff, '%d') AS Date_added, Total_Sale FROM island3_cashsale WHERE DATE(Date_CutOff) BETWEEN @date1 AND @date2"
    '            .Parameters.AddWithValue("@date1", fullDate2)
    '            .Parameters.AddWithValue("@date2", fullDate1)
    '            .Connection = SQLString
    '        End With
    '        Try

    '            ConnectSQL()
    '            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
    '                While dataReader.Read
    '                    ChartTotalLiters.Series("ISLAND 3").Points.AddXY(dataReader.GetString(0), dataReader.GetDecimal("Total_Sale"))
    '                End While
    '            End Using
    '            ChartTotalLiters.ChartAreas(0).AxisX.MajorGrid.Enabled = False
    '            ChartTotalLiters.ChartAreas(0).AxisY.MajorGrid.Enabled = False
    '        Catch ex As Exception
    '            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using
    'End Sub
    'Private Sub showChartTotalLiters()
    '    Using sqlcommand As New MySqlCommand()
    '        With sqlcommand
    '            .CommandText = "SELECT * FROM fuelprice"
    '            .Connection = SQLString
    '        End With
    '        Try

    '            ConnectSQL()
    '            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
    '                If dataReader.Read Then
    '                    Chart1.Series("StockChart").Points.AddXY(dataReader.GetString(1), dataReader.GetString(7))
    '                    Chart1.Series("StockChart").Points.AddXY(dataReader.GetString(2), dataReader.GetString(8))
    '                    Chart1.Series("StockChart").Points.AddXY(dataReader.GetString(3), dataReader.GetString(9))

    '                    CartesianChart1.AxisX.Add(New LiveCharts.Wpf.Axis)

    '                End If
    '            End Using

    '        Catch ex As Exception
    '            dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using
    'End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showFuelInfo()
        ' showGraph()
        showMonthSale()
        showDailySale()
        nameDisplay.Text = Nameuser
    End Sub

    Private Sub showInventoryPanel()
        Dim ShowInventory As New InventoryPanel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowInventory.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowInventory)

        MainPanel.dashboardButton.BackColor = Color.Transparent
        MainPanel.dashboardButton.ForeColor = Color.White
        MainPanel.dashboardButton.Image = My.Resources.dashboardWhite


        MainPanel.inventoryButton.BackColor = Color.White
        MainPanel.inventoryButton.ForeColor = Color.Black
        MainPanel.inventoryButton.Image = My.Resources.inventoryBlack


        MainPanel.fuelsideButton.BackColor = Color.Transparent
        MainPanel.fuelsideButton.ForeColor = Color.White
        MainPanel.fuelsideButton.Image = My.Resources.fuelreportWhite

        MainPanel.CutOffButton.BackColor = Color.Transparent
        MainPanel.CutOffButton.ForeColor = Color.White
        MainPanel.CutOffButton.Image = My.Resources.cutoffWhite

        MainPanel.SalesReportButton.BackColor = Color.Transparent
        MainPanel.SalesReportButton.ForeColor = Color.White
        MainPanel.SalesReportButton.Image = My.Resources.salesreportWhite


        MainPanel.PayrollButton.BackColor = Color.Transparent
        MainPanel.PayrollButton.ForeColor = Color.White
        MainPanel.PayrollButton.Image = My.Resources.payrollWhite

        MainPanel.EmployeeButton.BackColor = Color.Transparent
        MainPanel.EmployeeButton.ForeColor = Color.White
        MainPanel.EmployeeButton.Image = My.Resources.employeeWhite


        MainPanel.AdminButton.BackColor = Color.Transparent
        MainPanel.AdminButton.ForeColor = Color.White
        MainPanel.AdminButton.Image = My.Resources.adminWhite
    End Sub


    Private Sub moreinfoButton1_Click(sender As Object, e As EventArgs) Handles moreinfoButton1.Click
        showInventoryPanel()
    End Sub

    Private Sub moreinfoButton2_Click(sender As Object, e As EventArgs) Handles moreinfoButton2.Click
        showInventoryPanel()
    End Sub

    Private Sub moreinfoButton3_Click(sender As Object, e As EventArgs) Handles moreinfoButton3.Click
        showInventoryPanel()
    End Sub


    Private Sub moreinfoButton4_Click(sender As Object, e As EventArgs) Handles moreinfoButton4.Click
        Dim SalesPanelShow As New CashSalesPanel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        SalesPanelShow.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(SalesPanelShow)

        MainPanel.dashboardButton.BackColor = Color.Transparent
        MainPanel.dashboardButton.ForeColor = Color.White
        MainPanel.dashboardButton.Image = My.Resources.dashboardWhite

        MainPanel.inventoryButton.BackColor = Color.Transparent
        MainPanel.inventoryButton.ForeColor = Color.White
        MainPanel.inventoryButton.Image = My.Resources.inventoryWhite

        MainPanel.fuelsideButton.BackColor = Color.Transparent
        MainPanel.fuelsideButton.ForeColor = Color.White
        MainPanel.fuelsideButton.Image = My.Resources.fuelreportWhite

        MainPanel.CutOffButton.BackColor = Color.Transparent
        MainPanel.CutOffButton.ForeColor = Color.White
        MainPanel.CutOffButton.Image = My.Resources.cutoffWhite

        MainPanel.SalesReportButton.BackColor = Color.White
        MainPanel.SalesReportButton.ForeColor = Color.Black
        MainPanel.SalesReportButton.Image = My.Resources.salesreportBlack


        MainPanel.PayrollButton.BackColor = Color.Transparent
        MainPanel.PayrollButton.ForeColor = Color.White
        MainPanel.PayrollButton.Image = My.Resources.payrollWhite

        MainPanel.EmployeeButton.BackColor = Color.Transparent
        MainPanel.EmployeeButton.ForeColor = Color.White
        MainPanel.EmployeeButton.Image = My.Resources.employeeWhite

        MainPanel.AdminButton.BackColor = Color.Transparent
        MainPanel.AdminButton.ForeColor = Color.White
        MainPanel.AdminButton.Image = My.Resources.adminWhite
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles dashboarUser.Click
        Me.GunaContextMenuStrip1.Show(Me.dashboarUser, Me.dashboarUser.PointToClient(Cursor.Position))
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles settingButton.Click
        Me.GunaContextMenuStrip2.Show(Me.settingButton, Me.settingButton.PointToClient(Cursor.Position))
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim ShowPanel As New UserSettingUpdate
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowPanel.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowPanel)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        dialog1 = MessageBox.Show("SIGN OUT?",
                                                 "EXIT",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)
        If dialog1 = DialogResult.Yes Then
            MainPanel.Close()
            LoginForm.Show()
        End If
    End Sub



    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'Dim saveDialog As New SaveFileDialog()
        'saveDialog.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*"
        'saveDialog.FilterIndex = 1
        'saveDialog.RestoreDirectory = True

        'If saveDialog.ShowDialog() = DialogResult.OK Then
        '    Dim mysqldumpPath As String = "C:\Program Files\Ampps\mysql\bin\mysqldump.exe"
        '    Dim backupFilePath As String = saveDialog.FileName

        '    Dim process As New Process()
        '    process.StartInfo.FileName = mysqldumpPath
        '    process.StartInfo.Arguments = String.Format("-h localhost -u root -mysql cn_database -r {0}", backupFilePath)
        '    process.StartInfo.UseShellExecute = False
        '    process.StartInfo.CreateNoWindow = True
        '    process.Start()
        '    process.WaitForExit()

        'End If
    End Sub


End Class

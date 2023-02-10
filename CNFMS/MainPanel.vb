
Public Class MainPanel
    Dim dialog1 As DialogResult
    Dim sidebar As String = "Close"

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property 'CreateParams

    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

        'show Dashboard 
        Dim dashboardShow As New Dashboard
        FillPanel.Size = FillPanel.MaximumSize
        dashboardShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(dashboardShow)

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        If sidebar = "Open" Then
            sidebarpanel.Width += 30
            If sidebarpanel.Width >= 185 Then
                sidebar = "Close"
                animationTimer.Stop()
            End If
        Else
            sidebarpanel.Width -= 30
            If sidebarpanel.Width <= 80 Then
                sidebar = "Open"
                animationTimer.Stop()
            End If
        End If
    End Sub

    Private Sub slidePanelButton_Click(sender As Object, e As EventArgs) Handles slidePanelButton.Click
        animationTimer.Start()
    End Sub

    Private Sub dashboardButton_Click(sender As Object, e As EventArgs) Handles dashboardButton.Click
        Dim dashboardShow As New Dashboard
        FillPanel.Size = FillPanel.MaximumSize
        dashboardShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(dashboardShow)


        dashboardButton.BackColor = Color.White
        dashboardButton.ForeColor = Color.Black
        dashboardButton.Image = My.Resources.dashboardBlack

        inventoryButton.BackColor = Color.Transparent
        inventoryButton.ForeColor = Color.White
        inventoryButton.Image = My.Resources.inventoryWhite

        fuelsideButton.BackColor = Color.Transparent
        fuelsideButton.ForeColor = Color.White
        fuelsideButton.Image = My.Resources.fuelreportWhite

        CutOffButton.BackColor = Color.Transparent
        CutOffButton.ForeColor = Color.White
        CutOffButton.Image = My.Resources.cutoffWhite

        SalesReportButton.BackColor = Color.Transparent
        SalesReportButton.ForeColor = Color.White
        SalesReportButton.Image = My.Resources.salesreportWhite

        PayrollButton.BackColor = Color.Transparent
        PayrollButton.ForeColor = Color.White
        PayrollButton.Image = My.Resources.payrollWhite

        EmployeeButton.BackColor = Color.Transparent
        EmployeeButton.ForeColor = Color.White
        EmployeeButton.Image = My.Resources.employeeWhite

        AdminButton.BackColor = Color.Transparent
        AdminButton.ForeColor = Color.White
        AdminButton.Image = My.Resources.adminWhite
    End Sub

    Public Sub inventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        Dim inventoryShow As New InventoryPanel
        FillPanel.Size = FillPanel.MaximumSize
        inventoryShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(inventoryShow)


        dashboardButton.BackColor = Color.Transparent
        dashboardButton.ForeColor = Color.White
        dashboardButton.Image = My.Resources.dashboardWhite


        inventoryButton.BackColor = Color.White
        inventoryButton.ForeColor = Color.Black
        inventoryButton.Image = My.Resources.inventoryBlack


        fuelsideButton.BackColor = Color.Transparent
        fuelsideButton.ForeColor = Color.White
        fuelsideButton.Image = My.Resources.fuelreportWhite

        CutOffButton.BackColor = Color.Transparent
        CutOffButton.ForeColor = Color.White
        CutOffButton.Image = My.Resources.cutoffWhite

        SalesReportButton.BackColor = Color.Transparent
        SalesReportButton.ForeColor = Color.White
        SalesReportButton.Image = My.Resources.salesreportWhite


        PayrollButton.BackColor = Color.Transparent
        PayrollButton.ForeColor = Color.White
        PayrollButton.Image = My.Resources.payrollWhite

        EmployeeButton.BackColor = Color.Transparent
        EmployeeButton.ForeColor = Color.White
        EmployeeButton.Image = My.Resources.employeeWhite


        AdminButton.BackColor = Color.Transparent
        AdminButton.ForeColor = Color.White
        AdminButton.Image = My.Resources.adminWhite


    End Sub

    Private Sub fuelsideButton_Click(sender As Object, e As EventArgs) Handles fuelsideButton.Click
        Dim FuelReportPanelShow As New FuelReportPanel
        FillPanel.Size = FillPanel.MaximumSize
        FuelReportPanelShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(FuelReportPanelShow)



        dashboardButton.BackColor = Color.Transparent
        dashboardButton.ForeColor = Color.White
        dashboardButton.Image = My.Resources.dashboardWhite

        inventoryButton.BackColor = Color.Transparent
        inventoryButton.ForeColor = Color.White
        inventoryButton.Image = My.Resources.inventoryWhite

        fuelsideButton.BackColor = Color.White
        fuelsideButton.ForeColor = Color.Black
        fuelsideButton.Image = My.Resources.fuelreportBlack

        CutOffButton.BackColor = Color.Transparent
        CutOffButton.ForeColor = Color.White
        CutOffButton.Image = My.Resources.cutoffWhite

        SalesReportButton.BackColor = Color.Transparent
        SalesReportButton.ForeColor = Color.White
        SalesReportButton.Image = My.Resources.salesreportWhite


        PayrollButton.BackColor = Color.Transparent
        PayrollButton.ForeColor = Color.White
        PayrollButton.Image = My.Resources.payrollWhite

        EmployeeButton.BackColor = Color.Transparent
        EmployeeButton.ForeColor = Color.White
        EmployeeButton.Image = My.Resources.employeeWhite

        AdminButton.BackColor = Color.Transparent
        AdminButton.ForeColor = Color.White
        AdminButton.Image = My.Resources.adminWhite
    End Sub


    Private Sub maximizedButton_Click(sender As Object, e As EventArgs) Handles maximizedButton.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CutOffButton_Click(sender As Object, e As EventArgs) Handles CutOffButton.Click
        Dim CutOffPanelShow As New CutOff_Panel
        FillPanel.Size = FillPanel.MaximumSize
        CutOffPanelShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(CutOffPanelShow)



        dashboardButton.BackColor = Color.Transparent
        dashboardButton.ForeColor = Color.White
        dashboardButton.Image = My.Resources.dashboardWhite

        inventoryButton.BackColor = Color.Transparent
        inventoryButton.ForeColor = Color.White
        inventoryButton.Image = My.Resources.inventoryWhite

        fuelsideButton.BackColor = Color.Transparent
        fuelsideButton.ForeColor = Color.White
        fuelsideButton.Image = My.Resources.fuelreportWhite

        CutOffButton.BackColor = Color.White
        CutOffButton.ForeColor = Color.Black
        CutOffButton.Image = My.Resources.cutoffBlack

        SalesReportButton.BackColor = Color.Transparent
        SalesReportButton.ForeColor = Color.White
        SalesReportButton.Image = My.Resources.salesreportWhite


        PayrollButton.BackColor = Color.Transparent
        PayrollButton.ForeColor = Color.White
        PayrollButton.Image = My.Resources.payrollWhite

        EmployeeButton.BackColor = Color.Transparent
        EmployeeButton.ForeColor = Color.White
        EmployeeButton.Image = My.Resources.employeeWhite

        AdminButton.BackColor = Color.Transparent
        AdminButton.ForeColor = Color.White
        AdminButton.Image = My.Resources.adminWhite
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        dialog1 = MessageBox.Show("SIGN OUT?",
                                                  "EXIT",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question)
        If dialog1 = DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        End If
    End Sub

    Private Sub SalesReportButton_Click(sender As Object, e As EventArgs) Handles SalesReportButton.Click
        Dim SalesPanelShow As New CashSalesPanel
        FillPanel.Size = FillPanel.MaximumSize
        SalesPanelShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(SalesPanelShow)



        dashboardButton.BackColor = Color.Transparent
        dashboardButton.ForeColor = Color.White
        dashboardButton.Image = My.Resources.dashboardWhite

        inventoryButton.BackColor = Color.Transparent
        inventoryButton.ForeColor = Color.White
        inventoryButton.Image = My.Resources.inventoryWhite

        fuelsideButton.BackColor = Color.Transparent
        fuelsideButton.ForeColor = Color.White
        fuelsideButton.Image = My.Resources.fuelreportWhite

        CutOffButton.BackColor = Color.Transparent
        CutOffButton.ForeColor = Color.White
        CutOffButton.Image = My.Resources.cutoffWhite

        SalesReportButton.BackColor = Color.White
        SalesReportButton.ForeColor = Color.Black
        SalesReportButton.Image = My.Resources.salesreportBlack


        PayrollButton.BackColor = Color.Transparent
        PayrollButton.ForeColor = Color.White
        PayrollButton.Image = My.Resources.payrollWhite

        EmployeeButton.BackColor = Color.Transparent
        EmployeeButton.ForeColor = Color.White
        EmployeeButton.Image = My.Resources.employeeWhite

        AdminButton.BackColor = Color.Transparent
        AdminButton.ForeColor = Color.White
        AdminButton.Image = My.Resources.adminWhite
    End Sub

    Public Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        Dim EmployeePanelShow As New EmployeeInfo
        FillPanel.Size = FillPanel.MaximumSize
        EmployeePanelShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(EmployeePanelShow)



        dashboardButton.BackColor = Color.Transparent
        dashboardButton.ForeColor = Color.White
        dashboardButton.Image = My.Resources.dashboardWhite

        inventoryButton.BackColor = Color.Transparent
        inventoryButton.ForeColor = Color.White
        inventoryButton.Image = My.Resources.inventoryWhite

        fuelsideButton.BackColor = Color.Transparent
        fuelsideButton.ForeColor = Color.White
        fuelsideButton.Image = My.Resources.fuelreportWhite

        CutOffButton.BackColor = Color.Transparent
        CutOffButton.ForeColor = Color.White
        CutOffButton.Image = My.Resources.cutoffWhite

        SalesReportButton.BackColor = Color.Transparent
        SalesReportButton.ForeColor = Color.White
        SalesReportButton.Image = My.Resources.salesreportWhite


        PayrollButton.BackColor = Color.Transparent
        PayrollButton.ForeColor = Color.White
        PayrollButton.Image = My.Resources.payrollWhite


        EmployeeButton.BackColor = Color.White
        EmployeeButton.ForeColor = Color.Black
        EmployeeButton.Image = My.Resources.employeeblack

        AdminButton.BackColor = Color.Transparent
        AdminButton.ForeColor = Color.White
        AdminButton.Image = My.Resources.adminWhite
    End Sub

    Public Sub PayrollButton_Click(sender As Object, e As EventArgs) Handles PayrollButton.Click
        Dim PayrollPanelShow As New PayrollPanel
        FillPanel.Size = FillPanel.MaximumSize
        PayrollPanelShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(PayrollPanelShow)


        dashboardButton.BackColor = Color.Transparent
        dashboardButton.ForeColor = Color.White
        dashboardButton.Image = My.Resources.dashboardWhite

        inventoryButton.BackColor = Color.Transparent
        inventoryButton.ForeColor = Color.White
        inventoryButton.Image = My.Resources.inventoryWhite

        fuelsideButton.BackColor = Color.Transparent
        fuelsideButton.ForeColor = Color.White
        fuelsideButton.Image = My.Resources.fuelreportWhite

        CutOffButton.BackColor = Color.Transparent
        CutOffButton.ForeColor = Color.White
        CutOffButton.Image = My.Resources.cutoffWhite

        SalesReportButton.BackColor = Color.Transparent
        SalesReportButton.ForeColor = Color.White
        SalesReportButton.Image = My.Resources.salesreportWhite

        EmployeeButton.BackColor = Color.Transparent
        EmployeeButton.ForeColor = Color.White
        EmployeeButton.Image = My.Resources.employeeWhite

        PayrollButton.BackColor = Color.White
        PayrollButton.ForeColor = Color.Black
        PayrollButton.Image = My.Resources.payrollBlack


        AdminButton.BackColor = Color.Transparent
        AdminButton.ForeColor = Color.White
        AdminButton.Image = My.Resources.adminWhite
    End Sub

    Public Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        Dim AdminShow As New AdminPanel
        FillPanel.Size = FillPanel.MaximumSize
        AdminShow.Dock = DockStyle.Fill
        FillPanel.Controls.Clear()
        FillPanel.Controls.Add(AdminShow)


        dashboardButton.BackColor = Color.Transparent
        dashboardButton.ForeColor = Color.White
        dashboardButton.Image = My.Resources.dashboardWhite

        inventoryButton.BackColor = Color.Transparent
        inventoryButton.ForeColor = Color.White
        inventoryButton.Image = My.Resources.inventoryWhite

        fuelsideButton.BackColor = Color.Transparent
        fuelsideButton.ForeColor = Color.White
        fuelsideButton.Image = My.Resources.fuelreportWhite

        CutOffButton.BackColor = Color.Transparent
        CutOffButton.ForeColor = Color.White
        CutOffButton.Image = My.Resources.cutoffWhite

        SalesReportButton.BackColor = Color.Transparent
        SalesReportButton.ForeColor = Color.White
        SalesReportButton.Image = My.Resources.salesreportWhite

        EmployeeButton.BackColor = Color.Transparent
        EmployeeButton.ForeColor = Color.White
        EmployeeButton.Image = My.Resources.employeeWhite

        PayrollButton.BackColor = Color.Transparent
        PayrollButton.ForeColor = Color.White
        PayrollButton.Image = My.Resources.payrollWhite


        AdminButton.BackColor = Color.White
        AdminButton.ForeColor = Color.Black
        AdminButton.Image = My.Resources.adminBlack
    End Sub
End Class
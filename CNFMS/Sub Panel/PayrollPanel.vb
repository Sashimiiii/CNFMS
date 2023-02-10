Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn


Public Class PayrollPanel
    Dim dialog1 As DialogResult
    Public Shared selectedID As Integer
    Dim selectedNameTable As String
    Dim selectedName As String
    Dim CountID As String
    Private Sub checkIfTableIsEmpty()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT COUNT(Id) FROM payroll_data WHERE print = 0"
                .Connection = SQLString
            End With
            Try

                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    While dataReader.Read()
                        If IsDBNull(dataReader(0)) Then
                            'MessageBox.Show("DB IS EMPTY")
                        Else
                            CountID = dataReader.GetString(0)
                            If CountID <= 0 Then
                                PrintButton.Enabled = False
                            Else
                                PrintButton.Enabled = True
                            End If

                        End If
                    End While
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub loadPayrollData()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            With sqlcommand
                .CommandText = "SELECT Id, DateFrom, DateTo, Name_Employee, Designation, CONCAT('₱ ', FORMAT(BasicDaily,2)) AS BasicDaily, NumberDays, CONCAT('₱ ', FORMAT(BasicPay,2)) AS BasicPay, CONCAT('₱ ', FORMAT(RegularHoliday,2)) AS RegularHoliday, CONCAT('₱ ', FORMAT(SpecialHoliday,2)) AS SpecialHoliday, CONCAT('₱ ', FORMAT(OT,2)) AS OT, CONCAT('₱ ', FORMAT(TotalPay,2)) AS TotalPay, SSS, PHIC, HDMF, TotalDeduction, CONCAT('₱ ', FORMAT(NetPay,2)) AS NetPay FROM payroll_data WHERE print = 0"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                payrollTable.DataSource = dataTables
                payrollTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        AddEmployeePayroll.Show()
    End Sub

    Private Sub PayrollPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkIfTableIsEmpty()
        loadPayrollData()
    End Sub

    Private Sub payrollTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles payrollTable.CellContentClick
        Try
            Dim selecteddata As DataGridViewRow = payrollTable.Rows(e.RowIndex)
            If payrollTable.Columns(e.ColumnIndex).Name = "deleteData" Then
                selectedID = selecteddata.Cells(1).Value.ToString()
                selectedNameTable = selecteddata.Cells(4).Value.ToString()

                dialog1 = MessageBox.Show("Do you want to delete PAYROLL DATA of" & vbCrLf & "           " & selectedNameTable,
                                                     "Remove",
                                                     MessageBoxButtons.OKCancel,
                                                     MessageBoxIcon.Information)
                If dialog1 = DialogResult.OK Then

                    Using sqlcommandDelete As New MySqlCommand()
                        With sqlcommandDelete
                            .CommandText = "DELETE FROM `payroll_data` WHERE Id = @delID"
                            .Parameters.AddWithValue("@delID", selectedID)
                            .Connection = SQLString
                            Try
                                sqlcommandDelete.ExecuteNonQuery()
                            Catch ex As Exception
                                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End With
                    End Using
                    PayrollPanel_Load(sender, e)
                    dialog1 = MessageBox.Show("Deleted! SuccessFully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        SearchTxt.Select()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dt As New DataTable
            With sqlcommand
                .CommandText = "SELECT Id, DateFrom, DateTo, Name_Employee, Designation, CONCAT('₱ ', FORMAT(BasicDaily,2)) AS BasicDaily, NumberDays, CONCAT('₱ ', FORMAT(BasicPay,2)) AS BasicPay, CONCAT('₱ ', FORMAT(RegularHoliday,2)) AS RegularHoliday, CONCAT('₱ ', FORMAT(SpecialHoliday,2)) AS SpecialHoliday, CONCAT('₱ ', FORMAT(OT,2)) AS OT, CONCAT('₱ ', FORMAT(TotalPay,2)) AS TotalPay, SSS, PHIC, HDMF, TotalDeduction, CONCAT('₱ ', FORMAT(NetPay,2)) AS NetPay FROM payroll_data"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dt.Clear()
                dataAdapter.Fill(dt)
                payrollTable.DataSource = dt
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Dim view As New DataView(dt)
            Dim source As New BindingSource
            source.DataSource = view
            payrollTable.DataSource = source
            source.Filter = String.Format("Name_Employee like '*" & Me.SearchTxt.Text & "*'", Me.SearchTxt.Text)
        End Using
    End Sub

    Private Sub SearchTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchTxt.KeyPress
        If SearchTxt.Text = "Search" Then
            SearchTxt.Text = ""
            SearchTxt.FocusedForeColor = Color.Black
        End If
    End Sub

    Private Sub SearchTxt_Enter(sender As Object, e As EventArgs) Handles SearchTxt.Enter
        If SearchTxt.Text = "Search" Then
            SearchTxt.Text = ""
            SearchTxt.FocusedForeColor = Color.Black
        End If
    End Sub

    Private Sub SearchTxt_LostFocus(sender As Object, e As EventArgs) Handles SearchTxt.LostFocus
        If SearchTxt.Text = "" Then
            SearchTxt.Text = "Search"
            loadPayrollData()

        End If
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPayroll.Show()
    End Sub

    Private Sub exportExcelButton_Click(sender As Object, e As EventArgs) Handles exportExcelButton.Click
        Dim showPanel As New ArchivedPayrollData
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        showPanel.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(showPanel)
    End Sub
End Class

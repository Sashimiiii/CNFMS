Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn

Public Class ArchivedPayrollData
    Dim dialog1 As DialogResult
    Public Shared selectedID As Integer
    Dim selectedNameTable As String
    Dim selectedName As String
    Private Sub ArchivedloadPayrollData()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            With sqlcommand
                .CommandText = "SELECT FORMAT(ROW_NUMBER() OVER (ORDER BY Id), 0) AS Id, DateFrom, DateTo, Name_Employee, Designation, CONCAT('₱ ', FORMAT(BasicDaily,2)) AS BasicDaily, NumberDays, CONCAT('₱ ', FORMAT(BasicPay,2)) AS BasicPay, CONCAT('₱ ', FORMAT(RegularHoliday,2)) AS RegularHoliday, CONCAT('₱ ', FORMAT(SpecialHoliday,2)) AS SpecialHoliday, CONCAT('₱ ', FORMAT(OT,2)) AS OT, CONCAT('₱ ', FORMAT(TotalPay,2)) AS TotalPay, SSS, PHIC, HDMF, TotalDeduction, CONCAT('₱ ', FORMAT(NetPay,2)) AS NetPay FROM payroll_data WHERE print = 1"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                ArchivedpayrollTable.DataSource = dataTables
                ArchivedpayrollTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub

    'Private Sub FilterArchivedPayrollData()
    '    Using sqlcommand As New MySqlCommand()
    '        Dim dataAdapter As New MySqlDataAdapter
    '        Dim dataTables As New DataTable
    '        Dim dateFrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
    '        Dim dateTo = DateTimePickerTo.Value.ToString("yyyy-MM-dd")
    '        With sqlcommand
    '            .CommandText = "SELECT FORMAT(ROW_NUMBER() OVER (ORDER BY Id), 0) AS Id, DateFrom, DateTo, Name_Employee, Designation, CONCAT('₱ ', FORMAT(BasicDaily,2)) AS BasicDaily, NumberDays, CONCAT('₱ ', FORMAT(BasicPay,2)) AS BasicPay, CONCAT('₱ ', FORMAT(RegularHoliday,2)) AS RegularHoliday, CONCAT('₱ ', FORMAT(SpecialHoliday,2)) AS SpecialHoliday, CONCAT('₱ ', FORMAT(OT,2)) AS OT, CONCAT('₱ ', FORMAT(TotalPay,2)) AS TotalPay, SSS, PHIC, HDMF, TotalDeduction, CONCAT('₱ ', FORMAT(NetPay,2)) AS NetPay FROM payroll_data WHERE print = 1 AND DateFrom = @periodfrom AND DateTo = @periodto"
    '            .Parameters.AddWithValue("@periodfrom", dateFrom)
    '            .Parameters.AddWithValue("@periodto", dateTo)
    '            .Connection = SQLString
    '        End With
    '        Try
    '            dataAdapter.SelectCommand = sqlcommand
    '            dataTables.Clear()
    '            dataAdapter.Fill(dataTables)
    '            ArchivedpayrollTable.DataSource = dataTables
    '            ArchivedpayrollTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    '        Catch ex As Exception
    '            dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End Try
    '    End Using
    'End Sub
    Private Sub ArchivedPayrollData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DateTimePickerFrom.Value = New DateTime((Now.Year), Now.Month, 1)
        'DateTimePickerTo.Value = DateSerial(Year(DateTimePickerFrom.Value), Month(DateTimePickerFrom.Value) + 1, 0)
        ArchivedloadPayrollData()
    End Sub

    Private Sub ArchivedpayrollTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArchivedpayrollTable.CellContentClick
        Try
            Dim selecteddata As DataGridViewRow = ArchivedpayrollTable.Rows(e.RowIndex)
            If ArchivedpayrollTable.Columns(e.ColumnIndex).Name = "deleteData" Then
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
                    ArchivedPayrollData_Load(sender, e)
                    dialog1 = MessageBox.Show("Deleted! SuccessFully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub



    Private Sub showAllButton_Click(sender As Object, e As EventArgs)
        ArchivedloadPayrollData()
    End Sub

    Private Sub exportPDFButton_Click(sender As Object, e As EventArgs) Handles exportPDFButton.Click
        ArchivedPayrolPdf.Show()
    End Sub

    Private Sub exportExcelButton_Click(sender As Object, e As EventArgs) 

    End Sub
End Class

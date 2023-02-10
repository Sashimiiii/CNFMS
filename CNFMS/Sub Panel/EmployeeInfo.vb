Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn


Public Class EmployeeInfo

    Dim dialog1 As DialogResult
    Public Shared selectedID As Integer
    Dim selectedName As String
    Private Sub loadTableEmployeeInfo()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            With sqlcommand
                .CommandText = "SELECT Id, CONCAT(Lname,', ', Fname, ' ',SUBSTRING(Mname, 1,1),'.') AS fullname, Position, Email, Address, ContactNumber FROM employee_info"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                employeeTable.DataSource = dataTables
                employeeTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub





    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        AddEmployee.Show()
    End Sub


    Public Sub EmployeeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTableEmployeeInfo()
    End Sub

    Private Sub employeeTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeeTable.CellContentClick
        Try
            Dim selecteddata As DataGridViewRow = employeeTable.Rows(e.RowIndex)
            If employeeTable.Columns(e.ColumnIndex).Name = "deleteData" Then
                selectedID = selecteddata.Cells(2).Value.ToString()
                selectedName = selecteddata.Cells(3).Value.ToString()
                'selectedPremium = selecteddata.Cells(4).Value.ToString()
                'selectedDiesel = selecteddata.Cells(5).Value.ToString()


                dialog1 = MessageBox.Show("Do you want to delete the EMPLOYEE INFORMATION OF " & vbCrLf & "                  " & selectedName,
                                                       "Delete Information",
                                                       MessageBoxButtons.OKCancel,
                                                       MessageBoxIcon.Information)
                If dialog1 = DialogResult.OK Then
                    Using sqlcommandDelete As New MySqlCommand()
                        With sqlcommandDelete
                            .CommandText = "DELETE FROM `employee_info` WHERE Id = @delID"
                            .Parameters.AddWithValue("@delID", selectedID)
                            .Connection = SQLString
                            Try
                                sqlcommandDelete.ExecuteNonQuery()
                            Catch ex As Exception
                                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End With
                    End Using
                    MainPanel.EmployeeButton_Click(sender, e)
                End If
            ElseIf employeeTable.Columns(e.ColumnIndex).Name = "updateData" Then
                selectedID = selecteddata.Cells(2).Value.ToString()
                'UpdateEmployee.Show()

                Dim ShowIsland3 As New EmployeeInformation
                MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
                ShowIsland3.Dock = DockStyle.Fill
                MainPanel.FillPanel.Controls.Clear()
                MainPanel.FillPanel.Controls.Add(ShowIsland3)
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
                .CommandText = "SELECT Id, CONCAT(Lname,', ', Fname, ' ',SUBSTRING(Mname, 1,1),'.') AS fullname, Position, Email, Address, ContactNumber FROM employee_info"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dt.Clear()
                dataAdapter.Fill(dt)
                employeeTable.DataSource = dt
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Dim view As New DataView(dt)
            Dim source As New BindingSource
            source.DataSource = view
            employeeTable.DataSource = source
            source.Filter = String.Format("fullname like '*" & Me.SearchTxt.Text & "*'", Me.SearchTxt.Text)
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
            loadTableEmployeeInfo()

        End If
    End Sub
End Class

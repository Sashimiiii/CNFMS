Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn

Public Class AddEmployeePayroll
    Public Shared employeeID As String = ""
    Dim dialog1 As DialogResult
    Private Sub addEmployee()
        Using sqlcommandCombox As New MySqlCommand()
            With sqlcommandCombox
                .CommandText = "SELECT CONCAT(Lname,', ', Fname, ' ',SUBSTRING(Mname, 1,1),'.') FROM employee_info"
                .Connection = SQLString
            End With
            Try
                ConnectSQL()
                Dim NameTxt As String = ""
                Using dataReader As MySqlDataReader = sqlcommandCombox.ExecuteReader
                    While dataReader.Read
                        NameTxt = dataReader.GetString(0)
                        NameEmployeeCombox.Items.Add(NameTxt)
                    End While
                End Using
            Catch ex As Exception
                dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property 'CreateParams


    Private Sub AddEmployeePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        addEmployee()

    End Sub

    Private Sub saveButton_Click_1(sender As Object, e As EventArgs) Handles saveButton.Click
        If NameEmployeeCombox.SelectedItem = String.Empty Then
            dialog1 = MessageBox.Show("Please Select Employee!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Using sqlcommandCombox As New MySqlCommand()
                With sqlcommandCombox
                    .CommandText = "SELECT Id FROM employee_info WHERE CONCAT(Lname,', ', Fname, ' ',SUBSTRING(Mname, 1,1),'.') = @fullname"
                    .Parameters.AddWithValue("@fullname", NameEmployeeCombox.SelectedItem.ToString)
                    .Connection = SQLString
                End With
                Try
                    ConnectSQL()
                    Dim Idss As String = ""
                    Using dataReader As MySqlDataReader = sqlcommandCombox.ExecuteReader
                        While dataReader.Read
                            Idss = dataReader.GetString(0)
                        End While
                        employeeID = Idss
                    End Using
                Catch ex As Exception
                    dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            Me.Close()
            Dim dashboardShow As New AddPayrollPanel
            MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
            dashboardShow.Dock = DockStyle.Fill
            MainPanel.FillPanel.Controls.Clear()
            MainPanel.FillPanel.Controls.Add(dashboardShow)
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
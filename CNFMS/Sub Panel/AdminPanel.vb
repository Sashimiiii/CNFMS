Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn



Public Class AdminPanel
    Dim dialog1 As DialogResult
    Public Shared selectedID As Integer
    Dim selectedName As String

    Dim IdTxt As String = ""
    Private Sub loadUserAccounts()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            With sqlcommand
                .CommandText = "SELECT Id, Username, CONCAT(l_name,', ', f_name, ' ',SUBSTRING(m_name, 1,1),'.') AS fullname, contact_number, email, role FROM user_accounts"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                AdminTable.DataSource = dataTables
                AdminTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub

    Private Sub CountUsers()
        Using sqlcommandCombox As New MySqlCommand()
            With sqlcommandCombox
                .CommandText = "SELECT Count(Id) FROM user_accounts"
                .Connection = SQLString
            End With
            Try
                ConnectSQL()

                Using dataReader As MySqlDataReader = sqlcommandCombox.ExecuteReader
                    While dataReader.Read
                        IdTxt = dataReader.GetString(0)
                    End While
                End Using

            Catch ex As Exception
                dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserAccounts()
    End Sub



    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        AddUser.Show()
    End Sub

    Private Sub AdminTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminTable.CellContentClick
        Try
            Dim selecteddata As DataGridViewRow = AdminTable.Rows(e.RowIndex)
            If AdminTable.Columns(e.ColumnIndex).Name = "deleteData" Then
                selectedID = selecteddata.Cells(2).Value.ToString()
                selectedName = selecteddata.Cells(4).Value.ToString()
                CountUsers()
                If IdTxt.Equals("1") Then
                    dialog1 = MessageBox.Show("Invalid! One Admin Account Must Remained!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    dialog1 = MessageBox.Show("Do you want to delete the ADMIN ACCOUNT of" & vbCrLf & "                  " & selectedName,
                                                       "Delete Information",
                                                       MessageBoxButtons.OKCancel,
                                                       MessageBoxIcon.Information)
                    If dialog1 = DialogResult.OK Then
                        Using sqlcommandDelete As New MySqlCommand()
                            With sqlcommandDelete
                                .CommandText = "DELETE FROM `user_accounts` WHERE Id = @delID"
                                .Parameters.AddWithValue("@delID", selectedID)
                                .Connection = SQLString
                                Try
                                    sqlcommandDelete.ExecuteNonQuery()
                                Catch ex As Exception
                                    dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            End With
                        End Using
                        MainPanel.AdminButton_Click(sender, e)
                    End If
                End If


            ElseIf AdminTable.Columns(e.ColumnIndex).Name = "updateData" Then
                selectedID = selecteddata.Cells(2).Value.ToString()
                'UpdateEmployee.Show()
                Dim showPanel As New AdminAccountInfo
                MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
                showPanel.Dock = DockStyle.Fill
                MainPanel.FillPanel.Controls.Clear()
                MainPanel.FillPanel.Controls.Add(showPanel)
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
                .CommandText = "SELECT Id, Username, CONCAT(l_name,', ', f_name, ' ',SUBSTRING(m_name, 1,1),'.') AS fullname, contact_number, email, role FROM user_accounts"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dt.Clear()
                dataAdapter.Fill(dt)
                AdminTable.DataSource = dt
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Dim view As New DataView(dt)
            Dim source As New BindingSource
            source.DataSource = view
            AdminTable.DataSource = source
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
            loadUserAccounts()
        End If
    End Sub
End Class

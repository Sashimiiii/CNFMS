Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class SQLConn
    Public Shared dialog3 As DialogResult

    Public Shared SQLString As New MySqlConnection("Server = " & My.Settings.Server & "; Database = " & My.Settings.Database & "; Uid = " & My.Settings.User & "; Password = " & My.Settings.Pass & ";")
    Shared Sub ConnectSQL()
        Try

            If SQLString.State = ConnectionState.Closed Then
                SQLString.Open()
            End If
        Catch ex As Exception
            dialog3 = MessageBox.Show("Connection is OFFLINE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function Md5FromString(ByVal Source As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()
        If String.IsNullOrEmpty(Source) Then
            Try
                Throw New ArgumentNullException
            Catch ex As Exception
            End Try

        End If
        Bytes = Encoding.Default.GetBytes(Source)
        Bytes = MD5.Create().ComputeHash(Bytes)
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        Return sb.ToString
    End Function
    Shared Function SearchData(itemToSearch As String, tbl As String, whereToSearch As String, value As String) As String

        Using sqlComm As New MySqlCommand
            Dim dataAdapt As New MySqlDataAdapter
            Dim dataset As New DataSet
            Dim result As String = ""
            With sqlComm
                .CommandText = "SELECT " & itemToSearch & " FROM " & tbl & " WHERE " & whereToSearch & " = " & value
                .Connection = SQLString
            End With

            Try
                dataAdapt.SelectCommand = sqlComm
                dataAdapt.Fill(dataset)
                If dataset.Tables(0).Rows.Count < 1 Then
                    result = ""
                Else
                    result = dataset.Tables(0).Rows(0).Item(0).ToString
                End If
            Catch ex As Exception
                dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Return result
        End Using

    End Function

    Shared Function SearchDataOR(itemToSearch As String, tbl As String, whereToSearch As String, value As String, whereToSearch1 As String, value1 As String) As String
        Using sqlComm As New MySqlCommand
            Dim dataAdapt As New MySqlDataAdapter
            Dim dataset As New DataSet
            Dim result As String = ""
            With sqlComm
                .CommandText = "SELECT " & itemToSearch & " FROM " & tbl & " WHERE " & whereToSearch & " = " & value & " Or " & whereToSearch1 & value1
                .Connection = SQLString
            End With

            Try
                dataAdapt.SelectCommand = sqlComm
                dataAdapt.Fill(dataset)
                If dataset.Tables(0).Rows.Count < 1 Then
                    result = ""
                Else
                    result = dataset.Tables(0).Rows(0).Item(0).ToString
                End If
            Catch ex As Exception
                dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return result
        End Using
    End Function

    Shared Sub DeleteData(tableName As String, columnName As String, id As String)
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "DELETE FROM " & tableName & " WHERE " & columnName & " = @id"
                .Parameters.AddWithValue("@id", id)
                .Connection = SQLString
            End With
            Try
                sqlcommand.ExecuteNonQuery()
            Catch ex As Exception
                dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    'Shared Sub PrintAccount()
    '    Dim reg As New UsersDashboard
    '    Using sqlcommand As New MySqlCommand()
    '        Dim dataAdapter As New MySqlDataAdapter
    '        Dim dataTable As New DataTable

    '        With sqlcommand
    '            .CommandText = "SELECT id, FirstName, LastName, Department, UserType, EmailAddress FROM user_accounts"
    '            .Connection = SQLString
    '        End With

    '        Try
    '            dataAdapter.SelectCommand = sqlcommand
    '            dataTable.Clear()
    '            dataAdapter.Fill(dataTable)

    '            For Each row As DataRow In dataTable.Rows
    '                row(1) = row(1) & " " & row(2)
    '            Next
    '            dataTable.Columns.RemoveAt(2)
    '            reg.register_table_accounts.DataSource = dataTable

    '        Catch ex As Exception
    '            dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using
    'End Sub

    Shared Sub PrintItem(tbl As DataGridView, itemToDisplay As String, tableName As String, Optional condition As String = "1")

        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable
            With sqlcommand
                .CommandText = "SELECT " & itemToDisplay & " FROM " & tableName & " WHERE " & condition
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                tbl.DataSource = dataTable
                tbl.Refresh()
            Catch ex As Exception
                dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Shared Sub PrintData(tbl As DataGridView, cmd As String)
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable

            With sqlcommand
                .CommandText = cmd
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                tbl.DataSource = dataTable
                tbl.Refresh()
            Catch ex As Exception
                dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



End Class

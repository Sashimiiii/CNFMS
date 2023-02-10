Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CNFMS.LoginForm

Public Class UserSettingUpdate
    Dim dialog1 As DialogResult
    Dim passwordTxt As String = ""
    Private Sub showFuelInfo()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT * FROM user_accounts WHERE Id = @idss"
                .Parameters.AddWithValue("@idss", selectedID)
                .Connection = SQLString
            End With
            Try
                Dim FnameUpper As String = ""
                Dim LnameUpper As String = ""
                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    If dataReader.Read Then
                        FnameUpper = dataReader.GetString(2)
                        LnameUpper = dataReader.GetString(4)
                        jobTxt.Text = dataReader.GetString(7)
                        passwordTxt = dataReader.GetString(8)
                    End If
                End Using
                nameFullTxt.Text = LnameUpper + ", " + FnameUpper

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub UserSettingUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showFuelInfo()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If Not Md5FromString(oldtPassTxt.Text).Equals(passwordTxt) Then
            dialog1 = MessageBox.Show("Invalid Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not newPassTxt.Text.Equals(confirmPwTxt.Text) Then
            dialog1 = MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using sqlcommand As New MySqlCommand()
                    With sqlcommand
                        .CommandText = "UPDATE user_accounts SET password = MD5(@pword) WHERE Id = @idss"
                        .Parameters.AddWithValue("@idss", selectedID)
                        .Parameters.AddWithValue("@pword", confirmPwTxt.Text)
                        .Connection = SQLString

                    End With
                    Try
                        ConnectSQL()
                        sqlcommand.ExecuteNonQuery()
                        Dim showPanel As New Dashboard
                        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
                        showPanel.Dock = DockStyle.Fill
                        MainPanel.FillPanel.Controls.Clear()
                        MainPanel.FillPanel.Controls.Add(showPanel)

                        dialog1 = MessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


End Class

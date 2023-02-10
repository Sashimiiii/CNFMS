Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CNFMS.AdminPanel

Public Class AdminAccountInfo
    Dim FnameUpper As String = ""
    Dim MnameUpper As String = ""
    Dim LnameUpper As String = ""
    Dim PositionUpper As String = ""
    Dim AddressUpper As String = ""
    Dim dialog1 As DialogResult
    Private Sub showFuelInfo()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT * FROM user_accounts WHERE Id = @idss"
                .Parameters.AddWithValue("@idss", selectedID)
                .Connection = SQLString
            End With
            Try
                Dim showTxt1 As String = ""
                Dim showTxt2 As String = ""
                Dim showTxt3 As String = ""
                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    If dataReader.Read Then
                        IDTxt.Text = dataReader.GetString(0)
                        FnameTxt.Text = dataReader.GetString(2)
                        MnameTxt.Text = dataReader.GetString(3)
                        LnameTxt.Text = dataReader.GetString(4)
                        positionTxtBox.Text = dataReader.GetString(7)
                        emailTextBox.Text = dataReader.GetString(6)
                        cotactTextBox.Text = dataReader.GetString(5)
                        usernameTextBox.Text = dataReader.GetString(1)
                        jobTxt.Text = dataReader.GetString(7)
                    End If
                End Using
                nameFullTxt.Text = LnameTxt.Text + ", " + FnameTxt.Text

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub AdminAccountInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showFuelInfo()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If FnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf positionTxtBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf emailTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cotactTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf LnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usernameTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cotactTextBox.Text.Length < 11 Then
            dialog1 = MessageBox.Show("Must Contain 11 Numbers!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                FnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(FnameTxt.Text)
                MnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(MnameTxt.Text)
                LnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LnameTxt.Text)



                ''Update AdminUserAccount
                Using sqlcommand As New MySqlCommand()
                    With sqlcommand
                        .CommandText = "UPDATE user_accounts SET username = @userss, f_name = @fname, m_name = @mname, l_name = @lname, contact_number = @contactss, email = @emailss, role = @positionss WHERE Id = @idss"
                        .Parameters.AddWithValue("@idss", selectedID)
                        .Parameters.AddWithValue("@userss", usernameTextBox.Text)
                        .Parameters.AddWithValue("@fname", FnameUpper)
                        .Parameters.AddWithValue("@mname", MnameUpper)
                        .Parameters.AddWithValue("@lname", LnameUpper)
                        .Parameters.AddWithValue("@contactss", cotactTextBox.Text.Trim)
                        .Parameters.AddWithValue("@emailss", emailTextBox.Text.Trim)
                        .Parameters.AddWithValue("@positionss", positionTxtBox.Text)
                        .Connection = SQLString

                    End With
                    Try
                        ConnectSQL()
                        sqlcommand.ExecuteNonQuery()
                        Dim showPanel As New AdminPanel
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

    Private Sub cotactTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cotactTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class

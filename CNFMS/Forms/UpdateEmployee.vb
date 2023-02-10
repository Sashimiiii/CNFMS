Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CNFMS.EmployeeInfo


Public Class UpdateEmployee
    Dim dialog1 As DialogResult

    Dim FnameUpper As String = ""
    Dim MnameUpper As String = ""
    Dim LnameUpper As String = ""
    Dim PositionUpper As String = ""
    Dim AddressUpper As String = ""



    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property 'CreateParams

    Private Sub showFuelInfo()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT * FROM employee_info WHERE Id = @idss"
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
                        FnameTxt.Text = dataReader.GetString(1)
                        MnameTxt.Text = dataReader.GetString(2)
                        LnameTxt.Text = dataReader.GetString(3)
                        positionTxtBox.Text = dataReader.GetString(4)
                        emailTextBox.Text = dataReader.GetString(5)
                        addressTextBox.Text = dataReader.GetString(6)
                        cotactTextBox.Text = dataReader.GetString(7)
                    End If
                End Using


            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub UpdateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        showFuelInfo()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub



    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub cotactTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cotactTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If FnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf positionTxtBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf emailTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf addressTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cotactTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf LnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cotactTextBox.Text.Length < 11 Then
            dialog1 = MessageBox.Show("Must Contain 11 Numbers!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                FnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(FnameTxt.Text)
                MnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(MnameTxt.Text)
                LnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LnameTxt.Text)
                PositionUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(positionTxtBox.Text)
                AddressUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(addressTextBox.Text)

                ''add inventory to database
                Using sqlcommand As New MySqlCommand()
                    With sqlcommand
                        .CommandText = "UPDATE employee_info SET Fname = @fname, Mname = @mname, Lname = @lname, Position = @positionss, Email = @emailss, Address = @addresss, ContactNumber = @contactss WHERE Id = @idss"
                        .Parameters.AddWithValue("@idss", selectedID)
                        .Parameters.AddWithValue("@fname", FnameUpper)
                        .Parameters.AddWithValue("@mname", MnameUpper)
                        .Parameters.AddWithValue("@lname", LnameUpper)
                        .Parameters.AddWithValue("@positionss", PositionUpper)
                        .Parameters.AddWithValue("@emailss", emailTextBox.Text.Trim)
                        .Parameters.AddWithValue("@addresss", AddressUpper)
                        .Parameters.AddWithValue("@contactss", cotactTextBox.Text.Trim)
                        .Connection = SQLString

                    End With
                    Try
                        ConnectSQL()
                        sqlcommand.ExecuteNonQuery()
                        MainPanel.EmployeeButton_Click(sender, e)
                        Me.Close()
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
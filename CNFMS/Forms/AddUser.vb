Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn

Public Class AddUser
    Dim dialog1 As DialogResult

    Dim FnameUpper As String = ""
    Dim MnameUpper As String = ""
    Dim LnameUpper As String = ""
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property 'CreateParams

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If UsernameTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf FnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf roleTxtBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf emailTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf UsernameTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cotactTextBox.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf LnameTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cotactTextBox.Text.Length < 11 Then
            dialog1 = MessageBox.Show("Must Contain 11 Numbers!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not (pwTxt.Text.Equals(confirmPwTxt.Text)) Then
            dialog1 = MessageBox.Show("Invalid Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pwTxt.Text = ""
            confirmPwTxt.Text = ""
        Else
            Try
                FnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(FnameTxt.Text)
                MnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(MnameTxt.Text)
                LnameUpper = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LnameTxt.Text)


                ''insert into userAccounts table
                Using sqlcommand As New MySqlCommand()
                    With sqlcommand
                        .CommandText = "INSERT INTO user_accounts (username, f_name, m_name, l_name, contact_number, email, role, password) 
                                values (@userss, @fname, @mname, @lname, @contacts, @emailss, @roless, MD5(@pw))"
                        .Parameters.AddWithValue("userss", UsernameTextBox.Text.Trim)
                        .Parameters.AddWithValue("@fname", FnameUpper)
                        .Parameters.AddWithValue("@mname", MnameUpper)
                        .Parameters.AddWithValue("@lname", LnameUpper)
                        .Parameters.AddWithValue("@contacts", cotactTextBox.Text.Trim)
                        .Parameters.AddWithValue("@emailss", emailTextBox.Text.Trim)
                        .Parameters.AddWithValue("@roless", roleTxtBox.Text)
                        .Parameters.AddWithValue("@pw", confirmPwTxt.Text.Trim)
                        .Connection = SQLString
                    End With
                    Try
                        ConnectSQL()
                        sqlcommand.ExecuteNonQuery()
                        MainPanel.AdminButton_Click(sender, e)
                        Me.Close()
                        dialog1 = MessageBox.Show("Admin User Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using


            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        End If
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
End Class
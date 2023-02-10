Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports CNFMS.SQLConn
Public Class LoginForm
    Dim dialog1 As DialogResult
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property 'CreateParams
    Public Shared selectedID As Integer
    Public Shared Nameuser As String = ""
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

        userBox.Text = "Username"
        userBox.TextAlign = HorizontalAlignment.Left
        userBox.ForeColor = Color.DimGray

        passBox.Text = "Password"
        passBox.TextAlign = HorizontalAlignment.Left
        passBox.ForeColor = Color.DimGray
    End Sub

    Private Sub userBox_Enter(sender As Object, e As EventArgs) Handles userBox.Enter
        If userBox.Text = "Username" Then
            userBox.Text = ""
            userBox.FocusedForeColor = Color.Black
        End If
    End Sub

    Private Sub userBox_Leave(sender As Object, e As EventArgs) Handles userBox.Leave
        If userBox.Text = "" Then
            userBox.Text = "Username"
            userBox.ForeColor = Color.DimGray
        End If
    End Sub



    Private Sub passBox_Enter(sender As Object, e As EventArgs) Handles passBox.Enter
        If passBox.Text = "Password" Then
            passBox.Text = ""
            passBox.FocusedForeColor = Color.Black
        End If
    End Sub

    Private Sub passBox_Leave(sender As Object, e As EventArgs) Handles passBox.Leave
        If passBox.Text = "" Then
            passBox.Text = "Password"
            passBox.ForeColor = Color.DimGray
        End If
    End Sub



    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT * FROM user_accounts WHERE username = @usss And password = MD5(@pass)"
                .Parameters.AddWithValue("@usss", userBox.Text.Trim)
                .Parameters.AddWithValue("@pass", passBox.Text)
                .Connection = SQLString
            End With
            Try
                ConnectSQL()
                Dim getuser As String = ""
                Dim getpass As String = ""
                Dim getrole As String = ""
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    If dataReader.Read Then
                        selectedID = dataReader.GetString(0)
                        Nameuser = dataReader.GetString(4)
                        getuser = dataReader.GetString(1)
                        getrole = dataReader.GetString(7)
                        getpass = dataReader.GetString(8)
                    End If

                End Using
                If getuser = String.Empty Or getpass = String.Empty Then
                    dialog1 = MessageBox.Show("INVALID CREDENTIALS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (getrole.Equals("ADMIN")) Then
                    userBox.Text = ""
                    passBox.Text = ""
                    MainPanel.Show()
                    Me.Hide()
                Else
                    dialog1 = MessageBox.Show("INVALID CREDENTIALS!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


End Class
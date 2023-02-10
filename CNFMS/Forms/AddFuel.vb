Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Public Class AddFuel
    Dim dialog1 As DialogResult
    Dim invenShow As New InventoryPanel
    Dim totalliters1 As Decimal
    Dim totalliters2 As Decimal
    Dim totalliters3 As Decimal
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property 'CreateParams

    Dim regularTxt As String = ""
    Dim premiumTxt As String = ""
    Dim dieselTxt As String = ""

    Dim AddQuantity1 As Decimal
    Dim AddQuantity2 As Decimal
    Dim AddQuantity3 As Decimal

    Dim X As Integer
    Dim dateText As String
    Private Sub showFuelInfo()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT * FROM fuelprice"
                .Connection = SQLString
            End With
            Try

                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    If dataReader.Read Then
                        regularTxt = dataReader.GetString(4)
                        premiumTxt = dataReader.GetString(5)
                        dieselTxt = dataReader.GetString(6)
                        totalliters1 = dataReader.GetString(7)
                        totalliters2 = dataReader.GetString(8)
                        totalliters3 = dataReader.GetString(9)
                    End If
                End Using

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub





    Private Sub AddFuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        showFuelInfo()
        timecombox.DropDownStyle = ComboBoxStyle.DropDown
        DateTimePickerFrom.Value = DateTime.Now
        'Fills the combobox with times 1 hour appart from 12:00AM to 11:00PM
        For X = 0 To 23
            Dim tm As New Date(1, 1, 1, X, 0, 0)
            timecombox.Items.Add(tm.ToShortTimeString)
        Next
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        quantityFuel1.Text = ""
        quantityFuel2.Text = ""
        quantityFuel3.Text = ""
        Me.Close()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        If quantityFuel1.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf quantityFuel2.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf quantityFuel3.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf timecombox.SelectedItem = String.Empty Then
            dialog1 = MessageBox.Show("Please Select Time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                AddQuantity1 = Math.Round(CDec(quantityFuel1.Text), 2)
                AddQuantity2 = Math.Round(CDec(quantityFuel2.Text), 2)
                AddQuantity3 = Math.Round(CDec(quantityFuel3.Text), 2)


                Using sqlcommand As New MySqlCommand()
                    With sqlcommand
                        .CommandText = "INSERT INTO inventoryfuel (Date_added, Regular, Premium, Diesel, Price_Regular, Price_Premium, Price_Diesel) 
                                values (@dateSet, @regular, @premium, @diesel, @p_regular, @p_premium, @p_diesel)"
                        .Parameters.AddWithValue("@dateSet", dateText)
                        .Parameters.AddWithValue("@regular", AddQuantity1)
                        .Parameters.AddWithValue("@premium", AddQuantity2)
                        .Parameters.AddWithValue("@diesel", AddQuantity3)
                        .Parameters.AddWithValue("@p_regular", regularTxt)
                        .Parameters.AddWithValue("@p_premium", premiumTxt)
                        .Parameters.AddWithValue("@p_diesel", dieselTxt)
                        .Connection = SQLString

                    End With
                    Try
                        ConnectSQL()
                        sqlcommand.ExecuteNonQuery()
                    Catch ex As Exception
                        dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using



                Using sqlcommand1 As New MySqlCommand()
                    Dim addquantiyRegular As String
                    Dim addquantiyPremium As String
                    Dim addquantiyDiesel As String

                    addquantiyRegular = quantityFuel1.Text + totalliters1
                    addquantiyPremium = quantityFuel2.Text + totalliters2
                    addquantiyDiesel = quantityFuel3.Text + totalliters3

                    With sqlcommand1
                        .CommandText = "UPDATE fuelprice SET TotalQuantity1 = @regular, TotalQuantity2 = @premium, TotalQuantity3 = @diesel WHERE id = 1"
                        .Parameters.AddWithValue("@regular", addquantiyRegular)
                        .Parameters.AddWithValue("@premium", addquantiyPremium)
                        .Parameters.AddWithValue("@diesel", addquantiyDiesel)
                        .Connection = SQLString

                    End With
                    Try
                        ConnectSQL()
                        sqlcommand1.ExecuteNonQuery()
                        AddFuel_Load(sender, e)
                        MainPanel.inventoryButton_Click(sender, e)
                    Catch ex As Exception
                        dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
                quantityFuel1.Text = ""
                quantityFuel2.Text = ""
                quantityFuel3.Text = ""
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub quantityFuel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityFuel1.KeyPress

        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub quantityFuel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityFuel2.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub quantityFuel3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityFuel3.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub



    Private Sub timecombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles timecombox.SelectedIndexChanged
        Dim dt As Date
        If Date.TryParse(timecombox.SelectedItem.ToString, dt) Then
            Dim datefrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
            dateText = datefrom + " " + dt.ToString("HH:mm:ss")

        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn

Public Class Addisland1Report
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property 'CreateParams

    Dim X As Integer

    Dim dialog1 As DialogResult
    Dim regularTxt As String = ""
    Dim premiumTxt As String = ""
    Dim dieselTxt As String = ""

    Dim CashSaleRegular As Decimal
    Dim CashSalePremium As Decimal
    Dim CashSaleDiesel As Decimal
    Dim TotalSaleTXT As String

    Dim updateTotalLiters1 As Decimal
    Dim updateTotalLiters2 As Decimal
    Dim updateTotalLiters3 As Decimal

    Dim totalliters1 As Decimal
    Dim totalliters2 As Decimal
    Dim totalliters3 As Decimal

    Dim TotalLitersOut1 As Decimal
    Dim TotalLitersOut2 As Decimal
    Dim TotalLitersOut3 As Decimal

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
    Private Sub Addisland1Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        If litersOutTxt1.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf litersOutTxt2.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf litersOutTxt3.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pumpCombox.SelectedItem = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf litersOutTxt1.Text > totalliters1 Then
            dialog1 = MessageBox.Show("Inventory of Regular is low cant deduct!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf litersOutTxt2.Text > totalliters2 Then
            dialog1 = MessageBox.Show("Inventory of Premium is low cant deduct!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf litersOutTxt3.Text > totalliters3 Then
            dialog1 = MessageBox.Show("Inventory of Diesel is low cant deduct!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf timecombox.SelectedItem = String.Empty Then
            dialog1 = MessageBox.Show("Please Select Time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            TotalLitersOut1 = Math.Round(CDec(litersOutTxt1.Text), 2)
            TotalLitersOut2 = Math.Round(CDec(litersOutTxt2.Text), 2)
            TotalLitersOut3 = Math.Round(CDec(litersOutTxt3.Text), 2)
            Try
                ''add inventory to database
                Using sqlcommand As New MySqlCommand()
                    With sqlcommand
                        .CommandText = "INSERT INTO island1_report (Pump_name, Date_cutOff, LitersOut_Regular, LitersOut_Premium, LitersOut_Diesel, Price_Regular, Price_Premium, Price_Diesel) 
                                values (@pumpname, @dateSet, @regular, @premium, @diesel, @p_regular, @p_premium, @p_diesel)"
                        .Parameters.AddWithValue("@pumpname", pumpCombox.SelectedItem.ToString)
                        .Parameters.AddWithValue("@dateSet", dateText)
                        .Parameters.AddWithValue("@regular", TotalLitersOut1)
                        .Parameters.AddWithValue("@premium", TotalLitersOut2)
                        .Parameters.AddWithValue("@diesel", TotalLitersOut3)
                        .Parameters.AddWithValue("@p_regular", regularTxt)
                        .Parameters.AddWithValue("@p_premium", premiumTxt)
                        .Parameters.AddWithValue("@p_diesel", dieselTxt)
                        .Connection = SQLString

                    End With
                    Try
                        ConnectSQL()
                        sqlcommand.ExecuteNonQuery()
                    Catch ex As Exception
                        dialog1 = MessageBox.Show("bayot1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using

                Using sqlcommand2 As New MySqlCommand()

                    CashSaleRegular = Format(Val(litersOutTxt1.Text * regularTxt), "0.00")
                    CashSalePremium = Format(Val(litersOutTxt2.Text * premiumTxt), "0.00")
                    CashSaleDiesel = Format(Val(litersOutTxt3.Text * dieselTxt), "0.00")
                    TotalSaleTXT = Format(Val(CashSaleRegular + CashSalePremium + CashSaleDiesel), "0.00")

                    With sqlcommand2
                        .CommandText = "INSERT INTO island1_cashsale (Pump_name, Date_CutOff, SalesRegular, SalesPremium, SalesDiesel, Total_Sale, Price_Regular, Price_Premium, Price_Diesel) 
                                values (@pumpname, @dateSet, @regular, @premium, @diesel, @TotalSales, @p_regular, @p_premium, @p_diesel)"
                        .Parameters.AddWithValue("@pumpname", pumpCombox.SelectedItem.ToString)
                        .Parameters.AddWithValue("@dateSet", dateText)
                        .Parameters.AddWithValue("@regular", CashSaleRegular)
                        .Parameters.AddWithValue("@premium", CashSalePremium)
                        .Parameters.AddWithValue("@diesel", CashSaleDiesel)
                        .Parameters.AddWithValue("@TotalSales", TotalSaleTXT)
                        .Parameters.AddWithValue("@p_regular", regularTxt)
                        .Parameters.AddWithValue("@p_premium", premiumTxt)
                        .Parameters.AddWithValue("@p_diesel", dieselTxt)
                        .Connection = SQLString

                    End With
                    Try
                        ConnectSQL()
                        sqlcommand2.ExecuteNonQuery()
                    Catch ex As Exception
                        dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using

                ''deduc into inventory
                Using sqlcommand3 As New MySqlCommand()

                    updateTotalLiters1 = Format(Val(totalliters1 - litersOutTxt1.Text), "0.00")
                        updateTotalLiters2 = Format(Val(totalliters2 - litersOutTxt2.Text), "0.00")
                        updateTotalLiters3 = Format(Val(totalliters3 - litersOutTxt3.Text), "0.00")

                        With sqlcommand3
                            .CommandText = "UPDATE fuelprice SET TotalQuantity1 = @regular, TotalQuantity2 = @premium, TotalQuantity3 = @diesel WHERE id = 1"
                            .Parameters.AddWithValue("@regular", updateTotalLiters1)
                            .Parameters.AddWithValue("@premium", updateTotalLiters2)
                            .Parameters.AddWithValue("@diesel", updateTotalLiters3)
                            .Connection = SQLString

                        End With
                    Try
                        ConnectSQL()
                        sqlcommand3.ExecuteNonQuery()

                    Catch ex As Exception
                        dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End Using
                Me.Close()
                Dim showCutOffPanel As New CutOff_Panel
                Addisland1Report_Load(sender, e)
                showCutOffPanel.ShadowPanel1_MouseClick(sender, e)
                dialog1 = MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                litersOutTxt1.Text = ""
                litersOutTxt2.Text = ""
                litersOutTxt3.Text = ""

            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub litersOutTxt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles litersOutTxt1.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub litersOutTxt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles litersOutTxt2.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub litersOutTxt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles litersOutTxt3.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        litersOutTxt1.Text = ""
        litersOutTxt2.Text = ""
        litersOutTxt3.Text = ""
        Me.Close()
    End Sub

    Private Sub timecombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles timecombox.SelectedIndexChanged
        Dim dt As Date
        If Date.TryParse(timecombox.SelectedItem.ToString, dt) Then
            Dim datefrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
            dateText = datefrom + " " + dt.ToString("HH:mm:ss")

        End If
    End Sub


End Class
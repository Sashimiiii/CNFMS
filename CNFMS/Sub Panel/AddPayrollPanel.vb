Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn
Imports CNFMS.AddEmployeePayroll
Public Class AddPayrollPanel
    Dim dialog1 As DialogResult
    Private Sub DisplayEmployee()
        Using sqlcommandCombox As New MySqlCommand()
            With sqlcommandCombox
                .CommandText = "SELECT Id, CONCAT(Lname,', ', Fname, ' ',SUBSTRING(Mname, 1,1),'.'), Position FROM employee_info WHERE Id = @idss"
                .Parameters.AddWithValue("@idss", employeeID)
                .Connection = SQLString
            End With
            Try
                ConnectSQL()
                Dim IdTxt As String = ""
                Dim FullnameTxt As String = ""
                Dim PosTxt As String = ""
                Using dataReader As MySqlDataReader = sqlcommandCombox.ExecuteReader
                    While dataReader.Read
                        IdTxt = dataReader.GetString(0)
                        FullnameTxt = dataReader.GetString(1)
                        PosTxt = dataReader.GetString(2)
                    End While
                End Using
                employmentIDTxt.Text = IdTxt
                nameFullTxt.Text = FullnameTxt
                jobTxt.Text = PosTxt
            Catch ex As Exception
                dialog3 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub
    'Private Function ConvertToDeci(ByRef value As String) As Integer
    '    If String.IsNullOrEmpty(value) Then
    '        value = "0"
    '    End If
    '    Return Convert.ToDecimal(value)
    'End Function
    Private Sub ComputeAll()

        If dutyDaysTxt.Value = "0" Or dutyDaysTxt.Value = "0" Then
            MessageBox.Show("Invalid")

        ElseIf basicDailyTxt.Text = String.Empty Or basicDailyTxt.Text = "0" Then
            MessageBox.Show("Invalid")
        Else
            basicPayTxt.Text = Format(Val((basicDailyTxt.Text * dutyDaysTxt.Value)), "0.00")
            TotalPayTxt.Text = Format(Val((OTTxt.Text) + Decimal.Parse(specialHolidayTxt.Text) + Decimal.Parse(RegularHolidayTxt.Text) + Decimal.Parse(basicPayTxt.Text)), "0.00")
            TotalDeducTxt.Text = Format(Val(Decimal.Parse(hdmTxt.Text) + Decimal.Parse(sssTxt.Text) + Decimal.Parse(phicTxt.Text)), "0.00")
            TotalNetPay.Text = Format(Val(Decimal.Parse(TotalPayTxt.Text) - (Decimal.Parse(hdmTxt.Text) + Decimal.Parse(sssTxt.Text) + Decimal.Parse(phicTxt.Text))), "0.00")
        End If
    End Sub


    Private Sub AddPayrollPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmployee()
        basicPayTxt.Text = "0.00"
        TotalPayTxt.Text = "0.00"
        TotalDeducTxt.Text = "0.00"
        TotalNetPay.Text = "0.00"
        DateFromPicker.Value = DateTime.Now
        DateToPicker.Value = DateTime.Now
    End Sub

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        If basicDailyTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill-up all blanks!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dutyDaysTxt.Value <= 0 Then
            dialog1 = MessageBox.Show("# of duty Days Must be greater than 0!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf basicPayTxt.Text = String.Empty Then
            dialog1 = MessageBox.Show("NO Total Basic Pay Invalid!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DateFromPicker.Value.Equals(DateToPicker.Value) Then
            dialog1 = MessageBox.Show("Invalid! Please select the date period of the payroll", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ComputeAll()
            saveButton.Enabled = True
        End If

    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        '  MessageBox.Show(TotalDeducTxt.Text)
        Try
            Dim detFrom As String = DateFromPicker.Value.ToString("yyyy-MM-dd")
            Dim detTo As String = DateToPicker.Value.ToString("yyyy-MM-dd")
            Using sqlcommand1 As New MySqlCommand()
                With sqlcommand1
                    .CommandText = "INSERT INTO payroll_data (DateFrom, DateTo, Name_Employee, Designation, BasicDaily, numberDays, BasicPay, RegularHoliday, SpecialHoliday, OT, TotalPay, SSS, PHIC, HDMF, TotalDeduction, NetPay)
                                values (@dateFroms, @dateToss, @fullname, @positionss, @basicDailys, @numDays, @basicPays, @rholiday, @spholiday, @otpay, @totalpay, @ssstax, @phictax, @hdmftax, @totaldeduc, @netpays)"
                    .Parameters.AddWithValue("@dateFroms", detFrom)
                    .Parameters.AddWithValue("@dateToss", detTo)
                    .Parameters.AddWithValue("@fullname", nameFullTxt.Text)
                    .Parameters.AddWithValue("@positionss", jobTxt.Text)
                    .Parameters.AddWithValue("@basicDailys", basicDailyTxt.Text)
                    .Parameters.AddWithValue("@numDays", dutyDaysTxt.Value)
                    .Parameters.AddWithValue("@basicPays", basicPayTxt.Text)
                    .Parameters.AddWithValue("@rholiday", RegularHolidayTxt.Text)
                    .Parameters.AddWithValue("@spholiday", specialHolidayTxt.Text)
                    .Parameters.AddWithValue("@otpay", OTTxt.Text)
                    .Parameters.AddWithValue("@totalpay", TotalPayTxt.Text)
                    .Parameters.AddWithValue("@ssstax", sssTxt.Text)
                    .Parameters.AddWithValue("@phictax", phicTxt.Text)
                    .Parameters.AddWithValue("@hdmftax", hdmTxt.Text)
                    .Parameters.AddWithValue("@totaldeduc", TotalDeducTxt.Text)
                    .Parameters.AddWithValue("@netpays", TotalNetPay.Text)
                    .Connection = SQLString
                End With

                ConnectSQL()
                sqlcommand1.ExecuteNonQuery()
                MainPanel.PayrollButton_Click(sender, e)
                ' dialog1 = MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            dialog1 = MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub basicDailyTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles basicDailyTxt.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub dutyDaysTxt_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub RegularHolidayTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RegularHolidayTxt.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub



    Private Sub OTTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OTTxt.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub specialHolidayTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles specialHolidayTxt.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub sssTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sssTxt.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub phicTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phicTxt.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub hdmTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hdmTxt.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub DateToPicker_ValueChanged(sender As Object, e As EventArgs) Handles DateToPicker.ValueChanged

    End Sub

    Private Sub TotalPayTxt_Click(sender As Object, e As EventArgs) Handles TotalPayTxt.Click

    End Sub
End Class

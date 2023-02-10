Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn



Public Class PriceFuelPanel
    Dim dialog1 As DialogResult
    Private Sub loadPriceFuel()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            With sqlcommand
                .CommandText = "SELECT CONCAT('₱ ', FORMAT(price_fuel1,2)) AS price_fuel1, CONCAT('₱ ', FORMAT(price_fuel2,2)) AS price_fuel2, CONCAT('₱ ', FORMAT(price_fuel3,2)) AS price_fuel3 FROM fuelprice"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                priceTable.DataSource = dataTables
                priceTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub


    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If updatePriceFuel1.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf updatePriceFuel2.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf updatePriceFuel3.Text = String.Empty Then
            dialog1 = MessageBox.Show("Fill up the blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ''change Price 
            Using sqlcommand As New MySqlCommand()
                With sqlcommand
                    .CommandText = "UPDATE fuelprice SET price_fuel1 = @regular, price_fuel2 = @premium, price_fuel3 = @diesel WHERE id = 1"
                    .Parameters.AddWithValue("@regular", updatePriceFuel1.Text.Trim)
                    .Parameters.AddWithValue("@premium", updatePriceFuel2.Text.Trim)
                    .Parameters.AddWithValue("@diesel", updatePriceFuel3.Text.Trim)
                    .Connection = SQLString

                End With
                Try
                    ConnectSQL()
                    sqlcommand.ExecuteNonQuery()
                    MainPanel.inventoryButton_Click(sender, e)
                Catch ex As Exception
                    dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using


            updatePriceFuel1.Text = ""
            updatePriceFuel2.Text = ""
            updatePriceFuel3.Text = ""
            dialog1 = MessageBox.Show("Price Regular, Premium and Diesel is Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub updatePriceFuel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles updatePriceFuel1.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub updatePriceFuel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles updatePriceFuel2.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub updatePriceFuel3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles updatePriceFuel3.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub PriceFuelPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPriceFuel()
    End Sub


End Class

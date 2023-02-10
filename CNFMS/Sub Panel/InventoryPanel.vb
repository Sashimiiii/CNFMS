Imports MySql.Data.MySqlClient
Imports CNFMS.SQLConn



Public Class InventoryPanel
    Dim dialog1 As DialogResult

    Dim selectedID As Integer
    Dim selectedRegular As String
    Dim selectedPremium As String
    Dim selectedDiesel As String


    Dim totalliters1 As Decimal
    Dim totalliters2 As Decimal
    Dim totalliters3 As Decimal
    Private Sub showFuelInfo()
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "SELECT * FROM fuelprice"
                .Connection = SQLString
            End With
            Try
                Dim showTxt1 As String = ""
                Dim showTxt2 As String = ""
                Dim showTxt3 As String = ""
                ConnectSQL()
                Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                    If dataReader.Read Then
                        showTxt1 = dataReader.GetString(4)
                        TotalLiters_RegularTxt.Text = dataReader.GetString(7)
                        showTxt2 = dataReader.GetString(5)
                        showPremiumTxt.Text = dataReader.GetString(8)
                        showTxt3 = dataReader.GetString(6)
                        showTotalTxt.Text = dataReader.GetString(9)

                        totalliters1 = dataReader.GetString(7)
                        totalliters2 = dataReader.GetString(8)
                        totalliters3 = dataReader.GetString(9)
                    End If
                End Using
                priceTxt1.Text = "₱  " + showTxt1
                priceTxt2.Text = "₱  " + showTxt2
                priceTxt3.Text = "₱  " + showTxt3
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub loadInventory()
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTables As New DataTable
            Dim datefrom = DateTimePickerFrom.Value.ToString("yyyy-MM-dd")
            With sqlcommand
                .CommandText = "SELECT Id, Date_added, Regular, Premium, Diesel, CONCAT('₱ ', FORMAT(Price_Regular,2)) AS Price_Regular, CONCAT('₱ ', FORMAT(Price_Premium,2)) AS Price_Premium, CONCAT('₱ ', FORMAT(Price_Diesel,2)) AS Price_Diesel FROM inventoryfuel WHERE DATE(Date_added) = @dateto"
                .Parameters.AddWithValue("@dateto", datefrom)
                '.CommandText = "SELECT inventoryfuel.Id, inventoryfuel.Date_added, inventoryfuel.Regular, inventoryfuel.Premium, inventoryfuel.Diesel, showFuel.price_Fuel, showFuel1.price_Fuel, showFuel2.price_Fuel FROM inventoryfuel JOIN fuelprice AS showFuel ON showFuel.id = inventoryfuel.Price_Regular JOIN fuelprice AS showFuel1 ON showFuel1.id = inventoryfuel.Price_Premium JOIN fuelprice AS showFuel2 ON showFuel2.id = inventoryfuel.Price_Diesel"
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTables.Clear()
                dataAdapter.Fill(dataTables)
                inventory_table.DataSource = dataTables
            Catch ex As Exception
                dialog1 = MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Using
    End Sub




    Private Sub InventoryPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerFrom.Value = DateTime.Now
        DateTimePickerFrom.MinDate = DateTime.Today.Date
        DateTimePickerFrom.MaxDate = DateTime.Today.Date
        loadInventory()
        showFuelInfo()
      
    End Sub
    Private Sub addFuelButton_Click_1(sender As Object, e As EventArgs) Handles addFuelButton.Click
        AddFuel.Show()
    End Sub



    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click

        Dim ShowIsland3 As New PriceFuelPanel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowIsland3.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowIsland3)
    End Sub

    Private Sub inventory_table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles inventory_table.CellContentClick
        Try
            Dim selecteddata As DataGridViewRow = inventory_table.Rows(e.RowIndex)
            If inventory_table.Columns(e.ColumnIndex).Name = "deduction" Then

                selectedID = selecteddata.Cells(1).Value.ToString()
                selectedRegular = selecteddata.Cells(3).Value.ToString()
                selectedPremium = selecteddata.Cells(4).Value.ToString()
                selectedDiesel = selecteddata.Cells(5).Value.ToString()

                If selectedRegular > totalliters1 Then
                    dialog1 = MessageBox.Show("Inventory of Regular is Critical!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf selectedPremium > totalliters2 Then
                    dialog1 = MessageBox.Show("Inventory of Premium is Critical!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf selectedDiesel > totalliters3 Then
                    dialog1 = MessageBox.Show("Inventory of Diesel is Critical!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dialog1 = MessageBox.Show("Regular, Premium and Diesel Quantity will be deducted?" & vbCrLf & "Do you want to continue?",
                                                     "Cancel?",
                                                     MessageBoxButtons.OKCancel,
                                                     MessageBoxIcon.Information)
                    If dialog1 = DialogResult.OK Then
                        Using sqlcommand1 As New MySqlCommand()
                            Dim DeducQuantiyRegular As Decimal
                            Dim DeducQuantiyPremium As Decimal
                            Dim DeducQuantiyDiesel As Decimal
                            'deduction  Operation
                            DeducQuantiyRegular = TotalLiters_RegularTxt.Text - selectedRegular
                            DeducQuantiyPremium = showPremiumTxt.Text - selectedPremium
                            DeducQuantiyDiesel = showTotalTxt.Text - selectedDiesel

                            With sqlcommand1
                                .CommandText = "UPDATE fuelprice SET TotalQuantity1 = @regular, TotalQuantity2 = @premium, TotalQuantity3 = @diesel WHERE id = 1"
                                .Parameters.AddWithValue("@regular", DeducQuantiyRegular)
                                .Parameters.AddWithValue("@premium", DeducQuantiyPremium)
                                .Parameters.AddWithValue("@diesel", DeducQuantiyDiesel)
                                .Connection = SQLString

                            End With
                            Try
                                ConnectSQL()
                                sqlcommand1.ExecuteNonQuery()
                            Catch ex As Exception
                                dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End Using

                        Using sqlcommandDelete As New MySqlCommand()
                            With sqlcommandDelete
                                .CommandText = "DELETE FROM `inventoryfuel` WHERE Id = @delID"
                                .Parameters.AddWithValue("@delID", selectedID)
                                .Connection = SQLString
                                Try
                                    sqlcommandDelete.ExecuteNonQuery()
                                Catch ex As Exception
                                    dialog1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            End With
                        End Using
                        MainPanel.inventoryButton_Click(sender, e)
                        dialog1 = MessageBox.Show("Deleted! SuccessFully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

End Class

Public Class CashSalesPanel

    Private Sub ShadowPanel1_MouseHover(sender As Object, e As EventArgs) Handles ShadowPanel1.MouseHover
        ShadowPanel1.ShadowShift = 10
    End Sub

    Private Sub ShadowPanel1_MouseLeave(sender As Object, e As EventArgs) Handles ShadowPanel1.MouseLeave
        ShadowPanel1.ShadowShift = 5
    End Sub

    Private Sub ShadowPanel1_MouseClick(sender As Object, e As MouseEventArgs) Handles ShadowPanel1.MouseClick
        ShadowPanel1.ShadowShift = 10
        Dim ShowIsland1 As New Island1CashSalePanel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowIsland1.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowIsland1)
    End Sub

    Private Sub ShadowPanel2_MouseHover(sender As Object, e As EventArgs) Handles ShadowPanel2.MouseHover
        ShadowPanel2.ShadowShift = 10
    End Sub

    Private Sub ShadowPanel2_MouseLeave(sender As Object, e As EventArgs) Handles ShadowPanel2.MouseLeave
        ShadowPanel2.ShadowShift = 5
    End Sub

    Private Sub ShadowPanel2_MouseClick(sender As Object, e As MouseEventArgs) Handles ShadowPanel2.MouseClick
        ShadowPanel2.ShadowShift = 10
        Dim ShowIsland2 As New Island2CashSalePanel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowIsland2.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowIsland2)
    End Sub

    Private Sub ShadowPanel3_MouseHover(sender As Object, e As EventArgs) Handles ShadowPanel3.MouseHover
        ShadowPanel3.ShadowShift = 10
    End Sub

    Private Sub ShadowPanel3_MouseLeave(sender As Object, e As EventArgs) Handles ShadowPanel3.MouseLeave
        ShadowPanel3.ShadowShift = 5
    End Sub

    Private Sub ShadowPanel3_MouseClick(sender As Object, e As MouseEventArgs) Handles ShadowPanel3.MouseClick
        ShadowPanel3.ShadowShift = 10
        Dim ShowIsland3 As New Island3CashSalePanel
        MainPanel.FillPanel.Size = MainPanel.FillPanel.MaximumSize
        ShowIsland3.Dock = DockStyle.Fill
        MainPanel.FillPanel.Controls.Clear()
        MainPanel.FillPanel.Controls.Add(ShowIsland3)
    End Sub

End Class

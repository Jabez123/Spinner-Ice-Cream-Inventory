Public Class Main
    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        inventoryPanel.Visible = True
        branchPanel.Visible = False
    End Sub

    Private Sub BranchButton_Click(sender As Object, e As EventArgs) Handles branchButton.Click
        inventoryPanel.Visible = False
        branchPanel.Visible = True
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Application.Exit()
    End Sub
End Class

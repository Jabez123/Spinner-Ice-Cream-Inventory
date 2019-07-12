Imports System.Data.SqlClient

Public Class Main

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim inventoryId As Integer
    Dim branchId As Integer

    Private Sub Connection()
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Jabez\source\repos\Spinner Ice Cream Inventory\Spinner_Inventory_Db.mdf';Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()


    End Sub

    Private Sub DisplayData(table As String)
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from " & table & ";"
        cmd.ExecuteNonQuery()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        If table = "inventory" Then
            inventoryDataGridView.DataSource = dt
        ElseIf table = "branch" Then
            branchDataGridView.DataSource = dt
        End If

    End Sub

    Private Sub LoadInDropDown()

        Dim dr As SqlDataReader
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from branch"
        dr = cmd.ExecuteReader()

        While dr.Read
            branchDropDown.RemoveItem(dr("name").ToString())
            branchDropDown.AddItem(dr("name").ToString())
        End While

        dr.Close()
    End Sub

    Private Sub AddData(table As String, branchId As Integer)

        If table = "inventory" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO " & table & "
            (branch_id, description, unit, inventory_beginning, quantity, 
            price, transfer_in, transfer_out, wastage, inventory_ending, 
            usage, remarks) values(
            '" & branchId.ToString() & "', '" & descriptionTextBox.Text & "', 
            '" & unitTextBox.Text & "', '" & inventoryBeginningTextBox.Text & "',
            '" & quantityTextBox.Text & "', '" & priceTextBox.Text & "',
            '" & transferInTextBox.Text & "', '" & transferOutTextBox.Text & "',
            '" & wastageTextBox.Text & "', '" & inventoryEndingTextBox.Text & "',
            '" & remarksTextBox.Text & "')"

            cmd.ExecuteNonQuery()

            DisplayData("inventory")
            ClearValues("inventory")
        ElseIf table = "branch" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO " & table & " (name) values('" & nameTextBox.Text & "')"

            cmd.ExecuteNonQuery()

            DisplayData("branch")
            LoadInDropDown()
            ClearValues("branch")
        End If

        MessageBox.Show("Added Successfully")

    End Sub

    Private Sub ClearValues(panel As String)
        If panel = "inventory" Then
            descriptionTextBox.Text = ""
            unitTextBox.Text = ""
            branchDropDown.selectedIndex = 0
            inventoryBeginningTextBox.Text = ""
            quantityTextBox.Text = ""
            priceTextBox.Text = ""
            transferInTextBox.Text = ""
            transferOutTextBox.Text = ""
            wastageTextBox.Text = ""
            inventoryEndingTextBox.Text = ""
            usageTextBox.Text = ""
            remarksTextBox.Text = ""
        ElseIf panel = "branch" Then
            nameTextBox.Text = ""
        End If
    End Sub

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

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spinner_Inventory_DbDataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Spinner_Inventory_DbDataSet.inventory)
        Connection()
        DisplayData("inventory")
        DisplayData("branch")
        LoadInDropDown()
    End Sub

    Private Sub AddBranchButton_Click(sender As Object, e As EventArgs) Handles addBranchButton.Click
        AddData("branch", branchId)
    End Sub

    Private Sub BranchDropDown_onItemSelected(sender As Object, e As EventArgs) Handles branchDropDown.onItemSelected
        branchId = branchDropDown.selectedIndex
    End Sub
End Class

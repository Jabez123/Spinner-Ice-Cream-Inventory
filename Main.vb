Imports System.Data.SqlClient

Public Class Main

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim selectedInventoryId As Integer
    Dim branchId As Integer
    Dim selectedBranchId As Integer
    Dim selectedBranch As String
    Dim todaysDate As String
    Dim totalInventory As Integer
    Dim totalPrice As Integer

    Private Sub ClearValues(panel As String)
        If panel = "inventory" Then
            descriptionTextBox.Text = ""
            unitTextBox.Text = ""
            branchComboBox.SelectedIndex = -1
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

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        DisplayData("inventory", "branch")
        DisplayData("branch", "branch")
        LoadInComboBox()
        GetDateToday()
        CheckDateToday()
    End Sub

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.PreviousDate = todaysDate
        My.Settings.Save()
    End Sub

    Private Sub GetDateToday()
        todaysDate = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Console.WriteLine(todaysDate)
        Console.WriteLine(My.Settings.PreviousDate)
    End Sub

    Private Sub CheckDateToday()
        If todaysDate <> My.Settings.PreviousDate Then
            Console.WriteLine("Date is not match")

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE inventory 
            SET
            inventory_beginning = inventory_ending;"
            cmd.ExecuteNonQuery()

            DisplayData("inventory", "branch")
        Else
            Console.WriteLine("Date is match")
        End If
    End Sub

    Private Sub ComputeInventory(_inventoryBeginning As String, _quantity As String,
                                 _transferIn As String, _transferOut As String, _wastage As String,
                                 _inventoryEnding As String, _usage As String)
        Dim inventoryBeginning As Integer
        Dim quantity As Integer
        Dim transferIn As Integer
        Dim transferOut As Integer
        Dim wastage As Integer
        Dim inventoryEnding As Integer
        Dim usage As Integer

        Int32.TryParse(_inventoryBeginning, inventoryBeginning)
        Int32.TryParse(_quantity, quantity)
        Int32.TryParse(_transferIn, transferIn)
        Int32.TryParse(_transferOut, transferOut)
        Int32.TryParse(_wastage, wastage)
        Int32.TryParse(_inventoryEnding, inventoryEnding)
        Int32.TryParse(_usage, usage)

        inventoryEnding = inventoryBeginning - quantity + transferIn - transferOut - wastage - usage

        totalInventory = inventoryEnding

        inventoryEndingTextBox.Text = totalInventory

    End Sub

    Private Sub ComputePrice(_price As String, _quantity As String)
        Dim price As Integer
        Dim quantity As Integer

        Int32.TryParse(_price, price)
        Int32.TryParse(_quantity, quantity)

        totalPrice = price * quantity

        totalPriceTextBox.Text = totalPrice

    End Sub

#Region "On Value Change"
    Private Sub InventoryBeginningTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles inventoryBeginningTextBox.OnValueChanged
        ComputeInventory(inventoryBeginningTextBox.Text, quantityTextBox.Text,
                        transferInTextBox.Text, transferOutTextBox.Text,
                        wastageTextBox.Text, inventoryEndingTextBox.Text,
                        usageTextBox.Text)
    End Sub

    Private Sub PriceTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles priceTextBox.OnValueChanged
        ComputePrice(priceTextBox.Text, quantityTextBox.Text)
    End Sub

    Private Sub TransferOutTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles transferOutTextBox.OnValueChanged
        ComputeInventory(inventoryBeginningTextBox.Text, quantityTextBox.Text,
                        transferInTextBox.Text, transferOutTextBox.Text,
                        wastageTextBox.Text, inventoryEndingTextBox.Text,
                        usageTextBox.Text)
    End Sub

    Private Sub InventoryEndingTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles inventoryEndingTextBox.OnValueChanged
        ComputeInventory(inventoryBeginningTextBox.Text, quantityTextBox.Text,
                        transferInTextBox.Text, transferOutTextBox.Text,
                        wastageTextBox.Text, inventoryEndingTextBox.Text,
                        usageTextBox.Text)
    End Sub

    Private Sub QuantityTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles quantityTextBox.OnValueChanged
        ComputeInventory(inventoryBeginningTextBox.Text, quantityTextBox.Text,
                        transferInTextBox.Text, transferOutTextBox.Text,
                        wastageTextBox.Text, inventoryEndingTextBox.Text,
                        usageTextBox.Text)
        ComputePrice(priceTextBox.Text, quantityTextBox.Text)
    End Sub

    Private Sub TransferInTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles transferInTextBox.OnValueChanged
        ComputeInventory(inventoryBeginningTextBox.Text, quantityTextBox.Text,
                        transferInTextBox.Text, transferOutTextBox.Text,
                        wastageTextBox.Text, inventoryEndingTextBox.Text,
                        usageTextBox.Text)
    End Sub

    Private Sub WastageTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles wastageTextBox.OnValueChanged
        ComputeInventory(inventoryBeginningTextBox.Text, quantityTextBox.Text,
                        transferInTextBox.Text, transferOutTextBox.Text,
                        wastageTextBox.Text, inventoryEndingTextBox.Text,
                        usageTextBox.Text)
    End Sub

    Private Sub UsageTextBox_OnValueChanged(sender As Object, e As EventArgs) Handles usageTextBox.OnValueChanged
        ComputeInventory(inventoryBeginningTextBox.Text, quantityTextBox.Text,
                        transferInTextBox.Text, transferOutTextBox.Text,
                        wastageTextBox.Text, inventoryEndingTextBox.Text,
                        usageTextBox.Text)
    End Sub
#End Region

#Region "Database Related"

#Region "Connection"
    Private Sub Connection()
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Jabez\source\repos\Spinner Ice Cream Inventory\Spinner_Inventory_Db.mdf';Integrated Security=True"

        Connect()
    End Sub

    Private Sub Connect()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
    End Sub
#End Region

#Region "Load & Display Data"
    Private Sub LoadInComboBox()
        Dim dr As SqlDataReader
        branchComboBox.Items.Clear()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from branch"
        dr = cmd.ExecuteReader()

        While dr.Read
            branchComboBox.Items.Add(dr("branch_name"))
        End While

        dr.Close()
    End Sub

    Private Sub DisplayData(table As String, join As String)
        If table = "inventory" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select inventory.id as 'ID', branch.branch_name AS 'Branch Name',
                                inventory.description AS 'Description', inventory.unit AS 'Unit', 
                                inventory.inventory_beginning AS 'Inventory Beginning', 
                                inventory.quantity AS 'Qty', price as 'Price', 
                                inventory.transfer_in as 'Transfer In', 
                                inventory.transfer_out as 'Transfer Out',
                                inventory.wastage as 'Wastage', 
                                inventory.inventory_ending as 'Inventory Ending', 
                                inventory.usage as 'Usage', 
                                inventory.remarks as 'Remarks' 
                                from " & table & "
                                inner join " & join & " 
                                on inventory.branch_id = branch.id;"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            inventoryDataGridView.DataSource = dt
            inventoryDataGridView.Columns(0).Visible = False
        End If

        If table = "branch" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select id as 'ID', branch_name as 'Branch Name' from " & table & ";"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            branchDataGridView.DataSource = dt
            branchDataGridView.Columns(0).Visible = False
        End If

    End Sub

#End Region

#Region "Add Data"
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
            '" & usageTextBox.Text & "', '" & remarksTextBox.Text & "')"

            cmd.ExecuteNonQuery()

            DisplayData("inventory", "branch")
            ClearValues("inventory")
        ElseIf table = "branch" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO " & table & " (branch_name) values('" & nameTextBox.Text & "')"

            cmd.ExecuteNonQuery()

            DisplayData("branch", "branch")
            LoadInComboBox()
            ClearValues("branch")
        End If

        MessageBox.Show("Added Successfully")

    End Sub
#End Region

#Region "Edit Data"
    Private Sub EditData(table As String, id As Integer, branchId As Integer)
        Connect()

        If table = "inventory" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE " & table & " 
            SET branch_id ='" & branchId.ToString() & "', 
            description = '" & descriptionTextBox.Text & "',
            unit = '" & unitTextBox.Text & "',
            inventory_beginning = '" & inventoryBeginningTextBox.Text & "',
            quantity = '" & quantityTextBox.Text & "',
            price = '" & priceTextBox.Text & "',
            transfer_in = '" & transferInTextBox.Text & "',
            transfer_out = '" & transferOutTextBox.Text & "',
            wastage = '" & wastageTextBox.Text & "', 
            inventory_ending = '" & inventoryEndingTextBox.Text & "',
            usage = '" & usageTextBox.Text & "',
            remarks = '" & remarksTextBox.Text & "' WHERE id = '" & id.ToString() & "';"
            cmd.ExecuteNonQuery()

            DisplayData("inventory", "branch")
            LoadInComboBox()
            ClearValues("inventory")
        End If

        If table = "branch" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE " & table & " 
            SET branch_name='" + nameTextBox.Text + "' WHERE id = " & id.ToString() & ""
            cmd.ExecuteNonQuery()

            DisplayData("branch", "branch")
            LoadInComboBox()
            ClearValues("branch")
        End If
    End Sub
#End Region

#Region "Delete Data"
    Private Sub DeleteData(table As String, id As Integer)
        Connect()

        If table = "inventory" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM " & table & " WHERE id = " & id & ""
            cmd.ExecuteNonQuery()

            DisplayData("inventory", "branch")
            LoadInComboBox()
            ClearValues("inventory")
        End If

        If table = "branch" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM " & table & " WHERE id = " & id & ""
            cmd.ExecuteNonQuery()

            DisplayData("branch", "branch")
            LoadInComboBox()
            ClearValues("branch")
        End If
    End Sub
#End Region


#Region "Search Data"
    Private Sub SearchData(table As String, searchTextBox As String, join As String)
        If table = "inventory" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select inventory.id as 'ID', branch.branch_name AS 'Branch Name',
                                inventory.description AS 'Description', inventory.unit AS 'Unit', 
                                inventory.inventory_beginning AS 'Inventory Beginning', 
                                inventory.quantity AS 'Qty', price as 'Price', 
                                inventory.transfer_in as 'Transfer In', 
                                inventory.transfer_out as 'Transfer Out',
                                inventory.wastage as 'Wastage', 
                                inventory.inventory_ending as 'Inventory Ending', 
                                inventory.usage as 'Usage', 
                                inventory.remarks as 'Remarks' 
                                from " & table & "
                                inner Join " & join & " 
                                On inventory.branch_id = branch.id where inventory.description LIKE '%" & searchTextBox & "%' OR
                                branch.branch_name LIKE '%" & searchTextBox & "%';"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            inventoryDataGridView.DataSource = dt
        End If

        If table = "branch" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select branch_name as 'Branch Name' from " & table & " where branch_name LIKE '%" & searchTextBox & "%';"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            branchDataGridView.DataSource = dt
        End If
    End Sub
#End Region
#End Region

#Region "ComboBox"

    Private Sub SelectBranch(selectedBranch As String)
        Connect()
        Dim dr As SqlDataReader
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from branch where branch_name = '" & selectedBranch & "'"
        dr = cmd.ExecuteReader()

        While dr.Read
            branchId = Convert.ToInt32(dr("id").ToString())
        End While

        dr.Close()

        Console.WriteLine("Selected id " & branchId)
        branchComboBox.SelectedText = selectedBranch
    End Sub

    Private Sub SelectBranch(selectedIntBranch As Integer)
        Connect()
        Dim dr As SqlDataReader
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from branch where id = '" & selectedIntBranch & "'"
        dr = cmd.ExecuteReader()

        While dr.Read
            selectedBranch = dr("branch_name").ToString()
        End While

        dr.Close()

        Console.WriteLine("Selected branch " & selectedBranch)
        branchComboBox.SelectedItem = selectedBranch
    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles branchComboBox.SelectedIndexChanged
        selectedBranch = branchComboBox.SelectedItem

        SelectBranch(selectedBranch)
    End Sub

#End Region

#Region "DataGridView"
    Private Sub InventoryDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles inventoryDataGridView.CellDoubleClick
        Try
            Connect()

            selectedInventoryId = Convert.ToInt32(inventoryDataGridView.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM inventory WHERE id = " & selectedInventoryId.ToString() & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                branchId = dr.GetInt32(1).ToString()
                descriptionTextBox.Text = dr.GetString(2).ToString()
                unitTextBox.Text = dr.GetString(3).ToString()
                inventoryBeginningTextBox.Text = dr.GetInt32(4).ToString()
                quantityTextBox.Text = dr.GetInt32(5).ToString()
                priceTextBox.Text = dr.GetDouble(6).ToString()
                transferInTextBox.Text = dr.GetInt32(7).ToString()
                transferOutTextBox.Text = dr.GetInt32(8).ToString()
                wastageTextBox.Text = dr.GetInt32(9).ToString()
                inventoryEndingTextBox.Text = dr.GetInt32(10).ToString()
                usageTextBox.Text = dr.GetInt32(11).ToString()
                remarksTextBox.Text = dr.GetString(12).ToString()

            End While
            con.Close()
            SelectBranch(branchId)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub BranchDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles branchDataGridView.CellDoubleClick
        Try
            Connect()

            selectedBranchId = Convert.ToInt32(branchDataGridView.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM branch WHERE id= " & selectedBranchId.ToString() & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                nameTextBox.Text = dr.GetString(1).ToString()

            End While
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Buttons"

#Region "Search"
    Private Sub InventorySearchButton_Click(sender As Object, e As EventArgs) Handles inventorySearchButton.Click
        SearchData("inventory", inventorySearchTextBox.Text, "branch")
    End Sub

    Private Sub BranchSearchButton_Click(sender As Object, e As EventArgs) Handles branchSearchButton.Click
        SearchData("branch", branchSearchTextBox.Text, "branch")
    End Sub
#End Region

#Region "Delete"
    Private Sub DeleteInventoryButton_Click(sender As Object, e As EventArgs) Handles deleteInventoryButton.Click
        If selectedInventoryId > 0 Then
            DeleteData("inventory", selectedInventoryId)
        Else
            MessageBox.Show("Please select a row first.")
        End If
    End Sub

    Private Sub DeleteBranchTextBox_Click(sender As Object, e As EventArgs) Handles DeleteBranchTextBox.Click
        If selectedInventoryId > 0 Then
            DeleteData("branch", selectedBranchId)
        Else
            MessageBox.Show("Please select a row first.")
        End If
    End Sub
#End Region

#Region "Edit"
    Private Sub EditInventoryButton_Click(sender As Object, e As EventArgs) Handles editInventoryButton.Click
        If selectedInventoryId > 0 Then
            EditData("inventory", selectedInventoryId, branchId)
        Else
            MessageBox.Show("Please select a row first.")
        End If
    End Sub

    Private Sub EditBranchTextBox_Click(sender As Object, e As EventArgs) Handles EditBranchTextBox.Click
        If selectedBranchId > 0 Then
            EditData("branch", selectedBranchId, branchId)
        Else
            MessageBox.Show("Please select a row first.")
        End If
    End Sub
#End Region

#Region "Add"
    Private Sub AddInventoryButton_Click(sender As Object, e As EventArgs) Handles addInventoryButton.Click
        If descriptionTextBox.Text <> "" And unitTextBox.Text <> "" And branchComboBox.SelectedIndex = -1 And inventoryBeginningTextBox.Text <> "" And
           quantityTextBox.Text <> "" And priceTextBox.Text <> "" And transferInTextBox.Text <> "" And
           transferOutTextBox.Text <> "" And wastageTextBox.Text <> "" And usageTextBox.Text <> "" Then
            AddData("branch", branchId)
        Else
            MessageBox.Show("Enter a value first.")
        End If
    End Sub

    Private Sub AddBranchButton_Click(sender As Object, e As EventArgs) Handles addBranchButton.Click

        If nameTextBox.Text <> "" Then
            AddData("branch", branchId)
        Else
            MessageBox.Show("Enter a value first.")
        End If
    End Sub
#End Region

#Region "Close"
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Application.Exit()
    End Sub
#End Region

#Region "Navigation"
    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        inventoryPanel.Visible = True
        branchPanel.Visible = False
    End Sub

    Private Sub BranchButton_Click(sender As Object, e As EventArgs) Handles branchButton.Click
        inventoryPanel.Visible = False
        branchPanel.Visible = True
    End Sub

#End Region

#End Region

End Class
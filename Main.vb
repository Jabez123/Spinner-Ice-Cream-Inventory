Imports System.Data.SqlClient

Public Class Main

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim selectedInventoryId As Integer
    Dim branchId As Integer
    Dim selectedBranchId As Integer

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

    Private Sub LoadInComboBox()
        Dim dr As SqlDataReader
        branchComboBox.Items.Clear()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from branch"
        dr = cmd.ExecuteReader()

        While dr.Read
            branchComboBox.Items.Add(dr("name"))
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
            LoadInComboBox()
            ClearValues("branch")
        End If

        MessageBox.Show("Added Successfully")

    End Sub

    Private Sub EditData(table As String, id As Integer)
        Connect()

        If table = "inventory" Then

        End If

        If table = "branch" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE " & table & " 
            SET name='" + nameTextBox.Text + "' WHERE id = " & id.ToString() & ""
            cmd.ExecuteNonQuery()

            DisplayData("branch")
            LoadInComboBox()
            ClearValues("branch")
        End If
    End Sub

    Private Sub DeleteData(table As String, id As Integer)
        Connect()

        If table = "inventory" Then

        End If

        If table = "branch" Then
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM " & table & " WHERE id = " & id & ""
            cmd.ExecuteNonQuery()

            DisplayData("branch")
            LoadInComboBox()
            ClearValues("branch")
        End If
    End Sub


    Private Sub ClearValues(panel As String)
        If panel = "inventory" Then
            descriptionTextBox.Text = ""
            unitTextBox.Text = ""
            branchComboBox.SelectedIndex = 0
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
        Connection()
        DisplayData("inventory")
        DisplayData("branch")
        LoadInComboBox()
    End Sub

    Private Sub AddBranchButton_Click(sender As Object, e As EventArgs) Handles addBranchButton.Click
        AddData("branch", branchId)
    End Sub

    Private Sub BranchDropDown_onItemSelected(sender As Object, e As EventArgs)
        branchId = branchComboBox.SelectedIndex
    End Sub

    Private Sub EditBranchTextBox_Click(sender As Object, e As EventArgs) Handles EditBranchTextBox.Click
        If selectedBranchId > 0 Then
            EditData("branch", selectedBranchId)
        End If
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

    Private Sub DeleteBranchTextBox_Click(sender As Object, e As EventArgs) Handles DeleteBranchTextBox.Click
        DeleteData("branch", selectedBranchId)
    End Sub
End Class

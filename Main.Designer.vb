﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.inventoryButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.branchButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navigationPanel = New System.Windows.Forms.Panel()
        Me.closeButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.branchPanel = New System.Windows.Forms.Panel()
        Me.branchSearchButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.branchSearchTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DeleteBranchTextBox = New Bunifu.Framework.UI.BunifuTileButton()
        Me.EditBranchTextBox = New Bunifu.Framework.UI.BunifuTileButton()
        Me.addBranchButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.branchDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Spinner_Inventory_DbDataSet = New Spinner_Ice_Cream_Inventory.Spinner_Inventory_DbDataSet()
        Me.nameTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.branchLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.inventoryPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.branchComboBox = New System.Windows.Forms.ComboBox()
        Me.inventorySearchTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.inventoryDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.remarksTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.unitTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.deleteInventoryButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.editInventoryButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.usageTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.addInventoryButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.inventoryEndingTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.wastageTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.transferOutTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.transferInTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.priceTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.quantityTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.inventoryBeginningTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.descriptionTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.inventoryLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BranchTableAdapter = New Spinner_Ice_Cream_Inventory.Spinner_Inventory_DbDataSetTableAdapters.branchTableAdapter()
        Me.InventoryTableAdapter = New Spinner_Ice_Cream_Inventory.Spinner_Inventory_DbDataSetTableAdapters.inventoryTableAdapter()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.navigationPanel.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        Me.branchPanel.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.branchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spinner_Inventory_DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inventoryPanel.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.inventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inventoryButton
        '
        Me.inventoryButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.inventoryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.inventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inventoryButton.BorderRadius = 0
        Me.inventoryButton.ButtonText = "Inventory"
        Me.inventoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inventoryButton.DisabledColor = System.Drawing.Color.Gray
        Me.inventoryButton.Iconcolor = System.Drawing.Color.Transparent
        Me.inventoryButton.Iconimage = CType(resources.GetObject("inventoryButton.Iconimage"), System.Drawing.Image)
        Me.inventoryButton.Iconimage_right = Nothing
        Me.inventoryButton.Iconimage_right_Selected = Nothing
        Me.inventoryButton.Iconimage_Selected = Nothing
        Me.inventoryButton.IconMarginLeft = 0
        Me.inventoryButton.IconMarginRight = 0
        Me.inventoryButton.IconRightVisible = True
        Me.inventoryButton.IconRightZoom = 0R
        Me.inventoryButton.IconVisible = True
        Me.inventoryButton.IconZoom = 90.0R
        Me.inventoryButton.IsTab = False
        Me.inventoryButton.Location = New System.Drawing.Point(12, 108)
        Me.inventoryButton.Name = "inventoryButton"
        Me.inventoryButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.inventoryButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.inventoryButton.OnHoverTextColor = System.Drawing.Color.White
        Me.inventoryButton.selected = False
        Me.inventoryButton.Size = New System.Drawing.Size(206, 48)
        Me.inventoryButton.TabIndex = 3
        Me.inventoryButton.Text = "Inventory"
        Me.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inventoryButton.Textcolor = System.Drawing.Color.White
        Me.inventoryButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'branchButton
        '
        Me.branchButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.branchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.branchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.branchButton.BorderRadius = 0
        Me.branchButton.ButtonText = "Branch"
        Me.branchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.branchButton.DisabledColor = System.Drawing.Color.Gray
        Me.branchButton.Iconcolor = System.Drawing.Color.Transparent
        Me.branchButton.Iconimage = CType(resources.GetObject("branchButton.Iconimage"), System.Drawing.Image)
        Me.branchButton.Iconimage_right = Nothing
        Me.branchButton.Iconimage_right_Selected = Nothing
        Me.branchButton.Iconimage_Selected = Nothing
        Me.branchButton.IconMarginLeft = 0
        Me.branchButton.IconMarginRight = 0
        Me.branchButton.IconRightVisible = True
        Me.branchButton.IconRightZoom = 0R
        Me.branchButton.IconVisible = True
        Me.branchButton.IconZoom = 90.0R
        Me.branchButton.IsTab = False
        Me.branchButton.Location = New System.Drawing.Point(12, 162)
        Me.branchButton.Name = "branchButton"
        Me.branchButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.branchButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.branchButton.OnHoverTextColor = System.Drawing.Color.White
        Me.branchButton.selected = False
        Me.branchButton.Size = New System.Drawing.Size(206, 48)
        Me.branchButton.TabIndex = 4
        Me.branchButton.Text = "Branch"
        Me.branchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.branchButton.Textcolor = System.Drawing.Color.White
        Me.branchButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'navigationPanel
        '
        Me.navigationPanel.Controls.Add(Me.logoPictureBox)
        Me.navigationPanel.Controls.Add(Me.closeButton)
        Me.navigationPanel.Controls.Add(Me.inventoryButton)
        Me.navigationPanel.Controls.Add(Me.branchButton)
        Me.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.navigationPanel.Location = New System.Drawing.Point(0, 0)
        Me.navigationPanel.Name = "navigationPanel"
        Me.navigationPanel.Size = New System.Drawing.Size(231, 768)
        Me.navigationPanel.TabIndex = 5
        '
        'closeButton
        '
        Me.closeButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.closeButton.BackColor = System.Drawing.Color.Red
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeButton.BorderRadius = 0
        Me.closeButton.ButtonText = "Close"
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.DisabledColor = System.Drawing.Color.Gray
        Me.closeButton.Iconcolor = System.Drawing.Color.Transparent
        Me.closeButton.Iconimage = Nothing
        Me.closeButton.Iconimage_right = Nothing
        Me.closeButton.Iconimage_right_Selected = Nothing
        Me.closeButton.Iconimage_Selected = Nothing
        Me.closeButton.IconMarginLeft = 0
        Me.closeButton.IconMarginRight = 0
        Me.closeButton.IconRightVisible = True
        Me.closeButton.IconRightZoom = 0R
        Me.closeButton.IconVisible = True
        Me.closeButton.IconZoom = 90.0R
        Me.closeButton.IsTab = False
        Me.closeButton.Location = New System.Drawing.Point(12, 708)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Normalcolor = System.Drawing.Color.Red
        Me.closeButton.OnHovercolor = System.Drawing.Color.Maroon
        Me.closeButton.OnHoverTextColor = System.Drawing.Color.White
        Me.closeButton.selected = False
        Me.closeButton.Size = New System.Drawing.Size(206, 48)
        Me.closeButton.TabIndex = 5
        Me.closeButton.Text = "Close"
        Me.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.closeButton.Textcolor = System.Drawing.Color.White
        Me.closeButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'mainPanel
        '
        Me.mainPanel.Controls.Add(Me.inventoryPanel)
        Me.mainPanel.Controls.Add(Me.branchPanel)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.mainPanel.Location = New System.Drawing.Point(230, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1136, 768)
        Me.mainPanel.TabIndex = 6
        '
        'branchPanel
        '
        Me.branchPanel.Controls.Add(Me.branchSearchButton)
        Me.branchPanel.Controls.Add(Me.branchSearchTextBox)
        Me.branchPanel.Controls.Add(Me.DeleteBranchTextBox)
        Me.branchPanel.Controls.Add(Me.EditBranchTextBox)
        Me.branchPanel.Controls.Add(Me.addBranchButton)
        Me.branchPanel.Controls.Add(Me.BunifuCards2)
        Me.branchPanel.Controls.Add(Me.nameTextBox)
        Me.branchPanel.Controls.Add(Me.branchLabel)
        Me.branchPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.branchPanel.Location = New System.Drawing.Point(0, 0)
        Me.branchPanel.Name = "branchPanel"
        Me.branchPanel.Size = New System.Drawing.Size(1136, 768)
        Me.branchPanel.TabIndex = 1
        Me.branchPanel.Visible = False
        '
        'branchSearchButton
        '
        Me.branchSearchButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.branchSearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.branchSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.branchSearchButton.BorderRadius = 0
        Me.branchSearchButton.ButtonText = "Search"
        Me.branchSearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.branchSearchButton.DisabledColor = System.Drawing.Color.Gray
        Me.branchSearchButton.Iconcolor = System.Drawing.Color.Transparent
        Me.branchSearchButton.Iconimage = CType(resources.GetObject("branchSearchButton.Iconimage"), System.Drawing.Image)
        Me.branchSearchButton.Iconimage_right = Nothing
        Me.branchSearchButton.Iconimage_right_Selected = Nothing
        Me.branchSearchButton.Iconimage_Selected = Nothing
        Me.branchSearchButton.IconMarginLeft = 0
        Me.branchSearchButton.IconMarginRight = 0
        Me.branchSearchButton.IconRightVisible = False
        Me.branchSearchButton.IconRightZoom = 0R
        Me.branchSearchButton.IconVisible = False
        Me.branchSearchButton.IconZoom = 90.0R
        Me.branchSearchButton.IsTab = False
        Me.branchSearchButton.Location = New System.Drawing.Point(989, 51)
        Me.branchSearchButton.Name = "branchSearchButton"
        Me.branchSearchButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.branchSearchButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.branchSearchButton.OnHoverTextColor = System.Drawing.Color.White
        Me.branchSearchButton.selected = False
        Me.branchSearchButton.Size = New System.Drawing.Size(135, 42)
        Me.branchSearchButton.TabIndex = 6
        Me.branchSearchButton.Text = "Search"
        Me.branchSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.branchSearchButton.Textcolor = System.Drawing.Color.White
        Me.branchSearchButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'branchSearchTextBox
        '
        Me.branchSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.branchSearchTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.branchSearchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.branchSearchTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.branchSearchTextBox.HintText = "Search"
        Me.branchSearchTextBox.isPassword = False
        Me.branchSearchTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.branchSearchTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.branchSearchTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.branchSearchTextBox.LineThickness = 3
        Me.branchSearchTextBox.Location = New System.Drawing.Point(297, 49)
        Me.branchSearchTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.branchSearchTextBox.Name = "branchSearchTextBox"
        Me.branchSearchTextBox.Size = New System.Drawing.Size(682, 44)
        Me.branchSearchTextBox.TabIndex = 42
        Me.branchSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DeleteBranchTextBox
        '
        Me.DeleteBranchTextBox.BackColor = System.Drawing.Color.SeaGreen
        Me.DeleteBranchTextBox.color = System.Drawing.Color.SeaGreen
        Me.DeleteBranchTextBox.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.DeleteBranchTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBranchTextBox.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.DeleteBranchTextBox.ForeColor = System.Drawing.Color.White
        Me.DeleteBranchTextBox.Image = CType(resources.GetObject("DeleteBranchTextBox.Image"), System.Drawing.Image)
        Me.DeleteBranchTextBox.ImagePosition = 10
        Me.DeleteBranchTextBox.ImageZoom = 40
        Me.DeleteBranchTextBox.LabelPosition = 41
        Me.DeleteBranchTextBox.LabelText = "Delete"
        Me.DeleteBranchTextBox.Location = New System.Drawing.Point(200, 103)
        Me.DeleteBranchTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.DeleteBranchTextBox.Name = "DeleteBranchTextBox"
        Me.DeleteBranchTextBox.Size = New System.Drawing.Size(85, 75)
        Me.DeleteBranchTextBox.TabIndex = 41
        '
        'EditBranchTextBox
        '
        Me.EditBranchTextBox.BackColor = System.Drawing.Color.SeaGreen
        Me.EditBranchTextBox.color = System.Drawing.Color.SeaGreen
        Me.EditBranchTextBox.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.EditBranchTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditBranchTextBox.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.EditBranchTextBox.ForeColor = System.Drawing.Color.White
        Me.EditBranchTextBox.Image = CType(resources.GetObject("EditBranchTextBox.Image"), System.Drawing.Image)
        Me.EditBranchTextBox.ImagePosition = 10
        Me.EditBranchTextBox.ImageZoom = 40
        Me.EditBranchTextBox.LabelPosition = 41
        Me.EditBranchTextBox.LabelText = "Edit"
        Me.EditBranchTextBox.Location = New System.Drawing.Point(103, 103)
        Me.EditBranchTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.EditBranchTextBox.Name = "EditBranchTextBox"
        Me.EditBranchTextBox.Size = New System.Drawing.Size(85, 75)
        Me.EditBranchTextBox.TabIndex = 40
        '
        'addBranchButton
        '
        Me.addBranchButton.BackColor = System.Drawing.Color.SeaGreen
        Me.addBranchButton.color = System.Drawing.Color.SeaGreen
        Me.addBranchButton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.addBranchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBranchButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.addBranchButton.ForeColor = System.Drawing.Color.White
        Me.addBranchButton.Image = CType(resources.GetObject("addBranchButton.Image"), System.Drawing.Image)
        Me.addBranchButton.ImagePosition = 10
        Me.addBranchButton.ImageZoom = 40
        Me.addBranchButton.LabelPosition = 41
        Me.addBranchButton.LabelText = "Add"
        Me.addBranchButton.Location = New System.Drawing.Point(6, 103)
        Me.addBranchButton.Margin = New System.Windows.Forms.Padding(6)
        Me.addBranchButton.Name = "addBranchButton"
        Me.addBranchButton.Size = New System.Drawing.Size(85, 75)
        Me.addBranchButton.TabIndex = 39
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Orange
        Me.BunifuCards2.Controls.Add(Me.branchDataGridView)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(16, 187)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(1108, 566)
        Me.BunifuCards2.TabIndex = 36
        '
        'branchDataGridView
        '
        Me.branchDataGridView.AllowUserToAddRows = False
        Me.branchDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.branchDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.branchDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.branchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.branchDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.branchDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.branchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.branchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.branchDataGridView.DoubleBuffered = True
        Me.branchDataGridView.EnableHeadersVisualStyles = False
        Me.branchDataGridView.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.branchDataGridView.HeaderForeColor = System.Drawing.Color.White
        Me.branchDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.branchDataGridView.MultiSelect = False
        Me.branchDataGridView.Name = "branchDataGridView"
        Me.branchDataGridView.ReadOnly = True
        Me.branchDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.branchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.branchDataGridView.Size = New System.Drawing.Size(1108, 566)
        Me.branchDataGridView.TabIndex = 1
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "branch"
        Me.BranchBindingSource.DataSource = Me.Spinner_Inventory_DbDataSet
        '
        'Spinner_Inventory_DbDataSet
        '
        Me.Spinner_Inventory_DbDataSet.DataSetName = "Spinner_Inventory_DbDataSet"
        Me.Spinner_Inventory_DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nameTextBox
        '
        Me.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nameTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.nameTextBox.HintText = "Name"
        Me.nameTextBox.isPassword = False
        Me.nameTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.nameTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.nameTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.nameTextBox.LineThickness = 3
        Me.nameTextBox.Location = New System.Drawing.Point(6, 49)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(279, 44)
        Me.nameTextBox.TabIndex = 25
        Me.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'branchLabel
        '
        Me.branchLabel.AutoSize = True
        Me.branchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branchLabel.Location = New System.Drawing.Point(7, 12)
        Me.branchLabel.Name = "branchLabel"
        Me.branchLabel.Size = New System.Drawing.Size(100, 31)
        Me.branchLabel.TabIndex = 0
        Me.branchLabel.Text = "Branch"
        '
        'inventoryPanel
        '
        Me.inventoryPanel.Controls.Add(Me.Label1)
        Me.inventoryPanel.Controls.Add(Me.branchComboBox)
        Me.inventoryPanel.Controls.Add(Me.inventorySearchTextBox)
        Me.inventoryPanel.Controls.Add(Me.BunifuCards1)
        Me.inventoryPanel.Controls.Add(Me.remarksTextBox)
        Me.inventoryPanel.Controls.Add(Me.unitTextBox)
        Me.inventoryPanel.Controls.Add(Me.deleteInventoryButton)
        Me.inventoryPanel.Controls.Add(Me.editInventoryButton)
        Me.inventoryPanel.Controls.Add(Me.usageTextBox)
        Me.inventoryPanel.Controls.Add(Me.addInventoryButton)
        Me.inventoryPanel.Controls.Add(Me.inventoryEndingTextBox)
        Me.inventoryPanel.Controls.Add(Me.wastageTextBox)
        Me.inventoryPanel.Controls.Add(Me.transferOutTextBox)
        Me.inventoryPanel.Controls.Add(Me.transferInTextBox)
        Me.inventoryPanel.Controls.Add(Me.priceTextBox)
        Me.inventoryPanel.Controls.Add(Me.quantityTextBox)
        Me.inventoryPanel.Controls.Add(Me.inventoryBeginningTextBox)
        Me.inventoryPanel.Controls.Add(Me.descriptionTextBox)
        Me.inventoryPanel.Controls.Add(Me.inventoryLabel)
        Me.inventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventoryPanel.Location = New System.Drawing.Point(0, 0)
        Me.inventoryPanel.Name = "inventoryPanel"
        Me.inventoryPanel.Size = New System.Drawing.Size(1136, 768)
        Me.inventoryPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Select branch"
        '
        'branchComboBox
        '
        Me.branchComboBox.BackColor = System.Drawing.Color.SeaGreen
        Me.branchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.branchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.branchComboBox.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branchComboBox.ForeColor = System.Drawing.Color.White
        Me.branchComboBox.FormattingEnabled = True
        Me.branchComboBox.Location = New System.Drawing.Point(58, 177)
        Me.branchComboBox.Name = "branchComboBox"
        Me.branchComboBox.Size = New System.Drawing.Size(231, 31)
        Me.branchComboBox.TabIndex = 42
        '
        'inventorySearchTextBox
        '
        Me.inventorySearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inventorySearchTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.inventorySearchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inventorySearchTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.inventorySearchTextBox.HintText = "Search"
        Me.inventorySearchTextBox.isPassword = False
        Me.inventorySearchTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.inventorySearchTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.inventorySearchTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.inventorySearchTextBox.LineThickness = 3
        Me.inventorySearchTextBox.Location = New System.Drawing.Point(13, 232)
        Me.inventorySearchTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.inventorySearchTextBox.Name = "inventorySearchTextBox"
        Me.inventorySearchTextBox.Size = New System.Drawing.Size(777, 44)
        Me.inventorySearchTextBox.TabIndex = 41
        Me.inventorySearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Orange
        Me.BunifuCards1.Controls.Add(Me.inventoryDataGridView)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(13, 298)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(1111, 458)
        Me.BunifuCards1.TabIndex = 35
        '
        'inventoryDataGridView
        '
        Me.inventoryDataGridView.AllowUserToAddRows = False
        Me.inventoryDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.inventoryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.inventoryDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.inventoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inventoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inventoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventoryDataGridView.DoubleBuffered = True
        Me.inventoryDataGridView.EnableHeadersVisualStyles = False
        Me.inventoryDataGridView.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.inventoryDataGridView.HeaderForeColor = System.Drawing.Color.White
        Me.inventoryDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.inventoryDataGridView.Name = "inventoryDataGridView"
        Me.inventoryDataGridView.ReadOnly = True
        Me.inventoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventoryDataGridView.Size = New System.Drawing.Size(1111, 458)
        Me.inventoryDataGridView.TabIndex = 1
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "inventory"
        Me.InventoryBindingSource.DataSource = Me.Spinner_Inventory_DbDataSet
        '
        'remarksTextBox
        '
        Me.remarksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.remarksTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.remarksTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.remarksTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.remarksTextBox.HintText = "Remarks"
        Me.remarksTextBox.isPassword = False
        Me.remarksTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.remarksTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.remarksTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.remarksTextBox.LineThickness = 3
        Me.remarksTextBox.Location = New System.Drawing.Point(297, 164)
        Me.remarksTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.remarksTextBox.Name = "remarksTextBox"
        Me.remarksTextBox.Size = New System.Drawing.Size(776, 44)
        Me.remarksTextBox.TabIndex = 34
        Me.remarksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'unitTextBox
        '
        Me.unitTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.unitTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.unitTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.unitTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.unitTextBox.HintText = "Unit"
        Me.unitTextBox.isPassword = False
        Me.unitTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.unitTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.unitTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.unitTextBox.LineThickness = 3
        Me.unitTextBox.Location = New System.Drawing.Point(58, 103)
        Me.unitTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.unitTextBox.Name = "unitTextBox"
        Me.unitTextBox.Size = New System.Drawing.Size(231, 44)
        Me.unitTextBox.TabIndex = 33
        Me.unitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'deleteInventoryButton
        '
        Me.deleteInventoryButton.BackColor = System.Drawing.Color.SeaGreen
        Me.deleteInventoryButton.color = System.Drawing.Color.SeaGreen
        Me.deleteInventoryButton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.deleteInventoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteInventoryButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.deleteInventoryButton.ForeColor = System.Drawing.Color.White
        Me.deleteInventoryButton.Image = CType(resources.GetObject("deleteInventoryButton.Image"), System.Drawing.Image)
        Me.deleteInventoryButton.ImagePosition = 5
        Me.deleteInventoryButton.ImageZoom = 40
        Me.deleteInventoryButton.LabelPosition = 41
        Me.deleteInventoryButton.LabelText = "Delete"
        Me.deleteInventoryButton.Location = New System.Drawing.Point(989, 217)
        Me.deleteInventoryButton.Margin = New System.Windows.Forms.Padding(5)
        Me.deleteInventoryButton.Name = "deleteInventoryButton"
        Me.deleteInventoryButton.Size = New System.Drawing.Size(84, 72)
        Me.deleteInventoryButton.TabIndex = 38
        '
        'editInventoryButton
        '
        Me.editInventoryButton.BackColor = System.Drawing.Color.SeaGreen
        Me.editInventoryButton.color = System.Drawing.Color.SeaGreen
        Me.editInventoryButton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.editInventoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editInventoryButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.editInventoryButton.ForeColor = System.Drawing.Color.White
        Me.editInventoryButton.Image = CType(resources.GetObject("editInventoryButton.Image"), System.Drawing.Image)
        Me.editInventoryButton.ImagePosition = 5
        Me.editInventoryButton.ImageZoom = 40
        Me.editInventoryButton.LabelPosition = 41
        Me.editInventoryButton.LabelText = "Edit"
        Me.editInventoryButton.Location = New System.Drawing.Point(895, 217)
        Me.editInventoryButton.Margin = New System.Windows.Forms.Padding(5)
        Me.editInventoryButton.Name = "editInventoryButton"
        Me.editInventoryButton.Size = New System.Drawing.Size(84, 72)
        Me.editInventoryButton.TabIndex = 37
        '
        'usageTextBox
        '
        Me.usageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usageTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.usageTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usageTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.usageTextBox.HintText = "Usage"
        Me.usageTextBox.isPassword = False
        Me.usageTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.usageTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.usageTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.usageTextBox.LineThickness = 3
        Me.usageTextBox.Location = New System.Drawing.Point(885, 103)
        Me.usageTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.usageTextBox.Name = "usageTextBox"
        Me.usageTextBox.Size = New System.Drawing.Size(188, 44)
        Me.usageTextBox.TabIndex = 32
        Me.usageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'addInventoryButton
        '
        Me.addInventoryButton.BackColor = System.Drawing.Color.SeaGreen
        Me.addInventoryButton.color = System.Drawing.Color.SeaGreen
        Me.addInventoryButton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.addInventoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addInventoryButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.addInventoryButton.ForeColor = System.Drawing.Color.White
        Me.addInventoryButton.Image = CType(resources.GetObject("addInventoryButton.Image"), System.Drawing.Image)
        Me.addInventoryButton.ImagePosition = 5
        Me.addInventoryButton.ImageZoom = 40
        Me.addInventoryButton.LabelPosition = 41
        Me.addInventoryButton.LabelText = "Add"
        Me.addInventoryButton.Location = New System.Drawing.Point(800, 217)
        Me.addInventoryButton.Margin = New System.Windows.Forms.Padding(6)
        Me.addInventoryButton.Name = "addInventoryButton"
        Me.addInventoryButton.Size = New System.Drawing.Size(84, 72)
        Me.addInventoryButton.TabIndex = 36
        '
        'inventoryEndingTextBox
        '
        Me.inventoryEndingTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inventoryEndingTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.inventoryEndingTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inventoryEndingTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.inventoryEndingTextBox.HintText = "Inventory Ending"
        Me.inventoryEndingTextBox.isPassword = False
        Me.inventoryEndingTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.inventoryEndingTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.inventoryEndingTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.inventoryEndingTextBox.LineThickness = 3
        Me.inventoryEndingTextBox.Location = New System.Drawing.Point(885, 51)
        Me.inventoryEndingTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.inventoryEndingTextBox.Name = "inventoryEndingTextBox"
        Me.inventoryEndingTextBox.Size = New System.Drawing.Size(188, 44)
        Me.inventoryEndingTextBox.TabIndex = 31
        Me.inventoryEndingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'wastageTextBox
        '
        Me.wastageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.wastageTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.wastageTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.wastageTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.wastageTextBox.HintText = "Wastage"
        Me.wastageTextBox.isPassword = False
        Me.wastageTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.wastageTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.wastageTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.wastageTextBox.LineThickness = 3
        Me.wastageTextBox.Location = New System.Drawing.Point(689, 103)
        Me.wastageTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.wastageTextBox.Name = "wastageTextBox"
        Me.wastageTextBox.Size = New System.Drawing.Size(188, 44)
        Me.wastageTextBox.TabIndex = 30
        Me.wastageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'transferOutTextBox
        '
        Me.transferOutTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transferOutTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.transferOutTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.transferOutTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.transferOutTextBox.HintText = "Transfer Out"
        Me.transferOutTextBox.isPassword = False
        Me.transferOutTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.transferOutTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.transferOutTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.transferOutTextBox.LineThickness = 3
        Me.transferOutTextBox.Location = New System.Drawing.Point(689, 51)
        Me.transferOutTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.transferOutTextBox.Name = "transferOutTextBox"
        Me.transferOutTextBox.Size = New System.Drawing.Size(188, 44)
        Me.transferOutTextBox.TabIndex = 29
        Me.transferOutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'transferInTextBox
        '
        Me.transferInTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transferInTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.transferInTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.transferInTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.transferInTextBox.HintText = "Transfer In"
        Me.transferInTextBox.isPassword = False
        Me.transferInTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.transferInTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.transferInTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.transferInTextBox.LineThickness = 3
        Me.transferInTextBox.Location = New System.Drawing.Point(493, 103)
        Me.transferInTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.transferInTextBox.Name = "transferInTextBox"
        Me.transferInTextBox.Size = New System.Drawing.Size(188, 44)
        Me.transferInTextBox.TabIndex = 28
        Me.transferInTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'priceTextBox
        '
        Me.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.priceTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.priceTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.priceTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.priceTextBox.HintText = "Price"
        Me.priceTextBox.isPassword = False
        Me.priceTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.priceTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.priceTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.priceTextBox.LineThickness = 3
        Me.priceTextBox.Location = New System.Drawing.Point(493, 51)
        Me.priceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(188, 44)
        Me.priceTextBox.TabIndex = 27
        Me.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quantityTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.quantityTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.quantityTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.quantityTextBox.HintText = "Quantity"
        Me.quantityTextBox.isPassword = False
        Me.quantityTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.quantityTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.quantityTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.quantityTextBox.LineThickness = 3
        Me.quantityTextBox.Location = New System.Drawing.Point(297, 103)
        Me.quantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(188, 44)
        Me.quantityTextBox.TabIndex = 26
        Me.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'inventoryBeginningTextBox
        '
        Me.inventoryBeginningTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inventoryBeginningTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.inventoryBeginningTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inventoryBeginningTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.inventoryBeginningTextBox.HintText = "Inventory Beginning"
        Me.inventoryBeginningTextBox.isPassword = False
        Me.inventoryBeginningTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.inventoryBeginningTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.inventoryBeginningTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.inventoryBeginningTextBox.LineThickness = 3
        Me.inventoryBeginningTextBox.Location = New System.Drawing.Point(297, 51)
        Me.inventoryBeginningTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.inventoryBeginningTextBox.Name = "inventoryBeginningTextBox"
        Me.inventoryBeginningTextBox.Size = New System.Drawing.Size(188, 44)
        Me.inventoryBeginningTextBox.TabIndex = 25
        Me.inventoryBeginningTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.descriptionTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.descriptionTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.descriptionTextBox.HintText = "Description"
        Me.descriptionTextBox.isPassword = False
        Me.descriptionTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen
        Me.descriptionTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.descriptionTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.descriptionTextBox.LineThickness = 3
        Me.descriptionTextBox.Location = New System.Drawing.Point(58, 49)
        Me.descriptionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(231, 44)
        Me.descriptionTextBox.TabIndex = 24
        Me.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'inventoryLabel
        '
        Me.inventoryLabel.AutoSize = True
        Me.inventoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryLabel.Location = New System.Drawing.Point(7, 12)
        Me.inventoryLabel.Name = "inventoryLabel"
        Me.inventoryLabel.Size = New System.Drawing.Size(127, 31)
        Me.inventoryLabel.TabIndex = 0
        Me.inventoryLabel.Text = "Inventory"
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Image = Global.Spinner_Ice_Cream_Inventory.My.Resources.Resources.logo
        Me.logoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(206, 90)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPictureBox.TabIndex = 6
        Me.logoPictureBox.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.navigationPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.navigationPanel.ResumeLayout(False)
        Me.mainPanel.ResumeLayout(False)
        Me.branchPanel.ResumeLayout(False)
        Me.branchPanel.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        CType(Me.branchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spinner_Inventory_DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inventoryPanel.ResumeLayout(False)
        Me.inventoryPanel.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.inventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inventoryButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents branchButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents navigationPanel As Panel
    Friend WithEvents closeButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents mainPanel As Panel
    Friend WithEvents branchPanel As Panel
    Friend WithEvents branchLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents inventoryPanel As Panel
    Friend WithEvents inventoryLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents inventoryDataGridView As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents remarksTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents unitTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents usageTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents inventoryEndingTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents wastageTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents transferOutTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents transferInTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents priceTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents quantityTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents inventoryBeginningTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents descriptionTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents deleteInventoryButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents editInventoryButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents addInventoryButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents DeleteBranchTextBox As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents EditBranchTextBox As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents addBranchButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents branchDataGridView As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents nameTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents inventorySearchTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Spinner_Inventory_DbDataSet As Spinner_Inventory_DbDataSet
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchTableAdapter As Spinner_Inventory_DbDataSetTableAdapters.branchTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As Spinner_Inventory_DbDataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents branchComboBox As ComboBox
    Friend WithEvents branchSearchTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents branchSearchButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logoPictureBox As PictureBox
End Class

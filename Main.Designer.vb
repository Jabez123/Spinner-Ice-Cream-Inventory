<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.DoubleBitmapControl1 = New BunifuAnimatorNS.DoubleBitmapControl()
        Me.branchButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navigationPanel = New System.Windows.Forms.Panel()
        Me.closeButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.branchPanel = New System.Windows.Forms.Panel()
        Me.branchSearchTextBox = New Bunifu.Framework.UI.BunifuTextbox()
        Me.DeleteBranchTextBox = New Bunifu.Framework.UI.BunifuTileButton()
        Me.EditBranchTextBox = New Bunifu.Framework.UI.BunifuTileButton()
        Me.addBranchButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.branchDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.nameTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.branchLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.inventoryPanel = New System.Windows.Forms.Panel()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.branchDropDown = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.inventoryDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.remarksTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.deleteInventoryButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.unitTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.Spinner_Inventory_DbDataSet = New Spinner_Ice_Cream_Inventory.Spinner_Inventory_DbDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchTableAdapter = New Spinner_Ice_Cream_Inventory.Spinner_Inventory_DbDataSetTableAdapters.branchTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New Spinner_Ice_Cream_Inventory.Spinner_Inventory_DbDataSetTableAdapters.inventoryTableAdapter()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventorybeginningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransferinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransferoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WastageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryendingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.navigationPanel.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        Me.branchPanel.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.branchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inventoryPanel.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.inventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spinner_Inventory_DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DoubleBitmapControl1
        '
        Me.DoubleBitmapControl1.BackgroundImage = Global.Spinner_Ice_Cream_Inventory.My.Resources.Resources.logo
        Me.DoubleBitmapControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DoubleBitmapControl1.Location = New System.Drawing.Point(12, 12)
        Me.DoubleBitmapControl1.Margin = New System.Windows.Forms.Padding(3, 3, 9, 3)
        Me.DoubleBitmapControl1.Name = "DoubleBitmapControl1"
        Me.DoubleBitmapControl1.Size = New System.Drawing.Size(206, 90)
        Me.DoubleBitmapControl1.TabIndex = 1
        Me.DoubleBitmapControl1.Text = "DoubleBitmapControl1"
        Me.DoubleBitmapControl1.Visible = False
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
        Me.navigationPanel.Controls.Add(Me.closeButton)
        Me.navigationPanel.Controls.Add(Me.DoubleBitmapControl1)
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
        Me.mainPanel.Controls.Add(Me.branchPanel)
        Me.mainPanel.Controls.Add(Me.inventoryPanel)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.mainPanel.Location = New System.Drawing.Point(230, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1136, 768)
        Me.mainPanel.TabIndex = 6
        '
        'branchPanel
        '
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
        'branchSearchTextBox
        '
        Me.branchSearchTextBox.BackColor = System.Drawing.Color.Silver
        Me.branchSearchTextBox.BackgroundImage = CType(resources.GetObject("branchSearchTextBox.BackgroundImage"), System.Drawing.Image)
        Me.branchSearchTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.branchSearchTextBox.ForeColor = System.Drawing.Color.SeaGreen
        Me.branchSearchTextBox.Icon = CType(resources.GetObject("branchSearchTextBox.Icon"), System.Drawing.Image)
        Me.branchSearchTextBox.Location = New System.Drawing.Point(294, 49)
        Me.branchSearchTextBox.Name = "branchSearchTextBox"
        Me.branchSearchTextBox.Size = New System.Drawing.Size(284, 42)
        Me.branchSearchTextBox.TabIndex = 42
        Me.branchSearchTextBox.text = "Bunifu TextBox"
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
        Me.BunifuCards2.Location = New System.Drawing.Point(294, 100)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(830, 653)
        Me.BunifuCards2.TabIndex = 36
        '
        'branchDataGridView
        '
        Me.branchDataGridView.AllowUserToAddRows = False
        Me.branchDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.branchDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.branchDataGridView.AutoGenerateColumns = False
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
        Me.branchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.branchDataGridView.DataSource = Me.BranchBindingSource
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
        Me.branchDataGridView.Size = New System.Drawing.Size(830, 653)
        Me.branchDataGridView.TabIndex = 1
        '
        'nameTextBox
        '
        Me.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nameTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.nameTextBox.HintText = "Name"
        Me.nameTextBox.isPassword = False
        Me.nameTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.nameTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.nameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.inventoryPanel.Controls.Add(Me.branchDropDown)
        Me.inventoryPanel.Controls.Add(Me.BunifuCards1)
        Me.inventoryPanel.Controls.Add(Me.remarksTextBox)
        Me.inventoryPanel.Controls.Add(Me.deleteInventoryButton)
        Me.inventoryPanel.Controls.Add(Me.unitTextBox)
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
        Me.inventoryPanel.Visible = False
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = "Search"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(13, 232)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(777, 44)
        Me.BunifuMaterialTextbox1.TabIndex = 41
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'branchDropDown
        '
        Me.branchDropDown.BackColor = System.Drawing.Color.Transparent
        Me.branchDropDown.BorderRadius = 3
        Me.branchDropDown.ForeColor = System.Drawing.Color.White
        Me.branchDropDown.Items = New String() {"Select Branch"}
        Me.branchDropDown.Location = New System.Drawing.Point(58, 164)
        Me.branchDropDown.Name = "branchDropDown"
        Me.branchDropDown.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.branchDropDown.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.branchDropDown.selectedIndex = 0
        Me.branchDropDown.Size = New System.Drawing.Size(231, 44)
        Me.branchDropDown.TabIndex = 40
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
        Me.inventoryDataGridView.AutoGenerateColumns = False
        Me.inventoryDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.inventoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inventoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inventoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.BranchidDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.UnitDataGridViewTextBoxColumn, Me.InventorybeginningDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TransferinDataGridViewTextBoxColumn, Me.TransferoutDataGridViewTextBoxColumn, Me.WastageDataGridViewTextBoxColumn, Me.InventoryendingDataGridViewTextBoxColumn, Me.UsageDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.inventoryDataGridView.DataSource = Me.InventoryBindingSource
        Me.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventoryDataGridView.DoubleBuffered = True
        Me.inventoryDataGridView.EnableHeadersVisualStyles = False
        Me.inventoryDataGridView.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.inventoryDataGridView.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.inventoryDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.inventoryDataGridView.Name = "inventoryDataGridView"
        Me.inventoryDataGridView.ReadOnly = True
        Me.inventoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.inventoryDataGridView.Size = New System.Drawing.Size(1111, 458)
        Me.inventoryDataGridView.TabIndex = 1
        '
        'remarksTextBox
        '
        Me.remarksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.remarksTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.remarksTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.remarksTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.remarksTextBox.HintText = "Remarks"
        Me.remarksTextBox.isPassword = False
        Me.remarksTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.remarksTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.remarksTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.remarksTextBox.LineThickness = 3
        Me.remarksTextBox.Location = New System.Drawing.Point(297, 164)
        Me.remarksTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.remarksTextBox.Name = "remarksTextBox"
        Me.remarksTextBox.Size = New System.Drawing.Size(776, 44)
        Me.remarksTextBox.TabIndex = 34
        Me.remarksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'unitTextBox
        '
        Me.unitTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.unitTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.unitTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.unitTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.unitTextBox.HintText = "Unit"
        Me.unitTextBox.isPassword = False
        Me.unitTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.unitTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.unitTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.unitTextBox.LineThickness = 3
        Me.unitTextBox.Location = New System.Drawing.Point(58, 103)
        Me.unitTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.unitTextBox.Name = "unitTextBox"
        Me.unitTextBox.Size = New System.Drawing.Size(231, 44)
        Me.unitTextBox.TabIndex = 33
        Me.unitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.usageTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.usageTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.usageTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        Me.wastageTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.wastageTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.wastageTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        Me.transferOutTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.transferOutTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.transferOutTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        Me.transferInTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.transferInTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.transferInTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        Me.priceTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.priceTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.priceTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        Me.quantityTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.quantityTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.quantityTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        Me.inventoryBeginningTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.inventoryBeginningTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.inventoryBeginningTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        Me.descriptionTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.descriptionTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.descriptionTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
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
        'Spinner_Inventory_DbDataSet
        '
        Me.Spinner_Inventory_DbDataSet.DataSetName = "Spinner_Inventory_DbDataSet"
        Me.Spinner_Inventory_DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "branch"
        Me.BranchBindingSource.DataSource = Me.Spinner_Inventory_DbDataSet
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "inventory"
        Me.InventoryBindingSource.DataSource = Me.Spinner_Inventory_DbDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BranchidDataGridViewTextBoxColumn
        '
        Me.BranchidDataGridViewTextBoxColumn.DataPropertyName = "branch_id"
        Me.BranchidDataGridViewTextBoxColumn.HeaderText = "branch_id"
        Me.BranchidDataGridViewTextBoxColumn.Name = "BranchidDataGridViewTextBoxColumn"
        Me.BranchidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitDataGridViewTextBoxColumn
        '
        Me.UnitDataGridViewTextBoxColumn.DataPropertyName = "unit"
        Me.UnitDataGridViewTextBoxColumn.HeaderText = "unit"
        Me.UnitDataGridViewTextBoxColumn.Name = "UnitDataGridViewTextBoxColumn"
        Me.UnitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventorybeginningDataGridViewTextBoxColumn
        '
        Me.InventorybeginningDataGridViewTextBoxColumn.DataPropertyName = "inventory_beginning"
        Me.InventorybeginningDataGridViewTextBoxColumn.HeaderText = "inventory_beginning"
        Me.InventorybeginningDataGridViewTextBoxColumn.Name = "InventorybeginningDataGridViewTextBoxColumn"
        Me.InventorybeginningDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransferinDataGridViewTextBoxColumn
        '
        Me.TransferinDataGridViewTextBoxColumn.DataPropertyName = "transfer_in"
        Me.TransferinDataGridViewTextBoxColumn.HeaderText = "transfer_in"
        Me.TransferinDataGridViewTextBoxColumn.Name = "TransferinDataGridViewTextBoxColumn"
        Me.TransferinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransferoutDataGridViewTextBoxColumn
        '
        Me.TransferoutDataGridViewTextBoxColumn.DataPropertyName = "transfer_out"
        Me.TransferoutDataGridViewTextBoxColumn.HeaderText = "transfer_out"
        Me.TransferoutDataGridViewTextBoxColumn.Name = "TransferoutDataGridViewTextBoxColumn"
        Me.TransferoutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WastageDataGridViewTextBoxColumn
        '
        Me.WastageDataGridViewTextBoxColumn.DataPropertyName = "wastage"
        Me.WastageDataGridViewTextBoxColumn.HeaderText = "wastage"
        Me.WastageDataGridViewTextBoxColumn.Name = "WastageDataGridViewTextBoxColumn"
        Me.WastageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventoryendingDataGridViewTextBoxColumn
        '
        Me.InventoryendingDataGridViewTextBoxColumn.DataPropertyName = "inventory_ending"
        Me.InventoryendingDataGridViewTextBoxColumn.HeaderText = "inventory_ending"
        Me.InventoryendingDataGridViewTextBoxColumn.Name = "InventoryendingDataGridViewTextBoxColumn"
        Me.InventoryendingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsageDataGridViewTextBoxColumn
        '
        Me.UsageDataGridViewTextBoxColumn.DataPropertyName = "usage"
        Me.UsageDataGridViewTextBoxColumn.HeaderText = "usage"
        Me.UsageDataGridViewTextBoxColumn.Name = "UsageDataGridViewTextBoxColumn"
        Me.UsageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        Me.RemarksDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.Text = "Form1"
        Me.navigationPanel.ResumeLayout(False)
        Me.mainPanel.ResumeLayout(False)
        Me.branchPanel.ResumeLayout(False)
        Me.branchPanel.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        CType(Me.branchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inventoryPanel.ResumeLayout(False)
        Me.inventoryPanel.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.inventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spinner_Inventory_DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inventoryButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DoubleBitmapControl1 As BunifuAnimatorNS.DoubleBitmapControl
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
    Friend WithEvents branchSearchTextBox As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents DeleteBranchTextBox As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents EditBranchTextBox As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents addBranchButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents branchDataGridView As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents nameTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents branchDropDown As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Spinner_Inventory_DbDataSet As Spinner_Inventory_DbDataSet
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchTableAdapter As Spinner_Inventory_DbDataSetTableAdapters.branchTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As Spinner_Inventory_DbDataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BranchidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventorybeginningDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransferinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransferoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WastageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryendingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

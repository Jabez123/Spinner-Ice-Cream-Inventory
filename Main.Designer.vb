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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.inventoryButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DoubleBitmapControl1 = New BunifuAnimatorNS.DoubleBitmapControl()
        Me.branchButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navigationPanel = New System.Windows.Forms.Panel()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.inventoryPanel = New System.Windows.Forms.Panel()
        Me.inventoryLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.branchPanel = New System.Windows.Forms.Panel()
        Me.branchLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.closeButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuMaterialTextbox11 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox10 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox9 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox8 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox7 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox6 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton2 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton3 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.navigationPanel.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        Me.inventoryPanel.SuspendLayout()
        Me.branchPanel.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'inventoryPanel
        '
        Me.inventoryPanel.Controls.Add(Me.BunifuTileButton3)
        Me.inventoryPanel.Controls.Add(Me.BunifuTileButton2)
        Me.inventoryPanel.Controls.Add(Me.BunifuTileButton1)
        Me.inventoryPanel.Controls.Add(Me.BunifuCards1)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox11)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox10)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox9)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox8)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox7)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox6)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox5)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox4)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox3)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.inventoryPanel.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.inventoryPanel.Controls.Add(Me.inventoryLabel)
        Me.inventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventoryPanel.Location = New System.Drawing.Point(0, 0)
        Me.inventoryPanel.Name = "inventoryPanel"
        Me.inventoryPanel.Size = New System.Drawing.Size(1136, 768)
        Me.inventoryPanel.TabIndex = 0
        Me.inventoryPanel.Visible = False
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
        'branchPanel
        '
        Me.branchPanel.Controls.Add(Me.branchLabel)
        Me.branchPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.branchPanel.Location = New System.Drawing.Point(0, 0)
        Me.branchPanel.Name = "branchPanel"
        Me.branchPanel.Size = New System.Drawing.Size(1136, 768)
        Me.branchPanel.TabIndex = 1
        Me.branchPanel.Visible = False
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
        'BunifuMaterialTextbox11
        '
        Me.BunifuMaterialTextbox11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox11.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox11.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox11.HintText = "Remarks"
        Me.BunifuMaterialTextbox11.isPassword = False
        Me.BunifuMaterialTextbox11.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox11.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox11.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox11.LineThickness = 3
        Me.BunifuMaterialTextbox11.Location = New System.Drawing.Point(13, 164)
        Me.BunifuMaterialTextbox11.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox11.Name = "BunifuMaterialTextbox11"
        Me.BunifuMaterialTextbox11.Size = New System.Drawing.Size(718, 75)
        Me.BunifuMaterialTextbox11.TabIndex = 34
        Me.BunifuMaterialTextbox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox10
        '
        Me.BunifuMaterialTextbox10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox10.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox10.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox10.HintText = "Unit"
        Me.BunifuMaterialTextbox10.isPassword = False
        Me.BunifuMaterialTextbox10.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox10.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox10.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox10.LineThickness = 3
        Me.BunifuMaterialTextbox10.Location = New System.Drawing.Point(13, 101)
        Me.BunifuMaterialTextbox10.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox10.Name = "BunifuMaterialTextbox10"
        Me.BunifuMaterialTextbox10.Size = New System.Drawing.Size(231, 44)
        Me.BunifuMaterialTextbox10.TabIndex = 33
        Me.BunifuMaterialTextbox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox9
        '
        Me.BunifuMaterialTextbox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox9.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox9.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox9.HintText = "Usage"
        Me.BunifuMaterialTextbox9.isPassword = False
        Me.BunifuMaterialTextbox9.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox9.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox9.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox9.LineThickness = 3
        Me.BunifuMaterialTextbox9.Location = New System.Drawing.Point(935, 101)
        Me.BunifuMaterialTextbox9.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox9.Name = "BunifuMaterialTextbox9"
        Me.BunifuMaterialTextbox9.Size = New System.Drawing.Size(188, 44)
        Me.BunifuMaterialTextbox9.TabIndex = 32
        Me.BunifuMaterialTextbox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox8
        '
        Me.BunifuMaterialTextbox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox8.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox8.HintText = "Inventory Ending"
        Me.BunifuMaterialTextbox8.isPassword = False
        Me.BunifuMaterialTextbox8.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox8.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox8.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox8.LineThickness = 3
        Me.BunifuMaterialTextbox8.Location = New System.Drawing.Point(935, 49)
        Me.BunifuMaterialTextbox8.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox8.Name = "BunifuMaterialTextbox8"
        Me.BunifuMaterialTextbox8.Size = New System.Drawing.Size(188, 44)
        Me.BunifuMaterialTextbox8.TabIndex = 31
        Me.BunifuMaterialTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox7
        '
        Me.BunifuMaterialTextbox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox7.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox7.HintText = "Wastage"
        Me.BunifuMaterialTextbox7.isPassword = False
        Me.BunifuMaterialTextbox7.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox7.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox7.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox7.LineThickness = 3
        Me.BunifuMaterialTextbox7.Location = New System.Drawing.Point(739, 101)
        Me.BunifuMaterialTextbox7.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox7.Name = "BunifuMaterialTextbox7"
        Me.BunifuMaterialTextbox7.Size = New System.Drawing.Size(188, 44)
        Me.BunifuMaterialTextbox7.TabIndex = 30
        Me.BunifuMaterialTextbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox6
        '
        Me.BunifuMaterialTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox6.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox6.HintText = "Transfer Out"
        Me.BunifuMaterialTextbox6.isPassword = False
        Me.BunifuMaterialTextbox6.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox6.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox6.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox6.LineThickness = 3
        Me.BunifuMaterialTextbox6.Location = New System.Drawing.Point(739, 49)
        Me.BunifuMaterialTextbox6.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox6.Name = "BunifuMaterialTextbox6"
        Me.BunifuMaterialTextbox6.Size = New System.Drawing.Size(188, 44)
        Me.BunifuMaterialTextbox6.TabIndex = 29
        Me.BunifuMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox5
        '
        Me.BunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox5.HintText = "Transfer In"
        Me.BunifuMaterialTextbox5.isPassword = False
        Me.BunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox5.LineThickness = 3
        Me.BunifuMaterialTextbox5.Location = New System.Drawing.Point(543, 101)
        Me.BunifuMaterialTextbox5.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox5.Name = "BunifuMaterialTextbox5"
        Me.BunifuMaterialTextbox5.Size = New System.Drawing.Size(188, 44)
        Me.BunifuMaterialTextbox5.TabIndex = 28
        Me.BunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox4
        '
        Me.BunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox4.HintText = "Price"
        Me.BunifuMaterialTextbox4.isPassword = False
        Me.BunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox4.LineThickness = 3
        Me.BunifuMaterialTextbox4.Location = New System.Drawing.Point(543, 49)
        Me.BunifuMaterialTextbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox4.Name = "BunifuMaterialTextbox4"
        Me.BunifuMaterialTextbox4.Size = New System.Drawing.Size(188, 44)
        Me.BunifuMaterialTextbox4.TabIndex = 27
        Me.BunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox3
        '
        Me.BunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox3.HintText = "Quantity"
        Me.BunifuMaterialTextbox3.isPassword = False
        Me.BunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox3.LineThickness = 3
        Me.BunifuMaterialTextbox3.Location = New System.Drawing.Point(347, 101)
        Me.BunifuMaterialTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox3.Name = "BunifuMaterialTextbox3"
        Me.BunifuMaterialTextbox3.Size = New System.Drawing.Size(188, 44)
        Me.BunifuMaterialTextbox3.TabIndex = 26
        Me.BunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox2.HintText = "Inventory Beginning"
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(347, 49)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(188, 44)
        Me.BunifuMaterialTextbox2.TabIndex = 25
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = "Description"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(13, 47)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(231, 44)
        Me.BunifuMaterialTextbox1.TabIndex = 24
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Orange
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(13, 246)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(1111, 510)
        Me.BunifuCards1.TabIndex = 35
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToAddRows = False
        Me.BunifuCustomDataGrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(0, 5)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.ReadOnly = True
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1109, 502)
        Me.BunifuCustomDataGrid1.TabIndex = 1
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton1.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = CType(resources.GetObject("BunifuTileButton1.Image"), System.Drawing.Image)
        Me.BunifuTileButton1.ImagePosition = 10
        Me.BunifuTileButton1.ImageZoom = 40
        Me.BunifuTileButton1.LabelPosition = 41
        Me.BunifuTileButton1.LabelText = "Add"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(739, 155)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(85, 84)
        Me.BunifuTileButton1.TabIndex = 36
        '
        'BunifuTileButton2
        '
        Me.BunifuTileButton2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BunifuTileButton2.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton2.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton2.Image = CType(resources.GetObject("BunifuTileButton2.Image"), System.Drawing.Image)
        Me.BunifuTileButton2.ImagePosition = 10
        Me.BunifuTileButton2.ImageZoom = 40
        Me.BunifuTileButton2.LabelPosition = 41
        Me.BunifuTileButton2.LabelText = "Edit"
        Me.BunifuTileButton2.Location = New System.Drawing.Point(836, 155)
        Me.BunifuTileButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton2.Name = "BunifuTileButton2"
        Me.BunifuTileButton2.Size = New System.Drawing.Size(85, 84)
        Me.BunifuTileButton2.TabIndex = 37
        '
        'BunifuTileButton3
        '
        Me.BunifuTileButton3.BackColor = System.Drawing.Color.Firebrick
        Me.BunifuTileButton3.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton3.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton3.Image = CType(resources.GetObject("BunifuTileButton3.Image"), System.Drawing.Image)
        Me.BunifuTileButton3.ImagePosition = 10
        Me.BunifuTileButton3.ImageZoom = 40
        Me.BunifuTileButton3.LabelPosition = 41
        Me.BunifuTileButton3.LabelText = "Delete"
        Me.BunifuTileButton3.Location = New System.Drawing.Point(933, 155)
        Me.BunifuTileButton3.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton3.Name = "BunifuTileButton3"
        Me.BunifuTileButton3.Size = New System.Drawing.Size(85, 84)
        Me.BunifuTileButton3.TabIndex = 38
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
        Me.inventoryPanel.ResumeLayout(False)
        Me.inventoryPanel.PerformLayout()
        Me.branchPanel.ResumeLayout(False)
        Me.branchPanel.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuMaterialTextbox11 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox10 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox9 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox8 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox7 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox6 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuTileButton3 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton2 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
End Class

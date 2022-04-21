<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstSearchResults = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbSearch = New System.Windows.Forms.GroupBox()
        Me.lblScaleSearch = New System.Windows.Forms.Label()
        Me.cmbScaleOptions = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUUID = New System.Windows.Forms.Label()
        Me.txtNormalWeight = New System.Windows.Forms.TextBox()
        Me.lblNormalWeight = New System.Windows.Forms.Label()
        Me.txtItemCountPerBox = New System.Windows.Forms.TextBox()
        Me.lblItemCountPerBox = New System.Windows.Forms.Label()
        Me.txtItemTareEach = New System.Windows.Forms.TextBox()
        Me.lblItemTareEach = New System.Windows.Forms.Label()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.lblLot = New System.Windows.Forms.Label()
        Me.txtProductType = New System.Windows.Forms.TextBox()
        Me.lblProductType = New System.Windows.Forms.Label()
        Me.txtAlphaDesc = New System.Windows.Forms.TextBox()
        Me.lblAlphaDesc = New System.Windows.Forms.Label()
        Me.txtTestingDesc = New System.Windows.Forms.TextBox()
        Me.lblTestingDesc = New System.Windows.Forms.Label()
        Me.txtLabel = New System.Windows.Forms.TextBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.txtPricePerLb = New System.Windows.Forms.TextBox()
        Me.lblPricePerLb = New System.Windows.Forms.Label()
        Me.txtSellByDate = New System.Windows.Forms.TextBox()
        Me.lblSellByDate = New System.Windows.Forms.Label()
        Me.txtKillDate = New System.Windows.Forms.TextBox()
        Me.lblKillDate = New System.Windows.Forms.Label()
        Me.txtDiscPerLb = New System.Windows.Forms.TextBox()
        Me.lblDiscPerLb = New System.Windows.Forms.Label()
        Me.lblScaleType = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.lblProductCode = New System.Windows.Forms.Label()
        Me.txtProductDesc = New System.Windows.Forms.TextBox()
        Me.lblProductDesc = New System.Windows.Forms.Label()
        Me.txtProductDesc2 = New System.Windows.Forms.TextBox()
        Me.lblProductDesc2 = New System.Windows.Forms.Label()
        Me.txtSetWeight = New System.Windows.Forms.TextBox()
        Me.lblSetWeight = New System.Windows.Forms.Label()
        Me.txtProductGrade = New System.Windows.Forms.TextBox()
        Me.lblProductGrade = New System.Windows.Forms.Label()
        Me.txtProductTare = New System.Windows.Forms.TextBox()
        Me.lblProductTare = New System.Windows.Forms.Label()
        Me.txtProductTare2 = New System.Windows.Forms.TextBox()
        Me.lblProductTare2 = New System.Windows.Forms.Label()
        Me.txtKickoutCount = New System.Windows.Forms.TextBox()
        Me.lblKickoutCount = New System.Windows.Forms.Label()
        Me.txtMinWeight = New System.Windows.Forms.TextBox()
        Me.lblMinWeight = New System.Windows.Forms.Label()
        Me.txtMaxWeight = New System.Windows.Forms.TextBox()
        Me.lblMaxWeight = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoAddNew = New System.Windows.Forms.RadioButton()
        Me.rdoUpdate = New System.Windows.Forms.RadioButton()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.cmbScaleType = New System.Windows.Forms.ComboBox()
        Me.grbSearch.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSearchResults
        '
        Me.lstSearchResults.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSearchResults.FormattingEnabled = True
        Me.lstSearchResults.ItemHeight = 19
        Me.lstSearchResults.Location = New System.Drawing.Point(17, 225)
        Me.lstSearchResults.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSearchResults.Name = "lstSearchResults"
        Me.lstSearchResults.Size = New System.Drawing.Size(349, 327)
        Me.lstSearchResults.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Text"
        '
        'txtSearchText
        '
        Me.txtSearchText.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchText.Location = New System.Drawing.Point(107, 29)
        Me.txtSearchText.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(259, 27)
        Me.txtSearchText.TabIndex = 1
        '
        'cmbSearchType
        '
        Me.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Location = New System.Drawing.Point(107, 71)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(259, 27)
        Me.cmbSearchType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Type"
        '
        'grbSearch
        '
        Me.grbSearch.Controls.Add(Me.lblScaleSearch)
        Me.grbSearch.Controls.Add(Me.cmbScaleOptions)
        Me.grbSearch.Controls.Add(Me.btnSearch)
        Me.grbSearch.Controls.Add(Me.Label2)
        Me.grbSearch.Controls.Add(Me.cmbSearchType)
        Me.grbSearch.Controls.Add(Me.txtSearchText)
        Me.grbSearch.Controls.Add(Me.Label1)
        Me.grbSearch.Controls.Add(Me.lstSearchResults)
        Me.grbSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbSearch.Location = New System.Drawing.Point(33, 108)
        Me.grbSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.grbSearch.Name = "grbSearch"
        Me.grbSearch.Padding = New System.Windows.Forms.Padding(4)
        Me.grbSearch.Size = New System.Drawing.Size(395, 586)
        Me.grbSearch.TabIndex = 4
        Me.grbSearch.TabStop = False
        Me.grbSearch.Text = "Search"
        '
        'lblScaleSearch
        '
        Me.lblScaleSearch.AutoSize = True
        Me.lblScaleSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScaleSearch.Location = New System.Drawing.Point(56, 114)
        Me.lblScaleSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScaleSearch.Name = "lblScaleSearch"
        Me.lblScaleSearch.Size = New System.Drawing.Size(43, 19)
        Me.lblScaleSearch.TabIndex = 6
        Me.lblScaleSearch.Text = "Scale"
        '
        'cmbScaleOptions
        '
        Me.cmbScaleOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbScaleOptions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbScaleOptions.FormattingEnabled = True
        Me.cmbScaleOptions.Location = New System.Drawing.Point(107, 114)
        Me.cmbScaleOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbScaleOptions.Name = "cmbScaleOptions"
        Me.cmbScaleOptions.Size = New System.Drawing.Size(259, 27)
        Me.cmbScaleOptions.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(107, 162)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(198, 44)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbScaleType)
        Me.GroupBox2.Controls.Add(Me.lblUUID)
        Me.GroupBox2.Controls.Add(Me.txtNormalWeight)
        Me.GroupBox2.Controls.Add(Me.lblNormalWeight)
        Me.GroupBox2.Controls.Add(Me.txtItemCountPerBox)
        Me.GroupBox2.Controls.Add(Me.lblItemCountPerBox)
        Me.GroupBox2.Controls.Add(Me.txtItemTareEach)
        Me.GroupBox2.Controls.Add(Me.lblItemTareEach)
        Me.GroupBox2.Controls.Add(Me.txtLot)
        Me.GroupBox2.Controls.Add(Me.lblLot)
        Me.GroupBox2.Controls.Add(Me.txtProductType)
        Me.GroupBox2.Controls.Add(Me.lblProductType)
        Me.GroupBox2.Controls.Add(Me.txtAlphaDesc)
        Me.GroupBox2.Controls.Add(Me.lblAlphaDesc)
        Me.GroupBox2.Controls.Add(Me.txtTestingDesc)
        Me.GroupBox2.Controls.Add(Me.lblTestingDesc)
        Me.GroupBox2.Controls.Add(Me.txtLabel)
        Me.GroupBox2.Controls.Add(Me.lblLabel)
        Me.GroupBox2.Controls.Add(Me.txtPricePerLb)
        Me.GroupBox2.Controls.Add(Me.lblPricePerLb)
        Me.GroupBox2.Controls.Add(Me.txtSellByDate)
        Me.GroupBox2.Controls.Add(Me.lblSellByDate)
        Me.GroupBox2.Controls.Add(Me.txtKillDate)
        Me.GroupBox2.Controls.Add(Me.lblKillDate)
        Me.GroupBox2.Controls.Add(Me.txtDiscPerLb)
        Me.GroupBox2.Controls.Add(Me.lblDiscPerLb)
        Me.GroupBox2.Controls.Add(Me.lblScaleType)
        Me.GroupBox2.Controls.Add(Me.txtProductCode)
        Me.GroupBox2.Controls.Add(Me.lblProductCode)
        Me.GroupBox2.Controls.Add(Me.txtProductDesc)
        Me.GroupBox2.Controls.Add(Me.lblProductDesc)
        Me.GroupBox2.Controls.Add(Me.txtProductDesc2)
        Me.GroupBox2.Controls.Add(Me.lblProductDesc2)
        Me.GroupBox2.Controls.Add(Me.txtSetWeight)
        Me.GroupBox2.Controls.Add(Me.lblSetWeight)
        Me.GroupBox2.Controls.Add(Me.txtProductGrade)
        Me.GroupBox2.Controls.Add(Me.lblProductGrade)
        Me.GroupBox2.Controls.Add(Me.txtProductTare)
        Me.GroupBox2.Controls.Add(Me.lblProductTare)
        Me.GroupBox2.Controls.Add(Me.txtProductTare2)
        Me.GroupBox2.Controls.Add(Me.lblProductTare2)
        Me.GroupBox2.Controls.Add(Me.txtKickoutCount)
        Me.GroupBox2.Controls.Add(Me.lblKickoutCount)
        Me.GroupBox2.Controls.Add(Me.txtMinWeight)
        Me.GroupBox2.Controls.Add(Me.lblMinWeight)
        Me.GroupBox2.Controls.Add(Me.txtMaxWeight)
        Me.GroupBox2.Controls.Add(Me.lblMaxWeight)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(470, 108)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(791, 590)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'lblUUID
        '
        Me.lblUUID.AutoSize = True
        Me.lblUUID.Location = New System.Drawing.Point(123, 560)
        Me.lblUUID.Name = "lblUUID"
        Me.lblUUID.Size = New System.Drawing.Size(43, 19)
        Me.lblUUID.TabIndex = 6
        Me.lblUUID.Text = "UUID"
        Me.lblUUID.Visible = False
        '
        'txtNormalWeight
        '
        Me.txtNormalWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNormalWeight.Location = New System.Drawing.Point(552, 153)
        Me.txtNormalWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNormalWeight.Name = "txtNormalWeight"
        Me.txtNormalWeight.Size = New System.Drawing.Size(203, 27)
        Me.txtNormalWeight.TabIndex = 70
        '
        'lblNormalWeight
        '
        Me.lblNormalWeight.AutoSize = True
        Me.lblNormalWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNormalWeight.Location = New System.Drawing.Point(439, 156)
        Me.lblNormalWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNormalWeight.Name = "lblNormalWeight"
        Me.lblNormalWeight.Size = New System.Drawing.Size(106, 19)
        Me.lblNormalWeight.TabIndex = 71
        Me.lblNormalWeight.Text = "Normal Weight"
        '
        'txtItemCountPerBox
        '
        Me.txtItemCountPerBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCountPerBox.Location = New System.Drawing.Point(552, 343)
        Me.txtItemCountPerBox.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemCountPerBox.Name = "txtItemCountPerBox"
        Me.txtItemCountPerBox.Size = New System.Drawing.Size(203, 27)
        Me.txtItemCountPerBox.TabIndex = 68
        '
        'lblItemCountPerBox
        '
        Me.lblItemCountPerBox.AutoSize = True
        Me.lblItemCountPerBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCountPerBox.Location = New System.Drawing.Point(412, 346)
        Me.lblItemCountPerBox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemCountPerBox.Name = "lblItemCountPerBox"
        Me.lblItemCountPerBox.Size = New System.Drawing.Size(133, 19)
        Me.lblItemCountPerBox.TabIndex = 69
        Me.lblItemCountPerBox.Text = "Item Count Per Box"
        '
        'txtItemTareEach
        '
        Me.txtItemTareEach.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemTareEach.Location = New System.Drawing.Point(552, 305)
        Me.txtItemTareEach.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemTareEach.Name = "txtItemTareEach"
        Me.txtItemTareEach.Size = New System.Drawing.Size(203, 27)
        Me.txtItemTareEach.TabIndex = 66
        '
        'lblItemTareEach
        '
        Me.lblItemTareEach.AutoSize = True
        Me.lblItemTareEach.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemTareEach.Location = New System.Drawing.Point(440, 308)
        Me.lblItemTareEach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemTareEach.Name = "lblItemTareEach"
        Me.lblItemTareEach.Size = New System.Drawing.Size(105, 19)
        Me.lblItemTareEach.TabIndex = 67
        Me.lblItemTareEach.Text = "Item Tare Each"
        '
        'txtLot
        '
        Me.txtLot.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot.Location = New System.Drawing.Point(175, 305)
        Me.txtLot.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(203, 27)
        Me.txtLot.TabIndex = 64
        '
        'lblLot
        '
        Me.lblLot.AutoSize = True
        Me.lblLot.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.Location = New System.Drawing.Point(139, 308)
        Me.lblLot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(29, 19)
        Me.lblLot.TabIndex = 65
        Me.lblLot.Text = "Lot"
        '
        'txtProductType
        '
        Me.txtProductType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductType.Location = New System.Drawing.Point(552, 194)
        Me.txtProductType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductType.Name = "txtProductType"
        Me.txtProductType.Size = New System.Drawing.Size(203, 27)
        Me.txtProductType.TabIndex = 62
        '
        'lblProductType
        '
        Me.lblProductType.AutoSize = True
        Me.lblProductType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductType.Location = New System.Drawing.Point(453, 194)
        Me.lblProductType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductType.Name = "lblProductType"
        Me.lblProductType.Size = New System.Drawing.Size(92, 19)
        Me.lblProductType.TabIndex = 63
        Me.lblProductType.Text = "Product Type"
        '
        'txtAlphaDesc
        '
        Me.txtAlphaDesc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlphaDesc.Location = New System.Drawing.Point(176, 495)
        Me.txtAlphaDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlphaDesc.Name = "txtAlphaDesc"
        Me.txtAlphaDesc.Size = New System.Drawing.Size(579, 27)
        Me.txtAlphaDesc.TabIndex = 60
        '
        'lblAlphaDesc
        '
        Me.lblAlphaDesc.AutoSize = True
        Me.lblAlphaDesc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlphaDesc.Location = New System.Drawing.Point(44, 498)
        Me.lblAlphaDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlphaDesc.Name = "lblAlphaDesc"
        Me.lblAlphaDesc.Size = New System.Drawing.Size(124, 19)
        Me.lblAlphaDesc.TabIndex = 61
        Me.lblAlphaDesc.Text = "Alpha Description"
        '
        'txtTestingDesc
        '
        Me.txtTestingDesc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestingDesc.Location = New System.Drawing.Point(176, 533)
        Me.txtTestingDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTestingDesc.Name = "txtTestingDesc"
        Me.txtTestingDesc.Size = New System.Drawing.Size(579, 27)
        Me.txtTestingDesc.TabIndex = 58
        '
        'lblTestingDesc
        '
        Me.lblTestingDesc.AutoSize = True
        Me.lblTestingDesc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestingDesc.Location = New System.Drawing.Point(34, 536)
        Me.lblTestingDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTestingDesc.Name = "lblTestingDesc"
        Me.lblTestingDesc.Size = New System.Drawing.Size(134, 19)
        Me.lblTestingDesc.TabIndex = 59
        Me.lblTestingDesc.Text = "Testing Description"
        '
        'txtLabel
        '
        Me.txtLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabel.Location = New System.Drawing.Point(176, 457)
        Me.txtLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.Size = New System.Drawing.Size(579, 27)
        Me.txtLabel.TabIndex = 56
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel.Location = New System.Drawing.Point(82, 460)
        Me.lblLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(86, 19)
        Me.lblLabel.TabIndex = 57
        Me.lblLabel.Text = "Label Name"
        '
        'txtPricePerLb
        '
        Me.txtPricePerLb.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPricePerLb.Location = New System.Drawing.Point(175, 381)
        Me.txtPricePerLb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPricePerLb.Name = "txtPricePerLb"
        Me.txtPricePerLb.Size = New System.Drawing.Size(203, 27)
        Me.txtPricePerLb.TabIndex = 54
        '
        'lblPricePerLb
        '
        Me.lblPricePerLb.AutoSize = True
        Me.lblPricePerLb.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerLb.Location = New System.Drawing.Point(83, 384)
        Me.lblPricePerLb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPricePerLb.Name = "lblPricePerLb"
        Me.lblPricePerLb.Size = New System.Drawing.Size(85, 19)
        Me.lblPricePerLb.TabIndex = 55
        Me.lblPricePerLb.Text = "Price Per Lb"
        '
        'txtSellByDate
        '
        Me.txtSellByDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellByDate.Location = New System.Drawing.Point(175, 419)
        Me.txtSellByDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSellByDate.Name = "txtSellByDate"
        Me.txtSellByDate.Size = New System.Drawing.Size(203, 27)
        Me.txtSellByDate.TabIndex = 52
        '
        'lblSellByDate
        '
        Me.lblSellByDate.AutoSize = True
        Me.lblSellByDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellByDate.Location = New System.Drawing.Point(81, 422)
        Me.lblSellByDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSellByDate.Name = "lblSellByDate"
        Me.lblSellByDate.Size = New System.Drawing.Size(87, 19)
        Me.lblSellByDate.TabIndex = 53
        Me.lblSellByDate.Text = "Sell By Date"
        '
        'txtKillDate
        '
        Me.txtKillDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKillDate.Location = New System.Drawing.Point(552, 419)
        Me.txtKillDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKillDate.Name = "txtKillDate"
        Me.txtKillDate.Size = New System.Drawing.Size(203, 27)
        Me.txtKillDate.TabIndex = 50
        '
        'lblKillDate
        '
        Me.lblKillDate.AutoSize = True
        Me.lblKillDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKillDate.Location = New System.Drawing.Point(481, 422)
        Me.lblKillDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKillDate.Name = "lblKillDate"
        Me.lblKillDate.Size = New System.Drawing.Size(64, 19)
        Me.lblKillDate.TabIndex = 51
        Me.lblKillDate.Text = "Kill Date"
        '
        'txtDiscPerLb
        '
        Me.txtDiscPerLb.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscPerLb.Location = New System.Drawing.Point(552, 381)
        Me.txtDiscPerLb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscPerLb.Name = "txtDiscPerLb"
        Me.txtDiscPerLb.Size = New System.Drawing.Size(203, 27)
        Me.txtDiscPerLb.TabIndex = 48
        '
        'lblDiscPerLb
        '
        Me.lblDiscPerLb.AutoSize = True
        Me.lblDiscPerLb.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscPerLb.Location = New System.Drawing.Point(464, 384)
        Me.lblDiscPerLb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscPerLb.Name = "lblDiscPerLb"
        Me.lblDiscPerLb.Size = New System.Drawing.Size(81, 19)
        Me.lblDiscPerLb.TabIndex = 49
        Me.lblDiscPerLb.Text = "Disc Per Lb"
        '
        'lblScaleType
        '
        Me.lblScaleType.AutoSize = True
        Me.lblScaleType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScaleType.Location = New System.Drawing.Point(91, 42)
        Me.lblScaleType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScaleType.Name = "lblScaleType"
        Me.lblScaleType.Size = New System.Drawing.Size(77, 19)
        Me.lblScaleType.TabIndex = 47
        Me.lblScaleType.Text = "Scale Type"
        '
        'txtProductCode
        '
        Me.txtProductCode.Enabled = False
        Me.txtProductCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.Location = New System.Drawing.Point(552, 39)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(203, 27)
        Me.txtProductCode.TabIndex = 44
        '
        'lblProductCode
        '
        Me.lblProductCode.AutoSize = True
        Me.lblProductCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductCode.Location = New System.Drawing.Point(450, 44)
        Me.lblProductCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductCode.Name = "lblProductCode"
        Me.lblProductCode.Size = New System.Drawing.Size(95, 19)
        Me.lblProductCode.TabIndex = 45
        Me.lblProductCode.Text = "Product Code"
        '
        'txtProductDesc
        '
        Me.txtProductDesc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDesc.Location = New System.Drawing.Point(176, 77)
        Me.txtProductDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductDesc.Name = "txtProductDesc"
        Me.txtProductDesc.Size = New System.Drawing.Size(579, 27)
        Me.txtProductDesc.TabIndex = 42
        '
        'lblProductDesc
        '
        Me.lblProductDesc.AutoSize = True
        Me.lblProductDesc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDesc.Location = New System.Drawing.Point(32, 80)
        Me.lblProductDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductDesc.Name = "lblProductDesc"
        Me.lblProductDesc.Size = New System.Drawing.Size(136, 19)
        Me.lblProductDesc.TabIndex = 43
        Me.lblProductDesc.Text = "Product Description"
        '
        'txtProductDesc2
        '
        Me.txtProductDesc2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDesc2.Location = New System.Drawing.Point(176, 115)
        Me.txtProductDesc2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductDesc2.Name = "txtProductDesc2"
        Me.txtProductDesc2.Size = New System.Drawing.Size(579, 27)
        Me.txtProductDesc2.TabIndex = 40
        '
        'lblProductDesc2
        '
        Me.lblProductDesc2.AutoSize = True
        Me.lblProductDesc2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDesc2.Location = New System.Drawing.Point(20, 118)
        Me.lblProductDesc2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductDesc2.Name = "lblProductDesc2"
        Me.lblProductDesc2.Size = New System.Drawing.Size(148, 19)
        Me.lblProductDesc2.TabIndex = 41
        Me.lblProductDesc2.Text = "Product Description 2"
        '
        'txtSetWeight
        '
        Me.txtSetWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetWeight.Location = New System.Drawing.Point(175, 153)
        Me.txtSetWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSetWeight.Name = "txtSetWeight"
        Me.txtSetWeight.Size = New System.Drawing.Size(203, 27)
        Me.txtSetWeight.TabIndex = 38
        '
        'lblSetWeight
        '
        Me.lblSetWeight.AutoSize = True
        Me.lblSetWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetWeight.Location = New System.Drawing.Point(89, 156)
        Me.lblSetWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSetWeight.Name = "lblSetWeight"
        Me.lblSetWeight.Size = New System.Drawing.Size(79, 19)
        Me.lblSetWeight.TabIndex = 39
        Me.lblSetWeight.Text = "Set Weight"
        '
        'txtProductGrade
        '
        Me.txtProductGrade.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductGrade.Location = New System.Drawing.Point(175, 191)
        Me.txtProductGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductGrade.Name = "txtProductGrade"
        Me.txtProductGrade.Size = New System.Drawing.Size(203, 27)
        Me.txtProductGrade.TabIndex = 36
        '
        'lblProductGrade
        '
        Me.lblProductGrade.AutoSize = True
        Me.lblProductGrade.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductGrade.Location = New System.Drawing.Point(67, 194)
        Me.lblProductGrade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductGrade.Name = "lblProductGrade"
        Me.lblProductGrade.Size = New System.Drawing.Size(101, 19)
        Me.lblProductGrade.TabIndex = 37
        Me.lblProductGrade.Text = "Product Grade"
        '
        'txtProductTare
        '
        Me.txtProductTare.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductTare.Location = New System.Drawing.Point(175, 229)
        Me.txtProductTare.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductTare.Name = "txtProductTare"
        Me.txtProductTare.Size = New System.Drawing.Size(203, 27)
        Me.txtProductTare.TabIndex = 34
        '
        'lblProductTare
        '
        Me.lblProductTare.AutoSize = True
        Me.lblProductTare.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductTare.Location = New System.Drawing.Point(78, 232)
        Me.lblProductTare.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductTare.Name = "lblProductTare"
        Me.lblProductTare.Size = New System.Drawing.Size(90, 19)
        Me.lblProductTare.TabIndex = 35
        Me.lblProductTare.Text = "Product Tare"
        '
        'txtProductTare2
        '
        Me.txtProductTare2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductTare2.Location = New System.Drawing.Point(552, 229)
        Me.txtProductTare2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductTare2.Name = "txtProductTare2"
        Me.txtProductTare2.Size = New System.Drawing.Size(203, 27)
        Me.txtProductTare2.TabIndex = 32
        '
        'lblProductTare2
        '
        Me.lblProductTare2.AutoSize = True
        Me.lblProductTare2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductTare2.Location = New System.Drawing.Point(443, 232)
        Me.lblProductTare2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductTare2.Name = "lblProductTare2"
        Me.lblProductTare2.Size = New System.Drawing.Size(102, 19)
        Me.lblProductTare2.TabIndex = 33
        Me.lblProductTare2.Text = "Product Tare 2"
        '
        'txtKickoutCount
        '
        Me.txtKickoutCount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKickoutCount.Location = New System.Drawing.Point(175, 343)
        Me.txtKickoutCount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKickoutCount.Name = "txtKickoutCount"
        Me.txtKickoutCount.Size = New System.Drawing.Size(203, 27)
        Me.txtKickoutCount.TabIndex = 30
        '
        'lblKickoutCount
        '
        Me.lblKickoutCount.AutoSize = True
        Me.lblKickoutCount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKickoutCount.Location = New System.Drawing.Point(71, 346)
        Me.lblKickoutCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKickoutCount.Name = "lblKickoutCount"
        Me.lblKickoutCount.Size = New System.Drawing.Size(97, 19)
        Me.lblKickoutCount.TabIndex = 31
        Me.lblKickoutCount.Text = "Kickout Count"
        '
        'txtMinWeight
        '
        Me.txtMinWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinWeight.Location = New System.Drawing.Point(175, 267)
        Me.txtMinWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMinWeight.Name = "txtMinWeight"
        Me.txtMinWeight.Size = New System.Drawing.Size(203, 27)
        Me.txtMinWeight.TabIndex = 28
        '
        'lblMinWeight
        '
        Me.lblMinWeight.AutoSize = True
        Me.lblMinWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinWeight.Location = New System.Drawing.Point(84, 270)
        Me.lblMinWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinWeight.Name = "lblMinWeight"
        Me.lblMinWeight.Size = New System.Drawing.Size(84, 19)
        Me.lblMinWeight.TabIndex = 29
        Me.lblMinWeight.Text = "Min Weight"
        '
        'txtMaxWeight
        '
        Me.txtMaxWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxWeight.Location = New System.Drawing.Point(552, 267)
        Me.txtMaxWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaxWeight.Name = "txtMaxWeight"
        Me.txtMaxWeight.Size = New System.Drawing.Size(203, 27)
        Me.txtMaxWeight.TabIndex = 26
        '
        'lblMaxWeight
        '
        Me.lblMaxWeight.AutoSize = True
        Me.lblMaxWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxWeight.Location = New System.Drawing.Point(458, 270)
        Me.lblMaxWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxWeight.Name = "lblMaxWeight"
        Me.lblMaxWeight.Size = New System.Drawing.Size(87, 19)
        Me.lblMaxWeight.TabIndex = 27
        Me.lblMaxWeight.Text = "Max Weight"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(780, 30)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(204, 53)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1037, 30)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(180, 53)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoAddNew)
        Me.GroupBox3.Controls.Add(Me.rdoUpdate)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(395, 84)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'rdoAddNew
        '
        Me.rdoAddNew.AutoSize = True
        Me.rdoAddNew.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAddNew.Location = New System.Drawing.Point(197, 26)
        Me.rdoAddNew.Name = "rdoAddNew"
        Me.rdoAddNew.Size = New System.Drawing.Size(132, 37)
        Me.rdoAddNew.TabIndex = 1
        Me.rdoAddNew.TabStop = True
        Me.rdoAddNew.Text = "Add New"
        Me.rdoAddNew.UseVisualStyleBackColor = True
        '
        'rdoUpdate
        '
        Me.rdoUpdate.AutoSize = True
        Me.rdoUpdate.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoUpdate.Location = New System.Drawing.Point(49, 26)
        Me.rdoUpdate.Name = "rdoUpdate"
        Me.rdoUpdate.Size = New System.Drawing.Size(113, 37)
        Me.rdoUpdate.TabIndex = 0
        Me.rdoUpdate.TabStop = True
        Me.rdoUpdate.Text = "Update"
        Me.rdoUpdate.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(527, 30)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(204, 53)
        Me.btnAddNew.TabIndex = 7
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'cmbScaleType
        '
        Me.cmbScaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbScaleType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbScaleType.FormattingEnabled = True
        Me.cmbScaleType.Location = New System.Drawing.Point(175, 42)
        Me.cmbScaleType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbScaleType.Name = "cmbScaleType"
        Me.cmbScaleType.Size = New System.Drawing.Size(203, 27)
        Me.cmbScaleType.TabIndex = 72
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 710)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grbSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "Small Scales Info Updater"
        Me.grbSearch.ResumeLayout(False)
        Me.grbSearch.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstSearchResults As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchText As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grbSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtItemCountPerBox As TextBox
    Friend WithEvents lblItemCountPerBox As Label
    Friend WithEvents txtItemTareEach As TextBox
    Friend WithEvents lblItemTareEach As Label
    Friend WithEvents txtLot As TextBox
    Friend WithEvents lblLot As Label
    Friend WithEvents txtProductType As TextBox
    Friend WithEvents lblProductType As Label
    Friend WithEvents txtAlphaDesc As TextBox
    Friend WithEvents lblAlphaDesc As Label
    Friend WithEvents txtTestingDesc As TextBox
    Friend WithEvents lblTestingDesc As Label
    Friend WithEvents txtLabel As TextBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents txtPricePerLb As TextBox
    Friend WithEvents lblPricePerLb As Label
    Friend WithEvents txtSellByDate As TextBox
    Friend WithEvents lblSellByDate As Label
    Friend WithEvents txtKillDate As TextBox
    Friend WithEvents lblKillDate As Label
    Friend WithEvents txtDiscPerLb As TextBox
    Friend WithEvents lblDiscPerLb As Label
    Friend WithEvents lblScaleType As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents lblProductCode As Label
    Friend WithEvents txtProductDesc As TextBox
    Friend WithEvents lblProductDesc As Label
    Friend WithEvents txtProductDesc2 As TextBox
    Friend WithEvents lblProductDesc2 As Label
    Friend WithEvents txtSetWeight As TextBox
    Friend WithEvents lblSetWeight As Label
    Friend WithEvents txtProductGrade As TextBox
    Friend WithEvents lblProductGrade As Label
    Friend WithEvents txtProductTare As TextBox
    Friend WithEvents lblProductTare As Label
    Friend WithEvents txtProductTare2 As TextBox
    Friend WithEvents lblProductTare2 As Label
    Friend WithEvents txtKickoutCount As TextBox
    Friend WithEvents lblKickoutCount As Label
    Friend WithEvents txtMinWeight As TextBox
    Friend WithEvents lblMinWeight As Label
    Friend WithEvents txtMaxWeight As TextBox
    Friend WithEvents lblMaxWeight As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNormalWeight As TextBox
    Friend WithEvents lblNormalWeight As Label
    Friend WithEvents lblScaleSearch As Label
    Friend WithEvents cmbScaleOptions As ComboBox
    Friend WithEvents lblUUID As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdoAddNew As RadioButton
    Friend WithEvents rdoUpdate As RadioButton
    Friend WithEvents btnAddNew As Button
    Friend WithEvents cmbScaleType As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.components = New System.ComponentModel.Container()
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim Date_OrderedLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.ComboBoxPayment = New System.Windows.Forms.ComboBox()
        Me.TudungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventorySystemDatabase2DataSet = New InventorySystemProject.InventorySystemDatabase2DataSet()
        Me.LabelMethodOfPayment = New System.Windows.Forms.Label()
        Me.ComboBoxOrderMade = New System.Windows.Forms.ComboBox()
        Me.LabelOrderMade = New System.Windows.Forms.Label()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxTudung = New System.Windows.Forms.GroupBox()
        Me.ListBoxTudung = New System.Windows.Forms.ListBox()
        Me.GroupBoxColor = New System.Windows.Forms.GroupBox()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.GroupBoxQuantity = New System.Windows.Forms.GroupBox()
        Me.ComboBoxQuantity = New System.Windows.Forms.ComboBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonAddMore = New System.Windows.Forms.Button()
        Me.ButtonUpdateData = New System.Windows.Forms.Button()
        Me.TudungTableAdapter = New InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TudungTableAdapter()
        Me.TableAdapterManager = New InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TableAdapterManager()
        Me.TudungBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TudungBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TudungDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_OrderedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TudungTableAdapter1 = New InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TudungTableAdapter()
        Me.TableAdapterManager1 = New InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TableAdapterManager()
        Me.TudungTableAdapter2 = New InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TudungTableAdapter()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.TitleColorDialog = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Surname2ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SurnameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SurnameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Surname2ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        SurnameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Date_OrderedLabel = New System.Windows.Forms.Label()
        CType(Me.TudungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventorySystemDatabase2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBoxTudung.SuspendLayout()
        Me.GroupBoxColor.SuspendLayout()
        Me.GroupBoxQuantity.SuspendLayout()
        CType(Me.TudungBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TudungBindingNavigator.SuspendLayout()
        CType(Me.TudungDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Surname2ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(404, 135)
        SurnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(69, 17)
        SurnameLabel.TabIndex = 61
        SurnameLabel.Text = "Surname:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(218, 136)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(80, 17)
        First_NameLabel.TabIndex = 59
        First_NameLabel.Text = "First Name:"
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Location = New System.Drawing.Point(13, 138)
        Customer_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(89, 17)
        Customer_IDLabel.TabIndex = 58
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Date_OrderedLabel
        '
        Date_OrderedLabel.AutoSize = True
        Date_OrderedLabel.Location = New System.Drawing.Point(376, 182)
        Date_OrderedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Date_OrderedLabel.Name = "Date_OrderedLabel"
        Date_OrderedLabel.Size = New System.Drawing.Size(99, 17)
        Date_OrderedLabel.TabIndex = 71
        Date_OrderedLabel.Text = "Date Ordered:"
        '
        'ComboBoxPayment
        '
        Me.ComboBoxPayment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TudungBindingSource, "Payment Method", True))
        Me.ComboBoxPayment.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TudungBindingSource, "Payment Method", True))
        Me.ComboBoxPayment.FormattingEnabled = True
        Me.ComboBoxPayment.Location = New System.Drawing.Point(906, 139)
        Me.ComboBoxPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxPayment.Name = "ComboBoxPayment"
        Me.ComboBoxPayment.Size = New System.Drawing.Size(104, 25)
        Me.ComboBoxPayment.TabIndex = 69
        Me.ComboBoxPayment.Text = "Select Type"
        '
        'TudungBindingSource
        '
        Me.TudungBindingSource.DataMember = "Tudung"
        Me.TudungBindingSource.DataSource = Me.InventorySystemDatabase2DataSet
        '
        'InventorySystemDatabase2DataSet
        '
        Me.InventorySystemDatabase2DataSet.DataSetName = "InventorySystemDatabase2DataSet"
        Me.InventorySystemDatabase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelMethodOfPayment
        '
        Me.LabelMethodOfPayment.AutoSize = True
        Me.LabelMethodOfPayment.Location = New System.Drawing.Point(797, 139)
        Me.LabelMethodOfPayment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMethodOfPayment.Name = "LabelMethodOfPayment"
        Me.LabelMethodOfPayment.Size = New System.Drawing.Size(138, 17)
        Me.LabelMethodOfPayment.TabIndex = 68
        Me.LabelMethodOfPayment.Text = "Method of Payment: "
        '
        'ComboBoxOrderMade
        '
        Me.ComboBoxOrderMade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TudungBindingSource, "Order Made", True))
        Me.ComboBoxOrderMade.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TudungBindingSource, "Order Made", True))
        Me.ComboBoxOrderMade.FormattingEnabled = True
        Me.ComboBoxOrderMade.Location = New System.Drawing.Point(680, 135)
        Me.ComboBoxOrderMade.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxOrderMade.Name = "ComboBoxOrderMade"
        Me.ComboBoxOrderMade.Size = New System.Drawing.Size(100, 25)
        Me.ComboBoxOrderMade.TabIndex = 67
        Me.ComboBoxOrderMade.Text = "Select Course"
        '
        'LabelOrderMade
        '
        Me.LabelOrderMade.AutoSize = True
        Me.LabelOrderMade.Location = New System.Drawing.Point(599, 137)
        Me.LabelOrderMade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelOrderMade.Name = "LabelOrderMade"
        Me.LabelOrderMade.Size = New System.Drawing.Size(92, 17)
        Me.LabelOrderMade.TabIndex = 66
        Me.LabelOrderMade.Text = "Order Made: "
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TudungBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(460, 132)
        Me.SurnameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(120, 24)
        Me.SurnameTextBox.TabIndex = 63
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TudungBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(283, 133)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(109, 24)
        Me.First_NameTextBox.TabIndex = 62
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TudungBindingSource, "Customer ID", True))
        Me.Customer_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(84, 136)
        Me.Customer_IDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(117, 24)
        Me.Customer_IDTextBox.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.ButtonCalculate)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBoxTudung)
        Me.Panel1.Controls.Add(Me.GroupBoxColor)
        Me.Panel1.Controls.Add(Me.GroupBoxQuantity)
        Me.Panel1.Location = New System.Drawing.Point(268, 200)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 208)
        Me.Panel1.TabIndex = 70
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalculate.Location = New System.Drawing.Point(389, 170)
        Me.ButtonCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(96, 28)
        Me.ButtonCalculate.TabIndex = 3
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.LabelPrice)
        Me.Panel2.Controls.Add(Me.PriceTextBox)
        Me.Panel2.Location = New System.Drawing.Point(192, 157)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 31)
        Me.Panel2.TabIndex = 2
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Location = New System.Drawing.Point(2, 3)
        Me.LabelPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(76, 17)
        Me.LabelPrice.TabIndex = 0
        Me.LabelPrice.Text = "Total Price"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TudungBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(68, 3)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(76, 23)
        Me.PriceTextBox.TabIndex = 73
        '
        'GroupBoxTudung
        '
        Me.GroupBoxTudung.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBoxTudung.Controls.Add(Me.ListBoxTudung)
        Me.GroupBoxTudung.Location = New System.Drawing.Point(10, 14)
        Me.GroupBoxTudung.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxTudung.Name = "GroupBoxTudung"
        Me.GroupBoxTudung.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxTudung.Size = New System.Drawing.Size(119, 160)
        Me.GroupBoxTudung.TabIndex = 1
        Me.GroupBoxTudung.TabStop = False
        Me.GroupBoxTudung.Text = "Tudung"
        '
        'ListBoxTudung
        '
        Me.ListBoxTudung.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TudungBindingSource, "Type of Scarf", True))
        Me.ListBoxTudung.FormattingEnabled = True
        Me.ListBoxTudung.ItemHeight = 17
        Me.ListBoxTudung.Location = New System.Drawing.Point(5, 18)
        Me.ListBoxTudung.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxTudung.Name = "ListBoxTudung"
        Me.ListBoxTudung.Size = New System.Drawing.Size(110, 123)
        Me.ListBoxTudung.TabIndex = 0
        '
        'GroupBoxColor
        '
        Me.GroupBoxColor.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBoxColor.Controls.Add(Me.ComboBoxColor)
        Me.GroupBoxColor.Location = New System.Drawing.Point(191, 14)
        Me.GroupBoxColor.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxColor.Name = "GroupBoxColor"
        Me.GroupBoxColor.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxColor.Size = New System.Drawing.Size(170, 51)
        Me.GroupBoxColor.TabIndex = 0
        Me.GroupBoxColor.TabStop = False
        Me.GroupBoxColor.Text = "Color"
        '
        'ComboBoxColor
        '
        Me.ComboBoxColor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TudungBindingSource, "Colour", True))
        Me.ComboBoxColor.FormattingEnabled = True
        Me.ComboBoxColor.Location = New System.Drawing.Point(52, 17)
        Me.ComboBoxColor.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxColor.Name = "ComboBoxColor"
        Me.ComboBoxColor.Size = New System.Drawing.Size(92, 25)
        Me.ComboBoxColor.TabIndex = 72
        Me.ComboBoxColor.Text = "Select Color"
        '
        'GroupBoxQuantity
        '
        Me.GroupBoxQuantity.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBoxQuantity.Controls.Add(Me.ComboBoxQuantity)
        Me.GroupBoxQuantity.Location = New System.Drawing.Point(191, 91)
        Me.GroupBoxQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxQuantity.Name = "GroupBoxQuantity"
        Me.GroupBoxQuantity.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxQuantity.Size = New System.Drawing.Size(170, 48)
        Me.GroupBoxQuantity.TabIndex = 1
        Me.GroupBoxQuantity.TabStop = False
        Me.GroupBoxQuantity.Text = "Quantity"
        '
        'ComboBoxQuantity
        '
        Me.ComboBoxQuantity.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TudungBindingSource, "Quantity", True))
        Me.ComboBoxQuantity.FormattingEnabled = True
        Me.ComboBoxQuantity.Location = New System.Drawing.Point(52, 17)
        Me.ComboBoxQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxQuantity.Name = "ComboBoxQuantity"
        Me.ComboBoxQuantity.Size = New System.Drawing.Size(107, 25)
        Me.ComboBoxQuantity.TabIndex = 0
        Me.ComboBoxQuantity.Text = "Select Quantity"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(283, 680)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(66, 28)
        Me.ButtonDelete.TabIndex = 51
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(715, 680)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(58, 28)
        Me.ButtonExit.TabIndex = 50
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(387, 680)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(58, 28)
        Me.ButtonClear.TabIndex = 49
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonAddMore
        '
        Me.ButtonAddMore.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddMore.Location = New System.Drawing.Point(484, 680)
        Me.ButtonAddMore.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAddMore.Name = "ButtonAddMore"
        Me.ButtonAddMore.Size = New System.Drawing.Size(76, 28)
        Me.ButtonAddMore.TabIndex = 48
        Me.ButtonAddMore.Text = "Add More"
        Me.ButtonAddMore.UseVisualStyleBackColor = True
        '
        'ButtonUpdateData
        '
        Me.ButtonUpdateData.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdateData.Location = New System.Drawing.Point(599, 680)
        Me.ButtonUpdateData.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonUpdateData.Name = "ButtonUpdateData"
        Me.ButtonUpdateData.Size = New System.Drawing.Size(77, 28)
        Me.ButtonUpdateData.TabIndex = 47
        Me.ButtonUpdateData.Text = "Update Data"
        Me.ButtonUpdateData.UseVisualStyleBackColor = True
        '
        'TudungTableAdapter
        '
        Me.TudungTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TudungTableAdapter = Me.TudungTableAdapter
        Me.TableAdapterManager.UpdateOrder = InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TudungBindingNavigator
        '
        Me.TudungBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TudungBindingNavigator.BindingSource = Me.TudungBindingSource
        Me.TudungBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TudungBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TudungBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TudungBindingNavigatorSaveItem})
        Me.TudungBindingNavigator.Location = New System.Drawing.Point(0, 28)
        Me.TudungBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TudungBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TudungBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TudungBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TudungBindingNavigator.Name = "TudungBindingNavigator"
        Me.TudungBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TudungBindingNavigator.Size = New System.Drawing.Size(1051, 25)
        Me.TudungBindingNavigator.TabIndex = 71
        Me.TudungBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TudungBindingNavigatorSaveItem
        '
        Me.TudungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TudungBindingNavigatorSaveItem.Image = CType(resources.GetObject("TudungBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TudungBindingNavigatorSaveItem.Name = "TudungBindingNavigatorSaveItem"
        Me.TudungBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TudungBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TudungDataGridView
        '
        Me.TudungDataGridView.AutoGenerateColumns = False
        Me.TudungDataGridView.BackgroundColor = System.Drawing.Color.Ivory
        Me.TudungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TudungDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TudungDataGridView.DataSource = Me.TudungBindingSource
        Me.TudungDataGridView.Location = New System.Drawing.Point(11, 470)
        Me.TudungDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.TudungDataGridView.Name = "TudungDataGridView"
        Me.TudungDataGridView.RowTemplate.Height = 24
        Me.TudungDataGridView.Size = New System.Drawing.Size(1029, 179)
        Me.TudungDataGridView.TabIndex = 71
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Type of Scarf"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type of Scarf"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Colour"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Colour"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Order Made"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Order Made"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Date Ordered"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Date Ordered"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Payment Method"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Payment Method"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Date_OrderedDateTimePicker
        '
        Me.Date_OrderedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TudungBindingSource, "Date Ordered", True))
        Me.Date_OrderedDateTimePicker.Location = New System.Drawing.Point(460, 176)
        Me.Date_OrderedDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.Date_OrderedDateTimePicker.Name = "Date_OrderedDateTimePicker"
        Me.Date_OrderedDateTimePicker.Size = New System.Drawing.Size(151, 23)
        Me.Date_OrderedDateTimePicker.TabIndex = 72
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'TudungTableAdapter1
        '
        Me.TudungTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.TudungTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TudungTableAdapter2
        '
        Me.TudungTableAdapter2.ClearBeforeFill = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(379, 62)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(429, 54)
        Me.LabelTitle.TabIndex = 77
        Me.LabelTitle.Text = "Scarf Inventory System"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1051, 28)
        Me.MenuStrip1.TabIndex = 78
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Surname2ToolStrip
        '
        Me.Surname2ToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.Surname2ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Surname2ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SurnameToolStripLabel, Me.SurnameToolStripTextBox, Me.Surname2ToolStripButton, Me.ToolStripButton1})
        Me.Surname2ToolStrip.Location = New System.Drawing.Point(407, 438)
        Me.Surname2ToolStrip.Name = "Surname2ToolStrip"
        Me.Surname2ToolStrip.Size = New System.Drawing.Size(242, 27)
        Me.Surname2ToolStrip.TabIndex = 79
        Me.Surname2ToolStrip.Text = "Surname2ToolStrip"
        '
        'SurnameToolStripLabel
        '
        Me.SurnameToolStripLabel.BackColor = System.Drawing.Color.Transparent
        Me.SurnameToolStripLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameToolStripLabel.Name = "SurnameToolStripLabel"
        Me.SurnameToolStripLabel.Size = New System.Drawing.Size(82, 24)
        Me.SurnameToolStripLabel.Text = "Surname:"
        '
        'SurnameToolStripTextBox
        '
        Me.SurnameToolStripTextBox.Name = "SurnameToolStripTextBox"
        Me.SurnameToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'Surname2ToolStripButton
        '
        Me.Surname2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Surname2ToolStripButton.Name = "Surname2ToolStripButton"
        Me.Surname2ToolStripButton.Size = New System.Drawing.Size(23, 24)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 422)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Type surname to search"
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Palatino Linotype", 10.2!)
        Me.BtnFirst.Location = New System.Drawing.Point(55, 680)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(75, 28)
        Me.BtnFirst.TabIndex = 81
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Palatino Linotype", 10.2!)
        Me.BtnLast.Location = New System.Drawing.Point(169, 680)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(75, 28)
        Me.BtnLast.TabIndex = 82
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Palatino Linotype", 10.2!)
        Me.BtnNext.Location = New System.Drawing.Point(812, 680)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 27)
        Me.BtnNext.TabIndex = 83
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Palatino Linotype", 10.2!)
        Me.BtnPrev.Location = New System.Drawing.Point(926, 680)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(75, 27)
        Me.BtnPrev.TabIndex = 84
        Me.BtnPrev.Text = "Previous"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1051, 741)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Surname2ToolStrip)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Date_OrderedLabel)
        Me.Controls.Add(Me.Date_OrderedDateTimePicker)
        Me.Controls.Add(Me.TudungDataGridView)
        Me.Controls.Add(Me.TudungBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ComboBoxPayment)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.LabelMethodOfPayment)
        Me.Controls.Add(Me.ButtonAddMore)
        Me.Controls.Add(Me.ButtonUpdateData)
        Me.Controls.Add(Me.ComboBoxOrderMade)
        Me.Controls.Add(Me.LabelOrderMade)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Me.Customer_IDTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.TudungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventorySystemDatabase2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBoxTudung.ResumeLayout(False)
        Me.GroupBoxColor.ResumeLayout(False)
        Me.GroupBoxQuantity.ResumeLayout(False)
        CType(Me.TudungBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TudungBindingNavigator.ResumeLayout(False)
        Me.TudungBindingNavigator.PerformLayout()
        CType(Me.TudungDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Surname2ToolStrip.ResumeLayout(False)
        Me.Surname2ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxPayment As System.Windows.Forms.ComboBox
    Friend WithEvents LabelMethodOfPayment As System.Windows.Forms.Label
    Friend WithEvents ComboBoxOrderMade As System.Windows.Forms.ComboBox
    Friend WithEvents LabelOrderMade As System.Windows.Forms.Label
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxTudung As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxTudung As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxQuantity As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxColor As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonAddMore As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdateData As System.Windows.Forms.Button
    Friend WithEvents InventorySystemDatabase2DataSet As InventorySystemProject.InventorySystemDatabase2DataSet
    Friend WithEvents TudungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TudungTableAdapter As InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TudungTableAdapter
    Friend WithEvents TableAdapterManager As InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TudungBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TudungBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TudungDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxColor As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxQuantity As System.Windows.Forms.ComboBox
    Friend WithEvents Date_OrderedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelPrice As System.Windows.Forms.Label
    Friend WithEvents ButtonCalculate As System.Windows.Forms.Button
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TudungTableAdapter1 As InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TudungTableAdapter
    Friend WithEvents TableAdapterManager1 As InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TudungTableAdapter2 As InventorySystemProject.InventorySystemDatabase2DataSetTableAdapters.TudungTableAdapter
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents TitleColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Surname2ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents SurnameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SurnameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Surname2ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class

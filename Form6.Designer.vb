<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim Medicine_NameLabel As System.Windows.Forms.Label
        Dim Medine_TypeLabel As System.Windows.Forms.Label
        Dim Doctor_NameLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Expiry_DateLabel As System.Windows.Forms.Label
        Dim PrescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Pharmaplus_Hospital_Database_System1DataSet = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSet()
        Me.MEDICINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICINETableAdapter = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.MEDICINETableAdapter()
        Me.TableAdapterManager = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager()
        Me.MEDICINEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Medicine_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Medine_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Expiry_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.MEDICINEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSaveData = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.MEDICINEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Medicine_NameLabel = New System.Windows.Forms.Label()
        Medine_TypeLabel = New System.Windows.Forms.Label()
        Doctor_NameLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        Expiry_DateLabel = New System.Windows.Forms.Label()
        PrescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICINEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MEDICINEBindingNavigator.SuspendLayout()
        CType(Me.MEDICINEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Medicine_NameLabel
        '
        Medicine_NameLabel.AutoSize = True
        Medicine_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medicine_NameLabel.Location = New System.Drawing.Point(66, 64)
        Medicine_NameLabel.Name = "Medicine_NameLabel"
        Medicine_NameLabel.Size = New System.Drawing.Size(129, 18)
        Medicine_NameLabel.TabIndex = 1
        Medicine_NameLabel.Text = "Medicine Name:"
        '
        'Medine_TypeLabel
        '
        Medine_TypeLabel.AutoSize = True
        Medine_TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medine_TypeLabel.Location = New System.Drawing.Point(66, 89)
        Medine_TypeLabel.Name = "Medine_TypeLabel"
        Medine_TypeLabel.Size = New System.Drawing.Size(108, 18)
        Medine_TypeLabel.TabIndex = 3
        Medine_TypeLabel.Text = "Medine Type:"
        '
        'Doctor_NameLabel
        '
        Doctor_NameLabel.AutoSize = True
        Doctor_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_NameLabel.Location = New System.Drawing.Point(66, 115)
        Doctor_NameLabel.Name = "Doctor_NameLabel"
        Doctor_NameLabel.Size = New System.Drawing.Size(114, 18)
        Doctor_NameLabel.TabIndex = 5
        Doctor_NameLabel.Text = "Doctor Name:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.Location = New System.Drawing.Point(66, 141)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(70, 18)
        AmountLabel.TabIndex = 7
        AmountLabel.Text = "Amount:"
        '
        'Expiry_DateLabel
        '
        Expiry_DateLabel.AutoSize = True
        Expiry_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Expiry_DateLabel.Location = New System.Drawing.Point(66, 168)
        Expiry_DateLabel.Name = "Expiry_DateLabel"
        Expiry_DateLabel.Size = New System.Drawing.Size(99, 18)
        Expiry_DateLabel.TabIndex = 9
        Expiry_DateLabel.Text = "Expiry Date:"
        '
        'PrescriptionLabel
        '
        PrescriptionLabel.AutoSize = True
        PrescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrescriptionLabel.Location = New System.Drawing.Point(66, 193)
        PrescriptionLabel.Name = "PrescriptionLabel"
        PrescriptionLabel.Size = New System.Drawing.Size(104, 18)
        PrescriptionLabel.TabIndex = 11
        PrescriptionLabel.Text = "Prescription:"
        '
        'Pharmaplus_Hospital_Database_System1DataSet
        '
        Me.Pharmaplus_Hospital_Database_System1DataSet.DataSetName = "Pharmaplus_Hospital_Database_System1DataSet"
        Me.Pharmaplus_Hospital_Database_System1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICINEBindingSource
        '
        Me.MEDICINEBindingSource.DataMember = "MEDICINE"
        Me.MEDICINEBindingSource.DataSource = Me.Pharmaplus_Hospital_Database_System1DataSet
        '
        'MEDICINETableAdapter
        '
        Me.MEDICINETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APPOINTMENTTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BILLINGTableAdapter = Nothing
        Me.TableAdapterManager.DISCHARGETableAdapter = Nothing
        Me.TableAdapterManager.DOCTORTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Me.MEDICINETableAdapter
        Me.TableAdapterManager.PATIENTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MEDICINEBindingNavigator
        '
        Me.MEDICINEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MEDICINEBindingNavigator.BindingSource = Me.MEDICINEBindingSource
        Me.MEDICINEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MEDICINEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MEDICINEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MEDICINEBindingNavigatorSaveItem})
        Me.MEDICINEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MEDICINEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MEDICINEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MEDICINEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MEDICINEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MEDICINEBindingNavigator.Name = "MEDICINEBindingNavigator"
        Me.MEDICINEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MEDICINEBindingNavigator.Size = New System.Drawing.Size(897, 25)
        Me.MEDICINEBindingNavigator.TabIndex = 0
        Me.MEDICINEBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Medicine_NameTextBox
        '
        Me.Medicine_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "Medicine Name", True))
        Me.Medicine_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medicine_NameTextBox.Location = New System.Drawing.Point(220, 64)
        Me.Medicine_NameTextBox.Name = "Medicine_NameTextBox"
        Me.Medicine_NameTextBox.Size = New System.Drawing.Size(293, 24)
        Me.Medicine_NameTextBox.TabIndex = 2
        '
        'Medine_TypeTextBox
        '
        Me.Medine_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "Medine Type", True))
        Me.Medine_TypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medine_TypeTextBox.Location = New System.Drawing.Point(220, 90)
        Me.Medine_TypeTextBox.Name = "Medine_TypeTextBox"
        Me.Medine_TypeTextBox.Size = New System.Drawing.Size(293, 24)
        Me.Medine_TypeTextBox.TabIndex = 4
        '
        'Doctor_NameTextBox
        '
        Me.Doctor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "Doctor Name", True))
        Me.Doctor_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_NameTextBox.Location = New System.Drawing.Point(220, 116)
        Me.Doctor_NameTextBox.Name = "Doctor_NameTextBox"
        Me.Doctor_NameTextBox.Size = New System.Drawing.Size(293, 24)
        Me.Doctor_NameTextBox.TabIndex = 6
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "Amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(220, 142)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(293, 24)
        Me.AmountTextBox.TabIndex = 8
        '
        'Expiry_DateDateTimePicker
        '
        Me.Expiry_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MEDICINEBindingSource, "Expiry Date", True))
        Me.Expiry_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Expiry_DateDateTimePicker.Location = New System.Drawing.Point(220, 168)
        Me.Expiry_DateDateTimePicker.Name = "Expiry_DateDateTimePicker"
        Me.Expiry_DateDateTimePicker.Size = New System.Drawing.Size(293, 24)
        Me.Expiry_DateDateTimePicker.TabIndex = 10
        '
        'PrescriptionTextBox
        '
        Me.PrescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "Prescription", True))
        Me.PrescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrescriptionTextBox.Location = New System.Drawing.Point(220, 194)
        Me.PrescriptionTextBox.Name = "PrescriptionTextBox"
        Me.PrescriptionTextBox.Size = New System.Drawing.Size(293, 24)
        Me.PrescriptionTextBox.TabIndex = 12
        '
        'MEDICINEDataGridView
        '
        Me.MEDICINEDataGridView.AutoGenerateColumns = False
        Me.MEDICINEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MEDICINEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MEDICINEDataGridView.DataSource = Me.MEDICINEBindingSource
        Me.MEDICINEDataGridView.Location = New System.Drawing.Point(21, 371)
        Me.MEDICINEDataGridView.Name = "MEDICINEDataGridView"
        Me.MEDICINEDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.MEDICINEDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Medicine Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Medicine Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Medine Type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Medine Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Doctor Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Doctor Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Expiry Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Expiry Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Prescription"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Prescription"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnSaveData)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnPrevious)
        Me.Panel1.Controls.Add(Me.BtnNext)
        Me.Panel1.Controls.Add(Me.BtnAddNew)
        Me.Panel1.Location = New System.Drawing.Point(530, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 269)
        Me.Panel1.TabIndex = 14
        '
        'BtnSaveData
        '
        Me.BtnSaveData.BackColor = System.Drawing.Color.Black
        Me.BtnSaveData.ForeColor = System.Drawing.Color.White
        Me.BtnSaveData.Location = New System.Drawing.Point(63, 6)
        Me.BtnSaveData.Name = "BtnSaveData"
        Me.BtnSaveData.Size = New System.Drawing.Size(164, 33)
        Me.BtnSaveData.TabIndex = 13
        Me.BtnSaveData.Text = "Save Data"
        Me.BtnSaveData.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Black
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(63, 217)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(164, 33)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Black
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(63, 178)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(164, 33)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.Black
        Me.BtnPrevious.ForeColor = System.Drawing.Color.White
        Me.BtnPrevious.Location = New System.Drawing.Point(63, 139)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(164, 33)
        Me.BtnPrevious.TabIndex = 10
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Black
        Me.BtnNext.ForeColor = System.Drawing.Color.White
        Me.BtnNext.Location = New System.Drawing.Point(63, 98)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(164, 33)
        Me.BtnNext.TabIndex = 11
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackColor = System.Drawing.Color.Black
        Me.BtnAddNew.ForeColor = System.Drawing.Color.White
        Me.BtnAddNew.Location = New System.Drawing.Point(63, 54)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(164, 33)
        Me.BtnAddNew.TabIndex = 12
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.UseVisualStyleBackColor = False
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
        'MEDICINEBindingNavigatorSaveItem
        '
        Me.MEDICINEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MEDICINEBindingNavigatorSaveItem.Image = CType(resources.GetObject("MEDICINEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MEDICINEBindingNavigatorSaveItem.Name = "MEDICINEBindingNavigatorSaveItem"
        Me.MEDICINEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MEDICINEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(897, 589)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MEDICINEDataGridView)
        Me.Controls.Add(Medicine_NameLabel)
        Me.Controls.Add(Me.Medicine_NameTextBox)
        Me.Controls.Add(Medine_TypeLabel)
        Me.Controls.Add(Me.Medine_TypeTextBox)
        Me.Controls.Add(Doctor_NameLabel)
        Me.Controls.Add(Me.Doctor_NameTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Expiry_DateLabel)
        Me.Controls.Add(Me.Expiry_DateDateTimePicker)
        Me.Controls.Add(PrescriptionLabel)
        Me.Controls.Add(Me.PrescriptionTextBox)
        Me.Controls.Add(Me.MEDICINEBindingNavigator)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine"
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICINEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MEDICINEBindingNavigator.ResumeLayout(False)
        Me.MEDICINEBindingNavigator.PerformLayout()
        CType(Me.MEDICINEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pharmaplus_Hospital_Database_System1DataSet As Pharmaplus_Hospital_Database_System1DataSet
    Friend WithEvents MEDICINEBindingSource As BindingSource
    Friend WithEvents MEDICINETableAdapter As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.MEDICINETableAdapter
    Friend WithEvents TableAdapterManager As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MEDICINEBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MEDICINEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Medicine_NameTextBox As TextBox
    Friend WithEvents Medine_TypeTextBox As TextBox
    Friend WithEvents Doctor_NameTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Expiry_DateDateTimePicker As DateTimePicker
    Friend WithEvents PrescriptionTextBox As TextBox
    Friend WithEvents MEDICINEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSaveData As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnAddNew As Button
End Class

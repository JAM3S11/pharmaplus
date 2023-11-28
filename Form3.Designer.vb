<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Patient_NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim Blood_GroupLabel As System.Windows.Forms.Label
        Dim Marital_StatusLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Room_NumberLabel As System.Windows.Forms.Label
        Dim Admin_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Pharmaplus_Hospital_Database_System1DataSet = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSet()
        Me.PATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTTableAdapter = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.PATIENTTableAdapter()
        Me.TableAdapterManager = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager()
        Me.PATIENTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.Blood_GroupTextBox = New System.Windows.Forms.TextBox()
        Me.Marital_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Room_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Admin_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PATIENTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnSaveData = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.PATIENTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Patient_NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        Blood_GroupLabel = New System.Windows.Forms.Label()
        Marital_StatusLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Room_NumberLabel = New System.Windows.Forms.Label()
        Admin_DateLabel = New System.Windows.Forms.Label()
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PATIENTBindingNavigator.SuspendLayout()
        CType(Me.PATIENTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Location = New System.Drawing.Point(85, 67)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(95, 20)
        Patient_IDLabel.TabIndex = 1
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_NameLabel
        '
        Patient_NameLabel.AutoSize = True
        Patient_NameLabel.Location = New System.Drawing.Point(85, 99)
        Patient_NameLabel.Name = "Patient_NameLabel"
        Patient_NameLabel.Size = New System.Drawing.Size(122, 20)
        Patient_NameLabel.TabIndex = 3
        Patient_NameLabel.Text = "Patient Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(85, 131)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(46, 20)
        AgeLabel.TabIndex = 5
        AgeLabel.Text = "Age:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(85, 163)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(44, 20)
        SexLabel.TabIndex = 7
        SexLabel.Text = "Sex:"
        '
        'Blood_GroupLabel
        '
        Blood_GroupLabel.AutoSize = True
        Blood_GroupLabel.Location = New System.Drawing.Point(85, 195)
        Blood_GroupLabel.Name = "Blood_GroupLabel"
        Blood_GroupLabel.Size = New System.Drawing.Size(115, 20)
        Blood_GroupLabel.TabIndex = 9
        Blood_GroupLabel.Text = "Blood Group:"
        '
        'Marital_StatusLabel
        '
        Marital_StatusLabel.AutoSize = True
        Marital_StatusLabel.Location = New System.Drawing.Point(85, 227)
        Marital_StatusLabel.Name = "Marital_StatusLabel"
        Marital_StatusLabel.Size = New System.Drawing.Size(126, 20)
        Marital_StatusLabel.TabIndex = 11
        Marital_StatusLabel.Text = "Marital Status:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(85, 259)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(132, 20)
        Phone_NumberLabel.TabIndex = 13
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Room_NumberLabel
        '
        Room_NumberLabel.AutoSize = True
        Room_NumberLabel.Location = New System.Drawing.Point(85, 291)
        Room_NumberLabel.Name = "Room_NumberLabel"
        Room_NumberLabel.Size = New System.Drawing.Size(128, 20)
        Room_NumberLabel.TabIndex = 15
        Room_NumberLabel.Text = "Room Number:"
        '
        'Admin_DateLabel
        '
        Admin_DateLabel.AutoSize = True
        Admin_DateLabel.Location = New System.Drawing.Point(85, 324)
        Admin_DateLabel.Name = "Admin_DateLabel"
        Admin_DateLabel.Size = New System.Drawing.Size(108, 20)
        Admin_DateLabel.TabIndex = 17
        Admin_DateLabel.Text = "Admin Date:"
        '
        'Pharmaplus_Hospital_Database_System1DataSet
        '
        Me.Pharmaplus_Hospital_Database_System1DataSet.DataSetName = "Pharmaplus_Hospital_Database_System1DataSet"
        Me.Pharmaplus_Hospital_Database_System1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PATIENTBindingSource
        '
        Me.PATIENTBindingSource.DataMember = "PATIENT"
        Me.PATIENTBindingSource.DataSource = Me.Pharmaplus_Hospital_Database_System1DataSet
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APPOINTMENTTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BILLINGTableAdapter = Nothing
        Me.TableAdapterManager.DISCHARGETableAdapter = Nothing
        Me.TableAdapterManager.DOCTORTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTableAdapter = Me.PATIENTTableAdapter
        Me.TableAdapterManager.UpdateOrder = Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PATIENTBindingNavigator
        '
        Me.PATIENTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PATIENTBindingNavigator.BindingSource = Me.PATIENTBindingSource
        Me.PATIENTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PATIENTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PATIENTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PATIENTBindingNavigatorSaveItem})
        Me.PATIENTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PATIENTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PATIENTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PATIENTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PATIENTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PATIENTBindingNavigator.Name = "PATIENTBindingNavigator"
        Me.PATIENTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PATIENTBindingNavigator.Size = New System.Drawing.Size(988, 25)
        Me.PATIENTBindingNavigator.TabIndex = 0
        Me.PATIENTBindingNavigator.Text = "BindingNavigator1"
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
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(223, 64)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(345, 26)
        Me.Patient_IDTextBox.TabIndex = 2
        '
        'Patient_NameTextBox
        '
        Me.Patient_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Patient Name", True))
        Me.Patient_NameTextBox.Location = New System.Drawing.Point(223, 96)
        Me.Patient_NameTextBox.Name = "Patient_NameTextBox"
        Me.Patient_NameTextBox.Size = New System.Drawing.Size(345, 26)
        Me.Patient_NameTextBox.TabIndex = 4
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(223, 128)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(345, 26)
        Me.AgeTextBox.TabIndex = 6
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(223, 160)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.ReadOnly = True
        Me.SexTextBox.Size = New System.Drawing.Size(165, 26)
        Me.SexTextBox.TabIndex = 8
        '
        'Blood_GroupTextBox
        '
        Me.Blood_GroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Blood Group", True))
        Me.Blood_GroupTextBox.Location = New System.Drawing.Point(223, 192)
        Me.Blood_GroupTextBox.Name = "Blood_GroupTextBox"
        Me.Blood_GroupTextBox.Size = New System.Drawing.Size(345, 26)
        Me.Blood_GroupTextBox.TabIndex = 10
        '
        'Marital_StatusTextBox
        '
        Me.Marital_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Marital Status", True))
        Me.Marital_StatusTextBox.Location = New System.Drawing.Point(223, 224)
        Me.Marital_StatusTextBox.Name = "Marital_StatusTextBox"
        Me.Marital_StatusTextBox.Size = New System.Drawing.Size(345, 26)
        Me.Marital_StatusTextBox.TabIndex = 12
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(223, 256)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(345, 26)
        Me.Phone_NumberTextBox.TabIndex = 14
        '
        'Room_NumberTextBox
        '
        Me.Room_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Room Number", True))
        Me.Room_NumberTextBox.Location = New System.Drawing.Point(223, 288)
        Me.Room_NumberTextBox.Name = "Room_NumberTextBox"
        Me.Room_NumberTextBox.Size = New System.Drawing.Size(345, 26)
        Me.Room_NumberTextBox.TabIndex = 16
        '
        'Admin_DateDateTimePicker
        '
        Me.Admin_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PATIENTBindingSource, "Admin Date", True))
        Me.Admin_DateDateTimePicker.Location = New System.Drawing.Point(223, 320)
        Me.Admin_DateDateTimePicker.Name = "Admin_DateDateTimePicker"
        Me.Admin_DateDateTimePicker.Size = New System.Drawing.Size(345, 26)
        Me.Admin_DateDateTimePicker.TabIndex = 18
        '
        'PATIENTDataGridView
        '
        Me.PATIENTDataGridView.AutoGenerateColumns = False
        Me.PATIENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PATIENTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PATIENTDataGridView.DataSource = Me.PATIENTBindingSource
        Me.PATIENTDataGridView.Location = New System.Drawing.Point(0, 424)
        Me.PATIENTDataGridView.Name = "PATIENTDataGridView"
        Me.PATIENTDataGridView.Size = New System.Drawing.Size(944, 220)
        Me.PATIENTDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Patient Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Patient Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Blood Group"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Blood Group"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Marital Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Marital Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Phone Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Room Number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Room Number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Admin Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Admin Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(394, 162)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(65, 24)
        Me.radMale.TabIndex = 20
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(482, 162)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(86, 24)
        Me.radFemale.TabIndex = 20
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(635, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 314)
        Me.Panel1.TabIndex = 21
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(63, 255)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(164, 33)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(63, 209)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(164, 33)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrevious.Location = New System.Drawing.Point(63, 158)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(164, 33)
        Me.BtnPrevious.TabIndex = 0
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNext.Location = New System.Drawing.Point(63, 113)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(164, 33)
        Me.BtnNext.TabIndex = 0
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAddNew.Location = New System.Drawing.Point(63, 62)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(164, 33)
        Me.BtnAddNew.TabIndex = 0
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.UseVisualStyleBackColor = False
        '
        'BtnSaveData
        '
        Me.BtnSaveData.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSaveData.Location = New System.Drawing.Point(63, 17)
        Me.BtnSaveData.Name = "BtnSaveData"
        Me.BtnSaveData.Size = New System.Drawing.Size(164, 33)
        Me.BtnSaveData.TabIndex = 1
        Me.BtnSaveData.Text = "Save Data"
        Me.BtnSaveData.UseVisualStyleBackColor = False
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
        'PATIENTBindingNavigatorSaveItem
        '
        Me.PATIENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PATIENTBindingNavigatorSaveItem.Image = CType(resources.GetObject("PATIENTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PATIENTBindingNavigatorSaveItem.Name = "PATIENTBindingNavigatorSaveItem"
        Me.PATIENTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PATIENTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(988, 664)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.PATIENTDataGridView)
        Me.Controls.Add(Patient_IDLabel)
        Me.Controls.Add(Me.Patient_IDTextBox)
        Me.Controls.Add(Patient_NameLabel)
        Me.Controls.Add(Me.Patient_NameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.SexTextBox)
        Me.Controls.Add(Blood_GroupLabel)
        Me.Controls.Add(Me.Blood_GroupTextBox)
        Me.Controls.Add(Marital_StatusLabel)
        Me.Controls.Add(Me.Marital_StatusTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Room_NumberLabel)
        Me.Controls.Add(Me.Room_NumberTextBox)
        Me.Controls.Add(Admin_DateLabel)
        Me.Controls.Add(Me.Admin_DateDateTimePicker)
        Me.Controls.Add(Me.PATIENTBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Details"
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PATIENTBindingNavigator.ResumeLayout(False)
        Me.PATIENTBindingNavigator.PerformLayout()
        CType(Me.PATIENTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pharmaplus_Hospital_Database_System1DataSet As Pharmaplus_Hospital_Database_System1DataSet
    Friend WithEvents PATIENTBindingSource As BindingSource
    Friend WithEvents PATIENTTableAdapter As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.PATIENTTableAdapter
    Friend WithEvents TableAdapterManager As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PATIENTBindingNavigator As BindingNavigator
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
    Friend WithEvents PATIENTBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Patient_IDTextBox As TextBox
    Friend WithEvents Patient_NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents SexTextBox As TextBox
    Friend WithEvents Blood_GroupTextBox As TextBox
    Friend WithEvents Marital_StatusTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Room_NumberTextBox As TextBox
    Friend WithEvents Admin_DateDateTimePicker As DateTimePicker
    Friend WithEvents PATIENTDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnSaveData As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim Doctor_NameLabel As System.Windows.Forms.Label
        Dim Doctor_Ref_NumberLabel As System.Windows.Forms.Label
        Dim Appointment_RefLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim Consultation_TimeLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim Emergency_NumberLabel As System.Windows.Forms.Label
        Dim Consultation_FeeLabel As System.Windows.Forms.Label
        Dim Consulation_DayLabel As System.Windows.Forms.Label
        Dim Total_PatientLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Pharmaplus_Hospital_Database_System1DataSet = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSet()
        Me.DOCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DOCTORTableAdapter = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.DOCTORTableAdapter()
        Me.TableAdapterManager = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager()
        Me.DOCTORBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Doctor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_Ref_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Appointment_RefTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Consultation_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Emergency_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Consultation_FeeTextBox = New System.Windows.Forms.TextBox()
        Me.Consulation_DayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Total_PatientTextBox = New System.Windows.Forms.TextBox()
        Me.DOCTORDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DOCTORBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Doctor_NameLabel = New System.Windows.Forms.Label()
        Doctor_Ref_NumberLabel = New System.Windows.Forms.Label()
        Appointment_RefLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        Consultation_TimeLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        Emergency_NumberLabel = New System.Windows.Forms.Label()
        Consultation_FeeLabel = New System.Windows.Forms.Label()
        Consulation_DayLabel = New System.Windows.Forms.Label()
        Total_PatientLabel = New System.Windows.Forms.Label()
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOCTORBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DOCTORBindingNavigator.SuspendLayout()
        CType(Me.DOCTORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pharmaplus_Hospital_Database_System1DataSet
        '
        Me.Pharmaplus_Hospital_Database_System1DataSet.DataSetName = "Pharmaplus_Hospital_Database_System1DataSet"
        Me.Pharmaplus_Hospital_Database_System1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DOCTORBindingSource
        '
        Me.DOCTORBindingSource.DataMember = "DOCTOR"
        Me.DOCTORBindingSource.DataSource = Me.Pharmaplus_Hospital_Database_System1DataSet
        '
        'DOCTORTableAdapter
        '
        Me.DOCTORTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APPOINTMENTTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BILLINGTableAdapter = Nothing
        Me.TableAdapterManager.DISCHARGETableAdapter = Nothing
        Me.TableAdapterManager.DOCTORTableAdapter = Me.DOCTORTableAdapter
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DOCTORBindingNavigator
        '
        Me.DOCTORBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DOCTORBindingNavigator.BindingSource = Me.DOCTORBindingSource
        Me.DOCTORBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DOCTORBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DOCTORBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DOCTORBindingNavigatorSaveItem})
        Me.DOCTORBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DOCTORBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DOCTORBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DOCTORBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DOCTORBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DOCTORBindingNavigator.Name = "DOCTORBindingNavigator"
        Me.DOCTORBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DOCTORBindingNavigator.Size = New System.Drawing.Size(1038, 25)
        Me.DOCTORBindingNavigator.TabIndex = 0
        Me.DOCTORBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Doctor_NameLabel
        '
        Doctor_NameLabel.AutoSize = True
        Doctor_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_NameLabel.Location = New System.Drawing.Point(41, 65)
        Doctor_NameLabel.Name = "Doctor_NameLabel"
        Doctor_NameLabel.Size = New System.Drawing.Size(114, 18)
        Doctor_NameLabel.TabIndex = 1
        Doctor_NameLabel.Text = "Doctor Name:"
        '
        'Doctor_NameTextBox
        '
        Me.Doctor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "Doctor Name", True))
        Me.Doctor_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_NameTextBox.Location = New System.Drawing.Point(205, 62)
        Me.Doctor_NameTextBox.Name = "Doctor_NameTextBox"
        Me.Doctor_NameTextBox.Size = New System.Drawing.Size(290, 24)
        Me.Doctor_NameTextBox.TabIndex = 2
        '
        'Doctor_Ref_NumberLabel
        '
        Doctor_Ref_NumberLabel.AutoSize = True
        Doctor_Ref_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_Ref_NumberLabel.Location = New System.Drawing.Point(41, 91)
        Doctor_Ref_NumberLabel.Name = "Doctor_Ref_NumberLabel"
        Doctor_Ref_NumberLabel.Size = New System.Drawing.Size(160, 18)
        Doctor_Ref_NumberLabel.TabIndex = 3
        Doctor_Ref_NumberLabel.Text = "Doctor Ref Number:"
        '
        'Doctor_Ref_NumberTextBox
        '
        Me.Doctor_Ref_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "Doctor Ref Number", True))
        Me.Doctor_Ref_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_Ref_NumberTextBox.Location = New System.Drawing.Point(205, 88)
        Me.Doctor_Ref_NumberTextBox.Name = "Doctor_Ref_NumberTextBox"
        Me.Doctor_Ref_NumberTextBox.Size = New System.Drawing.Size(290, 24)
        Me.Doctor_Ref_NumberTextBox.TabIndex = 4
        '
        'Appointment_RefLabel
        '
        Appointment_RefLabel.AutoSize = True
        Appointment_RefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appointment_RefLabel.Location = New System.Drawing.Point(41, 117)
        Appointment_RefLabel.Name = "Appointment_RefLabel"
        Appointment_RefLabel.Size = New System.Drawing.Size(137, 18)
        Appointment_RefLabel.TabIndex = 5
        Appointment_RefLabel.Text = "Appointment Ref:"
        '
        'Appointment_RefTextBox
        '
        Me.Appointment_RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "Appointment Ref", True))
        Me.Appointment_RefTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appointment_RefTextBox.Location = New System.Drawing.Point(205, 114)
        Me.Appointment_RefTextBox.Name = "Appointment_RefTextBox"
        Me.Appointment_RefTextBox.Size = New System.Drawing.Size(290, 24)
        Me.Appointment_RefTextBox.TabIndex = 6
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(41, 143)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(100, 18)
        DepartmentLabel.TabIndex = 7
        DepartmentLabel.Text = "Department:"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "Department", True))
        Me.DepartmentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(205, 140)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(290, 24)
        Me.DepartmentTextBox.TabIndex = 8
        '
        'Consultation_TimeLabel
        '
        Consultation_TimeLabel.AutoSize = True
        Consultation_TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Consultation_TimeLabel.Location = New System.Drawing.Point(41, 170)
        Consultation_TimeLabel.Name = "Consultation_TimeLabel"
        Consultation_TimeLabel.Size = New System.Drawing.Size(150, 18)
        Consultation_TimeLabel.TabIndex = 9
        Consultation_TimeLabel.Text = "Consultation Time:"
        '
        'Consultation_TimeDateTimePicker
        '
        Me.Consultation_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DOCTORBindingSource, "Consultation Time", True))
        Me.Consultation_TimeDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultation_TimeDateTimePicker.Location = New System.Drawing.Point(205, 166)
        Me.Consultation_TimeDateTimePicker.Name = "Consultation_TimeDateTimePicker"
        Me.Consultation_TimeDateTimePicker.Size = New System.Drawing.Size(290, 24)
        Me.Consultation_TimeDateTimePicker.TabIndex = 10
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_NumberLabel.Location = New System.Drawing.Point(41, 195)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(136, 18)
        Contact_NumberLabel.TabIndex = 11
        Contact_NumberLabel.Text = "Contact Number:"
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "Contact Number", True))
        Me.Contact_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(205, 192)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(290, 24)
        Me.Contact_NumberTextBox.TabIndex = 12
        '
        'Emergency_NumberLabel
        '
        Emergency_NumberLabel.AutoSize = True
        Emergency_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Emergency_NumberLabel.Location = New System.Drawing.Point(41, 221)
        Emergency_NumberLabel.Name = "Emergency_NumberLabel"
        Emergency_NumberLabel.Size = New System.Drawing.Size(161, 18)
        Emergency_NumberLabel.TabIndex = 13
        Emergency_NumberLabel.Text = "Emergency Number:"
        '
        'Emergency_NumberTextBox
        '
        Me.Emergency_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "Emergency Number", True))
        Me.Emergency_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emergency_NumberTextBox.Location = New System.Drawing.Point(205, 218)
        Me.Emergency_NumberTextBox.Name = "Emergency_NumberTextBox"
        Me.Emergency_NumberTextBox.Size = New System.Drawing.Size(290, 24)
        Me.Emergency_NumberTextBox.TabIndex = 14
        '
        'Consultation_FeeLabel
        '
        Consultation_FeeLabel.AutoSize = True
        Consultation_FeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Consultation_FeeLabel.Location = New System.Drawing.Point(41, 247)
        Consultation_FeeLabel.Name = "Consultation_FeeLabel"
        Consultation_FeeLabel.Size = New System.Drawing.Size(141, 18)
        Consultation_FeeLabel.TabIndex = 15
        Consultation_FeeLabel.Text = "Consultation Fee:"
        '
        'Consultation_FeeTextBox
        '
        Me.Consultation_FeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "Consultation Fee", True))
        Me.Consultation_FeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultation_FeeTextBox.Location = New System.Drawing.Point(205, 244)
        Me.Consultation_FeeTextBox.Name = "Consultation_FeeTextBox"
        Me.Consultation_FeeTextBox.Size = New System.Drawing.Size(290, 24)
        Me.Consultation_FeeTextBox.TabIndex = 16
        '
        'Consulation_DayLabel
        '
        Consulation_DayLabel.AutoSize = True
        Consulation_DayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Consulation_DayLabel.Location = New System.Drawing.Point(41, 274)
        Consulation_DayLabel.Name = "Consulation_DayLabel"
        Consulation_DayLabel.Size = New System.Drawing.Size(137, 18)
        Consulation_DayLabel.TabIndex = 17
        Consulation_DayLabel.Text = "Consulation Day:"
        '
        'Consulation_DayDateTimePicker
        '
        Me.Consulation_DayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DOCTORBindingSource, "Consulation Day", True))
        Me.Consulation_DayDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consulation_DayDateTimePicker.Location = New System.Drawing.Point(205, 270)
        Me.Consulation_DayDateTimePicker.Name = "Consulation_DayDateTimePicker"
        Me.Consulation_DayDateTimePicker.Size = New System.Drawing.Size(290, 24)
        Me.Consulation_DayDateTimePicker.TabIndex = 18
        '
        'Total_PatientLabel
        '
        Total_PatientLabel.AutoSize = True
        Total_PatientLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_PatientLabel.Location = New System.Drawing.Point(41, 299)
        Total_PatientLabel.Name = "Total_PatientLabel"
        Total_PatientLabel.Size = New System.Drawing.Size(108, 18)
        Total_PatientLabel.TabIndex = 19
        Total_PatientLabel.Text = "Total Patient:"
        '
        'Total_PatientTextBox
        '
        Me.Total_PatientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "Total Patient", True))
        Me.Total_PatientTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_PatientTextBox.Location = New System.Drawing.Point(205, 296)
        Me.Total_PatientTextBox.Name = "Total_PatientTextBox"
        Me.Total_PatientTextBox.Size = New System.Drawing.Size(290, 24)
        Me.Total_PatientTextBox.TabIndex = 20
        '
        'DOCTORDataGridView
        '
        Me.DOCTORDataGridView.AutoGenerateColumns = False
        Me.DOCTORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DOCTORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DOCTORDataGridView.DataSource = Me.DOCTORBindingSource
        Me.DOCTORDataGridView.Location = New System.Drawing.Point(0, 382)
        Me.DOCTORDataGridView.Name = "DOCTORDataGridView"
        Me.DOCTORDataGridView.Size = New System.Drawing.Size(1014, 220)
        Me.DOCTORDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Doctor Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Doctor Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Doctor Ref Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Doctor Ref Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Appointment Ref"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Appointment Ref"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Consultation Time"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Consultation Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Contact Number"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Emergency Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Emergency Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Consultation Fee"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Consultation Fee"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Consulation Day"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Consulation Day"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Total Patient"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Total Patient"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
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
        Me.Panel1.Location = New System.Drawing.Point(623, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 284)
        Me.Panel1.TabIndex = 22
        '
        'BtnSaveData
        '
        Me.BtnSaveData.BackColor = System.Drawing.Color.Silver
        Me.BtnSaveData.Location = New System.Drawing.Point(89, 3)
        Me.BtnSaveData.Name = "BtnSaveData"
        Me.BtnSaveData.Size = New System.Drawing.Size(164, 31)
        Me.BtnSaveData.TabIndex = 7
        Me.BtnSaveData.Text = "Save Data"
        Me.BtnSaveData.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Silver
        Me.BtnClose.Location = New System.Drawing.Point(89, 233)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(164, 29)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Silver
        Me.BtnDelete.Location = New System.Drawing.Point(89, 189)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(164, 38)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.Silver
        Me.BtnPrevious.Location = New System.Drawing.Point(89, 137)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(164, 35)
        Me.BtnPrevious.TabIndex = 4
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Silver
        Me.BtnNext.Location = New System.Drawing.Point(89, 88)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(164, 34)
        Me.BtnNext.TabIndex = 5
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackColor = System.Drawing.Color.Silver
        Me.BtnAddNew.Location = New System.Drawing.Point(89, 45)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(164, 35)
        Me.BtnAddNew.TabIndex = 6
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
        'DOCTORBindingNavigatorSaveItem
        '
        Me.DOCTORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DOCTORBindingNavigatorSaveItem.Image = CType(resources.GetObject("DOCTORBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DOCTORBindingNavigatorSaveItem.Name = "DOCTORBindingNavigatorSaveItem"
        Me.DOCTORBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DOCTORBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1038, 614)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DOCTORDataGridView)
        Me.Controls.Add(Doctor_NameLabel)
        Me.Controls.Add(Me.Doctor_NameTextBox)
        Me.Controls.Add(Doctor_Ref_NumberLabel)
        Me.Controls.Add(Me.Doctor_Ref_NumberTextBox)
        Me.Controls.Add(Appointment_RefLabel)
        Me.Controls.Add(Me.Appointment_RefTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Consultation_TimeLabel)
        Me.Controls.Add(Me.Consultation_TimeDateTimePicker)
        Me.Controls.Add(Contact_NumberLabel)
        Me.Controls.Add(Me.Contact_NumberTextBox)
        Me.Controls.Add(Emergency_NumberLabel)
        Me.Controls.Add(Me.Emergency_NumberTextBox)
        Me.Controls.Add(Consultation_FeeLabel)
        Me.Controls.Add(Me.Consultation_FeeTextBox)
        Me.Controls.Add(Consulation_DayLabel)
        Me.Controls.Add(Me.Consulation_DayDateTimePicker)
        Me.Controls.Add(Total_PatientLabel)
        Me.Controls.Add(Me.Total_PatientTextBox)
        Me.Controls.Add(Me.DOCTORBindingNavigator)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Details"
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOCTORBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DOCTORBindingNavigator.ResumeLayout(False)
        Me.DOCTORBindingNavigator.PerformLayout()
        CType(Me.DOCTORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pharmaplus_Hospital_Database_System1DataSet As Pharmaplus_Hospital_Database_System1DataSet
    Friend WithEvents DOCTORBindingSource As BindingSource
    Friend WithEvents DOCTORTableAdapter As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.DOCTORTableAdapter
    Friend WithEvents TableAdapterManager As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DOCTORBindingNavigator As BindingNavigator
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
    Friend WithEvents DOCTORBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Doctor_NameTextBox As TextBox
    Friend WithEvents Doctor_Ref_NumberTextBox As TextBox
    Friend WithEvents Appointment_RefTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents Consultation_TimeDateTimePicker As DateTimePicker
    Friend WithEvents Contact_NumberTextBox As TextBox
    Friend WithEvents Emergency_NumberTextBox As TextBox
    Friend WithEvents Consultation_FeeTextBox As TextBox
    Friend WithEvents Consulation_DayDateTimePicker As DateTimePicker
    Friend WithEvents Total_PatientTextBox As TextBox
    Friend WithEvents DOCTORDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSaveData As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnAddNew As Button
End Class

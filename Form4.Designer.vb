<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Appointment_RefLabel As System.Windows.Forms.Label
        Dim Patient_NameLabel As System.Windows.Forms.Label
        Dim Patient_NumberLabel As System.Windows.Forms.Label
        Dim Appointment_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Pharmaplus_Hospital_Database_System1DataSet = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSet()
        Me.APPOINTMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APPOINTMENTTableAdapter = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.APPOINTMENTTableAdapter()
        Me.TableAdapterManager = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager()
        Me.APPOINTMENTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Appointment_RefTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Appointment_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.APPOINTMENTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.APPOINTMENTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Appointment_RefLabel = New System.Windows.Forms.Label()
        Patient_NameLabel = New System.Windows.Forms.Label()
        Patient_NumberLabel = New System.Windows.Forms.Label()
        Appointment_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APPOINTMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APPOINTMENTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APPOINTMENTBindingNavigator.SuspendLayout()
        CType(Me.APPOINTMENTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pharmaplus_Hospital_Database_System1DataSet
        '
        Me.Pharmaplus_Hospital_Database_System1DataSet.DataSetName = "Pharmaplus_Hospital_Database_System1DataSet"
        Me.Pharmaplus_Hospital_Database_System1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APPOINTMENTBindingSource
        '
        Me.APPOINTMENTBindingSource.DataMember = "APPOINTMENT"
        Me.APPOINTMENTBindingSource.DataSource = Me.Pharmaplus_Hospital_Database_System1DataSet
        '
        'APPOINTMENTTableAdapter
        '
        Me.APPOINTMENTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APPOINTMENTTableAdapter = Me.APPOINTMENTTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BILLINGTableAdapter = Nothing
        Me.TableAdapterManager.DISCHARGETableAdapter = Nothing
        Me.TableAdapterManager.DOCTORTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'APPOINTMENTBindingNavigator
        '
        Me.APPOINTMENTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.APPOINTMENTBindingNavigator.BindingSource = Me.APPOINTMENTBindingSource
        Me.APPOINTMENTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.APPOINTMENTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.APPOINTMENTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.APPOINTMENTBindingNavigatorSaveItem})
        Me.APPOINTMENTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.APPOINTMENTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.APPOINTMENTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.APPOINTMENTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.APPOINTMENTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.APPOINTMENTBindingNavigator.Name = "APPOINTMENTBindingNavigator"
        Me.APPOINTMENTBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.APPOINTMENTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.APPOINTMENTBindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.APPOINTMENTBindingNavigator.TabIndex = 0
        Me.APPOINTMENTBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(81, 23)
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
        'Appointment_RefLabel
        '
        Appointment_RefLabel.AutoSize = True
        Appointment_RefLabel.Location = New System.Drawing.Point(102, 116)
        Appointment_RefLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Appointment_RefLabel.Name = "Appointment_RefLabel"
        Appointment_RefLabel.Size = New System.Drawing.Size(137, 18)
        Appointment_RefLabel.TabIndex = 1
        Appointment_RefLabel.Text = "Appointment Ref:"
        '
        'Appointment_RefTextBox
        '
        Me.Appointment_RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APPOINTMENTBindingSource, "Appointment Ref", True))
        Me.Appointment_RefTextBox.Location = New System.Drawing.Point(293, 112)
        Me.Appointment_RefTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Appointment_RefTextBox.Name = "Appointment_RefTextBox"
        Me.Appointment_RefTextBox.Size = New System.Drawing.Size(357, 24)
        Me.Appointment_RefTextBox.TabIndex = 2
        '
        'Patient_NameLabel
        '
        Patient_NameLabel.AutoSize = True
        Patient_NameLabel.Location = New System.Drawing.Point(102, 152)
        Patient_NameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Patient_NameLabel.Name = "Patient_NameLabel"
        Patient_NameLabel.Size = New System.Drawing.Size(114, 18)
        Patient_NameLabel.TabIndex = 3
        Patient_NameLabel.Text = "Patient Name:"
        '
        'Patient_NameTextBox
        '
        Me.Patient_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APPOINTMENTBindingSource, "Patient Name", True))
        Me.Patient_NameTextBox.Location = New System.Drawing.Point(293, 148)
        Me.Patient_NameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Patient_NameTextBox.Name = "Patient_NameTextBox"
        Me.Patient_NameTextBox.Size = New System.Drawing.Size(357, 24)
        Me.Patient_NameTextBox.TabIndex = 4
        '
        'Patient_NumberLabel
        '
        Patient_NumberLabel.AutoSize = True
        Patient_NumberLabel.Location = New System.Drawing.Point(102, 188)
        Patient_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Patient_NumberLabel.Name = "Patient_NumberLabel"
        Patient_NumberLabel.Size = New System.Drawing.Size(129, 18)
        Patient_NumberLabel.TabIndex = 5
        Patient_NumberLabel.Text = "Patient Number:"
        '
        'Patient_NumberTextBox
        '
        Me.Patient_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APPOINTMENTBindingSource, "Patient Number", True))
        Me.Patient_NumberTextBox.Location = New System.Drawing.Point(293, 184)
        Me.Patient_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Patient_NumberTextBox.Name = "Patient_NumberTextBox"
        Me.Patient_NumberTextBox.Size = New System.Drawing.Size(357, 24)
        Me.Patient_NumberTextBox.TabIndex = 6
        '
        'Appointment_NumberLabel
        '
        Appointment_NumberLabel.AutoSize = True
        Appointment_NumberLabel.Location = New System.Drawing.Point(102, 224)
        Appointment_NumberLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Appointment_NumberLabel.Name = "Appointment_NumberLabel"
        Appointment_NumberLabel.Size = New System.Drawing.Size(170, 18)
        Appointment_NumberLabel.TabIndex = 7
        Appointment_NumberLabel.Text = "Appointment Number:"
        '
        'Appointment_NumberTextBox
        '
        Me.Appointment_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.APPOINTMENTBindingSource, "Appointment Number", True))
        Me.Appointment_NumberTextBox.Location = New System.Drawing.Point(293, 220)
        Me.Appointment_NumberTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Appointment_NumberTextBox.Name = "Appointment_NumberTextBox"
        Me.Appointment_NumberTextBox.Size = New System.Drawing.Size(357, 24)
        Me.Appointment_NumberTextBox.TabIndex = 8
        '
        'APPOINTMENTDataGridView
        '
        Me.APPOINTMENTDataGridView.AutoGenerateColumns = False
        Me.APPOINTMENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.APPOINTMENTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.APPOINTMENTDataGridView.DataSource = Me.APPOINTMENTBindingSource
        Me.APPOINTMENTDataGridView.Location = New System.Drawing.Point(208, 278)
        Me.APPOINTMENTDataGridView.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.APPOINTMENTDataGridView.Name = "APPOINTMENTDataGridView"
        Me.APPOINTMENTDataGridView.Size = New System.Drawing.Size(442, 305)
        Me.APPOINTMENTDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Appointment Ref"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Appointment Ref"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Patient Number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Patient Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Appointment Number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Appointment Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
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
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(670, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 300)
        Me.Panel1.TabIndex = 10
        '
        'BtnSaveData
        '
        Me.BtnSaveData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSaveData.Location = New System.Drawing.Point(70, 15)
        Me.BtnSaveData.Name = "BtnSaveData"
        Me.BtnSaveData.Size = New System.Drawing.Size(164, 33)
        Me.BtnSaveData.TabIndex = 7
        Me.BtnSaveData.Text = "Save Data"
        Me.BtnSaveData.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(70, 253)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(164, 33)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(70, 207)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(164, 33)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnPrevious.Location = New System.Drawing.Point(70, 156)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(164, 33)
        Me.BtnPrevious.TabIndex = 4
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnNext.Location = New System.Drawing.Point(70, 111)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(164, 33)
        Me.BtnNext.TabIndex = 5
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAddNew.Location = New System.Drawing.Point(70, 60)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(164, 33)
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
        'APPOINTMENTBindingNavigatorSaveItem
        '
        Me.APPOINTMENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.APPOINTMENTBindingNavigatorSaveItem.Image = CType(resources.GetObject("APPOINTMENTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.APPOINTMENTBindingNavigatorSaveItem.Name = "APPOINTMENTBindingNavigatorSaveItem"
        Me.APPOINTMENTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.APPOINTMENTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.APPOINTMENTDataGridView)
        Me.Controls.Add(Appointment_RefLabel)
        Me.Controls.Add(Me.Appointment_RefTextBox)
        Me.Controls.Add(Patient_NameLabel)
        Me.Controls.Add(Me.Patient_NameTextBox)
        Me.Controls.Add(Patient_NumberLabel)
        Me.Controls.Add(Me.Patient_NumberTextBox)
        Me.Controls.Add(Appointment_NumberLabel)
        Me.Controls.Add(Me.Appointment_NumberTextBox)
        Me.Controls.Add(Me.APPOINTMENTBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment"
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APPOINTMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APPOINTMENTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APPOINTMENTBindingNavigator.ResumeLayout(False)
        Me.APPOINTMENTBindingNavigator.PerformLayout()
        CType(Me.APPOINTMENTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pharmaplus_Hospital_Database_System1DataSet As Pharmaplus_Hospital_Database_System1DataSet
    Friend WithEvents APPOINTMENTBindingSource As BindingSource
    Friend WithEvents APPOINTMENTTableAdapter As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.APPOINTMENTTableAdapter
    Friend WithEvents TableAdapterManager As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents APPOINTMENTBindingNavigator As BindingNavigator
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
    Friend WithEvents APPOINTMENTBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Appointment_RefTextBox As TextBox
    Friend WithEvents Patient_NameTextBox As TextBox
    Friend WithEvents Patient_NumberTextBox As TextBox
    Friend WithEvents Appointment_NumberTextBox As TextBox
    Friend WithEvents APPOINTMENTDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSaveData As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnAddNew As Button
End Class

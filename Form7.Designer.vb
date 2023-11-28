<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim Treatment_ChargesLabel As System.Windows.Forms.Label
        Dim Bed_ChargesLabel As System.Windows.Forms.Label
        Dim Medicine_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Pharmaplus_Hospital_Database_System1DataSet = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSet()
        Me.BILLINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BILLINGTableAdapter = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.BILLINGTableAdapter()
        Me.TableAdapterManager = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager()
        Me.BILLINGBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Treatment_ChargesTextBox = New System.Windows.Forms.TextBox()
        Me.Bed_ChargesTextBox = New System.Windows.Forms.TextBox()
        Me.Medicine_NameTextBox = New System.Windows.Forms.TextBox()
        Me.BILLINGDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.BILLINGBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Treatment_ChargesLabel = New System.Windows.Forms.Label()
        Bed_ChargesLabel = New System.Windows.Forms.Label()
        Medicine_NameLabel = New System.Windows.Forms.Label()
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BILLINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BILLINGBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BILLINGBindingNavigator.SuspendLayout()
        CType(Me.BILLINGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pharmaplus_Hospital_Database_System1DataSet
        '
        Me.Pharmaplus_Hospital_Database_System1DataSet.DataSetName = "Pharmaplus_Hospital_Database_System1DataSet"
        Me.Pharmaplus_Hospital_Database_System1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BILLINGBindingSource
        '
        Me.BILLINGBindingSource.DataMember = "BILLING"
        Me.BILLINGBindingSource.DataSource = Me.Pharmaplus_Hospital_Database_System1DataSet
        '
        'BILLINGTableAdapter
        '
        Me.BILLINGTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APPOINTMENTTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BILLINGTableAdapter = Me.BILLINGTableAdapter
        Me.TableAdapterManager.DISCHARGETableAdapter = Nothing
        Me.TableAdapterManager.DOCTORTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BILLINGBindingNavigator
        '
        Me.BILLINGBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BILLINGBindingNavigator.BindingSource = Me.BILLINGBindingSource
        Me.BILLINGBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BILLINGBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BILLINGBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BILLINGBindingNavigatorSaveItem})
        Me.BILLINGBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BILLINGBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BILLINGBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BILLINGBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BILLINGBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BILLINGBindingNavigator.Name = "BILLINGBindingNavigator"
        Me.BILLINGBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BILLINGBindingNavigator.Size = New System.Drawing.Size(873, 25)
        Me.BILLINGBindingNavigator.TabIndex = 0
        Me.BILLINGBindingNavigator.Text = "BindingNavigator1"
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
        'Treatment_ChargesLabel
        '
        Treatment_ChargesLabel.AutoSize = True
        Treatment_ChargesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Treatment_ChargesLabel.Location = New System.Drawing.Point(143, 92)
        Treatment_ChargesLabel.Name = "Treatment_ChargesLabel"
        Treatment_ChargesLabel.Size = New System.Drawing.Size(157, 18)
        Treatment_ChargesLabel.TabIndex = 1
        Treatment_ChargesLabel.Text = "Treatment Charges:"
        '
        'Treatment_ChargesTextBox
        '
        Me.Treatment_ChargesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BILLINGBindingSource, "Treatment Charges", True))
        Me.Treatment_ChargesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treatment_ChargesTextBox.Location = New System.Drawing.Point(307, 89)
        Me.Treatment_ChargesTextBox.Name = "Treatment_ChargesTextBox"
        Me.Treatment_ChargesTextBox.Size = New System.Drawing.Size(214, 24)
        Me.Treatment_ChargesTextBox.TabIndex = 2
        '
        'Bed_ChargesLabel
        '
        Bed_ChargesLabel.AutoSize = True
        Bed_ChargesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Bed_ChargesLabel.Location = New System.Drawing.Point(143, 118)
        Bed_ChargesLabel.Name = "Bed_ChargesLabel"
        Bed_ChargesLabel.Size = New System.Drawing.Size(110, 18)
        Bed_ChargesLabel.TabIndex = 3
        Bed_ChargesLabel.Text = "Bed Charges:"
        '
        'Bed_ChargesTextBox
        '
        Me.Bed_ChargesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BILLINGBindingSource, "Bed Charges", True))
        Me.Bed_ChargesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bed_ChargesTextBox.Location = New System.Drawing.Point(307, 115)
        Me.Bed_ChargesTextBox.Name = "Bed_ChargesTextBox"
        Me.Bed_ChargesTextBox.Size = New System.Drawing.Size(214, 24)
        Me.Bed_ChargesTextBox.TabIndex = 4
        '
        'Medicine_NameLabel
        '
        Medicine_NameLabel.AutoSize = True
        Medicine_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medicine_NameLabel.Location = New System.Drawing.Point(143, 144)
        Medicine_NameLabel.Name = "Medicine_NameLabel"
        Medicine_NameLabel.Size = New System.Drawing.Size(129, 18)
        Medicine_NameLabel.TabIndex = 5
        Medicine_NameLabel.Text = "Medicine Name:"
        '
        'Medicine_NameTextBox
        '
        Me.Medicine_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BILLINGBindingSource, "Medicine Name", True))
        Me.Medicine_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medicine_NameTextBox.Location = New System.Drawing.Point(307, 141)
        Me.Medicine_NameTextBox.Name = "Medicine_NameTextBox"
        Me.Medicine_NameTextBox.Size = New System.Drawing.Size(214, 24)
        Me.Medicine_NameTextBox.TabIndex = 6
        '
        'BILLINGDataGridView
        '
        Me.BILLINGDataGridView.AutoGenerateColumns = False
        Me.BILLINGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BILLINGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.BILLINGDataGridView.DataSource = Me.BILLINGBindingSource
        Me.BILLINGDataGridView.Location = New System.Drawing.Point(68, 264)
        Me.BILLINGDataGridView.Name = "BILLINGDataGridView"
        Me.BILLINGDataGridView.Size = New System.Drawing.Size(395, 220)
        Me.BILLINGDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Treatment Charges"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Treatment Charges"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bed Charges"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bed Charges"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Medicine Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Medicine Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        Me.Panel1.Location = New System.Drawing.Point(543, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 256)
        Me.Panel1.TabIndex = 8
        '
        'BtnSaveData
        '
        Me.BtnSaveData.BackColor = System.Drawing.Color.White
        Me.BtnSaveData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveData.ForeColor = System.Drawing.Color.Black
        Me.BtnSaveData.Location = New System.Drawing.Point(49, 6)
        Me.BtnSaveData.Name = "BtnSaveData"
        Me.BtnSaveData.Size = New System.Drawing.Size(164, 33)
        Me.BtnSaveData.TabIndex = 19
        Me.BtnSaveData.Text = "Save Data"
        Me.BtnSaveData.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(49, 217)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(164, 33)
        Me.BtnClose.TabIndex = 14
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.White
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.Location = New System.Drawing.Point(49, 178)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(164, 33)
        Me.BtnDelete.TabIndex = 15
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.White
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Black
        Me.BtnPrevious.Location = New System.Drawing.Point(49, 139)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(164, 33)
        Me.BtnPrevious.TabIndex = 16
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.White
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Black
        Me.BtnNext.Location = New System.Drawing.Point(49, 98)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(164, 33)
        Me.BtnNext.TabIndex = 17
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackColor = System.Drawing.Color.White
        Me.BtnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.ForeColor = System.Drawing.Color.Black
        Me.BtnAddNew.Location = New System.Drawing.Point(49, 54)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(164, 33)
        Me.BtnAddNew.TabIndex = 18
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
        'BILLINGBindingNavigatorSaveItem
        '
        Me.BILLINGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BILLINGBindingNavigatorSaveItem.Image = CType(resources.GetObject("BILLINGBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BILLINGBindingNavigatorSaveItem.Name = "BILLINGBindingNavigatorSaveItem"
        Me.BILLINGBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BILLINGBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(873, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BILLINGDataGridView)
        Me.Controls.Add(Treatment_ChargesLabel)
        Me.Controls.Add(Me.Treatment_ChargesTextBox)
        Me.Controls.Add(Bed_ChargesLabel)
        Me.Controls.Add(Me.Bed_ChargesTextBox)
        Me.Controls.Add(Medicine_NameLabel)
        Me.Controls.Add(Me.Medicine_NameTextBox)
        Me.Controls.Add(Me.BILLINGBindingNavigator)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BILLINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BILLINGBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BILLINGBindingNavigator.ResumeLayout(False)
        Me.BILLINGBindingNavigator.PerformLayout()
        CType(Me.BILLINGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pharmaplus_Hospital_Database_System1DataSet As Pharmaplus_Hospital_Database_System1DataSet
    Friend WithEvents BILLINGBindingSource As BindingSource
    Friend WithEvents BILLINGTableAdapter As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.BILLINGTableAdapter
    Friend WithEvents TableAdapterManager As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BILLINGBindingNavigator As BindingNavigator
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
    Friend WithEvents BILLINGBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Treatment_ChargesTextBox As TextBox
    Friend WithEvents Bed_ChargesTextBox As TextBox
    Friend WithEvents Medicine_NameTextBox As TextBox
    Friend WithEvents BILLINGDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSaveData As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnAddNew As Button
End Class

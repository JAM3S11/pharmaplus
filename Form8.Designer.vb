<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim RemarkLabel As System.Windows.Forms.Label
        Dim Treatment_ChargesLabel As System.Windows.Forms.Label
        Dim Total_BillLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Pharmaplus_Hospital_Database_System1DataSet = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSet()
        Me.DISCHARGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DISCHARGETableAdapter = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.DISCHARGETableAdapter()
        Me.TableAdapterManager = New Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager()
        Me.DISCHARGEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemarkTextBox = New System.Windows.Forms.TextBox()
        Me.Treatment_ChargesTextBox = New System.Windows.Forms.TextBox()
        Me.Total_BillTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.DISCHARGEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DISCHARGEDataGridView = New System.Windows.Forms.DataGridView()
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
        RemarkLabel = New System.Windows.Forms.Label()
        Treatment_ChargesLabel = New System.Windows.Forms.Label()
        Total_BillLabel = New System.Windows.Forms.Label()
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISCHARGEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISCHARGEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DISCHARGEBindingNavigator.SuspendLayout()
        CType(Me.DISCHARGEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pharmaplus_Hospital_Database_System1DataSet
        '
        Me.Pharmaplus_Hospital_Database_System1DataSet.DataSetName = "Pharmaplus_Hospital_Database_System1DataSet"
        Me.Pharmaplus_Hospital_Database_System1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DISCHARGEBindingSource
        '
        Me.DISCHARGEBindingSource.DataMember = "DISCHARGE"
        Me.DISCHARGEBindingSource.DataSource = Me.Pharmaplus_Hospital_Database_System1DataSet
        '
        'DISCHARGETableAdapter
        '
        Me.DISCHARGETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APPOINTMENTTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BILLINGTableAdapter = Nothing
        Me.TableAdapterManager.DISCHARGETableAdapter = Me.DISCHARGETableAdapter
        Me.TableAdapterManager.DOCTORTableAdapter = Nothing
        Me.TableAdapterManager.MEDICINETableAdapter = Nothing
        Me.TableAdapterManager.PATIENTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pharmaplus_Hospital_Management_1.Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DISCHARGEBindingNavigator
        '
        Me.DISCHARGEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DISCHARGEBindingNavigator.BindingSource = Me.DISCHARGEBindingSource
        Me.DISCHARGEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DISCHARGEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DISCHARGEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DISCHARGEBindingNavigatorSaveItem})
        Me.DISCHARGEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DISCHARGEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DISCHARGEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DISCHARGEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DISCHARGEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DISCHARGEBindingNavigator.Name = "DISCHARGEBindingNavigator"
        Me.DISCHARGEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DISCHARGEBindingNavigator.Size = New System.Drawing.Size(862, 25)
        Me.DISCHARGEBindingNavigator.TabIndex = 0
        Me.DISCHARGEBindingNavigator.Text = "BindingNavigator1"
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
        'RemarkLabel
        '
        RemarkLabel.AutoSize = True
        RemarkLabel.Location = New System.Drawing.Point(150, 86)
        RemarkLabel.Name = "RemarkLabel"
        RemarkLabel.Size = New System.Drawing.Size(47, 13)
        RemarkLabel.TabIndex = 1
        RemarkLabel.Text = "Remark:"
        '
        'RemarkTextBox
        '
        Me.RemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DISCHARGEBindingSource, "Remark", True))
        Me.RemarkTextBox.Location = New System.Drawing.Point(286, 86)
        Me.RemarkTextBox.Name = "RemarkTextBox"
        Me.RemarkTextBox.Size = New System.Drawing.Size(220, 20)
        Me.RemarkTextBox.TabIndex = 2
        '
        'Treatment_ChargesLabel
        '
        Treatment_ChargesLabel.AutoSize = True
        Treatment_ChargesLabel.Location = New System.Drawing.Point(150, 112)
        Treatment_ChargesLabel.Name = "Treatment_ChargesLabel"
        Treatment_ChargesLabel.Size = New System.Drawing.Size(100, 13)
        Treatment_ChargesLabel.TabIndex = 3
        Treatment_ChargesLabel.Text = "Treatment Charges:"
        '
        'Treatment_ChargesTextBox
        '
        Me.Treatment_ChargesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DISCHARGEBindingSource, "Treatment Charges", True))
        Me.Treatment_ChargesTextBox.Location = New System.Drawing.Point(286, 112)
        Me.Treatment_ChargesTextBox.Name = "Treatment_ChargesTextBox"
        Me.Treatment_ChargesTextBox.Size = New System.Drawing.Size(220, 20)
        Me.Treatment_ChargesTextBox.TabIndex = 4
        '
        'Total_BillLabel
        '
        Total_BillLabel.AutoSize = True
        Total_BillLabel.Location = New System.Drawing.Point(150, 138)
        Total_BillLabel.Name = "Total_BillLabel"
        Total_BillLabel.Size = New System.Drawing.Size(50, 13)
        Total_BillLabel.TabIndex = 5
        Total_BillLabel.Text = "Total Bill:"
        '
        'Total_BillTextBox
        '
        Me.Total_BillTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DISCHARGEBindingSource, "Total Bill", True))
        Me.Total_BillTextBox.Location = New System.Drawing.Point(286, 138)
        Me.Total_BillTextBox.Name = "Total_BillTextBox"
        Me.Total_BillTextBox.Size = New System.Drawing.Size(220, 20)
        Me.Total_BillTextBox.TabIndex = 6
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
        'DISCHARGEBindingNavigatorSaveItem
        '
        Me.DISCHARGEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DISCHARGEBindingNavigatorSaveItem.Image = CType(resources.GetObject("DISCHARGEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DISCHARGEBindingNavigatorSaveItem.Name = "DISCHARGEBindingNavigatorSaveItem"
        Me.DISCHARGEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DISCHARGEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DISCHARGEDataGridView
        '
        Me.DISCHARGEDataGridView.AutoGenerateColumns = False
        Me.DISCHARGEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DISCHARGEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DISCHARGEDataGridView.DataSource = Me.DISCHARGEBindingSource
        Me.DISCHARGEDataGridView.Location = New System.Drawing.Point(100, 216)
        Me.DISCHARGEDataGridView.Name = "DISCHARGEDataGridView"
        Me.DISCHARGEDataGridView.Size = New System.Drawing.Size(385, 220)
        Me.DISCHARGEDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Remark"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Remark"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Treatment Charges"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Treatment Charges"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Total Bill"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total Bill"
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
        Me.Panel1.Location = New System.Drawing.Point(558, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 265)
        Me.Panel1.TabIndex = 8
        '
        'BtnSaveData
        '
        Me.BtnSaveData.BackColor = System.Drawing.Color.White
        Me.BtnSaveData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveData.ForeColor = System.Drawing.Color.Black
        Me.BtnSaveData.Location = New System.Drawing.Point(25, 2)
        Me.BtnSaveData.Name = "BtnSaveData"
        Me.BtnSaveData.Size = New System.Drawing.Size(164, 33)
        Me.BtnSaveData.TabIndex = 25
        Me.BtnSaveData.Text = "Save Data"
        Me.BtnSaveData.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(25, 213)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(164, 33)
        Me.BtnClose.TabIndex = 20
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.White
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.Location = New System.Drawing.Point(25, 174)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(164, 33)
        Me.BtnDelete.TabIndex = 21
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.White
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Black
        Me.BtnPrevious.Location = New System.Drawing.Point(25, 135)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(164, 33)
        Me.BtnPrevious.TabIndex = 22
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.White
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Black
        Me.BtnNext.Location = New System.Drawing.Point(25, 94)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(164, 33)
        Me.BtnNext.TabIndex = 23
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackColor = System.Drawing.Color.White
        Me.BtnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.ForeColor = System.Drawing.Color.Black
        Me.BtnAddNew.Location = New System.Drawing.Point(25, 50)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(164, 33)
        Me.BtnAddNew.TabIndex = 24
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.UseVisualStyleBackColor = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(862, 572)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DISCHARGEDataGridView)
        Me.Controls.Add(RemarkLabel)
        Me.Controls.Add(Me.RemarkTextBox)
        Me.Controls.Add(Treatment_ChargesLabel)
        Me.Controls.Add(Me.Treatment_ChargesTextBox)
        Me.Controls.Add(Total_BillLabel)
        Me.Controls.Add(Me.Total_BillTextBox)
        Me.Controls.Add(Me.DISCHARGEBindingNavigator)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discharge"
        CType(Me.Pharmaplus_Hospital_Database_System1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISCHARGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISCHARGEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DISCHARGEBindingNavigator.ResumeLayout(False)
        Me.DISCHARGEBindingNavigator.PerformLayout()
        CType(Me.DISCHARGEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pharmaplus_Hospital_Database_System1DataSet As Pharmaplus_Hospital_Database_System1DataSet
    Friend WithEvents DISCHARGEBindingSource As BindingSource
    Friend WithEvents DISCHARGETableAdapter As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.DISCHARGETableAdapter
    Friend WithEvents TableAdapterManager As Pharmaplus_Hospital_Database_System1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DISCHARGEBindingNavigator As BindingNavigator
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
    Friend WithEvents DISCHARGEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RemarkTextBox As TextBox
    Friend WithEvents Treatment_ChargesTextBox As TextBox
    Friend WithEvents Total_BillTextBox As TextBox
    Friend WithEvents DISCHARGEDataGridView As DataGridView
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

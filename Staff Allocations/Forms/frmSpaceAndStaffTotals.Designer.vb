<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpaceAndStaffTotals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpaceAndStaffTotals))
        Me.Staff_AllocationsDataSet = New Staff_Allocations.Staff_AllocationsDataSet()
        Me.TblSpaceAndStaffTotalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSpaceAndStaffTotalsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblSpaceAndStaffTotalsTableAdapter()
        Me.TableAdapterManager = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager()
        Me.TblSpaceAndStaffTotalsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblSpaceAndStaffTotalsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSpaceAndStaffTotalsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Staff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSpaceAndStaffTotalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSpaceAndStaffTotalsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSpaceAndStaffTotalsBindingNavigator.SuspendLayout()
        CType(Me.TblSpaceAndStaffTotalsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_AllocationsDataSet
        '
        Me.Staff_AllocationsDataSet.DataSetName = "Staff_AllocationsDataSet"
        Me.Staff_AllocationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSpaceAndStaffTotalsBindingSource
        '
        Me.TblSpaceAndStaffTotalsBindingSource.DataMember = "tblSpaceAndStaffTotals"
        Me.TblSpaceAndStaffTotalsBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblSpaceAndStaffTotalsTableAdapter
        '
        Me.TblSpaceAndStaffTotalsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.tblExtrasTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblProgramsTableAdapter = Nothing
        Me.TableAdapterManager.tblReportsTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSpaceAndStaffTotalsTableAdapter = Me.TblSpaceAndStaffTotalsTableAdapter
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSpaceAndStaffTotalsBindingNavigator
        '
        Me.TblSpaceAndStaffTotalsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblSpaceAndStaffTotalsBindingNavigator.BindingSource = Me.TblSpaceAndStaffTotalsBindingSource
        Me.TblSpaceAndStaffTotalsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSpaceAndStaffTotalsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblSpaceAndStaffTotalsBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TblSpaceAndStaffTotalsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblSpaceAndStaffTotalsBindingNavigatorSaveItem})
        Me.TblSpaceAndStaffTotalsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSpaceAndStaffTotalsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSpaceAndStaffTotalsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSpaceAndStaffTotalsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSpaceAndStaffTotalsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSpaceAndStaffTotalsBindingNavigator.Name = "TblSpaceAndStaffTotalsBindingNavigator"
        Me.TblSpaceAndStaffTotalsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSpaceAndStaffTotalsBindingNavigator.Size = New System.Drawing.Size(989, 31)
        Me.TblSpaceAndStaffTotalsBindingNavigator.TabIndex = 0
        Me.TblSpaceAndStaffTotalsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'TblSpaceAndStaffTotalsBindingNavigatorSaveItem
        '
        Me.TblSpaceAndStaffTotalsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblSpaceAndStaffTotalsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblSpaceAndStaffTotalsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblSpaceAndStaffTotalsBindingNavigatorSaveItem.Name = "TblSpaceAndStaffTotalsBindingNavigatorSaveItem"
        Me.TblSpaceAndStaffTotalsBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.TblSpaceAndStaffTotalsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblSpaceAndStaffTotalsDataGridView
        '
        Me.TblSpaceAndStaffTotalsDataGridView.AutoGenerateColumns = False
        Me.TblSpaceAndStaffTotalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSpaceAndStaffTotalsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Total_Staff, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn4})
        Me.TblSpaceAndStaffTotalsDataGridView.DataSource = Me.TblSpaceAndStaffTotalsBindingSource
        Me.TblSpaceAndStaffTotalsDataGridView.Location = New System.Drawing.Point(12, 52)
        Me.TblSpaceAndStaffTotalsDataGridView.Name = "TblSpaceAndStaffTotalsDataGridView"
        Me.TblSpaceAndStaffTotalsDataGridView.RowTemplate.Height = 28
        Me.TblSpaceAndStaffTotalsDataGridView.Size = New System.Drawing.Size(924, 494)
        Me.TblSpaceAndStaffTotalsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Total_Staff
        '
        Me.Total_Staff.DataPropertyName = "Total_Staff"
        Me.Total_Staff.HeaderText = "Total Staff"
        Me.Total_Staff.Name = "Total_Staff"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn1.HeaderText = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 400
        '
        'frmSpaceAndStaffTotals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(989, 558)
        Me.Controls.Add(Me.TblSpaceAndStaffTotalsDataGridView)
        Me.Controls.Add(Me.TblSpaceAndStaffTotalsBindingNavigator)
        Me.Name = "frmSpaceAndStaffTotals"
        Me.Text = "frmSpaceAndStaffTotals"
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSpaceAndStaffTotalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSpaceAndStaffTotalsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSpaceAndStaffTotalsBindingNavigator.ResumeLayout(False)
        Me.TblSpaceAndStaffTotalsBindingNavigator.PerformLayout()
        CType(Me.TblSpaceAndStaffTotalsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Staff_AllocationsDataSet As Staff_AllocationsDataSet
    Friend WithEvents TblSpaceAndStaffTotalsBindingSource As BindingSource
    Friend WithEvents TblSpaceAndStaffTotalsTableAdapter As Staff_AllocationsDataSetTableAdapters.tblSpaceAndStaffTotalsTableAdapter
    Friend WithEvents TableAdapterManager As Staff_AllocationsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSpaceAndStaffTotalsBindingNavigator As BindingNavigator
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
    Friend WithEvents TblSpaceAndStaffTotalsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblSpaceAndStaffTotalsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Total_Staff As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

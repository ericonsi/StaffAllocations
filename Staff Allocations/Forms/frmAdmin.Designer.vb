<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Staff_AllocationsDataSet = New Staff_Allocations.Staff_AllocationsDataSet()
        Me.TblSettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSettingsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblSettingsTableAdapter()
        Me.TableAdapterManager = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager()
        Me.TblSettingsDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSettingsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSettingsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSMA_TimeStamp = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSettingsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSettingsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSettingsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settings"
        '
        'Staff_AllocationsDataSet
        '
        Me.Staff_AllocationsDataSet.DataSetName = "Staff_AllocationsDataSet"
        Me.Staff_AllocationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSettingsBindingSource
        '
        Me.TblSettingsBindingSource.DataMember = "tblSettings"
        Me.TblSettingsBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblSettingsTableAdapter
        '
        Me.TblSettingsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.tblExtrasTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblProgramsTableAdapter = Nothing
        Me.TableAdapterManager.tblReportsTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Me.TblSettingsTableAdapter
        Me.TableAdapterManager.tblSpaceAndStaffTotalsTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSettingsDataGridView
        '
        Me.TblSettingsDataGridView.AutoGenerateColumns = False
        Me.TblSettingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSettingsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.SSMA_TimeStamp, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Comments})
        Me.TblSettingsDataGridView.DataSource = Me.TblSettingsBindingSource
        Me.TblSettingsDataGridView.Location = New System.Drawing.Point(18, 117)
        Me.TblSettingsDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TblSettingsDataGridView.Name = "TblSettingsDataGridView"
        Me.TblSettingsDataGridView.Size = New System.Drawing.Size(1080, 338)
        Me.TblSettingsDataGridView.TabIndex = 2
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'TblSettingsBindingNavigatorSaveItem
        '
        Me.TblSettingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblSettingsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblSettingsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblSettingsBindingNavigatorSaveItem.Name = "TblSettingsBindingNavigatorSaveItem"
        Me.TblSettingsBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.TblSettingsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblSettingsBindingNavigator
        '
        Me.TblSettingsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblSettingsBindingNavigator.BindingSource = Me.TblSettingsBindingSource
        Me.TblSettingsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSettingsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblSettingsBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TblSettingsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblSettingsBindingNavigatorSaveItem})
        Me.TblSettingsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSettingsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSettingsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSettingsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSettingsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSettingsBindingNavigator.Name = "TblSettingsBindingNavigator"
        Me.TblSettingsBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.TblSettingsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSettingsBindingNavigator.Size = New System.Drawing.Size(1446, 31)
        Me.TblSettingsBindingNavigator.TabIndex = 1
        Me.TblSettingsBindingNavigator.Text = "BindingNavigator1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'SSMA_TimeStamp
        '
        Me.SSMA_TimeStamp.DataPropertyName = "SSMA_TimeStamp"
        Me.SSMA_TimeStamp.HeaderText = "SSMA_TimeStamp"
        Me.SSMA_TimeStamp.Name = "SSMA_TimeStamp"
        Me.SSMA_TimeStamp.ReadOnly = True
        Me.SSMA_TimeStamp.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Setting_Type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Setting_Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Setting"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Setting"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Data_Type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data_Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Comments
        '
        Me.Comments.DataPropertyName = "Comments"
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        Me.Comments.Width = 400
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1446, 660)
        Me.Controls.Add(Me.TblSettingsDataGridView)
        Me.Controls.Add(Me.TblSettingsBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSettingsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSettingsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSettingsBindingNavigator.ResumeLayout(False)
        Me.TblSettingsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Staff_AllocationsDataSet As Staff_Allocations.Staff_AllocationsDataSet
    Friend WithEvents TblSettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSettingsTableAdapter As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblSettingsTableAdapter
    Friend WithEvents TableAdapterManager As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSettingsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblSettingsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblSettingsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SSMA_TimeStamp As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Comments As DataGridViewTextBoxColumn
End Class

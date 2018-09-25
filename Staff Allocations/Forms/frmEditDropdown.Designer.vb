<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditDropdown
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
        Me.Staff_AllocationsDataSet = New Staff_Allocations.Staff_AllocationsDataSet()
        Me.TblProgramNameDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProgramNameDetailsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblProgramNameDetailsTableAdapter()
        Me.TableAdapterManager = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager()
        Me.TblDepartmentDetailsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblDepartmentDetailsTableAdapter()
        Me.TblDropDownsForSitesTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblDropDownsForSitesTableAdapter()
        Me.TblDropDownsForSitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSettingsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblSettingsTableAdapter()
        Me.dgvEditDropDowns = New System.Windows.Forms.DataGridView()
        Me.TblDepartmentDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramNameDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDropDownsForSitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEditDropDowns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_AllocationsDataSet
        '
        Me.Staff_AllocationsDataSet.DataSetName = "Staff_AllocationsDataSet"
        Me.Staff_AllocationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProgramNameDetailsBindingSource
        '
        Me.TblProgramNameDetailsBindingSource.DataMember = "tblProgramNameDetails"
        Me.TblProgramNameDetailsBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblProgramNameDetailsTableAdapter
        '
        Me.TblProgramNameDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.tblAuditForDeletesTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentDetailsTableAdapter = Me.TblDepartmentDetailsTableAdapter
        Me.TableAdapterManager.tblDropDownsForSitesTableAdapter = Me.TblDropDownsForSitesTableAdapter
        Me.TableAdapterManager.tblExtrasTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblProgramNameDetailsTableAdapter = Me.TblProgramNameDetailsTableAdapter
        Me.TableAdapterManager.tblProgramsTableAdapter = Nothing
        Me.TableAdapterManager.tblReportsTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSpaceAndStaffTotalsTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblDepartmentDetailsTableAdapter
        '
        Me.TblDepartmentDetailsTableAdapter.ClearBeforeFill = True
        '
        'TblDropDownsForSitesTableAdapter
        '
        Me.TblDropDownsForSitesTableAdapter.ClearBeforeFill = True
        '
        'TblDropDownsForSitesBindingSource
        '
        Me.TblDropDownsForSitesBindingSource.DataMember = "tblDropDownsForSites"
        Me.TblDropDownsForSitesBindingSource.DataSource = Me.Staff_AllocationsDataSet
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
        'dgvEditDropDowns
        '
        Me.dgvEditDropDowns.AllowUserToDeleteRows = False
        Me.dgvEditDropDowns.AutoGenerateColumns = False
        Me.dgvEditDropDowns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEditDropDowns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.EntryDataGridViewTextBoxColumn, Me.EntryOrderDataGridViewTextBoxColumn})
        Me.dgvEditDropDowns.DataSource = Me.TblDropDownsForSitesBindingSource
        Me.dgvEditDropDowns.Location = New System.Drawing.Point(12, 32)
        Me.dgvEditDropDowns.Name = "dgvEditDropDowns"
        Me.dgvEditDropDowns.Size = New System.Drawing.Size(523, 493)
        Me.dgvEditDropDowns.TabIndex = 1
        '
        'TblDepartmentDetailsBindingSource
        '
        Me.TblDepartmentDetailsBindingSource.DataMember = "tblDepartmentDetails"
        Me.TblDepartmentDetailsBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntryDataGridViewTextBoxColumn
        '
        Me.EntryDataGridViewTextBoxColumn.DataPropertyName = "Entry"
        Me.EntryDataGridViewTextBoxColumn.HeaderText = "Entry"
        Me.EntryDataGridViewTextBoxColumn.Name = "EntryDataGridViewTextBoxColumn"
        '
        'EntryOrderDataGridViewTextBoxColumn
        '
        Me.EntryOrderDataGridViewTextBoxColumn.DataPropertyName = "EntryOrder"
        Me.EntryOrderDataGridViewTextBoxColumn.HeaderText = "EntryOrder"
        Me.EntryOrderDataGridViewTextBoxColumn.Name = "EntryOrderDataGridViewTextBoxColumn"
        '
        'frmEditDropdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 539)
        Me.Controls.Add(Me.dgvEditDropDowns)
        Me.Name = "frmEditDropdown"
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramNameDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDropDownsForSitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEditDropDowns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Staff_AllocationsDataSet As Staff_AllocationsDataSet
    Friend WithEvents TblProgramNameDetailsBindingSource As BindingSource
    Friend WithEvents TblProgramNameDetailsTableAdapter As Staff_AllocationsDataSetTableAdapters.tblProgramNameDetailsTableAdapter
    Friend WithEvents TableAdapterManager As Staff_AllocationsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblDropDownsForSitesBindingSource As BindingSource
    Friend WithEvents TblDropDownsForSitesTableAdapter As Staff_AllocationsDataSetTableAdapters.tblDropDownsForSitesTableAdapter
    Friend WithEvents TblSettingsBindingSource As BindingSource
    Friend WithEvents TblSettingsTableAdapter As Staff_AllocationsDataSetTableAdapters.tblSettingsTableAdapter
    Friend WithEvents dgvEditDropDowns As DataGridView
    Friend WithEvents TblDepartmentDetailsBindingSource As BindingSource
    Friend WithEvents TblDepartmentDetailsTableAdapter As Staff_AllocationsDataSetTableAdapters.tblDepartmentDetailsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntryOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddProgramOrStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddProgramOrStaff))
        Me.bnBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TblProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_AllocationsDataSet = New Staff_Allocations.Staff_AllocationsDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblProgramsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblStaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radStaff = New System.Windows.Forms.RadioButton()
        Me.radProgram = New System.Windows.Forms.RadioButton()
        Me.Add_Datagridview = New System.Windows.Forms.DataGridView()
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDropDownsForSitesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffAllocationsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProgramsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblProgramsTableAdapter()
        Me.TableAdapterManager = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager()
        Me.TblStaffTableAdapter1 = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblStaffTableAdapter()
        Me.Add_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProgramsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStaffBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDropDownsForSitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDropDownsForSitesTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblDropDownsForSitesTableAdapter()
        Me.TblDropDownsForSitesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDropDownsForSitesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddNewProgramName = New System.Windows.Forms.Button()
        Me.btnAddNewSite = New System.Windows.Forms.Button()
        Me.btnAddNewDepartment = New System.Windows.Forms.Button()
        Me.btnAddNewDepartmentHead = New System.Windows.Forms.Button()
        Me.JobTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblDropDownsForDepartmentHeadsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDropDownsForDepartmentHeadsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblDropDownsForDepartmentHeadsTableAdapter()
        CType(Me.bnBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnBindingNavigator.SuspendLayout()
        CType(Me.TblProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Add_Datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDropDownsForSitesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffAllocationsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDropDownsForSitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDropDownsForSitesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDropDownsForSitesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDropDownsForDepartmentHeadsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnBindingNavigator
        '
        Me.bnBindingNavigator.AddNewItem = Nothing
        Me.bnBindingNavigator.BindingSource = Me.TblProgramsBindingSource
        Me.bnBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.bnBindingNavigator.DeleteItem = Nothing
        Me.bnBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.bnBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem})
        Me.bnBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.bnBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnBindingNavigator.Name = "bnBindingNavigator"
        Me.bnBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnBindingNavigator.Size = New System.Drawing.Size(1276, 31)
        Me.bnBindingNavigator.TabIndex = 0
        Me.bnBindingNavigator.Text = "BindingNavigator1"
        '
        'TblProgramsBindingSource
        '
        Me.TblProgramsBindingSource.DataMember = "tblPrograms"
        Me.TblProgramsBindingSource.DataSource = Me.Staff_AllocationsDataSet
        Me.TblProgramsBindingSource.Sort = "Program"
        '
        'Staff_AllocationsDataSet
        '
        Me.Staff_AllocationsDataSet.DataSetName = "Staff_AllocationsDataSet"
        Me.Staff_AllocationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblProgramsDataGridView
        '
        Me.TblProgramsDataGridView.AutoGenerateColumns = False
        Me.TblProgramsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProgramsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblProgramsDataGridView.DataSource = Me.TblProgramsBindingSource
        Me.TblProgramsDataGridView.Location = New System.Drawing.Point(138, 375)
        Me.TblProgramsDataGridView.Name = "TblProgramsDataGridView"
        Me.TblProgramsDataGridView.Size = New System.Drawing.Size(62, 54)
        Me.TblProgramsDataGridView.TabIndex = 2
        Me.TblProgramsDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProgramID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProgramID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Program"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Program"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn1.HeaderText = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "data_enterer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "data_enterer"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "insertion_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "insertion_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TblStaffDataGridView
        '
        Me.TblStaffDataGridView.AutoGenerateColumns = False
        Me.TblStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblStaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewImageColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TblStaffDataGridView.DataSource = Me.TblStaffBindingSource
        Me.TblStaffDataGridView.Location = New System.Drawing.Point(79, 375)
        Me.TblStaffDataGridView.Name = "TblStaffDataGridView"
        Me.TblStaffDataGridView.Size = New System.Drawing.Size(52, 54)
        Me.TblStaffDataGridView.TabIndex = 3
        Me.TblStaffDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "StaffID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "StaffID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Staff"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Staff"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.DataPropertyName = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn2.HeaderText = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "data_enterer"
        Me.DataGridViewTextBoxColumn8.HeaderText = "data_enterer"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "insertion_date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "insertion_date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'TblStaffBindingSource
        '
        Me.TblStaffBindingSource.DataMember = "tblStaff"
        Me.TblStaffBindingSource.DataSource = Me.Staff_AllocationsDataSet
        Me.TblStaffBindingSource.Sort = "Staff"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.radStaff)
        Me.GroupBox1.Controls.Add(Me.radProgram)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(180, 67)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'radStaff
        '
        Me.radStaff.BackColor = System.Drawing.Color.LightGreen
        Me.radStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStaff.Location = New System.Drawing.Point(18, 10)
        Me.radStaff.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radStaff.Name = "radStaff"
        Me.radStaff.Size = New System.Drawing.Size(125, 30)
        Me.radStaff.TabIndex = 0
        Me.radStaff.Text = "Edit Staff List"
        Me.radStaff.UseVisualStyleBackColor = False
        '
        'radProgram
        '
        Me.radProgram.BackColor = System.Drawing.Color.LightGreen
        Me.radProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radProgram.Location = New System.Drawing.Point(18, 36)
        Me.radProgram.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radProgram.Name = "radProgram"
        Me.radProgram.Size = New System.Drawing.Size(133, 24)
        Me.radProgram.TabIndex = 1
        Me.radProgram.Text = "Edit Program List"
        Me.radProgram.UseVisualStyleBackColor = False
        '
        'Add_Datagridview
        '
        Me.Add_Datagridview.AutoGenerateColumns = False
        Me.Add_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Add_Datagridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ActiveDataGridViewCheckBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleDataGridViewTextBoxColumn, Me.SiteDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.EmployeeNumberDataGridViewTextBoxColumn, Me.GLCodeDataGridViewTextBoxColumn, Me.JobTitleDataGridViewTextBoxColumn, Me.Comments})
        Me.Add_Datagridview.DataSource = Me.TblStaffBindingSource
        Me.Add_Datagridview.Location = New System.Drawing.Point(14, 101)
        Me.Add_Datagridview.Name = "Add_Datagridview"
        Me.Add_Datagridview.Size = New System.Drawing.Size(1257, 501)
        Me.Add_Datagridview.TabIndex = 5
        '
        'Comments
        '
        Me.Comments.DataPropertyName = "Comments"
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        '
        'TblDropDownsForSitesBindingSource3
        '
        Me.TblDropDownsForSitesBindingSource3.DataMember = "tblDropDownsForSites"
        Me.TblDropDownsForSitesBindingSource3.DataSource = Me.StaffAllocationsDataSetBindingSource
        '
        'StaffAllocationsDataSetBindingSource
        '
        Me.StaffAllocationsDataSetBindingSource.DataSource = Me.Staff_AllocationsDataSet
        Me.StaffAllocationsDataSetBindingSource.Position = 0
        '
        'TblStaffBindingSource1
        '
        Me.TblStaffBindingSource1.DataMember = "tblStaff"
        Me.TblStaffBindingSource1.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblProgramsTableAdapter
        '
        Me.TblProgramsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.tblAuditForDeletesTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblDropDownsForDepartmentHeadsTableAdapter = Nothing
        Me.TableAdapterManager.tblDropDownsForSitesTableAdapter = Nothing
        Me.TableAdapterManager.tblExtrasTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblProgramNameDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblProgramsTableAdapter = Me.TblProgramsTableAdapter
        Me.TableAdapterManager.tblReportsTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSpaceAndStaffTotalsTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Me.TblStaffTableAdapter1
        Me.TableAdapterManager.UpdateOrder = Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblStaffTableAdapter1
        '
        Me.TblStaffTableAdapter1.ClearBeforeFill = True
        '
        'Add_BindingSource
        '
        Me.Add_BindingSource.DataSource = Me.Staff_AllocationsDataSet
        Me.Add_BindingSource.Position = 0
        '
        'TblProgramsBindingSource1
        '
        Me.TblProgramsBindingSource1.DataMember = "tblPrograms"
        Me.TblProgramsBindingSource1.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblStaffBindingSource2
        '
        Me.TblStaffBindingSource2.DataMember = "tblStaff"
        Me.TblStaffBindingSource2.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblDropDownsForSitesBindingSource
        '
        Me.TblDropDownsForSitesBindingSource.DataMember = "tblDropDownsForSites"
        Me.TblDropDownsForSitesBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblDropDownsForSitesTableAdapter
        '
        Me.TblDropDownsForSitesTableAdapter.ClearBeforeFill = True
        '
        'TblDropDownsForSitesBindingSource1
        '
        Me.TblDropDownsForSitesBindingSource1.DataMember = "tblDropDownsForSites"
        Me.TblDropDownsForSitesBindingSource1.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblDropDownsForSitesBindingSource2
        '
        Me.TblDropDownsForSitesBindingSource2.DataMember = "tblDropDownsForSites"
        Me.TblDropDownsForSitesBindingSource2.DataSource = Me.Staff_AllocationsDataSet
        '
        'btnAddNewProgramName
        '
        Me.btnAddNewProgramName.Location = New System.Drawing.Point(240, 68)
        Me.btnAddNewProgramName.Name = "btnAddNewProgramName"
        Me.btnAddNewProgramName.Size = New System.Drawing.Size(150, 23)
        Me.btnAddNewProgramName.TabIndex = 6
        Me.btnAddNewProgramName.Text = "Add/Edit Funder"
        Me.btnAddNewProgramName.UseVisualStyleBackColor = True
        '
        'btnAddNewSite
        '
        Me.btnAddNewSite.Location = New System.Drawing.Point(240, 45)
        Me.btnAddNewSite.Name = "btnAddNewSite"
        Me.btnAddNewSite.Size = New System.Drawing.Size(150, 23)
        Me.btnAddNewSite.TabIndex = 7
        Me.btnAddNewSite.Text = "Add/Edit Site"
        Me.btnAddNewSite.UseVisualStyleBackColor = True
        '
        'btnAddNewDepartment
        '
        Me.btnAddNewDepartment.Location = New System.Drawing.Point(396, 68)
        Me.btnAddNewDepartment.Name = "btnAddNewDepartment"
        Me.btnAddNewDepartment.Size = New System.Drawing.Size(150, 23)
        Me.btnAddNewDepartment.TabIndex = 8
        Me.btnAddNewDepartment.Text = "Add/Edit Grant"
        Me.btnAddNewDepartment.UseVisualStyleBackColor = True
        '
        'btnAddNewDepartmentHead
        '
        Me.btnAddNewDepartmentHead.Location = New System.Drawing.Point(396, 45)
        Me.btnAddNewDepartmentHead.Name = "btnAddNewDepartmentHead"
        Me.btnAddNewDepartmentHead.Size = New System.Drawing.Size(150, 23)
        Me.btnAddNewDepartmentHead.TabIndex = 9
        Me.btnAddNewDepartmentHead.Text = "Add/Edit Department Head"
        Me.btnAddNewDepartmentHead.UseVisualStyleBackColor = True
        '
        'JobTitleDataGridViewTextBoxColumn
        '
        Me.JobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle"
        Me.JobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle"
        Me.JobTitleDataGridViewTextBoxColumn.Name = "JobTitleDataGridViewTextBoxColumn"
        '
        'GLCodeDataGridViewTextBoxColumn
        '
        Me.GLCodeDataGridViewTextBoxColumn.DataPropertyName = "GL_Code"
        Me.GLCodeDataGridViewTextBoxColumn.HeaderText = "GL_Code"
        Me.GLCodeDataGridViewTextBoxColumn.Name = "GLCodeDataGridViewTextBoxColumn"
        '
        'EmployeeNumberDataGridViewTextBoxColumn
        '
        Me.EmployeeNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumber"
        Me.EmployeeNumberDataGridViewTextBoxColumn.HeaderText = "EmployeeNumber"
        Me.EmployeeNumberDataGridViewTextBoxColumn.Name = "EmployeeNumberDataGridViewTextBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'SiteDataGridViewTextBoxColumn
        '
        Me.SiteDataGridViewTextBoxColumn.DataPropertyName = "Site"
        Me.SiteDataGridViewTextBoxColumn.HeaderText = "Site"
        Me.SiteDataGridViewTextBoxColumn.Name = "SiteDataGridViewTextBoxColumn"
        '
        'MiddleDataGridViewTextBoxColumn
        '
        Me.MiddleDataGridViewTextBoxColumn.DataPropertyName = "Middle"
        Me.MiddleDataGridViewTextBoxColumn.HeaderText = "Middle"
        Me.MiddleDataGridViewTextBoxColumn.Name = "MiddleDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'ActiveDataGridViewCheckBoxColumn
        '
        Me.ActiveDataGridViewCheckBoxColumn.DataPropertyName = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.HeaderText = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.Name = "ActiveDataGridViewCheckBoxColumn"
        '
        'TblDropDownsForDepartmentHeadsBindingSource
        '
        Me.TblDropDownsForDepartmentHeadsBindingSource.DataMember = "tblDropDownsForDepartmentHeads"
        Me.TblDropDownsForDepartmentHeadsBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblDropDownsForDepartmentHeadsTableAdapter
        '
        Me.TblDropDownsForDepartmentHeadsTableAdapter.ClearBeforeFill = True
        '
        'frmAddProgramOrStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1276, 648)
        Me.Controls.Add(Me.btnAddNewDepartmentHead)
        Me.Controls.Add(Me.btnAddNewDepartment)
        Me.Controls.Add(Me.btnAddNewSite)
        Me.Controls.Add(Me.btnAddNewProgramName)
        Me.Controls.Add(Me.Add_Datagridview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TblStaffDataGridView)
        Me.Controls.Add(Me.TblProgramsDataGridView)
        Me.Controls.Add(Me.bnBindingNavigator)
        Me.Name = "frmAddProgramOrStaff"
        CType(Me.bnBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnBindingNavigator.ResumeLayout(False)
        Me.bnBindingNavigator.PerformLayout()
        CType(Me.TblProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Add_Datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDropDownsForSitesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffAllocationsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDropDownsForSitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDropDownsForSitesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDropDownsForSitesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDropDownsForDepartmentHeadsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Staff_AllocationsDataSet As Staff_Allocations.Staff_AllocationsDataSet
    Friend WithEvents TblProgramsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProgramsTableAdapter As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblProgramsTableAdapter
    Friend WithEvents TableAdapterManager As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents bnBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblStaffTableAdapter1 As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblStaffTableAdapter
    Friend WithEvents TblStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Add_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProgramsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblStaffDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblStaffBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblProgramsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblStaffBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radStaff As System.Windows.Forms.RadioButton
    Friend WithEvents radProgram As System.Windows.Forms.RadioButton
    Friend WithEvents Add_Datagridview As System.Windows.Forms.DataGridView
    Friend WithEvents TblDropDownsForSitesBindingSource As BindingSource
    Friend WithEvents TblDropDownsForSitesTableAdapter As Staff_AllocationsDataSetTableAdapters.tblDropDownsForSitesTableAdapter
    Friend WithEvents TblDropDownsForSitesBindingSource1 As BindingSource
    Friend WithEvents TblDropDownsForSitesBindingSource2 As BindingSource
    Friend WithEvents TblDropDownsForSitesBindingSource3 As BindingSource
    Friend WithEvents StaffAllocationsDataSetBindingSource As BindingSource
    Friend WithEvents btnAddNewProgramName As Button
    Friend WithEvents btnAddNewSite As Button
    Friend WithEvents btnAddNewDepartment As Button
    Friend WithEvents Comments As DataGridViewTextBoxColumn
    Friend WithEvents btnAddNewDepartmentHead As Button
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GLCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblDropDownsForDepartmentHeadsBindingSource As BindingSource
    Friend WithEvents TblDropDownsForDepartmentHeadsTableAdapter As Staff_AllocationsDataSetTableAdapters.tblDropDownsForDepartmentHeadsTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim lblProgComments As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.radStaff = New System.Windows.Forms.RadioButton()
        Me.radProgram = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Staff_AllocationsDataSet = New Staff_Allocations.Staff_AllocationsDataSet()
        Me.TblProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProgramsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblProgramsTableAdapter()
        Me.TableAdapterManager = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager()
        Me.TblMonthsTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblMonthsTableAdapter()
        Me.cmbStaffOrPrograms = New System.Windows.Forms.ComboBox()
        Me.TblStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMonthsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LegMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LegMonthTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.LegMonthTableAdapter()
        Me.cmbLegMonth = New System.Windows.Forms.ComboBox()
        Me.TblStaffTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblStaffTableAdapter()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblAllocations = New System.Windows.Forms.Label()
        Me.cmbAdd = New System.Windows.Forms.ComboBox()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.TblProgramsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProgramsComboBox = New System.Windows.Forms.ComboBox()
        Me.TblStaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStaffBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStaffComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rtbStaffComments = New System.Windows.Forms.RichTextBox()
        Me.rtbProgramComments = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TblMonthsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMonthsComboBox = New System.Windows.Forms.ComboBox()
        Me.LegMonthBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LegMonthComboBox = New System.Windows.Forms.ComboBox()
        Me.dgvAllocatedTotals = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        lblProgComments = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMonthsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMonthsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegMonthBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAllocatedTotals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProgComments
        '
        lblProgComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblProgComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProgComments.Location = New System.Drawing.Point(11, 227)
        lblProgComments.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        lblProgComments.Name = "lblProgComments"
        lblProgComments.Size = New System.Drawing.Size(84, 23)
        lblProgComments.TabIndex = 10
        lblProgComments.Text = "Comments:"
        '
        'radStaff
        '
        Me.radStaff.BackColor = System.Drawing.Color.Tomato
        Me.radStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStaff.Location = New System.Drawing.Point(37, 16)
        Me.radStaff.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radStaff.Name = "radStaff"
        Me.radStaff.Size = New System.Drawing.Size(160, 30)
        Me.radStaff.TabIndex = 0
        Me.radStaff.TabStop = True
        Me.radStaff.Text = "Allocate By Staff"
        Me.radStaff.UseVisualStyleBackColor = False
        '
        'radProgram
        '
        Me.radProgram.BackColor = System.Drawing.Color.Tomato
        Me.radProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radProgram.Location = New System.Drawing.Point(37, 44)
        Me.radProgram.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radProgram.Name = "radProgram"
        Me.radProgram.Size = New System.Drawing.Size(160, 23)
        Me.radProgram.TabIndex = 1
        Me.radProgram.TabStop = True
        Me.radProgram.Text = "Allocate By Program"
        Me.radProgram.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Tomato
        Me.GroupBox1.Controls.Add(Me.radStaff)
        Me.GroupBox1.Controls.Add(Me.radProgram)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(13, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(219, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Allocation:"
        '
        'Staff_AllocationsDataSet
        '
        Me.Staff_AllocationsDataSet.DataSetName = "Staff_AllocationsDataSet"
        Me.Staff_AllocationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProgramsBindingSource
        '
        Me.TblProgramsBindingSource.DataMember = "tblPrograms"
        Me.TblProgramsBindingSource.DataSource = Me.Staff_AllocationsDataSet
        Me.TblProgramsBindingSource.Sort = "Program"
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
        Me.TableAdapterManager.tblMonthsTableAdapter = Me.TblMonthsTableAdapter
        Me.TableAdapterManager.tblProgramNameDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblProgramsTableAdapter = Me.TblProgramsTableAdapter
        Me.TableAdapterManager.tblReportsTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSpaceAndStaffTotalsTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblMonthsTableAdapter
        '
        Me.TblMonthsTableAdapter.ClearBeforeFill = True
        '
        'cmbStaffOrPrograms
        '
        Me.cmbStaffOrPrograms.BackColor = System.Drawing.Color.White
        Me.cmbStaffOrPrograms.DataSource = Me.TblStaffBindingSource
        Me.cmbStaffOrPrograms.DisplayMember = "Staff"
        Me.cmbStaffOrPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffOrPrograms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStaffOrPrograms.FormattingEnabled = True
        Me.cmbStaffOrPrograms.Location = New System.Drawing.Point(102, 118)
        Me.cmbStaffOrPrograms.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbStaffOrPrograms.Name = "cmbStaffOrPrograms"
        Me.cmbStaffOrPrograms.Size = New System.Drawing.Size(130, 24)
        Me.cmbStaffOrPrograms.TabIndex = 2
        Me.cmbStaffOrPrograms.TabStop = False
        Me.cmbStaffOrPrograms.ValueMember = "StaffID"
        '
        'TblStaffBindingSource
        '
        Me.TblStaffBindingSource.DataMember = "tblStaff"
        Me.TblStaffBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblMonthsBindingSource
        '
        Me.TblMonthsBindingSource.DataMember = "tblMonths"
        Me.TblMonthsBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'LegMonthBindingSource
        '
        Me.LegMonthBindingSource.DataMember = "LegMonth"
        Me.LegMonthBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'LegMonthTableAdapter
        '
        Me.LegMonthTableAdapter.ClearBeforeFill = True
        '
        'cmbLegMonth
        '
        Me.cmbLegMonth.BackColor = System.Drawing.Color.White
        Me.cmbLegMonth.DataSource = Me.TblMonthsBindingSource
        Me.cmbLegMonth.DisplayMember = "Date_Ordinal"
        Me.cmbLegMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLegMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLegMonth.FormattingEnabled = True
        Me.cmbLegMonth.Location = New System.Drawing.Point(102, 145)
        Me.cmbLegMonth.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbLegMonth.Name = "cmbLegMonth"
        Me.cmbLegMonth.Size = New System.Drawing.Size(130, 24)
        Me.cmbLegMonth.TabIndex = 3
        Me.cmbLegMonth.TabStop = False
        Me.cmbLegMonth.ValueMember = "Date_Ordinal"
        '
        'TblStaffTableAdapter
        '
        Me.TblStaffTableAdapter.ClearBeforeFill = True
        '
        'lblStaff
        '
        Me.lblStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.Location = New System.Drawing.Point(11, 120)
        Me.lblStaff.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(84, 23)
        Me.lblStaff.TabIndex = 4
        Me.lblStaff.Text = "Staff:"
        '
        'lblMonth
        '
        Me.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(11, 147)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(84, 21)
        Me.lblMonth.TabIndex = 5
        Me.lblMonth.Text = "Pay Period:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton5, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton6, Me.ToolStripButton4, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1154, 26)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(140, 23)
        Me.ToolStripButton3.Text = "Approve Selection"
        Me.ToolStripButton3.ToolTipText = "Reports"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.AutoSize = False
        Me.ToolStripButton5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(140, 23)
        Me.ToolStripButton5.Text = "Select All In Grid"
        Me.ToolStripButton5.ToolTipText = "Reports"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(140, 23)
        Me.ToolStripButton1.Text = "Edit Lists"
        Me.ToolStripButton1.ToolTipText = "Reports"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(140, 23)
        Me.ToolStripButton2.Text = "Reports"
        Me.ToolStripButton2.ToolTipText = "Reports"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.AutoSize = False
        Me.ToolStripButton6.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(140, 23)
        Me.ToolStripButton6.Text = "Refresh"
        Me.ToolStripButton6.ToolTipText = "Reports"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(140, 23)
        Me.ToolStripButton4.Text = "Admin"
        Me.ToolStripButton4.ToolTipText = "Reports"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.AutoSize = False
        Me.ToolStripButton7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(140, 23)
        Me.ToolStripButton7.Text = "Extras"
        Me.ToolStripButton7.ToolTipText = "Reports"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(262, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(877, 241)
        Me.DataGridView1.TabIndex = 13
        '
        'lblAllocations
        '
        Me.lblAllocations.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblAllocations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllocations.Location = New System.Drawing.Point(262, 37)
        Me.lblAllocations.Name = "lblAllocations"
        Me.lblAllocations.Size = New System.Drawing.Size(487, 23)
        Me.lblAllocations.TabIndex = 14
        Me.lblAllocations.Text = "Label1"
        Me.lblAllocations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbAdd
        '
        Me.cmbAdd.BackColor = System.Drawing.Color.White
        Me.cmbAdd.DataSource = Me.TblProgramsBindingSource
        Me.cmbAdd.DisplayMember = "Program"
        Me.cmbAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdd.FormattingEnabled = True
        Me.cmbAdd.Location = New System.Drawing.Point(989, 37)
        Me.cmbAdd.Name = "cmbAdd"
        Me.cmbAdd.Size = New System.Drawing.Size(150, 24)
        Me.cmbAdd.TabIndex = 15
        Me.cmbAdd.ValueMember = "ProgramID"
        '
        'lblAdd
        '
        Me.lblAdd.BackColor = System.Drawing.Color.Tomato
        Me.lblAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdd.Location = New System.Drawing.Point(882, 37)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(101, 23)
        Me.lblAdd.TabIndex = 17
        Me.lblAdd.Text = "Label3"
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TblProgramsBindingSource1
        '
        Me.TblProgramsBindingSource1.DataMember = "tblPrograms"
        Me.TblProgramsBindingSource1.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblProgramsComboBox
        '
        Me.TblProgramsComboBox.BackColor = System.Drawing.Color.Tomato
        Me.TblProgramsComboBox.DataSource = Me.TblProgramsBindingSource
        Me.TblProgramsComboBox.DisplayMember = "Program"
        Me.TblProgramsComboBox.FormattingEnabled = True
        Me.TblProgramsComboBox.Location = New System.Drawing.Point(14, 387)
        Me.TblProgramsComboBox.Name = "TblProgramsComboBox"
        Me.TblProgramsComboBox.Size = New System.Drawing.Size(159, 24)
        Me.TblProgramsComboBox.TabIndex = 17
        Me.TblProgramsComboBox.ValueMember = "ProgramID"
        Me.TblProgramsComboBox.Visible = False
        '
        'TblStaffBindingSource1
        '
        Me.TblStaffBindingSource1.DataMember = "tblStaff"
        Me.TblStaffBindingSource1.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblStaffBindingSource2
        '
        Me.TblStaffBindingSource2.DataMember = "tblStaff"
        Me.TblStaffBindingSource2.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblStaffComboBox
        '
        Me.TblStaffComboBox.BackColor = System.Drawing.Color.Tomato
        Me.TblStaffComboBox.DataSource = Me.TblStaffBindingSource
        Me.TblStaffComboBox.DisplayMember = "Staff"
        Me.TblStaffComboBox.FormattingEnabled = True
        Me.TblStaffComboBox.Location = New System.Drawing.Point(13, 357)
        Me.TblStaffComboBox.Name = "TblStaffComboBox"
        Me.TblStaffComboBox.Size = New System.Drawing.Size(160, 24)
        Me.TblStaffComboBox.TabIndex = 17
        Me.TblStaffComboBox.ValueMember = "StaffID"
        Me.TblStaffComboBox.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(102, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.TabStop = False
        Me.Button1.Text = "See All Pay Periods"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rtbStaffComments
        '
        Me.rtbStaffComments.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStaffBindingSource, "Comments", True))
        Me.rtbStaffComments.Location = New System.Drawing.Point(13, 253)
        Me.rtbStaffComments.Name = "rtbStaffComments"
        Me.rtbStaffComments.Size = New System.Drawing.Size(222, 225)
        Me.rtbStaffComments.TabIndex = 19
        Me.rtbStaffComments.Text = ""
        '
        'rtbProgramComments
        '
        Me.rtbProgramComments.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbProgramComments.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblProgramsBindingSource, "Comments", True))
        Me.rtbProgramComments.Location = New System.Drawing.Point(11, 253)
        Me.rtbProgramComments.Name = "rtbProgramComments"
        Me.rtbProgramComments.Size = New System.Drawing.Size(221, 225)
        Me.rtbProgramComments.TabIndex = 20
        Me.rtbProgramComments.Text = ""
        Me.rtbProgramComments.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tomato
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(279, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Allocated:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Tomato
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(279, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Approved:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.Location = New System.Drawing.Point(262, 436)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(877, 241)
        Me.DataGridView2.TabIndex = 25
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.Color.White
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.Location = New System.Drawing.Point(385, 73)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(130, 23)
        Me.btnSelectAll.TabIndex = 26
        Me.btnSelectAll.Text = "Select All In Grid"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        Me.btnSelectAll.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(974, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Approve Selected Cells"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 454)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 100)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "In Development.  Testing Purposes Only."
        Me.Label3.Visible = False
        '
        'TblMonthsBindingSource1
        '
        Me.TblMonthsBindingSource1.DataMember = "tblMonths"
        Me.TblMonthsBindingSource1.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblMonthsComboBox
        '
        Me.TblMonthsComboBox.DataSource = Me.TblMonthsBindingSource1
        Me.TblMonthsComboBox.DisplayMember = "sMonth"
        Me.TblMonthsComboBox.FormattingEnabled = True
        Me.TblMonthsComboBox.Location = New System.Drawing.Point(13, 421)
        Me.TblMonthsComboBox.Name = "TblMonthsComboBox"
        Me.TblMonthsComboBox.Size = New System.Drawing.Size(159, 24)
        Me.TblMonthsComboBox.TabIndex = 28
        Me.TblMonthsComboBox.ValueMember = "DateID"
        Me.TblMonthsComboBox.Visible = False
        '
        'LegMonthBindingSource1
        '
        Me.LegMonthBindingSource1.DataMember = "LegMonth"
        Me.LegMonthBindingSource1.DataSource = Me.Staff_AllocationsDataSet
        '
        'LegMonthComboBox
        '
        Me.LegMonthComboBox.DataSource = Me.LegMonthBindingSource1
        Me.LegMonthComboBox.DisplayMember = "sMonth"
        Me.LegMonthComboBox.FormattingEnabled = True
        Me.LegMonthComboBox.Location = New System.Drawing.Point(13, 454)
        Me.LegMonthComboBox.Name = "LegMonthComboBox"
        Me.LegMonthComboBox.Size = New System.Drawing.Size(159, 24)
        Me.LegMonthComboBox.TabIndex = 28
        Me.LegMonthComboBox.ValueMember = "DateID"
        Me.LegMonthComboBox.Visible = False
        '
        'dgvAllocatedTotals
        '
        Me.dgvAllocatedTotals.AllowUserToAddRows = False
        Me.dgvAllocatedTotals.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvAllocatedTotals.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAllocatedTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllocatedTotals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAllocatedTotals.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAllocatedTotals.Location = New System.Drawing.Point(262, 348)
        Me.dgvAllocatedTotals.Name = "dgvAllocatedTotals"
        Me.dgvAllocatedTotals.ReadOnly = True
        Me.dgvAllocatedTotals.Size = New System.Drawing.Size(877, 40)
        Me.dgvAllocatedTotals.TabIndex = 29
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Column1"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Column2"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 52
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Column3"
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 52
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Column4"
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 52
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Column5"
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 52
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Column6"
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 52
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Column7"
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 52
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Column8"
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 52
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Column9"
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 52
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "Column10"
        Me.Column10.HeaderText = "Column10"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 52
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "Column11"
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 52
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "Column12"
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 52
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "Column13"
        Me.Column13.HeaderText = "Column13"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 699)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Version: 180925"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(1154, 724)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvAllocatedTotals)
        Me.Controls.Add(Me.LegMonthComboBox)
        Me.Controls.Add(Me.TblMonthsComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbStaffComments)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TblStaffComboBox)
        Me.Controls.Add(Me.TblProgramsComboBox)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.cmbAdd)
        Me.Controls.Add(Me.lblAllocations)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(lblProgComments)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblStaff)
        Me.Controls.Add(Me.cmbLegMonth)
        Me.Controls.Add(Me.cmbStaffOrPrograms)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rtbProgramComments)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmMain"
        Me.Text = "Staff Allocations"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMonthsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMonthsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegMonthBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAllocatedTotals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radStaff As System.Windows.Forms.RadioButton
    Friend WithEvents radProgram As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Staff_AllocationsDataSet As Staff_Allocations.Staff_AllocationsDataSet
    Friend WithEvents TblProgramsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProgramsTableAdapter As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblProgramsTableAdapter
    Friend WithEvents TableAdapterManager As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblMonthsTableAdapter As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblMonthsTableAdapter
    Friend WithEvents cmbStaffOrPrograms As System.Windows.Forms.ComboBox
    Friend WithEvents TblMonthsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LegMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LegMonthTableAdapter As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.LegMonthTableAdapter
    Friend WithEvents cmbLegMonth As System.Windows.Forms.ComboBox
    Friend WithEvents TblStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStaffTableAdapter As Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblStaffTableAdapter
    Friend WithEvents lblStaff As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblAllocations As System.Windows.Forms.Label
    Friend WithEvents cmbAdd As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents TblProgramsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblProgramsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblStaffBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblStaffBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblStaffComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents rtbStaffComments As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbProgramComments As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LegMonthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LegMonthBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblMonthsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblMonthsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents dgvAllocatedTotals As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
End Class

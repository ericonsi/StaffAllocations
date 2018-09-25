<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Staff_AllocationsDataSet = New Staff_Allocations.Staff_AllocationsDataSet()
        Me.TblExtrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblExtrasTableAdapter = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.tblExtrasTableAdapter()
        Me.TableAdapterManager = New Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager()
        Me.Extras_DatagridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Presenting_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extra_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extra_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExtrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Extras_DatagridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_AllocationsDataSet
        '
        Me.Staff_AllocationsDataSet.DataSetName = "Staff_AllocationsDataSet"
        Me.Staff_AllocationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblExtrasBindingSource
        '
        Me.TblExtrasBindingSource.DataMember = "tblExtras"
        Me.TblExtrasBindingSource.DataSource = Me.Staff_AllocationsDataSet
        '
        'TblExtrasTableAdapter
        '
        Me.TblExtrasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.tblExtrasTableAdapter = Me.TblExtrasTableAdapter
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblProgramsTableAdapter = Nothing
        Me.TableAdapterManager.tblReportsTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSpaceAndStaffTotalsTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Staff_Allocations.Staff_AllocationsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Extras_DatagridView
        '
        Me.Extras_DatagridView.AutoGenerateColumns = False
        Me.Extras_DatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Extras_DatagridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Presenting_Name, Me.Extra_Name, Me.Extra_Type, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn4})
        Me.Extras_DatagridView.DataSource = Me.TblExtrasBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Extras_DatagridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.Extras_DatagridView.Location = New System.Drawing.Point(12, 40)
        Me.Extras_DatagridView.Name = "Extras_DatagridView"
        Me.Extras_DatagridView.RowTemplate.Height = 28
        Me.Extras_DatagridView.Size = New System.Drawing.Size(1104, 260)
        Me.Extras_DatagridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Presenting_Name
        '
        Me.Presenting_Name.DataPropertyName = "Presenting_Name"
        Me.Presenting_Name.HeaderText = "Name"
        Me.Presenting_Name.Name = "Presenting_Name"
        Me.Presenting_Name.Width = 300
        '
        'Extra_Name
        '
        Me.Extra_Name.DataPropertyName = "Extra_Name"
        Me.Extra_Name.HeaderText = "Extra_Name"
        Me.Extra_Name.Name = "Extra_Name"
        Me.Extra_Name.Visible = False
        Me.Extra_Name.Width = 300
        '
        'Extra_Type
        '
        Me.Extra_Type.DataPropertyName = "Extra_Type"
        Me.Extra_Type.HeaderText = "Type"
        Me.Extra_Type.Name = "Extra_Type"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To open a selection, double-click on it."
        '
        'frmExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1119, 326)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Extras_DatagridView)
        Me.Name = "frmExtras"
        Me.Text = "Extras"
        CType(Me.Staff_AllocationsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExtrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Extras_DatagridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Staff_AllocationsDataSet As Staff_AllocationsDataSet
    Friend WithEvents TblExtrasBindingSource As BindingSource
    Friend WithEvents TblExtrasTableAdapter As Staff_AllocationsDataSetTableAdapters.tblExtrasTableAdapter
    Friend WithEvents TableAdapterManager As Staff_AllocationsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Extras_DatagridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Presenting_Name As DataGridViewTextBoxColumn
    Friend WithEvents Extra_Name As DataGridViewTextBoxColumn
    Friend WithEvents Extra_Type As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

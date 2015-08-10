<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DBDataSet = New MaidExampleSystem.DBDataSet()
        Me.MaidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaidTableAdapter = New MaidExampleSystem.DBDataSetTableAdapters.MaidTableAdapter()
        Me.TableAdapterManager = New MaidExampleSystem.DBDataSetTableAdapters.TableAdapterManager()
        Me.MaidBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MaidBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MaidDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddMaidBtn = New System.Windows.Forms.Button()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.PriceTxt = New System.Windows.Forms.TextBox()
        Me.AgeTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DelRowBtn = New System.Windows.Forms.Button()
        Me.PeanutBtn = New System.Windows.Forms.Button()
        Me.DelPeanutBtn = New System.Windows.Forms.Button()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaidBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaidBindingNavigator.SuspendLayout()
        CType(Me.MaidDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaidBindingSource
        '
        Me.MaidBindingSource.DataMember = "Maid"
        Me.MaidBindingSource.DataSource = Me.DBDataSet
        '
        'MaidTableAdapter
        '
        Me.MaidTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MaidTableAdapter = Me.MaidTableAdapter
        Me.TableAdapterManager.UpdateOrder = MaidExampleSystem.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaidBindingNavigator
        '
        Me.MaidBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MaidBindingNavigator.BindingSource = Me.MaidBindingSource
        Me.MaidBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MaidBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MaidBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MaidBindingNavigatorSaveItem})
        Me.MaidBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MaidBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MaidBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MaidBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MaidBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MaidBindingNavigator.Name = "MaidBindingNavigator"
        Me.MaidBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MaidBindingNavigator.Size = New System.Drawing.Size(684, 25)
        Me.MaidBindingNavigator.TabIndex = 0
        Me.MaidBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MaidBindingNavigatorSaveItem
        '
        Me.MaidBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MaidBindingNavigatorSaveItem.Image = CType(resources.GetObject("MaidBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MaidBindingNavigatorSaveItem.Name = "MaidBindingNavigatorSaveItem"
        Me.MaidBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MaidBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MaidDataGridView
        '
        Me.MaidDataGridView.AllowUserToAddRows = False
        Me.MaidDataGridView.AllowUserToDeleteRows = False
        Me.MaidDataGridView.AutoGenerateColumns = False
        Me.MaidDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaidDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MaidDataGridView.DataSource = Me.MaidBindingSource
        Me.MaidDataGridView.Location = New System.Drawing.Point(27, 45)
        Me.MaidDataGridView.Name = "MaidDataGridView"
        Me.MaidDataGridView.Size = New System.Drawing.Size(336, 288)
        Me.MaidDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "maid_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "maid_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn3.HeaderText = "age"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'AddMaidBtn
        '
        Me.AddMaidBtn.Location = New System.Drawing.Point(415, 135)
        Me.AddMaidBtn.Name = "AddMaidBtn"
        Me.AddMaidBtn.Size = New System.Drawing.Size(227, 23)
        Me.AddMaidBtn.TabIndex = 2
        Me.AddMaidBtn.Text = "Add"
        Me.AddMaidBtn.UseVisualStyleBackColor = True
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(468, 57)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(174, 20)
        Me.NameTxt.TabIndex = 3
        '
        'PriceTxt
        '
        Me.PriceTxt.Location = New System.Drawing.Point(468, 109)
        Me.PriceTxt.Name = "PriceTxt"
        Me.PriceTxt.Size = New System.Drawing.Size(174, 20)
        Me.PriceTxt.TabIndex = 5
        '
        'AgeTxt
        '
        Me.AgeTxt.Location = New System.Drawing.Point(468, 83)
        Me.AgeTxt.Name = "AgeTxt"
        Me.AgeTxt.Size = New System.Drawing.Size(174, 20)
        Me.AgeTxt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(412, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Price:"
        '
        'DelRowBtn
        '
        Me.DelRowBtn.Location = New System.Drawing.Point(415, 208)
        Me.DelRowBtn.Name = "DelRowBtn"
        Me.DelRowBtn.Size = New System.Drawing.Size(227, 23)
        Me.DelRowBtn.TabIndex = 9
        Me.DelRowBtn.Text = "Delete Selected Rows"
        Me.DelRowBtn.UseVisualStyleBackColor = True
        '
        'PeanutBtn
        '
        Me.PeanutBtn.Location = New System.Drawing.Point(415, 280)
        Me.PeanutBtn.Name = "PeanutBtn"
        Me.PeanutBtn.Size = New System.Drawing.Size(227, 23)
        Me.PeanutBtn.TabIndex = 10
        Me.PeanutBtn.Text = "Change selected maid to 'Peanut'"
        Me.PeanutBtn.UseVisualStyleBackColor = True
        '
        'DelPeanutBtn
        '
        Me.DelPeanutBtn.Location = New System.Drawing.Point(415, 310)
        Me.DelPeanutBtn.Name = "DelPeanutBtn"
        Me.DelPeanutBtn.Size = New System.Drawing.Size(227, 23)
        Me.DelPeanutBtn.TabIndex = 11
        Me.DelPeanutBtn.Text = "Delete all 'Peanut'"
        Me.DelPeanutBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 363)
        Me.Controls.Add(Me.DelPeanutBtn)
        Me.Controls.Add(Me.PeanutBtn)
        Me.Controls.Add(Me.DelRowBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AgeTxt)
        Me.Controls.Add(Me.PriceTxt)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.AddMaidBtn)
        Me.Controls.Add(Me.MaidDataGridView)
        Me.Controls.Add(Me.MaidBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaidBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaidBindingNavigator.ResumeLayout(False)
        Me.MaidBindingNavigator.PerformLayout()
        CType(Me.MaidDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DBDataSet As MaidExampleSystem.DBDataSet
    Friend WithEvents MaidBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaidTableAdapter As MaidExampleSystem.DBDataSetTableAdapters.MaidTableAdapter
    Friend WithEvents TableAdapterManager As MaidExampleSystem.DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MaidBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents MaidBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MaidDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddMaidBtn As System.Windows.Forms.Button
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents PriceTxt As System.Windows.Forms.TextBox
    Friend WithEvents AgeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DelRowBtn As System.Windows.Forms.Button
    Friend WithEvents PeanutBtn As System.Windows.Forms.Button
    Friend WithEvents DelPeanutBtn As System.Windows.Forms.Button

End Class

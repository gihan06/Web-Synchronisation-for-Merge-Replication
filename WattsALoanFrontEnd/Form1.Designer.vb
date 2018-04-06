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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim DateCreatedLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim BillingAddressLabel As System.Windows.Forms.Label
        Dim BillingCityLabel As System.Windows.Forms.Label
        Dim BillingStateLabel As System.Windows.Forms.Label
        Dim BillingZIPCideLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Me.QueriesTableAdapter1 = New WattsALoanFrontEnd.WattsALoanSubDataSetTableAdapters.QueriesTableAdapter()
        Me.WattsALoanSubDataSet = New WattsALoanFrontEnd.WattsALoanSubDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New WattsALoanFrontEnd.WattsALoanSubDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New WattsALoanFrontEnd.WattsALoanSubDataSetTableAdapters.TableAdapterManager()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateCreatedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.BillingAddressTextBox = New System.Windows.Forms.TextBox()
        Me.BillingCityTextBox = New System.Windows.Forms.TextBox()
        Me.BillingStateTextBox = New System.Windows.Forms.TextBox()
        Me.BillingZIPCideTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.SynchronisationBotton = New System.Windows.Forms.Button()
        Me.UpdateCustomerBotton = New System.Windows.Forms.Button()
        CustomerIDLabel = New System.Windows.Forms.Label()
        DateCreatedLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        BillingAddressLabel = New System.Windows.Forms.Label()
        BillingCityLabel = New System.Windows.Forms.Label()
        BillingStateLabel = New System.Windows.Forms.Label()
        BillingZIPCideLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        CType(Me.WattsALoanSubDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'WattsALoanSubDataSet
        '
        Me.WattsALoanSubDataSet.DataSetName = "WattsALoanSubDataSet"
        Me.WattsALoanSubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.WattsALoanSubDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = WattsALoanFrontEnd.WattsALoanSubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(417, 25)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(21, 43)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(105, 40)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerIDTextBox.TabIndex = 2
        '
        'DateCreatedLabel
        '
        DateCreatedLabel.AutoSize = True
        DateCreatedLabel.Location = New System.Drawing.Point(21, 70)
        DateCreatedLabel.Name = "DateCreatedLabel"
        DateCreatedLabel.Size = New System.Drawing.Size(73, 13)
        DateCreatedLabel.TabIndex = 3
        DateCreatedLabel.Text = "Date Created:"
        '
        'DateCreatedDateTimePicker
        '
        Me.DateCreatedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomersBindingSource, "DateCreated", True))
        Me.DateCreatedDateTimePicker.Location = New System.Drawing.Point(105, 66)
        Me.DateCreatedDateTimePicker.Name = "DateCreatedDateTimePicker"
        Me.DateCreatedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateCreatedDateTimePicker.TabIndex = 4
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(21, 95)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 5
        FullNameLabel.Text = "Full Name:"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(105, 92)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FullNameTextBox.TabIndex = 6
        '
        'BillingAddressLabel
        '
        BillingAddressLabel.AutoSize = True
        BillingAddressLabel.Location = New System.Drawing.Point(21, 121)
        BillingAddressLabel.Name = "BillingAddressLabel"
        BillingAddressLabel.Size = New System.Drawing.Size(78, 13)
        BillingAddressLabel.TabIndex = 7
        BillingAddressLabel.Text = "Billing Address:"
        '
        'BillingAddressTextBox
        '
        Me.BillingAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "BillingAddress", True))
        Me.BillingAddressTextBox.Location = New System.Drawing.Point(105, 118)
        Me.BillingAddressTextBox.Name = "BillingAddressTextBox"
        Me.BillingAddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BillingAddressTextBox.TabIndex = 8
        '
        'BillingCityLabel
        '
        BillingCityLabel.AutoSize = True
        BillingCityLabel.Location = New System.Drawing.Point(21, 147)
        BillingCityLabel.Name = "BillingCityLabel"
        BillingCityLabel.Size = New System.Drawing.Size(57, 13)
        BillingCityLabel.TabIndex = 9
        BillingCityLabel.Text = "Billing City:"
        '
        'BillingCityTextBox
        '
        Me.BillingCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "BillingCity", True))
        Me.BillingCityTextBox.Location = New System.Drawing.Point(105, 144)
        Me.BillingCityTextBox.Name = "BillingCityTextBox"
        Me.BillingCityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BillingCityTextBox.TabIndex = 10
        '
        'BillingStateLabel
        '
        BillingStateLabel.AutoSize = True
        BillingStateLabel.Location = New System.Drawing.Point(21, 173)
        BillingStateLabel.Name = "BillingStateLabel"
        BillingStateLabel.Size = New System.Drawing.Size(65, 13)
        BillingStateLabel.TabIndex = 11
        BillingStateLabel.Text = "Billing State:"
        '
        'BillingStateTextBox
        '
        Me.BillingStateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "BillingState", True))
        Me.BillingStateTextBox.Location = New System.Drawing.Point(105, 170)
        Me.BillingStateTextBox.Name = "BillingStateTextBox"
        Me.BillingStateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BillingStateTextBox.TabIndex = 12
        '
        'BillingZIPCideLabel
        '
        BillingZIPCideLabel.AutoSize = True
        BillingZIPCideLabel.Location = New System.Drawing.Point(21, 199)
        BillingZIPCideLabel.Name = "BillingZIPCideLabel"
        BillingZIPCideLabel.Size = New System.Drawing.Size(78, 13)
        BillingZIPCideLabel.TabIndex = 13
        BillingZIPCideLabel.Text = "Billing ZIPCide:"
        '
        'BillingZIPCideTextBox
        '
        Me.BillingZIPCideTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "BillingZIPCide", True))
        Me.BillingZIPCideTextBox.Location = New System.Drawing.Point(105, 196)
        Me.BillingZIPCideTextBox.Name = "BillingZIPCideTextBox"
        Me.BillingZIPCideTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BillingZIPCideTextBox.TabIndex = 14
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(21, 225)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 15
        EmailAddressLabel.Text = "Email Address:"
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(105, 222)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailAddressTextBox.TabIndex = 16
        '
        'SynchronisationBotton
        '
        Me.SynchronisationBotton.Location = New System.Drawing.Point(37, 310)
        Me.SynchronisationBotton.Name = "SynchronisationBotton"
        Me.SynchronisationBotton.Size = New System.Drawing.Size(129, 23)
        Me.SynchronisationBotton.TabIndex = 19
        Me.SynchronisationBotton.Text = "Synchronisation Botton"
        Me.SynchronisationBotton.UseVisualStyleBackColor = True
        '
        'UpdateCustomerBotton
        '
        Me.UpdateCustomerBotton.Location = New System.Drawing.Point(230, 310)
        Me.UpdateCustomerBotton.Name = "UpdateCustomerBotton"
        Me.UpdateCustomerBotton.Size = New System.Drawing.Size(135, 23)
        Me.UpdateCustomerBotton.TabIndex = 20
        Me.UpdateCustomerBotton.Text = "Update Customer Botton"
        Me.UpdateCustomerBotton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 392)
        Me.Controls.Add(Me.UpdateCustomerBotton)
        Me.Controls.Add(Me.SynchronisationBotton)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(DateCreatedLabel)
        Me.Controls.Add(Me.DateCreatedDateTimePicker)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(BillingAddressLabel)
        Me.Controls.Add(Me.BillingAddressTextBox)
        Me.Controls.Add(BillingCityLabel)
        Me.Controls.Add(Me.BillingCityTextBox)
        Me.Controls.Add(BillingStateLabel)
        Me.Controls.Add(Me.BillingStateTextBox)
        Me.Controls.Add(BillingZIPCideLabel)
        Me.Controls.Add(Me.BillingZIPCideTextBox)
        Me.Controls.Add(EmailAddressLabel)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.WattsALoanSubDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QueriesTableAdapter1 As WattsALoanFrontEnd.WattsALoanSubDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents WattsALoanSubDataSet As WattsALoanFrontEnd.WattsALoanSubDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As WattsALoanFrontEnd.WattsALoanSubDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As WattsALoanFrontEnd.WattsALoanSubDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateCreatedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingStateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillingZIPCideTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SynchronisationBotton As System.Windows.Forms.Button
    Friend WithEvents UpdateCustomerBotton As System.Windows.Forms.Button

End Class

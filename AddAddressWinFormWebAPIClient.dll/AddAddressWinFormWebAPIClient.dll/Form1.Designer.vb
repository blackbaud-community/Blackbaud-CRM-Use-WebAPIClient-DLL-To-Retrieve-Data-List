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
        Me.btnAddAddress = New System.Windows.Forms.Button
        Me.lblLookupID = New System.Windows.Forms.Label
        Me.lblStreetAddress = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.txtLookupID = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.cboState = New System.Windows.Forms.ComboBox
        Me.cboAddressType = New System.Windows.Forms.ComboBox
        Me.lblAddressType = New System.Windows.Forms.Label
        Me.txtSearchResults = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.DataGridViewAddress = New System.Windows.Forms.DataGridView
        Me.btnDeleteAddress = New System.Windows.Forms.Button
        CType(Me.DataGridViewAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddAddress
        '
        Me.btnAddAddress.Enabled = False
        Me.btnAddAddress.Location = New System.Drawing.Point(329, 145)
        Me.btnAddAddress.Name = "btnAddAddress"
        Me.btnAddAddress.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAddress.TabIndex = 0
        Me.btnAddAddress.Text = "Add Address"
        Me.btnAddAddress.UseVisualStyleBackColor = True
        '
        'lblLookupID
        '
        Me.lblLookupID.AutoSize = True
        Me.lblLookupID.Location = New System.Drawing.Point(24, 8)
        Me.lblLookupID.Name = "lblLookupID"
        Me.lblLookupID.Size = New System.Drawing.Size(60, 13)
        Me.lblLookupID.TabIndex = 1
        Me.lblLookupID.Text = "Lookup ID:"
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Location = New System.Drawing.Point(36, 49)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblStreetAddress.TabIndex = 2
        Me.lblStreetAddress.Text = "Address:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(49, 123)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 3
        Me.lblState.Text = "State:"
        '
        'txtLookupID
        '
        Me.txtLookupID.Location = New System.Drawing.Point(90, 5)
        Me.txtLookupID.Name = "txtLookupID"
        Me.txtLookupID.Size = New System.Drawing.Size(127, 20)
        Me.txtLookupID.TabIndex = 4
        Me.txtLookupID.Text = "96"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(90, 49)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(314, 65)
        Me.txtAddress.TabIndex = 6
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(90, 120)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(127, 21)
        Me.cboState.TabIndex = 7
        '
        'cboAddressType
        '
        Me.cboAddressType.FormattingEnabled = True
        Me.cboAddressType.Location = New System.Drawing.Point(90, 147)
        Me.cboAddressType.Name = "cboAddressType"
        Me.cboAddressType.Size = New System.Drawing.Size(127, 21)
        Me.cboAddressType.TabIndex = 9
        '
        'lblAddressType
        '
        Me.lblAddressType.AutoSize = True
        Me.lblAddressType.Location = New System.Drawing.Point(12, 150)
        Me.lblAddressType.Name = "lblAddressType"
        Me.lblAddressType.Size = New System.Drawing.Size(75, 13)
        Me.lblAddressType.TabIndex = 8
        Me.lblAddressType.Text = "Address Type:"
        '
        'txtSearchResults
        '
        Me.txtSearchResults.BackColor = System.Drawing.SystemColors.Control
        Me.txtSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchResults.Location = New System.Drawing.Point(90, 30)
        Me.txtSearchResults.Name = "txtSearchResults"
        Me.txtSearchResults.Size = New System.Drawing.Size(284, 13)
        Me.txtSearchResults.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.Enabled = False
        Me.btnSearch.Location = New System.Drawing.Point(223, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 23)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridViewAddress
        '
        Me.DataGridViewAddress.AllowUserToAddRows = False
        Me.DataGridViewAddress.AllowUserToDeleteRows = False
        Me.DataGridViewAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAddress.Location = New System.Drawing.Point(12, 174)
        Me.DataGridViewAddress.Name = "DataGridViewAddress"
        Me.DataGridViewAddress.ReadOnly = True
        Me.DataGridViewAddress.Size = New System.Drawing.Size(392, 190)
        Me.DataGridViewAddress.TabIndex = 12
        '
        'btnDeleteAddress
        '
        Me.btnDeleteAddress.Enabled = False
        Me.btnDeleteAddress.Location = New System.Drawing.Point(248, 370)
        Me.btnDeleteAddress.Name = "btnDeleteAddress"
        Me.btnDeleteAddress.Size = New System.Drawing.Size(156, 23)
        Me.btnDeleteAddress.TabIndex = 13
        Me.btnDeleteAddress.Text = "Delete Selected Address"
        Me.btnDeleteAddress.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 396)
        Me.Controls.Add(Me.btnDeleteAddress)
        Me.Controls.Add(Me.DataGridViewAddress)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchResults)
        Me.Controls.Add(Me.cboAddressType)
        Me.Controls.Add(Me.lblAddressType)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLookupID)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblStreetAddress)
        Me.Controls.Add(Me.lblLookupID)
        Me.Controls.Add(Me.btnAddAddress)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridViewAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddAddress As System.Windows.Forms.Button
    Friend WithEvents lblLookupID As System.Windows.Forms.Label
    Friend WithEvents lblStreetAddress As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtLookupID As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents cboAddressType As System.Windows.Forms.ComboBox
    Friend WithEvents lblAddressType As System.Windows.Forms.Label
    Friend WithEvents txtSearchResults As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridViewAddress As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteAddress As System.Windows.Forms.Button

End Class

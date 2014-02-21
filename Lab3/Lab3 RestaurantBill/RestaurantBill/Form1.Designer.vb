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
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.menuItemLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.addItemButton = New System.Windows.Forms.Button()
        Me.totalBillButton = New System.Windows.Forms.Button()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.menuTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.quantityListBox = New System.Windows.Forms.ListBox()
        Me.menuItemListBox = New System.Windows.Forms.ListBox()
        Me.priceListBox = New System.Windows.Forms.ListBox()
        Me.quantityLabelListBox = New System.Windows.Forms.Label()
        Me.menuItemLabelListBox = New System.Windows.Forms.Label()
        Me.priceLabelListBox = New System.Windows.Forms.Label()
        Me.totalCostLabelBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.Location = New System.Drawing.Point(13, 18)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(49, 13)
        Me.quantityLabel.TabIndex = 0
        Me.quantityLabel.Text = "Quantity:"
        '
        'menuItemLabel
        '
        Me.menuItemLabel.AutoSize = True
        Me.menuItemLabel.Location = New System.Drawing.Point(13, 45)
        Me.menuItemLabel.Name = "menuItemLabel"
        Me.menuItemLabel.Size = New System.Drawing.Size(60, 13)
        Me.menuItemLabel.TabIndex = 1
        Me.menuItemLabel.Text = "Menu Item:"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(13, 71)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(34, 13)
        Me.priceLabel.TabIndex = 2
        Me.priceLabel.Text = "Price:"
        '
        'totalCostLabel
        '
        Me.totalCostLabel.AutoSize = True
        Me.totalCostLabel.Location = New System.Drawing.Point(143, 253)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(58, 13)
        Me.totalCostLabel.TabIndex = 3
        Me.totalCostLabel.Text = "Total Cost:"
        '
        'addItemButton
        '
        Me.addItemButton.Location = New System.Drawing.Point(219, 6)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Size = New System.Drawing.Size(75, 23)
        Me.addItemButton.TabIndex = 4
        Me.addItemButton.Text = "Add Item"
        Me.addItemButton.UseVisualStyleBackColor = True
        '
        'totalBillButton
        '
        Me.totalBillButton.Location = New System.Drawing.Point(219, 35)
        Me.totalBillButton.Name = "totalBillButton"
        Me.totalBillButton.Size = New System.Drawing.Size(75, 23)
        Me.totalBillButton.TabIndex = 5
        Me.totalBillButton.Text = "Total Bill"
        Me.totalBillButton.UseVisualStyleBackColor = True
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(92, 11)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.quantityTextBox.TabIndex = 6
        '
        'menuTextBox
        '
        Me.menuTextBox.Location = New System.Drawing.Point(92, 38)
        Me.menuTextBox.Name = "menuTextBox"
        Me.menuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.menuTextBox.TabIndex = 7
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(92, 64)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.priceTextBox.TabIndex = 8
        '
        'quantityListBox
        '
        Me.quantityListBox.FormattingEnabled = True
        Me.quantityListBox.Location = New System.Drawing.Point(13, 143)
        Me.quantityListBox.Name = "quantityListBox"
        Me.quantityListBox.Size = New System.Drawing.Size(70, 95)
        Me.quantityListBox.TabIndex = 9
        '
        'menuItemListBox
        '
        Me.menuItemListBox.FormattingEnabled = True
        Me.menuItemListBox.Location = New System.Drawing.Point(103, 143)
        Me.menuItemListBox.Name = "menuItemListBox"
        Me.menuItemListBox.Size = New System.Drawing.Size(98, 95)
        Me.menuItemListBox.TabIndex = 10
        '
        'priceListBox
        '
        Me.priceListBox.FormattingEnabled = True
        Me.priceListBox.Location = New System.Drawing.Point(218, 143)
        Me.priceListBox.Name = "priceListBox"
        Me.priceListBox.Size = New System.Drawing.Size(75, 95)
        Me.priceListBox.TabIndex = 11
        '
        'quantityLabelListBox
        '
        Me.quantityLabelListBox.AutoSize = True
        Me.quantityLabelListBox.Location = New System.Drawing.Point(10, 118)
        Me.quantityLabelListBox.Name = "quantityLabelListBox"
        Me.quantityLabelListBox.Size = New System.Drawing.Size(49, 13)
        Me.quantityLabelListBox.TabIndex = 13
        Me.quantityLabelListBox.Text = "Quantity:"
        '
        'menuItemLabelListBox
        '
        Me.menuItemLabelListBox.AutoSize = True
        Me.menuItemLabelListBox.Location = New System.Drawing.Point(100, 118)
        Me.menuItemLabelListBox.Name = "menuItemLabelListBox"
        Me.menuItemLabelListBox.Size = New System.Drawing.Size(60, 13)
        Me.menuItemLabelListBox.TabIndex = 14
        Me.menuItemLabelListBox.Text = "Menu Item:"
        '
        'priceLabelListBox
        '
        Me.priceLabelListBox.AutoSize = True
        Me.priceLabelListBox.Location = New System.Drawing.Point(215, 118)
        Me.priceLabelListBox.Name = "priceLabelListBox"
        Me.priceLabelListBox.Size = New System.Drawing.Size(34, 13)
        Me.priceLabelListBox.TabIndex = 15
        Me.priceLabelListBox.Text = "Price:"
        '
        'totalCostLabelBox
        '
        Me.totalCostLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalCostLabelBox.Location = New System.Drawing.Point(215, 241)
        Me.totalCostLabelBox.Name = "totalCostLabelBox"
        Me.totalCostLabelBox.Size = New System.Drawing.Size(79, 25)
        Me.totalCostLabelBox.TabIndex = 16
        Me.totalCostLabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 273)
        Me.Controls.Add(Me.totalCostLabelBox)
        Me.Controls.Add(Me.priceLabelListBox)
        Me.Controls.Add(Me.menuItemLabelListBox)
        Me.Controls.Add(Me.quantityLabelListBox)
        Me.Controls.Add(Me.priceListBox)
        Me.Controls.Add(Me.menuItemListBox)
        Me.Controls.Add(Me.quantityListBox)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.menuTextBox)
        Me.Controls.Add(Me.quantityTextBox)
        Me.Controls.Add(Me.totalBillButton)
        Me.Controls.Add(Me.addItemButton)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.menuItemLabel)
        Me.Controls.Add(Me.quantityLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents quantityLabel As System.Windows.Forms.Label
    Friend WithEvents menuItemLabel As System.Windows.Forms.Label
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents totalCostLabel As System.Windows.Forms.Label
    Friend WithEvents addItemButton As System.Windows.Forms.Button
    Friend WithEvents totalBillButton As System.Windows.Forms.Button
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents menuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents quantityListBox As System.Windows.Forms.ListBox
    Friend WithEvents menuItemListBox As System.Windows.Forms.ListBox
    Friend WithEvents priceListBox As System.Windows.Forms.ListBox
    Friend WithEvents quantityLabelListBox As System.Windows.Forms.Label
    Friend WithEvents menuItemLabelListBox As System.Windows.Forms.Label
    Friend WithEvents priceLabelListBox As System.Windows.Forms.Label
    Friend WithEvents totalCostLabelBox As System.Windows.Forms.Label

End Class

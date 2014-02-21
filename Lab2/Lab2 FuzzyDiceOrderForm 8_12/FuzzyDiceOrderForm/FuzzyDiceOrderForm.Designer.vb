<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuzzyDiceOrderForm
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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.orderNumberLabel = New System.Windows.Forms.Label()
        Me.orderNumberTextBox = New System.Windows.Forms.TextBox()
        Me.companyNameLabel = New System.Windows.Forms.Label()
        Me.address1Label = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.cityStateZipTextBox = New System.Windows.Forms.TextBox()
        Me.addressLine2TextBox = New System.Windows.Forms.TextBox()
        Me.addressLine1TextBox = New System.Windows.Forms.TextBox()
        Me.typeLabel = New System.Windows.Forms.Label()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.totalsLabel = New System.Windows.Forms.Label()
        Me.whiteBlackQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.redBlackQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.blueBlackQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.whiteBlackPriceLabel = New System.Windows.Forms.Label()
        Me.redBlackPriceLabel = New System.Windows.Forms.Label()
        Me.blueBlackPriceLabel = New System.Windows.Forms.Label()
        Me.whiteBlackTotalsLabel = New System.Windows.Forms.Label()
        Me.redBlackTotalsLabel = New System.Windows.Forms.Label()
        Me.blueBlackTotalsLabel = New System.Windows.Forms.Label()
        Me.taxResultLabel = New System.Windows.Forms.Label()
        Me.subtotalResultLabel = New System.Windows.Forms.Label()
        Me.totalResultLabel = New System.Windows.Forms.Label()
        Me.shippingResultLabel = New System.Windows.Forms.Label()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.shippingLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.cityStateZipLabel = New System.Windows.Forms.Label()
        Me.address2Label = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(74, 9)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(256, 35)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Fuzzy Dice"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'orderNumberLabel
        '
        Me.orderNumberLabel.Location = New System.Drawing.Point(19, 62)
        Me.orderNumberLabel.Name = "orderNumberLabel"
        Me.orderNumberLabel.Size = New System.Drawing.Size(87, 16)
        Me.orderNumberLabel.TabIndex = 1
        Me.orderNumberLabel.Text = "Order Number:"
        Me.orderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'orderNumberTextBox
        '
        Me.orderNumberTextBox.Location = New System.Drawing.Point(115, 60)
        Me.orderNumberTextBox.Name = "orderNumberTextBox"
        Me.orderNumberTextBox.Size = New System.Drawing.Size(48, 23)
        Me.orderNumberTextBox.TabIndex = 2
        Me.orderNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'companyNameLabel
        '
        Me.companyNameLabel.AutoSize = True
        Me.companyNameLabel.Location = New System.Drawing.Point(19, 103)
        Me.companyNameLabel.Name = "companyNameLabel"
        Me.companyNameLabel.Size = New System.Drawing.Size(42, 15)
        Me.companyNameLabel.TabIndex = 3
        Me.companyNameLabel.Text = "Name:"
        '
        'address1Label
        '
        Me.address1Label.AutoSize = True
        Me.address1Label.Location = New System.Drawing.Point(19, 132)
        Me.address1Label.Name = "address1Label"
        Me.address1Label.Size = New System.Drawing.Size(61, 15)
        Me.address1Label.TabIndex = 4
        Me.address1Label.Text = "Address 1:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(115, 100)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(248, 23)
        Me.nameTextBox.TabIndex = 5
        '
        'cityStateZipTextBox
        '
        Me.cityStateZipTextBox.Location = New System.Drawing.Point(115, 187)
        Me.cityStateZipTextBox.Name = "cityStateZipTextBox"
        Me.cityStateZipTextBox.Size = New System.Drawing.Size(248, 23)
        Me.cityStateZipTextBox.TabIndex = 6
        '
        'addressLine2TextBox
        '
        Me.addressLine2TextBox.Location = New System.Drawing.Point(115, 158)
        Me.addressLine2TextBox.Name = "addressLine2TextBox"
        Me.addressLine2TextBox.Size = New System.Drawing.Size(248, 23)
        Me.addressLine2TextBox.TabIndex = 7
        '
        'addressLine1TextBox
        '
        Me.addressLine1TextBox.Location = New System.Drawing.Point(115, 129)
        Me.addressLine1TextBox.Name = "addressLine1TextBox"
        Me.addressLine1TextBox.Size = New System.Drawing.Size(248, 23)
        Me.addressLine1TextBox.TabIndex = 8
        '
        'typeLabel
        '
        Me.typeLabel.AutoSize = True
        Me.typeLabel.Location = New System.Drawing.Point(19, 230)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(36, 15)
        Me.typeLabel.TabIndex = 9
        Me.typeLabel.Text = "Type:"
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.Location = New System.Drawing.Point(126, 230)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(56, 15)
        Me.quantityLabel.TabIndex = 10
        Me.quantityLabel.Text = "Quantity:"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(224, 230)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(36, 15)
        Me.priceLabel.TabIndex = 11
        Me.priceLabel.Text = "Price:"
        '
        'totalsLabel
        '
        Me.totalsLabel.AutoSize = True
        Me.totalsLabel.Location = New System.Drawing.Point(288, 230)
        Me.totalsLabel.Name = "totalsLabel"
        Me.totalsLabel.Size = New System.Drawing.Size(42, 15)
        Me.totalsLabel.TabIndex = 12
        Me.totalsLabel.Text = "Totals:"
        '
        'whiteBlackQuantityTextBox
        '
        Me.whiteBlackQuantityTextBox.Location = New System.Drawing.Point(126, 260)
        Me.whiteBlackQuantityTextBox.Name = "whiteBlackQuantityTextBox"
        Me.whiteBlackQuantityTextBox.Size = New System.Drawing.Size(80, 23)
        Me.whiteBlackQuantityTextBox.TabIndex = 13
        Me.whiteBlackQuantityTextBox.Text = "0"
        Me.whiteBlackQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'redBlackQuantityTextBox
        '
        Me.redBlackQuantityTextBox.Location = New System.Drawing.Point(126, 289)
        Me.redBlackQuantityTextBox.Name = "redBlackQuantityTextBox"
        Me.redBlackQuantityTextBox.Size = New System.Drawing.Size(80, 23)
        Me.redBlackQuantityTextBox.TabIndex = 14
        Me.redBlackQuantityTextBox.Text = "0"
        Me.redBlackQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'blueBlackQuantityTextBox
        '
        Me.blueBlackQuantityTextBox.Location = New System.Drawing.Point(126, 318)
        Me.blueBlackQuantityTextBox.Name = "blueBlackQuantityTextBox"
        Me.blueBlackQuantityTextBox.Size = New System.Drawing.Size(80, 23)
        Me.blueBlackQuantityTextBox.TabIndex = 15
        Me.blueBlackQuantityTextBox.Text = "0"
        Me.blueBlackQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'whiteBlackPriceLabel
        '
        Me.whiteBlackPriceLabel.AutoSize = True
        Me.whiteBlackPriceLabel.Location = New System.Drawing.Point(224, 263)
        Me.whiteBlackPriceLabel.Name = "whiteBlackPriceLabel"
        Me.whiteBlackPriceLabel.Size = New System.Drawing.Size(28, 15)
        Me.whiteBlackPriceLabel.TabIndex = 16
        Me.whiteBlackPriceLabel.Text = "6.25"
        '
        'redBlackPriceLabel
        '
        Me.redBlackPriceLabel.AutoSize = True
        Me.redBlackPriceLabel.Location = New System.Drawing.Point(224, 292)
        Me.redBlackPriceLabel.Name = "redBlackPriceLabel"
        Me.redBlackPriceLabel.Size = New System.Drawing.Size(28, 15)
        Me.redBlackPriceLabel.TabIndex = 17
        Me.redBlackPriceLabel.Text = "5.00"
        '
        'blueBlackPriceLabel
        '
        Me.blueBlackPriceLabel.AutoSize = True
        Me.blueBlackPriceLabel.Location = New System.Drawing.Point(224, 321)
        Me.blueBlackPriceLabel.Name = "blueBlackPriceLabel"
        Me.blueBlackPriceLabel.Size = New System.Drawing.Size(28, 15)
        Me.blueBlackPriceLabel.TabIndex = 18
        Me.blueBlackPriceLabel.Text = "7.50"
        '
        'whiteBlackTotalsLabel
        '
        Me.whiteBlackTotalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.whiteBlackTotalsLabel.Location = New System.Drawing.Point(291, 259)
        Me.whiteBlackTotalsLabel.Name = "whiteBlackTotalsLabel"
        Me.whiteBlackTotalsLabel.Size = New System.Drawing.Size(72, 19)
        Me.whiteBlackTotalsLabel.TabIndex = 19
        Me.whiteBlackTotalsLabel.Text = "$0.00"
        Me.whiteBlackTotalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'redBlackTotalsLabel
        '
        Me.redBlackTotalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.redBlackTotalsLabel.Location = New System.Drawing.Point(291, 290)
        Me.redBlackTotalsLabel.Name = "redBlackTotalsLabel"
        Me.redBlackTotalsLabel.Size = New System.Drawing.Size(72, 19)
        Me.redBlackTotalsLabel.TabIndex = 20
        Me.redBlackTotalsLabel.Text = "$0.00"
        Me.redBlackTotalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'blueBlackTotalsLabel
        '
        Me.blueBlackTotalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.blueBlackTotalsLabel.Location = New System.Drawing.Point(291, 319)
        Me.blueBlackTotalsLabel.Name = "blueBlackTotalsLabel"
        Me.blueBlackTotalsLabel.Size = New System.Drawing.Size(72, 19)
        Me.blueBlackTotalsLabel.TabIndex = 21
        Me.blueBlackTotalsLabel.Text = "$0.00"
        Me.blueBlackTotalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'taxResultLabel
        '
        Me.taxResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.taxResultLabel.Location = New System.Drawing.Point(291, 394)
        Me.taxResultLabel.Name = "taxResultLabel"
        Me.taxResultLabel.Size = New System.Drawing.Size(72, 19)
        Me.taxResultLabel.TabIndex = 23
        Me.taxResultLabel.Text = "$0.00"
        Me.taxResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'subtotalResultLabel
        '
        Me.subtotalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.subtotalResultLabel.Location = New System.Drawing.Point(291, 365)
        Me.subtotalResultLabel.Name = "subtotalResultLabel"
        Me.subtotalResultLabel.Size = New System.Drawing.Size(72, 19)
        Me.subtotalResultLabel.TabIndex = 22
        Me.subtotalResultLabel.Text = "$0.00"
        Me.subtotalResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalResultLabel
        '
        Me.totalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalResultLabel.Location = New System.Drawing.Point(291, 450)
        Me.totalResultLabel.Name = "totalResultLabel"
        Me.totalResultLabel.Size = New System.Drawing.Size(72, 19)
        Me.totalResultLabel.TabIndex = 25
        Me.totalResultLabel.Text = "$0.00"
        Me.totalResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'shippingResultLabel
        '
        Me.shippingResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shippingResultLabel.Location = New System.Drawing.Point(291, 422)
        Me.shippingResultLabel.Name = "shippingResultLabel"
        Me.shippingResultLabel.Size = New System.Drawing.Size(72, 19)
        Me.shippingResultLabel.TabIndex = 24
        Me.shippingResultLabel.Text = "$0.00"
        Me.shippingResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'subtotalLabel
        '
        Me.subtotalLabel.AutoSize = True
        Me.subtotalLabel.Location = New System.Drawing.Point(224, 367)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(54, 15)
        Me.subtotalLabel.TabIndex = 26
        Me.subtotalLabel.Text = "Subtotal:"
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Location = New System.Drawing.Point(224, 396)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(28, 15)
        Me.taxLabel.TabIndex = 27
        Me.taxLabel.Text = "Tax:"
        '
        'shippingLabel
        '
        Me.shippingLabel.AutoSize = True
        Me.shippingLabel.Location = New System.Drawing.Point(224, 424)
        Me.shippingLabel.Name = "shippingLabel"
        Me.shippingLabel.Size = New System.Drawing.Size(57, 15)
        Me.shippingLabel.TabIndex = 28
        Me.shippingLabel.Text = "Shipping:"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(224, 452)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(37, 15)
        Me.totalLabel.TabIndex = 29
        Me.totalLabel.Text = "Total:"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(291, 483)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(72, 23)
        Me.calculateButton.TabIndex = 30
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'cityStateZipLabel
        '
        Me.cityStateZipLabel.AutoSize = True
        Me.cityStateZipLabel.Location = New System.Drawing.Point(19, 190)
        Me.cityStateZipLabel.Name = "cityStateZipLabel"
        Me.cityStateZipLabel.Size = New System.Drawing.Size(80, 15)
        Me.cityStateZipLabel.TabIndex = 37
        Me.cityStateZipLabel.Text = "City, State Zip"
        '
        'address2Label
        '
        Me.address2Label.AutoSize = True
        Me.address2Label.Location = New System.Drawing.Point(19, 161)
        Me.address2Label.Name = "address2Label"
        Me.address2Label.Size = New System.Drawing.Size(61, 15)
        Me.address2Label.TabIndex = 36
        Me.address2Label.Text = "Address 2:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 264)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(90, 19)
        Me.CheckBox1.TabIndex = 38
        Me.CheckBox1.Text = "White/Black"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(22, 293)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(79, 19)
        Me.CheckBox2.TabIndex = 39
        Me.CheckBox2.Text = "Red/Black"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(22, 321)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(82, 19)
        Me.CheckBox3.TabIndex = 40
        Me.CheckBox3.Text = "Blue/Black"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'FuzzyDiceOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 518)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cityStateZipLabel)
        Me.Controls.Add(Me.address2Label)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.shippingLabel)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.subtotalLabel)
        Me.Controls.Add(Me.totalResultLabel)
        Me.Controls.Add(Me.shippingResultLabel)
        Me.Controls.Add(Me.taxResultLabel)
        Me.Controls.Add(Me.subtotalResultLabel)
        Me.Controls.Add(Me.blueBlackTotalsLabel)
        Me.Controls.Add(Me.redBlackTotalsLabel)
        Me.Controls.Add(Me.whiteBlackTotalsLabel)
        Me.Controls.Add(Me.blueBlackPriceLabel)
        Me.Controls.Add(Me.redBlackPriceLabel)
        Me.Controls.Add(Me.whiteBlackPriceLabel)
        Me.Controls.Add(Me.blueBlackQuantityTextBox)
        Me.Controls.Add(Me.redBlackQuantityTextBox)
        Me.Controls.Add(Me.whiteBlackQuantityTextBox)
        Me.Controls.Add(Me.totalsLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.quantityLabel)
        Me.Controls.Add(Me.typeLabel)
        Me.Controls.Add(Me.addressLine1TextBox)
        Me.Controls.Add(Me.addressLine2TextBox)
        Me.Controls.Add(Me.cityStateZipTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.address1Label)
        Me.Controls.Add(Me.companyNameLabel)
        Me.Controls.Add(Me.orderNumberTextBox)
        Me.Controls.Add(Me.orderNumberLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FuzzyDiceOrderForm"
        Me.Text = "Fuzzy Dice Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents titleLabel As System.Windows.Forms.Label
   Friend WithEvents orderNumberLabel As System.Windows.Forms.Label
   Friend WithEvents orderNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents companyNameLabel As System.Windows.Forms.Label
   Friend WithEvents address1Label As System.Windows.Forms.Label
   Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents cityStateZipTextBox As System.Windows.Forms.TextBox
   Friend WithEvents addressLine2TextBox As System.Windows.Forms.TextBox
   Friend WithEvents addressLine1TextBox As System.Windows.Forms.TextBox
   Friend WithEvents typeLabel As System.Windows.Forms.Label
   Friend WithEvents quantityLabel As System.Windows.Forms.Label
   Friend WithEvents priceLabel As System.Windows.Forms.Label
   Friend WithEvents totalsLabel As System.Windows.Forms.Label
   Friend WithEvents whiteBlackQuantityTextBox As System.Windows.Forms.TextBox
   Friend WithEvents redBlackQuantityTextBox As System.Windows.Forms.TextBox
   Friend WithEvents blueBlackQuantityTextBox As System.Windows.Forms.TextBox
   Friend WithEvents whiteBlackPriceLabel As System.Windows.Forms.Label
   Friend WithEvents redBlackPriceLabel As System.Windows.Forms.Label
   Friend WithEvents blueBlackPriceLabel As System.Windows.Forms.Label
   Friend WithEvents whiteBlackTotalsLabel As System.Windows.Forms.Label
   Friend WithEvents redBlackTotalsLabel As System.Windows.Forms.Label
   Friend WithEvents blueBlackTotalsLabel As System.Windows.Forms.Label
   Friend WithEvents taxResultLabel As System.Windows.Forms.Label
   Friend WithEvents subtotalResultLabel As System.Windows.Forms.Label
   Friend WithEvents totalResultLabel As System.Windows.Forms.Label
   Friend WithEvents shippingResultLabel As System.Windows.Forms.Label
   Friend WithEvents subtotalLabel As System.Windows.Forms.Label
   Friend WithEvents taxLabel As System.Windows.Forms.Label
   Friend WithEvents shippingLabel As System.Windows.Forms.Label
   Friend WithEvents totalLabel As System.Windows.Forms.Label
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents cityStateZipLabel As System.Windows.Forms.Label
    Friend WithEvents address2Label As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

End Class

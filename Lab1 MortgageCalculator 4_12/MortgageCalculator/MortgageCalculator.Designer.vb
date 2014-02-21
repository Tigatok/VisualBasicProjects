<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MortgageCalculatorForm
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
        Me.monthlyPaymentResultLabel = New System.Windows.Forms.Label()
        Me.homeTextBox = New System.Windows.Forms.TextBox()
        Me.loanTextBox = New System.Windows.Forms.TextBox()
        Me.termTextBox = New System.Windows.Forms.TextBox()
        Me.insuranceTextBox = New System.Windows.Forms.TextBox()
        Me.propertyTextBox = New System.Windows.Forms.TextBox()
        Me.interestTextBox = New System.Windows.Forms.TextBox()
        Me.insuranceLabel = New System.Windows.Forms.Label()
        Me.monthlyPaymentLabel = New System.Windows.Forms.Label()
        Me.homeLabel = New System.Windows.Forms.Label()
        Me.loanLabel = New System.Windows.Forms.Label()
        Me.termLabel = New System.Windows.Forms.Label()
        Me.propertyLabel = New System.Windows.Forms.Label()
        Me.interestLabel = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'monthlyPaymentResultLabel
        '
        Me.monthlyPaymentResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.monthlyPaymentResultLabel.Location = New System.Drawing.Point(217, 9)
        Me.monthlyPaymentResultLabel.Name = "monthlyPaymentResultLabel"
        Me.monthlyPaymentResultLabel.Size = New System.Drawing.Size(52, 23)
        Me.monthlyPaymentResultLabel.TabIndex = 8
        Me.monthlyPaymentResultLabel.Text = "550"
        Me.monthlyPaymentResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'homeTextBox
        '
        Me.homeTextBox.Location = New System.Drawing.Point(217, 43)
        Me.homeTextBox.Name = "homeTextBox"
        Me.homeTextBox.Size = New System.Drawing.Size(52, 23)
        Me.homeTextBox.TabIndex = 0
        Me.homeTextBox.Text = "125000"
        Me.homeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'loanTextBox
        '
        Me.loanTextBox.Location = New System.Drawing.Point(217, 82)
        Me.loanTextBox.Name = "loanTextBox"
        Me.loanTextBox.Size = New System.Drawing.Size(52, 23)
        Me.loanTextBox.TabIndex = 1
        Me.loanTextBox.Text = "100000"
        Me.loanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'termTextBox
        '
        Me.termTextBox.Location = New System.Drawing.Point(217, 121)
        Me.termTextBox.Name = "termTextBox"
        Me.termTextBox.Size = New System.Drawing.Size(52, 23)
        Me.termTextBox.TabIndex = 2
        Me.termTextBox.Text = "20"
        Me.termTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'insuranceTextBox
        '
        Me.insuranceTextBox.Location = New System.Drawing.Point(217, 160)
        Me.insuranceTextBox.Name = "insuranceTextBox"
        Me.insuranceTextBox.Size = New System.Drawing.Size(52, 23)
        Me.insuranceTextBox.TabIndex = 3
        Me.insuranceTextBox.Text = "500"
        Me.insuranceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'propertyTextBox
        '
        Me.propertyTextBox.Location = New System.Drawing.Point(217, 199)
        Me.propertyTextBox.Name = "propertyTextBox"
        Me.propertyTextBox.Size = New System.Drawing.Size(52, 23)
        Me.propertyTextBox.TabIndex = 4
        Me.propertyTextBox.Text = "2100"
        Me.propertyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'interestTextBox
        '
        Me.interestTextBox.Location = New System.Drawing.Point(217, 243)
        Me.interestTextBox.Name = "interestTextBox"
        Me.interestTextBox.Size = New System.Drawing.Size(52, 23)
        Me.interestTextBox.TabIndex = 5
        Me.interestTextBox.Text = "5.5"
        Me.interestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'insuranceLabel
        '
        Me.insuranceLabel.AutoSize = True
        Me.insuranceLabel.Location = New System.Drawing.Point(12, 168)
        Me.insuranceLabel.Name = "insuranceLabel"
        Me.insuranceLabel.Size = New System.Drawing.Size(180, 15)
        Me.insuranceLabel.TabIndex = 13
        Me.insuranceLabel.Text = "Homeowner's insurance (yearly):"
        '
        'monthlyPaymentLabel
        '
        Me.monthlyPaymentLabel.AutoSize = True
        Me.monthlyPaymentLabel.Location = New System.Drawing.Point(12, 17)
        Me.monthlyPaymentLabel.Name = "monthlyPaymentLabel"
        Me.monthlyPaymentLabel.Size = New System.Drawing.Size(105, 15)
        Me.monthlyPaymentLabel.TabIndex = 9
        Me.monthlyPaymentLabel.Text = "Monthly payment:"
        '
        'homeLabel
        '
        Me.homeLabel.AutoSize = True
        Me.homeLabel.Location = New System.Drawing.Point(12, 51)
        Me.homeLabel.Name = "homeLabel"
        Me.homeLabel.Size = New System.Drawing.Size(74, 15)
        Me.homeLabel.TabIndex = 10
        Me.homeLabel.Text = "Home value:"
        '
        'loanLabel
        '
        Me.loanLabel.AutoSize = True
        Me.loanLabel.Location = New System.Drawing.Point(12, 90)
        Me.loanLabel.Name = "loanLabel"
        Me.loanLabel.Size = New System.Drawing.Size(81, 15)
        Me.loanLabel.TabIndex = 11
        Me.loanLabel.Text = "Loan amount:"
        '
        'termLabel
        '
        Me.termLabel.AutoSize = True
        Me.termLabel.Location = New System.Drawing.Point(12, 129)
        Me.termLabel.Name = "termLabel"
        Me.termLabel.Size = New System.Drawing.Size(76, 15)
        Me.termLabel.TabIndex = 12
        Me.termLabel.Text = "Term (years):"
        '
        'propertyLabel
        '
        Me.propertyLabel.AutoSize = True
        Me.propertyLabel.Location = New System.Drawing.Point(12, 207)
        Me.propertyLabel.Name = "propertyLabel"
        Me.propertyLabel.Size = New System.Drawing.Size(126, 15)
        Me.propertyLabel.TabIndex = 14
        Me.propertyLabel.Text = "Property taxes (yearly):"
        '
        'interestLabel
        '
        Me.interestLabel.AutoSize = True
        Me.interestLabel.Location = New System.Drawing.Point(12, 250)
        Me.interestLabel.Name = "interestLabel"
        Me.interestLabel.Size = New System.Drawing.Size(49, 15)
        Me.interestLabel.TabIndex = 15
        Me.interestLabel.Text = "Interest:"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(117, 295)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(217, 295)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 7
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'MortgageCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 333)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.interestLabel)
        Me.Controls.Add(Me.propertyLabel)
        Me.Controls.Add(Me.termLabel)
        Me.Controls.Add(Me.loanLabel)
        Me.Controls.Add(Me.homeLabel)
        Me.Controls.Add(Me.monthlyPaymentLabel)
        Me.Controls.Add(Me.insuranceLabel)
        Me.Controls.Add(Me.interestTextBox)
        Me.Controls.Add(Me.propertyTextBox)
        Me.Controls.Add(Me.insuranceTextBox)
        Me.Controls.Add(Me.termTextBox)
        Me.Controls.Add(Me.loanTextBox)
        Me.Controls.Add(Me.homeTextBox)
        Me.Controls.Add(Me.monthlyPaymentResultLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MortgageCalculatorForm"
        Me.Text = "Mortgage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents monthlyPaymentResultLabel As System.Windows.Forms.Label
   Friend WithEvents homeTextBox As System.Windows.Forms.TextBox
   Friend WithEvents loanTextBox As System.Windows.Forms.TextBox
   Friend WithEvents termTextBox As System.Windows.Forms.TextBox
   Friend WithEvents insuranceTextBox As System.Windows.Forms.TextBox
   Friend WithEvents propertyTextBox As System.Windows.Forms.TextBox
   Friend WithEvents interestTextBox As System.Windows.Forms.TextBox
   Friend WithEvents insuranceLabel As System.Windows.Forms.Label
   Friend WithEvents monthlyPaymentLabel As System.Windows.Forms.Label
   Friend WithEvents homeLabel As System.Windows.Forms.Label
   Friend WithEvents loanLabel As System.Windows.Forms.Label
   Friend WithEvents termLabel As System.Windows.Forms.Label
   Friend WithEvents propertyLabel As System.Windows.Forms.Label
   Friend WithEvents interestLabel As System.Windows.Forms.Label
   Friend WithEvents clearButton As System.Windows.Forms.Button
   Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class

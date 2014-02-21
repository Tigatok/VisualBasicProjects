<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditCheckerForm
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
        Me.accountNumberLabel = New System.Windows.Forms.Label()
        Me.startBalanceLabel = New System.Windows.Forms.Label()
        Me.totalChargesLabel = New System.Windows.Forms.Label()
        Me.totalCreditsLabel = New System.Windows.Forms.Label()
        Me.creditLimitLabel = New System.Windows.Forms.Label()
        Me.newBalanceLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.newBalanceResultLabel = New System.Windows.Forms.Label()
        Me.accountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.startBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.totalChargesTextBox = New System.Windows.Forms.TextBox()
        Me.totalCreditsTextBox = New System.Windows.Forms.TextBox()
        Me.creditLimitTextBox = New System.Windows.Forms.TextBox()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'accountNumberLabel
        '
        Me.accountNumberLabel.AutoSize = True
        Me.accountNumberLabel.Location = New System.Drawing.Point(14, 13)
        Me.accountNumberLabel.Name = "accountNumberLabel"
        Me.accountNumberLabel.Size = New System.Drawing.Size(100, 15)
        Me.accountNumberLabel.TabIndex = 0
        Me.accountNumberLabel.Text = "Account number:"
        Me.accountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'startBalanceLabel
        '
        Me.startBalanceLabel.AutoSize = True
        Me.startBalanceLabel.Location = New System.Drawing.Point(14, 50)
        Me.startBalanceLabel.Name = "startBalanceLabel"
        Me.startBalanceLabel.Size = New System.Drawing.Size(95, 15)
        Me.startBalanceLabel.TabIndex = 1
        Me.startBalanceLabel.Text = "Starting balance:"
        Me.startBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalChargesLabel
        '
        Me.totalChargesLabel.AutoSize = True
        Me.totalChargesLabel.Location = New System.Drawing.Point(14, 87)
        Me.totalChargesLabel.Name = "totalChargesLabel"
        Me.totalChargesLabel.Size = New System.Drawing.Size(81, 15)
        Me.totalChargesLabel.TabIndex = 2
        Me.totalChargesLabel.Text = "Total charges:"
        Me.totalChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalCreditsLabel
        '
        Me.totalCreditsLabel.AutoSize = True
        Me.totalCreditsLabel.Location = New System.Drawing.Point(14, 124)
        Me.totalCreditsLabel.Name = "totalCreditsLabel"
        Me.totalCreditsLabel.Size = New System.Drawing.Size(75, 15)
        Me.totalCreditsLabel.TabIndex = 3
        Me.totalCreditsLabel.Text = "Total credits:"
        Me.totalCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'creditLimitLabel
        '
        Me.creditLimitLabel.AutoSize = True
        Me.creditLimitLabel.Location = New System.Drawing.Point(14, 161)
        Me.creditLimitLabel.Name = "creditLimitLabel"
        Me.creditLimitLabel.Size = New System.Drawing.Size(69, 15)
        Me.creditLimitLabel.TabIndex = 4
        Me.creditLimitLabel.Text = "Credit limit:"
        Me.creditLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'newBalanceLabel
        '
        Me.newBalanceLabel.AutoSize = True
        Me.newBalanceLabel.Location = New System.Drawing.Point(14, 197)
        Me.newBalanceLabel.Name = "newBalanceLabel"
        Me.newBalanceLabel.Size = New System.Drawing.Size(78, 15)
        Me.newBalanceLabel.TabIndex = 5
        Me.newBalanceLabel.Text = "New balance:"
        Me.newBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(104, 265)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(117, 23)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "Calculate Balance"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'newBalanceResultLabel
        '
        Me.newBalanceResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.newBalanceResultLabel.Location = New System.Drawing.Point(121, 193)
        Me.newBalanceResultLabel.Name = "newBalanceResultLabel"
        Me.newBalanceResultLabel.Size = New System.Drawing.Size(100, 23)
        Me.newBalanceResultLabel.TabIndex = 7
        Me.newBalanceResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'accountNumberTextBox
        '
        Me.accountNumberTextBox.Location = New System.Drawing.Point(121, 10)
        Me.accountNumberTextBox.Name = "accountNumberTextBox"
        Me.accountNumberTextBox.Size = New System.Drawing.Size(100, 23)
        Me.accountNumberTextBox.TabIndex = 8
        Me.accountNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'startBalanceTextBox
        '
        Me.startBalanceTextBox.Location = New System.Drawing.Point(121, 47)
        Me.startBalanceTextBox.Name = "startBalanceTextBox"
        Me.startBalanceTextBox.Size = New System.Drawing.Size(100, 23)
        Me.startBalanceTextBox.TabIndex = 9
        Me.startBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalChargesTextBox
        '
        Me.totalChargesTextBox.Location = New System.Drawing.Point(121, 84)
        Me.totalChargesTextBox.Name = "totalChargesTextBox"
        Me.totalChargesTextBox.Size = New System.Drawing.Size(100, 23)
        Me.totalChargesTextBox.TabIndex = 10
        Me.totalChargesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalCreditsTextBox
        '
        Me.totalCreditsTextBox.Location = New System.Drawing.Point(121, 121)
        Me.totalCreditsTextBox.Name = "totalCreditsTextBox"
        Me.totalCreditsTextBox.Size = New System.Drawing.Size(100, 23)
        Me.totalCreditsTextBox.TabIndex = 11
        Me.totalCreditsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'creditLimitTextBox
        '
        Me.creditLimitTextBox.Location = New System.Drawing.Point(121, 158)
        Me.creditLimitTextBox.Name = "creditLimitTextBox"
        Me.creditLimitTextBox.Size = New System.Drawing.Size(100, 23)
        Me.creditLimitTextBox.TabIndex = 12
        Me.creditLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'errorLabel
        '
        Me.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.errorLabel.Location = New System.Drawing.Point(17, 228)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(204, 23)
        Me.errorLabel.TabIndex = 13
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreditCheckerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 299)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.creditLimitTextBox)
        Me.Controls.Add(Me.totalCreditsTextBox)
        Me.Controls.Add(Me.totalChargesTextBox)
        Me.Controls.Add(Me.startBalanceTextBox)
        Me.Controls.Add(Me.accountNumberTextBox)
        Me.Controls.Add(Me.newBalanceResultLabel)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.newBalanceLabel)
        Me.Controls.Add(Me.creditLimitLabel)
        Me.Controls.Add(Me.totalCreditsLabel)
        Me.Controls.Add(Me.totalChargesLabel)
        Me.Controls.Add(Me.startBalanceLabel)
        Me.Controls.Add(Me.accountNumberLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CreditCheckerForm"
        Me.Text = "Credit Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents accountNumberLabel As System.Windows.Forms.Label
   Friend WithEvents startBalanceLabel As System.Windows.Forms.Label
   Friend WithEvents totalChargesLabel As System.Windows.Forms.Label
   Friend WithEvents totalCreditsLabel As System.Windows.Forms.Label
   Friend WithEvents creditLimitLabel As System.Windows.Forms.Label
   Friend WithEvents newBalanceLabel As System.Windows.Forms.Label
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents newBalanceResultLabel As System.Windows.Forms.Label
   Friend WithEvents accountNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents startBalanceTextBox As System.Windows.Forms.TextBox
   Friend WithEvents totalChargesTextBox As System.Windows.Forms.TextBox
   Friend WithEvents totalCreditsTextBox As System.Windows.Forms.TextBox
   Friend WithEvents creditLimitTextBox As System.Windows.Forms.TextBox
   Friend WithEvents errorLabel As System.Windows.Forms.Label

End Class

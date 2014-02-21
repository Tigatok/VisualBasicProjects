<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountInformationForm
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
        Me.inputGroupBox = New System.Windows.Forms.GroupBox()
        Me.depositAmountTextBox = New System.Windows.Forms.TextBox()
        Me.withdrawlAmountTextBox = New System.Windows.Forms.TextBox()
        Me.accountNumberLabel1 = New System.Windows.Forms.Label()
        Me.nameLabel1 = New System.Windows.Forms.Label()
        Me.outputGroupBox = New System.Windows.Forms.GroupBox()
        Me.balanceAmountLabel = New System.Windows.Forms.Label()
        Me.copiedAccountNumberLabel = New System.Windows.Forms.Label()
        Me.copiedNameLabel = New System.Windows.Forms.Label()
        Me.balanceLabel = New System.Windows.Forms.Label()
        Me.accountNumberLabel2 = New System.Windows.Forms.Label()
        Me.nameLabel2 = New System.Windows.Forms.Label()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.inputGroupBox.SuspendLayout()
        Me.outputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'inputGroupBox
        '
        Me.inputGroupBox.Controls.Add(Me.depositAmountTextBox)
        Me.inputGroupBox.Controls.Add(Me.withdrawlAmountTextBox)
        Me.inputGroupBox.Controls.Add(Me.accountNumberLabel1)
        Me.inputGroupBox.Controls.Add(Me.nameLabel1)
        Me.inputGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.inputGroupBox.Name = "inputGroupBox"
        Me.inputGroupBox.Size = New System.Drawing.Size(165, 212)
        Me.inputGroupBox.TabIndex = 0
        Me.inputGroupBox.TabStop = False
        Me.inputGroupBox.Text = "Enter information"
        '
        'depositAmountTextBox
        '
        Me.depositAmountTextBox.Location = New System.Drawing.Point(8, 136)
        Me.depositAmountTextBox.Name = "depositAmountTextBox"
        Me.depositAmountTextBox.Size = New System.Drawing.Size(144, 23)
        Me.depositAmountTextBox.TabIndex = 5
        '
        'withdrawlAmountTextBox
        '
        Me.withdrawlAmountTextBox.Location = New System.Drawing.Point(12, 73)
        Me.withdrawlAmountTextBox.Name = "withdrawlAmountTextBox"
        Me.withdrawlAmountTextBox.Size = New System.Drawing.Size(144, 23)
        Me.withdrawlAmountTextBox.TabIndex = 4
        '
        'accountNumberLabel1
        '
        Me.accountNumberLabel1.AutoSize = True
        Me.accountNumberLabel1.Location = New System.Drawing.Point(9, 117)
        Me.accountNumberLabel1.Name = "accountNumberLabel1"
        Me.accountNumberLabel1.Size = New System.Drawing.Size(98, 15)
        Me.accountNumberLabel1.TabIndex = 1
        Me.accountNumberLabel1.Text = "Deposit amount: "
        Me.accountNumberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameLabel1
        '
        Me.nameLabel1.AutoSize = True
        Me.nameLabel1.Location = New System.Drawing.Point(9, 53)
        Me.nameLabel1.Name = "nameLabel1"
        Me.nameLabel1.Size = New System.Drawing.Size(109, 15)
        Me.nameLabel1.TabIndex = 0
        Me.nameLabel1.Text = "Withdrawl amount:"
        Me.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'outputGroupBox
        '
        Me.outputGroupBox.Controls.Add(Me.balanceAmountLabel)
        Me.outputGroupBox.Controls.Add(Me.copiedAccountNumberLabel)
        Me.outputGroupBox.Controls.Add(Me.copiedNameLabel)
        Me.outputGroupBox.Controls.Add(Me.balanceLabel)
        Me.outputGroupBox.Controls.Add(Me.accountNumberLabel2)
        Me.outputGroupBox.Controls.Add(Me.nameLabel2)
        Me.outputGroupBox.Location = New System.Drawing.Point(271, 13)
        Me.outputGroupBox.Name = "outputGroupBox"
        Me.outputGroupBox.Size = New System.Drawing.Size(165, 212)
        Me.outputGroupBox.TabIndex = 1
        Me.outputGroupBox.TabStop = False
        Me.outputGroupBox.Text = "Account information"
        '
        'balanceAmountLabel
        '
        Me.balanceAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.balanceAmountLabel.Location = New System.Drawing.Point(9, 169)
        Me.balanceAmountLabel.Name = "balanceAmountLabel"
        Me.balanceAmountLabel.Size = New System.Drawing.Size(144, 23)
        Me.balanceAmountLabel.TabIndex = 11
        Me.balanceAmountLabel.Text = "0"
        Me.balanceAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'copiedAccountNumberLabel
        '
        Me.copiedAccountNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.copiedAccountNumberLabel.Location = New System.Drawing.Point(9, 105)
        Me.copiedAccountNumberLabel.Name = "copiedAccountNumberLabel"
        Me.copiedAccountNumberLabel.Size = New System.Drawing.Size(144, 23)
        Me.copiedAccountNumberLabel.TabIndex = 10
        Me.copiedAccountNumberLabel.Text = "12345"
        Me.copiedAccountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'copiedNameLabel
        '
        Me.copiedNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.copiedNameLabel.Location = New System.Drawing.Point(9, 42)
        Me.copiedNameLabel.Name = "copiedNameLabel"
        Me.copiedNameLabel.Size = New System.Drawing.Size(144, 23)
        Me.copiedNameLabel.TabIndex = 9
        Me.copiedNameLabel.Text = "Sue Purple"
        Me.copiedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'balanceLabel
        '
        Me.balanceLabel.AutoSize = True
        Me.balanceLabel.Location = New System.Drawing.Point(6, 151)
        Me.balanceLabel.Name = "balanceLabel"
        Me.balanceLabel.Size = New System.Drawing.Size(51, 15)
        Me.balanceLabel.TabIndex = 8
        Me.balanceLabel.Text = "Balance:"
        Me.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'accountNumberLabel2
        '
        Me.accountNumberLabel2.AutoSize = True
        Me.accountNumberLabel2.Location = New System.Drawing.Point(6, 87)
        Me.accountNumberLabel2.Name = "accountNumberLabel2"
        Me.accountNumberLabel2.Size = New System.Drawing.Size(100, 15)
        Me.accountNumberLabel2.TabIndex = 7
        Me.accountNumberLabel2.Text = "Account number:"
        Me.accountNumberLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameLabel2
        '
        Me.nameLabel2.AutoSize = True
        Me.nameLabel2.Location = New System.Drawing.Point(6, 23)
        Me.nameLabel2.Name = "nameLabel2"
        Me.nameLabel2.Size = New System.Drawing.Size(42, 15)
        Me.nameLabel2.TabIndex = 6
        Me.nameLabel2.Text = "Name:"
        Me.nameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(187, 107)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(75, 23)
        Me.enterButton.TabIndex = 2
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'AccountInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 237)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.outputGroupBox)
        Me.Controls.Add(Me.inputGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AccountInformationForm"
        Me.Text = "Account Information"
        Me.inputGroupBox.ResumeLayout(False)
        Me.inputGroupBox.PerformLayout()
        Me.outputGroupBox.ResumeLayout(False)
        Me.outputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents accountNumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents nameLabel1 As System.Windows.Forms.Label
    Friend WithEvents outputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents depositAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents withdrawlAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents enterButton As System.Windows.Forms.Button
   Friend WithEvents balanceAmountLabel As System.Windows.Forms.Label
   Friend WithEvents copiedAccountNumberLabel As System.Windows.Forms.Label
   Friend WithEvents copiedNameLabel As System.Windows.Forms.Label
   Friend WithEvents balanceLabel As System.Windows.Forms.Label
   Friend WithEvents accountNumberLabel2 As System.Windows.Forms.Label
   Friend WithEvents nameLabel2 As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayRaiseForm
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
        Me.wageLabel = New System.Windows.Forms.Label()
        Me.wageTextBox = New System.Windows.Forms.TextBox()
        Me.raiseLabel = New System.Windows.Forms.Label()
        Me.yearsLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.earningsLabel = New System.Windows.Forms.Label()
        Me.earningsTextBox = New System.Windows.Forms.TextBox()
        Me.percentUpDown = New System.Windows.Forms.NumericUpDown()
        Me.yearsUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.percentUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yearsUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wageLabel
        '
        Me.wageLabel.AutoSize = True
        Me.wageLabel.Location = New System.Drawing.Point(13, 19)
        Me.wageLabel.Name = "wageLabel"
        Me.wageLabel.Size = New System.Drawing.Size(130, 15)
        Me.wageLabel.TabIndex = 0
        Me.wageLabel.Text = "Starting wage per hour:"
        '
        'wageTextBox
        '
        Me.wageTextBox.Location = New System.Drawing.Point(150, 16)
        Me.wageTextBox.Name = "wageTextBox"
        Me.wageTextBox.Size = New System.Drawing.Size(60, 23)
        Me.wageTextBox.TabIndex = 1
        Me.wageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'raiseLabel
        '
        Me.raiseLabel.AutoSize = True
        Me.raiseLabel.Location = New System.Drawing.Point(13, 52)
        Me.raiseLabel.Name = "raiseLabel"
        Me.raiseLabel.Size = New System.Drawing.Size(129, 15)
        Me.raiseLabel.TabIndex = 2
        Me.raiseLabel.Text = "Amount of raise (in %):"
        '
        'yearsLabel
        '
        Me.yearsLabel.AutoSize = True
        Me.yearsLabel.Location = New System.Drawing.Point(13, 87)
        Me.yearsLabel.Name = "yearsLabel"
        Me.yearsLabel.Size = New System.Drawing.Size(38, 15)
        Me.yearsLabel.TabIndex = 3
        Me.yearsLabel.Text = "Years:"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(234, 16)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'earningsLabel
        '
        Me.earningsLabel.AutoSize = True
        Me.earningsLabel.Location = New System.Drawing.Point(13, 132)
        Me.earningsLabel.Name = "earningsLabel"
        Me.earningsLabel.Size = New System.Drawing.Size(90, 15)
        Me.earningsLabel.TabIndex = 7
        Me.earningsLabel.Text = "Yearly earnings:"
        '
        'earningsTextBox
        '
        Me.earningsTextBox.Location = New System.Drawing.Point(16, 160)
        Me.earningsTextBox.Multiline = True
        Me.earningsTextBox.Name = "earningsTextBox"
        Me.earningsTextBox.ReadOnly = True
        Me.earningsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.earningsTextBox.Size = New System.Drawing.Size(293, 116)
        Me.earningsTextBox.TabIndex = 8
        '
        'percentUpDown
        '
        Me.percentUpDown.Location = New System.Drawing.Point(150, 52)
        Me.percentUpDown.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.percentUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.percentUpDown.Name = "percentUpDown"
        Me.percentUpDown.Size = New System.Drawing.Size(60, 23)
        Me.percentUpDown.TabIndex = 9
        Me.percentUpDown.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'yearsUpDown
        '
        Me.yearsUpDown.Location = New System.Drawing.Point(150, 87)
        Me.yearsUpDown.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.yearsUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.yearsUpDown.Name = "yearsUpDown"
        Me.yearsUpDown.Size = New System.Drawing.Size(60, 23)
        Me.yearsUpDown.TabIndex = 10
        Me.yearsUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PayRaiseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 288)
        Me.Controls.Add(Me.yearsUpDown)
        Me.Controls.Add(Me.percentUpDown)
        Me.Controls.Add(Me.earningsTextBox)
        Me.Controls.Add(Me.earningsLabel)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.yearsLabel)
        Me.Controls.Add(Me.raiseLabel)
        Me.Controls.Add(Me.wageTextBox)
        Me.Controls.Add(Me.wageLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PayRaiseForm"
        Me.Text = "Pay Raise Calculator"
        CType(Me.percentUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yearsUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wageLabel As System.Windows.Forms.Label
    Friend WithEvents wageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents raiseLabel As System.Windows.Forms.Label
    Friend WithEvents yearsLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents earningsLabel As System.Windows.Forms.Label
    Friend WithEvents earningsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents percentUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents yearsUpDown As System.Windows.Forms.NumericUpDown

End Class

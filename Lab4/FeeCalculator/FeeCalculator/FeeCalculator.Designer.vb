<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeCalculatorForm
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
        Me.timeInLabel = New System.Windows.Forms.Label()
        Me.timeOutLabel = New System.Windows.Forms.Label()
        Me.feeLabel = New System.Windows.Forms.Label()
        Me.feeResultLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.timeInDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.timeOutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'timeInLabel
        '
        Me.timeInLabel.AutoSize = True
        Me.timeInLabel.Location = New System.Drawing.Point(11, 20)
        Me.timeInLabel.Name = "timeInLabel"
        Me.timeInLabel.Size = New System.Drawing.Size(50, 15)
        Me.timeInLabel.TabIndex = 0
        Me.timeInLabel.Text = "Time in:"
        '
        'timeOutLabel
        '
        Me.timeOutLabel.AutoSize = True
        Me.timeOutLabel.Location = New System.Drawing.Point(11, 56)
        Me.timeOutLabel.Name = "timeOutLabel"
        Me.timeOutLabel.Size = New System.Drawing.Size(58, 15)
        Me.timeOutLabel.TabIndex = 1
        Me.timeOutLabel.Text = "Time out:"
        '
        'feeLabel
        '
        Me.feeLabel.AutoSize = True
        Me.feeLabel.Location = New System.Drawing.Point(12, 91)
        Me.feeLabel.Name = "feeLabel"
        Me.feeLabel.Size = New System.Drawing.Size(28, 15)
        Me.feeLabel.TabIndex = 2
        Me.feeLabel.Text = "Fee:"
        '
        'feeResultLabel
        '
        Me.feeResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.feeResultLabel.Location = New System.Drawing.Point(76, 87)
        Me.feeResultLabel.Name = "feeResultLabel"
        Me.feeResultLabel.Size = New System.Drawing.Size(102, 23)
        Me.feeResultLabel.TabIndex = 5
        Me.feeResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(103, 128)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'timeInDateTimePicker
        '
        Me.timeInDateTimePicker.CustomFormat = "hh:mm:ss:tt"
        Me.timeInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeInDateTimePicker.Location = New System.Drawing.Point(76, 12)
        Me.timeInDateTimePicker.Name = "timeInDateTimePicker"
        Me.timeInDateTimePicker.ShowUpDown = True
        Me.timeInDateTimePicker.Size = New System.Drawing.Size(102, 23)
        Me.timeInDateTimePicker.TabIndex = 7
        '
        'timeOutDateTimePicker
        '
        Me.timeOutDateTimePicker.CustomFormat = "hh:mm:ss:tt"
        Me.timeOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeOutDateTimePicker.Location = New System.Drawing.Point(76, 56)
        Me.timeOutDateTimePicker.Name = "timeOutDateTimePicker"
        Me.timeOutDateTimePicker.ShowUpDown = True
        Me.timeOutDateTimePicker.Size = New System.Drawing.Size(102, 23)
        Me.timeOutDateTimePicker.TabIndex = 8
        Me.timeOutDateTimePicker.Value = New Date(2014, 2, 8, 22, 43, 18, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "hh:mm:ss:tt"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(86, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'FeeCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 163)
        Me.Controls.Add(Me.timeOutDateTimePicker)
        Me.Controls.Add(Me.timeInDateTimePicker)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.feeResultLabel)
        Me.Controls.Add(Me.feeLabel)
        Me.Controls.Add(Me.timeOutLabel)
        Me.Controls.Add(Me.timeInLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FeeCalculatorForm"
        Me.Text = "Fee Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timeInLabel As System.Windows.Forms.Label
    Friend WithEvents timeOutLabel As System.Windows.Forms.Label
    Friend WithEvents feeLabel As System.Windows.Forms.Label
    Friend WithEvents feeResultLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents timeInDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeOutDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class

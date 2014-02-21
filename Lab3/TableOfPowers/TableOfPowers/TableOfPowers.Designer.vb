<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOfPowersForm
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
        Me.upperLimitLabel = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.resultsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'upperLimitLabel
        '
        Me.upperLimitLabel.AutoSize = True
        Me.upperLimitLabel.Location = New System.Drawing.Point(16, 22)
        Me.upperLimitLabel.Name = "upperLimitLabel"
        Me.upperLimitLabel.Size = New System.Drawing.Size(69, 15)
        Me.upperLimitLabel.TabIndex = 0
        Me.upperLimitLabel.Text = "Upper limit:"
        Me.upperLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(96, 19)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(59, 23)
        Me.inputTextBox.TabIndex = 1
        Me.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(167, 19)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'resultsListBox
        '
        Me.resultsListBox.FormattingEnabled = True
        Me.resultsListBox.ItemHeight = 15
        Me.resultsListBox.Location = New System.Drawing.Point(19, 60)
        Me.resultsListBox.Name = "resultsListBox"
        Me.resultsListBox.Size = New System.Drawing.Size(223, 109)
        Me.resultsListBox.TabIndex = 3
        '
        'TableOfPowersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 179)
        Me.Controls.Add(Me.resultsListBox)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.upperLimitLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TableOfPowersForm"
        Me.Text = "Table Of Powers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents upperLimitLabel As System.Windows.Forms.Label
   Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents resultsListBox As System.Windows.Forms.ListBox

End Class

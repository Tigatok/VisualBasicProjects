<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomeTax
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
        Me.salaryLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.salaryTextBox = New System.Windows.Forms.TextBox()
        Me.taxresultlabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'salaryLabel
        '
        Me.salaryLabel.AutoSize = True
        Me.salaryLabel.Location = New System.Drawing.Point(18, 16)
        Me.salaryLabel.Name = "salaryLabel"
        Me.salaryLabel.Size = New System.Drawing.Size(75, 15)
        Me.salaryLabel.TabIndex = 0
        Me.salaryLabel.Text = "Yearly salary:"
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Location = New System.Drawing.Point(18, 52)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(68, 15)
        Me.taxLabel.TabIndex = 1
        Me.taxLabel.Text = "Income tax:"
        '
        'salaryTextBox
        '
        Me.salaryTextBox.Location = New System.Drawing.Point(109, 13)
        Me.salaryTextBox.Name = "salaryTextBox"
        Me.salaryTextBox.Size = New System.Drawing.Size(100, 23)
        Me.salaryTextBox.TabIndex = 2
        Me.salaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'taxresultlabel
        '
        Me.taxresultlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.taxresultlabel.Location = New System.Drawing.Point(109, 51)
        Me.taxresultlabel.Name = "taxresultlabel"
        Me.taxresultlabel.Size = New System.Drawing.Size(100, 23)
        Me.taxresultlabel.TabIndex = 3
        Me.taxresultlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(109, 89)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(100, 23)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'IncomeTaxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 125)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.taxresultlabel)
        Me.Controls.Add(Me.salaryTextBox)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.salaryLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "IncomeTaxForm"
        Me.Text = "Income Tax Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salaryLabel As System.Windows.Forms.Label
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents salaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents taxresultlabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class

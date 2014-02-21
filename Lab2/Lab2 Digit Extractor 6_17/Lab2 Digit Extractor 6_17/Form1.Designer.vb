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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(163, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 0
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(268, 12)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(75, 23)
        Me.enterButton.TabIndex = 5
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(163, 12)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(99, 20)
        Me.inputTextBox.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Enter five-digit number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Extracted digits:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(184, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(205, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(226, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(247, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 92)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Digit Extractor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class

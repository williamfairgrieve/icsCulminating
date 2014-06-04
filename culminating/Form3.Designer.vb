<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trigCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trigCalc))
        Me.inputBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.invalidLabel = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.radRB = New System.Windows.Forms.RadioButton()
        Me.degRB = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'inputBox
        '
        Me.inputBox.Location = New System.Drawing.Point(12, 43)
        Me.inputBox.Name = "inputBox"
        Me.inputBox.Size = New System.Drawing.Size(100, 20)
        Me.inputBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(197, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(197, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Tan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'invalidLabel
        '
        Me.invalidLabel.AutoSize = True
        Me.invalidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invalidLabel.ForeColor = System.Drawing.Color.Red
        Me.invalidLabel.Location = New System.Drawing.Point(8, 78)
        Me.invalidLabel.Name = "invalidLabel"
        Me.invalidLabel.Size = New System.Drawing.Size(137, 20)
        Me.invalidLabel.TabIndex = 4
        Me.invalidLabel.Text = "INVALID INPUT"
        Me.invalidLabel.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.ForeColor = System.Drawing.Color.Orange
        Me.Button4.Location = New System.Drawing.Point(197, 100)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "RESET"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(12, 100)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Copy to Clipboard"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'radRB
        '
        Me.radRB.AutoSize = True
        Me.radRB.Checked = True
        Me.radRB.Location = New System.Drawing.Point(12, 12)
        Me.radRB.Name = "radRB"
        Me.radRB.Size = New System.Drawing.Size(48, 17)
        Me.radRB.TabIndex = 7
        Me.radRB.TabStop = True
        Me.radRB.Text = "RAD"
        Me.radRB.UseVisualStyleBackColor = True
        '
        'degRB
        '
        Me.degRB.AutoSize = True
        Me.degRB.Location = New System.Drawing.Point(64, 12)
        Me.degRB.Name = "degRB"
        Me.degRB.Size = New System.Drawing.Size(48, 17)
        Me.degRB.TabIndex = 8
        Me.degRB.Text = "DEG"
        Me.degRB.UseVisualStyleBackColor = True
        '
        'trigCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 131)
        Me.Controls.Add(Me.degRB)
        Me.Controls.Add(Me.radRB)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.invalidLabel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.inputBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "trigCalc"
        Me.Text = "Trig Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents invalidLabel As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents radRB As System.Windows.Forms.RadioButton
    Friend WithEvents degRB As System.Windows.Forms.RadioButton
End Class

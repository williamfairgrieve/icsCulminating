<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tempForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tempForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.celcBox = New System.Windows.Forms.TextBox()
        Me.ferBox = New System.Windows.Forms.TextBox()
        Me.kelBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.invalidLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Celsius:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Farenheight:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kelvin:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'celcBox
        '
        Me.celcBox.Location = New System.Drawing.Point(84, 10)
        Me.celcBox.Name = "celcBox"
        Me.celcBox.Size = New System.Drawing.Size(100, 20)
        Me.celcBox.TabIndex = 4
        '
        'ferBox
        '
        Me.ferBox.Location = New System.Drawing.Point(84, 33)
        Me.ferBox.Name = "ferBox"
        Me.ferBox.Size = New System.Drawing.Size(100, 20)
        Me.ferBox.TabIndex = 5
        '
        'kelBox
        '
        Me.kelBox.Location = New System.Drawing.Point(84, 55)
        Me.kelBox.Name = "kelBox"
        Me.kelBox.Size = New System.Drawing.Size(100, 20)
        Me.kelBox.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 28)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'invalidLabel
        '
        Me.invalidLabel.AutoSize = True
        Me.invalidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invalidLabel.ForeColor = System.Drawing.Color.Red
        Me.invalidLabel.Location = New System.Drawing.Point(49, 86)
        Me.invalidLabel.Name = "invalidLabel"
        Me.invalidLabel.Size = New System.Drawing.Size(173, 25)
        Me.invalidLabel.TabIndex = 8
        Me.invalidLabel.Text = "INVALID INPUT"
        Me.invalidLabel.Visible = False
        '
        'tempForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 120)
        Me.Controls.Add(Me.invalidLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.kelBox)
        Me.Controls.Add(Me.ferBox)
        Me.Controls.Add(Me.celcBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tempForm"
        Me.Text = "Temperature Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents celcBox As System.Windows.Forms.TextBox
    Friend WithEvents ferBox As System.Windows.Forms.TextBox
    Friend WithEvents kelBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents invalidLabel As System.Windows.Forms.Label
End Class

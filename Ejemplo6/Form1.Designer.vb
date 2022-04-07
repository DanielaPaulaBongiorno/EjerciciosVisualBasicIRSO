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
        Me.Caja1 = New System.Windows.Forms.TextBox()
        Me.Caja2 = New System.Windows.Forms.TextBox()
        Me.Caja3 = New System.Windows.Forms.TextBox()
        Me.Caja4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Caja1
        '
        Me.Caja1.Location = New System.Drawing.Point(135, 91)
        Me.Caja1.Multiline = True
        Me.Caja1.Name = "Caja1"
        Me.Caja1.Size = New System.Drawing.Size(156, 48)
        Me.Caja1.TabIndex = 0
        '
        'Caja2
        '
        Me.Caja2.Location = New System.Drawing.Point(297, 91)
        Me.Caja2.Multiline = True
        Me.Caja2.Name = "Caja2"
        Me.Caja2.Size = New System.Drawing.Size(156, 48)
        Me.Caja2.TabIndex = 1
        '
        'Caja3
        '
        Me.Caja3.Location = New System.Drawing.Point(459, 91)
        Me.Caja3.Multiline = True
        Me.Caja3.Name = "Caja3"
        Me.Caja3.Size = New System.Drawing.Size(156, 48)
        Me.Caja3.TabIndex = 2
        '
        'Caja4
        '
        Me.Caja4.Location = New System.Drawing.Point(263, 188)
        Me.Caja4.Multiline = True
        Me.Caja4.Name = "Caja4"
        Me.Caja4.Size = New System.Drawing.Size(220, 92)
        Me.Caja4.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 59)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Pegar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Caja4)
        Me.Controls.Add(Me.Caja3)
        Me.Controls.Add(Me.Caja2)
        Me.Controls.Add(Me.Caja1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Caja1 As TextBox
    Friend WithEvents Caja2 As TextBox
    Friend WithEvents Caja3 As TextBox
    Friend WithEvents Caja4 As TextBox
    Friend WithEvents Button1 As Button
End Class

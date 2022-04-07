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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Caja1
        '
        Me.Caja1.Location = New System.Drawing.Point(190, 68)
        Me.Caja1.Name = "Caja1"
        Me.Caja1.Size = New System.Drawing.Size(100, 23)
        Me.Caja1.TabIndex = 0
        Me.Caja1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Caja2
        '
        Me.Caja2.Location = New System.Drawing.Point(190, 120)
        Me.Caja2.Name = "Caja2"
        Me.Caja2.Size = New System.Drawing.Size(100, 23)
        Me.Caja2.TabIndex = 1
        Me.Caja2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Caja3
        '
        Me.Caja3.Location = New System.Drawing.Point(190, 210)
        Me.Caja3.Name = "Caja3"
        Me.Caja3.Size = New System.Drawing.Size(100, 23)
        Me.Caja3.TabIndex = 2
        Me.Caja3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 57)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Número 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

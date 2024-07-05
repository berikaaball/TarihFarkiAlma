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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPİlk = New System.Windows.Forms.DateTimePicker()
        Me.DTPSon = New System.Windows.Forms.DateTimePicker()
        Me.CBoxFarkTipi = New System.Windows.Forms.ComboBox()
        Me.TBoxFark = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "İlk Tarih:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Son Tarih:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fark Tipi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fark:"
        '
        'DTPİlk
        '
        Me.DTPİlk.Location = New System.Drawing.Point(202, 55)
        Me.DTPİlk.Name = "DTPİlk"
        Me.DTPİlk.Size = New System.Drawing.Size(200, 22)
        Me.DTPİlk.TabIndex = 4
        '
        'DTPSon
        '
        Me.DTPSon.Location = New System.Drawing.Point(202, 99)
        Me.DTPSon.Name = "DTPSon"
        Me.DTPSon.Size = New System.Drawing.Size(200, 22)
        Me.DTPSon.TabIndex = 5
        '
        'CBoxFarkTipi
        '
        Me.CBoxFarkTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxFarkTipi.FormattingEnabled = True
        Me.CBoxFarkTipi.Location = New System.Drawing.Point(202, 143)
        Me.CBoxFarkTipi.Name = "CBoxFarkTipi"
        Me.CBoxFarkTipi.Size = New System.Drawing.Size(121, 24)
        Me.CBoxFarkTipi.TabIndex = 6
        '
        'TBoxFark
        '
        Me.TBoxFark.Location = New System.Drawing.Point(202, 190)
        Me.TBoxFark.Name = "TBoxFark"
        Me.TBoxFark.ReadOnly = True
        Me.TBoxFark.Size = New System.Drawing.Size(100, 22)
        Me.TBoxFark.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Farkı Gör"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 375)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBoxFark)
        Me.Controls.Add(Me.CBoxFarkTipi)
        Me.Controls.Add(Me.DTPSon)
        Me.Controls.Add(Me.DTPİlk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarih Farkı Al"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPİlk As DateTimePicker
    Friend WithEvents DTPSon As DateTimePicker
    Friend WithEvents CBoxFarkTipi As ComboBox
    Friend WithEvents TBoxFark As TextBox
    Friend WithEvents Button1 As Button
End Class

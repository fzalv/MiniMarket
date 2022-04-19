<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransTerimaBarang
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_tlpsup = New System.Windows.Forms.Label()
        Me.lbl_namasup = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_alamatsup = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_kodeterima = New System.Windows.Forms.Label()
        Me.cbkodesupplier = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_tgl = New System.Windows.Forms.Label()
        Me.lbl_jam = New System.Windows.Forms.Label()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Terima"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Supplier"
        '
        'lbl_tlpsup
        '
        Me.lbl_tlpsup.AutoSize = True
        Me.lbl_tlpsup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tlpsup.Location = New System.Drawing.Point(127, 227)
        Me.lbl_tlpsup.Name = "lbl_tlpsup"
        Me.lbl_tlpsup.Size = New System.Drawing.Size(14, 20)
        Me.lbl_tlpsup.TabIndex = 0
        Me.lbl_tlpsup.Text = "-"
        '
        'lbl_namasup
        '
        Me.lbl_namasup.AutoSize = True
        Me.lbl_namasup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_namasup.Location = New System.Drawing.Point(127, 128)
        Me.lbl_namasup.Name = "lbl_namasup"
        Me.lbl_namasup.Size = New System.Drawing.Size(14, 20)
        Me.lbl_namasup.TabIndex = 0
        Me.lbl_namasup.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nama"
        '
        'lbl_alamatsup
        '
        Me.lbl_alamatsup.AutoSize = True
        Me.lbl_alamatsup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alamatsup.Location = New System.Drawing.Point(127, 176)
        Me.lbl_alamatsup.Name = "lbl_alamatsup"
        Me.lbl_alamatsup.Size = New System.Drawing.Size(14, 20)
        Me.lbl_alamatsup.TabIndex = 0
        Me.lbl_alamatsup.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Telepon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Alamat"
        '
        'lbl_kodeterima
        '
        Me.lbl_kodeterima.AutoSize = True
        Me.lbl_kodeterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kodeterima.Location = New System.Drawing.Point(127, 34)
        Me.lbl_kodeterima.Name = "lbl_kodeterima"
        Me.lbl_kodeterima.Size = New System.Drawing.Size(57, 20)
        Me.lbl_kodeterima.TabIndex = 0
        Me.lbl_kodeterima.Text = "Label1"
        '
        'cbkodesupplier
        '
        Me.cbkodesupplier.FormattingEnabled = True
        Me.cbkodesupplier.Location = New System.Drawing.Point(131, 80)
        Me.cbkodesupplier.Name = "cbkodesupplier"
        Me.cbkodesupplier.Size = New System.Drawing.Size(121, 21)
        Me.cbkodesupplier.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(373, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(373, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Admin"
        '
        'lbl_tgl
        '
        Me.lbl_tgl.AutoSize = True
        Me.lbl_tgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tgl.Location = New System.Drawing.Point(480, 34)
        Me.lbl_tgl.Name = "lbl_tgl"
        Me.lbl_tgl.Size = New System.Drawing.Size(14, 20)
        Me.lbl_tgl.TabIndex = 0
        Me.lbl_tgl.Text = "-"
        '
        'lbl_jam
        '
        Me.lbl_jam.AutoSize = True
        Me.lbl_jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jam.Location = New System.Drawing.Point(480, 81)
        Me.lbl_jam.Name = "lbl_jam"
        Me.lbl_jam.Size = New System.Drawing.Size(14, 20)
        Me.lbl_jam.TabIndex = 0
        Me.lbl_jam.Text = "-"
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admin.Location = New System.Drawing.Point(480, 129)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(14, 20)
        Me.lbl_admin.TabIndex = 0
        Me.lbl_admin.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TransTerimaBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 434)
        Me.Controls.Add(Me.cbkodesupplier)
        Me.Controls.Add(Me.lbl_kodeterima)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_admin)
        Me.Controls.Add(Me.lbl_jam)
        Me.Controls.Add(Me.lbl_tgl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_alamatsup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_namasup)
        Me.Controls.Add(Me.lbl_tlpsup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TransTerimaBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransTerimaBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_tlpsup As System.Windows.Forms.Label
    Friend WithEvents lbl_namasup As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_alamatsup As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_kodeterima As System.Windows.Forms.Label
    Friend WithEvents cbkodesupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_tgl As System.Windows.Forms.Label
    Friend WithEvents lbl_jam As System.Windows.Forms.Label
    Friend WithEvents lbl_admin As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

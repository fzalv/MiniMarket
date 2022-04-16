<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterSupplier
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_telepon = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(273, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(329, 238)
        Me.DataGridView1.TabIndex = 16
        '
        'btn_tutup
        '
        Me.btn_tutup.Location = New System.Drawing.Point(138, 252)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(75, 23)
        Me.btn_tutup.TabIndex = 8
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(36, 252)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 7
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(138, 197)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 6
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(36, 197)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(75, 23)
        Me.btn_input.TabIndex = 5
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(124, 111)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(100, 20)
        Me.txt_alamat.TabIndex = 3
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(124, 75)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(100, 20)
        Me.txt_nama.TabIndex = 2
        '
        'txt_kode
        '
        Me.txt_kode.Location = New System.Drawing.Point(124, 37)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(100, 20)
        Me.txt_kode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Kode"
        '
        'txt_telepon
        '
        Me.txt_telepon.Location = New System.Drawing.Point(124, 144)
        Me.txt_telepon.Name = "txt_telepon"
        Me.txt_telepon.Size = New System.Drawing.Size(100, 20)
        Me.txt_telepon.TabIndex = 4
        '
        'MasterSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 310)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.txt_telepon)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MasterSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterSupplier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_tutup As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_input As System.Windows.Forms.Button
    Friend WithEvents txt_alamat As System.Windows.Forms.TextBox
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_kode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_telepon As System.Windows.Forms.TextBox
End Class

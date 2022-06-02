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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Harga = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgvterimabarang = New System.Windows.Forms.DataGridView()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntbatal = New System.Windows.Forms.Button()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblitem = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgvterimabarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Terima"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Supplier"
        '
        'lbl_tlpsup
        '
        Me.lbl_tlpsup.AutoSize = True
        Me.lbl_tlpsup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tlpsup.Location = New System.Drawing.Point(503, 105)
        Me.lbl_tlpsup.Name = "lbl_tlpsup"
        Me.lbl_tlpsup.Size = New System.Drawing.Size(14, 20)
        Me.lbl_tlpsup.TabIndex = 0
        Me.lbl_tlpsup.Text = "-"
        '
        'lbl_namasup
        '
        Me.lbl_namasup.AutoSize = True
        Me.lbl_namasup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_namasup.Location = New System.Drawing.Point(503, 44)
        Me.lbl_namasup.Name = "lbl_namasup"
        Me.lbl_namasup.Size = New System.Drawing.Size(14, 20)
        Me.lbl_namasup.TabIndex = 0
        Me.lbl_namasup.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nama"
        '
        'lbl_alamatsup
        '
        Me.lbl_alamatsup.AutoSize = True
        Me.lbl_alamatsup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alamatsup.Location = New System.Drawing.Point(503, 75)
        Me.lbl_alamatsup.Name = "lbl_alamatsup"
        Me.lbl_alamatsup.Size = New System.Drawing.Size(14, 20)
        Me.lbl_alamatsup.TabIndex = 0
        Me.lbl_alamatsup.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Telepon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(388, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Alamat"
        '
        'lbl_kodeterima
        '
        Me.lbl_kodeterima.AutoSize = True
        Me.lbl_kodeterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kodeterima.Location = New System.Drawing.Point(142, 44)
        Me.lbl_kodeterima.Name = "lbl_kodeterima"
        Me.lbl_kodeterima.Size = New System.Drawing.Size(57, 20)
        Me.lbl_kodeterima.TabIndex = 0
        Me.lbl_kodeterima.Text = "Label1"
        '
        'cbkodesupplier
        '
        Me.cbkodesupplier.FormattingEnabled = True
        Me.cbkodesupplier.Location = New System.Drawing.Point(146, 73)
        Me.cbkodesupplier.Name = "cbkodesupplier"
        Me.cbkodesupplier.Size = New System.Drawing.Size(121, 21)
        Me.cbkodesupplier.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(217, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(401, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Admin"
        '
        'lbl_tgl
        '
        Me.lbl_tgl.AutoSize = True
        Me.lbl_tgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tgl.Location = New System.Drawing.Point(87, 9)
        Me.lbl_tgl.Name = "lbl_tgl"
        Me.lbl_tgl.Size = New System.Drawing.Size(14, 20)
        Me.lbl_tgl.TabIndex = 0
        Me.lbl_tgl.Text = "-"
        '
        'lbl_jam
        '
        Me.lbl_jam.AutoSize = True
        Me.lbl_jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jam.Location = New System.Drawing.Point(262, 9)
        Me.lbl_jam.Name = "lbl_jam"
        Me.lbl_jam.Size = New System.Drawing.Size(14, 20)
        Me.lbl_jam.TabIndex = 0
        Me.lbl_jam.Text = "-"
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admin.Location = New System.Drawing.Point(480, 9)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(14, 20)
        Me.lbl_admin.TabIndex = 0
        Me.lbl_admin.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kode"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nama"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(95, 157)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(14, 20)
        Me.lbl_nama.TabIndex = 0
        Me.lbl_nama.Text = "-"
        '
        'Harga
        '
        Me.Harga.AutoSize = True
        Me.Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harga.Location = New System.Drawing.Point(308, 160)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(53, 20)
        Me.Harga.TabIndex = 0
        Me.Harga.Text = "Harga"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(99, 136)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(100, 20)
        Me.txtkode.TabIndex = 2
        Me.txtkode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblharga.Location = New System.Drawing.Point(367, 160)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(14, 20)
        Me.lblharga.TabIndex = 0
        Me.lblharga.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(464, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Jumlah"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(530, 159)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(39, 20)
        Me.txtjumlah.TabIndex = 2
        Me.txtjumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(593, 156)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(63, 23)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dgvterimabarang
        '
        Me.dgvterimabarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvterimabarang.Location = New System.Drawing.Point(13, 191)
        Me.dgvterimabarang.Name = "dgvterimabarang"
        Me.dgvterimabarang.Size = New System.Drawing.Size(643, 167)
        Me.dgvterimabarang.TabIndex = 4
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(20, 364)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(63, 23)
        Me.btnsimpan.TabIndex = 3
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btntbatal
        '
        Me.btntbatal.Location = New System.Drawing.Point(89, 364)
        Me.btntbatal.Name = "btntbatal"
        Me.btntbatal.Size = New System.Drawing.Size(63, 23)
        Me.btntbatal.TabIndex = 3
        Me.btntbatal.Text = "Batal"
        Me.btntbatal.UseVisualStyleBackColor = True
        '
        'btntutup
        '
        Me.btntutup.Location = New System.Drawing.Point(158, 364)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(63, 23)
        Me.btntutup.TabIndex = 3
        Me.btntutup.Text = "Tutup"
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(439, 369)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Item"
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitem.Location = New System.Drawing.Point(486, 369)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(18, 20)
        Me.lblitem.TabIndex = 0
        Me.lblitem.Text = "0"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(595, 368)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(19, 20)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(537, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Total :"
        '
        'TransTerimaBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 397)
        Me.Controls.Add(Me.dgvterimabarang)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btntbatal)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.cbkodesupplier)
        Me.Controls.Add(Me.lbl_kodeterima)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_admin)
        Me.Controls.Add(Me.lbl_jam)
        Me.Controls.Add(Me.lbl_tgl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lblharga)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Harga)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
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
        CType(Me.dgvterimabarang, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Harga As System.Windows.Forms.Label
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents lblharga As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents dgvterimabarang As System.Windows.Forms.DataGridView
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntbatal As System.Windows.Forms.Button
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class

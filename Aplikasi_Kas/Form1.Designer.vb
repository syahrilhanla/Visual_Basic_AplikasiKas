<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.DateTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.tableIsiKas = New System.Windows.Forms.DataGridView()
        Me.IsiKas = New Aplikasi_Kas.isiKas()
        Me.IsitablekasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Isi_tablekasTableAdapter = New Aplikasi_Kas.isiKasTableAdapters.isi_tablekasTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbNomor = New System.Windows.Forms.ComboBox()
        CType(Me.tableIsiKas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsiKas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsitablekasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(163, 212)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(200, 20)
        Me.txtKeterangan.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(274, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(401, 247)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(405, 36)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Aplikasi Kas Pengeluaran & Pemasukan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(163, 176)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(200, 20)
        Me.txtJumlah.TabIndex = 16
        '
        'DateTransaksi
        '
        Me.DateTransaksi.Location = New System.Drawing.Point(163, 109)
        Me.DateTransaksi.Name = "DateTransaksi"
        Me.DateTransaksi.Size = New System.Drawing.Size(200, 20)
        Me.DateTransaksi.TabIndex = 18
        '
        'cmbJenis
        '
        Me.cmbJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Masuk", "Keluar"})
        Me.cmbJenis.Location = New System.Drawing.Point(163, 142)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(200, 21)
        Me.cmbJenis.TabIndex = 19
        '
        'tableIsiKas
        '
        Me.tableIsiKas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableIsiKas.Location = New System.Drawing.Point(67, 276)
        Me.tableIsiKas.Name = "tableIsiKas"
        Me.tableIsiKas.Size = New System.Drawing.Size(483, 150)
        Me.tableIsiKas.TabIndex = 20
        '
        'IsiKas
        '
        Me.IsiKas.DataSetName = "isiKas"
        Me.IsiKas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IsitablekasBindingSource
        '
        Me.IsitablekasBindingSource.DataMember = "isi_tablekas"
        Me.IsitablekasBindingSource.DataSource = Me.IsiKas
        '
        'Isi_tablekasTableAdapter
        '
        Me.Isi_tablekasTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Rp."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(401, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saldo Utama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(43, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(293, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Cari Berdasarkan Nomor Peminjaman"
        '
        'cmbNomor
        '
        Me.cmbNomor.FormattingEnabled = True
        Me.cmbNomor.Location = New System.Drawing.Point(163, 82)
        Me.cmbNomor.Name = "cmbNomor"
        Me.cmbNomor.Size = New System.Drawing.Size(200, 21)
        Me.cmbNomor.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 438)
        Me.Controls.Add(Me.cmbNomor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tableIsiKas)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.DateTransaksi)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Kas"
        CType(Me.tableIsiKas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsiKas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsitablekasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents DateTransaksi As DateTimePicker
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents tableIsiKas As DataGridView
    Friend WithEvents IsiKas As isiKas
    Friend WithEvents IsitablekasBindingSource As BindingSource
    Friend WithEvents Isi_tablekasTableAdapter As isiKasTableAdapters.isi_tablekasTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbNomor As ComboBox
End Class

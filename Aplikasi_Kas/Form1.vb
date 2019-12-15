Imports System.Data.Odbc

Public Class Form1
    Public SaldoSekarang As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IsiKas.isi_tablekas' table. You can move, or remove it, as needed.
        Me.Isi_tablekasTableAdapter.Fill(Me.IsiKas.isi_tablekas)
        TampilGrid()
        ambilSaldo()
        daftarNomorPeminjaman()
    End Sub

    Sub TampilGrid()
        bukakoneksi()

        DA = New OdbcDataAdapter("select * From isi_tablekas ", CONN)
        DS = New DataSet
        DA.Fill(DS, "isi_tablekas")
        tableIsiKas.DataSource = DS.Tables("isi_tablekas")
        TutupKoneksi()
    End Sub

    Sub kosongkanInput()
        txtJumlah.Text = ""
        txtKeterangan.Text = ""

    End Sub

    Sub ambilSaldo()
        bukakoneksi()

        DA = New OdbcDataAdapter("SELECT * from isi_tablekas order by NomorTransaksi desc limit 1", CONN)
        DS = New DataSet
        DA.Fill(DS, "isi_tablekas")
        Label5.Text = DS.Tables(0).Rows(0).Item(2)
        SaldoSekarang = DS.Tables(0).Rows(0).Item(2)

        TutupKoneksi()
    End Sub

    Sub daftarNomorPeminjaman()
        bukakoneksi()
        Dim daftar_nomor = "select NomorTransaksi From isi_tablekas"
        CMD = New OdbcCommand(daftar_nomor, CONN)
        RD = CMD.ExecuteReader()
        If RD.HasRows() Then
            Do While RD.Read()
                cmbNomor.Items.Add(RD("NomorTransaksi"))
            Loop
        End If
        TutupKoneksi()
    End Sub

    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNomor.KeyPress
        cmbNomor.MaxLength = 3
        If e.KeyChar = Chr(13) Then
            bukakoneksi()
            CMD = New OdbcCommand("Select * from isi_tablekas where NomorTransaksi ='" & cmbNomor.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("No Tidak Ada, Silahkan coba lagi!")
            Else
                cmbJenis.Text = RD.Item("Jenis")
                txtJumlah.Text = RD.Item("Jumlah")
                txtKeterangan.Text = RD.Item("Keterangan")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim JumlahMasuk As Integer = CInt(txtJumlah.Text)
        Dim saldoAwal As Integer = CInt(SaldoSekarang)
        Dim totalSaldo As Integer

        If txtJumlah.Text = "" Or txtKeterangan.Text = "" Or cmbJenis.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            bukakoneksi()
            If cmbJenis.Text = "Masuk" Then
                totalSaldo = JumlahMasuk + saldoAwal

                Dim simpan As String = "insert into isi_tablekas (Tanggal, Jenis, Jumlah, Keterangan, Saldo) values ('" & Format(DateTransaksi.Value, "yyyy-MM-dd") & "', '" & cmbJenis.Text & "', '" & txtJumlah.Text & "', '" & txtKeterangan.Text & "', '" & totalSaldo & "')"
                CMD = New OdbcCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                TampilGrid()
                ambilSaldo()
                kosongkanInput()
                TutupKoneksi()

            ElseIf cmbJenis.Text = "Keluar" Then

                If saldoAwal >= 5000 Then
                    totalSaldo = saldoAwal - JumlahMasuk
                    If totalSaldo < 5000 Then
                        totalSaldo = totalSaldo + JumlahMasuk
                        MsgBox("Batas minimum saldo adalah Rp.5000, anda tidak dapat menarik saldo sekarang")
                    End If
                Else
                    MsgBox("Batas minimum saldo adalah Rp.5000, anda tidak dapat menarik saldo sekarang")
                End If

                Dim simpan As String = "insert into isi_tablekas (Tanggal, Jenis, Jumlah, Keterangan, Saldo) values ('" & Format(DateTransaksi.Value, "yyyy-MM-dd") & "', '" & cmbJenis.Text & "', '" & txtJumlah.Text & "', '" & txtKeterangan.Text & "', '" & totalSaldo & "')"
                    CMD = New OdbcCommand(simpan, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Input data berhasil")
                    TampilGrid()
                    ambilSaldo()
                    kosongkanInput()
                    TutupKoneksi()
                End If
            TutupKoneksi()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bukakoneksi()
        Dim edit As String = "update isi_tablekas set
        
        Jenis ='" & cmbJenis.Text & "',
        Jumlah ='" & txtJumlah.Text & "',
        Keterangan ='" & txtKeterangan.Text & "',
        Tanggal = '" & Format(DateTransaksi.Value, "yyyy-MM-dd") & "'
        where NomorTransaksi = '" & cmbNomor.Text & "' "

        CMD = New OdbcCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        TampilGrid()
        kosongkanInput()
        TutupKoneksi()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cmbNomor.Text = "" Then
            MsgBox("Silahkan Pilih Data yag akan dihapus dengan Masukan id dan Enter")
        Else
            If MessageBox.Show("Hapus Data? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) Then
                bukakoneksi()
                Dim hapus As String = "delete from isi_tablekas where NomorTransaksi ='" & cmbNomor.Text & "'"
                CMD = New OdbcCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                TampilGrid()
                kosongkanInput()
                TutupKoneksi()
            End If
        End If
    End Sub
End Class

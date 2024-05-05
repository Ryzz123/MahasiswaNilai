Public Class Form1
    Private Function Validasi() As Boolean
        If TextBox1.Text = "" Then
            MessageBox.Show("Nama Harus Diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return False
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("NIM Harus Diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Return False
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Prodi Harus Diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Focus()
            Return False
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Fakultas Harus Diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox4.Focus()
            Return False
        ElseIf TextBox5.Text = "" Then
            MessageBox.Show("Nilai Harian Harus Diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox5.Focus()
            Return False
        ElseIf TextBox6.Text = "" Then
            MessageBox.Show("Nilai Absen Harus Diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox6.Focus()
            Return False
        ElseIf TextBox7.Text = "" Then
            MessageBox.Show("Nilai UAS Harus Diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox7.Focus()
            Return False
        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Nilai UTS Harus Diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox8.Focus()
            Return False
        End If
        Return True
    End Function
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Validasi() Then
            Return
        End If
        
        Dim Nama As String = TextBox1.Text
        Dim NIM As String = TextBox2.Text
        Dim Prodi As String = TextBox3.Text
        Dim Fakultas As String = TextBox4.Text

        Dim NilaiHarian As Single = Val(TextBox5.Text)*0.2
        Dim NilaiAbsen As Single = Val(TextBox6.Text)*0.2
        Dim NilaiUTS As Single = Val(TextBox8.Text)*0.25
        Dim NilaiUAS As Single = Val(TextBox7.Text)*0.25

        Dim NilaiAkhir As Integer = NilaiHarian + NilaiAbsen + NilaiUTS + NilaiUAS

        If NilaiAkhir >= 80 Then
            MessageBox.Show(
                "Selamat " & Nama & " dengan NIM " & NIM & " dari Prodi " & Prodi & " Fakultas " & Fakultas &
                " Anda Lulus dengan Nilai " & NilaiAkhir, "A", MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        ElseIf NilaiAkhir >= 70 Then
            MessageBox.Show(
                "Selamat " & Nama & " dengan NIM " & NIM & " dari Prodi " & Prodi & " Fakultas " & Fakultas &
                " Anda Lulus dengan Nilai " & NilaiAkhir, "B", MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        ElseIf NilaiAkhir >= 60 Then
            MessageBox.Show(
                "Selamat " & Nama & " dengan NIM " & NIM & " dari Prodi " & Prodi & " Fakultas " & Fakultas &
                " Anda Lulus dengan Nilai " & NilaiAkhir, "C", MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        ElseIf NilaiAkhir >= 50 Then
            MessageBox.Show(
                "Selamat " & Nama & " dengan NIM " & NIM & " dari Prodi " & Prodi & " Fakultas " & Fakultas &
                " Anda Lulus dengan Nilai " & NilaiAkhir, "D", MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        Else
            MessageBox.Show(
                "Maaf " & Nama & " dengan NIM " & NIM & " dari Prodi " & Prodi & " Fakultas " & Fakultas &
                " Anda Tidak Lulus dengan Nilai " & NilaiAkhir, "E", MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End If
    End Sub
End Class

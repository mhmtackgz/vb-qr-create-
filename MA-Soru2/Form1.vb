Imports ThoughtWorks.QRCode
Imports System.Text
Imports ThoughtWorks.QRCode.Codec

Public Class Form1


    Private Sub MAQRButton_Click(sender As Object, e As EventArgs) Handles MAQRButton.Click
        Dim VerileriYazdır As String
        VerileriYazdır = MAPersonelTextBox.Text + "*" + MASicilTextBox.Text + "*" + MAGörevTextBox.Text
        'QR da oluşacak metnin aralarında yıldız istendiği için bir değişkene atandı 
        If (MAPersonelTextBox.TextLength > 0 And MASicilTextBox.TextLength > 0 And MAGörevTextBox.TextLength > 0) Then
            '3 tane texboxt'ın boş olup olmama kontorlu sağlandı
            Dim Veri As String = TurkceKarakterler(VerileriYazdır) 'Veri adında bir değer oluşturulup picture boxa aktarıldı.
            'Sebebi ise girilen değerlere göre QR oluşacak bundan dolayı
            PictureBox1.Image = KodOlustur(Veri)
        Else
            MessageBox.Show("Veri Girmelisiniz.", "Hata")
            MAPersonelTextBox.Select()
        End If
    End Sub
    Private Function KodOlustur(Veri As String) As Image
        Dim KodResim As Image = Nothing 'Kodresim adlı değişken oluşturulup değeri boş olarak verildi.
        Dim QRKodlama As New Codec.QRCodeEncoder ' QR Oluşturucu tanımlandı.
        QRKodlama.QRCodeForegroundColor = Color.Blue ' QR renginin mavi olması sağlandı
        QRKodlama.QRCodeBackgroundColor = Color.White ' Arkaplan renginin beyaz olması sağlandı
        QRKodlama.QRCodeScale = 3 'QR ölçek değeri 3 olarak verildi
        QRKodlama.QRCodeVersion = 5 'QR versiyonu 5 olarak verildi
        QRKodlama.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M ' Hata Düzeltme M olarak ayarlardı (Orta Seviye) 
        Try
            KodResim = QRKodlama.Encode(Veri, Encoding.Unicode) ' QR kod okunduktan sonra UTF-16 olarak  kodlama sağlar
        Catch ex As Exception
            MessageBox.Show("Programda Hata Oluştu", "Hata")
        End Try
        Return KodResim
    End Function
    Private Function TurkceKarakterler(Metin As String) As String
        'Buraya bir fonksiyon oluşturuldu. Sebebi ise girilen değerlerin Türkçe karaktere uyum sağlamaması 
        'girilen değerin büyük veya küçük olma durumunda QR değişmesinden dolayı
        Dim Kelimeler As String = "üiçğşöÜİÇĞŞÖ" ' Değişmesi istenen kelimeler belirlendi ve Kelimeler adlı değişkene atandı
        Dim DeğişecekKelimeler As String = "UICGSOUICGSO" 'Kelimeler değişkeninde belirlenen harflerin alacakları değer belirlendi 
        For i = 0 To Kelimeler.Length - 1
            Metin = Metin.Replace(Kelimeler(i), DeğişecekKelimeler(i))
        Next
        Return Metin.ToUpper
    End Function

    Private Sub MAPersonelTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MAPersonelTextBox.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Bu Alana Sadece Harf Değeri Girebilir", "Bilgilendirme")
        End If

    End Sub

    Private Sub MASicilTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MASicilTextBox.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Bu Alana Sadece Sayı Değeri Girebilir", "Bilgilendirme")
        End If
    End Sub

    Private Sub MAGörevTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MAGörevTextBox.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Bu Alana Sadece Harf Değeri Girebilir", "Bilgilendirme")
        End If
    End Sub
End Class

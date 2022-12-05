<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MAPersonelTextBox = New System.Windows.Forms.TextBox()
        Me.MASicilTextBox = New System.Windows.Forms.TextBox()
        Me.MAGörevTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MAQRButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personel Ad Soyad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Personel Sicil No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Personelin Görevi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Personel Kimliği"
        '
        'MAPersonelTextBox
        '
        Me.MAPersonelTextBox.Location = New System.Drawing.Point(127, 44)
        Me.MAPersonelTextBox.Name = "MAPersonelTextBox"
        Me.MAPersonelTextBox.Size = New System.Drawing.Size(185, 20)
        Me.MAPersonelTextBox.TabIndex = 4
        '
        'MASicilTextBox
        '
        Me.MASicilTextBox.Location = New System.Drawing.Point(127, 70)
        Me.MASicilTextBox.Name = "MASicilTextBox"
        Me.MASicilTextBox.Size = New System.Drawing.Size(185, 20)
        Me.MASicilTextBox.TabIndex = 5
        '
        'MAGörevTextBox
        '
        Me.MAGörevTextBox.Location = New System.Drawing.Point(127, 95)
        Me.MAGörevTextBox.Name = "MAGörevTextBox"
        Me.MAGörevTextBox.Size = New System.Drawing.Size(185, 20)
        Me.MAGörevTextBox.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MA_Soru2.My.Resources.Resources.Qr_Code
        Me.PictureBox1.Location = New System.Drawing.Point(318, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MAQRButton
        '
        Me.MAQRButton.Location = New System.Drawing.Point(24, 121)
        Me.MAQRButton.Name = "MAQRButton"
        Me.MAQRButton.Size = New System.Drawing.Size(288, 42)
        Me.MAQRButton.TabIndex = 8
        Me.MAQRButton.Text = "QR KOD OLUŞTUR"
        Me.MAQRButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(548, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 212)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MAQRButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MAGörevTextBox)
        Me.Controls.Add(Me.MASicilTextBox)
        Me.Controls.Add(Me.MAPersonelTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mehmet Acikgöz"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MAPersonelTextBox As TextBox
    Friend WithEvents MASicilTextBox As TextBox
    Friend WithEvents MAGörevTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MAQRButton As Button
    Friend WithEvents Label5 As Label
End Class

Public Class Form1
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim BR_Generator As New MessagingToolkit.Barcode.BarcodeEncoder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PictureBox1.Image = QR_Generator.Encode(TextBox1.Text)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BR_Generator.IncludeLabel = True
        BR_Generator.CustomLabel = TextBox2.Text
        Try
            PictureBox2.Image = BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, TextBox2.Text)
            'PictureBox2.Image = New Bitmap(BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.ISBN, TextBox2.Text))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Image File (*.jpeg;*jpg;*.png;*.bmp;)| *.jpeg;*jpg;*.png;*.bmp;"
        If SD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class

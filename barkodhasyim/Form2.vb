Imports MessagingToolkit.Barcode.BarcodeDecoder
Imports MessagingToolkit.QRCode.Codec

Public Class Form2
    Dim QR_Generator1 As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim BR_Generator1 As New MessagingToolkit.Barcode.BarcodeEncoder

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OPD As New OpenFileDialog
        OPD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If OPD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Load(OPD.FileName)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Scanner As New MessagingToolkit.Barcode.BarcodeDecoder
        Dim result As MessagingToolkit.Barcode.Result
        Try
            result = Scanner.Decode(New Bitmap(PictureBox1.Image))
            MsgBox(result.Text)
            TextBox2.Text = result.Text
        Catch ex As Exception
        End Try
    End Sub


End Class
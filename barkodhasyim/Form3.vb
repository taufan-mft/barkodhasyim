Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode
Imports WebCam_Capture

Public Class Form3
    WithEvents Mywebcam As WebCamCapture
    Dim Reader As QRCodeDecoder
    Dim Scanner As New BarcodeDecoder
    Dim result As MessagingToolkit.Barcode.Result
    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles Mywebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage

    End Sub
    Private Sub StartWebCam()
        Try
            'StopWebcam()
            Mywebcam = New WebCamCapture
            Mywebcam.Start(0)
            Mywebcam.Start(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub StopWebCam()
        Try
            Mywebcam.Stop()
            Mywebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartWebCam()
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            StopWebCam()
            StopWebCam()
            Reader = New QRCodeDecoder
            TextBox1.Text = Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("QR code is detected!")
            MsgBox("QR code is detected!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StopWebCam()
    End Sub
End Class
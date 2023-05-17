Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Form2

    Dim LabelTimerc As Integer
    Public filetoload As String = ""

    Private _originalSize As Size = Nothing
    Private _scale As Single = 1
    Private _scaleDelta As Single = 0.0005

    Private Sub PictureBox_MouseWheel(sender As System.Object,
                             e As MouseEventArgs) Handles PictureBoxResult.MouseWheel
        If e.Delta <> 0 Then
            If e.Delta <= 0 Then
                If PictureBoxResult.Width < 100 Then Exit Sub
            Else
                If PictureBoxResult.Width > (Me.Width * 5) Then Exit Sub
            End If

            PictureBoxResult.Width += CInt(PictureBoxResult.Width * e.Delta / 1000)
            PictureBoxResult.Height += CInt(PictureBoxResult.Height * e.Delta / 1000)
        End If

    End Sub

    Private Sub ButtonDelResult_Click(sender As Object, e As EventArgs) Handles ButtonDelResult.Click
        If TextBoxResult.Text <> "" Then
            Try
                PictureBoxResult.Image.Dispose()
                My.Computer.FileSystem.DeleteFile(TextBoxResult.Text)
                TextBoxResult.Text = ""
                LabelTimer.Text = "D"
            Catch
                LabelTimer.Text = "E"
            End Try
        End If
    End Sub

    Private Sub ButtonResult_Click(sender As Object, e As EventArgs) Handles ButtonResult.Click
        refreshResultImage()
    End Sub


    Private Sub refreshResultImage()

        Try
            Dim tryFile As New IO.FileInfo(filetoload)
            If tryFile.Exists Then

                LabelTimer.Text = "."
                Dim tryFileName = tryFile.Name
                Dim ImageSource = New Bitmap(filetoload, True)
                PictureBoxResult.Image = ImageSource
                Me.Refresh()
                TextBoxResult.Text = filetoload

                Timer1.Enabled = False
                ' Form1.PictureBoxResult.Image = ImageSource

                '          PictureBoxResult.Image.Dispose()
                ' LabelSourceName.Text = Microsoft.VisualBasic.Left(tryFileName, 12)
                ' PictureBoxSourceLabel.Text = ImageSource.Size.ToString + " - " + tryFile.Length.ToString
            Else
                ' LabelTimer.Text = "E"
            End If
        Catch ex As Exception
            LabelTimer.Text = "E"
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTimerc = LabelTimerc + 1
        If LabelTimerc = 1 Then
            LabelTimer.Text = "-"
        ElseIf LabelTimerc = 2 Then
            LabelTimer.Text = "/"
        ElseIf LabelTimerc = 3 Then
            LabelTimer.Text = "↓"
        ElseIf LabelTimerc = 4 Then
            LabelTimer.Text = "∟"
        ElseIf LabelTimerc = 5 Then
            LabelTimer.Text = "→"
            LabelTimerc = 0
        End If

        refreshResultImage()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelTimer.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub PictureBoxResult_Click(sender As Object, e As EventArgs) Handles PictureBoxResult.Click
        'If PictureBoxResult.SizeMode = PictureBoxSizeMode.AutoSize Then
        '    PictureBoxResult.SizeMode = PictureBoxSizeMode.CenterImage
        'ElseIf PictureBoxResult.SizeMode = PictureBoxSizeMode.CenterImage Then
        '    PictureBoxResult.SizeMode = PictureBoxSizeMode.Normal
        'ElseIf PictureBoxResult.SizeMode = PictureBoxSizeMode.Normal Then
        '    PictureBoxResult.SizeMode = PictureBoxSizeMode.StretchImage
        'ElseIf PictureBoxResult.SizeMode = PictureBoxSizeMode.StretchImage Then
        '    PictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom
        'Else
        '    PictureBoxResult.SizeMode = PictureBoxSizeMode.AutoSize
        'End If


    End Sub

    Private Sub Form2_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        PictureBoxResult.Width = Me.Width - PictureBoxResult.Left - 15
        PictureBoxResult.Height = Me.Height - PictureBoxResult.Top - 15
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        PictureBoxResult.Width = Me.Width - PictureBoxResult.Left - 15
        PictureBoxResult.Height = Me.Height - PictureBoxResult.Top - 15
    End Sub
End Class

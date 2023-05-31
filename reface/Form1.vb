Imports System.Drawing.Text
Imports System.Text
Imports System.Threading

Public Class F
    Public terminateCheckBoxBehavior As Boolean
    Public terminateRefresh As Boolean
    Private wasrotated As Boolean

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        If OpenFileDialog1.Title = "Select the FACE image.." Then
            TextBoxName.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName).Replace("face_prepared_", "")
            TextBoxName.Text = Microsoft.VisualBasic.Left(TextBoxName.Text, Len(TextBoxName.Text) - 4)
            TextFace.Text = OpenFileDialog1.FileName
            CheckBoxFacesFromFolder.Checked = False
            refreshFaceImage()
        ElseIf OpenFileDialog1.Title = "Select the SOURCE image.." Then
            TextBoxSourceName.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            TextBoxSourceName.Text = Microsoft.VisualBasic.Left(TextBoxSourceName.Text, Len(TextBoxSourceName.Text) - 4)
            TextBoxSourceImage.Text = OpenFileDialog1.FileName
            CheckBoxSourceImagesFromFolder.Checked = False
            refreshSourceImage()
        ElseIf OpenFileDialog1.Title = "Select the SOURCE Video.." Then
            TextBoxNameSourceVideo.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            TextBoxNameSourceVideo.Text = Microsoft.VisualBasic.Left(TextBoxNameSourceVideo.Text, Len(TextBoxNameSourceVideo.Text) - 4)
            TextBoxSourceVideo.Text = OpenFileDialog1.FileName
            CheckBoxSourceVideoFromFolder.Checked = False
            refreshSourceVideo()
        End If

    End Sub

    Private Sub refreshSourceVideo()

        If Not terminateRefresh Then
            If CheckBoxSourceVideoFromFolder.Checked Then
                PictureBoxSourceVideoLabel.Text = ""
                LabelSourceVideoName.Text = ""
            Else
                Try
                    Dim tryFile As New IO.FileInfo(TextBoxSourceVideo.Text)
                    If tryFile.Exists Then
                        Dim tryFileName = tryFile.Name
                        LabelSourceVideoName.Text = Microsoft.VisualBasic.Left(tryFileName, 12)
                        PictureBoxSourceVideoLabel.Text = tryFile.Length.ToString

                        PictureBoxVideo.Image = Bitmap.FromFile(TextBoxSourceVideo.Text)
                    Else
                        LabelSourceVideoName.Text = "no file"
                        PictureBoxSourceVideoLabel.Text = ""
                    End If
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub refreshSourceImage()

        wasrotated = False
        PictureBoxSourceImage.Visible = Not CheckBoxSourceHidden.Checked

        If Not terminateRefresh Then
            If CheckBoxSourceImagesFromFolder.Checked Then
                PictureBoxSourceImage.Image = Nothing
                PictureBoxSourceLabel.Text = ""
                LabelSourceName.Text = ""
            Else
                Try
                    Dim tryFile As New IO.FileInfo(TextBoxSourceImage.Text)
                    If tryFile.Exists Then
                        Dim tryFileName = tryFile.Name
                        '  Dim ImageSource = Bitmap.FromFile(TextBoxSourceImage.Text)
                        '     PictureBoxSourceImage.Image = ImageSource
                        LabelSourceName.Text = Microsoft.VisualBasic.Left(tryFileName, 12)
                        '   PictureBoxSourceLabel.Text = ImageSource.Size.ToString + " - " + tryFile.Length.ToString

                        Dim strImageFileName As String
                        strImageFileName = TextBoxSourceImage.Text
                        Dim fs As System.IO.FileStream

                        fs = New System.IO.FileStream(strImageFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                        PictureBoxSourceImage.Image = System.Drawing.Image.FromStream(fs)
                        PictureBoxSourceLabel.Text = PictureBoxSourceImage.Image.Size.ToString + " - " + tryFile.Length.ToString
                        fs.Close()

                    Else
                        LabelSourceName.Text = "no file"
                        PictureBoxSourceLabel.Text = ""
                    End If
                Catch ex As Exception
                    LabelSourceName.Text = "cannot be open"
                    PictureBoxSourceLabel.Text = ""
                End Try
            End If
        End If

    End Sub

    Private Sub refreshResultImage()

        Form2.TextBoxResult.Text = TextBoxResult.Text

        If Not terminateRefresh Then
            Try
                Dim tryFile As New IO.FileInfo(TextBoxResult.Text)
                If tryFile.Exists Then
                    Dim tryFileName = tryFile.Name
                    '  Dim ImageSource = Bitmap.FromFile(TextBoxResult.Text)
                    '   PictureBoxResult.Image = ImageSource

                    '   Form2.PictureBoxResult.Image = ImageSource

                    Dim strImageFileName As String
                    strImageFileName = TextBoxResult.Text
                    Dim fs As System.IO.FileStream

                    fs = New System.IO.FileStream(strImageFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                    PictureBoxResult.Image = System.Drawing.Image.FromStream(fs)
                    Form2.PictureBoxResult.Image = PictureBoxResult.Image

                    PictureBoxSourceLabel.Text = PictureBoxResult.Image.Size.ToString + " - " + tryFile.Length.ToString
                    fs.Close()
                    '          PictureBoxResult.Image.Dispose()
                    ' LabelSourceName.Text = Microsoft.VisualBasic.Left(tryFileName, 12)
                    ' PictureBoxSourceLabel.Text = ImageSource.Size.ToString + " - " + tryFile.Length.ToString
                Else
                    '                   LabelSourceName.Text = "no file"
                    '                  PictureBoxSourceLabel.Text = ""
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub refreshFaceImage(Optional ByVal face_file_address As String = "")

        PictureBoxFace.Visible = Not CheckBoxFaceHidden.Checked

        If Not terminateRefresh Then
            If CheckBoxFacesFromFolder.Checked Then
                PictureBoxFace.Image = Nothing
                PictureBoxFaceLabel.Text = ""
                LabelPrefix.Text = ""
            Else
                If face_file_address = "" Then
                    face_file_address = TextFace.Text
                End If
                Try
                    Dim tryFile As New IO.FileInfo(face_file_address)
                    If tryFile.Exists Then

                        Dim strImageFileName As String
                        strImageFileName = face_file_address
                        Dim fs As System.IO.FileStream

                        fs = New System.IO.FileStream(strImageFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                        PictureBoxFace.Image = System.Drawing.Image.FromStream(fs)
                        PictureBoxFaceLabel.Text = PictureBoxFace.Image.Size.ToString + " - " + tryFile.Length.ToString
                        fs.Close()

                        Dim tryFileName = tryFile.Name
                        'Dim ImageFace = Bitmap.FromFile(face_file_address)
                        'PictureBoxFace.Image = ImageFace
                        LabelPrefix.Text = Microsoft.VisualBasic.Left(tryFileName, 12)

                    Else
                        LabelPrefix.Text = "no file"
                        PictureBoxFaceLabel.Text = ""
                    End If
                Catch ex As Exception
                    LabelPrefix.Text = "cannot be open"
                    PictureBoxFaceLabel.Text = ""
                End Try
            End If
        End If

    End Sub

    Private Sub Face_folder_click(sender As Object, e As EventArgs) Handles ButFaceFolder.Click

        terminateCheckBoxBehavior = True
        SelectFaceFolder()

    End Sub

    Private Sub SelectFaceFolder()

        Dim tryFile As New IO.FileInfo(TextFace.Text)

        FolderBrowserDialog1.SelectedPath = tryFile.DirectoryName
        FolderBrowserDialog1.Description = "Select the FACE Folder.."
        FolderBrowserDialog1.ShowNewFolderButton = True

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextFace.Text = FolderBrowserDialog1.SelectedPath
            CheckBoxFacesFromFolder.Checked = True
            refreshFaceImage()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelSourceVideo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSourceImageFile.Click

        terminateCheckBoxBehavior = True
        SelectSourceFile()

    End Sub

    Private Sub SelectSourceFile()

        Dim tryFileDirectoryName As String = ""

        If TextFace.Text <> "" Then
            Try
                Dim tryFile As New IO.FileInfo(TextBoxSourceImage.Text)
                tryFileDirectoryName = tryFile.DirectoryName
            Catch ex As Exception

            End Try
        End If

        With OpenFileDialog1
            .FileName = TextFace.Text
            .Title = "Select the SOURCE image.."
            .Filter = ("Image File (*.jpg;*.jpeg;*.bmp;*.png;*.jfif;*.webp)|*.jpg;*.jpeg;*.bmp;*.png;*.jfif;*.webp")
            .RestoreDirectory = True
            .Multiselect = False
            .CheckFileExists = True
            .InitialDirectory = tryFileDirectoryName
            .ShowDialog()
        End With

    End Sub

    Private Sub F_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        terminateRefresh = True
        Load_Parameters()
        terminateRefresh = False
        refreshFaceImage()
        refreshSourceImage()
        refreshSourceVideo()

    End Sub

    Private Sub Load_Parameters()

        TextFace.Text = GetSetting("SZA reFACE", "SET", "TextFace")
        terminateCheckBoxBehavior = True
        CheckBoxFacesFromFolder.Checked = If(GetSetting("SZA reFACE", "SET", "CheckBoxFacesFromFolder") = "Y", True, False)
        TextSimSwapFolder.Text = GetSetting("SZA reFACE", "SET", "TextSimSwapFolder")
        TextAnaconda.Text = GetSetting("SZA reFACE", "SET", "TextAnaconda")
        TextBoxOutputFolder.Text = GetSetting("SZA reFACE", "SET", "TextBoxOutputFolder")
        TextBoxSourceImage.Text = GetSetting("SZA reFACE", "SET", "TextBoxSourceImage")
        terminateCheckBoxBehavior = True
        CheckBoxSourceImagesFromFolder.Checked = If(GetSetting("SZA reFACE", "SET", "CheckBoxSourceImagesFromFolder") = "Y", True, False)
        TextBoxSourceVideo.Text = GetSetting("SZA reFACE", "SET", "TextBoxSourceVideo")
        terminateCheckBoxBehavior = True
        CheckBoxSourceVideoFromFolder.Checked = If(GetSetting("SZA reFACE", "SET", "CheckBoxSourceVideoFromFolder") = "Y", True, False)

        Left = Val(GetSetting("SZA reFACE", "SET", "Left"))
        If Left < 0 Then
            Left = 10
            Width = 800
        End If
        Top = Val(GetSetting("SZA reFACE", "SET", "Top"))
        If Top < 0 Then
            Top = 10
            Height = 640
        End If
        CheckBoxFaceHidden.Checked = If(GetSetting("SZA reFACE", "SET", "CheckBoxFaceHidden") = "Y", True, False)
        CheckBoxSourceHidden.Checked = If(GetSetting("SZA reFACE", "SET", "CheckBoxSourceHidden") = "Y", True, False)
        CheckBoxRunMinimized.Checked = If(GetSetting("SZA reFACE", "SET", "CheckBoxRunMinimized") = "Y", True, False)
        CheckBox512.Checked = If(GetSetting("SZA reFACE", "SET", "CheckBox512") = "Y", True, False)
        CheckBoxNoWindow.Checked = GetSetting("SZA reFACE", "SET", "CheckBoxNoWindow") = "Y"
        CheckBoxNoWindowForVideo.Checked = GetSetting("SZA reFACE", "SET", "CheckBoxNoWindowForvideo") = "Y"
        CheckBoxForAllFaces.Checked = GetSetting("SZA reFACE", "SET", "CheckBoxForAllFaces") = "Y"

        TextBoxName.Text = GetSetting("SZA reFACE", "SET", "TextBoxName")
        TextBoxSourceName.Text = GetSetting("SZA reFACE", "SET", "TextBoxSourceName")

        terminateCheckBoxBehavior = False

        Left = 10
        Width = 800
        Top = 10
        Height = 640

    End Sub

    Private Sub Save_Parameters()

        SaveSetting("SZA reFACE", "SET", "TextFace", TextFace.Text)
        SaveSetting("SZA reFACE", "SET", "CheckBoxFacesFromFolder", If(CheckBoxFacesFromFolder.Checked = True, "Y", "N"))
        SaveSetting("SZA reFACE", "SET", "TextSimSwapFolder", TextSimSwapFolder.Text)
        SaveSetting("SZA reFACE", "SET", "TextAnaconda", TextAnaconda.Text)
        SaveSetting("SZA reFACE", "SET", "TextBoxOutputFolder", TextBoxOutputFolder.Text)
        SaveSetting("SZA reFACE", "SET", "TextBoxSourceImage", TextBoxSourceImage.Text)
        SaveSetting("SZA reFACE", "SET", "CheckBoxSourceImagesFromFolder", If(CheckBoxSourceImagesFromFolder.Checked = True, "Y", "N"))
        SaveSetting("SZA reFACE", "SET", "TextBoxSourceVideo", TextBoxSourceVideo.Text)
        SaveSetting("SZA reFACE", "SET", "CheckBoxSourceVideoFromFolder", If(CheckBoxSourceVideoFromFolder.Checked = True, "Y", "N"))

        If Left > 0 Then
            SaveSetting("SZA reFACE", "SET", "Left", Left.ToString())
        End If
        If Top > 0 Then
            SaveSetting("SZA reFACE", "SET", "Top", Top.ToString())
        End If

        SaveSetting("SZA reFACE", "SET", "CheckBoxFaceHidden", If(CheckBoxFaceHidden.Checked = True, "Y", "N"))
        SaveSetting("SZA reFACE", "SET", "CheckBoxSourceHidden", If(CheckBoxSourceHidden.Checked = True, "Y", "N"))
        SaveSetting("SZA reFACE", "SET", "CheckBoxRunMinimized", If(CheckBoxRunMinimized.Checked = True, "Y", "N"))
        SaveSetting("SZA reFACE", "SET", "CheckBox512", If(CheckBox512.Checked = True, "Y", "N"))
        SaveSetting("SZA reFACE", "SET", "CheckBoxNoWindow", If(CheckBoxNoWindow.Checked = True, "Y", "N"))
        SaveSetting("SZA reFACE", "SET", "CheckBoxNoWindowForVideo", If(CheckBoxNoWindowForVideo.Checked = True, "Y", "N"))

        SaveSetting("SZA reFACE", "SET", "CheckBoxForAllFaces", If(CheckBoxForAllFaces.Checked = True, "Y", "N"))

        SaveSetting("SZA reFACE", "SET", "TextBoxName", TextBoxName.Text)
        SaveSetting("SZA reFACE", "SET", "TextBoxSourceName", TextBoxSourceName.Text)

    End Sub

    Private Sub F_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Save_Parameters()
    End Sub

    Private Sub CheckBoxSourceImagesFromFolder_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSourceImagesFromFolder.CheckedChanged

        If terminateCheckBoxBehavior Then
            terminateCheckBoxBehavior = False
        Else
            If CheckBoxSourceImagesFromFolder.Checked Then
                SelectSourceFolder()
            Else
                SelectSourceFile()
            End If
        End If

    End Sub

    Private Sub ButtonFaceFile_Click(sender As Object, e As EventArgs) Handles ButtonFaceFile.Click

        terminateCheckBoxBehavior = True
        SelectFaceFile()

    End Sub

    Private Sub SelectFaceFile()

        Dim tryFileDirectoryName As String = ""

        If TextFace.Text <> "" Then
            Try
                Dim tryFile As New IO.FileInfo(TextFace.Text)
                tryFileDirectoryName = tryFile.DirectoryName

            Catch ex As Exception

            End Try
        End If

        With OpenFileDialog1
            .FileName = TextFace.Text
            .Title = "Select the FACE image.."
            .Filter = ("Image File (*.jpg;*.jpeg;*.bmp;*.png;*.jfif;*.webp)|*.jpg;*.jpeg;*.bmp;*.png;*.jfif;*.webp")
            .RestoreDirectory = True
            .Multiselect = False
            .CheckFileExists = True
            .InitialDirectory = tryFileDirectoryName
            .ShowDialog()
        End With

    End Sub

    Private Sub CheckBoxFacesFromFolder_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFacesFromFolder.CheckedChanged

        If terminateCheckBoxBehavior Then
            terminateCheckBoxBehavior = False
        Else
            If CheckBoxFacesFromFolder.Checked Then
                SelectFaceFolder()
            Else
                SelectFaceFile()
            End If
        End If

    End Sub

    Private Sub ButtonAnaconda_Click(sender As Object, e As EventArgs) Handles ButtonAnaconda.Click

        FolderBrowserDialog1.SelectedPath = TextAnaconda.Text
        FolderBrowserDialog1.Description = "Select the ANACONDA Folder.."
        FolderBrowserDialog1.ShowNewFolderButton = False

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextAnaconda.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub ButtonSimSwapFolder_Click(sender As Object, e As EventArgs) Handles ButtonSimSwapFolder.Click

        FolderBrowserDialog1.SelectedPath = TextSimSwapFolder.Text
        FolderBrowserDialog1.Description = "Select the SimSwap Folder.."
        FolderBrowserDialog1.ShowNewFolderButton = False

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextSimSwapFolder.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub ButtonOutputFolder_Click(sender As Object, e As EventArgs) Handles ButtonOutputFolder.Click

        FolderBrowserDialog1.SelectedPath = TextBoxOutputFolder.Text
        FolderBrowserDialog1.Description = "Select the OUTPUT Folder.."
        FolderBrowserDialog1.ShowNewFolderButton = False

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBoxOutputFolder.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub PageTask_Click(sender As Object, e As EventArgs) Handles PageTask.Click

    End Sub

    Private Sub ButtonSourceImageFolder_Click(sender As Object, e As EventArgs) Handles ButtonSourceImageFolder.Click

        terminateCheckBoxBehavior = True
        SelectSourceFolder()

    End Sub

    Private Sub SelectSourceFolder()

        Dim tryFile As New IO.FileInfo(TextBoxSourceImage.Text)

        FolderBrowserDialog1.SelectedPath = tryFile.DirectoryName
        FolderBrowserDialog1.Description = "Select the SOURCE Images Folder.."
        FolderBrowserDialog1.ShowNewFolderButton = False

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBoxSourceImage.Text = FolderBrowserDialog1.SelectedPath
            CheckBoxSourceImagesFromFolder.Checked = True
            refreshSourceImage()
        End If

    End Sub

    Private Sub TextFace_TextChanged(sender As Object, e As EventArgs) Handles TextFace.TextChanged
        refreshFaceImage()
    End Sub

    Private Sub TextBoxSourceVideo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSourceVideo.TextChanged
        refreshSourceVideo()
    End Sub

    Private Sub TextBoxSourceImage_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSourceImage.TextChanged
        refreshSourceImage()
    End Sub

    Private Sub ButtonSourceVideoFile_Click(sender As Object, e As EventArgs) Handles ButtonSourceVideoFile.Click

        terminateCheckBoxBehavior = True
        SelectSourceVideoFile()

    End Sub

    Private Sub SelectSourceVideoFile()

        Dim tryFileDirectoryName As String = ""

        If TextBoxSourceVideo.Text <> "" Then
            Try
                Dim tryFile As New IO.FileInfo(TextBoxSourceVideo.Text)
                tryFileDirectoryName = tryFile.DirectoryName

            Catch ex As Exception

            End Try
        End If

        With OpenFileDialog1
            .FileName = TextBoxSourceVideo.Text
            .InitialDirectory = tryFileDirectoryName
            .Title = "Select the SOURCE Video.."
            .Filter = ("Video File (*.mpg;*.avi;*.mp4;*.webm;*.mov)|*.mpg;*.avi;*.mp4;*.webm;*.mov")
            .RestoreDirectory = True
            .Multiselect = False
            .CheckFileExists = True

            .ShowDialog()
        End With

    End Sub

    Private Sub ButtonSourceVideoFolder_Click(sender As Object, e As EventArgs) Handles ButtonSourceVideoFolder.Click

        terminateCheckBoxBehavior = True
        SelectSouceVideoFolder()

    End Sub

    Private Sub SelectSouceVideoFolder()

        Dim tryFile As New IO.FileInfo(TextBoxSourceVideo.Text)

        FolderBrowserDialog1.SelectedPath = tryFile.DirectoryName
        FolderBrowserDialog1.Description = "Select the SOURCE Video Folder.."
        FolderBrowserDialog1.ShowNewFolderButton = True

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBoxSourceVideo.Text = FolderBrowserDialog1.SelectedPath
            CheckBoxSourceVideoFromFolder.Checked = True
            refreshSourceVideo()
        End If

    End Sub

    Private Sub CheckBoxSourceVideoFromFolder_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSourceVideoFromFolder.CheckedChanged

        If terminateCheckBoxBehavior Then
            terminateCheckBoxBehavior = False
        Else
            If CheckBoxSourceVideoFromFolder.Checked Then
                SelectSouceVideoFolder()
            Else
                SelectSourceVideoFile()
            End If
        End If

    End Sub

    Private Sub ButtonSourceVideoPlay_Click(sender As Object, e As EventArgs) Handles ButtonSourceVideoPlay.Click

        Try
            Dim Forun = "start " + TextBoxSourceVideo.Text
            'Dim textvalue As String
            'textvalue = "111.111.111.111"
            'Dim vmdtxt As String
            'vmdtxt = "netsh advfirewall firewall add rule name=""IP Block Test2"" dir=in interface=any action=block remoteip=" + textvalue + ""
            RunCommandCom(Forun, "", False, False, True)

        Catch ex As Exception
            MsgBox("Unable to start: " + ex.ToString)
        End Try

    End Sub

    Private Sub RunCommandCom(command As String, arguments As String, permanent As Boolean, waitForExit As Boolean, show_window As Boolean)

        'Dim p As Process = New Process()
        'Dim pi As ProcessStartInfo = New ProcessStartInfo()
        'pi.Verb = "runas" ' runas = Run As Administrator
        'pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        'pi.FileName = "cmd.exe"
        'If CheckBoxRunMinimized.Checked = True Then
        '    pi.WindowStyle = ProcessWindowStyle.Minimized
        '    'or ProcessWindowStyle.Normal
        'End If

        'p.StartInfo = pi
        'p.Start()
        'If waitForExit Then
        '    p.WaitForExit()
        'End If
        'p.Close()

        If permanent Then
            ' command = "cmd " + command
        End If

        Dim process As New Process
        process.StartInfo.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.Verb = "runas"
        If Not show_window Then
            process.StartInfo.CreateNoWindow = True
        End If
        If CheckBoxRunMinimized.Checked = True Then
            process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
        End If
        process.Start()
        If CheckBoxRunMinimized.Checked = True Then
            process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
        End If

        If waitForExit Then
            Do While Not process.HasExited
                Thread.Sleep(200)
            Loop
        End If

        process.Close()
        process.Dispose()
    End Sub

    Private Sub ButtonTempFolder_Click(sender As Object, e As EventArgs) Handles ButtonTempFolder.Click
        RunCommandCom("start explorer " + TextSimSwapFolder.Text + "\temp_results", "", False, False, True)
    End Sub

    Private Sub ButtonOpenOutputFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenOutputFolder.Click
        RunCommandCom("start explorer " + TextBoxOutputFolder.Text, "", False, False, True)
    End Sub

    Private Sub PictureBoxFace_Click(sender As Object, e As EventArgs) Handles PictureBoxFace.Click

        Dim command_file_address, face_file_address As String
        command_file_address = TextSimSwapFolder.Text + "\allocate_face.bat"
        face_file_address = TextSimSwapFolder.Text + "\face_prepared_" + If(TextBoxName.Text = "", "last_face", TextBoxName.Text) + ".png"

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(command_file_address, False)
        file.WriteLine("rem " + command_file_address)
        file.WriteLine("call " + Chr(34) + TextAnaconda.Text + "\Scripts\activate.bat" + Chr(34) + " " + Chr(34) + TextAnaconda.Text + Chr(34))
        file.WriteLine("C: ")
        file.WriteLine("cd " + Chr(34) + TextSimSwapFolder.Text + Chr(34))
        file.WriteLine("conda activate simswap & python allocate_face.py --isTrain false --no_simswaplogo --use_mask --name people --Arc_path arcface_model/arcface_checkpoint.tar --pic_a_path " +
            Chr(34) + TextFace.Text + Chr(34) + " --pic_b_path " +
            Chr(34) + face_file_address + Chr(34) + " & del " + Chr(34) + command_file_address + Chr(34))
        file.Close()

        Try
            RunCommandCom(command_file_address, "", False, True, Not CheckBoxNoWindow.Checked)
            'TextFace.Text = face_file_address
            'CheckBoxFacesFromFolder.Checked = False
            refreshFaceImage(face_file_address)
        Catch ex As Exception
            MsgBox("Unable to start: " + ex.ToString)
        End Try

    End Sub

    Private Sub CheckBoxFaceHidden_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFaceHidden.CheckedChanged
        refreshFaceImage()
    End Sub

    Private Sub CheckBoxHideSource_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSourceHidden.CheckedChanged
        refreshSourceImage()
    End Sub

    Private Sub ButtonImageStart_Click(sender As Object, e As EventArgs) Handles ButtonImageStart.Click
        ExecuteImage(,,,, CheckBoxSourceImagesFromFolder.Checked)
    End Sub

    Function RandomString(r As Random)

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next

        Return sb.ToString()

    End Function

    Private Sub ExecuteImage(Optional ResultName As String = "",
                             Optional face_file As String = "",
                             Optional source_file As String = "",
                             Optional one_by_one As Boolean = False,
                             Optional ImagesFromFolder As Boolean = False)

        If wasrotated = True Then
            TextBoxSourceImage.Text = TextBoxSourceImage.Text.Replace(".", "_r.")
            PictureBoxSourceImage.Image.Save(TextBoxSourceImage.Text, System.Drawing.Imaging.ImageFormat.Png)
            wasrotated = False
        End If

        Dim command_file_address As String
        Dim r As New Random

        command_file_address = TextSimSwapFolder.Text + "\swap_face_" + RandomString(r) + ".bat"

        If CheckBoxFacesFromFolder.Checked Then

        Else
            If ResultName = "" Then
                ResultName = TextBoxName.Text + "_" + TextBoxSourceName.Text
            End If

            If face_file = "" Then
                face_file = TextFace.Text
            End If

            If source_file = "" Then
                source_file = TextBoxSourceImage.Text
            End If

            If ImagesFromFolder Then
                Generate_Batch_for_source_folder(command_file_address)
            Else
                Dim list_of_tasks(1, 3) As String

                list_of_tasks(0, 0) = ResultName
                list_of_tasks(0, 1) = face_file
                list_of_tasks(0, 2) = source_file

                Generate_Batch(command_file_address, list_of_tasks)
            End If

            Form2.Timer1.Enabled = True
        End If

        RunCommandCom(command_file_address, "", False, one_by_one, Not CheckBoxNoWindow.Checked)

    End Sub

    Private Sub Generate_Batch_for_source_folder(batch_name As String)

        Dim ResultName,
            face_file,
            source_file,
            result_file_name,
                result_file_address,
        clcl As String

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(batch_name, False)

        TextBoxLastCommandLine.Text = ""
        file.WriteLine("rem " + batch_name)
        clcl = "call " + Chr(34) + TextAnaconda.Text + "\Scripts\activate.bat" + Chr(34) + " " + Chr(34) + TextAnaconda.Text + Chr(34)
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)
        clcl = "C: "
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)
        clcl = "cd " + Chr(34) + TextSimSwapFolder.Text + Chr(34)
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)

        Dim all_tasks As String
        all_tasks = "conda activate simswap & "

        'For task_number As Integer = list_of_tasks.GetLowerBound(0) To list_of_tasks.GetUpperBound(0) - 1

        Dim thisisit As Integer = 0

        Dim wasTextBoxSourceImage As String = TextBoxSourceImage.Text
        Dim tryFile As New IO.FileInfo(wasTextBoxSourceImage)
        If tryFile.Exists Then
            TextBoxSourceImage.Text = tryFile.DirectoryName
        End If

        Dim tryFolder As New IO.DirectoryInfo(TextBoxSourceImage.Text)
        If tryFolder.Exists Then

            ResultName = TextBoxName.Text
            face_file = TextFace.Text
            source_file = TextBoxSourceImage.Text

            result_file_name = ResultName + "_"
            result_file_address = TextBoxOutputFolder.Text + "\" + result_file_name

            all_tasks = all_tasks +
            "python swap_face_folder_source" + If(InStr(face_file, "face_prepared"), "_prepared", "") + If(CheckBoxForAllFaces.Checked, "_multi", "") +
                       ".py --isTrain false --no_simswaplogo --use_mask --name people --Arc_path arcface_model/arcface_checkpoint.tar --pic_a_path " +
                       Chr(34) + TextFace.Text + Chr(34) +
                       If(CheckBox512.Checked = True, " --crop_size 512 ", "") + " --pic_b_path " + Chr(34) +
            source_file + Chr(34) + " --output_path " + Chr(34) +
            TextBoxOutputFolder.Text + Chr(34) + " --cluster_path " +
            Chr(34) + result_file_name + Chr(34) + " & "

            LabelLast.Text = source_file

            TextBoxResult.Text = result_file_address
            Form2.filetoload = TextBoxResult.Text
            LabelLastFileName.Text = Microsoft.VisualBasic.Left(result_file_name, 200)
        End If

        all_tasks = all_tasks + "del " + Chr(34) + batch_name + Chr(34)

        file.WriteLine(all_tasks)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + all_tasks
        file.Close()

    End Sub

    Private Sub Generate_Batch(batch_name As String, list_of_tasks(,) As String)

        Dim ResultName,
            face_file,
            source_file,
            result_file_name,
                result_file_address,
        clcl As String

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(batch_name, False)

        TextBoxLastCommandLine.Text = ""
        file.WriteLine(" rem " + batch_name)
        clcl = "call " + Chr(34) + TextAnaconda.Text + "\Scripts\activate.bat" + Chr(34) + " " + Chr(34) + TextAnaconda.Text + Chr(34)
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13) + Chr(10)
        clcl = "C: "
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13) + Chr(10)
        clcl = "cd " + Chr(34) + TextSimSwapFolder.Text + Chr(34)
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13) + Chr(10)

        Dim all_tasks As String
        all_tasks = "conda activate simswap & "

        For task_number As Integer = list_of_tasks.GetLowerBound(0) To list_of_tasks.GetUpperBound(0) - 1

            ResultName = list_of_tasks(task_number, 0)
            face_file = list_of_tasks(task_number, 1)
            source_file = list_of_tasks(task_number, 2)

            result_file_name = ResultName + ".png"
            result_file_address = TextBoxOutputFolder.Text + "\" + result_file_name

            all_tasks = all_tasks +
            "python swap_face" + If(InStr(face_file, "face_prepared"), "_prepared", "") + If(CheckBoxForAllFaces.Checked, "_multi", "") +
                       ".py --isTrain false --no_simswaplogo --use_mask --name people --Arc_path arcface_model/arcface_checkpoint.tar --pic_a_path " +
                       Chr(34) + TextFace.Text + Chr(34) +
                       If(CheckBox512.Checked = True, " --crop_size 512 ", "") + " --pic_b_path " + Chr(34) +
            source_file + Chr(34) + " --output_path " + Chr(34) +
            TextBoxOutputFolder.Text + Chr(34) + " --cluster_path " +
            Chr(34) + result_file_name + Chr(34) + " & "

            LabelLast.Text = source_file

            TextBoxResult.Text = result_file_address
            Form2.filetoload = TextBoxResult.Text
            LabelLastFileName.Text = Microsoft.VisualBasic.Left(result_file_name, 200)
        Next

        all_tasks = all_tasks + "del " + Chr(34) + batch_name + Chr(34)

        file.WriteLine(all_tasks)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + all_tasks
        file.Close()

    End Sub

    Private Sub Generate_Batch_for_source_folder_video(batch_name As String)

        Dim ResultName,
            face_file,
            source_file,
            result_file_name,
                result_file_address,
        clcl As String

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(batch_name, False)

        TextBoxLastCommandLine.Text = ""
        file.WriteLine("rem " + batch_name)
        clcl = "call " + Chr(34) + TextAnaconda.Text + "\Scripts\activate.bat" + Chr(34) + " " + Chr(34) + TextAnaconda.Text + Chr(34)
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)
        clcl = "C: "
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)
        clcl = "cd " + Chr(34) + TextSimSwapFolder.Text + Chr(34)
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)

        Dim all_tasks As String
        all_tasks = "conda activate simswap & "

        'For task_number As Integer = list_of_tasks.GetLowerBound(0) To list_of_tasks.GetUpperBound(0) - 1

        Dim thisisit As Integer = 0

        Dim wasTextBoxSourceImage As String = TextBoxSourceImage.Text
        Dim tryFile As New IO.FileInfo(wasTextBoxSourceImage)
        If tryFile.Exists Then
            TextBoxSourceImage.Text = tryFile.DirectoryName
        End If

        Dim tryFolder As New IO.DirectoryInfo(TextBoxSourceImage.Text)
        If tryFolder.Exists Then

            ResultName = TextBoxName.Text
            face_file = TextFace.Text
            source_file = TextBoxSourceImage.Text

            result_file_name = ResultName + ".mp4"
            result_file_address = TextBoxOutputFolder.Text + "\" + result_file_name

            all_tasks = all_tasks +
            "python swap_face_folder_source_video" + If(InStr(face_file, "face_prepared"), "_prepared", "") + If(CheckBoxForAllFaces.Checked, "_multi", "") +
                       ".py --isTrain false --no_simswaplogo --use_mask --name people --Arc_path arcface_model/arcface_checkpoint.tar --pic_a_path " +
                       Chr(34) + TextFace.Text + Chr(34) +
                       If(CheckBox512.Checked = True, " --crop_size 512 ", "") + " --pic_b_path " + Chr(34) +
            source_file + Chr(34) + " --video_path " + Chr(34) +
            source_file + Chr(34) + " --output_path " + Chr(34) +
            TextBoxOutputFolder.Text + Chr(34) + " --cluster_path " +
            Chr(34) + result_file_name + Chr(34) + " & "

            LabelLast.Text = source_file

            TextBoxResult.Text = result_file_address
            Form2.filetoload = TextBoxResult.Text
            LabelLastFileName.Text = Microsoft.VisualBasic.Left(result_file_name, 50)
        End If

        all_tasks = all_tasks + "del " + Chr(34) + batch_name + Chr(34)

        file.WriteLine(all_tasks)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + all_tasks
        file.Close()

    End Sub

    Private Sub Generate_Batch_video(batch_name As String, list_of_tasks(,) As String)

        Dim ResultName,
            face_file,
            source_file,
            result_file_name,
                result_file_address,
        clcl As String

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(batch_name, False)

        TextBoxLastCommandLine.Text = ""
        file.WriteLine("rem " + batch_name)
        clcl = "call " + Chr(34) + TextAnaconda.Text + "\Scripts\activate.bat" + Chr(34) + " " + Chr(34) + TextAnaconda.Text + Chr(34)
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)
        clcl = "C: "
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)
        clcl = "cd " + Chr(34) + TextSimSwapFolder.Text + Chr(34)
        file.WriteLine(clcl)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + clcl + Chr(13)

        Dim all_tasks As String
        all_tasks = "conda activate simswap & "

        For task_number As Integer = list_of_tasks.GetLowerBound(0) To list_of_tasks.GetUpperBound(0) - 1

            ResultName = list_of_tasks(task_number, 0)
            face_file = list_of_tasks(task_number, 1)
            source_file = list_of_tasks(task_number, 2)

            result_file_name = ResultName + ".mp4"
            result_file_address = TextBoxOutputFolder.Text + "\" + result_file_name

            all_tasks = all_tasks +
            "python swap_face_video" + If(InStr(face_file, "face_prepared"), "_prepared", "") + If(CheckBoxForAllFaces.Checked, "_multi", "") +
                       ".py --isTrain false --no_simswaplogo --use_mask --name people --Arc_path arcface_model/arcface_checkpoint.tar --pic_a_path " +
                       Chr(34) + TextFace.Text + Chr(34) +
                       If(CheckBox512.Checked = True, " --crop_size 512 ", "") + " --pic_b_path " + Chr(34) +
            source_file + Chr(34) + " --video_path " + Chr(34) +
            source_file + Chr(34) + " --output_path " + Chr(34) +
            TextBoxOutputFolder.Text + Chr(34) + " --cluster_path " +
            Chr(34) + result_file_name + Chr(34) + " & "

            LabelLast.Text = source_file + " >"

            TextBoxResult.Text = result_file_address
            Form2.filetoload = TextBoxResult.Text
            LabelLastFileName.Text = Microsoft.VisualBasic.Left(result_file_name, 200)
        Next

        all_tasks = all_tasks + "del " + Chr(34) + batch_name + Chr(34)

        file.WriteLine(all_tasks)
        TextBoxLastCommandLine.Text = TextBoxLastCommandLine.Text + all_tasks
        file.Close()

    End Sub


    Private Sub ButtonResult_Click(sender As Object, e As EventArgs) Handles ButtonResult.Click
        refreshResultImage()
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub

    Private Sub ReFace_Click(sender As Object, e As EventArgs) Handles ReFace.Click
        refreshFaceImage()
    End Sub

    Private Sub ReSource_Click(sender As Object, e As EventArgs) Handles ReSource.Click
        refreshFaceImage()
    End Sub

    Private Sub TextBoxResult_TextChanged(sender As Object, e As EventArgs) Handles TextBoxResult.TextChanged

    End Sub

    Private Sub ButtonDelResult_Click(sender As Object, e As EventArgs) Handles ButtonDelResult.Click

        If TextBoxResult.Text <> "" Then
            Form2.Timer1.Enabled = False

            PictureBoxResult.Image.Dispose()
            My.Computer.FileSystem.DeleteFile(TextBoxResult.Text)
            TextBoxResult.Text = ""
            Form2.TextBoxResult.Text = TextBoxResult.Text
        End If

    End Sub

    Private Sub ButtonImageAddTask_Click(sender As Object, e As EventArgs) Handles ButtonImageAddTask.Click

        If CheckBoxSourceImagesFromFolder.Checked Then
            ListBox1.Items.Add("FOLDER->" + TextBoxName.Text + "_" + TextBoxSourceName.Text + "_↑_" + TextFace.Text + "_↑_" + TextBoxSourceImage.Text)
        Else
            ListBox1.Items.Add(TextBoxName.Text + "_" + TextBoxSourceName.Text + "_↑_" + TextFace.Text + "_↑_" + TextBoxSourceImage.Text)
        End If

    End Sub

    Private Sub ButtonOutputOpen_Click(sender As Object, e As EventArgs) Handles ButtonOutputOpen.Click
        RunCommandCom("start explorer ", TextBoxOutputFolder.Text, False, False, True)
    End Sub

    Private Sub ButtonTasksRemove_Click(sender As Object, e As EventArgs) Handles ButtonTasksRemove.Click
        Dim lst As New List(Of Object)
        For Each a As Object In ListBox1.SelectedItems
            lst.Add(a)
        Next
        For Each a As Object In lst
            ListBox1.Items.Remove(a)
        Next
    End Sub

    Private Sub ButtonTasksClear_Click(sender As Object, e As EventArgs) Handles ButtonTasksClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ButtonTasksRun_Click(sender As Object, e As EventArgs) Handles ButtonTasksRun.Click
        TasksRun(False)
    End Sub

    Private Sub TasksRun(one_by_one As Boolean)

        Dim ImagesFromFolder As Boolean
        Dim strArr() As String
        For Each task In ListBox1.Items
            strArr = task.ToString().Split("_↑_")
            If Microsoft.VisualBasic.Left(strArr(0), 8) = "FOLDER->" Then
                strArr(0) = Microsoft.VisualBasic.Right(strArr(0), strArr(0).Length - 8)
                ImagesFromFolder = True
            Else
                ImagesFromFolder = False
            End If
            ExecuteImage(strArr(0), strArr(1), strArr(2), one_by_one, ImagesFromFolder)

        Next

        ListBox1.Items.Clear()
    End Sub

    Private Sub ButtonOpenLastFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenLastFile.Click
        RunCommandCom("start explorer ", LabelLastFileName.Text, False, False, True)
    End Sub

    Private Sub ButtonTasksOneByOne_Click(sender As Object, e As EventArgs) Handles ButtonTasksOneByOne.Click
        TasksRun(True)
    End Sub

    Private Sub ButtonTasksOneBatch_Click(sender As Object, e As EventArgs) Handles ButtonTasksOneBatch.Click

        Dim command_file_address As String
        Dim r As New Random

        command_file_address = TextSimSwapFolder.Text + "\swap_face" + RandomString(r) + ".bat"

        Dim list_of_tasks(ListBox1.Items.Count, 3) As String

        Dim task_count As Integer = 0
        Dim strArr() As String
        For Each task In ListBox1.Items
            strArr = task.ToString().Split("_↑_")

            list_of_tasks(task_count, 0) = strArr(0)
            list_of_tasks(task_count, 1) = strArr(1)
            list_of_tasks(task_count, 2) = strArr(2)
            task_count = task_count + 1
        Next

        Generate_Batch(command_file_address, list_of_tasks)

        RunCommandCom(command_file_address, "", False, False, True)
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Left = 0
        Top = 0
        Width = 800
        Height = 600
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form2.Show()
        Form2.filetoload = TextBoxResult.Text
        Form2.Timer1.Enabled = True
    End Sub

    Private Sub TabsBlock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabsBlock.SelectedIndexChanged

    End Sub

    Private Sub F_ResizeEnd(sender As Object, e As EventArgs)
        fix_picture_loaction()
    End Sub

    Private Sub fix_picture_loaction()
        Dim curx, cury, curtx, curty As Integer

        '        curx = PictureBoxSourceImage.Location.X
        '       cury = PictureBoxSourceImage.Location.Y
        curtx = TabPageSourceImage.Size.Width
        curty = TabPageSourceImage.Size.Height

        If ((curtx - 1107) * (curty - 22)) < ((curtx - 7) * (curty - 230)) Then
            PictureBoxSourceImage.Location = New Point(7, 230)
            PictureBoxSourceImage.Width = Me.Width - 7
            PictureBoxSourceImage.Height = Me.Height - 230
        Else
            PictureBoxSourceImage.Location = New Point(1107, 22)
            PictureBoxSourceImage.Width = Me.Width - 1107
            PictureBoxSourceImage.Height = Me.Height - 22
        End If

    End Sub

    Private Sub F_MaximumSizeChanged(sender As Object, e As EventArgs)
        fix_picture_loaction()
    End Sub

    Private Sub PictureBoxSourceImage_Click(sender As Object, e As EventArgs) Handles PictureBoxSourceImage.Click

        'If PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.AutoSize Then
        '    PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.CenterImage
        'ElseIf PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.CenterImage Then
        '    PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.Normal
        'ElseIf PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.Normal Then
        '    PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.StretchImage
        'ElseIf PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.StretchImage Then
        '    PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.Zoom
        'Else
        '    PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.AutoSize
        'End If

        '   refreshSourceImage()
        '    fix_picture_loaction()

        'PictureBoxSourceImage.Refresh()

    End Sub

    Private Sub CheckBoxRunMinimized_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRunMinimized.CheckedChanged
        If CheckBoxRunMinimized.Checked Then
            CheckBoxNoWindow.Checked = False
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click

        If TextBoxSourceImage.Text <> "" Then
            Dim thisisit As Integer = 0

            Dim wasTextBoxSourceImage As String = TextBoxSourceImage.Text

            Dim tryFile As New IO.FileInfo(wasTextBoxSourceImage)
            '  Try
            Dim allowedExtensions As String() = {"*.jpg", "*.bmp", "*.png", "*.jfif", "*.webp"}

            For Each foundFile In My.Computer.FileSystem.GetFiles(tryFile.DirectoryName,
                    FileIO.SearchOption.SearchTopLevelOnly,
                    allowedExtensions)

                If thisisit = 1 Then
                    TextBoxSourceImage.Text = foundFile.ToString()
                    Exit For
                End If
                If foundFile.ToString() = TextBoxSourceImage.Text Then
                    thisisit = 1
                End If
            Next
            '  Catch ex As Exception

            '  End Try

            If TextBoxSourceImage.Text <> wasTextBoxSourceImage Then
                TextBoxSourceName.Text = System.IO.Path.GetFileName(TextBoxSourceImage.Text)
                TextBoxSourceName.Text = Microsoft.VisualBasic.Left(TextBoxSourceName.Text, Len(TextBoxSourceName.Text) - 4)
                CheckBoxSourceImagesFromFolder.Checked = False
                refreshSourceImage()

                ExecuteImage(,,,, CheckBoxSourceImagesFromFolder.Checked)
            End If
        End If

    End Sub

    Private Sub ButtonLoadNext_Click(sender As Object, e As EventArgs) Handles ButtonLoadNext.Click
        Next_file()
    End Sub

    Private Sub Next_file()
        If TextBoxSourceImage.Text <> "" Then
            Dim thisisit As Integer = 0

            Dim wasTextBoxSourceImage As String = TextBoxSourceImage.Text

            Dim tryFile As New IO.FileInfo(wasTextBoxSourceImage)
            '  Try
            Dim allowedExtensions As String() = {"*.jpg", "*.bmp", "*.png", "*.jfif", "*.webp"}

            For Each foundFile In My.Computer.FileSystem.GetFiles(tryFile.DirectoryName,
                    FileIO.SearchOption.SearchTopLevelOnly,
                    allowedExtensions)

                If thisisit = 1 Then
                    TextBoxSourceImage.Text = foundFile.ToString()
                    Exit For
                End If
                If foundFile.ToString() = TextBoxSourceImage.Text Then
                    thisisit = 1
                End If
            Next
            '  Catch ex As Exception

            '  End Try

            If TextBoxSourceImage.Text <> wasTextBoxSourceImage Then
                TextBoxSourceName.Text = System.IO.Path.GetFileName(TextBoxSourceImage.Text)
                TextBoxSourceName.Text = Microsoft.VisualBasic.Left(TextBoxSourceName.Text, Len(TextBoxSourceName.Text) - 4)
                CheckBoxSourceImagesFromFolder.Checked = False
                refreshSourceImage()

            End If
        End If
    End Sub

    Private Sub ButtonLoadPrev_Click(sender As Object, e As EventArgs) Handles ButtonLoadPrev.Click
        prev()
    End Sub

    Private Sub prev()
        If TextBoxSourceImage.Text <> "" Then
            Dim thisisit As Integer = 0

            Dim wasTextBoxSourceImage As String = TextBoxSourceImage.Text

            Dim tryFile As New IO.FileInfo(wasTextBoxSourceImage)
            '  Try
            Dim allowedExtensions As String() = {"*.jpg", "*.bmp", "*.png", "*.jfif", "*.webp"}
            Dim prevfile As String = wasTextBoxSourceImage

            For Each foundFile In My.Computer.FileSystem.GetFiles(tryFile.DirectoryName,
                    FileIO.SearchOption.SearchTopLevelOnly,
                    allowedExtensions)

                If foundFile.ToString() = TextBoxSourceImage.Text Then
                    TextBoxSourceImage.Text = prevfile
                    Exit For
                Else
                    prevfile = foundFile.ToString()
                End If
            Next

            If TextBoxSourceImage.Text <> wasTextBoxSourceImage Then
                Dim newt As String
                newt = System.IO.Path.GetFileName(TextBoxSourceImage.Text)
                If newt.Length > 4 Then
                    TextBoxSourceName.Text = newt
                    TextBoxSourceName.Text = Microsoft.VisualBasic.Left(TextBoxSourceName.Text, Len(TextBoxSourceName.Text) - 4)
                    CheckBoxSourceImagesFromFolder.Checked = False
                    refreshSourceImage()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRotate_Click(sender As Object, e As EventArgs) Handles ButtonRotate.Click
        If PictureBoxSourceImage.Image IsNot Nothing Then
            Dim bmp As Bitmap = New Bitmap(PictureBoxSourceImage.Image)
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
            PictureBoxSourceImage.Image = bmp
            wasrotated = True
        End If
    End Sub

    Private Sub PageSettings_Click(sender As Object, e As EventArgs) Handles PageSettings.Click

    End Sub

    Private Sub CheckBoxNoWindow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNoWindow.CheckedChanged
        If CheckBoxNoWindow.Checked Then
            CheckBoxRunMinimized.Checked = False
        End If
    End Sub

    Private Sub ButtonVideoStart_Click(sender As Object, e As EventArgs) Handles ButtonVideoStart.Click

        Dim command_file_address As String
        Dim r As New Random

        command_file_address = TextSimSwapFolder.Text + "\swap_face_" + RandomString(r) + ".bat"

        If CheckBoxSourceImagesFromFolder.Checked Then
            Generate_Batch_for_source_folder_video(command_file_address)
        Else
            Dim list_of_tasks(1, 3) As String

            list_of_tasks(0, 0) = TextBoxName.Text + "_" + TextBoxNameSourceVideo.Text
            list_of_tasks(0, 1) = TextFace.Text
            list_of_tasks(0, 2) = TextBoxSourceVideo.Text

            Generate_Batch_video(command_file_address, list_of_tasks)
        End If

        RunCommandCom(command_file_address, "", False, False, Not CheckBoxNoWindowForVideo.Checked)

    End Sub

    Private Sub TextBoxNameSourceVideo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNameSourceVideo.TextChanged

    End Sub

    Private Sub ButtonDeleteSourceImage_Click(sender As Object, e As EventArgs) Handles ButtonDeleteSourceImage.Click
        If TextBoxSourceImage.Text <> "" Then
            Try
                Dim oldfile = TextBoxSourceImage.Text
                '      PictureBoxResult.Image.Dispose()
                Next_file()
                My.Computer.FileSystem.DeleteFile(oldfile)
            Catch
            End Try
        End If
    End Sub

    Private Sub ButtonLoadNext_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ButtonLoadNext.KeyPress

    End Sub

    Private Sub ButtonTasksOneByOne_KeyDown(sender As Object, e As KeyEventArgs) Handles ButtonTasksOneByOne.KeyDown
        If e.KeyCode = Keys.Space Then
            Next_file()
        End If
    End Sub

    Private Sub ButtonRunThisCommand_Click(sender As Object, e As EventArgs) Handles ButtonRunThisCommand.Click

        Dim command_file_address As String
        Dim r As New Random

        command_file_address = TextSimSwapFolder.Text + "\swap_face_" + RandomString(r) + ".bat"

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(command_file_address, False)

        file.WriteLine("rem " + command_file_address)
        file.WriteLine("call " + Chr(34) + TextAnaconda.Text + "\Scripts\activate.bat" + Chr(34) + " " + Chr(34) + TextAnaconda.Text + Chr(34))
        file.WriteLine("C: ")
        file.WriteLine("cd " + Chr(34) + TextSimSwapFolder.Text + Chr(34))

        file.WriteLine(TextBoxLastCommandLine.Text)
        file.Close()

        RunCommandCom(command_file_address, "", True, False, True)

    End Sub

    Private Sub F_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            Next_file()
        ElseIf e.KeyCode = Keys.Enter Then
            ExecuteImage(,,,, CheckBoxSourceImagesFromFolder.Checked)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Form2.filetoload = TextBoxResult.Text
        Form2.Timer1.Enabled = True
    End Sub

    Private Sub PictureBox_MouseWheel(sender As System.Object,
                         e As MouseEventArgs) Handles MyBase.MouseWheel
        If e.Delta <> 0 Then
            If e.Delta <= 0 Then
                Next_file()
            Else
                prev()
            End If
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TabPageSourceVideo_Click(sender As Object, e As EventArgs) Handles TabPageSourceVideo.Click

    End Sub

    Private Sub TabPageSourceImage_Click(sender As Object, e As EventArgs) Handles TabPageSourceImage.Click

    End Sub
End Class

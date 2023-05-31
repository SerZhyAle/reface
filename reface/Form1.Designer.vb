<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(F))
        TabsBlock = New TabControl()
        PageTask = New TabPage()
        PictureBoxFace = New PictureBox()
        ReFace = New Button()
        CaptionName = New Label()
        TextBoxName = New TextBox()
        CheckBoxFaceHidden = New CheckBox()
        LabelPrefix = New Label()
        PictureBoxFaceLabel = New Label()
        ButFaceFolder = New Button()
        CheckBoxFacesFromFolder = New CheckBox()
        ButtonFaceFile = New Button()
        LabelFace = New Label()
        TextFace = New TextBox()
        TabControlSource = New TabControl()
        TabPageSourceImage = New TabPage()
        Button3 = New Button()
        ButtonDeleteSourceImage = New Button()
        ButtonRotate = New Button()
        ButtonLoadPrev = New Button()
        ButtonLoadNext = New Button()
        ButtonNext = New Button()
        ReSource = New Button()
        TextBoxSourceName = New TextBox()
        LabelNameSource = New Label()
        CheckBoxSourceHidden = New CheckBox()
        LabelSourceName = New Label()
        PictureBoxSourceLabel = New Label()
        ButtonImageAddTask = New Button()
        ButtonSourceImageFolder = New Button()
        ButtonImageStart = New Button()
        CheckBoxSourceImagesFromFolder = New CheckBox()
        ButtonSourceImageFile = New Button()
        LabelSource = New Label()
        TextBoxSourceImage = New TextBox()
        PictureBoxSourceImage = New PictureBox()
        TabPageSourceVideo = New TabPage()
        TextBoxNameSourceVideo = New TextBox()
        Label1 = New Label()
        PictureBoxVideo = New PictureBox()
        PictureBoxSourceVideoLabel = New Label()
        LabelSourceVideoName = New Label()
        ButtonSourceVideoPlay = New Button()
        ButtonSourceVideoFolder = New Button()
        CheckBoxSourceVideoFromFolder = New CheckBox()
        ButtonSourceVideoFile = New Button()
        ButtonVideoAddTask = New Button()
        ButtonVideoStart = New Button()
        LabelSourceVideo = New Label()
        TextBoxSourceVideo = New TextBox()
        PageTasks = New TabPage()
        ButtonTasksOneBatch = New Button()
        ButtonTasksOneByOne = New Button()
        ButtonTasksRun = New Button()
        ButtonTasksClear = New Button()
        ButtonTasksRemove = New Button()
        ListBox1 = New ListBox()
        PageSettings = New TabPage()
        CheckBoxNoWindowForVideo = New CheckBox()
        ButtonRunThisCommand = New Button()
        TextBoxLastCommandLine = New TextBox()
        CheckBoxNoWindow = New CheckBox()
        CheckBox512 = New CheckBox()
        CheckBoxRunMinimized = New CheckBox()
        ButtonOutputOpen = New Button()
        ButtonOutputFolder = New Button()
        LabelOutputFolder = New Label()
        TextBoxOutputFolder = New TextBox()
        ButtonSimSwapFolder = New Button()
        LabelSimSwap = New Label()
        TextSimSwapFolder = New TextBox()
        ButtonAnaconda = New Button()
        LabelAnaconda = New Label()
        TextAnaconda = New TextBox()
        TabResult = New TabPage()
        Button2 = New Button()
        ButtonDelResult = New Button()
        ButtonResult = New Button()
        PictureBoxResult = New PictureBox()
        TextBoxResult = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        ButtonTempFolder = New Button()
        ButtonOpenOutputFolder = New Button()
        LabelLast = New Label()
        LabelLastFileName = New Label()
        ButtonOpenLastFile = New Button()
        Button1 = New Button()
        CheckBoxForAllFaces = New CheckBox()
        TabsBlock.SuspendLayout()
        PageTask.SuspendLayout()
        CType(PictureBoxFace, ComponentModel.ISupportInitialize).BeginInit()
        TabControlSource.SuspendLayout()
        TabPageSourceImage.SuspendLayout()
        CType(PictureBoxSourceImage, ComponentModel.ISupportInitialize).BeginInit()
        TabPageSourceVideo.SuspendLayout()
        CType(PictureBoxVideo, ComponentModel.ISupportInitialize).BeginInit()
        PageTasks.SuspendLayout()
        PageSettings.SuspendLayout()
        TabResult.SuspendLayout()
        CType(PictureBoxResult, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabsBlock
        ' 
        TabsBlock.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabsBlock.Controls.Add(PageTask)
        TabsBlock.Controls.Add(PageTasks)
        TabsBlock.Controls.Add(PageSettings)
        TabsBlock.Controls.Add(TabResult)
        TabsBlock.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TabsBlock.Location = New Point(4, 5)
        TabsBlock.Margin = New Padding(4, 5, 4, 5)
        TabsBlock.Name = "TabsBlock"
        TabsBlock.SelectedIndex = 0
        TabsBlock.Size = New Size(780, 520)
        TabsBlock.TabIndex = 0
        ' 
        ' PageTask
        ' 
        PageTask.Controls.Add(PictureBoxFace)
        PageTask.Controls.Add(ReFace)
        PageTask.Controls.Add(CaptionName)
        PageTask.Controls.Add(TextBoxName)
        PageTask.Controls.Add(CheckBoxFaceHidden)
        PageTask.Controls.Add(LabelPrefix)
        PageTask.Controls.Add(PictureBoxFaceLabel)
        PageTask.Controls.Add(ButFaceFolder)
        PageTask.Controls.Add(CheckBoxFacesFromFolder)
        PageTask.Controls.Add(ButtonFaceFile)
        PageTask.Controls.Add(LabelFace)
        PageTask.Controls.Add(TextFace)
        PageTask.Controls.Add(TabControlSource)
        PageTask.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        PageTask.Location = New Point(4, 22)
        PageTask.Margin = New Padding(4, 5, 4, 5)
        PageTask.Name = "PageTask"
        PageTask.Padding = New Padding(4, 5, 4, 5)
        PageTask.Size = New Size(772, 494)
        PageTask.TabIndex = 0
        PageTask.Text = "SIMSWAP Task"
        PageTask.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxFace
        ' 
        PictureBoxFace.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBoxFace.BackColor = Color.WhiteSmoke
        PictureBoxFace.Location = New Point(624, 0)
        PictureBoxFace.Margin = New Padding(4, 5, 4, 5)
        PictureBoxFace.Name = "PictureBoxFace"
        PictureBoxFace.Size = New Size(144, 140)
        PictureBoxFace.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxFace.TabIndex = 0
        PictureBoxFace.TabStop = False
        ' 
        ' ReFace
        ' 
        ReFace.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ReFace.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ReFace.Location = New Point(588, 5)
        ReFace.Name = "ReFace"
        ReFace.Size = New Size(32, 30)
        ReFace.TabIndex = 17
        ReFace.Text = "re"
        ReFace.UseVisualStyleBackColor = True
        ' 
        ' CaptionName
        ' 
        CaptionName.AutoSize = True
        CaptionName.Location = New Point(8, 30)
        CaptionName.Name = "CaptionName"
        CaptionName.Size = New Size(36, 13)
        CaptionName.TabIndex = 16
        CaptionName.Text = "Name"
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxName.Location = New Point(48, 30)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(264, 22)
        TextBoxName.TabIndex = 15
        ' 
        ' CheckBoxFaceHidden
        ' 
        CheckBoxFaceHidden.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckBoxFaceHidden.AutoSize = True
        CheckBoxFaceHidden.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxFaceHidden.Location = New Point(572, 40)
        CheckBoxFaceHidden.Margin = New Padding(2)
        CheckBoxFaceHidden.Name = "CheckBoxFaceHidden"
        CheckBoxFaceHidden.Size = New Size(49, 17)
        CheckBoxFaceHidden.TabIndex = 14
        CheckBoxFaceHidden.Text = "hide"
        CheckBoxFaceHidden.UseVisualStyleBackColor = True
        ' 
        ' LabelPrefix
        ' 
        LabelPrefix.AutoSize = True
        LabelPrefix.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        LabelPrefix.ForeColor = Color.Maroon
        LabelPrefix.Location = New Point(4, 75)
        LabelPrefix.Margin = New Padding(4, 5, 4, 5)
        LabelPrefix.Name = "LabelPrefix"
        LabelPrefix.Size = New Size(40, 13)
        LabelPrefix.TabIndex = 13
        LabelPrefix.Text = "no file"
        ' 
        ' PictureBoxFaceLabel
        ' 
        PictureBoxFaceLabel.AutoSize = True
        PictureBoxFaceLabel.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        PictureBoxFaceLabel.ForeColor = SystemColors.HotTrack
        PictureBoxFaceLabel.Location = New Point(4, 55)
        PictureBoxFaceLabel.Margin = New Padding(4, 5, 4, 5)
        PictureBoxFaceLabel.Name = "PictureBoxFaceLabel"
        PictureBoxFaceLabel.Size = New Size(40, 13)
        PictureBoxFaceLabel.TabIndex = 12
        PictureBoxFaceLabel.Text = "no file"
        ' 
        ' ButFaceFolder
        ' 
        ButFaceFolder.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButFaceFolder.Enabled = False
        ButFaceFolder.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButFaceFolder.Location = New Point(500, 40)
        ButFaceFolder.Margin = New Padding(4, 5, 4, 5)
        ButFaceFolder.Name = "ButFaceFolder"
        ButFaceFolder.Size = New Size(60, 30)
        ButFaceFolder.TabIndex = 5
        ButFaceFolder.Text = "Folder.."
        ButFaceFolder.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxFacesFromFolder
        ' 
        CheckBoxFacesFromFolder.AutoSize = True
        CheckBoxFacesFromFolder.Enabled = False
        CheckBoxFacesFromFolder.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxFacesFromFolder.Location = New Point(320, 30)
        CheckBoxFacesFromFolder.Margin = New Padding(4, 5, 4, 5)
        CheckBoxFacesFromFolder.Name = "CheckBoxFacesFromFolder"
        CheckBoxFacesFromFolder.Size = New Size(172, 17)
        CheckBoxFacesFromFolder.TabIndex = 4
        CheckBoxFacesFromFolder.Text = "For all the Faces from Folder"
        CheckBoxFacesFromFolder.UseVisualStyleBackColor = True
        ' 
        ' ButtonFaceFile
        ' 
        ButtonFaceFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonFaceFile.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonFaceFile.Location = New Point(500, 5)
        ButtonFaceFile.Margin = New Padding(4, 5, 4, 5)
        ButtonFaceFile.Name = "ButtonFaceFile"
        ButtonFaceFile.Size = New Size(60, 30)
        ButtonFaceFile.TabIndex = 3
        ButtonFaceFile.Text = "File.."
        ButtonFaceFile.UseVisualStyleBackColor = True
        ' 
        ' LabelFace
        ' 
        LabelFace.AutoSize = True
        LabelFace.Location = New Point(8, 5)
        LabelFace.Margin = New Padding(4, 5, 4, 5)
        LabelFace.Name = "LabelFace"
        LabelFace.Size = New Size(30, 13)
        LabelFace.TabIndex = 2
        LabelFace.Text = "Face"
        ' 
        ' TextFace
        ' 
        TextFace.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextFace.BackColor = SystemColors.Info
        TextFace.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextFace.Location = New Point(48, 5)
        TextFace.Margin = New Padding(4, 5, 4, 5)
        TextFace.Name = "TextFace"
        TextFace.Size = New Size(444, 22)
        TextFace.TabIndex = 1
        ' 
        ' TabControlSource
        ' 
        TabControlSource.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControlSource.Controls.Add(TabPageSourceImage)
        TabControlSource.Controls.Add(TabPageSourceVideo)
        TabControlSource.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TabControlSource.Location = New Point(4, 125)
        TabControlSource.Margin = New Padding(4, 5, 4, 5)
        TabControlSource.Name = "TabControlSource"
        TabControlSource.SelectedIndex = 0
        TabControlSource.Size = New Size(772, 365)
        TabControlSource.TabIndex = 11
        ' 
        ' TabPageSourceImage
        ' 
        TabPageSourceImage.BackColor = Color.Linen
        TabPageSourceImage.Controls.Add(CheckBoxForAllFaces)
        TabPageSourceImage.Controls.Add(Button3)
        TabPageSourceImage.Controls.Add(ButtonDeleteSourceImage)
        TabPageSourceImage.Controls.Add(ButtonRotate)
        TabPageSourceImage.Controls.Add(ButtonLoadPrev)
        TabPageSourceImage.Controls.Add(ButtonLoadNext)
        TabPageSourceImage.Controls.Add(ButtonNext)
        TabPageSourceImage.Controls.Add(ReSource)
        TabPageSourceImage.Controls.Add(TextBoxSourceName)
        TabPageSourceImage.Controls.Add(LabelNameSource)
        TabPageSourceImage.Controls.Add(CheckBoxSourceHidden)
        TabPageSourceImage.Controls.Add(LabelSourceName)
        TabPageSourceImage.Controls.Add(PictureBoxSourceLabel)
        TabPageSourceImage.Controls.Add(ButtonImageAddTask)
        TabPageSourceImage.Controls.Add(ButtonSourceImageFolder)
        TabPageSourceImage.Controls.Add(ButtonImageStart)
        TabPageSourceImage.Controls.Add(CheckBoxSourceImagesFromFolder)
        TabPageSourceImage.Controls.Add(ButtonSourceImageFile)
        TabPageSourceImage.Controls.Add(LabelSource)
        TabPageSourceImage.Controls.Add(TextBoxSourceImage)
        TabPageSourceImage.Controls.Add(PictureBoxSourceImage)
        TabPageSourceImage.Location = New Point(4, 22)
        TabPageSourceImage.Margin = New Padding(4, 5, 4, 5)
        TabPageSourceImage.Name = "TabPageSourceImage"
        TabPageSourceImage.Padding = New Padding(4, 5, 4, 5)
        TabPageSourceImage.Size = New Size(764, 339)
        TabPageSourceImage.TabIndex = 0
        TabPageSourceImage.Text = "Source from IMAGE"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(700, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(60, 30)
        Button3.TabIndex = 26
        Button3.Text = "out"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ButtonDeleteSourceImage
        ' 
        ButtonDeleteSourceImage.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonDeleteSourceImage.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonDeleteSourceImage.Location = New Point(636, 35)
        ButtonDeleteSourceImage.Name = "ButtonDeleteSourceImage"
        ButtonDeleteSourceImage.Size = New Size(48, 30)
        ButtonDeleteSourceImage.TabIndex = 25
        ButtonDeleteSourceImage.Text = "del"
        ButtonDeleteSourceImage.UseVisualStyleBackColor = True
        ' 
        ' ButtonRotate
        ' 
        ButtonRotate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonRotate.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonRotate.Location = New Point(728, 70)
        ButtonRotate.Margin = New Padding(4, 5, 4, 5)
        ButtonRotate.Name = "ButtonRotate"
        ButtonRotate.Size = New Size(32, 30)
        ButtonRotate.TabIndex = 24
        ButtonRotate.Text = "R"
        ButtonRotate.UseVisualStyleBackColor = True
        ' 
        ' ButtonLoadPrev
        ' 
        ButtonLoadPrev.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonLoadPrev.Location = New Point(636, 70)
        ButtonLoadPrev.Margin = New Padding(4, 5, 4, 5)
        ButtonLoadPrev.Name = "ButtonLoadPrev"
        ButtonLoadPrev.Size = New Size(32, 30)
        ButtonLoadPrev.TabIndex = 23
        ButtonLoadPrev.Text = "<"
        ButtonLoadPrev.UseVisualStyleBackColor = True
        ' 
        ' ButtonLoadNext
        ' 
        ButtonLoadNext.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonLoadNext.Location = New Point(672, 70)
        ButtonLoadNext.Margin = New Padding(4, 5, 4, 5)
        ButtonLoadNext.Name = "ButtonLoadNext"
        ButtonLoadNext.Size = New Size(48, 30)
        ButtonLoadNext.TabIndex = 22
        ButtonLoadNext.Text = ">"
        ButtonLoadNext.UseVisualStyleBackColor = True
        ' 
        ' ButtonNext
        ' 
        ButtonNext.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonNext.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonNext.Location = New Point(464, 70)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(84, 30)
        ButtonNext.TabIndex = 21
        ButtonNext.Text = "Next"
        ButtonNext.UseVisualStyleBackColor = True
        ' 
        ' ReSource
        ' 
        ReSource.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ReSource.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ReSource.Location = New Point(596, 5)
        ReSource.Name = "ReSource"
        ReSource.Size = New Size(32, 30)
        ReSource.TabIndex = 20
        ReSource.Text = "re"
        ReSource.UseVisualStyleBackColor = True
        ' 
        ' TextBoxSourceName
        ' 
        TextBoxSourceName.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSourceName.Location = New Point(44, 30)
        TextBoxSourceName.Name = "TextBoxSourceName"
        TextBoxSourceName.Size = New Size(256, 22)
        TextBoxSourceName.TabIndex = 19
        ' 
        ' LabelNameSource
        ' 
        LabelNameSource.AutoSize = True
        LabelNameSource.Location = New Point(4, 30)
        LabelNameSource.Name = "LabelNameSource"
        LabelNameSource.Size = New Size(36, 13)
        LabelNameSource.TabIndex = 18
        LabelNameSource.Text = "Name"
        ' 
        ' CheckBoxSourceHidden
        ' 
        CheckBoxSourceHidden.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckBoxSourceHidden.AutoSize = True
        CheckBoxSourceHidden.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxSourceHidden.Location = New Point(708, 50)
        CheckBoxSourceHidden.Margin = New Padding(2)
        CheckBoxSourceHidden.Name = "CheckBoxSourceHidden"
        CheckBoxSourceHidden.Size = New Size(49, 17)
        CheckBoxSourceHidden.TabIndex = 17
        CheckBoxSourceHidden.Text = "hide"
        CheckBoxSourceHidden.UseVisualStyleBackColor = True
        ' 
        ' LabelSourceName
        ' 
        LabelSourceName.AutoSize = True
        LabelSourceName.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        LabelSourceName.ForeColor = Color.Maroon
        LabelSourceName.Location = New Point(4, 60)
        LabelSourceName.Margin = New Padding(4, 5, 4, 5)
        LabelSourceName.Name = "LabelSourceName"
        LabelSourceName.Size = New Size(40, 13)
        LabelSourceName.TabIndex = 16
        LabelSourceName.Text = "no file"
        ' 
        ' PictureBoxSourceLabel
        ' 
        PictureBoxSourceLabel.AutoSize = True
        PictureBoxSourceLabel.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        PictureBoxSourceLabel.ForeColor = SystemColors.Highlight
        PictureBoxSourceLabel.Location = New Point(4, 80)
        PictureBoxSourceLabel.Margin = New Padding(4, 5, 4, 5)
        PictureBoxSourceLabel.Name = "PictureBoxSourceLabel"
        PictureBoxSourceLabel.Size = New Size(40, 13)
        PictureBoxSourceLabel.TabIndex = 15
        PictureBoxSourceLabel.Text = "no file"
        ' 
        ' ButtonImageAddTask
        ' 
        ButtonImageAddTask.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonImageAddTask.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonImageAddTask.Location = New Point(368, 70)
        ButtonImageAddTask.Margin = New Padding(4, 5, 4, 5)
        ButtonImageAddTask.Name = "ButtonImageAddTask"
        ButtonImageAddTask.Size = New Size(92, 30)
        ButtonImageAddTask.TabIndex = 14
        ButtonImageAddTask.Text = "Add task"
        ButtonImageAddTask.UseVisualStyleBackColor = True
        ' 
        ' ButtonSourceImageFolder
        ' 
        ButtonSourceImageFolder.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonSourceImageFolder.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSourceImageFolder.Location = New Point(488, 40)
        ButtonSourceImageFolder.Margin = New Padding(4, 5, 4, 5)
        ButtonSourceImageFolder.Name = "ButtonSourceImageFolder"
        ButtonSourceImageFolder.Size = New Size(60, 30)
        ButtonSourceImageFolder.TabIndex = 12
        ButtonSourceImageFolder.Text = "Folder.."
        ButtonSourceImageFolder.UseVisualStyleBackColor = True
        ' 
        ' ButtonImageStart
        ' 
        ButtonImageStart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonImageStart.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonImageStart.Location = New Point(552, 45)
        ButtonImageStart.Margin = New Padding(4, 5, 4, 5)
        ButtonImageStart.Name = "ButtonImageStart"
        ButtonImageStart.Size = New Size(76, 55)
        ButtonImageStart.TabIndex = 13
        ButtonImageStart.Text = "START"
        ButtonImageStart.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxSourceImagesFromFolder
        ' 
        CheckBoxSourceImagesFromFolder.AutoSize = True
        CheckBoxSourceImagesFromFolder.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxSourceImagesFromFolder.Location = New Point(308, 30)
        CheckBoxSourceImagesFromFolder.Margin = New Padding(4, 5, 4, 5)
        CheckBoxSourceImagesFromFolder.Name = "CheckBoxSourceImagesFromFolder"
        CheckBoxSourceImagesFromFolder.Size = New Size(180, 17)
        CheckBoxSourceImagesFromFolder.TabIndex = 11
        CheckBoxSourceImagesFromFolder.Text = "For all the Images from Folder"
        CheckBoxSourceImagesFromFolder.UseVisualStyleBackColor = True
        ' 
        ' ButtonSourceImageFile
        ' 
        ButtonSourceImageFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonSourceImageFile.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSourceImageFile.Location = New Point(488, 5)
        ButtonSourceImageFile.Margin = New Padding(4, 5, 4, 5)
        ButtonSourceImageFile.Name = "ButtonSourceImageFile"
        ButtonSourceImageFile.Size = New Size(60, 30)
        ButtonSourceImageFile.TabIndex = 10
        ButtonSourceImageFile.Text = "File.."
        ButtonSourceImageFile.UseVisualStyleBackColor = True
        ' 
        ' LabelSource
        ' 
        LabelSource.AutoSize = True
        LabelSource.Location = New Point(4, 5)
        LabelSource.Margin = New Padding(4, 5, 4, 5)
        LabelSource.Name = "LabelSource"
        LabelSource.Size = New Size(38, 13)
        LabelSource.TabIndex = 6
        LabelSource.Text = "Image"
        ' 
        ' TextBoxSourceImage
        ' 
        TextBoxSourceImage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxSourceImage.BackColor = SystemColors.GradientInactiveCaption
        TextBoxSourceImage.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSourceImage.Location = New Point(44, 5)
        TextBoxSourceImage.Margin = New Padding(4, 5, 4, 5)
        TextBoxSourceImage.Name = "TextBoxSourceImage"
        TextBoxSourceImage.Size = New Size(436, 22)
        TextBoxSourceImage.TabIndex = 7
        ' 
        ' PictureBoxSourceImage
        ' 
        PictureBoxSourceImage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBoxSourceImage.BackColor = Color.Linen
        PictureBoxSourceImage.Location = New Point(4, 110)
        PictureBoxSourceImage.Margin = New Padding(4, 5, 4, 5)
        PictureBoxSourceImage.Name = "PictureBoxSourceImage"
        PictureBoxSourceImage.Size = New Size(756, 225)
        PictureBoxSourceImage.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxSourceImage.TabIndex = 9
        PictureBoxSourceImage.TabStop = False
        ' 
        ' TabPageSourceVideo
        ' 
        TabPageSourceVideo.BackColor = Color.Moccasin
        TabPageSourceVideo.Controls.Add(TextBoxNameSourceVideo)
        TabPageSourceVideo.Controls.Add(Label1)
        TabPageSourceVideo.Controls.Add(PictureBoxVideo)
        TabPageSourceVideo.Controls.Add(PictureBoxSourceVideoLabel)
        TabPageSourceVideo.Controls.Add(LabelSourceVideoName)
        TabPageSourceVideo.Controls.Add(ButtonSourceVideoPlay)
        TabPageSourceVideo.Controls.Add(ButtonSourceVideoFolder)
        TabPageSourceVideo.Controls.Add(CheckBoxSourceVideoFromFolder)
        TabPageSourceVideo.Controls.Add(ButtonSourceVideoFile)
        TabPageSourceVideo.Controls.Add(ButtonVideoAddTask)
        TabPageSourceVideo.Controls.Add(ButtonVideoStart)
        TabPageSourceVideo.Controls.Add(LabelSourceVideo)
        TabPageSourceVideo.Controls.Add(TextBoxSourceVideo)
        TabPageSourceVideo.Location = New Point(4, 22)
        TabPageSourceVideo.Margin = New Padding(4, 5, 4, 5)
        TabPageSourceVideo.Name = "TabPageSourceVideo"
        TabPageSourceVideo.Padding = New Padding(4, 5, 4, 5)
        TabPageSourceVideo.Size = New Size(764, 339)
        TabPageSourceVideo.TabIndex = 1
        TabPageSourceVideo.Text = "Source from VIDEO"
        ' 
        ' TextBoxNameSourceVideo
        ' 
        TextBoxNameSourceVideo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxNameSourceVideo.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxNameSourceVideo.Location = New Point(52, 5)
        TextBoxNameSourceVideo.Name = "TextBoxNameSourceVideo"
        TextBoxNameSourceVideo.Size = New Size(436, 22)
        TextBoxNameSourceVideo.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 13)
        Label1.TabIndex = 24
        Label1.Text = "Name"
        ' 
        ' PictureBoxVideo
        ' 
        PictureBoxVideo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBoxVideo.Location = New Point(8, 80)
        PictureBoxVideo.Name = "PictureBoxVideo"
        PictureBoxVideo.Size = New Size(752, 255)
        PictureBoxVideo.TabIndex = 23
        PictureBoxVideo.TabStop = False
        ' 
        ' PictureBoxSourceVideoLabel
        ' 
        PictureBoxSourceVideoLabel.AutoSize = True
        PictureBoxSourceVideoLabel.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        PictureBoxSourceVideoLabel.ForeColor = SystemColors.HotTrack
        PictureBoxSourceVideoLabel.Location = New Point(4, 50)
        PictureBoxSourceVideoLabel.Margin = New Padding(4, 5, 4, 5)
        PictureBoxSourceVideoLabel.Name = "PictureBoxSourceVideoLabel"
        PictureBoxSourceVideoLabel.Size = New Size(40, 13)
        PictureBoxSourceVideoLabel.TabIndex = 22
        PictureBoxSourceVideoLabel.Text = "no file"
        ' 
        ' LabelSourceVideoName
        ' 
        LabelSourceVideoName.AutoSize = True
        LabelSourceVideoName.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        LabelSourceVideoName.ForeColor = Color.Maroon
        LabelSourceVideoName.Location = New Point(4, 65)
        LabelSourceVideoName.Margin = New Padding(4, 5, 4, 5)
        LabelSourceVideoName.Name = "LabelSourceVideoName"
        LabelSourceVideoName.Size = New Size(40, 13)
        LabelSourceVideoName.TabIndex = 21
        LabelSourceVideoName.Text = "no file"
        ' 
        ' ButtonSourceVideoPlay
        ' 
        ButtonSourceVideoPlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonSourceVideoPlay.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSourceVideoPlay.Location = New Point(700, 5)
        ButtonSourceVideoPlay.Margin = New Padding(4, 5, 4, 5)
        ButtonSourceVideoPlay.Name = "ButtonSourceVideoPlay"
        ButtonSourceVideoPlay.Size = New Size(60, 30)
        ButtonSourceVideoPlay.TabIndex = 20
        ButtonSourceVideoPlay.Text = "Play.."
        ButtonSourceVideoPlay.UseVisualStyleBackColor = True
        ' 
        ' ButtonSourceVideoFolder
        ' 
        ButtonSourceVideoFolder.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonSourceVideoFolder.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSourceVideoFolder.Location = New Point(490, 35)
        ButtonSourceVideoFolder.Margin = New Padding(4, 5, 4, 5)
        ButtonSourceVideoFolder.Name = "ButtonSourceVideoFolder"
        ButtonSourceVideoFolder.Size = New Size(60, 30)
        ButtonSourceVideoFolder.TabIndex = 19
        ButtonSourceVideoFolder.Text = "Folder.."
        ButtonSourceVideoFolder.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxSourceVideoFromFolder
        ' 
        CheckBoxSourceVideoFromFolder.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckBoxSourceVideoFromFolder.AutoSize = True
        CheckBoxSourceVideoFromFolder.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxSourceVideoFromFolder.Location = New Point(364, 30)
        CheckBoxSourceVideoFromFolder.Margin = New Padding(4, 5, 4, 5)
        CheckBoxSourceVideoFromFolder.Name = "CheckBoxSourceVideoFromFolder"
        CheckBoxSourceVideoFromFolder.Size = New Size(124, 17)
        CheckBoxSourceVideoFromFolder.TabIndex = 18
        CheckBoxSourceVideoFromFolder.Text = "Videos from Folder"
        CheckBoxSourceVideoFromFolder.UseVisualStyleBackColor = True
        ' 
        ' ButtonSourceVideoFile
        ' 
        ButtonSourceVideoFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonSourceVideoFile.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSourceVideoFile.Location = New Point(490, 5)
        ButtonSourceVideoFile.Margin = New Padding(4, 5, 4, 5)
        ButtonSourceVideoFile.Name = "ButtonSourceVideoFile"
        ButtonSourceVideoFile.Size = New Size(60, 30)
        ButtonSourceVideoFile.TabIndex = 17
        ButtonSourceVideoFile.Text = "File.."
        ButtonSourceVideoFile.UseVisualStyleBackColor = True
        ' 
        ' ButtonVideoAddTask
        ' 
        ButtonVideoAddTask.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonVideoAddTask.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonVideoAddTask.Location = New Point(700, 35)
        ButtonVideoAddTask.Margin = New Padding(4, 5, 4, 5)
        ButtonVideoAddTask.Name = "ButtonVideoAddTask"
        ButtonVideoAddTask.Size = New Size(60, 30)
        ButtonVideoAddTask.TabIndex = 16
        ButtonVideoAddTask.Text = "Add task"
        ButtonVideoAddTask.UseVisualStyleBackColor = True
        ' 
        ' ButtonVideoStart
        ' 
        ButtonVideoStart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonVideoStart.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonVideoStart.Location = New Point(560, 5)
        ButtonVideoStart.Margin = New Padding(4, 5, 4, 5)
        ButtonVideoStart.Name = "ButtonVideoStart"
        ButtonVideoStart.Size = New Size(132, 60)
        ButtonVideoStart.TabIndex = 15
        ButtonVideoStart.Text = "START"
        ButtonVideoStart.UseVisualStyleBackColor = True
        ' 
        ' LabelSourceVideo
        ' 
        LabelSourceVideo.AutoSize = True
        LabelSourceVideo.Location = New Point(4, 5)
        LabelSourceVideo.Margin = New Padding(4, 5, 4, 5)
        LabelSourceVideo.Name = "LabelSourceVideo"
        LabelSourceVideo.Size = New Size(37, 13)
        LabelSourceVideo.TabIndex = 10
        LabelSourceVideo.Text = "Video"
        ' 
        ' TextBoxSourceVideo
        ' 
        TextBoxSourceVideo.BackColor = SystemColors.ControlLight
        TextBoxSourceVideo.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSourceVideo.Location = New Point(52, 30)
        TextBoxSourceVideo.Margin = New Padding(4, 5, 4, 5)
        TextBoxSourceVideo.Name = "TextBoxSourceVideo"
        TextBoxSourceVideo.Size = New Size(240, 22)
        TextBoxSourceVideo.TabIndex = 9
        ' 
        ' PageTasks
        ' 
        PageTasks.BackColor = Color.MistyRose
        PageTasks.Controls.Add(ButtonTasksOneBatch)
        PageTasks.Controls.Add(ButtonTasksOneByOne)
        PageTasks.Controls.Add(ButtonTasksRun)
        PageTasks.Controls.Add(ButtonTasksClear)
        PageTasks.Controls.Add(ButtonTasksRemove)
        PageTasks.Controls.Add(ListBox1)
        PageTasks.Location = New Point(4, 22)
        PageTasks.Margin = New Padding(4, 5, 4, 5)
        PageTasks.Name = "PageTasks"
        PageTasks.Padding = New Padding(4, 5, 4, 5)
        PageTasks.Size = New Size(772, 494)
        PageTasks.TabIndex = 1
        PageTasks.Text = "List of tasks.."
        ' 
        ' ButtonTasksOneBatch
        ' 
        ButtonTasksOneBatch.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonTasksOneBatch.Location = New Point(612, 5)
        ButtonTasksOneBatch.Name = "ButtonTasksOneBatch"
        ButtonTasksOneBatch.Size = New Size(144, 30)
        ButtonTasksOneBatch.TabIndex = 5
        ButtonTasksOneBatch.Text = "RUN Tasks as Batch"
        ButtonTasksOneBatch.UseVisualStyleBackColor = True
        ' 
        ' ButtonTasksOneByOne
        ' 
        ButtonTasksOneByOne.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonTasksOneByOne.Location = New Point(460, 5)
        ButtonTasksOneByOne.Name = "ButtonTasksOneByOne"
        ButtonTasksOneByOne.Size = New Size(144, 30)
        ButtonTasksOneByOne.TabIndex = 4
        ButtonTasksOneByOne.Text = "RUN one-by-one Tasks"
        ButtonTasksOneByOne.UseVisualStyleBackColor = True
        ' 
        ' ButtonTasksRun
        ' 
        ButtonTasksRun.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonTasksRun.Location = New Point(312, 5)
        ButtonTasksRun.Name = "ButtonTasksRun"
        ButtonTasksRun.Size = New Size(144, 30)
        ButtonTasksRun.TabIndex = 3
        ButtonTasksRun.Text = "RUN all Tasks"
        ButtonTasksRun.UseVisualStyleBackColor = True
        ' 
        ' ButtonTasksClear
        ' 
        ButtonTasksClear.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonTasksClear.Location = New Point(160, 5)
        ButtonTasksClear.Name = "ButtonTasksClear"
        ButtonTasksClear.Size = New Size(144, 30)
        ButtonTasksClear.TabIndex = 2
        ButtonTasksClear.Text = "Clear list"
        ButtonTasksClear.UseVisualStyleBackColor = True
        ' 
        ' ButtonTasksRemove
        ' 
        ButtonTasksRemove.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonTasksRemove.Location = New Point(4, 5)
        ButtonTasksRemove.Name = "ButtonTasksRemove"
        ButtonTasksRemove.Size = New Size(144, 30)
        ButtonTasksRemove.TabIndex = 1
        ButtonTasksRemove.Text = "Remove Selected"
        ButtonTasksRemove.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBox1.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.HorizontalScrollbar = True
        ListBox1.Location = New Point(4, 56)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        ListBox1.Size = New Size(764, 394)
        ListBox1.TabIndex = 0
        ' 
        ' PageSettings
        ' 
        PageSettings.BackColor = Color.Gainsboro
        PageSettings.BorderStyle = BorderStyle.FixedSingle
        PageSettings.Controls.Add(CheckBoxNoWindowForVideo)
        PageSettings.Controls.Add(ButtonRunThisCommand)
        PageSettings.Controls.Add(TextBoxLastCommandLine)
        PageSettings.Controls.Add(CheckBoxNoWindow)
        PageSettings.Controls.Add(CheckBox512)
        PageSettings.Controls.Add(CheckBoxRunMinimized)
        PageSettings.Controls.Add(ButtonOutputOpen)
        PageSettings.Controls.Add(ButtonOutputFolder)
        PageSettings.Controls.Add(LabelOutputFolder)
        PageSettings.Controls.Add(TextBoxOutputFolder)
        PageSettings.Controls.Add(ButtonSimSwapFolder)
        PageSettings.Controls.Add(LabelSimSwap)
        PageSettings.Controls.Add(TextSimSwapFolder)
        PageSettings.Controls.Add(ButtonAnaconda)
        PageSettings.Controls.Add(LabelAnaconda)
        PageSettings.Controls.Add(TextAnaconda)
        PageSettings.Location = New Point(4, 22)
        PageSettings.Margin = New Padding(4, 5, 4, 5)
        PageSettings.Name = "PageSettings"
        PageSettings.Padding = New Padding(4, 5, 4, 5)
        PageSettings.Size = New Size(772, 494)
        PageSettings.TabIndex = 2
        PageSettings.Text = "RUN Settings"
        ' 
        ' CheckBoxNoWindowForVideo
        ' 
        CheckBoxNoWindowForVideo.AutoSize = True
        CheckBoxNoWindowForVideo.Location = New Point(216, 120)
        CheckBoxNoWindowForVideo.Name = "CheckBoxNoWindowForVideo"
        CheckBoxNoWindowForVideo.Size = New Size(139, 17)
        CheckBoxNoWindowForVideo.TabIndex = 15
        CheckBoxNoWindowForVideo.Text = "No Window for Video"
        CheckBoxNoWindowForVideo.UseVisualStyleBackColor = True
        ' 
        ' ButtonRunThisCommand
        ' 
        ButtonRunThisCommand.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ButtonRunThisCommand.Location = New Point(656, 110)
        ButtonRunThisCommand.Name = "ButtonRunThisCommand"
        ButtonRunThisCommand.Size = New Size(96, 30)
        ButtonRunThisCommand.TabIndex = 14
        ButtonRunThisCommand.Text = "RUN"
        ButtonRunThisCommand.UseVisualStyleBackColor = True
        ' 
        ' TextBoxLastCommandLine
        ' 
        TextBoxLastCommandLine.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxLastCommandLine.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLastCommandLine.Location = New Point(8, 145)
        TextBoxLastCommandLine.Multiline = True
        TextBoxLastCommandLine.Name = "TextBoxLastCommandLine"
        TextBoxLastCommandLine.Size = New Size(756, 320)
        TextBoxLastCommandLine.TabIndex = 13
        ' 
        ' CheckBoxNoWindow
        ' 
        CheckBoxNoWindow.AutoSize = True
        CheckBoxNoWindow.Location = New Point(216, 100)
        CheckBoxNoWindow.Name = "CheckBoxNoWindow"
        CheckBoxNoWindow.Size = New Size(140, 17)
        CheckBoxNoWindow.TabIndex = 12
        CheckBoxNoWindow.Text = "No Window for Image"
        CheckBoxNoWindow.UseVisualStyleBackColor = True
        ' 
        ' CheckBox512
        ' 
        CheckBox512.AutoSize = True
        CheckBox512.Location = New Point(112, 100)
        CheckBox512.Name = "CheckBox512"
        CheckBox512.Size = New Size(44, 17)
        CheckBox512.TabIndex = 11
        CheckBox512.Text = "512"
        CheckBox512.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxRunMinimized
        ' 
        CheckBoxRunMinimized.AutoSize = True
        CheckBoxRunMinimized.Location = New Point(112, 120)
        CheckBoxRunMinimized.Name = "CheckBoxRunMinimized"
        CheckBoxRunMinimized.Size = New Size(103, 17)
        CheckBoxRunMinimized.TabIndex = 10
        CheckBoxRunMinimized.Text = "Run Minimized"
        CheckBoxRunMinimized.UseVisualStyleBackColor = True
        ' 
        ' ButtonOutputOpen
        ' 
        ButtonOutputOpen.Location = New Point(692, 75)
        ButtonOutputOpen.Margin = New Padding(4, 5, 4, 5)
        ButtonOutputOpen.Name = "ButtonOutputOpen"
        ButtonOutputOpen.Size = New Size(60, 25)
        ButtonOutputOpen.TabIndex = 9
        ButtonOutputOpen.Text = "open"
        ButtonOutputOpen.UseVisualStyleBackColor = True
        ' 
        ' ButtonOutputFolder
        ' 
        ButtonOutputFolder.Location = New Point(656, 75)
        ButtonOutputFolder.Margin = New Padding(4, 5, 4, 5)
        ButtonOutputFolder.Name = "ButtonOutputFolder"
        ButtonOutputFolder.Size = New Size(36, 25)
        ButtonOutputFolder.TabIndex = 8
        ButtonOutputFolder.Text = "..."
        ButtonOutputFolder.UseVisualStyleBackColor = True
        ' 
        ' LabelOutputFolder
        ' 
        LabelOutputFolder.AutoSize = True
        LabelOutputFolder.Location = New Point(12, 80)
        LabelOutputFolder.Margin = New Padding(4, 5, 4, 5)
        LabelOutputFolder.Name = "LabelOutputFolder"
        LabelOutputFolder.Size = New Size(79, 13)
        LabelOutputFolder.TabIndex = 7
        LabelOutputFolder.Text = "Output folder"
        ' 
        ' TextBoxOutputFolder
        ' 
        TextBoxOutputFolder.BackColor = SystemColors.Info
        TextBoxOutputFolder.Location = New Point(112, 75)
        TextBoxOutputFolder.Margin = New Padding(4, 5, 4, 5)
        TextBoxOutputFolder.Name = "TextBoxOutputFolder"
        TextBoxOutputFolder.Size = New Size(528, 22)
        TextBoxOutputFolder.TabIndex = 6
        ' 
        ' ButtonSimSwapFolder
        ' 
        ButtonSimSwapFolder.Location = New Point(656, 40)
        ButtonSimSwapFolder.Margin = New Padding(4, 5, 4, 5)
        ButtonSimSwapFolder.Name = "ButtonSimSwapFolder"
        ButtonSimSwapFolder.Size = New Size(36, 25)
        ButtonSimSwapFolder.TabIndex = 5
        ButtonSimSwapFolder.Text = "..."
        ButtonSimSwapFolder.UseVisualStyleBackColor = True
        ' 
        ' LabelSimSwap
        ' 
        LabelSimSwap.AutoSize = True
        LabelSimSwap.Location = New Point(12, 45)
        LabelSimSwap.Margin = New Padding(4, 5, 4, 5)
        LabelSimSwap.Name = "LabelSimSwap"
        LabelSimSwap.Size = New Size(87, 13)
        LabelSimSwap.TabIndex = 4
        LabelSimSwap.Text = "SimSwap folder"
        ' 
        ' TextSimSwapFolder
        ' 
        TextSimSwapFolder.Location = New Point(112, 40)
        TextSimSwapFolder.Margin = New Padding(4, 5, 4, 5)
        TextSimSwapFolder.Name = "TextSimSwapFolder"
        TextSimSwapFolder.Size = New Size(528, 22)
        TextSimSwapFolder.TabIndex = 3
        ' 
        ' ButtonAnaconda
        ' 
        ButtonAnaconda.Location = New Point(656, 5)
        ButtonAnaconda.Margin = New Padding(4, 5, 4, 5)
        ButtonAnaconda.Name = "ButtonAnaconda"
        ButtonAnaconda.Size = New Size(36, 25)
        ButtonAnaconda.TabIndex = 2
        ButtonAnaconda.Text = "..."
        ButtonAnaconda.UseVisualStyleBackColor = True
        ' 
        ' LabelAnaconda
        ' 
        LabelAnaconda.AutoSize = True
        LabelAnaconda.Location = New Point(12, 10)
        LabelAnaconda.Margin = New Padding(4, 5, 4, 5)
        LabelAnaconda.Name = "LabelAnaconda"
        LabelAnaconda.Size = New Size(93, 13)
        LabelAnaconda.TabIndex = 1
        LabelAnaconda.Text = "Anaconda folder"
        ' 
        ' TextAnaconda
        ' 
        TextAnaconda.Location = New Point(112, 5)
        TextAnaconda.Margin = New Padding(4, 5, 4, 5)
        TextAnaconda.Name = "TextAnaconda"
        TextAnaconda.Size = New Size(528, 22)
        TextAnaconda.TabIndex = 0
        ' 
        ' TabResult
        ' 
        TabResult.Controls.Add(Button2)
        TabResult.Controls.Add(ButtonDelResult)
        TabResult.Controls.Add(ButtonResult)
        TabResult.Controls.Add(PictureBoxResult)
        TabResult.Controls.Add(TextBoxResult)
        TabResult.Location = New Point(4, 22)
        TabResult.Name = "TabResult"
        TabResult.Padding = New Padding(3)
        TabResult.Size = New Size(772, 494)
        TabResult.TabIndex = 3
        TabResult.Text = "Result"
        TabResult.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(704, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(60, 30)
        Button2.TabIndex = 13
        Button2.Text = "out"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelResult
        ' 
        ButtonDelResult.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonDelResult.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonDelResult.Location = New Point(628, 0)
        ButtonDelResult.Name = "ButtonDelResult"
        ButtonDelResult.Size = New Size(72, 30)
        ButtonDelResult.TabIndex = 12
        ButtonDelResult.Text = "del"
        ButtonDelResult.UseVisualStyleBackColor = True
        ' 
        ' ButtonResult
        ' 
        ButtonResult.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonResult.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonResult.Location = New Point(588, 0)
        ButtonResult.Name = "ButtonResult"
        ButtonResult.Size = New Size(36, 30)
        ButtonResult.TabIndex = 11
        ButtonResult.Text = "re"
        ButtonResult.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxResult
        ' 
        PictureBoxResult.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBoxResult.BackColor = Color.Moccasin
        PictureBoxResult.Location = New Point(4, 35)
        PictureBoxResult.Margin = New Padding(4, 5, 4, 5)
        PictureBoxResult.Name = "PictureBoxResult"
        PictureBoxResult.Size = New Size(760, 455)
        PictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxResult.TabIndex = 10
        PictureBoxResult.TabStop = False
        ' 
        ' TextBoxResult
        ' 
        TextBoxResult.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxResult.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxResult.Location = New Point(4, 5)
        TextBoxResult.Name = "TextBoxResult"
        TextBoxResult.ReadOnly = True
        TextBoxResult.Size = New Size(572, 22)
        TextBoxResult.TabIndex = 0
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ButtonTempFolder
        ' 
        ButtonTempFolder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonTempFolder.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonTempFolder.Location = New Point(672, 525)
        ButtonTempFolder.Margin = New Padding(4, 5, 4, 5)
        ButtonTempFolder.Name = "ButtonTempFolder"
        ButtonTempFolder.Size = New Size(76, 35)
        ButtonTempFolder.TabIndex = 1
        ButtonTempFolder.Text = "Open Temp Folder"
        ButtonTempFolder.UseVisualStyleBackColor = True
        ' 
        ' ButtonOpenOutputFolder
        ' 
        ButtonOpenOutputFolder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonOpenOutputFolder.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonOpenOutputFolder.Location = New Point(592, 525)
        ButtonOpenOutputFolder.Margin = New Padding(4, 5, 4, 5)
        ButtonOpenOutputFolder.Name = "ButtonOpenOutputFolder"
        ButtonOpenOutputFolder.Size = New Size(76, 35)
        ButtonOpenOutputFolder.TabIndex = 2
        ButtonOpenOutputFolder.Text = "OUTPUT Folder"
        ButtonOpenOutputFolder.UseVisualStyleBackColor = True
        ' 
        ' LabelLast
        ' 
        LabelLast.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LabelLast.AutoSize = True
        LabelLast.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        LabelLast.Location = New Point(5, 523)
        LabelLast.Margin = New Padding(4, 5, 4, 5)
        LabelLast.Name = "LabelLast"
        LabelLast.Size = New Size(30, 13)
        LabelLast.TabIndex = 3
        LabelLast.Text = "Last:"
        ' 
        ' LabelLastFileName
        ' 
        LabelLastFileName.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LabelLastFileName.AutoSize = True
        LabelLastFileName.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        LabelLastFileName.ForeColor = Color.Green
        LabelLastFileName.Location = New Point(4, 540)
        LabelLastFileName.Margin = New Padding(4, 5, 4, 5)
        LabelLastFileName.Name = "LabelLastFileName"
        LabelLastFileName.Size = New Size(40, 13)
        LabelLastFileName.TabIndex = 4
        LabelLastFileName.Text = "no file"
        ' 
        ' ButtonOpenLastFile
        ' 
        ButtonOpenLastFile.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonOpenLastFile.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonOpenLastFile.Location = New Point(552, 525)
        ButtonOpenLastFile.Margin = New Padding(4, 5, 4, 5)
        ButtonOpenLastFile.Name = "ButtonOpenLastFile"
        ButtonOpenLastFile.Size = New Size(36, 35)
        ButtonOpenLastFile.TabIndex = 5
        ButtonOpenLastFile.Text = "."
        ButtonOpenLastFile.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Location = New Point(752, 530)
        Button1.Name = "Button1"
        Button1.Size = New Size(28, 25)
        Button1.TabIndex = 7
        Button1.Text = "~"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxForAllFaces
        ' 
        CheckBoxForAllFaces.AutoSize = True
        CheckBoxForAllFaces.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxForAllFaces.Location = New Point(308, 50)
        CheckBoxForAllFaces.Margin = New Padding(4, 5, 4, 5)
        CheckBoxForAllFaces.Name = "CheckBoxForAllFaces"
        CheckBoxForAllFaces.Size = New Size(68, 17)
        CheckBoxForAllFaces.TabIndex = 27
        CheckBoxForAllFaces.Text = "All faces"
        CheckBoxForAllFaces.UseVisualStyleBackColor = True
        ' 
        ' F
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        AutoScroll = True
        AutoSize = True
        ClientSize = New Size(784, 561)
        Controls.Add(Button1)
        Controls.Add(ButtonOpenLastFile)
        Controls.Add(ButtonOpenOutputFolder)
        Controls.Add(LabelLast)
        Controls.Add(TabsBlock)
        Controls.Add(LabelLastFileName)
        Controls.Add(ButtonTempFolder)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MinimumSize = New Size(800, 600)
        Name = "F"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.Manual
        Text = "ReFace"
        TabsBlock.ResumeLayout(False)
        PageTask.ResumeLayout(False)
        PageTask.PerformLayout()
        CType(PictureBoxFace, ComponentModel.ISupportInitialize).EndInit()
        TabControlSource.ResumeLayout(False)
        TabPageSourceImage.ResumeLayout(False)
        TabPageSourceImage.PerformLayout()
        CType(PictureBoxSourceImage, ComponentModel.ISupportInitialize).EndInit()
        TabPageSourceVideo.ResumeLayout(False)
        TabPageSourceVideo.PerformLayout()
        CType(PictureBoxVideo, ComponentModel.ISupportInitialize).EndInit()
        PageTasks.ResumeLayout(False)
        PageSettings.ResumeLayout(False)
        PageSettings.PerformLayout()
        TabResult.ResumeLayout(False)
        TabResult.PerformLayout()
        CType(PictureBoxResult, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabsBlock As TabControl
    Friend WithEvents PageTask As TabPage
    Friend WithEvents PageTasks As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ButFaceFolder As Button
    Friend WithEvents CheckBoxFacesFromFolder As CheckBox
    Friend WithEvents ButtonFaceFile As Button
    Friend WithEvents LabelFace As Label
    Friend WithEvents TextFace As TextBox
    Friend WithEvents PictureBoxFace As PictureBox
    Friend WithEvents PageSettings As TabPage
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ButtonSimSwapFolder As Button
    Friend WithEvents LabelSimSwap As Label
    Public WithEvents TextSimSwapFolder As TextBox
    Friend WithEvents ButtonAnaconda As Button
    Friend WithEvents LabelAnaconda As Label
    Friend WithEvents TextAnaconda As TextBox
    Friend WithEvents TextBoxSourceImage As TextBox
    Friend WithEvents LabelSource As Label
    Friend WithEvents LabelSourceVideo As Label
    Friend WithEvents TextBoxSourceVideo As TextBox
    Friend WithEvents TabControlSource As TabControl
    Friend WithEvents TabPageSourceImage As TabPage
    Friend WithEvents ButtonSourceImageFile As Button
    Friend WithEvents PictureBoxSourceImage As PictureBox
    Friend WithEvents TabPageSourceVideo As TabPage
    Friend WithEvents CheckBoxSourceImagesFromFolder As CheckBox
    Friend WithEvents ButtonSourceImageFolder As Button
    Friend WithEvents ButtonOutputFolder As Button
    Friend WithEvents LabelOutputFolder As Label
    Public WithEvents TextBoxOutputFolder As TextBox
    Friend WithEvents ButtonTempFolder As Button
    Friend WithEvents ButtonOpenOutputFolder As Button
    Friend WithEvents LabelLast As Label
    Friend WithEvents LabelLastFileName As Label
    Friend WithEvents ButtonImageAddTask As Button
    Friend WithEvents ButtonImageStart As Button
    Friend WithEvents ButtonSourceVideoPlay As Button
    Friend WithEvents ButtonSourceVideoFolder As Button
    Friend WithEvents CheckBoxSourceVideoFromFolder As CheckBox
    Friend WithEvents ButtonSourceVideoFile As Button
    Friend WithEvents ButtonVideoAddTask As Button
    Friend WithEvents ButtonVideoStart As Button
    Friend WithEvents ButtonOpenLastFile As Button
    Friend WithEvents PictureBoxFaceLabel As Label
    Friend WithEvents LabelPrefix As Label
    Friend WithEvents LabelSourceName As Label
    Friend WithEvents PictureBoxSourceLabel As Label
    Friend WithEvents LabelSourceVideoName As Label
    Friend WithEvents PictureBoxSourceVideoLabel As Label
    Friend WithEvents CheckBoxFaceHidden As CheckBox
    Friend WithEvents CheckBoxSourceHidden As CheckBox
    Friend WithEvents CaptionName As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents LabelNameSource As Label
    Friend WithEvents TextBoxSourceName As TextBox
    Friend WithEvents TabResult As TabPage
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents ButtonResult As Button
    Friend WithEvents PictureBoxResult As PictureBox
    Friend WithEvents ReFace As Button
    Friend WithEvents ReSource As Button
    Friend WithEvents ButtonDelResult As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonOutputOpen As Button
    Friend WithEvents ButtonTasksRemove As Button
    Friend WithEvents ButtonTasksClear As Button
    Friend WithEvents ButtonTasksRun As Button
    Friend WithEvents ButtonTasksOneByOne As Button
    Friend WithEvents ButtonTasksOneBatch As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBoxRunMinimized As CheckBox
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonLoadNext As Button
    Friend WithEvents ButtonLoadPrev As Button
    Friend WithEvents ButtonRotate As Button
    Friend WithEvents CheckBox512 As CheckBox
    Friend WithEvents CheckBoxNoWindow As CheckBox
    Friend WithEvents PictureBoxVideo As PictureBox
    Friend WithEvents TextBoxNameSourceVideo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonDeleteSourceImage As Button
    Friend WithEvents TextBoxLastCommandLine As TextBox
    Friend WithEvents ButtonRunThisCommand As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxNoWindowForVideo As CheckBox
    Friend WithEvents CheckBoxForAllFaces As CheckBox
End Class

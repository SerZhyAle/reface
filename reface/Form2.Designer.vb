<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ButtonDelResult = New Button()
        ButtonResult = New Button()
        PictureBoxResult = New PictureBox()
        TextBoxResult = New TextBox()
        Timer1 = New Timer(components)
        LabelTimer = New Label()
        Panel1 = New Panel()
        CType(PictureBoxResult, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonDelResult
        ' 
        ButtonDelResult.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonDelResult.Font = New Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonDelResult.Location = New Point(2046, 4)
        ButtonDelResult.Name = "ButtonDelResult"
        ButtonDelResult.Size = New Size(101, 45)
        ButtonDelResult.TabIndex = 16
        ButtonDelResult.Text = "del"
        ButtonDelResult.UseVisualStyleBackColor = True
        ' 
        ' ButtonResult
        ' 
        ButtonResult.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonResult.Font = New Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonResult.Location = New Point(1939, 4)
        ButtonResult.Name = "ButtonResult"
        ButtonResult.Size = New Size(101, 45)
        ButtonResult.TabIndex = 15
        ButtonResult.Text = "re"
        ButtonResult.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxResult
        ' 
        PictureBoxResult.BackColor = Color.Moccasin
        PictureBoxResult.Location = New Point(4, 5)
        PictureBoxResult.Margin = New Padding(4, 5, 4, 5)
        PictureBoxResult.Name = "PictureBoxResult"
        PictureBoxResult.Size = New Size(2123, 1199)
        PictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxResult.TabIndex = 14
        PictureBoxResult.TabStop = False
        PictureBoxResult.WaitOnLoad = True
        ' 
        ' TextBoxResult
        ' 
        TextBoxResult.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxResult.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxResult.Location = New Point(33, 2)
        TextBoxResult.Name = "TextBoxResult"
        TextBoxResult.ReadOnly = True
        TextBoxResult.Size = New Size(1900, 44)
        TextBoxResult.TabIndex = 13
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 750
        ' 
        ' LabelTimer
        ' 
        LabelTimer.AutoSize = True
        LabelTimer.Location = New Point(4, 9)
        LabelTimer.Name = "LabelTimer"
        LabelTimer.Size = New Size(24, 32)
        LabelTimer.TabIndex = 17
        LabelTimer.Text = "-"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.Controls.Add(PictureBoxResult)
        Panel1.Location = New Point(12, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2131, 1209)
        Panel1.TabIndex = 18
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScrollMargin = New Size(100, 100)
        ClientSize = New Size(2155, 1276)
        Controls.Add(Panel1)
        Controls.Add(LabelTimer)
        Controls.Add(ButtonDelResult)
        Controls.Add(ButtonResult)
        Controls.Add(TextBoxResult)
        Name = "Form2"
        Text = "view"
        CType(PictureBoxResult, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonDelResult As Button
    Friend WithEvents ButtonResult As Button
    Friend WithEvents PictureBoxResult As PictureBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTimer As Label
    Friend WithEvents Panel1 As Panel
End Class

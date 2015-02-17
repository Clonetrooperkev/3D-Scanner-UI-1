<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ModelName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveAs = New System.Windows.Forms.TextBox()
        Me.TakeNum = New System.Windows.Forms.TextBox()
        Me.PicOnly = New System.Windows.Forms.CheckBox()
        Me.Increment = New System.Windows.Forms.CheckBox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.SaveAsBrowseBtn = New System.Windows.Forms.Button()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusTracker = New System.Windows.Forms.Label()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.dlgLighting = New System.Windows.Forms.OpenFileDialog()
        Me.sveLighting = New System.Windows.Forms.SaveFileDialog()
        Me.dlgSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.TimerLbl = New System.Windows.Forms.Label()
        Me.TimerSecBox = New System.Windows.Forms.TextBox()
        Me.CountDownBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Camera Status"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 125)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(178, 29)
        Me.ProgressBar1.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(100, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Ready"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(48, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Status : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(110, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(110, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(58, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Offline :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(58, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Online : "
        '
        'ModelName
        '
        Me.ModelName.Location = New System.Drawing.Point(369, 41)
        Me.ModelName.Name = "ModelName"
        Me.ModelName.Size = New System.Drawing.Size(292, 20)
        Me.ModelName.TabIndex = 2
        Me.ModelName.Text = "Model Name here"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Model :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Take :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Save As :"
        '
        'SaveAs
        '
        Me.SaveAs.Location = New System.Drawing.Point(369, 120)
        Me.SaveAs.Name = "SaveAs"
        Me.SaveAs.Size = New System.Drawing.Size(216, 20)
        Me.SaveAs.TabIndex = 6
        Me.SaveAs.Text = "C://Users/X/Model_Name_here_1_[x].jpg"
        '
        'TakeNum
        '
        Me.TakeNum.Location = New System.Drawing.Point(369, 80)
        Me.TakeNum.Name = "TakeNum"
        Me.TakeNum.Size = New System.Drawing.Size(100, 20)
        Me.TakeNum.TabIndex = 7
        Me.TakeNum.Text = "1"
        '
        'PicOnly
        '
        Me.PicOnly.AutoSize = True
        Me.PicOnly.Checked = True
        Me.PicOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PicOnly.Location = New System.Drawing.Point(580, 82)
        Me.PicOnly.Name = "PicOnly"
        Me.PicOnly.Size = New System.Drawing.Size(83, 17)
        Me.PicOnly.TabIndex = 8
        Me.PicOnly.Text = "Picture Only"
        Me.PicOnly.UseVisualStyleBackColor = True
        '
        'Increment
        '
        Me.Increment.AutoSize = True
        Me.Increment.Checked = True
        Me.Increment.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Increment.Location = New System.Drawing.Point(477, 82)
        Me.Increment.Name = "Increment"
        Me.Increment.Size = New System.Drawing.Size(98, 17)
        Me.Increment.TabIndex = 9
        Me.Increment.Text = "Auto Increment"
        Me.Increment.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(434, 241)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(75, 23)
        Me.ResetBtn.TabIndex = 10
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'SaveAsBrowseBtn
        '
        Me.SaveAsBrowseBtn.Location = New System.Drawing.Point(591, 117)
        Me.SaveAsBrowseBtn.Name = "SaveAsBrowseBtn"
        Me.SaveAsBrowseBtn.Size = New System.Drawing.Size(70, 23)
        Me.SaveAsBrowseBtn.TabIndex = 11
        Me.SaveAsBrowseBtn.Text = "Browse"
        Me.SaveAsBrowseBtn.UseVisualStyleBackColor = True
        '
        'GoBtn
        '
        Me.GoBtn.BackColor = System.Drawing.Color.Red
        Me.GoBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.GoBtn.Location = New System.Drawing.Point(515, 241)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(151, 23)
        Me.GoBtn.TabIndex = 12
        Me.GoBtn.Text = "GO"
        Me.GoBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "3D Model Generating Status : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(475, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "--------------------------------------------------"
        '
        'StatusTracker
        '
        Me.StatusTracker.AutoSize = True
        Me.StatusTracker.ForeColor = System.Drawing.Color.Red
        Me.StatusTracker.Location = New System.Drawing.Point(51, 241)
        Me.StatusTracker.Name = "StatusTracker"
        Me.StatusTracker.Size = New System.Drawing.Size(237, 13)
        Me.StatusTracker.TabIndex = 18
        Me.StatusTracker.Text = "Model_Name_here_1.3D saved at C://Users/C/"
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "OpenFileDialog1"
        '
        'dlgLighting
        '
        Me.dlgLighting.FileName = "OpenFileDialog1"
        '
        'TimerLbl
        '
        Me.TimerLbl.AutoSize = True
        Me.TimerLbl.Location = New System.Drawing.Point(303, 157)
        Me.TimerLbl.Name = "TimerLbl"
        Me.TimerLbl.Size = New System.Drawing.Size(39, 13)
        Me.TimerLbl.TabIndex = 20
        Me.TimerLbl.Text = "Timer :"
        '
        'TimerSecBox
        '
        Me.TimerSecBox.Location = New System.Drawing.Point(369, 154)
        Me.TimerSecBox.Name = "TimerSecBox"
        Me.TimerSecBox.Size = New System.Drawing.Size(100, 20)
        Me.TimerSecBox.TabIndex = 19
        Me.TimerSecBox.Text = "10"
        '
        'CountDownBar
        '
        Me.CountDownBar.Location = New System.Drawing.Point(485, 154)
        Me.CountDownBar.Name = "CountDownBar"
        Me.CountDownBar.Size = New System.Drawing.Size(175, 19)
        Me.CountDownBar.TabIndex = 21
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 287)
        Me.Controls.Add(Me.CountDownBar)
        Me.Controls.Add(Me.TimerLbl)
        Me.Controls.Add(Me.TimerSecBox)
        Me.Controls.Add(Me.StatusTracker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.SaveAsBrowseBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.Increment)
        Me.Controls.Add(Me.PicOnly)
        Me.Controls.Add(Me.TakeNum)
        Me.Controls.Add(Me.SaveAs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ModelName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "3D Scanner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ModelName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SaveAs As System.Windows.Forms.TextBox
    Friend WithEvents TakeNum As System.Windows.Forms.TextBox
    Friend WithEvents PicOnly As System.Windows.Forms.CheckBox
    Friend WithEvents Increment As System.Windows.Forms.CheckBox
    Friend WithEvents ResetBtn As System.Windows.Forms.Button
    Friend WithEvents SaveAsBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents GoBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusTracker As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgLighting As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sveLighting As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TimerLbl As System.Windows.Forms.Label
    Friend WithEvents TimerSecBox As System.Windows.Forms.TextBox
    Friend WithEvents CountDownBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

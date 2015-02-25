Public Class Form1
    Dim TakeNumber As Integer

    'Note on what to do next:
    '- To approach status update on each pi, send signal to pi( similar to the pictures taking ones ) and make each pi sent a blank file with file name being
    '  its own ip, the ui will then look at each file and make changes to each check marks on the status section, after all have been read, it will delete those blank files. 
    '- Update the total pi count to 50 [DONE]
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SaveAsBrowseBtn.Click
        dlgOpenFile.InitialDirectory = "c:\"
        dlgOpenFile.ShowDialog()
        SaveAs.Text = dlgOpenFile.FileName
    End Sub
    'Reset button, does exactly what people would expect it to. 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        ModelName.Text = "Model Name"
        TakeNum.Text = "1"
        SaveAs.Text = "SaveAs.jpg"
        PicOnly.Checked = True
        Increment.Checked = True
        StatusTracker.Text = "Reset Form"
        TakeNumber = 0
        TimerSecBox.Text = "10"
        CountDownBar.Value = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        dlgSaveFile.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        dlgLighting.ShowDialog()
    End Sub
    'Execute the python script after timer second
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        Dim timer As Integer
        Timer = CInt(TimerSecBox.Text)
        Timer1.Start()
        If Increment.Checked = True Then
            TakeNumber += 1
            TakeNum.Text = TakeNumber
        End If
        StatusTracker.Text = "Model will be saved as " + SaveAs.Text

        Shell("C:\Python27\python.exe C:\Users\Punny\Desktop\Classes\Spring 2015\Csci 493\Senior Project\send_script.py " + SaveAs.Text + " " + TimerSecBox.Text)
        'Threading.Thread.Sleep(1000 * timer)

    End Sub
    'Timer tick reference for timer usage
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = (1000)
        CountDownBar.Increment(100 / CInt(TimerSecBox.Text))
        If CountDownBar.Value = 100 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class

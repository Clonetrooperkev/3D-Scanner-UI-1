Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dlgOpenFile.InitialDirectory = "c:\"
        dlgOpenFile.ShowDialog()
        SaveAs.Text = dlgOpenFile.FileName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        SaveAs.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        StatusTracker.Text = "Reset Form"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        dlgSaveFile.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dlgLighting.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StatusTracker.Text = "Model saved as" + SaveAs.Text + ".3d"
    End Sub
End Class

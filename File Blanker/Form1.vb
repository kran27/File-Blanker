Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each file As String In My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchAllSubDirectories, "*")
            IO.File.WriteAllBytes(file, My.Resources.blankfile)
        Next
        MsgBox("Done Writing!", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Process Complete")
    End Sub
End Class
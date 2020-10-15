Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dirinfo As New IO.DirectoryInfo(TextBox1.Text)
        Dim getfiles As IO.FileInfo() = dirinfo.GetFiles()
        Dim file As IO.FileInfo

        For Each file In getfiles
            IO.File.WriteAllBytes(file.FullName, My.Resources.blankfile)
        Next
        MsgBox("Done Writing!", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Process Complete")
    End Sub
End Class
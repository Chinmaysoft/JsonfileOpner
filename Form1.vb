Imports System.IO


Public Class Json_Opner

    Dim strtxt As String
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        WebBrowser1.Hide()
        OpenFileDialog1.Title = "Open Text Files"
        OpenFileDialog1.ShowDialog()
        strtxt = OpenFileDialog1.FileName
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(strtxt)
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem1.Click
        End
    End Sub

    Private Sub BrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowserToolStripMenuItem.Click
        WebBrowser1.Navigate(strtxt)
        RichTextBox1.Hide()
    End Sub
End Class
